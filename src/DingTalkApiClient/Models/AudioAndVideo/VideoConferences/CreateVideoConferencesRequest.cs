using System.ComponentModel.DataAnnotations;

namespace DingTalkApiClient.Models.AudioAndVideo.VideoConferences;

/// <summary>
/// 创建视频会议请求
/// </summary>
/// <param name="UserId">会议发起人的unionId</param>
/// <param name="ConfTitle">预约会议标题。标题最大长度限制不允许超过50</param>
/// <param name="InviteUserIds">邀请参会人员unionId列表</param>
/// <param name="InviteCaller">是否邀请主叫</param>
public record CreateVideoConferencesRequest(string UserId, [StringLength(50)] string ConfTitle, string[]? InviteUserIds = null, bool InviteCaller = true);

/// <summary>
/// 视频会议创建结果
/// </summary>
public class CreateVideoConferencesResult
{
    /// <summary>
    /// 会议 ID
    /// </summary>
    public required string ConferenceId { get; set; }

    /// <summary>
    /// 会议密码
    /// </summary>
    public string? ConferencePassword { get; set; }

    /// <summary>
    /// 主持人密码
    /// </summary>
    public string? HostPassword { get; set; }

    /// <summary>
    /// 入会链接
    /// </summary>
    public string? ExternalLinkUrl { get; set; }

    /// <summary>
    /// PSTN呼入号码
    /// </summary>
    public string[] PhoneNumbers { get; set; } = [];

    /// <summary>
    /// 房间码
    /// </summary>
    public required string RoomCode { get; set; }
}
