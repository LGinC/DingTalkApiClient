using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models.IM.CorpConversation;

/// <summary>
/// 获取工作通知消息的发送进度请求
/// </summary>
public class GetSendProgressCorpConversationRequest
{
    /// <summary>
    /// 初始化 <see cref="GetSendProgressCorpConversationRequest"/> 类的新实例
    /// </summary>
    public GetSendProgressCorpConversationRequest() { }

    /// <summary>
    /// 初始化 <see cref="GetSendProgressCorpConversationRequest"/> 类的新实例
    /// </summary>
    /// <param name="agentId">发送消息时使用的微应用的AgentID</param>
    /// <param name="taskId">发送消息时返回的task_id</param>
    public GetSendProgressCorpConversationRequest(long agentId, long taskId)
    {
        AgentId = agentId;
        TaskId = taskId;
    }

    /// <summary>
    /// 发送消息时使用的微应用的AgentID
    /// </summary>
    [JsonPropertyName("agent_id")] 
    public long AgentId { get; set; }

    /// <summary>
    /// 发送消息时返回的task_id
    /// </summary>
    [JsonPropertyName("task_id")] 
    public long TaskId { get; set; }
}

/// <summary>
/// 获取工作通知消息的发送进度响应
/// </summary>
public class GetSendProgressCorpConversationResponse : DingTalkResult
{
    /// <summary>
    /// 进度对象
    /// </summary>
    [JsonPropertyName("progress")]
    public ProgressObj? Progress { get; set; }

    /// <summary>
    /// 进度详情对象
    /// </summary>
    public class ProgressObj
    {
        /// <summary>
        /// 发送进度百分比
        /// </summary>
        [JsonPropertyName("progress_in_percent")]
        public int ProgressInPercent { get; set; }
        
        /// <summary>
        /// 发送状态：0为初始化，1为处理中，2为处理完毕
        /// </summary>
        [JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
