using System.Text.Json.Serialization;
using DingTalkApiClient.Models;

namespace DingTalkApiClient.Models.IM.Chat;

/// <summary>
/// 创建场景群请求
/// </summary>
public class CreateSceneGroupRequest
{
    /// <summary>
    /// 群名称；最长不超过30字符，建议长度在10字符以内。
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// 群模板ID，登录开发者后台 &gt; 开放能力 &gt; 场景群 &gt; 群模板查看id。
    /// </summary>
    [JsonPropertyName("template_id")]
    public required string TemplateId { get; set; }

    /// <summary>
    /// 群主的userid。
    /// </summary>
    [JsonPropertyName("owner_user_id")]
    public required string OwnerUserId { get; set; }

    /// <summary>
    /// 群成员userid列表，最多传999个。
    /// </summary>
    [JsonPropertyName("user_ids")]
    public List<string>? UserIds { get; set; }

    /// <summary>
    /// 群管理员userid列表。
    /// </summary>
    [JsonPropertyName("subadmin_ids")]
    public List<string>? SubAdminIds { get; set; }

    /// <summary>
    /// 建群去重的业务ID，由接口调用方指定；建议长度在64字符以内。
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    /// <summary>
    /// 群头像，格式为mediaId；需要调用上传媒体文件接口上传群头像并获取mediaId。
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// @all 权限：0（默认）所有人都可以@all，1仅群主可@all。
    /// </summary>
    [JsonPropertyName("mention_all_authority")]
    public int? MentionAllAuthority { get; set; }

    /// <summary>
    /// 新成员是否可查看聊天历史消息：0（默认）不可以查看历史记录，1可以查看历史记录。
    /// </summary>
    [JsonPropertyName("show_history_type")]
    public int? ShowHistoryType { get; set; }

    /// <summary>
    /// 入群是否需要验证：0（默认）不验证入群，1入群验证。
    /// </summary>
    [JsonPropertyName("validation_type")]
    public int? ValidationType { get; set; }

    /// <summary>
    /// 群是否可搜索：0（默认）不可搜索，1可搜索。
    /// </summary>
    public int? Searchable { get; set; }

    /// <summary>
    /// 是否开启群禁言：0（默认）不禁言，1全员禁言。
    /// </summary>
    [JsonPropertyName("chat_banned_type")]
    public int? ChatBannedType { get; set; }

    /// <summary>
    /// 管理类型：0（默认）所有人可管理，1仅群主可管理。
    /// </summary>
    [JsonPropertyName("management_type")]
    public int? ManagementType { get; set; }

    /// <summary>
    /// 群内发DING权限：0（默认）所有人可发DING，1仅群主和管理员可发DING。
    /// </summary>
    [JsonPropertyName("only_admin_can_ding")]
    public int? OnlyAdminCanDing { get; set; }

    /// <summary>
    /// 群直播权限：0仅群主与管理员可发起直播，1（默认）群内任意成员可发起群直播。
    /// </summary>
    [JsonPropertyName("group_live_switch")]
    public int? GroupLiveSwitch { get; set; }
}

/// <summary>
/// 创建场景群响应
/// </summary>
public class CreateSceneGroupResponse : ChatBooleanResponse
{
    /// <summary>
    /// 场景群创建结果。
    /// </summary>
    public string? Result { get; set; }
}

/// <summary>
/// 更新场景群请求
/// </summary>
public class UpdateSceneGroupRequest
{
    /// <summary>
    /// 群ID；企业内部应用或第三方企业应用调用创建群接口获取open_conversation_id参数值。
    /// </summary>
    [JsonPropertyName("open_conversation_id")]
    public required string OpenConversationId { get; set; }

    /// <summary>
    /// 群名称；最长不超过30字符，建议长度在10字符以内。
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 群主的userId。
    /// </summary>
    [JsonPropertyName("owner_user_id")]
    public string? OwnerUserId { get; set; }

    /// <summary>
    /// 群头像，格式为mediaId；可通过上传媒体文件接口获取mediaId参数值。
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// @all 权限（非必填）：0（默认）所有人可@all，1仅群主可@all。
    /// </summary>
    [JsonPropertyName("mention_all_authority")]
    public int? MentionAllAuthority { get; set; }

    /// <summary>
    /// 新成员是否可查看聊天历史消息（非必填）：0（默认）不可以，1可以。
    /// </summary>
    [JsonPropertyName("show_history_type")]
    public int? ShowHistoryType { get; set; }

    /// <summary>
    /// 入群验证（非必填）：0（默认）不需要验证，1入群验证。
    /// </summary>
    [JsonPropertyName("validation_type")]
    public int? ValidationType { get; set; }

    /// <summary>
    /// 群是否可搜索（非必填）：0（默认）不可搜索，1可搜索。
    /// </summary>
    public int? Searchable { get; set; }

    /// <summary>
    /// 群是否开启禁言（非必填）：0（默认）不禁言，1全员禁言。
    /// </summary>
    [JsonPropertyName("chat_banned_type")]
    public int? ChatBannedType { get; set; }

    /// <summary>
    /// 管理类型（非必填）：0（默认）所有人可管理，1仅群主可管理。
    /// </summary>
    [JsonPropertyName("management_type")]
    public int? ManagementType { get; set; }
}

/// <summary>
/// 查询场景群请求
/// </summary>
public class GetSceneGroupRequest
{
    /// <summary>
    /// 群ID；企业内部应用或第三方企业应用调用创建群接口获取open_conversation_id参数值。
    /// </summary>
    [JsonPropertyName("open_conversation_id")]
    public required string OpenConversationId { get; set; }
}

