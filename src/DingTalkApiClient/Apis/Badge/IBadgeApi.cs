using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.Badge;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.Badge;

/// <summary>
/// 钉工牌api
/// </summary>
public interface IBadgeApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 创建钉工牌电子码
    /// </summary>
    [HttpPost("/v1.0/badge/codes/userInstances")]
    ITask<CreateBadgeCodeUserInstanceResponse> CreateBadgeCodeUserInstanceAsync([JsonContent] CreateBadgeCodeUserInstanceRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新钉工牌电子码
    /// </summary>
    [HttpPut("/v1.0/badge/codes/userInstances")]
    ITask<UpdateBadgeCodeUserInstanceResponse> UpdateBadgeCodeUserInstanceAsync([JsonContent] UpdateBadgeCodeUserInstanceRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 配置企业钉工牌
    /// </summary>
    [HttpPost("/v1.0/badge/codes/corpInstances")]
    ITask<SaveBadgeCodeCorpInstanceResponse> SaveBadgeCodeCorpInstanceAsync([JsonContent] SaveBadgeCodeCorpInstanceRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 解码钉工牌电子码
    /// </summary>
    [HttpPost("/v1.0/badge/codes/decode")]
    ITask<DecodeBadgeCodeResponse> DecodeBadgeCodeAsync([JsonContent] DecodeBadgeCodeRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 通知支付结果
    /// </summary>
    [HttpPost("/v1.0/badge/codes/payResults")]
    ITask<BadgeStringResultResponse> NotifyBadgeCodePayResultAsync([JsonContent] NotifyBadgeCodePayResultRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 通知退款结果
    /// </summary>
    [HttpPost("/v1.0/badge/codes/refundResults")]
    ITask<BadgeStringResultResponse> NotifyBadgeCodeRefundResultAsync([JsonContent] NotifyBadgeCodeRefundResultRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 钉工牌通知消息
    /// </summary>
    [HttpPost("/v1.0/badge/notices")]
    ITask<BadgeBooleanResultResponse> CreateBadgeNotifyAsync([JsonContent] CreateBadgeNotifyRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 同步钉工牌码验证结果
    /// </summary>
    [HttpPost("/v1.0/badge/codes/verifyResults")]
    ITask<BadgeStringResultResponse> NotifyBadgeCodeVerifyResultAsync([JsonContent] NotifyBadgeCodeVerifyResultRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
