using System.Text.Json.Serialization;
namespace DingTalkApi.Models.Contacts.ContactUsers;
#pragma warning disable CS8618
/// <summary>
/// 获取用户通讯录个人信息请求
/// </summary>
public class ContactUsersUnionIdGetRequest
{
}

/// <summary>
/// 获取用户通讯录个人信息响应
/// </summary>
public class ContactUsersUnionIdGetResponse
{
    /// <summary>
    /// 用户的钉钉昵称。
    /// </summary>
    [JsonPropertyName("nick")]
    public string? Nick { get; set; }

    /// <summary>
    /// 头像URL。
    /// </summary>
    [JsonPropertyName("avatarUrl")]
    public string? AvatarUrl { get; set; }

    /// <summary>
    /// 用户的手机号。 如果要获取用户手机号，需要在开发者后台申请个人手机号信息权限，如下图。
    /// </summary>
    [JsonPropertyName("mobile")]
    public string? Mobile { get; set; }

    /// <summary>
    /// 用户的openId。
    /// </summary>
    [JsonPropertyName("openId")]
    public string? OpenId { get; set; }

    /// <summary>
    /// 用户的unionId。
    /// </summary>
    [JsonPropertyName("unionId")]
    public string? UnionId { get; set; }

    /// <summary>
    /// 用户的个人邮箱。
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// 手机号对应的国家号。
    /// </summary>
    [JsonPropertyName("stateCode")]
    public string? StateCode { get; set; }
}
