using Microsoft.Extensions.DependencyInjection;
using Moq;
using Moq.Protected;
using System.Net;
using DingTalkApiClient.Apis.AudioAndVideo;
using DingTalkApiClient.Models.AudioAndVideo.MeetingRooms;

namespace DingTalkApiClient.Tests;

public class MeetingRoomsApiTests : TestBase
{
    private readonly IMeetingRoomsApi _api;

    public MeetingRoomsApiTests()
    {
        _api = Provider.GetRequiredService<IMeetingRoomsApi>();
    }

    [Fact]
    public async Task CreateAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Post && req.RequestUri!.ToString().Contains("rooms/meetingrooms")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"result\":\"room01\"}", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.CreateAsync(new MeetingRoomRequest { UnionId = "u1", RoomName = "会议室" }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("room01", response.Result);
    }

    [Fact]
    public async Task GetAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Get && req.RequestUri!.ToString().Contains("meetingRooms/room01")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"result\":{\"roomId\":\"room01\",\"roomName\":\"会议室\",\"roomLocation\":{\"title\":\"杭州\",\"desc\":\"西溪\"}}}", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.GetAsync("room01", "u1", cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("会议室", response.Result.RoomName);
        Assert.Equal("杭州", response.Result.RoomLocation!.Title);
    }

    [Fact]
    public async Task QueryDevicePropertiesAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Post && req.RequestUri!.ToString().Contains("devices/properties/query")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"result\":[{\"propertyName\":\"dev_code\",\"propertyValue\":\"123456\"}]}", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.QueryDevicePropertiesAsync("u1", new MeetingRoomDevicePropertiesRequest(["dev_code"]), cancellationToken: TestContext.Current.CancellationToken);

        Assert.Single(response.Result);
        Assert.Equal("123456", response.Result[0].PropertyValue);
    }

    [Fact]
    public async Task CreateScreenTemplateAsyncTest()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Post && req.RequestUri!.ToString().Contains("devices/screens/templates")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"templateId\":1001}", System.Text.Encoding.UTF8, "application/json")
            });

        var response = await _api.CreateScreenTemplateAsync(new ScreenTemplateRequest
        {
            TemplateName = "模板",
            OrgName = "组织",
            CustomDoc = "欢迎",
            BgUrl = "https://bg",
            BgImgList = ["media01"],
            DeviceUnionIds = ["du01"],
            GroupIds = ["1"],
            RoomIds = ["room01"]
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal(1001, response.TemplateId);
    }
}
