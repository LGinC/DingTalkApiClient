using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models;
using DingTalkApiClient.Models.Contacts.IndustryContacts;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.Contacts;

/// <summary>
/// 行业通讯录api
/// </summary>
public interface IIndustryContactsApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 获取部门列表
    /// </summary>
    [HttpPost("/topapi/industry/department/list")]
    ITask<DingTalkResult<IndustryDepartmentListResult>> IndustryDepartmentListAsync([JsonContent] IndustryDepartmentListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取部门详情
    /// </summary>
    [HttpPost("/topapi/industry/department/get")]
    ITask<DingTalkResult<IndustryDepartmentGetResult>> IndustryDepartmentGetAsync([JsonContent] IndustryDepartmentGetRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取部门下人员列表
    /// </summary>
    [HttpPost("/topapi/industry/user/list")]
    ITask<DingTalkResult<IndustryUserListResult>> IndustryUserListAsync([JsonContent] IndustryUserListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取部门用户详情
    /// </summary>
    [HttpPost("/topapi/industry/user/get")]
    ITask<DingTalkResult<IndustryUserGetResult>> IndustryUserGetAsync([JsonContent] IndustryUserGetRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取企业信息
    /// </summary>
    [HttpPost("/topapi/industry/organization/get")]
    ITask<DingTalkResult<IndustryOrganizationGetResult>> IndustryOrganizationGetAsync([JsonContent] IndustryOrganizationGetRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
