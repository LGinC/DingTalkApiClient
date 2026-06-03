using DingTalkApi.Attributes;
using DingTalkApi.Models.ServiceWindow;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.ServiceWindow;

/// <summary>
/// 服务窗 API
/// </summary>
public interface IServiceWindowApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 批量发送服务窗消息
    /// </summary>
    [HttpPost("/v1.0/crm/officialAccounts/oToMessages/batchSend")]
    ITask<ServiceWindowMessageSendResponse> BatchSendMessageAsync([JsonContent] ServiceWindowBatchSendMessageRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 发送服务窗单人消息
    /// </summary>
    [HttpPost("/v1.0/crm/officialAccounts/oToMessages/send")]
    ITask<ServiceWindowMessageSendResponse> SendMessageAsync([JsonContent] ServiceWindowSendMessageRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取企业下服务窗列表
    /// </summary>
    [HttpGet("/v1.0/link/accounts")]
    ITask<ServiceWindowAccountListResponse> ListAccountsAsync([DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量获取关注服务窗用户信息
    /// </summary>
    [HttpGet("/v1.0/link/followers")]
    ITask<ServiceWindowFollowerListResponse> ListFollowersAsync(string? nextToken = null, string? maxResults = null, string? accountId = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取关注服务窗用户信息
    /// </summary>
    [HttpGet("/v1.0/link/followers/infos")]
    ITask<ServiceWindowFollowerInfoResponse> GetFollowerInfoAsync(string? userId = null, string? unionId = null, string? accountId = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
