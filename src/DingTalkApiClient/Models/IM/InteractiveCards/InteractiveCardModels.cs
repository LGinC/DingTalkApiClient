using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models.IM.InteractiveCards;

/// <summary>
/// 互动卡片流程响应
/// </summary>
public class InteractiveCardProcessResponse
{
    /// <summary>
    /// 用于业务方后续查看已读列表的查询key。
    /// </summary>
    public string? ProcessQueryKey { get; set; }
}

/// <summary>
/// 互动卡片成功响应
/// </summary>
public class InteractiveCardSuccessResponse
{
    /// <summary>
    /// 接口调用是否成功。
    /// </summary>
    public bool? Success { get; set; }
}

/// <summary>
/// 互动卡片发送响应
/// </summary>
public class InteractiveCardSendResponse : InteractiveCardSuccessResponse
{
    /// <summary>
    /// 创建卡片结果。
    /// </summary>
    public InteractiveCardSendResult? Result { get; set; }
}

/// <summary>
/// 互动卡片发送结果
/// </summary>
public class InteractiveCardSendResult
{
    /// <summary>
    /// 用于业务方后续查看已读列表的查询key。
    /// </summary>
    public string? ProcessQueryKey { get; set; }

    /// <summary>
    /// 开放动态卡片实例 ID
    /// </summary>
    public string? OpenDynamicCardInstanceId { get; set; }
}

/// <summary>
/// 机器人发送互动卡片请求
/// </summary>
public class SendRobotInteractiveCardRequest
{
    /// <summary>
    /// 卡片搭建平台模板ID，固定值填写为StandardCard。
    /// </summary>
    public required string CardTemplateId { get; set; }

    /// <summary>
    /// 唯一标识一张卡片的外部ID，卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话。
    /// </summary>
    public required string CardBizId { get; set; }

    /// <summary>
    /// 机器人的编码；企业内部应用或第三方企业应用参见机器人名词表-robotCode内容获取robotCode。
    /// </summary>
    public required string RobotCode { get; set; }

    /// <summary>
    /// 卡片模板文本内容参数，卡片json结构体。
    /// </summary>
    public required Dictionary<string, object?> CardData { get; set; }

    /// <summary>
    /// 接收卡片的加密群ID，特指多人群会话（非单聊）；openConversationId和singleChatReceiver二选一必填。
    /// </summary>
    public string? OpenConversationId { get; set; }

    /// <summary>
    /// 单聊会话接收者json串；openConversationId和singleChatReceiver二选一必填。
    /// </summary>
    public string? SingleChatReceiver { get; set; }

    /// <summary>
    /// 可控制卡片回调的URL，不填则无需回调。
    /// </summary>
    public string? CallbackUrl { get; set; }

    /// <summary>
    /// 互动卡片发送选项。
    /// </summary>
    public Dictionary<string, object?>? SendOptions { get; set; }
}

/// <summary>
/// 更新机器人互动卡片请求
/// </summary>
public class UpdateRobotInteractiveCardRequest
{
    /// <summary>
    /// 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话），需与发送接口Body参数中cardBizId保持一致。
    /// </summary>
    public required string CardBizId { get; set; }

    /// <summary>
    /// 卡片模板文本内容，在卡片搭建平台设计模板后复制右侧示例代码信息即为该参数值。
    /// </summary>
    public Dictionary<string, object?>? CardData { get; set; }

    /// <summary>
    /// 互动卡片更新选项。
    /// </summary>
    public Dictionary<string, object?>? UpdateOptions { get; set; }
}

/// <summary>
/// 发送互动卡片请求
/// </summary>
public class SendInteractiveCardRequest
{
    /// <summary>
    /// 互动卡片的消息模板ID；企业内部应用或第三方企业应用调用创建消息模板接口获取模板ID。
    /// </summary>
    public required string CardTemplateId { get; set; }

    /// <summary>
    /// 唯一标识一张卡片的外部编码；最长不超过100字符，建议长度在64字符以内。
    /// </summary>
    public required string OutTrackId { get; set; }

    /// <summary>
    /// 卡片公有数据；cardData数据长度和privateData数据长度总和不能超过100KB。
    /// </summary>
    public required Dictionary<string, object?> CardData { get; set; }

    /// <summary>
    /// 发送的会话类型：0单聊，1群聊。
    /// </summary>
    public required int ConversationType { get; set; }

    /// <summary>
    /// 群ID；单聊时openConversationId不用填写。
    /// </summary>
    public string? OpenConversationId { get; set; }

    /// <summary>
    /// 接收人userId列表；单聊最大值20，群聊不填写表示当前群内所有用户可见。
    /// </summary>
    public List<string>? ReceiverUserIdList { get; set; }

