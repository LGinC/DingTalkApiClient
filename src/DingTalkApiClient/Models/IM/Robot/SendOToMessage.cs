using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models.IM.Robot;

/// <summary>
/// 人与人会话中机器人发送普通消息请求
/// </summary>
public class SendOToMessageRequest
{
    /// <summary>
    /// 初始化 <see cref="SendOToMessageRequest"/> 类的新实例
    /// </summary>
    public SendOToMessageRequest() { }

    /// <summary>
    /// 初始化 <see cref="SendOToMessageRequest"/> 类的新实例
    /// </summary>
    /// <param name="robotCode">机器人的编码</param>
    /// <param name="openConversationId">人与人单聊开放会话ID</param>
    /// <param name="msgKey">消息模板标识</param>
    /// <param name="msgParam">消息模板参数</param>
    /// <param name="coolAppCode">酷应用编码</param>
    public SendOToMessageRequest(string robotCode, string openConversationId, string msgKey, string msgParam, string? coolAppCode = null)
    {
        RobotCode = robotCode;
        OpenConversationId = openConversationId;
        MsgKey = msgKey;
        MsgParam = msgParam;
        CoolAppCode = coolAppCode;
    }

    /// <summary>
    /// 机器人的编码
    /// </summary>
    [JsonPropertyName("robotCode")]
    public string RobotCode { get; set; } = string.Empty;

    /// <summary>
    /// 人与人单聊开放会话ID
    /// </summary>
    [JsonPropertyName("openConversationId")]
    public string OpenConversationId { get; set; } = string.Empty;

    /// <summary>
    /// 消息模板标识
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
/// 人与人会话中机器人发送普通消息响应
/// </summary>
public class SendOToMessageResponse : DingTalkResult
{
    /// <summary>
    /// 消息发送的进度查询Key
    /// </summary>
    [JsonPropertyName("processQueryKey")]
    public string ProcessQueryKey { get; set; } = string.Empty;
}
