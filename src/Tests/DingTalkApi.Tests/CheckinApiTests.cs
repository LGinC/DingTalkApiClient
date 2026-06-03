using System.Linq.Expressions;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Moq.Protected;
using DingTalkApi.Apis.Checkin;
using DingTalkApi.Models.Checkin;

namespace DingTalkApi.Tests;

public class CheckinApiTests : TestBase
{
    private readonly ICheckinApi _api;

    public CheckinApiTests()
    {
        _api = Provider.GetRequiredService<ICheckinApi>();
    }

    [Fact]
    public async Task GetUserCheckinRecordsAsync_ShouldPostTopApiWithQueryTokenAndSnakeCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/checkin/record/get",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """
            {"errcode":0,"result":{"next_cursor":20,"page_list":[{"checkin_time":1599544940000,"detail_place":"浙江省杭州市余杭区五常街道","image_list":["https://static.dingtalk.com/media/xxxx"],"place":"绿城未来park","remark":"客户拜访","userid":"manager4220","visit_user":"客户A"}]},"request_id":"pod643x3uywf"}
            """);

        var response = await _api.GetUserCheckinRecordsAsync(new GetUserCheckinRecordsRequest
        {
            UseridList = "manager4220",
            StartTime = 1605437194000,
            EndTime = 1605786394000,
            Cursor = 0,
            Size = 100
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal(0, response.ErrCode);
        Assert.Equal("pod643x3uywf", response.RequestId);
        Assert.Equal(20, response.Result!.NextCursor);
        Assert.Equal("manager4220", response.Result.PageList[0].Userid);
        Assert.Equal("客户A", response.Result.PageList[0].VisitUser);
        Assert.NotNull(capturedRequest);
        Assert.Contains("access_token=mock_token", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"userid_list\":\"manager4220\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"start_time\":1605437194000", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task GetDepartmentCheckinRecordsAsync_ShouldGetRecordsWithSnakeCaseQuery()
    {
        HttpRequestMessage? capturedRequest = null;

        SetupResponse(
            req => req.Method == HttpMethod.Get && req.RequestUri!.AbsolutePath == "/checkin/record",
            req => capturedRequest = req,
            """
            {"errcode":0,"errmsg":"ok","data":[{"detailPlace":"浙江省杭州市余杭区五常街道","latitude":"30.286053","name":"杨xx","remark":"客户拜访","place":"绿城未来park","userId":"manager4220","imageList":["https://static.dingtalk.com/media/xxxx"],"timestamp":1599544940000,"longitude":"120.017394"}]}
            """);

        var response = await _api.GetDepartmentCheckinRecordsAsync(
            department_id: "1",
            end_time: "1520956800000",
            start_time: "1520870400000",
            offset: "0",
            size: "100",
            order: "asc", cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal(0, response.ErrCode);
        Assert.Equal("ok", response.ErrMsg);
        Assert.Equal("manager4220", response.Data[0].UserId);
        Assert.Equal("浙江省杭州市余杭区五常街道", response.Data[0].DetailPlace);
        Assert.NotNull(capturedRequest);
        var query = capturedRequest!.RequestUri!.Query;
        Assert.Contains("access_token=mock_token", query, StringComparison.Ordinal);
        Assert.Contains("department_id=1", query, StringComparison.Ordinal);
        Assert.Contains("start_time=1520870400000", query, StringComparison.Ordinal);
        Assert.Contains("end_time=1520956800000", query, StringComparison.Ordinal);
    }

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
}
