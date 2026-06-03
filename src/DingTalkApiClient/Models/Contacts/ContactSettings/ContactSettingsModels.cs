using System.Text.Json.Serialization;
namespace DingTalkApiClient.Models.Contacts.ContactSettings;
#pragma warning disable CS8618
/// <summary>
/// 获取企业邀请信息请求
/// </summary>
public class ContactInvitesInfosGetRequest
{
}

/// <summary>
/// 获取企业邀请信息响应
/// </summary>
public class ContactInvitesInfosGetResponse
{
    /// <summary>
    /// 是否开启邀请。
    /// </summary>
    [JsonPropertyName("inviteSwitch")]
    public bool? InviteSwitch { get; set; }

    /// <summary>
    /// 是否开启通过企业名称搜索申请。
    /// </summary>
    [JsonPropertyName("searchNameInvite")]
    public bool? SearchNameInvite { get; set; }

    /// <summary>
    /// 是否开启通过团队号申请加入。
    /// </summary>
    [JsonPropertyName("orgApplyCodeInvite")]
    public bool? OrgApplyCodeInvite { get; set; }

    /// <summary>
    /// 是否开启通过链接邀请加入。
    /// </summary>
    [JsonPropertyName("linkInvite")]
    public bool? LinkInvite { get; set; }

    /// <summary>
    /// 邀请链接。
    /// </summary>
    [JsonPropertyName("inviteUrl")]
    public string? InviteUrl { get; set; }

    /// <summary>
    /// 审核类型。 仅部门邀请有效。
    /// </summary>
    [JsonPropertyName("auditType")]
    public long? AuditType { get; set; }

    /// <summary>
    /// 是否允许员工扫码加入部门。 仅在无需审核的时候有效，已经在组织内的成员通过扫描部门二维码加入某个部门。
    /// </summary>
    [JsonPropertyName("empApplyJoinDept")]
    public bool? EmpApplyJoinDept { get; set; }
}

/// <summary>
/// 获取企业最新钉钉指数信息请求
/// </summary>
public class ContactDingIndexsGetRequest
{
}

/// <summary>
/// 获取企业最新钉钉指数信息响应
/// </summary>
public class ContactDingIndexsGetResponse
{
    /// <summary>
    /// 日期。
    /// </summary>
    [JsonPropertyName("statDate")]
    public string? StatDate { get; set; }

    /// <summary>
    /// 钉钉指数。
    /// </summary>
    [JsonPropertyName("idxTotal")]
    public Dictionary<string, object?> IdxTotal { get; set; } = [];

    /// <summary>
    /// 效率指数。
    /// </summary>
    [JsonPropertyName("idxEfficiency")]
    public Dictionary<string, object?> IdxEfficiency { get; set; } = [];

    /// <summary>
    /// 绿色指数。
    /// </summary>
    [JsonPropertyName("idxCarbon")]
    public Dictionary<string, object?> IdxCarbon { get; set; } = [];

    /// <summary>
    /// 钉钉指数月均分。
    /// </summary>
    [JsonPropertyName("idxMonthlyAvg")]
    public Dictionary<string, object?> IdxMonthlyAvg { get; set; } = [];
}

/// <summary>
/// 获取企业认证信息响应
/// </summary>
public class ContactOrganizationsAuthInfosGetResponse
{
    /// <summary>
    /// 企业在钉钉通讯录的名称。
    /// </summary>
    [JsonPropertyName("orgName")]
    public required string OrgName { get; set; }

    /// <summary>
    /// 提交企业认证时营业执照上面的企业名称。
    /// </summary>
    [JsonPropertyName("licenseOrgName")]
    public required string LicenseOrgName { get; set; }

    /// <summary>
    /// 营业执照注册号（一般15位）。
    /// </summary>
    [JsonPropertyName("registrationNum")]
    public required string RegistrationNum { get; set; }

    /// <summary>
    /// 社会统一信用代码（固定18位）。
    /// </summary>
    [JsonPropertyName("unifiedSocialCredit")]
    public required string UnifiedSocialCredit { get; set; }

    /// <summary>
    /// 组织机构代码证号（格式11111111-1）。
    /// </summary>
    [JsonPropertyName("organizationCode")]
    public required string OrganizationCode { get; set; }

