using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.Attendance;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.Attendance;

/// <summary>
/// 考勤报表api
/// </summary>
public interface IAttendanceReportsApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 查询是否启用智能统计报表
    /// </summary>
    [HttpPost("/topapi/attendance/isopensmartreport")]
    ITask<DingTalkResult<AttendanceIsOpenSmartReportResult>> AttendanceIsOpenSmartReportAsync([JsonContent] AttendanceIsOpenSmartReportRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取用户考勤数据
    /// </summary>
    [HttpPost("/topapi/attendance/getupdatedata")]
    ITask<DingTalkResult<AttendanceGetUpdateDataResult>> AttendanceGetUpdateDataAsync([JsonContent] AttendanceGetUpdateDataRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取报表假期数据
    /// </summary>
    [HttpPost("/topapi/attendance/getleavetimebynames")]
    ITask<DingTalkResult<AttendanceGetLeaveTimeByNamesResult>> AttendanceGetLeaveTimeByNamesAsync([JsonContent] AttendanceGetLeaveTimeByNamesRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取考勤报表列定义
    /// </summary>
    [HttpPost("/topapi/attendance/getattcolumns")]
    ITask<DingTalkResult<AttendanceGetAttColumnsResult>> AttendanceGetAttColumnsAsync([JsonContent] AttendanceGetAttColumnsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取考勤报表列值
    /// </summary>
    [HttpPost("/topapi/attendance/getcolumnval")]
    ITask<DingTalkResult<AttendanceGetColumnValResult>> AttendanceGetColumnValAsync([JsonContent] AttendanceGetColumnValRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
