namespace DingTalkApi.Models.AudioAndVideo.Live;

/// <summary>
/// 创建直播请求
/// </summary>
public class LiveCreateRequest
{
    /// <summary>
    /// 用户unionId
    /// </summary>
    public required string UnionId { get; set; }

    /// <summary>
    /// 直播标题
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// 直播简介
    /// </summary>
    public string? Introduction { get; set; }

    /// <summary>
    /// 封面地址
    /// </summary>
    public string? CoverUrl { get; set; }

    /// <summary>
    /// 预开始时间，毫秒级时间戳
    /// </summary>
    public long? PreStartTime { get; set; }
}

/// <summary>
/// 修改直播属性请求
/// </summary>
public class LiveUpdateRequest : LiveCreateRequest
{
    /// <summary>
    /// 直播ID
    /// </summary>
    public required string LiveId { get; set; }
}

/// <summary>
/// 创建直播响应
/// </summary>
public class LiveCreateResponse
{
    /// <summary>
    /// 直播创建结果
    /// </summary>
    public required LiveCreateResult Result { get; set; }
}

/// <summary>
/// 直播创建结果
/// </summary>
public class LiveCreateResult
{
    /// <summary>
    /// 直播ID
    /// </summary>
    public required string LiveId { get; set; }

    /// <summary>
    /// 直播观看地址
    /// </summary>
    public string? WatchUrl { get; set; }
}

/// <summary>
/// 直播布尔响应
/// </summary>
public class LiveBooleanResponse
{
    /// <summary>
    /// 操作结果
    /// </summary>
    public bool Result { get; set; }
}

/// <summary>
/// 查询直播信息响应
/// </summary>
public class LiveInfoResponse
{
    /// <summary>
    /// 直播信息
    /// </summary>
    public required LiveInfo Result { get; set; }
}

/// <summary>
/// 直播信息
/// </summary>
public class LiveInfo
{
    /// <summary>
    /// 直播ID
    /// </summary>
    public required string LiveId { get; set; }

    /// <summary>
    /// 直播标题
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 直播简介
    /// </summary>
    public string? Introduction { get; set; }

    /// <summary>
    /// 封面地址
    /// </summary>
    public string? CoverUrl { get; set; }

    /// <summary>
    /// 直播状态
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// 观看地址
    /// </summary>
    public string? WatchUrl { get; set; }
}

/// <summary>
/// 查询直播观看人员响应
/// </summary>
public class LiveWatchUsersResponse
{
    /// <summary>
    /// 观看人员分页信息
    /// </summary>
    public required LiveWatchUsersResult Result { get; set; }
}

/// <summary>
/// 直播观看人员分页信息
/// </summary>
public class LiveWatchUsersResult
{
    /// <summary>
    /// 总数
    /// </summary>
    public int TotalCount { get; set; }

    /// <summary>
    /// 观看人员列表
    /// </summary>
    public List<LiveWatchUser> List { get; set; } = [];
}

/// <summary>
/// 直播观看人员
/// </summary>
public class LiveWatchUser
{
    /// <summary>
    /// 用户unionId
    /// </summary>
    public string? UnionId { get; set; }

    /// <summary>
    /// 用户昵称
    /// </summary>
    public string? Nick { get; set; }

    /// <summary>
    /// 观看时长，单位秒
    /// </summary>
    public long WatchTime { get; set; }
}
