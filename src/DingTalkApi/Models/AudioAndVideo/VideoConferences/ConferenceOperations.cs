using System.Text.Json.Serialization;

namespace DingTalkApi.Models.AudioAndVideo.VideoConferences;

/// <summary>
/// 查询视频会议信息结果
/// </summary>
public class GetVideoConferenceResult
{
    /// <summary>
    /// 会议信息
    /// </summary>
    public required VideoConferenceDetail ConfInfo { get; set; }
}

/// <summary>
/// 视频会议详情
/// </summary>
public class VideoConferenceDetail
{
    /// <summary>
    /// 当前在会人数
    /// </summary>
    public int ActiveNum { get; set; }

    /// <summary>
    /// 累积入会人数
    /// </summary>
    public int AttendNum { get; set; }

    /// <summary>
    /// 会议时长，单位毫秒
    /// </summary>
    public long ConfDuration { get; set; }

    /// <summary>
    /// 会议ID
    /// </summary>
    public required string ConferenceId { get; set; }

    /// <summary>
    /// 会议创建人的unionId
    /// </summary>
    public required string CreatorId { get; set; }

    /// <summary>
    /// 会议创建人的昵称
    /// </summary>
    public required string CreatorNick { get; set; }

    /// <summary>
    /// 会议的入会链接
    /// </summary>
    public required string ExternalLinkUrl { get; set; }

    /// <summary>
    /// 邀请人数
    /// </summary>
    public int InvitedNum { get; set; }

    /// <summary>
    /// 会议开始时间戳，单位毫秒
    /// </summary>
    public long StartTime { get; set; }

    /// <summary>
    /// 会议状态。0：初始化；1：会议结束；2：会议开始
    /// </summary>
    public int Status { get; set; }

    /// <summary>
    /// 会议标题
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// 会议码
    /// </summary>
    public required string RoomCode { get; set; }

    /// <summary>
    /// 会议结束时间戳，单位毫秒
    /// </summary>
    public long EndTime { get; set; }
}

/// <summary>
/// 查询视频会议成员结果
/// </summary>
public class ConferenceMembersResult
{
    /// <summary>
    /// 成员列表
    /// </summary>
    public List<ConferenceMember> MemberModels { get; set; } = [];

    /// <summary>
    /// 分页游标
    /// </summary>
    public string? NextToken { get; set; }

    /// <summary>
    /// 总数量
    /// </summary>
    public int TotalCount { get; set; }
}

/// <summary>
/// 视频会议成员信息
/// </summary>
public class ConferenceMember
{
    /// <summary>
    /// 成员的unionId
    /// </summary>
    public required string UnionId { get; set; }

    /// <summary>
    /// 视频会议ID
    /// </summary>
    public required string ConferenceId { get; set; }

    /// <summary>
    /// 成员的昵称
    /// </summary>
    public string? UserNick { get; set; }

    /// <summary>
    /// 成员入会时间戳，单位毫秒
    /// </summary>
    public long JoinTime { get; set; }

    /// <summary>
    /// 成员离会时间戳，单位毫秒
    /// </summary>
    public long LeaveTime { get; set; }

    /// <summary>
    /// 在会时长，单位毫秒
    /// </summary>
    public long Duration { get; set; }

    /// <summary>
    /// 是否是主持人
    /// </summary>
    public bool Host { get; set; }

    /// <summary>
    /// 成员状态
    /// </summary>
    public int AttendStatus { get; set; }

    /// <summary>
    /// 是否非会议所属企业内成员
    /// </summary>
    public bool? OuterOrgMember { get; set; }

    /// <summary>
    /// 是否为电话号码入会
    /// </summary>
    public bool? PstnJoin { get; set; }

    /// <summary>
    /// 是否为联席主持人
    /// </summary>
    public bool? CoHost { get; set; }

    /// <summary>
    /// 入会的设备类型
    /// </summary>
    public string? DeviceType { get; set; }
}

