using System.Collections.Generic;
using System.Text.Json.Serialization;
using DingTalkApiClient.Enums;

namespace DingTalkApiClient.Models.IM.Robot;

/// <summary>
/// 发送DING消息请求
/// </summary>
public class DingMessage
{
    /// <summary>
    /// 初始化 <see cref="DingMessage"/> 类的新实例
    /// </summary>
    public DingMessage() { }

    /// <summary>
    /// 初始化 <see cref="DingMessage"/> 类的新实例
    /// </summary>
    /// <param name="robotCode">机器人的robotCode</param>
    /// <param name="remindType">提醒类型</param>
    /// <param name="receiverUserIdList">接收人userId列表</param>
    /// <param name="content">DING消息内容</param>
    /// <param name="callVoice">电话音色</param>
    public DingMessage(string robotCode, DingRemindType remindType, string[] receiverUserIdList, string content, string? callVoice = null)
    {
        RobotCode = robotCode;
        RemindType = remindType;
        ReceiverUserIdList = receiverUserIdList;
        Content = content;
        CallVoice = callVoice;
    }

    /// <summary>
    /// 发DING消息的机器人ID
    /// </summary>
    [JsonPropertyName("robotCode")]
    public string RobotCode { get; set; } = string.Empty;

    /// <summary>
    /// DING消息类型
    /// </summary>
    [JsonPropertyName("remindType")]
    public DingRemindType RemindType { get; set; }

    /// <summary>
    /// 接收人userId列表
    /// <list type="bullet"><item>应用内DING消息，每次接收人不能超过200个</item>
    /// <item>短信DING和电话DING，每次接收人不能超过20个</item></list>
    /// </summary>
    [JsonPropertyName("receiverUserIdList")]
    public string[] ReceiverUserIdList { get; set; } = [];

    /// <summary>
    /// DING消息内容
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// 电话音色，非电话DING该字段无效。
    /// </summary>
    [JsonPropertyName("callVoice")]
    public string? CallVoice { get; set; }
}

/// <summary>
/// DING消息响应
/// </summary>
public class DingMessageResponse : DingTalkResult
{
    /// <summary>
    /// DING消息id
    /// </summary>
    [JsonPropertyName("openDingId")]
    public string OpenDingId { get; set; } = string.Empty;

    /// <summary>
    /// 失败列表
    /// </summary>
    [JsonPropertyName("failedList")]
    public Dictionary<string, string[]>? FailedList { get; set; }
}