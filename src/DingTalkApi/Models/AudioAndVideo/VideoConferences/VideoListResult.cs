using System.Collections.Generic;
using DingTalkApi.Enums;

namespace DingTalkApi.Models.AudioAndVideo.VideoConferences;

/// <summary>
/// 视频记录列表响应
/// </summary>
public class VideoListResult
{
    /// <summary>
    /// 视频记录列表
    /// </summary>
    public List<VideoInfo> VideoList { get; set; } = [];
}

/// <summary>
/// 单个视频记录信息
/// </summary>
public class VideoInfo
{
    /// <summary>
    /// 视频记录唯一ID
    /// </summary>
    public required string RecordId { get; set; }

    /// <summary>
    /// 关联的用户/会话ID
    /// </summary>
    public required string UnionId { get; set; }

    /// <summary>
    /// 开始时间戳（毫秒）
    /// </summary>
    public long StartTime { get; set; }

    /// <summary>
    /// 录制类型
    /// </summary>
    public RecordType RecordType { get; set; }

    /// <summary>
    /// 视频时长（毫秒）
    /// </summary>
    public int Duration { get; set; }

    /// <summary>
    /// 文件大小（字节）
    /// </summary>
    public int FileSize { get; set; }

    /// <summary>
    /// 结束时间戳（毫秒）
    /// </summary>
    public long EndTime { get; set; }

    /// <summary>
    /// 媒体资源ID
    /// </summary>
    public required string MediaId { get; set; }

    /// <summary>
    /// 存储区域ID（如 cn-shenzhen）
    /// </summary>
    public required string RegionId { get; set; }
}