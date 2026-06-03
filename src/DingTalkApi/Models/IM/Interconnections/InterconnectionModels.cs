using System.Text.Json.Serialization;

namespace DingTalkApi.Models.IM.Interconnections;

/// <summary>
/// 创建普通群请求
/// </summary>
public class CreateInterconnectionGroupRequest
{
    /// <summary>
    /// 群名称，长度限制为 1 到 64 个字符。
    /// </summary>
    public required string GroupName { get; set; }

    /// <summary>
    /// 群头像地址，长度限制为 1 到 1024 个字符。
    /// </summary>
    public string? GroupAvatar { get; set; }

    /// <summary>
    /// 群模板 ID，来源自钉钉客联工作台。
    /// </summary>
    public required string GroupTemplateId { get; set; }

    /// <summary>
    /// 群成员列表。
    /// </summary>
    public required List<InterconnectionGroupUser> Users { get; set; }

    /// <summary>
    /// 操作者在业务系统内的唯一标识，支持钉内账号 userId 或钉外账号 appUserId。
    /// </summary>
    public string? OperatorId { get; set; }
}

/// <summary>
/// 创建两人群请求
/// </summary>
public class CreateInterconnectionCoupleGroupRequest
{
    /// <summary>
    /// 群模板 ID，来源自钉钉客联工作台。
    /// </summary>
    public required string GroupTemplateId { get; set; }

    /// <summary>
    /// 群成员列表，两人群应有且只有两个成员。
    /// </summary>
    public List<InterconnectionGroupUser>? Users { get; set; }

    /// <summary>
    /// 操作者在业务系统内的唯一标识，支持钉内账号 userId 或钉外账号 appUserId。
    /// </summary>
    public string? OperatorId { get; set; }
}

/// <summary>
/// 互通群成员入参
/// </summary>
public class InterconnectionGroupUser
{
    /// <summary>
    /// 钉外账号在业务系统内的唯一标识；与 UserId 二选一。
    /// </summary>
    public string? AppUserId { get; set; }

    /// <summary>
    /// 钉内账号 userId；与 AppUserId 二选一。
    /// </summary>
    public string? UserId { get; set; }
}

/// <summary>
/// 创建群响应
/// </summary>
public class CreateInterconnectionGroupResponse
{
    /// <summary>
    /// 群会话 ID。
    /// </summary>
    public required string OpenConversationId { get; set; }

    /// <summary>
    /// 钉钉群会话 ID。
    /// </summary>
    public required string ConversationId { get; set; }

    /// <summary>
    /// 钉外账号在业务系统内的唯一标识。
    /// </summary>
    public required List<string> AppUserIds { get; set; }

    /// <summary>
    /// 钉内账号 userId。
    /// </summary>
    public required List<string> UserIds { get; set; }
}

/// <summary>
/// 创建钉外账号请求
/// </summary>
public class CreateInterconnectionsRequest
{
    /// <summary>
    /// 钉外账号列表。
    /// </summary>
    public required List<InterconnectionAccountCreateItem> Interconnections { get; set; }
}

/// <summary>
/// 钉外账号创建项
/// </summary>
public class InterconnectionAccountCreateItem
{
    /// <summary>
    /// 钉外账号在业务系统内的唯一标识，长度限制为 1 到 64 个字符。
    /// </summary>
    public required string AppUserId { get; set; }

    /// <summary>
    /// 钉外账号名称，长度限制为 1 到 64 个字符。
    /// </summary>
    public required string AppUserName { get; set; }

    /// <summary>
    /// 钉外账号头像地址。
    /// </summary>
    public string? AppUserAvatar { get; set; }

    /// <summary>
    /// 钉外账号扩展字段。
    /// </summary>
    public string? AppUserDynamics { get; set; }

    /// <summary>
    /// 钉外账号手机号。
    /// </summary>
    public required string AppUserMobile { get; set; }

    /// <summary>
    /// 关联的钉内账号 userId。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// 渠道码。
    /// </summary>
    public string? ChannelCode { get; set; }
}

