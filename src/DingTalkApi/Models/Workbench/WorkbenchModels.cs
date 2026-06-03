namespace DingTalkApi.Models.Workbench;

/// <summary>
/// 批量添加最近使用应用请求。
/// </summary>
public class BatchAddRecentUsedAppsRequest
{
    /// <summary>
    /// 组织corpId。
    /// </summary>
    public required string CorpId { get; set; }

    /// <summary>
    /// 最近使用应用列表。
    /// </summary>
    public required List<RecentUsedAppDetail> UsedAppDetailList { get; set; }

    /// <summary>
    /// 员工userId。
    /// </summary>
    public required string UserId { get; set; }
}

/// <summary>
/// 最近使用应用详情。
/// </summary>
public class RecentUsedAppDetail
{
    /// <summary>
    /// 组织开通的应用Id，可通过调用获取企业所有应用列表接口获取返回参数agentId字段。
    /// </summary>
    public required string AgentId { get; set; }
}