    /// <summary>
    /// 机器人的编码；场景群机器人发送群聊时填写robotCode。
    /// </summary>
    public string? RobotCode { get; set; }

    /// <summary>
    /// 卡片回调时的路由Key，用于查询注册的callbackUrl；可以为空，不填写默认无需回调。
    /// </summary>
    public string? CallbackRouteKey { get; set; }

    /// <summary>
    /// 卡片私有数据；key为用户userId或unionId，value为用户数据。
    /// </summary>
    public Dictionary<string, object?>? PrivateData { get; set; }

    /// <summary>
    /// 卡片操作。
    /// </summary>
    public Dictionary<string, object?>? CardOptions { get; set; }
}

/// <summary>
/// 更新互动卡片请求
/// </summary>
public class UpdateInteractiveCardRequest
{
    /// <summary>
    /// 卡片的唯一标识编码；由开发者生成并作为入参传递给钉钉。
    /// </summary>
    public string? OutTrackId { get; set; }

    /// <summary>
    /// 卡片数据。
    /// </summary>
    public Dictionary<string, object?>? CardData { get; set; }

    /// <summary>
    /// 指定用户可见的按钮列表；key为用户userId，value为用户数据。
    /// </summary>
    public Dictionary<string, object?>? PrivateData { get; set; }

    /// <summary>
    /// 发送可交互卡片的功能选项。
    /// </summary>
    public Dictionary<string, object?>? CardOptions { get; set; }
}

/// <summary>
/// 发送私聊互动卡片请求
/// </summary>
public class SendPrivateChatInteractiveCardRequest
{
    /// <summary>
    /// 卡片模板ID，可通过卡片平台创建消息卡片。
    /// </summary>
    public required string CardTemplateId { get; set; }

    /// <summary>
    /// 卡片的外部编码。
    /// </summary>
    public required string OutTrackId { get; set; }

    /// <summary>
    /// 卡片公有数据内容。
    /// </summary>
    public required Dictionary<string, object?> CardData { get; set; }

    /// <summary>
    /// 会话ID；可通过单聊酷应用安装或事件获取OpenConversationId参数值。
    /// </summary>
    public string? OpenConversationId { get; set; }

    /// <summary>
    /// 用户ID列表。
    /// </summary>
    public List<string>? ReceiverUserIdList { get; set; }

    /// <summary>
    /// 本接口只支持企业内部应用机器人调用，该参数使用企业内部应用机器人的robotCode。
    /// </summary>
    public string? RobotCode { get; set; }

    /// <summary>
    /// 卡片回调时的路由Key，用于查询注册的callbackUrl；可以为空，不填写默认无需回调。
    /// </summary>
    public string? CallbackRouteKey { get; set; }

    /// <summary>
    /// 指定用户可见的按钮；key为用户userId或unionId，value为用户数据。
    /// </summary>
    public Dictionary<string, object?>? PrivateData { get; set; }

    /// <summary>
    /// 卡片属性。
    /// </summary>
    public Dictionary<string, object?>? CardOptions { get; set; }
}

/// <summary>
/// 发送轻量级互动卡片请求
/// </summary>
public class SendTemplateInteractiveCardRequest
{
    /// <summary>
    /// 卡片内容模板ID，响应模板目前有TuWenCard01、TuWenCard02、TuWenCard03、TuWenCard04。
    /// </summary>
    public required string CardTemplateId { get; set; }

    /// <summary>
    /// 唯一标识一张卡片的外部ID；卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话。
    /// </summary>
    public required string OutTrackId { get; set; }

    /// <summary>
    /// 机器人代码；企业内部机器人取机器人appKey值，第三方企业机器人或群模板机器人取robotCode值。
    /// </summary>
    public required string RobotCode { get; set; }

    /// <summary>
    /// 卡片模板文本内容参数。
    /// </summary>
    public required Dictionary<string, object?> CardData { get; set; }

    /// <summary>
    /// 接收卡片的加密群ID，特指多人群会话（非单聊）；openConversationId和singleChatReceiver二选一必填。
    /// </summary>
    public string? OpenConversationId { get; set; }

    /// <summary>
    /// 单聊会话接收者json字符串；openConversationId和singleChatReceiver二选一必填。
    /// </summary>
    public string? SingleChatReceiver { get; set; }

    /// <summary>
    /// 可控制卡片回调的URL；如果不填则默认为无需回调。
    /// </summary>
    public string? CallbackUrl { get; set; }

    /// <summary>
    /// 互动卡片发送选项。
    /// </summary>
    public Dictionary<string, object?>? SendOptions { get; set; }
}
