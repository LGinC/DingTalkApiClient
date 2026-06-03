using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Moq.Protected;
using DingTalkApi.Apis.Blackboard;
using DingTalkApi.Attributes;
using DingTalkApi.Models.Blackboard;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Tests;

public class BlackboardApiTests : TestBase
{
    private static readonly Type[] BlackboardApiTypes =
    [
        typeof(IBlackboardApi),
        typeof(IBlackboardV1Api),
    ];

    private readonly IBlackboardApi _api;
    private readonly IBlackboardV1Api _v1Api;

    public BlackboardApiTests()
    {
        _api = Provider.GetRequiredService<IBlackboardApi>();
        _v1Api = Provider.GetRequiredService<IBlackboardV1Api>();
    }

    [Theory]
    [MemberData(nameof(BlackboardApiTypeData))]
    public void BlackboardApis_ShouldBeRegisteredAndUseExpectedOptions(Type apiType)
    {
        var api = Provider.GetService(apiType);
        Assert.NotNull(api);

        var options = Provider.GetRequiredService<IOptionsMonitor<HttpApiOptions>>().Get(apiType.FullName);
        var expectedNamingPolicy = typeof(IBlackboardApi).IsAssignableFrom(apiType)
            ? JsonNamingPolicy.SnakeCaseLower
            : JsonNamingPolicy.CamelCase;
        Assert.Equal(expectedNamingPolicy, options.JsonSerializeOptions.PropertyNamingPolicy);
        Assert.Equal(expectedNamingPolicy, options.JsonDeserializeOptions.PropertyNamingPolicy);
        Assert.Equal(expectedNamingPolicy, options.KeyValueSerializeOptions.PropertyNamingPolicy);
    }

    [Theory]
    [MemberData(nameof(BlackboardApiMethodData))]
    public void BlackboardApiMethods_ShouldHaveHttpAttributeAndTokenProvider(Type apiType, MethodInfo method)
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
    [MemberData(nameof(BlackboardModelTypeData))]
    public void BlackboardModels_ShouldBeRegisteredInJsonSerializerContext(Type modelType)
    {
        Assert.NotNull(DingTalkJsonSerializerContext.Default.GetTypeInfo(modelType));
    }

