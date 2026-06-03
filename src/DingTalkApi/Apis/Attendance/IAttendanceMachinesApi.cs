using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.Attendance;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.Attendance;

/// <summary>
/// 智能考勤机api
/// </summary>
public interface IAttendanceMachinesApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 查询员工智能考勤机列表
    /// </summary>
    [HttpPost("/topapi/smartdevice/atmachine/get_by_userid")]
    ITask<DingTalkResult<SmartDeviceAtmachineGetByUseridResult>> SmartDeviceAtmachineGetByUseridAsync([JsonContent] SmartDeviceAtmachineGetByUseridRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
