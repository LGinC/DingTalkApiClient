using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.Auth.SsoAuth;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.Auth;

/// <summary>
/// 应用后台免登api
/// </summary>
public interface ISsoAuthApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 获取应用管理员的身份信息
    /// </summary>
    /// <param name="code">通过Oauth认证给URL带上的code</param>
    /// <param name="tokenProviderName">TokenProvider 名称</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("/sso/getuserinfo")]
    public ITask<SsoUserInfoResult> GetSsoUserInfoAsync(
        string code,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.MicroApp,
        CancellationToken cancellationToken = default);
}
