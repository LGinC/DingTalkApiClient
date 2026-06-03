namespace DingTalkApiClient.Models.Badge;

/// <summary>
/// 创建钉工牌电子码请求
/// </summary>
public class CreateBadgeCodeUserInstanceRequest
{
    /// <summary>
    /// 业务幂等ID，由调用方随机生成。
    /// </summary>
    public required string RequestId { get; set; }

    /// <summary>
    /// 码标识，取值。
    /// </summary>
    public required string CodeIdentity { get; set; }

    /// <summary>
    /// 码值，由调用方生成。
    /// </summary>
    public string? CodeValue { get; set; }

    /// <summary>
    /// 状态，传入关闭状态需要用户手动开启后才会渲染二维码。
    /// </summary>
    public required string Status { get; set; }

    /// <summary>
    /// 企业corpId。
    /// </summary>
    public required string CorpId { get; set; }

    /// <summary>
    /// 用户和企业的关系类型，用于区分内部员工，外部联系人，无关系普通用户。
    /// </summary>
    public required string UserCorpRelationType { get; set; }

    /// <summary>
    /// 用户身份标识。取值和userCorpRelationType值有关。
    /// </summary>
    public required string UserIdentity { get; set; }

    /// <summary>
    /// 临时码过期时间，格式：yyyy-MM-dd HH:mm:ss。
    /// </summary>
    public required string GmtExpired { get; set; }

    /// <summary>
    /// 有效时间列表，对于连续时间段，只需传入一个对象即可。过期时间必须晚于最晚结束时间。
    /// </summary>
    public required List<BadgeAvailableTime> AvailableTimes { get; set; }

    /// <summary>
    /// 扩展参数。
    /// </summary>
    public required Dictionary<string, object?> ExtInfo { get; set; }

    /// <summary>
    /// 码值类型，可不传，默认为DING_STATIC。
    /// </summary>
    public string? CodeValueType { get; set; }
}

/// <summary>
/// 更新钉工牌电子码请求
/// </summary>
public class UpdateBadgeCodeUserInstanceRequest
{
    /// <summary>
    /// 用户码ID。
    /// </summary>
    public required string CodeId { get; set; }

    /// <summary>
    /// 码标识，取值。
    /// </summary>
    public required string CodeIdentity { get; set; }

    /// <summary>
    /// 码值，由调用方生成。
    /// </summary>
    public required string CodeValue { get; set; }

    /// <summary>
    /// 状态，传入关闭状态需要用户手动开启后才会渲染二维码。
    /// </summary>
    public required string Status { get; set; }

    /// <summary>
    /// 企业corpId。
    /// </summary>
    public required string CorpId { get; set; }

    /// <summary>
    /// 用户和企业的关系类型，用于区分内部员工，外部联系人，无关系普通用户。
    /// </summary>
    public required string UserCorpRelationType { get; set; }

    /// <summary>
    /// 用户身份标识。取值和userCorpRelationType值有关。
    /// </summary>
    public required string UserIdentity { get; set; }

    /// <summary>
    /// 临时码过期时间，格式：yyyy-MM-dd HH:mm:ss。
    /// </summary>
    public required string GmtExpired { get; set; }

    /// <summary>
    /// 有效时间列表，对于连续时间段，只需传入一个对象即可。过期时间必须晚于最晚结束时间。
    /// </summary>
    public required List<BadgeAvailableTime> AvailableTimes { get; set; }

    /// <summary>
    /// 扩展参数。
    /// </summary>
    public required Dictionary<string, object?> ExtInfo { get; set; }
}

/// <summary>
/// 钉工牌电子码有效时间
/// </summary>
public class BadgeAvailableTime
{
    /// <summary>
    /// 开始时间，格式：yyyy-MM-dd HH:mm:ss。
    /// </summary>
    public required string GmtStart { get; set; }

    /// <summary>
    /// 结束时间，格式：yyyy-MM-dd HH:mm:ss。
    /// </summary>
    public required string GmtEnd { get; set; }
}

/// <summary>
/// 创建钉工牌电子码响应
/// </summary>
public class CreateBadgeCodeUserInstanceResponse
{
    /// <summary>
    /// 码ID。
    /// </summary>
    public required string CodeId { get; set; }

    /// <summary>
    /// 码详情跳转地址。
    /// </summary>
    public required string CodeDetailUrl { get; set; }
}

/// <summary>
/// 更新钉工牌电子码响应
/// </summary>
public class UpdateBadgeCodeUserInstanceResponse
{
    /// <summary>
    /// 码ID。
    /// </summary>
    public required string CodeId { get; set; }
}

/// <summary>
/// 配置企业钉工牌请求
/// </summary>
public class SaveBadgeCodeCorpInstanceRequest
{
    /// <summary>
    /// 码标识，取值。
    /// </summary>
    public required string CodeIdentity { get; set; }

    /// <summary>
    /// 开通的企业corpId。
    /// </summary>
    public required string CorpId { get; set; }