/// <summary>
/// 创建钉外账号响应
/// </summary>
public class CreateInterconnectionsResponse
{
    /// <summary>
    /// 创建结果列表。
    /// </summary>
    public required List<InterconnectionCreateResult> Results { get; set; }
}

/// <summary>
/// 钉外账号创建结果
/// </summary>
public class InterconnectionCreateResult
{
    /// <summary>
    /// 钉外账号在业务系统内的唯一标识。
    /// </summary>
    public string? AppUserId { get; set; }

    /// <summary>
    /// 关联的钉内账号 userId。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// 结果消息。
    /// </summary>
    public string? Message { get; set; }
}

/// <summary>
/// 批量查询跨钉两人群请求
/// </summary>
public class QueryDoubleGroupsRequest
{
    /// <summary>
    /// 群模板 ID。
    /// </summary>
    public required string GroupTemplateId { get; set; }

    /// <summary>
    /// 两人群成员列表。
    /// </summary>
    public required List<DoubleGroupMemberQueryItem> GroupMembers { get; set; }
}

/// <summary>
/// 两人群成员查询项
/// </summary>
public class DoubleGroupMemberQueryItem
{
    /// <summary>
    /// 钉外账号在业务系统内的唯一标识。
    /// </summary>
    public required string AppUserId { get; set; }

    /// <summary>
    /// 钉内账号 userId。
    /// </summary>
    public required string UserId { get; set; }
}

/// <summary>
/// 批量查询跨钉两人群响应
/// </summary>
public class QueryDoubleGroupsResponse
{
    /// <summary>
    /// 群会话列表。
    /// </summary>
    public required List<DoubleGroupConversation> OpenConversations { get; set; }
}

/// <summary>
/// 跨钉两人群会话信息
/// </summary>
public class DoubleGroupConversation
{
    /// <summary>
    /// 群会话 openConversationId。
    /// </summary>
    public string? OpenConversationId { get; set; }

    /// <summary>
    /// 钉外账号在业务系统内的唯一标识。
    /// </summary>
    public string? AppUserId { get; set; }

    /// <summary>
    /// 钉内账号 userId。
    /// </summary>
    public string? UserId { get; set; }
}

/// <summary>
/// 获取钉钉客联 H5 会话地址请求
/// </summary>
public class GetConversationUrlRequest
{
    /// <summary>
    /// 钉外账号在业务系统内的唯一标识。
    /// </summary>
    public required string AppUserId { get; set; }

    /// <summary>
    /// 钉内账号 userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 群会话 openConversationId。
    /// </summary>
    public string? OpenConversationId { get; set; }

    /// <summary>
    /// 渠道码。
    /// </summary>
    public required string ChannelCode { get; set; }
}

/// <summary>
/// 获取钉钉客联 H5 会话地址响应
/// </summary>
public class GetConversationUrlResponse
{
    /// <summary>
    /// H5 会话地址。
    /// </summary>
    public required string Url { get; set; }
}

/// <summary>
/// 查询钉外账号未读消息数请求
/// </summary>
public class QueryUnreadMessagesRequest
{
    /// <summary>
    /// 钉外账号在业务系统内的唯一标识。
    /// </summary>
    public required string AppUserId { get; set; }

    /// <summary>
    /// 群会话 openConversationId 列表。
    /// </summary>
    public List<string>? OpenConversationIds { get; set; }
}

/// <summary>
/// 查询钉外账号未读消息数响应
/// </summary>
public class QueryUnreadMessagesResponse
{
    /// <summary>
    /// 未读消息总数。
    /// </summary>
    public required int UnReadCount { get; set; }

    /// <summary>
    /// 各会话未读消息数。
    /// </summary>
    public required List<UnreadMessageItem> UnReadItems { get; set; }
}

/// <summary>
/// 会话未读消息数
/// </summary>
public class UnreadMessageItem
{
    /// <summary>
    /// 群会话 openConversationId。
    /// </summary>
    public string? OpenConversationId { get; set; }

