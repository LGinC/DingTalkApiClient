using System.Text.Json.Serialization;
namespace DingTalkApi.Models.Contacts.StaffAttributes;
#pragma warning disable CS8618
/// <summary>
/// 删除用户属性可见性设置请求
/// </summary>
public class ContactStaffAttributesVisibilitySettingsSettingIdDeleteRequest
{
}

/// <summary>
/// 删除用户属性可见性设置响应
/// </summary>
public class ContactStaffAttributesVisibilitySettingsSettingIdDeleteResponse
{
    /// <summary>
    /// 是否删除成功，true表示成功。
    /// </summary>
    [JsonPropertyName("result")]
    public bool Result { get; set; }
}

/// <summary>
/// 获取用户属性可见性设置请求
/// </summary>
public class ContactStaffAttributesVisibilitySettingsGetRequest
{
}

/// <summary>
/// 获取用户属性可见性设置响应
/// </summary>
public class ContactStaffAttributesVisibilitySettingsGetResponse
{
    /// <summary>
    /// 是否还有更多数据。
    /// </summary>
    [JsonPropertyName("hasMore")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// 下一次拉取时的token。
    /// </summary>
    [JsonPropertyName("nextCursor")]
    public long? NextCursor { get; set; }

    /// <summary>
    /// 设置列表。
    /// </summary>
    [JsonPropertyName("list")]
    public List<ContactStaffAttributesVisibilitySettingsGetResponseListItem> List { get; set; } = [];
}

/// <summary>
/// ContactStaffAttributesVisibilitySettingsGetResponseListItem
/// </summary>
public class ContactStaffAttributesVisibilitySettingsGetResponseListItem
{
    /// <summary>
    /// 设置的ID。
    /// </summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>
    /// 设置创建的时间。
    /// </summary>
    [JsonPropertyName("gmtCreate")]
    public string? GmtCreate { get; set; }

    /// <summary>
    /// 设置最后修改的时间。
    /// </summary>
    [JsonPropertyName("gmtModified")]
    public string? GmtModified { get; set; }

    /// <summary>
    /// 设置的名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 设置的描述信息。
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// 需要隐藏的字段的用户userid列表。
    /// </summary>
    [JsonPropertyName("objectStaffIds")]
    public List<string> ObjectStaffIds { get; set; } = [];

    /// <summary>
    /// 需要隐藏的字段的部门ID列表。
    /// </summary>
    [JsonPropertyName("objectDeptIds")]
    public List<long> ObjectDeptIds { get; set; } = [];

    /// <summary>
    /// 需要隐藏的字段的角色ID列表。
    /// </summary>
    [JsonPropertyName("objectTagIds")]
    public List<long> ObjectTagIds { get; set; } = [];

    /// <summary>
    /// 隐藏的字段ID列表。
    /// </summary>
    [JsonPropertyName("hideFields")]
    public List<string> HideFields { get; set; } = [];

    /// <summary>
    /// 白名单用户userid列表。
    /// </summary>
    [JsonPropertyName("excludeStaffIds")]
    public List<string> ExcludeStaffIds { get; set; } = [];

    /// <summary>
    /// 白名单部门ID列表。
    /// </summary>
    [JsonPropertyName("excludeDeptIds")]
    public List<long> ExcludeDeptIds { get; set; } = [];

    /// <summary>
    /// 白名单角色ID列表。
    /// </summary>
    [JsonPropertyName("excludeTagIds")]
    public List<long> ExcludeTagIds { get; set; } = [];

    /// <summary>
    /// 是否生效。
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }
}

/// <summary>
/// 设置用户属性可见性请求
/// </summary>
public class ContactStaffAttributesVisibilitySettingsRequest
{
    /// <summary>
    /// 更新的时候需要指定ID，新增的时候不需要指定。
    /// </summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>
    /// 设置的名称，非必填。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 设置的描述信息，非必填。
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// 需要隐藏字段的员工userid列表。
    /// </summary>
    [JsonPropertyName("objectStaffIds")]
    public List<string> ObjectStaffIds { get; set; } = [];

    /// <summary>
    /// 需要隐藏字段的部门ID列表。
    /// </summary>
    [JsonPropertyName("objectDeptIds")]
    public List<string> ObjectDeptIds { get; set; } = [];

    /// <summary>
    /// 需要隐藏字段的角色ID列表。
    /// </summary>
    [JsonPropertyName("objectTagIds")]
    public List<string> ObjectTagIds { get; set; } = [];

    /// <summary>
    /// 隐藏的字段ID列表。
    /// </summary>
    [JsonPropertyName("hideFields")]
    public List<string> HideFields { get; set; } = [];

    /// <summary>
    /// 可见隐藏字段的员工userid列表。
    /// </summary>
    [JsonPropertyName("excludeStaffIds")]
    public List<string> ExcludeStaffIds { get; set; } = [];

    /// <summary>
    /// 可见隐藏字段的部门ID列表。
    /// </summary>
    [JsonPropertyName("excludeDeptIds")]
    public List<string> ExcludeDeptIds { get; set; } = [];

    /// <summary>
    /// 可见隐藏字段的角色ID列表。
    /// </summary>
    [JsonPropertyName("excludeTagIds")]
    public List<string> ExcludeTagIds { get; set; } = [];

    /// <summary>
    /// 是否生效。
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }
}

/// <summary>
/// 设置用户属性可见性响应
/// </summary>
public class ContactStaffAttributesVisibilitySettingsResponse
{
    /// <summary>
    /// 设置的ID。
    /// </summary>
    [JsonPropertyName("result")]
    public long? Result { get; set; }
}
