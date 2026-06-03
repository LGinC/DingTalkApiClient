using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.Checkin;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.Checkin;

/// <summary>
/// 签到api
/// </summary>
public interface ICheckinApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 获取用户签到记录
    /// </summary>
    [HttpPost("/topapi/checkin/record/get")]
    ITask<GetUserCheckinRecordsResponse> GetUserCheckinRecordsAsync(
        [JsonContent] GetUserCheckinRecordsRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取部门用户签到记录
    /// </summary>
    [HttpGet("/checkin/record")]
    ITask<GetDepartmentCheckinRecordsResponse> GetDepartmentCheckinRecordsAsync(
        string department_id,
        string end_time,
        string start_time,
        string? offset = null,
        string? size = null,
        string? order = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);
}
