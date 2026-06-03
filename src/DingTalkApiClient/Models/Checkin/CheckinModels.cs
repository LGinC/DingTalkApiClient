using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models.Checkin;

/// <summary>
/// 获取用户签到记录请求
/// </summary>
public class GetUserCheckinRecordsRequest
{
    /// <summary>
    /// 需要查询的用户列表，最大列表长度为10。
    /// </summary>
    [JsonPropertyName("userid_list")]
    public required string UseridList { get; set; }

    /// <summary>
    /// 开始时间，Unix时间戳，单位毫秒。
    /// </summary>
    [JsonPropertyName("start_time")]
    public long StartTime { get; set; }

    /// <summary>
    /// 截止时间，单位毫秒。如果是取1个人的数据，时间范围最大到10天，如果是取多个人的数据，时间范围最大1天。
    /// </summary>
    [JsonPropertyName("end_time")]
    public long EndTime { get; set; }

    /// <summary>
    /// 分页查询的游标，最开始可以传0。
    /// </summary>
    public long Cursor { get; set; }

    /// <summary>
    /// 分页查询的每页大小，最大100。
    /// </summary>
    public long Size { get; set; }
}

/// <summary>
/// 获取用户签到记录响应
/// </summary>
public class GetUserCheckinRecordsResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    public CheckinRecordsResult? Result { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public int? ErrCode { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 签到记录分页结果
/// </summary>
public class CheckinRecordsResult
{
    /// <summary>
    /// 下次查询的游标，为null代表没有更多的数据了。
    /// </summary>
    [JsonPropertyName("next_cursor")]
    public long? NextCursor { get; set; }

    /// <summary>
    /// 签到信息。
    /// </summary>
    [JsonPropertyName("page_list")]
    public List<UserCheckinRecord> PageList { get; set; } = [];
}

/// <summary>
/// 用户签到信息
/// </summary>
public class UserCheckinRecord
{
    /// <summary>
    /// 签到时间，单位毫秒。
    /// </summary>
    [JsonPropertyName("checkin_time")]
    public long? CheckinTime { get; set; }

    /// <summary>
    /// 签到照片URL列表。
    /// </summary>
    [JsonPropertyName("image_list")]
    public List<string> ImageList { get; set; } = [];

    /// <summary>
    /// 签到详细地址。
    /// </summary>
    [JsonPropertyName("detail_place")]
    public string? DetailPlace { get; set; }

    /// <summary>
    /// 签到备注。
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 签到用户userid。
    /// </summary>
    public string? Userid { get; set; }

    /// <summary>
    /// 签到地址。
    /// </summary>
    public string? Place { get; set; }

    /// <summary>
    /// 签到位置经度（暂未开放）。
    /// </summary>
    public string? Longitude { get; set; }

    /// <summary>
    /// 签到位置维度（暂未开放）。
    /// </summary>
    public string? Latitude { get; set; }

    /// <summary>
    /// 签到的拜访对象，可以为外部联系人的userid或者用户自己输入的名字。
    /// </summary>
    [JsonPropertyName("visit_user")]
    public string? VisitUser { get; set; }
}

/// <summary>
/// 获取部门用户签到记录响应
/// </summary>
public class GetDepartmentCheckinRecordsResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    public List<DepartmentCheckinRecord> Data { get; set; } = [];

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? ErrMsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public int? ErrCode { get; set; }
}

/// <summary>
/// 部门用户签到信息
/// </summary>
public class DepartmentCheckinRecord
{
    /// <summary>
    /// 员工姓名。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 员工userid，不可修改。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 头像URL。
    /// </summary>
    public string? Avatar { get; set; }

    /// <summary>
    /// 签到时间，不可修改。
    /// </summary>
    public long? Timestamp { get; set; }

    /// <summary>
    /// 签到地址。
    /// </summary>
    public string? Place { get; set; }

    /// <summary>
    /// 签到详细地址。
    /// </summary>
    [JsonPropertyName("detailPlace")]
    public string? DetailPlace { get; set; }

    /// <summary>
    /// 签到备注。
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 签到照片URL列表。
    /// </summary>
    [JsonPropertyName("imageList")]
    public List<string> ImageList { get; set; } = [];

    /// <summary>
    /// 纬度。
    /// </summary>
    public string? Latitude { get; set; }

    /// <summary>
    /// 经度。
    /// </summary>
    public string? Longitude { get; set; }
}
