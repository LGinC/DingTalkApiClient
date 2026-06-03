using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models.IM.Robot;

/// <summary>
/// 机器人发送群聊消息请求
/// </summary>
public class SendGroupMessageRequest
{
    /// <summary>
    /// 初始化 <see cref="SendGroupMessageRequest"/> 类的新实例
    /// </summary>
    public SendGroupMessageRequest() { }

    /// <summary>
    /// 初始化 <see cref="SendGroupMessageRequest"/> 类的新实例
    /// </summary>
    /// <param name="robotCode">机器人的唯一编码</param>
    /// <param name="openConversationId">开放的群ID</param>
    /// <param name="msgKey">消息模板Key</param>
    /// <param name="msgParam">消息模板参数</param>
    /// <param name="coolAppCode">酷应用编码</param>
    public SendGroupMessageRequest(string robotCode, string openConversationId, string msgKey, string msgParam, string? coolAppCode = null)
    {
        RobotCode = robotCode;
        OpenConversationId = openConversationId;
        MsgKey = msgKey;
        MsgParam = msgParam;
        CoolAppCode = coolAppCode;
    }

    /// <summary>
    /// 机器人的唯一编码
    /// </summary>
    [JsonPropertyName("robotCode")]
    public string RobotCode { get; set; } = string.Empty;

    /// <summary>
    /// 开放的群ID
    /// </summary>
    [JsonPropertyName("openConversationId")]
    public string OpenConversationId { get; set; } = string.Empty;

    /// <summary>
    /// 消息模板Key
    /// </summary>
    [JsonPropertyName("msgKey")]
    public string MsgKey { get; set; } = string.Empty;

    /// <summary>
    /// 消息模板参数
    /// </summary>
    [JsonPropertyName("msgParam")]
    public string MsgParam { get; set; } = string.Empty;

    /// <summary>
    /// 酷应用编码
    /// </summary>
    [JsonPropertyName("coolAppCode")]
    public string? CoolAppCode { get; set; }
}

/// <summary>
/// 机器人发送群聊消息响应
/// </summary>
public class SendGroupMessageResponse : DingTalkResult
{
    /// <summary>
    /// 消息发送的进度查询Key
    /// </summary>
    [JsonPropertyName("processQueryKey")]
    public string ProcessQueryKey { get; set; } = string.Empty;
}
