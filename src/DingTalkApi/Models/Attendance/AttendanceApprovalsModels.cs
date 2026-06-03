using System.Text.Json.Serialization;

namespace DingTalkApi.Models.Attendance;

#pragma warning disable CS1591
#pragma warning disable CS8618

/// <summary>
/// 预计算时长（旧版SDK）请求
/// </summary>
public class AttendanceApproveDurationCalculateRequest
{
    /// <summary>
    /// 员工的userid。
    /// </summary>
    public required string Userid { get; set; }

    /// <summary>
    /// 审批单类型：1：加班2：出差3：请假
    /// </summary>
    [JsonPropertyName("biz_type")]
    public decimal BizType { get; set; }

    /// <summary>
    /// 开始时间。开始时间不能早于当前时间前31天。支持以下格式：2019-08-152019-08-15 AM2019-08-15 12:43
    /// </summary>
    [JsonPropertyName("from_time")]
    public required string FromTime { get; set; }

    /// <summary>
    /// 结束时间。结束时间减去开始时间的天数不能超过31天。biz_type为1时结束时间减去开始时间不能超过1天。支持以下格式：2019-08-152019-08-15 AM2019-08-15 12:43
    /// </summary>
    [JsonPropertyName("to_time")]
    public required string ToTime { get; set; }

    /// <summary>
    /// 时长单位，支持格式如下：dayhalfDayhour：biz_type为1时仅支持hour。时间格式必须与时长单位对应：2019-08-15对应day2019-08-15 AM对应halfDay2019-08-15 12:43对应hour
    /// </summary>
    [JsonPropertyName("duration_unit")]
    public required string DurationUnit { get; set; }

    /// <summary>
    /// 计算方法：0：按自然日计算1：按工作日计算
    /// </summary>
    [JsonPropertyName("calculate_model")]
    public decimal CalculateModel { get; set; }
}

/// <summary>
/// 预计算时长（旧版SDK）结果
/// </summary>
public class AttendanceApproveDurationCalculateResult
{
    /// <summary>
    /// 总时长。
    /// </summary>
    public string? Duration { get; set; }

    /// <summary>
    /// 详细信息。
    /// </summary>
    [JsonPropertyName("duration_details")]
    public List<AttendanceApproveDurationCalculateResultDurationDetailsItem> DurationDetails { get; set; } = [];
}

/// <summary>
/// AttendanceApproveDurationCalculateResultDurationDetailsItem
/// </summary>
public class AttendanceApproveDurationCalculateResultDurationDetailsItem
{
    /// <summary>
    /// 日期。
    /// </summary>
    public string? Date { get; set; }

    /// <summary>
    /// 每日时长。
    /// </summary>
    public string? Duration { get; set; }
}

/// <summary>
/// 通知审批通过（旧版SDK)请求
/// </summary>
public class AttendanceApproveFinishRequest
{
    /// <summary>
    /// 员工的userid。
    /// </summary>
    public required string Userid { get; set; }

    /// <summary>
    /// 审批单类型：1：加班2：出差、外出3：请假
    /// </summary>
    [JsonPropertyName("biz_type")]
    public decimal BizType { get; set; }

    /// <summary>
    /// 开始时间。开始时间不能早于当前时间前31天。支持以下格式：2019-08-152019-08-15 AM2019-08-15 12:43
    /// </summary>
    [JsonPropertyName("from_time")]
    public required string FromTime { get; set; }

    /// <summary>
    /// 结束时间。结束时间减去开始时间的天数不能超过31天。biz_type为1时结束时间减去开始时间不能超过1天。支持以下格式：2019-08-152019-08-15 AM2019-08-15 12:43
    /// </summary>
    [JsonPropertyName("to_time")]
    public required string ToTime { get; set; }

    /// <summary>
    /// 时长单位，支持格式如下：dayhalfDayhour：biz_type为1时仅支持hour。时间格式必须与时长单位对应：2019-08-15对应day2019-08-15 AM对应halfDay2019-08-15 12:43对应hour
    /// </summary>
    [JsonPropertyName("duration_unit")]
    public required string DurationUnit { get; set; }

    /// <summary>
    /// 计算方法：0：按自然日计算1：按工作日计算
    /// </summary>
    [JsonPropertyName("calculate_model")]
    public decimal CalculateModel { get; set; }

    /// <summary>
    /// 审批单类型名称，最大长度20个字符。支持类型如下：请假出差外出加班
    /// </summary>
    [JsonPropertyName("tag_name")]
    public required string TagName { get; set; }

    /// <summary>
    /// 子类型名称，最大长度20个字符。审批单类型biz_type=3时，该参数必传。
    /// </summary>
    [JsonPropertyName("sub_type")]
    public string? SubType { get; set; }

