using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.Contacts.CooperateCorps;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.Contacts;

/// <summary>
/// 上下游组织oapi
/// </summary>
public interface IUnionCooperateApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 获取企业已经加入的或申请加入中的上下游组织的信息
    /// </summary>
    [HttpPost("/topapi/union/cooperate/joined/list")]
    ITask<UnionCooperateJoinedListResponse> GetJoinedCooperatesAsync([JsonContent] UnionCooperateJoinedListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取已加入或正在申请加入上下游组织的组织和个人信息
    /// </summary>
    [HttpPost("/topapi/union/cooperate/info/list")]
    ITask<UnionCooperateInfoListResponse> GetCooperateInfosAsync([JsonContent] UnionCooperateInfoListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取主干组织列表
    /// </summary>
    [HttpPost("/topapi/org/union/trunk/get")]
    ITask<UnionTrunkGetResponse> GetUnionTrunksAsync([DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取分支组织列表
    /// </summary>
    [HttpPost("/topapi/org/union/branch/get")]
    ITask<UnionBranchGetResponse> GetUnionBranchesAsync([JsonContent] UnionBranchGetRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
