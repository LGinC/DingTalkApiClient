using System.ComponentModel;

namespace DingTalkApi.Enums;

/// <summary>
/// 与会状态
/// </summary>
public enum AttendStatus
{
    /// <summary>
    /// 未定义
    /// </summary>
    [Description("未定义")]
    Undefined = 0,

    /// <summary>
    /// 初始化
    /// </summary>
    [Description("初始化")]
    Initialized = 1,

    /// <summary>
    /// 加入中
    /// </summary>
    [Description("加入中")]
    Joining = 2,

    /// <summary>
    /// 在会
    /// </summary>
    [Description("在会")]
    InMeeting = 3,

    /// <summary>
    /// 加入失败
    /// </summary>
    [Description("加入失败")]
    JoinFailed = 4,

    /// <summary>
    /// 被踢出
    /// </summary>
    [Description("被踢出")]
    KickedOut = 5,

    /// <summary>
    /// 离开
    /// </summary>
    [Description("离开")]
    Left = 6,
}