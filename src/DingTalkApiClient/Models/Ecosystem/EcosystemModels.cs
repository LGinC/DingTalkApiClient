using System.Text.Json;
using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models.Ecosystem;

/// <summary>
/// PostV1CustomerServiceTicketsRequestPropertiesItem
/// </summary>
public class PostV1CustomerServiceTicketsRequestPropertiesItem
{
    /// <summary>
    /// 字段的key。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 字段的值。
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// 创建自助单请求
/// </summary>
public class PostV1CustomerServiceTicketsRequest
{
    /// <summary>
    /// 会员来源，取diamond配置的值。
    /// </summary>
    [JsonPropertyName("sourceId")]
    public required string SourceId { get; set; }

    /// <summary>
    /// 第三方会员ID。
    /// </summary>
    [JsonPropertyName("foreignId")]
    public required string ForeignId { get; set; }

    /// <summary>
    /// 第三方会员名称。
    /// </summary>
    [JsonPropertyName("foreignName")]
    public required string ForeignName { get; set; }

    /// <summary>
    /// 实例ID。 单实例企业必须传default，多实例企业必须传实例ID。
    /// </summary>
    [JsonPropertyName("openInstanceId")]
    public string? OpenInstanceId { get; set; }

    /// <summary>
    /// 智能客服产品类型：
    /// </summary>
    [JsonPropertyName("productionType")]
    public long? ProductionType { get; set; }

    /// <summary>
    /// 自助单ID，钉钉智能客服自助单配置里的值。
    /// </summary>
    [JsonPropertyName("templateId")]
    public required string TemplateId { get; set; }

    /// <summary>
    /// 工单标题。
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    /// <summary>
    /// 工单表单。
    /// </summary>
    [JsonPropertyName("properties")]
    public List<PostV1CustomerServiceTicketsRequestPropertiesItem> Properties { get; set; } = [];
}

/// <summary>
/// 创建自助单响应
/// </summary>
public class PostV1CustomerServiceTicketsResponse
{
    /// <summary>
    /// 新创建的工单ID。
    /// </summary>
    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}

/// <summary>
/// GetV1CustomerServiceTicketsResponseListItem
/// </summary>
public class GetV1CustomerServiceTicketsResponseListItem
{
    /// <summary>
    /// 第三方会员。 如果系统中不存在需要在CRM中新建。
    /// </summary>
    [JsonPropertyName("foreignId")]
    public string? ForeignId { get; set; }

    /// <summary>
    /// 第三方来源。
    /// </summary>
    [JsonPropertyName("sourceId")]
    public string? SourceId { get; set; }

    /// <summary>
    /// 第三方会员名。
    /// </summary>
    [JsonPropertyName("foreignName")]
    public string? ForeignName { get; set; }

    /// <summary>
    /// 工单模板ID。
    /// </summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }

    /// <summary>
    /// 工单标题。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 工单ID。
    /// </summary>
    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }

    /// <summary>
    /// 工单状态。 在钉钉工单类型配置里的工单状态机里自主配置。
    /// </summary>
    [JsonPropertyName("ticketStatus")]
    public string? TicketStatus { get; set; }

    /// <summary>
    /// 实例ID。
    /// </summary>
    [JsonPropertyName("openInstanceId")]
    public string? OpenInstanceId { get; set; }

    /// <summary>
    /// 智能客服产品类型：
    /// </summary>
    [JsonPropertyName("productionType")]
    public long? ProductionType { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    [JsonPropertyName("gmtCreate")]
    public string? GmtCreate { get; set; }

    /// <summary>
    /// 最新修改时间。
    /// </summary>
    [JsonPropertyName("gmtModified")]
    public string? GmtModified { get; set; }

    /// <summary>
    /// 工单自定义业务字段信息。
    /// </summary>
    [JsonPropertyName("bizDataMap")]
    public JsonElement? BizDataMap { get; set; }
}

/// <summary>
/// 分页查询工单响应
/// </summary>
public class GetV1CustomerServiceTicketsResponse
{
    /// <summary>
    /// 是否还有下一页数据。
    /// </summary>
    [JsonPropertyName("nextCursor")]
    public long? NextCursor { get; set; }

    /// <summary>
    /// 总记录数。
    /// </summary>
    [JsonPropertyName("total")]
    public long? Total { get; set; }

    /// <summary>
    /// 查询结果。
    /// </summary>
    [JsonPropertyName("list")]
    public List<GetV1CustomerServiceTicketsResponseListItem> List { get; set; } = [];
}

/// <summary>
/// PutV1CustomerServiceTicketsTicketIdRequestPropertiesItem
/// </summary>
public class PutV1CustomerServiceTicketsTicketIdRequestPropertiesItem
{
    /// <summary>
    /// 字段的key。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 字段的值。
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// 执行工单活动请求
/// </summary>
public class PutV1CustomerServiceTicketsTicketIdRequest
{
    /// <summary>
    /// 会员来源，取diamond配置的值。
    /// </summary>
    [JsonPropertyName("sourceId")]
    public required string SourceId { get; set; }

    /// <summary>
    /// 会员ID。
    /// </summary>
    [JsonPropertyName("foreignId")]
    public required string ForeignId { get; set; }

    /// <summary>
    /// 会员名称。
    /// </summary>
    [JsonPropertyName("foreignName")]
    public required string ForeignName { get; set; }

    /// <summary>
    /// 动作编码。
    /// </summary>
    [JsonPropertyName("activityCode")]
    public required string ActivityCode { get; set; }

    /// <summary>
    /// 实例ID。
    /// </summary>
    [JsonPropertyName("openInstanceId")]
    public string? OpenInstanceId { get; set; }

    /// <summary>
    /// 智能客服产品类型：
    /// </summary>
    [JsonPropertyName("productionType")]
    public long? ProductionType { get; set; }

    /// <summary>
    /// 工单表单字段。
    /// </summary>
    [JsonPropertyName("properties")]
    public List<PutV1CustomerServiceTicketsTicketIdRequestPropertiesItem> Properties { get; set; } = [];
}

/// <summary>
/// 执行工单活动响应
/// </summary>
public class PutV1CustomerServiceTicketsTicketIdResponse
{
    /// <summary>
    /// 任务ID。
    /// </summary>
    [JsonPropertyName("taskId")]
    public string? TaskId { get; set; }
}

/// <summary>
/// GetV1CustomerServiceTicketsTicketIdActionsResponseListItemActionContentItem
/// </summary>
public class GetV1CustomerServiceTicketsTicketIdActionsResponseListItemActionContentItem
{
    /// <summary>
    /// 标签的值。
    /// </summary>
    [JsonPropertyName("displayValue")]
    public string? DisplayValue { get; set; }

    /// <summary>
    /// 字段的展示名称。
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// 字段的key。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 字段的值。
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    /// 字段的类型：
    /// </summary>
    [JsonPropertyName("valueType")]
    public string? ValueType { get; set; }
}

/// <summary>
/// GetV1CustomerServiceTicketsTicketIdActionsResponseListItem
/// </summary>
public class GetV1CustomerServiceTicketsTicketIdActionsResponseListItem
{
    /// <summary>
    /// 操作人的userid。
    /// </summary>
    [JsonPropertyName("operatorId")]
    public string? OperatorId { get; set; }

    /// <summary>
    /// 操作人。
    /// </summary>
    [JsonPropertyName("operator")]
    public string? OperatorValue { get; set; }

    /// <summary>
    /// 操作人角色。
    /// </summary>
    [JsonPropertyName("operatorRole")]
    public string? OperatorRole { get; set; }

    /// <summary>
    /// 动作code。
    /// </summary>
    [JsonPropertyName("actionCode")]
    public string? ActionCode { get; set; }

    /// <summary>
    /// 操作记录。
    /// </summary>
    [JsonPropertyName("actionContent")]
    public List<GetV1CustomerServiceTicketsTicketIdActionsResponseListItemActionContentItem> ActionContent { get; set; } = [];
}

/// <summary>
/// 查询动作记录响应
/// </summary>
public class GetV1CustomerServiceTicketsTicketIdActionsResponse
{
    /// <summary>
    /// 是否还有下一页数据，当返回结果里没有nextCursor时，表示分页结束。
    /// </summary>
    [JsonPropertyName("nextCursor")]
    public long? NextCursor { get; set; }

    /// <summary>
    /// 总记录数。
    /// </summary>
    [JsonPropertyName("total")]
    public long? Total { get; set; }

    /// <summary>
    /// 查询列表。
    /// </summary>
    [JsonPropertyName("list")]
    public List<GetV1CustomerServiceTicketsTicketIdActionsResponseListItem> List { get; set; } = [];
}

/// <summary>
/// 智能问答请求
/// </summary>
public class PostV1DingMiRobotsAskRequest
{
    /// <summary>
    /// 问题内容。
    /// </summary>
    [JsonPropertyName("question")]
    public required string Question { get; set; }

    /// <summary>
    /// 机器人唯一标识。
    /// </summary>
    [JsonPropertyName("robotAppKey")]
    public required string RobotAppKey { get; set; }

    /// <summary>
    /// 会话ID。
    /// </summary>
    [JsonPropertyName("sessionUuid")]
    public string? SessionUuid { get; set; }

    /// <summary>
    /// 钉钉用户的userid。
    /// </summary>
    [JsonPropertyName("dingUserId")]
    public string? DingUserId { get; set; }
}

/// <summary>
/// 智能问答响应
/// </summary>
public class PostV1DingMiRobotsAskResponse
{
    /// <summary>
    /// 回复的答案，需将示例值转成json。
    /// </summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }
}

/// <summary>
/// 获取用户登录凭证请求
/// </summary>
public class PostV1DingMiWebChannelsUserTokensRequest
{
    /// <summary>
    /// 调用方在小蜜客服平台申请的业务账号体系的id。
    /// </summary>
    [JsonPropertyName("source")]
    public long Source { get; set; }

    /// <summary>
    /// 登录用户在业务账号体系内的昵称。
    /// </summary>
    [JsonPropertyName("nick")]
    public required string Nick { get; set; }

    /// <summary>
    /// 登录用户在业务账号体系内的用户id。
    /// </summary>
    [JsonPropertyName("foreignId")]
    public required string ForeignId { get; set; }
}

/// <summary>
/// 获取用户登录凭证响应
/// </summary>
public class PostV1DingMiWebChannelsUserTokensResponse
{
    /// <summary>
    /// token值，用于小蜜客服提供的网页渠道中接入三方业务系统获取自己的用户登录状态。
    /// </summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }
}

/// <summary>
/// 推送小蜜机器人单聊O2O消息请求
/// </summary>
public class PostV1DingMiRobotsOToMessagesSendRequest
{
    /// <summary>
    /// 机器人标识，由小蜜客服平台提供。
    /// </summary>
    [JsonPropertyName("chatbotId")]
    public required string ChatbotId { get; set; }

    /// <summary>
    /// 用户的userid。
    /// </summary>
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }

    /// <summary>
    /// 消息类型，详情可参考消息类型说明。
    /// </summary>
    [JsonPropertyName("msgKey")]
    public required string MsgKey { get; set; }

    /// <summary>
    /// 消息内容。 需要做base64处理。
    /// </summary>
    [JsonPropertyName("msgParam")]
    public required string MsgParam { get; set; }
}

/// <summary>
/// 推送小蜜机器人单聊O2O消息响应
/// </summary>
public class PostV1DingMiRobotsOToMessagesSendResponse
{
    /// <summary>
    /// 推送queryKey。
    /// </summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }
}

/// <summary>
/// 小蜜客服机器人消息回复请求
/// </summary>
public class PostV1DingMiRobotsReplyRequest
{
    /// <summary>
    /// 回复消息内容的内容。
    /// </summary>
    [JsonPropertyName("proxyMessageStr")]
    public required string ProxyMessageStr { get; set; }
}

/// <summary>
/// 小蜜客服机器人消息回复响应
/// </summary>
public class PostV1DingMiRobotsReplyResponse
{
    /// <summary>
    /// 回复是否成功。
    /// </summary>
    [JsonPropertyName("result")]
    public bool? Result { get; set; }
}

/// <summary>
/// 查询机器人基础指标数据请求
/// </summary>
public class GetV1DingMiRobotsDataRequest
{
}

/// <summary>
/// 查询机器人基础指标数据响应
/// </summary>
public class GetV1DingMiRobotsDataResponse
{
    /// <summary>
    /// 是否缓存。
    /// </summary>
    [JsonPropertyName("fromCache")]
    public bool? FromCache { get; set; }

    /// <summary>
    /// 运行时间。
    /// </summary>
    [JsonPropertyName("runtime")]
    public long? Runtime { get; set; }

    /// <summary>
    /// 指标集合。
    /// </summary>
    [JsonPropertyName("rawset")]
    public List<JsonElement> Rawset { get; set; } = [];

    /// <summary>
    /// 字段解释。
    /// </summary>
    [JsonPropertyName("tips")]
    public JsonElement? Tips { get; set; }
}

/// <summary>
/// 钉钉文本翻译请求
/// </summary>
public class PostTopapiAiMtTranslateRequest
{
    /// <summary>
    /// 翻译源文字符串。
    /// </summary>
    [JsonPropertyName("query")]
    public required string Query { get; set; }

    /// <summary>
    /// 翻译源语言类型。
    /// </summary>
    [JsonPropertyName("source_language")]
    public required string SourceLanguage { get; set; }

    /// <summary>
    /// 翻译目标语言类型。
    /// </summary>
    [JsonPropertyName("target_language")]
    public required string TargetLanguage { get; set; }
}

/// <summary>
/// 钉钉文本翻译响应
/// </summary>
public class PostTopapiAiMtTranslateResponse
{
    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public long Errcode { get; set; }

    /// <summary>
    /// 翻译结果字符串。
    /// </summary>
    [JsonPropertyName("result")]
    public required string Result { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; set; }
}

/// <summary>
/// OCR文字识别请求
/// </summary>
public class PostTopapiOcrStructuredRecognizeRequest
{
    /// <summary>
    /// 识别图片地址，最大长度1000。
    /// </summary>
    [JsonPropertyName("image_url")]
    public required string ImageUrl { get; set; }

    /// <summary>
    /// 识别图片类型。 idcard：身份证 invoice：营业执照增值税发票 blicense：营业执照 bank_card：银行卡 car_no：车牌 car_invoice：机动车发票 driving_license：驾驶证 vehicle_license：行驶证 train_ticket：火车票 quota_invoice：定额发票 taxi_tic...
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// 识别结果。
/// </summary>
public class PostTopapiOcrStructuredRecognizeResponseResult
{
    /// <summary>
    /// 原始图片宽度。
    /// </summary>
    [JsonPropertyName("original_width")]
    public required string OriginalWidth { get; set; }

    /// <summary>
    /// 图片识别内容json字符串，不同的类型有不同的字段。 例如，身份证{"姓名":"王xx","性别":"男","民族":"汉","出生日期":"1986年1月9日","住址":"四川省攀枝xxxx","身份证号码":"5101241988xxxxx"}。
    /// </summary>
    [JsonPropertyName("data")]
    public required string Data { get; set; }

    /// <summary>
    /// 旋转后图片宽度。
    /// </summary>
    [JsonPropertyName("width")]
    public required string Width { get; set; }

    /// <summary>
    /// 旋转度。
    /// </summary>
    [JsonPropertyName("angle")]
    public required string Angle { get; set; }

    /// <summary>
    /// 原始图片高度。
    /// </summary>
    [JsonPropertyName("original_height")]
    public required string OriginalHeight { get; set; }

    /// <summary>
    /// 旋转后图片高度。
    /// </summary>
    [JsonPropertyName("height")]
    public required string Height { get; set; }
}

/// <summary>
/// OCR文字识别响应
/// </summary>
public class PostTopapiOcrStructuredRecognizeResponse
{
    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public required string Errcode { get; set; }

    /// <summary>
    /// 识别结果。
    /// </summary>
    [JsonPropertyName("result")]
    public required PostTopapiOcrStructuredRecognizeResponseResult Result { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public required string Errmsg { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; set; }
}

/// <summary>
/// ASR 一句话语音识别请求
/// </summary>
public class PostTopapiAsrVoiceTranslateRequest
{
    /// <summary>
    /// 音频的mediaId。 企业内部应用，调用上传媒体文件接口获取media_id参数值。 第三方企业应用，调用上传媒体文件接口获取media_id参数值。 重要 目前只接受 ogg 或 amr 格式的音频。
    /// </summary>
    [JsonPropertyName("media_id")]
    public required string MediaId { get; set; }
}

/// <summary>
/// ASR 一句话语音识别响应
/// </summary>
public class PostTopapiAsrVoiceTranslateResponse
{
    /// <summary>
    /// 返回码。 如果返回44001，请检查 media_id 对应的文件是否为音频格式，或请重新上传音频文件再次请求。
    /// </summary>
    [JsonPropertyName("errcode")]
    public long Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public required string Errmsg { get; set; }

    /// <summary>
    /// 调用结果。
    /// </summary>
    [JsonPropertyName("result")]
    public required string Result { get; set; }
}

/// <summary>
/// 文本消息。
/// </summary>
public class PostTopapiSmartbotMsgPushRequestMsgText
{
    /// <summary>
    /// 文本消息内容，建议500字符以内。
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }
}

/// <summary>
/// markdown消息。
/// </summary>
public class PostTopapiSmartbotMsgPushRequestMsgMarkdown
{
    /// <summary>
    /// markdown格式的消息，建议500字符以内。
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>
    /// 首屏会话透出的展示内容。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// PostTopapiSmartbotMsgPushRequestMsgActionCardBtnJsonListItem
/// </summary>
public class PostTopapiSmartbotMsgPushRequestMsgActionCardBtnJsonListItem
{
    /// <summary>
    /// 使用独立跳转ActionCard样式时的跳转链接，最长500个字符。
    /// </summary>
    [JsonPropertyName("action_url")]
    public string? ActionUrl { get; set; }

    /// <summary>
    /// 使用独立跳转ActionCard样式时的按钮的标题，最长20个字符。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// 卡片消息。
/// </summary>
public class PostTopapiSmartbotMsgPushRequestMsgActionCard
{
    /// <summary>
    /// 使用独立跳转ActionCard样式时的按钮列表，必须与btn_orientation同时设置，且长度不超过1000字符。如果是独立跳转的ActionCard样式，则btn_json_list和btn_orientation必须设置。
    /// </summary>
    [JsonPropertyName("btn_json_list")]
    public List<PostTopapiSmartbotMsgPushRequestMsgActionCardBtnJsonListItem> BtnJsonList { get; set; } = [];

    /// <summary>
    /// 使用独立跳转ActionCard样式时的按钮排列方式。0：竖直排列1：横向排列必须与btn_json_list同时设置。
    /// </summary>
    [JsonPropertyName("btn_orientation")]
    public string? BtnOrientation { get; set; }

    /// <summary>
    /// 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接，最长500个字符。消息链接跳转，请参考消息链接说明。
    /// </summary>
    [JsonPropertyName("single_url")]
    public string? SingleUrl { get; set; }

    /// <summary>
    /// 使用整体跳转ActionCard样式时的标题。必须与single_url同时设置，最长20个字符。如果是整体跳转的ActionCard样式，则single_title和single_url必须设置。
    /// </summary>
    [JsonPropertyName("single_title")]
    public string? SingleTitle { get; set; }

    /// <summary>
    /// 消息内容，支持markdown，语法参考标准markdown语法。建议1000个字符以内。
    /// </summary>
    [JsonPropertyName("markdown")]
    public string? Markdown { get; set; }

    /// <summary>
    /// 透出到会话列表和通知的文案，最长64个字符
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// 消息内容，最长不超过2048个字节。消息类型和样例参考消息类型与数据格式。
/// </summary>
public class PostTopapiSmartbotMsgPushRequestMsg
{
    /// <summary>
    /// 消息类型，支持如下消息类型。text：文本消息。markdown：Markdown消息。action_card：卡片消息。
    /// </summary>
    [JsonPropertyName("msgtype")]
    public required string Msgtype { get; set; }

    /// <summary>
    /// 文本消息。
    /// </summary>
    [JsonPropertyName("text")]
    public PostTopapiSmartbotMsgPushRequestMsgText? Text { get; set; }

    /// <summary>
    /// markdown消息。
    /// </summary>
    [JsonPropertyName("markdown")]
    public PostTopapiSmartbotMsgPushRequestMsgMarkdown? Markdown { get; set; }

    /// <summary>
    /// 卡片消息。
    /// </summary>
    [JsonPropertyName("action_card")]
    public PostTopapiSmartbotMsgPushRequestMsgActionCard? ActionCard { get; set; }
}

/// <summary>
/// 使用服务助手推送消息请求
/// </summary>
public class PostTopapiSmartbotMsgPushRequest
{
    /// <summary>
    /// 消息内容，最长不超过2048个字节。消息类型和样例参考消息类型与数据格式。
    /// </summary>
    [JsonPropertyName("msg")]
    public required PostTopapiSmartbotMsgPushRequestMsg Msg { get; set; }

    /// <summary>
    /// 接收者的userid列表，最大用户列表长度100。
    /// </summary>
    [JsonPropertyName("user_id_list")]
    public string? UserIdList { get; set; }

    /// <summary>
    /// 接收者的会话chatid列表，最大会话列表长度10。
    /// </summary>
    [JsonPropertyName("chat_id_list")]
    public string? ChatIdList { get; set; }

    /// <summary>
    /// 是否发送给企业全部用户。当设置为false时必须指定userid_list或chat_id_list其中一个参数的值。
    /// </summary>
    [JsonPropertyName("to_all_user")]
    public bool? ToAllUser { get; set; }
}

/// <summary>
/// 使用服务助手推送消息响应
/// </summary>
public class PostTopapiSmartbotMsgPushResponse
{
    /// <summary>
    /// 创建的异步发送任务id
    /// </summary>
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripFlightCitySuggestRequestRq
{
    /// <summary>
    /// 搜索关键字。
    /// </summary>
    [JsonPropertyName("keyword")]
    public required string Keyword { get; set; }

    /// <summary>
    /// 用户的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }

    /// <summary>
    /// 机场城市类型：0：国内机场2：国内机场+临近机场3：国际机场
    /// </summary>
    [JsonPropertyName("type")]
    public decimal? Type { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }
}

/// <summary>
/// 机票城市搜索请求
/// </summary>
public class PostTopapiAliTripBTripFlightCitySuggestRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("rq")]
    public required PostTopapiAliTripBTripFlightCitySuggestRequestRq Rq { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripFlightCitySuggestResponseResultCitiesItem
/// </summary>
public class PostTopapiAliTripBTripFlightCitySuggestResponseResultCitiesItem
{
    /// <summary>
    /// 三字码。
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// 城市名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 与搜索城市距离，单位千米，只在邻近机场推荐有值。
    /// </summary>
    [JsonPropertyName("distance")]
    public decimal? Distance { get; set; }

    /// <summary>
    /// 邻近机场城市，只在邻近机场推荐有值。
    /// </summary>
    [JsonPropertyName("travel_name")]
    public string? TravelName { get; set; }
}

/// <summary>
/// 返回结果。
/// </summary>
public class PostTopapiAliTripBTripFlightCitySuggestResponseResult
{
    /// <summary>
    /// 城市列表。
    /// </summary>
    [JsonPropertyName("cities")]
    public List<PostTopapiAliTripBTripFlightCitySuggestResponseResultCitiesItem> Cities { get; set; } = [];

    /// <summary>
    /// 是否为邻近城市。
    /// </summary>
    [JsonPropertyName("nearby")]
    public bool? Nearby { get; set; }
}

/// <summary>
/// 机票城市搜索响应
/// </summary>
public class PostTopapiAliTripBTripFlightCitySuggestResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    [JsonPropertyName("result")]
    public PostTopapiAliTripBTripFlightCitySuggestResponseResult? Result { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 成功标识。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripTrainCitySuggestRequestRq
{
    /// <summary>
    /// 搜索关键字。
    /// </summary>
    [JsonPropertyName("keyword")]
    public required string Keyword { get; set; }

    /// <summary>
    /// 用户ID。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }

    /// <summary>
    /// 企业ID。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }
}

/// <summary>
/// 火车票城市搜索请求
/// </summary>
public class PostTopapiAliTripBTripTrainCitySuggestRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("rq")]
    public required PostTopapiAliTripBTripTrainCitySuggestRequestRq Rq { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripTrainCitySuggestResponseResultCitiesItem
/// </summary>
public class PostTopapiAliTripBTripTrainCitySuggestResponseResultCitiesItem
{
    /// <summary>
    /// 城市名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 城市码。
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>
/// 结果对象。
/// </summary>
public class PostTopapiAliTripBTripTrainCitySuggestResponseResult
{
    /// <summary>
    /// 城市列表。
    /// </summary>
    [JsonPropertyName("cities")]
    public List<PostTopapiAliTripBTripTrainCitySuggestResponseResultCitiesItem> Cities { get; set; } = [];
}

/// <summary>
/// 火车票城市搜索响应
/// </summary>
public class PostTopapiAliTripBTripTrainCitySuggestResponse
{
    /// <summary>
    /// 结果对象。
    /// </summary>
    [JsonPropertyName("result")]
    public PostTopapiAliTripBTripTrainCitySuggestResponseResult? Result { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 成功标识。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripCostCenterNewRequestRq
{
    /// <summary>
    /// 绑定支付宝账号。
    /// </summary>
    [JsonPropertyName("alipay_no")]
    public string? AlipayNo { get; set; }

    /// <summary>
    /// 成本中心名称。
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    /// <summary>
    /// 适用范围：1：全员2：部分人员
    /// </summary>
    [JsonPropertyName("scope")]
    public decimal Scope { get; set; }

    /// <summary>
    /// 第三方成本中心ID。
    /// </summary>
    [JsonPropertyName("thirdpart_id")]
    public required string ThirdpartId { get; set; }

    /// <summary>
    /// 第三方成本中心编号。
    /// </summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }
}

/// <summary>
/// 新建成本中心请求
/// </summary>
public class PostTopapiAliTripBTripCostCenterNewRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("rq")]
    public required PostTopapiAliTripBTripCostCenterNewRequestRq Rq { get; set; }
}

/// <summary>
/// 操作结果。
/// </summary>
public class PostTopapiAliTripBTripCostCenterNewResponseResult
{
    /// <summary>
    /// 商旅横版中心ID。
    /// </summary>
    [JsonPropertyName("id")]
    public decimal? Id { get; set; }
}

/// <summary>
/// 新建成本中心响应
/// </summary>
public class PostTopapiAliTripBTripCostCenterNewResponse
{
    /// <summary>
    /// 操作结果。
    /// </summary>
    [JsonPropertyName("result")]
    public PostTopapiAliTripBTripCostCenterNewResponseResult? Result { get; set; }

    /// <summary>
    /// 成功标识。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripCostCenterModifyRequestRq
{
    /// <summary>
    /// 绑定支付宝账号。
    /// </summary>
    [JsonPropertyName("alipay_no")]
    public string? AlipayNo { get; set; }

    /// <summary>
    /// 成本中心名称。
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    /// <summary>
    /// 适用范围：1：全员2：部分员工
    /// </summary>
    [JsonPropertyName("scope")]
    public decimal Scope { get; set; }

    /// <summary>
    /// 第三方成本中心id。
    /// </summary>
    [JsonPropertyName("thirdpart_id")]
    public required string ThirdpartId { get; set; }

    /// <summary>
    /// 成本中心编号。
    /// </summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }
}

/// <summary>
/// 修改成本中心请求
/// </summary>
public class PostTopapiAliTripBTripCostCenterModifyRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("rq")]
    public required PostTopapiAliTripBTripCostCenterModifyRequestRq Rq { get; set; }
}

/// <summary>
/// 修改成本中心响应
/// </summary>
public class PostTopapiAliTripBTripCostCenterModifyResponse
{
    /// <summary>
    /// 调用是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripCostCenterDeleteRequestRq
{
    /// <summary>
    /// 第三方成本中心id。
    /// </summary>
    [JsonPropertyName("thirdpart_id")]
    public string? ThirdpartId { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public string? Corpid { get; set; }
}

/// <summary>
/// 删除成本中心请求
/// </summary>
public class PostTopapiAliTripBTripCostCenterDeleteRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("rq")]
    public required PostTopapiAliTripBTripCostCenterDeleteRequestRq Rq { get; set; }
}

/// <summary>
/// 删除成本中心响应
/// </summary>
public class PostTopapiAliTripBTripCostCenterDeleteResponse
{
    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 调用是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripCostCenterQueryRequestRq
{
    /// <summary>
    /// 成本中心名称。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 第三方成本中心ID，不填写的时候userid必填。
    /// </summary>
    [JsonPropertyName("thirdpart_id")]
    public string? ThirdpartId { get; set; }

    /// <summary>
    /// 用户的userid，不填的时候thirdpart_id必填。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 是否需要展示成员信息，当成本中心为部分人员适用的时候有返回。
    /// </summary>
    [JsonPropertyName("need_org_entity")]
    public bool? NeedOrgEntity { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }
}

/// <summary>
/// 查询成本中心请求
/// </summary>
public class PostTopapiAliTripBTripCostCenterQueryRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("rq")]
    public required PostTopapiAliTripBTripCostCenterQueryRequestRq Rq { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripCostCenterQueryResponseCostCenterListItemEntityListItem
/// </summary>
public class PostTopapiAliTripBTripCostCenterQueryResponseCostCenterListItemEntityListItem
{
    /// <summary>
    /// 人员类型：1：用户2：部门3：角色
    /// </summary>
    [JsonPropertyName("entity_type")]
    public string? EntityType { get; set; }

    /// <summary>
    /// 用户/部门/角色ID。
    /// </summary>
    [JsonPropertyName("entity_id")]
    public string? EntityId { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public string? Corpid { get; set; }

    /// <summary>
    /// 用户/部门/角色名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 角色/部门下面员工人数。
    /// </summary>
    [JsonPropertyName("user_num")]
    public decimal? UserNum { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripCostCenterQueryResponseCostCenterListItem
/// </summary>
public class PostTopapiAliTripBTripCostCenterQueryResponseCostCenterListItem
{
    /// <summary>
    /// 商旅成本中心ID。
    /// </summary>
    [JsonPropertyName("id")]
    public decimal? Id { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public string? Corpid { get; set; }

    /// <summary>
    /// 成本中心名称。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 成本中心编号。
    /// </summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>
    /// 第三方成本中心ID。
    /// </summary>
    [JsonPropertyName("thirdpart_id")]
    public string? ThirdpartId { get; set; }

    /// <summary>
    /// 适用范围：1：全员2：部分员工
    /// </summary>
    [JsonPropertyName("scope")]
    public decimal? Scope { get; set; }

    /// <summary>
    /// 绑定支付宝账号。
    /// </summary>
    [JsonPropertyName("alipay_no")]
    public string? AlipayNo { get; set; }

    /// <summary>
    /// 绑定人员信息。
    /// </summary>
    [JsonPropertyName("entity_list")]
    public List<PostTopapiAliTripBTripCostCenterQueryResponseCostCenterListItemEntityListItem> EntityList { get; set; } = [];
}

/// <summary>
/// 查询成本中心响应
/// </summary>
public class PostTopapiAliTripBTripCostCenterQueryResponse
{
    /// <summary>
    /// 调用是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 成本中心列表。
    /// </summary>
    [JsonPropertyName("cost_center_list")]
    public List<PostTopapiAliTripBTripCostCenterQueryResponseCostCenterListItem> CostCenterList { get; set; } = [];
}

/// <summary>
/// PostTopapiAliTripBTripCostCenterEntitySetRequestRqEntityListItem
/// </summary>
public class PostTopapiAliTripBTripCostCenterEntitySetRequestRqEntityListItem
{
    /// <summary>
    /// 员工/部门/角色id。
    /// </summary>
    [JsonPropertyName("entity_id")]
    public required string EntityId { get; set; }

    /// <summary>
    /// 人员类型：1：员工2：部门3：角色
    /// </summary>
    [JsonPropertyName("entity_type")]
    public required string EntityType { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripCostCenterEntitySetRequestRq
{
    /// <summary>
    /// 第三方成本中心id。
    /// </summary>
    [JsonPropertyName("thirdpart_id")]
    public required string ThirdpartId { get; set; }

    /// <summary>
    /// 人员信息列表。
    /// </summary>
    [JsonPropertyName("entity_list")]
    public List<PostTopapiAliTripBTripCostCenterEntitySetRequestRqEntityListItem> EntityList { get; set; } = [];

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }
}

/// <summary>
/// 设置成本中心人员信息请求
/// </summary>
public class PostTopapiAliTripBTripCostCenterEntitySetRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("rq")]
    public required PostTopapiAliTripBTripCostCenterEntitySetRequestRq Rq { get; set; }
}

/// <summary>
/// 结果对象。
/// </summary>
public class PostTopapiAliTripBTripCostCenterEntitySetResponseResult
{
    /// <summary>
    /// 增加的人员信息条数。
    /// </summary>
    [JsonPropertyName("add_num")]
    public decimal? AddNum { get; set; }

    /// <summary>
    /// 删除的人员信息条数。
    /// </summary>
    [JsonPropertyName("remove_num")]
    public decimal? RemoveNum { get; set; }

    /// <summary>
    /// 该成本中心下员工总数。
    /// </summary>
    [JsonPropertyName("selected_user_num")]
    public decimal? SelectedUserNum { get; set; }
}

/// <summary>
/// 设置成本中心人员信息响应
/// </summary>
public class PostTopapiAliTripBTripCostCenterEntitySetResponse
{
    /// <summary>
    /// 成本标识。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 结果对象。
    /// </summary>
    [JsonPropertyName("result")]
    public PostTopapiAliTripBTripCostCenterEntitySetResponseResult? Result { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripCostCenterEntityDeleteRequestRqEntityListItem
/// </summary>
public class PostTopapiAliTripBTripCostCenterEntityDeleteRequestRqEntityListItem
{
    /// <summary>
    /// 员工/部门/角色id。
    /// </summary>
    [JsonPropertyName("entity_id")]
    public required string EntityId { get; set; }

    /// <summary>
    /// 人员类型：1：员工2：部门3：角色
    /// </summary>
    [JsonPropertyName("entity_type")]
    public required string EntityType { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripCostCenterEntityDeleteRequestRq
{
    /// <summary>
    /// 是否全部删除。
    /// </summary>
    [JsonPropertyName("del_all")]
    public bool? DelAll { get; set; }

    /// <summary>
    /// 第三方成本中心id。
    /// </summary>
    [JsonPropertyName("thirdpart_id")]
    public required string ThirdpartId { get; set; }

    /// <summary>
    /// 删除的成员信息列表，del_all为true时可不填。
    /// </summary>
    [JsonPropertyName("entity_list")]
    public List<PostTopapiAliTripBTripCostCenterEntityDeleteRequestRqEntityListItem> EntityList { get; set; } = [];

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }
}

/// <summary>
/// 删除成本中心人员信息请求
/// </summary>
public class PostTopapiAliTripBTripCostCenterEntityDeleteRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("rq")]
    public required PostTopapiAliTripBTripCostCenterEntityDeleteRequestRq Rq { get; set; }
}

/// <summary>
/// 结果对象。
/// </summary>
public class PostTopapiAliTripBTripCostCenterEntityDeleteResponseResult
{
    /// <summary>
    /// 该成本中心下员工总数。
    /// </summary>
    [JsonPropertyName("selected_user_num")]
    public decimal? SelectedUserNum { get; set; }

    /// <summary>
    /// 删除的人员信息条数。
    /// </summary>
    [JsonPropertyName("remove_num")]
    public decimal? RemoveNum { get; set; }
}

/// <summary>
/// 删除成本中心人员信息响应
/// </summary>
public class PostTopapiAliTripBTripCostCenterEntityDeleteResponse
{
    /// <summary>
    /// 结果对象。
    /// </summary>
    [JsonPropertyName("result")]
    public PostTopapiAliTripBTripCostCenterEntityDeleteResponseResult? Result { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 调用是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripCostCenterTransferRequestRq
{
    /// <summary>
    /// 第三方成本中心id。
    /// </summary>
    [JsonPropertyName("thirdpart_id")]
    public required string ThirdpartId { get; set; }

    /// <summary>
    /// 商旅成本中心id。
    /// </summary>
    [JsonPropertyName("cost_center_id")]
    public decimal CostCenterId { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }
}

/// <summary>
/// 商旅成本中心转换为外部成本中心请求
/// </summary>
public class PostTopapiAliTripBTripCostCenterTransferRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("rq")]
    public required PostTopapiAliTripBTripCostCenterTransferRequestRq Rq { get; set; }
}

/// <summary>
/// 商旅成本中心转换为外部成本中心响应
/// </summary>
public class PostTopapiAliTripBTripCostCenterTransferResponse
{
    /// <summary>
    /// 调用是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 错误码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 错误码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripProjectAddRequestRequest
{
    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }

    /// <summary>
    /// 项目名称。
    /// </summary>
    [JsonPropertyName("project_name")]
    public required string ProjectName { get; set; }

    /// <summary>
    /// 第三方项目ID。
    /// </summary>
    [JsonPropertyName("third_part_id")]
    public required string ThirdPartId { get; set; }

    /// <summary>
    /// 第三方发票ID。
    /// </summary>
    [JsonPropertyName("third_part_invoice_id")]
    public string? ThirdPartInvoiceId { get; set; }

    /// <summary>
    /// 第三方成本中心ID。
    /// </summary>
    [JsonPropertyName("third_part_cost_center_id")]
    public string? ThirdPartCostCenterId { get; set; }

    /// <summary>
    /// 项目代码。
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>
/// 添加项目请求
/// </summary>
public class PostTopapiAliTripBTripProjectAddRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("request")]
    public required PostTopapiAliTripBTripProjectAddRequestRequest Request { get; set; }
}

/// <summary>
/// 添加项目响应
/// </summary>
public class PostTopapiAliTripBTripProjectAddResponse
{
    /// <summary>
    /// 是否操作成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 项目ID。
    /// </summary>
    [JsonPropertyName("module")]
    public string? Module { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripProjectModifyRequestRequest
{
    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }

    /// <summary>
    /// 项目名称。
    /// </summary>
    [JsonPropertyName("project_name")]
    public required string ProjectName { get; set; }

    /// <summary>
    /// 第三方项目ID。
    /// </summary>
    [JsonPropertyName("third_part_id")]
    public required string ThirdPartId { get; set; }

    /// <summary>
    /// 第三方发票ID。
    /// </summary>
    [JsonPropertyName("third_part_invoice_id")]
    public string? ThirdPartInvoiceId { get; set; }

    /// <summary>
    /// 第三方成本中心ID。
    /// </summary>
    [JsonPropertyName("third_part_cost_center_id")]
    public string? ThirdPartCostCenterId { get; set; }

    /// <summary>
    /// 项目代码。
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>
/// 修改项目请求
/// </summary>
public class PostTopapiAliTripBTripProjectModifyRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("request")]
    public required PostTopapiAliTripBTripProjectModifyRequestRequest Request { get; set; }
}

/// <summary>
/// 修改项目响应
/// </summary>
public class PostTopapiAliTripBTripProjectModifyResponse
{
    /// <summary>
    /// 操作是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 项目ID。
    /// </summary>
    [JsonPropertyName("module")]
    public string? Module { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }
}

/// <summary>
/// 删除项目请求
/// </summary>
public class PostTopapiAliTripBTripProjectDeleteRequest
{
    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }

    /// <summary>
    /// 第三方项目ID。
    /// </summary>
    [JsonPropertyName("third_part_id")]
    public required string ThirdPartId { get; set; }
}

/// <summary>
/// 删除项目响应
/// </summary>
public class PostTopapiAliTripBTripProjectDeleteResponse
{
    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 操作是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 操作结果。
    /// </summary>
    [JsonPropertyName("module")]
    public bool? Module { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripApprovalNewRequestRqItineraryListItem
/// </summary>
public class PostTopapiAliTripBTripApprovalNewRequestRqItineraryListItem
{
    /// <summary>
    /// 行程类型：0：单程1：往返
    /// </summary>
    [JsonPropertyName("trip_way")]
    public decimal TripWay { get; set; }

    /// <summary>
    /// 用户自定义行程ID。
    /// </summary>
    [JsonPropertyName("itinerary_id")]
    public required string ItineraryId { get; set; }

    /// <summary>
    /// 交通方式：0：飞机1：火车2：汽车3：其他
    /// </summary>
    [JsonPropertyName("traffic_type")]
    public decimal TrafficType { get; set; }

    /// <summary>
    /// 出发城市。
    /// </summary>
    [JsonPropertyName("dep_city")]
    public required string DepCity { get; set; }

    /// <summary>
    /// 出发城市编码。
    /// </summary>
    [JsonPropertyName("dep_city_code")]
    public string? DepCityCode { get; set; }

    /// <summary>
    /// 到达城市。
    /// </summary>
    [JsonPropertyName("arr_city")]
    public required string ArrCity { get; set; }

    /// <summary>
    /// 到达城市编码。
    /// </summary>
    [JsonPropertyName("arr_city_code")]
    public string? ArrCityCode { get; set; }

    /// <summary>
    /// 商旅成本中心id，可通过查询成本中心接口获取。若不填则第三方成本中心id必填。
    /// </summary>
    [JsonPropertyName("cost_center_id")]
    public decimal CostCenterId { get; set; }

    /// <summary>
    /// 第三方成本中心id，可通过查询成本中心接口获取。若不填则商旅成本中心id必填。
    /// </summary>
    [JsonPropertyName("thirdpart_cost_center_id")]
    public string? ThirdpartCostCenterId { get; set; }

    /// <summary>
    /// 发票id，可调用查询可用发票列表接口获取。
    /// </summary>
    [JsonPropertyName("invoice_id")]
    public decimal InvoiceId { get; set; }

    /// <summary>
    /// 出发日期。
    /// </summary>
    [JsonPropertyName("dep_date")]
    public required string DepDate { get; set; }

    /// <summary>
    /// 到达日期。
    /// </summary>
    [JsonPropertyName("arr_date")]
    public required string ArrDate { get; set; }

    /// <summary>
    /// 项目名称。
    /// </summary>
    [JsonPropertyName("project_title")]
    public string? ProjectTitle { get; set; }

    /// <summary>
    /// 项目编号。
    /// </summary>
    [JsonPropertyName("project_code")]
    public string? ProjectCode { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripApprovalNewRequestRqTravelerListItem
/// </summary>
public class PostTopapiAliTripBTripApprovalNewRequestRqTravelerListItem
{
    /// <summary>
    /// 出行人的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }

    /// <summary>
    /// 出行人姓名。
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripApprovalNewRequestRq
{
    /// <summary>
    /// 出差天数。
    /// </summary>
    [JsonPropertyName("trip_day")]
    public decimal? TripDay { get; set; }

    /// <summary>
    /// 外部申请单id。
    /// </summary>
    [JsonPropertyName("thirdpart_apply_id")]
    public required string ThirdpartApplyId { get; set; }

    /// <summary>
    /// 申请单标题。
    /// </summary>
    [JsonPropertyName("trip_title")]
    public required string TripTitle { get; set; }

    /// <summary>
    /// 行程列表。
    /// </summary>
    [JsonPropertyName("itinerary_list")]
    public List<PostTopapiAliTripBTripApprovalNewRequestRqItineraryListItem> ItineraryList { get; set; } = [];

    /// <summary>
    /// 部门名称。
    /// </summary>
    [JsonPropertyName("dept_name")]
    public string? DeptName { get; set; }

    /// <summary>
    /// 出差事由。
    /// </summary>
    [JsonPropertyName("trip_cause")]
    public required string TripCause { get; set; }

    /// <summary>
    /// 企业名称。
    /// </summary>
    [JsonPropertyName("corp_name")]
    public string? CorpName { get; set; }

    /// <summary>
    /// 用户的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }

    /// <summary>
    /// 用户名称。如果要传必须传真实姓名，如果不传则会以系统当前维护userId对应的名称进行预订。
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }

    /// <summary>
    /// 部门id。如果不传，会根据user相关信息去获取对应的部门信息，如果传的是错误的部门信息，后面无法做部门的费用归属。
    /// </summary>
    [JsonPropertyName("deptid")]
    public string? Deptid { get; set; }

    /// <summary>
    /// 出行人列表。
    /// </summary>
    [JsonPropertyName("traveler_list")]
    public List<PostTopapiAliTripBTripApprovalNewRequestRqTravelerListItem> TravelerList { get; set; } = [];

    /// <summary>
    /// 企业的corpid，可登录开发者后台查看。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }

    /// <summary>
    /// 审批单状态。0（默认）：审批中1：同意2：拒绝
    /// </summary>
    [JsonPropertyName("status")]
    public decimal? Status { get; set; }

    /// <summary>
    /// 用户展示的外部审批单id信息。
    /// </summary>
    [JsonPropertyName("thirdpart_business_id")]
    public string? ThirdpartBusinessId { get; set; }
}

/// <summary>
/// 新建审批单请求
/// </summary>
public class PostTopapiAliTripBTripApprovalNewRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("rq")]
    public required PostTopapiAliTripBTripApprovalNewRequestRq Rq { get; set; }
}

/// <summary>
/// 结果对象。
/// </summary>
public class PostTopapiAliTripBTripApprovalNewResponseModule
{
    /// <summary>
    /// 外部申请单id。
    /// </summary>
    [JsonPropertyName("thirdpart_apply_id")]
    public string? ThirdpartApplyId { get; set; }

    /// <summary>
    /// 商旅申请单id。
    /// </summary>
    [JsonPropertyName("apply_id")]
    public decimal? ApplyId { get; set; }
}

/// <summary>
/// 新建审批单响应
/// </summary>
public class PostTopapiAliTripBTripApprovalNewResponse
{
    /// <summary>
    /// 结果对象。
    /// </summary>
    [JsonPropertyName("module")]
    public PostTopapiAliTripBTripApprovalNewResponseModule? Module { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 成功标识。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripApplySearchRequestRq
{
    /// <summary>
    /// 更新时间大于等于此时间的审批单。
    /// </summary>
    [JsonPropertyName("gmt_modified")]
    public string? GmtModified { get; set; }

    /// <summary>
    /// 每页返回数量，默认10，最多50。
    /// </summary>
    [JsonPropertyName("page_size")]
    public decimal? PageSize { get; set; }

    /// <summary>
    /// 结束时间。
    /// </summary>
    [JsonPropertyName("end_time")]
    public string? EndTime { get; set; }

    /// <summary>
    /// 开始时间。
    /// </summary>
    [JsonPropertyName("start_time")]
    public string? StartTime { get; set; }

    /// <summary>
    /// 页数，从1开始。
    /// </summary>
    [JsonPropertyName("page")]
    public decimal? Page { get; set; }

    /// <summary>
    /// 提交审批单的用户的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 部门ID。
    /// </summary>
    [JsonPropertyName("deptid")]
    public string? Deptid { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }

    /// <summary>
    /// 是否包括未报销的申请：false: 未报销的申请单
    /// </summary>
    [JsonPropertyName("all_apply")]
    public bool? AllApply { get; set; }

    /// <summary>
    /// 是否仅包括商旅申请单：true：商旅申请单
    /// </summary>
    [JsonPropertyName("only_shang_lv_apply")]
    public bool? OnlyShangLvApply { get; set; }
}

/// <summary>
/// 获取申请单列表请求
/// </summary>
public class PostTopapiAliTripBTripApplySearchRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("rq")]
    public required PostTopapiAliTripBTripApplySearchRequestRq Rq { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripApplySearchResponseModuleItemItineraryListItem
/// </summary>
public class PostTopapiAliTripBTripApplySearchResponseModuleItemItineraryListItem
{
    /// <summary>
    /// 行程方式：0：单程 1：往返
    /// </summary>
    [JsonPropertyName("trip_way")]
    public decimal? TripWay { get; set; }

    /// <summary>
    /// 行程ID。
    /// </summary>
    [JsonPropertyName("itinerary_id")]
    public string? ItineraryId { get; set; }

    /// <summary>
    /// 交通方式：0：飞机 1：火车 2：汽车 3：其他
    /// </summary>
    [JsonPropertyName("traffic_type")]
    public decimal? TrafficType { get; set; }

    /// <summary>
    /// 出发城市。
    /// </summary>
    [JsonPropertyName("dep_city")]
    public string? DepCity { get; set; }

    /// <summary>
    /// 到达城市。
    /// </summary>
    [JsonPropertyName("arr_city")]
    public string? ArrCity { get; set; }

    /// <summary>
    /// 成本中心。
    /// </summary>
    [JsonPropertyName("cost_center_name")]
    public string? CostCenterName { get; set; }

    /// <summary>
    /// 发票抬头。
    /// </summary>
    [JsonPropertyName("invoice_name")]
    public string? InvoiceName { get; set; }

    /// <summary>
    /// 出发日期。
    /// </summary>
    [JsonPropertyName("dep_date")]
    public string? DepDate { get; set; }

    /// <summary>
    /// 到达日期。
    /// </summary>
    [JsonPropertyName("arr_date")]
    public string? ArrDate { get; set; }

    /// <summary>
    /// 项目代码。
    /// </summary>
    [JsonPropertyName("project_code")]
    public string? ProjectCode { get; set; }

    /// <summary>
    /// 项目名称。
    /// </summary>
    [JsonPropertyName("project_title")]
    public string? ProjectTitle { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripApplySearchResponseModuleItemTravelerListItem
/// </summary>
public class PostTopapiAliTripBTripApplySearchResponseModuleItemTravelerListItem
{
    /// <summary>
    /// 出行人userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 出行人姓名。
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripApplySearchResponseModuleItemApproverListItem
/// </summary>
public class PostTopapiAliTripBTripApplySearchResponseModuleItemApproverListItem
{
    /// <summary>
    /// 审批人顺序。
    /// </summary>
    [JsonPropertyName("order")]
    public decimal? Order { get; set; }

    /// <summary>
    /// 审批人姓名。
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }

    /// <summary>
    /// 审批人userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 审批状态：0：审批中 1：已同意 2：已拒绝 3：已转交4：已取消 5：已终止 6：发起审批 7：评论
    /// </summary>
    [JsonPropertyName("status")]
    public decimal? Status { get; set; }

    /// <summary>
    /// 审批状态描述。
    /// </summary>
    [JsonPropertyName("status_desc")]
    public string? StatusDesc { get; set; }

    /// <summary>
    /// 审批意见。
    /// </summary>
    [JsonPropertyName("note")]
    public string? Note { get; set; }

    /// <summary>
    /// 操作时间。
    /// </summary>
    [JsonPropertyName("operate_time")]
    public string? OperateTime { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripApplySearchResponseModuleItem
/// </summary>
public class PostTopapiAliTripBTripApplySearchResponseModuleItem
{
    /// <summary>
    /// 商旅审批单ID。
    /// </summary>
    [JsonPropertyName("id")]
    public decimal? Id { get; set; }

    /// <summary>
    /// 商旅审批展示ID。
    /// </summary>
    [JsonPropertyName("apply_show_id")]
    public string? ApplyShowId { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    [JsonPropertyName("gmt_create")]
    public string? GmtCreate { get; set; }

    /// <summary>
    /// 更新时间。
    /// </summary>
    [JsonPropertyName("gmt_modified")]
    public string? GmtModified { get; set; }

    /// <summary>
    /// 第三方审批单ID。如果非第三方审批单则为空。
    /// </summary>
    [JsonPropertyName("thirdpart_id")]
    public string? ThirdpartId { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public string? Corpid { get; set; }

    /// <summary>
    /// 用户的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 用户的部门ID。
    /// </summary>
    [JsonPropertyName("deptid")]
    public string? Deptid { get; set; }

    /// <summary>
    /// 企业名称。
    /// </summary>
    [JsonPropertyName("corp_name")]
    public string? CorpName { get; set; }

    /// <summary>
    /// 用户名称。
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }

    /// <summary>
    /// 部门名称。
    /// </summary>
    [JsonPropertyName("dept_name")]
    public string? DeptName { get; set; }

    /// <summary>
    /// 出差天数。
    /// </summary>
    [JsonPropertyName("trip_day")]
    public decimal? TripDay { get; set; }

    /// <summary>
    /// 出差事由。
    /// </summary>
    [JsonPropertyName("trip_cause")]
    public string? TripCause { get; set; }

    /// <summary>
    /// 申请单标题。
    /// </summary>
    [JsonPropertyName("trip_title")]
    public string? TripTitle { get; set; }

    /// <summary>
    /// 申请单状态：0：申请 1：同意 2：拒绝 3：转交 4：取消5：修改已同意 6：撤销已同意 7：修改审批中 8：已同意(修改被拒绝) 9：撤销审批中 10：已同意(撤销被拒绝)11：已同意(修改被取消)12：已同意(撤销被取消)
    /// </summary>
    [JsonPropertyName("status")]
    public decimal? Status { get; set; }

    /// <summary>
    /// 审批单状态描述。
    /// </summary>
    [JsonPropertyName("status_desc")]
    public string? StatusDesc { get; set; }

    /// <summary>
    /// 行程列表。
    /// </summary>
    [JsonPropertyName("itinerary_list")]
    public List<PostTopapiAliTripBTripApplySearchResponseModuleItemItineraryListItem> ItineraryList { get; set; } = [];

    /// <summary>
    /// 出行人列表。
    /// </summary>
    [JsonPropertyName("traveler_list")]
    public List<PostTopapiAliTripBTripApplySearchResponseModuleItemTravelerListItem> TravelerList { get; set; } = [];

    /// <summary>
    /// 审批人列表。
    /// </summary>
    [JsonPropertyName("approver_list")]
    public List<PostTopapiAliTripBTripApplySearchResponseModuleItemApproverListItem> ApproverList { get; set; } = [];

    /// <summary>
    /// 流程编码。
    /// </summary>
    [JsonPropertyName("flow_code")]
    public string? FlowCode { get; set; }
}

/// <summary>
/// 获取申请单列表响应
/// </summary>
public class PostTopapiAliTripBTripApplySearchResponse
{
    /// <summary>
    /// 审批单列表。
    /// </summary>
    [JsonPropertyName("module")]
    public List<PostTopapiAliTripBTripApplySearchResponseModuleItem> Module { get; set; } = [];

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 操作是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripApplyGetRequestRq
{
    /// <summary>
    /// 外部审批单ID。
    /// </summary>
    [JsonPropertyName("thirdpart_apply_id")]
    public string? ThirdpartApplyId { get; set; }

    /// <summary>
    /// 阿里商旅审批单ID。
    /// </summary>
    [JsonPropertyName("apply_id")]
    public decimal? ApplyId { get; set; }

    /// <summary>
    /// 阿里商旅审批单展示ID。
    /// </summary>
    [JsonPropertyName("apply_show_id")]
    public string? ApplyShowId { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }
}

/// <summary>
/// 获取申请单详情请求
/// </summary>
public class PostTopapiAliTripBTripApplyGetRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("rq")]
    public required PostTopapiAliTripBTripApplyGetRequestRq Rq { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripApplyGetResponseModuleItineraryListItem
/// </summary>
public class PostTopapiAliTripBTripApplyGetResponseModuleItineraryListItem
{
    /// <summary>
    /// 行程方式：0：单程 1：往返
    /// </summary>
    [JsonPropertyName("trip_way")]
    public decimal? TripWay { get; set; }

    /// <summary>
    /// 行程ID。
    /// </summary>
    [JsonPropertyName("itinerary_id")]
    public string? ItineraryId { get; set; }

    /// <summary>
    /// 交通方式：0：飞机 1：火车 2：汽车 3：其他
    /// </summary>
    [JsonPropertyName("traffic_type")]
    public decimal? TrafficType { get; set; }

    /// <summary>
    /// 出发城市。
    /// </summary>
    [JsonPropertyName("dep_city")]
    public string? DepCity { get; set; }

    /// <summary>
    /// 到达城市。
    /// </summary>
    [JsonPropertyName("arr_city")]
    public string? ArrCity { get; set; }

    /// <summary>
    /// 出发时间。
    /// </summary>
    [JsonPropertyName("dep_date")]
    public string? DepDate { get; set; }

    /// <summary>
    /// 成本中心。
    /// </summary>
    [JsonPropertyName("cost_center_name")]
    public string? CostCenterName { get; set; }

    /// <summary>
    /// 到达时间。
    /// </summary>
    [JsonPropertyName("arr_date")]
    public string? ArrDate { get; set; }

    /// <summary>
    /// 发票抬头。
    /// </summary>
    [JsonPropertyName("invoice_name")]
    public string? InvoiceName { get; set; }

    /// <summary>
    /// 项目名称。
    /// </summary>
    [JsonPropertyName("project_title")]
    public string? ProjectTitle { get; set; }

    /// <summary>
    /// 项目编号
    /// </summary>
    [JsonPropertyName("project_code")]
    public string? ProjectCode { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripApplyGetResponseModuleTravelerListItem
/// </summary>
public class PostTopapiAliTripBTripApplyGetResponseModuleTravelerListItem
{
    /// <summary>
    /// 出行人的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 出行人姓名。
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripApplyGetResponseModuleApproverListItem
/// </summary>
public class PostTopapiAliTripBTripApplyGetResponseModuleApproverListItem
{
    /// <summary>
    /// 审批人顺序。
    /// </summary>
    [JsonPropertyName("order")]
    public decimal? Order { get; set; }

    /// <summary>
    /// 审批人的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 审批人姓名。
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }

    /// <summary>
    /// 审批状态：0：审批中1：已同意 2：已拒绝 3：已转交4：已取消 5：已终止 6：发起审批 7：评论
    /// </summary>
    [JsonPropertyName("status")]
    public decimal? Status { get; set; }

    /// <summary>
    /// 审批状态描述。
    /// </summary>
    [JsonPropertyName("status_desc")]
    public string? StatusDesc { get; set; }

    /// <summary>
    /// 审批意见。
    /// </summary>
    [JsonPropertyName("note")]
    public string? Note { get; set; }

    /// <summary>
    /// 操作时间。
    /// </summary>
    [JsonPropertyName("operate_time")]
    public string? OperateTime { get; set; }
}

/// <summary>
/// 审批单对象。
/// </summary>
public class PostTopapiAliTripBTripApplyGetResponseModule
{
    /// <summary>
    /// 商旅审批单ID。
    /// </summary>
    [JsonPropertyName("id")]
    public decimal? Id { get; set; }

    /// <summary>
    /// 商旅审批展示ID。
    /// </summary>
    [JsonPropertyName("apply_show_id")]
    public string? ApplyShowId { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    [JsonPropertyName("gmt_create")]
    public string? GmtCreate { get; set; }

    /// <summary>
    /// 更新时间。
    /// </summary>
    [JsonPropertyName("gmt_modified")]
    public string? GmtModified { get; set; }

    /// <summary>
    /// 第三方审批单ID。如果非第三方审批单则为空。
    /// </summary>
    [JsonPropertyName("thirdpart_id")]
    public string? ThirdpartId { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public string? Corpid { get; set; }

    /// <summary>
    /// 企业名称。
    /// </summary>
    [JsonPropertyName("corp_name")]
    public string? CorpName { get; set; }

    /// <summary>
    /// 用户的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 用户姓名。
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }

    /// <summary>
    /// 部门ID。
    /// </summary>
    [JsonPropertyName("deptid")]
    public string? Deptid { get; set; }

    /// <summary>
    /// 出差天数。
    /// </summary>
    [JsonPropertyName("trip_day")]
    public decimal? TripDay { get; set; }

    /// <summary>
    /// 部门名称。
    /// </summary>
    [JsonPropertyName("dept_name")]
    public string? DeptName { get; set; }

    /// <summary>
    /// 出差事由。
    /// </summary>
    [JsonPropertyName("trip_cause")]
    public string? TripCause { get; set; }

    /// <summary>
    /// 审批单标题。
    /// </summary>
    [JsonPropertyName("trip_title")]
    public string? TripTitle { get; set; }

    /// <summary>
    /// 申请单状态：0：申请 1：同意 2：拒绝 3：转交 4：取消5：修改已同意 6：撤销已同意 7：修改审批中 8：已同意(修改被拒绝) 9：撤销审批中 10：已同意(撤销被拒绝)11：已同意(修改被取消)12：已同意(撤销被取消)
    /// </summary>
    [JsonPropertyName("status")]
    public decimal? Status { get; set; }

    /// <summary>
    /// 审批单状态描述。
    /// </summary>
    [JsonPropertyName("status_desc")]
    public string? StatusDesc { get; set; }

    /// <summary>
    /// 行程列表。
    /// </summary>
    [JsonPropertyName("itinerary_list")]
    public List<PostTopapiAliTripBTripApplyGetResponseModuleItineraryListItem> ItineraryList { get; set; } = [];

    /// <summary>
    /// 出行人列表。
    /// </summary>
    [JsonPropertyName("traveler_list")]
    public List<PostTopapiAliTripBTripApplyGetResponseModuleTravelerListItem> TravelerList { get; set; } = [];

    /// <summary>
    /// 审批人列表。
    /// </summary>
    [JsonPropertyName("approver_list")]
    public List<PostTopapiAliTripBTripApplyGetResponseModuleApproverListItem> ApproverList { get; set; } = [];
}

/// <summary>
/// 获取申请单详情响应
/// </summary>
public class PostTopapiAliTripBTripApplyGetResponse
{
    /// <summary>
    /// 审批单对象。
    /// </summary>
    [JsonPropertyName("module")]
    public PostTopapiAliTripBTripApplyGetResponseModule? Module { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 操作是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripApprovalModifyRequestRqTravelerListItem
/// </summary>
public class PostTopapiAliTripBTripApprovalModifyRequestRqTravelerListItem
{
    /// <summary>
    /// 出行人姓名。
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }

    /// <summary>
    /// 出行人的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripApprovalModifyRequestRqItineraryListItem
/// </summary>
public class PostTopapiAliTripBTripApprovalModifyRequestRqItineraryListItem
{
    /// <summary>
    /// 项目编码。
    /// </summary>
    [JsonPropertyName("project_code")]
    public string? ProjectCode { get; set; }

    /// <summary>
    /// 项目名称。
    /// </summary>
    [JsonPropertyName("project_title")]
    public string? ProjectTitle { get; set; }

    /// <summary>
    /// 到达日期。
    /// </summary>
    [JsonPropertyName("arr_date")]
    public required string ArrDate { get; set; }

    /// <summary>
    /// 出发日期。
    /// </summary>
    [JsonPropertyName("dep_date")]
    public required string DepDate { get; set; }

    /// <summary>
    /// 发票ID。
    /// </summary>
    [JsonPropertyName("invoice_id")]
    public decimal InvoiceId { get; set; }

    /// <summary>
    /// 第三方成本中心ID。该参数与cost_center_id必填一个。
    /// </summary>
    [JsonPropertyName("thirdpart_cost_center_id")]
    public string? ThirdpartCostCenterId { get; set; }

    /// <summary>
    /// 商旅成本中心id。该参数与thirdpart_cost_center_id必填一个。
    /// </summary>
    [JsonPropertyName("cost_center_id")]
    public decimal? CostCenterId { get; set; }

    /// <summary>
    /// 到达城市编码。
    /// </summary>
    [JsonPropertyName("arr_city_code")]
    public string? ArrCityCode { get; set; }

    /// <summary>
    /// 到达城市。
    /// </summary>
    [JsonPropertyName("arr_city")]
    public required string ArrCity { get; set; }

    /// <summary>
    /// 出发城市编码。
    /// </summary>
    [JsonPropertyName("dep_city_code")]
    public string? DepCityCode { get; set; }

    /// <summary>
    /// 出发城市。
    /// </summary>
    [JsonPropertyName("dep_city")]
    public required string DepCity { get; set; }

    /// <summary>
    /// 交通方式：0：飞机1：火车,2：汽车,3：其他
    /// </summary>
    [JsonPropertyName("traffic_type")]
    public decimal TrafficType { get; set; }

    /// <summary>
    /// 行程ID。
    /// </summary>
    [JsonPropertyName("itinerary_id")]
    public required string ItineraryId { get; set; }

    /// <summary>
    /// 行程类型：0：单程1：往返
    /// </summary>
    [JsonPropertyName("trip_way")]
    public decimal TripWay { get; set; }
}

/// <summary>
/// 请求参数。
/// </summary>
public class PostTopapiAliTripBTripApprovalModifyRequestRq
{
    /// <summary>
    /// 用户展示的外部审批单ID，可调用查询企业申请单数据接口获取。
    /// </summary>
    [JsonPropertyName("thirdpart_business_id")]
    public string? ThirdpartBusinessId { get; set; }

    /// <summary>
    /// 审批单状态，不传入默认为0：0：审批中1：同意2：拒绝
    /// </summary>
    [JsonPropertyName("status")]
    public decimal? Status { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }

    /// <summary>
    /// 出行人列表。
    /// </summary>
    [JsonPropertyName("traveler_list")]
    public List<PostTopapiAliTripBTripApprovalModifyRequestRqTravelerListItem> TravelerList { get; set; } = [];

    /// <summary>
    /// 部门ID。如果不传，会根据user相关信息去获取对应的部门信息。如果传的是错误的部门信息，后面无法做部门的费用归属；部门ID只能是数字。
    /// </summary>
    [JsonPropertyName("deptid")]
    public string? Deptid { get; set; }

    /// <summary>
    /// 用户名称，如果要传必须传真实姓名，如果不传则会以系统当前维护userId对应的名称进行预订
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }

    /// <summary>
    /// 用户的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }

    /// <summary>
    /// 企业名称。
    /// </summary>
    [JsonPropertyName("corp_name")]
    public string? CorpName { get; set; }

    /// <summary>
    /// 出差事由。
    /// </summary>
    [JsonPropertyName("trip_cause")]
    public required string TripCause { get; set; }

    /// <summary>
    /// 部门名称。
    /// </summary>
    [JsonPropertyName("dept_name")]
    public string? DeptName { get; set; }

    /// <summary>
    /// 行程列表。
    /// </summary>
    [JsonPropertyName("itinerary_list")]
    public List<PostTopapiAliTripBTripApprovalModifyRequestRqItineraryListItem> ItineraryList { get; set; } = [];

    /// <summary>
    /// 申请单标题。
    /// </summary>
    [JsonPropertyName("trip_title")]
    public required string TripTitle { get; set; }

    /// <summary>
    /// 外部申请单ID。
    /// </summary>
    [JsonPropertyName("thirdpart_apply_id")]
    public required string ThirdpartApplyId { get; set; }

    /// <summary>
    /// 出差天数。
    /// </summary>
    [JsonPropertyName("trip_day")]
    public decimal? TripDay { get; set; }
}

/// <summary>
/// 修改申请单请求
/// </summary>
public class PostTopapiAliTripBTripApprovalModifyRequest
{
    /// <summary>
    /// 请求参数。
    /// </summary>
    [JsonPropertyName("rq")]
    public required PostTopapiAliTripBTripApprovalModifyRequestRq Rq { get; set; }
}

/// <summary>
/// 结果对象。
/// </summary>
public class PostTopapiAliTripBTripApprovalModifyResponseModule
{
    /// <summary>
    /// 商旅申请单ID。
    /// </summary>
    [JsonPropertyName("apply_id")]
    public decimal? ApplyId { get; set; }

    /// <summary>
    /// 外部申请单ID。
    /// </summary>
    [JsonPropertyName("thirdpart_apply_id")]
    public string? ThirdpartApplyId { get; set; }
}

/// <summary>
/// 修改申请单响应
/// </summary>
public class PostTopapiAliTripBTripApprovalModifyResponse
{
    /// <summary>
    /// 操作是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 结果对象。
    /// </summary>
    [JsonPropertyName("module")]
    public PostTopapiAliTripBTripApprovalModifyResponseModule? Module { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripApprovalUpdateRequestRq
{
    /// <summary>
    /// 外部申请单ID。
    /// </summary>
    [JsonPropertyName("thirdpart_apply_id")]
    public required string ThirdpartApplyId { get; set; }

    /// <summary>
    /// 操作时间。
    /// </summary>
    [JsonPropertyName("operate_time")]
    public required string OperateTime { get; set; }

    /// <summary>
    /// 申请单状态：1：已同意 2：已拒绝 3：已转交 4：已取消
    /// </summary>
    [JsonPropertyName("status")]
    public decimal Status { get; set; }

    /// <summary>
    /// 审批人的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }

    /// <summary>
    /// 审批人姓名。
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }

    /// <summary>
    /// 备注。
    /// </summary>
    [JsonPropertyName("note")]
    public string? Note { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }
}

/// <summary>
/// 更新申请单状态请求
/// </summary>
public class PostTopapiAliTripBTripApprovalUpdateRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("rq")]
    public required PostTopapiAliTripBTripApprovalUpdateRequestRq Rq { get; set; }
}

/// <summary>
/// 更新申请单状态响应
/// </summary>
public class PostTopapiAliTripBTripApprovalUpdateResponse
{
    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 操作是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 意向出行信息。
/// </summary>
public class GetV1AliTripExceedapplyGetHotelResponseApplyIntentionInfoDO
{
    /// <summary>
    /// 入住日期。
    /// </summary>
    [JsonPropertyName("checkIn")]
    public string? CheckIn { get; set; }

    /// <summary>
    /// 离店日期。
    /// </summary>
    [JsonPropertyName("checkOut")]
    public string? CheckOut { get; set; }

    /// <summary>
    /// 入住城市三字码。
    /// </summary>
    [JsonPropertyName("cityCode")]
    public string? CityCode { get; set; }

    /// <summary>
    /// 入住城市名称。
    /// </summary>
    [JsonPropertyName("cityName")]
    public string? CityName { get; set; }

    /// <summary>
    /// 意向酒店金额（分）。
    /// </summary>
    [JsonPropertyName("price")]
    public long? Price { get; set; }

    /// <summary>
    /// 是否合住。
    /// </summary>
    [JsonPropertyName("together")]
    public bool? Together { get; set; }

    /// <summary>
    /// 超标类型，取值：
    /// </summary>
    [JsonPropertyName("type")]
    public long? Type { get; set; }
}

/// <summary>
/// 搜索第三方酒店超标审批单响应
/// </summary>
public class GetV1AliTripExceedapplyGetHotelResponse
{
    /// <summary>
    /// 第三方企业的corpId。
    /// </summary>
    [JsonPropertyName("corpId")]
    public string? CorpId { get; set; }

    /// <summary>
    /// 商旅超标审批单ID。
    /// </summary>
    [JsonPropertyName("applyId")]
    public long? ApplyId { get; set; }

    /// <summary>
    /// 审批单状态，取值：
    /// </summary>
    [JsonPropertyName("status")]
    public long? Status { get; set; }

    /// <summary>
    /// 出差原因。
    /// </summary>
    [JsonPropertyName("btripCause")]
    public string? BTripCause { get; set; }

    /// <summary>
    /// 超标类型，取值：
    /// </summary>
    [JsonPropertyName("exceedType")]
    public long? ExceedType { get; set; }

    /// <summary>
    /// 超标原因。
    /// </summary>
    [JsonPropertyName("exceedReason")]
    public string? ExceedReason { get; set; }

    /// <summary>
    /// 原差旅标准。
    /// </summary>
    [JsonPropertyName("originStandard")]
    public string? OriginStandard { get; set; }

    /// <summary>
    /// 审批单提交时间。
    /// </summary>
    [JsonPropertyName("submitTime")]
    public string? SubmitTime { get; set; }

    /// <summary>
    /// 第三方用户的userid。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 意向出行信息。
    /// </summary>
    [JsonPropertyName("applyIntentionInfoDO")]
    public GetV1AliTripExceedapplyGetHotelResponseApplyIntentionInfoDO? ApplyIntentionInfoDO { get; set; }

    /// <summary>
    /// 第三方出差审批单号。
    /// </summary>
    [JsonPropertyName("thirdpartApplyId")]
    public string? ThirdpartApplyId { get; set; }
}

/// <summary>
/// 意向出行信息。
/// </summary>
public class GetV1AliTripExceedapplyGetTrainResponseApplyIntentionInfoDO
{
    /// <summary>
    /// 意向坐席价格（分）。
    /// </summary>
    [JsonPropertyName("price")]
    public long? Price { get; set; }

    /// <summary>
    /// 出发城市名。
    /// </summary>
    [JsonPropertyName("depCityName")]
    public string? DepCityName { get; set; }

    /// <summary>
    /// 到达城市名。
    /// </summary>
    [JsonPropertyName("arrCityName")]
    public string? ArrCityName { get; set; }

    /// <summary>
    /// 出发城市三字码。
    /// </summary>
    [JsonPropertyName("depCity")]
    public string? DepCity { get; set; }

    /// <summary>
    /// 到达城市三字码。
    /// </summary>
    [JsonPropertyName("arrCity")]
    public string? ArrCity { get; set; }

    /// <summary>
    /// 出发时间。
    /// </summary>
    [JsonPropertyName("depTime")]
    public string? DepTime { get; set; }

    /// <summary>
    /// 到达时间。
    /// </summary>
    [JsonPropertyName("arrTime")]
    public string? ArrTime { get; set; }

    /// <summary>
    /// 到达站点名称。
    /// </summary>
    [JsonPropertyName("arrStation")]
    public string? ArrStation { get; set; }

    /// <summary>
    /// 出发站点名称。
    /// </summary>
    [JsonPropertyName("depStation")]
    public string? DepStation { get; set; }

    /// <summary>
    /// 意向车次号。
    /// </summary>
    [JsonPropertyName("trainNo")]
    public string? TrainNo { get; set; }

    /// <summary>
    /// 意向车次类型。
    /// </summary>
    [JsonPropertyName("trainTypeDesc")]
    public string? TrainTypeDesc { get; set; }

    /// <summary>
    /// 意向坐席名称。
    /// </summary>
    [JsonPropertyName("seatName")]
    public string? SeatName { get; set; }
}

/// <summary>
/// 搜索第三方火车票超标审批单响应
/// </summary>
public class GetV1AliTripExceedapplyGetTrainResponse
{
    /// <summary>
    /// 第三方企业的corpId。
    /// </summary>
    [JsonPropertyName("corpId")]
    public string? CorpId { get; set; }

    /// <summary>
    /// 商旅超标审批单ID。
    /// </summary>
    [JsonPropertyName("applyId")]
    public long? ApplyId { get; set; }

    /// <summary>
    /// 审批单状态，取值：
    /// </summary>
    [JsonPropertyName("status")]
    public long? Status { get; set; }

    /// <summary>
    /// 出差原因。
    /// </summary>
    [JsonPropertyName("btripCause")]
    public string? BTripCause { get; set; }

    /// <summary>
    /// 超标类型，取值：
    /// </summary>
    [JsonPropertyName("exceedType")]
    public long? ExceedType { get; set; }

    /// <summary>
    /// 超标原因。
    /// </summary>
    [JsonPropertyName("exceedReason")]
    public string? ExceedReason { get; set; }

    /// <summary>
    /// 原差旅标准。
    /// </summary>
    [JsonPropertyName("originStandard")]
    public string? OriginStandard { get; set; }

    /// <summary>
    /// 审批单提交时间。
    /// </summary>
    [JsonPropertyName("submitTime")]
    public string? SubmitTime { get; set; }

    /// <summary>
    /// 第三方用户的userid。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 意向出行信息。
    /// </summary>
    [JsonPropertyName("applyIntentionInfoDO")]
    public GetV1AliTripExceedapplyGetTrainResponseApplyIntentionInfoDO? ApplyIntentionInfoDO { get; set; }

    /// <summary>
    /// 第三方出差审批单号。
    /// </summary>
    [JsonPropertyName("thirdpartApplyId")]
    public string? ThirdpartApplyId { get; set; }
}

/// <summary>
/// 回传第三方超标审批结果响应
/// </summary>
public class PostV1AliTripExceedapplySyncResponse
{
    /// <summary>
    /// 调用是否成功。
    /// </summary>
    [JsonPropertyName("module")]
    public bool? Module { get; set; }
}

/// <summary>
/// 意向出行信息。
/// </summary>
public class GetV1AliTripExceedapplyGetFlightResponseApplyIntentionInfoDO
{
    /// <summary>
    /// 到达城市三字码。
    /// </summary>
    [JsonPropertyName("arrCity")]
    public string? ArrCity { get; set; }

    /// <summary>
    /// 到达城市名称。
    /// </summary>
    [JsonPropertyName("arrCityName")]
    public string? ArrCityName { get; set; }

    /// <summary>
    /// 到达时间。
    /// </summary>
    [JsonPropertyName("arrTime")]
    public string? ArrTime { get; set; }

    /// <summary>
    /// 超标的舱位，取值：
    /// </summary>
    [JsonPropertyName("cabin")]
    public string? Cabin { get; set; }

    /// <summary>
    /// 申请超标的舱等，取值：
    /// </summary>
    [JsonPropertyName("cabinClass")]
    public long? CabinClass { get; set; }

    /// <summary>
    /// 舱等描述。
    /// </summary>
    [JsonPropertyName("cabinClassStr")]
    public string? CabinClassStr { get; set; }

    /// <summary>
    /// 出发城市三字码。
    /// </summary>
    [JsonPropertyName("depCity")]
    public string? DepCity { get; set; }

    /// <summary>
    /// 出发城市名称。
    /// </summary>
    [JsonPropertyName("depCityName")]
    public string? DepCityName { get; set; }

    /// <summary>
    /// 出发时间。
    /// </summary>
    [JsonPropertyName("depTime")]
    public string? DepTime { get; set; }

    /// <summary>
    /// 折扣。
    /// </summary>
    [JsonPropertyName("discount")]
    public JsonElement? Discount { get; set; }

    /// <summary>
    /// 航班号。
    /// </summary>
    [JsonPropertyName("flightNo")]
    public string? FlightNo { get; set; }

    /// <summary>
    /// 意向航班价格（元）。
    /// </summary>
    [JsonPropertyName("price")]
    public long? Price { get; set; }

    /// <summary>
    /// 超标类型，取值：
    /// </summary>
    [JsonPropertyName("type")]
    public long? Type { get; set; }
}

/// <summary>
/// 搜索第三方机票超标审批单响应
/// </summary>
public class GetV1AliTripExceedapplyGetFlightResponse
{
    /// <summary>
    /// 第三方企业的corpId。
    /// </summary>
    [JsonPropertyName("corpId")]
    public string? CorpId { get; set; }

    /// <summary>
    /// 商旅超标审批单ID。
    /// </summary>
    [JsonPropertyName("applyId")]
    public long? ApplyId { get; set; }

    /// <summary>
    /// 审批单状态，取值：
    /// </summary>
    [JsonPropertyName("status")]
    public long? Status { get; set; }

    /// <summary>
    /// 出差原因。
    /// </summary>
    [JsonPropertyName("btripCause")]
    public string? BTripCause { get; set; }

    /// <summary>
    /// 超标类型，取值：
    /// </summary>
    [JsonPropertyName("exceedType")]
    public long? ExceedType { get; set; }

    /// <summary>
    /// 超标原因。
    /// </summary>
    [JsonPropertyName("exceedReason")]
    public string? ExceedReason { get; set; }

    /// <summary>
    /// 原差旅标准。
    /// </summary>
    [JsonPropertyName("originStandard")]
    public string? OriginStandard { get; set; }

    /// <summary>
    /// 审批单提交时间。
    /// </summary>
    [JsonPropertyName("submitTime")]
    public string? SubmitTime { get; set; }

    /// <summary>
    /// 第三方用户的userid。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 意向出行信息。
    /// </summary>
    [JsonPropertyName("applyIntentionInfoDO")]
    public GetV1AliTripExceedapplyGetFlightResponseApplyIntentionInfoDO? ApplyIntentionInfoDO { get; set; }

    /// <summary>
    /// 第三方出差审批单号。
    /// </summary>
    [JsonPropertyName("thirdpartApplyId")]
    public string? ThirdpartApplyId { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripFlightOrderSearchRequestRq
{
    /// <summary>
    /// 开始时间。
    /// </summary>
    [JsonPropertyName("start_time")]
    public string? StartTime { get; set; }

    /// <summary>
    /// 商旅申请单ID。
    /// </summary>
    [JsonPropertyName("apply_id")]
    public decimal? ApplyId { get; set; }

    /// <summary>
    /// 页数，从1开始。
    /// </summary>
    [JsonPropertyName("page")]
    public decimal? Page { get; set; }

    /// <summary>
    /// 用户的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 每页数据量，默认10，最高50。
    /// </summary>
    [JsonPropertyName("page_size")]
    public decimal? PageSize { get; set; }

    /// <summary>
    /// 部门ID。
    /// </summary>
    [JsonPropertyName("deptid")]
    public string? Deptid { get; set; }

    /// <summary>
    /// 结束时间。
    /// </summary>
    [JsonPropertyName("end_time")]
    public string? EndTime { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }

    /// <summary>
    /// 更新结束时间。
    /// </summary>
    [JsonPropertyName("update_end_time")]
    public string? UpdateEndTime { get; set; }

    /// <summary>
    /// 更新开始时间。
    /// </summary>
    [JsonPropertyName("update_start_time")]
    public string? UpdateStartTime { get; set; }

    /// <summary>
    /// false：仅搜索未报销的申请单。
    /// </summary>
    [JsonPropertyName("all_apply")]
    public bool? AllApply { get; set; }

    /// <summary>
    /// 第三方申请单ID。
    /// </summary>
    [JsonPropertyName("thirdpart_apply_id")]
    public string? ThirdpartApplyId { get; set; }
}

/// <summary>
/// 获取企业机票订单数据请求
/// </summary>
public class PostTopapiAliTripBTripFlightOrderSearchRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("rq")]
    public required PostTopapiAliTripBTripFlightOrderSearchRequestRq Rq { get; set; }
}

/// <summary>
/// 发票信息对象。
/// </summary>
public class PostTopapiAliTripBTripFlightOrderSearchResponseFlightOrderListItemInvoice
{
    /// <summary>
    /// 商旅发票ID。
    /// </summary>
    [JsonPropertyName("id")]
    public decimal? Id { get; set; }

    /// <summary>
    /// 发票抬头。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// 成本中心对象。
/// </summary>
public class PostTopapiAliTripBTripFlightOrderSearchResponseFlightOrderListItemCostCenter
{
    /// <summary>
    /// 商旅成本中心id。
    /// </summary>
    [JsonPropertyName("id")]
    public decimal? Id { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public string? Corpid { get; set; }

    /// <summary>
    /// 成本中心编号。
    /// </summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>
    /// 成本中心名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripFlightOrderSearchResponseFlightOrderListItemPriceInfoListItem
/// </summary>
public class PostTopapiAliTripBTripFlightOrderSearchResponseFlightOrderListItemPriceInfoListItem
{
    /// <summary>
    /// 价格。
    /// </summary>
    [JsonPropertyName("price")]
    public string? Price { get; set; }

    /// <summary>
    /// 资金流向:1：支出2：收入
    /// </summary>
    [JsonPropertyName("type")]
    public decimal? Type { get; set; }

    /// <summary>
    /// 交易类目。
    /// </summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>
    /// 结算方式：1：个人现付2：企业现付4：企业月结8：企业预存
    /// </summary>
    [JsonPropertyName("pay_type")]
    public decimal? PayType { get; set; }

    /// <summary>
    /// 流水创建时间。
    /// </summary>
    [JsonPropertyName("gmt_create")]
    public string? GmtCreate { get; set; }

    /// <summary>
    /// 乘机人，多个用‘,’分割。
    /// </summary>
    [JsonPropertyName("passenger_name")]
    public string? PassengerName { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripFlightOrderSearchResponseFlightOrderListItemInsureInfoListItem
/// </summary>
public class PostTopapiAliTripBTripFlightOrderSearchResponseFlightOrderListItemInsureInfoListItem
{
    /// <summary>
    /// 保单号。
    /// </summary>
    [JsonPropertyName("insure_no")]
    public string? InsureNo { get; set; }

    /// <summary>
    /// 保单状态：1：已出保 2：已退保
    /// </summary>
    [JsonPropertyName("status")]
    public decimal? Status { get; set; }

    /// <summary>
    /// 乘机人(保险人)姓名。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripFlightOrderSearchResponseFlightOrderListItemUserAffiliateListItem
/// </summary>
public class PostTopapiAliTripBTripFlightOrderSearchResponseFlightOrderListItemUserAffiliateListItem
{
    /// <summary>
    /// 出行人userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 出行人姓名。
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripFlightOrderSearchResponseFlightOrderListItem
/// </summary>
public class PostTopapiAliTripBTripFlightOrderSearchResponseFlightOrderListItem
{
    /// <summary>
    /// 机票订单ID。
    /// </summary>
    [JsonPropertyName("id")]
    public decimal? Id { get; set; }

    /// <summary>
    /// 更新时间。
    /// </summary>
    [JsonPropertyName("gmt_modified")]
    public string? GmtModified { get; set; }

    /// <summary>
    /// 用户userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 企业名称。
    /// </summary>
    [JsonPropertyName("corp_name")]
    public string? CorpName { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public string? Corpid { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    [JsonPropertyName("gmt_create")]
    public string? GmtCreate { get; set; }

    /// <summary>
    /// 用户姓名。
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }

    /// <summary>
    /// 部门ID。
    /// </summary>
    [JsonPropertyName("deptid")]
    public string? Deptid { get; set; }

    /// <summary>
    /// 部门名称。
    /// </summary>
    [JsonPropertyName("dept_name")]
    public string? DeptName { get; set; }

    /// <summary>
    /// 商旅申请单ID。
    /// </summary>
    [JsonPropertyName("apply_id")]
    public string? ApplyId { get; set; }

    /// <summary>
    /// 联系人。
    /// </summary>
    [JsonPropertyName("contact_name")]
    public string? ContactName { get; set; }

    /// <summary>
    /// 出发城市。
    /// </summary>
    [JsonPropertyName("dep_city")]
    public string? DepCity { get; set; }

    /// <summary>
    /// 到达城市。
    /// </summary>
    [JsonPropertyName("arr_city")]
    public string? ArrCity { get; set; }

    /// <summary>
    /// 出发日期。
    /// </summary>
    [JsonPropertyName("dep_date")]
    public string? DepDate { get; set; }

    /// <summary>
    /// 到达日期。
    /// </summary>
    [JsonPropertyName("ret_date")]
    public string? RetDate { get; set; }

    /// <summary>
    /// 行程类型：0：单程1：往返2：中转
    /// </summary>
    [JsonPropertyName("trip_type")]
    public decimal? TripType { get; set; }

    /// <summary>
    /// 乘机人数量。
    /// </summary>
    [JsonPropertyName("passenger_count")]
    public decimal? PassengerCount { get; set; }

    /// <summary>
    /// 舱位类型。
    /// </summary>
    [JsonPropertyName("cabin_class")]
    public string? CabinClass { get; set; }

    /// <summary>
    /// 订单状态：0：待支付1：出票中2：已关闭3：有改签单4：有退票单5：出票成功6：退票申请中7：改签申请中
    /// </summary>
    [JsonPropertyName("status")]
    public decimal? Status { get; set; }

    /// <summary>
    /// 折扣。
    /// </summary>
    [JsonPropertyName("discount")]
    public string? Discount { get; set; }

    /// <summary>
    /// 航班号。
    /// </summary>
    [JsonPropertyName("flight_no")]
    public string? FlightNo { get; set; }

    /// <summary>
    /// 乘机人，多个用‘,’分割。
    /// </summary>
    [JsonPropertyName("passenger_name")]
    public string? PassengerName { get; set; }

    /// <summary>
    /// 出发机场。
    /// </summary>
    [JsonPropertyName("dep_airport")]
    public string? DepAirport { get; set; }

    /// <summary>
    /// 到达机场。
    /// </summary>
    [JsonPropertyName("arr_airport")]
    public string? ArrAirport { get; set; }

    /// <summary>
    /// 发票信息对象。
    /// </summary>
    [JsonPropertyName("invoice")]
    public PostTopapiAliTripBTripFlightOrderSearchResponseFlightOrderListItemInvoice? Invoice { get; set; }

    /// <summary>
    /// 成本中心对象。
    /// </summary>
    [JsonPropertyName("cost_center")]
    public PostTopapiAliTripBTripFlightOrderSearchResponseFlightOrderListItemCostCenter? CostCenter { get; set; }

    /// <summary>
    /// 价目信息。
    /// </summary>
    [JsonPropertyName("price_info_list")]
    public List<PostTopapiAliTripBTripFlightOrderSearchResponseFlightOrderListItemPriceInfoListItem> PriceInfoList { get; set; } = [];

    /// <summary>
    /// 保险信息。
    /// </summary>
    [JsonPropertyName("insureInfo_list")]
    public List<PostTopapiAliTripBTripFlightOrderSearchResponseFlightOrderListItemInsureInfoListItem> InsureInfoList { get; set; } = [];

    /// <summary>
    /// 第三方行程ID。
    /// </summary>
    [JsonPropertyName("thirdpart_itinerary_id")]
    public string? ThirdpartItineraryId { get; set; }

    /// <summary>
    /// 出行人列表。
    /// </summary>
    [JsonPropertyName("user_affiliate_list")]
    public List<PostTopapiAliTripBTripFlightOrderSearchResponseFlightOrderListItemUserAffiliateListItem> UserAffiliateList { get; set; } = [];

    /// <summary>
    /// 第三方申请单ID。
    /// </summary>
    [JsonPropertyName("thirdpart_apply_id")]
    public string? ThirdpartApplyId { get; set; }

    /// <summary>
    /// 申请单名称。
    /// </summary>
    [JsonPropertyName("btrip_title")]
    public string? BTripTitle { get; set; }
}

/// <summary>
/// 获取企业机票订单数据响应
/// </summary>
public class PostTopapiAliTripBTripFlightOrderSearchResponse
{
    /// <summary>
    /// 操作是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 机票列表。
    /// </summary>
    [JsonPropertyName("flight_order_list")]
    public List<PostTopapiAliTripBTripFlightOrderSearchResponseFlightOrderListItem> FlightOrderList { get; set; } = [];
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripHotelOrderSearchRequestRq
{
    /// <summary>
    /// 开始时间。
    /// </summary>
    [JsonPropertyName("start_time")]
    public string? StartTime { get; set; }

    /// <summary>
    /// 商旅审批单ID。
    /// </summary>
    [JsonPropertyName("apply_id")]
    public decimal? ApplyId { get; set; }

    /// <summary>
    /// 页数，从1开始。
    /// </summary>
    [JsonPropertyName("page")]
    public decimal? Page { get; set; }

    /// <summary>
    /// 用户的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 每页数量，默认10，最大50
    /// </summary>
    [JsonPropertyName("page_size")]
    public decimal? PageSize { get; set; }

    /// <summary>
    /// 部门ID。
    /// </summary>
    [JsonPropertyName("deptid")]
    public string? Deptid { get; set; }

    /// <summary>
    /// 结束时间。
    /// </summary>
    [JsonPropertyName("end_time")]
    public string? EndTime { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }

    /// <summary>
    /// 更新开始时间。
    /// </summary>
    [JsonPropertyName("update_end_time")]
    public string? UpdateEndTime { get; set; }

    /// <summary>
    /// 更新结束时间。
    /// </summary>
    [JsonPropertyName("update_start_time")]
    public string? UpdateStartTime { get; set; }

    /// <summary>
    /// false：搜索未报销订单。
    /// </summary>
    [JsonPropertyName("all_apply")]
    public bool? AllApply { get; set; }

    /// <summary>
    /// 第三方申请单ID。
    /// </summary>
    [JsonPropertyName("thirdpart_apply_id")]
    public string? ThirdpartApplyId { get; set; }
}

/// <summary>
/// 获取企业商旅酒店订单数据请求
/// </summary>
public class PostTopapiAliTripBTripHotelOrderSearchRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("rq")]
    public required PostTopapiAliTripBTripHotelOrderSearchRequestRq Rq { get; set; }
}

/// <summary>
/// 成本中心对象。
/// </summary>
public class PostTopapiAliTripBTripHotelOrderSearchResponseModuleItemCostCenter
{
    /// <summary>
    /// 商旅成本中心ID。
    /// </summary>
    [JsonPropertyName("id")]
    public decimal? Id { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public string? Corpid { get; set; }

    /// <summary>
    /// 成本中心编号。
    /// </summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>
    /// 成本中心名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// 发票对象。
/// </summary>
public class PostTopapiAliTripBTripHotelOrderSearchResponseModuleItemInvoice
{
    /// <summary>
    /// 商旅发票ID。
    /// </summary>
    [JsonPropertyName("id")]
    public decimal? Id { get; set; }

    /// <summary>
    /// 发票抬头。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripHotelOrderSearchResponseModuleItemPriceInfoListItem
/// </summary>
public class PostTopapiAliTripBTripHotelOrderSearchResponseModuleItemPriceInfoListItem
{
    /// <summary>
    /// 价格。
    /// </summary>
    [JsonPropertyName("price")]
    public string? Price { get; set; }

    /// <summary>
    /// 资金流向：1：支出2：收入
    /// </summary>
    [JsonPropertyName("type")]
    public decimal? Type { get; set; }

    /// <summary>
    /// 交易类型。
    /// </summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>
    /// 结算方式：1：个人现付2：企业现付4：企业月结8：企业预存
    /// </summary>
    [JsonPropertyName("pay_type")]
    public decimal? PayType { get; set; }

    /// <summary>
    /// 流水创建时间。
    /// </summary>
    [JsonPropertyName("gmt_create")]
    public string? GmtCreate { get; set; }

    /// <summary>
    /// 入住人信息，多个用‘,’分割。
    /// </summary>
    [JsonPropertyName("passenger_name")]
    public string? PassengerName { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripHotelOrderSearchResponseModuleItemUserAffiliateListItem
/// </summary>
public class PostTopapiAliTripBTripHotelOrderSearchResponseModuleItemUserAffiliateListItem
{
    /// <summary>
    /// 入住人姓名。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 入住人名称。
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripHotelOrderSearchResponseModuleItem
/// </summary>
public class PostTopapiAliTripBTripHotelOrderSearchResponseModuleItem
{
    /// <summary>
    /// 订单ID。
    /// </summary>
    [JsonPropertyName("id")]
    public decimal? Id { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    [JsonPropertyName("gmt_create")]
    public string? GmtCreate { get; set; }

    /// <summary>
    /// 更新时间。
    /// </summary>
    [JsonPropertyName("gmt_modified")]
    public string? GmtModified { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public string? Corpid { get; set; }

    /// <summary>
    /// 企业名称。
    /// </summary>
    [JsonPropertyName("corp_name")]
    public string? CorpName { get; set; }

    /// <summary>
    /// 用户的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 用户名称。
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }

    /// <summary>
    /// 部门ID。
    /// </summary>
    [JsonPropertyName("deptid")]
    public string? Deptid { get; set; }

    /// <summary>
    /// 部门名称。
    /// </summary>
    [JsonPropertyName("dept_name")]
    public string? DeptName { get; set; }

    /// <summary>
    /// 商旅申请单ID。
    /// </summary>
    [JsonPropertyName("apply_id")]
    public decimal? ApplyId { get; set; }

    /// <summary>
    /// 联系人姓名。
    /// </summary>
    [JsonPropertyName("contact_name")]
    public string? ContactName { get; set; }

    /// <summary>
    /// 酒店所在城市。
    /// </summary>
    [JsonPropertyName("city")]
    public string? City { get; set; }

    /// <summary>
    /// 酒店名称。
    /// </summary>
    [JsonPropertyName("hotel_name")]
    public string? HotelName { get; set; }

    /// <summary>
    /// 入住时间。
    /// </summary>
    [JsonPropertyName("check_in")]
    public string? CheckIn { get; set; }

    /// <summary>
    /// 离店时间。
    /// </summary>
    [JsonPropertyName("check_out")]
    public string? CheckOut { get; set; }

    /// <summary>
    /// 房型。
    /// </summary>
    [JsonPropertyName("room_type")]
    public string? RoomType { get; set; }

    /// <summary>
    /// 房间数。
    /// </summary>
    [JsonPropertyName("room_num")]
    public decimal? RoomNum { get; set; }

    /// <summary>
    /// 总共住几晚。
    /// </summary>
    [JsonPropertyName("night")]
    public decimal? Night { get; set; }

    /// <summary>
    /// 入住顾客，多个用','分割。
    /// </summary>
    [JsonPropertyName("guest")]
    public string? Guest { get; set; }

    /// <summary>
    /// 订单类型描述。
    /// </summary>
    [JsonPropertyName("order_type_desc")]
    public string? OrderTypeDesc { get; set; }

    /// <summary>
    /// 订单状态描述。
    /// </summary>
    [JsonPropertyName("order_status_desc")]
    public string? OrderStatusDesc { get; set; }

    /// <summary>
    /// 成本中心对象。
    /// </summary>
    [JsonPropertyName("cost_center")]
    public PostTopapiAliTripBTripHotelOrderSearchResponseModuleItemCostCenter? CostCenter { get; set; }

    /// <summary>
    /// 发票对象。
    /// </summary>
    [JsonPropertyName("invoice")]
    public PostTopapiAliTripBTripHotelOrderSearchResponseModuleItemInvoice? Invoice { get; set; }

    /// <summary>
    /// 价目详情列表。
    /// </summary>
    [JsonPropertyName("price_info_list")]
    public List<PostTopapiAliTripBTripHotelOrderSearchResponseModuleItemPriceInfoListItem> PriceInfoList { get; set; } = [];

    /// <summary>
    /// 第三方行程ID。
    /// </summary>
    [JsonPropertyName("thirdpart_itinerary_id")]
    public string? ThirdpartItineraryId { get; set; }

    /// <summary>
    /// 订单状态：1：等待确认2：等待付款3：预订成功4：申请退款5：退款成功6：已关闭7：结账成功8：支付成功
    /// </summary>
    [JsonPropertyName("order_status")]
    public decimal? OrderStatus { get; set; }

    /// <summary>
    /// 订单类型：1：预付5：面付6：信用住
    /// </summary>
    [JsonPropertyName("order_type")]
    public decimal? OrderType { get; set; }

    /// <summary>
    /// 入住人列表。
    /// </summary>
    [JsonPropertyName("user_affiliate_list")]
    public List<PostTopapiAliTripBTripHotelOrderSearchResponseModuleItemUserAffiliateListItem> UserAffiliateList { get; set; } = [];

    /// <summary>
    /// 第三方申请单ID。
    /// </summary>
    [JsonPropertyName("thirdpart_apply_id")]
    public string? ThirdpartApplyId { get; set; }

    /// <summary>
    /// 申请单名称。
    /// </summary>
    [JsonPropertyName("btrip_title")]
    public string? BTripTitle { get; set; }
}

/// <summary>
/// 获取企业商旅酒店订单数据响应
/// </summary>
public class PostTopapiAliTripBTripHotelOrderSearchResponse
{
    /// <summary>
    /// 操作是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 酒店订单列表。
    /// </summary>
    [JsonPropertyName("module")]
    public List<PostTopapiAliTripBTripHotelOrderSearchResponseModuleItem> Module { get; set; } = [];
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripTrainOrderSearchRequestRq
{
    /// <summary>
    /// 开始时间。
    /// </summary>
    [JsonPropertyName("start_time")]
    public string? StartTime { get; set; }

    /// <summary>
    /// 商旅审批单ID。
    /// </summary>
    [JsonPropertyName("apply_id")]
    public decimal? ApplyId { get; set; }

    /// <summary>
    /// 页数，从1开始。
    /// </summary>
    [JsonPropertyName("page")]
    public decimal? Page { get; set; }

    /// <summary>
    /// 用户的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 每页返回数量，默认10，最大50。
    /// </summary>
    [JsonPropertyName("page_size")]
    public decimal? PageSize { get; set; }

    /// <summary>
    /// 部门ID。
    /// </summary>
    [JsonPropertyName("deptid")]
    public string? Deptid { get; set; }

    /// <summary>
    /// 结束时间。
    /// </summary>
    [JsonPropertyName("end_time")]
    public string? EndTime { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }

    /// <summary>
    /// 更新结束时间。
    /// </summary>
    [JsonPropertyName("update_end_time")]
    public string? UpdateEndTime { get; set; }

    /// <summary>
    /// 更新开始时间
    /// </summary>
    [JsonPropertyName("update_start_time")]
    public string? UpdateStartTime { get; set; }

    /// <summary>
    /// false：仅搜索未报销的订单。
    /// </summary>
    [JsonPropertyName("all_apply")]
    public bool? AllApply { get; set; }

    /// <summary>
    /// 第三方申请单ID。
    /// </summary>
    [JsonPropertyName("thirdpart_apply_id")]
    public string? ThirdpartApplyId { get; set; }
}

/// <summary>
/// 获取企业火车票订单数据请求
/// </summary>
public class PostTopapiAliTripBTripTrainOrderSearchRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("rq")]
    public required PostTopapiAliTripBTripTrainOrderSearchRequestRq Rq { get; set; }
}

/// <summary>
/// 发票对象。
/// </summary>
public class PostTopapiAliTripBTripTrainOrderSearchResponseTrainOrderListItemInvoice
{
    /// <summary>
    /// 商旅发票ID。
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// 发票抬头。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// 成本中心对象。
/// </summary>
public class PostTopapiAliTripBTripTrainOrderSearchResponseTrainOrderListItemCostCenter
{
    /// <summary>
    /// 商旅成本中心ID。
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public string? Corpid { get; set; }

    /// <summary>
    /// 成本中心编号。
    /// </summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>
    /// 成本中心名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripTrainOrderSearchResponseTrainOrderListItemPriceInfoListItem
/// </summary>
public class PostTopapiAliTripBTripTrainOrderSearchResponseTrainOrderListItemPriceInfoListItem
{
    /// <summary>
    /// 价格。
    /// </summary>
    [JsonPropertyName("price")]
    public string? Price { get; set; }

    /// <summary>
    /// 资金流向：1：支出2：收入
    /// </summary>
    [JsonPropertyName("type")]
    public decimal? Type { get; set; }

    /// <summary>
    /// 消费类型。
    /// </summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>
    /// 结算方式：1：个人现付2：企业现付4：企业月结8：企业预存
    /// </summary>
    [JsonPropertyName("pay_type")]
    public decimal? PayType { get; set; }

    /// <summary>
    /// 流水创建时间。
    /// </summary>
    [JsonPropertyName("gmt_create")]
    public string? GmtCreate { get; set; }

    /// <summary>
    /// 乘车人名称，多个用‘,’分割。
    /// </summary>
    [JsonPropertyName("passenger_name")]
    public string? PassengerName { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripTrainOrderSearchResponseTrainOrderListItemUserAffiliateListItem
/// </summary>
public class PostTopapiAliTripBTripTrainOrderSearchResponseTrainOrderListItemUserAffiliateListItem
{
    /// <summary>
    /// 乘车人userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 乘车人姓名。
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripTrainOrderSearchResponseTrainOrderListItem
/// </summary>
public class PostTopapiAliTripBTripTrainOrderSearchResponseTrainOrderListItem
{
    /// <summary>
    /// 订单ID。
    /// </summary>
    [JsonPropertyName("id")]
    public decimal? Id { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    [JsonPropertyName("gmt_create")]
    public string? GmtCreate { get; set; }

    /// <summary>
    /// 更新时间。
    /// </summary>
    [JsonPropertyName("gmt_modified")]
    public string? GmtModified { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public string? Corpid { get; set; }

    /// <summary>
    /// 企业名称。
    /// </summary>
    [JsonPropertyName("corp_name")]
    public string? CorpName { get; set; }

    /// <summary>
    /// 用户的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 用户姓名。
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }

    /// <summary>
    /// 部门ID。
    /// </summary>
    [JsonPropertyName("deptid")]
    public string? Deptid { get; set; }

    /// <summary>
    /// 部门名称。
    /// </summary>
    [JsonPropertyName("dept_name")]
    public string? DeptName { get; set; }

    /// <summary>
    /// 商旅审批单ID。
    /// </summary>
    [JsonPropertyName("apply_id")]
    public decimal? ApplyId { get; set; }

    /// <summary>
    /// 联系人姓名。
    /// </summary>
    [JsonPropertyName("contact_name")]
    public string? ContactName { get; set; }

    /// <summary>
    /// 出发站。
    /// </summary>
    [JsonPropertyName("dep_station")]
    public string? DepStation { get; set; }

    /// <summary>
    /// 到达站。
    /// </summary>
    [JsonPropertyName("arr_station")]
    public string? ArrStation { get; set; }

    /// <summary>
    /// 出发时间。
    /// </summary>
    [JsonPropertyName("dep_time")]
    public string? DepTime { get; set; }

    /// <summary>
    /// 到达时间。
    /// </summary>
    [JsonPropertyName("arr_time")]
    public string? ArrTime { get; set; }

    /// <summary>
    /// 车次。
    /// </summary>
    [JsonPropertyName("train_number")]
    public string? TrainNumber { get; set; }

    /// <summary>
    /// 车次类型。
    /// </summary>
    [JsonPropertyName("train_type")]
    public string? TrainType { get; set; }

    /// <summary>
    /// 座位类型。
    /// </summary>
    [JsonPropertyName("seat_type")]
    public string? SeatType { get; set; }

    /// <summary>
    /// 运行时长。
    /// </summary>
    [JsonPropertyName("run_time")]
    public string? RunTime { get; set; }

    /// <summary>
    /// 12306票号。
    /// </summary>
    [JsonPropertyName("ticket_no_12306")]
    public string? TicketNo12306 { get; set; }

    /// <summary>
    /// 出发城市。
    /// </summary>
    [JsonPropertyName("dep_city")]
    public string? DepCity { get; set; }

    /// <summary>
    /// 到达城市。
    /// </summary>
    [JsonPropertyName("arr_city")]
    public string? ArrCity { get; set; }

    /// <summary>
    /// 乘客姓名。
    /// </summary>
    [JsonPropertyName("rider_name")]
    public string? RiderName { get; set; }

    /// <summary>
    /// 票的数量。
    /// </summary>
    [JsonPropertyName("ticket_count")]
    public decimal? TicketCount { get; set; }

    /// <summary>
    /// 订单状态：0：待支付1：出票中2：已关闭3：改签成功4：退票成功5：出票完成6：退票申请中7：改签申请中8：已出票/已发货9：出票失败10：改签失败11：退票失败
    /// </summary>
    [JsonPropertyName("status")]
    public decimal? Status { get; set; }

    /// <summary>
    /// 发票对象。
    /// </summary>
    [JsonPropertyName("invoice")]
    public PostTopapiAliTripBTripTrainOrderSearchResponseTrainOrderListItemInvoice? Invoice { get; set; }

    /// <summary>
    /// 成本中心对象。
    /// </summary>
    [JsonPropertyName("cost_center")]
    public PostTopapiAliTripBTripTrainOrderSearchResponseTrainOrderListItemCostCenter? CostCenter { get; set; }

    /// <summary>
    /// 价目信息。
    /// </summary>
    [JsonPropertyName("price_info_list")]
    public List<PostTopapiAliTripBTripTrainOrderSearchResponseTrainOrderListItemPriceInfoListItem> PriceInfoList { get; set; } = [];

    /// <summary>
    /// 第三方行程ID。
    /// </summary>
    [JsonPropertyName("thirdpart_itinerary_id")]
    public string? ThirdpartItineraryId { get; set; }

    /// <summary>
    /// 乘车人列表。
    /// </summary>
    [JsonPropertyName("user_affiliate_list")]
    public List<PostTopapiAliTripBTripTrainOrderSearchResponseTrainOrderListItemUserAffiliateListItem> UserAffiliateList { get; set; } = [];

    /// <summary>
    /// 第三方申请单ID。
    /// </summary>
    [JsonPropertyName("thirdpart_apply_id")]
    public string? ThirdpartApplyId { get; set; }

    /// <summary>
    /// 申请单名称。
    /// </summary>
    [JsonPropertyName("btrip_title")]
    public string? BTripTitle { get; set; }
}

/// <summary>
/// 获取企业火车票订单数据响应
/// </summary>
public class PostTopapiAliTripBTripTrainOrderSearchResponse
{
    /// <summary>
    /// 操作是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 火车票订单列表。
    /// </summary>
    [JsonPropertyName("train_order_list")]
    public List<PostTopapiAliTripBTripTrainOrderSearchResponseTrainOrderListItem> TrainOrderList { get; set; } = [];
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripVehicleOrderSearchRequestRq
{
    /// <summary>
    /// 创建开始时间。
    /// </summary>
    [JsonPropertyName("start_time")]
    public string? StartTime { get; set; }

    /// <summary>
    /// 更新结束时间。
    /// </summary>
    [JsonPropertyName("update_end_time")]
    public string? UpdateEndTime { get; set; }

    /// <summary>
    /// 商旅审批单ID。
    /// </summary>
    [JsonPropertyName("apply_id")]
    public decimal? ApplyId { get; set; }

    /// <summary>
    /// 页数，从1开始。
    /// </summary>
    [JsonPropertyName("page")]
    public decimal? Page { get; set; }

    /// <summary>
    /// 用户userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 每页数量，默认10，最大50。
    /// </summary>
    [JsonPropertyName("page_size")]
    public decimal? PageSize { get; set; }

    /// <summary>
    /// 部门ID。
    /// </summary>
    [JsonPropertyName("deptid")]
    public string? Deptid { get; set; }

    /// <summary>
    /// 创建结束时间。
    /// </summary>
    [JsonPropertyName("end_time")]
    public string? EndTime { get; set; }

    /// <summary>
    /// 更新开始时间。
    /// </summary>
    [JsonPropertyName("update_start_time")]
    public string? UpdateStartTime { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }

    /// <summary>
    /// false：仅搜索未报销订单。
    /// </summary>
    [JsonPropertyName("all_apply")]
    public bool? AllApply { get; set; }

    /// <summary>
    /// 第三方申请单ID。
    /// </summary>
    [JsonPropertyName("thirdpart_apply_id")]
    public string? ThirdpartApplyId { get; set; }
}

/// <summary>
/// 获取用车订单数据请求
/// </summary>
public class PostTopapiAliTripBTripVehicleOrderSearchRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("rq")]
    public required PostTopapiAliTripBTripVehicleOrderSearchRequestRq Rq { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripVehicleOrderSearchResponseVehicleOrderListItemPriceInfoListItem
/// </summary>
public class PostTopapiAliTripBTripVehicleOrderSearchResponseVehicleOrderListItemPriceInfoListItem
{
    /// <summary>
    /// 价格。
    /// </summary>
    [JsonPropertyName("price")]
    public string? Price { get; set; }

    /// <summary>
    /// 资金流向：1：支出2：收入
    /// </summary>
    [JsonPropertyName("type")]
    public decimal? Type { get; set; }

    /// <summary>
    /// 交易类型：用车支付, 服务费用车取消后收费用车退款, 用车赔付
    /// </summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>
    /// 结算方式：1：个人现付2：企业现付4：企业月结8：企业预存
    /// </summary>
    [JsonPropertyName("pay_type")]
    public decimal? PayType { get; set; }

    /// <summary>
    /// 流水创建时间。
    /// </summary>
    [JsonPropertyName("gmt_create")]
    public string? GmtCreate { get; set; }

    /// <summary>
    /// 出行人，多个用‘,’分割。
    /// </summary>
    [JsonPropertyName("passenger_name")]
    public string? PassengerName { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripVehicleOrderSearchResponseVehicleOrderListItemUserAffiliateListItem
/// </summary>
public class PostTopapiAliTripBTripVehicleOrderSearchResponseVehicleOrderListItemUserAffiliateListItem
{
    /// <summary>
    /// 出行人userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 出行人姓名。
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripVehicleOrderSearchResponseVehicleOrderListItem
/// </summary>
public class PostTopapiAliTripBTripVehicleOrderSearchResponseVehicleOrderListItem
{
    /// <summary>
    /// 订单ID。
    /// </summary>
    [JsonPropertyName("id")]
    public decimal? Id { get; set; }

    /// <summary>
    /// 订单创建时间。
    /// </summary>
    [JsonPropertyName("gmt_create")]
    public string? GmtCreate { get; set; }

    /// <summary>
    /// 订单更新时间。
    /// </summary>
    [JsonPropertyName("gmt_modified")]
    public string? GmtModified { get; set; }

    /// <summary>
    /// 乘客名称。
    /// </summary>
    [JsonPropertyName("passenger_name")]
    public string? PassengerName { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public string? Corpid { get; set; }

    /// <summary>
    /// 企业名称。
    /// </summary>
    [JsonPropertyName("corp_name")]
    public string? CorpName { get; set; }

    /// <summary>
    /// 预定人姓名。
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }

    /// <summary>
    /// 预定人userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 部门名称。
    /// </summary>
    [JsonPropertyName("dept_name")]
    public string? DeptName { get; set; }

    /// <summary>
    /// 部门ID。
    /// </summary>
    [JsonPropertyName("deptid")]
    public string? Deptid { get; set; }

    /// <summary>
    /// 商旅审批单展示ID。
    /// </summary>
    [JsonPropertyName("apply_show_id")]
    public string? ApplyShowId { get; set; }

    /// <summary>
    /// 商旅系统审批单ID。
    /// </summary>
    [JsonPropertyName("apply_id")]
    public decimal? ApplyId { get; set; }

    /// <summary>
    /// 实际出发城市。
    /// </summary>
    [JsonPropertyName("real_from_city_name")]
    public string? RealFromCityName { get; set; }

    /// <summary>
    /// 实际到达城市。
    /// </summary>
    [JsonPropertyName("real_to_city_name")]
    public string? RealToCityName { get; set; }

    /// <summary>
    /// 出发地。
    /// </summary>
    [JsonPropertyName("from_address")]
    public string? FromAddress { get; set; }

    /// <summary>
    /// 目的地。
    /// </summary>
    [JsonPropertyName("to_address")]
    public string? ToAddress { get; set; }

    /// <summary>
    /// 出发城市。
    /// </summary>
    [JsonPropertyName("from_city_name")]
    public string? FromCityName { get; set; }

    /// <summary>
    /// 目的城市。
    /// </summary>
    [JsonPropertyName("to_city_name")]
    public string? ToCityName { get; set; }

    /// <summary>
    /// 打车事由。
    /// </summary>
    [JsonPropertyName("memo")]
    public string? Memo { get; set; }

    /// <summary>
    /// 订单状态：0：初始状态1：已超时2：派单成功3：派单失败4：已退款5：已支付6：已取消
    /// </summary>
    [JsonPropertyName("order_status")]
    public decimal? OrderStatus { get; set; }

    /// <summary>
    /// 类型级别：1：经济型2：舒适型3：豪华型
    /// </summary>
    [JsonPropertyName("car_level")]
    public string? CarLevel { get; set; }

    /// <summary>
    /// 车辆类型。
    /// </summary>
    [JsonPropertyName("car_info")]
    public string? CarInfo { get; set; }

    /// <summary>
    /// 订单预估价格。
    /// </summary>
    [JsonPropertyName("estimate_price")]
    public string? EstimatePrice { get; set; }

    /// <summary>
    /// 乘客发布用车时间。
    /// </summary>
    [JsonPropertyName("publish_time")]
    public string? PublishTime { get; set; }

    /// <summary>
    /// 乘客上车时间。
    /// </summary>
    [JsonPropertyName("taken_time")]
    public string? TakenTime { get; set; }

    /// <summary>
    /// 司机到达目的地时间。
    /// </summary>
    [JsonPropertyName("driver_confirm_time")]
    public string? DriverConfirmTime { get; set; }

    /// <summary>
    /// 取消时间。
    /// </summary>
    [JsonPropertyName("cancel_time")]
    public string? CancelTime { get; set; }

    /// <summary>
    /// 行驶公里数。
    /// </summary>
    [JsonPropertyName("travel_distance")]
    public string? TravelDistance { get; set; }

    /// <summary>
    /// 支付时间。
    /// </summary>
    [JsonPropertyName("pay_time")]
    public string? PayTime { get; set; }

    /// <summary>
    /// 打车服务类型：1：出租车2：专车3：快车
    /// </summary>
    [JsonPropertyName("service_type")]
    public decimal? ServiceType { get; set; }

    /// <summary>
    /// 用车原因：TRAVEL: 差旅TRAFFIC: 市内交通WORK: 加班OTHER: 其它
    /// </summary>
    [JsonPropertyName("business_category")]
    public string? BusinessCategory { get; set; }

    /// <summary>
    /// 商旅成本中心ID。
    /// </summary>
    [JsonPropertyName("cost_center_id")]
    public decimal? CostCenterId { get; set; }

    /// <summary>
    /// 成本中心编号。
    /// </summary>
    [JsonPropertyName("cost_center_number")]
    public string? CostCenterNumber { get; set; }

    /// <summary>
    /// 成本中心名称。
    /// </summary>
    [JsonPropertyName("cost_center_name")]
    public string? CostCenterName { get; set; }

    /// <summary>
    /// 商旅发票ID。
    /// </summary>
    [JsonPropertyName("invoice_id")]
    public decimal? InvoiceId { get; set; }

    /// <summary>
    /// 发票抬头。
    /// </summary>
    [JsonPropertyName("invoice_title")]
    public string? InvoiceTitle { get; set; }

    /// <summary>
    /// 项目编号。
    /// </summary>
    [JsonPropertyName("project_code")]
    public string? ProjectCode { get; set; }

    /// <summary>
    /// 项目名称。
    /// </summary>
    [JsonPropertyName("project_title")]
    public string? ProjectTitle { get; set; }

    /// <summary>
    /// 价目详情列表。
    /// </summary>
    [JsonPropertyName("price_info_list")]
    public List<PostTopapiAliTripBTripVehicleOrderSearchResponseVehicleOrderListItemPriceInfoListItem> PriceInfoList { get; set; } = [];

    /// <summary>
    /// 第三方行程ID。
    /// </summary>
    [JsonPropertyName("thirdpart_itinerary_id")]
    public string? ThirdpartItineraryId { get; set; }

    /// <summary>
    /// 出行人列表。
    /// </summary>
    [JsonPropertyName("user_affiliate_list")]
    public List<PostTopapiAliTripBTripVehicleOrderSearchResponseVehicleOrderListItemUserAffiliateListItem> UserAffiliateList { get; set; } = [];

    /// <summary>
    /// 用户确认状态：0：未确认1：已确认2：有异议3：系统检查不合理
    /// </summary>
    [JsonPropertyName("user_confirm")]
    public decimal? UserConfirm { get; set; }

    /// <summary>
    /// 服务商：2：滴滴3：曹操4：首汽5：阳光
    /// </summary>
    [JsonPropertyName("provider")]
    public decimal? Provider { get; set; }

    /// <summary>
    /// 真实出发地。
    /// </summary>
    [JsonPropertyName("real_from_address")]
    public string? RealFromAddress { get; set; }

    /// <summary>
    /// 真实到达地。
    /// </summary>
    [JsonPropertyName("real_to_address")]
    public string? RealToAddress { get; set; }

    /// <summary>
    /// 第三方申请单ID。
    /// </summary>
    [JsonPropertyName("thirdpart_apply_id")]
    public string? ThirdpartApplyId { get; set; }

    /// <summary>
    /// 申请单名称。
    /// </summary>
    [JsonPropertyName("btrip_title")]
    public string? BTripTitle { get; set; }
}

/// <summary>
/// 获取用车订单数据响应
/// </summary>
public class PostTopapiAliTripBTripVehicleOrderSearchResponse
{
    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 操作是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 订单列表。
    /// </summary>
    [JsonPropertyName("vehicle_order_list")]
    public List<PostTopapiAliTripBTripVehicleOrderSearchResponseVehicleOrderListItem> VehicleOrderList { get; set; } = [];
}

/// <summary>
/// GetV1AliTripUnionOrdersResponseFlightListItem
/// </summary>
public class GetV1AliTripUnionOrdersResponseFlightListItem
{
    /// <summary>
    /// 飞机票订单ID。
    /// </summary>
    [JsonPropertyName("flightOrderId")]
    public long? FlightOrderId { get; set; }

    /// <summary>
    /// 订单状态，取值：
    /// </summary>
    [JsonPropertyName("flightOrderStatus")]
    public long? FlightOrderStatus { get; set; }
}

/// <summary>
/// GetV1AliTripUnionOrdersResponseTrainListItem
/// </summary>
public class GetV1AliTripUnionOrdersResponseTrainListItem
{
    /// <summary>
    /// 火车票订单号。
    /// </summary>
    [JsonPropertyName("trainOrderId")]
    public long? TrainOrderId { get; set; }

    /// <summary>
    /// 订单状态，取值：
    /// </summary>
    [JsonPropertyName("trainOrderstatus")]
    public long? TrainOrderstatus { get; set; }
}

/// <summary>
/// GetV1AliTripUnionOrdersResponseHotelListItem
/// </summary>
public class GetV1AliTripUnionOrdersResponseHotelListItem
{
    /// <summary>
    /// 酒店订单号。
    /// </summary>
    [JsonPropertyName("hotelOrderId")]
    public long? HotelOrderId { get; set; }

    /// <summary>
    /// 订单状态，取值：
    /// </summary>
    [JsonPropertyName("hotelOrderStatus")]
    public long? HotelOrderStatus { get; set; }
}

/// <summary>
/// GetV1AliTripUnionOrdersResponseVehicleListItem
/// </summary>
public class GetV1AliTripUnionOrdersResponseVehicleListItem
{
    /// <summary>
    /// 用车订单号。
    /// </summary>
    [JsonPropertyName("vehicleOrderId")]
    public long? VehicleOrderId { get; set; }

    /// <summary>
    /// 订单状态，取值：
    /// </summary>
    [JsonPropertyName("vehicleOrderStatus")]
    public long? VehicleOrderStatus { get; set; }
}

/// <summary>
/// 关联单号查询相关订单信息列表响应
/// </summary>
public class GetV1AliTripUnionOrdersResponse
{
    /// <summary>
    /// 飞机订单信息列表。
    /// </summary>
    [JsonPropertyName("flightList")]
    public List<GetV1AliTripUnionOrdersResponseFlightListItem> FlightList { get; set; } = [];

    /// <summary>
    /// 企业corpId。
    /// </summary>
    [JsonPropertyName("corpId")]
    public string? CorpId { get; set; }

    /// <summary>
    /// 火车订单信息列表。
    /// </summary>
    [JsonPropertyName("trainList")]
    public List<GetV1AliTripUnionOrdersResponseTrainListItem> TrainList { get; set; } = [];

    /// <summary>
    /// 酒店订单信息列表。
    /// </summary>
    [JsonPropertyName("hotelList")]
    public List<GetV1AliTripUnionOrdersResponseHotelListItem> HotelList { get; set; } = [];

    /// <summary>
    /// 用车订单信息列表。
    /// </summary>
    [JsonPropertyName("vehicleList")]
    public List<GetV1AliTripUnionOrdersResponseVehicleListItem> VehicleList { get; set; } = [];
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripAddressGetRequestRequest
{
    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }

    /// <summary>
    /// 用户userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }

    /// <summary>
    /// 类目类型：1：机票2：火车票3：酒店4：用车
    /// </summary>
    [JsonPropertyName("type")]
    public decimal Type { get; set; }

    /// <summary>
    /// 操作类型：1：预订2：我的订单列表3：商旅管理后台，如果需要获取该场景的地址，只需提供corpid，userid4：商旅h5主页
    /// </summary>
    [JsonPropertyName("action_type")]
    public decimal ActionType { get; set; }

    /// <summary>
    /// 第三方行程ID。存在代表通过审批单预订，不存在代表特殊场景：普通员工是预览，特殊授权人和代订人是免审批预订场景。
    /// </summary>
    [JsonPropertyName("itinerary_id")]
    public string? ItineraryId { get; set; }

    /// <summary>
    /// 员工第一次使用用车需要手机号，与司机联系。
    /// </summary>
    [JsonPropertyName("phone")]
    public string? Phone { get; set; }
}

/// <summary>
/// 获取商旅访问地址请求
/// </summary>
public class PostTopapiAliTripBTripAddressGetRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("request")]
    public PostTopapiAliTripBTripAddressGetRequestRequest? Request { get; set; }
}

/// <summary>
/// 结果对象。
/// </summary>
public class PostTopapiAliTripBTripAddressGetResponseResult
{
    /// <summary>
    /// 访问地址。
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// 获取商旅访问地址响应
/// </summary>
public class PostTopapiAliTripBTripAddressGetResponse
{
    /// <summary>
    /// 操作是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 结果对象。
    /// </summary>
    [JsonPropertyName("result")]
    public PostTopapiAliTripBTripAddressGetResponseResult? Result { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripInvoiceSettingAddRequestRq
{
    /// <summary>
    /// 企业的corpid，可登录开发者后台查看。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }

    /// <summary>
    /// 发票类型：1：增值税普通发票2：增值税专用发票
    /// </summary>
    [JsonPropertyName("type")]
    public decimal Type { get; set; }

    /// <summary>
    /// 发票抬头。
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    /// <summary>
    /// 纳税人识别号。
    /// </summary>
    [JsonPropertyName("tax_no")]
    public required string TaxNo { get; set; }

    /// <summary>
    /// 开户行。
    /// </summary>
    [JsonPropertyName("bank_name")]
    public string? BankName { get; set; }

    /// <summary>
    /// 注册地址。
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// 公司电话。
    /// </summary>
    [JsonPropertyName("tel")]
    public string? Tel { get; set; }

    /// <summary>
    /// 银行账号。
    /// </summary>
    [JsonPropertyName("bank_no")]
    public string? BankNo { get; set; }

    /// <summary>
    /// 第三方发票id。
    /// </summary>
    [JsonPropertyName("third_part_id")]
    public required string ThirdPartId { get; set; }
}

/// <summary>
/// 新增发票配置请求
/// </summary>
public class PostTopapiAliTripBTripInvoiceSettingAddRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("rq")]
    public required PostTopapiAliTripBTripInvoiceSettingAddRequestRq Rq { get; set; }
}

/// <summary>
/// 新增发票配置响应
/// </summary>
public class PostTopapiAliTripBTripInvoiceSettingAddResponse
{
    /// <summary>
    /// 操作是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 结果值。
    /// </summary>
    [JsonPropertyName("module")]
    public decimal? Module { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("")]
    public string? Value { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripInvoiceSettingRuleRequestRequestEntitiesItem
/// </summary>
public class PostTopapiAliTripBTripInvoiceSettingRuleRequestRequestEntitiesItem
{
    /// <summary>
    /// 人员名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 人员id。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// 1：员工
    /// </summary>
    [JsonPropertyName("type")]
    public decimal Type { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripInvoiceSettingRuleRequestRequest
{
    /// <summary>
    /// 企业的corpid，可登录开发者后台查看。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }

    /// <summary>
    /// 人员列表。
    /// </summary>
    [JsonPropertyName("entities")]
    public List<PostTopapiAliTripBTripInvoiceSettingRuleRequestRequestEntitiesItem> Entities { get; set; } = [];

    /// <summary>
    /// 是否适用所有员工。true：是false：否
    /// </summary>
    [JsonPropertyName("all_employe")]
    public bool AllEmploye { get; set; }

    /// <summary>
    /// 第三方发票id。
    /// </summary>
    [JsonPropertyName("third_part_id")]
    public required string ThirdPartId { get; set; }
}

/// <summary>
/// 配置发票适用人群请求
/// </summary>
public class PostTopapiAliTripBTripInvoiceSettingRuleRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("request")]
    public required PostTopapiAliTripBTripInvoiceSettingRuleRequestRequest Request { get; set; }
}

/// <summary>
/// 返回值。
/// </summary>
public class PostTopapiAliTripBTripInvoiceSettingRuleResponseModule
{
    /// <summary>
    /// 新增适用人群数。当配置的发票适用人群列表大于当前适用人群数时，返回该参数。
    /// </summary>
    [JsonPropertyName("add_num")]
    public decimal? AddNum { get; set; }

    /// <summary>
    /// 删除适用人群数。当配置的发票适用人群列表少于当前的适用人群数时，返回该参数。
    /// </summary>
    [JsonPropertyName("remove_num")]
    public decimal? RemoveNum { get; set; }
}

/// <summary>
/// 配置发票适用人群响应
/// </summary>
public class PostTopapiAliTripBTripInvoiceSettingRuleResponse
{
    /// <summary>
    /// 操作是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 返回值。
    /// </summary>
    [JsonPropertyName("module")]
    public PostTopapiAliTripBTripInvoiceSettingRuleResponseModule? Module { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripInvoiceSearchRequestRq
{
    /// <summary>
    /// 发票抬头。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 用户的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }
}

/// <summary>
/// 查询可用发票列表请求
/// </summary>
public class PostTopapiAliTripBTripInvoiceSearchRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("rq")]
    public required PostTopapiAliTripBTripInvoiceSearchRequestRq Rq { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripInvoiceSearchResponseInvoiceItem
/// </summary>
public class PostTopapiAliTripBTripInvoiceSearchResponseInvoiceItem
{
    /// <summary>
    /// 商旅发票id。
    /// </summary>
    [JsonPropertyName("id")]
    public decimal? Id { get; set; }

    /// <summary>
    /// 发票抬头。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// 查询可用发票列表响应
/// </summary>
public class PostTopapiAliTripBTripInvoiceSearchResponse
{
    /// <summary>
    /// 发票列表。
    /// </summary>
    [JsonPropertyName("invoice")]
    public List<PostTopapiAliTripBTripInvoiceSearchResponseInvoiceItem> Invoice { get; set; } = [];

    /// <summary>
    /// 操作是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 返回信息。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripInvoiceSettingModifyRequestRequest
{
    /// <summary>
    /// 注册地址。
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// 企业的corpid，可登录开发者后台查看。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }

    /// <summary>
    /// 开户行。
    /// </summary>
    [JsonPropertyName("bank_name")]
    public string? BankName { get; set; }

    /// <summary>
    /// 发票类型：1：增值税普通发票2：增值税专用发票
    /// </summary>
    [JsonPropertyName("type")]
    public decimal Type { get; set; }

    /// <summary>
    /// 发票抬头。
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    /// <summary>
    /// 公司电话。
    /// </summary>
    [JsonPropertyName("tel")]
    public string? Tel { get; set; }

    /// <summary>
    /// 纳税人识别号。
    /// </summary>
    [JsonPropertyName("tax_no")]
    public string? TaxNo { get; set; }

    /// <summary>
    /// 银行账号。
    /// </summary>
    [JsonPropertyName("bank_no")]
    public string? BankNo { get; set; }

    /// <summary>
    /// 第三方发票id。
    /// </summary>
    [JsonPropertyName("third_part_id")]
    public required string ThirdPartId { get; set; }
}

/// <summary>
/// 修改发票配置请求
/// </summary>
public class PostTopapiAliTripBTripInvoiceSettingModifyRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("request")]
    public PostTopapiAliTripBTripInvoiceSettingModifyRequestRequest? Request { get; set; }
}

/// <summary>
/// 修改发票配置响应
/// </summary>
public class PostTopapiAliTripBTripInvoiceSettingModifyResponse
{
    /// <summary>
    /// 操作是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 返回值。
    /// </summary>
    [JsonPropertyName("module")]
    public decimal? Module { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripInvoiceSettingDeleteRequestRequest
{
    /// <summary>
    /// 企业的corpid，可登录开发者后台查看。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }

    /// <summary>
    /// 第三方发票id。
    /// </summary>
    [JsonPropertyName("third_part_id")]
    public required string ThirdPartId { get; set; }
}

/// <summary>
/// 删除发票信息请求
/// </summary>
public class PostTopapiAliTripBTripInvoiceSettingDeleteRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("request")]
    public PostTopapiAliTripBTripInvoiceSettingDeleteRequestRequest? Request { get; set; }
}

/// <summary>
/// 删除发票信息响应
/// </summary>
public class PostTopapiAliTripBTripInvoiceSettingDeleteResponse
{
    /// <summary>
    /// 操作是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 返回值。
    /// </summary>
    [JsonPropertyName("module")]
    public bool? Module { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 同步市内用车申请单请求
/// </summary>
public class PostV1AliTripCityCarApprovalsRequest
{
    /// <summary>
    /// 出差事由。
    /// </summary>
    [JsonPropertyName("cause")]
    public required string Cause { get; set; }

    /// <summary>
    /// 用车城市。
    /// </summary>
    [JsonPropertyName("city")]
    public required string City { get; set; }

    /// <summary>
    /// 第三方企业的corpid。
    /// </summary>
    [JsonPropertyName("corpId")]
    public required string CorpId { get; set; }

    /// <summary>
    /// 用车时间，按天管控，比如传值2021-03-18 20:26:56表示2021-03-18当天可用车，跨天情况配合finishedDate参数使用
    /// </summary>
    [JsonPropertyName("date")]
    public required string Date { get; set; }

    /// <summary>
    /// 审批单关联的项目code。
    /// </summary>
    [JsonPropertyName("projectCode")]
    public string? ProjectCode { get; set; }

    /// <summary>
    /// 审批单关联的项目名。
    /// </summary>
    [JsonPropertyName("projectName")]
    public string? ProjectName { get; set; }

    /// <summary>
    /// 审批单状态：
    /// </summary>
    [JsonPropertyName("status")]
    public long Status { get; set; }

    /// <summary>
    /// 三方审批单ID。
    /// </summary>
    [JsonPropertyName("thirdPartApplyId")]
    public required string ThirdPartApplyId { get; set; }

    /// <summary>
    /// 审批单关联的三方成本中心ID。
    /// </summary>
    [JsonPropertyName("thirdPartCostCenterId")]
    public required string ThirdPartCostCenterId { get; set; }

    /// <summary>
    /// 审批单关联的三方发票抬头ID。
    /// </summary>
    [JsonPropertyName("thirdPartInvoiceId")]
    public required string ThirdPartInvoiceId { get; set; }

    /// <summary>
    /// 审批单可用总次数。
    /// </summary>
    [JsonPropertyName("timesTotal")]
    public long TimesTotal { get; set; }

    /// <summary>
    /// 审批单可用次数类型：如果企业没有限制审批单使用次数的需求，这个参数传1(次数不限制)，同时timesTotal和timesUsed都传0即可
    /// </summary>
    [JsonPropertyName("timesType")]
    public long TimesType { get; set; }

    /// <summary>
    /// 审批单已用次数。
    /// </summary>
    [JsonPropertyName("timesUsed")]
    public long TimesUsed { get; set; }

    /// <summary>
    /// 审批单标题。
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    /// <summary>
    /// 发起审批的第三方员工ID。
    /// </summary>
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }

    /// <summary>
    /// 用车截止时间，按天管控，比如date传值2021-03-18 20:26:56、finishedDate传值2021-03-30 20:26:56表示2021-03-18(含)到2021-03-30(含)之间可用车，该参数不传值情况使用date作为用车截止时间；
    /// </summary>
    [JsonPropertyName("finishedDate")]
    public string? FinishedDate { get; set; }
}

/// <summary>
/// 同步市内用车申请单响应
/// </summary>
public class PostV1AliTripCityCarApprovalsResponse
{
    /// <summary>
    /// 商旅内部审批单ID。
    /// </summary>
    [JsonPropertyName("applyId")]
    public long? ApplyId { get; set; }
}

/// <summary>
/// 审批市内用车申请单请求
/// </summary>
public class PutV1AliTripCityCarApprovalsRequest
{
    /// <summary>
    /// 第三方企业的corpid。
    /// </summary>
    [JsonPropertyName("corpId")]
    public required string CorpId { get; set; }

    /// <summary>
    /// 审批时间，例如2021-03-18 20:26:56。
    /// </summary>
    [JsonPropertyName("operateTime")]
    public string? OperateTime { get; set; }

    /// <summary>
    /// 审批备注。
    /// </summary>
    [JsonPropertyName("remark")]
    public string? Remark { get; set; }

    /// <summary>
    /// 审批结果：
    /// </summary>
    [JsonPropertyName("status")]
    public long Status { get; set; }

    /// <summary>
    /// 第三方审批单ID。
    /// </summary>
    [JsonPropertyName("thirdPartApplyId")]
    public required string ThirdPartApplyId { get; set; }

    /// <summary>
    /// 审批的第三方员工ID。
    /// </summary>
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }
}

/// <summary>
/// 审批市内用车申请单响应
/// </summary>
public class PutV1AliTripCityCarApprovalsResponse
{
    /// <summary>
    /// 审批结果。
    /// </summary>
    [JsonPropertyName("approveResult")]
    public bool? ApproveResult { get; set; }
}

/// <summary>
/// GetV1AliTripCityCarApprovalsResponseApplyListItemApproverListItem
/// </summary>
public class GetV1AliTripCityCarApprovalsResponseApplyListItemApproverListItem
{
    /// <summary>
    /// 审批备注。
    /// </summary>
    [JsonPropertyName("note")]
    public string? Note { get; set; }

    /// <summary>
    /// 审批时间。
    /// </summary>
    [JsonPropertyName("operateTime")]
    public string? OperateTime { get; set; }

    /// <summary>
    /// 审批人排序值。
    /// </summary>
    [JsonPropertyName("order")]
    public long? Order { get; set; }

    /// <summary>
    /// 审批状态：
    /// </summary>
    [JsonPropertyName("status")]
    public long? Status { get; set; }

    /// <summary>
    /// 审批状态描述。
    /// </summary>
    [JsonPropertyName("statusDesc")]
    public string? StatusDesc { get; set; }

    /// <summary>
    /// 审批员工ID。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 审批员工姓名。
    /// </summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>
/// GetV1AliTripCityCarApprovalsResponseApplyListItemItineraryListItem
/// </summary>
public class GetV1AliTripCityCarApprovalsResponseApplyListItemItineraryListItem
{
    /// <summary>
    /// 目的地城市。
    /// </summary>
    [JsonPropertyName("arrCity")]
    public string? ArrCity { get; set; }

    /// <summary>
    /// 目的地城市三字码。
    /// </summary>
    [JsonPropertyName("arrCityCode")]
    public string? ArrCityCode { get; set; }

    /// <summary>
    /// 到达目的地城市时间。
    /// </summary>
    [JsonPropertyName("arrDate")]
    public string? ArrDate { get; set; }

    /// <summary>
    /// 商旅内部成本中心ID。
    /// </summary>
    [JsonPropertyName("costCenterId")]
    public long? CostCenterId { get; set; }

    /// <summary>
    /// 成本中心名称。
    /// </summary>
    [JsonPropertyName("costCenterName")]
    public string? CostCenterName { get; set; }

    /// <summary>
    /// 出发城市。
    /// </summary>
    [JsonPropertyName("depCity")]
    public string? DepCity { get; set; }

    /// <summary>
    /// 出发城市三字码。
    /// </summary>
    [JsonPropertyName("depCityCode")]
    public string? DepCityCode { get; set; }

    /// <summary>
    /// 出发时间。
    /// </summary>
    [JsonPropertyName("depDate")]
    public string? DepDate { get; set; }

    /// <summary>
    /// 商旅内部发票抬头ID。
    /// </summary>
    [JsonPropertyName("invoiceId")]
    public long? InvoiceId { get; set; }

    /// <summary>
    /// 发票抬头名称。
    /// </summary>
    [JsonPropertyName("invoiceName")]
    public string? InvoiceName { get; set; }

    /// <summary>
    /// 商旅内部行程单ID。
    /// </summary>
    [JsonPropertyName("itineraryId")]
    public string? ItineraryId { get; set; }

    /// <summary>
    /// 项目code。
    /// </summary>
    [JsonPropertyName("projectCode")]
    public string? ProjectCode { get; set; }

    /// <summary>
    /// 项目名称。
    /// </summary>
    [JsonPropertyName("projectTitle")]
    public string? ProjectTitle { get; set; }

    /// <summary>
    /// 交通方式：
    /// </summary>
    [JsonPropertyName("trafficType")]
    public long? TrafficType { get; set; }
}

/// <summary>
/// GetV1AliTripCityCarApprovalsResponseApplyListItem
/// </summary>
public class GetV1AliTripCityCarApprovalsResponseApplyListItem
{
    /// <summary>
    /// 审批单列表。
    /// </summary>
    [JsonPropertyName("approverList")]
    public List<GetV1AliTripCityCarApprovalsResponseApplyListItemApproverListItem> ApproverList { get; set; } = [];

    /// <summary>
    /// 员工所在部门ID。
    /// </summary>
    [JsonPropertyName("departId")]
    public string? DepartId { get; set; }

    /// <summary>
    /// 员工所在部门。
    /// </summary>
    [JsonPropertyName("departName")]
    public string? DepartName { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    [JsonPropertyName("gmtCreate")]
    public string? GmtCreate { get; set; }

    /// <summary>
    /// 最近修改时间。
    /// </summary>
    [JsonPropertyName("gmtModified")]
    public string? GmtModified { get; set; }

    /// <summary>
    /// 审批单关联的行程。
    /// </summary>
    [JsonPropertyName("itineraryList")]
    public List<GetV1AliTripCityCarApprovalsResponseApplyListItemItineraryListItem> ItineraryList { get; set; } = [];

    /// <summary>
    /// 审批单状态：
    /// </summary>
    [JsonPropertyName("status")]
    public long? Status { get; set; }

    /// <summary>
    /// 审批单状态：
    /// </summary>
    [JsonPropertyName("statusDesc")]
    public string? StatusDesc { get; set; }

    /// <summary>
    /// 三方审批单ID。
    /// </summary>
    [JsonPropertyName("thirdPartApplyId")]
    public string? ThirdPartApplyId { get; set; }

    /// <summary>
    /// 申请事由。
    /// </summary>
    [JsonPropertyName("tripCause")]
    public string? TripCause { get; set; }

    /// <summary>
    /// 审批单标题。
    /// </summary>
    [JsonPropertyName("tripTitle")]
    public string? TripTitle { get; set; }

    /// <summary>
    /// 发起审批员工userid。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 发起审批员工名。
    /// </summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>
/// 查询市内用车申请单响应
/// </summary>
public class GetV1AliTripCityCarApprovalsResponse
{
    /// <summary>
    /// 审批单列表。
    /// </summary>
    [JsonPropertyName("applyList")]
    public List<GetV1AliTripCityCarApprovalsResponseApplyListItem> ApplyList { get; set; } = [];

    /// <summary>
    /// 总数。
    /// </summary>
    [JsonPropertyName("total")]
    public long? Total { get; set; }
}

/// <summary>
/// GetV1AliTripBillSettlementsCarsResponseModuleDataListItem
/// </summary>
public class GetV1AliTripBillSettlementsCarsResponseModuleDataListItem
{
    /// <summary>
    /// 支付交易流水号。
    /// </summary>
    [JsonPropertyName("alipayTradeNo")]
    public string? AlipayTradeNo { get; set; }

    /// <summary>
    /// 审批单号。
    /// </summary>
    [JsonPropertyName("applyId")]
    public string? ApplyId { get; set; }

    /// <summary>
    /// 到达城市。
    /// </summary>
    [JsonPropertyName("arrCity")]
    public string? ArrCity { get; set; }

    /// <summary>
    /// 到达日期。
    /// </summary>
    [JsonPropertyName("arrDate")]
    public string? ArrDate { get; set; }

    /// <summary>
    /// 到达地。
    /// </summary>
    [JsonPropertyName("arrLocation")]
    public string? ArrLocation { get; set; }

    /// <summary>
    /// 到达时间。
    /// </summary>
    [JsonPropertyName("arrTime")]
    public string? ArrTime { get; set; }

    /// <summary>
    /// 预定时间。
    /// </summary>
    [JsonPropertyName("bookTime")]
    public string? BookTime { get; set; }

    /// <summary>
    /// 预定人use id。
    /// </summary>
    [JsonPropertyName("bookerId")]
    public string? BookerId { get; set; }

    /// <summary>
    /// 预订人名称。
    /// </summary>
    [JsonPropertyName("bookerName")]
    public string? BookerName { get; set; }

    /// <summary>
    /// 用车原因。
    /// </summary>
    [JsonPropertyName("businessCategory")]
    public string? BusinessCategory { get; set; }

    /// <summary>
    /// 资金方向： 1：支出 2：收入
    /// </summary>
    [JsonPropertyName("capitalDirection")]
    public string? CapitalDirection { get; set; }

    /// <summary>
    /// 车型。
    /// </summary>
    [JsonPropertyName("carLevel")]
    public string? CarLevel { get; set; }

    /// <summary>
    /// 级联部门。
    /// </summary>
    [JsonPropertyName("cascadeDepartment")]
    public string? CascadeDepartment { get; set; }

    /// <summary>
    /// 成本中心名称。
    /// </summary>
    [JsonPropertyName("costCenter")]
    public string? CostCenter { get; set; }

    /// <summary>
    /// 成本中心编号。
    /// </summary>
    [JsonPropertyName("costCenterNumber")]
    public string? CostCenterNumber { get; set; }

    /// <summary>
    /// 优惠券。
    /// </summary>
    [JsonPropertyName("coupon")]
    public long? Coupon { get; set; }

    /// <summary>
    /// 优惠金额。
    /// </summary>
    [JsonPropertyName("couponPrice")]
    public long? CouponPrice { get; set; }

    /// <summary>
    /// 末级部门。
    /// </summary>
    [JsonPropertyName("department")]
    public string? Department { get; set; }

    /// <summary>
    /// 部门id。
    /// </summary>
    [JsonPropertyName("departmentId")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// 出发城市。
    /// </summary>
    [JsonPropertyName("deptCity")]
    public string? DeptCity { get; set; }

    /// <summary>
    /// 出发日期。
    /// </summary>
    [JsonPropertyName("deptDate")]
    public string? DeptDate { get; set; }

    /// <summary>
    /// 出发地。
    /// </summary>
    [JsonPropertyName("deptLocation")]
    public string? DeptLocation { get; set; }

    /// <summary>
    /// 出发时间。
    /// </summary>
    [JsonPropertyName("deptTime")]
    public string? DeptTime { get; set; }

    /// <summary>
    /// 预估行驶距离。
    /// </summary>
    [JsonPropertyName("estimateDriveDistance")]
    public string? EstimateDriveDistance { get; set; }

    /// <summary>
    /// 预估金额。
    /// </summary>
    [JsonPropertyName("estimatePrice")]
    public decimal? EstimatePrice { get; set; }

    /// <summary>
    /// 费用类型： 10101：机票预订 10202：机票改签手续费 10203：机票改签差价 10301：机票退款 10302：机票改签退款 10303：机票补退 10401：机票保险-航意险购买 10501：机票保险-航意险退保 11001：机票的预订服务费 11002：机票改签服务费 20101：酒店预订 20103：酒店退款 20111：酒店预订服务费...
    /// </summary>
    [JsonPropertyName("feeType")]
    public string? FeeType { get; set; }

    /// <summary>
    /// 序号。
    /// </summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>
    /// 发票抬头。
    /// </summary>
    [JsonPropertyName("invoiceTitle")]
    public string? InvoiceTitle { get; set; }

    /// <summary>
    /// 用车事由。
    /// </summary>
    [JsonPropertyName("memo")]
    public string? Memo { get; set; }

    /// <summary>
    /// 订单id。
    /// </summary>
    [JsonPropertyName("orderId")]
    public string? OrderId { get; set; }

    /// <summary>
    /// 订单金额。
    /// </summary>
    [JsonPropertyName("orderPrice")]
    public decimal? OrderPrice { get; set; }

    /// <summary>
    /// 超标审批单号。
    /// </summary>
    [JsonPropertyName("overApplyId")]
    public string? OverApplyId { get; set; }

    /// <summary>
    /// 个人支付金额。
    /// </summary>
    [JsonPropertyName("personSettleFee")]
    public long? PersonSettleFee { get; set; }

    /// <summary>
    /// 主键id。
    /// </summary>
    [JsonPropertyName("primaryId")]
    public string? PrimaryId { get; set; }

    /// <summary>
    /// 项目编码。
    /// </summary>
    [JsonPropertyName("projectCode")]
    public string? ProjectCode { get; set; }

    /// <summary>
    /// 项目名称。
    /// </summary>
    [JsonPropertyName("projectName")]
    public string? ProjectName { get; set; }

    /// <summary>
    /// 供应商。
    /// </summary>
    [JsonPropertyName("providerName")]
    public string? ProviderName { get; set; }

    /// <summary>
    /// 实际行驶距离。
    /// </summary>
    [JsonPropertyName("realDriveDistance")]
    public string? RealDriveDistance { get; set; }

    /// <summary>
    /// 实际上车点。
    /// </summary>
    [JsonPropertyName("realFromAddr")]
    public string? RealFromAddr { get; set; }

    /// <summary>
    /// 实际下车点。
    /// </summary>
    [JsonPropertyName("realToAddr")]
    public string? RealToAddr { get; set; }

    /// <summary>
    /// 服务费，仅在feeType 40111 中展示。
    /// </summary>
    [JsonPropertyName("serviceFee")]
    public string? ServiceFee { get; set; }

    /// <summary>
    /// 结算金额。
    /// </summary>
    [JsonPropertyName("settlementFee")]
    public decimal? SettlementFee { get; set; }

    /// <summary>
    /// 结算时间。
    /// </summary>
    [JsonPropertyName("settlementTime")]
    public string? SettlementTime { get; set; }

    /// <summary>
    /// 结算类型： 1：个人现付 2：企业现付 4：企业月结 8：企业预存
    /// </summary>
    [JsonPropertyName("settlementType")]
    public string? SettlementType { get; set; }

    /// <summary>
    /// 特别关注订单。
    /// </summary>
    [JsonPropertyName("specialOrder")]
    public string? SpecialOrder { get; set; }

    /// <summary>
    /// 特别关注原因。
    /// </summary>
    [JsonPropertyName("specialReason")]
    public string? SpecialReason { get; set; }

    /// <summary>
    /// 入账状态： -1：个人支付不入账 0：待入账 1：入账成功
    /// </summary>
    [JsonPropertyName("status")]
    public long? Status { get; set; }

    /// <summary>
    /// 出行人use id。
    /// </summary>
    [JsonPropertyName("travelerId")]
    public string? TravelerId { get; set; }

    /// <summary>
    /// 出行人名称。
    /// </summary>
    [JsonPropertyName("travelerName")]
    public string? TravelerName { get; set; }

    /// <summary>
    /// 员工是否认可。
    /// </summary>
    [JsonPropertyName("userConfirmDesc")]
    public string? UserConfirmDesc { get; set; }

    /// <summary>
    /// 预订人工号。
    /// </summary>
    [JsonPropertyName("bookerJobNo")]
    public string? BookerJobNo { get; set; }

    /// <summary>
    /// 出行人工号。
    /// </summary>
    [JsonPropertyName("travelerJobNo")]
    public string? TravelerJobNo { get; set; }
}

/// <summary>
/// module。
/// </summary>
public class GetV1AliTripBillSettlementsCarsResponseModule
{
    /// <summary>
    /// 类目：机酒火车： 0：火车 1：机票 2：酒店 4：用车 6：商旅火车票
    /// </summary>
    [JsonPropertyName("category")]
    public long Category { get; set; }

    /// <summary>
    /// 企业id。
    /// </summary>
    [JsonPropertyName("corpId")]
    public required string CorpId { get; set; }

    /// <summary>
    /// 数据集合。
    /// </summary>
    [JsonPropertyName("dataList")]
    public List<GetV1AliTripBillSettlementsCarsResponseModuleDataListItem> DataList { get; set; } = [];

    /// <summary>
    /// 记账更新开始日期。
    /// </summary>
    [JsonPropertyName("periodEnd")]
    public required string PeriodEnd { get; set; }

    /// <summary>
    /// 记账更新结束日期。
    /// </summary>
    [JsonPropertyName("periodStart")]
    public required string PeriodStart { get; set; }

    /// <summary>
    /// 总数量。
    /// </summary>
    [JsonPropertyName("totalNum")]
    public long TotalNum { get; set; }
}

/// <summary>
/// 查询用车结算记账记录响应
/// </summary>
public class GetV1AliTripBillSettlementsCarsResponse
{
    /// <summary>
    /// 结果msg。
    /// </summary>
    [JsonPropertyName("resultMsg")]
    public required string ResultMsg { get; set; }

    /// <summary>
    /// module。
    /// </summary>
    [JsonPropertyName("module")]
    public required GetV1AliTripBillSettlementsCarsResponseModule Module { get; set; }

    /// <summary>
    /// 是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    /// <summary>
    /// 结果code。
    /// </summary>
    [JsonPropertyName("resultCode")]
    public long ResultCode { get; set; }
}

/// <summary>
/// GetV1AliTripBillSettlementsBTripTrainsResponseModuleDataListItem
/// </summary>
public class GetV1AliTripBillSettlementsBTripTrainsResponseModuleDataListItem
{
    /// <summary>
    /// 支付交易流水号。
    /// </summary>
    [JsonPropertyName("alipayTradeNo")]
    public string? AlipayTradeNo { get; set; }

    /// <summary>
    /// 审批单号。
    /// </summary>
    [JsonPropertyName("applyId")]
    public string? ApplyId { get; set; }

    /// <summary>
    /// 到达城市。
    /// </summary>
    [JsonPropertyName("arrCity")]
    public string? ArrCity { get; set; }

    /// <summary>
    /// 到达日期。
    /// </summary>
    [JsonPropertyName("arrDate")]
    public string? ArrDate { get; set; }

    /// <summary>
    /// 到达地。
    /// </summary>
    [JsonPropertyName("arrLocation")]
    public string? ArrLocation { get; set; }

    /// <summary>
    /// 到达时间。
    /// </summary>
    [JsonPropertyName("arrTime")]
    public string? ArrTime { get; set; }

    /// <summary>
    /// 预定时间。
    /// </summary>
    [JsonPropertyName("bookTime")]
    public string? BookTime { get; set; }

    /// <summary>
    /// 预定人use id。
    /// </summary>
    [JsonPropertyName("bookerId")]
    public string? BookerId { get; set; }

    /// <summary>
    /// 预订人名称。
    /// </summary>
    [JsonPropertyName("bookerName")]
    public string? BookerName { get; set; }

    /// <summary>
    /// 用车原因。
    /// </summary>
    [JsonPropertyName("businessCategory")]
    public string? BusinessCategory { get; set; }

    /// <summary>
    /// 资金方向： 1：支出 2：收入
    /// </summary>
    [JsonPropertyName("capitalDirection")]
    public string? CapitalDirection { get; set; }

    /// <summary>
    /// 车型。
    /// </summary>
    [JsonPropertyName("carLevel")]
    public string? CarLevel { get; set; }

    /// <summary>
    /// 级联部门。
    /// </summary>
    [JsonPropertyName("cascadeDepartment")]
    public string? CascadeDepartment { get; set; }

    /// <summary>
    /// 成本中心名称。
    /// </summary>
    [JsonPropertyName("costCenter")]
    public string? CostCenter { get; set; }

    /// <summary>
    /// 成本中心编号。
    /// </summary>
    [JsonPropertyName("costCenterNumber")]
    public string? CostCenterNumber { get; set; }

    /// <summary>
    /// 优惠券。
    /// </summary>
    [JsonPropertyName("coupon")]
    public long? Coupon { get; set; }

    /// <summary>
    /// 优惠金额。
    /// </summary>
    [JsonPropertyName("couponPrice")]
    public long? CouponPrice { get; set; }

    /// <summary>
    /// 末级部门。
    /// </summary>
    [JsonPropertyName("department")]
    public string? Department { get; set; }

    /// <summary>
    /// 部门id。
    /// </summary>
    [JsonPropertyName("departmentId")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// 出发城市。
    /// </summary>
    [JsonPropertyName("deptCity")]
    public string? DeptCity { get; set; }

    /// <summary>
    /// 出发日期。
    /// </summary>
    [JsonPropertyName("deptDate")]
    public string? DeptDate { get; set; }

    /// <summary>
    /// 出发地。
    /// </summary>
    [JsonPropertyName("deptLocation")]
    public string? DeptLocation { get; set; }

    /// <summary>
    /// 出发时间。
    /// </summary>
    [JsonPropertyName("deptTime")]
    public string? DeptTime { get; set; }

    /// <summary>
    /// 预估行驶距离。
    /// </summary>
    [JsonPropertyName("estimateDriveDistance")]
    public string? EstimateDriveDistance { get; set; }

    /// <summary>
    /// 预估金额。
    /// </summary>
    [JsonPropertyName("estimatePrice")]
    public decimal? EstimatePrice { get; set; }

    /// <summary>
    /// 费用类型： 10101：机票预订 10202：机票改签手续费 10203：机票改签差价 10301：机票退款 10302：机票改签退款 10303：机票补退 10401：机票保险-航意险购买 10501：机票保险-航意险退保 11001：机票的预订服务费 11002：机票改签服务费 20101：酒店预订 20103：酒店退款 20111：酒店预订服务费...
    /// </summary>
    [JsonPropertyName("feeType")]
    public string? FeeType { get; set; }

    /// <summary>
    /// 序号。
    /// </summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>
    /// 发票抬头。
    /// </summary>
    [JsonPropertyName("invoiceTitle")]
    public string? InvoiceTitle { get; set; }

    /// <summary>
    /// 用车事由。
    /// </summary>
    [JsonPropertyName("memo")]
    public string? Memo { get; set; }

    /// <summary>
    /// 订单id。
    /// </summary>
    [JsonPropertyName("orderId")]
    public string? OrderId { get; set; }

    /// <summary>
    /// 订单金额。
    /// </summary>
    [JsonPropertyName("orderPrice")]
    public decimal? OrderPrice { get; set; }

    /// <summary>
    /// 超标审批单号。
    /// </summary>
    [JsonPropertyName("overApplyId")]
    public string? OverApplyId { get; set; }

    /// <summary>
    /// 个人支付金额。
    /// </summary>
    [JsonPropertyName("personSettleFee")]
    public long? PersonSettleFee { get; set; }

    /// <summary>
    /// 主键id。
    /// </summary>
    [JsonPropertyName("primaryId")]
    public string? PrimaryId { get; set; }

    /// <summary>
    /// 项目编码。
    /// </summary>
    [JsonPropertyName("projectCode")]
    public string? ProjectCode { get; set; }

    /// <summary>
    /// 项目名称。
    /// </summary>
    [JsonPropertyName("projectName")]
    public string? ProjectName { get; set; }

    /// <summary>
    /// 供应商。
    /// </summary>
    [JsonPropertyName("providerName")]
    public string? ProviderName { get; set; }

    /// <summary>
    /// 实际行驶距离。
    /// </summary>
    [JsonPropertyName("realDriveDistance")]
    public string? RealDriveDistance { get; set; }

    /// <summary>
    /// 实际上车点。
    /// </summary>
    [JsonPropertyName("realFromAddr")]
    public string? RealFromAddr { get; set; }

    /// <summary>
    /// 实际下车点。
    /// </summary>
    [JsonPropertyName("realToAddr")]
    public string? RealToAddr { get; set; }

    /// <summary>
    /// 服务费，仅在feeType 40111 中展示。
    /// </summary>
    [JsonPropertyName("serviceFee")]
    public string? ServiceFee { get; set; }

    /// <summary>
    /// 结算金额。
    /// </summary>
    [JsonPropertyName("settlementFee")]
    public decimal? SettlementFee { get; set; }

    /// <summary>
    /// 结算时间。
    /// </summary>
    [JsonPropertyName("settlementTime")]
    public string? SettlementTime { get; set; }

    /// <summary>
    /// 结算类型： 1：个人现付 2：企业现付 4：企业月结 8：企业预存
    /// </summary>
    [JsonPropertyName("settlementType")]
    public string? SettlementType { get; set; }

    /// <summary>
    /// 特别关注订单。
    /// </summary>
    [JsonPropertyName("specialOrder")]
    public string? SpecialOrder { get; set; }

    /// <summary>
    /// 特别关注原因。
    /// </summary>
    [JsonPropertyName("specialReason")]
    public string? SpecialReason { get; set; }

    /// <summary>
    /// 入账状态： -1：个人支付不入账 0：待入账 1：入账成功
    /// </summary>
    [JsonPropertyName("status")]
    public long? Status { get; set; }

    /// <summary>
    /// 出行人use id。
    /// </summary>
    [JsonPropertyName("travelerId")]
    public string? TravelerId { get; set; }

    /// <summary>
    /// 出行人名称。
    /// </summary>
    [JsonPropertyName("travelerName")]
    public string? TravelerName { get; set; }

    /// <summary>
    /// 员工是否认可。
    /// </summary>
    [JsonPropertyName("userConfirmDesc")]
    public string? UserConfirmDesc { get; set; }

    /// <summary>
    /// 预订人工号。
    /// </summary>
    [JsonPropertyName("bookerJobNo")]
    public string? BookerJobNo { get; set; }

    /// <summary>
    /// 出行人工号。
    /// </summary>
    [JsonPropertyName("travelerJobNo")]
    public string? TravelerJobNo { get; set; }
}

/// <summary>
/// module。
/// </summary>
public class GetV1AliTripBillSettlementsBTripTrainsResponseModule
{
    /// <summary>
    /// 类目：机酒火车： 0：火车 1：机票 2：酒店 4：用车 6：商旅火车票
    /// </summary>
    [JsonPropertyName("category")]
    public long Category { get; set; }

    /// <summary>
    /// 企业id。
    /// </summary>
    [JsonPropertyName("corpId")]
    public required string CorpId { get; set; }

    /// <summary>
    /// 数据集合。
    /// </summary>
    [JsonPropertyName("dataList")]
    public List<GetV1AliTripBillSettlementsBTripTrainsResponseModuleDataListItem> DataList { get; set; } = [];

    /// <summary>
    /// 记账更新开始日期。
    /// </summary>
    [JsonPropertyName("periodEnd")]
    public required string PeriodEnd { get; set; }

    /// <summary>
    /// 记账更新结束日期。
    /// </summary>
    [JsonPropertyName("periodStart")]
    public required string PeriodStart { get; set; }

    /// <summary>
    /// 总数量。
    /// </summary>
    [JsonPropertyName("totalNum")]
    public long TotalNum { get; set; }
}

/// <summary>
/// 查询商旅火车票结算记账数据响应
/// </summary>
public class GetV1AliTripBillSettlementsBTripTrainsResponse
{
    /// <summary>
    /// 结果msg。
    /// </summary>
    [JsonPropertyName("resultMsg")]
    public required string ResultMsg { get; set; }

    /// <summary>
    /// module。
    /// </summary>
    [JsonPropertyName("module")]
    public required GetV1AliTripBillSettlementsBTripTrainsResponseModule Module { get; set; }

    /// <summary>
    /// 是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    /// <summary>
    /// 结果code。
    /// </summary>
    [JsonPropertyName("resultCode")]
    public long ResultCode { get; set; }
}

/// <summary>
/// GetV1AliTripBillSettlementsHotelsResponseModuleDataListItem
/// </summary>
public class GetV1AliTripBillSettlementsHotelsResponseModuleDataListItem
{
    /// <summary>
    /// 支付交易流水号。
    /// </summary>
    [JsonPropertyName("alipayTradeNo")]
    public string? AlipayTradeNo { get; set; }

    /// <summary>
    /// 审批单号。
    /// </summary>
    [JsonPropertyName("applyId")]
    public string? ApplyId { get; set; }

    /// <summary>
    /// 到达城市。
    /// </summary>
    [JsonPropertyName("arrCity")]
    public string? ArrCity { get; set; }

    /// <summary>
    /// 到达日期。
    /// </summary>
    [JsonPropertyName("arrDate")]
    public string? ArrDate { get; set; }

    /// <summary>
    /// 到达地。
    /// </summary>
    [JsonPropertyName("arrLocation")]
    public string? ArrLocation { get; set; }

    /// <summary>
    /// 到达时间。
    /// </summary>
    [JsonPropertyName("arrTime")]
    public string? ArrTime { get; set; }

    /// <summary>
    /// 预定时间。
    /// </summary>
    [JsonPropertyName("bookTime")]
    public string? BookTime { get; set; }

    /// <summary>
    /// 预定人use id。
    /// </summary>
    [JsonPropertyName("bookerId")]
    public string? BookerId { get; set; }

    /// <summary>
    /// 预订人名称。
    /// </summary>
    [JsonPropertyName("bookerName")]
    public string? BookerName { get; set; }

    /// <summary>
    /// 用车原因。
    /// </summary>
    [JsonPropertyName("businessCategory")]
    public string? BusinessCategory { get; set; }

    /// <summary>
    /// 资金方向： 1：支出 2：收入
    /// </summary>
    [JsonPropertyName("capitalDirection")]
    public string? CapitalDirection { get; set; }

    /// <summary>
    /// 车型。
    /// </summary>
    [JsonPropertyName("carLevel")]
    public string? CarLevel { get; set; }

    /// <summary>
    /// 级联部门。
    /// </summary>
    [JsonPropertyName("cascadeDepartment")]
    public string? CascadeDepartment { get; set; }

    /// <summary>
    /// 成本中心名称。
    /// </summary>
    [JsonPropertyName("costCenter")]
    public string? CostCenter { get; set; }

    /// <summary>
    /// 成本中心编号。
    /// </summary>
    [JsonPropertyName("costCenterNumber")]
    public string? CostCenterNumber { get; set; }

    /// <summary>
    /// 优惠券。
    /// </summary>
    [JsonPropertyName("coupon")]
    public long? Coupon { get; set; }

    /// <summary>
    /// 优惠金额。
    /// </summary>
    [JsonPropertyName("couponPrice")]
    public long? CouponPrice { get; set; }

    /// <summary>
    /// 末级部门。
    /// </summary>
    [JsonPropertyName("department")]
    public string? Department { get; set; }

    /// <summary>
    /// 部门id。
    /// </summary>
    [JsonPropertyName("departmentId")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// 出发城市。
    /// </summary>
    [JsonPropertyName("deptCity")]
    public string? DeptCity { get; set; }

    /// <summary>
    /// 出发日期。
    /// </summary>
    [JsonPropertyName("deptDate")]
    public string? DeptDate { get; set; }

    /// <summary>
    /// 出发地。
    /// </summary>
    [JsonPropertyName("deptLocation")]
    public string? DeptLocation { get; set; }

    /// <summary>
    /// 出发时间。
    /// </summary>
    [JsonPropertyName("deptTime")]
    public string? DeptTime { get; set; }

    /// <summary>
    /// 预估行驶距离。
    /// </summary>
    [JsonPropertyName("estimateDriveDistance")]
    public string? EstimateDriveDistance { get; set; }

    /// <summary>
    /// 预估金额。
    /// </summary>
    [JsonPropertyName("estimatePrice")]
    public decimal? EstimatePrice { get; set; }

    /// <summary>
    /// 费用类型： 10101：机票预订 10202：机票改签手续费 10203：机票改签差价 10301：机票退款 10302：机票改签退款 10303：机票补退 10401：机票保险-航意险购买 10501：机票保险-航意险退保 11001：机票的预订服务费 11002：机票改签服务费 20101：酒店预订 20103：酒店退款 20111：酒店预订服务费...
    /// </summary>
    [JsonPropertyName("feeType")]
    public string? FeeType { get; set; }

    /// <summary>
    /// 序号。
    /// </summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>
    /// 发票抬头。
    /// </summary>
    [JsonPropertyName("invoiceTitle")]
    public string? InvoiceTitle { get; set; }

    /// <summary>
    /// 用车事由。
    /// </summary>
    [JsonPropertyName("memo")]
    public string? Memo { get; set; }

    /// <summary>
    /// 订单id。
    /// </summary>
    [JsonPropertyName("orderId")]
    public string? OrderId { get; set; }

    /// <summary>
    /// 订单金额。
    /// </summary>
    [JsonPropertyName("orderPrice")]
    public decimal? OrderPrice { get; set; }

    /// <summary>
    /// 超标审批单号。
    /// </summary>
    [JsonPropertyName("overApplyId")]
    public string? OverApplyId { get; set; }

    /// <summary>
    /// 个人支付金额。
    /// </summary>
    [JsonPropertyName("personSettleFee")]
    public long? PersonSettleFee { get; set; }

    /// <summary>
    /// 主键id。
    /// </summary>
    [JsonPropertyName("primaryId")]
    public string? PrimaryId { get; set; }

    /// <summary>
    /// 项目编码。
    /// </summary>
    [JsonPropertyName("projectCode")]
    public string? ProjectCode { get; set; }

    /// <summary>
    /// 项目名称。
    /// </summary>
    [JsonPropertyName("projectName")]
    public string? ProjectName { get; set; }

    /// <summary>
    /// 供应商。
    /// </summary>
    [JsonPropertyName("providerName")]
    public string? ProviderName { get; set; }

    /// <summary>
    /// 实际行驶距离。
    /// </summary>
    [JsonPropertyName("realDriveDistance")]
    public string? RealDriveDistance { get; set; }

    /// <summary>
    /// 实际上车点。
    /// </summary>
    [JsonPropertyName("realFromAddr")]
    public string? RealFromAddr { get; set; }

    /// <summary>
    /// 实际下车点。
    /// </summary>
    [JsonPropertyName("realToAddr")]
    public string? RealToAddr { get; set; }

    /// <summary>
    /// 服务费，仅在feeType 40111 中展示。
    /// </summary>
    [JsonPropertyName("serviceFee")]
    public string? ServiceFee { get; set; }

    /// <summary>
    /// 结算金额。
    /// </summary>
    [JsonPropertyName("settlementFee")]
    public decimal? SettlementFee { get; set; }

    /// <summary>
    /// 结算时间。
    /// </summary>
    [JsonPropertyName("settlementTime")]
    public string? SettlementTime { get; set; }

    /// <summary>
    /// 结算类型： 1：个人现付 2：企业现付 4：企业月结 8：企业预存
    /// </summary>
    [JsonPropertyName("settlementType")]
    public string? SettlementType { get; set; }

    /// <summary>
    /// 特别关注订单。
    /// </summary>
    [JsonPropertyName("specialOrder")]
    public string? SpecialOrder { get; set; }

    /// <summary>
    /// 特别关注原因。
    /// </summary>
    [JsonPropertyName("specialReason")]
    public string? SpecialReason { get; set; }

    /// <summary>
    /// 入账状态： -1：个人支付不入账 0：待入账 1：入账成功
    /// </summary>
    [JsonPropertyName("status")]
    public long? Status { get; set; }

    /// <summary>
    /// 出行人use id。
    /// </summary>
    [JsonPropertyName("travelerId")]
    public string? TravelerId { get; set; }

    /// <summary>
    /// 出行人名称。
    /// </summary>
    [JsonPropertyName("travelerName")]
    public string? TravelerName { get; set; }

    /// <summary>
    /// 员工是否认可。
    /// </summary>
    [JsonPropertyName("userConfirmDesc")]
    public string? UserConfirmDesc { get; set; }

    /// <summary>
    /// 预订人工号。
    /// </summary>
    [JsonPropertyName("bookerJobNo")]
    public string? BookerJobNo { get; set; }

    /// <summary>
    /// 出行人工号。
    /// </summary>
    [JsonPropertyName("travelerJobNo")]
    public string? TravelerJobNo { get; set; }
}

/// <summary>
/// module。
/// </summary>
public class GetV1AliTripBillSettlementsHotelsResponseModule
{
    /// <summary>
    /// 类目：机酒火车： 0：火车 1：机票 2：酒店 4：用车 6：商旅火车票
    /// </summary>
    [JsonPropertyName("category")]
    public long Category { get; set; }

    /// <summary>
    /// 企业id。
    /// </summary>
    [JsonPropertyName("corpId")]
    public required string CorpId { get; set; }

    /// <summary>
    /// 数据集合。
    /// </summary>
    [JsonPropertyName("dataList")]
    public List<GetV1AliTripBillSettlementsHotelsResponseModuleDataListItem> DataList { get; set; } = [];

    /// <summary>
    /// 记账更新开始日期。
    /// </summary>
    [JsonPropertyName("periodEnd")]
    public required string PeriodEnd { get; set; }

    /// <summary>
    /// 记账更新结束日期。
    /// </summary>
    [JsonPropertyName("periodStart")]
    public required string PeriodStart { get; set; }

    /// <summary>
    /// 总数量。
    /// </summary>
    [JsonPropertyName("totalNum")]
    public long TotalNum { get; set; }
}

/// <summary>
/// 查询酒店结算记账数据响应
/// </summary>
public class GetV1AliTripBillSettlementsHotelsResponse
{
    /// <summary>
    /// 结果msg。
    /// </summary>
    [JsonPropertyName("resultMsg")]
    public required string ResultMsg { get; set; }

    /// <summary>
    /// module。
    /// </summary>
    [JsonPropertyName("module")]
    public required GetV1AliTripBillSettlementsHotelsResponseModule Module { get; set; }

    /// <summary>
    /// 是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    /// <summary>
    /// 结果code。
    /// </summary>
    [JsonPropertyName("resultCode")]
    public long ResultCode { get; set; }
}

/// <summary>
/// GetV1AliTripBillSettlementsFlightsResponseModuleDataListItem
/// </summary>
public class GetV1AliTripBillSettlementsFlightsResponseModuleDataListItem
{
    /// <summary>
    /// 支付交易流水号。
    /// </summary>
    [JsonPropertyName("alipayTradeNo")]
    public string? AlipayTradeNo { get; set; }

    /// <summary>
    /// 审批单号。
    /// </summary>
    [JsonPropertyName("applyId")]
    public string? ApplyId { get; set; }

    /// <summary>
    /// 到达城市。
    /// </summary>
    [JsonPropertyName("arrCity")]
    public string? ArrCity { get; set; }

    /// <summary>
    /// 到达日期。
    /// </summary>
    [JsonPropertyName("arrDate")]
    public string? ArrDate { get; set; }

    /// <summary>
    /// 到达地。
    /// </summary>
    [JsonPropertyName("arrLocation")]
    public string? ArrLocation { get; set; }

    /// <summary>
    /// 到达时间。
    /// </summary>
    [JsonPropertyName("arrTime")]
    public string? ArrTime { get; set; }

    /// <summary>
    /// 预定时间。
    /// </summary>
    [JsonPropertyName("bookTime")]
    public string? BookTime { get; set; }

    /// <summary>
    /// 预定人use id。
    /// </summary>
    [JsonPropertyName("bookerId")]
    public string? BookerId { get; set; }

    /// <summary>
    /// 预订人名称。
    /// </summary>
    [JsonPropertyName("bookerName")]
    public string? BookerName { get; set; }

    /// <summary>
    /// 用车原因。
    /// </summary>
    [JsonPropertyName("businessCategory")]
    public string? BusinessCategory { get; set; }

    /// <summary>
    /// 资金方向： 1：支出 2：收入
    /// </summary>
    [JsonPropertyName("capitalDirection")]
    public string? CapitalDirection { get; set; }

    /// <summary>
    /// 车型。
    /// </summary>
    [JsonPropertyName("carLevel")]
    public string? CarLevel { get; set; }

    /// <summary>
    /// 级联部门。
    /// </summary>
    [JsonPropertyName("cascadeDepartment")]
    public string? CascadeDepartment { get; set; }

    /// <summary>
    /// 成本中心名称。
    /// </summary>
    [JsonPropertyName("costCenter")]
    public string? CostCenter { get; set; }

    /// <summary>
    /// 成本中心编号。
    /// </summary>
    [JsonPropertyName("costCenterNumber")]
    public string? CostCenterNumber { get; set; }

    /// <summary>
    /// 优惠券。
    /// </summary>
    [JsonPropertyName("coupon")]
    public long? Coupon { get; set; }

    /// <summary>
    /// 优惠金额。
    /// </summary>
    [JsonPropertyName("couponPrice")]
    public long? CouponPrice { get; set; }

    /// <summary>
    /// 末级部门。
    /// </summary>
    [JsonPropertyName("department")]
    public string? Department { get; set; }

    /// <summary>
    /// 部门id。
    /// </summary>
    [JsonPropertyName("departmentId")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// 出发城市。
    /// </summary>
    [JsonPropertyName("deptCity")]
    public string? DeptCity { get; set; }

    /// <summary>
    /// 出发日期。
    /// </summary>
    [JsonPropertyName("deptDate")]
    public string? DeptDate { get; set; }

    /// <summary>
    /// 出发地。
    /// </summary>
    [JsonPropertyName("deptLocation")]
    public string? DeptLocation { get; set; }

    /// <summary>
    /// 出发时间。
    /// </summary>
    [JsonPropertyName("deptTime")]
    public string? DeptTime { get; set; }

    /// <summary>
    /// 预估行驶距离。
    /// </summary>
    [JsonPropertyName("estimateDriveDistance")]
    public string? EstimateDriveDistance { get; set; }

    /// <summary>
    /// 预估金额。
    /// </summary>
    [JsonPropertyName("estimatePrice")]
    public decimal? EstimatePrice { get; set; }

    /// <summary>
    /// 费用类型： 10101：机票预订 10202：机票改签手续费 10203：机票改签差价 10301：机票退款 10302：机票改签退款 10303：机票补退 10401：机票保险-航意险购买 10501：机票保险-航意险退保 11001：机票的预订服务费 11002：机票改签服务费 20101：酒店预订 20103：酒店退款 20111：酒店预订服务费...
    /// </summary>
    [JsonPropertyName("feeType")]
    public string? FeeType { get; set; }

    /// <summary>
    /// 序号。
    /// </summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary>
    /// 发票抬头。
    /// </summary>
    [JsonPropertyName("invoiceTitle")]
    public string? InvoiceTitle { get; set; }

    /// <summary>
    /// 用车事由。
    /// </summary>
    [JsonPropertyName("memo")]
    public string? Memo { get; set; }

    /// <summary>
    /// 订单id。
    /// </summary>
    [JsonPropertyName("orderId")]
    public string? OrderId { get; set; }

    /// <summary>
    /// 订单金额。
    /// </summary>
    [JsonPropertyName("orderPrice")]
    public decimal? OrderPrice { get; set; }

    /// <summary>
    /// 超标审批单号。
    /// </summary>
    [JsonPropertyName("overApplyId")]
    public string? OverApplyId { get; set; }

    /// <summary>
    /// 个人支付金额。
    /// </summary>
    [JsonPropertyName("personSettleFee")]
    public long? PersonSettleFee { get; set; }

    /// <summary>
    /// 主键id。
    /// </summary>
    [JsonPropertyName("primaryId")]
    public string? PrimaryId { get; set; }

    /// <summary>
    /// 项目编码。
    /// </summary>
    [JsonPropertyName("projectCode")]
    public string? ProjectCode { get; set; }

    /// <summary>
    /// 项目名称。
    /// </summary>
    [JsonPropertyName("projectName")]
    public string? ProjectName { get; set; }

    /// <summary>
    /// 供应商。
    /// </summary>
    [JsonPropertyName("providerName")]
    public string? ProviderName { get; set; }

    /// <summary>
    /// 实际行驶距离。
    /// </summary>
    [JsonPropertyName("realDriveDistance")]
    public string? RealDriveDistance { get; set; }

    /// <summary>
    /// 实际上车点。
    /// </summary>
    [JsonPropertyName("realFromAddr")]
    public string? RealFromAddr { get; set; }

    /// <summary>
    /// 实际下车点。
    /// </summary>
    [JsonPropertyName("realToAddr")]
    public string? RealToAddr { get; set; }

    /// <summary>
    /// 服务费，仅在feeType 40111 中展示。
    /// </summary>
    [JsonPropertyName("serviceFee")]
    public string? ServiceFee { get; set; }

    /// <summary>
    /// 结算金额。
    /// </summary>
    [JsonPropertyName("settlementFee")]
    public decimal? SettlementFee { get; set; }

    /// <summary>
    /// 结算时间。
    /// </summary>
    [JsonPropertyName("settlementTime")]
    public string? SettlementTime { get; set; }

    /// <summary>
    /// 结算类型： 1：个人现付 2：企业现付 4：企业月结 8：企业预存
    /// </summary>
    [JsonPropertyName("settlementType")]
    public string? SettlementType { get; set; }

    /// <summary>
    /// 特别关注订单。
    /// </summary>
    [JsonPropertyName("specialOrder")]
    public string? SpecialOrder { get; set; }

    /// <summary>
    /// 特别关注原因。
    /// </summary>
    [JsonPropertyName("specialReason")]
    public string? SpecialReason { get; set; }

    /// <summary>
    /// 入账状态： -1：个人支付不入账 0：待入账 1：入账成功
    /// </summary>
    [JsonPropertyName("status")]
    public long? Status { get; set; }

    /// <summary>
    /// 出行人use id。
    /// </summary>
    [JsonPropertyName("travelerId")]
    public string? TravelerId { get; set; }

    /// <summary>
    /// 出行人名称。
    /// </summary>
    [JsonPropertyName("travelerName")]
    public string? TravelerName { get; set; }

    /// <summary>
    /// 员工是否认可。
    /// </summary>
    [JsonPropertyName("userConfirmDesc")]
    public string? UserConfirmDesc { get; set; }

    /// <summary>
    /// 预订人工号。
    /// </summary>
    [JsonPropertyName("bookerJobNo")]
    public string? BookerJobNo { get; set; }

    /// <summary>
    /// 出行人工号。
    /// </summary>
    [JsonPropertyName("travelerJobNo")]
    public string? TravelerJobNo { get; set; }
}

/// <summary>
/// module。
/// </summary>
public class GetV1AliTripBillSettlementsFlightsResponseModule
{
    /// <summary>
    /// 类目：机酒火车： 0：火车 1：机票 2：酒店 4：用车 6：商旅火车票
    /// </summary>
    [JsonPropertyName("category")]
    public long Category { get; set; }

    /// <summary>
    /// 企业id。
    /// </summary>
    [JsonPropertyName("corpId")]
    public required string CorpId { get; set; }

    /// <summary>
    /// 数据集合。
    /// </summary>
    [JsonPropertyName("dataList")]
    public List<GetV1AliTripBillSettlementsFlightsResponseModuleDataListItem> DataList { get; set; } = [];

    /// <summary>
    /// 记账更新开始日期。
    /// </summary>
    [JsonPropertyName("periodEnd")]
    public required string PeriodEnd { get; set; }

    /// <summary>
    /// 记账更新结束日期。
    /// </summary>
    [JsonPropertyName("periodStart")]
    public required string PeriodStart { get; set; }

    /// <summary>
    /// 总数量。
    /// </summary>
    [JsonPropertyName("totalNum")]
    public long TotalNum { get; set; }
}

/// <summary>
/// 查询机票结算记账数据响应
/// </summary>
public class GetV1AliTripBillSettlementsFlightsResponse
{
    /// <summary>
    /// 结果msg。
    /// </summary>
    [JsonPropertyName("resultMsg")]
    public required string ResultMsg { get; set; }

    /// <summary>
    /// module。
    /// </summary>
    [JsonPropertyName("module")]
    public required GetV1AliTripBillSettlementsFlightsResponseModule Module { get; set; }

    /// <summary>
    /// 是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    /// <summary>
    /// 结果code。
    /// </summary>
    [JsonPropertyName("resultCode")]
    public long ResultCode { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripMonthbillUrlGetRequestRequest
{
    /// <summary>
    /// 对账单月份，不传取最新对账单。
    /// </summary>
    [JsonPropertyName("bill_month")]
    public string? BillMonth { get; set; }

    /// <summary>
    /// 企业的corpid，可登录开发者后台查看。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }
}

/// <summary>
/// 获取月对账结算数据请求
/// </summary>
public class PostTopapiAliTripBTripMonthbillUrlGetRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("request")]
    public required PostTopapiAliTripBTripMonthbillUrlGetRequestRequest Request { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripMonthbillUrlGetResponseModuleItem
/// </summary>
public class PostTopapiAliTripBTripMonthbillUrlGetResponseModuleItem
{
    /// <summary>
    /// 账期开始时间。
    /// </summary>
    [JsonPropertyName("start_date")]
    public string? StartDate { get; set; }

    /// <summary>
    /// 账期结束时间。
    /// </summary>
    [JsonPropertyName("end_date")]
    public string? EndDate { get; set; }

    /// <summary>
    /// json数据下载链接，通过HttpClient 获取，并以GBK格式解析，链接有效期为五分钟。
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// 获取月对账结算数据响应
/// </summary>
public class PostTopapiAliTripBTripMonthbillUrlGetResponse
{
    /// <summary>
    /// 成功标识。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 返回对象。
    /// </summary>
    [JsonPropertyName("module")]
    public List<PostTopapiAliTripBTripMonthbillUrlGetResponseModuleItem> Module { get; set; } = [];

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 请求对象。
/// </summary>
public class PostTopapiAliTripBTripPriceQueryRequestReq
{
    /// <summary>
    /// 企业的corpid，可登录开发者后台查看。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string Corpid { get; set; }

    /// <summary>
    /// 出发地点。
    /// </summary>
    [JsonPropertyName("from_where")]
    public required string FromWhere { get; set; }

    /// <summary>
    /// 用户的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }

    /// <summary>
    /// 行程ID，可通过获取申请单列表接口获取。
    /// </summary>
    [JsonPropertyName("itinerary_id")]
    public string? ItineraryId { get; set; }

    /// <summary>
    /// 出发时间。
    /// </summary>
    [JsonPropertyName("start_time")]
    public required string StartTime { get; set; }

    /// <summary>
    /// 返程时间。
    /// </summary>
    [JsonPropertyName("end_time")]
    public required string EndTime { get; set; }

    /// <summary>
    /// 目的地。
    /// </summary>
    [JsonPropertyName("to_where")]
    public required string ToWhere { get; set; }

    /// <summary>
    /// 类目：flight：机票hotel：酒店train：火车
    /// </summary>
    [JsonPropertyName("category")]
    public required string Category { get; set; }

    /// <summary>
    /// 根据key查询。
    /// </summary>
    [JsonPropertyName("query_key")]
    public string? QueryKey { get; set; }
}

/// <summary>
/// 查询预估价请求
/// </summary>
public class PostTopapiAliTripBTripPriceQueryRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    [JsonPropertyName("req")]
    public required PostTopapiAliTripBTripPriceQueryRequestReq Req { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripPriceQueryResponseResultModuleHotelFeeDetailItem
/// </summary>
public class PostTopapiAliTripBTripPriceQueryResponseResultModuleHotelFeeDetailItem
{
    /// <summary>
    /// 费用。
    /// </summary>
    [JsonPropertyName("criterion")]
    public decimal? Criterion { get; set; }

    /// <summary>
    /// 城市。
    /// </summary>
    [JsonPropertyName("city")]
    public string? City { get; set; }
}

/// <summary>
/// 最高价。
/// </summary>
public class PostTopapiAliTripBTripPriceQueryResponseResultModuleTrafficFeeBTripRoutesItemMostExpensive
{
    /// <summary>
    /// 班次。
    /// </summary>
    [JsonPropertyName("vehicle_no")]
    public string? VehicleNo { get; set; }

    /// <summary>
    /// 坐席级别。
    /// </summary>
    [JsonPropertyName("seat_grade")]
    public string? SeatGrade { get; set; }

    /// <summary>
    /// 出发时间。
    /// </summary>
    [JsonPropertyName("dep_time")]
    public string? DepTime { get; set; }

    /// <summary>
    /// 费用。
    /// </summary>
    [JsonPropertyName("fee")]
    public decimal? Fee { get; set; }

    /// <summary>
    /// 到达时间。
    /// </summary>
    [JsonPropertyName("arr_time")]
    public string? ArrTime { get; set; }
}

/// <summary>
/// 最低价。
/// </summary>
public class PostTopapiAliTripBTripPriceQueryResponseResultModuleTrafficFeeBTripRoutesItemCheapest
{
    /// <summary>
    /// 班次。
    /// </summary>
    [JsonPropertyName("vehicle_no")]
    public string? VehicleNo { get; set; }

    /// <summary>
    /// 坐席级别。
    /// </summary>
    [JsonPropertyName("seat_grade")]
    public string? SeatGrade { get; set; }

    /// <summary>
    /// 出发时间。
    /// </summary>
    [JsonPropertyName("dep_time")]
    public string? DepTime { get; set; }

    /// <summary>
    /// 费用。
    /// </summary>
    [JsonPropertyName("fee")]
    public decimal? Fee { get; set; }

    /// <summary>
    /// 到达时间。
    /// </summary>
    [JsonPropertyName("arr_time")]
    public string? ArrTime { get; set; }
}

/// <summary>
/// PostTopapiAliTripBTripPriceQueryResponseResultModuleTrafficFeeBTripRoutesItem
/// </summary>
public class PostTopapiAliTripBTripPriceQueryResponseResultModuleTrafficFeeBTripRoutesItem
{
    /// <summary>
    /// 最高价。
    /// </summary>
    [JsonPropertyName("most_expensive")]
    public PostTopapiAliTripBTripPriceQueryResponseResultModuleTrafficFeeBTripRoutesItemMostExpensive? MostExpensive { get; set; }

    /// <summary>
    /// 查询是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 最低价。
    /// </summary>
    [JsonPropertyName("cheapest")]
    public PostTopapiAliTripBTripPriceQueryResponseResultModuleTrafficFeeBTripRoutesItemCheapest? Cheapest { get; set; }

    /// <summary>
    /// 目的地。
    /// </summary>
    [JsonPropertyName("dest_city")]
    public string? DestCity { get; set; }

    /// <summary>
    /// 出发地。
    /// </summary>
    [JsonPropertyName("org_city")]
    public string? OrgCity { get; set; }

    /// <summary>
    /// 错误信息。
    /// </summary>
    [JsonPropertyName("err_msg")]
    public string? ErrMsg { get; set; }

    /// <summary>
    /// 出发时间。
    /// </summary>
    [JsonPropertyName("dep_date")]
    public string? DepDate { get; set; }
}

/// <summary>
/// 费用。
/// </summary>
public class PostTopapiAliTripBTripPriceQueryResponseResultModuleTrafficFee
{
    /// <summary>
    /// 行程费用。
    /// </summary>
    [JsonPropertyName("btrip_routes")]
    public List<PostTopapiAliTripBTripPriceQueryResponseResultModuleTrafficFeeBTripRoutesItem> BTripRoutes { get; set; } = [];

    /// <summary>
    /// 是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 错误信息。
    /// </summary>
    [JsonPropertyName("err_msg")]
    public string? ErrMsg { get; set; }
}

/// <summary>
/// 预估价信息。
/// </summary>
public class PostTopapiAliTripBTripPriceQueryResponseResultModule
{
    /// <summary>
    /// 酒店差标。
    /// </summary>
    [JsonPropertyName("hotel_fee_detail")]
    public List<PostTopapiAliTripBTripPriceQueryResponseResultModuleHotelFeeDetailItem> HotelFeeDetail { get; set; } = [];

    /// <summary>
    /// 费用。
    /// </summary>
    [JsonPropertyName("traffic_fee")]
    public PostTopapiAliTripBTripPriceQueryResponseResultModuleTrafficFee? TrafficFee { get; set; }

    /// <summary>
    /// 异步查询key。需要client再次尝试请求。
    /// </summary>
    [JsonPropertyName("query_key")]
    public string? QueryKey { get; set; }
}

/// <summary>
/// 返回结果。
/// </summary>
public class PostTopapiAliTripBTripPriceQueryResponseResult
{
    /// <summary>
    /// 操作是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 预估价信息。
    /// </summary>
    [JsonPropertyName("module")]
    public PostTopapiAliTripBTripPriceQueryResponseResultModule? Module { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }
}

/// <summary>
/// 查询预估价响应
/// </summary>
public class PostTopapiAliTripBTripPriceQueryResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    [JsonPropertyName("result")]
    public PostTopapiAliTripBTripPriceQueryResponseResult? Result { get; set; }
}

/// <summary>
/// 编辑数据。
/// </summary>
public class PostV1JzCrmCustomersRequestData
{
    /// <summary>
    /// 创建人。
    /// </summary>
    [JsonPropertyName("data_userid")]
    public required string DataUserid { get; set; }

    /// <summary>
    /// 上级客户。
    /// </summary>
    [JsonPropertyName("kh_pkhid")]
    public string? KhPkhid { get; set; }

    /// <summary>
    /// 类别，取值。
    /// </summary>
    [JsonPropertyName("kh_class")]
    public required string KhClass { get; set; }

    /// <summary>
    /// 客户名称。
    /// </summary>
    [JsonPropertyName("kh_name")]
    public required string KhName { get; set; }

    /// <summary>
    /// 性别，取值。
    /// </summary>
    [JsonPropertyName("kh_sex")]
    public string? KhSex { get; set; }

    /// <summary>
    /// 助记简称。
    /// </summary>
    [JsonPropertyName("kh_shortname")]
    public string? KhShortname { get; set; }

    /// <summary>
    /// 行业。
    /// </summary>
    [JsonPropertyName("kh_industry")]
    public string? KhIndustry { get; set; }

    /// <summary>
    /// 人员规模。
    /// </summary>
    [JsonPropertyName("kh_employees")]
    public string? KhEmployees { get; set; }

    /// <summary>
    /// 家庭地址。
    /// </summary>
    [JsonPropertyName("kh_address")]
    public string? KhAddress { get; set; }

    /// <summary>
    /// 国家地区。
    /// </summary>
    [JsonPropertyName("kh_country")]
    public string? KhCountry { get; set; }

    /// <summary>
    /// 省份。
    /// </summary>
    [JsonPropertyName("kh_province")]
    public string? KhProvince { get; set; }

    /// <summary>
    /// 城市。
    /// </summary>
    [JsonPropertyName("kh_city")]
    public string? KhCity { get; set; }

    /// <summary>
    /// 单位地址。
    /// </summary>
    [JsonPropertyName("kh_coaddress")]
    public string? KhCoaddress { get; set; }

    /// <summary>
    /// 是否为热点客。
    /// </summary>
    [JsonPropertyName("kh_hottype")]
    public string? KhHottype { get; set; }

    /// <summary>
    /// 热度，取值。
    /// </summary>
    [JsonPropertyName("kh_hotlevel")]
    public string? KhHotlevel { get; set; }

    /// <summary>
    /// 热点分类。
    /// </summary>
    [JsonPropertyName("kh_hotfl")]
    public string? KhHotfl { get; set; }

    /// <summary>
    /// 热点说明。
    /// </summary>
    [JsonPropertyName("kh_hotmemo")]
    public string? KhHotmemo { get; set; }

    /// <summary>
    /// 种类。
    /// </summary>
    [JsonPropertyName("kh_type")]
    public string? KhType { get; set; }

    /// <summary>
    /// 阶段。
    /// </summary>
    [JsonPropertyName("kh_status")]
    public string? KhStatus { get; set; }

    /// <summary>
    /// 编号。
    /// </summary>
    [JsonPropertyName("kh_sn")]
    public string? KhSn { get; set; }

    /// <summary>
    /// 手机号。
    /// </summary>
    [JsonPropertyName("kh_handset")]
    public string? KhHandset { get; set; }

    /// <summary>
    /// 邮箱。
    /// </summary>
    [JsonPropertyName("kh_email")]
    public string? KhEmail { get; set; }

    /// <summary>
    /// 钉钉号。
    /// </summary>
    [JsonPropertyName("kh_dingtalk")]
    public string? KhDingtalk { get; set; }

    /// <summary>
    /// 家庭电话。
    /// </summary>
    [JsonPropertyName("kh_tel")]
    public string? KhTel { get; set; }

    /// <summary>
    /// 微信号。
    /// </summary>
    [JsonPropertyName("kh_weixin")]
    public string? KhWeixin { get; set; }

    /// <summary>
    /// QQ号。
    /// </summary>
    [JsonPropertyName("kh_qq")]
    public string? KhQq { get; set; }

    /// <summary>
    /// Skype账号。
    /// </summary>
    [JsonPropertyName("kh_skype")]
    public string? KhSkype { get; set; }

    /// <summary>
    /// 旺旺。
    /// </summary>
    [JsonPropertyName("kh_wangwang")]
    public string? KhWangwang { get; set; }

    /// <summary>
    /// 工作电话。
    /// </summary>
    [JsonPropertyName("kh_worktel")]
    public string? KhWorktel { get; set; }

    /// <summary>
    /// 传真。
    /// </summary>
    [JsonPropertyName("kh_fax")]
    public string? KhFax { get; set; }

    /// <summary>
    /// 邮编。
    /// </summary>
    [JsonPropertyName("kh_pst")]
    public string? KhPst { get; set; }

    /// <summary>
    /// 部门。
    /// </summary>
    [JsonPropertyName("kh_department")]
    public string? KhDepartment { get; set; }

    /// <summary>
    /// 称谓。
    /// </summary>
    [JsonPropertyName("kh_appellation")]
    public string? KhAppellation { get; set; }

    /// <summary>
    /// 负责业务。
    /// </summary>
    [JsonPropertyName("kh_preside")]
    public string? KhPreside { get; set; }

    /// <summary>
    /// 职务。
    /// </summary>
    [JsonPropertyName("kh_headship")]
    public string? KhHeadship { get; set; }

    /// <summary>
    /// 网址。
    /// </summary>
    [JsonPropertyName("kh_web")]
    public string? KhWeb { get; set; }

    /// <summary>
    /// 爱好。
    /// </summary>
    [JsonPropertyName("kh_befontof")]
    public string? KhBefontof { get; set; }

    /// <summary>
    /// 来源。
    /// </summary>
    [JsonPropertyName("kh_from")]
    public string? KhFrom { get; set; }

    /// <summary>
    /// 开票资料。
    /// </summary>
    [JsonPropertyName("kh_billinfo")]
    public string? KhBillinfo { get; set; }

    /// <summary>
    /// 公司简介。
    /// </summary>
    [JsonPropertyName("kh_info")]
    public string? KhInfo { get; set; }

    /// <summary>
    /// 关系等级。
    /// </summary>
    [JsonPropertyName("kh_ralagrade")]
    public string? KhRalagrade { get; set; }

    /// <summary>
    /// 信用等级，取值。
    /// </summary>
    [JsonPropertyName("kh_creditgrade")]
    public string? KhCreditgrade { get; set; }

    /// <summary>
    /// 价值评估，取值。
    /// </summary>
    [JsonPropertyName("kh_valrating")]
    public string? KhValrating { get; set; }

    /// <summary>
    /// 证件类型。
    /// </summary>
    [JsonPropertyName("kh_cttype")]
    public string? KhCttype { get; set; }

    /// <summary>
    /// 证件号码。
    /// </summary>
    [JsonPropertyName("kh_ctnumber")]
    public string? KhCtnumber { get; set; }

    /// <summary>
    /// 联系人分类
    /// </summary>
    [JsonPropertyName("kh_contype")]
    public string? KhContype { get; set; }

    /// <summary>
    /// 备注。
    /// </summary>
    [JsonPropertyName("kh_remark")]
    public string? KhRemark { get; set; }

    /// <summary>
    /// 客户级别。
    /// </summary>
    [JsonPropertyName("kh_jibie")]
    public string? KhJibie { get; set; }
}

/// <summary>
/// 客户资料请求
/// </summary>
public class PostV1JzCrmCustomersRequest
{
    /// <summary>
    /// 数据类型，固定值148。
    /// </summary>
    [JsonPropertyName("datatype")]
    public long Datatype { get; set; }

    /// <summary>
    /// 时间戳，单位：秒。
    /// </summary>
    [JsonPropertyName("stamp")]
    public long Stamp { get; set; }

    /// <summary>
    /// 数据ID。 值为0或不填时，为新增数据。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }

    /// <summary>
    /// 编辑数据。
    /// </summary>
    [JsonPropertyName("data")]
    public PostV1JzCrmCustomersRequestData? Data { get; set; }
}

/// <summary>
/// 客户资料响应
/// </summary>
public class PostV1JzCrmCustomersResponse
{
    /// <summary>
    /// 响应时间。
    /// </summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>
    /// 编辑数据的ID。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }
}

/// <summary>
/// 编辑数据。
/// </summary>
public class PostV1JzCrmCustomerPoolsRequestData
{
    /// <summary>
    /// 创建人。
    /// </summary>
    [JsonPropertyName("data_userid")]
    public required string DataUserid { get; set; }

    /// <summary>
    /// 上级客户。
    /// </summary>
    [JsonPropertyName("kh_pkhid")]
    public string? KhPkhid { get; set; }

    /// <summary>
    /// 类别，取值。
    /// </summary>
    [JsonPropertyName("kh_class")]
    public required string KhClass { get; set; }

    /// <summary>
    /// 客户名称。
    /// </summary>
    [JsonPropertyName("kh_name")]
    public required string KhName { get; set; }

    /// <summary>
    /// 性别，取值。
    /// </summary>
    [JsonPropertyName("kh_sex")]
    public string? KhSex { get; set; }

    /// <summary>
    /// 助记简称。
    /// </summary>
    [JsonPropertyName("kh_shortname")]
    public string? KhShortname { get; set; }

    /// <summary>
    /// 行业。
    /// </summary>
    [JsonPropertyName("kh_industry")]
    public string? KhIndustry { get; set; }

    /// <summary>
    /// 人员规模。
    /// </summary>
    [JsonPropertyName("kh_employees")]
    public string? KhEmployees { get; set; }

    /// <summary>
    /// 家庭地址。
    /// </summary>
    [JsonPropertyName("kh_address")]
    public string? KhAddress { get; set; }

    /// <summary>
    /// 国家地区。
    /// </summary>
    [JsonPropertyName("kh_country")]
    public string? KhCountry { get; set; }

    /// <summary>
    /// 省份。
    /// </summary>
    [JsonPropertyName("kh_province")]
    public string? KhProvince { get; set; }

    /// <summary>
    /// 城市。
    /// </summary>
    [JsonPropertyName("kh_city")]
    public string? KhCity { get; set; }

    /// <summary>
    /// 单位地址。
    /// </summary>
    [JsonPropertyName("kh_coaddress")]
    public string? KhCoaddress { get; set; }

    /// <summary>
    /// 是否热点客户，取值。
    /// </summary>
    [JsonPropertyName("kh_hottype")]
    public string? KhHottype { get; set; }

    /// <summary>
    /// 热度，取值。
    /// </summary>
    [JsonPropertyName("kh_hotlevel")]
    public string? KhHotlevel { get; set; }

    /// <summary>
    /// 热点分类。
    /// </summary>
    [JsonPropertyName("kh_hotfl")]
    public string? KhHotfl { get; set; }

    /// <summary>
    /// 热点说明。
    /// </summary>
    [JsonPropertyName("kh_hotmemo")]
    public string? KhHotmemo { get; set; }

    /// <summary>
    /// 种类。
    /// </summary>
    [JsonPropertyName("kh_type")]
    public string? KhType { get; set; }

    /// <summary>
    /// 阶段。
    /// </summary>
    [JsonPropertyName("kh_status")]
    public string? KhStatus { get; set; }

    /// <summary>
    /// 编号。
    /// </summary>
    [JsonPropertyName("kh_sn")]
    public string? KhSn { get; set; }

    /// <summary>
    /// 手机。
    /// </summary>
    [JsonPropertyName("kh_handset")]
    public string? KhHandset { get; set; }

    /// <summary>
    /// 邮箱。
    /// </summary>
    [JsonPropertyName("kh_email")]
    public string? KhEmail { get; set; }

    /// <summary>
    /// 钉钉号。
    /// </summary>
    [JsonPropertyName("kh_dingtalk")]
    public string? KhDingtalk { get; set; }

    /// <summary>
    /// 家庭电话。
    /// </summary>
    [JsonPropertyName("kh_tel")]
    public string? KhTel { get; set; }

    /// <summary>
    /// 微信号。
    /// </summary>
    [JsonPropertyName("kh_weixin")]
    public string? KhWeixin { get; set; }

    /// <summary>
    /// QQ号。
    /// </summary>
    [JsonPropertyName("kh_qq")]
    public string? KhQq { get; set; }

    /// <summary>
    /// Skype账号。
    /// </summary>
    [JsonPropertyName("kh_skype")]
    public string? KhSkype { get; set; }

    /// <summary>
    /// 旺旺。
    /// </summary>
    [JsonPropertyName("kh_wangwang")]
    public string? KhWangwang { get; set; }

    /// <summary>
    /// 工作电话。
    /// </summary>
    [JsonPropertyName("kh_worktel")]
    public string? KhWorktel { get; set; }

    /// <summary>
    /// 传真。
    /// </summary>
    [JsonPropertyName("kh_fax")]
    public string? KhFax { get; set; }

    /// <summary>
    /// 邮编。
    /// </summary>
    [JsonPropertyName("kh_pst")]
    public string? KhPst { get; set; }

    /// <summary>
    /// 部门。
    /// </summary>
    [JsonPropertyName("kh_department")]
    public string? KhDepartment { get; set; }

    /// <summary>
    /// 称谓。
    /// </summary>
    [JsonPropertyName("kh_appellation")]
    public string? KhAppellation { get; set; }

    /// <summary>
    /// 负责业务。
    /// </summary>
    [JsonPropertyName("kh_preside")]
    public string? KhPreside { get; set; }

    /// <summary>
    /// 职务。
    /// </summary>
    [JsonPropertyName("kh_headship")]
    public string? KhHeadship { get; set; }

    /// <summary>
    /// 网址。
    /// </summary>
    [JsonPropertyName("kh_web")]
    public string? KhWeb { get; set; }

    /// <summary>
    /// 爱好。
    /// </summary>
    [JsonPropertyName("kh_befontof")]
    public string? KhBefontof { get; set; }

    /// <summary>
    /// 来源。
    /// </summary>
    [JsonPropertyName("kh_from")]
    public string? KhFrom { get; set; }

    /// <summary>
    /// 开票资料。
    /// </summary>
    [JsonPropertyName("kh_billinfo")]
    public string? KhBillinfo { get; set; }

    /// <summary>
    /// 公司简介。
    /// </summary>
    [JsonPropertyName("kh_info")]
    public string? KhInfo { get; set; }

    /// <summary>
    /// 关系等级。
    /// </summary>
    [JsonPropertyName("kh_ralagrade")]
    public string? KhRalagrade { get; set; }

    /// <summary>
    /// 信用等级，取值。
    /// </summary>
    [JsonPropertyName("kh_creditgrade")]
    public string? KhCreditgrade { get; set; }

    /// <summary>
    /// 价值评估，取值。
    /// </summary>
    [JsonPropertyName("kh_valrating")]
    public string? KhValrating { get; set; }

    /// <summary>
    /// 证件类型。
    /// </summary>
    [JsonPropertyName("kh_cttype")]
    public string? KhCttype { get; set; }

    /// <summary>
    /// 证件号码。
    /// </summary>
    [JsonPropertyName("kh_ctnumber")]
    public string? KhCtnumber { get; set; }

    /// <summary>
    /// 联系人分类。
    /// </summary>
    [JsonPropertyName("kh_contype")]
    public string? KhContype { get; set; }

    /// <summary>
    /// 备注。
    /// </summary>
    [JsonPropertyName("kh_remark")]
    public string? KhRemark { get; set; }

    /// <summary>
    /// 客户级别。
    /// </summary>
    [JsonPropertyName("kh_jibie")]
    public string? KhJibie { get; set; }

    /// <summary>
    /// 最后跟踪。
    /// </summary>
    [JsonPropertyName("kh_genzongtime")]
    public string? KhGenzongtime { get; set; }
}

/// <summary>
/// 客户公共池请求
/// </summary>
public class PostV1JzCrmCustomerPoolsRequest
{
    /// <summary>
    /// 数据类型，固定值238。
    /// </summary>
    [JsonPropertyName("datatype")]
    public long Datatype { get; set; }

    /// <summary>
    /// 时间戳。
    /// </summary>
    [JsonPropertyName("stamp")]
    public long Stamp { get; set; }

    /// <summary>
    /// 数据ID。 值为0或不填时，为新增数据。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }

    /// <summary>
    /// 编辑数据。
    /// </summary>
    [JsonPropertyName("data")]
    public PostV1JzCrmCustomerPoolsRequestData? Data { get; set; }
}

/// <summary>
/// 客户公共池响应
/// </summary>
public class PostV1JzCrmCustomerPoolsResponse
{
    /// <summary>
    /// 响应时间。
    /// </summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>
    /// 编辑数据的ID。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }
}

/// <summary>
/// 编辑数据。
/// </summary>
public class PostV1JzCrmContactsRequestData
{
    /// <summary>
    /// 创建人。
    /// </summary>
    [JsonPropertyName("data_userid")]
    public required string DataUserid { get; set; }

    /// <summary>
    /// 对应客户。
    /// </summary>
    [JsonPropertyName("lxr_customerid")]
    public required string LxrCustomerid { get; set; }

    /// <summary>
    /// 姓名。
    /// </summary>
    [JsonPropertyName("lxr_name")]
    public required string LxrName { get; set; }

    /// <summary>
    /// 手机。
    /// </summary>
    [JsonPropertyName("lxr_handset")]
    public string? LxrHandset { get; set; }

    /// <summary>
    /// 工作电话。
    /// </summary>
    [JsonPropertyName("lxr_worktel")]
    public string? LxrWorktel { get; set; }

    /// <summary>
    /// 性别，取值。
    /// </summary>
    [JsonPropertyName("lxr_sex")]
    public string? LxrSex { get; set; }

    /// <summary>
    /// 分类。
    /// </summary>
    [JsonPropertyName("lxr_group")]
    public string? LxrGroup { get; set; }

    /// <summary>
    /// 负责业务。
    /// </summary>
    [JsonPropertyName("lxr_preside")]
    public string? LxrPreside { get; set; }

    /// <summary>
    /// 证件类型。
    /// </summary>
    [JsonPropertyName("lxr_cttype")]
    public string? LxrCttype { get; set; }

    /// <summary>
    /// 证件号码。
    /// </summary>
    [JsonPropertyName("lxr_ctnumber")]
    public string? LxrCtnumber { get; set; }

    /// <summary>
    /// 称谓。
    /// </summary>
    [JsonPropertyName("lxr_chengwei")]
    public string? LxrChengwei { get; set; }

    /// <summary>
    /// 类型，取值。
    /// </summary>
    [JsonPropertyName("lxr_type")]
    public string? LxrType { get; set; }

    /// <summary>
    /// 部门。
    /// </summary>
    [JsonPropertyName("lxr_department")]
    public string? LxrDepartment { get; set; }

    /// <summary>
    /// 职务。
    /// </summary>
    [JsonPropertyName("lxr_headship")]
    public string? LxrHeadship { get; set; }

    /// <summary>
    /// 钉钉号。
    /// </summary>
    [JsonPropertyName("lxr_dingtalk")]
    public string? LxrDingtalk { get; set; }

    /// <summary>
    /// 传真。
    /// </summary>
    [JsonPropertyName("lxr_fax")]
    public string? LxrFax { get; set; }

    /// <summary>
    /// 旺旺。
    /// </summary>
    [JsonPropertyName("lxr_wangwang")]
    public string? LxrWangwang { get; set; }

    /// <summary>
    /// 邮箱。
    /// </summary>
    [JsonPropertyName("lxr_email")]
    public string? LxrEmail { get; set; }

    /// <summary>
    /// 微信号
    /// </summary>
    [JsonPropertyName("lxr_weixin")]
    public string? LxrWeixin { get; set; }

    /// <summary>
    /// QQ号。
    /// </summary>
    [JsonPropertyName("lxr_qq")]
    public string? LxrQq { get; set; }

    /// <summary>
    /// 家庭电话。
    /// </summary>
    [JsonPropertyName("lxr_tel")]
    public string? LxrTel { get; set; }

    /// <summary>
    /// 邮编。
    /// </summary>
    [JsonPropertyName("lxr_pst")]
    public string? LxrPst { get; set; }

    /// <summary>
    /// Skype账号。
    /// </summary>
    [JsonPropertyName("lxr_skype")]
    public string? LxrSkype { get; set; }

    /// <summary>
    /// 住址。
    /// </summary>
    [JsonPropertyName("lxr_address")]
    public string? LxrAddress { get; set; }

    /// <summary>
    /// 生日。
    /// </summary>
    [JsonPropertyName("lxr_birthday")]
    public string? LxrBirthday { get; set; }

    /// <summary>
    /// 爱好。
    /// </summary>
    [JsonPropertyName("lxr_like")]
    public string? LxrLike { get; set; }

    /// <summary>
    /// 备注。
    /// </summary>
    [JsonPropertyName("lxr_remark")]
    public string? LxrRemark { get; set; }

    /// <summary>
    /// 联系名片。
    /// </summary>
    [JsonPropertyName("lxr_photo")]
    public string? LxrPhoto { get; set; }
}

/// <summary>
/// 联系人请求
/// </summary>
public class PostV1JzCrmContactsRequest
{
    /// <summary>
    /// 数据类型，固定值197。
    /// </summary>
    [JsonPropertyName("datatype")]
    public long Datatype { get; set; }

    /// <summary>
    /// 时间戳。
    /// </summary>
    [JsonPropertyName("stamp")]
    public long Stamp { get; set; }

    /// <summary>
    /// 数据ID。 值为0或不填时，为新增数据。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }

    /// <summary>
    /// 编辑数据。
    /// </summary>
    [JsonPropertyName("data")]
    public PostV1JzCrmContactsRequestData? Data { get; set; }
}

/// <summary>
/// 联系人响应
/// </summary>
public class PostV1JzCrmContactsResponse
{
    /// <summary>
    /// 响应时间。
    /// </summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>
    /// 编辑数据的ID。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }
}

/// <summary>
/// 编辑数据。
/// </summary>
public class PostV1JzCrmOrdersRequestData
{
    /// <summary>
    /// 创建人。
    /// </summary>
    [JsonPropertyName("data_userid")]
    public required string DataUserid { get; set; }

    /// <summary>
    /// 对应客户。
    /// </summary>
    [JsonPropertyName("ht_customerid")]
    public required string HtCustomerid { get; set; }

    /// <summary>
    /// 签单日期。
    /// </summary>
    [JsonPropertyName("ht_date")]
    public required string HtDate { get; set; }

    /// <summary>
    /// 所有者。
    /// </summary>
    [JsonPropertyName("ht_preside")]
    public required string HtPreside { get; set; }

    /// <summary>
    /// 状态，取值。
    /// </summary>
    [JsonPropertyName("ht_state")]
    public required string HtState { get; set; }

    /// <summary>
    /// 总金额。
    /// </summary>
    [JsonPropertyName("ht_summoney")]
    public required string HtSummoney { get; set; }

    /// <summary>
    /// 单据类型，取值。
    /// </summary>
    [JsonPropertyName("ht_order")]
    public required string HtOrder { get; set; }

    /// <summary>
    /// 主题。
    /// </summary>
    [JsonPropertyName("ht_title")]
    public string? HtTitle { get; set; }

    /// <summary>
    /// 合同单号。
    /// </summary>
    [JsonPropertyName("ht_number")]
    public string? HtNumber { get; set; }

    /// <summary>
    /// 对应联系人。
    /// </summary>
    [JsonPropertyName("ht_lxrid")]
    public string? HtLxrid { get; set; }

    /// <summary>
    /// 联系方式。
    /// </summary>
    [JsonPropertyName("ht_lxrinfo")]
    public string? HtLxrinfo { get; set; }

    /// <summary>
    /// 对应机会。
    /// </summary>
    [JsonPropertyName("ht_xshid")]
    public string? HtXshid { get; set; }

    /// <summary>
    /// 自定义分类。
    /// </summary>
    [JsonPropertyName("ht_type")]
    public string? HtType { get; set; }

    /// <summary>
    /// 付款方式。
    /// </summary>
    [JsonPropertyName("ht_paymode")]
    public string? HtPaymode { get; set; }

    /// <summary>
    /// 开始日期。
    /// </summary>
    [JsonPropertyName("ht_begindate")]
    public string? HtBegindate { get; set; }

    /// <summary>
    /// 客户签约人。
    /// </summary>
    [JsonPropertyName("ht_cusub")]
    public string? HtCusub { get; set; }

    /// <summary>
    /// 我方签约人。
    /// </summary>
    [JsonPropertyName("ht_wesub")]
    public string? HtWesub { get; set; }

    /// <summary>
    /// 优惠折扣率。
    /// </summary>
    [JsonPropertyName("ht_moneyzhekou")]
    public string? HtMoneyzhekou { get; set; }

    /// <summary>
    /// 优惠抹零金额。
    /// </summary>
    [JsonPropertyName("ht_kjmoney")]
    public string? HtKjmoney { get; set; }

    /// <summary>
    /// 附加费用分类。
    /// </summary>
    [JsonPropertyName("ht_fjmoneylx")]
    public string? HtFjmoneylx { get; set; }

    /// <summary>
    /// 附加费用金额。
    /// </summary>
    [JsonPropertyName("ht_fjmoney")]
    public string? HtFjmoney { get; set; }

    /// <summary>
    /// 外币备注。
    /// </summary>
    [JsonPropertyName("ht_summemo")]
    public string? HtSummemo { get; set; }

    /// <summary>
    /// 交付地点。
    /// </summary>
    [JsonPropertyName("ht_deliplace")]
    public string? HtDeliplace { get; set; }

    /// <summary>
    /// 最晚发货日。
    /// </summary>
    [JsonPropertyName("ht_enddate")]
    public string? HtEnddate { get; set; }

    /// <summary>
    /// 发货方式。
    /// </summary>
    [JsonPropertyName("ht_wuliutype")]
    public string? HtWuliutype { get; set; }

    /// <summary>
    /// 预计运费。
    /// </summary>
    [JsonPropertyName("ht_yunfeimoney")]
    public string? HtYunfeimoney { get; set; }

    /// <summary>
    /// 收货地址。
    /// </summary>
    [JsonPropertyName("fahuoaddressid")]
    public string? Fahuoaddressid { get; set; }

    /// <summary>
    /// 合同正文。
    /// </summary>
    [JsonPropertyName("ht_contract")]
    public string? HtContract { get; set; }

    /// <summary>
    /// 备注。
    /// </summary>
    [JsonPropertyName("ht_remark")]
    public string? HtRemark { get; set; }

    /// <summary>
    /// 产品明细，json格式。
    /// </summary>
    [JsonPropertyName("child_mx")]
    public string? ChildMx { get; set; }
}

/// <summary>
/// 合同订单请求
/// </summary>
public class PostV1JzCrmOrdersRequest
{
    /// <summary>
    /// 数据类型，固定填写150。
    /// </summary>
    [JsonPropertyName("datatype")]
    public long Datatype { get; set; }

    /// <summary>
    /// 时间戳。
    /// </summary>
    [JsonPropertyName("stamp")]
    public long Stamp { get; set; }

    /// <summary>
    /// 数据ID。 值为0或不填时，为新增数据。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }

    /// <summary>
    /// 编辑数据。
    /// </summary>
    [JsonPropertyName("data")]
    public PostV1JzCrmOrdersRequestData? Data { get; set; }
}

/// <summary>
/// 合同订单响应
/// </summary>
public class PostV1JzCrmOrdersResponse
{
    /// <summary>
    /// 响应时间。
    /// </summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>
    /// 编辑数据的ID。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }
}

/// <summary>
/// 编辑数据。
/// </summary>
public class PostV1JzCrmInvoicesRequestData
{
    /// <summary>
    /// 创建人。
    /// </summary>
    [JsonPropertyName("data_userid")]
    public required string DataUserid { get; set; }

    /// <summary>
    /// 对应客户。
    /// </summary>
    [JsonPropertyName("fh_customerid")]
    public required string FhCustomerid { get; set; }

    /// <summary>
    /// 发货日期。
    /// </summary>
    [JsonPropertyName("fh_date")]
    public required string FhDate { get; set; }

    /// <summary>
    /// 发货单号。
    /// </summary>
    [JsonPropertyName("fh_number")]
    public required string FhNumber { get; set; }

    /// <summary>
    /// 发货方式。
    /// </summary>
    [JsonPropertyName("fh_mode")]
    public required string FhMode { get; set; }

    /// <summary>
    /// 对应订单。
    /// </summary>
    [JsonPropertyName("fh_htorder")]
    public string? FhHtorder { get; set; }

    /// <summary>
    /// 发货主题。
    /// </summary>
    [JsonPropertyName("fh_title")]
    public string? FhTitle { get; set; }

    /// <summary>
    /// 运费。
    /// </summary>
    [JsonPropertyName("fh_yunfei")]
    public string? FhYunfei { get; set; }

    /// <summary>
    /// 打包件数。
    /// </summary>
    [JsonPropertyName("fh_jianshu")]
    public string? FhJianshu { get; set; }

    /// <summary>
    /// 重量，单位：Kg。
    /// </summary>
    [JsonPropertyName("fh_kg")]
    public string? FhKg { get; set; }

    /// <summary>
    /// 发货人。
    /// </summary>
    [JsonPropertyName("fh_shipper")]
    public string? FhShipper { get; set; }

    /// <summary>
    /// 所有者。
    /// </summary>
    [JsonPropertyName("fh_preside")]
    public string? FhPreside { get; set; }

    /// <summary>
    /// 联系人。
    /// </summary>
    [JsonPropertyName("fh_lxrid")]
    public string? FhLxrid { get; set; }

    /// <summary>
    /// 收货人。
    /// </summary>
    [JsonPropertyName("fh_linkman")]
    public string? FhLinkman { get; set; }

    /// <summary>
    /// 电话。
    /// </summary>
    [JsonPropertyName("fh_tel")]
    public string? FhTel { get; set; }

    /// <summary>
    /// 手机。
    /// </summary>
    [JsonPropertyName("fh_handset")]
    public string? FhHandset { get; set; }

    /// <summary>
    /// 邮编。
    /// </summary>
    [JsonPropertyName("fh_post")]
    public string? FhPost { get; set; }

    /// <summary>
    /// 地址。
    /// </summary>
    [JsonPropertyName("fh_address")]
    public string? FhAddress { get; set; }

    /// <summary>
    /// 邮箱。
    /// </summary>
    [JsonPropertyName("fh_email")]
    public string? FhEmail { get; set; }

    /// <summary>
    /// MSN账号。
    /// </summary>
    [JsonPropertyName("fh_msn")]
    public string? FhMsn { get; set; }

    /// <summary>
    /// 备注。
    /// </summary>
    [JsonPropertyName("fh_remark")]
    public string? FhRemark { get; set; }

    /// <summary>
    /// 发货状态。
    /// </summary>
    [JsonPropertyName("fh_state")]
    public string? FhState { get; set; }

    /// <summary>
    /// 产品明细，json格式。
    /// </summary>
    [JsonPropertyName("child_mx")]
    public string? ChildMx { get; set; }
}

/// <summary>
/// 发货单请求
/// </summary>
public class PostV1JzCrmInvoicesRequest
{
    /// <summary>
    /// 数据类型，固定值169。
    /// </summary>
    [JsonPropertyName("datatype")]
    public long Datatype { get; set; }

    /// <summary>
    /// 时间戳。
    /// </summary>
    [JsonPropertyName("stamp")]
    public long Stamp { get; set; }

    /// <summary>
    /// 数据ID。 值为0或不填时，为新增数据。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }

    /// <summary>
    /// 编辑数据。
    /// </summary>
    [JsonPropertyName("data")]
    public PostV1JzCrmInvoicesRequestData? Data { get; set; }
}

/// <summary>
/// 发货单响应
/// </summary>
public class PostV1JzCrmInvoicesResponse
{
    /// <summary>
    /// 响应时间。
    /// </summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>
    /// 编辑数据的ID。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }
}

/// <summary>
/// 编辑数据。
/// </summary>
public class PostV1JzCrmExchangesRequestData
{
    /// <summary>
    /// 创建人。
    /// </summary>
    [JsonPropertyName("data_userid")]
    public required string DataUserid { get; set; }

    /// <summary>
    /// 换入仓库。
    /// </summary>
    [JsonPropertyName("hh_inlibid")]
    public required string HhInlibid { get; set; }

    /// <summary>
    /// 换出仓库。
    /// </summary>
    [JsonPropertyName("hh_outlibid")]
    public required string HhOutlibid { get; set; }

    /// <summary>
    /// 主题。
    /// </summary>
    [JsonPropertyName("hh_title")]
    public required string HhTitle { get; set; }

    /// <summary>
    /// 换货单号。
    /// </summary>
    [JsonPropertyName("hh_number")]
    public required string HhNumber { get; set; }

    /// <summary>
    /// 对应客户。
    /// </summary>
    [JsonPropertyName("hh_customerid")]
    public string? HhCustomerid { get; set; }

    /// <summary>
    /// 取值。
    /// </summary>
    [JsonPropertyName("hh_orderid")]
    public string? HhOrderid { get; set; }

    /// <summary>
    /// 分类。
    /// </summary>
    [JsonPropertyName("hh_type")]
    public string? HhType { get; set; }

    /// <summary>
    /// 换货日期。
    /// </summary>
    [JsonPropertyName("hh_date")]
    public string? HhDate { get; set; }

    /// <summary>
    /// 换入操作员。
    /// </summary>
    [JsonPropertyName("hh_inempid")]
    public string? HhInempid { get; set; }

    /// <summary>
    /// 换入时间。
    /// </summary>
    [JsonPropertyName("hh_intime")]
    public string? HhIntime { get; set; }

    /// <summary>
    /// 换出操作员。
    /// </summary>
    [JsonPropertyName("hh_outempid")]
    public string? HhOutempid { get; set; }

    /// <summary>
    /// 换出时间。
    /// </summary>
    [JsonPropertyName("hh_outtime")]
    public string? HhOuttime { get; set; }

    /// <summary>
    /// 备注。
    /// </summary>
    [JsonPropertyName("hh_remark")]
    public string? HhRemark { get; set; }

    /// <summary>
    /// 状态，取值。
    /// </summary>
    [JsonPropertyName("hh_state")]
    public string? HhState { get; set; }

    /// <summary>
    /// 产品明细，json格式。
    /// </summary>
    [JsonPropertyName("child_mx")]
    public string? ChildMx { get; set; }
}

/// <summary>
/// 销售换货单请求
/// </summary>
public class PostV1JzCrmExchangesRequest
{
    /// <summary>
    /// 数据类型，固定值228。
    /// </summary>
    [JsonPropertyName("datatype")]
    public long Datatype { get; set; }

    /// <summary>
    /// 时间戳。
    /// </summary>
    [JsonPropertyName("stamp")]
    public long Stamp { get; set; }

    /// <summary>
    /// 数据ID。 值为0或不填时，为新增数据。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }

    /// <summary>
    /// 编辑数据。
    /// </summary>
    [JsonPropertyName("data")]
    public PostV1JzCrmExchangesRequestData? Data { get; set; }
}

/// <summary>
/// 销售换货单响应
/// </summary>
public class PostV1JzCrmExchangesResponse
{
    /// <summary>
    /// 响应时间。
    /// </summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>
    /// 编辑数据的ID。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }
}

/// <summary>
/// 编辑数据。
/// </summary>
public class PostV1JzCrmSalesRequestData
{
    /// <summary>
    /// 创建人。
    /// </summary>
    [JsonPropertyName("data_userid")]
    public required string DataUserid { get; set; }

    /// <summary>
    /// 对应客户。
    /// </summary>
    [JsonPropertyName("xsh_customerid")]
    public required string XshCustomerid { get; set; }

    /// <summary>
    /// 主题。
    /// </summary>
    [JsonPropertyName("xsh_title")]
    public required string XshTitle { get; set; }

    /// <summary>
    /// 发现时间。
    /// </summary>
    [JsonPropertyName("xsh_date")]
    public required string XshDate { get; set; }

    /// <summary>
    /// 机会编号。
    /// </summary>
    [JsonPropertyName("xsh_number")]
    public string? XshNumber { get; set; }

    /// <summary>
    /// 联系人。
    /// </summary>
    [JsonPropertyName("xsh_lxrid")]
    public string? XshLxrid { get; set; }

    /// <summary>
    /// 联系方式。
    /// </summary>
    [JsonPropertyName("xsh_lianxi")]
    public string? XshLianxi { get; set; }

    /// <summary>
    /// 类型。
    /// </summary>
    [JsonPropertyName("xsh_type")]
    public string? XshType { get; set; }

    /// <summary>
    /// 来源。
    /// </summary>
    [JsonPropertyName("xsh_from")]
    public string? XshFrom { get; set; }

    /// <summary>
    /// 所有者。
    /// </summary>
    [JsonPropertyName("xsh_preside")]
    public string? XshPreside { get; set; }

    /// <summary>
    /// 提供人。
    /// </summary>
    [JsonPropertyName("xsh_provider")]
    public string? XshProvider { get; set; }

    /// <summary>
    /// 客户需求。
    /// </summary>
    [JsonPropertyName("xsh_require")]
    public string? XshRequire { get; set; }

    /// <summary>
    /// 预计签单日。
    /// </summary>
    [JsonPropertyName("xsh_expdate")]
    public string? XshExpdate { get; set; }

    /// <summary>
    /// 预期金额。
    /// </summary>
    [JsonPropertyName("xsh_expmoney")]
    public string? XshExpmoney { get; set; }

    /// <summary>
    /// 外币备注。
    /// </summary>
    [JsonPropertyName("xsh_moneynote")]
    public string? XshMoneynote { get; set; }

    /// <summary>
    /// 阶段。
    /// </summary>
    [JsonPropertyName("xsh_phase")]
    public string? XshPhase { get; set; }

    /// <summary>
    /// 可能性。
    /// </summary>
    [JsonPropertyName("xsh_knx")]
    public string? XshKnx { get; set; }

    /// <summary>
    /// 状态。
    /// </summary>
    [JsonPropertyName("xsh_state")]
    public string? XshState { get; set; }

    /// <summary>
    /// 阶段备注。
    /// </summary>
    [JsonPropertyName("xsh_phasenote")]
    public string? XshPhasenote { get; set; }
}

/// <summary>
/// 销售机会请求
/// </summary>
public class PostV1JzCrmSalesRequest
{
    /// <summary>
    /// 数据类型，固定值158。
    /// </summary>
    [JsonPropertyName("datatype")]
    public long Datatype { get; set; }

    /// <summary>
    /// 时间戳。
    /// </summary>
    [JsonPropertyName("stamp")]
    public long Stamp { get; set; }

    /// <summary>
    /// 数据ID、 值为0或不填时，为新增数据。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }

    /// <summary>
    /// 编辑数据。
    /// </summary>
    [JsonPropertyName("data")]
    public PostV1JzCrmSalesRequestData? Data { get; set; }
}

/// <summary>
/// 销售机会响应
/// </summary>
public class PostV1JzCrmSalesResponse
{
    /// <summary>
    /// 响应时间。
    /// </summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>
    /// 编辑数据的ID。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }
}

/// <summary>
/// 编辑数据。
/// </summary>
public class PostV1JzCrmQuotationRecordsRequestData
{
    /// <summary>
    /// 创建人。
    /// </summary>
    [JsonPropertyName("data_userid")]
    public required string DataUserid { get; set; }

    /// <summary>
    /// 对应客户。
    /// </summary>
    [JsonPropertyName("bj_customerid")]
    public required string BjCustomerid { get; set; }

    /// <summary>
    /// 报价人。
    /// </summary>
    [JsonPropertyName("bj_bjren")]
    public required string BjBjren { get; set; }

    /// <summary>
    /// 报价日期。
    /// </summary>
    [JsonPropertyName("bj_date")]
    public required string BjDate { get; set; }

    /// <summary>
    /// 报价（总）。
    /// </summary>
    [JsonPropertyName("bj_price")]
    public required string BjPrice { get; set; }

    /// <summary>
    /// 主题。
    /// </summary>
    [JsonPropertyName("bj_title")]
    public string? BjTitle { get; set; }

    /// <summary>
    /// 报价单号。
    /// </summary>
    [JsonPropertyName("bj_number")]
    public string? BjNumber { get; set; }

    /// <summary>
    /// 转成订单。
    /// </summary>
    [JsonPropertyName("bj_state")]
    public string? BjState { get; set; }

    /// <summary>
    /// 接收人。
    /// </summary>
    [JsonPropertyName("bj_jshren")]
    public string? BjJshren { get; set; }

    /// <summary>
    /// 联系方式。
    /// </summary>
    [JsonPropertyName("bj_lianxi")]
    public string? BjLianxi { get; set; }

    /// <summary>
    /// 对应机会。
    /// </summary>
    [JsonPropertyName("bj_xshid")]
    public string? BjXshid { get; set; }

    /// <summary>
    /// 优惠折扣率。
    /// </summary>
    [JsonPropertyName("bj_moneyzhekou")]
    public string? BjMoneyzhekou { get; set; }

    /// <summary>
    /// 优惠抹零金额。
    /// </summary>
    [JsonPropertyName("bj_kjmoney")]
    public string? BjKjmoney { get; set; }

    /// <summary>
    /// 附加费用分类。
    /// </summary>
    [JsonPropertyName("bj_fjmoneylx")]
    public string? BjFjmoneylx { get; set; }

    /// <summary>
    /// 附加费用金额。
    /// </summary>
    [JsonPropertyName("bj_fjmoney")]
    public string? BjFjmoney { get; set; }

    /// <summary>
    /// 交付说明。
    /// </summary>
    [JsonPropertyName("bj_jfremark")]
    public string? BjJfremark { get; set; }

    /// <summary>
    /// 付款说明。
    /// </summary>
    [JsonPropertyName("bj_fkremark")]
    public string? BjFkremark { get; set; }

    /// <summary>
    /// 包装运输。
    /// </summary>
    [JsonPropertyName("bj_bzremark")]
    public string? BjBzremark { get; set; }

    /// <summary>
    /// 备注。
    /// </summary>
    [JsonPropertyName("bj_remark")]
    public string? BjRemark { get; set; }

    /// <summary>
    /// 产品明细，json格式。
    /// </summary>
    [JsonPropertyName("child_mx")]
    public string? ChildMx { get; set; }
}

/// <summary>
/// 报价记录请求
/// </summary>
public class PostV1JzCrmQuotationRecordsRequest
{
    /// <summary>
    /// 数据类型，固定值161。
    /// </summary>
    [JsonPropertyName("datatype")]
    public long Datatype { get; set; }

    /// <summary>
    /// 时间戳。
    /// </summary>
    [JsonPropertyName("stamp")]
    public long Stamp { get; set; }

    /// <summary>
    /// 数据ID。 值为0或不填时，为新增数据。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }

    /// <summary>
    /// 编辑数据。
    /// </summary>
    [JsonPropertyName("data")]
    public PostV1JzCrmQuotationRecordsRequestData? Data { get; set; }
}

/// <summary>
/// 报价记录响应
/// </summary>
public class PostV1JzCrmQuotationRecordsResponse
{
    /// <summary>
    /// 响应时间。
    /// </summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>
    /// 编辑数据的ID。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }
}

/// <summary>
/// 编辑数据。
/// </summary>
public class PostV1JzCrmPurchasesRequestData
{
    /// <summary>
    /// 创建人。
    /// </summary>
    [JsonPropertyName("data_userid")]
    public required string DataUserid { get; set; }

    /// <summary>
    /// 供应商。
    /// </summary>
    [JsonPropertyName("gysid")]
    public required string Gysid { get; set; }

    /// <summary>
    /// 采购单号。
    /// </summary>
    [JsonPropertyName("cgno")]
    public required string Cgno { get; set; }

    /// <summary>
    /// 采购金额。
    /// </summary>
    [JsonPropertyName("summoney")]
    public required string Summoney { get; set; }

    /// <summary>
    /// 采购日期。
    /// </summary>
    [JsonPropertyName("cgdate")]
    public required string Cgdate { get; set; }

    /// <summary>
    /// 执行状态，取值。
    /// </summary>
    [JsonPropertyName("cg_zxstate")]
    public required string CgZxstate { get; set; }

    /// <summary>
    /// 关联订单客户。
    /// </summary>
    [JsonPropertyName("order_khid")]
    public string? OrderKhid { get; set; }

    /// <summary>
    /// 采购主题。
    /// </summary>
    [JsonPropertyName("cgname")]
    public string? Cgname { get; set; }

    /// <summary>
    /// 供应商联系人。
    /// </summary>
    [JsonPropertyName("gys_lxrid")]
    public string? GysLxrid { get; set; }

    /// <summary>
    /// 联系方式。
    /// </summary>
    [JsonPropertyName("gys_lxrinfo")]
    public string? GysLxrinfo { get; set; }

    /// <summary>
    /// 自定义采购分类
    /// </summary>
    [JsonPropertyName("cgtype")]
    public string? Cgtype { get; set; }

    /// <summary>
    /// 供应商代表。
    /// </summary>
    [JsonPropertyName("gysjingban")]
    public string? Gysjingban { get; set; }

    /// <summary>
    /// 我方代表。
    /// </summary>
    [JsonPropertyName("empid")]
    public string? Empid { get; set; }

    /// <summary>
    /// 优惠折扣率。
    /// </summary>
    [JsonPropertyName("cg_moneyzhekou")]
    public string? CgMoneyzhekou { get; set; }

    /// <summary>
    /// 优惠抹零金额。
    /// </summary>
    [JsonPropertyName("cg_kjmoney")]
    public string? CgKjmoney { get; set; }

    /// <summary>
    /// 附加费用分类。
    /// </summary>
    [JsonPropertyName("cg_fjmoneylx")]
    public string? CgFjmoneylx { get; set; }

    /// <summary>
    /// 附加费用金额。
    /// </summary>
    [JsonPropertyName("cg_fjmoney")]
    public string? CgFjmoney { get; set; }

    /// <summary>
    /// 关联订单。
    /// </summary>
    [JsonPropertyName("order_htid")]
    public string? OrderHtid { get; set; }

    /// <summary>
    /// 采购摘要。
    /// </summary>
    [JsonPropertyName("cgremark")]
    public string? Cgremark { get; set; }

    /// <summary>
    /// 产品明细，json格式。
    /// </summary>
    [JsonPropertyName("child_mx")]
    public string? ChildMx { get; set; }
}

/// <summary>
/// 采购单请求
/// </summary>
public class PostV1JzCrmPurchasesRequest
{
    /// <summary>
    /// 数据类型，固定值153。
    /// </summary>
    [JsonPropertyName("datatype")]
    public long Datatype { get; set; }

    /// <summary>
    /// 时间戳。
    /// </summary>
    [JsonPropertyName("stamp")]
    public long Stamp { get; set; }

    /// <summary>
    /// 数据ID。 值为0或不填时，为新增数据。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }

    /// <summary>
    /// 编辑数据。
    /// </summary>
    [JsonPropertyName("data")]
    public PostV1JzCrmPurchasesRequestData? Data { get; set; }
}

/// <summary>
/// 采购单响应
/// </summary>
public class PostV1JzCrmPurchasesResponse
{
    /// <summary>
    /// 响应时间。
    /// </summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>
    /// 编辑数据的ID。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }
}

/// <summary>
/// 编辑数据。
/// </summary>
public class PostV1JzCrmProductionsRequestData
{
    /// <summary>
    /// 创建人。
    /// </summary>
    [JsonPropertyName("data_userid")]
    public required string DataUserid { get; set; }

    /// <summary>
    /// 主题。
    /// </summary>
    [JsonPropertyName("sch_title")]
    public required string SchTitle { get; set; }

    /// <summary>
    /// 单号。
    /// </summary>
    [JsonPropertyName("sch_number")]
    public required string SchNumber { get; set; }

    /// <summary>
    /// 开始日期。
    /// </summary>
    [JsonPropertyName("sch_starttime")]
    public required string SchStarttime { get; set; }

    /// <summary>
    /// 计划完成时间。
    /// </summary>
    [JsonPropertyName("sch_planendtime")]
    public required string SchPlanendtime { get; set; }

    /// <summary>
    /// 对应客户。
    /// </summary>
    [JsonPropertyName("sch_customerid")]
    public string? SchCustomerid { get; set; }

    /// <summary>
    /// 订单。
    /// </summary>
    [JsonPropertyName("sch_htid")]
    public string? SchHtid { get; set; }

    /// <summary>
    /// 完成日期。
    /// </summary>
    [JsonPropertyName("sch_endtime")]
    public string? SchEndtime { get; set; }

    /// <summary>
    /// 负责人。
    /// </summary>
    [JsonPropertyName("sch_principal")]
    public string? SchPrincipal { get; set; }

    /// <summary>
    /// 生产人员。
    /// </summary>
    [JsonPropertyName("sch_makeemp")]
    public string? SchMakeemp { get; set; }

    /// <summary>
    /// 备注。
    /// </summary>
    [JsonPropertyName("sch_remark")]
    public string? SchRemark { get; set; }

    /// <summary>
    /// 阶段，取值。
    /// </summary>
    [JsonPropertyName("sch_statesstr")]
    public string? SchStatesstr { get; set; }

    /// <summary>
    /// 状态，取值。
    /// </summary>
    [JsonPropertyName("sch_finished")]
    public string? SchFinished { get; set; }
}

/// <summary>
/// 生产单请求
/// </summary>
public class PostV1JzCrmProductionsRequest
{
    /// <summary>
    /// 数据类型，固定值156。
    /// </summary>
    [JsonPropertyName("datatype")]
    public long Datatype { get; set; }

    /// <summary>
    /// 时间戳。
    /// </summary>
    [JsonPropertyName("stamp")]
    public long Stamp { get; set; }

    /// <summary>
    /// 数据ID。 值为0或不填时，为新增数据。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }

    /// <summary>
    /// 编辑数据。
    /// </summary>
    [JsonPropertyName("data")]
    public PostV1JzCrmProductionsRequestData? Data { get; set; }
}

/// <summary>
/// 生产单响应
/// </summary>
public class PostV1JzCrmProductionsResponse
{
    /// <summary>
    /// 响应时间。
    /// </summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>
    /// 编辑数据的ID。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }
}

/// <summary>
/// 编辑数据。
/// </summary>
public class PostV1JzCrmGoodsRequestData
{
    /// <summary>
    /// 创建人。
    /// </summary>
    [JsonPropertyName("data_userid")]
    public required string DataUserid { get; set; }

    /// <summary>
    /// 产品名称。
    /// </summary>
    [JsonPropertyName("cpname")]
    public required string Cpname { get; set; }

    /// <summary>
    /// 产品单位。
    /// </summary>
    [JsonPropertyName("cpunit")]
    public required string Cpunit { get; set; }

    /// <summary>
    /// 单位换算。
    /// </summary>
    [JsonPropertyName("unitrate")]
    public required string Unitrate { get; set; }

    /// <summary>
    /// 基准产品。
    /// </summary>
    [JsonPropertyName("cp_parentid")]
    public string? CpParentid { get; set; }

    /// <summary>
    /// 产品型号。
    /// </summary>
    [JsonPropertyName("cptype")]
    public string? Cptype { get; set; }

    /// <summary>
    /// 产品规格。
    /// </summary>
    [JsonPropertyName("cpguige")]
    public string? Cpguige { get; set; }

    /// <summary>
    /// 产品类别。
    /// </summary>
    [JsonPropertyName("typeid")]
    public string? Typeid { get; set; }

    /// <summary>
    /// 产品编号。
    /// </summary>
    [JsonPropertyName("cpno")]
    public string? Cpno { get; set; }

    /// <summary>
    /// 产品状态，取值。
    /// </summary>
    [JsonPropertyName("isstop")]
    public string? Isstop { get; set; }

    /// <summary>
    /// 上架时间。
    /// </summary>
    [JsonPropertyName("addedtime")]
    public string? Addedtime { get; set; }

    /// <summary>
    /// 产品产地。
    /// </summary>
    [JsonPropertyName("cparea")]
    public string? Cparea { get; set; }

    /// <summary>
    /// 产品品牌。
    /// </summary>
    [JsonPropertyName("cpbrand")]
    public string? Cpbrand { get; set; }

    /// <summary>
    /// 成本价格。
    /// </summary>
    [JsonPropertyName("cbprice")]
    public string? Cbprice { get; set; }

    /// <summary>
    /// 序列号管理，取值。
    /// </summary>
    [JsonPropertyName("issnmanage")]
    public string? Issnmanage { get; set; }

    /// <summary>
    /// 批次号管理，取值。
    /// </summary>
    [JsonPropertyName("ispicimanage")]
    public string? Ispicimanage { get; set; }

    /// <summary>
    /// 默认供应商。
    /// </summary>
    [JsonPropertyName("gysid")]
    public string? Gysid { get; set; }

    /// <summary>
    /// 产品图片。
    /// </summary>
    [JsonPropertyName("cpimg")]
    public string? Cpimg { get; set; }

    /// <summary>
    /// 条形码。
    /// </summary>
    [JsonPropertyName("cpbarcode")]
    public string? Cpbarcode { get; set; }

    /// <summary>
    /// 产品重量。
    /// </summary>
    [JsonPropertyName("cpweight")]
    public string? Cpweight { get; set; }

    /// <summary>
    /// 零售价格。
    /// </summary>
    [JsonPropertyName("preprice1")]
    public string? Preprice1 { get; set; }

    /// <summary>
    /// 预设价格1。
    /// </summary>
    [JsonPropertyName("preprice2")]
    public string? Preprice2 { get; set; }

    /// <summary>
    /// 预设价格2。
    /// </summary>
    [JsonPropertyName("preprice3")]
    public string? Preprice3 { get; set; }

    /// <summary>
    /// 预设价格3。
    /// </summary>
    [JsonPropertyName("preprice4")]
    public string? Preprice4 { get; set; }

    /// <summary>
    /// 是否算库存，取值。
    /// </summary>
    [JsonPropertyName("isstock")]
    public string? Isstock { get; set; }

    /// <summary>
    /// 库存上限。
    /// </summary>
    [JsonPropertyName("stockup")]
    public string? Stockup { get; set; }

    /// <summary>
    /// 库存下限。
    /// </summary>
    [JsonPropertyName("stockdown")]
    public string? Stockdown { get; set; }

    /// <summary>
    /// 产品说明。
    /// </summary>
    [JsonPropertyName("cpcontent")]
    public string? Cpcontent { get; set; }

    /// <summary>
    /// 产品备注。
    /// </summary>
    [JsonPropertyName("cpremark")]
    public string? Cpremark { get; set; }
}

/// <summary>
/// 产品信息请求
/// </summary>
public class PostV1JzCrmGoodsRequest
{
    /// <summary>
    /// 数据类型，固定值154。
    /// </summary>
    [JsonPropertyName("datatype")]
    public long Datatype { get; set; }

    /// <summary>
    /// 时间戳。
    /// </summary>
    [JsonPropertyName("stamp")]
    public long Stamp { get; set; }

    /// <summary>
    /// 数据ID。 值为0或不填时，为新增数据。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }

    /// <summary>
    /// 编辑数据。
    /// </summary>
    [JsonPropertyName("data")]
    public PostV1JzCrmGoodsRequestData? Data { get; set; }
}

/// <summary>
/// 产品信息响应
/// </summary>
public class PostV1JzCrmGoodsResponse
{
    /// <summary>
    /// 响应时间。
    /// </summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>
    /// 编辑数据的ID。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }
}

/// <summary>
/// 编辑数据。
/// </summary>
public class PostV1JzCrmIntoStocksRequestData
{
    /// <summary>
    /// 创建人。
    /// </summary>
    [JsonPropertyName("data_userid")]
    public required string DataUserid { get; set; }

    /// <summary>
    /// 入库日期。
    /// </summary>
    [JsonPropertyName("libiodate")]
    public required string Libiodate { get; set; }

    /// <summary>
    /// 入库仓库。
    /// </summary>
    [JsonPropertyName("stocklibid")]
    public required string Stocklibid { get; set; }

    /// <summary>
    /// 入库状态，取值。
    /// </summary>
    [JsonPropertyName("libiostate")]
    public required string Libiostate { get; set; }

    /// <summary>
    /// 入库单号。
    /// </summary>
    [JsonPropertyName("billno")]
    public required string Billno { get; set; }

    /// <summary>
    /// 取值。
    /// </summary>
    [JsonPropertyName("customerid")]
    public string? Customerid { get; set; }

    /// <summary>
    /// 入库经办人。
    /// </summary>
    [JsonPropertyName("empid")]
    public required string Empid { get; set; }

    /// <summary>
    /// 单据类型
    /// </summary>
    [JsonPropertyName("inorout")]
    public string? Inorout { get; set; }

    /// <summary>
    /// 入库主题。
    /// </summary>
    [JsonPropertyName("libioname")]
    public string? Libioname { get; set; }

    /// <summary>
    /// 对应单据。
    /// </summary>
    [JsonPropertyName("orderid")]
    public string? Orderid { get; set; }

    /// <summary>
    /// 入库申请人。
    /// </summary>
    [JsonPropertyName("askempid")]
    public string? Askempid { get; set; }

    /// <summary>
    /// 申请备注。
    /// </summary>
    [JsonPropertyName("remark")]
    public string? Remark { get; set; }

    /// <summary>
    /// 入库备注。
    /// </summary>
    [JsonPropertyName("auditreson")]
    public string? Auditreson { get; set; }

    /// <summary>
    /// 产品明细，json格式。
    /// </summary>
    [JsonPropertyName("child_mx")]
    public required string ChildMx { get; set; }
}

/// <summary>
/// 入库单请求
/// </summary>
public class PostV1JzCrmIntoStocksRequest
{
    /// <summary>
    /// 数据类型，固定值189。
    /// </summary>
    [JsonPropertyName("datatype")]
    public long Datatype { get; set; }

    /// <summary>
    /// 时间戳。
    /// </summary>
    [JsonPropertyName("stamp")]
    public long Stamp { get; set; }

    /// <summary>
    /// 数据ID。 值为0或不填时，为新增数据。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }

    /// <summary>
    /// 编辑数据。
    /// </summary>
    [JsonPropertyName("data")]
    public PostV1JzCrmIntoStocksRequestData? Data { get; set; }
}

/// <summary>
/// 入库单响应
/// </summary>
public class PostV1JzCrmIntoStocksResponse
{
    /// <summary>
    /// 响应时间
    /// </summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>
    /// 编辑数据的id
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }
}

/// <summary>
/// 编辑数据。
/// </summary>
public class PostV1JzCrmOutStocksRequestData
{
    /// <summary>
    /// 创建人。
    /// </summary>
    [JsonPropertyName("data_userid")]
    public required string DataUserid { get; set; }

    /// <summary>
    /// 出库日期。
    /// </summary>
    [JsonPropertyName("libiodate")]
    public required string Libiodate { get; set; }

    /// <summary>
    /// 出库仓库。
    /// </summary>
    [JsonPropertyName("stocklibid")]
    public required string Stocklibid { get; set; }

    /// <summary>
    /// 出库状态。
    /// </summary>
    [JsonPropertyName("libiostate")]
    public required string Libiostate { get; set; }

    /// <summary>
    /// 出库单号。
    /// </summary>
    [JsonPropertyName("billno")]
    public required string Billno { get; set; }

    /// <summary>
    /// 对应客户
    /// </summary>
    [JsonPropertyName("customerid")]
    public string? Customerid { get; set; }

    /// <summary>
    /// 经办人。
    /// </summary>
    [JsonPropertyName("empid")]
    public required string Empid { get; set; }

    /// <summary>
    /// 单据类型。
    /// </summary>
    [JsonPropertyName("inorout")]
    public string? Inorout { get; set; }

    /// <summary>
    /// 出库主题。
    /// </summary>
    [JsonPropertyName("libioname")]
    public string? Libioname { get; set; }

    /// <summary>
    /// 对应订单。
    /// </summary>
    [JsonPropertyName("orderid")]
    public string? Orderid { get; set; }

    /// <summary>
    /// 申请人。
    /// </summary>
    [JsonPropertyName("askempid")]
    public string? Askempid { get; set; }

    /// <summary>
    /// 申请备注。
    /// </summary>
    [JsonPropertyName("remark")]
    public string? Remark { get; set; }

    /// <summary>
    /// 出库备注。
    /// </summary>
    [JsonPropertyName("auditreson")]
    public string? Auditreson { get; set; }

    /// <summary>
    /// 产品明细，json格式。
    /// </summary>
    [JsonPropertyName("child_mx")]
    public required string ChildMx { get; set; }
}

/// <summary>
/// 出库单请求
/// </summary>
public class PostV1JzCrmOutStocksRequest
{
    /// <summary>
    /// 数据类型，固定值191。
    /// </summary>
    [JsonPropertyName("datatype")]
    public long Datatype { get; set; }

    /// <summary>
    /// 时间戳。
    /// </summary>
    [JsonPropertyName("stamp")]
    public long Stamp { get; set; }

    /// <summary>
    /// 数据ID。 值为0或不填时，为新增数据。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }

    /// <summary>
    /// 编辑数据。
    /// </summary>
    [JsonPropertyName("data")]
    public PostV1JzCrmOutStocksRequestData? Data { get; set; }
}

/// <summary>
/// 出库单响应
/// </summary>
public class PostV1JzCrmOutStocksResponse
{
    /// <summary>
    /// 响应时间。
    /// </summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>
    /// 编辑数据的ID。
    /// </summary>
    [JsonPropertyName("msgid")]
    public long? Msgid { get; set; }
}

/// <summary>
/// 数据详情。
/// </summary>
public class GetV1JzCrmDataViewResponseData
{
    /// <summary>
    /// 数据详情。
    /// </summary>
    [JsonPropertyName("detail")]
    public JsonElement? Detail { get; set; }
}

/// <summary>
/// 字段明细。
/// </summary>
public class GetV1JzCrmDataViewResponseDataname
{
    /// <summary>
    /// 字段明细。
    /// </summary>
    [JsonPropertyName("")]
    public JsonElement? Value { get; set; }
}

/// <summary>
/// 获取数据详情响应
/// </summary>
public class GetV1JzCrmDataViewResponse
{
    /// <summary>
    /// 数据详情。
    /// </summary>
    [JsonPropertyName("data")]
    public GetV1JzCrmDataViewResponseData? Data { get; set; }

    /// <summary>
    /// 字段明细。
    /// </summary>
    [JsonPropertyName("dataname")]
    public GetV1JzCrmDataViewResponseDataname? Dataname { get; set; }

    /// <summary>
    /// 响应时间。
    /// </summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>
/// GetV1JzCrmDataResponseDataItem
/// </summary>
public class GetV1JzCrmDataResponseDataItem
{
    /// <summary>
    /// 数据列表。
    /// </summary>
    [JsonPropertyName("detail")]
    public JsonElement? Detail { get; set; }
}

/// <summary>
/// 获取数据列表响应
/// </summary>
public class GetV1JzCrmDataResponse
{
    /// <summary>
    /// 数据列表。
    /// </summary>
    [JsonPropertyName("data")]
    public List<GetV1JzCrmDataResponseDataItem> Data { get; set; } = [];

    /// <summary>
    /// 字段明细。
    /// </summary>
    [JsonPropertyName("dataname")]
    public JsonElement? Dataname { get; set; }

    /// <summary>
    /// 当前页码。
    /// </summary>
    [JsonPropertyName("page")]
    public long? Page { get; set; }

    /// <summary>
    /// 分页条数。
    /// </summary>
    [JsonPropertyName("pageSize")]
    public long? PageSize { get; set; }

    /// <summary>
    /// 总条数。
    /// </summary>
    [JsonPropertyName("totalCount")]
    public long? TotalCount { get; set; }

    /// <summary>
    /// 响应时间。
    /// </summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>
/// 获取应用列表请求
/// </summary>
public class PostV1H3YunAppsSearchRequest
{
    /// <summary>
    /// 查询类型，取值： All：全部 Solution：以解决方案编码为条件来查询应用 AppCode：以应用编码为条件来查询
    /// </summary>
    [JsonPropertyName("queryType")]
    public required string QueryType { get; set; }

    /// <summary>
    /// 待查询条件数组。 说明 queryType参数为All时，此值可为空。
    /// </summary>
    [JsonPropertyName("values")]
    public List<string> Values { get; set; } = [];
}

/// <summary>
/// PostV1H3YunAppsSearchResponseDataItem
/// </summary>
public class PostV1H3YunAppsSearchResponseDataItem
{
    /// <summary>
    /// 应用编码。
    /// </summary>
    [JsonPropertyName("appCode")]
    public string? AppCode { get; set; }

    /// <summary>
    /// 应用显示名称。
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// 应用的来源类型，取值： Custom：自开发的 Installed：安装的
    /// </summary>
    [JsonPropertyName("appSource")]
    public string? AppSource { get; set; }

    /// <summary>
    /// 应用状态，取值： Enable：启用 Forbidden：禁用 Warring：预警
    /// </summary>
    [JsonPropertyName("appState")]
    public string? AppState { get; set; }

    /// <summary>
    /// 应用所属的解决方案名称。
    /// </summary>
    [JsonPropertyName("solution")]
    public string? Solution { get; set; }
}

/// <summary>
/// 获取应用列表响应
/// </summary>
public class PostV1H3YunAppsSearchResponse
{
    /// <summary>
    /// 状态码。
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// 状态码描述。
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// 应用实例信息。
    /// </summary>
    [JsonPropertyName("data")]
    public List<PostV1H3YunAppsSearchResponseDataItem> Data { get; set; } = [];
}

/// <summary>
/// GetV1H3YunAppsFunctionNodesResponseDataItem
/// </summary>
public class GetV1H3YunAppsFunctionNodesResponseDataItem
{
    /// <summary>
    /// 节点编码。 说明 如果nodeType值为FormModule，则为表单编码。 若果nodeType值为WorkflowModule，则为流程表单编码。
    /// </summary>
    [JsonPropertyName("schemaCode")]
    public string? SchemaCode { get; set; }

    /// <summary>
    /// 节点所属的应用编码。
    /// </summary>
    [JsonPropertyName("appCode")]
    public string? AppCode { get; set; }

    /// <summary>
    /// 父节点的编码。
    /// </summary>
    [JsonPropertyName("parentCode")]
    public string? ParentCode { get; set; }

    /// <summary>
    /// 显示名称。
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// 菜单可见类型，取值： Inactive：未指定 AllVisible：全部可见 PcVisible：仅pc可见 MobileVisible：仅移动端可见 InVisible：全部不可见
    /// </summary>
    [JsonPropertyName("nodeVisibleType")]
    public string? NodeVisibleType { get; set; }

    /// <summary>
    /// 菜单节点类型，取值： AppPackage：应用程序 FormModule：表单模块（不能发起流程） WorkflowModule：流程表单模块（可以发起流程） ReportModule：报表模块 GroupModule：节点分组
    /// </summary>
    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    /// <summary>
    /// 菜单状态，取值： Inactive：未激活 Active：激活
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// 排序编号。
    /// </summary>
    [JsonPropertyName("sortKey")]
    public long? SortKey { get; set; }

    /// <summary>
    /// 是否是系统节点，如果是则无法删除。
    /// </summary>
    [JsonPropertyName("isSystem")]
    public bool? IsSystem { get; set; }
}

/// <summary>
/// 获取应用功能节点响应
/// </summary>
public class GetV1H3YunAppsFunctionNodesResponse
{
    /// <summary>
    /// 状态码。
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// 状态码描述。
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// 应用功能节点信息列表。
    /// </summary>
    [JsonPropertyName("data")]
    public List<GetV1H3YunAppsFunctionNodesResponseDataItem> Data { get; set; } = [];
}

/// <summary>
/// GetV1H3YunDepartmentsResponseDataItem
/// </summary>
public class GetV1H3YunDepartmentsResponseDataItem
{
    /// <summary>
    /// 部门ID。
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// 父级部门ID。
    /// </summary>
    [JsonPropertyName("parentId")]
    public string? ParentId { get; set; }

    /// <summary>
    /// 部门名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 部门编码。
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// 组织类型，取值： Company：公司 OrganizationUnit：组织单元
    /// </summary>
    [JsonPropertyName("unitType")]
    public string? UnitType { get; set; }

    /// <summary>
    /// 排序值。
    /// </summary>
    [JsonPropertyName("sortKey")]
    public long? SortKey { get; set; }

    /// <summary>
    /// 描述。
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}

/// <summary>
/// 获取组织数据响应
/// </summary>
public class GetV1H3YunDepartmentsResponse
{
    /// <summary>
    /// 状态码。
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// 状态码描述。
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// 组织部门信息。
    /// </summary>
    [JsonPropertyName("data")]
    public List<GetV1H3YunDepartmentsResponseDataItem> Data { get; set; } = [];
}

/// <summary>
/// GetV1H3YunUsersResponseDataItem
/// </summary>
public class GetV1H3YunUsersResponseDataItem
{
    /// <summary>
    /// 用户ID。
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// 用户姓名。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 用户编码。
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// 性别，取值： None：未指定 Man：男性 Female：女性
    /// </summary>
    [JsonPropertyName("sex")]
    public string? Sex { get; set; }

    /// <summary>
    /// 描述。
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// 电话。
    /// </summary>
    [JsonPropertyName("mobile")]
    public string? Mobile { get; set; }

    /// <summary>
    /// 邮箱。
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// 直属组织ID。
    /// </summary>
    [JsonPropertyName("departmentId")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// 直属组织名称。
    /// </summary>
    [JsonPropertyName("departmentName")]
    public string? DepartmentName { get; set; }

    /// <summary>
    /// 作用域类型，取值： Unspecified：未指定 Internal：内部组织机构 External：外部组织机构
    /// </summary>
    [JsonPropertyName("domainType")]
    public string? DomainType { get; set; }

    /// <summary>
    /// 兼职部门ID列表，含主部门ID。
    /// </summary>
    [JsonPropertyName("partDepartmentIds")]
    public List<string> PartDepartmentIds { get; set; } = [];

    /// <summary>
    /// 排序号。
    /// </summary>
    [JsonPropertyName("sortKey")]
    public long? SortKey { get; set; }
}

/// <summary>
/// 获取用户数据响应
/// </summary>
public class GetV1H3YunUsersResponse
{
    /// <summary>
    /// 状态码。
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// 返回吗描述。
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// 用户基础信息列表。
    /// </summary>
    [JsonPropertyName("data")]
    public List<GetV1H3YunUsersResponseDataItem> Data { get; set; } = [];
}

/// <summary>
/// GetV1H3YunRolesResponseDataRoleGroupsItem
/// </summary>
public class GetV1H3YunRolesResponseDataRoleGroupsItem
{
    /// <summary>
    /// 角色组ID。
    /// </summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>
    /// 角色组名称。
    /// </summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    /// <summary>
    /// 角色组编码。
    /// </summary>
    [JsonPropertyName("groupCode")]
    public string? GroupCode { get; set; }

    /// <summary>
    /// 所属企业ID。
    /// </summary>
    [JsonPropertyName("companyId")]
    public string? CompanyId { get; set; }

    /// <summary>
    /// 可见性，取值： All：全部可见 Normal：普通可见 OnlyAdmin：只有管理的时候可见 OnlyOrganization：本组织范围可见
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    /// <summary>
    /// 状态，取值： Active：激活 Inactive：未激活 Unspecified：未指定状态
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// 描述。
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}

/// <summary>
/// GetV1H3YunRolesResponseDataRolesItem
/// </summary>
public class GetV1H3YunRolesResponseDataRolesItem
{
    /// <summary>
    /// 角色ID。
    /// </summary>
    [JsonPropertyName("roleId")]
    public string? RoleId { get; set; }

    /// <summary>
    /// 角色名称。
    /// </summary>
    [JsonPropertyName("roleName")]
    public string? RoleName { get; set; }

    /// <summary>
    /// 角色编码。
    /// </summary>
    [JsonPropertyName("roleCode")]
    public string? RoleCode { get; set; }

    /// <summary>
    /// 描述。
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// 所属的角色组ID。
    /// </summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>
    /// 状态，取值 Active：激活 Inactive：未激活 Unspecified：未指定状态
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// 可见性，取值： All：全部可见 Normal：普通可见 OnlyAdmin：只有管理的时候可见 OnlyOrganization：本组织范围可见
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }

    /// <summary>
    /// 所属企业ID。
    /// </summary>
    [JsonPropertyName("companyId")]
    public string? CompanyId { get; set; }
}

/// <summary>
/// 角色组列表。
/// </summary>
public class GetV1H3YunRolesResponseData
{
    /// <summary>
    /// 角色组列表。
    /// </summary>
    [JsonPropertyName("roleGroups")]
    public List<GetV1H3YunRolesResponseDataRoleGroupsItem> RoleGroups { get; set; } = [];

    /// <summary>
    /// 角色对象列表。
    /// </summary>
    [JsonPropertyName("roles")]
    public List<GetV1H3YunRolesResponseDataRolesItem> Roles { get; set; } = [];
}

/// <summary>
/// 获取角色数据响应
/// </summary>
public class GetV1H3YunRolesResponse
{
    /// <summary>
    /// 状态码。
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// 状态码描述。
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// 角色组列表。
    /// </summary>
    [JsonPropertyName("data")]
    public required GetV1H3YunRolesResponseData Data { get; set; }
}

/// <summary>
/// GetV1H3YunRolesRoleUsersResponseDataItem
/// </summary>
public class GetV1H3YunRolesRoleUsersResponseDataItem
{
    /// <summary>
    /// 用户ID。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 用户名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 用户编码。
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// 性别，取值： None：未指定 Man：男性 Female：女性
    /// </summary>
    [JsonPropertyName("sex")]
    public string? Sex { get; set; }

    /// <summary>
    /// 描述。
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// 手机号码。
    /// </summary>
    [JsonPropertyName("mobile")]
    public string? Mobile { get; set; }

    /// <summary>
    /// 邮箱。
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// 所属部门ID。
    /// </summary>
    [JsonPropertyName("departmentId")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// 所属部门名称。
    /// </summary>
    [JsonPropertyName("departmentName")]
    public string? DepartmentName { get; set; }

    /// <summary>
    /// 所属范围，取值： Internal：内部 External：外部
    /// </summary>
    [JsonPropertyName("domainType")]
    public string? DomainType { get; set; }

    /// <summary>
    /// 兼职部门ID集合，含主部门ID。
    /// </summary>
    [JsonPropertyName("partDepartmentIds")]
    public List<string> PartDepartmentIds { get; set; } = [];

    /// <summary>
    /// 排序值。
    /// </summary>
    [JsonPropertyName("sortKey")]
    public long? SortKey { get; set; }
}

/// <summary>
/// 获取角色用户数据响应
/// </summary>
public class GetV1H3YunRolesRoleUsersResponse
{
    /// <summary>
    /// 状态码。
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// 状态码描述。
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// 用户信息列表。
    /// </summary>
    [JsonPropertyName("data")]
    public List<GetV1H3YunRolesRoleUsersResponseDataItem> Data { get; set; } = [];
}

/// <summary>
/// GetV1H3YunFormsLoadBizFieldsResponseDataFieldsItem
/// </summary>
public class GetV1H3YunFormsLoadBizFieldsResponseDataFieldsItem
{
    /// <summary>
    /// 显示名称。
    /// </summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>
    /// 字段名称。
    /// </summary>
    [JsonPropertyName("fieldName")]
    public string? FieldName { get; set; }

    /// <summary>
    /// 字段、自定义组件的数据类型，取值： Bool：逻辑型 DataTime：日期型、日期组件 Double：双精度数值型 Int：整形 Long：长整形 String：长文本 ShortString：短文本 ByteArray：二进制流 Image：图片类型、图片组件 File：附件类型组件 TimeSpan：时间段 Unit：参与者（单人） UnitAr...
    /// </summary>
    [JsonPropertyName("bizDataType")]
    public string? BizDataType { get; set; }
}

/// <summary>
/// GetV1H3YunFormsLoadBizFieldsResponseDataChildFormsItemFieldsItem
/// </summary>
public class GetV1H3YunFormsLoadBizFieldsResponseDataChildFormsItemFieldsItem
{
    /// <summary>
    /// 显示名称。
    /// </summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>
    /// 字段名或组件名。
    /// </summary>
    [JsonPropertyName("fieldName")]
    public string? FieldName { get; set; }

    /// <summary>
    /// 字段数据类型。
    /// </summary>
    [JsonPropertyName("bizDataType")]
    public string? BizDataType { get; set; }
}

/// <summary>
/// GetV1H3YunFormsLoadBizFieldsResponseDataChildFormsItem
/// </summary>
public class GetV1H3YunFormsLoadBizFieldsResponseDataChildFormsItem
{
    /// <summary>
    /// 子表编码。
    /// </summary>
    [JsonPropertyName("schemaCode")]
    public string? SchemaCode { get; set; }

    /// <summary>
    /// 子表名称。
    /// </summary>
    [JsonPropertyName("formName")]
    public string? FormName { get; set; }

    /// <summary>
    /// 子表字段数组。
    /// </summary>
    [JsonPropertyName("fields")]
    public List<GetV1H3YunFormsLoadBizFieldsResponseDataChildFormsItemFieldsItem> Fields { get; set; } = [];
}

/// <summary>
/// 返回结果。
/// </summary>
public class GetV1H3YunFormsLoadBizFieldsResponseData
{
    /// <summary>
    /// 表单编码。
    /// </summary>
    [JsonPropertyName("schemaCode")]
    public required string SchemaCode { get; set; }

    /// <summary>
    /// 表单名称。
    /// </summary>
    [JsonPropertyName("formName")]
    public required string FormName { get; set; }

    /// <summary>
    /// 字段、组件结构数组。
    /// </summary>
    [JsonPropertyName("fields")]
    public List<GetV1H3YunFormsLoadBizFieldsResponseDataFieldsItem> Fields { get; set; } = [];

    /// <summary>
    /// 子表结构数组。
    /// </summary>
    [JsonPropertyName("childForms")]
    public List<GetV1H3YunFormsLoadBizFieldsResponseDataChildFormsItem> ChildForms { get; set; } = [];
}

/// <summary>
/// 获取表单对象结构响应
/// </summary>
public class GetV1H3YunFormsLoadBizFieldsResponse
{
    /// <summary>
    /// 状态码。
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// 状态码描述。
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// 返回结果。
    /// </summary>
    [JsonPropertyName("data")]
    public required GetV1H3YunFormsLoadBizFieldsResponseData Data { get; set; }
}

/// <summary>
/// 创建表单业务数据请求
/// </summary>
public class PostV1H3YunFormsInstancesRequest
{
    /// <summary>
    /// 表单编码。
    /// </summary>
    [JsonPropertyName("schemaCode")]
    public required string SchemaCode { get; set; }

    /// <summary>
    /// 操作用户ID。
    /// </summary>
    [JsonPropertyName("opUserId")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// json格式的业务数据。JSON数组的key只可以调用获取表单对象结构接口获取。 例如： { "F0000010": "0000004", "F0000011": "王五1", "F0000012": "D1级客户", "F0000013": 7000, "D000183Fcd15f3a51e624bbc9945392d190b6aa8": [ { "...
    /// </summary>
    [JsonPropertyName("bizObjectJson")]
    public required string BizObjectJson { get; set; }
}

/// <summary>
/// 返回结果。
/// </summary>
public class PostV1H3YunFormsInstancesResponseData
{
    /// <summary>
    /// 表单编码。
    /// </summary>
    [JsonPropertyName("schemaCode")]
    public required string SchemaCode { get; set; }

    /// <summary>
    /// 数据模型，取值： DataList：本地存储的列表库 Workflow：工作流应用
    /// </summary>
    [JsonPropertyName("formUsageType")]
    public required string FormUsageType { get; set; }

    /// <summary>
    /// 表单业务数据ID。
    /// </summary>
    [JsonPropertyName("bizObjectId")]
    public required string BizObjectId { get; set; }

    /// <summary>
    /// 流程实例ID。
    /// </summary>
    [JsonPropertyName("processInstanceId")]
    public required string ProcessInstanceId { get; set; }
}

/// <summary>
/// 创建表单业务数据响应
/// </summary>
public class PostV1H3YunFormsInstancesResponse
{
    /// <summary>
    /// 状态码。
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// 状态码描述。
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// 返回结果。
    /// </summary>
    [JsonPropertyName("data")]
    public required PostV1H3YunFormsInstancesResponseData Data { get; set; }
}

/// <summary>
/// 修改表单业务对象数据请求
/// </summary>
public class PutV1H3YunFormsInstancesRequest
{
    /// <summary>
    /// 表单编码。
    /// </summary>
    [JsonPropertyName("schemaCode")]
    public required string SchemaCode { get; set; }

    /// <summary>
    /// 业务数据ID。
    /// </summary>
    [JsonPropertyName("bizObjectId")]
    public required string BizObjectId { get; set; }

    /// <summary>
    /// 待修改的json格式业务数据。
    /// </summary>
    [JsonPropertyName("bizObjectJson")]
    public required string BizObjectJson { get; set; }
}

/// <summary>
/// 修改表单业务对象数据响应
/// </summary>
public class PutV1H3YunFormsInstancesResponse
{
    /// <summary>
    /// 状态码。
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// 状态码描述。
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }
}

/// <summary>
/// 删除业务对象响应
/// </summary>
public class DeleteV1H3YunFormsInstancesResponse
{
    /// <summary>
    /// 状态码。
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// 状态码描述。
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }
}

/// <summary>
/// PostV1H3YunFormsInstancesSearchRequestSortByFieldsItem
/// </summary>
public class PostV1H3YunFormsInstancesSearchRequestSortByFieldsItem
{
    /// <summary>
    /// 排序字段名。
    /// </summary>
    [JsonPropertyName("fieldName")]
    public string? FieldName { get; set; }

    /// <summary>
    /// 排序方向，取值： Ascending：升序 Descending：降序
    /// </summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }
}

/// <summary>
/// 查询表单业务数据列表请求
/// </summary>
public class PostV1H3YunFormsInstancesSearchRequest
{
    /// <summary>
    /// 表单编码。
    /// </summary>
    [JsonPropertyName("schemaCode")]
    public required string SchemaCode { get; set; }

    /// <summary>
    /// 分页页码。
    /// </summary>
    [JsonPropertyName("pageNumber")]
    public long PageNumber { get; set; }

    /// <summary>
    /// 分页页大小，最大值500。
    /// </summary>
    [JsonPropertyName("pageSize")]
    public long PageSize { get; set; }

    /// <summary>
    /// 需要返回的字段名，仅支持传入主表的字段。
    /// </summary>
    [JsonPropertyName("returnFields")]
    public List<string> ReturnFields { get; set; } = [];

    /// <summary>
    /// 排序字段结构列表。
    /// </summary>
    [JsonPropertyName("sortByFields")]
    public List<PostV1H3YunFormsInstancesSearchRequestSortByFieldsItem> SortByFields { get; set; } = [];

    /// <summary>
    /// json格式的动态条件过滤器。
    /// </summary>
    [JsonPropertyName("matcherJson")]
    public string? MatcherJson { get; set; }
}

/// <summary>
/// PostV1H3YunFormsInstancesSearchResponseDataBizObjectsItemD000183Fcd15f3a51e624bbc9945392d190b6aa8Item
/// </summary>
public class PostV1H3YunFormsInstancesSearchResponseDataBizObjectsItemD000183Fcd15f3a51e624bbc9945392d190b6aa8Item
{
    /// <summary>
    /// ObjectId
    /// </summary>
    [JsonPropertyName("ObjectId")]
    public string? ObjectId { get; set; }

    /// <summary>
    /// ParentObjectId
    /// </summary>
    [JsonPropertyName("ParentObjectId")]
    public string? ParentObjectId { get; set; }

    /// <summary>
    /// F0000014
    /// </summary>
    [JsonPropertyName("F0000014")]
    public string? F0000014 { get; set; }
}

/// <summary>
/// PostV1H3YunFormsInstancesSearchResponseDataBizObjectsItemCreatedByObject
/// </summary>
public class PostV1H3YunFormsInstancesSearchResponseDataBizObjectsItemCreatedByObject
{
    /// <summary>
    /// ObjectId
    /// </summary>
    [JsonPropertyName("ObjectId")]
    public required string ObjectId { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    [JsonPropertyName("Name")]
    public required string Name { get; set; }
}

/// <summary>
/// PostV1H3YunFormsInstancesSearchResponseDataBizObjectsItem
/// </summary>
public class PostV1H3YunFormsInstancesSearchResponseDataBizObjectsItem
{
    /// <summary>
    /// ObjectId
    /// </summary>
    [JsonPropertyName("ObjectId")]
    public string? ObjectId { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>
    /// CreatedBy
    /// </summary>
    [JsonPropertyName("CreatedBy")]
    public string? CreatedBy { get; set; }

    /// <summary>
    /// CreatedTime
    /// </summary>
    [JsonPropertyName("CreatedTime")]
    public string? CreatedTime { get; set; }

    /// <summary>
    /// ModifiedBy
    /// </summary>
    [JsonPropertyName("ModifiedBy")]
    public string? ModifiedBy { get; set; }

    /// <summary>
    /// ModifiedTime
    /// </summary>
    [JsonPropertyName("ModifiedTime")]
    public string? ModifiedTime { get; set; }

    /// <summary>
    /// WorkflowInstanceId
    /// </summary>
    [JsonPropertyName("WorkflowInstanceId")]
    public string? WorkflowInstanceId { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    [JsonPropertyName("Status")]
    public long? Status { get; set; }

    /// <summary>
    /// F0000010
    /// </summary>
    [JsonPropertyName("F0000010")]
    public string? F0000010 { get; set; }

    /// <summary>
    /// F0000011
    /// </summary>
    [JsonPropertyName("F0000011")]
    public string? F0000011 { get; set; }

    /// <summary>
    /// F0000012
    /// </summary>
    [JsonPropertyName("F0000012")]
    public string? F0000012 { get; set; }

    /// <summary>
    /// F0000013
    /// </summary>
    [JsonPropertyName("F0000013")]
    public string? F0000013 { get; set; }

    /// <summary>
    /// D000183Fcd15f3a51e624bbc9945392d190b6aa8
    /// </summary>
    [JsonPropertyName("D000183Fcd15f3a51e624bbc9945392d190b6aa8")]
    public List<PostV1H3YunFormsInstancesSearchResponseDataBizObjectsItemD000183Fcd15f3a51e624bbc9945392d190b6aa8Item> D000183Fcd15f3a51e624bbc9945392d190b6aa8 { get; set; } = [];

    /// <summary>
    /// CreatedByObject
    /// </summary>
    [JsonPropertyName("CreatedByObject")]
    public PostV1H3YunFormsInstancesSearchResponseDataBizObjectsItemCreatedByObject? CreatedByObject { get; set; }
}

/// <summary>
/// 返回结果。
/// </summary>
public class PostV1H3YunFormsInstancesSearchResponseData
{
    /// <summary>
    /// 分页页码。
    /// </summary>
    [JsonPropertyName("pageNumber")]
    public long PageNumber { get; set; }

    /// <summary>
    /// 分页参数，每页显示条数。
    /// </summary>
    [JsonPropertyName("pageSize")]
    public long PageSize { get; set; }

    /// <summary>
    /// 匹配条件的结果总数量。
    /// </summary>
    [JsonPropertyName("totalCount")]
    public long TotalCount { get; set; }

    /// <summary>
    /// 业务对象实例。
    /// </summary>
    [JsonPropertyName("bizObjects")]
    public List<PostV1H3YunFormsInstancesSearchResponseDataBizObjectsItem> BizObjects { get; set; } = [];
}

/// <summary>
/// 查询表单业务数据列表响应
/// </summary>
public class PostV1H3YunFormsInstancesSearchResponse
{
    /// <summary>
    /// Code
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// Message
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// 返回结果。
    /// </summary>
    [JsonPropertyName("data")]
    public required PostV1H3YunFormsInstancesSearchResponseData Data { get; set; }
}

/// <summary>
/// 批量新增表单业务数据请求
/// </summary>
public class PostV1H3YunFormsInstancesBatchRequest
{
    /// <summary>
    /// 表单编码。
    /// </summary>
    [JsonPropertyName("schemaCode")]
    public required string SchemaCode { get; set; }

    /// <summary>
    /// 操作用户ID。
    /// </summary>
    [JsonPropertyName("opUserId")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 待新增的业对象json数组。JSON数组的key只可以调用获取表单对象结构接口获取。 例如： { "F0000010": "0000007", "F0000011": "王五", "F0000012": "D级客户", "F0000013": 7000, "D000183Fcd15f3a51e624bbc9945392d190b6aa8": [ { "...
    /// </summary>
    [JsonPropertyName("bizObjectJsonArray")]
    public List<string> BizObjectJsonArray { get; set; } = [];
}

/// <summary>
/// 成功新增的业务对象ID数组。
/// </summary>
public class PostV1H3YunFormsInstancesBatchResponseData
{
    /// <summary>
    /// 成功新增的业务对象ID数组。
    /// </summary>
    [JsonPropertyName("bizObjectIds")]
    public List<string> BizObjectIds { get; set; } = [];

    /// <summary>
    /// 新增成功的流程实例ID列表。
    /// </summary>
    [JsonPropertyName("processIds")]
    public List<string> ProcessIds { get; set; } = [];

    /// <summary>
    /// 新增失败的数据列表。
    /// </summary>
    [JsonPropertyName("failedDatas")]
    public List<string> FailedDatas { get; set; } = [];

    /// <summary>
    /// 失败的提示信息列表。
    /// </summary>
    [JsonPropertyName("failedMessages")]
    public List<string> FailedMessages { get; set; } = [];
}

/// <summary>
/// 批量新增表单业务数据响应
/// </summary>
public class PostV1H3YunFormsInstancesBatchResponse
{
    /// <summary>
    /// Code
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// Message
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// 成功新增的业务对象ID数组。
    /// </summary>
    [JsonPropertyName("data")]
    public required PostV1H3YunFormsInstancesBatchResponseData Data { get; set; }
}

/// <summary>
/// GetV1H3YunFormsInstancesLoadInstancesResponseDataD000183Fcd15f3a51e624bbc9945392d190b6aa8Item
/// </summary>
public class GetV1H3YunFormsInstancesLoadInstancesResponseDataD000183Fcd15f3a51e624bbc9945392d190b6aa8Item
{
    /// <summary>
    /// ObjectId
    /// </summary>
    [JsonPropertyName("ObjectId")]
    public string? ObjectId { get; set; }

    /// <summary>
    /// ParentObjectId
    /// </summary>
    [JsonPropertyName("ParentObjectId")]
    public string? ParentObjectId { get; set; }

    /// <summary>
    /// F0000014
    /// </summary>
    [JsonPropertyName("F0000014")]
    public string? F0000014 { get; set; }

    /// <summary>
    /// F0000015
    /// </summary>
    [JsonPropertyName("F0000015")]
    public string? F0000015 { get; set; }

    /// <summary>
    /// F0000018
    /// </summary>
    [JsonPropertyName("F0000018")]
    public string? F0000018 { get; set; }

    /// <summary>
    /// F0000019
    /// </summary>
    [JsonPropertyName("F0000019")]
    public string? F0000019 { get; set; }
}

/// <summary>
/// GetV1H3YunFormsInstancesLoadInstancesResponseDataCreatedByObject
/// </summary>
public class GetV1H3YunFormsInstancesLoadInstancesResponseDataCreatedByObject
{
    /// <summary>
    /// ObjectId
    /// </summary>
    [JsonPropertyName("ObjectId")]
    public required string ObjectId { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    [JsonPropertyName("Name")]
    public required string Name { get; set; }
}

/// <summary>
/// GetV1H3YunFormsInstancesLoadInstancesResponseDataOwnerIdObject
/// </summary>
public class GetV1H3YunFormsInstancesLoadInstancesResponseDataOwnerIdObject
{
    /// <summary>
    /// ObjectId
    /// </summary>
    [JsonPropertyName("ObjectId")]
    public required string ObjectId { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    [JsonPropertyName("Name")]
    public required string Name { get; set; }
}

/// <summary>
/// 返回结果。
/// </summary>
public class GetV1H3YunFormsInstancesLoadInstancesResponseData
{
    /// <summary>
    /// ObjectId
    /// </summary>
    [JsonPropertyName("ObjectId")]
    public required string ObjectId { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    [JsonPropertyName("Name")]
    public required string Name { get; set; }

    /// <summary>
    /// CreatedBy
    /// </summary>
    [JsonPropertyName("CreatedBy")]
    public required string CreatedBy { get; set; }

    /// <summary>
    /// OwnerId
    /// </summary>
    [JsonPropertyName("OwnerId")]
    public required string OwnerId { get; set; }

    /// <summary>
    /// CreatedTime
    /// </summary>
    [JsonPropertyName("CreatedTime")]
    public required string CreatedTime { get; set; }

    /// <summary>
    /// WorkflowInstanceId
    /// </summary>
    [JsonPropertyName("WorkflowInstanceId")]
    public required string WorkflowInstanceId { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    [JsonPropertyName("Status")]
    public long Status { get; set; }

    /// <summary>
    /// F0000010
    /// </summary>
    [JsonPropertyName("F0000010")]
    public required string F0000010 { get; set; }

    /// <summary>
    /// F0000011
    /// </summary>
    [JsonPropertyName("F0000011")]
    public required string F0000011 { get; set; }

    /// <summary>
    /// F0000012
    /// </summary>
    [JsonPropertyName("F0000012")]
    public required string F0000012 { get; set; }

    /// <summary>
    /// F0000013
    /// </summary>
    [JsonPropertyName("F0000013")]
    public required string F0000013 { get; set; }

    /// <summary>
    /// D000183Fcd15f3a51e624bbc9945392d190b6aa8
    /// </summary>
    [JsonPropertyName("D000183Fcd15f3a51e624bbc9945392d190b6aa8")]
    public List<GetV1H3YunFormsInstancesLoadInstancesResponseDataD000183Fcd15f3a51e624bbc9945392d190b6aa8Item> D000183Fcd15f3a51e624bbc9945392d190b6aa8 { get; set; } = [];

    /// <summary>
    /// CreatedByObject
    /// </summary>
    [JsonPropertyName("CreatedByObject")]
    public required GetV1H3YunFormsInstancesLoadInstancesResponseDataCreatedByObject CreatedByObject { get; set; }

    /// <summary>
    /// OwnerIdObject
    /// </summary>
    [JsonPropertyName("OwnerIdObject")]
    public required GetV1H3YunFormsInstancesLoadInstancesResponseDataOwnerIdObject OwnerIdObject { get; set; }
}

/// <summary>
/// 获取业务实例信息响应
/// </summary>
public class GetV1H3YunFormsInstancesLoadInstancesResponse
{
    /// <summary>
    /// 状态码。
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// 状态码描述。
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// 返回结果。
    /// </summary>
    [JsonPropertyName("data")]
    public required GetV1H3YunFormsInstancesLoadInstancesResponseData Data { get; set; }
}

/// <summary>
/// 创建流程实例请求
/// </summary>
public class PostV1H3YunProcessesInstancesRequest
{
    /// <summary>
    /// 流程表单编码。 说明 非流程表单编码无法创建流程实例。
    /// </summary>
    [JsonPropertyName("schemaCode")]
    public required string SchemaCode { get; set; }

    /// <summary>
    /// 业务数据实例ID。
    /// </summary>
    [JsonPropertyName("bizObjectId")]
    public required string BizObjectId { get; set; }

    /// <summary>
    /// 操作者的ID。 说明 此为氚云的用户ID，可调用获取用户数据接口获取。
    /// </summary>
    [JsonPropertyName("opUserId")]
    public required string OpUserId { get; set; }
}

/// <summary>
/// 响应结果。
/// </summary>
public class PostV1H3YunProcessesInstancesResponseData
{
    /// <summary>
    /// 流程实例ID。
    /// </summary>
    [JsonPropertyName("processInstanceId")]
    public required string ProcessInstanceId { get; set; }
}

/// <summary>
/// 创建流程实例响应
/// </summary>
public class PostV1H3YunProcessesInstancesResponse
{
    /// <summary>
    /// Code
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// Message
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// 响应结果。
    /// </summary>
    [JsonPropertyName("data")]
    public required PostV1H3YunProcessesInstancesResponseData Data { get; set; }
}

/// <summary>
/// 删除流程实例数据响应
/// </summary>
public class DeleteV1H3YunProcessesInstancesResponse
{
    /// <summary>
    /// 状态码。
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// 状态码描述。
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }
}

/// <summary>
/// 流程发起人信息。
/// </summary>
public class GetV1H3YunProcessesInstancesResponseDataItemOriginator
{
    /// <summary>
    /// 用户ID。
    /// </summary>
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }

    /// <summary>
    /// 用户名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 所属组织ID。
    /// </summary>
    [JsonPropertyName("departmentId")]
    public required string DepartmentId { get; set; }

    /// <summary>
    /// 所属组织名称。
    /// </summary>
    [JsonPropertyName("departmentName")]
    public required string DepartmentName { get; set; }
}

/// <summary>
/// GetV1H3YunProcessesInstancesResponseDataItem
/// </summary>
public class GetV1H3YunProcessesInstancesResponseDataItem
{
    /// <summary>
    /// 流程实例ID。
    /// </summary>
    [JsonPropertyName("processInstanceId")]
    public string? ProcessInstanceId { get; set; }

    /// <summary>
    /// 钉钉流程ID。
    /// </summary>
    [JsonPropertyName("dingTalkProcessId")]
    public string? DingTalkProcessId { get; set; }

    /// <summary>
    /// 流程名称。
    /// </summary>
    [JsonPropertyName("processDisplayName")]
    public string? ProcessDisplayName { get; set; }

    /// <summary>
    /// 工作流模板的版本。
    /// </summary>
    [JsonPropertyName("processVersion")]
    public long? ProcessVersion { get; set; }

    /// <summary>
    /// 流程所属的表单编码。
    /// </summary>
    [JsonPropertyName("schemaCode")]
    public string? SchemaCode { get; set; }

    /// <summary>
    /// 流程关联的业务对象ID。
    /// </summary>
    [JsonPropertyName("bizObjectId")]
    public string? BizObjectId { get; set; }

    /// <summary>
    /// 流程所属的应用编码。
    /// </summary>
    [JsonPropertyName("appCode")]
    public string? AppCode { get; set; }

    /// <summary>
    /// 状态，取值： Initiated=初始化完成 Starting：正在启动 Running：正在运行 Finishing：正在结束 Finished：已完成 Canceled：已取消
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// 流程发起人信息。
    /// </summary>
    [JsonPropertyName("originator")]
    public GetV1H3YunProcessesInstancesResponseDataItemOriginator? Originator { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    [JsonPropertyName("createdTimeGMT")]
    public string? CreatedTimeGMT { get; set; }

    /// <summary>
    /// 开始时间。
    /// </summary>
    [JsonPropertyName("startTimeGMT")]
    public string? StartTimeGMT { get; set; }

    /// <summary>
    /// 完成时间。
    /// </summary>
    [JsonPropertyName("finishTimeGMT")]
    public string? FinishTimeGMT { get; set; }
}

/// <summary>
/// 查询流程实例响应
/// </summary>
public class GetV1H3YunProcessesInstancesResponse
{
    /// <summary>
    /// Code
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// Message
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// 流程实例列表。
    /// </summary>
    [JsonPropertyName("data")]
    public List<GetV1H3YunProcessesInstancesResponseDataItem> Data { get; set; } = [];
}

/// <summary>
/// 取消流程实例请求
/// </summary>
public class PostV1H3YunProcessesInstancesCancelRequest
{
    /// <summary>
    /// 流程实例ID。可以调用查询流程实例接口获取。
    /// </summary>
    [JsonPropertyName("processInstanceId")]
    public required string ProcessInstanceId { get; set; }
}

/// <summary>
/// 取消流程实例响应
/// </summary>
public class PostV1H3YunProcessesInstancesCancelResponse
{
    /// <summary>
    /// 状态码。
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// 状态码描述。
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }
}

/// <summary>
/// 参与者。
/// </summary>
public class GetV1H3YunProcessesWorkItemsResponseDataItemParticipant
{
    /// <summary>
    /// 用户ID。
    /// </summary>
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }

    /// <summary>
    /// 用户名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 用户直属的部门ID。
    /// </summary>
    [JsonPropertyName("departmentId")]
    public required string DepartmentId { get; set; }

    /// <summary>
    /// 用户直属的部门名称。
    /// </summary>
    [JsonPropertyName("departmentName")]
    public required string DepartmentName { get; set; }
}

/// <summary>
/// 完成者。
/// </summary>
public class GetV1H3YunProcessesWorkItemsResponseDataItemFinisher
{
    /// <summary>
    /// 用户ID。
    /// </summary>
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }

    /// <summary>
    /// 用户名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 用户直属的部门ID。
    /// </summary>
    [JsonPropertyName("departmentId")]
    public required string DepartmentId { get; set; }

    /// <summary>
    /// 用户直属的部门名称。
    /// </summary>
    [JsonPropertyName("departmentName")]
    public required string DepartmentName { get; set; }
}

/// <summary>
/// 转交工作的接收人。如无转接人，则为空。
/// </summary>
public class GetV1H3YunProcessesWorkItemsResponseDataItemReceiptor
{
    /// <summary>
    /// 用户ID。
    /// </summary>
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }

    /// <summary>
    /// 用户名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 用户直属的部门ID。
    /// </summary>
    [JsonPropertyName("departmentId")]
    public required string DepartmentId { get; set; }

    /// <summary>
    /// 用户直属的部门名称。
    /// </summary>
    [JsonPropertyName("departmentName")]
    public required string DepartmentName { get; set; }
}

/// <summary>
/// GetV1H3YunProcessesWorkItemsResponseDataItem
/// </summary>
public class GetV1H3YunProcessesWorkItemsResponseDataItem
{
    /// <summary>
    /// 工作任务ID。
    /// </summary>
    [JsonPropertyName("workItemId")]
    public string? WorkItemId { get; set; }

    /// <summary>
    /// 工作项类型，取值： Fill：普通工作项 Approve：审批类型工作项 Circulate：传阅
    /// </summary>
    [JsonPropertyName("workItemType")]
    public string? WorkItemType { get; set; }

    /// <summary>
    /// 流程实例ID。
    /// </summary>
    [JsonPropertyName("processInstanceId")]
    public string? ProcessInstanceId { get; set; }

    /// <summary>
    /// 应用编码。
    /// </summary>
    [JsonPropertyName("appCode")]
    public string? AppCode { get; set; }

    /// <summary>
    /// 表单编码。
    /// </summary>
    [JsonPropertyName("schemaCode")]
    public string? SchemaCode { get; set; }

    /// <summary>
    /// 工作项所关联的业务对象ID。
    /// </summary>
    [JsonPropertyName("bizObjectId")]
    public string? BizObjectId { get; set; }

    /// <summary>
    /// 工作流版本。
    /// </summary>
    [JsonPropertyName("processVersion")]
    public string? ProcessVersion { get; set; }

    /// <summary>
    /// 活动编码。
    /// </summary>
    [JsonPropertyName("activityCode")]
    public string? ActivityCode { get; set; }

    /// <summary>
    /// 当前活动名称。
    /// </summary>
    [JsonPropertyName("activityName")]
    public string? ActivityName { get; set; }

    /// <summary>
    /// 显示名称。
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// 状态，取值： Waiting：等待的状态 Working：正在工作中的状态 Finished：处于完成状态 Canceled：已经被取消 Forwarded：已转交状态 Revoked：撤回
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// 是否已完成。
    /// </summary>
    [JsonPropertyName("isFinish")]
    public bool? IsFinish { get; set; }

    /// <summary>
    /// 接收时间。
    /// </summary>
    [JsonPropertyName("receiveTimeGMT")]
    public string? ReceiveTimeGMT { get; set; }

    /// <summary>
    /// 开始这个任务的时间。
    /// </summary>
    [JsonPropertyName("startTimeGMT")]
    public string? StartTimeGMT { get; set; }

    /// <summary>
    /// 完成时间。
    /// </summary>
    [JsonPropertyName("finishTimeGMT")]
    public string? FinishTimeGMT { get; set; }

    /// <summary>
    /// 对该工作项的意见。
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// 对该工作项是否同意。
    /// </summary>
    [JsonPropertyName("isApproval")]
    public bool? IsApproval { get; set; }

    /// <summary>
    /// 参与者。
    /// </summary>
    [JsonPropertyName("participant")]
    public GetV1H3YunProcessesWorkItemsResponseDataItemParticipant? Participant { get; set; }

    /// <summary>
    /// 完成者。
    /// </summary>
    [JsonPropertyName("finisher")]
    public GetV1H3YunProcessesWorkItemsResponseDataItemFinisher? Finisher { get; set; }

    /// <summary>
    /// 转交工作的接收人。如无转接人，则为空。
    /// </summary>
    [JsonPropertyName("receiptor")]
    public GetV1H3YunProcessesWorkItemsResponseDataItemReceiptor? Receiptor { get; set; }
}

/// <summary>
/// 查询流程实例节点工作项响应
/// </summary>
public class GetV1H3YunProcessesWorkItemsResponse
{
    /// <summary>
    /// Code
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// Message
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// 工作项实例信息列表。
    /// </summary>
    [JsonPropertyName("data")]
    public List<GetV1H3YunProcessesWorkItemsResponseDataItem> Data { get; set; } = [];
}

/// <summary>
/// 附件临时免登地址。
/// </summary>
public class GetV1H3YunAttachmentsTemporaryUrlsResponseData
{
    /// <summary>
    /// 附件临时免登地址。
    /// </summary>
    [JsonPropertyName("attachmentUrl")]
    public required string AttachmentUrl { get; set; }
}

/// <summary>
/// 获取附件临时免登地址响应
/// </summary>
public class GetV1H3YunAttachmentsTemporaryUrlsResponse
{
    /// <summary>
    /// Code
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// Message
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// 附件临时免登地址。
    /// </summary>
    [JsonPropertyName("data")]
    public required GetV1H3YunAttachmentsTemporaryUrlsResponseData Data { get; set; }
}

/// <summary>
/// GetV1H3YunAttachmentsUploadUrlsResponseData
/// </summary>
public class GetV1H3YunAttachmentsUploadUrlsResponseData
{
    /// <summary>
    /// UploadUrl
    /// </summary>
    [JsonPropertyName("uploadUrl")]
    public required string UploadUrl { get; set; }
}

/// <summary>
/// 获取文件上传地址响应
/// </summary>
public class GetV1H3YunAttachmentsUploadUrlsResponse
{
    /// <summary>
    /// Code
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// Message
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// Data
    /// </summary>
    [JsonPropertyName("data")]
    public required GetV1H3YunAttachmentsUploadUrlsResponseData Data { get; set; }
}

/// <summary>
/// e签宝数据初始化请求
/// </summary>
public class PostV2EsignDevelopersRequest
{
    /// <summary>
    /// 通知回调地址。
    /// </summary>
    [JsonPropertyName("noticeUrl")]
    public string? NoticeUrl { get; set; }
}

/// <summary>
/// e签宝数据初始化响应
/// </summary>
public class PostV2EsignDevelopersResponse
{
    /// <summary>
    /// 数据初始化结果。
    /// </summary>
    [JsonPropertyName("data")]
    public bool? Data { get; set; }
}

/// <summary>
/// 获取授权的页面地址请求
/// </summary>
public class PostV2EsignAuthsUrlsRequest
{
    /// <summary>
    /// 完成后的重定向地址。 授权成功后，在URL中会携带授权结果，其中：例如：
    /// </summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }
}

/// <summary>
/// 获取授权的页面地址响应
/// </summary>
public class PostV2EsignAuthsUrlsResponse
{
    /// <summary>
    /// 任务ID。
    /// </summary>
    [JsonPropertyName("taskId")]
    public string? TaskId { get; set; }

    /// <summary>
    /// PC端授权地址。
    /// </summary>
    [JsonPropertyName("pcUrl")]
    public string? PcUrl { get; set; }

    /// <summary>
    /// 手机授权地址。
    /// </summary>
    [JsonPropertyName("mobileUrl")]
    public string? MobileUrl { get; set; }
}

/// <summary>
/// 取消企业授权响应
/// </summary>
public class PostV2EsignAuthsCancelResponse
{
    /// <summary>
    /// 授权取消结果。
    /// </summary>
    [JsonPropertyName("result")]
    public bool? Result { get; set; }
}

/// <summary>
/// 套餐转售—分润模式请求
/// </summary>
public class PostV2EsignOrdersChannelRequest
{
    /// <summary>
    /// 第三方的订单ID，需保证唯一性。
    /// </summary>
    [JsonPropertyName("orderId")]
    public required string OrderId { get; set; }

    /// <summary>
    /// 商品ID。
    /// </summary>
    [JsonPropertyName("itemCode")]
    public required string ItemCode { get; set; }

    /// <summary>
    /// 商品名称。
    /// </summary>
    [JsonPropertyName("itemName")]
    public required string ItemName { get; set; }

    /// <summary>
    /// 购买数量。
    /// </summary>
    [JsonPropertyName("quantity")]
    public JsonElement Quantity { get; set; }

    /// <summary>
    /// 支付金额，单位：分。 仅作记录不作为凭证。
    /// </summary>
    [JsonPropertyName("payFee")]
    public JsonElement? PayFee { get; set; }

    /// <summary>
    /// 下单时间。
    /// </summary>
    [JsonPropertyName("orderCreateTime")]
    public JsonElement OrderCreateTime { get; set; }
}

/// <summary>
/// 套餐转售—分润模式响应
/// </summary>
public class PostV2EsignOrdersChannelResponse
{
    /// <summary>
    /// e签宝订单ID。
    /// </summary>
    [JsonPropertyName("esignOrderId")]
    public string? EsignOrderId { get; set; }
}

/// <summary>
/// 套餐转售—底价结算模式请求
/// </summary>
public class PostV2EsignOrdersResaleRequest
{
    /// <summary>
    /// isv方的订单ID，用于幂等，请保证唯一性。
    /// </summary>
    [JsonPropertyName("orderId")]
    public required string OrderId { get; set; }

    /// <summary>
    /// 购买数量，电子合同份数。
    /// </summary>
    [JsonPropertyName("quantity")]
    public JsonElement Quantity { get; set; }

    /// <summary>
    /// 下单时间。
    /// </summary>
    [JsonPropertyName("orderCreateTime")]
    public JsonElement OrderCreateTime { get; set; }

    /// <summary>
    /// 合同生效起始时间。
    /// </summary>
    [JsonPropertyName("serviceStartTime")]
    public JsonElement? ServiceStartTime { get; set; }

    /// <summary>
    /// 合同失效截止日期。默认有效时间一年。
    /// </summary>
    [JsonPropertyName("serviceStopTime")]
    public JsonElement ServiceStopTime { get; set; }
}

/// <summary>
/// 套餐转售—底价结算模式响应
/// </summary>
public class PostV2EsignOrdersResaleResponse
{
    /// <summary>
    /// e签宝订单ID。
    /// </summary>
    [JsonPropertyName("esignOrderId")]
    public string? EsignOrderId { get; set; }
}

/// <summary>
/// 查询套餐余量响应
/// </summary>
public class GetV2EsignMarginsResponse
{
    /// <summary>
    /// 套餐剩余份数。
    /// </summary>
    [JsonPropertyName("margin")]
    public JsonElement? Margin { get; set; }
}

/// <summary>
/// 获取企业的e签宝微应用状态响应
/// </summary>
public class GetV2EsignCorpsAppStatusResponse
{
    /// <summary>
    /// 企业微应用安装状态，取值：
    /// </summary>
    [JsonPropertyName("installStatus")]
    public string? InstallStatus { get; set; }

    /// <summary>
    /// 企业微应用授权状态，取值：
    /// </summary>
    [JsonPropertyName("authStatus")]
    public string? AuthStatus { get; set; }
}

/// <summary>
/// 查询企业信息响应
/// </summary>
public class GetV2EsignCorpsInfosResponse
{
    /// <summary>
    /// 企业是否实名。
    /// </summary>
    [JsonPropertyName("isRealName")]
    public string? IsRealName { get; set; }

    /// <summary>
    /// 如果已经实名，会返回实名企业名称。
    /// </summary>
    [JsonPropertyName("orgRealName")]
    public string? OrgRealName { get; set; }
}

/// <summary>
/// 获取企业控制台地址请求
/// </summary>
public class GetV2EsignCorpsConsolesRequest
{
}

/// <summary>
/// 获取企业控制台地址响应
/// </summary>
public class GetV2EsignCorpsConsolesResponse
{
    /// <summary>
    /// 企业的控制台地址。
    /// </summary>
    [JsonPropertyName("orgConsoleUrl")]
    public string? OrgConsoleUrl { get; set; }
}

/// <summary>
/// 查询个人信息响应
/// </summary>
public class GetV2EsignUsersUserIdResponse
{
    /// <summary>
    /// 个人是否实名。
    /// </summary>
    [JsonPropertyName("isRealName")]
    public string? IsRealName { get; set; }

    /// <summary>
    /// 如果已经实名，会返回个人实名名称。
    /// </summary>
    [JsonPropertyName("userRealName")]
    public string? UserRealName { get; set; }
}

/// <summary>
/// 获取个人实名的地址请求
/// </summary>
public class PostV2EsignUsersRealNamesRequest
{
    /// <summary>
    /// 当前用户的userid。
    /// </summary>
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }

    /// <summary>
    /// 实名认证成功后重定向地址。
    /// </summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }
}

/// <summary>
/// 获取个人实名的地址响应
/// </summary>
public class PostV2EsignUsersRealNamesResponse
{
    /// <summary>
    /// 任务ID。
    /// </summary>
    [JsonPropertyName("taskId")]
    public string? TaskId { get; set; }

    /// <summary>
    /// PC端实名地址。
    /// </summary>
    [JsonPropertyName("pcUrl")]
    public string? PcUrl { get; set; }

    /// <summary>
    /// 移动端实名地址。
    /// </summary>
    [JsonPropertyName("mobileUrl")]
    public string? MobileUrl { get; set; }
}

/// <summary>
/// 获取跳转到企业实名的地址请求
/// </summary>
public class PostV2EsignCorpsRealNamesRequest
{
    /// <summary>
    /// 当前用户userid。 必须是管理员。
    /// </summary>
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }

    /// <summary>
    /// 企业实名操作成功后的重定向地址。
    /// </summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }
}

/// <summary>
/// 获取跳转到企业实名的地址响应
/// </summary>
public class PostV2EsignCorpsRealNamesResponse
{
    /// <summary>
    /// 任务ID。
    /// </summary>
    [JsonPropertyName("taskId")]
    public string? TaskId { get; set; }

    /// <summary>
    /// PC端实名认证地址。
    /// </summary>
    [JsonPropertyName("pcUrl")]
    public string? PcUrl { get; set; }

    /// <summary>
    /// 移动端实名认证地址。
    /// </summary>
    [JsonPropertyName("mobileUrl")]
    public string? MobileUrl { get; set; }
}

/// <summary>
/// 获取文件上传地址请求
/// </summary>
public class PostV2EsignFilesUploadUrlsRequest
{
    /// <summary>
    /// ContentMD5值计算方法如下：
    /// </summary>
    [JsonPropertyName("contentMd5")]
    public string? ContentMd5 { get; set; }

    /// <summary>
    /// 目标文件的MIME类型，支持： 后面文件流上传的Content-Type参数要和这里一致，不然就会有403的报错。
    /// </summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>
    /// 文件名称，必须带上文件扩展名，不然会导致后续发起流程校验过不去。例如：合同.pdf 。 该字段的文件后缀名称和真实的文件后缀需要一致。例如上传的文件类型是word文件，那该参数需要传xxx.docx，不能是xxx.pdf。
    /// </summary>
    [JsonPropertyName("fileName")]
    public string? FileName { get; set; }

    /// <summary>
    /// 文件大小，单位byte。
    /// </summary>
    [JsonPropertyName("fileSize")]
    public long? FileSize { get; set; }

    /// <summary>
    /// 是否转换成pdf文档，默认false，代表不做转换。转换是异步行为，如果指定要转换，需要调用查询文件信息接口查询状态，转换完成后才可使用。 如果本身就是PDF文件，该参数必须传false，否则在【通过模板创建文件】的时候不能填充内容。
    /// </summary>
    [JsonPropertyName("convert2Pdf")]
    public bool? Convert2Pdf { get; set; }
}

/// <summary>
/// 获取文件上传地址响应
/// </summary>
public class PostV2EsignFilesUploadUrlsResponse
{
    /// <summary>
    /// 文件ID。
    /// </summary>
    [JsonPropertyName("fileId")]
    public string? FileId { get; set; }

    /// <summary>
    /// 文件直传地址, 可以重复使用，但是只能传相同的文件，有效期一小时。
    /// </summary>
    [JsonPropertyName("uploadUrl")]
    public string? UploadUrl { get; set; }
}

/// <summary>
/// 获取文件详情响应
/// </summary>
public class GetV2EsignFilesFileIdResponse
{
    /// <summary>
    /// 文件ID。
    /// </summary>
    [JsonPropertyName("fileId")]
    public string? FileId { get; set; }

    /// <summary>
    /// 文件名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 下载地址。
    /// </summary>
    [JsonPropertyName("downloadUrl")]
    public string? DownloadUrl { get; set; }

    /// <summary>
    /// 文件大小，单位：byte。
    /// </summary>
    [JsonPropertyName("size")]
    public long? Size { get; set; }

    /// <summary>
    /// 文件状态，取值：
    /// </summary>
    [JsonPropertyName("status")]
    public long? Status { get; set; }

    /// <summary>
    /// PDF文件总页数，仅当文件类型为PDF时有值。
    /// </summary>
    [JsonPropertyName("pdfTotalPages")]
    public long? PdfTotalPages { get; set; }
}

/// <summary>
/// PostV2EsignProcessesStartUrlsRequestFilesItem
/// </summary>
public class PostV2EsignProcessesStartUrlsRequestFilesItem
{
    /// <summary>
    /// 文件ID。
    /// </summary>
    [JsonPropertyName("fileId")]
    public required string FileId { get; set; }

    /// <summary>
    /// 文件名称。
    /// </summary>
    [JsonPropertyName("fileName")]
    public required string FileName { get; set; }
}

/// <summary>
/// PostV2EsignProcessesStartUrlsRequestParticipantsItem
/// </summary>
public class PostV2EsignProcessesStartUrlsRequestParticipantsItem
{
    /// <summary>
    /// 用户类型，取值：
    /// </summary>
    [JsonPropertyName("accountType")]
    public required string AccountType { get; set; }

    /// <summary>
    /// 签署印章类型，取值：
    /// </summary>
    [JsonPropertyName("signRequirements")]
    public string? SignRequirements { get; set; }

    /// <summary>
    /// 钉钉用户userid。 当accountType为DING_USER时必填。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 外部用户账号、手机号或邮箱。 当accountType为OUTER_USER时必填。
    /// </summary>
    [JsonPropertyName("account")]
    public string? Account { get; set; }

    /// <summary>
    /// 外部用户姓名。 当accountType为OUTER_USER时必填。
    /// </summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>
    /// 外部企业名称。 OUTER_USER需要盖企业章必填，如果不传，默认会赋值当前企业名称。
    /// </summary>
    [JsonPropertyName("orgName")]
    public string? OrgName { get; set; }
}

/// <summary>
/// PostV2EsignProcessesStartUrlsRequestCcsItem
/// </summary>
public class PostV2EsignProcessesStartUrlsRequestCcsItem
{
    /// <summary>
    /// 用户类型，取值：
    /// </summary>
    [JsonPropertyName("accountType")]
    public required string AccountType { get; set; }

    /// <summary>
    /// 钉钉用户userid。 当accountType为DING_USER时必填。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 外部用户账号、手机号或邮箱。 当accountType为OUTER_USER时必填。
    /// </summary>
    [JsonPropertyName("account")]
    public string? Account { get; set; }

    /// <summary>
    /// 外部用户姓名。 当accountType为OUTER_USER时必填。
    /// </summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>
    /// 外部企业名称，发给企业方必填。
    /// </summary>
    [JsonPropertyName("orgName")]
    public string? OrgName { get; set; }
}

/// <summary>
/// 来源信息。 支持传入审批信息和跳转地址。
/// </summary>
public class PostV2EsignProcessesStartUrlsRequestSourceInfo
{
    /// <summary>
    /// 展示文案。
    /// </summary>
    [JsonPropertyName("showText")]
    public string? ShowText { get; set; }

    /// <summary>
    /// pc端跳转地址。
    /// </summary>
    [JsonPropertyName("pcUrl")]
    public string? PcUrl { get; set; }

    /// <summary>
    /// 移动端跳转地址。
    /// </summary>
    [JsonPropertyName("mobileUrl")]
    public string? MobileUrl { get; set; }
}

/// <summary>
/// 获取发起签署任务的地址请求
/// </summary>
public class PostV2EsignProcessesStartUrlsRequest
{
    /// <summary>
    /// 任务发起方的userid。
    /// </summary>
    [JsonPropertyName("initiatorUserId")]
    public required string InitiatorUserId { get; set; }

    /// <summary>
    /// 任务名称，默认为文件名。
    /// </summary>
    [JsonPropertyName("taskName")]
    public string? TaskName { get; set; }

    /// <summary>
    /// 重定向跳转地址
    /// </summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    /// <summary>
    /// 文件列表。
    /// </summary>
    [JsonPropertyName("files")]
    public List<PostV2EsignProcessesStartUrlsRequestFilesItem> Files { get; set; } = [];

    /// <summary>
    /// 参与方列表。
    /// </summary>
    [JsonPropertyName("participants")]
    public List<PostV2EsignProcessesStartUrlsRequestParticipantsItem> Participants { get; set; } = [];

    /// <summary>
    /// 抄送人列表。
    /// </summary>
    [JsonPropertyName("ccs")]
    public List<PostV2EsignProcessesStartUrlsRequestCcsItem> Ccs { get; set; } = [];

    /// <summary>
    /// 来源信息。 支持传入审批信息和跳转地址。
    /// </summary>
    [JsonPropertyName("sourceInfo")]
    public PostV2EsignProcessesStartUrlsRequestSourceInfo? SourceInfo { get; set; }

    /// <summary>
    /// 是否跳过发起签署页直接发起。
    /// </summary>
    [JsonPropertyName("autoStart")]
    public string? AutoStart { get; set; }

    /// <summary>
    /// 三方业务Id。 说明 该参数值由开发者自定义，可根据自身业务添加唯一值，用于标记本次签署，串联自身前后业务（该参数会在回调通知里原样返回）。
    /// </summary>
    [JsonPropertyName("thirdBizId")]
    public string? ThirdBizId { get; set; }
}

/// <summary>
/// 获取发起签署任务的地址响应
/// </summary>
public class PostV2EsignProcessesStartUrlsResponse
{
    /// <summary>
    /// 任务ID。
    /// </summary>
    [JsonPropertyName("taskId")]
    public string? TaskId { get; set; }

    /// <summary>
    /// PC端发起签署任务地址。
    /// </summary>
    [JsonPropertyName("pcUrl")]
    public string? PcUrl { get; set; }

    /// <summary>
    /// 移动端发起签署任务地址。
    /// </summary>
    [JsonPropertyName("mobileUrl")]
    public string? MobileUrl { get; set; }
}

/// <summary>
/// PostV2EsignProcessStartAtOnceRequestFilesItem
/// </summary>
public class PostV2EsignProcessStartAtOnceRequestFilesItem
{
    /// <summary>
    /// 文件ID。
    /// </summary>
    [JsonPropertyName("fileId")]
    public required string FileId { get; set; }

    /// <summary>
    /// 文件类型，取值：
    /// </summary>
    [JsonPropertyName("fileType")]
    public long FileType { get; set; }

    /// <summary>
    /// 文件名称。
    /// </summary>
    [JsonPropertyName("fileName")]
    public required string FileName { get; set; }
}

/// <summary>
/// 签署区时间。
/// </summary>
public class PostV2EsignProcessStartAtOnceRequestParticipantsItemSignPosListItemSignDate
{
    /// <summary>
    /// 签署区时间格式， 支持：
    /// </summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }
}

/// <summary>
/// PostV2EsignProcessStartAtOnceRequestParticipantsItemSignPosListItem
/// </summary>
public class PostV2EsignProcessStartAtOnceRequestParticipantsItemSignPosListItem
{
    /// <summary>
    /// 文件ID。
    /// </summary>
    [JsonPropertyName("fileId")]
    public string? FileId { get; set; }

    /// <summary>
    /// 是否为骑缝章。
    /// </summary>
    [JsonPropertyName("isCrossPage")]
    public bool? IsCrossPage { get; set; }

    /// <summary>
    /// 是否需要显示签署时间。
    /// </summary>
    [JsonPropertyName("needSignDate")]
    public bool? NeedSignDate { get; set; }

    /// <summary>
    /// 签署区页码。
    /// </summary>
    [JsonPropertyName("page")]
    public string? Page { get; set; }

    /// <summary>
    /// 签署区时间。
    /// </summary>
    [JsonPropertyName("signDate")]
    public PostV2EsignProcessStartAtOnceRequestParticipantsItemSignPosListItemSignDate? SignDate { get; set; }

    /// <summary>
    /// 签署要求： 1：企业章 2：经办人
    /// </summary>
    [JsonPropertyName("signRequirement")]
    public string? SignRequirement { get; set; }

    /// <summary>
    /// 签署区x坐标
    /// </summary>
    [JsonPropertyName("x")]
    public JsonElement? X { get; set; }

    /// <summary>
    /// 签署区y坐标
    /// </summary>
    [JsonPropertyName("y")]
    public JsonElement? Y { get; set; }
}

/// <summary>
/// PostV2EsignProcessStartAtOnceRequestParticipantsItem
/// </summary>
public class PostV2EsignProcessStartAtOnceRequestParticipantsItem
{
    /// <summary>
    /// 签署印章类型，取值：
    /// </summary>
    [JsonPropertyName("signRequirements")]
    public required string SignRequirements { get; set; }

    /// <summary>
    /// 签署顺序。
    /// </summary>
    [JsonPropertyName("signOrder")]
    public long? SignOrder { get; set; }

    /// <summary>
    /// 用户类型，取值：
    /// </summary>
    [JsonPropertyName("accountType")]
    public required string AccountType { get; set; }

    /// <summary>
    /// 邮箱/手机号账号(accountType为OUTER_USER时必填）
    /// </summary>
    [JsonPropertyName("account")]
    public string? Account { get; set; }

    /// <summary>
    /// 钉钉用户userid。 accountType为DING_USER时必填。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 账号对应人姓名。 accountType为OUTER_USER时必填。
    /// </summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>
    /// 企业名称。 OUTER_USER需要盖企业章时必填，如果不传，默认会赋值当前企业名称。
    /// </summary>
    [JsonPropertyName("orgName")]
    public string? OrgName { get; set; }

    /// <summary>
    /// 参与方签署位置信息列表。
    /// </summary>
    [JsonPropertyName("signPosList")]
    public List<PostV2EsignProcessStartAtOnceRequestParticipantsItemSignPosListItem> SignPosList { get; set; } = [];
}

/// <summary>
/// PostV2EsignProcessStartAtOnceRequestCcsItem
/// </summary>
public class PostV2EsignProcessStartAtOnceRequestCcsItem
{
    /// <summary>
    /// 用户类型，取值：
    /// </summary>
    [JsonPropertyName("accountType")]
    public required string AccountType { get; set; }

    /// <summary>
    /// 邮箱或手机号账号。 account与userId两者至少填一项，优先取userId。
    /// </summary>
    [JsonPropertyName("account")]
    public string? Account { get; set; }

    /// <summary>
    /// 钉钉用户userid。 account与userId两者至少填一项，优先取userId。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 账号对应人姓名。
    /// </summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>
    /// 企业名称。
    /// </summary>
    [JsonPropertyName("orgName")]
    public string? OrgName { get; set; }
}

/// <summary>
/// 来源信息，目前支持传入审批信息和跳转地址。
/// </summary>
public class PostV2EsignProcessStartAtOnceRequestSourceInfo
{
    /// <summary>
    /// 展示文案
    /// </summary>
    [JsonPropertyName("showText")]
    public string? ShowText { get; set; }

    /// <summary>
    /// PC端签署地址。
    /// </summary>
    [JsonPropertyName("pcUrl")]
    public string? PcUrl { get; set; }

    /// <summary>
    /// 移动端签署地址。
    /// </summary>
    [JsonPropertyName("mobileUrl")]
    public string? MobileUrl { get; set; }
}

/// <summary>
/// 创建签署流程请求
/// </summary>
public class PostV2EsignProcessStartAtOnceRequest
{
    /// <summary>
    /// 发起人的userid。
    /// </summary>
    [JsonPropertyName("initiatorUserId")]
    public required string InitiatorUserId { get; set; }

    /// <summary>
    /// 任务名称，不支持特殊字符。
    /// </summary>
    [JsonPropertyName("taskName")]
    public required string TaskName { get; set; }

    /// <summary>
    /// 签署截止时间。
    /// </summary>
    [JsonPropertyName("signEndTime")]
    public long? SignEndTime { get; set; }

    /// <summary>
    /// 重定向跳转地址。
    /// </summary>
    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    /// <summary>
    /// 文件列表，包括合同文件和附件。
    /// </summary>
    [JsonPropertyName("files")]
    public List<PostV2EsignProcessStartAtOnceRequestFilesItem> Files { get; set; } = [];

    /// <summary>
    /// 参与方列表。
    /// </summary>
    [JsonPropertyName("participants")]
    public List<PostV2EsignProcessStartAtOnceRequestParticipantsItem> Participants { get; set; } = [];

    /// <summary>
    /// 抄送人列表。
    /// </summary>
    [JsonPropertyName("ccs")]
    public List<PostV2EsignProcessStartAtOnceRequestCcsItem> Ccs { get; set; } = [];

    /// <summary>
    /// 来源信息，目前支持传入审批信息和跳转地址。
    /// </summary>
    [JsonPropertyName("sourceInfo")]
    public PostV2EsignProcessStartAtOnceRequestSourceInfo? SourceInfo { get; set; }

    /// <summary>
    /// 三方业务Id。 说明 该参数值由开发者自定义，可根据自身业务添加唯一值，用于标记本次签署，串联自身前后业务（该参数会在回调通知里原样返回）。
    /// </summary>
    [JsonPropertyName("thirdBizId")]
    public string? ThirdBizId { get; set; }
}

/// <summary>
/// 创建签署流程响应
/// </summary>
public class PostV2EsignProcessStartAtOnceResponse
{
    /// <summary>
    /// 任务ID。
    /// </summary>
    [JsonPropertyName("taskId")]
    public string? TaskId { get; set; }
}

/// <summary>
/// 获取签署人签署地址请求
/// </summary>
public class PostV2EsignProcessExecuteUrlsRequest
{
    /// <summary>
    /// 任务ID。
    /// </summary>
    [JsonPropertyName("taskId")]
    public required string TaskId { get; set; }

    /// <summary>
    /// 签署链接允许在哪个容器打开，取值：默认值：1。
    /// </summary>
    [JsonPropertyName("signContainer")]
    public long? SignContainer { get; set; }

    /// <summary>
    /// 签署人账号ID。 signContainer为2时，此参数必填，其他情况不用填。
    /// </summary>
    [JsonPropertyName("account")]
    public string? Account { get; set; }
}

/// <summary>
/// 获取签署人签署地址响应
/// </summary>
public class PostV2EsignProcessExecuteUrlsResponse
{
    /// <summary>
    /// 移动端钉钉容器内流程地址。 signContainer为1时，返回该地址。
    /// </summary>
    [JsonPropertyName("mobileUrl")]
    public string? MobileUrl { get; set; }

    /// <summary>
    /// PC端钉钉容器内流程的地址。 signContainer为1时，返回该地址。
    /// </summary>
    [JsonPropertyName("pcUrl")]
    public string? PcUrl { get; set; }

    /// <summary>
    /// 流程地址，用于在浏览器内打开，长链地址永久有效, 不区分移动端或PC端，UI会自适应。 signContainer为2时，返回该地址。
    /// </summary>
    [JsonPropertyName("longUrl")]
    public string? LongUrl { get; set; }

    /// <summary>
    /// 流程地址，用于在浏览器内打开，短链地址30天有效, 不区分移动端或PC端，UI会自适应。 signContainer为2时，返回该地址。
    /// </summary>
    [JsonPropertyName("shortUrl")]
    public string? ShortUrl { get; set; }
}

/// <summary>
/// GetV2EsignSignTasksTaskIdResponseSignersItem
/// </summary>
public class GetV2EsignSignTasksTaskIdResponseSignersItem
{
    /// <summary>
    /// 签署状态，取值：
    /// </summary>
    [JsonPropertyName("signStatus")]
    public JsonElement? SignStatus { get; set; }

    /// <summary>
    /// 签署人姓名。
    /// </summary>
    [JsonPropertyName("signerName")]
    public string? SignerName { get; set; }
}

/// <summary>
/// 获取流程的签署详情响应
/// </summary>
public class GetV2EsignSignTasksTaskIdResponse
{
    /// <summary>
    /// 流程业务场景。
    /// </summary>
    [JsonPropertyName("businessScene")]
    public string? BusinessScene { get; set; }

    /// <summary>
    /// 流程状态，取值：
    /// </summary>
    [JsonPropertyName("flowStatus")]
    public JsonElement? FlowStatus { get; set; }

    /// <summary>
    /// 流程任务合同列表。
    /// </summary>
    [JsonPropertyName("signers")]
    public List<GetV2EsignSignTasksTaskIdResponseSignersItem> Signers { get; set; } = [];
}

/// <summary>
/// GetV2EsignApprovalsTaskIdResponseDataItemApprovalNodesItem
/// </summary>
public class GetV2EsignApprovalsTaskIdResponseDataItemApprovalNodesItem
{
    /// <summary>
    /// 审批人姓名。
    /// </summary>
    [JsonPropertyName("approverName")]
    public string? ApproverName { get; set; }

    /// <summary>
    /// 审批状态，取值：
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// 节点开始时间。
    /// </summary>
    [JsonPropertyName("startTime")]
    public JsonElement? StartTime { get; set; }

    /// <summary>
    /// 节点审批时间。
    /// </summary>
    [JsonPropertyName("approvalTime")]
    public string? ApprovalTime { get; set; }
}

/// <summary>
/// GetV2EsignApprovalsTaskIdResponseDataItem
/// </summary>
public class GetV2EsignApprovalsTaskIdResponseDataItem
{
    /// <summary>
    /// 审批名称。
    /// </summary>
    [JsonPropertyName("approvalName")]
    public string? ApprovalName { get; set; }

    /// <summary>
    /// 审批状态，取值：
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// 审批拒绝原因。
    /// </summary>
    [JsonPropertyName("refuseReason")]
    public string? RefuseReason { get; set; }

    /// <summary>
    /// 审批发起人姓名。
    /// </summary>
    [JsonPropertyName("sponsorAccountName")]
    public string? SponsorAccountName { get; set; }

    /// <summary>
    /// 审批开始时间戳。
    /// </summary>
    [JsonPropertyName("startTime")]
    public JsonElement? StartTime { get; set; }

    /// <summary>
    /// 审批结束时间戳。
    /// </summary>
    [JsonPropertyName("endTime")]
    public JsonElement? EndTime { get; set; }

    /// <summary>
    /// 印章图片地址。
    /// </summary>
    [JsonPropertyName("sealIdImg")]
    public string? SealIdImg { get; set; }

    /// <summary>
    /// 审批节点信息。
    /// </summary>
    [JsonPropertyName("approvalNodes")]
    public List<GetV2EsignApprovalsTaskIdResponseDataItemApprovalNodesItem> ApprovalNodes { get; set; } = [];
}

/// <summary>
/// 获取流程任务用印审批列表响应
/// </summary>
public class GetV2EsignApprovalsTaskIdResponse
{
    /// <summary>
    /// 业务数据。
    /// </summary>
    [JsonPropertyName("data")]
    public List<GetV2EsignApprovalsTaskIdResponseDataItem> Data { get; set; } = [];
}

/// <summary>
/// GetV2EsignFlowTasksTaskIdResponseLogsItem
/// </summary>
public class GetV2EsignFlowTasksTaskIdResponseLogsItem
{
    /// <summary>
    /// 操作人姓名。
    /// </summary>
    [JsonPropertyName("operatorAccountName")]
    public string? OperatorAccountName { get; set; }

    /// <summary>
    /// 操作类型，取值：
    /// </summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }

    /// <summary>
    /// 操作描述。
    /// </summary>
    [JsonPropertyName("operateDescription")]
    public string? OperateDescription { get; set; }

    /// <summary>
    /// 操作时间戳。
    /// </summary>
    [JsonPropertyName("operateTime")]
    public JsonElement? OperateTime { get; set; }
}

/// <summary>
/// 获取流程详细信息及操作记录响应
/// </summary>
public class GetV2EsignFlowTasksTaskIdResponse
{
    /// <summary>
    /// 流程业务场景，流程主题。
    /// </summary>
    [JsonPropertyName("businessScene")]
    public string? BusinessScene { get; set; }

    /// <summary>
    /// 流程状态，取值：
    /// </summary>
    [JsonPropertyName("flowStatus")]
    public JsonElement? FlowStatus { get; set; }

    /// <summary>
    /// 发起主体名称。
    /// </summary>
    [JsonPropertyName("initiatorAuthorizedName")]
    public string? InitiatorAuthorizedName { get; set; }

    /// <summary>
    /// 发起人名称。
    /// </summary>
    [JsonPropertyName("initiatorName")]
    public string? InitiatorName { get; set; }

    /// <summary>
    /// 流程操作日志。
    /// </summary>
    [JsonPropertyName("logs")]
    public List<GetV2EsignFlowTasksTaskIdResponseLogsItem> Logs { get; set; } = [];
}

/// <summary>
/// GetV2EsignFlowTasksTaskIdDocsResponseDataItem
/// </summary>
public class GetV2EsignFlowTasksTaskIdDocsResponseDataItem
{
    /// <summary>
    /// 文件上传后的文件ID。
    /// </summary>
    [JsonPropertyName("fileId")]
    public string? FileId { get; set; }

    /// <summary>
    /// 文件名称。
    /// </summary>
    [JsonPropertyName("fileName")]
    public string? FileName { get; set; }

    /// <summary>
    /// 文件地址。
    /// </summary>
    [JsonPropertyName("fileUrl")]
    public string? FileUrl { get; set; }
}

/// <summary>
/// 获取流程任务的所有合同列表响应
/// </summary>
public class GetV2EsignFlowTasksTaskIdDocsResponse
{
    /// <summary>
    /// 业务数据。
    /// </summary>
    [JsonPropertyName("data")]
    public List<GetV2EsignFlowTasksTaskIdDocsResponseDataItem> Data { get; set; } = [];
}
