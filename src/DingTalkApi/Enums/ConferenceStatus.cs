using System.ComponentModel;

namespace DingTalkApi.Enums;

/// <summary>
/// 会议状态
/// </summary>
public enum ConferenceStatus
{
    /// <summary>
    /// 初始化
    /// </summary>
    [Description("初始化")]
    Initiated = 0,
    /// <summary>
    /// 开始
    /// </summary>
    [Description("开始")]
    Started = 2,
    /// <summary>
    /// 结束
    /// </summary>
    [Description("结束")]
    Ended = 1,
}