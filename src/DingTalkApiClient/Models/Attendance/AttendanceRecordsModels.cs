using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models.Attendance;

#pragma warning disable CS1591
#pragma warning disable CS8618

/// <summary>
/// 获取打卡结果请求
/// </summary>
public class AttendanceListRequest
{
    /// <summary>
    /// 查询考勤打卡记录的起始工作日。格式为“yyyy-MM-dd HH:mm:ss”，HH:mm:ss可以使用00:00:00，将返回此日期从0点到24点的结果。workDateFrom ≤ x ≤ workDateEnd，即起始与结束工作日最多相隔7天（包含7天）。
    /// </summary>
    [JsonPropertyName("workDateFrom")]
    public required string WorkDateFrom { get; set; }

    /// <summary>
    /// 查询考勤打卡记录的结束工作日。格式为“yyyy-MM-dd HH:mm:ss”，HH:mm:ss可以使用00:00:00，将返回此日期从0点到24点的结果。workDateFrom ≤ x ≤ workDateEnd，即起始与结束工作日最多相隔7天（包含7天）。
    /// </summary>
    [JsonPropertyName("workDateTo")]
    public required string WorkDateTo { get; set; }

    /// <summary>
    /// 员工在企业内的userid列表，最多不能超过50个。
    /// </summary>
    [JsonPropertyName("userIdList")]
    public List<string> UserIdList { get; set; } = [];

    /// <summary>
    /// 表示获取考勤数据的起始点。第一次传0，如果还有多余数据，下次获取传的offset值为之前的offset+limit，0、1、2...依次递增。
    /// </summary>
    public decimal Offset { get; set; }

    /// <summary>
    /// 表示获取考勤数据的条数，最大不能超过50条。
    /// </summary>
    public decimal Limit { get; set; }

    /// <summary>
    /// 是否为海外企业使用：true：海外平台使用false（默认）：国内平台使用
    /// </summary>
    [JsonPropertyName("isI18n")]
    public bool? IsI18n { get; set; }
}

/// <summary>
/// 获取打卡结果响应
/// </summary>
public class AttendanceListResponse
{
    /// <summary>
    /// 打卡记录。
    /// </summary>
    public List<AttendanceListResponseRecordresultItem> Recordresult { get; set; } = [];

    /// <summary>
    /// 分页返回参数，表示是否还有更多数据。
    /// </summary>
    [JsonPropertyName("hasMore")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? ErrMsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? ErrCode { get; set; }
}

/// <summary>
/// AttendanceListResponseRecordresultItem
/// </summary>
public class AttendanceListResponseRecordresultItem
{
    /// <summary>
    /// 数据来源：ATM：考勤机打卡（指纹/人脸打卡）BEACON：IBeaconDING_ATM：钉钉考勤机（考勤机蓝牙打卡）USER：用户打卡BOSS：老板改签APPROVE：审批系统SYSTEM：考勤系统AUTO_CHECK：自动打卡
    /// </summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }

    /// <summary>
    /// 计算迟到和早退，基准时间。
    /// </summary>
    [JsonPropertyName("baseCheckTime")]
    public string? BaseCheckTime { get; set; }

    /// <summary>
    /// 实际打卡时间, 用户打卡时间的毫秒数。
    /// </summary>
    [JsonPropertyName("userCheckTime")]
    public string? UserCheckTime { get; set; }

    /// <summary>
    /// 关联的审批实例ID，当该字段非空时，表示打卡记录与请假、加班等审批有关。可以与获取审批实例详情配合使用。
    /// </summary>
    [JsonPropertyName("procInstId")]
    public string? ProcInstId { get; set; }

    /// <summary>
    /// 关联的审批ID，当该字段非空时，表示打卡记录与请假、加班等审批有关。
    /// </summary>
    [JsonPropertyName("approveId")]
    public decimal? ApproveId { get; set; }

    /// <summary>
    /// 位置结果：Normal：范围内Outside：范围外NotSigned：未打卡
    /// </summary>
    [JsonPropertyName("locationResult")]
    public string? LocationResult { get; set; }

    /// <summary>
    /// 打卡结果：Normal：正常Early：早退Late：迟到SeriousLate：严重迟到Absenteeism：旷工迟到NotSigned：未打卡
    /// </summary>
    [JsonPropertyName("timeResult")]
    public string? TimeResult { get; set; }

    /// <summary>
    /// 考勤类型：OnDuty：上班OffDuty：下班
    /// </summary>
    [JsonPropertyName("checkType")]
    public string? CheckType { get; set; }

    /// <summary>
    /// 打卡人的UserID。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 工作日。
    /// </summary>
    [JsonPropertyName("workDate")]
    public string? WorkDate { get; set; }

    /// <summary>
    /// 打卡记录ID。
    /// </summary>
    [JsonPropertyName("recordId")]
    public decimal? RecordId { get; set; }

