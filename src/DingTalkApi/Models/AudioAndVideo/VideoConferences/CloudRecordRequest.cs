namespace DingTalkApi.Models.AudioAndVideo.VideoConferences;

/// <summary>
/// 视频会议云录制请求
/// </summary>
/// <param name="UnionId">用户unionId 只有当用户是会议主持人时，才有权限开启云录制</param>
/// <param name="SmallWindowPosition">
/// 小窗位置
/// <example><list type="bullet">
/// <item>relative_right：分离右侧</item>
/// <item>float_right：悬浮右侧</item>
/// <item>float_bottom：悬浮底部</item>
/// </list></example>
/// </param>
/// <param name="Mode">布局
/// <example>
/// <list type="bullet">
/// <item>grid：宫格模式</item>
/// <item>speech：演讲者模式</item>
/// <item>full_screen：全屏模式</item>
/// </list>
/// </example>
/// </param>
public record CloudRecordRequest(string UnionId, string? SmallWindowPosition = null, string? Mode = null);
