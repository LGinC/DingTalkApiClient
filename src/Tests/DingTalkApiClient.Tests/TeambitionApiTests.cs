using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Moq.Protected;
using DingTalkApiClient.Apis.Teambition;
using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.Teambition;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Tests;

public class TeambitionApiTests : TestBase
{
    private static readonly Type[] TeambitionApiTypes =
    [
        typeof(ITeambitionProjectApi),
        typeof(ITeambitionWorkspaceTopApi),
    ];

    private readonly ITeambitionProjectApi _api;
    private readonly ITeambitionWorkspaceTopApi _topApi;

    public TeambitionApiTests()
    {
        _api = Provider.GetRequiredService<ITeambitionProjectApi>();
        _topApi = Provider.GetRequiredService<ITeambitionWorkspaceTopApi>();
    }

    [Theory]
    [MemberData(nameof(TeambitionApiTypeData))]
    public void TeambitionApis_ShouldBeRegisteredAndUseExpectedOptions(Type apiType)
    {
        Assert.NotNull(Provider.GetService(apiType));

        var options = Provider.GetRequiredService<IOptionsMonitor<HttpApiOptions>>().Get(apiType.FullName);
        var expectedPolicy = apiType == typeof(ITeambitionWorkspaceTopApi) ? JsonNamingPolicy.SnakeCaseLower : JsonNamingPolicy.CamelCase;
        Assert.Equal(expectedPolicy, options.JsonSerializeOptions.PropertyNamingPolicy);
        Assert.Equal(expectedPolicy, options.JsonDeserializeOptions.PropertyNamingPolicy);
        Assert.Equal(expectedPolicy, options.KeyValueSerializeOptions.PropertyNamingPolicy);
    }

    [Theory]
    [MemberData(nameof(TeambitionApiMethodData))]
    public void TeambitionApiMethods_ShouldHaveHttpAttributeAndTokenProvider(Type apiType, MethodInfo method)
    {
        Assert.Contains(method, apiType.GetMethods());
        Assert.NotNull(GetHttpMethodAttribute(method));

        var parameters = method.GetParameters();
        var tokenParameter = parameters.SingleOrDefault(parameter =>
            parameter.GetCustomAttribute<DingTalkTokenProviderAttribute>() is not null);
        Assert.NotNull(tokenParameter);
        Assert.Equal(ProviderNames.Internal, tokenParameter!.DefaultValue);
        Assert.Equal(typeof(CancellationToken), parameters.Last().ParameterType);
        Assert.True(method.ReturnType.IsGenericType);
        Assert.Equal(typeof(ITask<>), method.ReturnType.GetGenericTypeDefinition());
    }

    [Theory]
    [MemberData(nameof(TeambitionModelTypeData))]
    public void TeambitionModels_ShouldBeRegisteredInJsonSerializerContext(Type modelType)
    {
        Assert.NotNull(DingTalkJsonSerializerContext.Default.GetTypeInfo(modelType));
    }

