using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models.Attendance;

#pragma warning disable CS1591
#pragma warning disable CS8618

/// <summary>
/// 查询是否启用智能统计报表请求
/// </summary>
public class AttendanceIsOpenSmartReportRequest
{
}

/// <summary>
/// 查询是否启用智能统计报表结果
/// </summary>
public class AttendanceIsOpenSmartReportResult
{
    /// <summary>
    /// 是否开启了智能统计报表：true：开启false：未开启
    /// </summary>
    [JsonPropertyName("smart_report")]
    public bool? SmartReport { get; set; }
}

/// <summary>
/// 获取用户考勤数据请求
/// </summary>
public class AttendanceGetUpdateDataRequest
{
    /// <summary>
    /// 用户的userId。
    /// </summary>
    public required string Userid { get; set; }

    /// <summary>
    /// 查询日期。
    /// </summary>
    [JsonPropertyName("work_date")]
    public required string WorkDate { get; set; }
}

/// <summary>
/// 获取用户考勤数据结果
/// </summary>
public class AttendanceGetUpdateDataResult
{
    /// <summary>
    /// 查询日期
    /// </summary>
    [JsonPropertyName("work_date")]
    public string? WorkDate { get; set; }

    /// <summary>
    /// 打卡结果。
    /// </summary>
    [JsonPropertyName("attendance_result_list")]
    public List<AttendanceGetUpdateDataResultAttendanceResultListItem> AttendanceResultList { get; set; } = [];

    /// <summary>
    /// 用户userId。
    /// </summary>
    public string? Userid { get; set; }

    /// <summary>
    /// 审批单列表。
    /// </summary>
    [JsonPropertyName("approve_list")]
    public List<AttendanceGetUpdateDataResultApproveListItem> ApproveList { get; set; } = [];

    /// <summary>
    /// 打卡详情。
    /// </summary>
    [JsonPropertyName("check_record_list")]
    public List<AttendanceGetUpdateDataResultCheckRecordListItem> CheckRecordList { get; set; } = [];

    /// <summary>
    /// 企业corpId。
    /// </summary>
    [JsonPropertyName("corpId")]
    public string? CorpId { get; set; }

    /// <summary>
    /// 当前排班对应的休息时间段。
    /// </summary>
    [JsonPropertyName("class_setting_info")]
    public AttendanceGetUpdateDataResultClassSettingInfo ClassSettingInfo { get; set; }
}

/// <summary>
/// AttendanceGetUpdateDataResultAttendanceResultListItem
/// </summary>
public class AttendanceGetUpdateDataResultAttendanceResultListItem
{
    /// <summary>
    /// 打卡流水id。
    /// </summary>
    [JsonPropertyName("record_id")]
    public decimal? RecordId { get; set; }

    /// <summary>
    /// 打卡来源。ATM：考勤机BEACON：IBeaconDING_ATM：钉钉考勤机USER：用户打卡BOSS：老板改签APPROVE：审批系统SYSTEM：考勤系统AUTO_CHECK：自动打卡
    /// </summary>
    [JsonPropertyName("source_type")]
    public string? SourceType { get; set; }

    /// <summary>
    /// 标准打卡时间。
    /// </summary>
    [JsonPropertyName("plan_check_time")]
    public string? PlanCheckTime { get; set; }

    /// <summary>
    /// 班次id。
    /// </summary>
    [JsonPropertyName("class_id")]
    public decimal? ClassId { get; set; }

    /// <summary>
    /// 定位方法。
    /// </summary>
    [JsonPropertyName("location_method")]
    public string? LocationMethod { get; set; }

    /// <summary>
    /// 定位结果。Normal：范围内Outside：范围外NotSigned：未打卡
    /// </summary>
    [JsonPropertyName("location_result")]
    public string? LocationResult { get; set; }

    /// <summary>
    /// 外勤备注。
    /// </summary>
    [JsonPropertyName("outside_remark")]
    public string? OutsideRemark { get; set; }

    /// <summary>
    /// 排班id。
    /// </summary>
    [JsonPropertyName("plan_id")]
    public decimal? PlanId { get; set; }

    /// <summary>
    /// 用户打卡地址。
    /// </summary>
    [JsonPropertyName("user_address")]
    public string? UserAddress { get; set; }

