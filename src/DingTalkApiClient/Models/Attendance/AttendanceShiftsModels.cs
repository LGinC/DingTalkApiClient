using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models.Attendance;

#pragma warning disable CS1591
#pragma warning disable CS8618

/// <summary>
/// 创建班次请求
/// </summary>
public class AttendanceShiftAddRequest
{
    /// <summary>
    /// 操作人userId。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 班次。
    /// </summary>
    public AttendanceShiftAddRequestShift Shift { get; set; }
}

/// <summary>
/// 班次。
/// </summary>
public class AttendanceShiftAddRequestShift
{
    /// <summary>
    /// 班次owner。
    /// </summary>
    public string? Owner { get; set; }

    /// <summary>
    /// 班次组名。
    /// </summary>
    [JsonPropertyName("class_group_name")]
    public string? ClassGroupName { get; set; }

    /// <summary>
    /// 企业的corpid，可在开发者后台查看。
    /// </summary>
    [JsonPropertyName("corp_id")]
    public string? CorpId { get; set; }

    /// <summary>
    /// 班次名称。
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 班次id，可通过获取班次摘要信息接口获取。
    /// </summary>
    public decimal? Id { get; set; }

    /// <summary>
    /// 卡段。
    /// </summary>
    public List<AttendanceShiftAddRequestShiftSectionsItem> Sections { get; set; } = [];

    /// <summary>
    /// 设置。
    /// </summary>
    public AttendanceShiftAddRequestShiftSetting Setting { get; set; }

    /// <summary>
    /// 高级排班绑定服务id，非临时班次无需填写。
    /// </summary>
    [JsonPropertyName("service_id")]
    public decimal? ServiceId { get; set; }
}

/// <summary>
/// AttendanceShiftAddRequestShiftSectionsItem
/// </summary>
public class AttendanceShiftAddRequestShiftSectionsItem
{
    /// <summary>
    /// 打卡信息。
    /// </summary>
    public List<AttendanceShiftAddRequestShiftSectionsItemTimesItem> Times { get; set; } = [];
}

/// <summary>
/// AttendanceShiftAddRequestShiftSectionsItemTimesItem
/// </summary>
public class AttendanceShiftAddRequestShiftSectionsItemTimesItem
{
    /// <summary>
    /// 打卡类型：OnDuty：上班OffDuty：下班
    /// </summary>
    [JsonPropertyName("check_type")]
    public required string CheckType { get; set; }

    /// <summary>
    /// 是否跨天：0：不跨天1：跨天
    /// </summary>
    public decimal Across { get; set; }

    /// <summary>
    /// 允许的最晚打卡时间，分钟为单位（-1表示不限制）。
    /// </summary>
    [JsonPropertyName("end_min")]
    public decimal? EndMin { get; set; }

    /// <summary>
    /// 打卡时间。
    /// </summary>
    [JsonPropertyName("check_time")]
    public required string CheckTime { get; set; }

    /// <summary>
    /// 是否免打卡：false：需打卡true：免打卡
    /// </summary>
    [JsonPropertyName("free_check")]
    public bool? FreeCheck { get; set; }

    /// <summary>
    /// 允许的最早提前打卡时间，分钟为单位。
    /// </summary>
    [JsonPropertyName("begin_min")]
    public decimal? BeginMin { get; set; }
}

/// <summary>
/// 设置。
/// </summary>
public class AttendanceShiftAddRequestShiftSetting
{
    /// <summary>
    /// 休息开始。
    /// </summary>
    [JsonPropertyName("rest_begin_time")]
    public AttendanceShiftAddRequestShiftSettingRestBeginTime RestBeginTime { get; set; }

    /// <summary>
    /// 班次id，可通过获取班次摘要信息接口获取。
    /// </summary>
    [JsonPropertyName("class_id")]
    public decimal? ClassId { get; set; }

    /// <summary>
    /// 是否弹性。
    /// </summary>
    [JsonPropertyName("is_flexible")]
    public bool? IsFlexible { get; set; }

    /// <summary>
    /// 企业的corpid，可开发者后台获取。
    /// </summary>
    [JsonPropertyName("corp_id")]
    public string? CorpId { get; set; }

    /// <summary>
    /// 是否删除。N：是Y：否
    /// </summary>
    [JsonPropertyName("is_deleted")]
    public string? IsDeleted { get; set; }

    /// <summary>
    /// 休息结束。
    /// </summary>
    [JsonPropertyName("rest_end_time")]
    public AttendanceShiftAddRequestShiftSettingRestEndTime RestEndTime { get; set; }

