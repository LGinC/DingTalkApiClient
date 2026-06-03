using System.ComponentModel;

namespace DingTalkApi.Enums;

/// <summary>
/// 多媒体输入状态
/// </summary>
public enum MediaInputStatus
{
    /// <summary>
    /// 初始化
    /// </summary>
    [Description("初始化")]
    Initializing = 0,

    /// <summary>
    /// 关闭
    /// </summary>
    [Description("关闭")]
    Off = 1,

    /// <summary>
    /// 打开
    /// </summary>
    [Description("打开")]
    On = 2
}