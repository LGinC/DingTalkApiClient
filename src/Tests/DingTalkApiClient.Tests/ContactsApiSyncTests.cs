using System.Reflection;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Moq.Protected;
using DingTalkApiClient.Apis;
using DingTalkApiClient.Apis.Contacts;
using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.Contacts.CooperateCorps;
using DingTalkApiClient.Models.Contacts.ContactUsers;
using DingTalkApiClient.Models.Contacts.DepartmentManage;
using DingTalkApiClient.Models.Contacts.RoleManage;
using DingTalkApiClient.Models.Contacts.StaffAttributes;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Tests;

public class ContactsApiSyncTests : TestBase
{
    private static readonly Type[] ContactsApiTypes =
    [
        typeof(IUserManageApi),
        typeof(IDepartmentManageApi),
        typeof(IRoleManageApi),
        typeof(IExternalContactsApi),
        typeof(IIndustryContactsApi),
        typeof(IAuthScopesApi),
        typeof(IEmployeeRecordsApi),
        typeof(ISeniorSettingsApi),
        typeof(IStaffAttributesApi),
        typeof(IOrgAccountsApi),
        typeof(IContactSettingsApi),
        typeof(IContactUsersApi),
        typeof(ICooperateCorpsApi),
        typeof(IUnionCooperateApi)
    ];

    [Theory]
    [MemberData(nameof(ContactsApiTypeData))]
    public void ContactsApis_ShouldBeRegisteredAndUseExpectedTokenTransport(Type apiType)
    {
        var api = Provider.GetService(apiType);
        Assert.NotNull(api);

        if (typeof(IDingTalkQueryTokenApi).IsAssignableFrom(apiType))
        {
            Assert.True(apiType.GetInterfaces().Contains(typeof(IDingTalkQueryTokenApi)));
        }
        else
        {
            Assert.True(apiType.GetInterfaces().Contains(typeof(IDingTalkHeaderTokenApi)));
        }

        var options = Provider.GetRequiredService<IOptionsMonitor<HttpApiOptions>>().Get(apiType.FullName);
        var expectedNamingPolicy = apiType == typeof(ICooperateCorpsApi)
            ? JsonNamingPolicy.CamelCase
            : JsonNamingPolicy.SnakeCaseLower;
        Assert.Equal(expectedNamingPolicy, options.JsonSerializeOptions.PropertyNamingPolicy);
        Assert.Equal(expectedNamingPolicy, options.JsonDeserializeOptions.PropertyNamingPolicy);
        Assert.Equal(expectedNamingPolicy, options.KeyValueSerializeOptions.PropertyNamingPolicy);
    }

    [Theory]
    [MemberData(nameof(ContactsApiMethodData))]
    public void ContactsApiMethods_ShouldHaveHttpAttributeAndTokenProvider(Type apiType, MethodInfo method)
    {
        Assert.Contains(method, apiType.GetMethods());
        Assert.NotNull(GetHttpMethodAttribute(method));

        var parameters = method.GetParameters();
        var tokenParameter = parameters.SingleOrDefault(parameter =>
            parameter.GetCustomAttribute<DingTalkTokenProviderAttribute>() is not null);

        Assert.NotNull(tokenParameter);
        Assert.Equal(typeof(string), tokenParameter!.ParameterType);
        Assert.Equal(ProviderNames.Internal, tokenParameter.DefaultValue);
        Assert.Equal(typeof(CancellationToken), parameters.Last().ParameterType);
        Assert.True(method.ReturnType.IsGenericType);
        Assert.Equal(typeof(ITask<>), method.ReturnType.GetGenericTypeDefinition());
    }

    [Theory]
    [MemberData(nameof(ContactsModelTypeData))]
    public void ContactsModels_ShouldBeRegisteredInJsonSerializerContext(Type modelType)
    {
        Assert.NotNull(DingTalkJsonSerializerContext.Default.GetTypeInfo(modelType));
    }

