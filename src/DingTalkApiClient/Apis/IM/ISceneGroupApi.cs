using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.IM.Chat;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.IM;

/// <summary>
/// 即时通讯场景群 API
/// </summary>
public interface ISceneGroupApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 获取群会话的 OpenConversationId
    /// </summary>
    [HttpPost("/v1.0/im/chat/{chatId}/convertToOpenConversationId")]
    ITask<ConvertToOpenConversationIdResponse> ConvertToOpenConversationIdAsync([PathQuery] string chatId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量更新群管理员
    /// </summary>
    [HttpPost("/v1.0/im/subAdministrators")]
    ITask<SuccessResponse> BatchUpdateSubAdministratorsAsync([JsonContent] UpdateSubAdministratorsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 设置群成员禁言状态
    /// </summary>
    [HttpPost("/v1.0/im/sceneGroups/muteMembers/set")]
    ITask<object> SetMuteMembersAsync([JsonContent] SetMuteMembersRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询群禁言状态
    /// </summary>
    [HttpGet("/v1.0/im/sceneGroups/muteSettings")]
    ITask<GetMuteSettingsResponse> GetMuteSettingsAsync(GetMuteSettingsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新群成员的群昵称
    /// </summary>
    [HttpPut("/v1.0/im/sceneGroups/members/groupNicks")]
    ITask<SuccessResponse> UpdateSceneGroupMemberNickAsync([JsonContent] UpdateSceneGroupMemberNickRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新群管理员
    /// </summary>
    [HttpPut("/v1.0/im/sceneGroups/subAdmins")]
    ITask<SuccessResponse> UpdateSceneGroupSubAdminsAsync([JsonContent] UpdateSubAdministratorsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询群简要信息
    /// </summary>
    [HttpPost("/v1.0/im/sceneGroups/query")]
    ITask<QuerySceneGroupResponse> QuerySceneGroupAsync([JsonContent] QuerySceneGroupRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询群成员
    /// </summary>
    [HttpPost("/v1.0/im/sceneGroups/members/batchQuery")]
    ITask<BatchQuerySceneGroupMembersResponse> BatchQuerySceneGroupMembersAsync([JsonContent] BatchQuerySceneGroupMembersRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询群内群模版机器人
    /// </summary>
    [HttpGet("/v1.0/im/sceneGroups/template/robots")]
    ITask<QueryTemplateRobotsResponse> QueryTemplateRobotsAsync(QueryTemplateRobotsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建并开启互动卡片吊顶
    /// </summary>
    [HttpPost("/v2.0/im/topBoxes")]
    ITask<SuccessResponse> CreateTopBoxAsync([JsonContent] CreateTopBoxRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 关闭互动卡片吊顶
    /// </summary>
    [HttpPost("/v2.0/im/topBoxes/close")]
    ITask<SuccessResponse> CloseTopBoxAsync([JsonContent] CloseTopBoxRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