/// <summary>
/// 查询用户进行中会议列表结果
/// </summary>
public class UserOnGoingConferencesResult
{
    /// <summary>
    /// 进行中的会议ID列表
    /// </summary>
    public List<string> OnGoingConfIdList { get; set; } = [];

    /// <summary>
    /// 查询用户在会中的成员信息映射
    /// </summary>
    public Dictionary<string, ConferenceMember> MemberModelMap { get; set; } = [];
}

/// <summary>
/// 会议操作成功结果
/// </summary>
public class ConferenceSuccessResult
{
    /// <summary>
    /// 是否成功
    /// </summary>
    public bool Success { get; set; }
}

/// <summary>
/// 邀请用户入会请求
/// </summary>
/// <param name="UnionId">操作用户unionId</param>
/// <param name="InviteeList">被邀请人列表</param>
public record InviteConferenceUsersRequest(string? UnionId = null, List<ConferenceInvitee>? InviteeList = null);

/// <summary>
/// 被邀请人信息
/// </summary>
public class ConferenceInvitee
{
    /// <summary>
    /// 被邀请用户unionId
    /// </summary>
    public string? UnionId { get; set; }

    /// <summary>
    /// 被邀请人姓名
    /// </summary>
    public required string Nick { get; set; }
}

/// <summary>
/// 会议用户操作请求
/// </summary>
/// <param name="UserList">被操作用户列表</param>
public record ConferenceUsersRequest(List<ConferenceUser> UserList);

/// <summary>
/// 会议用户信息
/// </summary>
public class ConferenceUser
{
    /// <summary>
    /// 用户unionId
    /// </summary>
    public required string UnionId { get; set; }

    /// <summary>
    /// 用户参会者id，多设备场景使用
    /// </summary>
    public string? ParticipantId { get; set; }
}

/// <summary>
/// 设置全员看他请求
/// </summary>
/// <param name="Action">行为动作。focus：全员看他；un_focus：取消全员看他</param>
/// <param name="UnionId">被操作用户unionId</param>
public record SetConferenceFocusRequest(string Action, string UnionId);

/// <summary>
/// 带动作的会议用户操作请求
/// </summary>
/// <param name="Action">行为动作</param>
/// <param name="UserList">被操作用户列表</param>
public record SetConferenceUsersActionRequest(string Action, List<ConferenceUser> UserList);

/// <summary>
/// 会议动作请求
/// </summary>
/// <param name="Action">操作类型。mute：静音；un_mute：取消静音</param>
public record ConferenceActionRequest(string Action);

/// <summary>
/// 开启视频会议直播推流请求
/// </summary>
public class StartConferenceStreamOutRequest
{
    /// <summary>
    /// 用户unionId
    /// </summary>
    public required string UnionId { get; set; }

    /// <summary>
    /// 推流地址列表
    /// </summary>
    public List<string> StreamUrlList { get; set; } = [];

    /// <summary>
    /// 推流名称
    /// </summary>
    public required string StreamName { get; set; }

    /// <summary>
    /// 布局。grid：宫格模式；speech：演讲者模式；full_screen：全屏模式
    /// </summary>
    public required string Mode { get; set; }

    /// <summary>
    /// 小窗位置
    /// </summary>
    public required string SmallWindowPosition { get; set; }

    /// <summary>
    /// 是否需要主持人加入后才允许推流
    /// </summary>
    public bool NeedHostJoin { get; set; }
}

/// <summary>
/// 开启视频会议直播推流结果
/// </summary>
public class StartConferenceStreamOutResult
{
    /// <summary>
    /// 成功推流地址与liveId映射
    /// </summary>
    public Dictionary<string, string> SuccessStreamMap { get; set; } = [];

    /// <summary>
    /// 失败的地址与失败原因映射
    /// </summary>
    public Dictionary<string, string> FailStreamMap { get; set; } = [];
}

/// <summary>
/// 停止视频会议直播推流请求
/// </summary>
/// <param name="StreamId">推流id</param>
/// <param name="UnionId">用户unionId</param>
/// <param name="StopAllStream">是否停止所有流</param>
public record StopConferenceStreamOutRequest(string StreamId, string UnionId, bool StopAllStream);

