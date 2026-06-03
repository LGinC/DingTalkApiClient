using Microsoft.Extensions.DependencyInjection;
using Moq;
using Moq.Protected;
using System.Net;
using DingTalkApi.Apis.Badge;
using DingTalkApi.Models.Badge;

namespace DingTalkApi.Tests;

public class BadgeApiTests : TestBase
{
    private readonly IBadgeApi _api;

    public BadgeApiTests()
    {
        _api = Provider.GetRequiredService<IBadgeApi>();
    }

    [Fact]
    public async Task CreateBadgeCodeUserInstanceAsync_ShouldPostWithHeaderToken()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            HttpMethod.Post,
            "/v1.0/badge/codes/userInstances",
            """{"codeId":"code01","codeDetailUrl":"https://example.com/code01"}""",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            });

        var response = await _api.CreateBadgeCodeUserInstanceAsync(new CreateBadgeCodeUserInstanceRequest
        {
            RequestId = "request01",
            CodeIdentity = "DT_VISITOR",
            CodeValue = "value01",
            Status = "OPEN",
            CorpId = "dingcorp",
            UserCorpRelationType = "INTERNAL_STAFF",
            UserIdentity = "user01",
            GmtExpired = "2026-06-10 18:00:00",
            AvailableTimes = [new BadgeAvailableTime { GmtStart = "2026-06-03 09:00:00", GmtEnd = "2026-06-03 18:00:00" }],
            ExtInfo = new Dictionary<string, object?> { ["scene"] = "visitor" },
            CodeValueType = "DING_STATIC"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("code01", response.CodeId);
        Assert.Equal("https://example.com/code01", response.CodeDetailUrl);
        Assert.NotNull(capturedRequest);
        Assert.True(capturedRequest!.Headers.Contains("x-acs-dingtalk-access-token"));
        Assert.DoesNotContain("access_token", capturedRequest.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"requestId\":\"request01\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"availableTimes\"", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task UpdateBadgeCodeUserInstanceAsync_ShouldPutUserInstance()
    {
        SetupResponse(HttpMethod.Put, "/v1.0/badge/codes/userInstances", """{"codeId":"code01"}""");

        var response = await _api.UpdateBadgeCodeUserInstanceAsync(new UpdateBadgeCodeUserInstanceRequest
        {
            CodeId = "code01",
            CodeIdentity = "DT_VISITOR",
            CodeValue = "value02",
            Status = "OPEN",
            CorpId = "dingcorp",
            UserCorpRelationType = "INTERNAL_STAFF",
            UserIdentity = "user01",
            GmtExpired = "2026-06-10 18:00:00",
            AvailableTimes = [new BadgeAvailableTime { GmtStart = "2026-06-03 09:00:00", GmtEnd = "2026-06-03 18:00:00" }],
            ExtInfo = []
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("code01", response.CodeId);
    }

    [Fact]
    public async Task SaveBadgeCodeCorpInstanceAsync_ShouldPostCorpInstance()
    {
        SetupResponse(HttpMethod.Post, "/v1.0/badge/codes/corpInstances", """{"codeIdentity":"DT_IDENTITY","corpId":"dingcorp","status":"OPEN","extInfo":{"key":"value"}}""");

        var response = await _api.SaveBadgeCodeCorpInstanceAsync(new SaveBadgeCodeCorpInstanceRequest
        {
            CodeIdentity = "DT_IDENTITY",
            CorpId = "dingcorp",
            Status = "OPEN"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("DT_IDENTITY", response.CodeIdentity);
        Assert.Equal("dingcorp", response.CorpId);
        Assert.Equal("value", response.ExtInfo["key"]?.ToString());
    }

    [Fact]
    public async Task DecodeBadgeCodeAsync_ShouldPostDecode()
    {
        SetupResponse(HttpMethod.Post, "/v1.0/badge/codes/decode", """{"corpId":"dingcorp","userId":"user01","codeType":"PURE_IDENTIFY_CODE","alipayCode":"2512345678","userCorpRelationType":"INTERNAL_STAFF","codeIdentity":"DT_VISITOR","codeId":"code01","outBizId":"request01","extInfo":"{\"authRules\":{}}"}""");

        var response = await _api.DecodeBadgeCodeAsync(new DecodeBadgeCodeRequest
        {
            PayCode = "pay01",
            RequestId = "request01"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("dingcorp", response.CorpId);
        Assert.Equal("user01", response.UserId);
        Assert.Equal("code01", response.CodeId);
    }

    [Fact]
    public async Task NotifyBadgeCodePayResultAsync_ShouldPostPaymentDetails()
    {
        string? capturedBody = null;
        SetupResponse(
            HttpMethod.Post,
            "/v1.0/badge/codes/payResults",
            """{"result":"SUCCESS"}""",
            req => capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult());

        var response = await _api.NotifyBadgeCodePayResultAsync(new NotifyBadgeCodePayResultRequest
        {
            PayCode = "pay01",
            CorpId = "dingcorp",
            UserId = "user01",
            GmtTradeCreate = "2026-06-03 09:00:00",
            GmtTradeFinish = "2026-06-03 09:01:00",
            TradeNo = "trade01",
            TradeStatus = "SUCCESS",
            Title = "午餐",
            Remark = "食堂消费",
            Amount = "10.00",
            PromotionAmount = "1.00",
            ChargeAmount = "9.00",
            PayChannelDetailList = [CreatePayChannelDetail()],
            TradeErrorCode = "",
            TradeErrorMsg = "",
            ExtInfo = "{}",
            MerchantName = "食堂"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("SUCCESS", response.Result);
        Assert.Contains("\"payChannelDetailList\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"fundToolDetailList\"", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task NotifyBadgeCodeRefundResultAsync_ShouldPostRefundDetails()
    {
        SetupResponse(HttpMethod.Post, "/v1.0/badge/codes/refundResults", """{"result":"SUCCESS"}""");

        var response = await _api.NotifyBadgeCodeRefundResultAsync(new NotifyBadgeCodeRefundResultRequest
        {
            CorpId = "dingcorp",
            UserId = "user01",
            TradeNo = "trade01",
            RefundOrderNo = "refund01",
            Remark = "退款",
            RefundAmount = "5.00",
            RefundPromotionAmount = "0.50",
            GmtRefund = "2026-06-03 10:00:00",
            PayChannelDetailList = [CreatePayChannelDetail(payChannelRefundOrderNo: "refund-channel01")],
            PayCode = "pay01"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("SUCCESS", response.Result);
    }

    [Fact]
    public async Task CreateBadgeNotifyAsync_ShouldPostNotice()
    {
        SetupResponse(HttpMethod.Post, "/v1.0/badge/notices", """{"result":true}""");

        var response = await _api.CreateBadgeNotifyAsync(new CreateBadgeNotifyRequest
        {
            UserId = "user01",
            MsgId = "msg01",
            MsgType = "DING_BADGE_NOTIFY",
            Content = """{"title":"标题","subTitle":"备注","imageUrl":"https://example.com/a.png","url":"https://example.com"}"""
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Result);
    }

    [Fact]
    public async Task NotifyBadgeCodeVerifyResultAsync_ShouldPostVerifyResult()
    {
        SetupResponse(HttpMethod.Post, "/v1.0/badge/codes/verifyResults", """{"result":"SUCCESS"}""");

        var response = await _api.NotifyBadgeCodeVerifyResultAsync(new NotifyBadgeCodeVerifyResultRequest
        {
            PayCode = "pay01",
            CorpId = "dingcorp",
            UserCorpRelationType = "INTERNAL_STAFF",
            UserIdentity = "user01",
            VerifyTime = "2026-06-03 09:00:00",
            VerifyResult = true,
            VerifyLocation = "门禁A"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("SUCCESS", response.Result);
    }

    private static BadgePayChannelDetail CreatePayChannelDetail(string? payChannelRefundOrderNo = null) => new()
    {
        PayChannelName = "支付宝",
        GmtCreate = "2026-06-03 09:00:00",
        GmtFinish = "2026-06-03 09:01:00",
        PayChannelType = "ALIPAY",
        Amount = "10.00",
        PayChannelOrderNo = "channel01",
        PayChannelRefundOrderNo = payChannelRefundOrderNo,
        PromotionAmount = "1.00",
        FundToolDetailList =
        [
            new BadgeFundToolDetail
            {
                FundToolName = "余额",
                Amount = "9.00",
                GmtCreate = "2026-06-03 09:00:00",
                GmtFinish = "2026-06-03 09:01:00",
                PromotionFundTool = false,
                ExtInfo = "{}"
            }
        ]
    };

    private void SetupResponse(HttpMethod method, string path, string json, Action<HttpRequestMessage>? capture = null)
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req =>
                    req.Method == method &&
                    req.RequestUri != null &&
                    req.RequestUri.AbsolutePath == path),
                ItExpr.IsAny<CancellationToken>())
            .Callback((HttpRequestMessage req, CancellationToken _) => capture?.Invoke(req))
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json")
            });
    }
}
