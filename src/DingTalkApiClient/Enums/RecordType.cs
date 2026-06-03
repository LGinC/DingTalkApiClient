using System.ComponentModel;

namespace DingTalkApiClient.Enums;

/// <summary>
/// 录制类型
/// </summary>
public enum RecordType
{
    /// <summary>
    /// 普通录制
    /// </summary>
    [Description("普通录制")]
    Normal = 0,

    /// <summary>
    /// 合成文件
    /// </summary>
    [Description("合成文件")]
    Merge = 1,
}