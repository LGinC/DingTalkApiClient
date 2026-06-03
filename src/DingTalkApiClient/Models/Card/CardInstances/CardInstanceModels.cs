namespace DingTalkApiClient.Models.Card.CardInstances;

/// <summary>
/// 创建卡片请求。
/// </summary>
public class CreateCardInstanceRequest
{
    /// <summary>
    /// 卡片创建者的 userId。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// 卡片内容模板 ID，可通过开发者后台卡片平台获取。
    /// </summary>
    public required string CardTemplateId { get; set; }

    /// <summary>
    /// 外部卡片实例 Id，由开发者生成并作为入参传递给钉钉。
    /// </summary>
    public required string OutTrackId { get; set; }

    /// <summary>
    /// 卡片回调 HTTP 模式时的路由 Key，用于查询注册的 callbackUrl。
    /// </summary>
    public string? CallbackRouteKey { get; set; }

    /// <summary>
    /// 卡片数据。
    /// </summary>
    public required CardData CardData { get; set; }

    /// <summary>
    /// 用户私有数据，key 为用户 userId，value 为用户私有数据。
    /// </summary>
    public Dictionary<string, CardData>? PrivateData { get; set; }

    /// <summary>
    /// 动态数据源配置。
    /// </summary>
    public OpenDynamicDataConfig? OpenDynamicDataConfig { get; set; }

    /// <summary>
    /// IM 群聊场域信息。
    /// </summary>
    public ImOpenSpaceModel? ImGroupOpenSpaceModel { get; set; }

    /// <summary>
    /// IM 单聊场域信息。
    /// </summary>
    public ImOpenSpaceModel? ImRobotOpenSpaceModel { get; set; }

    /// <summary>
    /// 协作场域信息。
    /// </summary>
    public CoFeedOpenSpaceModel? CoFeedOpenSpaceModel { get; set; }

    /// <summary>
    /// 吊顶场域信息。
    /// </summary>
    public TopOpenSpaceModel? TopOpenSpaceModel { get; set; }

    /// <summary>
    /// 用户 ID 类型。
    /// </summary>
    public int? UserIdType { get; set; }
}

/// <summary>
/// 更新卡片请求。
/// </summary>
public class UpdateCardInstanceRequest
{
    /// <summary>
    /// 外部卡片实例 Id，由开发者生成并作为入参传递给钉钉。
    /// </summary>
    public required string OutTrackId { get; set; }

    /// <summary>
    /// 卡片数据。
    /// </summary>
    public CardData? CardData { get; set; }

    /// <summary>
    /// 用户私有数据，key 为用户 userId，value 为用户私有数据。
    /// </summary>
    public Dictionary<string, CardData>? PrivateData { get; set; }

    /// <summary>
    /// 卡片更新选项。
    /// </summary>
    public CardUpdateOptions? CardUpdateOptions { get; set; }

    /// <summary>
    /// 用户 ID 类型。
    /// </summary>
    public int? UserIdType { get; set; }
}

/// <summary>
/// 投放卡片请求。
/// </summary>
public class DeliverCardRequest
{
    /// <summary>
    /// 外部卡片实例 Id，由开发者生成并作为入参传递给钉钉。
    /// </summary>
    public required string OutTrackId { get; set; }

    /// <summary>
    /// 场域及其场域 id。
    /// </summary>
    public required string OpenSpaceId { get; set; }

    /// <summary>
    /// IM 机器人单聊投放参数。
    /// </summary>
    public ImRobotOpenDeliverModel? ImRobotOpenDeliverModel { get; set; }

    /// <summary>
    /// 群聊投放参数。
    /// </summary>
    public ImGroupOpenDeliverModel? ImGroupOpenDeliverModel { get; set; }

    /// <summary>
    /// 吊顶投放参数。
    /// </summary>
    public TopOpenDeliverModel? TopOpenDeliverModel { get; set; }

    /// <summary>
    /// 协作投放参数。
    /// </summary>
    public CoFeedOpenDeliverModel? CoFeedOpenDeliverModel { get; set; }

