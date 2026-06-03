using Moq;
using Moq.Protected;
using System.Net;
using Microsoft.Extensions.DependencyInjection;
using DingTalkApiClient.Apis.IM;
using DingTalkApiClient.Models.IM.Robot;
using DingTalkApiClient.Enums;

namespace DingTalkApiClient.Tests;

public class RobotApiTests : TestBase
{
    private readonly IRobotApi _api;

    public RobotApiTests()
    {
        _api = Provider.GetRequiredService<IRobotApi>();
    }

    [Fact]
    public async Task SendCustomRobotMessageAsyncTest()
    {
        var request = CustomRobotMessageRequest.Create(RobotMsgType.Text, new CustomRobotMessageRequest.TextObj { Content = "测试消息" });
        var response = await _api.SendCustomRobotMessageAsync("mock_access_token", request, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal(0, response.ErrCode);
    }

    [Fact]
    public async Task SendActionCardMessageAsync_Test()
    {
        var body = new CustomRobotMessageRequest.ActionCardObj
        {
            Title = "标题",
            Text = "内容",
            BtnOrientation = "1",
            Btns = [new() { Title = "按钮", ActionUrl = "http://test.com" }]
        };
        var request = CustomRobotMessageRequest.Create(RobotMsgType.ActionCard, body);
        var response = await _api.SendCustomRobotMessageAsync("mock_access_token", request, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal(0, response.ErrCode);
    }

    [Fact]
    public async Task SendFeedCardMessageAsync_Test()
    {
        var body = new CustomRobotMessageRequest.FeedCardObj
        {
            Links = [new() { Title = "标题", MessageUrl = "http://m.com", PicUrl = "http://p.com" }]
        };
        var request = CustomRobotMessageRequest.Create(RobotMsgType.FeedCard, body);
        var response = await _api.SendCustomRobotMessageAsync("mock_access_token", request, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal(0, response.ErrCode);
    }

    [Fact]
    public async Task SendDingMessageAsyncTest()
    {
        var request = new DingMessage("robotCode", DingRemindType.InternalApplication, ["userId"], "content");
        var response = await _api.SendDingMessageAsync(request, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal(0, response.ErrCode);
    }

    [Fact]
    public async Task RecallDingMessageAsyncTest()
    {
        var request = new RecallDingMessage("robotCode", "openDingId");
        var response = await _api.RecallDingMessageAsync(request, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal(0, response.ErrCode);
    }

    [Fact]
    public async Task SendOToMessageBatchAsyncTest()
    {
        var request = new SendOToMessageBatchRequest("robotCode", ["userId"], "msgKey", "msgParam");
        var response = await _api.SendOToMessageBatchAsync(request, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
    }

    [Fact]
    public async Task SendOToMessageAsyncTest()
    {
        var request = new SendOToMessageRequest("robotCode", "userId", "msgKey", "msgParam");
        var response = await _api.SendOToMessageAsync(request, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal(0, response.ErrCode);
    }

    [Fact]
    public async Task SendGroupMessageAsyncTest()
    {
        var request = new SendGroupMessageRequest("robotCode", "openConversationId", "msgKey", "msgParam");
        var response = await _api.SendGroupMessageAsync(request, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal(0, response.ErrCode);
    }

    [Fact]
    public async Task QueryPrivateChatMessagesAsyncTest()
    {
        var request = new QueryPrivateChatMessagesRequest("robotCode", "processQueryKey");
        var response = await _api.QueryPrivateChatMessagesAsync(request, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal(0, response.ErrCode);
    }

    [Fact]
    public async Task QueryOtoMessageReadStatusAsyncTest()
    {
        HttpRequestMessage? capturedRequest = null;
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req =>
                    req.Method == HttpMethod.Get &&
                    req.RequestUri != null &&
                    req.RequestUri.AbsolutePath == "/v1.0/robot/oToMessages/readStatus"),
                ItExpr.IsAny<CancellationToken>())
            .Callback((HttpRequestMessage req, CancellationToken _) => capturedRequest = req)
            .Returns(() => Task.FromResult(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("""
                {
                  "errcode":0,
                  "errmsg":"ok",
                  "sendStatus":"SUCCESS",
                  "messageReadInfoList":[{"name":"曲大岳","userId":"201382020","readStatus":"READ"}]
                }
                """, System.Text.Encoding.UTF8, "application/json")
            }));

        var request = new QueryOtoMessageReadStatusRequest("dingzxcifuvdfbvegdf", "xxxxxxxxxxxxx");
        var response = await _api.QueryOtoMessageReadStatusAsync(request, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.True(response.IsSuccess);
        Assert.Equal("SUCCESS", response.SendStatus);

        var messageReadInfo = Assert.Single(response.MessageReadInfoList!);
        Assert.Equal("曲大岳", messageReadInfo.Name);
        Assert.Equal("201382020", messageReadInfo.UserId);
        Assert.Equal("READ", messageReadInfo.ReadStatus);

        Assert.NotNull(capturedRequest);
        Assert.Equal(HttpMethod.Get, capturedRequest!.Method);
        Assert.Equal("/v1.0/robot/oToMessages/readStatus", capturedRequest.RequestUri!.AbsolutePath);
        Assert.Contains("robotCode=dingzxcifuvdfbvegdf", capturedRequest.RequestUri.Query, StringComparison.Ordinal);
        Assert.Contains("processQueryKey=xxxxxxxxxxxxx", capturedRequest.RequestUri.Query, StringComparison.Ordinal);
    }

    [Fact]
    public async Task QueryGroupMessagesAsyncTest()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedRequestBody = null;
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req =>
                    req.Method == HttpMethod.Post &&
                    req.RequestUri != null &&
                    req.RequestUri.AbsolutePath == "/v1.0/robot/groupMessages/query"),
                ItExpr.IsAny<CancellationToken>())
            .Callback((HttpRequestMessage req, CancellationToken _) =>
            {
                capturedRequest = req;
                capturedRequestBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            })
            .Returns(() => Task.FromResult(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("""
                {
                  "errcode":0,
                  "errmsg":"ok",
                  "sendStatus":"SUCCESS",
                  "readUserIds":["manager1234"],
                  "nextToken":"Kna29Ra5pdJ****mkQKwDzgfxZLapw55G7x0Q=",
                  "hasMore":true
                }
                """, System.Text.Encoding.UTF8, "application/json")
            }));

        var request = new QueryGroupMessagesRequest(
            robotCode: "dingzxcifuvdfbvegdf",
            processQueryKey: "xxxxxxxxxxxxx",
            openConversationId: "cid123",
            maxResults: 200,
            nextToken: "token1");

        var response = await _api.QueryGroupMessagesAsync(request, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal(0, response.ErrCode);
        Assert.Equal("SUCCESS", response.SendStatus);
        Assert.Equal("Kna29Ra5pdJ****mkQKwDzgfxZLapw55G7x0Q=", response.NextToken);
        Assert.True(response.HasMore);
        Assert.Equal("manager1234", Assert.Single(response.ReadUserIds!));

        Assert.NotNull(capturedRequest);
        Assert.Equal(HttpMethod.Post, capturedRequest!.Method);
        Assert.Equal("/v1.0/robot/groupMessages/query", capturedRequest.RequestUri!.AbsolutePath);

        Assert.NotNull(capturedRequestBody);
        Assert.Contains("\"openConversationId\":\"cid123\"", capturedRequestBody, StringComparison.Ordinal);
        Assert.Contains("\"robotCode\":\"dingzxcifuvdfbvegdf\"", capturedRequestBody, StringComparison.Ordinal);
        Assert.Contains("\"processQueryKey\":\"xxxxxxxxxxxxx\"", capturedRequestBody, StringComparison.Ordinal);
        Assert.Contains("\"maxResults\":200", capturedRequestBody, StringComparison.Ordinal);
        Assert.Contains("\"nextToken\":\"token1\"", capturedRequestBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task DownloadRobotMessageFileAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req =>
                    req.Method == HttpMethod.Post &&
                    req.RequestUri != null &&
                    req.RequestUri.AbsolutePath == "/v1.0/robot/messageFiles/download"),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("""{"errcode":0,"errmsg":"ok","downloadUrl":"https://example.com/file"}""", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.DownloadRobotMessageFileAsync(new DownloadRobotMessageFileRequest("code01", "robot01"), cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal("https://example.com/file", response.DownloadUrl);
    }

    [Fact]
    public async Task BatchRecallOtoMessagesAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req =>
                    req.Method == HttpMethod.Post &&
                    req.RequestUri != null &&
                    req.RequestUri.AbsolutePath == "/v1.0/robot/otoMessages/batchRecall"),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("""{"errcode":0,"errmsg":"ok","successResult":["pqk01"],"failedResult":[{"processQueryKey":"pqk02","errorCode":"400","errorMessage":"bad"}]}""", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.BatchRecallOtoMessagesAsync(new BatchRecallOtoMessagesRequest("robot01", ["pqk01"]), cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal("pqk01", Assert.Single(response.SuccessResult));
        Assert.Equal("pqk02", Assert.Single(response.FailedResult).ProcessQueryKey);
    }

    [Fact]
    public async Task QueryRobotPluginsAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req =>
                    req.Method == HttpMethod.Post &&
                    req.RequestUri != null &&
                    req.RequestUri.AbsolutePath == "/v1.0/robot/plugins/query"),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("""{"errcode":0,"errmsg":"ok","pluginInfoList":[{"pluginId":"p01","name":"入口"}]}""", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.QueryRobotPluginsAsync(new QueryRobotPluginsRequest("robot01"), cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal("p01", Assert.Single(response.PluginInfoList).PluginId);
    }
}