    /// <summary>
    /// 法人。
    /// </summary>
    [JsonPropertyName("legalPerson")]
    public required string LegalPerson { get; set; }

    /// <summary>
    /// 营业执照url。
    /// </summary>
    [JsonPropertyName("licenseUrl")]
    public required string LicenseUrl { get; set; }

    /// <summary>
    /// 认证等级，取值： 1：高级认证 2：中级认证
    /// </summary>
    [JsonPropertyName("authLevel")]
    public long AuthLevel { get; set; }
}

/// <summary>
/// 新增或更新通讯录隐藏设置请求
/// </summary>
public class ContactContactHideSettingsPutRequest
{
    /// <summary>
    /// 设置名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 设置描述信息。
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// 需要被隐藏的员工userId列表，可通过通过免登码获取用户信息获得userId参数值。 说明 objectStaffIds、objectDeptIds、objectTagIds三个参数内元素个数之和不能超过50。
    /// </summary>
    [JsonPropertyName("objectStaffIds")]
    public List<string> ObjectStaffIds { get; set; } = [];

    /// <summary>
    /// 需要被隐藏的部门ID列表，可通过获取部门列表接口获得dept_id参数值。 说明 objectStaffIds、objectDeptIds、objectTagIds三个参数内元素个数之和不能超过50。
    /// </summary>
    [JsonPropertyName("objectDeptIds")]
    public List<string> ObjectDeptIds { get; set; } = [];

    /// <summary>
    /// 需要被隐藏的角色roleId列表，可通过获取角色列表接口获得id参数值。 说明 objectStaffIds、objectDeptIds、objectTagIds三个参数内元素个数之和不能超过50。
    /// </summary>
    [JsonPropertyName("objectTagIds")]
    public List<string> ObjectTagIds { get; set; } = [];

    /// <summary>
    /// 不受本次隐藏设置影响的员工userId列表，可通过通过免登码获取用户信息获得userId参数值。 说明 excludeStaffIds、excludeDeptIds、excludeTagIds三个参数内元素个数之和不能超过50。
    /// </summary>
    [JsonPropertyName("excludeStaffIds")]
    public List<string> ExcludeStaffIds { get; set; } = [];

    /// <summary>
    /// 不受本次隐藏设置影响的部门ID列表，可通过获取部门列表接口获得dept_id参数值。 说明 excludeStaffIds、excludeDeptIds、excludeTagIds三个参数内元素个数之和不能超过50。
    /// </summary>
    [JsonPropertyName("excludeDeptIds")]
    public List<string> ExcludeDeptIds { get; set; } = [];

    /// <summary>
    /// 不受本次隐藏设置影响的角色ID列表，可通过获取角色列表接口获得id参数值。 说明 excludeStaffIds、excludeDeptIds、excludeTagIds三个参数内元素个数之和不能超过50。
    /// </summary>
    [JsonPropertyName("excludeTagIds")]
    public List<string> ExcludeTagIds { get; set; } = [];
}

/// <summary>
/// 新增或更新通讯录隐藏设置响应
/// </summary>
public class ContactContactHideSettingsPutResponse
{
    /// <summary>
    /// 设置ID。
    /// </summary>
    [JsonPropertyName("result")]
    public long Result { get; set; }
}

/// <summary>
/// 获取通讯录隐藏设置响应
/// </summary>
public class ContactContactHideSettingsGetResponse
{
    /// <summary>
    /// 是否还有更多数据。 true：是 false：否
    /// </summary>
    [JsonPropertyName("hasMore")]
    public bool HasMore { get; set; }

    /// <summary>
    /// 下一页的游标，为空字符串则表示分页结束。
    /// </summary>
    [JsonPropertyName("nextToken")]
    public long NextToken { get; set; }

    /// <summary>
    /// 通讯录隐藏的设置列表。
    /// </summary>
    [JsonPropertyName("list")]
    public List<ContactContactHideSettingsGetResponseListItem> List { get; set; } = [];
}

/// <summary>
/// ContactContactHideSettingsGetResponseListItem
/// </summary>
public class ContactContactHideSettingsGetResponseListItem
{
    /// <summary>
    /// 设置名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 设置描述。
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// 要隐藏的员工userId列表。
    /// </summary>
    [JsonPropertyName("objectStaffIds")]
    public List<string> ObjectStaffIds { get; set; } = [];

