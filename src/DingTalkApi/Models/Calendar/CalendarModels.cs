namespace DingTalkApi.Models.Calendar;

/// <summary>
/// 布尔操作响应。
/// </summary>
public class CalendarBooleanResponse
{
    /// <summary>
    /// 操作是否成功，true表示成功。
    /// </summary>
    public bool Result { get; set; }
}

/// <summary>
/// 创建访问控制请求。
/// </summary>
public class CreateCalendarAclRequest
{
    /// <summary>
    /// 权限信息，取值：free_busy_reader查看忙闲，title_reader查看标题，reader查看详情，writer创建和编辑。
    /// </summary>
    public required string Privilege { get; set; }

    /// <summary>
    /// 是否向授权人发消息。
    /// </summary>
    public bool SendMsg { get; set; }

    /// <summary>
    /// 权限范围。
    /// </summary>
    public required CalendarAclScope Scope { get; set; }
}

/// <summary>
/// 权限范围。
/// </summary>
public class CalendarAclScope
{
    /// <summary>
    /// 权限类型，目前只支持user表示用户。
    /// </summary>
    public required string ScopeType { get; set; }

    /// <summary>
    /// 用户ID；当scopeType为user时，值为用户的unionId。
    /// </summary>
    public required string UserId { get; set; }
}

/// <summary>
/// 日历访问控制。
/// </summary>
public class CalendarAcl
{
    /// <summary>
    /// 权限信息，取值：free_busy_reader查看忙闲，title_reader查看标题，reader查看详情，writer创建和编辑。
    /// </summary>
    public required string Privilege { get; set; }

    /// <summary>
    /// 权限资源ID。
    /// </summary>
    public required string AclId { get; set; }

    /// <summary>
    /// 权限范围。
    /// </summary>
    public required CalendarAclScope Scope { get; set; }
}

/// <summary>
/// 获取访问控制列表响应。
/// </summary>
public class ListCalendarAclsResponse
{
    /// <summary>
    /// 访问控制列表。
    /// </summary>
    public List<CalendarAcl> Acls { get; set; } = [];
}

/// <summary>
/// 日程创建或修改请求。
/// </summary>
public class CalendarEventRequest
{
    /// <summary>
    /// 日程ID，修改日程时可传入。
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// 日程标题。
    /// </summary>
    public required string Summary { get; set; }

    /// <summary>
    /// 日程描述。
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 日程开始时间。
    /// </summary>
    public required CalendarEventTime Start { get; set; }

    /// <summary>
    /// 日程结束时间。
    /// </summary>
    public required CalendarEventTime End { get; set; }

    /// <summary>
    /// 是否全天日程。
    /// </summary>
    public bool? IsAllDay { get; set; }

    /// <summary>
    /// 日程循环规则。
    /// </summary>
    public CalendarRecurrence? Recurrence { get; set; }

    /// <summary>
    /// 日程参与人列表，最多支持500个参与人。
    /// </summary>
    public List<CalendarAttendee>? Attendees { get; set; }

    /// <summary>
    /// 日程地点。
    /// </summary>
    public CalendarLocation? Location { get; set; }

    /// <summary>
    /// 日程提醒。
    /// </summary>
    public List<CalendarReminder>? Reminders { get; set; }

    /// <summary>
    /// 业务方扩展信息。
    /// </summary>
    public CalendarExtra? Extra { get; set; }
}

/// <summary>
/// 日程信息。
/// </summary>
public class CalendarEvent
{
    /// <summary>
    /// 日程ID。
    /// </summary>
    public required string Id { get; set; }

    /// <summary>
    /// 日程标题。
    /// </summary>
    public required string Summary { get; set; }

    /// <summary>
    /// 日程描述。
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 日程开始时间。
    /// </summary>
    public required CalendarEventTime Start { get; set; }

    /// <summary>
    /// 日程结束时间。
    /// </summary>
    public required CalendarEventTime End { get; set; }

    /// <summary>
    /// 是否全天日程。
    /// </summary>
    public bool IsAllDay { get; set; }

