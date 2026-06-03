using System.Text.Json.Serialization;
namespace DingTalkApiClient.Models.Contacts.ExternalContacts;
#pragma warning disable CS8618
/// <summary>
/// 添加外部联系人请求
/// </summary>
public class ExternalContactCreateRequest
{
    /// <summary>
    /// 外部联系人信息。
    /// </summary>
    [JsonPropertyName("contact")]
    public ExternalContactCreateRequestContact Contact { get; set; }
}

/// <summary>
/// 外部联系人信息。
/// </summary>
public class ExternalContactCreateRequestContact
{
    /// <summary>
    /// 职位。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 标签列表，可调用获取外部联系人标签列表接口查询标签信息。参考企业如何自定义标签组添加自定义标签。
    /// </summary>
    [JsonPropertyName("label_ids")]
    public List<decimal> LabelIds { get; set; } = [];

    /// <summary>
    /// 共享给的部门ID，可调用获取子部门ID列表接口获取。
    /// </summary>
    [JsonPropertyName("share_dept_ids")]
    public List<decimal> ShareDeptIds { get; set; } = [];

    /// <summary>
    /// 地址。
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// 备注。
    /// </summary>
    [JsonPropertyName("remark")]
    public string? Remark { get; set; }

    /// <summary>
    /// 负责人的userId，可通过根据手机号获取userid接口获取userid。
    /// </summary>
    [JsonPropertyName("follower_user_id")]
    public required string FollowerUserId { get; set; }

    /// <summary>
    /// 外部联系人的姓名。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 手机号国家码。
    /// </summary>
    [JsonPropertyName("state_code")]
    public required string StateCode { get; set; }

    /// <summary>
    /// 外部联系人的企业名称。
    /// </summary>
    [JsonPropertyName("company_name")]
    public string? CompanyName { get; set; }

    /// <summary>
    /// 共享给的员工userid列表，可通过根据手机号获取userid接口获取userid。
    /// </summary>
    [JsonPropertyName("share_user_ids")]
    public List<string> ShareUserIds { get; set; } = [];

    /// <summary>
    /// 外部联系人的手机号。
    /// </summary>
    [JsonPropertyName("mobile")]
    public required string Mobile { get; set; }
}

/// <summary>
/// 添加外部联系人响应
/// </summary>
public class ExternalContactCreateResponse
{
    /// <summary>
    /// 外部联系人的userId。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 删除外部联系人请求
/// </summary>
public class ExternalContactDeleteRequest
{
    /// <summary>
    /// 要删除的外部联系人的userid。
    /// </summary>
    [JsonPropertyName("user_id")]
    public required string UserId { get; set; }
}

/// <summary>
/// 更新外部联系人请求
/// </summary>
public class ExternalContactUpdateRequest
{
    /// <summary>
    /// 外部联系人信息。
    /// </summary>
    [JsonPropertyName("contact")]
    public ExternalContactUpdateRequestContact Contact { get; set; }
}

/// <summary>
/// 外部联系人信息。
/// </summary>
public class ExternalContactUpdateRequestContact
{
    /// <summary>
    /// 职位。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 标签列表，可调用获取外部联系人标签列表接口查询标签信息。参考企业如何自定义标签组添加自定义标签。
    /// </summary>
    [JsonPropertyName("label_ids")]
    public List<decimal> LabelIds { get; set; } = [];

    /// <summary>
    /// 共享给的部门ID，可调用获取子部门ID列表接口获取。
    /// </summary>
    [JsonPropertyName("share_dept_ids")]
    public List<decimal> ShareDeptIds { get; set; } = [];

    /// <summary>
    /// 地址。
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// 备注。
    /// </summary>
    [JsonPropertyName("remark")]
    public string? Remark { get; set; }

    /// <summary>
    /// 负责人的userid。
    /// </summary>
    [JsonPropertyName("follower_user_id")]
    public required string FollowerUserId { get; set; }

    /// <summary>
    /// 外部联系人的姓名。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 该外部联系人的userid。
    /// </summary>
    [JsonPropertyName("user_id")]
    public required string UserId { get; set; }

    /// <summary>
    /// 外部联系人的企业名称。
    /// </summary>
    [JsonPropertyName("company_name")]
    public string? CompanyName { get; set; }

    /// <summary>
    /// 共享给的员工userid列表。
    /// </summary>
    [JsonPropertyName("share_user_ids")]
    public List<string> ShareUserIds { get; set; } = [];
}

/// <summary>
/// 获取外部联系人列表请求
/// </summary>
public class ExternalContactListRequest
{
    /// <summary>
    /// 支持分页查询，与offset参数同时设置时才生效，此参数代表分页大小，最大100。
    /// </summary>
    [JsonPropertyName("size")]
    public decimal? Size { get; set; }

    /// <summary>
    /// 支持分页查询，与size参数同时设置时才生效，此参数代表偏移量，偏移量从0开始。
    /// </summary>
    [JsonPropertyName("offset")]
    public decimal? Offset { get; set; }
}

/// <summary>
/// 获取外部联系人列表响应
/// </summary>
public class ExternalContactListResponse
{
    /// <summary>
    /// 查询结果。
    /// </summary>
    [JsonPropertyName("results")]
    public List<ExternalContactListResponseResultsItem> Results { get; set; } = [];

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// ExternalContactListResponseResultsItem
/// </summary>
public class ExternalContactListResponseResultsItem
{
    /// <summary>
    /// 职位。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 共享部门ID列表。
    /// </summary>
    [JsonPropertyName("share_dept_ids")]
    public List<decimal> ShareDeptIds { get; set; } = [];

