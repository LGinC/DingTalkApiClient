using System.Text.Json.Serialization;

namespace DingTalkApi.Models.Attendance;

#pragma warning disable CS1591
#pragma warning disable CS8618

/// <summary>
/// 查询考勤写操作权限请求
/// </summary>
public class AttendanceWritePermissionsQueryRequest
{
    /// <summary>
    /// 员工userId。
    /// </summary>
    [JsonPropertyName("opUserId")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 资源类型： GROUP：考勤组，目前仅支持该值。
    /// </summary>
    public required string Category { get; set; }

    /// <summary>
    /// 权限点： GROUP_MEMBER：设置参与考勤人员 GROUP_NAME：修改考勤组名称 GROUP_TYPE：设置考勤组类型 CHECK_TIME：设置考勤时间 SCHEDULE：员工排班 CHECK_POSITION_TYPE：设置打卡方式 OVER_TIME_RULE：设置加班规则 CAMERA_CHECK：拍照验证规则 OUT_SIDE_CHECK：设置外勤打卡 MANAGE：考勤组子负责人 OWNER：考勤组主负责人 DELETE_GROUP：删除考勤组
    /// </summary>
    [JsonPropertyName("resourceKey")]
    public required string ResourceKey { get; set; }

    /// <summary>
    /// 资源ID，如果category参数值为GROUP，该参数值传考勤组ID。 企业内部应用，调用获取用户考勤组接口获取group_id参数值。 第三方企业应用，调用获取用户考勤组接口获取group_id参数值。
    /// </summary>
    [JsonPropertyName("entityIds")]
    public List<long> EntityIds { get; set; } = [];
}

/// <summary>
/// 查询考勤写操作权限响应
/// </summary>
public class AttendanceWritePermissionsQueryResponse
{
    /// <summary>
    /// 权限结果。 返回示例：{&quot;entityPermissionMap&quot;:{&quot;key&quot;:value}}。 key，指资源ID，即请求参数entityIds的值。 value，指是否有权限。 true：有权限。 false：无权限。
    /// </summary>
    [JsonPropertyName("entityPermissionMap")]
    public AttendanceWritePermissionsQueryResponseEntityPermissionMap EntityPermissionMap { get; set; }
}

/// <summary>
/// 权限结果。 返回示例：{&quot;entityPermissionMap&quot;:{&quot;key&quot;:value}}。 key，指资源ID，即请求参数entityIds的值。 value，指是否有权限。 true：有权限。 false：无权限。
/// </summary>
public class AttendanceWritePermissionsQueryResponseEntityPermissionMap
{
    /// <summary>
    /// 资源ID对应的权限结果，值表示是否有权限。
    /// </summary>
    public bool Key { get; set; }
}

/// <summary>
/// 配置考勤排班附加信息请求
/// </summary>
public class AttendanceSchedulesAdditionalInfoPutRequest
{
    /// <summary>
    /// 排班信息列表。
    /// </summary>
    [JsonPropertyName("scheduleInfos")]
    public List<AttendanceSchedulesAdditionalInfoPutRequestScheduleInfosItem> ScheduleInfos { get; set; } = [];

    /// <summary>
    /// 操作者的userId。
    /// </summary>
    [JsonPropertyName("opUserId")]
    public required string OpUserId { get; set; }
}

/// <summary>
/// AttendanceSchedulesAdditionalInfoPutRequestScheduleInfosItem
/// </summary>
public class AttendanceSchedulesAdditionalInfoPutRequestScheduleInfosItem
{
    /// <summary>
    /// 待添加的WIFI列表。
    /// </summary>
    [JsonPropertyName("wifiKeys")]
    public List<string> WifiKeys { get; set; } = [];

    /// <summary>
    /// 待添加的位置列表。
    /// </summary>
    [JsonPropertyName("positionKeys")]
    public List<string> PositionKeys { get; set; } = [];

    /// <summary>
    /// 待更新的排班ID。 企业内部应用，可调用查询企业考勤排班详情接口获取。
    /// </summary>
    [JsonPropertyName("planId")]
    public required string PlanId { get; set; }
}

/// <summary>
/// 配置考勤排班附加信息响应
/// </summary>
public class AttendanceSchedulesAdditionalInfoPutResponse
{
}

/// <summary>
/// 分页获取加班规则列表响应
/// </summary>
public class AttendanceOvertimeSettingsGetResponse
{
    /// <summary>
    /// 获取的结果。
    /// </summary>
    public AttendanceOvertimeSettingsGetResponseResult Result { get; set; }
}

/// <summary>
/// 获取的结果。
/// </summary>
public class AttendanceOvertimeSettingsGetResponseResult
{
    /// <summary>
    /// 当前页码。
    /// </summary>
    [JsonPropertyName("pageNumber")]
    public long PageNumber { get; set; }

    /// <summary>
    /// 总页数。
    /// </summary>
    [JsonPropertyName("totalPage")]
    public long TotalPage { get; set; }

    /// <summary>
    /// 加班规则列表。
    /// </summary>
    public List<AttendanceOvertimeSettingsGetResponseResultItemsItem> Items { get; set; } = [];
}

/// <summary>
/// AttendanceOvertimeSettingsGetResponseResultItemsItem
/// </summary>
public class AttendanceOvertimeSettingsGetResponseResultItemsItem
{
    /// <summary>
    /// 加班规则ID。
    /// </summary>
    public long? Id { get; set; }

    /// <summary>
    /// 加班规则名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 加班规则settingId。
    /// </summary>
    [JsonPropertyName("settingId")]
    public long? SettingId { get; set; }
}

/// <summary>
/// 分页获取补卡规则列表响应
/// </summary>
public class AttendanceAdjustmentsGetResponse
{
    /// <summary>
    /// 获取的结果。
    /// </summary>
    public AttendanceAdjustmentsGetResponseResult Result { get; set; }
}

/// <summary>
/// 获取的结果。
/// </summary>
public class AttendanceAdjustmentsGetResponseResult
{
    /// <summary>
    /// 当前页码。
    /// </summary>
    [JsonPropertyName("pageNumber")]
    public long PageNumber { get; set; }

    /// <summary>
    /// 总页数。
    /// </summary>
    [JsonPropertyName("totalPage")]
    public long TotalPage { get; set; }