    /// <summary>
    /// 考勤组id。
    /// </summary>
    [JsonPropertyName("group_id")]
    public decimal? GroupId { get; set; }

    /// <summary>
    /// 用户打卡时间。
    /// </summary>
    [JsonPropertyName("user_check_time")]
    public string? UserCheckTime { get; set; }

    /// <summary>
    /// 审批单id。
    /// </summary>
    [JsonPropertyName("procInst_id")]
    public string? ProcInstId { get; set; }

    /// <summary>
    /// 打卡类型。OnDuty：上班OffDuty：下班
    /// </summary>
    [JsonPropertyName("check_type")]
    public string? CheckType { get; set; }

    /// <summary>
    /// 打卡的时间结果。Normal：正常Early：早退Late：迟到SeriousLate：严重迟到Absenteeism：旷工迟到NotSigned：未打卡
    /// </summary>
    [JsonPropertyName("time_result")]
    public string? TimeResult { get; set; }
}

/// <summary>
/// AttendanceGetUpdateDataResultApproveListItem
/// </summary>
public class AttendanceGetUpdateDataResultApproveListItem
{
    /// <summary>
    /// 审批单的单位。
    /// </summary>
    [JsonPropertyName("duration_unit")]
    public string? DurationUnit { get; set; }

    /// <summary>
    /// 时长。
    /// </summary>
    public string? Duration { get; set; }

    /// <summary>
    /// 子类型名称。
    /// </summary>
    [JsonPropertyName("sub_type")]
    public string? SubType { get; set; }

    /// <summary>
    /// 审批单类型名称。支持类型如下：请假出差外出加班
    /// </summary>
    [JsonPropertyName("tag_name")]
    public string? TagName { get; set; }

    /// <summary>
    /// 审批单ID。
    /// </summary>
    [JsonPropertyName("procInst_id")]
    public string? ProcInstId { get; set; }

    /// <summary>
    /// 审批单开始时间。
    /// </summary>
    [JsonPropertyName("begin_time")]
    public string? BeginTime { get; set; }

    /// <summary>
    /// 审批单类型：1：加班2：出差/外出3：请假
    /// </summary>
    [JsonPropertyName("biz_type")]
    public decimal? BizType { get; set; }

    /// <summary>
    /// 审批单结束时间。
    /// </summary>
    [JsonPropertyName("end_time")]
    public string? EndTime { get; set; }

    /// <summary>
    /// 审批单审批完成时间。
    /// </summary>
    [JsonPropertyName("gmt_finished")]
    public string? GmtFinished { get; set; }
}

/// <summary>
/// AttendanceGetUpdateDataResultCheckRecordListItem
/// </summary>
public class AttendanceGetUpdateDataResultCheckRecordListItem
{
    /// <summary>
    /// 打卡记录ID。
    /// </summary>
    [JsonPropertyName("record_id")]
    public decimal? RecordId { get; set; }

    /// <summary>
    /// 打卡来源。ATM：考勤机BEACON：IBeaconDING_ATM：钉钉考勤机USER：用户打卡BOSS：老板改签APPROVE：审批系统SYSTEM：考勤系统AUTO_CHECK：自动打卡
    /// </summary>
    [JsonPropertyName("source_type")]
    public string? SourceType { get; set; }

    /// <summary>
    /// 用户定位精度。
    /// </summary>
    [JsonPropertyName("user_accuracy")]
    public string? UserAccuracy { get; set; }

    /// <summary>
    /// 是否匹配打卡结果的流水。true：匹配false：不匹配
    /// </summary>
    [JsonPropertyName("valid_matched")]
    public bool? ValidMatched { get; set; }

    /// <summary>
    /// 用户打卡时间。
    /// </summary>
    [JsonPropertyName("user_check_time")]
    public string? UserCheckTime { get; set; }

    /// <summary>
    /// 打卡经度。
    /// </summary>
    [JsonPropertyName("user_longitude")]
    public string? UserLongitude { get; set; }

    /// <summary>
    /// wifi名称。
    /// </summary>
    [JsonPropertyName("user_ssid")]
    public string? UserSsid { get; set; }

    /// <summary>
    /// 基本定位精度。
    /// </summary>
    [JsonPropertyName("base_accuracy")]
    public string? BaseAccuracy { get; set; }

