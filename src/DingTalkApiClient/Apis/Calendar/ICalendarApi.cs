using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.Calendar;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.Calendar;

/// <summary>
/// 日程api
/// </summary>
public interface ICalendarApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 创建访问控制
    /// </summary>
    [HttpPost("/v1.0/calendar/users/{userId}/calendars/{calendarId}/acls")]
    ITask<CalendarAcl> CreateAclAsync([PathQuery] string userId, [PathQuery] string calendarId, [JsonContent] CreateCalendarAclRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取访问控制列表
    /// </summary>
    [HttpGet("/v1.0/calendar/users/{userId}/calendars/{calendarId}/acls")]
    ITask<ListCalendarAclsResponse> ListAclsAsync([PathQuery] string userId, [PathQuery] string calendarId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除访问控制
    /// </summary>
    [HttpDelete("/v1.0/calendar/users/{userId}/calendars/{calendarId}/acls/{aclId}")]
    Task DeleteAclAsync([PathQuery] string userId, [PathQuery] string calendarId, [PathQuery] string aclId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建日程
    /// </summary>
    [HttpPost("/v1.0/calendar/users/{userId}/calendars/{calendarId}/events")]
    ITask<CalendarEvent> CreateEventAsync([PathQuery] string userId, [PathQuery] string calendarId, [JsonContent] CalendarEventRequest request, [Header("x-client-token")] string? clientToken = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询日程列表
    /// </summary>
    [HttpGet("/v1.0/calendar/users/{userId}/calendars/{calendarId}/events")]
    ITask<ListCalendarEventsResponse> ListEventsAsync([PathQuery] string userId, [PathQuery] string calendarId, string? timeMin = null, string? timeMax = null, string? showDeleted = null, string? maxResults = null, string? nextToken = null, string? syncToken = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除日程
    /// </summary>
    [HttpDelete("/v1.0/calendar/users/{userId}/calendars/{calendarId}/events/{eventId}")]
    Task DeleteEventAsync([PathQuery] string userId, [PathQuery] string calendarId, [PathQuery] string eventId, bool? pushNotification = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 修改日程
    /// </summary>
    [HttpPut("/v1.0/calendar/users/{userId}/calendars/{calendarId}/events/{eventId}")]
    ITask<CalendarEvent> UpdateEventAsync([PathQuery] string userId, [PathQuery] string calendarId, [PathQuery] string eventId, [JsonContent] CalendarEventRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询单个日程详情
    /// </summary>
    [HttpGet("/v1.0/calendar/users/{userId}/calendars/{calendarId}/events/{eventId}")]
    ITask<CalendarEvent> GetEventAsync([PathQuery] string userId, [PathQuery] string calendarId, [PathQuery] string eventId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询日程视图
    /// </summary>
    [HttpGet("/v1.0/calendar/users/{userId}/calendars/{calendarId}/eventsview")]
    ITask<CalendarEventsViewResponse> GetEventsViewAsync([PathQuery] string userId, [PathQuery] string calendarId, string? timeMin = null, string? timeMax = null, string? maxResults = null, string? nextToken = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 添加日程参与者
    /// </summary>
    [HttpPost("/v1.0/calendar/users/{userId}/calendars/{calendarId}/events/{eventId}/attendees")]
    Task AddEventAttendeesAsync([PathQuery] string userId, [PathQuery] string calendarId, [PathQuery] string eventId, [JsonContent] CalendarAttendeesRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取日程参与者
    /// </summary>
    [HttpGet("/v1.0/calendar/users/{userId}/calendars/{calendarId}/events/{eventId}/attendees")]
    ITask<ListCalendarAttendeesResponse> ListEventAttendeesAsync([PathQuery] string userId, [PathQuery] string calendarId, [PathQuery] string eventId, string? maxResults = null, string? nextToken = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除日程参与者
    /// </summary>
    [HttpPost("/v1.0/calendar/users/{userId}/calendars/{calendarId}/events/{eventId}/attendees/batchRemove")]
    Task RemoveEventAttendeesAsync([PathQuery] string userId, [PathQuery] string calendarId, [PathQuery] string eventId, [JsonContent] RemoveCalendarAttendeesRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 设置日程响应邀请状态
    /// </summary>
    [HttpPost("/v1.0/calendar/users/{userId}/calendars/{calendarId}/events/{eventId}/respond")]
    Task RespondEventAsync([PathQuery] string userId, [PathQuery] string calendarId, [PathQuery] string eventId, [JsonContent] RespondCalendarEventRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取用户忙闲信息
    /// </summary>
    [HttpPost("/v1.0/calendar/users/{userId}/querySchedule")]
    ITask<QueryUserScheduleResponse> QueryUserScheduleAsync([PathQuery] string userId, [JsonContent] QueryUserScheduleRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询日历
    /// </summary>
    [HttpGet("/v1.0/calendar/users/{userId}/calendars")]
    ITask<ListCalendarsResponse> ListCalendarsAsync([PathQuery] string userId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 订阅公共日历
    /// </summary>
    [HttpPost("/v1.0/calendar/users/{userId}/calendars/{calendarId}/subscribe")]
    Task SubscribeCalendarAsync([PathQuery] string userId, [PathQuery] string calendarId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 取消订阅公共日历
    /// </summary>
    [HttpPost("/v1.0/calendar/users/{userId}/calendars/{calendarId}/unsubscribe")]
    ITask<CalendarBooleanResponse> UnsubscribeCalendarAsync([PathQuery] string userId, [PathQuery] string calendarId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建订阅日历
    /// </summary>
    [HttpPost("/v1.0/calendar/users/{userId}/subscribedCalendars")]
    ITask<CreateSubscribedCalendarResponse> CreateSubscribedCalendarAsync([PathQuery] string userId, [JsonContent] SubscribedCalendarRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询单个订阅日历详情
    /// </summary>
    [HttpGet("/v1.0/calendar/users/{userId}/subscribedCalendars/{calendarId}")]
    ITask<SubscribedCalendar> GetSubscribedCalendarAsync([PathQuery] string userId, [PathQuery] string calendarId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新订阅日历
    /// </summary>
    [HttpPut("/v1.0/calendar/users/{userId}/subscribedCalendars/{calendarId}")]
    ITask<CalendarBooleanResponse> UpdateSubscribedCalendarAsync([PathQuery] string userId, [PathQuery] string calendarId, [JsonContent] SubscribedCalendarRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除订阅日历
    /// </summary>
    [HttpDelete("/v1.0/calendar/users/{userId}/subscribedCalendars/{calendarId}")]
    ITask<CalendarBooleanResponse> DeleteSubscribedCalendarAsync([PathQuery] string userId, [PathQuery] string calendarId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查看单个日程的签到详情
    /// </summary>
    [HttpGet("/v1.0/calendar/users/{userId}/calendars/{calendarId}/events/{eventId}/signin")]
    ITask<CalendarSignInListResponse> ListEventSignInsAsync([PathQuery] string userId, [PathQuery] string calendarId, [PathQuery] string eventId, string maxResults, string type, string? nextToken = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 针对单个日程进行签到
    /// </summary>
    [HttpPost("/v1.0/calendar/users/{userId}/calendars/{calendarId}/events/{eventId}/signin")]
    ITask<CalendarSignInResponse> SignInEventAsync([PathQuery] string userId, [PathQuery] string calendarId, [PathQuery] string eventId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查看单个日程的签退详情
    /// </summary>
    [HttpGet("/v1.0/calendar/users/{userId}/calendars/{calendarId}/events/{eventId}/signOut")]
    ITask<CalendarSignOutListResponse> ListEventSignOutsAsync([PathQuery] string userId, [PathQuery] string calendarId, [PathQuery] string eventId, string maxResults, string type, string? nextToken = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 针对单个日程进行签退
    /// </summary>
    [HttpPost("/v1.0/calendar/users/{userId}/calendars/{calendarId}/events/{eventId}/signOut")]
    ITask<CalendarSignOutResponse> SignOutEventAsync([PathQuery] string userId, [PathQuery] string calendarId, [PathQuery] string eventId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取会议室忙闲信息
    /// </summary>
    [HttpPost("/v1.0/calendar/users/{userId}/meetingRooms/schedules/query")]
    ITask<QueryMeetingRoomScheduleResponse> QueryMeetingRoomScheduleAsync([PathQuery] string userId, [JsonContent] QueryMeetingRoomScheduleRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 预定会议室
    /// </summary>
    [HttpPost("/v1.0/calendar/users/{userId}/calendars/{calendarId}/events/{eventId}/meetingRooms")]
    ITask<CalendarBooleanResponse> AddEventMeetingRoomsAsync([PathQuery] string userId, [PathQuery] string calendarId, [PathQuery] string eventId, [JsonContent] CalendarMeetingRoomsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 取消预定会议室
    /// </summary>
    [HttpPost("/v1.0/calendar/users/{userId}/calendars/{calendarId}/events/{eventId}/meetingRooms/batchRemove")]
    ITask<CalendarBooleanResponse> RemoveEventMeetingRoomsAsync([PathQuery] string userId, [PathQuery] string calendarId, [PathQuery] string eventId, [JsonContent] RemoveCalendarMeetingRoomsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
