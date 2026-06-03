namespace DingTalkApiClient.Models.AudioAndVideo.VideoConferences;

/// <summary>
/// 
/// </summary>
public class VideoPlayResult
{
    /// <summary>
    /// 录制视频的在线播放链接（M3U8 格式）
    /// </summary>
    public string? PlayUrl { get; set; }

    /// <summary>
    /// 录制视频的MP4格式下载链接
    /// </summary>
    public required string Mp4FileUrl { get; set; }

    /// <summary>
    /// 录制视频的文件大小（单位：字节）
    /// </summary>
    public int Size { get; set; }

    /// <summary>
    /// 视频时长（单位：毫秒）
    /// </summary>
    public int Duration { get; set; }

    /// <summary>
    /// 视频状态  该字段暂无使用场景。
    /// </summary>
    public long Status { get; set; }
}