    /// <summary>
    /// 补卡规则列表。
    /// </summary>
    public List<AttendanceAdjustmentsGetResponseResultItemsItem> Items { get; set; } = [];
}

/// <summary>
/// AttendanceAdjustmentsGetResponseResultItemsItem
/// </summary>
public class AttendanceAdjustmentsGetResponseResultItemsItem
{
    /// <summary>
    /// 补卡规则ID。
    /// </summary>
    public long? Id { get; set; }

    /// <summary>
    /// 补卡规则名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 补卡规则settingId。
    /// </summary>
    [JsonPropertyName("settingId")]
    public long? SettingId { get; set; }
}

/// <summary>
/// 批量获取加班规则设置请求
/// </summary>
public class AttendanceOvertimeSettingsQueryRequest
{
    /// <summary>
    /// 加班规则设置id。 企业内部应用，调用查询成员排班信息接口获取，对应features内的overtimeSettingId字段。 第三方企业应用，调用查询成员排班信息接口获取，对应features内的overtimeSettingId字段。
    /// </summary>
    [JsonPropertyName("overtimeSettingIds")]
    public List<long> OvertimeSettingIds { get; set; } = [];
}

/// <summary>
/// 批量获取加班规则设置响应
/// </summary>
public class AttendanceOvertimeSettingsQueryResponse
{
    /// <summary>
    /// 加班设置详情列表。
    /// </summary>
    public List<AttendanceOvertimeSettingsQueryResponseResultItem> Result { get; set; } = [];
}

/// <summary>
/// AttendanceOvertimeSettingsQueryResponseResultItem
/// </summary>
public class AttendanceOvertimeSettingsQueryResponseResultItem
{
    /// <summary>
    /// 设置ID。
    /// </summary>
    [JsonPropertyName("settingId")]
    public long? SettingId { get; set; }

    /// <summary>
    /// 规则名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 是否默认。 true：是 false：不是
    /// </summary>
    public bool? Default { get; set; }

    /// <summary>
    /// 加班规则日期类型列表。
    /// </summary>
    [JsonPropertyName("durationSettings")]
    public AttendanceOvertimeSettingsQueryResponseResultItemDurationSettings DurationSettings { get; set; }

    /// <summary>
    /// 预警设置部分。
    /// </summary>
    [JsonPropertyName("warningSettings")]
    public List<AttendanceOvertimeSettingsQueryResponseResultItemWarningSettingsItem> WarningSettings { get; set; } = [];

    /// <summary>
    /// 加班时长单位。
    /// </summary>
    [JsonPropertyName("stepType")]
    public long? StepType { get; set; }

    /// <summary>
    /// 加班时长是否取整，单位：小时 ，取值： 1：不取整 其他值：按步长值向下取整及步长值
    /// </summary>
    [JsonPropertyName("stepValue")]
    public long? StepValue { get; set; }

    /// <summary>
    /// 日折算时长 单位：分钟。
    /// </summary>
    [JsonPropertyName("workMinutesPerDay")]
    public long? WorkMinutesPerDay { get; set; }

    /// <summary>
    /// 时间分割规则。
    /// </summary>
    [JsonPropertyName("overtimeDivisions")]
    public List<AttendanceOvertimeSettingsQueryResponseResultItemOvertimeDivisionsItem> OvertimeDivisions { get; set; } = [];

    /// <summary>
    /// 历史加班规则设置ID。
    /// </summary>
    public long? Id { get; set; }
}

/// <summary>
/// 加班规则日期类型列表。
/// </summary>
public class AttendanceOvertimeSettingsQueryResponseResultItemDurationSettings
{
    /// <summary>
    /// 加班规则日期类型设置。
    /// </summary>
    public AttendanceOvertimeSettingsQueryResponseResultItemDurationSettingsKey Key { get; set; }
}

/// <summary>
/// AttendanceOvertimeSettingsQueryResponseResultItemDurationSettingsKey
/// </summary>
public class AttendanceOvertimeSettingsQueryResponseResultItemDurationSettingsKey
{
    /// <summary>
    /// 加班是否需要填写审批单，取值： 1： 需要提交审批单 2：无需提交审批单 3： 不允许加班
    /// </summary>
    [JsonPropertyName("calcType")]
    public long CalcType { get; set; }

    /// <summary>
    /// 计算方式，取值： 1：按审批单时长计算 2：按打卡时长计算。
    /// </summary>
    [JsonPropertyName("durationType")]
    public long DurationType { get; set; }

    /// <summary>
    /// 加班时长计为调休或加班费开关。
    /// </summary>
    [JsonPropertyName("overtimeRedress")]
    public bool OvertimeRedress { get; set; }

    /// <summary>
    /// 加班时长计为方式，取值： vacation：计为调休 charge：计为加班费 manual：员工自主选择
    /// </summary>
    [JsonPropertyName("overtimeRedressBy")]
    public required string OvertimeRedressBy { get; set; }

    /// <summary>
    /// 调休时长计算比例。
    /// </summary>
    [JsonPropertyName("vacationRate")]
    public long VacationRate { get; set; }

    /// <summary>
    /// 扣除休息时间，取值： frame： 按休息时段扣除 duration：按加班时长扣除
    /// </summary>
    [JsonPropertyName("skipTime")]
    public required string SkipTime { get; set; }

    /// <summary>
    /// 按休息时段扣除。 说明 只有skipTime等于frame时，才有值。
    /// </summary>
    [JsonPropertyName("skipTimeByFrames")]
    public List<AttendanceOvertimeSettingsQueryResponseResultItemDurationSettingsKeySkipTimeByFramesItem> SkipTimeByFrames { get; set; } = [];

    /// <summary>
    /// 按加班时长扣除。 说明 只有skipTime等于duration才有值。
    /// </summary>
    [JsonPropertyName("skipTimeByDurations")]
    public List<AttendanceOvertimeSettingsQueryResponseResultItemDurationSettingsKeySkipTimeByDurationsItem> SkipTimeByDurations { get; set; } = [];

    /// <summary>
    /// 休息日或节假日排班加班时长计为调休或加班费开关。
    /// </summary>
    [JsonPropertyName("holidayPlanOvertimeRedress")]
    public bool HolidayPlanOvertimeRedress { get; set; }

    /// <summary>
    /// 休息日或节假日排班加班时长计为方式，取值： vacation：计为调休 charge：计为加班费 manual：员工自主选择
    /// </summary>
    [JsonPropertyName("holidayPlanOvertimeRedressBy")]
    public required string HolidayPlanOvertimeRedressBy { get; set; }

