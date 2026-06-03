using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models.Attendance;

#pragma warning disable CS1591
#pragma warning disable CS8618

/// <summary>
/// 删除假期规则请求
/// </summary>
public class AttendanceVacationTypeDeleteRequest
{
    /// <summary>
    /// 假期规则唯一标识。 企业内部应用，通过查询假期规则列表接口获取leave_code参数值。 第三方企业应用，通过查询假期规则列表接口获取leave_code参数值。
    /// </summary>
    [JsonPropertyName("leave_code")]
    public required string LeaveCode { get; set; }

    /// <summary>
    /// 当前企业内拥有OA审批应用权限的管理员的userId。
    /// </summary>
    [JsonPropertyName("op_userid")]
    public required string OpUserid { get; set; }
}

/// <summary>
/// 删除假期规则结果
/// </summary>
public class AttendanceVacationTypeDeleteResult
{
    /// <summary>
    /// 假期类型。 general_leave：普通假期 lieu_leave：加班转调休
    /// </summary>
    [JsonPropertyName("biz_type")]
    public required string BizType { get; set; }

    /// <summary>
    /// 每天折算的工作时长，百分之一。 例如：1天=10小时=1000。
    /// </summary>
    [JsonPropertyName("hours_in_per_day")]
    public long HoursInPerDay { get; set; }

    /// <summary>
    /// 假期规则唯一标识。
    /// </summary>
    [JsonPropertyName("leave_code")]
    public required string LeaveCode { get; set; }

    /// <summary>
    /// 假期名称。
    /// </summary>
    [JsonPropertyName("leave_name")]
    public required string LeaveName { get; set; }

    /// <summary>
    /// 请假单位。 day：天 halfDay：半天 hour：小时
    /// </summary>
    [JsonPropertyName("leave_view_unit")]
    public required string LeaveViewUnit { get; set; }

    /// <summary>
    /// 是否按照自然日统计请假时长。
    /// </summary>
    [JsonPropertyName("natural_day_leave")]
    public bool NaturalDayLeave { get; set; }
}

/// <summary>
/// 初始化假期余额请求
/// </summary>
public class AttendanceVacationQuotaInitRequest
{
    /// <summary>
    /// 当前企业内拥有“OA审批”应用权限的管理员的userid。
    /// </summary>
    [JsonPropertyName("op_userid")]
    public required string OpUserid { get; set; }

    /// <summary>
    /// 待初始化的假期余额记录。
    /// </summary>
    [JsonPropertyName("leave_quotas")]
    public AttendanceVacationQuotaInitRequestLeaveQuotas LeaveQuotas { get; set; }
}

/// <summary>
/// 待初始化的假期余额记录。
/// </summary>
public class AttendanceVacationQuotaInitRequestLeaveQuotas
{
    /// <summary>
    /// 员工的userid。
    /// </summary>
    public required string Userid { get; set; }

    /// <summary>
    /// 额度有效期结束时间，毫秒级时间戳。
    /// </summary>
    [JsonPropertyName("end_time")]
    public decimal EndTime { get; set; }

    /// <summary>
    /// 额度有效期开始时间，毫秒级时间戳。
    /// </summary>
    [JsonPropertyName("start_time")]
    public decimal StartTime { get; set; }

    /// <summary>
    /// 假期类型唯一标识。
    /// </summary>
    [JsonPropertyName("leave_code")]
    public required string LeaveCode { get; set; }

    /// <summary>
    /// 操作原因。
    /// </summary>
    public string? Reason { get; set; }

    /// <summary>
    /// 以天计算的额度总数。假期类型按天计算时，该值不为空且按百分之一天折算。 例如：1000=10天。
    /// </summary>
    [JsonPropertyName("quota_num_per_day")]
    public decimal? QuotaNumPerDay { get; set; }

    /// <summary>
    /// 以小时计算的额度总数。假期类型按小时，计算该值不为空且按百分之一小时折算。例如：1000=10小时。
    /// </summary>
    [JsonPropertyName("quota_num_per_hour")]
    public decimal? QuotaNumPerHour { get; set; }

    /// <summary>
    /// 额度所对应的周期。除了假期类型为调休的时候可以为空之外，其他情况均不能为空且格式必须满足“yyyy”。
    /// </summary>
    [JsonPropertyName("quota_cycle")]
    public string? QuotaCycle { get; set; }
}

/// <summary>
/// 初始化假期余额结果
/// </summary>
public class AttendanceVacationQuotaInitResult
{
}

/// <summary>
/// 批量更新假期余额请求
/// </summary>
public class AttendanceVacationQuotaUpdateRequest
{
    /// <summary>
    /// 待更新的假期余额记录。
    /// </summary>
    [JsonPropertyName("leave_quotas")]
    public List<AttendanceVacationQuotaUpdateRequestLeaveQuotasItem> LeaveQuotas { get; set; } = [];

    /// <summary>
    /// 当前企业内拥有“OA审批”应用权限的管理员的userid。
    /// </summary>
    [JsonPropertyName("op_userid")]
    public required string OpUserid { get; set; }
}

/// <summary>
/// AttendanceVacationQuotaUpdateRequestLeaveQuotasItem
/// </summary>
public class AttendanceVacationQuotaUpdateRequestLeaveQuotasItem
{
    /// <summary>
    /// 员工的userid。
    /// </summary>
    public required string Userid { get; set; }

    /// <summary>
    /// 额度有效期结束时间，毫秒级时间戳。
    /// </summary>
    [JsonPropertyName("end_time")]
    public decimal? EndTime { get; set; }

    /// <summary>
    /// 额度有效期开始时间，毫秒级时间戳。
    /// </summary>
    [JsonPropertyName("start_time")]
    public decimal? StartTime { get; set; }

