using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models.IM.CorpConversation;

/// <summary>
/// 撤回工作通知消息请求
/// </summary>
public class RecallCorpConversationRequest
{
    /// <summary>
    /// 初始化 <see cref="RecallCorpConversationRequest"/> 类的新实例
    /// </summary>
    public RecallCorpConversationRequest() { }

    /// <summary>
    /// 初始化 <see cref="RecallCorpConversationRequest"/> 类的新实例
    /// </summary>
    /// <param name="agentId">发送消息时使用的微应用的AgentID</param>
    /// <param name="msgTaskId">发送消息时返回的task_id</param>
    public RecallCorpConversationRequest(long agentId, long msgTaskId)
    {
        AgentId = agentId;
        MsgTaskId = msgTaskId;
    }

    /// <summary>
    /// 发送消息时使用的微应用的AgentID
    /// </summary>
    [JsonPropertyName("agent_id")] 
    public long AgentId { get; set; }

    /// <summary>
    /// 发送消息时返回的task_id
    /// </summary>
    [JsonPropertyName("msg_task_id")] 
    public long MsgTaskId { get; set; }
}