    [Fact]
    public void ContactsModelProperties_ShouldHaveXmlSummaryComments()
    {
        var contactsModelRoot = FindRepositoryRoot()
            .GetDirectories("DingTalkApiClient", SearchOption.TopDirectoryOnly)
            .Single()
            .GetDirectories("Models", SearchOption.TopDirectoryOnly)
            .Single()
            .GetDirectories("Contacts", SearchOption.TopDirectoryOnly)
            .Single();

        var propertyPattern = new Regex(
            @"^\s+public\s+(?:required\s+)?[\w<>,.?\[\]]+\s+\w+\s*\{\s*get;\s*set;\s*\}",
            RegexOptions.Compiled);

        var missingComments = new List<string>();
        foreach (var file in contactsModelRoot.GetFiles("*.cs", SearchOption.AllDirectories))
        {
            var lines = File.ReadAllLines(file.FullName);
            for (var index = 0; index < lines.Length; index++)
            {
                if (!propertyPattern.IsMatch(lines[index]))
                {
                    continue;
                }

                var cursor = index - 1;
                while (cursor >= 0 &&
                       (string.IsNullOrWhiteSpace(lines[cursor]) ||
                        lines[cursor].TrimStart().StartsWith("[JsonPropertyName", StringComparison.Ordinal)))
                {
                    cursor--;
                }

                if (cursor < 0 || lines[cursor].Trim() != "/// </summary>")
                {
                    missingComments.Add($"{Path.GetRelativePath(FindRepositoryRoot().FullName, file.FullName)}:{index + 1}");
                }
            }
        }

        Assert.Empty(missingComments);
    }

