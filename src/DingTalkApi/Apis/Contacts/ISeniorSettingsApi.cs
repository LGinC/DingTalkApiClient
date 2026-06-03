using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.Contacts.SeniorSettings;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.Contacts;

/// <summary>
/// 高管模式api
/// </summary>
public interface ISeniorSettingsApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 设置高管模式
    /// </summary>
    [HttpPost("/v1.0/contact/seniorSettings")]
    ITask<ContactSeniorSettingsResponse> ContactSeniorSettingsAsync([JsonContent] ContactSeniorSettingsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取用户高管模式设置
    /// </summary>
    [HttpGet("/v1.0/contact/seniorSettings")]
    ITask<ContactSeniorSettingsGetResponse> GetContactSeniorSettingsAsync(string seniorStaffId, [JsonContent] ContactSeniorSettingsGetRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