    [Fact]
    public async Task CreateBlackboardAsync_ShouldPostTopApiWithQueryTokenAndSnakeCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/blackboard/create",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"errcode":0,"result":true,"success":true,"request_id":"req01"}""");

        var response = await _api.CreateBlackboardAsync(new CreateBlackboardRequest
        {
            CreateRequest = new CreateBlackboardRequestBody
            {
                OperationUserid = "manager01",
                Author = "作者",
                PrivateLevel = 0,
                Ding = false,
                BlackboardReceiver = new BlackboardReceiver { DeptidList = [1], UseridList = ["u1"] },
                Title = "入职须知",
                PushTop = true,
                Content = "欢迎加入",
                CategoryId = "cat01",
                CoverpicMediaid = "@media"
            }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Result);
        Assert.Equal("req01", response.RequestId);
        Assert.NotNull(capturedRequest);
        Assert.Contains("access_token=mock_token", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"create_request\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"operation_userid\":\"manager01\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"deptid_list\"", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task GetBlackboardAsync_ShouldDeserializeDetail()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/blackboard/get",
            _ => { },
            """{"errcode":0,"success":true,"request_id":"req01","result":{"id":"bb01","author":"张三","title":"入职须知","content":"欢迎加入","category_id":"cat01","private_level":0,"depname_list":["人事部"],"username_list":["李四"],"gmt_create":"2019-10-22 14:43:07","gmt_modified":"2019-11-22 10:43:07","read_count":10,"unread_count":1,"coverpic_url":"https://example.com/pic.png"}}""");

        var response = await _api.GetBlackboardAsync(new GetBlackboardRequest
        {
            OperationUserid = "manager01",
            BlackboardId = "bb01"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
        Assert.Equal("bb01", response.Result!.Id);
        Assert.Equal("人事部", Assert.Single(response.Result.DepnameList));
        Assert.Equal(10, response.Result.ReadCount);
    }

    [Fact]
    public async Task ListBlackboardIdsAsync_ShouldDeserializeIds()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/blackboard/listids",
            _ => { },
            """{"errcode":0,"success":true,"request_id":"req01","result":["bb01","bb02"]}""");

        var response = await _api.ListBlackboardIdsAsync(new ListBlackboardIdsRequest
        {
            QueryRequest = new ListBlackboardIdsRequestBody
            {
                OperationUserid = "manager01",
                Page = 1,
                PageSize = 10,
                StartTime = "2019-10-07 10:10:10",
                EndTime = "2019-11-07 10:10:10",
                CategoryId = "cat01"
            }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal(["bb01", "bb02"], response.Result);
    }

    [Fact]
    public async Task ListBlackboardCategoriesAsync_ShouldDeserializeCategories()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/blackboard/category/list",
            _ => { },
            """{"errcode":0,"success":true,"request_id":"req01","result":[{"name":"正式公告","id":"cat01"}]}""");

        var response = await _api.ListBlackboardCategoriesAsync(new ListBlackboardCategoriesRequest
        {
            OperationUserid = "manager01"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
        Assert.Equal("正式公告", Assert.Single(response.Result).Name);
    }

    [Fact]
    public async Task ListTopTenBlackboardsAsync_ShouldDeserializeBlackboardList()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/blackboard/listtopten",
            _ => { },
            """{"errcode":0,"request_id":"req01","blackboard_list":[{"gmt_create":"2020-09-08 14:42:12","title":"国庆节值班表","url":"https://example.com","categoryId":"cat01","id":"bb01"}]}""");

        var response = await _api.ListTopTenBlackboardsAsync(new ListTopTenBlackboardsRequest
        {
            Userid = "u1"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("req01", response.RequestId);
        Assert.Equal("国庆节值班表", Assert.Single(response.BlackboardList).Title);
        Assert.Equal("cat01", response.BlackboardList[0].CategoryId);
    }

    [Fact]
    public async Task DeleteAndUpdateBlackboardAsync_ShouldDeserializeBooleanResults()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/blackboard/delete",
            _ => { },
            """{"errcode":0,"errmsg":"ok","result":true,"success":true,"request_id":"delete01"}""");

        var deleteResponse = await _api.DeleteBlackboardAsync(new DeleteBlackboardRequest
        {
            BlackboardId = "bb01",
            OperationUserid = "manager01"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(deleteResponse.Result);
        Assert.Equal("ok", deleteResponse.Errmsg);

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/blackboard/update",
            _ => { },
            """{"errcode":0,"result":true,"success":true,"request_id":"update01"}""");

        var updateResponse = await _api.UpdateBlackboardAsync(new UpdateBlackboardRequest
        {
            UpdateRequest = new UpdateBlackboardRequestBody
            {
                BlackboardId = "bb01",
                Title = "标题",
                Content = "内容",
                OperationUserid = "manager01"
            }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(updateResponse.Success);
        Assert.Equal("update01", updateResponse.RequestId);
    }

    [Fact]
    public async Task QueryBlackboardSpaceAsync_ShouldGetV1WithHeaderTokenAndCamelCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Get && req.RequestUri!.AbsolutePath == "/v1.0/blackboard/spaces",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            "{}");

        var response = await _v1Api.QueryBlackboardSpaceAsync("manager01", new BlackboardSpaceRequest { SpaceId = "100" }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.NotNull(capturedRequest);
        Assert.True(capturedRequest!.Headers.Contains("x-acs-dingtalk-access-token"));
        Assert.Contains("operationUserId=manager01", capturedRequest.RequestUri!.Query, StringComparison.Ordinal);
        Assert.DoesNotContain("access_token", capturedRequest.RequestUri.Query, StringComparison.Ordinal);
        Assert.Contains("\"spaceId\":\"100\"", capturedBody, StringComparison.Ordinal);
    }

    public static IEnumerable<object[]> BlackboardApiTypeData() => BlackboardApiTypes.Select(type => new object[] { type });

    public static IEnumerable<object[]> BlackboardApiMethodData() =>
        BlackboardApiTypes.SelectMany(apiType => apiType.GetMethods().Select(method => new object[] { apiType, method }));

    public static IEnumerable<object[]> BlackboardModelTypeData() =>
        typeof(CreateBlackboardRequest).Assembly
            .GetTypes()
            .Where(type => type.IsClass && type.IsPublic && type.Namespace == "DingTalkApi.Models.Blackboard")
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
