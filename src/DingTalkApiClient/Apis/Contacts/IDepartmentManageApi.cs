using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models;
using DingTalkApiClient.Models.Contacts.DepartmentManage;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.Contacts;

/// <summary>
/// 部门管理api
/// </summary>
public interface IDepartmentManageApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 创建部门
    /// </summary>
    [HttpPost("/topapi/v2/department/create")]
    ITask<DingTalkResult<DepartmentCreateResult>> DepartmentCreateAsync([JsonContent] DepartmentCreateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新部门
    /// </summary>
    [HttpPost("/topapi/v2/department/update")]
    ITask<DingTalkResult> DepartmentUpdateAsync([JsonContent] DepartmentUpdateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除部门
    /// </summary>
    [HttpPost("/topapi/v2/department/delete")]
    ITask<DingTalkResult> DepartmentDeleteAsync([JsonContent] DepartmentDeleteRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取部门详情
    /// </summary>
    [HttpPost("/topapi/v2/department/get")]
    ITask<DingTalkResult<DepartmentGetResult>> DepartmentGetAsync([JsonContent] DepartmentGetRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取部门列表
    /// </summary>
    [HttpPost("/topapi/v2/department/listsub")]
    ITask<DingTalkResult<DepartmentListSubResult>> DepartmentListSubAsync([JsonContent] DepartmentListSubRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取子部门ID列表
    /// </summary>
    [HttpPost("/topapi/v2/department/listsubid")]
    ITask<DingTalkResult<DepartmentListSubIdResult>> DepartmentListSubIdAsync([JsonContent] DepartmentListSubIdRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取指定部门的所有父部门列表
    /// </summary>
    [HttpPost("/topapi/v2/department/listparentbydept")]
    ITask<DingTalkResult<DepartmentListParentByDeptResult>> DepartmentListParentByDeptAsync([JsonContent] DepartmentListParentByDeptRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取指定用户的所有父部门列表
    /// </summary>
    [HttpPost("/topapi/v2/department/listparentbyuser")]
    ITask<DingTalkResult<DepartmentListParentByUserResult>> DepartmentListParentByUserAsync([JsonContent] DepartmentListParentByUserRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
