using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.Attendance;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.Attendance;

/// <summary>
/// 考勤班次api
/// </summary>
public interface IAttendanceShiftsApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 创建班次
    /// </summary>
    [HttpPost("/topapi/attendance/shift/add")]
    ITask<DingTalkResult<AttendanceShiftAddResult>> AttendanceShiftAddAsync([JsonContent] AttendanceShiftAddRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除班次
    /// </summary>
    [HttpPost("/topapi/attendance/shift/delete")]
    ITask<DingTalkResult> AttendanceShiftDeleteAsync([JsonContent] AttendanceShiftDeleteRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 修改打卡时段设置
    /// </summary>
    [HttpPost("/topapi/attendance/shift/updatepunches")]
    ITask<DingTalkResult> AttendanceShiftUpdatePunchesAsync([JsonContent] AttendanceShiftUpdatePunchesRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询历史班次
    /// </summary>
    [HttpPost("/topapi/attendance/shift/history/query")]
    ITask<DingTalkResult<AttendanceShiftHistoryQueryResult>> AttendanceShiftHistoryQueryAsync([JsonContent] AttendanceShiftHistoryQueryRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 按名称搜索班次
    /// </summary>
    [HttpPost("/topapi/attendance/shift/search")]
    ITask<DingTalkResult<AttendanceShiftSearchResult>> AttendanceShiftSearchAsync([JsonContent] AttendanceShiftSearchRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取班次摘要信息
    /// </summary>
    [HttpPost("/topapi/attendance/shift/list")]
    ITask<DingTalkResult<AttendanceShiftListResult>> AttendanceShiftListAsync([JsonContent] AttendanceShiftListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取班次详情
    /// </summary>
    [HttpPost("/topapi/attendance/shift/query")]
    ITask<DingTalkResult<AttendanceShiftQueryResult>> AttendanceShiftQueryAsync([JsonContent] AttendanceShiftQueryRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
