namespace DingTalkApiClient.Models.AudioAndVideo.MeetingRooms;

/// <summary>
/// 会议室请求
/// </summary>
public class MeetingRoomRequest
{
    /// <summary>
    /// 操作人的unionId
    /// </summary>
    public required string UnionId { get; set; }

    /// <summary>
    /// 会议室名称
    /// </summary>
    public required string RoomName { get; set; }

    /// <summary>
    /// 会议室图片
    /// </summary>
    public string? RoomPicture { get; set; }

    /// <summary>
    /// 会议室位置信息
    /// </summary>
    public MeetingRoomLocation? RoomLocation { get; set; }

    /// <summary>
    /// 会议室标签ID列表
    /// </summary>
    public List<long> RoomLabelIds { get; set; } = [];

    /// <summary>
    /// 调用方外部会议室ID
    /// </summary>
    public string? IsvRoomId { get; set; }

    /// <summary>
    /// 预定权限
    /// </summary>
    public string? ReservationAuthority { get; set; }
}

/// <summary>
/// 更新会议室请求
/// </summary>
public class MeetingRoomUpdateRequest : MeetingRoomRequest
{
    /// <summary>
    /// 会议室ID
    /// </summary>
    public required string RoomId { get; set; }
}

/// <summary>
/// 会议室位置信息
/// </summary>
public class MeetingRoomLocation
{
    /// <summary>
    /// 会议室位置名称
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// 会议室位置详细信息
    /// </summary>
    public required string Desc { get; set; }
}

/// <summary>
/// 会议室ID响应
/// </summary>
public class MeetingRoomIdResponse
{
    /// <summary>
    /// 会议室ID
    /// </summary>
    public required string Result { get; set; }
}

/// <summary>
/// 会议室布尔响应
/// </summary>
public class MeetingRoomBooleanResponse
{
    /// <summary>
    /// 操作是否成功
    /// </summary>
    public bool Result { get; set; }
}

/// <summary>
/// 会议室详情响应
/// </summary>
public class MeetingRoomInfoResponse
{
    /// <summary>
    /// 会议室详情
    /// </summary>
    public required MeetingRoomInfo Result { get; set; }
}

/// <summary>
/// 会议室列表响应
/// </summary>
public class MeetingRoomListResponse
{
    /// <summary>
    /// 是否还有更多数据
    /// </summary>
    public bool HasMore { get; set; }

    /// <summary>
    /// 分页游标
    /// </summary>
    public string? NextToken { get; set; }

    /// <summary>
    /// 会议室列表
    /// </summary>
    public List<MeetingRoomInfo> Result { get; set; } = [];
}

/// <summary>
/// 会议室信息
/// </summary>
public class MeetingRoomInfo
{
    /// <summary>
    /// 会议室ID
    /// </summary>
    public required string RoomId { get; set; }

    /// <summary>
    /// 会议室名称
    /// </summary>
    public required string RoomName { get; set; }

    /// <summary>
    /// 会议室标签列表
    /// </summary>
    public List<MeetingRoomLabel> RoomLabels { get; set; } = [];

    /// <summary>
    /// 会议室可容纳人数
    /// </summary>
    public int RoomCapacity { get; set; }

    /// <summary>
    /// 会议室位置信息
    /// </summary>
    public MeetingRoomLocation? RoomLocation { get; set; }

    /// <summary>
    /// 会议室图片
    /// </summary>
    public string? RoomPicture { get; set; }

    /// <summary>
    /// 调用方外部会议室ID
    /// </summary>
    public string? IsvRoomId { get; set; }

    /// <summary>
    /// 会议室分组信息
    /// </summary>
    public MeetingRoomGroupInfo? RoomGroup { get; set; }
}

/// <summary>
/// 会议室标签
/// </summary>
public class MeetingRoomLabel
{
    /// <summary>
    /// 标签ID
    /// </summary>
    public long LabelId { get; set; }

    /// <summary>
    /// 标签名称
    /// </summary>
    public string? LabelName { get; set; }
}

/// <summary>
/// 查询视频会议设备信息响应
/// </summary>
public class MeetingRoomDeviceResponse
{
    /// <summary>
    /// 设备信息
    /// </summary>
    public required MeetingRoomDevice Result { get; set; }
}

/// <summary>
/// 视频会议设备信息
/// </summary>
public class MeetingRoomDevice
{
    /// <summary>
    /// 设备ID
    /// </summary>
    public required string DeviceId { get; set; }

    /// <summary>
    /// 设备unionId
    /// </summary>
    public string? DeviceUnionId { get; set; }

    /// <summary>
    /// 设备绑定的会议室ID
    /// </summary>
    public string? OpenRoomId { get; set; }

    /// <summary>
    /// 所属企业corpId
    /// </summary>
    public string? CorpId { get; set; }

    /// <summary>
    /// 设备名称
    /// </summary>
    public string? DeviceName { get; set; }

