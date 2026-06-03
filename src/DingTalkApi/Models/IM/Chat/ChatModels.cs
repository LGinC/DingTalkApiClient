using System.Text.Json.Serialization;
using DingTalkApi.Models;

namespace DingTalkApi.Models.IM.Chat;

/// <summary>
/// 创建群请求
/// </summary>
public class CreateChatRequest
{
    /// <summary>
    /// 群名称，长度限制为1~20个字符。
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 群主的userId，可通过根据手机号查询用户接口获取userid参数值；该员工必须为会话useridlist的成员之一。
    /// </summary>
    public required string Owner { get; set; }

    /// <summary>
    /// 群成员列表，每次最多支持40人，群人数上限为1000。
    /// </summary>
    public required List<string> Useridlist { get; set; }

    /// <summary>
    /// 新成员是否可查看100条历史消息：1可查看，0不可查看；如果不传值，代表不可查看。
    /// </summary>
    public int? ShowHistoryType { get; set; }

    /// <summary>
    /// 群是否可以被搜索：0（默认）不可搜索，1可搜索。
    /// </summary>
    public int? Searchable { get; set; }

    /// <summary>
    /// 入群是否需要验证：0（默认）不验证，1入群验证。
    /// </summary>
    public int? ValidationType { get; set; }

    /// <summary>
    /// @all 使用范围：0（默认）所有人可使用，1仅群主可@all。
    /// </summary>
    public int? MentionAllAuthority { get; set; }

    /// <summary>
    /// 群管理类型：0（默认）所有人可管理，1仅群主可管理。
    /// </summary>
    public int? ManagementType { get; set; }

    /// <summary>
    /// 是否开启群禁言：0（默认）不禁言，1全员禁言。
    /// </summary>
    public int? ChatBannedType { get; set; }
}

/// <summary>
/// 创建群响应
/// </summary>
public class CreateChatResponse : DingTalkResult
{
    /// <summary>
    /// 群会话的ID；后续版本中chatid将不再使用，请将openConversationId作为群会话唯一标识。
    /// </summary>
    [JsonPropertyName("chatid")]
    public string? ChatId { get; set; }

    /// <summary>
    /// 群会话的ID。
    /// </summary>
    public string? OpenConversationId { get; set; }

    /// <summary>
    /// 会话类型：2企业群。
    /// </summary>
    public int? ConversationTag { get; set; }
}

/// <summary>
/// 更新群请求
/// </summary>
public class UpdateChatRequest
{
    /// <summary>
    /// 群主的userId。
    /// </summary>
    public required string Owner { get; set; }

    /// <summary>
    /// 群主类型：emp企业员工，ext外部联系人。
    /// </summary>
    public required int OwnerType { get; set; }

    /// <summary>
    /// 群会话ID；仅支持通过调用服务端创建群接口获取的chatid参数值，不支持通过调用前端JSAPI获取的chatid。
    /// </summary>
    [JsonPropertyName("chatid")]
    public required string ChatId { get; set; }

    /// <summary>
    /// 添加的群成员列表，每次最多支持40人，群人数上限为1000；可通过根据手机号查询用户接口获取userId。
    /// </summary>
    [JsonPropertyName("add_useridlist")]
    public List<string>? AddUserIdList { get; set; }

    /// <summary>
    /// 删除的成员列表，可通过根据手机号查询用户接口获取userId。
    /// </summary>
    [JsonPropertyName("del_useridlist")]
    public List<string>? DeleteUserIdList { get; set; }

    /// <summary>
    /// 群名称，长度限制为1~20个字符。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 群头像的mediaId，可通过上传媒体文件接口获取media_id参数值。
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// 是否禁言：true禁言，false不禁言。
    /// </summary>
    public int? IsBan { get; set; }

    /// <summary>
    /// 新成员是否可查看100条历史消息：1可查看，0不可查看；如果不传值，代表不可查看。
    /// </summary>
    public int? ShowHistoryType { get; set; }

    /// <summary>
    /// 入群是否需要验证：0（默认）不验证，1入群验证。
    /// </summary>
    public int? ValidationType { get; set; }

    /// <summary>
    /// 群是否可以被搜索：0（默认）不可搜索，1可搜索。
    /// </summary>
    public int? Searchable { get; set; }