    /// <summary>
    /// 自定义添加的假期类型，可通过查询假期类型接口获取。此类型必须是通过添加假期类型接口创建的假期类型。
    /// </summary>
    [JsonPropertyName("leave_code")]
    public required string LeaveCode { get; set; }

    /// <summary>
    /// 操作原因。
    /// </summary>
    public string? Reason { get; set; }

    /// <summary>
    /// 以天计算的额度总数。假期类型按天计算时，该值不为空且按百分之一天折算。 例如：1000=10天。
    /// </summary>
    [JsonPropertyName("quota_num_per_day")]
    public decimal? QuotaNumPerDay { get; set; }

    /// <summary>
    /// 以小时计算的额度总数。假期类型按小时，计算该值不为空且按百分之一小时折算。例如：1000=10小时。
    /// </summary>
    [JsonPropertyName("quota_num_per_hour")]
    public decimal? QuotaNumPerHour { get; set; }

    /// <summary>
    /// 额度所对应的周期。除了假期类型为调休的时候可以为空之外，其他情况均不能为空且格式必须满足“yyyy”。
    /// </summary>
    [JsonPropertyName("quota_cycle")]
    public string? QuotaCycle { get; set; }
}

/// <summary>
/// 批量更新假期余额结果
/// </summary>
public class AttendanceVacationQuotaUpdateResult
{
}

/// <summary>
/// 查询假期类型请求
/// </summary>
public class AttendanceVacationTypeListRequest
{
    /// <summary>
    /// 当前企业内拥有“OA审批”应用权限的管理员的userid。
    /// </summary>
    [JsonPropertyName("op_userid")]
    public required string OpUserid { get; set; }

    /// <summary>
    /// 假期来源。取值：all：所有假期类型null：开放接口定义假期类型
    /// </summary>
    [JsonPropertyName("vacation_source")]
    public string? VacationSource { get; set; }
}

/// <summary>
/// 查询假期类型结果
/// </summary>
public class AttendanceVacationTypeListResult
{
}

/// <summary>
/// 查询假期余额请求
/// </summary>
public class AttendanceVacationQuotaListRequest
{
    /// <summary>
    /// 假期类型唯一标识。可以通过调用假期类型查询接口获取。
    /// </summary>
    [JsonPropertyName("leave_code")]
    public required string LeaveCode { get; set; }

    /// <summary>
    /// 当前企业内拥有“OA审批”应用权限的管理员的userid。
    /// </summary>
    [JsonPropertyName("op_userid")]
    public required string OpUserid { get; set; }

    /// <summary>
    /// 待查询的员工ID列表。
    /// </summary>
    public required string Userids { get; set; }

    /// <summary>
    /// 分页偏移，从0开始的非负整数。
    /// </summary>
    public decimal Offset { get; set; }

    /// <summary>
    /// 分页偏移，最大50。
    /// </summary>
    public decimal Size { get; set; }
}

/// <summary>
/// 查询假期余额结果
/// </summary>
public class AttendanceVacationQuotaListResult
{
    /// <summary>
    /// 是否存在更多记录。
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// 假期余额列表。
    /// </summary>
    [JsonPropertyName("leave_quotas")]
    public List<AttendanceVacationQuotaListResultLeaveQuotasItem> LeaveQuotas { get; set; } = [];
}

/// <summary>
/// AttendanceVacationQuotaListResultLeaveQuotasItem
/// </summary>
public class AttendanceVacationQuotaListResultLeaveQuotasItem
{
    /// <summary>
    /// 员工的userid。
    /// </summary>
    public string? Userid { get; set; }

    /// <summary>
    /// 假期类型唯一标识。
    /// </summary>
    [JsonPropertyName("leave_code")]
    public string? LeaveCode { get; set; }

    /// <summary>
    /// 额度所对应的周期。
    /// </summary>
    [JsonPropertyName("quota_cycle")]
    public string? QuotaCycle { get; set; }

    /// <summary>
    /// 配额的唯一标记。
    /// </summary>
    [JsonPropertyName("quota_id")]
    public string? QuotaId { get; set; }

    /// <summary>
    /// 假期有效期开始时间，毫秒级时间戳。
    /// </summary>
    [JsonPropertyName("start_time")]
    public decimal? StartTime { get; set; }

    /// <summary>
    /// 额度有效期结束时间，毫秒级时间戳。
    /// </summary>
    [JsonPropertyName("end_time")]
    public decimal? EndTime { get; set; }

    /// <summary>
    /// 以小时计算的额度总数。假期类型按小时，计算该值不为空且按百分之一小时折算。例如：1000=10小时。
    /// </summary>
    [JsonPropertyName("quota_num_per_hour")]
    public decimal? QuotaNumPerHour { get; set; }

    /// <summary>
    /// 以天计算的额度总数。假期类型按天计算时，该值不为空且按百分之一天折算。 例如：1000=10天。
    /// </summary>
    [JsonPropertyName("quota_num_per_day")]
    public decimal? QuotaNumPerDay { get; set; }

    /// <summary>
    /// 以天计算的使用额度。假期类型按天计算时，该值不为空且按百分之一天折算。例如：100=1天。
    /// </summary>
    [JsonPropertyName("used_num_per_day")]
    public decimal? UsedNumPerDay { get; set; }

    /// <summary>
    /// 以小时计算的使用额度。假期类型按小时计算时，该值不为空且按百分之一小时折算。例如：1000=10小时。
    /// </summary>
    [JsonPropertyName("used_num_per_hour")]
    public decimal? UsedNumPerHour { get; set; }
}
