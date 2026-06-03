using System.Text.Json.Serialization;
namespace DingTalkApiClient.Models.Contacts.DepartmentManage;
#pragma warning disable CS8618
/// <summary>
/// 创建部门请求
/// </summary>
public class DepartmentCreateRequest
{
    /// <summary>
    /// 部门名称。长度限制为1~64个字符，不允许包含字符"-"","以及","。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 父部门ID，根部门ID为1。
    /// </summary>
    [JsonPropertyName("parent_id")]
    public decimal ParentId { get; set; }

    /// <summary>
    /// 是否隐藏本部门：true：隐藏部门，隐藏后本部门将不会显示在公司通讯录中false（默认值）：显示部门
    /// </summary>
    [JsonPropertyName("hide_dept")]
    public bool? HideDept { get; set; }

    /// <summary>
    /// 指定可以查看本部门的其他部门列表，总数不能超过200。当hide_dept为true时，则此值生效。
    /// </summary>
    [JsonPropertyName("dept_permits")]
    public string? DeptPermits { get; set; }

    /// <summary>
    /// 指定可以查看本部门的人员userid列表，总数不能超过200。当hide_dept为true时，则此值生效。
    /// </summary>
    [JsonPropertyName("user_permits")]
    public string? UserPermits { get; set; }

    /// <summary>
    /// 是否限制本部门成员查看通讯录：true：开启限制。开启后本部门成员只能看到限定范围内的通讯录false（默认值）：不限制
    /// </summary>
    [JsonPropertyName("outer_dept")]
    public bool? OuterDept { get; set; }

    /// <summary>
    /// 本部门成员是否只能看到所在部门及下级部门通讯录：true：只能看到所在部门及下级部门通讯录false：不能查看所有通讯录，在通讯录中仅能看到自己当outer_dept为true时，此参数生效。
    /// </summary>
    [JsonPropertyName("outer_dept_only_self")]
    public bool? OuterDeptOnlySelf { get; set; }

    /// <summary>
    /// 指定本部门成员可查看的通讯录用户userid列表，总数不能超过200。当outer_dept为true时，此参数生效。
    /// </summary>
    [JsonPropertyName("outer_permit_users")]
    public string? OuterPermitUsers { get; set; }

    /// <summary>
    /// 指定本部门成员可查看的通讯录部门ID列表，总数不能超过200。当outer_dept为true时，此参数生效。
    /// </summary>
    [JsonPropertyName("outer_permit_depts")]
    public string? OuterPermitDepts { get; set; }

    /// <summary>
    /// 是否创建一个关联此部门的企业群，默认为false即不创建。
    /// </summary>
    [JsonPropertyName("create_dept_group")]
    public bool? CreateDeptGroup { get; set; }

    /// <summary>
    /// 是否默认同意加入该部门的申请：true：表示加入该部门的申请将默认同意false：表示加入该部门的申请需要有权限的管理员同意
    /// </summary>
    [JsonPropertyName("auto_approve_apply")]
    public bool? AutoApproveApply { get; set; }

    /// <summary>
    /// 在父部门中的排序值，order值小的排序靠前。
    /// </summary>
    [JsonPropertyName("order")]
    public decimal? Order { get; set; }

    /// <summary>
    /// 部门标识字段，开发者可用该字段来唯一标识一个部门，并与钉钉外部通讯录里的部门做映射。
    /// </summary>
    [JsonPropertyName("source_identifier")]
    public string? SourceIdentifier { get; set; }
}

/// <summary>
/// 创建部门结果
/// </summary>
public class DepartmentCreateResult
{
    /// <summary>
    /// 部门ID。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public decimal? DeptId { get; set; }
}

/// <summary>
/// 更新部门请求
/// </summary>
public class DepartmentUpdateRequest
{
    /// <summary>
    /// 部门ID。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public decimal DeptId { get; set; }

    /// <summary>
    /// 父部门ID，根部ID为1。
    /// </summary>
    [JsonPropertyName("parent_id")]
    public decimal? ParentId { get; set; }