    /// <summary>
    /// 日程循环规则。
    /// </summary>
    public CalendarRecurrence? Recurrence { get; set; }

    /// <summary>
    /// 参与人列表。
    /// </summary>
    public List<CalendarAttendee> Attendees { get; set; } = [];

    /// <summary>
    /// 日程组织者。
    /// </summary>
    public CalendarAttendee? Organizer { get; set; }

    /// <summary>
    /// 日程地点。
    /// </summary>
    public CalendarLocation? Location { get; set; }

    /// <summary>
    /// 日程提醒。
    /// </summary>
    public List<CalendarReminder> Reminders { get; set; } = [];

    /// <summary>
    /// 会议室信息。
    /// </summary>
    public List<CalendarMeetingRoom> MeetingRooms { get; set; } = [];

    /// <summary>
    /// 业务方扩展信息。
    /// </summary>
    public CalendarExtra? Extra { get; set; }

    /// <summary>
    /// 日程资源的eTag。
    /// </summary>
    public string? ETag { get; set; }
}

/// <summary>
/// 日程时间。
/// </summary>
public class CalendarEventTime
{
    /// <summary>
    /// 日程日期，格式：yyyy-MM-dd；全天日程使用。
    /// </summary>
    public string? Date { get; set; }

    /// <summary>
    /// 日程时间，格式为ISO-8601 date-time；非全天日程使用。
    /// </summary>
    public string? DateTime { get; set; }

    /// <summary>
    /// 时区名称，TZ database name格式，例如Asia/Shanghai。
    /// </summary>
    public string? TimeZone { get; set; }
}

/// <summary>
/// 日程循环规则。
/// </summary>
public class CalendarRecurrence
{
    /// <summary>
    /// 循环规则。
    /// </summary>
    public CalendarRecurrencePattern? Pattern { get; set; }

    /// <summary>
    /// 循环范围。
    /// </summary>
    public CalendarRecurrenceRange? Range { get; set; }
}

/// <summary>
/// 循环规则。
/// </summary>
public class CalendarRecurrencePattern
{
    /// <summary>
    /// 循环规则类型，例如daily、weekly、absoluteMonthly、relativeMonthly或absoluteYearly。
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// 当type为absoluteMonthly时，用于指定每个月的第几天。
    /// </summary>
    public int? DayOfMonth { get; set; }

    /// <summary>
    /// 英文小写单词指定星期几，如果有多个值使用逗号分割。
    /// </summary>
    public string? DaysOfWeek { get; set; }

    /// <summary>
    /// 当type为relativeMonthly时，用于指定每月第几周。
    /// </summary>
    public string? Index { get; set; }

    /// <summary>
    /// 循环间隔，根据type不同单位不同。
    /// </summary>
    public int? Interval { get; set; }
}

/// <summary>
/// 循环范围。
/// </summary>
public class CalendarRecurrenceRange
{
    /// <summary>
    /// 循环范围类型，例如noEnd、endDate或numbered。
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// 循环结束时间。
    /// </summary>
    public string? EndDate { get; set; }

    /// <summary>
    /// 循环次数。
    /// </summary>
    public int? NumberOfOccurrences { get; set; }
}

/// <summary>
/// 日程参与人。
/// </summary>
public class CalendarAttendee
{
    /// <summary>
    /// 用户的unionId或userid。
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// 用户姓名。
    /// </summary>
    public string? DisplayName { get; set; }

    /// <summary>
    /// 参会人响应状态。
    /// </summary>
    public string? ResponseStatus { get; set; }

    /// <summary>
    /// 是否当前操作用户。
    /// </summary>
    public bool? Self { get; set; }

    /// <summary>
    /// 是否可选参与人。
    /// </summary>
    public bool? IsOptional { get; set; }
}

/// <summary>
/// 日程地点。
/// </summary>
public class CalendarLocation
{
    /// <summary>
    /// 日程地点的名称。
    /// </summary>
    public string? DisplayName { get; set; }
}

