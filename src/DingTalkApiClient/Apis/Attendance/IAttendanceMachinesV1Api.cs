using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models;
using DingTalkApiClient.Models.Attendance;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.Attendance;

/// <summary>
/// 智能考勤机新版api
/// </summary>
public interface IAttendanceMachinesV1Api : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 根据设备ID获取员工信息
    /// </summary>
    [HttpGet("/v1.0/attendance/machines/getUser/{devId}")]
    ITask<AttendanceMachinesGetUserDevIdGetResponse> GetAttendanceMachinesGetUserDevIdAsync([PathQuery] string devId, string nextToken, string maxResults, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询考勤机信息
    /// </summary>
    [HttpGet("/v1.0/attendance/machines/{devId}")]
    ITask<AttendanceMachinesDevIdGetResponse> GetAttendanceMachinesDevIdAsync([PathQuery] string devId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 变更智能考勤机员工
    /// </summary>
    [HttpPut("/v1.0/smartDevice/atmachines/users")]
    ITask<SmartDeviceAtMachinesUsersPutResponse> UpdateSmartDeviceAtMachinesUsersAsync([JsonContent] SmartDeviceAtMachinesUsersPutRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