    /// <summary>
    /// 休息日或节假日排班调休时长计算比例。
    /// </summary>
    [JsonPropertyName("holidayPlanVacationRate")]
    public long HolidayPlanVacationRate { get; set; }
}

/// <summary>
/// AttendanceOvertimeSettingsQueryResponseResultItemDurationSettingsKeySkipTimeByFramesItem
/// </summary>
public class AttendanceOvertimeSettingsQueryResponseResultItemDurationSettingsKeySkipTimeByFramesItem
{
    /// <summary>
    /// 开始时间，格式为HH:mm。
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>
    /// 结束时间，格式为HH:mm。
    /// </summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>
    /// 是否生效。 true：生效 false：不生效
    /// </summary>
    public bool? Valid { get; set; }
}

/// <summary>
/// AttendanceOvertimeSettingsQueryResponseResultItemDurationSettingsKeySkipTimeByDurationsItem
/// </summary>
public class AttendanceOvertimeSettingsQueryResponseResultItemDurationSettingsKeySkipTimeByDurationsItem
{
    /// <summary>
    /// 每天加班满时长，单位：秒。
    /// </summary>
    public long? Duration { get; set; }

    /// <summary>
    /// 扣除时长，单位：秒。
    /// </summary>
    public long? Minus { get; set; }
}

/// <summary>
/// AttendanceOvertimeSettingsQueryResponseResultItemWarningSettingsItem
/// </summary>
public class AttendanceOvertimeSettingsQueryResponseResultItemWarningSettingsItem
{
    /// <summary>
    /// 预警类型，取值： everyday： 每日 everyweek：每周 everymonth：每月
    /// </summary>
    public string? Time { get; set; }

    /// <summary>
    /// 提醒阈值。
    /// </summary>
    public long? Threshold { get; set; }

    /// <summary>
    /// 取值为风险预警或最大加班时间。
    /// </summary>
    public string? Action { get; set; }
}

/// <summary>
/// AttendanceOvertimeSettingsQueryResponseResultItemOvertimeDivisionsItem
/// </summary>
public class AttendanceOvertimeSettingsQueryResponseResultItemOvertimeDivisionsItem
{
    /// <summary>
    /// 前一日类型。
    /// </summary>
    [JsonPropertyName("previousDayType")]
    public string? PreviousDayType { get; set; }

    /// <summary>
    /// 后一日类型。
    /// </summary>
    [JsonPropertyName("nextDayType")]
    public string? NextDayType { get; set; }

    /// <summary>
    /// 分割时间点。
    /// </summary>
    [JsonPropertyName("timeSplitPoint")]
    public string? TimeSplitPoint { get; set; }
}

/// <summary>
/// 查询用户某段时间内是否处于封账状态请求
/// </summary>
public class AttendanceClosingAccountsStatusQueryRequest
{
    /// <summary>
    /// 员工列表。
    /// </summary>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; } = [];

    /// <summary>
    /// 时间段。
    /// </summary>
    [JsonPropertyName("userTimeRange")]
    public List<AttendanceClosingAccountsStatusQueryRequestUserTimeRangeItem> UserTimeRange { get; set; } = [];

    /// <summary>
    /// 情景： BOSS_CHECK：老板改签 SCHEDULE：排班 APPROVE：补卡 SPECIAL_DAYS：特殊日期修改
    /// </summary>
    [JsonPropertyName("bizCode")]
    public required string BizCode { get; set; }
}

/// <summary>
/// AttendanceClosingAccountsStatusQueryRequestUserTimeRangeItem
/// </summary>
public class AttendanceClosingAccountsStatusQueryRequestUserTimeRangeItem
{
    /// <summary>
    /// 开始日期，Unix时间戳，单位毫秒。
    /// </summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }

    /// <summary>
    /// 结束日期，Unix时间戳，单位毫秒。
    /// </summary>
    [JsonPropertyName("endTime")]
    public required string EndTime { get; set; }
}

/// <summary>
/// 查询用户某段时间内是否处于封账状态响应
/// </summary>
public class AttendanceClosingAccountsStatusQueryResponse
{
    /// <summary>
    /// 返回码描述。
    /// </summary>
    public required string Mesage { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    public required string Code { get; set; }

    /// <summary>
    /// 处于封账期间返回false，否则返回true。
    /// </summary>
    public bool Pass { get; set; }
}

/// <summary>
/// 预计算时长（新版SDK）请求
/// </summary>
public class AttendanceApprovalsDurationsCalculateRequest
{
    /// <summary>
    /// 开始时间。开始时间不能早于当前时间前31天。支持以下格式： 2019-08-15 2019-08-15 AM 2019-08-15 12:43
    /// </summary>
    [JsonPropertyName("fromTime")]
    public required string FromTime { get; set; }

    /// <summary>
    /// 结束时间。 biz_type为1时，结束时间减去开始时间不能超过1天。 biz_type为2或3时，结束时间减去开始时间的天数不能超过31天。 支持以下格式： 2019-08-15 2019-08-15 AM 2019-08-15 12:43
    /// </summary>
    [JsonPropertyName("toTime")]
    public required string ToTime { get; set; }

    /// <summary>
    /// 时长单位，支持格式如下： day halfDay hour：biz_type为1时仅支持hour。 时间格式必须与时长单位对应： 2019-08-15对应day 2019-08-15 AM对应halfDay 2019-08-15 12:43对应hour
    /// </summary>
    [JsonPropertyName("durationUnit")]
    public required string DurationUnit { get; set; }

    /// <summary>
    /// 假期规则唯一标识。选填 仅支持bizType=3 请假时传不为空，可以支持根据假期类型设置的取整规则进行时长取整。
    /// </summary>
    [JsonPropertyName("leaveCode")]
    public required string LeaveCode { get; set; }
}

/// <summary>
/// 预计算时长（新版SDK）响应
/// </summary>
public class AttendanceApprovalsDurationsCalculateResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    public AttendanceApprovalsDurationsCalculateResponseResult Result { get; set; }

    /// <summary>
    /// 接口调用是否成功。
    /// </summary>
    public bool Success { get; set; }
}

/// <summary>
/// 返回结果。
/// </summary>
public class AttendanceApprovalsDurationsCalculateResponseResult
{
    /// <summary>
    /// 总时长，该字段的单位与本企业内对应审批单设置的单位一致。
    /// </summary>
    public long Duration { get; set; }