    /// <summary>
    /// 文档投放参数。
    /// </summary>
    public DocOpenDeliverModel? DocOpenDeliverModel { get; set; }

    /// <summary>
    /// 用户 ID 类型。
    /// </summary>
    public int? UserIdType { get; set; }
}

/// <summary>
/// 创建并投放卡片请求。
/// </summary>
public class CreateAndDeliverCardRequest : CreateCardInstanceRequest
{
    /// <summary>
    /// 场域及其场域 id。
    /// </summary>
    public required string OpenSpaceId { get; set; }

    /// <summary>
    /// 群聊投放参数。
    /// </summary>
    public ImGroupOpenDeliverModel? ImGroupOpenDeliverModel { get; set; }

    /// <summary>
    /// IM 机器人单聊投放参数。
    /// </summary>
    public ImRobotOpenDeliverModel? ImRobotOpenDeliverModel { get; set; }

    /// <summary>
    /// 吊顶投放参数。
    /// </summary>
    public TopOpenDeliverModel? TopOpenDeliverModel { get; set; }

    /// <summary>
    /// 协作投放参数。
    /// </summary>
    public CoFeedOpenDeliverModel? CoFeedOpenDeliverModel { get; set; }

    /// <summary>
    /// 文档投放参数。
    /// </summary>
    public DocOpenDeliverModel? DocOpenDeliverModel { get; set; }
}

/// <summary>
/// 注册卡片回调地址请求。
/// </summary>
public class RegisterCardCallbackRequest
{
    /// <summary>
    /// 回调地址的路由 Key，一个 callbackRouteKey 仅可映射一个 callbackUrl。
    /// </summary>
    public required string CallbackRouteKey { get; set; }

    /// <summary>
    /// 接收动态卡片回调的公网 URL 地址。
    /// </summary>
    public required string CallbackUrl { get; set; }

    /// <summary>
    /// 加密密钥用于校验来源。
    /// </summary>
    public string? ApiSecret { get; set; }

    /// <summary>
    /// 是否强制更新已存在的回调地址。
    /// </summary>
    public bool? ForceUpdate { get; set; }
}

/// <summary>
/// 新增或者更新卡片的场域信息请求。
/// </summary>
public class UpsertCardSpaceRequest
{
    /// <summary>
    /// 外部卡片实例 Id，由开发者生成并作为入参传递给钉钉。
    /// </summary>
    public required string OutTrackId { get; set; }

    /// <summary>
    /// IM 群聊场域信息。
    /// </summary>
    public ImOpenSpaceModel? ImGroupOpenSpaceModel { get; set; }

    /// <summary>
    /// 机器人单聊场域参数。
    /// </summary>
    public ImOpenSpaceModel? ImRobotOpenSpaceModel { get; set; }

    /// <summary>
    /// 吊顶场域信息。
    /// </summary>
    public TopOpenSpaceModel? TopOpenSpaceModel { get; set; }

    /// <summary>
    /// 协作场域信息。
    /// </summary>
    public CoFeedOpenSpaceModel? CoFeedOpenSpaceModel { get; set; }
}

/// <summary>
/// 卡片数据。
/// </summary>
public class CardData
{
    /// <summary>
    /// 卡片模板内容替换参数，key 为参数名，value 为参数值。
    /// </summary>
    public required Dictionary<string, string> CardParamMap { get; set; }
}

/// <summary>
/// 动态数据源配置。
/// </summary>
public class OpenDynamicDataConfig
{
    /// <summary>
    /// 动态数据源配置列表。
    /// </summary>
    public required List<DynamicDataSourceConfig> DynamicDataSourceConfigs { get; set; }
}

/// <summary>
/// 动态数据源配置项。
/// </summary>
public class DynamicDataSourceConfig
{
    /// <summary>
    /// 数据源的唯一 ID，由调用方指定。
    /// </summary>
    public required string DynamicDataSourceId { get; set; }

    /// <summary>
    /// 回调数据源时回传的固定参数。
    /// </summary>
    public Dictionary<string, string>? ConstParams { get; set; }

    /// <summary>
    /// 数据源拉取配置。
    /// </summary>
    public required DynamicDataPullConfig PullConfig { get; set; }
}