    /// <summary>
    /// 未读消息数。
    /// </summary>
    public int UnReadCount { get; set; }
}

/// <summary>
/// 添加或移除互通群成员请求
/// </summary>
public class UpdateGroupMembersRequest
{
    /// <summary>
    /// 群会话 openConversationId。
    /// </summary>
    public required string OpenConversationId { get; set; }

    /// <summary>
    /// 要添加或移除的钉外账号 appUserId 列表。
    /// </summary>
    public List<string>? AppUserIds { get; set; }

    /// <summary>
    /// 要添加或移除的钉内账号 userId 列表。
    /// </summary>
    public List<string>? UserIds { get; set; }

    /// <summary>
    /// 操作者在业务系统内的唯一标识，支持钉内账号 userId 或钉外账号 appUserId。
    /// </summary>
    public required string OperatorId { get; set; }
}

/// <summary>
/// 添加互通群成员响应
/// </summary>
public class UpdateGroupMembersResponse
{
    /// <summary>
    /// 添加成功的钉外账号 appUserId 列表。
    /// </summary>
    public required List<string> AppUserIds { get; set; }

    /// <summary>
    /// 添加成功的钉内账号 userId 列表。
    /// </summary>
    public required List<string> UserIds { get; set; }
}

/// <summary>
/// 移除互通群成员响应
/// </summary>
public class RemoveGroupMembersResponse
{
    /// <summary>
    /// 结果消息。
    /// </summary>
    public required string Message { get; set; }
}

/// <summary>
/// 修改互通群头像请求
/// </summary>
public class UpdateGroupAvatarRequest
{
    /// <summary>
    /// 群会话 openConversationId。
    /// </summary>
    public required string OpenConversationId { get; set; }

    /// <summary>
    /// 新群头像地址。
    /// </summary>
    public required string GroupAvatar { get; set; }
}

/// <summary>
/// 修改互通群头像响应
/// </summary>
public class UpdateGroupAvatarResponse
{
    /// <summary>
    /// 新群头像地址。
    /// </summary>
    public required string NewGroupAvatar { get; set; }
}

/// <summary>
/// 修改互通群名称请求
/// </summary>
public class UpdateGroupNameRequest
{
    /// <summary>
    /// 群会话 openConversationId。
    /// </summary>
    public required string OpenConversationId { get; set; }

    /// <summary>
    /// 新群名称。
    /// </summary>
    public required string GroupName { get; set; }
}

/// <summary>
/// 修改互通群名称响应
/// </summary>
public class UpdateGroupNameResponse
{
    /// <summary>
    /// 新群名称。
    /// </summary>
    public required string NewGroupName { get; set; }
}

/// <summary>
/// 更换互通群群主请求
/// </summary>
public class UpdateGroupOwnerRequest
{
    /// <summary>
    /// 群会话 openConversationId。
    /// </summary>
    public required string OpenConversationId { get; set; }

    /// <summary>
    /// 新群主 ID。
    /// </summary>
    public required string GroupOwnerId { get; set; }

    /// <summary>
    /// 新群主类型。
    /// </summary>
    public required int GroupOwnerType { get; set; }
}

/// <summary>
/// 更换互通群群主响应
/// </summary>
public class UpdateGroupOwnerResponse
{
    /// <summary>
    /// 新群主 ID。
    /// </summary>
    public required string NewGroupOwnerId { get; set; }

    /// <summary>
    /// 新群主类型。
    /// </summary>
    public required int NewGroupOwnerType { get; set; }
}

/// <summary>
/// 查询互通群成员列表请求
/// </summary>
/// <param name="OpenConversationId">群会话 openConversationId，长度限制为 1 到 32 个字符。</param>
public record QueryGroupMembersRequest(string OpenConversationId);

/// <summary>
/// 查询互通群成员列表响应
/// </summary>
public class QueryGroupMembersResponse
{
    /// <summary>
    /// 群会话 openConversationId。
    /// </summary>
    public required string OpenConversationId { get; set; }

