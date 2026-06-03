using System.Text.Json.Serialization;
using DingTalkApi.Models;

namespace DingTalkApi.Models.SmartDevice;

/// <summary>
/// 智能硬件通用响应。
/// </summary>
public class SmartDeviceResponse : DingTalkResult
{
    /// <summary>
    /// 请求是否成功。
    /// </summary>
    public bool? Success { get; set; }
}

/// <summary>
/// 绑定设备请求。
/// </summary>
public class SmartDeviceBindRequest
{
    /// <summary>
    /// 设备请求信息。
    /// </summary>
    public required SmartDeviceBindInfo DeviceBindReqVo { get; set; }
}

/// <summary>
/// 设备绑定信息。
/// </summary>
public class SmartDeviceBindInfo
{
    /// <summary>
    /// 设备昵称。
    /// </summary>
    public string? Nick { get; set; }

    /// <summary>
    /// sn地址。
    /// </summary>
    public required string Sn { get; set; }

    /// <summary>
    /// mac地址。
    /// </summary>
    public string? Mac { get; set; }

    /// <summary>
    /// 外部设备id。
    /// </summary>
    public string? Outid { get; set; }

    /// <summary>
    /// 扩展信息。
    /// </summary>
    public string? Ext { get; set; }

    /// <summary>
    /// 设备名称。
    /// </summary>
    public required string Dn { get; set; }

    /// <summary>
    /// 产品的唯一标识。
    /// </summary>
    public required string Pk { get; set; }
}

/// <summary>
/// 绑定设备响应。
/// </summary>
public class SmartDeviceBindResponse : SmartDeviceResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    public SmartDeviceBindResult? Result { get; set; }
}

/// <summary>
/// 设备绑定结果。
/// </summary>
public class SmartDeviceBindResult
{
    /// <summary>
    /// 设备ID。
    /// </summary>
    public string? DeviceId { get; set; }
}

/// <summary>
/// 解绑设备请求。
/// </summary>
public class SmartDeviceUnbindRequest
{
    /// <summary>
    /// 解绑参数。
    /// </summary>
    public required SmartDeviceUnbindInfo DeviceUnbindVo { get; set; }
}

/// <summary>
/// 设备解绑参数。
/// </summary>
public class SmartDeviceUnbindInfo
{
    /// <summary>
    /// 产品的唯一标识。
    /// </summary>
    public required string Pk { get; set; }

    /// <summary>
    /// 设备名称，可通过查询设备列表接口获取。该参数不能和设备id同时为空。
    /// </summary>
    public string? DeviceName { get; set; }

    /// <summary>
    /// 设备id，可通过查询设备列表接口获取。该参数不能和设备名称同时为空。
    /// </summary>
    public string? DeviceId { get; set; }

    /// <summary>
    /// 操作者userid。
    /// </summary>
    public string? Userid { get; set; }
}

/// <summary>
/// 修改设备昵称请求。
/// </summary>
public class SmartDeviceUpdateNickRequest
{
    /// <summary>
    /// 昵称修改参数。
    /// </summary>
    public required SmartDeviceUpdateNickInfo DeviceNickModifyVo { get; set; }
}

/// <summary>
/// 设备昵称修改参数。
/// </summary>
public class SmartDeviceUpdateNickInfo
{
    /// <summary>
    /// 产品的唯一标识。
    /// </summary>
    public required string Pk { get; set; }

    /// <summary>
    /// 设备名称，可通过查询设备列表接口获取。该参数不能和设备id同时为空。
    /// </summary>
    public string? DeviceName { get; set; }

    /// <summary>
    /// 设备id，可通过查询设备列表接口获取。该参数不能和设备名称同时为空。
    /// </summary>
    public string? DeviceId { get; set; }

    /// <summary>
    /// 新的设备昵称。
    /// </summary>
    public required string Nick { get; set; }
}