    /// <summary>
    /// 严重早退/迟到的时长，单位分钟。
    /// </summary>
    [JsonPropertyName("serious_late_minutes")]
    public decimal? SeriousLateMinutes { get; set; }

    /// <summary>
    /// 旷工早退/迟到的时长，单位分钟。旷工迟到的分钟数必须比严重迟到分钟数多。
    /// </summary>
    [JsonPropertyName("absenteeism_late_minutes")]
    public decimal? AbsenteeismLateMinutes { get; set; }

    /// <summary>
    /// 班次设置扩展字段，非临时班次无需填写。
    /// </summary>
    public Dictionary<string, object?> Extras { get; set; } = [];

    /// <summary>
    /// 班次tags，非临时班次无需填写。
    /// </summary>
    public string? Tags { get; set; }
}

/// <summary>
/// 休息开始。
/// </summary>
public class AttendanceShiftAddRequestShiftSettingRestBeginTime
{
    /// <summary>
    /// 休息类型：OnDuty：休息开始OffDuty：休息结束
    /// </summary>
    [JsonPropertyName("check_type")]
    public string? CheckType { get; set; }

    /// <summary>
    /// 休息打卡时间。
    /// </summary>
    [JsonPropertyName("check_time")]
    public string? CheckTime { get; set; }

    /// <summary>
    /// 是否免打卡：false：需打卡true：免打卡
    /// </summary>
    [JsonPropertyName("free_check")]
    public bool? FreeCheck { get; set; }

    /// <summary>
    /// 是否跨天，跨天是指休息时间是第二天：0：不跨天1：跨天
    /// </summary>
    public decimal? Across { get; set; }
}

/// <summary>
/// 休息结束。
/// </summary>
public class AttendanceShiftAddRequestShiftSettingRestEndTime
{
    /// <summary>
    /// 休息类型：OnDuty：休息开始OffDuty：休息结束
    /// </summary>
    [JsonPropertyName("check_type")]
    public string? CheckType { get; set; }

    /// <summary>
    /// 休息时间。
    /// </summary>
    [JsonPropertyName("check_time")]
    public string? CheckTime { get; set; }

    /// <summary>
    /// 是否免打卡：false：需打卡true：免打卡
    /// </summary>
    [JsonPropertyName("free_check")]
    public bool? FreeCheck { get; set; }

    /// <summary>
    /// 是否跨天，跨天是指休息时间是第二天：0：不跨天1：跨天
    /// </summary>
    public decimal? Across { get; set; }
}

/// <summary>
/// 创建班次结果
/// </summary>
public class AttendanceShiftAddResult
{
    /// <summary>
    /// 班次id。
    /// </summary>
    public decimal? Id { get; set; }

    /// <summary>
    /// 班次名称。
    /// </summary>
    public string? Name { get; set; }
}

/// <summary>
/// 删除班次请求
/// </summary>
public class AttendanceShiftDeleteRequest
{
    /// <summary>
    /// 操作人userid。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 班次ID，可通过获取班次摘要信息接口获取。
    /// </summary>
    [JsonPropertyName("shift_id")]
    public decimal ShiftId { get; set; }
}

/// <summary>
/// 修改打卡时段设置请求
/// </summary>
public class AttendanceShiftUpdatePunchesRequest
{
    /// <summary>
    /// 操作者的userid。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 卡点信息。
    /// </summary>
    public List<AttendanceShiftUpdatePunchesRequestPunchesItem> Punches { get; set; } = [];

    /// <summary>
    /// 班次ID， 可通过获取班次摘要信息接口获取。
    /// </summary>
    [JsonPropertyName("shift_id")]
    public decimal ShiftId { get; set; }
}

/// <summary>
/// AttendanceShiftUpdatePunchesRequestPunchesItem
/// </summary>
public class AttendanceShiftUpdatePunchesRequestPunchesItem
{
    /// <summary>
    /// 卡点ID， 可通过获取班次详情接口获取。
    /// </summary>
    public decimal Id { get; set; }

    /// <summary>
    /// 是否无需打卡。true：开启无需打卡。false：关闭无需打卡。
    /// </summary>
    [JsonPropertyName("free_check")]
    public bool FreeCheck { get; set; }
}

