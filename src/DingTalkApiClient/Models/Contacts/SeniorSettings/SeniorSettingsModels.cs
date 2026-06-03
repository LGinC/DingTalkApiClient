using System.Text.Json.Serialization;
namespace DingTalkApiClient.Models.Contacts.SeniorSettings;
#pragma warning disable CS8618
/// <summary>
/// 设置高管模式请求
/// </summary>
public class ContactSeniorSettingsRequest
{
    /// <summary>
    /// 需要设置的员工userid。
    /// </summary>
    [JsonPropertyName("seniorStaffId")]
    public required string SeniorStaffId { get; set; }

    /// <summary>
    /// 是否开启高管模式，取值：
    /// </summary>
    [JsonPropertyName("open")]
    public bool Open { get; set; }

    /// <summary>
    /// 高管白名单员工userid列表。 参数permitStaffIds、permitDeptIds、permitTagIds列表内元素之和最大为200。
    /// </summary>
    [JsonPropertyName("permitStaffIds")]
    public List<string> PermitStaffIds { get; set; } = [];

    /// <summary>
    /// 高管白名单部门列表。 参数permitStaffIds、permitDeptIds、permitTagIds列表内元素之和最大为200。
    /// </summary>
    [JsonPropertyName("permitDeptIds")]
    public List<string> PermitDeptIds { get; set; } = [];

    /// <summary>
    /// 高管白名单角色列表。 参数permitStaffIds、permitDeptIds、permitTagIds列表内元素之和最大为200。
    /// </summary>
    [JsonPropertyName("permitTagIds")]
    public List<string> PermitTagIds { get; set; } = [];

    /// <summary>
    /// 高管拦截场景，取值：
    /// </summary>
    [JsonPropertyName("protectScenes")]
    public List<string> ProtectScenes { get; set; } = [];
}

/// <summary>
/// 设置高管模式响应
/// </summary>
public class ContactSeniorSettingsResponse
{
}

/// <summary>
/// 获取用户高管模式设置请求
/// </summary>
public class ContactSeniorSettingsGetRequest
{
}

/// <summary>
/// 获取用户高管模式设置响应
/// </summary>
public class ContactSeniorSettingsGetResponse
{
    /// <summary>
    /// 用户userid。
    /// </summary>
    [JsonPropertyName("seniorStaffId")]
    public string? SeniorStaffId { get; set; }

    /// <summary>
    /// 拦截场景列表。
    /// </summary>
    [JsonPropertyName("protectScenes")]
    public List<string> ProtectScenes { get; set; } = [];

    /// <summary>
    /// 高管白名单列表。
    /// </summary>
    [JsonPropertyName("seniorWhiteList")]
    public List<ContactSeniorSettingsGetResponseSeniorWhiteListItem> SeniorWhiteList { get; set; } = [];
}

/// <summary>
/// ContactSeniorSettingsGetResponseSeniorWhiteListItem
/// </summary>
public class ContactSeniorSettingsGetResponseSeniorWhiteListItem
{
    /// <summary>
    /// Id
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// 白名单类型，取值：
    /// </summary>
    [JsonPropertyName("type")]
    public long? Type { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
