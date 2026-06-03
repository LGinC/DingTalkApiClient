using System.Text.Json.Serialization;
namespace DingTalkApi.Models.Contacts.RoleManage;
#pragma warning disable CS8618
/// <summary>
/// 创建角色请求
/// </summary>
public class RoleAddRoleRequest
{
    /// <summary>
    /// 角色名称。
    /// </summary>
    [JsonPropertyName("roleName")]
    public required string RoleName { get; set; }

    /// <summary>
    /// 角色组ID。如果要加入的角色组已存在，调用获取角色列表接口获取。如果尚未创建角色组，先调用创建角色组接口创建角色组，并获取角色组ID。
    /// </summary>
    [JsonPropertyName("groupId")]
    public decimal GroupId { get; set; }
}

/// <summary>
/// 创建角色响应
/// </summary>
public class RoleAddRoleResponse
{
    /// <summary>
    /// 角色ID。
    /// </summary>
    [JsonPropertyName("roleId")]
    public decimal? RoleId { get; set; }

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
}

/// <summary>
/// 创建角色组请求
/// </summary>
public class RoleAddRoleGroupRequest
{
    /// <summary>
    /// 角色组名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// 创建角色组响应
/// </summary>
public class RoleAddRoleGroupResponse
{
    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码ID。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 创建的角色组ID。
    /// </summary>
    [JsonPropertyName("groupId")]
    public decimal? GroupId { get; set; }
}

/// <summary>
/// 更新角色名称请求
/// </summary>
public class RoleUpdateRoleRequest
{
    /// <summary>
    /// 要更新的角色ID。“默认”分组内的角色不支持修改，包括：负责人、主管、主管理员、子管理员。
    /// </summary>
    [JsonPropertyName("roleId")]
    public decimal RoleId { get; set; }

    /// <summary>
    /// 修改的角色名称。
    /// </summary>
    [JsonPropertyName("roleName")]
    public required string RoleName { get; set; }
}

/// <summary>
/// 批量增加员工角色请求
/// </summary>
public class RoleAddRolesForEmpsRequest
{
    /// <summary>
    /// 角色roleId列表，可调用获取角色列表接口获取。多个roleId用英文逗号（,）分隔，最多可传20个。
    /// </summary>
    [JsonPropertyName("roleIds")]
    public required string RoleIds { get; set; }

    /// <summary>
    /// 员工的userId，可通过调用根据手机号获取userid获取。多个userId用英文逗号（,）分隔，最多可传20个。
    /// </summary>
    [JsonPropertyName("userIds")]
    public required string UserIds { get; set; }
}

/// <summary>
/// 删除角色请求
/// </summary>
public class RoleDeleteRoleRequest
{
    /// <summary>
    /// 要删除的角色ID。“默认”分组内的角色不支持修改，包括：负责人、主管、主管理员、子管理员
    /// </summary>
    [JsonPropertyName("role_id")]
    public decimal RoleId { get; set; }
}

/// <summary>
/// 删除角色响应
/// </summary>
public class RoleDeleteRoleResponse
{
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
    [JsonPropertyName("")]
    public string? Value { get; set; }
}

/// <summary>
/// 批量删除员工角色请求
/// </summary>
public class RoleRemoveRolesForEmpsRequest
{
    /// <summary>
    /// 角色roleId列表，可调用获取角色列表接口获取。最大列表长度为20，多个roleId用英文逗号（,）分隔。
    /// </summary>
    [JsonPropertyName("roleIds")]
    public required string RoleIds { get; set; }

    /// <summary>
    /// 员工的userid，可通过调用根据手机号获取userid获取userId。最大列表长度为100，多个userId用英文逗号（,）分隔。
    /// </summary>
    [JsonPropertyName("userIds")]
    public required string UserIds { get; set; }
}

/// <summary>
/// 设定角色成员管理范围请求
/// </summary>
public class RoleScopeUpdateRequest
{
    /// <summary>
    /// 员工在企业中的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }

    /// <summary>
    /// 角色ID。
    /// </summary>
    [JsonPropertyName("role_id")]
    public decimal RoleId { get; set; }

    /// <summary>
    /// 部门ID列表数，多个部门id之间使用逗号分隔。最多50个，不传则设置范围为所有人。
    /// </summary>
    [JsonPropertyName("dept_ids")]
    public string? DeptIds { get; set; }
}

/// <summary>
/// 获取角色组列表请求
/// </summary>
public class RoleGetRoleGroupRequest
{
    /// <summary>
    /// 角色组的ID。
    /// </summary>
    [JsonPropertyName("group_id")]
    public decimal GroupId { get; set; }
}

/// <summary>
/// 获取角色组列表响应
/// </summary>
public class RoleGetRoleGroupResponse
{
    /// <summary>
    /// 角色组信息。
    /// </summary>
    [JsonPropertyName("role_group")]
    public RoleGetRoleGroupResponseRoleGroup RoleGroup { get; set; }

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
/// 角色组信息。
/// </summary>
public class RoleGetRoleGroupResponseRoleGroup
{
    /// <summary>
    /// 角色列表信息。
    /// </summary>
    [JsonPropertyName("roles")]
    public List<RoleGetRoleGroupResponseRoleGroupRolesItem> Roles { get; set; } = [];