    [Fact]
    public async Task CreateProjectAsync_ShouldPostV1WithHeaderTokenAndCamelCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/project/users/user-01/projects",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"result":{"projectId":"proj-01","name":"测试项目","creatorId":"user-01","customFields":[{"customFieldId":"cf-01","type":"select","value":[{"customFieldValueId":"v-01","title":"高","metaString":"{}"}]}]}}""");

        var response = await _api.CreateProjectAsync("user-01", new TeambitionCreateProjectRequest("测试项目"), cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("proj-01", response.Result!.ProjectId);
        Assert.Equal("高", Assert.Single(Assert.Single(response.Result.CustomFields).Value).Title);
        Assert.NotNull(capturedRequest);
        Assert.True(capturedRequest!.Headers.Contains("x-acs-dingtalk-access-token"));
        Assert.DoesNotContain("access_token", capturedRequest.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"name\":\"测试项目\"", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task SearchUserTasksAsync_ShouldDeserializePagedTaskDetails()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/project/users/user-01/tasks/search",
            _ => { },
            """{"result":[{"taskId":"task-01","content":"任务","projectId":"proj-01","ancestorIds":["root"],"customFields":[{"customFieldId":"cf-01","type":"text","value":[{"title":"值"}]}]}],"requestId":"req-01","nextToken":"next"}""");

        var response = await _api.SearchUserTasksAsync("user-01", roleTypes: "executor", maxResults: "20", cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("req-01", response.RequestId);
        Assert.Equal("next", response.NextToken);
        var task = Assert.Single(response.Result!);
        Assert.Equal("task-01", task.TaskId);
        Assert.Equal("root", Assert.Single(task.AncestorIds));
        Assert.Equal("值", Assert.Single(Assert.Single(task.CustomFields).Value).Title);
    }

    [Fact]
    public async Task UpdateOrganizationTaskPriorityAsync_ShouldPutCamelCaseBody()
    {
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Put && req.RequestUri!.AbsolutePath == "/v1.0/project/organizations/users/user-01/tasks/task-01/priorities",
            req => capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult(),
            """{"result":{"priority":2,"updated":"2022-06-20T00:00:00Z"}}""");

        var response = await _api.UpdateOrganizationTaskPriorityAsync("user-01", "task-01", new TeambitionUpdateOrganizationTaskPriorityRequest
        {
            Priority = 2,
            DisableNotification = true
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal(2, response.Result!.Priority);
        Assert.Equal("2022-06-20T00:00:00Z", response.Result.Updated);
        Assert.Contains("\"priority\":2", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"disableNotification\":true", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task ListWorkspaceAuditLogsAsync_ShouldPostTopApiWithQueryTokenAndSnakeCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/workspace/auditlog/list",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"errcode":0,"errmsg":"ok","result":{"log_list":[{"action":"download","bizId":1001,"dingTalkId":2002,"empId":"emp-01","operatorName":"张三","projectName":"项目","resource":"设计稿"}]}}""");

        var response = await _topApi.ListWorkspaceAuditLogsAsync(new TeambitionWorkspaceAuditLogListRequest
        {
            StartDate = 1,
            EndDate = 2,
            PageSize = 20,
            LoadMoreBizId = 1001
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal(0, response.ErrCode);
        Assert.NotNull(capturedRequest);
        Assert.Contains("access_token=mock_token", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"start_date\":1", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"load_more_biz_id\":1001", capturedBody, StringComparison.Ordinal);
        var log = Assert.Single(response.Result!.LogList);
        Assert.Equal("download", log.Action);
        Assert.Equal("张三", log.OperatorName);
    }

    public static IEnumerable<object[]> TeambitionApiTypeData() => TeambitionApiTypes.Select(type => new object[] { type });

    public static IEnumerable<object[]> TeambitionApiMethodData() =>
        TeambitionApiTypes.SelectMany(apiType => apiType.GetMethods().Select(method => new object[] { apiType, method }));

    public static IEnumerable<object[]> TeambitionModelTypeData() =>
        typeof(TeambitionProject).Assembly
            .GetTypes()
            .Where(type => type.IsPublic && type.Namespace == "DingTalkApiClient.Models.Teambition" && !type.IsGenericType)
            .Select(type => new object[] { type });

    private void SetupResponse(Expression<Func<HttpRequestMessage, bool>> requestMatcher, Action<HttpRequestMessage> capture, string json)
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is(requestMatcher),
                ItExpr.IsAny<CancellationToken>())
            .Callback((HttpRequestMessage req, CancellationToken _) => capture(req))
            .Returns(() => Task.FromResult(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json")
            }));
    }

    private static Attribute? GetHttpMethodAttribute(MethodInfo method) =>
        method.GetCustomAttributes()
            .FirstOrDefault(attribute => attribute.GetType().Namespace == typeof(HttpGetAttribute).Namespace &&
                                         attribute.GetType().Name.StartsWith("Http", StringComparison.Ordinal));
}