/// <summary>
/// 停止视频会议直播推流结果
/// </summary>
public class StopConferenceStreamOutResult
{
    /// <summary>
    /// 返回码
    /// </summary>
    public string? Code { get; set; }
}

/// <summary>
/// 创建预约会议请求
/// </summary>
/// <param name="CreatorUnionId">创建者unionId</param>
/// <param name="Title">预约会议标题</param>
/// <param name="StartTime">预约会议开始时间，毫秒级UTC时间戳</param>
/// <param name="EndTime">预约会议结束时间，毫秒级UTC时间戳</param>
public record CreateScheduleConferenceRequest(string CreatorUnionId, string Title, string StartTime, string EndTime);

/// <summary>
/// 更新预约会议请求
/// </summary>
/// <param name="CreatorUnionId">预约会议创建者unionId</param>
/// <param name="ScheduleConferenceId">预约会议id</param>
/// <param name="Title">预约会议标题</param>
/// <param name="StartTime">预约会议开始时间，毫秒级UTC时间戳</param>
/// <param name="EndTime">预约会议结束时间，毫秒级UTC时间戳</param>
public record UpdateScheduleConferenceRequest(string CreatorUnionId, string ScheduleConferenceId, string Title, string StartTime, string EndTime);

/// <summary>
/// 取消预约会议请求
/// </summary>
/// <param name="ScheduleConferenceId">预约会议id</param>
/// <param name="CreatorUnionId">预约会议创建者unionId</param>
public record CancelScheduleConferenceRequest(string ScheduleConferenceId, string CreatorUnionId);

/// <summary>
/// 预约会议创建结果
/// </summary>
public class ScheduleConferenceResult
{
    /// <summary>
    /// 请求id
    /// </summary>
    public required string RequestId { get; set; }

    /// <summary>
    /// 预约会议id
    /// </summary>
    public required string ScheduleConferenceId { get; set; }

    /// <summary>
    /// 会议号
    /// </summary>
    public required string RoomCode { get; set; }

    /// <summary>
    /// 预约会议分享链接
    /// </summary>
    public required string Url { get; set; }

    /// <summary>
    /// 呼入电话号码
    /// </summary>
    public List<string> Phones { get; set; } = [];
}

/// <summary>
/// 预约会议信息结果
/// </summary>
public class ScheduleConferenceInfoResult : ScheduleConferenceResult
{
    /// <summary>
    /// 预约会议标题
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// 预约会议开始时间，毫秒级UTC时间戳
    /// </summary>
    public long StartTime { get; set; }

    /// <summary>
    /// 预约会议结束时间，毫秒级UTC时间戳
    /// </summary>
    public long EndTime { get; set; }
}

/// <summary>
/// 预约会议历史会议信息结果
/// </summary>
public class ScheduleConferenceHistoryResult
{
    /// <summary>
    /// 数据总量
    /// </summary>
    public int TotalCount { get; set; }

    /// <summary>
    /// 分页游标
    /// </summary>
    public string? NextToken { get; set; }

    /// <summary>
    /// 会议列表
    /// </summary>
    public List<ScheduleConferenceHistory> ConferenceList { get; set; } = [];
}

/// <summary>
/// 预约会议历史会议
/// </summary>
public class ScheduleConferenceHistory
{
    /// <summary>
    /// 会议id
    /// </summary>
    public required string ConferenceId { get; set; }

    /// <summary>
    /// 会议标题
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// 会议号
    /// </summary>
    public required string RoomCode { get; set; }

    /// <summary>
    /// 会议状态。0：待开始；1：进行中；2：已结束
    /// </summary>
    public int Status { get; set; }

    /// <summary>
    /// 会议开始时间，单位毫秒
    /// </summary>
    public long StartTime { get; set; }

    /// <summary>
    /// 会议结束时间，单位毫秒
    /// </summary>
    public long EndTime { get; set; }
}
