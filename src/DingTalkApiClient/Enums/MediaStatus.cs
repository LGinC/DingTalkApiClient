using System.ComponentModel;

namespace DingTalkApiClient.Enums;

/// <summary>
/// 媒体状态
/// </summary>
public enum MediaStatus
{
    /// <summary>
    /// 正常
    /// </summary>
    [Description("正常")]
    Normal = 0,

    /// <summary>
    /// 麦克风静音
    /// </summary>
    [Description("麦克风静音")]
    Muted = 1,

    /// <summary>
    /// 摄像头关闭
    /// </summary>
    [Description("摄像头关闭")]
    CameraClosed = 2,

    /// <summary>
    /// 强制全员静音
    /// </summary>
    [Description("强制全员静音")]
    AllForceMuted = 4
}