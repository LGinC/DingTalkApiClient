using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models;
using DingTalkApiClient.Models.Ecosystem;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.Ecosystem;

/// <summary>
/// 生态开放 TOP API。
/// </summary>
public interface IEcosystemTopApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 钉钉文本翻译
    /// </summary>
    [HttpPost("/topapi/ai/mt/translate")]
    ITask<PostTopapiAiMtTranslateResponse> PostTopapiAiMtTranslateAsync(
        [JsonContent] PostTopapiAiMtTranslateRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// OCR文字识别
    /// </summary>
    [HttpPost("/topapi/ocr/structured/recognize")]
    ITask<PostTopapiOcrStructuredRecognizeResponse> PostTopapiOcrStructuredRecognizeAsync(
        [JsonContent] PostTopapiOcrStructuredRecognizeRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// ASR 一句话语音识别
    /// </summary>
    [HttpPost("/topapi/asr/voice/translate")]
    ITask<PostTopapiAsrVoiceTranslateResponse> PostTopapiAsrVoiceTranslateAsync(
        [JsonContent] PostTopapiAsrVoiceTranslateRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 使用服务助手推送消息
    /// </summary>
    [HttpPost("/topapi/smartbot/msg/push")]
    ITask<PostTopapiSmartbotMsgPushResponse> PostTopapiSmartbotMsgPushAsync(
        [JsonContent] PostTopapiSmartbotMsgPushRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 机票城市搜索
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/flight/city/suggest")]
    ITask<PostTopapiAliTripBTripFlightCitySuggestResponse> PostTopapiAliTripBTripFlightCitySuggestAsync(
        [JsonContent] PostTopapiAliTripBTripFlightCitySuggestRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 火车票城市搜索
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/train/city/suggest")]
    ITask<PostTopapiAliTripBTripTrainCitySuggestResponse> PostTopapiAliTripBTripTrainCitySuggestAsync(
        [JsonContent] PostTopapiAliTripBTripTrainCitySuggestRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 新建成本中心
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/cost/center/new")]
    ITask<PostTopapiAliTripBTripCostCenterNewResponse> PostTopapiAliTripBTripCostCenterNewAsync(
        [JsonContent] PostTopapiAliTripBTripCostCenterNewRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 修改成本中心
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/cost/center/modify")]
    ITask<PostTopapiAliTripBTripCostCenterModifyResponse> PostTopapiAliTripBTripCostCenterModifyAsync(
        [JsonContent] PostTopapiAliTripBTripCostCenterModifyRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 删除成本中心
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/cost/center/delete")]
    ITask<PostTopapiAliTripBTripCostCenterDeleteResponse> PostTopapiAliTripBTripCostCenterDeleteAsync(
        [JsonContent] PostTopapiAliTripBTripCostCenterDeleteRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 查询成本中心
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/cost/center/query")]
    ITask<PostTopapiAliTripBTripCostCenterQueryResponse> PostTopapiAliTripBTripCostCenterQueryAsync(
        [JsonContent] PostTopapiAliTripBTripCostCenterQueryRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 设置成本中心人员信息
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/cost/center/entity/set")]
    ITask<PostTopapiAliTripBTripCostCenterEntitySetResponse> PostTopapiAliTripBTripCostCenterEntitySetAsync(
        [JsonContent] PostTopapiAliTripBTripCostCenterEntitySetRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 删除成本中心人员信息
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/cost/center/entity/delete")]
    ITask<PostTopapiAliTripBTripCostCenterEntityDeleteResponse> PostTopapiAliTripBTripCostCenterEntityDeleteAsync(
        [JsonContent] PostTopapiAliTripBTripCostCenterEntityDeleteRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 商旅成本中心转换为外部成本中心
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/cost/center/transfer")]
    ITask<PostTopapiAliTripBTripCostCenterTransferResponse> PostTopapiAliTripBTripCostCenterTransferAsync(
        [JsonContent] PostTopapiAliTripBTripCostCenterTransferRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 添加项目
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/project/add")]
    ITask<PostTopapiAliTripBTripProjectAddResponse> PostTopapiAliTripBTripProjectAddAsync(
        [JsonContent] PostTopapiAliTripBTripProjectAddRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 修改项目
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/project/modify")]
    ITask<PostTopapiAliTripBTripProjectModifyResponse> PostTopapiAliTripBTripProjectModifyAsync(
        [JsonContent] PostTopapiAliTripBTripProjectModifyRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 删除项目
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/project/delete")]
    ITask<PostTopapiAliTripBTripProjectDeleteResponse> PostTopapiAliTripBTripProjectDeleteAsync(
        [JsonContent] PostTopapiAliTripBTripProjectDeleteRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 新建审批单
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/approval/new")]
    ITask<PostTopapiAliTripBTripApprovalNewResponse> PostTopapiAliTripBTripApprovalNewAsync(
        [JsonContent] PostTopapiAliTripBTripApprovalNewRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取申请单列表
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/apply/search")]
    ITask<PostTopapiAliTripBTripApplySearchResponse> PostTopapiAliTripBTripApplySearchAsync(
        [JsonContent] PostTopapiAliTripBTripApplySearchRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取申请单详情
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/apply/get")]
    ITask<PostTopapiAliTripBTripApplyGetResponse> PostTopapiAliTripBTripApplyGetAsync(
        [JsonContent] PostTopapiAliTripBTripApplyGetRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 修改申请单
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/approval/modify")]
    ITask<PostTopapiAliTripBTripApprovalModifyResponse> PostTopapiAliTripBTripApprovalModifyAsync(
        [JsonContent] PostTopapiAliTripBTripApprovalModifyRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 更新申请单状态
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/approval/update")]
    ITask<PostTopapiAliTripBTripApprovalUpdateResponse> PostTopapiAliTripBTripApprovalUpdateAsync(
        [JsonContent] PostTopapiAliTripBTripApprovalUpdateRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取企业机票订单数据
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/flight/order/search")]
    ITask<PostTopapiAliTripBTripFlightOrderSearchResponse> PostTopapiAliTripBTripFlightOrderSearchAsync(
        [JsonContent] PostTopapiAliTripBTripFlightOrderSearchRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取企业商旅酒店订单数据
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/hotel/order/search")]
    ITask<PostTopapiAliTripBTripHotelOrderSearchResponse> PostTopapiAliTripBTripHotelOrderSearchAsync(
        [JsonContent] PostTopapiAliTripBTripHotelOrderSearchRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取企业火车票订单数据
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/train/order/search")]
    ITask<PostTopapiAliTripBTripTrainOrderSearchResponse> PostTopapiAliTripBTripTrainOrderSearchAsync(
        [JsonContent] PostTopapiAliTripBTripTrainOrderSearchRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取用车订单数据
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/vehicle/order/search")]
    ITask<PostTopapiAliTripBTripVehicleOrderSearchResponse> PostTopapiAliTripBTripVehicleOrderSearchAsync(
        [JsonContent] PostTopapiAliTripBTripVehicleOrderSearchRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取商旅访问地址
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/address/get")]
    ITask<PostTopapiAliTripBTripAddressGetResponse> PostTopapiAliTripBTripAddressGetAsync(
        [JsonContent] PostTopapiAliTripBTripAddressGetRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 新增发票配置
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/invoice/setting/add")]
    ITask<PostTopapiAliTripBTripInvoiceSettingAddResponse> PostTopapiAliTripBTripInvoiceSettingAddAsync(
        [JsonContent] PostTopapiAliTripBTripInvoiceSettingAddRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 配置发票适用人群
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/invoice/setting/rule")]
    ITask<PostTopapiAliTripBTripInvoiceSettingRuleResponse> PostTopapiAliTripBTripInvoiceSettingRuleAsync(
        [JsonContent] PostTopapiAliTripBTripInvoiceSettingRuleRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 查询可用发票列表
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/invoice/search")]
    ITask<PostTopapiAliTripBTripInvoiceSearchResponse> PostTopapiAliTripBTripInvoiceSearchAsync(
        [JsonContent] PostTopapiAliTripBTripInvoiceSearchRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 修改发票配置
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/invoice/setting/modify")]
    ITask<PostTopapiAliTripBTripInvoiceSettingModifyResponse> PostTopapiAliTripBTripInvoiceSettingModifyAsync(
        [JsonContent] PostTopapiAliTripBTripInvoiceSettingModifyRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 删除发票信息
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/invoice/setting/delete")]
    ITask<PostTopapiAliTripBTripInvoiceSettingDeleteResponse> PostTopapiAliTripBTripInvoiceSettingDeleteAsync(
        [JsonContent] PostTopapiAliTripBTripInvoiceSettingDeleteRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 获取月对账结算数据
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/monthbill/url/get")]
    ITask<PostTopapiAliTripBTripMonthbillUrlGetResponse> PostTopapiAliTripBTripMonthbillUrlGetAsync(
        [JsonContent] PostTopapiAliTripBTripMonthbillUrlGetRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// 查询预估价
    /// </summary>
    [HttpPost("/topapi/alitrip/btrip/price/query")]
    ITask<PostTopapiAliTripBTripPriceQueryResponse> PostTopapiAliTripBTripPriceQueryAsync(
        [JsonContent] PostTopapiAliTripBTripPriceQueryRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default
    );
}
