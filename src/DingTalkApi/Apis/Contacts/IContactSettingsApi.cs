using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.Contacts.ContactSettings;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.Contacts;

/// <summary>
/// 通讯录设置api
/// </summary>
public interface IContactSettingsApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 获取企业邀请信息
    /// </summary>
    [HttpGet("/v1.0/contact/invites/infos")]
    ITask<ContactInvitesInfosGetResponse> GetContactInvitesInfosAsync(string? inviterUserId, string? deptId, [JsonContent] ContactInvitesInfosGetRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取企业最新钉钉指数信息
    /// </summary>
    [HttpGet("/v1.0/contact/dingIndexs")]
    ITask<ContactDingIndexsGetResponse> GetContactDingIndexsAsync([JsonContent] ContactDingIndexsGetRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取企业认证信息
    /// </summary>
    [HttpGet("/v1.0/contact/organizations/authInfos")]
    ITask<ContactOrganizationsAuthInfosGetResponse> GetContactOrganizationsAuthInfosAsync(string? targetCorpId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 新增或更新通讯录隐藏设置
    /// </summary>
    [HttpPut("/v1.0/contact/contactHideSettings")]
    ITask<ContactContactHideSettingsPutResponse> UpdateContactContactHideSettingsAsync([JsonContent] ContactContactHideSettingsPutRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取通讯录隐藏设置
    /// </summary>
    [HttpGet("/v1.0/contact/contactHideSettings")]
    ITask<ContactContactHideSettingsGetResponse> GetContactContactHideSettingsAsync(string? nextToken, string? maxResults, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除通讯录隐藏设置
    /// </summary>
    [HttpDelete("/v1.0/contact/contactHideSettings/{settingId}")]
    ITask<ContactContactHideSettingsSettingIdDeleteResponse> DeleteContactContactHideSettingsSettingIdAsync([PathQuery] string settingId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 设置部门可见性优先级
    /// </summary>
    [HttpPost("/v1.0/contact/depts/settings/priorities")]
    ITask<ContactDeptsSettingsPrioritiesResponse> ContactDeptsSettingsPrioritiesAsync([JsonContent] ContactDeptsSettingsPrioritiesRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 新增或修改限制查看通讯录设置
    /// </summary>
    [HttpPut("/v1.0/contact/restrictions/settings")]
    ITask<ContactRestrictionsSettingsPutResponse> UpdateContactRestrictionsSettingsAsync([JsonContent] ContactRestrictionsSettingsPutRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取限制查看通讯录设置列表
    /// </summary>
    [HttpGet("/v1.0/contact/restrictions/settings")]
    ITask<ContactRestrictionsSettingsGetResponse> GetContactRestrictionsSettingsAsync(string? nextToken, string? maxResults, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除限制查看通讯录设置
    /// </summary>
    [HttpGet("/v1.0/contact/restrictions/settings/{settingId}")]
    ITask<ContactRestrictionsSettingsSettingIdGetResponse> GetContactRestrictionsSettingsSettingIdAsync([PathQuery] string settingId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
