using System.Text.Json.Serialization;

namespace DingTalkApi.Models.Attendance;

#pragma warning disable CS1591
#pragma warning disable CS8618

/// <summary>
/// 查询成员排班信息请求
/// </summary>
public class AttendanceScheduleListByDayRequest
{
    /// <summary>
    /// 操作人的userid。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 要查询的人员userid列表。
    /// </summary>
    [JsonPropertyName("user_id")]
    public required string UserId { get; set; }

    /// <summary>
    /// 查询的时间，Unix时间戳，单位毫秒。
    /// </summary>
    [JsonPropertyName("date_time")]
    public decimal DateTime { get; set; }
}

/// <summary>
/// 查询成员排班信息结果
/// </summary>
public class AttendanceScheduleListByDayResult
{
}

/// <summary>
/// 批量查询人员排班信息请求
/// </summary>
public class AttendanceScheduleListByUsersRequest
{
    /// <summary>
    /// 操作人userid。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 要查询的人员userid列表，多个userid用逗号分隔，一次最多可传入50个。
    /// </summary>
    public required string Userids { get; set; }

    /// <summary>
    /// 起始日期，Unix时间戳，单位毫秒。
    /// </summary>
    [JsonPropertyName("from_date_time")]
    public decimal FromDateTime { get; set; }

    /// <summary>
    /// 结束日期，Unix时间戳，单位毫秒。开始时间和结束时间间隔不能超过7天。
    /// </summary>
    [JsonPropertyName("to_date_time")]
    public decimal ToDateTime { get; set; }
}

/// <summary>
/// 批量查询人员排班信息结果
/// </summary>
public class AttendanceScheduleListByUsersResult
{
}

/// <summary>
/// 查询排班打卡结果请求
/// </summary>
public class AttendanceScheduleResultListByIdsRequest
{
    /// <summary>
    /// 操作人userid。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 排班ID，多个排班ID之间用逗号分割，可通过查询企业考勤排班详情接口获取。
    /// </summary>
    [JsonPropertyName("schedule_ids")]
    public required string ScheduleIds { get; set; }
}

/// <summary>
/// 查询排班打卡结果结果
/// </summary>
public class AttendanceScheduleResultListByIdsResult
{
}

/// <summary>
/// 查询企业考勤排班详情请求
/// </summary>
public class AttendanceListscheduleRequest
{
    /// <summary>
    /// 排班时间，只取年月日部分。
    /// </summary>
    [JsonPropertyName("workDate")]
    public required string WorkDate { get; set; }

    /// <summary>
    /// 支持分页查询，与size参数同时设置时才生效，此参数代表偏移量，偏移量从0开始。
    /// </summary>
    public decimal? Offset { get; set; }

    /// <summary>
    /// 分页大小，最大200。
    /// </summary>
    public decimal? Size { get; set; }
}

/// <summary>
/// 查询企业考勤排班详情结果
/// </summary>
public class AttendanceListscheduleResult
{
    /// <summary>
    /// 排班表。
    /// </summary>
    public List<AttendanceListscheduleResultSchedulesItem> Schedules { get; set; } = [];

    /// <summary>
    /// 分页用，表示是否还有下一页。
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}

/// <summary>
/// AttendanceListscheduleResultSchedulesItem
/// </summary>
public class AttendanceListscheduleResultSchedulesItem
{
    /// <summary>
    /// 排班ID。
    /// </summary>
    [JsonPropertyName("plan_id")]
    public decimal? PlanId { get; set; }

    /// <summary>
    /// 打卡类型：Onduty：上班打卡OffDuty：下班打卡
    /// </summary>
    [JsonPropertyName("check_type")]
    public string? CheckType { get; set; }

    /// <summary>
    /// 审批ID，没有返回表示没有审批单。
    /// </summary>
    [JsonPropertyName("approve_id")]
    public decimal? ApproveId { get; set; }

    /// <summary>
    /// 考勤的用户userid。
    /// </summary>
    public string? Userid { get; set; }

    /// <summary>
    /// 考勤班次ID。
    /// </summary>
    [JsonPropertyName("class_id")]
    public decimal? ClassId { get; set; }

    /// <summary>
    /// 班次配置ID，没有返回则表示使用全局配置。
    /// </summary>
    [JsonPropertyName("class_setting_id")]
    public decimal? ClassSettingId { get; set; }

    /// <summary>
    /// 打卡时间。
    /// </summary>
    [JsonPropertyName("plan_check_time")]
    public string? PlanCheckTime { get; set; }

    /// <summary>
    /// 考勤组ID。
    /// </summary>
    [JsonPropertyName("group_id")]
    public decimal? GroupId { get; set; }

    /// <summary>
    /// 调整后的卡点时间。
    /// </summary>
    [JsonPropertyName("changed_check_time")]
    public string? ChangedCheckTime { get; set; }
}

/// <summary>
/// 批量查询成员排班概要信息请求
/// </summary>
public class AttendanceScheduleShiftListByDaysRequest
{
    /// <summary>
    /// 操作者的userid。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 需要查询的用户userid列表，多个userid之间使用逗号分隔，且一次查询最多不能超过20。
    /// </summary>
    public required string Userids { get; set; }

    /// <summary>
    /// 开始日期的Unix时间戳，单位毫秒。时间跨度不能超过7天。
    /// </summary>
    [JsonPropertyName("from_date_time")]
    public decimal FromDateTime { get; set; }

    /// <summary>
    /// 结束日期的Unix时间戳，单位毫秒。时间跨度不能超过7天。
    /// </summary>
    [JsonPropertyName("to_date_time")]
    public decimal ToDateTime { get; set; }
}

/// <summary>
/// 批量查询成员排班概要信息结果
/// </summary>
public class AttendanceScheduleShiftListByDaysResult
{
}
