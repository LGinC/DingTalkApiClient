using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Moq.Protected;
using DingTalkApi.Apis;
using DingTalkApi.Apis.HRM;
using DingTalkApi.Attributes;
using DingTalkApi.Models.HRM;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Tests;

public class HumanResourcesApiTests : TestBase
{
    private static readonly Type[] HrmApiTypes =
    [
        typeof(IHumanResourcesApi),
        typeof(IHumanResourcesTopApi),
    ];

    private readonly IHumanResourcesApi _api;
    private readonly IHumanResourcesTopApi _topApi;

    public HumanResourcesApiTests()
    {
        _api = Provider.GetRequiredService<IHumanResourcesApi>();
        _topApi = Provider.GetRequiredService<IHumanResourcesTopApi>();
    }

    [Theory]
    [MemberData(nameof(HrmApiTypeData))]
    public void HumanResourcesApis_ShouldBeRegisteredAndUseExpectedOptions(Type apiType)
    {
        Assert.NotNull(Provider.GetService(apiType));

        var options = Provider.GetRequiredService<IOptionsMonitor<HttpApiOptions>>().Get(apiType.FullName);
        var expectedNamingPolicy = typeof(IDingTalkQueryTokenApi).IsAssignableFrom(apiType)
            ? JsonNamingPolicy.SnakeCaseLower
            : JsonNamingPolicy.CamelCase;

        Assert.Equal(expectedNamingPolicy, options.JsonSerializeOptions.PropertyNamingPolicy);
        Assert.Equal(expectedNamingPolicy, options.JsonDeserializeOptions.PropertyNamingPolicy);
        Assert.Equal(expectedNamingPolicy, options.KeyValueSerializeOptions.PropertyNamingPolicy);
    }

    [Theory]
    [MemberData(nameof(HrmApiMethodData))]
    public void HumanResourcesApiMethods_ShouldHaveHttpAttributeAndTokenProvider(Type apiType, MethodInfo method)
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
    [MemberData(nameof(HrmModelTypeData))]
    public void HumanResourcesModels_ShouldBeRegisteredInJsonSerializerContext(Type modelType)
    {
        Assert.NotNull(DingTalkJsonSerializerContext.Default.GetTypeInfo(modelType));
    }

    [Fact]
    public async Task QueryPositionsAsync_ShouldPostV1WithHeaderTokenAndCamelCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/hrm/positions/query",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"nextToken":20,"hasMore":true,"list":[{"positionId":"pos01","positionName":"工程师","rankIdList":["rank01"],"status":0}]}""");

        var response = await _api.QueryPositionsAsync(
            new HrmPositionQueryRequest
            {
                PositionName = "工程师",
                InCategoryIds = ["cat01"],
                InPositionIds = ["pos01"],
                DeptId = 1
            },
            "0",
            "20", cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.HasMore);
        Assert.Equal("工程师", Assert.Single(response.List).PositionName);
        Assert.NotNull(capturedRequest);
        Assert.True(capturedRequest!.Headers.Contains("x-acs-dingtalk-access-token"));
        Assert.DoesNotContain("access_token", capturedRequest.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("nextToken=0", capturedRequest.RequestUri.Query, StringComparison.Ordinal);
        Assert.Contains("\"positionName\":\"工程师\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"inCategoryIds\"", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task GetDimissionInfosAsync_ShouldDeserializeSnakeCaseNestedDepartment()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Get && req.RequestUri!.AbsolutePath == "/v1.0/hrm/employees/dimissionInfos",
            _ => { },
            """{"result":[{"userId":"u1","lastWorkDay":1700000000000,"deptList":[{"dept_path":"总部/研发","dept_id":1}],"preStatus":3,"status":2,"voluntaryReason":["个人原因"],"passiveReason":[]}]}""");

        var response = await _api.GetDimissionInfosAsync("u1", cancellationToken: TestContext.Current.CancellationToken);

        var info = Assert.Single(response.Result);
        Assert.Equal("u1", info.UserId);
        Assert.Equal("总部/研发", Assert.Single(info.DeptList).DeptPath);
    }

    [Fact]
    public async Task GetRosterMetaAsync_ShouldPostTopApiWithQueryTokenAndSnakeCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/smartwork/hrm/roster/meta/get",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"errcode":0,"errmsg":"ok","success":true,"request_id":"req01","result":[{"group_name":"个人信息","group_id":"sys00","field_meta_info_list":[{"field_name":"姓名","field_code":"sys00-name","derived":false}],"detail":false}]}""");

        var response = await _topApi.GetRosterMetaAsync(new HrmAgentRequest { Agentid = 123 }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
        Assert.Equal("个人信息", Assert.Single(response.Result).GroupName);
        Assert.Equal("sys00-name", Assert.Single(response.Result[0].FieldMetaInfoList).FieldCode);
        Assert.NotNull(capturedRequest);
        Assert.Contains("access_token=mock_token", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.False(capturedRequest.Headers.Contains("x-acs-dingtalk-access-token"));
        Assert.Contains("\"agentid\":123", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task UpdateEmployeeRosterAsync_ShouldSerializeNestedSnakeCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/smartwork/hrm/employee/v2/update",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"result":true,"errcode":0,"success":true,"errmsg":"ok","request_id":"req02"}""");

        var response = await _topApi.UpdateEmployeeRosterAsync(new HrmEmployeeRosterUpdateRequest
        {
            Agentid = 123,
            Param = new HrmEmployeeRosterUpdateParam
            {
                Userid = "u1",
                Groups =
                [
                    new()
                    {
                        GroupId = "sys03",
                        Sections =
                        [
                            new()
                            {
                                OldIndex = 0,
                                Section = [new HrmEmployeeRosterUpdateField { FieldCode = "sys03-school", Value = "测试大学" }]
                            }
                        ]
                    }
                ]
            }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Result);
        Assert.NotNull(capturedRequest);
        Assert.Contains("access_token=mock_token", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"group_id\":\"sys03\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"old_index\":0", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"field_code\":\"sys03-school\"", capturedBody, StringComparison.Ordinal);
    }

    public static IEnumerable<object[]> HrmApiTypeData() => HrmApiTypes.Select(type => new object[] { type });

    public static IEnumerable<object[]> HrmApiMethodData() =>
        HrmApiTypes.SelectMany(apiType => apiType.GetMethods().Select(method => new object[] { apiType, method }));

    public static IEnumerable<object[]> HrmModelTypeData() =>
        typeof(HrmPositionQueryRequest).Assembly
            .GetTypes()
            .Where(type => type.IsClass && type.IsPublic && type.Namespace == "DingTalkApi.Models.HRM")
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
                StatusCode = System.Net.HttpStatusCode.OK,
                Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json")
            }));
    }

    private static Attribute? GetHttpMethodAttribute(MethodInfo method) =>
        method.GetCustomAttributes()
            .FirstOrDefault(attribute => attribute.GetType().Namespace == typeof(HttpGetAttribute).Namespace &&
                                         attribute.GetType().Name.StartsWith("Http", StringComparison.Ordinal));
}
