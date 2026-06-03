using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.SmartFill;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.SmartFill;

/// <summary>
/// 智能填表api
/// </summary>
public interface ISmartFillApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 获取用户创建的填表模板列表
    /// </summary>
    [HttpGet("/v1.0/swform/users/forms")]
    ITask<SmartFillFormSchemasResponse> ListFormSchemasByCreatorAsync(string maxResults, string nextToken, string? bizType = null, string? creator = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取填表实例列表
    /// </summary>
    [HttpGet("/v1.0/swform/forms/{formCode}/instances")]
    ITask<SmartFillFormInstancesResponse> ListFormInstancesAsync([PathQuery] string formCode, string nextToken, string maxResults, string? bizType = null, string? actionDate = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取单条填表实例详情
    /// </summary>
    [HttpGet("/v1.0/swform/instances/{formInstanceId}")]
    ITask<SmartFillFormInstanceResponse> GetFormInstanceAsync([PathQuery] string formInstanceId, string? bizType = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
