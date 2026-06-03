using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.Blackboard;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.Blackboard;

/// <summary>
/// 公告api
/// </summary>
public interface IBlackboardApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 创建公告
    /// </summary>
    [HttpPost("/topapi/blackboard/create")]
    ITask<BlackboardBooleanResponse> CreateBlackboardAsync([JsonContent] CreateBlackboardRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除公告
    /// </summary>
    [HttpPost("/topapi/blackboard/delete")]
    ITask<BlackboardBooleanResponse> DeleteBlackboardAsync([JsonContent] DeleteBlackboardRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新公告
    /// </summary>
    [HttpPost("/topapi/blackboard/update")]
    ITask<BlackboardBooleanResponse> UpdateBlackboardAsync([JsonContent] UpdateBlackboardRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取公告详情
    /// </summary>
    [HttpPost("/topapi/blackboard/get")]
    ITask<GetBlackboardResponse> GetBlackboardAsync([JsonContent] GetBlackboardRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取公告ID列表
    /// </summary>
    [HttpPost("/topapi/blackboard/listids")]
    ITask<BlackboardIdListResponse> ListBlackboardIdsAsync([JsonContent] ListBlackboardIdsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取公告分类列表
    /// </summary>
    [HttpPost("/topapi/blackboard/category/list")]
    ITask<BlackboardCategoryListResponse> ListBlackboardCategoriesAsync([JsonContent] ListBlackboardCategoriesRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取用户可查看的公告
    /// </summary>
    [HttpPost("/topapi/blackboard/listtopten")]
    ITask<ListTopTenBlackboardsResponse> ListTopTenBlackboardsAsync([JsonContent] ListTopTenBlackboardsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}

/// <summary>
/// 公告v1.0 api
/// </summary>
public interface IBlackboardV1Api : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 获取公告钉盘空间信息
    /// </summary>
    [HttpGet("/v1.0/blackboard/spaces")]
    ITask<BlackboardSpaceResponse> QueryBlackboardSpaceAsync(string operationUserId, [JsonContent] BlackboardSpaceRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
