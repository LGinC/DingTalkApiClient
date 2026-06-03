using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.AudioAndVideo.MeetingRooms;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.AudioAndVideo;

/// <summary>
/// 会议室api
/// </summary>
public interface IMeetingRoomsApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 创建会议室
    /// </summary>
    [HttpPost("/v1.0/rooms/meetingrooms")]
    public ITask<MeetingRoomIdResponse> CreateAsync([JsonContent] MeetingRoomRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除会议室
    /// </summary>
    [HttpDelete("/v1.0/rooms/meetingRooms/{roomId}")]
    public ITask<MeetingRoomBooleanResponse> DeleteAsync([PathQuery] string roomId, string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询会议室详情
    /// </summary>
    [HttpGet("/v1.0/rooms/meetingRooms/{roomId}")]
    public ITask<MeetingRoomInfoResponse> GetAsync([PathQuery] string roomId, string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新会议室信息
    /// </summary>
    [HttpPut("/v1.0/rooms/meetingRooms")]
    public ITask<MeetingRoomBooleanResponse> UpdateAsync([JsonContent] MeetingRoomUpdateRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询会议室列表
    /// </summary>
    [HttpGet("/v1.0/rooms/meetingRoomLists")]
    public ITask<MeetingRoomListResponse> ListAsync(string unionId, string? nextToken = null, int? maxResults = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询视频会议设备信息
    /// </summary>
    [HttpGet("/v1.0/rooms/devices")]
    public ITask<MeetingRoomDeviceResponse> GetDeviceAsync(string operatorUnionId, string? deviceId = null, string? deviceUnionId = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询视频会议设备属性信息
    /// </summary>
    [HttpPost("/v1.0/rooms/devices/properties/query")]
    public ITask<MeetingRoomDevicePropertiesResponse> QueryDevicePropertiesAsync(string operatorUnionId, [JsonContent] MeetingRoomDevicePropertiesRequest request,
        string? deviceId = null, string? deviceUnionId = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建会议室分组
    /// </summary>
    [HttpPost("/v1.0/rooms/groups")]
    public ITask<MeetingRoomGroupIdResponse> CreateGroupAsync([JsonContent] MeetingRoomGroupRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新会议室分组信息
    /// </summary>
    [HttpPut("/v1.0/rooms/groups")]
    public ITask<MeetingRoomBooleanResponse> UpdateGroupAsync([JsonContent] MeetingRoomGroupUpdateRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除会议室分组
    /// </summary>
    [HttpDelete("/v1.0/rooms/groups/{groupId}")]
    public ITask<MeetingRoomBooleanResponse> DeleteGroupAsync([PathQuery] string groupId, string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询会议室分组信息
    /// </summary>
    [HttpGet("/v1.0/rooms/groups/{groupId}")]
    public ITask<MeetingRoomGroupInfo> GetGroupAsync([PathQuery] string groupId, string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询会议室分组列表
    /// </summary>
    [HttpGet("/v1.0/rooms/groupLists")]
    public ITask<MeetingRoomGroupListResponse> ListGroupsAsync(string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建自定义屏幕模板
    /// </summary>
    [HttpPost("/v1.0/rooms/devices/screens/templates")]
    public ITask<ScreenTemplateCreateResponse> CreateScreenTemplateAsync([JsonContent] ScreenTemplateRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新自定义屏幕模板
    /// </summary>
    [HttpPut("/v1.0/rooms/devices/screens/templates")]
    public ITask<MeetingRoomBooleanResponse> UpdateScreenTemplateAsync([JsonContent] ScreenTemplateRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除自定义屏幕模板
    /// </summary>
    [HttpPost("/v1.0/rooms/devices/screens/templates/remove")]
    public ITask<MeetingRoomBooleanResponse> RemoveScreenTemplateAsync([JsonContent] RemoveScreenTemplateRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询自定义屏幕信息
    /// </summary>
    [HttpGet("/v1.0/rooms/devices/screens/templates/{templateId}")]
    public ITask<ScreenTemplateInfoResponse> GetScreenTemplateAsync([PathQuery] string templateId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询自定义屏幕模板列表
    /// </summary>
    [HttpGet("/v1.0/rooms/devices/screens/templateLists")]
    public ITask<ScreenTemplateInfoResponse> ListScreenTemplatesAsync(
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
