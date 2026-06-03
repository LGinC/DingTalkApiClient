using System.Text.Json.Serialization;

namespace DingTalkApi.Models.Attendance;

#pragma warning disable CS1591
#pragma warning disable CS8618

/// <summary>
/// 创建考勤组请求
/// </summary>
public class AttendanceGroupAddRequest
{
    /// <summary>
    /// 操作人的userid。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 考勤组信息。
    /// </summary>
    [JsonPropertyName("top_group")]
    public AttendanceGroupAddRequestTopGroup TopGroup { get; set; }
}

/// <summary>
/// 考勤组信息。
/// </summary>
public class AttendanceGroupAddRequestTopGroup
{
    /// <summary>
    /// 考勤组负责人。
    /// </summary>
    public string? Owner { get; set; }

    /// <summary>
    /// 未排班时是否允许员工选择班次打卡。
    /// </summary>
    [JsonPropertyName("enable_emp_select_class")]
    public bool? EnableEmpSelectClass { get; set; }

    /// <summary>
    /// 企业的corpId，可以在开发者后台获取。
    /// </summary>
    [JsonPropertyName("corp_id")]
    public string? CorpId { get; set; }

    /// <summary>
    /// 是否跳过节假日。true：跳过（默认值）false：不跳过
    /// </summary>
    [JsonPropertyName("skip_holidays")]
    public bool? SkipHolidays { get; set; }

    /// <summary>
    /// 特殊日期配置。
    /// </summary>
    [JsonPropertyName("special_days")]
    public string? SpecialDays { get; set; }

    /// <summary>
    /// 是否开启外勤打卡必须拍照。true：开启false：关闭（默认值）
    /// </summary>
    [JsonPropertyName("enable_outside_camera_check")]
    public bool? EnableOutsideCameraCheck { get; set; }

    /// <summary>
    /// 考勤设置。
    /// </summary>
    public List<AttendanceGroupAddRequestTopGroupPositionsItem> Positions { get; set; } = [];

    /// <summary>
    /// 是否有修改考勤组成员相关信息。
    /// </summary>
    [JsonPropertyName("modify_member")]
    public bool? ModifyMember { get; set; }

    /// <summary>
    /// 考考勤组类型：FIXED：固定班制考勤组TURN：排班制考勤组NONE：自由工时考勤组
    /// </summary>
    public required string Type { get; set; }

    /// <summary>
    /// 是是否开启人脸检测。true：开启false：关闭（默认值）
    /// </summary>
    [JsonPropertyName("enable_face_check")]
    public bool? EnableFaceCheck { get; set; }

    /// <summary>
    /// 打卡是否需要健康码：true：开启false：关闭（默认值）
    /// </summary>
    [JsonPropertyName("check_need_healthy_code")]
    public bool? CheckNeedHealthyCode { get; set; }

    /// <summary>
    /// 是否开启拍照打卡。true：开启false：关闭（默认值）
    /// </summary>
    [JsonPropertyName("enable_camera_check")]
    public bool? EnableCameraCheck { get; set; }

    /// <summary>
    /// 班次信息。
    /// </summary>
    [JsonPropertyName("shift_vo_list")]
    public List<AttendanceGroupAddRequestTopGroupShiftVoListItem> ShiftVoList { get; set; } = [];

    /// <summary>
    /// 是否可以外勤打卡。true：允许（默认值）false：不允许
    /// </summary>
    [JsonPropertyName("enable_outside_check")]
    public bool? EnableOutsideCheck { get; set; }

    /// <summary>
    /// 考勤组成员。
    /// </summary>
    public List<AttendanceGroupAddRequestTopGroupMembersItem> Members { get; set; } = [];

    /// <summary>
    /// 考勤组名。
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 考勤组ID。
    /// </summary>
    public decimal? Id { get; set; }

    /// <summary>
    /// 是否第二天生效。true：是false：否
    /// </summary>
    [JsonPropertyName("enable_next_day")]
    public bool? EnableNextDay { get; set; }

    /// <summary>
    /// 考勤组子管理员userid列表。
    /// </summary>
    [JsonPropertyName("manager_list")]
    public List<string> ManagerList { get; set; } = [];

    /// <summary>
    /// 周班次列表。固定班制必填，0表示休息。
    /// </summary>
    [JsonPropertyName("workday_class_list")]
    public List<decimal> WorkdayClassList { get; set; } = [];

    /// <summary>
    /// 默认班次ID。固定班制必填。
    /// </summary>
    [JsonPropertyName("default_class_id")]
    public decimal? DefaultClassId { get; set; }

    /// <summary>
    /// 考勤范围。
    /// </summary>
    public decimal? Offset { get; set; }

    /// <summary>
    /// 子管理员权限范围。w：可管理r：可读
    /// </summary>
    [JsonPropertyName("resource_permission_map")]
    public AttendanceGroupAddRequestTopGroupResourcePermissionMap ResourcePermissionMap { get; set; }

    /// <summary>
    /// 考勤wifi打卡。
    /// </summary>
    public List<AttendanceGroupAddRequestTopGroupWifisItem> Wifis { get; set; } = [];

    /// <summary>
    /// 未排班时是否禁止员工打卡。
    /// </summary>
    [JsonPropertyName("disable_check_without_schedule")]
    public bool? DisableCheckWithoutSchedule { get; set; }

    /// <summary>
    /// 自由工时考勤组工作日。1：周一0：周日
    /// </summary>
    [JsonPropertyName("freecheck_work_days")]
    public List<decimal> FreecheckWorkDays { get; set; } = [];

    /// <summary>
    /// 自由工时考勤组考勤开始时间与当天0点偏移分钟数。例如：240表示4:00。
    /// </summary>
    [JsonPropertyName("freecheck_day_start_min_offset")]
    public decimal? FreecheckDayStartMinOffset { get; set; }

    /// <summary>
    /// 休息日打卡是否需审批：true：需要 false：不需要
    /// </summary>
    [JsonPropertyName("disable_check_when_rest")]
    public bool? DisableCheckWhenRest { get; set; }

    /// <summary>
    /// 是否启用蓝牙定位。
    /// </summary>
    [JsonPropertyName("enable_position_ble")]
    public bool? EnablePositionBle { get; set; }

    /// <summary>
    /// 蓝牙打卡信息。
    /// </summary>
    [JsonPropertyName("ble_device_list")]
    public List<AttendanceGroupAddRequestTopGroupBleDeviceListItem> BleDeviceList { get; set; } = [];
}

/// <summary>
/// AttendanceGroupAddRequestTopGroupPositionsItem
/// </summary>
public class AttendanceGroupAddRequestTopGroupPositionsItem
{
    /// <summary>
    /// 考勤地址。
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// 企业的corpId。可以在开发者后台查看。
    /// </summary>
    [JsonPropertyName("corp_id")]
    public string? CorpId { get; set; }

    /// <summary>
    /// 纬度。
    /// </summary>
    public string? Latitude { get; set; }

    /// <summary>
    /// 精度。
    /// </summary>
    public string? Accuracy { get; set; }

    /// <summary>
    /// 考勤标题。
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 经度。
    /// </summary>
    public string? Longitude { get; set; }
}

/// <summary>
/// AttendanceGroupAddRequestTopGroupShiftVoListItem
/// </summary>
public class AttendanceGroupAddRequestTopGroupShiftVoListItem
{
    /// <summary>
    /// 班次ID，可通过获取班次摘要信息接口获取。
    /// </summary>
    public decimal? Id { get; set; }
}

/// <summary>
/// AttendanceGroupAddRequestTopGroupMembersItem
/// </summary>
public class AttendanceGroupAddRequestTopGroupMembersItem
{
    /// <summary>
    /// 角色。
    /// </summary>
    public required string Role { get; set; }

    /// <summary>
    /// c企业的corpId，可以在开发者后台获取。
    /// </summary>
    [JsonPropertyName("corp_id")]
    public string? CorpId { get; set; }

    /// <summary>
    /// 类型。
    /// </summary>
    public required string Type { get; set; }

    /// <summary>
    /// 用户userid。
    /// </summary>
    [JsonPropertyName("user_id")]
    public required string UserId { get; set; }
}

/// <summary>
/// 子管理员权限范围。w：可管理r：可读
/// </summary>
public class AttendanceGroupAddRequestTopGroupResourcePermissionMap
{
    /// <summary>
    /// 员工排班。
    /// </summary>
    public string? Schedule { get; set; }

    /// <summary>
    /// 设置参与考勤人员。
    /// </summary>
    [JsonPropertyName("group_member")]
    public string? GroupMember { get; set; }

