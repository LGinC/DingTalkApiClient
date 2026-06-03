using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models;
using DingTalkApiClient.Models.Attendance;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.Attendance;

/// <summary>
/// 考勤设置api
/// </summary>
public interface IAttendanceSettingsApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 查询考勤写操作权限
    /// </summary>
    [HttpPost("/v1.0/attendance/writePermissions/query")]
    ITask<AttendanceWritePermissionsQueryResponse> AttendanceWritePermissionsQueryAsync([JsonContent] AttendanceWritePermissionsQueryRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 配置考勤排班附加信息
    /// </summary>
    [HttpPut("/v1.0/attendance/schedules/additionalInfo")]
    ITask<AttendanceSchedulesAdditionalInfoPutResponse> UpdateAttendanceSchedulesAdditionalInfoAsync([JsonContent] AttendanceSchedulesAdditionalInfoPutRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 分页获取加班规则列表
    /// </summary>
    [HttpGet("/v1.0/attendance/overtimeSettings")]
    ITask<AttendanceOvertimeSettingsGetResponse> GetAttendanceOvertimeSettingsAsync(string pageNumber, string pageSize, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 分页获取补卡规则列表
    /// </summary>
    [HttpGet("/v1.0/attendance/adjustments")]
    ITask<AttendanceAdjustmentsGetResponse> GetAttendanceAdjustmentsAsync(string pageNumber, string pageSize, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量获取加班规则设置
    /// </summary>
    [HttpPost("/v1.0/attendance/overtimeSettings/query")]
    ITask<AttendanceOvertimeSettingsQueryResponse> AttendanceOvertimeSettingsQueryAsync([JsonContent] AttendanceOvertimeSettingsQueryRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询用户某段时间内是否处于封账状态
    /// </summary>
    [HttpPost("/v1.0/attendance/closingAccounts/status/query")]
    ITask<AttendanceClosingAccountsStatusQueryResponse> AttendanceClosingAccountsStatusQueryAsync([JsonContent] AttendanceClosingAccountsStatusQueryRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 预计算时长（新版SDK）
    /// </summary>
    [HttpPost("/v1.0/attendance/approvals/durations/calculate")]
    ITask<AttendanceApprovalsDurationsCalculateResponse> AttendanceApprovalsDurationsCalculateAsync(string? userId, [JsonContent] AttendanceApprovalsDurationsCalculateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 通知审批通过(新版SDK)
    /// </summary>
    [HttpPost("/v1.0/attendance/approvals/finish")]
    ITask<AttendanceApprovalsFinishResponse> AttendanceApprovalsFinishAsync(string? userId, [JsonContent] AttendanceApprovalsFinishRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 添加假期规则
    /// </summary>
    [HttpPost("/v1.0/attendance/leaves/types")]
    ITask<AttendanceLeavesTypesResponse> AttendanceLeavesTypesAsync(string opUserId, [JsonContent] AttendanceLeavesTypesRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新假期规则
    /// </summary>
    [HttpPut("/v1.0/attendance/leaves/types")]
    ITask<AttendanceLeavesTypesPutResponse> UpdateAttendanceLeavesTypesAsync(string opUserId, [JsonContent] AttendanceLeavesTypesPutRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量查询员工假期余额变更记录
    /// </summary>
    [HttpPost("/v1.0/attendance/vacations/records/query")]
    ITask<AttendanceVacationsRecordsQueryResponse> AttendanceVacationsRecordsQueryAsync([JsonContent] AttendanceVacationsRecordsQueryRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询指定用户的封账规则
    /// </summary>
    [HttpPost("/v1.0/attendance/closingAccounts/rules/query")]
    ITask<AttendanceClosingAccountsRulesQueryResponse> AttendanceClosingAccountsRulesQueryAsync([JsonContent] AttendanceClosingAccountsRulesQueryRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
