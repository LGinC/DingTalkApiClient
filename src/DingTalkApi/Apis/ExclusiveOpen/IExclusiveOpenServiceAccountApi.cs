using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.ExclusiveOpen;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.ExclusiveOpen;

/// <summary>
/// 专属开放服务号api
/// </summary>
public interface IExclusiveOpenServiceAccountApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 新增服务号
    /// </summary>
    [HttpPost("/topapi/serviceaccount/add")]
    ITask<ServiceAccountAddResponse> ServiceAccountAddAsync([JsonContent] ServiceAccountAddRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新服务号
    /// </summary>
    [HttpPost("/topapi/serviceaccount/update")]
    ITask<ServiceAccountUpdateResponse> ServiceAccountUpdateAsync([JsonContent] ServiceAccountUpdateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询服务号列表
    /// </summary>
    [HttpPost("/topapi/serviceaccount/list")]
    ITask<ServiceAccountListResponse> ServiceAccountListAsync([JsonContent] ServiceAccountListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询服务号详情
    /// </summary>
    [HttpPost("/topapi/serviceaccount/get")]
    ITask<ServiceAccountGetResponse> ServiceAccountGetAsync([JsonContent] ServiceAccountGetRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 新增文章
    /// </summary>
    [HttpPost("/topapi/material/article/add")]
    ITask<MaterialArticleAddResponse> MaterialArticleAddAsync([JsonContent] MaterialArticleAddRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除文章
    /// </summary>
    [HttpPost("/topapi/material/article/delete")]
    ITask<MaterialArticleDeleteResponse> MaterialArticleDeleteAsync([JsonContent] MaterialArticleDeleteRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新文章
    /// </summary>
    [HttpPost("/topapi/material/article/update")]
    ITask<MaterialArticleUpdateResponse> MaterialArticleUpdateAsync([JsonContent] MaterialArticleUpdateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询文章列表
    /// </summary>
    [HttpPost("/topapi/material/article/list")]
    ITask<MaterialArticleListResponse> MaterialArticleListAsync([JsonContent] MaterialArticleListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取文章详情
    /// </summary>
    [HttpPost("/topapi/material/article/get")]
    ITask<MaterialArticleGetResponse> MaterialArticleGetAsync([JsonContent] MaterialArticleGetRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 发布文章
    /// </summary>
    [HttpPost("/topapi/material/article/publish")]
    ITask<MaterialArticlePublishResponse> MaterialArticlePublishAsync([JsonContent] MaterialArticlePublishRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 新增图文卡片
    /// </summary>
    [HttpPost("/topapi/material/news/add")]
    ITask<MaterialNewsAddResponse> MaterialNewsAddAsync([JsonContent] MaterialNewsAddRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除图文卡片
    /// </summary>
    [HttpPost("/topapi/material/news/delete")]
    ITask<MaterialNewsDeleteResponse> MaterialNewsDeleteAsync([JsonContent] MaterialNewsDeleteRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取图文卡片详情
    /// </summary>
    [HttpPost("/topapi/material/news/get")]
    ITask<MaterialNewsGetResponse> MaterialNewsGetAsync([JsonContent] MaterialNewsGetRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新图文卡片
    /// </summary>
    [HttpPost("/topapi/material/news/update")]
    ITask<MaterialNewsUpdateResponse> MaterialNewsUpdateAsync([JsonContent] MaterialNewsUpdateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询图文卡片列表
    /// </summary>
    [HttpPost("/topapi/material/news/list")]
    ITask<MaterialNewsListResponse> MaterialNewsListAsync([JsonContent] MaterialNewsListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 消息撤回
    /// </summary>
    [HttpPost("/topapi/message/mass/recall")]
    ITask<MessageMassRecallResponse> MessageMassRecallAsync([JsonContent] MessageMassRecallRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 消息群发
    /// </summary>
    [HttpPost("/topapi/message/mass/send")]
    ITask<MessageMassSendResponse> MessageMassSendAsync([JsonContent] MessageMassSendRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 服务号菜单更新
    /// </summary>
    [HttpPost("/topapi/serviceaccount/menu/update")]
    ITask<ServiceAccountMenuUpdateResponse> ServiceAccountMenuUpdateAsync([JsonContent] ServiceAccountMenuUpdateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询服务号菜单
    /// </summary>
    [HttpPost("/topapi/serviceaccount/menu/get")]
    ITask<ServiceAccountMenuGetResponse> ServiceAccountMenuGetAsync([JsonContent] ServiceAccountMenuGetRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