    /// <summary>
    /// 群成员列表。
    /// </summary>
    public required List<InterconnectionGroupMember> GroupMembers { get; set; }
}

/// <summary>
/// 互通群成员信息
/// </summary>
public class InterconnectionGroupMember
{
    /// <summary>
    /// 群成员 ID。
    /// </summary>
    public string? GroupMemberId { get; set; }

    /// <summary>
    /// 群成员名称。
    /// </summary>
    public string? GroupMemberName { get; set; }

    /// <summary>
    /// 群成员类型。
    /// </summary>
    public int? GroupMemberType { get; set; }

    /// <summary>
    /// 群成员头像地址。
    /// </summary>
    public string? GroupMemberAvatar { get; set; }

    /// <summary>
    /// 群成员扩展字段。
    /// </summary>
    public string? GroupMemberDynamics { get; set; }
}

/// <summary>
/// 解散互通群请求
/// </summary>
public class DismissGroupRequest
{
    /// <summary>
    /// 群会话 openConversationId。
    /// </summary>
    public required string OpenConversationId { get; set; }
}

/// <summary>
/// 解散互通群响应
/// </summary>
public class DismissGroupResponse
{
    /// <summary>
    /// 已解散的群会话 openConversationId。
    /// </summary>
    public required string OpenConversationId { get; set; }
}

/// <summary>
/// 互通群机器人发送群消息请求
/// </summary>
public class SendRobotGroupMessageRequest
{
    /// <summary>
    /// 群会话 openConversationId 列表。
    /// </summary>
    public required List<string> OpenConversationIds { get; set; }

    /// <summary>
    /// 机器人 robotCode。
    /// </summary>
    public string? RobotCode { get; set; }

    /// <summary>
    /// 消息类型，取值包括 text、photo、markdown、actionCard。
    /// </summary>
    public required string MsgType { get; set; }

    /// <summary>
    /// 消息体内容。
    /// </summary>
    public required string MsgContent { get; set; }

    /// <summary>
    /// 被 @ 的钉内账号 userId。
    /// </summary>
    public string? AtDingUserId { get; set; }

    /// <summary>
    /// 被 @ 的钉外账号 appUserId。
    /// </summary>
    public string? AtAppUserId { get; set; }

    /// <summary>
    /// 是否 @ 所有人。
    /// </summary>
    public bool? AtAll { get; set; }
}

/// <summary>
/// 互通群机器人发送群消息响应
/// </summary>
public class SendRobotGroupMessageResponse
{
    /// <summary>
    /// 是否发送成功。
    /// </summary>
    public required bool Success { get; set; }
}

/// <summary>
/// 钉外账号向钉内账号或互通群发送消息请求
/// </summary>
public class SendInterconnectionMessageRequest
{
    /// <summary>
    /// 消息发送者，钉外账号在业务系统内的唯一标识。
    /// </summary>
    public required string SenderId { get; set; }

    /// <summary>
    /// 钉内账号 userId；单聊场景必填。
    /// </summary>
    public string? ReceiverId { get; set; }

    /// <summary>
    /// 群会话 openConversationId；群聊场景必填。
    /// </summary>
    public string? OpenConversationId { get; set; }

    /// <summary>
    /// 消息类型，取值包括 text、link、action_card。
    /// </summary>
    public required string MessageType { get; set; }

    /// <summary>
    /// 消息内容。
    /// </summary>
    public required string Message { get; set; }
}

/// <summary>
/// 钉内账号向互通群或钉外账号发送消息请求
/// </summary>
public class SendDingMessageRequest : SendInterconnectionMessageRequest
{
    /// <summary>
    /// 发送者在钉钉客联应用内的个人授权码。
    /// </summary>
    public required string Code { get; set; }
}

/// <summary>
/// 互通消息发送响应
/// </summary>
public class SendInterconnectionMessageResponse
{
    /// <summary>
    /// 本次发送的请求消息 ID。
    /// </summary>
    public required string RequestId { get; set; }
}