/// <summary>
/// 日程提醒。
/// </summary>
public class CalendarReminder
{
    /// <summary>
    /// 提醒方式。
    /// </summary>
    public string? Method { get; set; }

    /// <summary>
    /// 提前提醒分钟数。
    /// </summary>
    public int? Minutes { get; set; }
}

/// <summary>
/// 业务方扩展信息。
/// </summary>
public class CalendarExtra
{
    /// <summary>
    /// 扩展信息名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 扩展信息值。
    /// </summary>
    public string? Value { get; set; }
}

/// <summary>
/// 会议室信息。
/// </summary>
public class CalendarMeetingRoom
{
    /// <summary>
    /// 会议室roomId。
    /// </summary>
    public string? RoomId { get; set; }

    /// <summary>
    /// 会议室名称。
    /// </summary>
    public string? RoomName { get; set; }
}

/// <summary>
/// 查询日程列表响应。
/// </summary>
public class ListCalendarEventsResponse
{
    /// <summary>
    /// 翻页token。
    /// </summary>
    public string? NextToken { get; set; }

    /// <summary>
    /// 同步token，用于增量同步场景。
    /// </summary>
    public string? SyncToken { get; set; }

    /// <summary>
    /// 日程列表。
    /// </summary>
    public List<CalendarEvent> Events { get; set; } = [];
}

/// <summary>
/// 查询日程视图响应。
/// </summary>
public class CalendarEventsViewResponse
{
    /// <summary>
    /// 翻页token。
    /// </summary>
    public string? NextToken { get; set; }

    /// <summary>
    /// 日程视图中的日程列表。
    /// </summary>
    public List<CalendarEvent> Events { get; set; } = [];
}

/// <summary>
/// 添加日程参与者请求。
/// </summary>
public class CalendarAttendeesRequest
{
    /// <summary>
    /// 需要添加的日程参与者列表。
    /// </summary>
    public List<CalendarAttendee> AttendeesToAdd { get; set; } = [];
}

/// <summary>
/// 删除日程参与者请求。
/// </summary>
public class RemoveCalendarAttendeesRequest
{
    /// <summary>
    /// 需要被删除的日程参与者列表。
    /// </summary>
    public List<CalendarAttendee> AttendeesToRemove { get; set; } = [];
}

/// <summary>
/// 获取日程参与者响应。
/// </summary>
public class ListCalendarAttendeesResponse
{
    /// <summary>
    /// 分页游标。
    /// </summary>
    public string? NextToken { get; set; }

    /// <summary>
    /// 日程参与者列表。
    /// </summary>
    public List<CalendarAttendee> Attendees { get; set; } = [];
}

/// <summary>
/// 设置日程响应邀请状态请求。
/// </summary>
public class RespondCalendarEventRequest
{
    /// <summary>
    /// 响应状态。
    /// </summary>
    public required string ResponseStatus { get; set; }
}

/// <summary>
/// 获取用户忙闲信息请求。
/// </summary>
public class QueryUserScheduleRequest
{
    /// <summary>
    /// 查询目标用户的unionId。
    /// </summary>
    public required List<string> UserIds { get; set; }

    /// <summary>
    /// 查询的开始时间。
    /// </summary>
    public required string StartTime { get; set; }

    /// <summary>
    /// 查询的结束时间。
    /// </summary>
    public required string EndTime { get; set; }
}

/// <summary>
/// 获取用户忙闲信息响应。
/// </summary>
public class QueryUserScheduleResponse
{
    /// <summary>
    /// 用户忙闲信息。
    /// </summary>
    public List<UserScheduleInformation> ScheduleInformation { get; set; } = [];
}

/// <summary>
/// 用户忙闲信息。
/// </summary>
public class UserScheduleInformation
{
    /// <summary>
    /// 查询目标用户的unionId。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// 异常信息。
    /// </summary>
    public string? Error { get; set; }

    /// <summary>
    /// 忙闲信息列表。
    /// </summary>
    public List<UserScheduleItem> ScheduleItems { get; set; } = [];
}

