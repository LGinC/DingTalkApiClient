using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.IM.Interconnections;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.IM;

/// <summary>
/// 钉钉客联互通 API
/// </summary>
public interface IInterconnectionsApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 创建普通群
    /// </summary>
    [HttpPost("/v2.0/im/interconnections/groups")]
    ITask<CreateInterconnectionGroupResponse> CreateGroupAsync([JsonContent] CreateInterconnectionGroupRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建两人群
    /// </summary>
    [HttpPost("/v2.0/im/interconnections/couples/groups")]
    ITask<CreateInterconnectionGroupResponse> CreateCoupleGroupAsync([JsonContent] CreateInterconnectionCoupleGroupRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建钉外账号
    /// </summary>
    [HttpPost("/v1.0/im/interconnections")]
    ITask<CreateInterconnectionsResponse> CreateInterconnectionsAsync([JsonContent] CreateInterconnectionsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量查询跨钉两人群列表
    /// </summary>
    [HttpPost("/v1.0/im/interconnections/doubleGroups/query")]
    ITask<QueryDoubleGroupsResponse> QueryDoubleGroupsAsync([JsonContent] QueryDoubleGroupsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取钉钉客联 H5 会话地址
    /// </summary>
    [HttpPost("/v1.0/im/conversations/urls")]
    ITask<GetConversationUrlResponse> GetConversationUrlAsync([JsonContent] GetConversationUrlRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询钉外账号未读消息数
    /// </summary>
    [HttpPost("/v1.0/im/interconnections/unReadMsgs/query")]
    ITask<QueryUnreadMessagesResponse> QueryUnreadMessagesAsync([JsonContent] QueryUnreadMessagesRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 添加互通群成员
    /// </summary>
    [HttpPost("/v1.0/im/interconnections/groups/members")]
    ITask<UpdateGroupMembersResponse> AddGroupMembersAsync([JsonContent] UpdateGroupMembersRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 移除互通群成员
    /// </summary>
    [HttpPost("/v1.0/im/interconnections/groups/members/remove")]
    ITask<RemoveGroupMembersResponse> RemoveGroupMembersAsync([JsonContent] UpdateGroupMembersRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 修改互通群头像
    /// </summary>
    [HttpPut("/v1.0/im/interconnections/groups/avatars")]
    ITask<UpdateGroupAvatarResponse> UpdateGroupAvatarAsync([JsonContent] UpdateGroupAvatarRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 修改互通群名称
    /// </summary>
    [HttpPut("/v1.0/im/interconnections/groups/names")]
    ITask<UpdateGroupNameResponse> UpdateGroupNameAsync([JsonContent] UpdateGroupNameRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更换互通群群主
    /// </summary>
    [HttpPut("/v1.0/im/interconnections/groups/owners")]
    ITask<UpdateGroupOwnerResponse> UpdateGroupOwnerAsync([JsonContent] UpdateGroupOwnerRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询互通群成员列表
    /// </summary>
    [HttpGet("/v1.0/im/interconnections/conversations/members")]
    ITask<QueryGroupMembersResponse> QueryGroupMembersAsync(QueryGroupMembersRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 解散互通群
    /// </summary>
    [HttpPost("/v1.0/im/interconnections/groups/dismiss")]
    ITask<DismissGroupResponse> DismissGroupAsync([JsonContent] DismissGroupRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 互通群机器人发送群消息
    /// </summary>
    [HttpPost("/v1.0/im/interconnections/robotMessages/send")]
    ITask<SendRobotGroupMessageResponse> SendRobotGroupMessageAsync([JsonContent] SendRobotGroupMessageRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 钉外账号向钉内账号或互通群发送消息
    /// </summary>
    [HttpPost("/v1.0/im/interconnections/messages/send")]
    ITask<SendInterconnectionMessageResponse> SendMessageAsync([JsonContent] SendInterconnectionMessageRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 钉内账号向互通群或钉外账号发送消息
    /// </summary>
    [HttpPost("/v1.0/im/interconnections/dingMessages/send")]
    ITask<SendInterconnectionMessageResponse> SendDingMessageAsync([JsonContent] SendDingMessageRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