    /// <summary>
    /// 是否开启群禁言：0（默认）不禁言，1全员禁言。
    /// </summary>
    public int? ChatBannedType { get; set; }

    /// <summary>
    /// 群管理类型：0（默认）所有人可管理，1仅群主可管理。
    /// </summary>
    public int? ManagementType { get; set; }

    /// <summary>
    /// @all 使用范围：0（默认）所有人可使用，1仅群主可@all。
    /// </summary>
    public int? MentionAllAuthority { get; set; }
}

/// <summary>
/// 查询群请求
/// </summary>
public class GetChatRequest
{
    /// <summary>
    /// 群会话ID。
    /// </summary>
    [JsonPropertyName("chatid")]
    public required string ChatId { get; set; }
}

/// <summary>
/// 查询群响应
/// </summary>
public class GetChatResponse : DingTalkResult
{
    /// <summary>
    /// 群会话信息。
    /// </summary>
    [JsonPropertyName("chat_info")]
    public ChatInfo? ChatInfo { get; set; }
}

/// <summary>
/// 群信息
/// </summary>
public class ChatInfo
{
    /// <summary>
    /// 群会话ID。
    /// </summary>
    [JsonPropertyName("chatid")]
    public string? ChatId { get; set; }

    /// <summary>
    /// 群会话的ID。
    /// </summary>
    public string? OpenConversationId { get; set; }

    /// <summary>
    /// 群名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 群主的userId。
    /// </summary>
    public string? Owner { get; set; }

    /// <summary>
    /// 群成员 userId 列表
    /// </summary>
    [JsonPropertyName("useridlist")]
    public List<string> UserIdList { get; set; } = [];
}

/// <summary>
/// 通用布尔响应
/// </summary>
public class ChatBooleanResponse : DingTalkResult
{
    /// <summary>
    /// 操作是否成功：true成功，false失败。
    /// </summary>
    public bool? Success { get; set; }
}

/// <summary>
/// 更新群成员昵称请求
/// </summary>
public class UpdateGroupNickRequest
{
    /// <summary>
    /// 群会话ID，可通过创建群会话接口获取chatid参数值。
    /// </summary>
    [JsonPropertyName("chatid")]
    public required string ChatId { get; set; }

    /// <summary>
    /// 要更改群昵称的群成员userId，可通过获取群会话信息接口获取群成员userId。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string UserId { get; set; }

    /// <summary>
    /// 该成员在群中的昵称。
    /// </summary>
    [JsonPropertyName("group_nick")]
    public required string GroupNick { get; set; }
}

/// <summary>
/// 更新群管理员请求
/// </summary>
public class UpdateChatSubAdminRequest
{
    /// <summary>
    /// 2添加为管理员，3删除该管理员。
    /// </summary>
    public required int Role { get; set; }

    /// <summary>
    /// 群会话ID，可通过创建群接口获取chatid参数值。
    /// </summary>
    [JsonPropertyName("chatid")]
    public required string ChatId { get; set; }

    /// <summary>
    /// 群成员userId，可通过根据手机号查询用户接口获取userId参数值。
    /// </summary>
    [JsonPropertyName("userids")]
    public required List<string> UserIds { get; set; }
}

/// <summary>
/// 设置禁止群成员私聊请求
/// </summary>
public class UpdateMemberFriendSwitchRequest
{
    /// <summary>
    /// 企业会话ID，可通过创建群接口或客户端选择会话能力获取chatId参数值。
    /// </summary>
    [JsonPropertyName("chatid")]
    public required string ChatId { get; set; }

    /// <summary>
    /// 是否开启禁止开关：true开启禁止开关，false关闭禁止开关。
    /// </summary>
    [JsonPropertyName("is_prohibit")]
    public required bool IsProhibit { get; set; }
}

/// <summary>
/// 获取入群二维码请求
/// </summary>
public class GetChatQrCodeRequest
{
    /// <summary>
    /// 群会话的chatid，可调用创建群接口获取chatid参数值。
    /// </summary>
    [JsonPropertyName("chatid")]
    public required string ChatId { get; set; }

    /// <summary>
    /// 分享二维码用户的userId。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string UserId { get; set; }
}

/// <summary>
/// 获取入群二维码响应
/// </summary>
public class GetChatQrCodeResponse : ChatBooleanResponse
{
    /// <summary>
    /// 返回入群的链接。
    /// </summary>
    public string? Result { get; set; }
}
