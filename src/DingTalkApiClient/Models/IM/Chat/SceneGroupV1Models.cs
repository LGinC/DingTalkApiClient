using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models.IM.Chat;

/// <summary>
/// 成功响应
/// </summary>
public class SuccessResponse
{
    /// <summary>
    /// 请求是否成功。
    /// </summary>
    public bool? Success { get; set; }
}

/// <summary>
/// 转换 OpenConversationId 响应
/// </summary>
public class ConvertToOpenConversationIdResponse
{
    /// <summary>
    /// 群会话的OpenConversationId。
    /// </summary>
    public string? OpenConversationId { get; set; }
}

/// <summary>
/// 更新管理员请求
/// </summary>
public class UpdateSubAdministratorsRequest
{
    /// <summary>
    /// 需要禁言或取消禁言的群成员userId列表；群主和群管理员无法被设置禁言，最多传999个。
    /// </summary>
    public required string OpenConversationId { get; set; }

    /// <summary>
    /// 角色。
    /// </summary>
    public required int Role { get; set; }

    /// <summary>
    /// 用户ID列表。
    /// </summary>
    public required List<string> UserIds { get; set; }
}

/// <summary>
/// 设置群成员禁言请求
/// </summary>
public class SetMuteMembersRequest
{
    /// <summary>
    /// 用户ID列表。
    /// </summary>
    public required List<string> UserIdList { get; set; }

    /// <summary>
    /// 群ID，通过创建群接口获取open_conversation_id参数值。
    /// </summary>
    public required string OpenConversationId { get; set; }

    /// <summary>
    /// 禁言状态：0取消禁言，1禁言。
    /// </summary>
    public required int MuteStatus { get; set; }

    /// <summary>
    /// 禁言持续时长，单位：毫秒。
    /// </summary>
    public required long MuteDuration { get; set; }
}

/// <summary>
/// 查询群禁言状态请求
/// </summary>
public class GetMuteSettingsRequest
{
    /// <summary>
    /// 群ID，通过创建群接口获取open_conversation_id参数值。
    /// </summary>
    public required string OpenConversationId { get; set; }
}

/// <summary>
/// 查询群禁言状态响应
/// </summary>
public class GetMuteSettingsResponse
{
    /// <summary>
    /// 群禁言状态：true禁言，false未禁言。
    /// </summary>
    public int? GroupMuteMode { get; set; }

    /// <summary>
    /// 群禁言状态结果。
    /// </summary>
    public List<UserMuteResultItem> UserMuteResult { get; set; } = [];
}

/// <summary>
/// 群禁言状态结果。
/// </summary>
public class UserMuteResultItem
{
    /// <summary>
    /// 用户userId。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// 禁言状态：0取消禁言，1禁言。
    /// </summary>
    public int? MuteStatus { get; set; }

    /// <summary>
    /// 禁言结束时间
    /// </summary>
    public long? MuteEndTime { get; set; }
}

/// <summary>
/// 更新场景群成员昵称请求
/// </summary>
public class UpdateSceneGroupMemberNickRequest
{
    /// <summary>
    /// 群ID。
    /// </summary>
    public required string OpenConversationId { get; set; }

    /// <summary>
    /// 用户userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 群昵称
    /// </summary>
    public required string GroupNick { get; set; }
}

/// <summary>
/// 查询场景群请求
/// </summary>
public class QuerySceneGroupRequest
{
    /// <summary>
    /// 群ID：基于群模板创建的群或安装群聊酷应用的群对应的openConversationId。
    /// </summary>
    public required string OpenConversationId { get; set; }

    /// <summary>
    /// 群聊酷应用编码；基于群模板创建的群不需要传入，安装群聊酷应用的群必须传入。
    /// </summary>
    public required string CoolAppCode { get; set; }
}

/// <summary>
/// 查询场景群响应
/// </summary>
public class QuerySceneGroupResponse : SuccessResponse
{
    /// <summary>
    /// 群ID：基于群模板创建的群或安装群聊酷应用的群对应的openConversationId。
    /// </summary>
    public string? OpenConversationId { get; set; }

    /// <summary>
    /// 场景群模板ID。
    /// </summary>
    public string? TemplateId { get; set; }

    /// <summary>
    /// 群名称。
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 群主的userId。
    /// </summary>
    public string? OwnerUserId { get; set; }

    /// <summary>
    /// 群头像mediaId。
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// 群URL。
    /// </summary>
    public string? GroupUrl { get; set; }

    /// <summary>
    /// 群状态：1正常，2已解散。
    /// </summary>
    public int? Status { get; set; }
}

/// <summary>
/// 批量查询场景群成员请求
/// </summary>
public class BatchQuerySceneGroupMembersRequest
{
    /// <summary>
    /// 群ID。
    /// </summary>
    public required string OpenConversationId { get; set; }

