using DingTalkApi.Enums;

namespace DingTalkApi.Models.AudioAndVideo.VideoConferences;

using System.Collections.Generic;
using System.Text.Json.Serialization;

/// <summary>
/// 获取视频会议列表请求
/// </summary>
/// <param name="ConferenceIdList">会议id列表</param>
public record GetVideoConferencesRequest(string[] ConferenceIdList);

/// <summary>
/// 会议列表查询结果
/// </summary>
public class VideoConferencesResult
{
    /// <summary>
    /// 会议详情列表
    /// </summary>
    [JsonPropertyName("infos")]
    public List<ConferenceInfo> Conferences { get; set; } = [];
}

/// <summary>
/// 会议详情
/// </summary>
public class ConferenceInfo
{
    /// <summary>
    /// 会议ID
    /// </summary>
    public required string ConferenceId { get; set; }

    /// <summary>
    /// 会议标题
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// 会议状态 
    /// </summary>
    public ConferenceStatus? Status { get; set; }

    /// <summary>
    /// 媒体状态 (0: 关闭, 1: 开启)
    /// </summary>
    public MediaStatus? MediaStatus { get; set; }

    /// <summary>
    /// 参会人员列表
    /// </summary>
    public List<AttendUserInfo> UserList { get; set; } = [];
}

/// <summary>
/// 参会用户的信息
/// </summary>
public class AttendUserInfo
{
    /// <summary>
    /// 用户ID
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 用户昵称
    /// </summary>
    [JsonPropertyName("nick")]
    public string? Nickname { get; set; }

    /// <summary>
    /// 参会状态
    /// </summary>
    public AttendStatus AttendStatus { get; set; }

    /// <summary>
    /// 摄像头状态
    /// </summary>
    public MediaInputStatus? CameraStatus { get; set; }

    /// <summary>
    /// 麦克风状态
    /// </summary>
    public MediaInputStatus? MicStatus { get; set; }

    /// <summary>
    /// 拒绝原因
    /// </summary>
    public string? RejectDescription { get; set; }
}