using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models.IM.CorpConversation;

/// <summary>
/// 使用模板发送工作通知消息请求
/// </summary>
public class SendByTemplateCorpConversationRequest
{
    /// <summary>
    /// 初始化 <see cref="SendByTemplateCorpConversationRequest"/> 类的新实例
    /// </summary>
    public SendByTemplateCorpConversationRequest() { }

    /// <summary>
    /// 初始化 <see cref="SendByTemplateCorpConversationRequest"/> 类的新实例
    /// </summary>
    /// <param name="agentId">应用agentId</param>
    /// <param name="templateId">消息模板ID</param>
    /// <param name="userIdList">接收者的userid列表</param>
    /// <param name="data">动态参数内容，JSON字符串格式</param>
    public SendByTemplateCorpConversationRequest(long agentId, string templateId, string userIdList, string data)
    {
        AgentId = agentId;
        TemplateId = templateId;
        UserIdList = userIdList;
        Data = data;
    }

    /// <summary>
    /// 应用agentId
    /// </summary>
    [JsonPropertyName("agent_id")] 
    public long AgentId { get; set; }

    /// <summary>
    /// 消息模板ID
    /// </summary>
    [JsonPropertyName("template_id")] 
    public string TemplateId { get; set; } = string.Empty;

    /// <summary>
    /// 接收者的userid列表
    /// </summary>
    [JsonPropertyName("userid_list")] 
    public string UserIdList { get; set; } = string.Empty;

    /// <summary>
    /// 动态参数内容，JSON字符串格式
    /// </summary>
    [JsonPropertyName("data")] 
    public string Data { get; set; } = string.Empty;
}

/// <summary>
/// 使用模板发送工作通知消息响应
/// </summary>
public class SendByTemplateCorpConversationResponse : DingTalkResult
{
    /// <summary>
    /// 创建的异步发送任务ID
    /// </summary>
    [JsonPropertyName("task_id")]
    public long TaskId { get; set; }
}
