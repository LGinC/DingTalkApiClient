using Moq.Protected;
using Moq;
using System.Net;
using DingTalkApi.Apis.AudioAndVideo;
using DingTalkApi.Models.AudioAndVideo.VideoConferences;
using Microsoft.Extensions.DependencyInjection;

namespace DingTalkApi.Tests;

public class VideoConferencesApiTests : TestBase
{
    private readonly IVideoConferencesApi _api;

    public VideoConferencesApiTests()
    {
        _api = Provider.GetRequiredService<IVideoConferencesApi>();
    }

    [Fact]
    public async Task CreateAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.RequestUri!.ToString().Contains("conference/videoConferences") && req.Method == HttpMethod.Post),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"conferenceId\":\"conf01\",\"roomCode\":\"room01\"}", System.Text.Encoding.UTF8, "application/json")
            });

        var request = new CreateVideoConferencesRequest("user01", "测试会议");
        var response = await _api.CreateAsync(request, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal("conf01", response.ConferenceId);
        Assert.Equal("room01", response.RoomCode);
    }

    [Fact]
    public async Task CloudRecordsAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.RequestUri!.ToString().Contains("cloudRecords/start")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"errcode\":0,\"errmsg\":\"ok\"}", System.Text.Encoding.UTF8, "application/json")
            });

        var request = new CloudRecordRequest("union01", Mode: "all");
        var response = await _api.CloudRecordsAsync("conf01", request, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal(0, response.ErrCode);
    }

    [Fact]
    public async Task QueryAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.RequestUri!.ToString().Contains("videoConferences/query")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                // JSON uses "infos" as property name mapped to "Conferences"
                Content = new StringContent("{\"infos\":[{\"conferenceId\":\"conf01\",\"title\":\"测试\"}]}", System.Text.Encoding.UTF8, "application/json")
            });

        var request = new GetVideoConferencesRequest(["conf01"]);
        var response = await _api.QueryAsync(request, token: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Single(response.Conferences);
        Assert.Equal("conf01", response.Conferences[0].ConferenceId);
    }

    [Fact]
    public async Task GetAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Post && req.RequestUri!.ToString().Contains("videoConferences/conf01")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"confInfo\":{\"conferenceId\":\"conf01\",\"title\":\"测试\",\"creatorId\":\"u1\",\"creatorNick\":\"n1\",\"externalLinkUrl\":\"https://dingtalk.com\",\"roomCode\":\"1001\"}}", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.GetAsync("conf01", cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal("conf01", response.ConfInfo.ConferenceId);
        Assert.Equal("1001", response.ConfInfo.RoomCode);
    }

    [Fact]
    public async Task ListMembersAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Get && req.RequestUri!.ToString().Contains("members")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"memberModels\":[{\"unionId\":\"u1\",\"conferenceId\":\"conf01\",\"userNick\":\"n1\"}],\"nextToken\":\"n\",\"totalCount\":1}", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.ListMembersAsync("conf01", maxResults: 10, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Single(response.MemberModels);
        Assert.Equal("u1", response.MemberModels[0].UnionId);
    }

    [Fact]
    public async Task InviteUsersAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Post && req.RequestUri!.ToString().Contains("users/invite")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"success\":true}", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.InviteUsersAsync("conf01", new InviteConferenceUsersRequest("u1", [new ConferenceInvitee { UnionId = "u2", Nick = "n2" }]), cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
    }

    [Fact]
    public async Task CreateScheduleConferenceAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Post && req.RequestUri!.ToString().Contains("scheduleConferences")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"requestId\":\"req01\",\"scheduleConferenceId\":\"sc01\",\"roomCode\":\"1001\",\"url\":\"https://dingtalk.com\",\"phones\":[\"0571\"]}", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.CreateScheduleConferenceAsync(new CreateScheduleConferenceRequest("u1", "预约", "1000", "2000"), cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("sc01", response.ScheduleConferenceId);
        Assert.Single(response.Phones);
    }

    [Fact]
    public async Task StartStreamOutAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Post && req.RequestUri!.ToString().Contains("streamOuts/start")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"successStreamMap\":{\"rtmp://demo\":\"live01\"},\"failStreamMap\":{}}", System.Text.Encoding.UTF8, "application/json")
            });

        var request = new StartConferenceStreamOutRequest
        {
            UnionId = "u1",
            StreamUrlList = ["rtmp://demo"],
            StreamName = "直播",
            Mode = "grid",
            SmallWindowPosition = "float_right",
            NeedHostJoin = true
        };
        var response = await _api.StartStreamOutAsync("conf01", request, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("live01", response.SuccessStreamMap["rtmp://demo"]);
    }

    [Fact]
    public async Task StopAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Delete && req.RequestUri!.ToString().Contains("videoConferences/conf01")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"cause\":\"closed\"}", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.StopAsync("conf01", "union01", cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal("closed", response.Cause);
    }

    [Fact]
    public async Task GetVideosTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Get && req.RequestUri!.ToString().Contains("cloudRecords/getVideos")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"videoList\":[{\"recordId\":\"r1\",\"unionId\":\"u1\",\"regionId\":\"reg1\",\"mediaId\":\"m01\",\"title\":\"v1\"}]}", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.GetVideos("conf01", "union01", cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Single(response.VideoList);
        Assert.Equal("m01", response.VideoList[0].MediaId);
    }

    [Fact]
    public async Task GetPlayInfoAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Get && req.RequestUri!.ToString().Contains("cloudRecords/videos/getPlayInfos")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"playUrl\":\"http://v.com/1\",\"mp4FileUrl\":\"http://v.com/1.mp4\"}", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.GetPlayInfoAsync("conf01", "union01", "m01", "r01", cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal("http://v.com/1", response.PlayUrl);
    }

    [Fact]
    public async Task GetTextsAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Get && req.RequestUri!.ToString().Contains("cloudRecords/getTexts")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"paragraphList\":[{\"unionId\":\"u1\",\"nickName\":\"n1\",\"paragraph\":\"hello\"}],\"hasMore\":false}", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.GetTextsAsync("conf01", "union01", cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Single(response.ParagraphList);
        Assert.Equal("hello", response.ParagraphList[0].ParagraphText);
    }
}
