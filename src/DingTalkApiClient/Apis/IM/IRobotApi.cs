using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.IM.Robot;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.IM;

/// <summary>
/// 机器人api
/// </summary>
public interface IRobotApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 发送DING消息
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/robot/ding/send")]
    public ITask<DingMessageResponse> SendDingMessageAsync([JsonContent] DingMessage request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 撤回已经发送的DING消息
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/robot/ding/recall")]
    public ITask<RecallDingMessageResponse> RecallDingMessageAsync([JsonContent] RecallDingMessage request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量发送人与机器人会话中机器人消息
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/robot/oToMessages/batchSend")]
    public ITask<SendOToMessageBatchResponse> SendOToMessageBatchAsync([JsonContent] SendOToMessageBatchRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 人与人会话中机器人发送普通消息
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/robot/oToMessages/send")]
    public ITask<SendOToMessageResponse> SendOToMessageAsync([JsonContent] SendOToMessageRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 机器人发送群聊消息
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/robot/groupMessages/send")]
    public ITask<SendGroupMessageResponse> SendGroupMessageAsync([JsonContent] SendGroupMessageRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 自定义机器人发送群消息
    /// </summary>
    /// <param name="access_token">机器人对应的 webhook token</param>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/robot/send")]
    public ITask<CustomRobotMessageResponse> SendCustomRobotMessageAsync([Parameter(Kind.Query)] string access_token, [JsonContent] CustomRobotMessageRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    #region 消息查询
    /// <summary>
    /// 查询人与人会话中机器人消息已读列表
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/robot/privateChatMessages/query")]
    public ITask<QueryPrivateChatMessagesResponse> QueryPrivateChatMessagesAsync([JsonContent] QueryPrivateChatMessagesRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量查询人与机器人会话消息是否已读
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("/v1.0/robot/oToMessages/readStatus")]
    public ITask<QueryOtoMessageReadStatusResponse> QueryOtoMessageReadStatusAsync(QueryOtoMessageReadStatusRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询企业机器人群聊消息用户已读状态
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/robot/groupMessages/query")]
    public ITask<QueryGroupMessagesResponse> QueryGroupMessagesAsync([JsonContent] QueryGroupMessagesRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 下载机器人接收消息的文件内容
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/robot/messageFiles/download")]
    public ITask<DownloadRobotMessageFileResponse> DownloadRobotMessageFileAsync([JsonContent] DownloadRobotMessageFileRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量撤回人与机器人会话中机器人消息
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/robot/otoMessages/batchRecall")]
    public ITask<BatchRecallRobotMessagesResponse> BatchRecallOtoMessagesAsync([JsonContent] BatchRecallOtoMessagesRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量撤回人与人会话中机器人消息
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/robot/privateChatMessages/batchRecall")]
    public ITask<BatchRecallRobotMessagesResponse> BatchRecallPrivateChatMessagesAsync([JsonContent] BatchRecallPrivateChatMessagesRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 企业机器人撤回内部群消息
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/robot/groupMessages/recall")]
    public ITask<BatchRecallRobotMessagesResponse> RecallGroupMessagesAsync([JsonContent] RecallGroupMessagesRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取群内机器人列表
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/robot/getBotListInGroup")]
    public ITask<GetBotListInGroupResponse> GetBotListInGroupAsync([JsonContent] GetBotListInGroupRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 设置单聊机器人快捷入口
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/robot/plugins/set")]
    public ITask<RobotPluginResultResponse> SetRobotPluginsAsync([JsonContent] SetRobotPluginsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询单聊机器人的快捷入口
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/robot/plugins/query")]
    public ITask<QueryRobotPluginsResponse> QueryRobotPluginsAsync([JsonContent] QueryRobotPluginsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 清空单聊机器人快捷入口
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/robot/plugins/clear")]
    public ITask<RobotPluginResultResponse> ClearRobotPluginsAsync([JsonContent] ClearRobotPluginsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    #endregion
}
