using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.Contacts.UserManage;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.Contacts;

/// <summary>
/// 用户管理api
/// </summary>
public interface IUserManageApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 邀请其他组织企业账号加入
    /// </summary>
    [HttpPost("/topapi/v2/user/create")]
    ITask<DingTalkResult<UserCreateResult>> UserCreateAsync([JsonContent] UserCreateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新企业账号用户信息
    /// </summary>
    [HttpPost("/topapi/v2/user/update")]
    ITask<DingTalkResult> UserUpdateAsync([JsonContent] UserUpdateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除用户
    /// </summary>
    [HttpPost("/topapi/v2/user/delete")]
    ITask<DingTalkResult> UserDeleteAsync([JsonContent] UserDeleteRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询企业账号用户详情
    /// </summary>
    [HttpPost("/topapi/v2/user/get")]
    ITask<DingTalkResult<UserGetResult>> UserGetAsync([JsonContent] UserGetRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询企业账号用户详情
    /// </summary>
    [HttpPost("/topapi/v2/user/get")]
    ITask<DingTalkResult<UserGetResult>> GetUserAsync([JsonContent] GetUserInfoRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取部门用户基础信息
    /// </summary>
    [HttpPost("/topapi/user/listsimple")]
    ITask<DingTalkResult<UserListSimpleResult>> UserListSimpleAsync([JsonContent] UserListSimpleRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取部门用户userid列表
    /// </summary>
    [HttpPost("/topapi/user/listid")]
    ITask<DingTalkResult<UserListIdResult>> UserListIdAsync([JsonContent] UserListIdRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取部门企业账号用户详情
    /// </summary>
    [HttpPost("/topapi/v2/user/list")]
    ITask<DingTalkResult<UserListResult>> UserListAsync([JsonContent] UserListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取员工人数
    /// </summary>
    [HttpPost("/topapi/user/count")]
    ITask<DingTalkResult<UserCountResult>> UserCountAsync([JsonContent] UserCountRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取未登录钉钉的员工列表
    /// </summary>
    [HttpPost("/topapi/inactive/user/v2/get")]
    ITask<DingTalkResult<InactiveUserGetResult>> InactiveUserGetAsync([JsonContent] InactiveUserGetRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 根据手机号查询企业账号用户
    /// </summary>
    [HttpPost("/topapi/v2/user/getbymobile")]
    ITask<DingTalkResult<UserGetByMobileResult>> UserGetByMobileAsync([JsonContent] UserGetByMobileRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 根据手机号查询企业账号用户
    /// </summary>
    [HttpPost("/topapi/v2/user/getbymobile")]
    ITask<DingTalkResult<UserGetByMobileResult>> GetUserByMobileAsync([JsonContent] MobileRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 根据unionid获取用户userid
    /// </summary>
    [HttpPost("/topapi/user/getbyunionid")]
    ITask<DingTalkResult<UserGetByUnionIdResult>> UserGetByUnionIdAsync([JsonContent] UserGetByUnionIdRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取管理员列表
    /// </summary>
    [HttpPost("/topapi/user/listadmin")]
    ITask<DingTalkResult<UserListAdminResult>> UserListAdminAsync([JsonContent] UserListAdminRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取管理员通讯录权限范围
    /// </summary>
    [HttpPost("/topapi/user/get_admin_scope")]
    ITask<UserGetAdminScopeResponse> UserGetAdminScopeAsync([JsonContent] UserGetAdminScopeRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
