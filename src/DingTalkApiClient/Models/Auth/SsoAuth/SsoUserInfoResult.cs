using DingTalkApiClient.Models;

namespace DingTalkApiClient.Models.Auth.SsoAuth;

/// <summary>
/// 应用管理员身份信息
/// </summary>
public class SsoUserInfoResult : DingTalkResult
{
    /// <summary>
    /// 用户信息
    /// </summary>
    public SsoUserInfo? UserInfo { get; set; }

    /// <summary>
    /// 企业信息
    /// </summary>
    public SsoCorpInfo? CorpInfo { get; set; }

    /// <summary>
    /// 是否是管理员
    /// </summary>
    public bool IsSys { get; set; }
}

/// <summary>
/// 应用管理员用户信息
/// </summary>
public class SsoUserInfo
{
    /// <summary>
    /// 头像地址
    /// </summary>
    public string? Avatar { get; set; }

    /// <summary>
    /// email地址
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// 用户名字
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 员工在企业内的userid
    /// </summary>
    public string? Userid { get; set; }
}

/// <summary>
/// 应用管理员企业信息
/// </summary>
public class SsoCorpInfo
{
    /// <summary>
    /// 公司名字
    /// </summary>
    public string? CorpName { get; set; }

    /// <summary>
    /// 公司corpid
    /// </summary>
    public string? Corpid { get; set; }
}
