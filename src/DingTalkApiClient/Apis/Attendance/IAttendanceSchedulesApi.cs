using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models;
using DingTalkApiClient.Models.Attendance;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.Attendance;

/// <summary>
/// 考勤排班api
/// </summary>
public interface IAttendanceSchedulesApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 查询成员排班信息
    /// </summary>
    [HttpPost("/topapi/attendance/schedule/listbyday")]
    ITask<DingTalkResult<AttendanceScheduleListByDayResult>> AttendanceScheduleListByDayAsync([JsonContent] AttendanceScheduleListByDayRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量查询人员排班信息
    /// </summary>
    [HttpPost("/topapi/attendance/schedule/listbyusers")]
    ITask<DingTalkResult<AttendanceScheduleListByUsersResult>> AttendanceScheduleListByUsersAsync([JsonContent] AttendanceScheduleListByUsersRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询排班打卡结果
    /// </summary>
    [HttpPost("/topapi/attendance/schedule/result/listbyids")]
    ITask<DingTalkResult<AttendanceScheduleResultListByIdsResult>> AttendanceScheduleResultListByIdsAsync([JsonContent] AttendanceScheduleResultListByIdsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询企业考勤排班详情
    /// </summary>
    [HttpPost("/topapi/attendance/listschedule")]
    ITask<DingTalkResult<AttendanceListscheduleResult>> AttendanceListscheduleAsync([JsonContent] AttendanceListscheduleRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量查询成员排班概要信息
    /// </summary>
    [HttpPost("/topapi/attendance/schedule/shift/listbydays")]
    ITask<DingTalkResult<AttendanceScheduleShiftListByDaysResult>> AttendanceScheduleShiftListByDaysAsync([JsonContent] AttendanceScheduleShiftListByDaysRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