/// <summary>
/// 查询设备列表请求。
/// </summary>
public class SmartDeviceQueryListRequest
{
    /// <summary>
    /// 列表查询对象。
    /// </summary>
    public required SmartDevicePageQuery PageQueryVo { get; set; }
}

/// <summary>
/// 智能硬件分页查询对象。
/// </summary>
public class SmartDevicePageQuery
{
    /// <summary>
    /// 产品的唯一标识。
    /// </summary>
    public required string Pk { get; set; }

    /// <summary>
    /// 游标地址，第一页填0。
    /// </summary>
    public long Cursor { get; set; }

    /// <summary>
    /// 分页大小，最大20。
    /// </summary>
    public int Size { get; set; }
}

/// <summary>
/// 查询设备列表响应。
/// </summary>
public class SmartDeviceQueryListResponse : SmartDeviceResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    public SmartDeviceQueryListResult? Result { get; set; }
}

/// <summary>
/// 智能硬件设备分页结果。
/// </summary>
public class SmartDeviceQueryListResult
{
    /// <summary>
    /// 下一页的游标。
    /// </summary>
    public long? NextCursor { get; set; }

    /// <summary>
    /// 是否有下一页。
    /// </summary>
    public bool? HasMore { get; set; }

    /// <summary>
    /// 结果列表。
    /// </summary>
    public List<SmartDeviceInfo> List { get; set; } = [];
}

/// <summary>
/// 查询设备详情请求。
/// </summary>
public class SmartDeviceQueryRequest
{
    /// <summary>
    /// 设备查询对象。
    /// </summary>
    public required SmartDeviceQueryInfo DeviceQueryVo { get; set; }
}

/// <summary>
/// 设备查询对象。
/// </summary>
public class SmartDeviceQueryInfo
{
    /// <summary>
    /// 产品的唯一标识。
    /// </summary>
    public required string Pk { get; set; }

    /// <summary>
    /// 设备名称，可通过查询设备列表接口获取。该参数不能和设备id同时为空。
    /// </summary>
    public string? DeviceName { get; set; }

    /// <summary>
    /// 设备的id，可通过查询设备列表接口获取。该参数不能和设备名称同时为空。
    /// </summary>
    public string? DeviceId { get; set; }
}

/// <summary>
/// 根据设备ID查询设备请求。
/// </summary>
public class SmartDeviceQueryByIdRequest
{
    /// <summary>
    /// 设备查询对象。
    /// </summary>
    public required SmartDeviceQueryByIdInfo DeviceQueryVo { get; set; }
}

/// <summary>
/// 根据设备ID查询对象。
/// </summary>
public class SmartDeviceQueryByIdInfo
{
    /// <summary>
    /// 设备的id，可通过查询设备列表接口获取。
    /// </summary>
    public required string DeviceId { get; set; }
}

/// <summary>
/// 查询设备详情响应。
/// </summary>
public class SmartDeviceQueryResponse : SmartDeviceResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    public SmartDeviceInfo? Result { get; set; }
}

/// <summary>
/// 智能硬件设备信息。
/// </summary>
public class SmartDeviceInfo
{
    /// <summary>
    /// 企业的corpid。
    /// </summary>
    public string? CorpId { get; set; }

    /// <summary>
    /// 设备的mac地址。
    /// </summary>
    public string? DeviceMac { get; set; }

    /// <summary>
    /// 设备的昵称。
    /// </summary>
    public string? Nick { get; set; }

    /// <summary>
    /// 设备的id。
    /// </summary>
    public string? DeviceId { get; set; }

    /// <summary>
    /// 设备名称。
    /// </summary>
    public string? DeviceName { get; set; }

    /// <summary>
    /// 产品的唯一标识。
    /// </summary>
    public string? Pk { get; set; }

    /// <summary>
    /// 员工的userid。
    /// </summary>
    public string? Userid { get; set; }

    /// <summary>
    /// 备注信息。
    /// </summary>
    public string? Ext { get; set; }

    /// <summary>
    /// 设备序列号。
    /// </summary>
    public string? Sn { get; set; }
}