    /// <summary>
    /// 状态，传入关闭状态需要用户手动开启后才会渲染二维码。
    /// </summary>
    public required string Status { get; set; }
}

/// <summary>
/// 配置企业钉工牌响应
/// </summary>
public class SaveBadgeCodeCorpInstanceResponse
{
    /// <summary>
    /// 码标识。
    /// </summary>
    public string? CodeIdentity { get; set; }

    /// <summary>
    /// 开通的企业corpId。
    /// </summary>
    public string? CorpId { get; set; }

    /// <summary>
    /// 状态，传入关闭状态需要用户手动开启后才会渲染二维码。
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// 扩展参数。
    /// </summary>
    public Dictionary<string, object?> ExtInfo { get; set; } = [];
}

/// <summary>
/// 解码钉工牌电子码请求
/// </summary>
public class DecodeBadgeCodeRequest
{
    /// <summary>
    /// 码值，解码接口仅支持钉钉侧生成的码值。目前不支持标准码解析。
    /// </summary>
    public required string PayCode { get; set; }

    /// <summary>
    /// 请求ID，幂等号。
    /// </summary>
    public required string RequestId { get; set; }
}

/// <summary>
/// 解码钉工牌电子码响应
/// </summary>
public class DecodeBadgeCodeResponse
{
    /// <summary>
    /// 企业corpId。
    /// </summary>
    public required string CorpId { get; set; }

    /// <summary>
    /// 员工的userid。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 付款码类型，取值。
    /// </summary>
    public required string CodeType { get; set; }

    /// <summary>
    /// 支付宝付款码。
    /// </summary>
    public required string AlipayCode { get; set; }

    /// <summary>
    /// 用户和企业关系，取值。
    /// </summary>
    public required string UserCorpRelationType { get; set; }

    /// <summary>
    /// 码标识。取值：DT_IDENTITY、DT_VISITOR、DT_CONFERENCE。
    /// </summary>
    public required string CodeIdentity { get; set; }

    /// <summary>
    /// 码ID，例如访客码ID或会展码ID等。
    /// </summary>
    public required string CodeId { get; set; }

    /// <summary>
    /// 外部业务ID，值为创建钉工牌电子码接口传入的参数requestId。
    /// </summary>
    public required string OutBizId { get; set; }

    /// <summary>
    /// 扩展信息。
    /// </summary>
    public required string ExtInfo { get; set; }
}

/// <summary>
/// 通知支付结果请求
/// </summary>
public class NotifyBadgeCodePayResultRequest
{
    /// <summary>
    /// 付款码值。
    /// </summary>
    public required string PayCode { get; set; }

    /// <summary>
    /// 企业corpId。
    /// </summary>
    public required string CorpId { get; set; }

    /// <summary>
    /// 用户userid，需要与生成码时传入的userid保持一致。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 交易开始时间。格式：yyyy-MM-dd HH:mm:ss。
    /// </summary>
    public required string GmtTradeCreate { get; set; }

    /// <summary>
    /// 交易结束时间。格式：yyyy-MM-dd HH:mm:ss。
    /// </summary>
    public required string GmtTradeFinish { get; set; }

    /// <summary>
    /// 交易号。
    /// </summary>
    public required string TradeNo { get; set; }

    /// <summary>
    /// 交易状态，取值。
    /// </summary>
    public required string TradeStatus { get; set; }

    /// <summary>
    /// 订单标题。
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// 备注。
    /// </summary>
    public required string Remark { get; set; }

    /// <summary>
    /// 订单金额。
    /// </summary>
    public required string Amount { get; set; }

    /// <summary>
    /// 订单优惠金额。
    /// </summary>
    public required string PromotionAmount { get; set; }

    /// <summary>
    /// 收费金额。
    /// </summary>
    public required string ChargeAmount { get; set; }

    /// <summary>
    /// 支付渠道明细信息。
    /// </summary>
    public required List<BadgePayChannelDetail> PayChannelDetailList { get; set; }

    /// <summary>
    /// 支付失败错误码，当tradeStatus为FAIL时必须传入。
    /// </summary>
    public required string TradeErrorCode { get; set; }

    /// <summary>
    /// 支付失败信息，当tradeStatus为FAIL时必须传入。
    /// </summary>
    public required string TradeErrorMsg { get; set; }

    /// <summary>
    /// 扩展信息。
    /// </summary>
    public required string ExtInfo { get; set; }

    /// <summary>
    /// 商户名称。
    /// </summary>
    public required string MerchantName { get; set; }
}

/// <summary>
/// 通知退款结果请求
/// </summary>
public class NotifyBadgeCodeRefundResultRequest
{
    /// <summary>
    /// 企业的corpId。
    /// </summary>
    public required string CorpId { get; set; }

    /// <summary>
    /// 用户userid，需要与生成码时使用的userid保持一致。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 交易订单号。
    /// </summary>
    public required string TradeNo { get; set; }

    /// <summary>
    /// 本次退款订单号。
    /// </summary>
    public required string RefundOrderNo { get; set; }

