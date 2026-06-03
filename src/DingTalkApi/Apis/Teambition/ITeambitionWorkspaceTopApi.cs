using DingTalkApi.Attributes;
using DingTalkApi.Models.Teambition;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.Teambition;

/// <summary>
/// Teambition 工作区 topapi
/// </summary>
public interface ITeambitionWorkspaceTopApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 查询项目中文件操作日志
    /// </summary>
    [HttpPost("/topapi/workspace/auditlog/list")]
    ITask<TeambitionTopResult<TeambitionWorkspaceAuditLogListResult>> ListWorkspaceAuditLogsAsync([JsonContent] TeambitionWorkspaceAuditLogListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
