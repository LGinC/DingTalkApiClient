using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.Contacts.AuthScopes;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.Contacts;

/// <summary>
/// 通讯录权限范围api
/// </summary>
public interface IAuthScopesApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 获取通讯录权限范围
    /// </summary>
    [HttpGet("/auth/scopes")]
    ITask<AuthScopesGetResponse> GetAuthScopesAsync([JsonContent] AuthScopesGetRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
