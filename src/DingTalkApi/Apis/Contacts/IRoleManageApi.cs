using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.Contacts.RoleManage;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.Contacts;

/// <summary>
/// 角色管理api
/// </summary>
public interface IRoleManageApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 创建角色
    /// </summary>
    [HttpPost("/role/add_role")]
    ITask<RoleAddRoleResponse> RoleAddRoleAsync([JsonContent] RoleAddRoleRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建角色组
    /// </summary>
    [HttpPost("/role/add_role_group")]
    ITask<RoleAddRoleGroupResponse> RoleAddRoleGroupAsync([JsonContent] RoleAddRoleGroupRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新角色名称
    /// </summary>
    [HttpPost("/role/update_role")]
    ITask<DingTalkResult> RoleUpdateRoleAsync([JsonContent] RoleUpdateRoleRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量增加员工角色
    /// </summary>
    [HttpPost("/topapi/role/addrolesforemps")]
    ITask<DingTalkResult> RoleAddRolesForEmpsAsync([JsonContent] RoleAddRolesForEmpsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除角色
    /// </summary>
    [HttpPost("/topapi/role/deleterole")]
    ITask<RoleDeleteRoleResponse> RoleDeleteRoleAsync([JsonContent] RoleDeleteRoleRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量删除员工角色
    /// </summary>
    [HttpPost("/topapi/role/removerolesforemps")]
    ITask<DingTalkResult> RoleRemoveRolesForEmpsAsync([JsonContent] RoleRemoveRolesForEmpsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 设定角色成员管理范围
    /// </summary>
    [HttpPost("/topapi/role/scope/update")]
    ITask<DingTalkResult> RoleScopeUpdateAsync([JsonContent] RoleScopeUpdateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取角色组列表
    /// </summary>
    [HttpPost("/topapi/role/getrolegroup")]
    ITask<RoleGetRoleGroupResponse> RoleGetRoleGroupAsync([JsonContent] RoleGetRoleGroupRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取角色列表
    /// </summary>
    [HttpPost("/topapi/role/list")]
    ITask<DingTalkResult<RoleListResult>> RoleListAsync([JsonContent] RoleListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取角色详情
    /// </summary>
    [HttpPost("/topapi/role/getrole")]
    ITask<RoleGetRoleResponse> RoleGetRoleAsync([JsonContent] RoleGetRoleRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取指定角色的员工列表
    /// </summary>
    [HttpPost("/topapi/role/simplelist")]
    ITask<DingTalkResult<RoleSimpleListResult>> RoleSimpleListAsync([JsonContent] RoleSimpleListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