    /// <summary>
    /// 标签，可调用获取外部联系人标签列表接口查询标签信息。
    /// </summary>
    [JsonPropertyName("label_ids")]
    public List<decimal> LabelIds { get; set; } = [];

    /// <summary>
    /// 备注。
    /// </summary>
    [JsonPropertyName("remark")]
    public string? Remark { get; set; }

    /// <summary>
    /// 地址。
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// 姓名。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 负责人的userid。
    /// </summary>
    [JsonPropertyName("follower_user_id")]
    public string? FollowerUserId { get; set; }

    /// <summary>
    /// 国家码。
    /// </summary>
    [JsonPropertyName("state_code")]
    public string? StateCode { get; set; }

    /// <summary>
    /// 公司名。
    /// </summary>
    [JsonPropertyName("company_name")]
    public string? CompanyName { get; set; }

    /// <summary>
    /// 共享员工userid列表。
    /// </summary>
    [JsonPropertyName("share_user_ids")]
    public List<string> ShareUserIds { get; set; } = [];

    /// <summary>
    /// 手机号。第三方企业应用不返回此参数。
    /// </summary>
    [JsonPropertyName("mobile")]
    public string? Mobile { get; set; }

    /// <summary>
    /// 外部联系人的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 邮箱。
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

/// <summary>
/// 获取外部联系人标签列表请求
/// </summary>
public class ExternalContactListlabelgroupsRequest
{
    /// <summary>
    /// 支持分页查询，与offset参数同时设置时才生效，此参数代表分页大小，最大100。
    /// </summary>
    [JsonPropertyName("size")]
    public decimal? Size { get; set; }

    /// <summary>
    /// 支持分页查询，与size参数同时设置时才生效，此参数代表偏移量，偏移量从0开始。
    /// </summary>
    [JsonPropertyName("offset")]
    public decimal? Offset { get; set; }
}

/// <summary>
/// 获取外部联系人标签列表响应
/// </summary>
public class ExternalContactListlabelgroupsResponse
{
    /// <summary>
    /// 查询结果。
    /// </summary>
    [JsonPropertyName("results")]
    public List<ExternalContactListlabelgroupsResponseResultsItem> Results { get; set; } = [];

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// ExternalContactListlabelgroupsResponseResultsItem
/// </summary>
public class ExternalContactListlabelgroupsResponseResultsItem
{
    /// <summary>
    /// 标签组名字。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 标签组颜色。
    /// </summary>
    [JsonPropertyName("color")]
    public decimal? Color { get; set; }

    /// <summary>
    /// 标签列表。
    /// </summary>
    [JsonPropertyName("labels")]
    public List<ExternalContactListlabelgroupsResponseResultsItemLabelsItem> Labels { get; set; } = [];
}

/// <summary>
/// ExternalContactListlabelgroupsResponseResultsItemLabelsItem
/// </summary>
public class ExternalContactListlabelgroupsResponseResultsItemLabelsItem
{
    /// <summary>
    /// 标签名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 标签ID。
    /// </summary>
    [JsonPropertyName("id")]
    public decimal? Id { get; set; }
}

/// <summary>
/// 获取外部联系人详情请求
/// </summary>
public class ExternalContactGetRequest
{
    /// <summary>
    /// 外部联系人的userId，可调用获取外部联系人列表接口获取。
    /// </summary>
    [JsonPropertyName("user_id")]
    public required string UserId { get; set; }
}

/// <summary>
/// 获取外部联系人详情结果
/// </summary>
public class ExternalContactGetResult
{
    /// <summary>
    /// 职位。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 共享部门ID列表。
    /// </summary>
    [JsonPropertyName("share_dept_ids")]
    public List<decimal> ShareDeptIds { get; set; } = [];

    /// <summary>
    /// 标签。
    /// </summary>
    [JsonPropertyName("label_ids")]
    public List<decimal> LabelIds { get; set; } = [];

    /// <summary>
    /// 备注。
    /// </summary>
    [JsonPropertyName("remark")]
    public string? Remark { get; set; }

    /// <summary>
    /// 地址。
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// 姓名。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 负责人的userId。
    /// </summary>
    [JsonPropertyName("follower_user_id")]
    public string? FollowerUserId { get; set; }

    /// <summary>
    /// 国家码。
    /// </summary>
    [JsonPropertyName("state_code")]
    public string? StateCode { get; set; }

    /// <summary>
    /// 公司名。
    /// </summary>
    [JsonPropertyName("company_name")]
    public string? CompanyName { get; set; }

    /// <summary>
    /// 共享员工userId列表。
    /// </summary>
    [JsonPropertyName("share_user_ids")]
    public List<string> ShareUserIds { get; set; } = [];

    /// <summary>
    /// 手机号。第三方企业应用不返回此参数。
    /// </summary>
    [JsonPropertyName("mobile")]
    public string? Mobile { get; set; }

    /// <summary>
    /// 外部联系人userId。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 邮箱。
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}