/// <summary>
/// 查询历史班次请求
/// </summary>
public class AttendanceShiftHistoryQueryRequest
{
    /// <summary>
    /// 操作者userid。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 班次ID，可通过获取班次摘要信息接口获取。
    /// </summary>
    [JsonPropertyName("shift_id")]
    public decimal ShiftId { get; set; }

    /// <summary>
    /// 班次版本，可通过查询排班概要信息接口获取。
    /// </summary>
    public decimal Version { get; set; }
}

/// <summary>
/// 查询历史班次结果
/// </summary>
public class AttendanceShiftHistoryQueryResult
{
    /// <summary>
    /// 班次组名称。
    /// </summary>
    [JsonPropertyName("shift_group_name")]
    public string? ShiftGroupName { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corp_id")]
    public string? CorpId { get; set; }

    /// <summary>
    /// 班次设置。
    /// </summary>
    [JsonPropertyName("shift_setting")]
    public AttendanceShiftHistoryQueryResultShiftSetting ShiftSetting { get; set; }

    /// <summary>
    /// 班次名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 班次ID。
    /// </summary>
    public decimal? Id { get; set; }

    /// <summary>
    /// 卡段。
    /// </summary>
    public List<AttendanceShiftHistoryQueryResultSectionsItem> Sections { get; set; } = [];

    /// <summary>
    /// 班组ID。
    /// </summary>
    [JsonPropertyName("shift_group_id")]
    public decimal? ShiftGroupId { get; set; }
}

/// <summary>
/// 班次设置。
/// </summary>
public class AttendanceShiftHistoryQueryResultShiftSetting
{
    /// <summary>
    /// 班次ID。
    /// </summary>
    [JsonPropertyName("shift_id")]
    public decimal? ShiftId { get; set; }

