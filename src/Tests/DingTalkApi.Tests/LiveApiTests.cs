using Microsoft.Extensions.DependencyInjection;
using Moq;
using Moq.Protected;
using System.Net;
using DingTalkApi.Apis.AudioAndVideo;
using DingTalkApi.Models.AudioAndVideo.Live;

namespace DingTalkApi.Tests;

public class LiveApiTests : TestBase
{
    private readonly ILiveApi _api;

    public LiveApiTests()
    {
        _api = Provider.GetRequiredService<ILiveApi>();
    }

    [Fact]
    public async Task CreateAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Post && req.RequestUri!.ToString().Contains("live/lives")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"result\":{\"liveId\":\"live01\",\"watchUrl\":\"https://live\"}}", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.CreateAsync(new LiveCreateRequest { UnionId = "u1", Title = "直播" }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("live01", response.Result.LiveId);
    }

    [Fact]
    public async Task GetAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Get && req.RequestUri!.ToString().Contains("live/lives")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"result\":{\"liveId\":\"live01\",\"title\":\"直播\",\"status\":\"created\"}}", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.GetAsync("live01", "u1", cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("直播", response.Result.Title);
    }

    [Fact]
    public async Task ListWatchUsersAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Get && req.RequestUri!.ToString().Contains("watchUsers")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"result\":{\"totalCount\":1,\"list\":[{\"unionId\":\"u1\",\"nick\":\"n1\",\"watchTime\":60}]}}", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.ListWatchUsersAsync("live01", "u1", cancellationToken: TestContext.Current.CancellationToken);

        Assert.Single(response.Result.List);
        Assert.Equal(60, response.Result.List[0].WatchTime);
    }
}