    /// <summary>
    /// 设置考勤类型。
    /// </summary>
    [JsonPropertyName("group_type")]
    public string? GroupType { get; set; }

    /// <summary>
    /// 设置考勤时间。
    /// </summary>
    [JsonPropertyName("check_time")]
    public string? CheckTime { get; set; }

    /// <summary>
    /// 设置打卡方式。
    /// </summary>
    [JsonPropertyName("check_position_type")]
    public string? CheckPositionType { get; set; }

    /// <summary>
    /// 设置加班规则。
    /// </summary>
    [JsonPropertyName("over_time_rule")]
    public string? OverTimeRule { get; set; }

    /// <summary>
    /// 设置拍照打卡规则。
    /// </summary>
    [JsonPropertyName("camera_check")]
    public string? CameraCheck { get; set; }

    /// <summary>
    /// 设置外勤打卡。
    /// </summary>
    [JsonPropertyName("out_side_check")]
    public string? OutSideCheck { get; set; }
}

/// <summary>
/// AttendanceGroupAddRequestTopGroupWifisItem
/// </summary>
public class AttendanceGroupAddRequestTopGroupWifisItem
{
    /// <summary>
    /// mac地址。
    /// </summary>
    [JsonPropertyName("mac_addr")]
    public string? MacAddr { get; set; }

    /// <summary>
    /// wifi的ssid。
    /// </summary>
    public string? Ssid { get; set; }

    /// <summary>
    /// 企业的corpId，可以在开发者后台查看。
    /// </summary>
    [JsonPropertyName("corp_id")]
    public string? CorpId { get; set; }
}

/// <summary>
/// AttendanceGroupAddRequestTopGroupBleDeviceListItem
/// </summary>
public class AttendanceGroupAddRequestTopGroupBleDeviceListItem
{
    /// <summary>
    /// 设备ID。
    /// </summary>
    [JsonPropertyName("device_id")]
    public decimal? DeviceId { get; set; }
}

/// <summary>
/// 创建考勤组结果
/// </summary>
public class AttendanceGroupAddResult
{
    /// <summary>
    /// 考勤组名。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 考勤组id。
    /// </summary>
    public decimal? Id { get; set; }
}

/// <summary>
/// 更新考勤组请求
/// </summary>
public class AttendanceGroupModifyRequest
{
    /// <summary>
    /// 操作人userId。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 考勤组信息。
    /// </summary>
    [JsonPropertyName("top_group")]
    public AttendanceGroupModifyRequestTopGroup TopGroup { get; set; }
}

/// <summary>
/// 考勤组信息。
/// </summary>
public class AttendanceGroupModifyRequestTopGroup
{
    /// <summary>
    /// 班次信息。
    /// </summary>
    [JsonPropertyName("shift_vo_list")]
    public List<AttendanceGroupModifyRequestTopGroupShiftVoListItem> ShiftVoList { get; set; } = [];

    /// <summary>
    /// 考勤组ID。如果你使用的是旧考勤组标识即group_key，可以调用groupKey转换为groupId接口将group_key转换为group_id。
    /// </summary>
    public decimal Id { get; set; }

    /// <summary>
    /// 考勤组名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 考勤设置。
    /// </summary>
    public List<AttendanceGroupModifyRequestTopGroupPositionsItem> Positions { get; set; } = [];

    /// <summary>
    /// 考勤范围。
    /// </summary>
    public decimal? Offset { get; set; }

    /// <summary>
    /// 是否开启人脸检测。true：开启false（默认）：关闭
    /// </summary>
    [JsonPropertyName("enable_face_check")]
    public bool? EnableFaceCheck { get; set; }

    /// <summary>
    /// 考勤组子管理员userid列表。
    /// </summary>
    [JsonPropertyName("manager_list")]
    public List<string> ManagerList { get; set; } = [];

    /// <summary>
    /// 是否开启拍照打卡。true：开启false（默认）：关闭
    /// </summary>
    [JsonPropertyName("enable_camera_check")]
    public bool? EnableCameraCheck { get; set; }

    /// <summary>
    /// 考勤组负责人。
    /// </summary>
    public string? Owner { get; set; }

    /// <summary>
    /// 休息日打卡是否需审批。true：需要false：不需要
    /// </summary>
    [JsonPropertyName("disable_check_when_rest")]
    public bool? DisableCheckWhenRest { get; set; }

    /// <summary>
    /// 是否跳过节假日。true（默认）：跳过false：不跳过
    /// </summary>
    [JsonPropertyName("skip_holidays")]
    public bool? SkipHolidays { get; set; }

    /// <summary>
    /// 是否可以外勤打卡。true（默认）：允许false：不允许
    /// </summary>
    [JsonPropertyName("enable_outside_check")]
    public bool? EnableOutsideCheck { get; set; }

    /// <summary>
    /// 未排班时是否禁止员工打卡。
    /// </summary>
    [JsonPropertyName("disable_check_without_schedule")]
    public bool? DisableCheckWithoutSchedule { get; set; }

    /// <summary>
    /// 周班次列表。固定班制必填，0表示休息。
    /// </summary>
    [JsonPropertyName("workday_class_list")]
    public List<decimal> WorkdayClassList { get; set; } = [];

    /// <summary>
    /// 未排班时是否允许员工选择班次打卡。
    /// </summary>
    [JsonPropertyName("enable_emp_select_class")]
    public bool? EnableEmpSelectClass { get; set; }

    /// <summary>
    /// 子管理员权限范围。w：可管理r：可读
    /// </summary>
    [JsonPropertyName("resource_permission_map")]
    public AttendanceGroupModifyRequestTopGroupResourcePermissionMap ResourcePermissionMap { get; set; }
}

/// <summary>
/// AttendanceGroupModifyRequestTopGroupShiftVoListItem
/// </summary>
public class AttendanceGroupModifyRequestTopGroupShiftVoListItem
{
    /// <summary>
    /// 班次ID，可通过获取班次摘要信息接口获取。
    /// </summary>
    public decimal? Id { get; set; }
}

/// <summary>
/// AttendanceGroupModifyRequestTopGroupPositionsItem
/// </summary>
public class AttendanceGroupModifyRequestTopGroupPositionsItem
{
    /// <summary>
    /// 地址描述。
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// 企业的corpId。可以在开发者后台查看。
    /// </summary>
    [JsonPropertyName("corp_id")]
    public string? CorpId { get; set; }

    /// <summary>
    /// 纬度(支持6位小数)。
    /// </summary>
    public string? Latitude { get; set; }

    /// <summary>
    /// 经度(支持6位小数)。
    /// </summary>
    public string? Longitude { get; set; }

    /// <summary>
    /// 考勤标题。
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 精度。
    /// </summary>
    public string? Accuracy { get; set; }
}

/// <summary>
/// 子管理员权限范围。w：可管理r：可读
/// </summary>
public class AttendanceGroupModifyRequestTopGroupResourcePermissionMap
{
    /// <summary>
    /// 设置拍照打卡规则。
    /// </summary>
    [JsonPropertyName("camera_check")]
    public string? CameraCheck { get; set; }

    /// <summary>
    /// 设置加班规则。
    /// </summary>
    [JsonPropertyName("over_time_rule")]
    public string? OverTimeRule { get; set; }

    /// <summary>
    /// 设置打卡方式。
    /// </summary>
    [JsonPropertyName("check_position_type")]
    public string? CheckPositionType { get; set; }

    /// <summary>
    /// 设置考勤时间。
    /// </summary>
    [JsonPropertyName("check_time")]
    public string? CheckTime { get; set; }

    /// <summary>
    /// 设置考勤类型。
    /// </summary>
    [JsonPropertyName("group_type")]
    public string? GroupType { get; set; }

    /// <summary>
    /// 设置参与考勤人员。
    /// </summary>
    [JsonPropertyName("group_member")]
    public string? GroupMember { get; set; }

    /// <summary>
    /// 员工排班。
    /// </summary>
    public string? Schedule { get; set; }

    /// <summary>
    /// 设置外勤打卡。
    /// </summary>
    [JsonPropertyName("out_side_check")]
    public string? OutSideCheck { get; set; }
}

/// <summary>
/// 更新考勤组结果
/// </summary>
public class AttendanceGroupModifyResult
{
    /// <summary>
    /// 考勤组名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 考勤组ID。
    /// </summary>
    public decimal? Id { get; set; }
}

/// <summary>
/// 删除考勤组请求
/// </summary>
public class AttendanceGroupDeleteRequest
{
    /// <summary>
    /// 操作人userId。
    /// </summary>
    [JsonPropertyName("op_userid")]
    public string? OpUserid { get; set; }