    /// <summary>
    /// 排班ID。
    /// </summary>
    [JsonPropertyName("planId")]
    public decimal? PlanId { get; set; }

    /// <summary>
    /// 考勤组ID。
    /// </summary>
    [JsonPropertyName("groupId")]
    public decimal? GroupId { get; set; }

    /// <summary>
    /// 唯一标识ID。
    /// </summary>
    public decimal? Id { get; set; }
}

/// <summary>
/// 获取打卡详情请求
/// </summary>
public class AttendanceListRecordRequest
{
    /// <summary>
    /// 企业内的员工ID列表，最多不能超过50个。
    /// </summary>
    [JsonPropertyName("userIds")]
    public Dictionary<string, object?> UserIds { get; set; } = [];

    /// <summary>
    /// 查询考勤打卡记录的起始工作日。格式为：yyyy-MM-dd hh:mm:ss。
    /// </summary>
    [JsonPropertyName("checkDateFrom")]
    public required string CheckDateFrom { get; set; }

    /// <summary>
    /// 查询考勤打卡记录的结束工作日。格式为：yyyy-MM-dd hh:mm:ss。起始与结束工作日最多相隔7天。
    /// </summary>
    [JsonPropertyName("checkDateTo")]
    public required string CheckDateTo { get; set; }

    /// <summary>
    /// 是否为海外企业使用：true：海外平台使用false（默认）：国内平台使用
    /// </summary>
    [JsonPropertyName("isI18n")]
    public bool? IsI18n { get; set; }
}

/// <summary>
/// 获取打卡详情响应
/// </summary>
public class AttendanceListRecordResponse
{
    /// <summary>
    /// 打卡详情。
    /// </summary>
    public List<AttendanceListRecordResponseRecordresultItem> Recordresult { get; set; } = [];

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? ErrMsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? ErrCode { get; set; }
}

/// <summary>
/// AttendanceListRecordResponseRecordresultItem
/// </summary>
public class AttendanceListRecordResponseRecordresultItem
{
    /// <summary>
    /// 用户打卡定位精度。
    /// </summary>
    [JsonPropertyName("userAccuracy")]
    public string? UserAccuracy { get; set; }

    /// <summary>
    /// 班次ID。
    /// </summary>
    [JsonPropertyName("classId")]
    public decimal? ClassId { get; set; }

    /// <summary>
    /// 用户打卡纬度。
    /// </summary>
    [JsonPropertyName("userLatitude")]
    public string? UserLatitude { get; set; }

    /// <summary>
    /// 用户打卡经度。
    /// </summary>
    [JsonPropertyName("userLongitude")]
    public string? UserLongitude { get; set; }

    /// <summary>
    /// 用户打卡地址
    /// </summary>
    [JsonPropertyName("userAddress")]
    public string? UserAddress { get; set; }

    /// <summary>
    /// 打卡设备ID。
    /// </summary>
    [JsonPropertyName("deviceId")]
    public string? DeviceId { get; set; }

    /// <summary>
    /// 定位方法。
    /// </summary>
    [JsonPropertyName("locationMethod")]
    public string? LocationMethod { get; set; }

    /// <summary>
    /// 是否合法。Y：合法当timeResult和locationResult都为Normal时，为该值。N：不合法
    /// </summary>
    [JsonPropertyName("isLegal")]
    public string? IsLegal { get; set; }

    /// <summary>
    /// 实际打卡时间。
    /// </summary>
    [JsonPropertyName("userCheckTime")]
    public string? UserCheckTime { get; set; }

    /// <summary>
    /// 关联的审批实例id，当该字段非空时，表示打卡记录与请假、加班等审批有关，可以和获取审批实例详情配合使用。
    /// </summary>
    [JsonPropertyName("procInstId")]
    public string? ProcInstId { get; set; }

    /// <summary>
    /// 计算迟到和早退，基准时间；也可作为排班打卡时间。
    /// </summary>
    [JsonPropertyName("baseCheckTime")]
    public string? BaseCheckTime { get; set; }

    /// <summary>
    /// 关联的审批ID，当该字段非空时，表示打卡记录与请假、加班等审批有关。
    /// </summary>
    [JsonPropertyName("approveId")]
    public decimal? ApproveId { get; set; }

    /// <summary>
    /// 打卡结果：Normal：正常Early：早退Late：迟到SeriousLate：严重迟到Absenteeism：旷工迟到NotSigned：未打卡
    /// </summary>
    [JsonPropertyName("timeResult")]
    public string? TimeResult { get; set; }

    /// <summary>
    /// 位置结果：Normal：范围内Outside：范围外NotSigned：未打卡
    /// </summary>
    [JsonPropertyName("locationResult")]
    public string? LocationResult { get; set; }