    /// <summary>
    /// MAC地址。
    /// </summary>
    [JsonPropertyName("user_mac_addr")]
    public string? UserMacAddr { get; set; }

    /// <summary>
    /// 打卡纬度。
    /// </summary>
    [JsonPropertyName("user_latitude")]
    public string? UserLatitude { get; set; }

    /// <summary>
    /// 打卡基础地址。
    /// </summary>
    [JsonPropertyName("base_address")]
    public string? BaseAddress { get; set; }

    /// <summary>
    /// 打卡无效的原因。
    /// </summary>
    [JsonPropertyName("invalid_record_msg")]
    public string? InvalidRecordMsg { get; set; }

    /// <summary>
    /// 打卡无效的类型。
    /// </summary>
    [JsonPropertyName("invalid_record_type")]
    public string? InvalidRecordType { get; set; }
}

/// <summary>
/// 当前排班对应的休息时间段。
/// </summary>
public class AttendanceGetUpdateDataResultClassSettingInfo
{
    /// <summary>
    /// restTimeVOList。
    /// </summary>
    [JsonPropertyName("rest_time_vo_list")]
    public List<AttendanceGetUpdateDataResultClassSettingInfoRestTimeVoListItem> RestTimeVoList { get; set; } = [];
}

/// <summary>
/// AttendanceGetUpdateDataResultClassSettingInfoRestTimeVoListItem
/// </summary>
public class AttendanceGetUpdateDataResultClassSettingInfoRestTimeVoListItem
{
    /// <summary>
    /// 休息结束时间。
    /// </summary>
    [JsonPropertyName("rest_end_time")]
    public decimal? RestEndTime { get; set; }

    /// <summary>
    /// 休息开始时间。
    /// </summary>
    [JsonPropertyName("rest_begin_time")]
    public decimal? RestBeginTime { get; set; }
}

/// <summary>
/// 获取报表假期数据请求
/// </summary>
public class AttendanceGetLeaveTimeByNamesRequest
{
    /// <summary>
    /// 用户的userid。
    /// </summary>
    public required string Userid { get; set; }

    /// <summary>
    /// 假期名称，多个用英文逗号分隔，最大长度20。
    /// </summary>
    [JsonPropertyName("leave_names")]
    public required string LeaveNames { get; set; }

    /// <summary>
    /// 开始时间。
    /// </summary>
    [JsonPropertyName("from_date")]
    public required string FromDate { get; set; }

    /// <summary>
    /// 结束时间，结束时间减去开始时间必须在31天以内。
    /// </summary>
    [JsonPropertyName("to_date")]
    public required string ToDate { get; set; }
}

/// <summary>
/// 获取报表假期数据结果
/// </summary>
public class AttendanceGetLeaveTimeByNamesResult
{
    /// <summary>
    /// 列信息与列值数据。
    /// </summary>
    public List<AttendanceGetLeaveTimeByNamesResultColumnsItem> Columns { get; set; } = [];
}

/// <summary>
/// AttendanceGetLeaveTimeByNamesResultColumnsItem
/// </summary>
public class AttendanceGetLeaveTimeByNamesResultColumnsItem
{
    /// <summary>
    /// 列信息。
    /// </summary>
    public AttendanceGetLeaveTimeByNamesResultColumnsItemColumnvo Columnvo { get; set; }

    /// <summary>
    /// 列值数据。
    /// </summary>
    public List<AttendanceGetLeaveTimeByNamesResultColumnsItemColumnvalsItem> Columnvals { get; set; } = [];
}

/// <summary>
/// 列信息。
/// </summary>
public class AttendanceGetLeaveTimeByNamesResultColumnsItemColumnvo
{
    /// <summary>
    /// 假期名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 子类型。
    /// </summary>
    [JsonPropertyName("sub_type")]
    public decimal? SubType { get; set; }

    /// <summary>
    /// 列状态。
    /// </summary>
    public decimal? Status { get; set; }

    /// <summary>
    /// 别名。
    /// </summary>
    public string? Alias { get; set; }

    /// <summary>
    /// 列类型。
    /// </summary>
    public decimal? Type { get; set; }

    /// <summary>
    /// 报表列ID。
    /// </summary>
    public decimal? Id { get; set; }
}

