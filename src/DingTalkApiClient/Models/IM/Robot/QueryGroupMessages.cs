using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models.IM.Robot;

/// <summary>
/// 查询企业机器人群聊消息用户已读状态请求
/// </summary>
public class QueryGroupMessagesRequest
{
    /// <summary>
    /// 初始化 <see cref="QueryGroupMessagesRequest"/> 类的新实例
    /// </summary>
    public QueryGroupMessagesRequest() { }

    /// <summary>
    /// 初始化 <see cref="QueryGroupMessagesRequest"/> 类的新实例
    /// </summary>
    /// <param name="robotCode">机器人的编码</param>
    /// <param name="processQueryKey">查询凭证，来自发送消息的响应</param>
    /// <param name="openConversationId">群开放会话ID</param>
    /// <param name="maxResults">分页查询每页的数量，最大200</param>
    /// <param name="nextToken">分页游标</param>
    public QueryGroupMessagesRequest(string robotCode, string processQueryKey, string? openConversationId = null, long maxResults = 50, string? nextToken = null)
    {
        RobotCode = robotCode;
        ProcessQueryKey = processQueryKey;
        OpenConversationId = openConversationId;
        MaxResults = maxResults;
        NextToken = nextToken;
    }

    /// <summary>
    /// 群ID
    /// </summary>
    [JsonPropertyName("openConversationId")]
    public string? OpenConversationId { get; set; }

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
    /// 分页查询每页的数量，最大值200
    /// </summary>
    [JsonPropertyName("maxResults")]
    public long MaxResults { get; set; } = 50;

    /// <summary>
    /// 分页游标
    /// </summary>
    [JsonPropertyName("nextToken")]
    public string? NextToken { get; set; }
}

/// <summary>
/// 查询群聊消息已读状态响应
/// </summary>
public class QueryGroupMessagesResponse : DingTalkResult
{
    /// <summary>
    /// 消息发送状态
    /// </summary>
    [JsonPropertyName("sendStatus")]
    public string? SendStatus { get; set; }

    /// <summary>
    /// 消息已读人的userId列表
    /// </summary>
    [JsonPropertyName("readUserIds")]
    public IEnumerable<string>? ReadUserIds { get; set; }

    /// <summary>
    /// 下次分页查询的游标
    /// </summary>
    [JsonPropertyName("nextToken")]
    public string? NextToken { get; set; }

    /// <summary>
    /// 分页查询是否还有人员可查询
    /// </summary>
    [JsonPropertyName("hasMore")]
    public bool HasMore { get; set; }
}
