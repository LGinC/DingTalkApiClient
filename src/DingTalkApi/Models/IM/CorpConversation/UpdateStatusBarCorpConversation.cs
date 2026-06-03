using System.Text.Json.Serialization;

namespace DingTalkApi.Models.IM.CorpConversation;

/// <summary>
/// 更新工作通知状态栏请求
/// </summary>
public class UpdateStatusBarCorpConversationRequest
{
    /// <summary>
    /// 初始化 <see cref="UpdateStatusBarCorpConversationRequest"/> 类的新实例
    /// </summary>
    public UpdateStatusBarCorpConversationRequest() { }

    /// <summary>
    /// 初始化 <see cref="UpdateStatusBarCorpConversationRequest"/> 类的新实例
    /// </summary>
    /// <param name="agentId">发送消息时使用的微应用的AgentID</param>
    /// <param name="taskId">发送消息时返回的task_id</param>
    /// <param name="statusValue">状态栏值</param>
    /// <param name="statusBg">状态栏背景色，推荐0xFF0000</param>
    public UpdateStatusBarCorpConversationRequest(long agentId, long taskId, string statusValue, string statusBg)
    {
        AgentId = agentId;
        TaskId = taskId;
        StatusValue = statusValue;
        StatusBg = statusBg;
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

    /// <summary>
    /// 状态栏值
    /// </summary>
    [JsonPropertyName("status_value")] 
    public string StatusValue { get; set; } = string.Empty;

    /// <summary>
    /// 状态栏背景色，推荐0xFF0000
    /// </summary>
    [JsonPropertyName("status_bg")] 
    public string StatusBg { get; set; } = string.Empty;
}
