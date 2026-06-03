using System.Diagnostics.CodeAnalysis;

namespace DingTalkApi.Models.Contacts.UserManage;

/// <summary>
/// 根据手机号搜索用户id请求。
/// </summary>
public class MobileRequest
{
    /// <summary>
    /// 初始化手机号查询请求。
    /// </summary>
    /// <param name="mobile">手机号。</param>
    /// <param name="supportExclusiveAccountSearch">是否支持企业账号搜索。</param>
    public MobileRequest(string mobile, bool supportExclusiveAccountSearch = true)
    {
        Mobile = mobile;
        SupportExclusiveAccountSearch = supportExclusiveAccountSearch;
    }

    /// <summary>
    /// 用户的手机号。
    /// </summary>
    public string Mobile { get; set; }

    /// <summary>
    /// 是否支持通过手机号搜索企业账号。
    /// </summary>
    public bool SupportExclusiveAccountSearch { get; set; }
}

/// <summary>
/// 根据手机号搜索用户id响应。
/// </summary>
public class MobileResponse : UserGetByMobileResult
{
    /// <summary>
    /// 初始化手机号查询响应。
    /// </summary>
    /// <param name="exclusiveAccountUseridList">企业账号id列表。</param>
    /// <param name="userid">用户id。</param>
    [SetsRequiredMembers]
    public MobileResponse(string[]? exclusiveAccountUseridList, string? userid)
    {
        ExclusiveAccountUseridList = exclusiveAccountUseridList?.ToList() ?? [];
        Userid = userid ?? string.Empty;
    }
}
