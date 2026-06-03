using DingTalkApi.Attributes;
using DingTalkApi.Models.EventSubscription;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.EventSubscription;

/// <summary>
/// 事件订阅 oapi
/// </summary>
public interface IEventSubscriptionApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 获取推送失败的事件列表
    /// </summary>
    [HttpGet("/call_back/get_call_back_failed_result")]
    ITask<GetCallbackFailedResultResponse> GetCallbackFailedResultAsync([DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
