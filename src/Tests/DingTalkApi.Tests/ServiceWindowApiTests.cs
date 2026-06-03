using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Moq.Protected;
using DingTalkApi.Apis.ServiceWindow;
using DingTalkApi.Attributes;
using DingTalkApi.Models.ServiceWindow;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Tests;

public class ServiceWindowApiTests : TestBase
{
    private readonly IServiceWindowApi _api;

    public ServiceWindowApiTests()
    {
        _api = Provider.GetRequiredService<IServiceWindowApi>();
    }

    [Fact]
    public void ServiceWindowApi_ShouldBeRegisteredAndUseCamelCase()
    {
        Assert.NotNull(Provider.GetService<IServiceWindowApi>());

        var options = Provider.GetRequiredService<IOptionsMonitor<HttpApiOptions>>().Get(typeof(IServiceWindowApi).FullName);
        Assert.Equal(JsonNamingPolicy.CamelCase, options.JsonSerializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.CamelCase, options.JsonDeserializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.CamelCase, options.KeyValueSerializeOptions.PropertyNamingPolicy);
    }

    [Theory]
    [MemberData(nameof(ServiceWindowApiMethodData))]
    public void ServiceWindowApiMethods_ShouldHaveHttpAttributeAndTokenProvider(MethodInfo method)
    {
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
    [MemberData(nameof(ServiceWindowModelTypeData))]
    public void ServiceWindowModels_ShouldBeRegisteredInJsonSerializerContext(Type modelType)
    {
        Assert.NotNull(DingTalkJsonSerializerContext.Default.GetTypeInfo(modelType));
    }

    [Fact]
    public async Task BatchSendMessageAsync_ShouldPostHeaderTokenAndCamelCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/crm/officialAccounts/oToMessages/batchSend",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"requestId":"req01","result":{"openPushId":"push01"}}""");

        var response = await _api.BatchSendMessageAsync(new ServiceWindowBatchSendMessageRequest
        {
            BizId = "biz01",
            AccountId = "account01",
            Detail = new ServiceWindowBatchMessageDetail
            {
                MsgType = "text",
                Uuid = "uuid01",
                BizRequestId = "biz-request-01",
                UserIdList = ["user01", "user02"],
                SendToAll = false,
                MessageBody = new ServiceWindowMessageBody
                {
                    Text = new ServiceWindowTextMessage { Content = "hello" }
                }
            }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("push01", response.Result!.OpenPushId);
        Assert.Equal("req01", response.RequestId);
        Assert.NotNull(capturedRequest);
        Assert.Equal("mock_token", capturedRequest!.Headers.GetValues("x-acs-dingtalk-access-token").Single());
        Assert.DoesNotContain("access_token", capturedRequest.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"bizRequestId\":\"biz-request-01\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"userIdList\":[\"user01\",\"user02\"]", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task SendMessageAsync_ShouldSerializeActionCardAndDeserializePushId()
    {
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/crm/officialAccounts/oToMessages/send",
            req => capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult(),
            """{"requestId":"req02","result":{"openPushId":"push02"}}""");

        var response = await _api.SendMessageAsync(new ServiceWindowSendMessageRequest
        {
            AccountId = "account01",
            Detail = new ServiceWindowMessageDetail
            {
                MsgType = "action_card",
                Uuid = "uuid02",
                UserId = "user01",
                MessageBody = new ServiceWindowMessageBody
                {
                    ActionCard = new ServiceWindowActionCardMessage
                    {
                        Title = "通知",
                        Markdown = "### 通知",
                        ButtonOrientation = "0",
                        ButtonList = [new ServiceWindowActionCardButton { Title = "查看", ActionUrl = "https://example.com" }]
                    }
                }
            }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("push02", response.Result!.OpenPushId);
        Assert.Contains("\"actionCard\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"buttonOrientation\":\"0\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"actionUrl\":\"https://example.com\"", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task ListAccountsAsync_ShouldDeserializeAccounts()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Get && req.RequestUri!.AbsolutePath == "/v1.0/link/accounts",
            _ => { },
            """{"result":[{"accountId":"account01","accountName":"服务窗"}]}""");

        var response = await _api.ListAccountsAsync(cancellationToken: TestContext.Current.CancellationToken);

        var account = Assert.Single(response.Result);
        Assert.Equal("account01", account.AccountId);
        Assert.Equal("服务窗", account.AccountName);
    }

    [Fact]
    public async Task ListFollowersAsync_ShouldSendQueryAndDeserializePage()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Get &&
                   req.RequestUri!.AbsolutePath == "/v1.0/link/followers" &&
                   req.RequestUri.Query.Contains("nextToken=next01", StringComparison.Ordinal) &&
                   req.RequestUri.Query.Contains("maxResults=20", StringComparison.Ordinal) &&
                   req.RequestUri.Query.Contains("accountId=account01", StringComparison.Ordinal),
            _ => { },
            """{"requestId":"req03","result":{"nextToken":"next02","userList":[{"userId":"user01","name":"张三","timestamp":1710000000000}]}}""");

        var response = await _api.ListFollowersAsync("next01", "20", "account01", cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("req03", response.RequestId);
        Assert.Equal("next02", response.Result.NextToken);
        var follower = Assert.Single(response.Result.UserList);
        Assert.Equal("user01", follower.UserId);
        Assert.Equal(1710000000000, follower.Timestamp);
    }

    [Fact]
    public async Task GetFollowerInfoAsync_ShouldSendQueryAndDeserializeUser()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Get &&
                   req.RequestUri!.AbsolutePath == "/v1.0/link/followers/infos" &&
                   req.RequestUri.Query.Contains("userId=user01", StringComparison.Ordinal) &&
                   req.RequestUri.Query.Contains("accountId=account01", StringComparison.Ordinal),
            _ => { },
            """{"requestId":"req04","result":{"user":{"userId":"user01","name":"张三","timestamp":"1710000000000"}}}""");

        var response = await _api.GetFollowerInfoAsync(userId: "user01", accountId: "account01", cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("req04", response.RequestId);
        Assert.Equal("张三", response.Result.User.Name);
        Assert.Equal(1710000000000, response.Result.User.Timestamp);
    }

    public static IEnumerable<object[]> ServiceWindowApiMethodData() =>
        typeof(IServiceWindowApi).GetMethods().Select(method => new object[] { method });

    public static IEnumerable<object[]> ServiceWindowModelTypeData() =>
        typeof(ServiceWindowBatchSendMessageRequest).Assembly
            .GetTypes()
            .Where(type => type.IsPublic && type.Namespace == "DingTalkApi.Models.ServiceWindow" && !type.IsGenericType)
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
