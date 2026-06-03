using System.Text.Json.Serialization;

namespace DingTalkApi.Models.Attendance;

#pragma warning disable CS1591
#pragma warning disable CS8618

/// <summary>
/// 根据设备ID获取员工信息响应
/// </summary>
public class AttendanceMachinesGetUserDevIdGetResponse
{
    /// <summary>
    /// 考勤机设备上的员工信息。
    /// </summary>
    public AttendanceMachinesGetUserDevIdGetResponseResult Result { get; set; }
}

/// <summary>
/// 考勤机设备上的员工信息。
/// </summary>
public class AttendanceMachinesGetUserDevIdGetResponseResult
{
    /// <summary>
    /// 员工列表。
    /// </summary>
    [JsonPropertyName("userList")]
    public List<AttendanceMachinesGetUserDevIdGetResponseResultUserListItem> UserList { get; set; } = [];

    /// <summary>
    /// 是否还有更多数据。 true：有 false：没有
    /// </summary>
    [JsonPropertyName("hasMore")]
    public bool HasMore { get; set; }

    /// <summary>
    /// 下一次请求的分页游标。
    /// </summary>
    [JsonPropertyName("nextToken")]
    public required string NextToken { get; set; }
}

/// <summary>
/// AttendanceMachinesGetUserDevIdGetResponseResultUserListItem
/// </summary>
public class AttendanceMachinesGetUserDevIdGetResponseResultUserListItem
{
    /// <summary>
    /// 员工的userId。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 员工姓名。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 是否有人脸信息。 true：有 false：没有
    /// </summary>
    [JsonPropertyName("hasFace")]
    public bool? HasFace { get; set; }
}

/// <summary>
/// 查询考勤机信息响应
/// </summary>
public class AttendanceMachinesDevIdGetResponse
{
    /// <summary>
    /// 考勤机的相关信息。
    /// </summary>
    public AttendanceMachinesDevIdGetResponseResult Result { get; set; }
}

/// <summary>
/// 考勤机的相关信息。
/// </summary>
public class AttendanceMachinesDevIdGetResponseResult
{
    /// <summary>
    /// 加密后的考勤机设备ID。
    /// </summary>
    [JsonPropertyName("deviceId")]
    public required string DeviceId { get; set; }

    /// <summary>
    /// 考勤机设备ID。
    /// </summary>
    [JsonPropertyName("devId")]
    public long DevId { get; set; }

    /// <summary>
    /// 设备名称。
    /// </summary>
    [JsonPropertyName("deviceName")]
    public required string DeviceName { get; set; }

    /// <summary>
    /// 设备类型名称。
    /// </summary>
    [JsonPropertyName("productName")]
    public required string ProductName { get; set; }

    /// <summary>
    /// 网络状态，取值。 1：激活 2：未激活 3：已连接 4：已断开
    /// </summary>
    [JsonPropertyName("netStatus")]
    public required string NetStatus { get; set; }

    /// <summary>
    /// 固件版本。
    /// </summary>
    [JsonPropertyName("productVersion")]
    public required string ProductVersion { get; set; }

    /// <summary>
    /// 设备序列号。
    /// </summary>
    [JsonPropertyName("deviceSn")]
    public required string DeviceSn { get; set; }

    /// <summary>
    /// 人脸容量。
    /// </summary>
    [JsonPropertyName("maxFace")]
    public long MaxFace { get; set; }

    /// <summary>
    /// 音量模式。
    /// </summary>
    [JsonPropertyName("voiceMode")]
    public long VoiceMode { get; set; }

    /// <summary>
    /// 设备管理员列表。
    /// </summary>
    [JsonPropertyName("atmManagerList")]
    public List<string> AtmManagerList { get; set; } = [];

    /// <summary>
    /// 考勤机蓝牙相关设置信息。
    /// </summary>
    [JsonPropertyName("machineBluetoothVO")]
    public AttendanceMachinesDevIdGetResponseResultMachineBluetoothVO MachineBluetoothVO { get; set; }
}