    /// <summary>
    /// 考勤组ID。如果你使用的考勤组标识是group_id，可以调用groupId转换为groupKey接口将group_id转换为group_key。
    /// </summary>
    [JsonPropertyName("group_key")]
    public required string GroupKey { get; set; }
}

/// <summary>
/// 删除考勤组响应
/// </summary>
public class AttendanceGroupDeleteResponse
{
    /// <summary>
    /// 考勤组id。
    /// </summary>
    public required string Result { get; set; }

    /// <summary>
    /// 是否成功。
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public required string ErrMsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public long ErrCode { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; set; }
}

/// <summary>
/// 搜索考勤组摘要请求
/// </summary>
public class AttendanceGroupSearchRequest
{
    /// <summary>
    /// 操作人userid。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 考勤组名称。
    /// </summary>
    [JsonPropertyName("group_name")]
    public required string GroupName { get; set; }
}

/// <summary>
/// 搜索考勤组摘要结果
/// </summary>
public class AttendanceGroupSearchResult
{
}

/// <summary>
/// 获取考勤组详情请求
/// </summary>
public class AttendanceGroupQueryRequest
{
    /// <summary>
    /// 操作人userid，调用通过免登码获取用户信息接口获取。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 考勤组ID。如果你使用的是旧考勤组标识即group_key，可以调用转换groupKey接口将group_key转换为group_id。
    /// </summary>
    [JsonPropertyName("group_id")]
    public decimal GroupId { get; set; }
}

/// <summary>
/// 获取考勤组详情结果
/// </summary>
public class AttendanceGroupQueryResult
{
    /// <summary>
    /// 考勤组名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 排班ID。
    /// </summary>
    [JsonPropertyName("shift_ids")]
    public List<decimal> ShiftIds { get; set; } = [];

    /// <summary>
    /// 考勤组ID。
    /// </summary>
    public decimal? Id { get; set; }

    /// <summary>
    /// wifi名称。
    /// </summary>
    public List<string> Wifis { get; set; } = [];

    /// <summary>
    /// 考勤地址。
    /// </summary>
    [JsonPropertyName("address_list")]
    public List<string> AddressList { get; set; } = [];

    /// <summary>
    /// 工作日。
    /// </summary>
    [JsonPropertyName("work_day_list")]
    public List<decimal> WorkDayList { get; set; } = [];

    /// <summary>
    /// 人员人数
    /// </summary>
    [JsonPropertyName("member_count")]
    public decimal? MemberCount { get; set; }

    /// <summary>
    /// 考勤组类型：FIXED：代表固定班制考勤组TURN：代表排班制考勤组NONE：代表自由工时考勤组
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// 跳转链接。
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// 考勤组管理员。
    /// </summary>
    [JsonPropertyName("manager_list")]
    public string? ManagerList { get; set; }

    /// <summary>
    /// 考勤组主负责人的userid。
    /// </summary>
    [JsonPropertyName("owner_user_id")]
    public string? OwnerUserId { get; set; }
}

/// <summary>
/// 根据groupkey查询考勤组信息请求
/// </summary>
public class AttendanceGroupGetRequest
{
    /// <summary>
    /// 操作人userid。
    /// </summary>
    [JsonPropertyName("op_userid")]
    public string? OpUserid { get; set; }

    /// <summary>
    /// 考勤组ID。如果你使用的考勤组标识是group_id，可以调用groupId转换为groupKey接口将group_id转换为group_key。
    /// </summary>
    [JsonPropertyName("group_key")]
    public required string GroupKey { get; set; }
}

/// <summary>
/// 根据groupkey查询考勤组信息结果
/// </summary>
public class AttendanceGroupGetResult
{
    /// <summary>
    /// 考勤组名称。
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 扩展字段，JSON格式。
    /// </summary>
    public required string Ext { get; set; }

    /// <summary>
    /// 打卡范围，单位为米。 说明 该字段已废弃，请以批量查询地点接口返回的offset为准。
    /// </summary>
    [JsonPropertyName("location_offset")]
    public long LocationOffset { get; set; }

    /// <summary>
    /// 考勤组id。
    /// </summary>
    [JsonPropertyName("group_key")]
    public required string GroupKey { get; set; }

    /// <summary>
    /// 是否开启笑脸打卡。true：开启false（默认）：关闭
    /// </summary>
    [JsonPropertyName("enable_face_check")]
    public bool EnableFaceCheck { get; set; }

    /// <summary>
    /// 是否开启美颜。true：开启false（默认）：关闭
    /// </summary>
    [JsonPropertyName("enable_face_beauty")]
    public bool EnableFaceBeauty { get; set; }

    /// <summary>
    /// 是否开启拍照打卡。true：开启false（默认）：关闭
    /// </summary>
    [JsonPropertyName("enable_camera_check")]
    public bool EnableCameraCheck { get; set; }

    /// <summary>
    /// 外勤打卡审批模式。 -1（默认）：关闭 0：先审批，再打卡 1：先打卡，再审批
    /// </summary>
    [JsonPropertyName("outside_check_approve_mode")]
    public long OutsideCheckApproveMode { get; set; }

    /// <summary>
    /// 是否禁止员工隐藏详细地址。 true（默认）：禁止 false：不禁止
    /// </summary>
    [JsonPropertyName("forbid_hide_outside_address")]
    public bool ForbidHideOutsideAddress { get; set; }

    /// <summary>
    /// 外勤打卡是否需要审批。 true：需要 false（默认）：不需要
    /// </summary>
    [JsonPropertyName("enable_outside_apply")]
    public bool EnableOutsideApply { get; set; }

    /// <summary>
    /// 外勤打卡是否需要拍照备注。 true：需要 false（默认）：不需要
    /// </summary>
    [JsonPropertyName("enable_outside_camera_check")]
    public bool EnableOutsideCameraCheck { get; set; }

    /// <summary>
    /// 是否允许外勤卡更新内勤卡。 true：允许 false（默认）：不允许
    /// </summary>
    [JsonPropertyName("enable_outside_update_normal_check")]
    public bool EnableOutsideUpdateNormalCheck { get; set; }

    /// <summary>
    /// 地点微调范围，单位为米。
    /// </summary>
    [JsonPropertyName("trim_distance")]
    public long TrimDistance { get; set; }

    /// <summary>
    /// 是否允许外勤打卡。 true：允许 false（默认）：不允许
    /// </summary>
    [JsonPropertyName("enable_outside_check")]
    public bool EnableOutsideCheck { get; set; }

    /// <summary>
    /// 外勤打卡是否需要填写备注。 true：需要 false（默认）：不需要
    /// </summary>
    [JsonPropertyName("enable_outside_remark")]
    public bool EnableOutsideRemark { get; set; }

    /// <summary>
    /// 是否允许地点微调距离。 true：允许 false（默认）：不允许
    /// </summary>
    [JsonPropertyName("enable_trim_distance")]
    public bool EnableTrimDistance { get; set; }
}

/// <summary>
/// groupKey转换为groupId请求
/// </summary>
public class AttendanceGroupsKeyToIdRequest
{
    /// <summary>
    /// 操作人的userId。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 考勤组ID，旧考勤组标识。
    /// </summary>
    [JsonPropertyName("group_key")]
    public required string GroupKey { get; set; }
}

/// <summary>
/// groupKey转换为groupId响应
/// </summary>
public class AttendanceGroupsKeyToIdResponse
{
    /// <summary>
    /// 考勤组ID。
    /// </summary>
    public long Result { get; set; }

    /// <summary>
    /// 是否成功。
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public long ErrCode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public required string ErrMsg { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; set; }
}

/// <summary>
/// groupId转换为groupKey请求
/// </summary>
public class AttendanceGroupsIdToKeyRequest
{
    /// <summary>
    /// 操作人的userId。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public string? OpUserId { get; set; }

    /// <summary>
    /// 考勤组ID，可通过批量获取考勤组详情获取。
    /// </summary>
    [JsonPropertyName("group_id")]
    public decimal GroupId { get; set; }
}