/// <summary>
/// AttendanceGetLeaveTimeByNamesResultColumnsItemColumnvalsItem
/// </summary>
public class AttendanceGetLeaveTimeByNamesResultColumnsItemColumnvalsItem
{
    /// <summary>
    /// 每天的值。
    /// </summary>
    public string? Value { get; set; }

    /// <summary>
    /// 开始时间。
    /// </summary>
    public string? Date { get; set; }
}

/// <summary>
/// 获取考勤报表列定义请求
/// </summary>
public class AttendanceGetAttColumnsRequest
{
}

/// <summary>
/// 获取考勤报表列定义结果
/// </summary>
public class AttendanceGetAttColumnsResult
{
    /// <summary>
    /// 报表列信息。
    /// </summary>
    public List<AttendanceGetAttColumnsResultColumnsItem> Columns { get; set; } = [];
}

/// <summary>
/// AttendanceGetAttColumnsResultColumnsItem
/// </summary>
public class AttendanceGetAttColumnsResultColumnsItem
{
    /// <summary>
    /// 报表列ID。
    /// </summary>
    public decimal? Id { get; set; }

    /// <summary>
    /// 报表列类型。
    /// </summary>
    public decimal? Type { get; set; }

    /// <summary>
    /// 报表列名。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 列报表。
    /// </summary>
    public string? Alias { get; set; }

    /// <summary>
    /// 报表列的状态。
    /// </summary>
    public decimal? Status { get; set; }

    /// <summary>
    /// 子类型。
    /// </summary>
    [JsonPropertyName("sub_type")]
    public decimal? SubType { get; set; }

    /// <summary>
    /// 废弃字段，勿用此字段处理业务。
    /// </summary>
    [JsonPropertyName("expression_id")]
    public decimal? ExpressionId { get; set; }
}

/// <summary>
/// 获取考勤报表列值请求
/// </summary>
public class AttendanceGetColumnValRequest
{
    /// <summary>
    /// 用户的userid。
    /// </summary>
    public required string Userid { get; set; }

    /// <summary>
    /// 报表列ID，多值用英文逗号分隔，最大长度20，可通过获取报表列定义接口获取。
    /// </summary>
    [JsonPropertyName("column_id_list")]
    public required string ColumnIdList { get; set; }

    /// <summary>
    /// 开始时间。
    /// </summary>
    [JsonPropertyName("from_date")]
    public required string FromDate { get; set; }

    /// <summary>
    /// 结束时间，结束时间减去开始时间必须在31天以内。
    /// </summary>
    [JsonPropertyName("to_date")]
    public required string ToDate { get; set; }
}

/// <summary>
/// 获取考勤报表列值结果
/// </summary>
public class AttendanceGetColumnValResult
{
    /// <summary>
    /// 列信息与列值数据。
    /// </summary>
    [JsonPropertyName("column_vals")]
    public List<AttendanceGetColumnValResultColumnValsItem> ColumnVals { get; set; } = [];
}

/// <summary>
/// AttendanceGetColumnValResultColumnValsItem
/// </summary>
public class AttendanceGetColumnValResultColumnValsItem
{
    /// <summary>
    /// 列值数据。
    /// </summary>
    [JsonPropertyName("column_vals")]
    public List<AttendanceGetColumnValResultColumnValsItemColumnValsItem> ColumnVals { get; set; } = [];

    /// <summary>
    /// 列信息。
    /// </summary>
    [JsonPropertyName("column_vo")]
    public AttendanceGetColumnValResultColumnValsItemColumnVo ColumnVo { get; set; }

    /// <summary>
    /// 固定值。某些报表列是固定列值的，那么仅会在这个字段返回，不会在column_vals中返回。
    /// </summary>
    [JsonPropertyName("fixed_value")]
    public string? FixedValue { get; set; }
}

/// <summary>
/// AttendanceGetColumnValResultColumnValsItemColumnValsItem
/// </summary>
public class AttendanceGetColumnValResultColumnValsItemColumnValsItem
{
    /// <summary>
    /// 日期。
    /// </summary>
    public string? Date { get; set; }

    /// <summary>
    /// 列值。
    /// </summary>
    public string? Value { get; set; }
}

/// <summary>
/// 列信息。
/// </summary>
public class AttendanceGetColumnValResultColumnValsItemColumnVo
{
    /// <summary>
    /// 报表列ID。
    /// </summary>
    public decimal? Id { get; set; }
}
