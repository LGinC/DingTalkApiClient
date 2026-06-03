using Microsoft.Extensions.DependencyInjection;
using Moq;
using Moq.Protected;
using System.Net;
using DingTalkApi.Apis.IM;
using DingTalkApi.Models.IM.Chat;

namespace DingTalkApi.Tests;

public class SceneGroupApiTests : TestBase
{
    private readonly ISceneGroupApi _api;

    public SceneGroupApiTests()
    {
        _api = Provider.GetRequiredService<ISceneGroupApi>();
    }

    [Fact]
    public async Task ConvertToOpenConversationIdAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req =>
                    req.Method == HttpMethod.Post &&
                    req.RequestUri != null &&
                    req.RequestUri.AbsolutePath == "/v1.0/im/chat/chat01/convertToOpenConversationId"),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("""{"openConversationId":"cid01"}""", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.ConvertToOpenConversationIdAsync("chat01", cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal("cid01", response.OpenConversationId);
    }

    [Fact]
    public async Task QuerySceneGroupAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req =>
                    req.Method == HttpMethod.Post &&
                    req.RequestUri != null &&
                    req.RequestUri.AbsolutePath == "/v1.0/im/sceneGroups/query"),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("""{"success":true,"openConversationId":"cid01","templateId":"tpl01","title":"项目群","ownerUserId":"manager01","icon":"icon","groupUrl":"https://example.com","status":1}""", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.QuerySceneGroupAsync(new QuerySceneGroupRequest
        {
            OpenConversationId = "cid01",
            CoolAppCode = "cool01"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.True(response.Success);
        Assert.Equal("项目群", response.Title);
    }
}
