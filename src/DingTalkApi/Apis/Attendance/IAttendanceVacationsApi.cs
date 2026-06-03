using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.Attendance;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.Attendance;

/// <summary>
/// 考勤假期api
/// </summary>
public interface IAttendanceVacationsApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 删除假期规则
    /// </summary>
    [HttpPost("/topapi/attendance/vacation/type/delete")]
    ITask<DingTalkResult<AttendanceVacationTypeDeleteResult>> AttendanceVacationTypeDeleteAsync([JsonContent] AttendanceVacationTypeDeleteRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 初始化假期余额
    /// </summary>
    [HttpPost("/topapi/attendance/vacation/quota/init")]
    ITask<DingTalkResult<AttendanceVacationQuotaInitResult>> AttendanceVacationQuotaInitAsync([JsonContent] AttendanceVacationQuotaInitRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量更新假期余额
    /// </summary>
    [HttpPost("/topapi/attendance/vacation/quota/update")]
    ITask<DingTalkResult<AttendanceVacationQuotaUpdateResult>> AttendanceVacationQuotaUpdateAsync([JsonContent] AttendanceVacationQuotaUpdateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询假期类型
    /// </summary>
    [HttpPost("/topapi/attendance/vacation/type/list")]
    ITask<DingTalkResult<AttendanceVacationTypeListResult>> AttendanceVacationTypeListAsync([JsonContent] AttendanceVacationTypeListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询假期余额
    /// </summary>
    [HttpPost("/topapi/attendance/vacation/quota/list")]
    ITask<DingTalkResult<AttendanceVacationQuotaListResult>> AttendanceVacationQuotaListAsync([JsonContent] AttendanceVacationQuotaListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