    /// <summary>
    /// 考勤类型：OnDuty：上班OffDuty：下班
    /// </summary>
    [JsonPropertyName("checkType")]
    public string? CheckType { get; set; }

    /// <summary>
    /// 数据来源：ATM：考勤机打卡（指纹/人脸打卡）BEACON：IBeaconDING_ATM：钉钉考勤机（考勤机蓝牙打卡）USER：用户打卡BOSS：老板改签APPROVE：审批系统SYSTEM：考勤系统AUTO_CHECK：自动打卡
    /// </summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }

    /// <summary>
    /// 打卡人的userid。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 工作日。
    /// </summary>
    [JsonPropertyName("workDate")]
    public string? WorkDate { get; set; }

    /// <summary>
    /// 企业ID。
    /// </summary>
    [JsonPropertyName("corpId")]
    public string? CorpId { get; set; }

    /// <summary>
    /// 排班ID。
    /// </summary>
    [JsonPropertyName("planId")]
    public decimal? PlanId { get; set; }

    /// <summary>
    /// 考勤组ID。
    /// </summary>
    [JsonPropertyName("groupId")]
    public decimal? GroupId { get; set; }

    /// <summary>
    /// 考勤ID。
    /// </summary>
    public decimal? Id { get; set; }

    /// <summary>
    /// 异常信息类型：Security：安全相关原因Other：其他原因
    /// </summary>
    [JsonPropertyName("invalidRecordType")]
    public string? InvalidRecordType { get; set; }

    /// <summary>
    /// 用户打卡wifi SSID。
    /// </summary>
    [JsonPropertyName("userSsid")]
    public string? UserSsid { get; set; }

    /// <summary>
    /// 用户打卡wifi Mac地址。
    /// </summary>
    [JsonPropertyName("userMacAddr")]
    public string? UserMacAddr { get; set; }

    /// <summary>
    /// 排班打卡时间。
    /// </summary>
    [JsonPropertyName("planCheckTime")]
    public string? PlanCheckTime { get; set; }

    /// <summary>
    /// 基准地址。
    /// </summary>
    [JsonPropertyName("baseAddress")]
    public string? BaseAddress { get; set; }

    /// <summary>
    /// 基准经度。
    /// </summary>
    [JsonPropertyName("baseLongitude")]
    public string? BaseLongitude { get; set; }

    /// <summary>
    /// 基准纬度。
    /// </summary>
    [JsonPropertyName("baseLatitude")]
    public string? BaseLatitude { get; set; }

    /// <summary>
    /// 基准定位精度。
    /// </summary>
    [JsonPropertyName("baseAccuracy")]
    public string? BaseAccuracy { get; set; }

    /// <summary>
    /// 基准wifi ssid。
    /// </summary>
    [JsonPropertyName("baseSsid")]
    public string? BaseSsid { get; set; }

    /// <summary>
    /// 基准Mac地址。
    /// </summary>
    [JsonPropertyName("baseMacAddr")]
    public string? BaseMacAddr { get; set; }

    /// <summary>
    /// 打卡记录创建时间。
    /// </summary>
    [JsonPropertyName("gmtCreate")]
    public string? GmtCreate { get; set; }

    /// <summary>
    /// 对应的invalidRecordType异常信息的具体描述。
    /// </summary>
    [JsonPropertyName("invalidRecordMsg")]
    public string? InvalidRecordMsg { get; set; }

    /// <summary>
    /// 打卡记录修改时间。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }

    /// <summary>
    /// 打卡备注。
    /// </summary>
    [JsonPropertyName("outsideRemark")]
    public string? OutsideRemark { get; set; }

    /// <summary>
    /// 打卡设备序列号。
    /// </summary>
    [JsonPropertyName("deviceSN")]
    public string? DeviceSN { get; set; }

    /// <summary>
    /// 关联的业务ID。
    /// </summary>
    [JsonPropertyName("bizId")]
    public string? BizId { get; set; }
}

/// <summary>
/// 上传打卡记录请求
/// </summary>
public class AttendanceRecordUploadRequest
{
    /// <summary>
    /// 员工的userid。
    /// </summary>
    public required string Userid { get; set; }

    /// <summary>
    /// 自定义考勤机名称。
    /// </summary>
    [JsonPropertyName("device_name")]
    public required string DeviceName { get; set; }

    /// <summary>
    /// 自定义考勤机ID。
    /// </summary>
    [JsonPropertyName("device_id")]
    public required string DeviceId { get; set; }

    /// <summary>
    /// 打卡备注图片地址，必须是公网可访问的地址。
    /// </summary>
    [JsonPropertyName("photo_url")]
    public string? PhotoUrl { get; set; }

    /// <summary>
    /// 员工打卡的时间，单位毫秒。
    /// </summary>
    [JsonPropertyName("user_check_time")]
    public decimal UserCheckTime { get; set; }
}