    /// <summary>
    /// 详细信息。
    /// </summary>
    [JsonPropertyName("durationDetail")]
    public List<AttendanceApprovalsDurationsCalculateResponseResultDurationDetailItem> DurationDetail { get; set; } = [];
}

/// <summary>
/// AttendanceApprovalsDurationsCalculateResponseResultDurationDetailItem
/// </summary>
public class AttendanceApprovalsDurationsCalculateResponseResultDurationDetailItem
{
    /// <summary>
    /// 日期。
    /// </summary>
    public string? Date { get; set; }

    /// <summary>
    /// 每日时长，该字段的单位与本企业内对应审批单设置的单位一致。
    /// </summary>
    public decimal? Duration { get; set; }
}

/// <summary>
/// 通知审批通过(新版SDK)请求
/// </summary>
public class AttendanceApprovalsFinishRequest
{
    /// <summary>
    /// 时长相关入参。
    /// </summary>
    [JsonPropertyName("topCalculateApproveDurationParam")]
    public AttendanceApprovalsFinishRequestTopCalculateApproveDurationParam TopCalculateApproveDurationParam { get; set; }

    /// <summary>
    /// 审批单类型名称，最大长度20个字符。 支持类型如下： 请假 出差 外出 加班
    /// </summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }

    /// <summary>
    /// 子类型名称，最大长度20个字符。 说明 审批单类型biz_type=3时，该参数必传。
    /// </summary>
    [JsonPropertyName("subType")]
    public string? SubType { get; set; }

    /// <summary>
    /// 审批单ID，最大长度100个字符，自定义值。
    /// </summary>
    [JsonPropertyName("approveId")]
    public string? ApproveId { get; set; }

    /// <summary>
    /// 审批单跳转地址，最大长度200个字符。
    /// </summary>
    [JsonPropertyName("jumpUrl")]
    public string? JumpUrl { get; set; }

    /// <summary>
    /// biz_type为1时必传，加班时长单位小时。
    /// </summary>
    [JsonPropertyName("overtimeDuration")]
    public string? OvertimeDuration { get; set; }
}

/// <summary>
/// 时长相关入参。
/// </summary>
public class AttendanceApprovalsFinishRequestTopCalculateApproveDurationParam
{
    /// <summary>
    /// 开始时间。开始时间不能早于当前时间前31天。 支持以下格式： 2019-08-15 2019-08-15 AM 2019-08-15 12:43
    /// </summary>
    [JsonPropertyName("fromTime")]
    public string? FromTime { get; set; }

    /// <summary>
    /// 结束时间。 支持以下格式： 2019-08-15 2019-08-15 AM 2019-08-15 12:43 说明 结束时间减去开始时间的天数不能超过31天。 biz_type为1时，结束时间减去开始时间的天数不能超过1天。
    /// </summary>
    [JsonPropertyName("toTime")]
    public string? ToTime { get; set; }

    /// <summary>
    /// 时长单位，支持格式如下： day halfDay hour：biz_type为1时仅支持hour。 时间格式必须与时长单位对应： 2019-08-15对应day 2019-08-15 AM对应halfDay 2019-08-15 12:43对应hour
    /// </summary>
    [JsonPropertyName("durationUnit")]
    public string? DurationUnit { get; set; }

    /// <summary>
    /// 假期规则唯一标识。选填。 仅支持bizType=3 请假时传不为空，可以支持根据假期类型设置的取整规则进行时长取整。
    /// </summary>
    [JsonPropertyName("leaveCode")]
    public string? LeaveCode { get; set; }
}

/// <summary>
/// 通知审批通过(新版SDK)响应
/// </summary>
public class AttendanceApprovalsFinishResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    public AttendanceApprovalsFinishResponseResult Result { get; set; }

    /// <summary>
    /// 接口调用是否成功。
    /// </summary>
    public bool Success { get; set; }
}

/// <summary>
/// 返回结果。
/// </summary>
public class AttendanceApprovalsFinishResponseResult
{
    /// <summary>
    /// 总时长，该字段的单位与本企业内对应审批单设置的单位一致。
    /// </summary>
    public long Duration { get; set; }

    /// <summary>
    /// 详细信息。
    /// </summary>
    [JsonPropertyName("durationDetail")]
    public List<AttendanceApprovalsFinishResponseResultDurationDetailItem> DurationDetail { get; set; } = [];
}

/// <summary>
/// AttendanceApprovalsFinishResponseResultDurationDetailItem
/// </summary>
public class AttendanceApprovalsFinishResponseResultDurationDetailItem
{
    /// <summary>
    /// 审批通过日期。
    /// </summary>
    public string? Date { get; set; }

    /// <summary>
    /// 每日时长。
    /// </summary>
    public long? Duration { get; set; }
}

/// <summary>
/// 添加假期规则请求
/// </summary>
public class AttendanceLeavesTypesRequest
{
    /// <summary>
    /// 假期规则名称。
    /// </summary>
    [JsonPropertyName("leaveName")]
    public required string LeaveName { get; set; }

    /// <summary>
    /// 请假时长单位。 day：天 halfDay：半天 hour：小时
    /// </summary>
    [JsonPropertyName("leaveViewUnit")]
    public required string LeaveViewUnit { get; set; }

    /// <summary>
    /// 假期类型。 general_leave：普通假期 lieu_leave：加班转调休 说明 一个企业只能存在一个加班转调休的假期规则。
    /// </summary>
    [JsonPropertyName("bizType")]
    public required string BizType { get; set; }

    /// <summary>
    /// 是否按照自然日统计请假时长。 true：是 false：否 说明 例如，员工小明提交请假审批单，开始时间是2022年4月11日上午9:30，结束时间是2022年4月18日下午18:30，其中4月16和4月17为周六日休息。 当该参数传true时，小明发起该请假审批单后，计入的请假天数为8天。包含员工未排班的休息日或者法定节假日。 当该参数传false时，小明发起该请假审批单后，计入的请假天数为6天。不包含员工未排班的休息日或者法定节假日。
    /// </summary>
    [JsonPropertyName("naturalDayLeave")]
    public bool NaturalDayLeave { get; set; }

    /// <summary>
    /// 每天折算的工作时长，为参数值的百分之一。 **说明** 例如，某企业员工所在的班次工时是8小时，则该参数值为8*100=800。 ![img](https://img.alicdn.com/imgextra/i2/O1CN01Cr8zh3288kv0CyFwm_!!6000000007888-2-tps-2810-1382.png)
    /// </summary>
    [JsonPropertyName("hoursInPerDay")]
    public long HoursInPerDay { get; set; }

