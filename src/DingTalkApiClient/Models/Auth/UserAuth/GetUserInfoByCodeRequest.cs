namespace DingTalkApiClient.Models.Auth.UserAuth;

/// <summary>
/// 通过免登码获取用户信息请求
/// </summary>
/// <param name="Code">免登授权码</param>
public record GetUserInfoByCodeRequest(string Code);

/// <summary>
/// 免登用户信息
/// </summary>
public class UserAuthInfo
{
    /// <summary>
    /// 用户的userid
    /// </summary>
    public required string Userid { get; set; }

    /// <summary>
    /// 设备ID
    /// </summary>
    public string? DeviceId { get; set; }

    /// <summary>
    /// 是否是管理员
    /// </summary>
    public bool Sys { get; set; }

    /// <summary>
    /// 管理员级别
    /// </summary>
    public long? SysLevel { get; set; }

    /// <summary>
    /// 用户关联的unionId
    /// </summary>
    public string? AssociatedUnionid { get; set; }

    /// <summary>
    /// 用户unionId
    /// </summary>
    public string? Unionid { get; set; }

    /// <summary>
    /// 用户名字
    /// </summary>
    public string? Name { get; set; }
}