    /// <summary>
    /// 要隐藏的部门ID列表。
    /// </summary>
    [JsonPropertyName("objectDeptIds")]
    public List<long> ObjectDeptIds { get; set; } = [];

    /// <summary>
    /// 要影藏的角色Id列表。
    /// </summary>
    [JsonPropertyName("objectTagIds")]
    public List<long> ObjectTagIds { get; set; } = [];

    /// <summary>
    /// 不受本次隐藏设置影响的用户userId列表。
    /// </summary>
    [JsonPropertyName("excludeStaffIds")]
    public List<string> ExcludeStaffIds { get; set; } = [];

    /// <summary>
    /// 不受本次隐藏影响的部门ID列表。
    /// </summary>
    [JsonPropertyName("excludeDeptIds")]
    public List<long> ExcludeDeptIds { get; set; } = [];

    /// <summary>
    /// 不受本次隐藏设置影响的角色Id列表。
    /// </summary>
    [JsonPropertyName("excludeTagIds")]
    public List<long> ExcludeTagIds { get; set; } = [];

    /// <summary>
    /// 规则是否生效。 true：生效 false：不生效
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// 设置ID。
    /// </summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }
}

/// <summary>
/// 删除通讯录隐藏设置响应
/// </summary>
public class ContactContactHideSettingsSettingIdDeleteResponse
{
    /// <summary>
    /// 删除操作结果。
    /// </summary>
    [JsonPropertyName("result")]
    public bool Result { get; set; }
}

/// <summary>
/// 设置部门可见性优先级请求
/// </summary>
public class ContactDeptsSettingsPrioritiesRequest
{
    /// <summary>
    /// 是否开启子部门设置优先，取值： true: 子部门设置优先于父部门 false(默认值): 父部门设置优先于子部门
    /// </summary>
    [JsonPropertyName("enable")]
    public bool Enable { get; set; }
}

/// <summary>
/// 设置部门可见性优先级响应
/// </summary>
public class ContactDeptsSettingsPrioritiesResponse
{
    /// <summary>
    /// 更新操作结果。
    /// </summary>
    [JsonPropertyName("result")]
    public bool Result { get; set; }
}

/// <summary>
/// 新增或修改限制查看通讯录设置请求
/// </summary>
public class ContactRestrictionsSettingsPutRequest
{
    /// <summary>
    /// 设置名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 设置描述。
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// 需要限制查看通讯录的用户userId列表，可调用获取部门用户userId接口获取userId。 说明 subjectUserIds、subjectDeptIds、subjectTagIds三个参数内元素个数之和不能超过50。
    /// </summary>
    [JsonPropertyName("subjectUserIds")]
    public List<string> SubjectUserIds { get; set; } = [];

    /// <summary>
    /// 需要限制查看通讯录的部门ID列表，可调用获取部门列表接口获取dept_id。 说明 subjectUserIds、subjectDeptIds、subjectTagIds三个参数内元素个数之和不能超过50。
    /// </summary>
    [JsonPropertyName("subjectDeptIds")]
    public List<string> SubjectDeptIds { get; set; } = [];

    /// <summary>
    /// 需要限制查看通讯录的角色ID，通过调用获取角色列表接口获取。 说明 subjectUserIds、subjectDeptIds、subjectTagIds三个参数内元素个数之和不能超过50。
    /// </summary>
    [JsonPropertyName("subjectTagIds")]
    public List<string> SubjectTagIds { get; set; } = [];

    /// <summary>
    /// 限制类型，有以下取值： onlySelf：只能查看自己，不能看自己之外的其他部门和人。 onlySelfDeptAndChild：只能看到自己所在的部门及子部门，不能看到其他部门和人。 excludeNode：默认值，只能看到白名单列表中的部门和人。 说明 当该参数值为excludeNode时，设置的白名单才生效。
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// 白名单用户userId，可调用获取部门用户userId接口获取userId。 说明 excludeUserIds、excludeDeptIds、excludeTagIds三个参数内元素个数之和不能超过50。 当type参数值为excludeNode时，设置的白名单才生效。
    /// </summary>
    [JsonPropertyName("excludeUserIds")]
    public List<string> ExcludeUserIds { get; set; } = [];