    /// <summary>
    /// 调休假有效期规则。 validity_type：有效类型 absolute_time：绝对时间 relative_time：相对时间 validity_value：延长日期 当validity_type为absolute_time，该值不为空且满足“yy-mm”格式。 当validity_type为relative_time，该值为大于1的整数。 说明 假期类型biz_type值为lieu_leave时，该参数必传。
    /// </summary>
    public string? Extras { get; set; }

    /// <summary>
    /// 适用范围规则列表，不传默认为全公司。
    /// </summary>
    [JsonPropertyName("visibilityRules")]
    public List<AttendanceLeavesTypesRequestVisibilityRulesItem> VisibilityRules { get; set; } = [];

    /// <summary>
    /// 限时提交规则。
    /// </summary>
    [JsonPropertyName("submitTimeRule")]
    public AttendanceLeavesTypesRequestSubmitTimeRule SubmitTimeRule { get; set; }

    /// <summary>
    /// 请假证明。
    /// </summary>
    [JsonPropertyName("leaveCertificate")]
    public AttendanceLeavesTypesRequestLeaveCertificate LeaveCertificate { get; set; }
}

/// <summary>
/// AttendanceLeavesTypesRequestVisibilityRulesItem
/// </summary>
public class AttendanceLeavesTypesRequestVisibilityRulesItem
{
    /// <summary>
    /// 适用范围内数据列表。 当type=staff时，传员工userId列表。 当type=dept时，传部门id列表。 当type=label时，传角色id列表。
    /// </summary>
    public List<string> Visible { get; set; } = [];

    /// <summary>
    /// 适用范围规则类型。 dept：部门 staff：员工 label：角色
    /// </summary>
    public string? Type { get; set; }
}

/// <summary>
/// 限时提交规则。
/// </summary>
public class AttendanceLeavesTypesRequestSubmitTimeRule
{
    /// <summary>
    /// 限制值。 当timeUnit为day时，有效值范围是0至30天。 当timeUnit为hour时，有效值范围是0至24小时。
    /// </summary>
    [JsonPropertyName("timeValue")]
    public long? TimeValue { get; set; }

    /// <summary>
    /// 时间单位。 day：天 hour：小时
    /// </summary>
    [JsonPropertyName("timeUnit")]
    public string? TimeUnit { get; set; }

    /// <summary>
    /// 限制类型。 before：提前 after：补交
    /// </summary>
    [JsonPropertyName("timeType")]
    public string? TimeType { get; set; }

    /// <summary>
    /// 是否开启限时提交功能。 true：开启 false：不开启
    /// </summary>
    [JsonPropertyName("enableTimeLimit")]
    public bool? EnableTimeLimit { get; set; }
}

/// <summary>
/// 请假证明。
/// </summary>
public class AttendanceLeavesTypesRequestLeaveCertificate
{
    /// <summary>
    /// 需提供请假证明时长单位。 hour：小时 day：天
    /// </summary>
    public string? Unit { get; set; }

    /// <summary>
    /// 超过多长时间需提供请假证明。 - 如果unit值为day，表示请假超过一天，需要提供请假证明。 - 如果unit值为hour，表示请假超过一小时，需要提供请假证明。 **说明** 提交请假超过设置时间，审批单会自动出现请假证明填写项。 ![img](https://img.alicdn.com/imgextra/i4/O1CN01ZlyMM61vHplHMaWfG_!!6000000006148-2-tps-658-1276.png)
    /// </summary>
    public long? Duration { get; set; }

    /// <summary>
    /// 是否开启请假证明。 true：开启 false：不开启
    /// </summary>
    public bool? Enable { get; set; }

    /// <summary>
    /// 请假提示文案。
    /// </summary>
    [JsonPropertyName("promptInformation")]
    public string? PromptInformation { get; set; }
}

/// <summary>
/// 添加假期规则响应
/// </summary>
public class AttendanceLeavesTypesResponse
{
    /// <summary>
    /// 返回信息。
    /// </summary>
    public AttendanceLeavesTypesResponseResult Result { get; set; }
}

/// <summary>
/// 返回信息。
/// </summary>
public class AttendanceLeavesTypesResponseResult
{
    /// <summary>
    /// 假期名称。
    /// </summary>
    [JsonPropertyName("leaveName")]
    public required string LeaveName { get; set; }

    /// <summary>
    /// 假期规则唯一标识。
    /// </summary>
    [JsonPropertyName("leaveCode")]
    public required string LeaveCode { get; set; }

    /// <summary>
    /// 请假单位。 day：天 halfDay：半天 hour：小时
    /// </summary>
    [JsonPropertyName("leaveViewUnit")]
    public required string LeaveViewUnit { get; set; }

    /// <summary>
    /// 假期类型。 general_leave：普通假期 lieu_leave：加班转调休
    /// </summary>
    [JsonPropertyName("bizType")]
    public required string BizType { get; set; }

    /// <summary>
    /// 是否按照自然日统计请假时长。 true：是 false：否 说明 当为false的时候，用户发起请假时候会根据用户在请假时间段内的排班情况来计算请假时长。
    /// </summary>
    [JsonPropertyName("naturalDayLeave")]
    public bool NaturalDayLeave { get; set; }

    /// <summary>
    /// 每天折算的工作时长，为参数值的百分之一。 例如，某企业每天的工作时长设置为10小时，则该参数值为10*100=1000。
    /// </summary>
    [JsonPropertyName("hoursInPerDay")]
    public long HoursInPerDay { get; set; }

    /// <summary>
    /// 适用范围规则列表，不传默认为全公司。
    /// </summary>
    [JsonPropertyName("visibilityRules")]
    public List<AttendanceLeavesTypesResponseResultVisibilityRulesItem> VisibilityRules { get; set; } = [];

    /// <summary>
    /// 限时提交规则。
    /// </summary>
    [JsonPropertyName("submitTimeRule")]
    public AttendanceLeavesTypesResponseResultSubmitTimeRule SubmitTimeRule { get; set; }

    /// <summary>
    /// 请假证明。
    /// </summary>
    [JsonPropertyName("leaveCertificate")]
    public AttendanceLeavesTypesResponseResultLeaveCertificate LeaveCertificate { get; set; }
}

