using System.Text.Json.Serialization;

namespace DingTalkApi.Models.Attendance;

#pragma warning disable CS1591
#pragma warning disable CS8618

/// <summary>
/// 查询员工智能考勤机列表请求
/// </summary>
public class SmartDeviceAtmachineGetByUseridRequest
{
    /// <summary>
    /// 请求结构。
    /// </summary>
    public SmartDeviceAtmachineGetByUseridRequestParam Param { get; set; }
}

/// <summary>
/// 请求结构。
/// </summary>
public class SmartDeviceAtmachineGetByUseridRequestParam
{
    /// <summary>
    /// 分页游标，从0开始的非负整数。
    /// </summary>
    public decimal Offset { get; set; }

    /// <summary>
    /// 每页大小。
    /// </summary>
    public decimal Size { get; set; }

    /// <summary>
    /// 员工userid。
    /// </summary>
    public required string Userid { get; set; }
}

/// <summary>
/// 查询员工智能考勤机列表结果
/// </summary>
public class SmartDeviceAtmachineGetByUseridResult
{
    /// <summary>
    /// 考勤机列表。
    /// </summary>
    [JsonPropertyName("machine_list")]
    public List<SmartDeviceAtmachineGetByUseridResultMachineListItem> MachineList { get; set; } = [];

    /// <summary>
    /// 是否有更多数据。true：有false：没有
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}

/// <summary>
/// SmartDeviceAtmachineGetByUseridResultMachineListItem
/// </summary>
public class SmartDeviceAtmachineGetByUseridResultMachineListItem
{
    /// <summary>
    /// 考勤机唯一ID。
    /// </summary>
    public string? Deviceid { get; set; }

    /// <summary>
    /// 考勤机名称。
    /// </summary>
    [JsonPropertyName("device_name")]
    public string? DeviceName { get; set; }

    /// <summary>
    /// 考勤机类型名称，即考勤机型号。
    /// </summary>
    [JsonPropertyName("product_name")]
    public string? ProductName { get; set; }

    /// <summary>
    /// 考勤机唯一ID。
    /// </summary>
    public decimal? Devid { get; set; }
}
