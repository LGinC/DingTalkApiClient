using DingTalkApi.Attributes;
using DingTalkApi.Models.HRM;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.HRM;

/// <summary>
/// 智能人事 v1.0 api
/// </summary>
public interface IHumanResourcesApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 获取企业职位列表
    /// </summary>
    [HttpPost("/v1.0/hrm/positions/query")]
    ITask<HrmPositionListResponse> QueryPositionsAsync([JsonContent] HrmPositionQueryRequest request, string nextToken, string maxResults, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取企业职级列表
    /// </summary>
    [HttpGet("/v1.0/hrm/jobRanks")]
    ITask<HrmJobRankListResponse> GetJobRanksAsync(string nextToken, string maxResults, string? rankCategoryId = null, string? rankCode = null, string? rankName = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取企业职务列表
    /// </summary>
    [HttpGet("/v1.0/hrm/jobs")]
    ITask<HrmJobListResponse> GetJobsAsync(string nextToken, string maxResults, string? jobName = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 新增或删除花名册选项类型字段的选项
    /// </summary>
    [HttpPut("/v1.0/hrm/rosters/meta/fields/options")]
    ITask<HrmBooleanResultResponse> UpdateRosterMetaFieldOptionsAsync([JsonContent] HrmRosterMetaFieldOptionsUpdateRequest request, string? appAgentId = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 添加待入职员工
    /// </summary>
    [HttpPost("/v1.0/hrm/preentries")]
    ITask<HrmPreentryCreateResponse> CreatePreentryAsync([JsonContent] HrmPreentryCreateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取离职员工列表
    /// </summary>
    [HttpGet("/v1.0/hrm/employees/dismissions")]
    ITask<HrmDismissionEmployeeListResponse> GetDismissionEmployeesAsync(string? nextToken = null, string? maxResults = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 修改已离职员工信息
    /// </summary>
    [HttpPut("/v1.0/hrm/processes/employees/terminations")]
    ITask<HrmBooleanResultResponse> UpdateTerminatedEmployeeAsync([JsonContent] HrmTerminatedEmployeeUpdateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量获取员工离职信息
    /// </summary>
    [HttpGet("/v1.0/hrm/employees/dimissionInfos")]
    ITask<HrmDimissionInfoListResponse> GetDimissionInfosAsync(string userIdList, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 智能人事员工调岗
    /// </summary>
    [HttpPost("/v1.0/hrm/processes/transfer")]
    ITask<HrmBooleanResultResponse> TransferEmployeeAsync([JsonContent] HrmEmployeeTransferRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 智能人事员工转正
    /// </summary>
    [HttpPost("/v1.0/hrm/processes/regulars/become")]
    ITask<HrmBooleanResultResponse> BecomeRegularAsync([JsonContent] HrmBecomeRegularRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}

/// <summary>
/// 智能人事 topapi
/// </summary>
public interface IHumanResourcesTopApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 获取花名册元数据
    /// </summary>
    [HttpPost("/topapi/smartwork/hrm/roster/meta/get")]
    ITask<HrmRosterMetaResponse> GetRosterMetaAsync([JsonContent] HrmAgentRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取花名册字段组详情
    /// </summary>
    [HttpPost("/topapi/smartwork/hrm/employee/field/grouplist")]
    ITask<HrmRosterFieldGroupResponse> GetRosterFieldGroupsAsync([JsonContent] HrmAgentRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取员工花名册字段信息
    /// </summary>
    [HttpPost("/topapi/smartwork/hrm/employee/v2/list")]
    ITask<HrmEmployeeRosterFieldListResponse> ListEmployeeRosterFieldsAsync([JsonContent] HrmEmployeeRosterFieldListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新员工花名册信息
    /// </summary>
    [HttpPost("/topapi/smartwork/hrm/employee/v2/update")]
    ITask<HrmTopBooleanResponse> UpdateEmployeeRosterAsync([JsonContent] HrmEmployeeRosterUpdateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取待入职员工列表
    /// </summary>
    [HttpPost("/topapi/smartwork/hrm/employee/querypreentry")]
    ITask<HrmPreentryListResponse> QueryPreentriesAsync([JsonContent] HrmCursorPageRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取在职员工列表
    /// </summary>
    [HttpPost("/topapi/smartwork/hrm/employee/queryonjob")]
    ITask<HrmOnJobEmployeeListResponse> QueryOnJobEmployeesAsync([JsonContent] HrmOnJobEmployeeListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 添加企业待入职员工
    /// </summary>
    [HttpPost("/topapi/smartwork/hrm/employee/addpreentry")]
    ITask<HrmTopPreentryCreateResponse> AddPreentryAsync([JsonContent] HrmTopPreentryCreateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
