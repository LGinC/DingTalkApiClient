using System.Text.Json.Serialization;

namespace DingTalkApi.Models.IM.Robot;

/// <summary>
/// 撤回已发送DING消息请求
/// </summary>
public class RecallDingMessage
{
    /// <summary>
    /// 初始化 <see cref="RecallDingMessage"/> 类的新实例
    /// </summary>
    public RecallDingMessage() { }

    /// <summary>
    /// 初始化 <see cref="RecallDingMessage"/> 类的新实例
    /// </summary>
    /// <param name="robotCode">机器人的robotCode</param>
    /// <param name="openDingId">ding消息ID</param>
    public RecallDingMessage(string robotCode, string openDingId)
    {
        RobotCode = robotCode;
        OpenDingId = openDingId;
    }

    /// <summary>
    /// 机器人代码
    /// </summary>
    [JsonPropertyName("robotCode")]
    public string RobotCode { get; set; } = string.Empty;

    /// <summary>
    /// ding消息ID
    /// </summary>
    [JsonPropertyName("openDingId")]
    public string OpenDingId { get; set; } = string.Empty;
}

/// <summary>
/// 撤回DING消息响应
/// </summary>
public class RecallDingMessageResponse : DingTalkResult
{
    /// <summary>
    /// 已撤回的ding消息ID
    /// </summary>
    [JsonPropertyName("openDingId")]
    public string OpenDingId { get; set; } = string.Empty;
}