/// <summary>
/// 用户忙闲项目。
/// </summary>
public class UserScheduleItem
{
    /// <summary>
    /// 忙闲状态。
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// 日程开始时间。
    /// </summary>
    public CalendarEventTime? Start { get; set; }

    /// <summary>
    /// 日程结束时间。
    /// </summary>
    public CalendarEventTime? End { get; set; }
}

/// <summary>
/// 查询日历响应。
/// </summary>
public class ListCalendarsResponse
{
    /// <summary>
    /// 日历信息。
    /// </summary>
    public CalendarListResponse? Response { get; set; }
}

/// <summary>
/// 日历列表响应体。
/// </summary>
public class CalendarListResponse
{
    /// <summary>
    /// 日历信息列表。
    /// </summary>
    public List<CalendarInfo> Calendars { get; set; } = [];
}

/// <summary>
/// 日历信息。
/// </summary>
public class CalendarInfo
{
    /// <summary>
    /// 日历ID。
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// 日历标题。
    /// </summary>
    public string? Summary { get; set; }

    /// <summary>
    /// 日历描述。
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 时区名称，使用IANA Time Zone Database标准。
    /// </summary>
    public string? TimeZone { get; set; }

    /// <summary>
    /// 日历资源的eTag。
    /// </summary>
    public string? ETag { get; set; }

    /// <summary>
    /// 日历类型。
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// 权限信息。
    /// </summary>
    public string? Privilege { get; set; }
}

/// <summary>
/// 创建或更新订阅日历请求。
/// </summary>
public class SubscribedCalendarRequest
{
    /// <summary>
    /// 订阅日历的名称。
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 订阅日历的描述，最大长度1024字符。
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 订阅日历共同编辑人的unionId。
    /// </summary>
    public List<string>? Managers { get; set; }

    /// <summary>
    /// 可订阅该日历的对象。
    /// </summary>
    public required CalendarSubscribeScope SubscribeScope { get; set; }
}

/// <summary>
/// 可订阅范围。
/// </summary>
public class CalendarSubscribeScope
{
    /// <summary>
    /// 可订阅该日历的人员unionId。
    /// </summary>
    public List<string>? UnionIds { get; set; }

    /// <summary>
    /// 可订阅该日历的群组OpenConversationId列表。
    /// </summary>
    public List<string>? OpenConversationIds { get; set; }

    /// <summary>
    /// 可订阅该日历的组织corpId列表。
    /// </summary>
    public List<string>? CorpIds { get; set; }
}

/// <summary>
/// 创建订阅日历响应。
/// </summary>
public class CreateSubscribedCalendarResponse
{
    /// <summary>
    /// 可订阅日历的ID。
    /// </summary>
    public required string CalendarId { get; set; }
}

/// <summary>
/// 订阅日历详情。
/// </summary>
public class SubscribedCalendar
{
    /// <summary>
    /// 订阅日历ID。
    /// </summary>
    public required string CalendarId { get; set; }

    /// <summary>
    /// 日历标题。
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 日历描述。
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 日历创建者。
    /// </summary>
    public required string Author { get; set; }

    /// <summary>
    /// 可编辑人员的unionId。
    /// </summary>
    public List<string> Managers { get; set; } = [];

    /// <summary>
    /// 可订阅范围。
    /// </summary>
    public required CalendarSubscribeScope SubscribeScope { get; set; }
}

/// <summary>
/// 签到信息列表响应。
/// </summary>
public class CalendarSignInListResponse
{
    /// <summary>
    /// 分页游标。
    /// </summary>
    public string? NextToken { get; set; }

    /// <summary>
    /// 签到信息列表。
    /// </summary>
    public List<CalendarSignInUser> Users { get; set; } = [];
}

/// <summary>
/// 签到用户信息。
/// </summary>
public class CalendarSignInUser
{
    /// <summary>
    /// 用户ID。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// 用户名。
    /// </summary>
    public string? DisplayName { get; set; }

