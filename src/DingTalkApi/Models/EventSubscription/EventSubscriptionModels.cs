using System.Text.Json;
using System.Text.Json.Serialization;
using DingTalkApi.Models;

namespace DingTalkApi.Models.EventSubscription;

/// <summary>
/// 获取推送失败的事件列表响应。
/// </summary>
public class GetCallbackFailedResultResponse : DingTalkResult
{
    /// <summary>
    /// 推送失败的事件列表，一次最多200个。
    /// </summary>
    public List<CallbackFailedEvent> FailedList { get; set; } = [];

    /// <summary>
    /// 是否还有推送失败的变更事件，若为true，则表示还有未回调的事件。
    /// </summary>
    public bool HasMore { get; set; }
}

/// <summary>
/// 推送失败的事件。
/// </summary>
public class CallbackFailedEvent
{
    /// <summary>
    /// 用户加入企业事件。
    /// </summary>
    public CallbackUserAddOrgEvent? UserAddOrg { get; set; }

    /// <summary>
    /// 事件类型。
    /// </summary>
    public required string CallBackTag { get; set; }

    /// <summary>
    /// 事件的时间戳。
    /// </summary>
    public long EventTime { get; set; }

    /// <summary>
    /// 审批实例变更事件。
    /// </summary>
    public CallbackBpmsInstanceChangeEvent? BpmsInstanceChange { get; set; }

    /// <summary>
    /// 角色标签配置新增事件。
    /// </summary>
    public CallbackLabelConfAddEvent? LabelConfAdd { get; set; }
}

/// <summary>
/// 用户加入企业事件。
/// </summary>
public class CallbackUserAddOrgEvent
{
    /// <summary>
    /// 员工userid列表。
    /// </summary>
    public List<string> Userid { get; set; } = [];

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    public required string Corpid { get; set; }
}

/// <summary>
/// 审批实例变更事件。
/// </summary>
public class CallbackBpmsInstanceChangeEvent
{
    /// <summary>
    /// 审批回调数据。
    /// </summary>
    [JsonPropertyName("bpmsCallBackData")]
    public JsonElement BpmsCallBackData { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    public required string Corpid { get; set; }
}

/// <summary>
/// 角色标签配置新增事件。
/// </summary>
public class CallbackLabelConfAddEvent
{
    /// <summary>
    /// 角色标签变更数据。
    /// </summary>
    [JsonPropertyName("roleLabelChange")]
    public JsonElement RoleLabelChange { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    public required string Corpid { get; set; }
}
