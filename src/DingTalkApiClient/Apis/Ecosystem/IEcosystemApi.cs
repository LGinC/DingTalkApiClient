using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models;
using DingTalkApiClient.Models.Ecosystem;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.Ecosystem;

/// <summary>
/// 生态开放 API。
/// </summary>
public interface IEcosystemApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 创建自助单
    /// </summary>
    [HttpPost("/v1.0/customerService/tickets")]
    ITask<PostV1CustomerServiceTicketsResponse> PostV1CustomerServiceTicketsAsync(
        [JsonContent] PostV1CustomerServiceTicketsRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 分页查询工单
    /// </summary>
    [HttpGet("/v1.0/customerService/tickets")]
    ITask<GetV1CustomerServiceTicketsResponse> GetV1CustomerServiceTicketsAsync(
        string templateId,
        string nextToken,
        string maxResults,
        string? openInstanceId = null,
        string? productionType = null,
        string? ticketId = null,
        string? sourceId = null,
        string? foreignId = null,
        string? ticketStatus = null,
        string? startTime = null,
        string? endTime = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 执行工单活动
    /// </summary>
    [HttpPut("/v1.0/customerService/tickets/{ticketId}")]
    ITask<PutV1CustomerServiceTicketsTicketIdResponse> PutV1CustomerServiceTicketsTicketIdAsync(
        [JsonContent] PutV1CustomerServiceTicketsTicketIdRequest request,
        [PathQuery] string ticketId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 查询动作记录
    /// </summary>
    [HttpGet("/v1.0/customerService/tickets/{ticketId}/actions")]
    ITask<GetV1CustomerServiceTicketsTicketIdActionsResponse> GetV1CustomerServiceTicketsTicketIdActionsAsync(
        [PathQuery] string ticketId,
        string nextToken,
        string maxResults,
        string? openInstanceId = null,
        string? productionType = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 智能问答
    /// </summary>
    [HttpPost("/v1.0/dingmi/robots/ask")]
    ITask<PostV1DingMiRobotsAskResponse> PostV1DingMiRobotsAskAsync(
        [JsonContent] PostV1DingMiRobotsAskRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取用户登录凭证
    /// </summary>
    [HttpPost("/v1.0/dingmi/webChannels/userTokens")]
    ITask<PostV1DingMiWebChannelsUserTokensResponse> PostV1DingMiWebChannelsUserTokensAsync(
        [JsonContent] PostV1DingMiWebChannelsUserTokensRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 推送小蜜机器人单聊O2O消息
    /// </summary>
    [HttpPost("/v1.0/dingmi/robots/oToMessages/send")]
    ITask<PostV1DingMiRobotsOToMessagesSendResponse> PostV1DingMiRobotsOToMessagesSendAsync(
        [JsonContent] PostV1DingMiRobotsOToMessagesSendRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 小蜜客服机器人消息回复
    /// </summary>
    [HttpPost("/v1.0/dingmi/robots/reply")]
    ITask<PostV1DingMiRobotsReplyResponse> PostV1DingMiRobotsReplyAsync(
        [JsonContent] PostV1DingMiRobotsReplyRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 查询机器人基础指标数据
    /// </summary>
    [HttpGet("/v1.0/dingmi/robots/data")]
    ITask<GetV1DingMiRobotsDataResponse> GetV1DingMiRobotsDataAsync(
        [JsonContent] GetV1DingMiRobotsDataRequest request,
        string appKey,
        string startDay,
        string endDay,
        string byDay,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 搜索第三方酒店超标审批单
    /// </summary>
    [HttpGet("/v1.0/alitrip/exceedapply/getHotel")]
    ITask<GetV1AliTripExceedapplyGetHotelResponse> GetV1AliTripExceedapplyGetHotelAsync(
        string corpId,
        string applyId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 搜索第三方火车票超标审批单
    /// </summary>
    [HttpGet("/v1.0/alitrip/exceedapply/getTrain")]
    ITask<GetV1AliTripExceedapplyGetTrainResponse> GetV1AliTripExceedapplyGetTrainAsync(
        string corpId,
        string applyId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 回传第三方超标审批结果
    /// </summary>
    [HttpPost("/v1.0/alitrip/exceedapply/sync")]
    ITask<PostV1AliTripExceedapplySyncResponse> PostV1AliTripExceedapplySyncAsync(
        string remark,
        string applyId,
        string corpId,
        string thirdpartyFlowId,
        string userId,
        string status,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 搜索第三方机票超标审批单
    /// </summary>
    [HttpGet("/v1.0/alitrip/exceedapply/getFlight")]
    ITask<GetV1AliTripExceedapplyGetFlightResponse> GetV1AliTripExceedapplyGetFlightAsync(
        string corpId,
        string applyId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 关联单号查询相关订单信息列表
    /// </summary>
    [HttpGet("/v1.0/alitrip/unionOrders")]
    ITask<GetV1AliTripUnionOrdersResponse> GetV1AliTripUnionOrdersAsync(
        string corpId,
        string? thirdPartApplyId = null,
        string? unionNo = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 同步市内用车申请单
    /// </summary>
    [HttpPost("/v1.0/alitrip/cityCarApprovals")]
    ITask<PostV1AliTripCityCarApprovalsResponse> PostV1AliTripCityCarApprovalsAsync(
        [JsonContent] PostV1AliTripCityCarApprovalsRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 审批市内用车申请单
    /// </summary>
    [HttpPut("/v1.0/alitrip/cityCarApprovals")]
    ITask<PutV1AliTripCityCarApprovalsResponse> PutV1AliTripCityCarApprovalsAsync(
        [JsonContent] PutV1AliTripCityCarApprovalsRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 查询市内用车申请单
    /// </summary>
    [HttpGet("/v1.0/alitrip/cityCarApprovals")]
    ITask<GetV1AliTripCityCarApprovalsResponse> GetV1AliTripCityCarApprovalsAsync(
        string corpId,
        string? createdEndAt = null,
        string? createdStartAt = null,
        string? pageNumber = null,
        string? pageSize = null,
        string? thirdPartApplyId = null,
        string? userId = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 查询用车结算记账记录
    /// </summary>
    [HttpGet("/v1.0/alitrip/billSettlements/cars")]
    ITask<GetV1AliTripBillSettlementsCarsResponse> GetV1AliTripBillSettlementsCarsAsync(
        string? corpId = null,
        string? category = null,
        string? pageSize = null,
        string? periodStart = null,
        string? periodEnd = null,
        string? pageNumber = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 查询商旅火车票结算记账数据
    /// </summary>
    [HttpGet("/v1.0/alitrip/billSettlements/btripTrains")]
    ITask<GetV1AliTripBillSettlementsBTripTrainsResponse> GetV1AliTripBillSettlementsBTripTrainsAsync(
        string? corpId = null,
        string? category = null,
        string? pageSize = null,
        string? periodStart = null,
        string? pageNumber = null,
        string? periodEnd = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 查询酒店结算记账数据
    /// </summary>
    [HttpGet("/v1.0/alitrip/billSettlements/hotels")]
    ITask<GetV1AliTripBillSettlementsHotelsResponse> GetV1AliTripBillSettlementsHotelsAsync(
        string? corpId = null,
        string? category = null,
        string? pageSize = null,
        string? periodStart = null,
        string? pageNumber = null,
        string? periodEnd = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 查询机票结算记账数据
    /// </summary>
    [HttpGet("/v1.0/alitrip/billSettlements/flights")]
    ITask<GetV1AliTripBillSettlementsFlightsResponse> GetV1AliTripBillSettlementsFlightsAsync(
        string? corpId = null,
        string? category = null,
        string? pageSize = null,
        string? periodStart = null,
        string? pageNumber = null,
        string? periodEnd = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 客户资料
    /// </summary>
    [HttpPost("/v1.0/jzcrm/customers")]
    ITask<PostV1JzCrmCustomersResponse> PostV1JzCrmCustomersAsync(
        [JsonContent] PostV1JzCrmCustomersRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 客户公共池
    /// </summary>
    [HttpPost("/v1.0/jzcrm/customerPools")]
    ITask<PostV1JzCrmCustomerPoolsResponse> PostV1JzCrmCustomerPoolsAsync(
        [JsonContent] PostV1JzCrmCustomerPoolsRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 联系人
    /// </summary>
    [HttpPost("/v1.0/jzcrm/contacts")]
    ITask<PostV1JzCrmContactsResponse> PostV1JzCrmContactsAsync(
        [JsonContent] PostV1JzCrmContactsRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 合同订单
    /// </summary>
    [HttpPost("/v1.0/jzcrm/orders")]
    ITask<PostV1JzCrmOrdersResponse> PostV1JzCrmOrdersAsync(
        [JsonContent] PostV1JzCrmOrdersRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 发货单
    /// </summary>
    [HttpPost("/v1.0/jzcrm/invoices")]
    ITask<PostV1JzCrmInvoicesResponse> PostV1JzCrmInvoicesAsync(
        [JsonContent] PostV1JzCrmInvoicesRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 销售换货单
    /// </summary>
    [HttpPost("/v1.0/jzcrm/exchanges")]
    ITask<PostV1JzCrmExchangesResponse> PostV1JzCrmExchangesAsync(
        [JsonContent] PostV1JzCrmExchangesRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 销售机会
    /// </summary>
    [HttpPost("/v1.0/jzcrm/sales")]
    ITask<PostV1JzCrmSalesResponse> PostV1JzCrmSalesAsync(
        [JsonContent] PostV1JzCrmSalesRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 报价记录
    /// </summary>
    [HttpPost("/v1.0/jzcrm/quotationRecords")]
    ITask<PostV1JzCrmQuotationRecordsResponse> PostV1JzCrmQuotationRecordsAsync(
        [JsonContent] PostV1JzCrmQuotationRecordsRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 采购单
    /// </summary>
    [HttpPost("/v1.0/jzcrm/purchases")]
    ITask<PostV1JzCrmPurchasesResponse> PostV1JzCrmPurchasesAsync(
        [JsonContent] PostV1JzCrmPurchasesRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 生产单
    /// </summary>
    [HttpPost("/v1.0/jzcrm/productions")]
    ITask<PostV1JzCrmProductionsResponse> PostV1JzCrmProductionsAsync(
        [JsonContent] PostV1JzCrmProductionsRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 产品信息
    /// </summary>
    [HttpPost("/v1.0/jzcrm/goods")]
    ITask<PostV1JzCrmGoodsResponse> PostV1JzCrmGoodsAsync(
        [JsonContent] PostV1JzCrmGoodsRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 入库单
    /// </summary>
    [HttpPost("/v1.0/jzcrm/intostocks")]
    ITask<PostV1JzCrmIntoStocksResponse> PostV1JzCrmIntoStocksAsync(
        [JsonContent] PostV1JzCrmIntoStocksRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 出库单
    /// </summary>
    [HttpPost("/v1.0/jzcrm/outstocks")]
    ITask<PostV1JzCrmOutStocksResponse> PostV1JzCrmOutStocksAsync(
        [JsonContent] PostV1JzCrmOutStocksRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取数据详情
    /// </summary>
    [HttpGet("/v1.0/jzcrm/dataView")]
    ITask<GetV1JzCrmDataViewResponse> GetV1JzCrmDataViewAsync(
        string datatype,
        string msgid,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取数据列表
    /// </summary>
    [HttpGet("/v1.0/jzcrm/data")]
    ITask<GetV1JzCrmDataResponse> GetV1JzCrmDataAsync(
        string datatype,
        string page,
        string pagesize,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取应用列表
    /// </summary>
    [HttpPost("/v1.0/h3yun/apps/search")]
    ITask<PostV1H3YunAppsSearchResponse> PostV1H3YunAppsSearchAsync(
        [JsonContent] PostV1H3YunAppsSearchRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取应用功能节点
    /// </summary>
    [HttpGet("/v1.0/h3yun/apps/functionNodes")]
    ITask<GetV1H3YunAppsFunctionNodesResponse> GetV1H3YunAppsFunctionNodesAsync(
        string appCode,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取组织数据
    /// </summary>
    [HttpGet("/v1.0/h3yun/departments")]
    ITask<GetV1H3YunDepartmentsResponse> GetV1H3YunDepartmentsAsync(
        string? departmentId = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取用户数据
    /// </summary>
    [HttpGet("/v1.0/h3yun/users")]
    ITask<GetV1H3YunUsersResponse> GetV1H3YunUsersAsync(
        string departmentId,
        string? isRecursive = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取角色数据
    /// </summary>
    [HttpGet("/v1.0/h3yun/roles")]
    ITask<GetV1H3YunRolesResponse> GetV1H3YunRolesAsync(
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取角色用户数据
    /// </summary>
    [HttpGet("/v1.0/h3yun/roles/roleUsers")]
    ITask<GetV1H3YunRolesRoleUsersResponse> GetV1H3YunRolesRoleUsersAsync(
        string roleId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取表单对象结构
    /// </summary>
    [HttpGet("/v1.0/h3yun/forms/loadBizFields")]
    ITask<GetV1H3YunFormsLoadBizFieldsResponse> GetV1H3YunFormsLoadBizFieldsAsync(
        string schemaCode,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 创建表单业务数据
    /// </summary>
    [HttpPost("/v1.0/h3yun/forms/instances")]
    ITask<PostV1H3YunFormsInstancesResponse> PostV1H3YunFormsInstancesAsync(
        [JsonContent] PostV1H3YunFormsInstancesRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 修改表单业务对象数据
    /// </summary>
    [HttpPut("/v1.0/h3yun/forms/instances")]
    ITask<PutV1H3YunFormsInstancesResponse> PutV1H3YunFormsInstancesAsync(
        [JsonContent] PutV1H3YunFormsInstancesRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 删除业务对象
    /// </summary>
    [HttpDelete("/v1.0/h3yun/forms/instances")]
    ITask<DeleteV1H3YunFormsInstancesResponse> DeleteV1H3YunFormsInstancesAsync(
        string schemaCode,
        string bizObjectId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 查询表单业务数据列表
    /// </summary>
    [HttpPost("/v1.0/h3yun/forms/instances/search")]
    ITask<PostV1H3YunFormsInstancesSearchResponse> PostV1H3YunFormsInstancesSearchAsync(
        [JsonContent] PostV1H3YunFormsInstancesSearchRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 批量新增表单业务数据
    /// </summary>
    [HttpPost("/v1.0/h3yun/forms/instances/batch")]
    ITask<PostV1H3YunFormsInstancesBatchResponse> PostV1H3YunFormsInstancesBatchAsync(
        [JsonContent] PostV1H3YunFormsInstancesBatchRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取业务实例信息
    /// </summary>
    [HttpGet("/v1.0/h3yun/forms/instances/loadInstances")]
    ITask<GetV1H3YunFormsInstancesLoadInstancesResponse> GetV1H3YunFormsInstancesLoadInstancesAsync(
        string schemaCode,
        string bizObjectId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 创建流程实例
    /// </summary>
    [HttpPost("/v1.0/h3yun/processes/instances")]
    ITask<PostV1H3YunProcessesInstancesResponse> PostV1H3YunProcessesInstancesAsync(
        [JsonContent] PostV1H3YunProcessesInstancesRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 删除流程实例数据
    /// </summary>
    [HttpDelete("/v1.0/h3yun/processes/instances")]
    ITask<DeleteV1H3YunProcessesInstancesResponse> DeleteV1H3YunProcessesInstancesAsync(
        string processInstanceId,
        bool isAutoUpdateBizObject,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 查询流程实例
    /// </summary>
    [HttpGet("/v1.0/h3yun/processes/instances")]
    ITask<GetV1H3YunProcessesInstancesResponse> GetV1H3YunProcessesInstancesAsync(
        string schemaCode,
        string bizObjectId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 取消流程实例
    /// </summary>
    [HttpPost("/v1.0/h3yun/processes/instances/cancel")]
    ITask<PostV1H3YunProcessesInstancesCancelResponse> PostV1H3YunProcessesInstancesCancelAsync(
        [JsonContent] PostV1H3YunProcessesInstancesCancelRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 查询流程实例节点工作项
    /// </summary>
    [HttpGet("/v1.0/h3yun/processes/workItems")]
    ITask<GetV1H3YunProcessesWorkItemsResponse> GetV1H3YunProcessesWorkItemsAsync(
        string processInstanceId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取附件临时免登地址
    /// </summary>
    [HttpGet("/v1.0/h3yun/attachments/temporaryUrls")]
    ITask<GetV1H3YunAttachmentsTemporaryUrlsResponse> GetV1H3YunAttachmentsTemporaryUrlsAsync(
        string attachmentId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取文件上传地址
    /// </summary>
    [HttpGet("/v1.0/h3yun/attachments/uploadUrls")]
    ITask<GetV1H3YunAttachmentsUploadUrlsResponse> GetV1H3YunAttachmentsUploadUrlsAsync(
        string schemaCode,
        string bizObjectId,
        string fieldName,
        bool isOverwrite,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// e签宝数据初始化
    /// </summary>
    [HttpPost("/v2.0/esign/developers")]
    ITask<PostV2EsignDevelopersResponse> PostV2EsignDevelopersAsync(
        [JsonContent] PostV2EsignDevelopersRequest request,
        [Header("serviceGroup")] string? serviceGroup = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取授权的页面地址
    /// </summary>
    [HttpPost("/v2.0/esign/auths/urls")]
    ITask<PostV2EsignAuthsUrlsResponse> PostV2EsignAuthsUrlsAsync(
        [JsonContent] PostV2EsignAuthsUrlsRequest request,
        [Header("serviceGroup")] string? serviceGroup = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 取消企业授权
    /// </summary>
    [HttpPost("/v2.0/esign/auths/cancel")]
    ITask<PostV2EsignAuthsCancelResponse> PostV2EsignAuthsCancelAsync(
        [Header("serviceGroup")] string? serviceGroup = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 套餐转售—分润模式
    /// </summary>
    [HttpPost("/v2.0/esign/orders/channel")]
    ITask<PostV2EsignOrdersChannelResponse> PostV2EsignOrdersChannelAsync(
        [JsonContent] PostV2EsignOrdersChannelRequest request,
        [Header("serviceGroup")] string? serviceGroup = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 套餐转售—底价结算模式
    /// </summary>
    [HttpPost("/v2.0/esign/orders/resale")]
    ITask<PostV2EsignOrdersResaleResponse> PostV2EsignOrdersResaleAsync(
        [JsonContent] PostV2EsignOrdersResaleRequest request,
        [Header("serviceGroup")] string? serviceGroup = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 查询套餐余量
    /// </summary>
    [HttpGet("/v2.0/esign/margins")]
    ITask<GetV2EsignMarginsResponse> GetV2EsignMarginsAsync(
        [Header("serviceGroup")] string? serviceGroup = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取企业的e签宝微应用状态
    /// </summary>
    [HttpGet("/v2.0/esign/corps/appStatus")]
    ITask<GetV2EsignCorpsAppStatusResponse> GetV2EsignCorpsAppStatusAsync(
        [Header("serviceGroup")] string? serviceGroup = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 查询企业信息
    /// </summary>
    [HttpGet("/v2.0/esign/corps/infos")]
    ITask<GetV2EsignCorpsInfosResponse> GetV2EsignCorpsInfosAsync(
        [Header("serviceGroup")] string? serviceGroup = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取企业控制台地址
    /// </summary>
    [HttpGet("/v2.0/esign/corps/consoles")]
    ITask<GetV2EsignCorpsConsolesResponse> GetV2EsignCorpsConsolesAsync(
        [JsonContent] GetV2EsignCorpsConsolesRequest request,
        [Header("serviceGroup")] string? serviceGroup = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 查询个人信息
    /// </summary>
    [HttpGet("/v2.0/esign/users/{userId}")]
    ITask<GetV2EsignUsersUserIdResponse> GetV2EsignUsersUserIdAsync(
        [PathQuery] string userId,
        [Header("serviceGroup")] string? serviceGroup = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取个人实名的地址
    /// </summary>
    [HttpPost("/v2.0/esign/users/realnames")]
    ITask<PostV2EsignUsersRealNamesResponse> PostV2EsignUsersRealNamesAsync(
        [JsonContent] PostV2EsignUsersRealNamesRequest request,
        [Header("serviceGroup")] string? serviceGroup = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取跳转到企业实名的地址
    /// </summary>
    [HttpPost("/v2.0/esign/corps/realnames")]
    ITask<PostV2EsignCorpsRealNamesResponse> PostV2EsignCorpsRealNamesAsync(
        [JsonContent] PostV2EsignCorpsRealNamesRequest request,
        [Header("serviceGroup")] string? serviceGroup = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取文件上传地址
    /// </summary>
    [HttpPost("/v2.0/esign/files/uploadUrls")]
    ITask<PostV2EsignFilesUploadUrlsResponse> PostV2EsignFilesUploadUrlsAsync(
        [JsonContent] PostV2EsignFilesUploadUrlsRequest request,
        [Header("serviceGroup")] string? serviceGroup = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取文件详情
    /// </summary>
    [HttpGet("/v2.0/esign/files/{fileId}")]
    ITask<GetV2EsignFilesFileIdResponse> GetV2EsignFilesFileIdAsync(
        [PathQuery] string fileId,
        [Header("serviceGroup")] string? serviceGroup = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取发起签署任务的地址
    /// </summary>
    [HttpPost("/v2.0/esign/processes/startUrls")]
    ITask<PostV2EsignProcessesStartUrlsResponse> PostV2EsignProcessesStartUrlsAsync(
        [JsonContent] PostV2EsignProcessesStartUrlsRequest request,
        [Header("serviceGroup")] string? serviceGroup = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 创建签署流程
    /// </summary>
    [HttpPost("/v2.0/esign/process/startAtOnce")]
    ITask<PostV2EsignProcessStartAtOnceResponse> PostV2EsignProcessStartAtOnceAsync(
        [JsonContent] PostV2EsignProcessStartAtOnceRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取签署人签署地址
    /// </summary>
    [HttpPost("/v2.0/esign/process/executeUrls")]
    ITask<PostV2EsignProcessExecuteUrlsResponse> PostV2EsignProcessExecuteUrlsAsync(
        [JsonContent] PostV2EsignProcessExecuteUrlsRequest request,
        [Header("serviceGroup")] string? serviceGroup = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取流程的签署详情
    /// </summary>
    [HttpGet("/v2.0/esign/signTasks/{taskId}")]
    ITask<GetV2EsignSignTasksTaskIdResponse> GetV2EsignSignTasksTaskIdAsync(
        [PathQuery] string taskId,
        [Header("serviceGroup")] string? serviceGroup = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取流程任务用印审批列表
    /// </summary>
    [HttpGet("/v2.0/esign/approvals/{taskId}")]
    ITask<GetV2EsignApprovalsTaskIdResponse> GetV2EsignApprovalsTaskIdAsync(
        [PathQuery] string taskId,
        [Header("serviceGroup")] string? serviceGroup = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取流程详细信息及操作记录
    /// </summary>
    [HttpGet("/v2.0/esign/flowTasks/{taskId}")]
    ITask<GetV2EsignFlowTasksTaskIdResponse> GetV2EsignFlowTasksTaskIdAsync(
        [PathQuery] string taskId,
        [Header("serviceGroup")] string? serviceGroup = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取流程任务的所有合同列表
    /// </summary>
    [HttpGet("/v2.0/esign/flowTasks/{taskId}/docs")]
    ITask<GetV2EsignFlowTasksTaskIdDocsResponse> GetV2EsignFlowTasksTaskIdDocsAsync(
        [PathQuery] string taskId,
        [Header("serviceGroup")] string? serviceGroup = null,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );
}