    /// <summary>
    /// 角色组名。
    /// </summary>
    [JsonPropertyName("group_name")]
    public string? GroupName { get; set; }
}

/// <summary>
/// RoleGetRoleGroupResponseRoleGroupRolesItem
/// </summary>
public class RoleGetRoleGroupResponseRoleGroupRolesItem
{
    /// <summary>
    /// 角色ID。
    /// </summary>
    [JsonPropertyName("role_id")]
    public decimal? RoleId { get; set; }

    /// <summary>
    /// 角色名。
    /// </summary>
    [JsonPropertyName("role_name")]
    public string? RoleName { get; set; }
}

/// <summary>
/// 获取角色列表请求
/// </summary>
public class RoleListRequest
{
    /// <summary>
    /// 支持分页查询，与offset参数同时设置时才生效，此参数代表分页大小，默认值20，最大值200。
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
/// 获取角色列表结果
/// </summary>
public class RoleListResult
{
    /// <summary>
    /// 是否还有更多数据。
    /// </summary>
    [JsonPropertyName("hasMore")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// 角色组列表。
    /// </summary>
    [JsonPropertyName("list")]
    public List<RoleListResultListItem> List { get; set; } = [];
}

/// <summary>
/// RoleListResultListItem
/// </summary>
public class RoleListResultListItem
{
    /// <summary>
    /// 角色组名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 角色组ID。
    /// </summary>
    [JsonPropertyName("groupId")]
    public decimal? GroupId { get; set; }

    /// <summary>
    /// 角色列表。
    /// </summary>
    [JsonPropertyName("roles")]
    public List<RoleListResultListItemRolesItem> Roles { get; set; } = [];
}

/// <summary>
/// RoleListResultListItemRolesItem
/// </summary>
public class RoleListResultListItemRolesItem
{
    /// <summary>
    /// 角色名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 角色ID。
    /// </summary>
    [JsonPropertyName("id")]
    public decimal? Id { get; set; }
}

/// <summary>
/// 获取角色详情请求
/// </summary>
public class RoleGetRoleRequest
{
    /// <summary>
    /// 角色ID。
    /// </summary>
    [JsonPropertyName("roleId")]
    public decimal RoleId { get; set; }
}

/// <summary>
/// 获取角色详情响应
/// </summary>
public class RoleGetRoleResponse
{
    /// <summary>
    /// 角色信息。
    /// </summary>
    [JsonPropertyName("role")]
    public RoleGetRoleResponseRole Role { get; set; }

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
/// 角色信息。
/// </summary>
public class RoleGetRoleResponseRole
{
    /// <summary>
    /// 角色名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 所属的角色组ID。
    /// </summary>
    [JsonPropertyName("groupId")]
    public decimal? GroupId { get; set; }
}

/// <summary>
/// 获取指定角色的员工列表请求
/// </summary>
public class RoleSimpleListRequest
{
    /// <summary>
    /// 角色ID。
    /// </summary>
    [JsonPropertyName("role_id")]
    public decimal RoleId { get; set; }

    /// <summary>
    /// 支持分页查询，与offset参数同时设置时才生效，此参数代表分页大小，默认值20，最大100。
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
/// 获取指定角色的员工列表结果
/// </summary>
public class RoleSimpleListResult
{
    /// <summary>
    /// 是否还有更多数据。
    /// </summary>
    [JsonPropertyName("hasMore")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// 下一次请求的索引。
    /// </summary>
    [JsonPropertyName("nextCursor")]
    public decimal? NextCursor { get; set; }

    /// <summary>
    /// 角色下的员工列表。
    /// </summary>
    [JsonPropertyName("list")]
    public List<RoleSimpleListResultListItem> List { get; set; } = [];
}

/// <summary>
/// RoleSimpleListResultListItem
/// </summary>
public class RoleSimpleListResultListItem
{
    /// <summary>
    /// 员工的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 员工姓名。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 管理范围。
    /// </summary>
    [JsonPropertyName("manageScopes")]
    public List<RoleSimpleListResultListItemManageScopesItem> ManageScopes { get; set; } = [];
}

/// <summary>
/// RoleSimpleListResultListItemManageScopesItem
/// </summary>
public class RoleSimpleListResultListItemManageScopesItem
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
}
