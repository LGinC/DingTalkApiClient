using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models;
using DingTalkApiClient.Models.OrgCulture;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.OrgCulture;

/// <summary>
/// 企业文化api
/// </summary>
public interface IOrgCultureApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 给员工颁发荣誉
    /// </summary>
    [HttpPost("/v1.0/orgCulture/honors/{honorId}/grant")]
    ITask<DingTalkResult> GrantHonorAsync([PathQuery] string honorId, [JsonContent] GrantHonorRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询员工已获得的组织荣誉
    /// </summary>
    [HttpGet("/v1.0/orgCulture/honors/users/{userId}")]
    ITask<QueryUserHonorsResponse> QueryUserHonorsAsync([PathQuery] string userId, string nextToken, string? maxResults = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询当前企业下可颁发的荣誉列表
    /// </summary>
    [HttpGet("/v1.0/orgCulture/organizations/honors")]
    ITask<QueryOrgHonorsResponse> QueryOrgHonorsAsync(string nextToken, string? maxResults = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建荣誉勋章模板
    /// </summary>
    [HttpPost("/v1.0/orgCulture/honors/templates")]
    ITask<CreateHonorTemplateResponse> CreateHonorTemplateAsync([JsonContent] CreateHonorTemplateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 撤销员工获得的荣誉勋章
    /// </summary>
    [HttpPost("/v1.0/orgCulture/honors/{honorId}/recall")]
    ITask<RecallHonorResponse> RecallHonorAsync([PathQuery] string honorId, [JsonContent] RecallHonorRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 新增词条
    /// </summary>
    [HttpPost("/v1.0/pedia/words")]
    ITask<PediaWordMutationResponse> AddPediaWordAsync([JsonContent] AddPediaWordRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新词条
    /// </summary>
    [HttpPut("/v1.0/pedia/words")]
    ITask<PediaWordMutationResponse> UpdatePediaWordAsync([JsonContent] UpdatePediaWordRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除词条
    /// </summary>
    [HttpDelete("/v1.0/pedia/words")]
    ITask<PediaWordMutationResponse> DeletePediaWordAsync(string uuid, string userId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 审核词条
    /// </summary>
    [HttpPost("/v1.0/pedia/words/approve")]
    ITask<PediaWordApproveResponse> ApprovePediaWordAsync([JsonContent] ApprovePediaWordRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询词条详情
    /// </summary>
    [HttpGet("/v1.0/wiki/words/details")]
    ITask<WikiWordDetailsResponse> GetWikiWordDetailsAsync(string wordName, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 根据词条ID查询详情
    /// </summary>
    [HttpPost("/v1.0/pedia/words/query")]
    ITask<PediaWordDetailResponse> QueryPediaWordAsync(string uuid, string userId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 分页获取企业词条信息
    /// </summary>
    [HttpPost("/v1.0/pedia/words/search")]
    ITask<PediaWordDetailResponse> SearchPediaWordsAsync([JsonContent] SearchPediaWordsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 匹配文本中的词条
    /// </summary>
    [HttpPost("/v1.0/wiki/words/parse")]
    ITask<ParseWikiWordsResponse> ParseWikiWordsAsync([JsonContent] ParseWikiWordsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}

/// <summary>
/// 企业文化钉钉运动api
/// </summary>
public interface IOrgCultureHealthApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 查询用户是否参与企业步数排行榜
    /// </summary>
    [HttpPost("/topapi/health/stepinfo/getuserstatus")]
    ITask<GetUserStepStatusResponse> GetUserStepStatusAsync([JsonContent] GetUserStepStatusRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