/// <summary>
/// groupId转换为groupKey响应
/// </summary>
public class AttendanceGroupsIdToKeyResponse
{
    /// <summary>
    /// 考勤组ID。
    /// </summary>
    public string? Result { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? ErrCode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? ErrMsg { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 批量获取考勤组摘要请求
/// </summary>
public class AttendanceGroupMinimalismListRequest
{
    /// <summary>
    /// 操作人userid。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 游标值，表示从第几个开始，不传默认从第一个开始。
    /// </summary>
    public decimal? Cursor { get; set; }
}

/// <summary>
/// 批量获取考勤组摘要结果
/// </summary>
public class AttendanceGroupMinimalismListResult
{
    /// <summary>
    /// 是否有更多数据。
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// 游标位置。
    /// </summary>
    public decimal? Cursor { get; set; }

    /// <summary>
    /// 考勤信息。
    /// </summary>
    public List<AttendanceGroupMinimalismListResultResultItem> Result { get; set; } = [];
}

/// <summary>
/// AttendanceGroupMinimalismListResultResultItem
/// </summary>
public class AttendanceGroupMinimalismListResultResultItem
{
    /// <summary>
    /// 考勤组名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 考勤组ID。
    /// </summary>
    public decimal? Id { get; set; }
}

/// <summary>
/// 批量获取考勤组详情请求
/// </summary>
public class AttendanceGetSimpleGroupsRequest
{
    /// <summary>
    /// 支持分页查询，与size参数同时设置时才生效，此参数代表偏移量，偏移量从0开始。
    /// </summary>
    public decimal? Offset { get; set; }

    /// <summary>
    /// 分页大小，最大10。
    /// </summary>
    public decimal? Size { get; set; }
}

/// <summary>
/// 批量获取考勤组详情结果
/// </summary>
public class AttendanceGetSimpleGroupsResult
{
    /// <summary>
    /// 分页用，表示是否有更多数据。
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool HasMore { get; set; }

    /// <summary>
    /// 考勤组列表。
    /// </summary>
    public List<AttendanceGetSimpleGroupsResultGroupsItem> Groups { get; set; } = [];
}

/// <summary>
/// AttendanceGetSimpleGroupsResultGroupsItem
/// </summary>
public class AttendanceGetSimpleGroupsResultGroupsItem
{
    /// <summary>
    /// 考勤组ID。
    /// </summary>
    [JsonPropertyName("group_id")]
    public long GroupId { get; set; }

    /// <summary>
    /// 是否是默认考勤组。false：不是true：是
    /// </summary>
    [JsonPropertyName("is_default")]
    public bool IsDefault { get; set; }

    /// <summary>
    /// 考勤组名称。
    /// </summary>
    [JsonPropertyName("group_name")]
    public required string GroupName { get; set; }

    /// <summary>
    /// 考勤组对应的考勤班次列表。
    /// </summary>
    [JsonPropertyName("selected_class")]
    public List<AttendanceGetSimpleGroupsResultGroupsItemSelectedClassItem> SelectedClass { get; set; } = [];

    /// <summary>
    /// 考勤类型。FIXED为固定排班TURN为轮班排班NONE为无班次
    /// </summary>
    public required string Type { get; set; }

    /// <summary>
    /// 参与考勤人员人数。
    /// </summary>
    [JsonPropertyName("member_count")]
    public long MemberCount { get; set; }

    /// <summary>
    /// 默认班次ID。
    /// </summary>
    [JsonPropertyName("default_class_id")]
    public long? DefaultClassId { get; set; }

    /// <summary>
    /// 固定班次的工作日班次。
    /// </summary>
    [JsonPropertyName("work_day_list")]
    public List<string> WorkDayList { get; set; } = [];

    /// <summary>
    /// 一周的班次时间展示列表。
    /// </summary>
    [JsonPropertyName("classes_list")]
    public List<string> ClassesList { get; set; } = [];

    /// <summary>
    /// 考勤组负责人。
    /// </summary>
    [JsonPropertyName("manager_list")]
    public List<string> ManagerList { get; set; } = [];

    /// <summary>
    /// 关联的部门。
    /// </summary>
    [JsonPropertyName("dept_name_list")]
    public List<string> DeptNameList { get; set; } = [];

    /// <summary>
    /// 考勤组主负责人。
    /// </summary>
    [JsonPropertyName("owner_user_id")]
    public string? OwnerUserId { get; set; }

    /// <summary>
    /// 未排班时是否允许员工选择班次打卡。
    /// </summary>
    [JsonPropertyName("enable_emp_select_class")]
    public bool EnableEmpSelectClass { get; set; }

    /// <summary>
    /// 未排班时是否禁止员工打卡。
    /// </summary>
    [JsonPropertyName("disable_check_without_schedule")]
    public bool DisableCheckWithoutSchedule { get; set; }

    /// <summary>
    /// 休息日打卡是否需审批：true：需要 false：不需要。
    /// </summary>
    [JsonPropertyName("disable_check_when_rest")]
    public bool DisableCheckWhenRest { get; set; }
}

/// <summary>
/// AttendanceGetSimpleGroupsResultGroupsItemSelectedClassItem
/// </summary>
public class AttendanceGetSimpleGroupsResultGroupsItemSelectedClassItem
{
    /// <summary>
    /// 未排班时是否允许员工选择班次打卡。
    /// </summary>
    [JsonPropertyName("enable_emp_select_class")]
    public bool? EnableEmpSelectClass { get; set; }

    /// <summary>
    /// 未排班时是否禁止员工打卡。
    /// </summary>
    [JsonPropertyName("disable_check_without_schedule")]
    public bool? DisableCheckWithoutSchedule { get; set; }

    /// <summary>
    /// 休息日打卡是否需审批：true：需要 false：不需要
    /// </summary>
    [JsonPropertyName("disable_check_when_rest")]
    public bool? DisableCheckWhenRest { get; set; }

    /// <summary>
    /// 考勤组班次配置。
    /// </summary>
    public AttendanceGetSimpleGroupsResultGroupsItemSelectedClassItemSetting Setting { get; set; }

    /// <summary>
    /// 班次ID。
    /// </summary>
    [JsonPropertyName("class_id")]
    public long ClassId { get; set; }

    /// <summary>
    /// 班次打卡时间段。
    /// </summary>
    public List<AttendanceGetSimpleGroupsResultGroupsItemSelectedClassItemSectionsItem> Sections { get; set; } = [];

    /// <summary>
    /// 考勤班次名称。
    /// </summary>
    [JsonPropertyName("class_name")]
    public required string ClassName { get; set; }
}

/// <summary>
/// 考勤组班次配置。
/// </summary>
public class AttendanceGetSimpleGroupsResultGroupsItemSelectedClassItemSetting
{
    /// <summary>
    /// 旷工早退/迟到的时长，单位分钟。
    /// </summary>
    [JsonPropertyName("absenteeism_late_minutes")]
    public long AbsenteeismLateMinutes { get; set; }

    /// <summary>
    /// 班次配置ID。
    /// </summary>
    [JsonPropertyName("class_setting_id")]
    public long ClassSettingId { get; set; }

    /// <summary>
    /// 下班是否免打卡。
    /// </summary>
    [JsonPropertyName("is_off_duty_free_check")]
    public required string IsOffDutyFreeCheck { get; set; }

    /// <summary>
    /// 允许迟到的时长，单位分钟。
    /// </summary>
    [JsonPropertyName("permit_late_minutes")]
    public long PermitLateMinutes { get; set; }

    /// <summary>
    /// 严重早退/迟到的时长，单位分钟。
    /// </summary>
    [JsonPropertyName("serious_late_minutes")]
    public long SeriousLateMinutes { get; set; }

    /// <summary>
    /// 工作时长，单位分钟。
    /// </summary>
    [JsonPropertyName("work_time_minutes")]
    public long WorkTimeMinutes { get; set; }
}

/// <summary>
/// AttendanceGetSimpleGroupsResultGroupsItemSelectedClassItemSectionsItem
/// </summary>
public class AttendanceGetSimpleGroupsResultGroupsItemSelectedClassItemSectionsItem
{
    /// <summary>
    /// 时间段列表。
    /// </summary>
    public List<AttendanceGetSimpleGroupsResultGroupsItemSelectedClassItemSectionsItemTimesItem> Times { get; set; } = [];
}

/// <summary>
/// AttendanceGetSimpleGroupsResultGroupsItemSelectedClassItemSectionsItemTimesItem
/// </summary>
public class AttendanceGetSimpleGroupsResultGroupsItemSelectedClassItemSectionsItemTimesItem
{
    /// <summary>
    /// 打卡时间。
    /// </summary>
    [JsonPropertyName("check_time")]
    public required string CheckTime { get; set; }

    /// <summary>
    /// 打卡类型。OnDuty：上班OffDuty：下班
    /// </summary>
    [JsonPropertyName("check_type")]
    public required string CheckType { get; set; }

    /// <summary>
    /// 打卡跨越的时间天数。
    /// </summary>
    public long Across { get; set; }
}

/// <summary>
/// 获取用户考勤组请求
/// </summary>
public class AttendanceGetUserGroupRequest
{
    /// <summary>
    /// 员工在企业内的userid。
    /// </summary>
    public required string Userid { get; set; }
}

/// <summary>
/// 获取用户考勤组结果
/// </summary>
public class AttendanceGetUserGroupResult
{
    /// <summary>
    /// 考勤组名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 考勤组ID。如果你使用的是旧考勤组标识即group_key，可以调用groupKey转换为groupId接口将group_key转换为group_id。
    /// </summary>
    [JsonPropertyName("group_id")]
    public decimal? GroupId { get; set; }

    /// <summary>
    /// 考勤类型：FIXED：固定排班TURN：轮班排班NONE：无班次
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// 考勤组中的班次列表。
    /// </summary>
    public List<AttendanceGetUserGroupResultClassesItem> Classes { get; set; } = [];
}

/// <summary>
/// AttendanceGetUserGroupResultClassesItem
/// </summary>
public class AttendanceGetUserGroupResultClassesItem
{
    /// <summary>
    /// 班次ID。
    /// </summary>
    [JsonPropertyName("class_id")]
    public decimal? ClassId { get; set; }

    /// <summary>
    /// 班次名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 班次中上下班列表。
    /// </summary>
    public List<AttendanceGetUserGroupResultClassesItemSectionsItem> Sections { get; set; } = [];

    /// <summary>
    /// 班次配置。
    /// </summary>
    public AttendanceGetUserGroupResultClassesItemSetting Setting { get; set; }
}

/// <summary>
/// AttendanceGetUserGroupResultClassesItemSectionsItem
/// </summary>
public class AttendanceGetUserGroupResultClassesItemSectionsItem
{
    /// <summary>
    /// 班次中上下班详情列表。
    /// </summary>
    public List<AttendanceGetUserGroupResultClassesItemSectionsItemTimesItem> Times { get; set; } = [];
}

/// <summary>
/// AttendanceGetUserGroupResultClassesItemSectionsItemTimesItem
/// </summary>
public class AttendanceGetUserGroupResultClassesItemSectionsItemTimesItem
{
    /// <summary>
    /// 打卡时间。
    /// </summary>
    [JsonPropertyName("check_time")]
    public string? CheckTime { get; set; }

    /// <summary>
    /// 打卡类型：OnDuty：上班OffDuty：下班
    /// </summary>
    [JsonPropertyName("check_type")]
    public string? CheckType { get; set; }

    /// <summary>
    /// 打卡跨越的时间天数。
    /// </summary>
    public decimal? Across { get; set; }

    /// <summary>
    /// 允许的最早提前打卡时间，单位分钟。
    /// </summary>
    [JsonPropertyName("begin_min")]
    public decimal? BeginMin { get; set; }

    /// <summary>
    /// 允许的最晚延后打卡时间，单位分钟。
    /// </summary>
    [JsonPropertyName("end_min")]
    public decimal? EndMin { get; set; }
}

/// <summary>
/// 班次配置。
/// </summary>
public class AttendanceGetUserGroupResultClassesItemSetting
{
    /// <summary>
    /// 休息开始设置。
    /// </summary>
    [JsonPropertyName("rest_begin_time")]
    public AttendanceGetUserGroupResultClassesItemSettingRestBeginTime RestBeginTime { get; set; }

    /// <summary>
    /// 休息结束时间设置。
    /// </summary>
    [JsonPropertyName("rest_end_time")]
    public AttendanceGetUserGroupResultClassesItemSettingRestEndTime RestEndTime { get; set; }
}

/// <summary>
/// 休息开始设置。
/// </summary>
public class AttendanceGetUserGroupResultClassesItemSettingRestBeginTime
{
    /// <summary>
    /// 时间跨度。
    /// </summary>
    public decimal? Across { get; set; }

    /// <summary>
    /// 开始时间。
    /// </summary>
    [JsonPropertyName("begin_min")]
    public decimal? BeginMin { get; set; }

    /// <summary>
    /// 结束时间。
    /// </summary>
    [JsonPropertyName("end_min")]
    public decimal? EndMin { get; set; }

    /// <summary>
    /// 休息开始时间。
    /// </summary>
    [JsonPropertyName("check_time")]
    public string? CheckTime { get; set; }

    /// <summary>
    /// 设置类型：OnDuty：休息开始OffDuty：休息结束
    /// </summary>
    [JsonPropertyName("check_type")]
    public string? CheckType { get; set; }
}

/// <summary>
/// 休息结束时间设置。
/// </summary>
public class AttendanceGetUserGroupResultClassesItemSettingRestEndTime
{
    /// <summary>
    /// 时间跨度。
    /// </summary>
    public decimal? Across { get; set; }

    /// <summary>
    /// 开始时间。
    /// </summary>
    [JsonPropertyName("begin_min")]
    public decimal? BeginMin { get; set; }

    /// <summary>
    /// 结束时间。
    /// </summary>
    [JsonPropertyName("end_min")]
    public decimal? EndMin { get; set; }

    /// <summary>
    /// 休息结束时间。
    /// </summary>
    [JsonPropertyName("check_time")]
    public string? CheckTime { get; set; }

    /// <summary>
    /// 打卡类型：OnDuty：休息开始OffDuty：休息结束
    /// </summary>
    [JsonPropertyName("check_type")]
    public string? CheckType { get; set; }
}

/// <summary>
/// 批量新增参与考勤人员请求
/// </summary>
public class AttendanceGroupUsersAddRequest
{
    /// <summary>
    /// 操作人userid。
    /// </summary>
    [JsonPropertyName("op_userid")]
    public string? OpUserid { get; set; }

    /// <summary>
    /// 考勤组ID。如果你使用的考勤组标识是group_id，可以调用groupId转换为groupKey接口将group_id转换为group_key。
    /// </summary>
    [JsonPropertyName("group_key")]
    public required string GroupKey { get; set; }

    /// <summary>
    /// 用户列表，最大值：100。
    /// </summary>
    [JsonPropertyName("user_id_list")]
    public List<string> UserIdList { get; set; } = [];
}

/// <summary>
/// 批量新增参与考勤人员结果
/// </summary>
public class AttendanceGroupUsersAddResult
{
    /// <summary>
    /// 错误列表。
    /// </summary>
    [JsonPropertyName("error_info_list")]
    public List<AttendanceGroupUsersAddResultErrorInfoListItem> ErrorInfoList { get; set; } = [];

    /// <summary>
    /// 成功列表。
    /// </summary>
    [JsonPropertyName("success_list")]
    public List<string> SuccessList { get; set; } = [];
}

/// <summary>
/// AttendanceGroupUsersAddResultErrorInfoListItem
/// </summary>
public class AttendanceGroupUsersAddResultErrorInfoListItem
{
    /// <summary>
    /// 失败列表。
    /// </summary>
    [JsonPropertyName("failure_list")]
    public List<string> FailureList { get; set; } = [];

    /// <summary>
    /// 错误信息。
    /// </summary>
    public string? Msg { get; set; }

    /// <summary>
    /// 错误码。
    /// </summary>
    public string? Code { get; set; }
}

/// <summary>
/// 更新参与考勤人员请求
/// </summary>
public class AttendanceGroupMemberUpdateRequest
{
    /// <summary>
    /// 操作人userid。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 考勤组ID。如果你使用的是旧考勤组标识即group_key，可以调用groupKey转换为groupId接口将group_key转换为group_id。
    /// </summary>
    [JsonPropertyName("group_id")]
    public decimal GroupId { get; set; }

    /// <summary>
    /// 从哪天开始排班：0：从今天开始排班1：从明天开始排班
    /// </summary>
    [JsonPropertyName("schedule_flag")]
    public decimal ScheduleFlag { get; set; }

    /// <summary>
    /// 更新考勤组信息。
    /// </summary>
    [JsonPropertyName("update_param")]
    public AttendanceGroupMemberUpdateRequestUpdateParam UpdateParam { get; set; }
}

/// <summary>
/// 更新考勤组信息。
/// </summary>
public class AttendanceGroupMemberUpdateRequestUpdateParam
{
    /// <summary>
    /// 删除无需考勤的成员，没有的话，无需赋值。
    /// </summary>
    [JsonPropertyName("remove_extra_users")]
    public List<string> RemoveExtraUsers { get; set; } = [];

    /// <summary>
    /// 删除考勤部门，没有的话，无需赋值。
    /// </summary>
    [JsonPropertyName("remove_depts")]
    public List<string> RemoveDepts { get; set; } = [];

    /// <summary>
    /// 删除考勤人员，没有的话，无需赋值。
    /// </summary>
    [JsonPropertyName("remove_users")]
    public List<string> RemoveUsers { get; set; } = [];

    /// <summary>
    /// 添加考勤部门，没有的话，无需赋值。
    /// </summary>
    [JsonPropertyName("add_depts")]
    public List<string> AddDepts { get; set; } = [];

    /// <summary>
    /// 添加考勤人员，没有的话，无需赋值。
    /// </summary>
    [JsonPropertyName("add_users")]
    public List<string> AddUsers { get; set; } = [];

    /// <summary>
    /// 添加无需考勤的人员，没有的话，无需赋值。
    /// </summary>
    [JsonPropertyName("add_extra_users")]
    public List<string> AddExtraUsers { get; set; } = [];
}

/// <summary>
/// 获取参与考勤人员请求
/// </summary>
public class AttendanceGroupMemberListRequest
{
    /// <summary>
    /// 游标值，表示从第几个开始，不传默认从第1个开始。
    /// </summary>
    public decimal? Cursor { get; set; }

    /// <summary>
    /// 操作人userid。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 考勤组ID。如果你使用的是旧考勤组标识即group_key，可以调用groupKey转换为groupId接口将group_key转换为group_id。
    /// </summary>
    [JsonPropertyName("group_id")]
    public decimal GroupId { get; set; }
}

/// <summary>
/// 获取参与考勤人员结果
/// </summary>
public class AttendanceGroupMemberListResult
{
    /// <summary>
    /// 是否还有更多数据。
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// 游标。
    /// </summary>
    public decimal? Cursor { get; set; }

    /// <summary>
    /// 人员userid列表。
    /// </summary>
    public List<AttendanceGroupMemberListResultResultItem> Result { get; set; } = [];
}

/// <summary>
/// AttendanceGroupMemberListResultResultItem
/// </summary>
public class AttendanceGroupMemberListResultResultItem
{
    /// <summary>
    /// 是否需要考勤：0：需要考勤1：无需考勤人员
    /// </summary>
    [JsonPropertyName("atc_flag")]
    public string? AtcFlag { get; set; }

    /// <summary>
    /// 类型：0：员工1：部门
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// 成员ID，可以是userid或deptId。
    /// </summary>
    [JsonPropertyName("member_id")]
    public string? MemberId { get; set; }
}

/// <summary>
/// 获取考勤组员工的userid请求
/// </summary>
public class AttendanceGroupMemberusersListRequest
{
    /// <summary>
    /// 游标值，表示从第几个开始，不传默认从第一个开始。
    /// </summary>
    public decimal? Cursor { get; set; }

    /// <summary>
    /// 操作人userid。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 考勤组ID。如果你使用的是旧考勤组标识即group_key，可以调用groupKey转换为groupId接口将group_key转换为group_id。
    /// </summary>
    [JsonPropertyName("group_id")]
    public decimal GroupId { get; set; }
}

/// <summary>
/// 获取考勤组员工的userid结果
/// </summary>
public class AttendanceGroupMemberusersListResult
{
    /// <summary>
    /// 是否还有更多数据。
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// 分页获取下一次请求的起始位置。
    /// </summary>
    public decimal? Cursor { get; set; }

    /// <summary>
    /// 考勤组人员userid列表。
    /// </summary>
    public List<string> Result { get; set; } = [];
}

/// <summary>
/// 批量删除考勤组成员请求
/// </summary>
public class AttendanceGroupUsersRemoveRequest
{
    /// <summary>
    /// 操作人userid。
    /// </summary>
    [JsonPropertyName("op_userid")]
    public string? OpUserid { get; set; }

    /// <summary>
    /// 考勤组ID。如果你使用的考勤组标识是group_id，可以调用groupId转换为groupKey接口将group_id转换为group_key。
    /// </summary>
    [JsonPropertyName("group_key")]
    public required string GroupKey { get; set; }

    /// <summary>
    /// 用户列表。
    /// </summary>
    [JsonPropertyName("user_id_list")]
    public List<string> UserIdList { get; set; } = [];
}

/// <summary>
/// 批量删除考勤组成员结果
/// </summary>
public class AttendanceGroupUsersRemoveResult
{
    /// <summary>
    /// 错误列表。
    /// </summary>
    [JsonPropertyName("error_info_list")]
    public List<AttendanceGroupUsersRemoveResultErrorInfoListItem> ErrorInfoList { get; set; } = [];

    /// <summary>
    /// 成功列表。
    /// </summary>
    [JsonPropertyName("success_list")]
    public List<string> SuccessList { get; set; } = [];
}

/// <summary>
/// AttendanceGroupUsersRemoveResultErrorInfoListItem
/// </summary>
public class AttendanceGroupUsersRemoveResultErrorInfoListItem
{
    /// <summary>
    /// 失败列表。
    /// </summary>
    [JsonPropertyName("failure_list")]
    public List<string> FailureList { get; set; } = [];

    /// <summary>
    /// 错误描述。
    /// </summary>
    public string? Msg { get; set; }

    /// <summary>
    /// 错误码。
    /// </summary>
    public string? Code { get; set; }
}

/// <summary>
/// 查询考勤组员工请求
/// </summary>
public class AttendanceGroupUsersQueryRequest
{
    /// <summary>
    /// 分页大小。
    /// </summary>
    public decimal? Size { get; set; }

    /// <summary>
    /// 上一批次最后一个userid，传null、空值表示从头开始查。
    /// </summary>
    public required string Cursor { get; set; }

    /// <summary>
    /// 操作人userid。
    /// </summary>
    [JsonPropertyName("op_userid")]
    public string? OpUserid { get; set; }

    /// <summary>
    /// 考勤组ID。如果你使用的考勤组标识是group_id，可以调用groupId转换为groupKey接口将group_id转换为group_key。
    /// </summary>
    [JsonPropertyName("group_key")]
    public required string GroupKey { get; set; }
}

/// <summary>
/// 查询考勤组员工响应
/// </summary>
public class AttendanceGroupUsersQueryResponse
{
    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }

    /// <summary>
    /// 返回结果。
    /// </summary>
    public Dictionary<string, object?> Result { get; set; } = [];
}

/// <summary>
/// 考勤组成员校验请求
/// </summary>
public class AttendanceGroupMemberListByIdsRequest
{
    /// <summary>
    /// 操作人userid。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 考勤组ID。如果你使用的是旧考勤组标识即group_key，可以调用groupKey转换为groupId接口将group_key转换为group_id。
    /// </summary>
    [JsonPropertyName("group_id")]
    public decimal GroupId { get; set; }

    /// <summary>
    /// 成员ID，可以是userid或者deptId，多个ID之间使用英文逗号分割。
    /// </summary>
    [JsonPropertyName("member_ids")]
    public required string MemberIds { get; set; }

    /// <summary>
    /// 成员类型：0：员工1：部门
    /// </summary>
    [JsonPropertyName("member_type")]
    public decimal MemberType { get; set; }
}

/// <summary>
/// 考勤组成员校验结果
/// </summary>
public class AttendanceGroupMemberListByIdsResult
{
}

/// <summary>
/// 批量新增wifi信息请求
/// </summary>
public class AttendanceGroupWifisAddRequest
{
    /// <summary>
    /// 操作人的userid
    /// </summary>
    [JsonPropertyName("op_userid")]
    public string? OpUserid { get; set; }

    /// <summary>
    /// 考勤组ID。如果你使用的考勤组标识是group_id，可以调用groupId转换为groupKey接口将group_id转换为group_key。
    /// </summary>
    [JsonPropertyName("group_key")]
    public required string GroupKey { get; set; }

    /// <summary>
    /// wifi列表。
    /// </summary>
    [JsonPropertyName("wifi_list")]
    public List<AttendanceGroupWifisAddRequestWifiListItem> WifiList { get; set; } = [];
}

/// <summary>
/// AttendanceGroupWifisAddRequestWifiListItem
/// </summary>
public class AttendanceGroupWifisAddRequestWifiListItem
{
    /// <summary>
    /// 业务方wifiId。
    /// </summary>
    [JsonPropertyName("foreign_id")]
    public required string ForeignId { get; set; }

    /// <summary>
    /// MAC地址。
    /// </summary>
    [JsonPropertyName("mac_addr")]
    public required string MacAddr { get; set; }

    /// <summary>
    /// 名称。
    /// </summary>
    public required string Ssid { get; set; }
}

/// <summary>
/// 批量新增wifi信息结果
/// </summary>
public class AttendanceGroupWifisAddResult
{
    /// <summary>
    /// 添加wifi结果。
    /// </summary>
    public AttendanceGroupWifisAddResultResult Result { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? ErrCode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? ErrMsg { get; set; }

    /// <summary>
    /// 是否成功。
    /// </summary>
    public bool? Success { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 添加wifi结果。
/// </summary>
public class AttendanceGroupWifisAddResultResult
{
    /// <summary>
    /// 添加失败的WiFi列表。
    /// </summary>
    [JsonPropertyName("error_info_list")]
    public List<AttendanceGroupWifisAddResultResultErrorInfoListItem> ErrorInfoList { get; set; } = [];

    /// <summary>
    /// 添加成功的WiFi列表。
    /// </summary>
    [JsonPropertyName("success_list")]
    public List<AttendanceGroupWifisAddResultResultSuccessListItem> SuccessList { get; set; } = [];
}

/// <summary>
/// AttendanceGroupWifisAddResultResultErrorInfoListItem
/// </summary>
public class AttendanceGroupWifisAddResultResultErrorInfoListItem
{
    /// <summary>
    /// 失败列表。
    /// </summary>
    [JsonPropertyName("failure_list")]
    public List<AttendanceGroupWifisAddResultResultErrorInfoListItemFailureListItem> FailureList { get; set; } = [];

    /// <summary>
    /// 错误描述。
    /// </summary>
    public string? Msg { get; set; }

    /// <summary>
    /// 错误码。
    /// </summary>
    public string? Code { get; set; }
}

/// <summary>
/// AttendanceGroupWifisAddResultResultErrorInfoListItemFailureListItem
/// </summary>
public class AttendanceGroupWifisAddResultResultErrorInfoListItemFailureListItem
{
    /// <summary>
    /// 业务方wifiId。
    /// </summary>
    [JsonPropertyName("foreign_id")]
    public string? ForeignId { get; set; }

    /// <summary>
    /// MAC地址。
    /// </summary>
    [JsonPropertyName("mac_addr")]
    public string? MacAddr { get; set; }

    /// <summary>
    /// MAC名称。
    /// </summary>
    public string? Ssid { get; set; }

    /// <summary>
    /// 添加wifi失败的key。
    /// </summary>
    [JsonPropertyName("wifi_key")]
    public string? WifiKey { get; set; }
}

/// <summary>
/// AttendanceGroupWifisAddResultResultSuccessListItem
/// </summary>
public class AttendanceGroupWifisAddResultResultSuccessListItem
{
    /// <summary>
    /// 业务方wifiId。
    /// </summary>
    [JsonPropertyName("foreign_id")]
    public string? ForeignId { get; set; }

    /// <summary>
    /// MAC地址。
    /// </summary>
    [JsonPropertyName("mac_addr")]
    public string? MacAddr { get; set; }

    /// <summary>
    /// MAC名称。
    /// </summary>
    public string? Ssid { get; set; }

    /// <summary>
    /// 添加wifi成功的key。
    /// </summary>
    [JsonPropertyName("wifi_key")]
    public string? WifiKey { get; set; }
}

/// <summary>
/// 批量移除wifi请求
/// </summary>
public class AttendanceGroupWifisRemoveRequest
{
    /// <summary>
    /// 操作人userId。
    /// </summary>
    [JsonPropertyName("op_userid")]
    public string? OpUserid { get; set; }

    /// <summary>
    /// 考勤组ID。如果你使用的考勤组标识是group_id，可以调用groupId转换为groupKey接口将group_id转换为group_key。
    /// </summary>
    [JsonPropertyName("group_key")]
    public required string GroupKey { get; set; }

    /// <summary>
    /// wifi的key，可通过批量查询wifi接口获取。
    /// </summary>
    [JsonPropertyName("wifi_key_list")]
    public required string WifiKeyList { get; set; }
}

/// <summary>
/// 批量移除wifi结果
/// </summary>
public class AttendanceGroupWifisRemoveResult
{
    /// <summary>
    /// 失败列表。
    /// </summary>
    [JsonPropertyName("error_info_list")]
    public List<AttendanceGroupWifisRemoveResultErrorInfoListItem> ErrorInfoList { get; set; } = [];

    /// <summary>
    /// 成功列表。
    /// </summary>
    [JsonPropertyName("success_list")]
    public List<string> SuccessList { get; set; } = [];
}

/// <summary>
/// AttendanceGroupWifisRemoveResultErrorInfoListItem
/// </summary>
public class AttendanceGroupWifisRemoveResultErrorInfoListItem
{
    /// <summary>
    /// 错误列表。
    /// </summary>
    [JsonPropertyName("failure_list")]
    public List<string> FailureList { get; set; } = [];

    /// <summary>
    /// 错误描述。
    /// </summary>
    public string? Msg { get; set; }

    /// <summary>
    /// 错误码。
    /// </summary>
    public string? Code { get; set; }
}

/// <summary>
/// 批量查询wifi请求
/// </summary>
public class AttendanceGroupWifisQueryRequest
{
    /// <summary>
    /// 上一批次最后一个id，默认为空。
    /// </summary>
    public string? Cursor { get; set; }

    /// <summary>
    /// 分页大小。
    /// </summary>
    public decimal Size { get; set; }

    /// <summary>
    /// 操作人userId。
    /// </summary>
    [JsonPropertyName("op_userid")]
    public string? OpUserid { get; set; }

    /// <summary>
    /// 考勤组ID。如果你使用的考勤组标识是group_id，可以调用groupId转换为groupKey接口将group_id转换为group_key。
    /// </summary>
    [JsonPropertyName("group_key")]
    public required string GroupKey { get; set; }
}

/// <summary>
/// 批量查询wifi结果
/// </summary>
public class AttendanceGroupWifisQueryResult
{
    /// <summary>
    /// 查询wifi列表结果。
    /// </summary>
    public AttendanceGroupWifisQueryResultResult Result { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? ErrCode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? ErrMsg { get; set; }

    /// <summary>
    /// 是否成功。
    /// </summary>
    public bool? Success { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 查询wifi列表结果。
/// </summary>
public class AttendanceGroupWifisQueryResultResult
{
    /// <summary>
    /// wifi列表。
    /// </summary>
    [JsonPropertyName("wifi_list")]
    public List<AttendanceGroupWifisQueryResultResultWifiListItem> WifiList { get; set; } = [];

    /// <summary>
    /// 是否更多。
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}

/// <summary>
/// AttendanceGroupWifisQueryResultResultWifiListItem
/// </summary>
public class AttendanceGroupWifisQueryResultResultWifiListItem
{
    /// <summary>
    /// mac地址。
    /// </summary>
    [JsonPropertyName("mac_addr")]
    public string? MacAddr { get; set; }

    /// <summary>
    /// wifi名称。
    /// </summary>
    public string? Ssid { get; set; }

    /// <summary>
    /// wifi的key。
    /// </summary>
    [JsonPropertyName("wifi_key")]
    public string? WifiKey { get; set; }
}

/// <summary>
/// 批量新增地点请求
/// </summary>
public class AttendanceGroupPositionsAddRequest
{
    /// <summary>
    /// 操作人userId。
    /// </summary>
    [JsonPropertyName("op_userid")]
    public string? OpUserid { get; set; }

    /// <summary>
    /// 考勤组ID。如果你使用的考勤组标识是group_id，可以调用groupId转换为groupKey接口将group_id转换为group_key。
    /// </summary>
    [JsonPropertyName("group_key")]
    public required string GroupKey { get; set; }

    /// <summary>
    /// postion列表。
    /// </summary>
    [JsonPropertyName("position_list")]
    public AttendanceGroupPositionsAddRequestPositionList PositionList { get; set; }
}

/// <summary>
/// postion列表。
/// </summary>
public class AttendanceGroupPositionsAddRequestPositionList
{
    /// <summary>
    /// 地址描述。
    /// </summary>
    public required string Address { get; set; }

    /// <summary>
    /// 业务方positionId。
    /// </summary>
    [JsonPropertyName("foreign_id")]
    public required string ForeignId { get; set; }

    /// <summary>
    /// 经度（支持6位小数）。
    /// </summary>
    public required string Longitude { get; set; }

    /// <summary>
    /// 纬度（支持6位小数）。
    /// </summary>
    public required string Latitude { get; set; }
}

/// <summary>
/// 批量新增地点结果
/// </summary>
public class AttendanceGroupPositionsAddResult
{
    /// <summary>
    /// 查询结果。
    /// </summary>
    public AttendanceGroupPositionsAddResultResult Result { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? ErrCode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? ErrMsg { get; set; }

    /// <summary>
    /// 是否成功。
    /// </summary>
    public bool? Success { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 查询结果。
/// </summary>
public class AttendanceGroupPositionsAddResultResult
{
    /// <summary>
    /// 错误列表。
    /// </summary>
    [JsonPropertyName("error_info_list")]
    public List<AttendanceGroupPositionsAddResultResultErrorInfoListItem> ErrorInfoList { get; set; } = [];

    /// <summary>
    /// 成功列表。
    /// </summary>
    [JsonPropertyName("success_list")]
    public List<AttendanceGroupPositionsAddResultResultSuccessListItem> SuccessList { get; set; } = [];
}

/// <summary>
/// AttendanceGroupPositionsAddResultResultErrorInfoListItem
/// </summary>
public class AttendanceGroupPositionsAddResultResultErrorInfoListItem
{
    /// <summary>
    /// 失败列表。
    /// </summary>
    [JsonPropertyName("failure_list")]
    public List<AttendanceGroupPositionsAddResultResultErrorInfoListItemFailureListItem> FailureList { get; set; } = [];

    /// <summary>
    /// 错误信息。
    /// </summary>
    public string? Msg { get; set; }

    /// <summary>
    /// 错误码。
    /// </summary>
    public string? Code { get; set; }
}

/// <summary>
/// AttendanceGroupPositionsAddResultResultErrorInfoListItemFailureListItem
/// </summary>
public class AttendanceGroupPositionsAddResultResultErrorInfoListItemFailureListItem
{
    /// <summary>
    /// 业务方positionId。
    /// </summary>
    [JsonPropertyName("foreign_id")]
    public string? ForeignId { get; set; }

    /// <summary>
    /// 地址描述。
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// 经度(支持6位小数)。
    /// </summary>
    public string? Latitude { get; set; }

    /// <summary>
    /// 纬度(支持6位小数)。
    /// </summary>
    public string? Longitude { get; set; }

    /// <summary>
    /// 位置key，失败时为空。
    /// </summary>
    [JsonPropertyName("position_key")]
    public string? PositionKey { get; set; }
}

/// <summary>
/// AttendanceGroupPositionsAddResultResultSuccessListItem
/// </summary>
public class AttendanceGroupPositionsAddResultResultSuccessListItem
{
    /// <summary>
    /// 业务方positionId。
    /// </summary>
    [JsonPropertyName("foreign_id")]
    public string? ForeignId { get; set; }

    /// <summary>
    /// 地址描述。
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// 经度(支持6位小数)。
    /// </summary>
    public string? Latitude { get; set; }

    /// <summary>
    /// 纬度(支持6位小数)。
    /// </summary>
    public string? Longitude { get; set; }

    /// <summary>
    /// position的唯一标识。
    /// </summary>
    [JsonPropertyName("position_key")]
    public string? PositionKey { get; set; }
}

/// <summary>
/// 批量删除地点请求
/// </summary>
public class AttendanceGroupPositionsRemoveRequest
{
    /// <summary>
    /// 操作人userId。
    /// </summary>
    [JsonPropertyName("op_userid")]
    public string? OpUserid { get; set; }

    /// <summary>
    /// 考勤组ID。如果你使用的考勤组标识是group_id，可以调用groupId转换为groupKey接口将group_id转换为group_key。
    /// </summary>
    [JsonPropertyName("group_key")]
    public required string GroupKey { get; set; }

    /// <summary>
    /// 要删除position的key列表，可通过批量查询position接口获取。
    /// </summary>
    [JsonPropertyName("position_key_list")]
    public required string PositionKeyList { get; set; }
}

/// <summary>
/// 批量删除地点结果
/// </summary>
public class AttendanceGroupPositionsRemoveResult
{
    /// <summary>
    /// 成功列表。
    /// </summary>
    [JsonPropertyName("success_list")]
    public List<string> SuccessList { get; set; } = [];

    /// <summary>
    /// 错误列表。
    /// </summary>
    [JsonPropertyName("error_info_list")]
    public List<AttendanceGroupPositionsRemoveResultErrorInfoListItem> ErrorInfoList { get; set; } = [];
}

/// <summary>
/// AttendanceGroupPositionsRemoveResultErrorInfoListItem
/// </summary>
public class AttendanceGroupPositionsRemoveResultErrorInfoListItem
{
    /// <summary>
    /// 失败列表。
    /// </summary>
    [JsonPropertyName("failure_list")]
    public List<string> FailureList { get; set; } = [];

    /// <summary>
    /// 错误描述。
    /// </summary>
    public string? Msg { get; set; }

    /// <summary>
    /// 错误码。
    /// </summary>
    public string? Code { get; set; }
}

/// <summary>
/// 批量查询地点请求
/// </summary>
public class AttendanceGroupPositionsQueryRequest
{
    /// <summary>
    /// 上一批次的最后一个id，默认为空。
    /// </summary>
    public string? Cursor { get; set; }

    /// <summary>
    /// 分页大小。
    /// </summary>
    public decimal Size { get; set; }

    /// <summary>
    /// 操作人userId。
    /// </summary>
    [JsonPropertyName("op_userid")]
    public string? OpUserid { get; set; }

    /// <summary>
    /// 考勤组ID。如果你使用的考勤组标识是group_id，可以调用groupId转换为groupKey接口将group_id转换为group_key。
    /// </summary>
    [JsonPropertyName("group_key")]
    public required string GroupKey { get; set; }
}

/// <summary>
/// 批量查询地点结果
/// </summary>
public class AttendanceGroupPositionsQueryResult
{
    /// <summary>
    /// 查询结果。
    /// </summary>
    public AttendanceGroupPositionsQueryResultResult Result { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? ErrCode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? ErrMsg { get; set; }

    /// <summary>
    /// 是否成功。
    /// </summary>
    public bool? Success { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 查询结果。
/// </summary>
public class AttendanceGroupPositionsQueryResultResult
{
    /// <summary>
    /// position列表。
    /// </summary>
    [JsonPropertyName("position_list")]
    public List<AttendanceGroupPositionsQueryResultResultPositionListItem> PositionList { get; set; } = [];

    /// <summary>
    /// 是否更多。
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}

/// <summary>
/// AttendanceGroupPositionsQueryResultResultPositionListItem
/// </summary>
public class AttendanceGroupPositionsQueryResultResultPositionListItem
{
    /// <summary>
    /// 打卡位置允许偏移量。
    /// </summary>
    public decimal? Offset { get; set; }

    /// <summary>
    /// 地址描述。
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// 纬度(支持6位小数)。
    /// </summary>
    public string? Latitude { get; set; }

    /// <summary>
    /// 经度(支持6位小数)。
    /// </summary>
    public string? Longitude { get; set; }

    /// <summary>
    /// position的唯一标识。
    /// </summary>
    [JsonPropertyName("position_key")]
    public string? PositionKey { get; set; }
}

/// <summary>
/// 排班制考勤组排班请求
/// </summary>
public class AttendanceGroupScheduleAsyncRequest
{
    /// <summary>
    /// 操作人userid。
    /// </summary>
    [JsonPropertyName("op_user_id")]
    public required string OpUserId { get; set; }

    /// <summary>
    /// 考勤组ID。如果你使用的是旧考勤组标识即group_key，可以调用groupKey转换为groupId接口将group_key转换为group_id。
    /// </summary>
    [JsonPropertyName("group_id")]
    public decimal GroupId { get; set; }

    /// <summary>
    /// 排班详情。
    /// </summary>
    public List<AttendanceGroupScheduleAsyncRequestSchedulesItem> Schedules { get; set; } = [];
}

/// <summary>
/// AttendanceGroupScheduleAsyncRequestSchedulesItem
/// </summary>
public class AttendanceGroupScheduleAsyncRequestSchedulesItem
{
    /// <summary>
    /// 班次ID，休息班传1，可通过查询企业考勤排班详情接口获取。
    /// </summary>
    [JsonPropertyName("shift_id")]
    public decimal ShiftId { get; set; }

    /// <summary>
    /// 排班日期。
    /// </summary>
    [JsonPropertyName("work_date")]
    public decimal WorkDate { get; set; }

    /// <summary>
    /// 是否休息：true：休息当该参数为1时，shift_id传1。false：不休息
    /// </summary>
    [JsonPropertyName("is_rest")]
    public bool? IsRest { get; set; }

    /// <summary>
    /// 用户的userid。
    /// </summary>
    public required string Userid { get; set; }
}
