using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models.IM.CorpConversation;

/// <summary>
/// 获取工作通知消息的发送结果请求
/// </summary>
public class GetSendResultCorpConversationRequest
{
    /// <summary>
    /// 初始化 <see cref="GetSendResultCorpConversationRequest"/> 类的新实例
    /// </summary>
    public GetSendResultCorpConversationRequest() { }

    /// <summary>
    /// 初始化 <see cref="GetSendResultCorpConversationRequest"/> 类的新实例
    /// </summary>
    /// <param name="agentId">发送消息时使用的微应用的AgentID</param>
    /// <param name="taskId">发送消息时返回的task_id</param>
    public GetSendResultCorpConversationRequest(long agentId, long taskId)
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
/// 获取工作通知消息的发送结果响应
/// </summary>
public class GetSendResultCorpConversationResponse : DingTalkResult
{
    /// <summary>
    /// 发送结果对象
    /// </summary>
    [JsonPropertyName("send_result")]
    public SendResultObj? SendResult { get; set; }

    /// <summary>
    /// 发送结果对象详情
    /// </summary>
    public class SendResultObj
    {
        /// <summary>
        /// 无效的用户ID列表
        /// </summary>
        [JsonPropertyName("invalid_user_id_list")]
        public IEnumerable<string>? InvalidUserIdList { get; set; }
        
        /// <summary>
        /// 被禁止发送的用户ID列表
        /// </summary>
        [JsonPropertyName("forbidden_user_id_list")]
        public IEnumerable<string>? ForbiddenUserIdList { get; set; }
        
        /// <summary>
        /// 发送失败的用户ID列表
        /// </summary>
        [JsonPropertyName("failed_user_id_list")]
        public IEnumerable<string>? FailedUserIdList { get; set; }
        
        /// <summary>
        /// 已读的用户ID列表
        /// </summary>
        [JsonPropertyName("read_user_id_list")]
        public IEnumerable<string>? ReadUserIdList { get; set; }
        
        /// <summary>
        /// 未读的用户ID列表
        /// </summary>
        [JsonPropertyName("unread_user_id_list")]
        public IEnumerable<string>? UnreadUserIdList { get; set; }
        
        /// <summary>
        /// 无效的部门ID列表
        /// </summary>
        [JsonPropertyName("invalid_dept_id_list")]
        public IEnumerable<string>? InvalidDeptIdList { get; set; }
    }
}
