using System.ComponentModel.DataAnnotations;
using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.AudioAndVideo.VideoConferences;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.AudioAndVideo;

/// <summary>
/// 视频会议api
/// </summary>
public interface IVideoConferencesApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 创建视频会议
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/conference/videoConferences")]
    public ITask<CreateVideoConferencesResult> CreateAsync([JsonContent] CreateVideoConferencesRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询视频会议信息
    /// </summary>
    /// <param name="conferenceId">会议id</param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/conference/videoConferences/{conferenceId}")]
    public ITask<GetVideoConferenceResult> GetAsync([PathQuery] string conferenceId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询视频会议成员
    /// </summary>
    /// <param name="conferenceId">会议id</param>
    /// <param name="nextToken">分页游标</param>
    /// <param name="maxResults">分页大小</param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("/v1.0/conference/videoConferences/{conferenceId}/members")]
    public ITask<ConferenceMembersResult> ListMembersAsync([PathQuery] string conferenceId, string? nextToken = null, int? maxResults = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 开启云录制
    /// </summary>
    /// <param name="conferenceId">会议id</param>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/conference/videoConferences/{conferenceId}/cloudRecords/start")]
    public ITask<DingTalkResult> CloudRecordsAsync([PathQuery] string conferenceId,
        [JsonContent] CloudRecordRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量查询视频会议信息
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="token"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/conference/videoConferences/query")]
    public ITask<VideoConferencesResult> QueryAsync([JsonContent] GetVideoConferencesRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken token = default);

    /// <summary>
    /// 查询用户进行中会议列表
    /// </summary>
    /// <param name="unionId">用户unionId</param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("/v1.0/conference/users/lists")]
    public ITask<UserOnGoingConferencesResult> ListUserOnGoingConferencesAsync(string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 邀请用户入会
    /// </summary>
    /// <param name="conferenceId">会议id</param>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/conference/videoConferences/{conferenceId}/users/invite")]
    public ITask<ConferenceSuccessResult> InviteUsersAsync([PathQuery] string conferenceId, [JsonContent] InviteConferenceUsersRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 踢出会议成员
    /// </summary>
    /// <param name="conferenceId">会议id</param>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/conference/videoConferences/{conferenceId}/members/kick")]
    public ITask<ConferenceSuccessResult> KickMembersAsync([PathQuery] string conferenceId, [JsonContent] ConferenceUsersRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 设置全员看他
    /// </summary>
    /// <param name="conferenceId">会议id</param>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/conference/videoConferences/{conferenceId}/focus")]
    public ITask<ConferenceSuccessResult> SetFocusAsync([PathQuery] string conferenceId, [JsonContent] SetConferenceFocusRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 设置联席主持人
    /// </summary>
    /// <param name="conferenceId">会议id</param>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/conference/videoConferences/{conferenceId}/coHosts/set")]
    public ITask<ConferenceSuccessResult> SetCoHostsAsync([PathQuery] string conferenceId, [JsonContent] SetConferenceUsersActionRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 开启视频会议直播推流
    /// </summary>
    /// <param name="conferenceId">会议id</param>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/conference/videoConferences/{conferenceId}/streamOuts/start")]
    public ITask<StartConferenceStreamOutResult> StartStreamOutAsync([PathQuery] string conferenceId, [JsonContent] StartConferenceStreamOutRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 停止视频会议直播推流
    /// </summary>
    /// <param name="conferenceId">会议id</param>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/conference/videoConferences/{conferenceId}/streamOuts/stop")]
    public ITask<StopConferenceStreamOutResult> StopStreamOutAsync([PathQuery] string conferenceId, [JsonContent] StopConferenceStreamOutRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 指定人员静音或取消静音
    /// </summary>
    /// <param name="conferenceId">会议id</param>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/conference/videoConferences/{conferenceId}/muteMembers")]
    public ITask<ConferenceSuccessResult> MuteMembersAsync([PathQuery] string conferenceId, [JsonContent] SetConferenceUsersActionRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 全员静音或全员取消静音
    /// </summary>
    /// <param name="conferenceId">会议id</param>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/conference/videoConferences/{conferenceId}/muteAll")]
    public ITask<ConferenceSuccessResult> MuteAllAsync([PathQuery] string conferenceId, [JsonContent] ConferenceActionRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建预约会议
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/conference/scheduleConferences")]
    public ITask<ScheduleConferenceResult> CreateScheduleConferenceAsync([JsonContent] CreateScheduleConferenceRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新预约会议
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPut("/v1.0/conference/scheduleConferences")]
    public ITask<ConferenceSuccessResult> UpdateScheduleConferenceAsync([JsonContent] UpdateScheduleConferenceRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 取消预约会议
    /// </summary>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/conference/scheduleConferences/cancel")]
    public ITask<ConferenceSuccessResult> CancelScheduleConferenceAsync([JsonContent] CancelScheduleConferenceRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询预约会议
    /// </summary>
    /// <param name="scheduleConferenceId">预约会议id</param>
    /// <param name="requestUnionId">查询用户unionId</param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("/v1.0/conference/scheduleConferences/{scheduleConferenceId}/infos")]
    public ITask<ScheduleConferenceInfoResult> GetScheduleConferenceAsync([PathQuery] string scheduleConferenceId, string requestUnionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询预约会议历史会议信息
    /// </summary>
    /// <param name="scheduleConferenceId">预约会议id</param>
    /// <param name="nextToken">分页游标</param>
    /// <param name="maxResults">分页大小</param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("/v1.0/conference/videoConferences/scheduleConferences/{scheduleConferenceId}")]
    public ITask<ScheduleConferenceHistoryResult> ListScheduleConferenceHistoriesAsync([PathQuery] string scheduleConferenceId, string? nextToken = null, int? maxResults = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 停止视频会议云录制
    /// </summary>
    /// <param name="conferenceId">会议id</param>
    /// <param name="request"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("/v1.0/conference/videoConferences/{conferenceId}/cloudRecords/stop")]
    public ITask<DingTalkResult> StopCloudRecordsAsync([PathQuery] string conferenceId,
        [JsonContent] UnionIdRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 关闭视频会议
    /// </summary>
    /// <param name="conferenceId">会议id</param>
    /// <param name="unionId">主持人unionId</param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpDelete("/v1.0/conference/videoConferences/{conferenceId}")]
    public ITask<DingTalkCauseResult> StopAsync([PathQuery] string conferenceId, string unionId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询会议录制的视频列表
    /// </summary>
    /// <param name="conferenceId"></param>
    /// <param name="unionId"></param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("/v1.0/conference/videoConferences/{conferenceId}/cloudRecords/getVideos")]
    public ITask<VideoListResult> GetVideos([PathQuery] string conferenceId, string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询会议录制中的视频信息
    /// </summary>
    /// <param name="conferenceId">会议ID</param>
    /// <param name="unionId">用户unionId</param>
    /// <param name="mediaId">媒体文件ID</param>
    /// <param name="regionId">地域ID</param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("/v1.0/conference/videoConferences/{conferenceId}/cloudRecords/videos/getPlayInfos")]
    public ITask<VideoPlayResult> GetPlayInfoAsync([PathQuery] string conferenceId, string unionId, string mediaId, string regionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询会议录制中的文本信息
    /// </summary>
    /// <param name="conferenceId">会议ID</param>
    /// <param name="unionId">用户unionId</param>
    /// <param name="startTime">开始时间，从会议开始计算 单位毫秒<example>该参数值传2000，表示从录制开始的第2秒开始查询</example></param>
    /// <param name="direction">查询方式
    /// <list type="bullet">
    /// <item>0：表示此次查询按照时间由小到大的顺序进行，默认方式</item>
    /// <item>1：表示此次查询按照时间由大到小的顺序进行</item>
    /// </list>
    /// </param>
    /// <param name="maxResults">单词查询条数，最大2000</param>
    /// <param name="nextToken">分页游标
    /// <list type="bullet">
    /// <item>如果是首次查询，该参数可不传</item>
    /// <item>如果是非首次查询，该参数传上次调用本接口时返回的nextToken</item>
    /// </list>
    /// </param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("/v1.0/conference/videoConferences/{conferenceId}/cloudRecords/getTexts")]
    public ITask<GetTextResult> GetTextsAsync([PathQuery] string conferenceId, string? unionId = null, long? startTime = null, string? direction = null,
       [Range(1, 2000)] int? maxResults = null, string? nextToken = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