    /// <summary>
    /// 白名单部门ID，通过调用获取部门列表接口获取。 说明 excludeUserIds、excludeDeptIds、excludeTagIds三个参数内元素之和不能超过50。 当type参数值为excludeNode时，设置的白名单才生效。
    /// </summary>
    [JsonPropertyName("excludeDeptIds")]
    public List<string> ExcludeDeptIds { get; set; } = [];

    /// <summary>
    /// 白名单角色ID，通过调用获取角色列表接口获取。 说明 excludeUserIds、excludeDeptIds、excludeTagIds三个参数内元素个数之和不能超过50。 当type参数值为excludeNode时，设置的白名单才生效。
    /// </summary>
    [JsonPropertyName("excludeTagIds")]
    public List<string> ExcludeTagIds { get; set; } = [];
}

/// <summary>
/// 新增或修改限制查看通讯录设置响应
/// </summary>
public class ContactRestrictionsSettingsPutResponse
{
    /// <summary>
    /// 限制设置ID。
    /// </summary>
    [JsonPropertyName("result")]
    public long Result { get; set; }
}

/// <summary>
/// 获取限制查看通讯录设置列表响应
/// </summary>
public class ContactRestrictionsSettingsGetResponse
{
    /// <summary>
    /// 是否还有更多数据。 true：是 false：否
    /// </summary>
    [JsonPropertyName("hasMore")]
    public bool HasMore { get; set; }

    /// <summary>
    /// 分页游标。
    /// </summary>
    [JsonPropertyName("nextToken")]
    public long NextToken { get; set; }

    /// <summary>
    /// 限制查看通讯录设置列表。
    /// </summary>
    [JsonPropertyName("list")]
    public List<ContactRestrictionsSettingsGetResponseListItem> List { get; set; } = [];
}

/// <summary>
/// ContactRestrictionsSettingsGetResponseListItem
/// </summary>
public class ContactRestrictionsSettingsGetResponseListItem
{
    /// <summary>
    /// 设置Id。
    /// </summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>
    /// 限制查看通讯录设置名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 限制查看通讯录描述。
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// 限制查看通讯录的用户userId列表。
    /// </summary>
    [JsonPropertyName("subjectUserIds")]
    public List<string> SubjectUserIds { get; set; } = [];

    /// <summary>
    /// 限制查看通讯录的部门deptId列表。
    /// </summary>
    [JsonPropertyName("subjectDeptIds")]
    public List<long> SubjectDeptIds { get; set; } = [];

    /// <summary>
    /// 限制查看通讯录的角色roleId。
    /// </summary>
    [JsonPropertyName("subjectTagIds")]
    public List<long> SubjectTagIds { get; set; } = [];

    /// <summary>
    /// 限制类型。 excludeNode: 只能看到白名单里的用户和部门。 onlySelf: 只能看到自己。 onlySelfDeptAndChild: 只能看到自己所在部门及子部门。
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// 白名单内用户userId列表。
    /// </summary>
    [JsonPropertyName("excludeUserIds")]
    public List<string> ExcludeUserIds { get; set; } = [];

    /// <summary>
    /// 白名单内的部门deptId列表。
    /// </summary>
    [JsonPropertyName("excludeDeptIds")]
    public List<long> ExcludeDeptIds { get; set; } = [];

    /// <summary>
    /// 白名单内角色roleId列表。
    /// </summary>
    [JsonPropertyName("excludeTagIds")]
    public List<long> ExcludeTagIds { get; set; } = [];

    /// <summary>
    /// 是否生效。 true：生效 false：不生效。
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>
    /// 是否同时限制查看个人资料页。 true：是 false：否
    /// </summary>
    [JsonPropertyName("restrictInUserProfile")]
    public bool? RestrictInUserProfile { get; set; }

    /// <summary>
    /// 是否同时限制搜索。 true：是 false：否
    /// </summary>
    [JsonPropertyName("restrictInSearch")]
    public bool? RestrictInSearch { get; set; }
}

/// <summary>
/// 删除限制查看通讯录设置响应
/// </summary>
public class ContactRestrictionsSettingsSettingIdGetResponse
{
    /// <summary>
    /// 请求是否成功。 true：成功 false：失败
    /// </summary>
    [JsonPropertyName("result")]
    public bool Result { get; set; }
}
