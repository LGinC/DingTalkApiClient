using System.Text.Json.Serialization;
namespace DingTalkApiClient.Models.Contacts.OrgAccounts;
#pragma warning disable CS8618
/// <summary>
/// 根据迁移后的dingId查询原dingId响应
/// </summary>
public class ContactOrgAccountGetDingIdByMigrationDingIdsGetResponse
{
    /// <summary>
    /// 原普通账号的dingId。
    /// </summary>
    [JsonPropertyName("dingId")]
    public required string DingId { get; set; }
}

/// <summary>
/// 根据迁移后的unionId查询原unionId响应
/// </summary>
public class ContactOrgAccountGetUnionIdByMigrationUnionIdsGetResponse
{
    /// <summary>
    /// 原普通账号的unionId。
    /// </summary>
    [JsonPropertyName("unionId")]
    public required string UnionId { get; set; }
}

/// <summary>
/// 根据原dingId查询迁移后的dingId响应
/// </summary>
public class ContactOrgAccountGetMigrationDingIdByDingIdsGetResponse
{
    /// <summary>
    /// 迁移后企业账号的dingId。
    /// </summary>
    [JsonPropertyName("$:LWCP_v1")]
    public required string LWCPV1 { get; set; }
}

/// <summary>
/// 根据原unionId查询迁移后的unionId响应
/// </summary>
public class ContactOrgAccountGetMigrationUnionIdByUnionIdsGetResponse
{
    /// <summary>
    /// LWCPV1
    /// </summary>
    [JsonPropertyName("$:LWCP_v1")]
    public required string LWCPV1 { get; set; }
}

/// <summary>
/// 启用企业帐号请求
/// </summary>
public class ContactOrgAccountsEnableRequest
{
    /// <summary>
    /// 企业账号的userid，可通过以下四种方式获得： - [根据手机号查询企业帐号用户](https://open.dingtalk.com/document/orgapp/obtain-the-userid-of-your-mobile-phone-number) - [创建SSO企业帐号](https://open.dingtalk.com/document/orgapp/create-an-sso-account) - [创建钉钉自建企业帐号](https://open.dingtalk.com/document/orgapp/create-dingtalk-user-created-dedicated-account) - [邀请其他组织企业帐号加入](https://open.dingtalk.com/document/orgapp/invite-other-organization-specific-accounts-to-join)
    /// </summary>
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }
}

/// <summary>
/// 启用企业帐号响应
/// </summary>
public class ContactOrgAccountsEnableResponse
{
    /// <summary>
    /// 启用操作结果。
    /// </summary>
    [JsonPropertyName("result")]
    public bool Result { get; set; }
}

/// <summary>
/// 停用企业帐号请求
/// </summary>
public class ContactOrgAccountsDisableRequest
{
    /// <summary>
    /// 企业账号的userid，可通过以下四种方式获得： 根据手机号查询企业帐号用户 创建SSO企业帐号 创建钉钉自建企业帐号 邀请其他组织企业帐号加入
    /// </summary>
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }

    /// <summary>
    /// 企业账号停用原因。
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

/// <summary>
/// 停用企业帐号响应
/// </summary>
public class ContactOrgAccountsDisableResponse
{
    /// <summary>
    /// 停用操作结果。
    /// </summary>
    [JsonPropertyName("result")]
    public bool Result { get; set; }
}

/// <summary>
/// 强制登出企业帐号请求
/// </summary>
public class ContactOrgAccountsSignOutRequest
{
    /// <summary>
    /// 企业账号的userid，可通过以下四种方式获得： 根据手机号查询企业帐号用户 创建SSO企业帐号 创建钉钉自建企业帐号 邀请其他组织企业帐号加入
    /// </summary>
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }

    /// <summary>
    /// 企业账号强制登出的原因。
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

/// <summary>
/// 强制登出企业帐号响应
/// </summary>
public class ContactOrgAccountsSignOutResponse
{
    /// <summary>
    /// 退出是否成功，true表示成功。
    /// </summary>
    [JsonPropertyName("result")]
    public bool Result { get; set; }
}

/// <summary>
/// 查询企业帐号状态响应
/// </summary>
public class ContactOrgAccountsStatusGetResponse
{
    /// <summary>
    /// 企业账号状态，取值： true：停用 false：可用
    /// </summary>
    [JsonPropertyName("disable")]
    public bool Disable { get; set; }
}

/// <summary>
/// 授权企业帐号可加入多组织请求
/// </summary>
public class ContactOrgAccountsMultiOrgPermissionsAuthRequest
{
    /// <summary>
    /// 被授权的组织CorpId。
    /// </summary>
    [JsonPropertyName("joinCorpId")]
    public required string JoinCorpId { get; set; }

    /// <summary>
    /// 授权的部门列表。 如果该参数不传，授权整个企业。 如果该参数传值，授权参数值对应的部门。
    /// </summary>
    [JsonPropertyName("grantDeptIdList")]
    public List<string> GrantDeptIdList { get; set; } = [];
}

/// <summary>
/// 授权企业帐号可加入多组织响应
/// </summary>
public class ContactOrgAccountsMultiOrgPermissionsAuthResponse
{
}

/// <summary>
/// 查询企业帐号拥有的组织响应
/// </summary>
public class ContactOrgAccountsOwnedOrganizationsGetResponse
{
    /// <summary>
    /// 组织列表。
    /// </summary>
    [JsonPropertyName("orgList")]
    public List<ContactOrgAccountsOwnedOrganizationsGetResponseOrgListItem> OrgList { get; set; } = [];
}

/// <summary>
/// ContactOrgAccountsOwnedOrganizationsGetResponseOrgListItem
/// </summary>
public class ContactOrgAccountsOwnedOrganizationsGetResponseOrgListItem
{
    /// <summary>
    /// 组织的corpId。
    /// </summary>
    [JsonPropertyName("corpId")]
    public string? CorpId { get; set; }

    /// <summary>
    /// 组织名称。
    /// </summary>
    [JsonPropertyName("corpName")]
    public string? CorpName { get; set; }
}

/// <summary>
/// 企业帐号转交主管理员（创建者）请求
/// </summary>
public class ContactOrgAccountsMainAdministratorsChangeRequest
{
    /// <summary>
    /// 原企业账号userid，可通过以下四种方式获得： 根据手机号查询企业帐号用户 创建SSO企业帐号 创建钉钉自建企业帐号 邀请其他组织企业帐号加入
    /// </summary>
    [JsonPropertyName("sourceUserId")]
    public required string SourceUserId { get; set; }

    /// <summary>
    /// 接收专属账号userid，可通过以下四种方式获得： 根据手机号查询专属帐号用户 创建SSO专属帐号 创建钉钉自建专属帐号 邀请其他组织专属帐号加入
    /// </summary>
    [JsonPropertyName("targetUserId")]
    public required string TargetUserId { get; set; }

    /// <summary>
    /// 被转交的组织corpId。详情参见基础概念-CorpId。
    /// </summary>
    [JsonPropertyName("effectCorpId")]
    public required string EffectCorpId { get; set; }
}

/// <summary>
/// 企业帐号转交主管理员（创建者）响应
/// </summary>
public class ContactOrgAccountsMainAdministratorsChangeResponse
{
    /// <summary>
    /// 转接操作结果。
    /// </summary>
    [JsonPropertyName("result")]
    public bool Result { get; set; }
}
