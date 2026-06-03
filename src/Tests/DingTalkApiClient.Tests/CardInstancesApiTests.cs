using Microsoft.Extensions.DependencyInjection;
using Moq;
using Moq.Protected;
using System.Net;
using DingTalkApiClient.Apis.Card;
using DingTalkApiClient.Models.Card.CardInstances;

namespace DingTalkApiClient.Tests;

public class CardInstancesApiTests : TestBase
{
    private readonly ICardInstancesApi _api;

    public CardInstancesApiTests()
    {
        _api = Provider.GetRequiredService<ICardInstancesApi>();
    }

    [Fact]
    public async Task CreateCardAsyncTest()
    {
        SetupResponse(HttpMethod.Post, "/v1.0/card/instances", """{"success":true,"result":"track01"}""");

        var response = await _api.CreateCardAsync(new CreateCardInstanceRequest
        {
            CardTemplateId = "tpl01",
            OutTrackId = "track01",
            CardData = new CardData { CardParamMap = new Dictionary<string, string> { ["title"] = "hello" } }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
        Assert.Equal("track01", response.Result);
    }

    [Fact]
    public async Task UpdateCardAsyncTest()
    {
        SetupResponse(HttpMethod.Put, "/v1.0/card/instances", """{"success":true,"result":true}""");

        var response = await _api.UpdateCardAsync(new UpdateCardInstanceRequest
        {
            OutTrackId = "track01",
            CardData = new CardData { CardParamMap = new Dictionary<string, string> { ["title"] = "updated" } },
            CardUpdateOptions = new CardUpdateOptions { UpdateCardDataByKey = true }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
        Assert.True(response.Result);
    }

    [Fact]
    public async Task DeliverCardAsyncTest()
    {
        SetupResponse(HttpMethod.Post, "/v1.0/card/instances/deliver", """{"success":true,"result":[{"spaceType":"IM_GROUP","spaceId":"space01","success":true,"carrierId":"pqk01"}]}""");

        var response = await _api.DeliverCardAsync(new DeliverCardRequest
        {
            OutTrackId = "track01",
            OpenSpaceId = "dtv1.card//IM_GROUP.space01",
            ImGroupOpenDeliverModel = new ImGroupOpenDeliverModel
            {
                RobotCode = "robot01",
                AtUserIds = new Dictionary<string, string> { ["u1"] = "User One" },
                Recipients = ["u1"]
            }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
        var result = Assert.Single(response.Result);
        Assert.Equal("IM_GROUP", result.SpaceType);
        Assert.Equal("pqk01", result.CarrierId);
    }

    [Fact]
    public async Task CreateAndDeliverCardAsyncTest()
    {
        SetupResponse(HttpMethod.Post, "/v1.0/card/instances/createAndDeliver", """{"success":true,"result":{"outTrackId":"track01","deliverResults":[{"spaceType":"IM_GROUP","spaceId":"space01","success":true}]}}""");

        var response = await _api.CreateAndDeliverCardAsync(new CreateAndDeliverCardRequest
        {
            CardTemplateId = "tpl01",
            OutTrackId = "track01",
            OpenSpaceId = "dtv1.card//IM_GROUP.space01",
            CardData = new CardData { CardParamMap = new Dictionary<string, string> { ["title"] = "hello" } },
            ImGroupOpenDeliverModel = new ImGroupOpenDeliverModel
            {
                RobotCode = "robot01",
                AtUserIds = new Dictionary<string, string> { ["u1"] = "User One" },
                Recipients = ["u1"]
            }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
        Assert.Equal("track01", response.Result.OutTrackId);
        Assert.True(Assert.Single(response.Result.DeliverResults).Success);
    }

    [Fact]
    public async Task RegisterCardCallbackAsyncTest()
    {
        SetupResponse(HttpMethod.Post, "/v1.0/card/callbacks/register", """{"success":true,"result":{"callbackUrl":"https://example.com/callback","apiSecret":"secret01"}}""");

        var response = await _api.RegisterCardCallbackAsync(new RegisterCardCallbackRequest
        {
            CallbackRouteKey = "route01",
            CallbackUrl = "https://example.com/callback",
            ApiSecret = "secret01"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
        Assert.Equal("https://example.com/callback", response.Result.CallbackUrl);
        Assert.Equal("secret01", response.Result.ApiSecret);
    }

    [Fact]
    public async Task UpsertCardSpaceAsyncTest()
    {
        SetupResponse(HttpMethod.Put, "/v1.0/card/instances/spaces", """{"success":true,"result":true}""");

        var response = await _api.UpsertCardSpaceAsync(new UpsertCardSpaceRequest
        {
            OutTrackId = "track01",
            ImGroupOpenSpaceModel = new ImOpenSpaceModel
            {
                LastMessageI18n = new Dictionary<string, string> { ["ZH_CN"] = "卡片" },
                SearchSupport = new SearchSupport { SearchIcon = "icon", SearchTypeName = "card", SearchDesc = "desc" },
                Notification = new Notification { AlertContent = "new card" }
            }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
        Assert.True(response.Result);
    }

    private void SetupResponse(HttpMethod method, string path, string json)
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req =>
                    req.Method == method &&
                    req.RequestUri != null &&
                    req.RequestUri.AbsolutePath == path),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json")
            });
    }
}