/// <summary>
/// 查询场景群响应
/// </summary>
public class GetSceneGroupResponse : ChatBooleanResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    public SceneGroupInfo? Result { get; set; }
}

/// <summary>
/// 场景群详情
/// </summary>
public class SceneGroupInfo
{
    /// <summary>
    /// 群ID。
    /// </summary>
    [JsonPropertyName("open_conversation_id")]
    public string? OpenConversationId { get; set; }

    /// <summary>
    /// 群标题
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 群模板 ID
    /// </summary>
    [JsonPropertyName("template_id")]
    public string? TemplateId { get; set; }

    /// <summary>
    /// 群主的userId。
    /// </summary>
    [JsonPropertyName("owner_user_id")]
    public string? OwnerUserId { get; set; }

    /// <summary>
    /// 群成员 userId 列表
    /// </summary>
    [JsonPropertyName("user_ids")]
    public List<string> UserIds { get; set; } = [];
}

/// <summary>
/// 场景群成员变更请求
/// </summary>
public class SceneGroupMemberRequest
{
    /// <summary>
    /// 批量增加的成员userid；多个userid之间使用英文逗号分隔，最多传100个。
    /// </summary>
    [JsonPropertyName("user_ids")]
    public required List<string> UserIds { get; set; }

    /// <summary>
    /// 群ID；企业内部应用或第三方企业应用调用创建群接口获取open_conversation_id参数值。
    /// </summary>
    [JsonPropertyName("open_conversation_id")]
    public required string OpenConversationId { get; set; }
}

/// <summary>
/// 场景群模板请求
/// </summary>
public class SceneGroupTemplateRequest
{
    /// <summary>
    /// 群主的userid。
    /// </summary>
    [JsonPropertyName("owner_user_id")]
    public required string OwnerUserId { get; set; }

    /// <summary>
    /// 群ID；企业内部应用或第三方企业应用调用创建群接口获取open_conversation_id参数值。
    /// </summary>
    [JsonPropertyName("open_conversation_id")]
    public required string OpenConversationId { get; set; }

    /// <summary>
    /// 群模板id，登录开发者后台 &gt; 开放能力 &gt; 场景群 &gt; 群模板查看id。
    /// </summary>
    [JsonPropertyName("template_id")]
    public required string TemplateId { get; set; }
}

/// <summary>
/// 发送群助手消息请求
/// </summary>
public class SendSceneGroupMessageRequest
{
    /// <summary>
    /// 机器人编码，登录开发者后台 &gt; 开放能力 &gt; 场景群 &gt; 机器人查看id。
    /// </summary>
    [JsonPropertyName("robot_code")]
    public required string RobotCode { get; set; }

    /// <summary>
    /// 群ID；企业内部应用或第三方企业应用调用创建群接口获取open_conversation_id参数值。
    /// </summary>
    [JsonPropertyName("target_open_conversation_id")]
    public required string TargetOpenConversationId { get; set; }

    /// <summary>
    /// 消息模板ID，详情参见场景群通用消息模板。
    /// </summary>
    [JsonPropertyName("msg_template_id")]
    public required string MessageTemplateId { get; set; }

    /// <summary>
    /// 消息接收人unionId列表；不设置任何接收人则消息对群内所有成员可见。
    /// </summary>
    [JsonPropertyName("receiver_union_ids")]
    public List<string>? ReceiverUnionIds { get; set; }

    /// <summary>
    /// 消息接收人userId列表；不设置任何接收人则消息对群内所有成员可见。
    /// </summary>
    [JsonPropertyName("receiver_user_ids")]
    public List<string>? ReceiverUserIds { get; set; }

    /// <summary>
    /// 是否@所有人：true是，false否。
    /// </summary>
    [JsonPropertyName("is_at_all")]
    public bool? IsAtAll { get; set; }

    /// <summary>
    /// 消息模板内容替换参数，普通文本类型；取值为Json格式的字符串。
    /// </summary>
    [JsonPropertyName("msg_param_map")]
    public Dictionary<string, string>? MessageParamMap { get; set; }

    /// <summary>
    /// 消息模板内容替换参数，多媒体类型；取值为Json格式的字符串。
    /// </summary>
    [JsonPropertyName("msg_media_id_param_map")]
    public Dictionary<string, string>? MessageMediaIdParamMap { get; set; }
}

/// <summary>
/// 发送群助手消息响应
/// </summary>
public class SendSceneGroupMessageResponse : ChatBooleanResponse
{
    /// <summary>
    /// 开发消息ID。
    /// </summary>
    [JsonPropertyName("open_msg_id")]
    public string? OpenMessageId { get; set; }
}

/// <summary>
/// 注册互动卡片回调请求
/// </summary>
public class RegisterInteractiveCardCallbackRequest
{
    /// <summary>
    /// 回调URL地址；URL地址不支持携带参数。
    /// </summary>
    [JsonPropertyName("callback_url")]
    public required string CallbackUrl { get; set; }

    /// <summary>
    /// 加密密钥用于校验来源。
    /// </summary>
    [JsonPropertyName("api_secret")]
    public string? ApiSecret { get; set; }
}

/// <summary>
/// 注册互动卡片回调响应
/// </summary>
public class RegisterInteractiveCardCallbackResponse : ChatBooleanResponse
{
    /// <summary>
    /// 业务返回结果。
    /// </summary>
    public bool? Result { get; set; }
}
