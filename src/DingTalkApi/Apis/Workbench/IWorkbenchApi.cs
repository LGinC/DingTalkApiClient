using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.Workbench;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.Workbench;

/// <summary>
/// 工作台api
/// </summary>
public interface IWorkbenchApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 批量添加最近使用应用
    /// </summary>
    [HttpPost("/v1.0/workbench/components/recentUsed/batch")]
    ITask<DingTalkResult<bool>> BatchAddRecentUsedAppsAsync([JsonContent] BatchAddRecentUsedAppsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
