using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models.IM.Robot;

/// <summary>
/// 查询人与人会话中机器人消息已读状态请求
/// </summary>
public class QueryOtoMessageReadStatusRequest
{
    /// <summary>
    /// 初始化 <see cref="QueryOtoMessageReadStatusRequest"/> 类的新实例
    /// </summary>
    public QueryOtoMessageReadStatusRequest() { }

    /// <summary>
    /// 初始化 <see cref="QueryOtoMessageReadStatusRequest"/> 类的新实例
    /// </summary>
    /// <param name="robotCode">机器人的编码</param>
    /// <param name="processQueryKey">查询凭证，来自发送消息的响应</param>
    public QueryOtoMessageReadStatusRequest(string robotCode, string processQueryKey)
    {
        RobotCode = robotCode;
        ProcessQueryKey = processQueryKey;
    }

    /// <summary>
    /// 机器人的编码
    /// </summary>
    [JsonPropertyName("robotCode")]
    public string RobotCode { get; set; } = string.Empty;

    /// <summary>
    /// 查询凭证，来自发送消息的响应
    /// </summary>
    [JsonPropertyName("processQueryKey")]
    public string ProcessQueryKey { get; set; } = string.Empty;
}

/// <summary>
/// 查询人与人会话中机器人消息已读状态响应
/// </summary>
public class QueryOtoMessageReadStatusResponse : DingTalkResult
{
    /// <summary>
    /// 是否成功
    /// </summary>
    public new bool IsSuccess => base.IsSuccess && SendStatus == "SUCCESS";

    /// <summary>
    /// 发送状态 
    /// <list type="bullet">
    /// <item>SUCCESS：成功</item>
    /// <item>RECALLED：已撤回</item>
    /// <item>PROCESSING：处理中</item>
    /// </list>
    /// </summary>
    [JsonPropertyName("sendStatus")]
    public string? SendStatus { get; set; }

    /// <summary>
    /// 消息已读信息列表
    /// </summary>
    [JsonPropertyName("messageReadInfoList")]
    public IEnumerable<OtoMessageReadInfo>? MessageReadInfoList { get; set; }
}

/// <summary>
/// 消息已读信息
/// </summary>
public class OtoMessageReadInfo
{
    /// <summary>
    /// 用户名称
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 用户ID
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 已读状态
    /// <list type="bullet">
    /// <item>READ：已读</item>
    /// <item>UNREAD：未读</item>
    /// </list>
    /// </summary>
    [JsonPropertyName("readStatus")]
    public string? ReadStatus { get; set; }

    /// <summary>
    /// 已读 时间戳
    /// </summary>
    [JsonPropertyName("readTimestamp")]
    public long ReadTimestamp { get; set; }
}
