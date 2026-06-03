using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.Card.CardInstances;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.Card;

/// <summary>
/// 互动卡片实例 API
/// </summary>
public interface ICardInstancesApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 创建卡片
    /// </summary>
    [HttpPost("/v1.0/card/instances")]
    ITask<CreateCardInstanceResponse> CreateCardAsync([JsonContent] CreateCardInstanceRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新卡片
    /// </summary>
    [HttpPut("/v1.0/card/instances")]
    ITask<CardBooleanResponse> UpdateCardAsync([JsonContent] UpdateCardInstanceRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 投放卡片
    /// </summary>
    [HttpPost("/v1.0/card/instances/deliver")]
    ITask<DeliverCardResponse> DeliverCardAsync([JsonContent] DeliverCardRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建并投放卡片
    /// </summary>
    [HttpPost("/v1.0/card/instances/createAndDeliver")]
    ITask<CreateAndDeliverCardResponse> CreateAndDeliverCardAsync([JsonContent] CreateAndDeliverCardRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 注册卡片回调地址
    /// </summary>
    [HttpPost("/v1.0/card/callbacks/register")]
    ITask<RegisterCardCallbackResponse> RegisterCardCallbackAsync([JsonContent] RegisterCardCallbackRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 新增或者更新卡片的场域信息
    /// </summary>
    [HttpPut("/v1.0/card/instances/spaces")]
    ITask<CardBooleanResponse> UpsertCardSpaceAsync([JsonContent] UpsertCardSpaceRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