    /// <summary>
    /// 签到时间，毫秒级时间戳。
    /// </summary>
    public long? CheckInTime { get; set; }
}

/// <summary>
/// 签到响应。
/// </summary>
public class CalendarSignInResponse
{
    /// <summary>
    /// 签到时间戳，单位毫秒。
    /// </summary>
    public long CheckInTime { get; set; }
}

/// <summary>
/// 签退信息列表响应。
/// </summary>
public class CalendarSignOutListResponse
{
    /// <summary>
    /// 分页游标。
    /// </summary>
    public string? NextToken { get; set; }

    /// <summary>
    /// 签退信息列表。
    /// </summary>
    public List<CalendarSignOutUser> Users { get; set; } = [];
}

/// <summary>
/// 签退用户信息。
/// </summary>
public class CalendarSignOutUser
{
    /// <summary>
    /// 用户ID。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// 用户名。
    /// </summary>
    public string? DisplayName { get; set; }

    /// <summary>
    /// 签退时间，单位毫秒。
    /// </summary>
    public long? CheckOutTime { get; set; }
}

/// <summary>
/// 签退响应。
/// </summary>
public class CalendarSignOutResponse
{
    /// <summary>
    /// 签退时间戳，单位毫秒。
    /// </summary>
    public long CheckOutTime { get; set; }
}

/// <summary>
/// 获取会议室忙闲信息请求。
/// </summary>
public class QueryMeetingRoomScheduleRequest
{
    /// <summary>
    /// 待查询的会议室roomId列表，建议不超过5个。
    /// </summary>
    public required List<string> RoomIds { get; set; }

    /// <summary>
    /// 查询开始时间，ISO-8601格式。
    /// </summary>
    public required string StartTime { get; set; }

    /// <summary>
    /// 查询结束时间，ISO-8601格式。
    /// </summary>
    public required string EndTime { get; set; }
}

/// <summary>
/// 获取会议室忙闲信息响应。
/// </summary>
public class QueryMeetingRoomScheduleResponse
{
    /// <summary>
    /// 会议室的忙闲信息列表。
    /// </summary>
    public List<MeetingRoomScheduleInformation> ScheduleInformation { get; set; } = [];
}

/// <summary>
/// 会议室忙闲信息。
/// </summary>
public class MeetingRoomScheduleInformation
{
    /// <summary>
    /// 会议室roomId。
    /// </summary>
    public string? RoomId { get; set; }

    /// <summary>
    /// 异常信息。
    /// </summary>
    public string? Error { get; set; }

    /// <summary>
    /// 忙闲信息列表。
    /// </summary>
    public List<MeetingRoomScheduleItem> ScheduleItems { get; set; } = [];
}

/// <summary>
/// 会议室忙闲项目。
/// </summary>
public class MeetingRoomScheduleItem
{
    /// <summary>
    /// 忙闲状态，BUSY表示繁忙，TENTATIVE表示审批中。
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// 日程ID。
    /// </summary>
    public string? EventId { get; set; }

    /// <summary>
    /// 日程组织者信息。
    /// </summary>
    public CalendarAttendee? Organizer { get; set; }

    /// <summary>
    /// 日程开始时间。
    /// </summary>
    public CalendarEventTime? Start { get; set; }

    /// <summary>
    /// 日程结束时间。
    /// </summary>
    public CalendarEventTime? End { get; set; }
}

/// <summary>
/// 预定会议室请求。
/// </summary>
public class CalendarMeetingRoomsRequest
{
    /// <summary>
    /// 需要预定的会议室roomId列表，一个日程最多添加5个会议室。
    /// </summary>
    public required List<CalendarMeetingRoom> MeetingRoomsToAdd { get; set; }
}

/// <summary>
/// 取消预定会议室请求。
/// </summary>
public class RemoveCalendarMeetingRoomsRequest
{
    /// <summary>
    /// 需要取消预定的会议室信息列表。
    /// </summary>
    public List<CalendarMeetingRoom> MeetingRoomsToRemove { get; set; } = [];
}