    /// <summary>
    /// 是否隐藏本部门：true：隐藏部门隐藏后本部门将不会显示在公司通讯录中。false：显示部门不传值，则保持不变。
    /// </summary>
    [JsonPropertyName("hide_dept")]
    public bool? HideDept { get; set; }

    /// <summary>
    /// 指定可以查看本部门的其他部门列表。当hide_dept为true时，则此值生效。该参数列表总数和user_permits列表总数之和不能超过50。
    /// </summary>
    [JsonPropertyName("dept_permits")]
    public string? DeptPermits { get; set; }

    /// <summary>
    /// 指定可以查看本部门的用户userid列表。当hide_dept为true时，则此值生效。该参数列表总数和dept_permits列表总数之和不能超过50。
    /// </summary>
    [JsonPropertyName("user_permits")]
    public string? UserPermits { get; set; }

    /// <summary>
    /// 是否创建一个关联此部门的企业群，默认为false即不创建。不传值，则保持不变。
    /// </summary>
    [JsonPropertyName("create_dept_group")]
    public bool? CreateDeptGroup { get; set; }

    /// <summary>
    /// 在父部门中的排序值，order值小的排序靠前。
    /// </summary>
    [JsonPropertyName("order")]
    public decimal? Order { get; set; }

    /// <summary>
    /// 部门名称，长度限制为1~64个字符，不允许包含字符‘-’‘，’以及‘,’。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 部门标识字段，开发者可用该字段来唯一标识一个部门，并与钉钉外部通讯录里的部门做映射。
    /// </summary>
    [JsonPropertyName("source_identifier")]
    public string? SourceIdentifier { get; set; }

    /// <summary>
    /// 是否限制本部门成员查看通讯录：true：开启限制。开启后本部门成员只能看到限定范围内的通讯录false：不限制不传值，则保持不变。
    /// </summary>
    [JsonPropertyName("outer_dept")]
    public bool? OuterDept { get; set; }

    /// <summary>
    /// 指定本部门成员可查看的通讯录用户userid列表。当outer_dept为true时，此参数生效。该参数列表总数和outer_permit_depts列表总数之和不能超过50。
    /// </summary>
    [JsonPropertyName("outer_permit_users")]
    public string? OuterPermitUsers { get; set; }

    /// <summary>
    /// 指定本部门成员可查看的通讯录部门ID列表。当outer_dept为true时，此参数生效。该参数列表总数和outer_permit_users列表总数之和不能超过50。
    /// </summary>
    [JsonPropertyName("outer_permit_depts")]
    public string? OuterPermitDepts { get; set; }

    /// <summary>
    /// 本部门成员是否只能看到所在部门及下级部门通讯录：true：只能看到所在部门及下级部门通讯录false：不能查看所有通讯录，在通讯录中仅能看到自己当outer_dept为true时，此参数生效。不传值，则保持不变。
    /// </summary>
    [JsonPropertyName("outer_dept_only_self")]
    public bool? OuterDeptOnlySelf { get; set; }

    /// <summary>
    /// 通讯录语言：zh_CN：中文en_US：英文
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>
    /// 当部门群已经创建后，有新人加入部门时是否会自动加入该群：true：自动加入群false：不会自动加入群不传值，则保持不变。
    /// </summary>
    [JsonPropertyName("auto_add_user")]
    public bool? AutoAddUser { get; set; }

    /// <summary>
    /// 是否默认同意加入该部门的申请：true：表示加入该部门的申请将默认同意false：表示加入该部门的申请需要有权限的管理员同意
    /// </summary>
    [JsonPropertyName("auto_approve_apply")]
    public bool? AutoApproveApply { get; set; }

    /// <summary>
    /// 部门的主管userid列表，多个userid之间使用英文逗号分隔。
    /// </summary>
    [JsonPropertyName("dept_manager_userid_list")]
    public string? DeptManagerUseridList { get; set; }

    /// <summary>
    /// 部门群是否包含子部门：true：包含false：不包含不传值，则保持不变。
    /// </summary>
    [JsonPropertyName("group_contain_sub_dept")]
    public bool? GroupContainSubDept { get; set; }

