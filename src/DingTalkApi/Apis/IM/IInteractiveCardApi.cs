using DingTalkApi.Attributes;
using DingTalkApi.Models.IM.InteractiveCards;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.IM;

/// <summary>
/// 钉钉互动卡片 API
/// </summary>
public interface IInteractiveCardApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 机器人发送互动卡片（普通版）
    /// </summary>
    [HttpPost("/v1.0/im/v1.0/robot/interactiveCards/send")]
    ITask<InteractiveCardProcessResponse> SendRobotInteractiveCardAsync([JsonContent] SendRobotInteractiveCardRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新机器人发送互动卡片（普通版）
    /// </summary>
    [HttpPut("/v1.0/im/robots/interactiveCards")]
    ITask<InteractiveCardProcessResponse> UpdateRobotInteractiveCardAsync([JsonContent] UpdateRobotInteractiveCardRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 发送钉钉互动卡片（高级版）
    /// </summary>
    [HttpPost("/v1.0/im/interactiveCards/send")]
    ITask<InteractiveCardSendResponse> SendInteractiveCardAsync([JsonContent] SendInteractiveCardRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新钉钉互动卡片
    /// </summary>
    [HttpPut("/v1.0/im/interactiveCards")]
    ITask<InteractiveCardSuccessResponse> UpdateInteractiveCardAsync([JsonContent] UpdateInteractiveCardRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 人与人会话中机器人发送互动卡片
    /// </summary>
    [HttpPost("/v1.0/im/privateChat/interactiveCards/send")]
    ITask<InteractiveCardSendResponse> SendPrivateChatInteractiveCardAsync([JsonContent] SendPrivateChatInteractiveCardRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 发送轻量级互动卡片
    /// </summary>
    [HttpPost("/v1.0/im/interactiveCards/templates/send")]
    ITask<InteractiveCardProcessResponse> SendTemplateInteractiveCardAsync([JsonContent] SendTemplateInteractiveCardRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
