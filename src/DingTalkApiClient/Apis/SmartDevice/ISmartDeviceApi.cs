using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.SmartDevice;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.SmartDevice;

/// <summary>
/// 智能硬件 topapi
/// </summary>
public interface ISmartDeviceApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 绑定设备
    /// </summary>
    [HttpPost("/topapi/smartdevice/external/bind")]
    ITask<SmartDeviceBindResponse> BindAsync([JsonContent] SmartDeviceBindRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 解绑设备
    /// </summary>
    [HttpPost("/topapi/smartdevice/device/unbind")]
    ITask<SmartDeviceResponse> UnbindAsync([JsonContent] SmartDeviceUnbindRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 修改设备昵称
    /// </summary>
    [HttpPost("/topapi/smartdevice/device/updatenick")]
    ITask<SmartDeviceResponse> UpdateNickAsync([JsonContent] SmartDeviceUpdateNickRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询设备列表
    /// </summary>
    [HttpPost("/topapi/smartdevice/device/querylist")]
    ITask<SmartDeviceQueryListResponse> QueryListAsync([JsonContent] SmartDeviceQueryListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询设备详情
    /// </summary>
    [HttpPost("/topapi/smartdevice/device/query")]
    ITask<SmartDeviceQueryResponse> QueryAsync([JsonContent] SmartDeviceQueryRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 根据设备ID查询设备
    /// </summary>
    [HttpPost("/topapi/smartdevice/device/querybyid")]
    ITask<SmartDeviceQueryResponse> QueryByIdAsync([JsonContent] SmartDeviceQueryByIdRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
