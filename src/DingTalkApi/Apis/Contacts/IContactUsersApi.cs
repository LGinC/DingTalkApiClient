using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.Contacts.ContactUsers;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.Contacts;

/// <summary>
/// 通讯录用户api
/// </summary>
public interface IContactUsersApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 获取用户通讯录个人信息
    /// </summary>
    [HttpGet("/v1.0/contact/users/{unionId}")]
    ITask<ContactUsersUnionIdGetResponse> GetContactUsersUnionIdAsync([PathQuery] string unionId, [JsonContent] ContactUsersUnionIdGetRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