    /// <summary>
    /// 审批单ID，最大长度100个字符，可通过查询企业考勤排班详情接口获取。
    /// </summary>
    [JsonPropertyName("approve_id")]
    public required string ApproveId { get; set; }

    /// <summary>
    /// 审批单跳转地址，最大长度200个字符。
    /// </summary>
    [JsonPropertyName("jump_url")]
    public required string JumpUrl { get; set; }

    /// <summary>
    /// biz_type为1时必传，加班时长单位小时。
    /// </summary>
    [JsonPropertyName("overtime_duration")]
    public string? OvertimeDuration { get; set; }

    /// <summary>
    /// biz_type为1时必传：1：加班转调休2：加班转工资
    /// </summary>
    [JsonPropertyName("overtime_to_more")]
    public decimal? OvertimeToMore { get; set; }
}

/// <summary>
/// 通知审批通过（旧版SDK)结果
/// </summary>
public class AttendanceApproveFinishResult
{
    /// <summary>
    /// 总时长。
    /// </summary>
    public string? Duration { get; set; }

    /// <summary>
    /// 详细信息。
    /// </summary>
    [JsonPropertyName("durationDetail")]
    public List<AttendanceApproveFinishResultDurationDetailItem> DurationDetail { get; set; } = [];
}

/// <summary>
/// AttendanceApproveFinishResultDurationDetailItem
/// </summary>
public class AttendanceApproveFinishResultDurationDetailItem
{
    /// <summary>
    /// 审批通过日期。
    /// </summary>
    public string? Date { get; set; }

    /// <summary>
    /// 每日时长。
    /// </summary>
    public string? Duration { get; set; }
}

/// <summary>
/// 通知审批撤销请求
/// </summary>
public class AttendanceApproveCancelRequest
{
    /// <summary>
    /// 员工的userid。
    /// </summary>
    public required string Userid { get; set; }

    /// <summary>
    /// 审批ID，最大长度100个字符，可通过查询企业考勤排班详情接口获取。
    /// </summary>
    [JsonPropertyName("approve_id")]
    public required string ApproveId { get; set; }
}

/// <summary>
/// 通知补卡通过请求
/// </summary>
public class AttendanceApproveCheckRequest
{
    /// <summary>
    /// 员工的userid。
    /// </summary>
    public required string Userid { get; set; }

    /// <summary>
    /// 要补卡的时间，注意这个日期不是实际要补的日期，而是班次的日期。例如用户要补卡的时间是2019-08-16 00:20，排班时间是2019-08-15 23：50，那么这里要传的日期是2019-08-15。
    /// </summary>
    [JsonPropertyName("work_date")]
    public required string WorkDate { get; set; }

    /// <summary>
    /// 要补的排班ID，可通过批量查询人员排班信息接口获取。
    /// </summary>
    [JsonPropertyName("punch_id")]
    public decimal PunchId { get; set; }

    /// <summary>
    /// 排班时间。
    /// </summary>
    [JsonPropertyName("punch_check_time")]
    public required string PunchCheckTime { get; set; }

    /// <summary>
    /// 用户打卡时间。
    /// </summary>
    [JsonPropertyName("user_check_time")]
    public required string UserCheckTime { get; set; }

    /// <summary>
    /// 审批单ID，可通过查询企业考勤排班详情接口获取。
    /// </summary>
    [JsonPropertyName("approve_id")]
    public required string ApproveId { get; set; }

    /// <summary>
    /// 审批单跳转地址。
    /// </summary>
    [JsonPropertyName("jump_url")]
    public required string JumpUrl { get; set; }

    /// <summary>
    /// 审批单名称。
    /// </summary>
    [JsonPropertyName("tag_name")]
    public required string TagName { get; set; }
}

/// <summary>
/// 通知换班通过请求
/// </summary>
public class AttendanceApproveScheduleSwitchRequest
{
    /// <summary>
    /// 发起人的userid。
    /// </summary>
    public required string Userid { get; set; }

    /// <summary>
    /// 申请换班日期，当天必须有排班或排休。
    /// </summary>
    [JsonPropertyName("switch_date")]
    public required string SwitchDate { get; set; }

    /// <summary>
    /// 还班日期，当天必须有排班或排休，如果申请换班人和被换班人是同一个人，那么必须要有还班日期。
    /// </summary>
    [JsonPropertyName("reback_date")]
    public required string RebackDate { get; set; }

    /// <summary>
    /// 申请换班人的userid，仅支持排班制考勤组用户。
    /// </summary>
    [JsonPropertyName("apply_userid")]
    public required string ApplyUserid { get; set; }