    /// <summary>
    /// 部门群是否包含外包部门：true：包含false：不包含不传值，则保持不变。
    /// </summary>
    [JsonPropertyName("group_contain_outer_dept")]
    public bool? GroupContainOuterDept { get; set; }

    /// <summary>
    /// 部门群是否包含隐藏部门：true：包含false：不包含不传值，则保持不变。
    /// </summary>
    [JsonPropertyName("group_contain_hidden_dept")]
    public bool? GroupContainHiddenDept { get; set; }

    /// <summary>
    /// 企业群群主的userid。
    /// </summary>
    [JsonPropertyName("org_dept_owner")]
    public string? OrgDeptOwner { get; set; }

    /// <summary>
    /// 强制更新的字段，支持清空指定的字段，多个字段之间使用英文逗号分隔。目前支持字段: dept_manager_userid_list。
    /// </summary>
    [JsonPropertyName("force_update_fields")]
    public string? ForceUpdateFields { get; set; }
}

/// <summary>
/// 删除部门请求
/// </summary>
public class DepartmentDeleteRequest
{
    /// <summary>
    /// 要删除的部门ID。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public decimal DeptId { get; set; }
}

/// <summary>
/// 获取部门详情请求
/// </summary>
public class DepartmentGetRequest
{
    /// <summary>
    /// 部门ID，根部门ID为1。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public decimal DeptId { get; set; }

    /// <summary>
    /// 通讯录语言：zh_CN（默认）：中文en_US：英文
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }
}

/// <summary>
/// 获取部门详情结果
/// </summary>
public class DepartmentGetResult
{
    /// <summary>
    /// 部门ID。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public decimal? DeptId { get; set; }

    /// <summary>
    /// 部门名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 父部门ID。
    /// </summary>
    [JsonPropertyName("parent_id")]
    public decimal? ParentId { get; set; }

    /// <summary>
    /// 部门标识字段。第三方企业应用不返回该参数。
    /// </summary>
    [JsonPropertyName("source_identifier")]
    public string? SourceIdentifier { get; set; }

    /// <summary>
    /// 是否同步创建一个关联此部门的企业群：true：创建false：不创建
    /// </summary>
    [JsonPropertyName("create_dept_group")]
    public bool? CreateDeptGroup { get; set; }

    /// <summary>
    /// 当部门群已经创建后，是否有新人加入部门会自动加入该群：true：自动加入群false：不会自动加入群
    /// </summary>
    [JsonPropertyName("auto_add_user")]
    public bool? AutoAddUser { get; set; }

    /// <summary>
    /// 是否默认同意加入该部门的申请：true：表示加入该部门的申请将默认同意false：表示加入该部门的申请需要有权限的管理员同意
    /// </summary>
    [JsonPropertyName("auto_approve_apply")]
    public bool? AutoApproveApply { get; set; }

    /// <summary>
    /// 部门是否来自关联组织：true：是false：不是第三方企业应用不返回该参数。
    /// </summary>
    [JsonPropertyName("from_union_org")]
    public bool? FromUnionOrg { get; set; }

    /// <summary>
    /// 教育部门标签：campus：校区period：学段grade：年级class：班级第三方企业应用不返回该参数。
    /// </summary>
    [JsonPropertyName("tags")]
    public string? Tags { get; set; }

    /// <summary>
    /// 在父部门中的次序值。
    /// </summary>
    [JsonPropertyName("order")]
    public decimal? Order { get; set; }

    /// <summary>
    /// 部门群ID。
    /// </summary>
    [JsonPropertyName("dept_group_chat_id")]
    public string? DeptGroupChatId { get; set; }

    /// <summary>
    /// 部门群是否包含子部门：true：包含false：不包含
    /// </summary>
    [JsonPropertyName("group_contain_sub_dept")]
    public bool? GroupContainSubDept { get; set; }

    /// <summary>
    /// 企业群群主ID。
    /// </summary>
    [JsonPropertyName("org_dept_owner")]
    public string? OrgDeptOwner { get; set; }

    /// <summary>
    /// 部门的主管列表。
    /// </summary>
    [JsonPropertyName("dept_manager_userid_list")]
    public List<string> DeptManagerUseridList { get; set; } = [];

