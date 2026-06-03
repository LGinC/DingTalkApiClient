using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models;
using DingTalkApiClient.Models.Contacts.OrgAccounts;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.Contacts;

/// <summary>
/// 企业帐号api
/// </summary>
public interface IOrgAccountsApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 根据迁移后的dingId查询原dingId
    /// </summary>
    [HttpGet("/v1.0/contact/orgAccount/getDingIdByMigrationDingIds")]
    ITask<ContactOrgAccountGetDingIdByMigrationDingIdsGetResponse> GetContactOrgAccountGetDingIdByMigrationDingIdsAsync(string migrationDingId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 根据迁移后的unionId查询原unionId
    /// </summary>
    [HttpGet("/v1.0/contact/orgAccount/getUnionIdByMigrationUnionIds")]
    ITask<ContactOrgAccountGetUnionIdByMigrationUnionIdsGetResponse> GetContactOrgAccountGetUnionIdByMigrationUnionIdsAsync(string migrationUnionId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 根据原dingId查询迁移后的dingId
    /// </summary>
    [HttpGet("/v1.0/contact/orgAccount/getMigrationDingIdByDingIds")]
    ITask<ContactOrgAccountGetMigrationDingIdByDingIdsGetResponse> GetContactOrgAccountGetMigrationDingIdByDingIdsAsync(string dingId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 根据原unionId查询迁移后的unionId
    /// </summary>
    [HttpGet("/v1.0/contact/orgAccount/getMigrationUnionIdByUnionIds")]
    ITask<ContactOrgAccountGetMigrationUnionIdByUnionIdsGetResponse> GetContactOrgAccountGetMigrationUnionIdByUnionIdsAsync(string unionId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 启用企业帐号
    /// </summary>
    [HttpPost("/v1.0/contact/orgAccounts/enable")]
    ITask<ContactOrgAccountsEnableResponse> ContactOrgAccountsEnableAsync([JsonContent] ContactOrgAccountsEnableRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 停用企业帐号
    /// </summary>
    [HttpPost("/v1.0/contact/orgAccounts/disable")]
    ITask<ContactOrgAccountsDisableResponse> ContactOrgAccountsDisableAsync([JsonContent] ContactOrgAccountsDisableRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 强制登出企业帐号
    /// </summary>
    [HttpPost("/v1.0/contact/orgAccounts/signOut")]
    ITask<ContactOrgAccountsSignOutResponse> ContactOrgAccountsSignOutAsync([JsonContent] ContactOrgAccountsSignOutRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询企业帐号状态
    /// </summary>
    [HttpGet("/v1.0/contact/orgAccounts/status")]
    ITask<ContactOrgAccountsStatusGetResponse> GetContactOrgAccountsStatusAsync(string? userId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 授权企业帐号可加入多组织
    /// </summary>
    [HttpPost("/v1.0/contact/orgAccounts/multiOrgPermissions/auth")]
    ITask<ContactOrgAccountsMultiOrgPermissionsAuthResponse> ContactOrgAccountsMultiOrgPermissionsAuthAsync([JsonContent] ContactOrgAccountsMultiOrgPermissionsAuthRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询企业帐号拥有的组织
    /// </summary>
    [HttpGet("/v1.0/contact/orgAccounts/ownedOrganizations")]
    ITask<ContactOrgAccountsOwnedOrganizationsGetResponse> GetContactOrgAccountsOwnedOrganizationsAsync(string? userId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 企业帐号转交主管理员（创建者）
    /// </summary>
    [HttpPost("/v1.0/contact/orgAccounts/mainAdministrators/change")]
    ITask<ContactOrgAccountsMainAdministratorsChangeResponse> ContactOrgAccountsMainAdministratorsChangeAsync([JsonContent] ContactOrgAccountsMainAdministratorsChangeRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
