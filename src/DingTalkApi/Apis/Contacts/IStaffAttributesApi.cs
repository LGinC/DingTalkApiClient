using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.Contacts.StaffAttributes;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.Contacts;

/// <summary>
/// 用户属性api
/// </summary>
public interface IStaffAttributesApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 删除用户属性可见性设置
    /// </summary>
    [HttpDelete("/v1.0/contact/staffAttributes/visibilitySettings/{settingId}")]
    ITask<ContactStaffAttributesVisibilitySettingsSettingIdDeleteResponse> DeleteContactStaffAttributesVisibilitySettingsSettingIdAsync([PathQuery] string settingId, [JsonContent] ContactStaffAttributesVisibilitySettingsSettingIdDeleteRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取用户属性可见性设置
    /// </summary>
    [HttpGet("/v1.0/contact/staffAttributes/visibilitySettings")]
    ITask<ContactStaffAttributesVisibilitySettingsGetResponse> GetContactStaffAttributesVisibilitySettingsAsync(string? nextToken, string? maxResults, [JsonContent] ContactStaffAttributesVisibilitySettingsGetRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 设置用户属性可见性
    /// </summary>
    [HttpPost("/v1.0/contact/staffAttributes/visibilitySettings")]
    ITask<ContactStaffAttributesVisibilitySettingsResponse> ContactStaffAttributesVisibilitySettingsAsync([JsonContent] ContactStaffAttributesVisibilitySettingsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