    /// <summary>
    /// 被换班人的userid，仅支持排班制考勤组用户。
    /// </summary>
    [JsonPropertyName("target_userid")]
    public required string TargetUserid { get; set; }

    /// <summary>
    /// 审批单ID，可通过查询企业考勤排班详情接口获取。
    /// </summary>
    [JsonPropertyName("approve_id")]
    public required string ApproveId { get; set; }

    /// <summary>
    /// 申请人换班日期当天的班次ID。
    /// </summary>
    [JsonPropertyName("apply_shift_id")]
    public decimal ApplyShiftId { get; set; }

    /// <summary>
    /// 被换班人换班日期当天的班次ID。
    /// </summary>
    [JsonPropertyName("target_shift_id")]
    public decimal TargetShiftId { get; set; }

    /// <summary>
    /// 申请人还班日期当天的班次ID。
    /// </summary>
    [JsonPropertyName("reback_apply_shift_id")]
    public decimal RebackApplyShiftId { get; set; }

    /// <summary>
    /// 被换班人还班日期当天的班次ID。
    /// </summary>
    [JsonPropertyName("reback_target_shift_id")]
    public decimal RebackTargetShiftId { get; set; }
}

/// <summary>
/// 计算请假时长请求
/// </summary>
public class AttendanceGetLeaveApproveDurationRequest
{
    /// <summary>
    /// 员工在企业内的userid，企业用来唯一标识用户的字段。
    /// </summary>
    public required string Userid { get; set; }

    /// <summary>
    /// 请假开始时间。
    /// </summary>
    [JsonPropertyName("from_date")]
    public required string FromDate { get; set; }

    /// <summary>
    /// 请假结束时间。
    /// </summary>
    [JsonPropertyName("to_date")]
    public required string ToDate { get; set; }
}

/// <summary>
/// 计算请假时长结果
/// </summary>
public class AttendanceGetLeaveApproveDurationResult
{
    /// <summary>
    /// 请假时长，单位分钟。
    /// </summary>
    [JsonPropertyName("duration_in_minutes")]
    public decimal? DurationInMinutes { get; set; }
}

/// <summary>
/// 查询请假状态请求
/// </summary>
public class AttendanceGetLeaveStatusRequest
{
    /// <summary>
    /// 待查询用户的ID列表，支持最多100个用户的批量查询。
    /// </summary>
    [JsonPropertyName("userid_list")]
    public required string UseridList { get; set; }

    /// <summary>
    /// 开始时间 ，Unix时间戳，支持最多180天的查询。
    /// </summary>
    [JsonPropertyName("start_time")]
    public decimal StartTime { get; set; }

    /// <summary>
    /// 结束时间，Unix时间戳，支持最多180天的查询。
    /// </summary>
    [JsonPropertyName("end_time")]
    public decimal EndTime { get; set; }

    /// <summary>
    /// 支持分页查询，与size参数同时设置时才生效，此参数代表偏移量，偏移量从0开始。
    /// </summary>
    public decimal Offset { get; set; }

    /// <summary>
    /// 支持分页查询，与offset参数同时设置时才生效，此参数代表分页大小，最大20。
    /// </summary>
    public decimal Size { get; set; }
}

/// <summary>
/// 查询请假状态结果
/// </summary>
public class AttendanceGetLeaveStatusResult
{
    /// <summary>
    /// 是否有更多数据。
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// 请假状态列表。
    /// </summary>
    [JsonPropertyName("leave_status")]
    public List<AttendanceGetLeaveStatusResultLeaveStatusItem> LeaveStatus { get; set; } = [];
}

/// <summary>
/// AttendanceGetLeaveStatusResultLeaveStatusItem
/// </summary>
public class AttendanceGetLeaveStatusResultLeaveStatusItem
{
    /// <summary>
    /// 请假单位：percent_day：天percent_hour：小时
    /// </summary>
    [JsonPropertyName("duration_unit")]
    public string? DurationUnit { get; set; }

    /// <summary>
    /// 假期时长*100，例如用户请假时长为1天，该值就等于100。
    /// </summary>
    [JsonPropertyName("duration_percent")]
    public decimal? DurationPercent { get; set; }

    /// <summary>
    /// 请假结束时间，Unix时间戳。
    /// </summary>
    [JsonPropertyName("end_time")]
    public decimal? EndTime { get; set; }

    /// <summary>
    /// 请假开始时间，Unix时间戳。
    /// </summary>
    [JsonPropertyName("start_time")]
    public decimal? StartTime { get; set; }

    /// <summary>
    /// 用户ID。
    /// </summary>
    public string? Userid { get; set; }
}
