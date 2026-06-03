using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models;
using DingTalkApiClient.Models.Contacts.ExternalContacts;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.Contacts;

/// <summary>
/// 外部联系人api
/// </summary>
public interface IExternalContactsApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 添加外部联系人
    /// </summary>
    [HttpPost("/topapi/extcontact/create")]
    ITask<ExternalContactCreateResponse> ExternalContactCreateAsync([JsonContent] ExternalContactCreateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除外部联系人
    /// </summary>
    [HttpPost("/topapi/extcontact/delete")]
    ITask<DingTalkResult> ExternalContactDeleteAsync([JsonContent] ExternalContactDeleteRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新外部联系人
    /// </summary>
    [HttpPost("/topapi/extcontact/update")]
    ITask<DingTalkResult> ExternalContactUpdateAsync([JsonContent] ExternalContactUpdateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取外部联系人列表
    /// </summary>
    [HttpPost("/topapi/extcontact/list")]
    ITask<ExternalContactListResponse> ExternalContactListAsync([JsonContent] ExternalContactListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取外部联系人标签列表
    /// </summary>
    [HttpPost("/topapi/extcontact/listlabelgroups")]
    ITask<ExternalContactListlabelgroupsResponse> ExternalContactListlabelgroupsAsync([JsonContent] ExternalContactListlabelgroupsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取外部联系人详情
    /// </summary>
    [HttpPost("/topapi/extcontact/get")]
    ITask<DingTalkResult<ExternalContactGetResult>> ExternalContactGetAsync([JsonContent] ExternalContactGetRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
