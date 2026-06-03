using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models;
using DingTalkApiClient.Models.Contacts.CooperateCorps;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.Contacts;

/// <summary>
/// 上下游和上下级组织api
/// </summary>
public interface ICooperateCorpsApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 创建上下游组织
    /// </summary>
    [HttpPost("/v1.0/contact/cooperateCorps")]
    ITask<CooperateCorpCreateResponse> CreateCooperateCorpAsync([JsonContent] CooperateCorpCreateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 解除关联组织
    /// </summary>
    [HttpPost("/v1.0/contact/cooperateCorps/separate")]
    ITask<CooperateCorpSeparateResponse> SeparateCooperateCorpAsync([JsonContent] CooperateCorpSeparateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取上下游组织的邀请信息
    /// </summary>
    [HttpGet("/v1.0/contact/cooperateCorps/{cooperateCorpId}/inviteInfos")]
    ITask<CooperateCorpInviteInfoResponse> GetCooperateCorpInviteInfoAsync([PathQuery] string cooperateCorpId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量通过伙伴组织的加入申请
    /// </summary>
    [HttpPost("/v1.0/contact/cooperateCorps/unionApplications/approve")]
    ITask<UnionApplicationApproveResponse> ApproveUnionApplicationsAsync([JsonContent] List<UnionApplicationApproveRequestItem> request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新分支组织在主干组织内的属性信息
    /// </summary>
    [HttpPut("/v1.0/contact/cooperateCorps/branchAttributes")]
    ITask<DingTalkResult> UpdateBranchAttributesAsync([JsonContent] List<BranchAttributeUpdateRequestItem> request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 设置分支组织在主干组织内的可见范围
    /// </summary>
    [HttpPut("/v1.0/contact/cooperateCorps/branchVisibleSettings")]
    ITask<DingTalkResult> UpdateBranchVisibleSettingsAsync([JsonContent] List<BranchVisibleSettingUpdateRequestItem> request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取上下级组织分支授权的数据
    /// </summary>
    [HttpPost("/v1.0/contact/branchAuthDatas/search")]
    ITask<BranchAuthDataSearchResponse> SearchBranchAuthDatasAsync(string branchCorpId, string code, [JsonContent] BranchAuthDataSearchRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
