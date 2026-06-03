using System.Text.Json.Serialization;

namespace DingTalkApi.Models.ServiceWindow;

/// <summary>
/// 批量发送服务窗消息请求。
/// </summary>
public class ServiceWindowBatchSendMessageRequest
{
    /// <summary>
    /// 消息详情。
    /// </summary>
    public required ServiceWindowBatchMessageDetail Detail { get; set; }

    /// <summary>
    /// 服务窗授权的调用方标识，可以为空。
    /// </summary>
    public string? BizId { get; set; }

    /// <summary>
    /// 账号id。
    /// </summary>
    public string? AccountId { get; set; }
}

/// <summary>
/// 服务窗批量消息详情。
/// </summary>
public class ServiceWindowBatchMessageDetail
{
    /// <summary>
    /// 消息类型。
    /// </summary>
    public required string MsgType { get; set; }

    /// <summary>
    /// 消息请求唯一ID。长度不超过128位字符。
    /// </summary>
    public required string Uuid { get; set; }

    /// <summary>
    /// 业务请求标识。当一次业务请求需要多次调用发送API时可以设置此参数，方便后续跟踪处理。
    /// </summary>
    public string? BizRequestId { get; set; }

    /// <summary>
    /// 消息接收人列表，最多支持1000人。值为服务窗粉丝userid。
    /// </summary>
    public List<string> UserIdList { get; set; } = [];

    /// <summary>
    /// 消息体。
    /// </summary>
    public required ServiceWindowMessageBody MessageBody { get; set; }

    /// <summary>
    /// 全员群发。
    /// </summary>
    public bool? SendToAll { get; set; }
}

/// <summary>
/// 发送服务窗单人消息请求。
/// </summary>
public class ServiceWindowSendMessageRequest
{
    /// <summary>
    /// 消息详情。
    /// </summary>
    public required ServiceWindowMessageDetail Detail { get; set; }

    /// <summary>
    /// API调用标识，可不填。
    /// </summary>
    public string? BizId { get; set; }

    /// <summary>
    /// 账号id。
    /// </summary>
    public string? AccountId { get; set; }
}

/// <summary>
/// 服务窗单人消息详情。
/// </summary>
public class ServiceWindowMessageDetail
{
    /// <summary>
    /// 消息类型。
    /// </summary>
    public required string MsgType { get; set; }

    /// <summary>
    /// 消息发送请求唯一ID，长度不超过128位字符。
    /// </summary>
    public required string Uuid { get; set; }

    /// <summary>
    /// 消息接收人的userid。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 消息体。
    /// </summary>
    public required ServiceWindowMessageBody MessageBody { get; set; }
}

/// <summary>
/// 服务窗消息体。
/// </summary>
public class ServiceWindowMessageBody
{
    /// <summary>
    /// 文本消息内容。如果消息类型为文本消息则此参数必填。
    /// </summary>
    public ServiceWindowTextMessage? Text { get; set; }

    /// <summary>
    /// markdown消息，仅对消息类型为markdown时有效。
    /// </summary>
    public ServiceWindowMarkdownMessage? Markdown { get; set; }

    /// <summary>
    /// 链接消息类型。
    /// </summary>
    public ServiceWindowLinkMessage? Link { get; set; }

    /// <summary>
    /// 卡片消息。
    /// </summary>
    public ServiceWindowActionCardMessage? ActionCard { get; set; }
}

/// <summary>
/// 服务窗文本消息内容。
/// </summary>
public class ServiceWindowTextMessage
{
    /// <summary>
    /// 文本消息内容，建议500字符以内。
    /// </summary>
    public required string Content { get; set; }
}

/// <summary>
/// 服务窗 markdown 消息内容。
/// </summary>
public class ServiceWindowMarkdownMessage
{
    /// <summary>
    /// 首屏会话透出的展示内容。
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// markdown格式的消息，建议500字符以内。
    /// </summary>
    public required string Text { get; set; }
}

/// <summary>
/// 服务窗链接消息内容。
/// </summary>
public class ServiceWindowLinkMessage
{
    /// <summary>
    /// 图片地址。
    /// </summary>
    public required string PicUrl { get; set; }

    /// <summary>
    /// 消息链接地址，当发送消息为小程序时支持小程序跳转链接。
    /// </summary>
    public required string MessageUrl { get; set; }

    /// <summary>
    /// 消息标题，建议100字符以内。
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// 消息描述，建议500字符以内。
    /// </summary>
    public required string Text { get; set; }
}

