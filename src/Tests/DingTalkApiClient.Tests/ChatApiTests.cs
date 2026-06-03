using Microsoft.Extensions.DependencyInjection;
using Moq;
using Moq.Protected;
using System.Net;
using DingTalkApiClient.Apis.IM;
using DingTalkApiClient.Models.IM.Chat;

namespace DingTalkApiClient.Tests;

public class ChatApiTests : TestBase
{
    private readonly IChatApi _api;

    public ChatApiTests()
    {
        _api = Provider.GetRequiredService<IChatApi>();
    }

    [Fact]
    public async Task CreateChatAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req =>
                    req.Method == HttpMethod.Post &&
                    req.RequestUri != null &&
                    req.RequestUri.AbsolutePath == "/chat/create"),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("""{"errcode":0,"errmsg":"ok","chatid":"chat01","openConversationId":"cid01","conversationTag":2}""", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.CreateChatAsync(new CreateChatRequest
        {
            Name = "全员群",
            Owner = "manager01",
            Useridlist = ["user01"]
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal("chat01", response.ChatId);
        Assert.Equal("cid01", response.OpenConversationId);
    }

    [Fact]
    public async Task CreateSceneGroupAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req =>
                    req.Method == HttpMethod.Post &&
                    req.RequestUri != null &&
                    req.RequestUri.AbsolutePath == "/topapi/im/chat/scenegroup/create"),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("""{"errcode":0,"errmsg":"ok","success":true,"result":"cid01","request_id":"req01"}""", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.CreateSceneGroupAsync(new CreateSceneGroupRequest
        {
            Title = "项目群",
            TemplateId = "tpl01",
            OwnerUserId = "manager01"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.True(response.Success);
        Assert.Equal("cid01", response.Result);
    }

    [Fact]
    public async Task SendSceneGroupMessageAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req =>
                    req.Method == HttpMethod.Post &&
                    req.RequestUri != null &&
                    req.RequestUri.AbsolutePath == "/topapi/im/chat/scencegroup/message/send_v2"),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("""{"errcode":0,"errmsg":"ok","success":true,"open_msg_id":"msg01","request_id":"req01"}""", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.SendSceneGroupMessageAsync(new SendSceneGroupMessageRequest
        {
            RobotCode = "robot01",
            TargetOpenConversationId = "cid01",
            MessageTemplateId = "tpl01"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal("msg01", response.OpenMessageId);
    }
}
