using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.CRM;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.CRM;

/// <summary>
/// 客户管理 CRM v1.0 api
/// </summary>
public interface ICrmApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 获取个人或企业客户的元数据
    /// </summary>
    [HttpGet("/v1.0/crm/personalCustomers/objectMeta")]
    ITask<CrmObjectMetaResponse> GetPersonalCustomerObjectMetaAsync(string? relationType = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建个人或企业客户数据
    /// </summary>
    [HttpPost("/v1.0/crm/personalCustomers")]
    ITask<CrmInstanceIdResponse> CreatePersonalCustomerAsync([JsonContent] CrmPersonalCustomerCreateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新个人或企业客户数据
    /// </summary>
    [HttpPut("/v1.0/crm/personalCustomers")]
    ITask<CrmInstanceIdResponse> UpdatePersonalCustomerAsync([JsonContent] CrmPersonalCustomerUpdateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 根据指定条件查询个人或企业客户数据
    /// </summary>
    [HttpGet("/v1.0/crm/personalCustomers")]
    ITask<CrmCustomerQueryResponse> QueryPersonalCustomersAsync(string? currentOperatorUserId = null, string? nextToken = null, int maxResults = 10, string? queryDsl = null, string? relationType = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除个人或企业客户数据
    /// </summary>
    [HttpDelete("/v1.0/crm/personalCustomers/{dataId}")]
    ITask<CrmInstanceIdResponse> DeletePersonalCustomerAsync([PathQuery] string dataId, string currentOperatorUserId, string? relationType = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量新增个人或企业客户数据
    /// </summary>
    [HttpPost("/v1.0/crm/relationDatas/batch")]
    ITask<CrmBatchRelationResponse> BatchCreateRelationDatasAsync([JsonContent] CrmBatchCreateRelationDatasRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量更新个人或企业客户数据
    /// </summary>
    [HttpPut("/v1.0/crm/relationDatas/batch")]
    ITask<CrmBatchRelationResponse> BatchUpdateRelationDatasAsync([JsonContent] CrmBatchUpdateRelationDatasRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量获取个人或企业客户数据
    /// </summary>
    [HttpPost("/v1.0/crm/personalCustomers/batchQuery")]
    ITask<CrmBatchGetPersonalCustomersResponse> BatchGetPersonalCustomersAsync(string? currentOperatorUserId = null, string? relationType = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取全量个人或企业客户数据
    /// </summary>
    [HttpPost("/v1.0/crm/customerInstances")]
    ITask<CrmCustomerInstancesResponse> GetCustomerInstancesAsync([JsonContent] CrmCustomerInstancesRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取个人或企业客户查重字段
    /// </summary>
    [HttpGet("/v1.0/crm/relationUkSettings")]
    ITask<CrmRelationUkSettingsResponse> GetRelationUkSettingsAsync(string relationType, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取客户管理全局信息
    /// </summary>
    [HttpGet("/v1.0/crm/globalInfos")]
    ITask<CrmGlobalInfosResponse> GetGlobalInfosAsync(string userId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询客户数据
    /// </summary>
    [HttpGet("/v1.0/crm/relations/datas/targets/{targetId}")]
    ITask<CrmRelationsByTargetResponse> QueryRelationsByTargetAsync([PathQuery] string targetId, string relationType, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量新增联系人数据
    /// </summary>
    [HttpPost("/v1.0/crm/contacts/batch")]
    ITask<CrmBatchRelationResponse> BatchCreateContactsAsync([JsonContent] CrmBatchContactRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量修改联系人数据
    /// </summary>
    [HttpPut("/v1.0/crm/contacts/batch")]
    ITask<CrmBatchRelationResponse> BatchUpdateContactsAsync([JsonContent] CrmBatchContactRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量新增跟进记录数据
    /// </summary>
    [HttpPost("/v1.0/crm/followRecords/batch")]
    ITask<CrmBatchRelationResponse> BatchCreateFollowRecordsAsync([JsonContent] CrmBatchFollowRecordRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量更新跟进记录数据
    /// </summary>
    [HttpPut("/v1.0/crm/followRecords/batch")]
    ITask<CrmBatchRelationResponse> BatchUpdateFollowRecordsAsync([JsonContent] CrmBatchFollowRecordRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量删除跟进记录数据
    /// </summary>
    [HttpPost("/v1.0/crm/followRecords/batchRemove")]
    ITask<CrmBatchRemoveResponse> BatchRemoveFollowRecordsAsync([JsonContent] CrmBatchRemoveFollowRecordsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除 CRM 自定义对象数据
    /// </summary>
    [HttpDelete("/v1.0/crm/customObjectData/{instanceId}")]
    ITask<CrmInstanceIdResponse> DeleteCustomObjectDataAsync([PathQuery] string instanceId, string formCode, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建客户群
    /// </summary>
    [HttpPost("/v1.0/crm/groups")]
    ITask<CrmCreateGroupResponse> CreateGroupAsync([JsonContent] CrmCreateGroupRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询客户群列表
    /// </summary>
    [HttpGet("/v1.0/crm/crmGroupChats")]
    ITask<CrmGroupChatListResponse> QueryGroupChatsAsync(string relationType, string? nextToken = null, int maxResults = 10, string? queryDsl = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取单个客户群详情
    /// </summary>
    [HttpPost("/v1.0/crm/crmGroupChats/query")]
    ITask<CrmGroupChatDetail> GetGroupChatAsync(string openConversationId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量查询客户群
    /// </summary>
    [HttpPost("/v1.0/crm/crmGroupChats/batchQuery")]
    ITask<CrmBatchGroupChatResponse> BatchQueryGroupChatsAsync([JsonContent] CrmBatchGroupChatRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建客户群组
    /// </summary>
    [HttpPost("/v1.0/crm/groupSets")]
    ITask<CrmGroupSetDetail> CreateGroupSetAsync([JsonContent] CrmCreateGroupSetRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取单个客户群组详情
    /// </summary>
    [HttpGet("/v1.0/crm/groupSets")]
    ITask<CrmGroupSetDetail> GetGroupSetAsync(string openGroupSetId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新客户群组
    /// </summary>
    [HttpPut("/v1.0/crm/groupSets/set")]
    ITask<CrmBooleanResultResponse> UpdateGroupSetAsync([JsonContent] CrmUpdateGroupSetRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询客户群组列表
    /// </summary>
    [HttpGet("/v1.0/crm/groupSets/lists")]
    ITask<CrmGroupSetListResponse> QueryGroupSetsAsync(string? nextToken = null, int? maxResults = null, string? queryDsl = null, string? relationType = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}

/// <summary>
/// 客户管理 CRM topapi
/// </summary>
public interface ICrmTopApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 删除联系人数据
    /// </summary>
    [HttpPost("/topapi/crm/objectdata/contact/delete")]
    ITask<CrmTopBooleanResponse> DeleteContactAsync([JsonContent] CrmTopDeleteDataRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取联系人对象的元数据
    /// </summary>
    [HttpPost("/topapi/crm/objectmeta/contact/describe")]
    ITask<CrmTopObjectMetaResponse> DescribeContactObjectMetaAsync([DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 根据指定条件查询联系人数据
    /// </summary>
    [HttpPost("/topapi/crm/objectdata/contact/query")]
    ITask<CrmTopQueryResponse> QueryContactsAsync([JsonContent] CrmTopQueryRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 按照 ID 列表批量获取联系人数据
    /// </summary>
    [HttpPost("/topapi/crm/objectdata/contact/list")]
    ITask<CrmTopListResponse> ListContactsAsync([JsonContent] CrmTopListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取跟进记录对象的元数据
    /// </summary>
    [HttpPost("/topapi/crm/objectmeta/followrecord/describe")]
    ITask<CrmTopObjectMetaResponse> DescribeFollowRecordObjectMetaAsync([DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 根据指定条件查询跟进记录数据
    /// </summary>
    [HttpPost("/topapi/crm/objectdata/followrecord/query")]
    ITask<CrmTopQueryResponse> QueryFollowRecordsAsync([JsonContent] CrmTopQueryRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 根据 ID 列表批量获取跟进记录数据
    /// </summary>
    [HttpPost("/topapi/crm/objectdata/followrecord/list")]
    ITask<CrmTopListResponse> ListFollowRecordsAsync([JsonContent] CrmTopListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建 CRM 自定义对象数据
    /// </summary>
    [HttpPost("/topapi/crm/objectdata/customobject/create")]
    ITask<CrmTopCustomObjectResponse> CreateCustomObjectDataAsync([JsonContent] CrmTopCustomObjectRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新自定义对象数据
    /// </summary>
    [HttpPost("/topapi/crm/objectdata/customobject/update")]
    ITask<CrmTopCustomObjectResponse> UpdateCustomObjectDataAsync([JsonContent] CrmTopCustomObjectRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取自定义对象的元数据
    /// </summary>
    [HttpPost("/topapi/crm/objectmeta/describe")]
    ITask<CrmTopObjectMetaResponse> DescribeCustomObjectMetaAsync([JsonContent] CrmTopDescribeCustomObjectMetaRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 根据指定条件查询自定义对象数据
    /// </summary>
    [HttpPost("/topapi/crm/objectdata/query")]
    ITask<CrmTopQueryResponse> QueryCustomObjectDataAsync([JsonContent] CrmTopCustomObjectQueryRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 按照 ID 列表批量获取 CRM 自定义表单数据
    /// </summary>
    [HttpPost("/topapi/crm/objectdata/list")]
    ITask<CrmTopListResponse> ListCustomObjectDataAsync([JsonContent] CrmTopCustomObjectListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