/// <summary>
/// 服务窗卡片消息内容。
/// </summary>
public class ServiceWindowActionCardMessage
{
    /// <summary>
    /// 按钮排列方式。必须与buttonList同时设置。
    /// </summary>
    public string? ButtonOrientation { get; set; }

    /// <summary>
    /// 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接，最长500个字符。
    /// </summary>
    public string? SingleUrl { get; set; }

    /// <summary>
    /// 使用整体跳转ActionCard样式时的标题。必须与singleUrl同时设置，最长20个字符。
    /// </summary>
    public string? SingleTitle { get; set; }

    /// <summary>
    /// 消息内容，支持markdown。语法参考标准markdown语法，1000个字符以内。
    /// </summary>
    public string? Markdown { get; set; }

    /// <summary>
    /// 透出到会话列表和通知的文案。
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// 使用独立跳转ActionCard样式时的按钮列表。必须与buttonOrientation同时设置，且长度不超过1000字符。
    /// </summary>
    public List<ServiceWindowActionCardButton> ButtonList { get; set; } = [];
}

/// <summary>
/// 服务窗卡片按钮。
/// </summary>
public class ServiceWindowActionCardButton
{
    /// <summary>
    /// 使用独立跳转ActionCard样式时的按钮的标题，最长20个字符。
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// 使用独立跳转ActionCard样式时的跳转链接。
    /// </summary>
    public required string ActionUrl { get; set; }
}

/// <summary>
/// 服务窗消息发送响应。
/// </summary>
public class ServiceWindowMessageSendResponse
{
    /// <summary>
    /// 请求ID。
    /// </summary>
    public string? RequestId { get; set; }

    /// <summary>
    /// 返回结果。
    /// </summary>
    public ServiceWindowMessageSendResult? Result { get; set; }
}

/// <summary>
/// 服务窗消息发送结果。
/// </summary>
public class ServiceWindowMessageSendResult
{
    /// <summary>
    /// 消息推送ID，长度不超过128位，可用于消息发送进度排查。
    /// </summary>
    public string? OpenPushId { get; set; }
}

/// <summary>
/// 企业下服务窗列表响应。
/// </summary>
public class ServiceWindowAccountListResponse
{
    /// <summary>
    /// 服务窗帐号列表。
    /// </summary>
    public List<ServiceWindowAccount> Result { get; set; } = [];
}

/// <summary>
/// 服务窗帐号信息。
/// </summary>
public class ServiceWindowAccount
{
    /// <summary>
    /// 服务窗帐号ID。
    /// </summary>
    public string? AccountId { get; set; }

    /// <summary>
    /// 服务窗账号名称。
    /// </summary>
    public string? AccountName { get; set; }
}

/// <summary>
/// 批量获取关注服务窗用户信息响应。
/// </summary>
public class ServiceWindowFollowerListResponse
{
    /// <summary>
    /// 请求ID。
    /// </summary>
    public string? RequestId { get; set; }

    /// <summary>
    /// 响应结果。
    /// </summary>
    public required ServiceWindowFollowerListResult Result { get; set; }
}

/// <summary>
/// 关注服务窗用户分页结果。
/// </summary>
public class ServiceWindowFollowerListResult
{
    /// <summary>
    /// 分页游标。当此返回值为空时，说明全部数据查询完成。
    /// </summary>
    public string? NextToken { get; set; }

    /// <summary>
    /// 关注服务窗的用户信息列表。
    /// </summary>
    public List<ServiceWindowFollower> UserList { get; set; } = [];
}

/// <summary>
/// 获取关注服务窗用户信息响应。
/// </summary>
public class ServiceWindowFollowerInfoResponse
{
    /// <summary>
    /// 请求ID。
    /// </summary>
    public string? RequestId { get; set; }

    /// <summary>
    /// 响应结果。
    /// </summary>
    public required ServiceWindowFollowerInfoResult Result { get; set; }
}

/// <summary>
/// 关注服务窗用户详情结果。
/// </summary>
public class ServiceWindowFollowerInfoResult
{
    /// <summary>
    /// 关注服务窗的用户详情。
    /// </summary>
    public required ServiceWindowFollower User { get; set; }
}

/// <summary>
/// 关注服务窗用户信息。
/// </summary>
public class ServiceWindowFollower
{
    /// <summary>
    /// 用户userId，可用于消息推送等场景。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 用户姓名。
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 关注时间戳，单位毫秒，可能为空。
    /// </summary>
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public long? Timestamp { get; set; }
}