/// <summary>
/// AttendanceLeavesTypesResponseResultVisibilityRulesItem
/// </summary>
public class AttendanceLeavesTypesResponseResultVisibilityRulesItem
{
    /// <summary>
    /// 适用范围内数据列表。 当type=staff时，传员工userId列表。 当type=dept时，传部门id列表。 当type=label时，传角色id列表。
    /// </summary>
    public List<string> Visible { get; set; } = [];

    /// <summary>
    /// 适用范围规则类型。 dept：部门 staff：员工 label：角色
    /// </summary>
    public string? Type { get; set; }
}

/// <summary>
/// 限时提交规则。
/// </summary>
public class AttendanceLeavesTypesResponseResultSubmitTimeRule
{
    /// <summary>
    /// 限制值。 当timeUnit为day时，有效值范围是0至30天。 当timeUnit为hour时，有效值范围是0至24小时。
    /// </summary>
    [JsonPropertyName("timeValue")]
    public long TimeValue { get; set; }

    /// <summary>
    /// 时间单位。 day：天 hour：小时
    /// </summary>
    [JsonPropertyName("timeUnit")]
    public required string TimeUnit { get; set; }

    /// <summary>
    /// 限制类型。 before：提前 after：补交
    /// </summary>
    [JsonPropertyName("timeType")]
    public required string TimeType { get; set; }

    /// <summary>
    /// 是否开启限时提交功能。 true：开启 false：不开启
    /// </summary>
    [JsonPropertyName("enableTimeLimit")]
    public bool EnableTimeLimit { get; set; }
}

/// <summary>
/// 请假证明。
/// </summary>
public class AttendanceLeavesTypesResponseResultLeaveCertificate
{
    /// <summary>
    /// 请假证明时长单位。 hour：小时 day：天
    /// </summary>
    public required string Unit { get; set; }

    /// <summary>
    /// 超过多长时间需提供请假证明。
    /// </summary>
    public long Duration { get; set; }

    /// <summary>
    /// 是否开启请假证明。 true：开启 false：不开启
    /// </summary>
    public bool Enable { get; set; }

    /// <summary>
    /// 请假提示文案。
    /// </summary>
    [JsonPropertyName("promptInformation")]
    public required string PromptInformation { get; set; }
}

/// <summary>
/// 更新假期规则请求
/// </summary>
public class AttendanceLeavesTypesPutRequest
{
    /// <summary>
    /// 假期名称。
    /// </summary>
    [JsonPropertyName("leaveName")]
    public string? LeaveName { get; set; }

    /// <summary>
    /// 请假单位。 day：天 halfDay：半天 hour：小时
    /// </summary>
    [JsonPropertyName("leaveViewUnit")]
    public required string LeaveViewUnit { get; set; }

    /// <summary>
    /// 假期类型。 general_leave：普通假期 lieu_leave：加班转调休
    /// </summary>
    [JsonPropertyName("bizType")]
    public required string BizType { get; set; }

    /// <summary>
    /// 接口添加的假期规则标识，leave_code必须是通过接口添加的假期类型。 企业内部应用，调用添加假期规则接口获取的leave_code参数值。 第三方企业应用，调用添加假期规则接口获取的leave_code参数值。
    /// </summary>
    [JsonPropertyName("leaveCode")]
    public required string LeaveCode { get; set; }

    /// <summary>
    /// 调休假有效期规则。 validity_type：有效类型 absolute_time：绝对时间 relative_time：相对时间 validity_value：延长日期 当validity_type为absolute_time，该值不为空且满足“yy-mm”格式。 当validity_type为relative_time，该值为大于1的整数。
    /// </summary>
    public string? Extras { get; set; }

    /// <summary>
    /// 适用范围规则列表，不传默认为全公司。
    /// </summary>
    [JsonPropertyName("visibilityRules")]
    public List<AttendanceLeavesTypesPutRequestVisibilityRulesItem> VisibilityRules { get; set; } = [];

    /// <summary>
    /// 限时提交规则。
    /// </summary>
    [JsonPropertyName("submitTimeRule")]
    public AttendanceLeavesTypesPutRequestSubmitTimeRule SubmitTimeRule { get; set; }

    /// <summary>
    /// 请假证明。
    /// </summary>
    [JsonPropertyName("leaveCertificate")]
    public AttendanceLeavesTypesPutRequestLeaveCertificate LeaveCertificate { get; set; }
}

/// <summary>
/// AttendanceLeavesTypesPutRequestVisibilityRulesItem
/// </summary>
public class AttendanceLeavesTypesPutRequestVisibilityRulesItem
{
    /// <summary>
    /// 适用范围内数据列表。 当type=staff时，传员工userId列表。 当type=dept时，传部门id列表。 当type=label时，传角色id列表。
    /// </summary>
    public List<string> Visible { get; set; } = [];

    /// <summary>
    /// 适用范围规则类型。 dept：部门 staff：员工 label：角色
    /// </summary>
    public string? Type { get; set; }
}

/// <summary>
/// 限时提交规则。
/// </summary>
public class AttendanceLeavesTypesPutRequestSubmitTimeRule
{
    /// <summary>
    /// 时间单位。 day：天 hour：小时
    /// </summary>
    [JsonPropertyName("timeUnit")]
    public required string TimeUnit { get; set; }

    /// <summary>
    /// 限制类型。 before：提前 after：补交
    /// </summary>
    [JsonPropertyName("timeType")]
    public required string TimeType { get; set; }
}

/// <summary>
/// 请假证明。
/// </summary>
public class AttendanceLeavesTypesPutRequestLeaveCertificate
{
    /// <summary>
    /// 请假证明单位。 hour：小时 day：天
    /// </summary>
    public required string Unit { get; set; }

    /// <summary>
    /// 请假提示文案。
    /// </summary>
    [JsonPropertyName("promptInformation")]
    public required string PromptInformation { get; set; }
}

/// <summary>
/// 更新假期规则响应
/// </summary>
public class AttendanceLeavesTypesPutResponse
{
    /// <summary>
    /// 返回信息。
    /// </summary>
    public AttendanceLeavesTypesPutResponseResult Result { get; set; }
}

/// <summary>
/// 返回信息。
/// </summary>
public class AttendanceLeavesTypesPutResponseResult
{
    /// <summary>
    /// 假期名称。
    /// </summary>
    [JsonPropertyName("leaveName")]
    public required string LeaveName { get; set; }