    /// <summary>
    /// 设备投屏码
    /// </summary>
    public string? ShareCode { get; set; }

    /// <summary>
    /// 设备sn码
    /// </summary>
    public string? DeviceSn { get; set; }

    /// <summary>
    /// 设备mac地址
    /// </summary>
    public string? DeviceMac { get; set; }

    /// <summary>
    /// 设备类型
    /// </summary>
    public string? DeviceType { get; set; }

    /// <summary>
    /// 设备注册serviceId
    /// </summary>
    public long DeviceServiceId { get; set; }

    /// <summary>
    /// 设备型号
    /// </summary>
    public string? DeviceModel { get; set; }

    /// <summary>
    /// 设备状态
    /// </summary>
    public string? DeviceStatus { get; set; }

    /// <summary>
    /// 设备控制器信息列表
    /// </summary>
    public List<MeetingRoomDevice> Controllers { get; set; } = [];

    /// <summary>
    /// 创建操作人
    /// </summary>
    public string? CreatorUnionId { get; set; }

    /// <summary>
    /// 所属会议室名称
    /// </summary>
    public string? RoomName { get; set; }

    /// <summary>
    /// 设备固件版本
    /// </summary>
    public string? FirmwareVersion { get; set; }

    /// <summary>
    /// 设备软件版本
    /// </summary>
    public string? SoftwareVersion { get; set; }

    /// <summary>
    /// 设备激活时间
    /// </summary>
    public long ActiveTime { get; set; }

    /// <summary>
    /// 设备网络类型
    /// </summary>
    public string? DevNetType { get; set; }

    /// <summary>
    /// 设备Ip
    /// </summary>
    public string? DevNetIp { get; set; }

    /// <summary>
    /// 设备无线mac地址
    /// </summary>
    public string? DevWifiMac { get; set; }

    /// <summary>
    /// 设备有线mac地址
    /// </summary>
    public string? DevWireMac { get; set; }

    /// <summary>
    /// 摄像头型号
    /// </summary>
    public string? DevCamera { get; set; }

    /// <summary>
    /// 麦克风型号
    /// </summary>
    public string? DevMic { get; set; }

    /// <summary>
    /// 扬声器型号
    /// </summary>
    public string? DevVoice { get; set; }

    /// <summary>
    /// 镜像状态
    /// </summary>
    public string? DevMirror { get; set; }

    /// <summary>
    /// HDMI输出状态
    /// </summary>
    public string? DevHdmi { get; set; }

    /// <summary>
    /// sip账号
    /// </summary>
    public string? SipAccountName { get; set; }
}

/// <summary>
/// 查询视频会议设备属性请求
/// </summary>
/// <param name="PropertyNames">设备属性名称列表，最大值10</param>
public record MeetingRoomDevicePropertiesRequest(List<string> PropertyNames);

/// <summary>
/// 查询视频会议设备属性响应
/// </summary>
public class MeetingRoomDevicePropertiesResponse
{
    /// <summary>
    /// 响应结果信息列表
    /// </summary>
    public List<MeetingRoomDeviceProperty> Result { get; set; } = [];
}

/// <summary>
/// 视频会议设备属性
/// </summary>
public class MeetingRoomDeviceProperty
{
    /// <summary>
    /// 设备属性名称
    /// </summary>
    public string? PropertyName { get; set; }

    /// <summary>
    /// 设备属性值
    /// </summary>
    public string? PropertyValue { get; set; }
}

/// <summary>
/// 会议室分组请求
/// </summary>
/// <param name="UnionId">操作人的unionId</param>
/// <param name="GroupName">分组名称</param>
public record MeetingRoomGroupRequest(string UnionId, string GroupName);

/// <summary>
/// 更新会议室分组请求
/// </summary>
/// <param name="UnionId">操作人的unionId</param>
/// <param name="GroupName">分组名称</param>
/// <param name="GroupId">分组ID</param>
public record MeetingRoomGroupUpdateRequest(string UnionId, string GroupName, long GroupId);

/// <summary>
/// 会议室分组ID响应
/// </summary>
public class MeetingRoomGroupIdResponse
{
    /// <summary>
    /// 创建的分组ID
    /// </summary>
    public long Result { get; set; }
}

/// <summary>
/// 会议室分组信息
/// </summary>
public class MeetingRoomGroupInfo
{
    /// <summary>
    /// 分组ID
    /// </summary>
    public long GroupId { get; set; }

    /// <summary>
    /// 分组名称
    /// </summary>
    public string? GroupName { get; set; }

    /// <summary>
    /// 父分组ID
    /// </summary>
    public long ParentId { get; set; }
}

/// <summary>
/// 会议室分组列表响应
/// </summary>
public class MeetingRoomGroupListResponse
{
    /// <summary>
    /// 结果列表
    /// </summary>
    public List<MeetingRoomGroupInfo> Result { get; set; } = [];
}

