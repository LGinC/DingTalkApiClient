using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DingTalkApi.Models.IM.Robot;

/// <summary>
/// 批量查询人与机器人会话机器人消息是否已读请求
/// </summary>
public class QueryPrivateChatMessagesRequest
{
    /// <summary>
    /// 初始化 <see cref="QueryPrivateChatMessagesRequest"/> 类的新实例
    /// </summary>
    public QueryPrivateChatMessagesRequest() { }

    /// <summary>
    /// 初始化 <see cref="QueryPrivateChatMessagesRequest"/> 类的新实例
    /// </summary>
    /// <param name="robotCode">机器人的编码</param>
    /// <param name="processQueryKey">查询凭证，来自发送消息的响应</param>
    /// <param name="openConversationId">人与人单聊开放会话ID</param>
    /// <param name="maxResults">单页查询数量</param>
    /// <param name="nextToken">分页游标</param>
    public QueryPrivateChatMessagesRequest(string robotCode, string processQueryKey, string? openConversationId = null, int maxResults = 50, string? nextToken = null)
    {
        RobotCode = robotCode;
        ProcessQueryKey = processQueryKey;
        OpenConversationId = openConversationId;
        MaxResults = maxResults;
        NextToken = nextToken;
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

    /// <summary>
    /// 人与人单聊开放会话ID
    /// </summary>
    [JsonPropertyName("openConversationId")]
    public string? OpenConversationId { get; set; }

    /// <summary>
    /// 单页查询数量
    /// </summary>
    [JsonPropertyName("maxResults")]
    public int MaxResults { get; set; } = 50;

    /// <summary>
    /// 分页游标
    /// </summary>
    [JsonPropertyName("nextToken")]
    public string? NextToken { get; set; }
}

/// <summary>
/// 批量查询人与机器人会话机器人消息是否已读响应
/// </summary>
public class QueryPrivateChatMessagesResponse : DingTalkResult
{
    /// <summary>
    /// 是否有下一页
    /// </summary>
    [JsonPropertyName("hasMore")]
    public bool HasMore { get; set; }

    /// <summary>
    /// 分页游标
    /// </summary>
    [JsonPropertyName("nextToken")]
    public string? NextToken { get; set; }

    /// <summary>
    /// 已读用户列表
    /// </summary>
    [JsonPropertyName("readUserIds")]
    public IEnumerable<string>? ReadUserIds { get; set; }
}
