using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models.IM.Robot;

/// <summary>
/// 批量发送人与机器人会话中机器人消息请求
/// </summary>
public class SendOToMessageBatchRequest
{
    /// <summary>
    /// 初始化 <see cref="SendOToMessageBatchRequest"/> 类的新实例
    /// </summary>
    public SendOToMessageBatchRequest() { }

    /// <summary>
    /// 初始化 <see cref="SendOToMessageBatchRequest"/> 类的新实例
    /// </summary>
    /// <param name="robotCode">机器人的robotCode</param>
    /// <param name="userIds">接收消息的用户userid列表</param>
    /// <param name="msgKey">消息模板的标识</param>
    /// <param name="msgParam">消息模板参数</param>
    public SendOToMessageBatchRequest(string robotCode, IEnumerable<string> userIds, string msgKey, string msgParam)
    {
        RobotCode = robotCode;
        UserIds = userIds;
        MsgKey = msgKey;
        MsgParam = msgParam;
    }

    /// <summary>
    /// 机器人的robotCode
    /// </summary>
    [JsonPropertyName("robotCode")]
    public string RobotCode { get; set; } = string.Empty;

    /// <summary>
    /// 接收消息的用户userid列表。最大不超过100个
    /// </summary>
    [JsonPropertyName("userIds")]
    public IEnumerable<string> UserIds { get; set; } = [];

    /// <summary>
    /// 消息模板的标识
    /// </summary>
    [JsonPropertyName("msgKey")]
    public string MsgKey { get; set; } = string.Empty;

    /// <summary>
    /// 消息模板参数
    /// </summary>
    [JsonPropertyName("msgParam")]
    public string MsgParam { get; set; } = string.Empty;
}

/// <summary>
/// 批量发送人与机器人会话中机器人消息响应
/// </summary>
public class SendOToMessageBatchResponse : DingTalkResult
{
    /// <summary>
    /// 消息发送的进度查询Key
    /// </summary>
    [JsonPropertyName("processQueryKey")]
    public string ProcessQueryKey { get; set; } = string.Empty;

    /// <summary>
    /// 无效的用户userid列表
    /// </summary>
    [JsonPropertyName("invalidStaffIdList")]
    public IEnumerable<string>? InvalidStaffIdList { get; set; }

    /// <summary>
    /// 受限的用户userid列表
    /// </summary>
    [JsonPropertyName("flowControlledStaffIdList")]
    public IEnumerable<string>? FlowControlledStaffIdList { get; set; }
}
