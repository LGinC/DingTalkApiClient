using System.Threading;
using DingTalkApi.Attributes;
using DingTalkApi.Models.IM.CorpConversation;
using WebApiClientCore;
using WebApiClientCore.Attributes;
using DingTalkApi.Models;

namespace DingTalkApi.Apis.IM;

/// <summary>
/// 钉钉工作通知API (Top API)
/// </summary>
public interface ICorpConversationApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 发送工作通知
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/topapi/message/corpconversation/asyncsend_v2")]
    ITask<AsyncSendCorpConversationV2Response> AsyncSendCorpConversationV2Async([JsonContent] AsyncSendCorpConversationV2Request request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 撤回工作通知消息
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/topapi/message/corpconversation/recall")]
    ITask<DingTalkResult> RecallCorpConversationAsync([JsonContent] RecallCorpConversationRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取工作通知消息的发送进度
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/topapi/message/corpconversation/getsendprogress")]
    ITask<GetSendProgressCorpConversationResponse> GetSendProgressCorpConversationAsync([JsonContent] GetSendProgressCorpConversationRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取工作通知消息的发送结果
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/topapi/message/corpconversation/getsendresult")]
    ITask<GetSendResultCorpConversationResponse> GetSendResultCorpConversationAsync([JsonContent] GetSendResultCorpConversationRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新工作通知状态栏
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/topapi/message/corpconversation/status_bar/update")]
    ITask<DingTalkResult> UpdateStatusBarCorpConversationAsync([JsonContent] UpdateStatusBarCorpConversationRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 使用模板发送工作通知消息
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/topapi/message/corpconversation/sendbytemplate")]
    ITask<SendByTemplateCorpConversationResponse> SendByTemplateCorpConversationAsync([JsonContent] SendByTemplateCorpConversationRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