/// <summary>
/// 考勤机蓝牙相关设置信息。
/// </summary>
public class AttendanceMachinesDevIdGetResponseResultMachineBluetoothVO
{
    /// <summary>
    /// 蓝牙是否打开打卡。 true：打开 false：未打开
    /// </summary>
    [JsonPropertyName("bluetoothValue")]
    public bool BluetoothValue { get; set; }

    /// <summary>
    /// 蓝牙是否打开打卡人脸识别。 true：打开 false：未打开
    /// </summary>
    [JsonPropertyName("bluetoothCheckWithFace")]
    public bool BluetoothCheckWithFace { get; set; }

    /// <summary>
    /// 蓝牙打卡范围。
    /// </summary>
    [JsonPropertyName("bluetoothDistanceMode")]
    public required string BluetoothDistanceMode { get; set; }

    /// <summary>
    /// 蓝牙打卡范围描述。
    /// </summary>
    [JsonPropertyName("bluetoothDistanceModeDesc")]
    public required string BluetoothDistanceModeDesc { get; set; }

    /// <summary>
    /// 是否打开位置异常监控。 true：打开 false：未打开
    /// </summary>
    [JsonPropertyName("monitorLocationAbnormal")]
    public bool MonitorLocationAbnormal { get; set; }

    /// <summary>
    /// 地址位置描述。
    /// </summary>
    public required string Address { get; set; }

    /// <summary>
    /// 经度。
    /// </summary>
    public decimal Longitude { get; set; }

    /// <summary>
    /// 纬度。
    /// </summary>
    public decimal Latitude { get; set; }

    /// <summary>
    /// 是否限制员工常用手机。 true：限制 false：不限制
    /// </summary>
    [JsonPropertyName("limitUserDeviceCount")]
    public bool LimitUserDeviceCount { get; set; }

    /// <summary>
    /// 员工常用手机数量。
    /// </summary>
    [JsonPropertyName("userDeviceCount")]
    public long UserDeviceCount { get; set; }
}

/// <summary>
/// 变更智能考勤机员工请求
/// </summary>
public class SmartDeviceAtMachinesUsersPutRequest
{
    /// <summary>
    /// 移除的员工userId列表。
    /// </summary>
    [JsonPropertyName("delUserIds")]
    public List<string> DelUserIds { get; set; } = [];

    /// <summary>
    /// 加密后的考勤机设备ID列表，字符串数组。 企业内部应用，调用查询考勤机信息接口获取deviceId参数值。 第三方企业应用，调用查询考勤机信息接口获取deviceId参数值。
    /// </summary>
    [JsonPropertyName("deviceIds")]
    public List<string> DeviceIds { get; set; } = [];

    /// <summary>
    /// 新增的员工userId列表。
    /// </summary>
    [JsonPropertyName("addUserIds")]
    public List<string> AddUserIds { get; set; } = [];

    /// <summary>
    /// 考勤机设备ID列表，Long数组。 企业内部应用，调用查询设备列表接口获取device_id参数值。 第三方企业应用，调用查询设备列表接口获取device_id参数值。
    /// </summary>
    [JsonPropertyName("devIds")]
    public List<string> DevIds { get; set; } = [];

    /// <summary>
    /// 删除的部门id列表。 企业内部应用，调用获取部门列表接口获取dept_id参数值。 第三方企业应用，调用获取部门列表接口获取dept_id参数值。
    /// </summary>
    [JsonPropertyName("delDeptIds")]
    public List<string> DelDeptIds { get; set; } = [];

    /// <summary>
    /// 新增的部门id列表。 企业内部应用，调用获取部门列表接口获取dept_id参数值。 第三方企业应用，调用获取部门列表接口获取dept_id参数值。
    /// </summary>
    [JsonPropertyName("addDeptIds")]
    public List<string> AddDeptIds { get; set; } = [];
}

/// <summary>
/// 变更智能考勤机员工响应
/// </summary>
public class SmartDeviceAtMachinesUsersPutResponse
{
}
