using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.AudioAndVideo.Live;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.AudioAndVideo;

/// <summary>
/// 直播api
/// </summary>
public interface ILiveApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 创建直播
    /// </summary>
    [HttpPost("/v1.0/live/lives")]
    public ITask<LiveCreateResponse> CreateAsync([JsonContent] LiveCreateRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除直播
    /// </summary>
    [HttpDelete("/v1.0/live/lives")]
    public ITask<LiveBooleanResponse> DeleteAsync(string liveId, string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询直播信息
    /// </summary>
    [HttpGet("/v1.0/live/lives")]
    public ITask<LiveInfoResponse> GetAsync(string liveId, string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 修改直播属性信息
    /// </summary>
    [HttpPut("/v1.0/live/lives")]
    public ITask<LiveBooleanResponse> UpdateAsync([JsonContent] LiveUpdateRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询直播观看人员信息
    /// </summary>
    [HttpGet("/v1.0/live/lives/watchUsers")]
    public ITask<LiveWatchUsersResponse> ListWatchUsersAsync(string liveId, string unionId, int pageNumber = 1, int pageSize = 20,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