/// <summary>
/// 自定义屏幕模板请求
/// </summary>
public class ScreenTemplateRequest
{
    /// <summary>
    /// 模板名称
    /// </summary>
    public required string TemplateName { get; set; }

    /// <summary>
    /// 模板logo
    /// </summary>
    public string? Logo { get; set; }

    /// <summary>
    /// 模板企业名称
    /// </summary>
    public required string OrgName { get; set; }

    /// <summary>
    /// 模板自定义文字内容
    /// </summary>
    public required string CustomDoc { get; set; }

    /// <summary>
    /// 模板自定义背景网址
    /// </summary>
    public required string BgUrl { get; set; }

    /// <summary>
    /// 图片mediaId列表，最多9张
    /// </summary>
    public List<string> BgImgList { get; set; } = [];

    /// <summary>
    /// 设备unionId列表
    /// </summary>
    public List<string> DeviceUnionIds { get; set; } = [];

    /// <summary>
    /// 分组id列表
    /// </summary>
    public List<string> GroupIds { get; set; } = [];

    /// <summary>
    /// 会议室id列表
    /// </summary>
    public List<string> RoomIds { get; set; } = [];
}

/// <summary>
/// 自定义屏幕模板创建响应
/// </summary>
public class ScreenTemplateCreateResponse
{
    /// <summary>
    /// 模板id
    /// </summary>
    public long TemplateId { get; set; }
}

/// <summary>
/// 删除自定义屏幕模板请求
/// </summary>
/// <param name="TemplateId">模板id</param>
public record RemoveScreenTemplateRequest(string TemplateId);

/// <summary>
/// 自定义屏幕模板信息响应
/// </summary>
public class ScreenTemplateInfoResponse
{
    /// <summary>
    /// 响应结果
    /// </summary>
    public required ScreenTemplateInfo Result { get; set; }
}

/// <summary>
/// 自定义屏幕模板信息
/// </summary>
public class ScreenTemplateInfo
{
    /// <summary>
    /// 模板内容
    /// </summary>
    public required DeviceCustomTemplate DeviceCustomTemplate { get; set; }

    /// <summary>
    /// 设备unionId
    /// </summary>
    public List<string> DeviceUnionIds { get; set; } = [];

    /// <summary>
    /// 分组id
    /// </summary>
    public List<long> GroupIds { get; set; } = [];

    /// <summary>
    /// 会议室id
    /// </summary>
    public List<string> RoomIds { get; set; } = [];
}

/// <summary>
/// 自定义屏幕模板内容
/// </summary>
public class DeviceCustomTemplate
{
    /// <summary>
    /// 模板id
    /// </summary>
    public long TemplateId { get; set; }

    /// <summary>
    /// 所属企业corpId
    /// </summary>
    public string? CorpId { get; set; }

    /// <summary>
    /// 模板logo
    /// </summary>
    public string? Logo { get; set; }

    /// <summary>
    /// 模板企业名称
    /// </summary>
    public string? OrgName { get; set; }

    /// <summary>
    /// 模板自定义文字内容
    /// </summary>
    public string? CustomDoc { get; set; }

    /// <summary>
    /// 模板自定义背景网址
    /// </summary>
    public string? BgUrl { get; set; }

    /// <summary>
    /// 图片mediaId
    /// </summary>
    public List<string> BgImageList { get; set; } = [];

    /// <summary>
    /// 是否显示使用说明
    /// </summary>
    public bool Instruction { get; set; }

    /// <summary>
    /// 模板自定义背景类型
    /// </summary>
    public int BgType { get; set; }

    /// <summary>
    /// 是否展示首页信息栏
    /// </summary>
    public int IsPicTop { get; set; }

    /// <summary>
    /// 模板名称
    /// </summary>
    public string? TemplateName { get; set; }

    /// <summary>
    /// 模板类型
    /// </summary>
    public int ConfType { get; set; }

    /// <summary>
    /// 日程卡片是否展示日程标题
    /// </summary>
    public bool ShowCalendarTitle { get; set; }

    /// <summary>
    /// 投屏中是否隐藏投屏码
    /// </summary>
    public bool HideServerCodeWhenProjecting { get; set; }

    /// <summary>
    /// 模板子类型
    /// </summary>
    public int ConfSubType { get; set; }

    /// <summary>
    /// 是否脱敏预订人昵称
    /// </summary>
    public bool DesensitizeUserName { get; set; }

    /// <summary>
    /// 自定义背景图轮播间隔秒
    /// </summary>
    public int PicturePlayInterval { get; set; }

    /// <summary>
    /// 是否展示日程卡片
    /// </summary>
    public bool ShowCalendarCard { get; set; }

    /// <summary>
    /// 是否展示功能卡片
    /// </summary>
    public bool ShowFunctionCard { get; set; }
}