    /// <summary>
    /// 群聊酷应用编码；基于群模板创建的群不需要传入，安装群聊酷应用的群必须传入。
    /// </summary>
    public string? CoolAppCode { get; set; }

    /// <summary>
    /// 分页大小；接口返回结果可能会大于或小于maxResults，以实际返回结果为准。
    /// </summary>
    public required int MaxResults { get; set; }

    /// <summary>
    /// 分页游标，置空表示从首页开始查询；响应中表示下一次请求的游标。
    /// </summary>
    public string? NextToken { get; set; }
}

/// <summary>
/// 批量查询场景群成员响应
/// </summary>
public class BatchQuerySceneGroupMembersResponse : SuccessResponse
{
    /// <summary>
    /// 群成员id。
    /// </summary>
    public List<string> MemberUserIds { get; set; } = [];

    /// <summary>
    /// 是否还有更多数据。
    /// </summary>
    public bool? HasMore { get; set; }

    /// <summary>
    /// 分页游标，置空表示从首页开始查询；响应中表示下一次请求的游标。
    /// </summary>
    public string? NextToken { get; set; }
}

/// <summary>
/// 查询模板机器人请求
/// </summary>
public class QueryTemplateRobotsRequest
{
    /// <summary>
    /// 会话id；群聊时必传，单聊助手不传入此参数。
    /// </summary>
    public required string OpenConversationId { get; set; }
}

/// <summary>
/// 查询模板机器人响应
/// </summary>
public class QueryTemplateRobotsResponse : SuccessResponse
{
    /// <summary>
    /// 机器人列表
    /// </summary>
    public List<TemplateRobotInfo> Result { get; set; } = [];
}

/// <summary>
/// 模板机器人信息
/// </summary>
public class TemplateRobotInfo
{
    /// <summary>
    /// 机器人编码；单聊助手时必填。
    /// </summary>
    public string? RobotCode { get; set; }

    /// <summary>
    /// 机器人名称
    /// </summary>
    public string? RobotName { get; set; }
}

/// <summary>
/// 创建吊顶请求
/// </summary>
public class CreateTopBoxRequest
{
    /// <summary>
    /// 互动卡片的消息模板ID；企业内部应用或第三方企业应用调用创建消息模板接口获取模板ID。
    /// </summary>
    public required string CardTemplateId { get; set; }

    /// <summary>
    /// 唯一标识一张卡片的外部ID，最大长度64；调用者自己定义的卡片唯一标识。
    /// </summary>
    public required string OutTrackId { get; set; }

    /// <summary>
    /// 卡片数据。
    /// </summary>
    public required Dictionary<string, object?> CardData { get; set; }

    /// <summary>
    /// 会话类型：1群聊，2单聊助手。
    /// </summary>
    public required int ConversationType { get; set; }

    /// <summary>
    /// 会话id；群聊时必传，单聊助手不传入此参数。
    /// </summary>
    public string? OpenConversationId { get; set; }

    /// <summary>
    /// 可控制卡片回调时的路由Key，用于指定特定的callbackUrl。
    /// </summary>
    public string? CallbackRouteKey { get; set; }

    /// <summary>
    /// 机器人编码；单聊助手时必填。
    /// </summary>
    public string? RobotCode { get; set; }

    /// <summary>
    /// 吊顶可见者userId，最多可传100个userId；群聊不传接收者列表则默认对会话内所有人可见。
    /// </summary>
    public List<string>? ReceiverUserIdList { get; set; }

    /// <summary>
    /// 期望吊顶的端，如果有多个用“|”分隔，例如ios|mac|android|win。
    /// </summary>
    public List<string>? Platforms { get; set; }
}

/// <summary>
/// 关闭吊顶请求
/// </summary>
public class CloseTopBoxRequest
{
    /// <summary>
    /// 唯一标识一张卡片的外部ID，最大长度64；调用者自己定义的卡片唯一标识。
    /// </summary>
    public required string OutTrackId { get; set; }

    /// <summary>
    /// 会话类型：1群聊，2单聊助手。
    /// </summary>
    public required int ConversationType { get; set; }

    /// <summary>
    /// 群ID。
    /// </summary>
    public string? OpenConversationId { get; set; }

    /// <summary>
    /// 用户userId；会话类型为单聊助手时，userId和unionId二选一必填。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// 用户unionId；会话类型为单聊助手时，userId和unionId二选一必填。
    /// </summary>
    [JsonPropertyName("unoinId")]
    public string? UnionId { get; set; }

    /// <summary>
    /// 机器人编码；单聊助手时必填。
    /// </summary>
    public string? RobotCode { get; set; }
}