    /// <summary>
    /// 是否限制本部门成员查看通讯录：true：开启限制。开启后本部门成员只能看到限定范围内的通讯录false：不限制
    /// </summary>
    [JsonPropertyName("outer_dept")]
    public bool? OuterDept { get; set; }

    /// <summary>
    /// 当限制部门成员的通讯录查看范围时（即outer_dept为true时），配置的部门员工可见部门列表。
    /// </summary>
    [JsonPropertyName("outer_permit_depts")]
    public List<decimal> OuterPermitDepts { get; set; } = [];

    /// <summary>
    /// 当限制部门成员的通讯录查看范围时（即outer_dept为true时），配置的部门员工可见员工列表。
    /// </summary>
    [JsonPropertyName("outer_permit_users")]
    public List<string> OuterPermitUsers { get; set; } = [];

    /// <summary>
    /// 是否隐藏本部门：true：隐藏部门，隐藏后本部门将不会显示在公司通讯录中false：显示部门
    /// </summary>
    [JsonPropertyName("hide_dept")]
    public bool? HideDept { get; set; }

    /// <summary>
    /// 当隐藏本部门时（即hide_dept为true时），配置的允许在通讯录中查看本部门的员工列表。
    /// </summary>
    [JsonPropertyName("user_permits")]
    public List<string> UserPermits { get; set; } = [];

    /// <summary>
    /// 当隐藏本部门时（即hide_dept为true时），配置的允许在通讯录中查看本部门的部门列表。
    /// </summary>
    [JsonPropertyName("dept_permits")]
    public List<decimal> DeptPermits { get; set; } = [];
}

/// <summary>
/// 获取部门列表请求
/// </summary>
public class DepartmentListSubRequest
{
    /// <summary>
    /// 父部门ID。如果不传，默认部门为根部门，根部门ID为1。只支持查询下一级子部门，不支持查询多级子部门。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public decimal? DeptId { get; set; }

    /// <summary>
    /// 通讯录语言：zh_CN（默认）：中文en_US：英文
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }
}

/// <summary>
/// 获取部门列表结果
/// </summary>
public class DepartmentListSubResult
{
}

/// <summary>
/// 获取子部门ID列表请求
/// </summary>
public class DepartmentListSubIdRequest
{
    /// <summary>
    /// 父部门ID，根部门传1。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public decimal DeptId { get; set; }
}

/// <summary>
/// 获取子部门ID列表结果
/// </summary>
public class DepartmentListSubIdResult
{
    /// <summary>
    /// 子部门列表。
    /// </summary>
    [JsonPropertyName("dept_id_list")]
    public List<decimal> DeptIdList { get; set; } = [];
}

/// <summary>
/// 获取指定部门的所有父部门列表请求
/// </summary>
public class DepartmentListParentByDeptRequest
{
    /// <summary>
    /// 要查询的部门的ID。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public decimal DeptId { get; set; }
}

/// <summary>
/// 获取指定部门的所有父部门列表结果
/// </summary>
public class DepartmentListParentByDeptResult
{
    /// <summary>
    /// 该部门的所有父部门ID列表。
    /// </summary>
    [JsonPropertyName("parent_id_list")]
    public List<decimal> ParentIdList { get; set; } = [];
}

/// <summary>
/// 获取指定用户的所有父部门列表请求
/// </summary>
public class DepartmentListParentByUserRequest
{
    /// <summary>
    /// 要查询的用户的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }
}

/// <summary>
/// 获取指定用户的所有父部门列表结果
/// </summary>
public class DepartmentListParentByUserResult
{
    /// <summary>
    /// 父部门列表集合。
    /// </summary>
    [JsonPropertyName("parent_list")]
    public List<DepartmentListParentByUserResultParentListItem> ParentList { get; set; } = [];
}

/// <summary>
/// DepartmentListParentByUserResultParentListItem
/// </summary>
public class DepartmentListParentByUserResultParentListItem
{
    /// <summary>
    /// 父部门列表。
    /// </summary>
    [JsonPropertyName("parent_dept_id_list")]
    public List<decimal> ParentDeptIdList { get; set; } = [];
}