/// <summary>
/// 数据源拉取配置。
/// </summary>
public class DynamicDataPullConfig
{
    /// <summary>
    /// 拉取策略，可选值：NONE、INTERVAL、ONCE。
    /// </summary>
    public required string PullStrategy { get; set; }

    /// <summary>
    /// 拉取的间隔时间单位，只在 pullStrategy 为 INTERVAL 时生效。
    /// </summary>
    public required string TimeUnit { get; set; }

    /// <summary>
    /// 拉取间隔时间。
    /// </summary>
    public int? Interval { get; set; }
}

/// <summary>
/// IM 场域信息。
/// </summary>
public class ImOpenSpaceModel
{
    /// <summary>
    /// 是否支持转发。
    /// </summary>
    public bool? SupportForward { get; set; }

    /// <summary>
    /// 支持国际化的 lastMessage，key 为语言枚举值，value 为 lastMessage 内容。
    /// </summary>
    public Dictionary<string, string>? LastMessageI18n { get; set; }

    /// <summary>
    /// 支持卡片消息可被搜索字段。
    /// </summary>
    public SearchSupport? SearchSupport { get; set; }

    /// <summary>
    /// 通知信息。
    /// </summary>
    public Notification? Notification { get; set; }
}

/// <summary>
/// 支持卡片消息可被搜索字段。
/// </summary>
public class SearchSupport
{
    /// <summary>
    /// 类型的 icon，供搜索展示使用。
    /// </summary>
    public string? SearchIcon { get; set; }

    /// <summary>
    /// 卡片类型名。
    /// </summary>
    public string? SearchTypeName { get; set; }

    /// <summary>
    /// 供消息展示与搜索的字段，最大限制 200 个字符。
    /// </summary>
    public string? SearchDesc { get; set; }
}

/// <summary>
/// 通知信息。
/// </summary>
public class Notification
{
    /// <summary>
    /// 通知内容，若不填写则使用默认文案。
    /// </summary>
    public string? AlertContent { get; set; }

    /// <summary>
    /// 是否关闭通知。
    /// </summary>
    public bool? NotificationOff { get; set; }
}

/// <summary>
/// 协作场域信息。
/// </summary>
public class CoFeedOpenSpaceModel
{
    /// <summary>
    /// 卡片标题。
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// 酷应用编码。
    /// </summary>
    public string? CoolAppCode { get; set; }
}

/// <summary>
/// 吊顶场域信息。
/// </summary>
public class TopOpenSpaceModel
{
    /// <summary>
    /// 吊顶场域属性，吊顶对应 spaceType 为 ONE_BOX。
    /// </summary>
    public required string SpaceType { get; set; }
}

/// <summary>
/// 卡片更新选项。
/// </summary>
public class CardUpdateOptions
{
    /// <summary>
    /// 是否按 key 更新卡片公共数据。
    /// </summary>
    public bool? UpdateCardDataByKey { get; set; }

    /// <summary>
    /// 是否按 key 更新用户私有数据。
    /// </summary>
    public bool? UpdatePrivateDataByKey { get; set; }
}

/// <summary>
/// IM 机器人单聊投放参数。
/// </summary>
public class ImRobotOpenDeliverModel
{
    /// <summary>
    /// 场域类型。
    /// </summary>
    public required string SpaceType { get; set; }
}

/// <summary>
/// 群聊投放参数。
/// </summary>
public class ImGroupOpenDeliverModel
{
    /// <summary>
    /// 机器人编码。
    /// </summary>
    public required string RobotCode { get; set; }

    /// <summary>
    /// 被 @ 用户列表，key 为用户 ID，value 为展示文本。
    /// </summary>
    public required Dictionary<string, string> AtUserIds { get; set; }

    /// <summary>
    /// 接收人列表。
    /// </summary>
    public required List<string> Recipients { get; set; }
}

/// <summary>
/// 吊顶投放参数。
/// </summary>
public class TopOpenDeliverModel
{
    /// <summary>
    /// 到期时间，毫秒时间戳。
    /// </summary>
    public long? ExpiredTimeMillis { get; set; }

