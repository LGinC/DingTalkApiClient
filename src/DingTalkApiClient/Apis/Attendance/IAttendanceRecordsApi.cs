using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models;
using DingTalkApiClient.Models.Attendance;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.Attendance;

/// <summary>
/// 考勤打卡api
/// </summary>
public interface IAttendanceRecordsApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 获取打卡结果
    /// </summary>
    [HttpPost("/attendance/list")]
    ITask<AttendanceListResponse> AttendanceListAsync([JsonContent] AttendanceListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取打卡详情
    /// </summary>
    [HttpPost("/attendance/listRecord")]
    ITask<AttendanceListRecordResponse> AttendanceListRecordAsync([JsonContent] AttendanceListRecordRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 上传打卡记录
    /// </summary>
    [HttpPost("/topapi/attendance/record/upload")]
    ITask<DingTalkResult> AttendanceRecordUploadAsync([JsonContent] AttendanceRecordUploadRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