    /// <summary>
    /// 备注。
    /// </summary>
    public required string Remark { get; set; }

    /// <summary>
    /// 退款金额。
    /// </summary>
    public required string RefundAmount { get; set; }

    /// <summary>
    /// 退款的优惠金额。
    /// </summary>
    public required string RefundPromotionAmount { get; set; }

    /// <summary>
    /// 退款时间。格式：yyyy-MM-dd HH:mm:ss。
    /// </summary>
    public required string GmtRefund { get; set; }

    /// <summary>
    /// 支付渠道明细信息。
    /// </summary>
    public required List<BadgePayChannelDetail> PayChannelDetailList { get; set; }

    /// <summary>
    /// 支付时使用的付款码。
    /// </summary>
    public required string PayCode { get; set; }
}

/// <summary>
/// 支付渠道明细信息
/// </summary>
public class BadgePayChannelDetail
{
    /// <summary>
    /// 支付渠道名称。
    /// </summary>
    public required string PayChannelName { get; set; }

    /// <summary>
    /// 开始时间。
    /// </summary>
    public string? GmtCreate { get; set; }

    /// <summary>
    /// 结束时间。
    /// </summary>
    public string? GmtFinish { get; set; }

    /// <summary>
    /// 支付渠道类型，取值。
    /// </summary>
    public required string PayChannelType { get; set; }

    /// <summary>
    /// 金额。
    /// </summary>
    public required string Amount { get; set; }

    /// <summary>
    /// 支付渠道单号。
    /// </summary>
    public required string PayChannelOrderNo { get; set; }

    /// <summary>
    /// 支付渠道退款号。
    /// </summary>
    public string? PayChannelRefundOrderNo { get; set; }

    /// <summary>
    /// 优惠金额。
    /// </summary>
    public required string PromotionAmount { get; set; }

    /// <summary>
    /// 资金工具明细。
    /// </summary>
    public required List<BadgeFundToolDetail> FundToolDetailList { get; set; }
}

/// <summary>
/// 支付资金工具明细
/// </summary>
public class BadgeFundToolDetail
{
    /// <summary>
    /// 资金工具名称。
    /// </summary>
    public required string FundToolName { get; set; }

    /// <summary>
    /// 金额。
    /// </summary>
    public required string Amount { get; set; }

    /// <summary>
    /// 创建时间。格式：yyyy-MM-dd HH:mm:ss。
    /// </summary>
    public required string GmtCreate { get; set; }

    /// <summary>
    /// 完成时间。格式：yyyy-MM-dd HH:mm:ss。
    /// </summary>
    public required string GmtFinish { get; set; }

    /// <summary>
    /// 是否是优惠工具。
    /// </summary>
    public bool PromotionFundTool { get; set; }

    /// <summary>
    /// 扩展信息。
    /// </summary>
    public string? ExtInfo { get; set; }
}

/// <summary>
/// 钉工牌通知消息请求
/// </summary>
public class CreateBadgeNotifyRequest
{
    /// <summary>
    /// 用户userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 消息传入，调用方传入，唯一标识消息。
    /// </summary>
    public required string MsgId { get; set; }

    /// <summary>
    /// 消息类型，取值：DING_BADGE_NOTIFY：钉工牌通知场景。
    /// </summary>
    public required string MsgType { get; set; }

    /// <summary>
    /// 通知内容。钉工牌场景必传字段：title、subTitle、imageUrl、url。
    /// </summary>
    public required string Content { get; set; }
}

/// <summary>
/// 同步钉工牌码验证结果请求
/// </summary>
public class NotifyBadgeCodeVerifyResultRequest
{
    /// <summary>
    /// 码值。硬件设备扫码获取码值。
    /// </summary>
    public required string PayCode { get; set; }

    /// <summary>
    /// 企业corpId。
    /// </summary>
    public required string CorpId { get; set; }

    /// <summary>
    /// 用户和企业的关系类型，用于区分内部员工，外部联系人，无关系普通用户。
    /// </summary>
    public required string UserCorpRelationType { get; set; }

    /// <summary>
    /// 用户身份标识。取值和userCorpRelationType值有关。
    /// </summary>
    public required string UserIdentity { get; set; }

    /// <summary>
    /// 验证时间。
    /// </summary>
    public required string VerifyTime { get; set; }

    /// <summary>
    /// 验证结果。
    /// </summary>
    public bool VerifyResult { get; set; }

    /// <summary>
    /// 验证地点。
    /// </summary>
    public required string VerifyLocation { get; set; }
}

/// <summary>
/// 钉工牌字符串结果响应
/// </summary>
public class BadgeStringResultResponse
{
    /// <summary>
    /// 请求处理结果。
    /// </summary>
    public required string Result { get; set; }
}

/// <summary>
/// 钉工牌布尔结果响应
/// </summary>
public class BadgeBooleanResultResponse
{
    /// <summary>
    /// 发送通知是否成功。true表示成功。
    /// </summary>
    public required bool Result { get; set; }
}
