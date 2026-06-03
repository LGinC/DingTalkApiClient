using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models;
using DingTalkApiClient.Models.ApplicationManagement;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.ApplicationManagement;

/// <summary>
/// 应用管理api
/// </summary>
public interface IApplicationManagementApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 创建企业内部应用
    /// </summary>
    [HttpPost("/v1.0/microApp/apps")]
    ITask<CreateInnerAppResponse> CreateInnerAppAsync([JsonContent] CreateInnerAppRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新企业内部应用
    /// </summary>
    [HttpPut("/v1.0/microApp/apps/{agentId}")]
    ITask<DingTalkResult<bool>> UpdateInnerAppAsync([PathQuery] string agentId, [JsonContent] UpdateInnerAppRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除企业内部应用
    /// </summary>
    [HttpDelete("/v1.0/microApp/apps/{agentId}")]
    ITask<DingTalkResult<bool>> DeleteInnerAppAsync([PathQuery] string agentId, string opUnionId, string? ecologicalCorpId = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取企业所有应用列表
    /// </summary>
    [HttpGet("/v1.0/microApp/allApps")]
    ITask<ApplicationListResponse> ListAllAppsAsync([DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 发布企业内部小程序版本
    /// </summary>
    [HttpPost("/v1.0/microApp/innerMiniApps/{agentId}/versions/publish")]
    ITask<DingTalkResult<bool>> PublishInnerMiniAppVersionAsync([PathQuery] string agentId, [JsonContent] PublishInnerMiniAppVersionRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 回滚企业内部小程序版本
    /// </summary>
    [HttpPost("/v1.0/microApp/innerMiniApps/{agentId}/versions/rollback")]
    ITask<DingTalkResult<bool>> RollbackInnerMiniAppVersionAsync([PathQuery] string agentId, [JsonContent] RollbackInnerMiniAppVersionRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取企业内部所有应用列表
    /// </summary>
    [HttpGet("/v1.0/microApp/allInnerApps")]
    ITask<ApplicationListResponse> ListAllInnerAppsAsync([DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取用户可见的企业应用列表
    /// </summary>
    [HttpGet("/v1.0/microApp/users/{userId}/apps")]
    ITask<ApplicationListResponse> ListUserVisibleAppsAsync([PathQuery] string userId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取企业内部小程序的版本列表
    /// </summary>
    [HttpGet("/v1.0/microApp/innerMiniApps/{agentId}/versions")]
    ITask<InnerMiniAppVersionListResponse> ListInnerMiniAppVersionsAsync([PathQuery] string agentId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取企业内部小程序历史版本列表
    /// </summary>
    [HttpGet("/v1.0/microApp/innerMiniApps/{agentId}/historyVersions")]
    ITask<InnerMiniAppHistoryVersionListResponse> ListInnerMiniAppHistoryVersionsAsync([PathQuery] string agentId, string? pageNumber = null, string? pageSize = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新企业内部应用微应用的可使用范围
    /// </summary>
    [HttpPost("/v1.0/microApp/apps/{agentId}/scopes")]
    ITask<DingTalkResult<bool>> SetInnerAppScopeAsync([PathQuery] string agentId, [JsonContent] SetInnerAppScopeRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取企业内部应用微应用的可使用范围
    /// </summary>
    [HttpGet("/v1.0/microApp/apps/{agentId}/scopes")]
    ITask<DingTalkResult<InnerAppScope>> GetInnerAppScopeAsync([PathQuery] string agentId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
