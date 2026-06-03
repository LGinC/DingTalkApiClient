using Microsoft.Extensions.DependencyInjection;
using Moq;
using Moq.Protected;
using System.Net;
using DingTalkApi.Apis.IM;
using DingTalkApi.Models.IM.InteractiveCards;

namespace DingTalkApi.Tests;

public class InteractiveCardApiTests : TestBase
{
    private readonly IInteractiveCardApi _api;

    public InteractiveCardApiTests()
    {
        _api = Provider.GetRequiredService<IInteractiveCardApi>();
    }

    [Fact]
    public async Task SendInteractiveCardAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req =>
                    req.Method == HttpMethod.Post &&
                    req.RequestUri != null &&
                    req.RequestUri.AbsolutePath == "/v1.0/im/interactiveCards/send"),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("""{"success":true,"result":{"processQueryKey":"pqk01","openDynamicCardInstanceId":"card01"}}""", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.SendInteractiveCardAsync(new SendInteractiveCardRequest
        {
            CardTemplateId = "tpl01",
            OutTrackId = "track01",
            ConversationType = 1,
            CardData = new Dictionary<string, object?> { ["title"] = "hello" }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.True(response.Success);
        Assert.Equal("pqk01", response.Result!.ProcessQueryKey);
    }
}