    /// <summary>
    /// 假期规则唯一标识。
    /// </summary>
    [JsonPropertyName("leaveCode")]
    public required string LeaveCode { get; set; }

    /// <summary>
    /// 请假单位。 day：天 halfDay：半天 hour：小时
    /// </summary>
    [JsonPropertyName("leaveViewUnit")]
    public required string LeaveViewUnit { get; set; }

    /// <summary>
    /// 假期类型。 general_leave：普通假期 lieu_leave：加班转调休
    /// </summary>
    [JsonPropertyName("bizType")]
    public required string BizType { get; set; }

    /// <summary>
    /// 是否按照自然日统计请假时长。 true：是 false：否 说明 当为false的时候，用户发起请假时候会根据用户在请假时间段内的排班情况来计算请假时长。
    /// </summary>
    [JsonPropertyName("naturalDayLeave")]
    public bool NaturalDayLeave { get; set; }

    /// <summary>
    /// 每天折算的工作时长，为参数值的百分之一。 例如，某企业每天的工作时长设置为10小时，则该参数值为10*100=1000。
    /// </summary>
    [JsonPropertyName("hoursInPerDay")]
    public long HoursInPerDay { get; set; }

    /// <summary>
    /// 适用范围规则列表，不传默认为全公司。
    /// </summary>
    [JsonPropertyName("visibilityRules")]
    public List<AttendanceLeavesTypesPutResponseResultVisibilityRulesItem> VisibilityRules { get; set; } = [];

    /// <summary>
    /// 限时提交规则。
    /// </summary>
    [JsonPropertyName("submitTimeRule")]
    public AttendanceLeavesTypesPutResponseResultSubmitTimeRule SubmitTimeRule { get; set; }

    /// <summary>
    /// 请假证明。
    /// </summary>
    [JsonPropertyName("leaveCertificate")]
    public AttendanceLeavesTypesPutResponseResultLeaveCertificate LeaveCertificate { get; set; }
}

/// <summary>
/// AttendanceLeavesTypesPutResponseResultVisibilityRulesItem
/// </summary>
public class AttendanceLeavesTypesPutResponseResultVisibilityRulesItem
{
    /// <summary>
    /// 适用范围内数据列表。 当type=staff时，传员工userId列表。 当type=dept时，传部门id列表。 当type=label时，传角色id列表。
    /// </summary>
    public List<string> Visible { get; set; } = [];

    /// <summary>
    /// 适用范围规则类型。 dept：部门 staff：员工 label：角色
    /// </summary>
    public string? Type { get; set; }
}

/// <summary>
/// 限时提交规则。
/// </summary>
public class AttendanceLeavesTypesPutResponseResultSubmitTimeRule
{
    /// <summary>
    /// 限制值。 当timeUnit为day时，有效值范围是0至30天。 当timeUnit为hour时，有效值范围是0至24小时。
    /// </summary>
    [JsonPropertyName("timeValue")]
    public long TimeValue { get; set; }

    /// <summary>
    /// 时间单位。 day：天 hour：小时
    /// </summary>
    [JsonPropertyName("timeUnit")]
    public required string TimeUnit { get; set; }

    /// <summary>
    /// 限制类型。 before：提前 after：补交
    /// </summary>
    [JsonPropertyName("timeType")]
    public required string TimeType { get; set; }

    /// <summary>
    /// 是否开启限时提交功能。 true：开启 false：不开启
    /// </summary>
    [JsonPropertyName("enableTimeLimit")]
    public bool EnableTimeLimit { get; set; }
}

/// <summary>
/// 请假证明。
/// </summary>
public class AttendanceLeavesTypesPutResponseResultLeaveCertificate
{
    /// <summary>
    /// 请假证明时长单位。 hour：小时 day：天
    /// </summary>
    public required string Unit { get; set; }

    /// <summary>
    /// 超过多长时间需提供请假证明。
    /// </summary>
    public long Duration { get; set; }

    /// <summary>
    /// 是否开启请假证明。 true：开启 false：不开启
    /// </summary>
    public bool Enable { get; set; }

    /// <summary>
    /// 请假提示文案。
    /// </summary>
    [JsonPropertyName("promptInformation")]
    public required string PromptInformation { get; set; }
}

/// <summary>
/// 批量查询员工假期余额变更记录请求
/// </summary>
public class AttendanceVacationsRecordsQueryRequest
{
    /// <summary>
    /// 当前企业内拥有OA审批应用权限的管理员的userId，建议传入企业主管理员userId。 企业内部应用，可调用获取管理员列表接口，获取返回参数主管理员userId字段。 第三方企业应用，可调用获取管理员列表接口，获取返回参数主管理员userId字段。
    /// </summary>
    [JsonPropertyName("opUserId")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 假期类型唯一标识。 企业内部应用调用查询假期类型列表接口获取leave_code参数值。 第三方企业应用调用查询假期类型列表接口,获取leave_code参数值。
    /// </summary>
    [JsonPropertyName("leaveCode")]
    public required string LeaveCode { get; set; }

    /// <summary>
    /// 当前页码，从0开始。
    /// </summary>
    [JsonPropertyName("pageNumber")]
    public required string PageNumber { get; set; }

    /// <summary>
    /// 每页条目数，最大值200。
    /// </summary>
    [JsonPropertyName("pageSize")]
    public long PageSize { get; set; }

    /// <summary>
    /// 待查询员工userId列表，每次调用最多传50个userId。
    /// </summary>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; } = [];
}

/// <summary>
/// 批量查询员工假期余额变更记录响应
/// </summary>
public class AttendanceVacationsRecordsQueryResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    public AttendanceVacationsRecordsQueryResponseResult Result { get; set; }

    /// <summary>
    /// 是否正确访问。 true：是 false：不是
    /// </summary>
    public bool Success { get; set; }
}

/// <summary>
/// 返回结果。
/// </summary>
public class AttendanceVacationsRecordsQueryResponseResult
{
    /// <summary>
    /// 是否存在更多结果。 true：存在 false：不存在
    /// </summary>
    [JsonPropertyName("hasMore")]
    public bool HasMore { get; set; }

    /// <summary>
    /// 假期消费记录列表。
    /// </summary>
    [JsonPropertyName("leaveRecords")]
    public List<AttendanceVacationsRecordsQueryResponseResultLeaveRecordsItem> LeaveRecords { get; set; } = [];
}