    /// <summary>
    /// 用户 ID 列表。
    /// </summary>
    public required List<string> UserIds { get; set; }

    /// <summary>
    /// 投放平台列表。
    /// </summary>
    public required List<string> Platforms { get; set; }
}

/// <summary>
/// 协作投放参数。
/// </summary>
public class CoFeedOpenDeliverModel
{
    /// <summary>
    /// 业务标签。
    /// </summary>
    public required string BizTag { get; set; }

    /// <summary>
    /// 时间线时间，毫秒时间戳。
    /// </summary>
    public long? GmtTimeLine { get; set; }
}

/// <summary>
/// 文档投放参数。
/// </summary>
public class DocOpenDeliverModel
{
    /// <summary>
    /// 用户 ID。
    /// </summary>
    public required string UserId { get; set; }
}

/// <summary>
/// 卡片布尔响应。
/// </summary>
public class CardBooleanResponse
{
    /// <summary>
    /// 调用是否成功。
    /// </summary>
    public required bool Success { get; set; }

    /// <summary>
    /// 业务结果。
    /// </summary>
    public required bool Result { get; set; }
}

/// <summary>
/// 创建卡片响应。
/// </summary>
public class CreateCardInstanceResponse
{
    /// <summary>
    /// 调用结果。
    /// </summary>
    public required bool Success { get; set; }

    /// <summary>
    /// 外部卡片实例 Id。
    /// </summary>
    public required string Result { get; set; }
}

/// <summary>
/// 投放卡片响应。
/// </summary>
public class DeliverCardResponse
{
    /// <summary>
    /// 调用结果。
    /// </summary>
    public required bool Success { get; set; }

    /// <summary>
    /// 投放结果。
    /// </summary>
    public required List<CardDeliverResult> Result { get; set; }
}

/// <summary>
/// 创建并投放卡片响应。
/// </summary>
public class CreateAndDeliverCardResponse
{
    /// <summary>
    /// 调用结果。
    /// </summary>
    public required bool Success { get; set; }

    /// <summary>
    /// 创建并投放实例结果。
    /// </summary>
    public required CreateAndDeliverCardResult Result { get; set; }
}

/// <summary>
/// 创建并投放实例结果。
/// </summary>
public class CreateAndDeliverCardResult
{
    /// <summary>
    /// 外部卡片实例 Id。
    /// </summary>
    public required string OutTrackId { get; set; }

    /// <summary>
    /// 投放结果。
    /// </summary>
    public required List<CardDeliverResult> DeliverResults { get; set; }
}

/// <summary>
/// 投放结果。
/// </summary>
public class CardDeliverResult
{
    /// <summary>
    /// 场域类型：IM、IM_GROUP、IM_ROBOT、ONE_BOX、COOPERATION_FEED。
    /// </summary>
    public string? SpaceType { get; set; }

    /// <summary>
    /// 场域 Id。
    /// </summary>
    public string? SpaceId { get; set; }

    /// <summary>
    /// 是否投放成功。
    /// </summary>
    public bool? Success { get; set; }

    /// <summary>
    /// 投放结果 id，IM 场域返回 processQueryKey。
    /// </summary>
    public string? CarrierId { get; set; }

    /// <summary>
    /// 错误信息。
    /// </summary>
    public string? ErrorMsg { get; set; }
}

/// <summary>
/// 注册卡片回调地址响应。
/// </summary>
public class RegisterCardCallbackResponse
{
    /// <summary>
    /// 请求是否成功。
    /// </summary>
    public required bool Success { get; set; }

    /// <summary>
    /// 注册回调地址的结果。
    /// </summary>
    public required RegisterCardCallbackResult Result { get; set; }
}

/// <summary>
/// 注册回调地址的结果。
/// </summary>
public class RegisterCardCallbackResult
{
    /// <summary>
    /// 回调 URL 地址。
    /// </summary>
    public required string CallbackUrl { get; set; }

    /// <summary>
    /// 加密密钥。
    /// </summary>
    public required string ApiSecret { get; set; }
}
