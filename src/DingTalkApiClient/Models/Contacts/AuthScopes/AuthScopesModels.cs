using System.Text.Json.Serialization;
namespace DingTalkApiClient.Models.Contacts.AuthScopes;
#pragma warning disable CS8618
/// <summary>
/// 获取通讯录权限范围请求
/// </summary>
public class AuthScopesGetRequest
{
}

/// <summary>
/// 获取通讯录权限范围响应
/// </summary>
public class AuthScopesGetResponse
{
    /// <summary>
    /// 授权信息。
    /// </summary>
    [JsonPropertyName("auth_org_scopes")]
    public AuthScopesGetResponseAuthOrgScopes AuthOrgScopes { get; set; }

    /// <summary>
    /// 授权可获取的企业用户字段。
    /// </summary>
    [JsonPropertyName("auth_user_field")]
    public List<string> AuthUserField { get; set; } = [];

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }
}

/// <summary>
/// 授权信息。
/// </summary>
public class AuthScopesGetResponseAuthOrgScopes
{
    /// <summary>
    /// 授权可获取通信录信息的员工userid列表。
    /// </summary>
    [JsonPropertyName("authed_user")]
    public List<string> AuthedUser { get; set; } = [];

    /// <summary>
    /// 授权可获取通信录信息的部门ID列表。
    /// </summary>
    [JsonPropertyName("authed_dept")]
    public List<decimal> AuthedDept { get; set; } = [];
}