/// <summary>
/// AttendanceVacationsRecordsQueryResponseResultLeaveRecordsItem
/// </summary>
public class AttendanceVacationsRecordsQueryResponseResultLeaveRecordsItem
{
    /// <summary>
    /// 员工userId。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 假期类型唯一标识。
    /// </summary>
    [JsonPropertyName("leaveCode")]
    public string? LeaveCode { get; set; }

    /// <summary>
    /// 假期消费记录唯一标识。
    /// </summary>
    [JsonPropertyName("recordId")]
    public string? RecordId { get; set; }

    /// <summary>
    /// 假期额度唯一标识。
    /// </summary>
    [JsonPropertyName("quotaId")]
    public string? QuotaId { get; set; }

    /// <summary>
    /// 计算类型。 insert：新纪录 add：新增 delete：删除 update：更新 null（或者不返回该字段）：请假消耗
    /// </summary>
    [JsonPropertyName("calType")]
    public string? CalType { get; set; }

    /// <summary>
    /// 额度有效期开始时间或请假开始时间，毫秒级时间戳。
    /// </summary>
    [JsonPropertyName("startTime")]
    public long? StartTime { get; set; }

    /// <summary>
    /// 额度有效期结束时间或请假结束时间，毫秒级时间戳。
    /// </summary>
    [JsonPropertyName("endTime")]
    public long? EndTime { get; set; }

    /// <summary>
    /// 显示单位。 day：天 hour：小时
    /// </summary>
    [JsonPropertyName("leaveViewUnit")]
    public string? LeaveViewUnit { get; set; }

    /// <summary>
    /// 原因。
    /// </summary>
    [JsonPropertyName("leaveReason")]
    public string? LeaveReason { get; set; }

    /// <summary>
    /// 假期记录类型。 leave：请假 update：更新配额 modify_quota:初始化余额或者更新余额
    /// </summary>
    [JsonPropertyName("leaveRecordType")]
    public string? LeaveRecordType { get; set; }

    /// <summary>
    /// 请假状态。 init：请假申请中 success：请假并已通过 refuse：请假但被被拒 abort：请假撤销 revoke：请假已通过但是撤销了请假并已同意
    /// </summary>
    [JsonPropertyName("leaveStatus")]
    public string? LeaveStatus { get; set; }

    /// <summary>
    /// 以天计算的消费额度。 说明 假期类型按天计算时，该值不为空且按百分之一天折算。 例如：1000=10天。
    /// </summary>
    [JsonPropertyName("recordNumPerDay")]
    public long? RecordNumPerDay { get; set; }

    /// <summary>
    /// 以小时计算的消费额度。 说明 假期类型按小时，计算该值不为空且按百分之一小时折算。例如：1000=10小时。
    /// </summary>
    [JsonPropertyName("recordNumPerHour")]
    public long? RecordNumPerHour { get; set; }

    /// <summary>
    /// 记录创建时间，毫秒级时间戳。
    /// </summary>
    [JsonPropertyName("gmtCreate")]
    public long? GmtCreate { get; set; }

    /// <summary>
    /// 记录修改时间，毫秒级时间戳。
    /// </summary>
    [JsonPropertyName("gmtModified")]
    public long? GmtModified { get; set; }

    /// <summary>
    /// 记录的操作人Id。
    /// </summary>
    [JsonPropertyName("opUserId")]
    public string? OpUserId { get; set; }
}

/// <summary>
/// 查询指定用户的封账规则请求
/// </summary>
public class AttendanceClosingAccountsRulesQueryRequest
{
    /// <summary>
    /// 人员userId列表。
    /// </summary>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; } = [];
}

/// <summary>
/// 查询指定用户的封账规则响应
/// </summary>
public class AttendanceClosingAccountsRulesQueryResponse
{
    /// <summary>
    /// 规则列表。
    /// </summary>
    public List<AttendanceClosingAccountsRulesQueryResponseResultItem> Result { get; set; } = [];
}

/// <summary>
/// AttendanceClosingAccountsRulesQueryResponseResultItem
/// </summary>
public class AttendanceClosingAccountsRulesQueryResponseResultItem
{
    /// <summary>
    /// 人员userId。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 规则标识： true：开 false：关
    /// </summary>
    [JsonPropertyName("switchOn")]
    public bool? SwitchOn { get; set; }

    /// <summary>
    /// 封账规则。
    /// </summary>
    [JsonPropertyName("closingAccountModel")]
    public AttendanceClosingAccountsRulesQueryResponseResultItemClosingAccountModel ClosingAccountModel { get; set; }

    /// <summary>
    /// 解封规则。
    /// </summary>
    [JsonPropertyName("unsealClosingAccountModel")]
    public AttendanceClosingAccountsRulesQueryResponseResultItemUnsealClosingAccountModel UnsealClosingAccountModel { get; set; }
}

/// <summary>
/// 封账规则。
/// </summary>
public class AttendanceClosingAccountsRulesQueryResponseResultItemClosingAccountModel
{
    /// <summary>
    /// 封账时间，单位日，例如：每月的30日。
    /// </summary>
    [JsonPropertyName("closingDay")]
    public long ClosingDay { get; set; }

    /// <summary>
    /// 封账时间中时分转换的时间戳，例如：16:00。
    /// </summary>
    [JsonPropertyName("closingHourMinutes")]
    public long ClosingHourMinutes { get; set; }

    /// <summary>
    /// 封账开始范围中的月。 -2：上上月 -1：上月 0：本月
    /// </summary>
    [JsonPropertyName("startMonth")]
    public long StartMonth { get; set; }

    /// <summary>
    /// 封账开始范围中的日，例如1日。
    /// </summary>
    [JsonPropertyName("startDay")]
    public long StartDay { get; set; }

    /// <summary>
    /// 封账结束范围中的月： -2：上上月 -1：上月 0：本月
    /// </summary>
    [JsonPropertyName("endMonth")]
    public long EndMonth { get; set; }

    /// <summary>
    /// 封账结束范围中的日，例如30日。
    /// </summary>
    [JsonPropertyName("endDay")]
    public long EndDay { get; set; }
}

/// <summary>
/// 解封规则。
/// </summary>
public class AttendanceClosingAccountsRulesQueryResponseResultItemUnsealClosingAccountModel
{
    /// <summary>
    /// 解封时间戳，单位毫秒。
    /// </summary>
    [JsonPropertyName("invalidTimeStamp")]
    public long InvalidTimeStamp { get; set; }
}
