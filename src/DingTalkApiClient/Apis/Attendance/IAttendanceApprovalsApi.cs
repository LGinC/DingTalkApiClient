using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models;
using DingTalkApiClient.Models.Attendance;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.Attendance;

/// <summary>
/// 考勤审批api
/// </summary>
public interface IAttendanceApprovalsApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 预计算时长（旧版SDK）
    /// </summary>
    [HttpPost("/topapi/attendance/approve/duration/calculate")]
    ITask<DingTalkResult<AttendanceApproveDurationCalculateResult>> AttendanceApproveDurationCalculateAsync([JsonContent] AttendanceApproveDurationCalculateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 通知审批通过（旧版SDK)
    /// </summary>
    [HttpPost("/topapi/attendance/approve/finish")]
    ITask<DingTalkResult<AttendanceApproveFinishResult>> AttendanceApproveFinishAsync([JsonContent] AttendanceApproveFinishRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 通知审批撤销
    /// </summary>
    [HttpPost("/topapi/attendance/approve/cancel")]
    ITask<DingTalkResult> AttendanceApproveCancelAsync([JsonContent] AttendanceApproveCancelRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 通知补卡通过
    /// </summary>
    [HttpPost("/topapi/attendance/approve/check")]
    ITask<DingTalkResult> AttendanceApproveCheckAsync([JsonContent] AttendanceApproveCheckRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 通知换班通过
    /// </summary>
    [HttpPost("/topapi/attendance/approve/schedule/switch")]
    ITask<DingTalkResult> AttendanceApproveScheduleSwitchAsync([JsonContent] AttendanceApproveScheduleSwitchRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 计算请假时长
    /// </summary>
    [HttpPost("/topapi/attendance/getleaveapproveduration")]
    ITask<DingTalkResult<AttendanceGetLeaveApproveDurationResult>> AttendanceGetLeaveApproveDurationAsync([JsonContent] AttendanceGetLeaveApproveDurationRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询请假状态
    /// </summary>
    [HttpPost("/topapi/attendance/getleavestatus")]
    ITask<DingTalkResult<AttendanceGetLeaveStatusResult>> AttendanceGetLeaveStatusAsync([JsonContent] AttendanceGetLeaveStatusRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