    [Fact]
    public async Task DepartmentCreateAsync_ShouldPostTopApiWithQueryToken()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/v2/department/create",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"errcode":0,"errmsg":"ok","result":{"dept_id":123}}""");

        var api = Provider.GetRequiredService<IDepartmentManageApi>();
        var response = await api.DepartmentCreateAsync(new DepartmentCreateRequest
        {
            Name = "研发部",
            ParentId = 1
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal(0, response.ErrCode);
        Assert.Equal(123, response.Result!.DeptId);
        Assert.NotNull(capturedRequest);
        Assert.Contains("access_token=mock_token", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"name\":\"研发部\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"parent_id\":1", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task ContactUsersGetAsync_ShouldUsePathParameterAndHeaderToken()
    {
        HttpRequestMessage? capturedRequest = null;

        SetupResponse(
            req => req.Method == HttpMethod.Get && req.RequestUri!.AbsolutePath == "/v1.0/contact/users/union01",
            req => capturedRequest = req,
            """{"nick":"张三","unionId":"union01","openId":"open01"}""");

        var api = Provider.GetRequiredService<IContactUsersApi>();
        var response = await api.GetContactUsersUnionIdAsync("union01", new ContactUsersUnionIdGetRequest(), cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("张三", response.Nick);
        Assert.Equal("union01", response.UnionId);
        Assert.NotNull(capturedRequest);
        Assert.True(capturedRequest!.Headers.Contains("x-acs-dingtalk-access-token"));
    }

    [Fact]
    public async Task StaffAttributesDeleteAsync_ShouldUseDeleteAndPathParameter()
    {
        HttpRequestMessage? capturedRequest = null;

        SetupResponse(
            req => req.Method == HttpMethod.Delete &&
                   req.RequestUri!.AbsolutePath == "/v1.0/contact/staffAttributes/visibilitySettings/42",
            req => capturedRequest = req,
            """{"result":true}""");

        var api = Provider.GetRequiredService<IStaffAttributesApi>();
        var response = await api.DeleteContactStaffAttributesVisibilitySettingsSettingIdAsync(
            "42",
            new ContactStaffAttributesVisibilitySettingsSettingIdDeleteRequest(), cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Result);
        Assert.NotNull(capturedRequest);
        Assert.Equal(HttpMethod.Delete, capturedRequest!.Method);
    }

    [Fact]
    public async Task RoleAddRoleAsync_ShouldDeserializeNonWrappedOapiResponse()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/role/add_role",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"errcode":0,"errmsg":"ok","roleId":88}""");

        var api = Provider.GetRequiredService<IRoleManageApi>();
        var response = await api.RoleAddRoleAsync(new RoleAddRoleRequest
        {
            RoleName = "审批员",
            GroupId = 1
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal(0, response.Errcode);
        Assert.Equal(88, response.RoleId);
        Assert.NotNull(capturedRequest);
        Assert.Contains("access_token=mock_token", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"roleName\":\"审批员\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"groupId\":1", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task CooperateCorpCreateAsync_ShouldPostV1WithHeaderToken()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/contact/cooperateCorps",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"cooperateCorpId":"corp01"}""");

        var api = Provider.GetRequiredService<ICooperateCorpsApi>();
        var response = await api.CreateCooperateCorpAsync(new CooperateCorpCreateRequest
        {
            OrgName = "测试联盟",
            LogoMediaId = "media01",
            IndustryCode = 123456
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("corp01", response.CooperateCorpId);
        Assert.NotNull(capturedRequest);
        Assert.True(capturedRequest!.Headers.Contains("x-acs-dingtalk-access-token"));
        Assert.DoesNotContain("access_token", capturedRequest.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"orgName\":\"测试联盟\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"logoMediaId\":\"media01\"", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task UnionCooperateJoinedListAsync_ShouldPostTopApiWithQueryTokenAndSnakeCase()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/union/cooperate/joined/list",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"errcode":0,"errmsg":"ok","success":"true","result":{"belong_corp_id":"corp-parent","belong_org_name":"总公司","org_name":"测试联盟","corp_id":"corp01"}}""");

        var api = Provider.GetRequiredService<IUnionCooperateApi>();
        var response = await api.GetJoinedCooperatesAsync(new UnionCooperateJoinedListRequest
        {
            Status = "1"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal(0, response.ErrCode);
        Assert.Equal("corp-parent", response.Result!.BelongCorpId);
        Assert.NotNull(capturedRequest);
        Assert.Contains("access_token=mock_token", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"status\":\"1\"", capturedBody, StringComparison.Ordinal);
    }

    public static IEnumerable<object[]> ContactsApiTypeData()
    {
        return ContactsApiTypes.Select(type => new object[] { type });
    }

    public static IEnumerable<object[]> ContactsApiMethodData()
    {
        return ContactsApiTypes
            .SelectMany(apiType => apiType.GetMethods().Select(method => new object[] { apiType, method }));
    }

    public static IEnumerable<object[]> ContactsModelTypeData()
    {
        return typeof(ContactUsersUnionIdGetRequest).Assembly
            .GetTypes()
            .Where(type => type.IsClass &&
                           type.IsPublic &&
                           type.Namespace is not null &&
                           type.Namespace.StartsWith("DingTalkApiClient.Models.Contacts.", StringComparison.Ordinal))
            .Select(type => new object[] { type });
    }

    private void SetupResponse(
        Expression<Func<HttpRequestMessage, bool>> requestMatcher,
        Action<HttpRequestMessage> capture,
        string json)
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is(requestMatcher),
                ItExpr.IsAny<CancellationToken>())
            .Callback((HttpRequestMessage req, CancellationToken _) => capture(req))
            .Returns(() => Task.FromResult(new HttpResponseMessage
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json")
            }));
    }

    private static Attribute? GetHttpMethodAttribute(MethodInfo method)
    {
        return method.GetCustomAttributes()
            .FirstOrDefault(attribute => attribute.GetType().Namespace == typeof(HttpGetAttribute).Namespace &&
                                         attribute.GetType().Name.StartsWith("Http", StringComparison.Ordinal));
    }

    private static DirectoryInfo FindRepositoryRoot()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null && directory.GetFiles("DingTalkApiClient.slnx").Length == 0)
        {
            directory = directory.Parent;
        }

        return directory ?? throw new DirectoryNotFoundException("Unable to locate repository root.");
    }
}