    /// <summary>
    /// 班次变更时间。
    /// </summary>
    [JsonPropertyName("gmt_modified")]
    public string? GmtModified { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corp_id")]
    public string? CorpId { get; set; }

    /// <summary>
    /// 删除标记。
    /// </summary>
    [JsonPropertyName("is_deleted")]
    public string? IsDeleted { get; set; }

    /// <summary>
    /// 工作时长，单位分钟，-1表示关闭该功能。
    /// </summary>
    [JsonPropertyName("work_time_minutes")]
    public decimal? WorkTimeMinutes { get; set; }

    /// <summary>
    /// 班次设置ID。
    /// </summary>
    public decimal? Id { get; set; }

    /// <summary>
    /// 该班次对应的出勤天数。
    /// </summary>
    [JsonPropertyName("attend_days")]
    public string? AttendDays { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    [JsonPropertyName("gmt_create")]
    public string? GmtCreate { get; set; }
}

/// <summary>
/// AttendanceShiftHistoryQueryResultSectionsItem
/// </summary>
public class AttendanceShiftHistoryQueryResultSectionsItem
{
    /// <summary>
    /// 卡点。
    /// </summary>
    public List<AttendanceShiftHistoryQueryResultSectionsItemPunchesItem> Punches { get; set; } = [];

    /// <summary>
    /// 工作时长，单位分钟。
    /// </summary>
    [JsonPropertyName("work_time_minutes")]
    public decimal? WorkTimeMinutes { get; set; }

    /// <summary>
    /// 休息段。
    /// </summary>
    public List<AttendanceShiftHistoryQueryResultSectionsItemRestsItem> Rests { get; set; } = [];

    /// <summary>
    /// 卡段ID。一次上下班成为一个卡段，一个班次可能会有多个卡段。
    /// </summary>
    public decimal? Id { get; set; }
}

/// <summary>
/// AttendanceShiftHistoryQueryResultSectionsItemPunchesItem
/// </summary>
public class AttendanceShiftHistoryQueryResultSectionsItemPunchesItem
{
    /// <summary>
    /// 打卡类型：OnDuty：上班OffDuty：下班
    /// </summary>
    [JsonPropertyName("check_type")]
    public string? CheckType { get; set; }

    /// <summary>
    /// 允许的最晚延后打卡时间，单位分钟。
    /// </summary>
    [JsonPropertyName("end_min")]
    public decimal? EndMin { get; set; }

    /// <summary>
    /// 是否跨天：0：不跨天1：跨天
    /// </summary>
    public decimal? Across { get; set; }

    /// <summary>
    /// 打卡时间。
    /// </summary>
    [JsonPropertyName("check_time")]
    public string? CheckTime { get; set; }

    /// <summary>
    /// 允许早退或迟到的时长。
    /// </summary>
    [JsonPropertyName("permit_minutes")]
    public decimal? PermitMinutes { get; set; }

    /// <summary>
    /// 是否免打卡：false：需打卡true：免打卡
    /// </summary>
    [JsonPropertyName("free_check")]
    public bool? FreeCheck { get; set; }

    /// <summary>
    /// 卡点ID。
    /// </summary>
    public decimal? Id { get; set; }

    /// <summary>
    /// 允许的最早提前打卡时间，单位分钟。
    /// </summary>
    [JsonPropertyName("begin_min")]
    public decimal? BeginMin { get; set; }
}

/// <summary>
/// AttendanceShiftHistoryQueryResultSectionsItemRestsItem
/// </summary>
public class AttendanceShiftHistoryQueryResultSectionsItemRestsItem
{
    /// <summary>
    /// 休息类型：OnDuty：休息开始OffDuty：休息结束
    /// </summary>
    [JsonPropertyName("check_type")]
    public string? CheckType { get; set; }

    /// <summary>
    /// 是否跨天，跨天是指休息时间是第二天：0：不跨天1：跨天
    /// </summary>
    public decimal? Across { get; set; }

    /// <summary>
    /// 休息时间。
    /// </summary>
    [JsonPropertyName("check_time")]
    public string? CheckTime { get; set; }

    /// <summary>
    /// 休息点ID。
    /// </summary>
    public decimal? Id { get; set; }
}

/// <summary>
/// 按名称搜索班次请求
/// </summary>
public class AttendanceShiftSearchRequest
{
    /// <summary>
    /// 操作人的userid。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 班次名称。
    /// </summary>
    [JsonPropertyName("shift_name")]
    public required string ShiftName { get; set; }
}

/// <summary>
/// 按名称搜索班次结果
/// </summary>
public class AttendanceShiftSearchResult
{
}

/// <summary>
/// 获取班次摘要信息请求
/// </summary>
public class AttendanceShiftListRequest
{
    /// <summary>
    /// 操作人userid。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 游标ID，起始值为0。
    /// </summary>
    public decimal? Cursor { get; set; }
}

/// <summary>
/// 获取班次摘要信息结果
/// </summary>
public class AttendanceShiftListResult
{
    /// <summary>
    /// 是否还有更多数据。
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// 下一页的游标位置。
    /// </summary>
    public decimal? Cursor { get; set; }

    /// <summary>
    /// 班次信息。
    /// </summary>
    public List<AttendanceShiftListResultResultItem> Result { get; set; } = [];
}

/// <summary>
/// AttendanceShiftListResultResultItem
/// </summary>
public class AttendanceShiftListResultResultItem
{
    /// <summary>
    /// 班次名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 班次ID。
    /// </summary>
    public decimal? Id { get; set; }
}

/// <summary>
/// 获取班次详情请求
/// </summary>
public class AttendanceShiftQueryRequest
{
    /// <summary>
    /// 操作者的userid。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 班次ID，可通过获取班次摘要信息接口获取。
    /// </summary>
    [JsonPropertyName("shift_id")]
    public decimal ShiftId { get; set; }
}

/// <summary>
/// 获取班次详情结果
/// </summary>
public class AttendanceShiftQueryResult
{
    /// <summary>
    /// 班次组名称。
    /// </summary>
    [JsonPropertyName("shift_group_name")]
    public string? ShiftGroupName { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corp_id")]
    public string? CorpId { get; set; }

    /// <summary>
    /// 班次设置信息。
    /// </summary>
    [JsonPropertyName("shift_setting")]
    public AttendanceShiftQueryResultShiftSetting ShiftSetting { get; set; }

    /// <summary>
    /// 班次名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 班次ID。
    /// </summary>
    public decimal? Id { get; set; }

    /// <summary>
    /// 卡段。
    /// </summary>
    public List<AttendanceShiftQueryResultSectionsItem> Sections { get; set; } = [];

    /// <summary>
    /// 班次组ID。
    /// </summary>
    [JsonPropertyName("shift_group_id")]
    public decimal? ShiftGroupId { get; set; }

    /// <summary>
    /// 班次负责人的userid。
    /// </summary>
    public string? Owner { get; set; }
}

/// <summary>
/// 班次设置信息。
/// </summary>
public class AttendanceShiftQueryResultShiftSetting
{
    /// <summary>
    /// 班次ID。
    /// </summary>
    [JsonPropertyName("shift_id")]
    public decimal? ShiftId { get; set; }

    /// <summary>
    /// 班次变更时间。
    /// </summary>
    [JsonPropertyName("gmt_modified")]
    public string? GmtModified { get; set; }

    /// <summary>
    /// 企业的corpid。
    /// </summary>
    [JsonPropertyName("corp_id")]
    public string? CorpId { get; set; }

    /// <summary>
    /// 工作时长，单位分钟，-1表示关闭该功能。
    /// </summary>
    [JsonPropertyName("work_time_minutes")]
    public decimal? WorkTimeMinutes { get; set; }

    /// <summary>
    /// 班次设置ID。
    /// </summary>
    public decimal? Id { get; set; }

    /// <summary>
    /// 该班次对应的出勤天数。
    /// </summary>
    [JsonPropertyName("attend_days")]
    public string? AttendDays { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    [JsonPropertyName("gmt_create")]
    public string? GmtCreate { get; set; }
}

/// <summary>
/// AttendanceShiftQueryResultSectionsItem
/// </summary>
public class AttendanceShiftQueryResultSectionsItem
{
    /// <summary>
    /// 卡点。
    /// </summary>
    public List<AttendanceShiftQueryResultSectionsItemPunchesItem> Punches { get; set; } = [];

    /// <summary>
    /// 休息时段信息。
    /// </summary>
    public List<AttendanceShiftQueryResultSectionsItemRestsItem> Rests { get; set; } = [];

    /// <summary>
    /// 卡段ID。一次上下班成为一个卡段，一个班次可能会有多个卡段。
    /// </summary>
    public decimal? Id { get; set; }
}

/// <summary>
/// AttendanceShiftQueryResultSectionsItemPunchesItem
/// </summary>
public class AttendanceShiftQueryResultSectionsItemPunchesItem
{
    /// <summary>
    /// 打卡类型：OnDuty：上班OffDuty：下班
    /// </summary>
    [JsonPropertyName("check_type")]
    public string? CheckType { get; set; }

    /// <summary>
    /// 允许的最晚的打卡时间。单位是分钟，用打卡时间加上分钟数可以计算出最晚打卡时间。
    /// </summary>
    [JsonPropertyName("end_min")]
    public decimal? EndMin { get; set; }

    /// <summary>
    /// 是否跨天，跨天是指打卡时间是第二天：0：不跨天1：跨天
    /// </summary>
    public decimal? Across { get; set; }

    /// <summary>
    /// 打卡时间，Unix时间戳，仅有时分秒信息。
    /// </summary>
    [JsonPropertyName("check_time")]
    public string? CheckTime { get; set; }

    /// <summary>
    /// 允许早退/迟到的时长，单位分钟。
    /// </summary>
    [JsonPropertyName("permit_minutes")]
    public decimal? PermitMinutes { get; set; }

    /// <summary>
    /// 是否免打卡：false：需打卡true：免打卡
    /// </summary>
    [JsonPropertyName("free_check")]
    public bool? FreeCheck { get; set; }

    /// <summary>
    /// 卡点ID。
    /// </summary>
    public decimal? Id { get; set; }

    /// <summary>
    /// 允许的最早提前打卡时间，分钟为单位。
    /// </summary>
    [JsonPropertyName("begin_min")]
    public decimal? BeginMin { get; set; }

    /// <summary>
    /// 旷工早退/迟到的时长，单位分钟。
    /// </summary>
    [JsonPropertyName("absenteeism_late_minutes")]
    public string? AbsenteeismLateMinutes { get; set; }

    /// <summary>
    /// 严重早退/迟到的时长，单位分钟。
    /// </summary>
    [JsonPropertyName("serious_late_minutes")]
    public string? SeriousLateMinutes { get; set; }
}

/// <summary>
/// AttendanceShiftQueryResultSectionsItemRestsItem
/// </summary>
public class AttendanceShiftQueryResultSectionsItemRestsItem
{
    /// <summary>
    /// 休息类型：OnDuty：休息开始OffDuty：休息结束
    /// </summary>
    [JsonPropertyName("check_type")]
    public string? CheckType { get; set; }

    /// <summary>
    /// 是否跨天，跨天是指休息时间是第二天：0：不跨天1：跨天
    /// </summary>
    public decimal? Across { get; set; }

    /// <summary>
    /// 休息时间。
    /// </summary>
    [JsonPropertyName("check_time")]
    public string? CheckTime { get; set; }

    /// <summary>
    /// 休息点ID。
    /// </summary>
    public decimal? Id { get; set; }
}
