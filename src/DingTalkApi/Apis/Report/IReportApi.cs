using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.Report;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.Report;

/// <summary>
/// 日志api
/// </summary>
public interface IReportApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 创建日志
    /// </summary>
    [HttpPost("/topapi/report/create")]
    ITask<DingTalkResult<string>> CreateReportAsync([JsonContent] CreateReportRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 保存日志内容
    /// </summary>
    [HttpPost("/topapi/report/savecontent")]
    ITask<DingTalkResult<string>> SaveReportContentAsync([JsonContent] SaveReportContentRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取模板详情
    /// </summary>
    [HttpPost("/topapi/report/template/getbyname")]
    ITask<DingTalkResult<ReportTemplateDetail>> GetReportTemplateByNameAsync([JsonContent] GetReportTemplateByNameRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取用户发出的日志列表
    /// </summary>
    [HttpPost("/topapi/report/list")]
    ITask<DingTalkResult<ReportListResult>> ListReportsAsync([JsonContent] ListReportsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取用户发送日志的概要信息
    /// </summary>
    [HttpPost("/topapi/report/simplelist")]
    ITask<ReportSimpleListResponse> ListSimpleReportsAsync([JsonContent] ListSimpleReportsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取日志相关人员列表
    /// </summary>
    [HttpPost("/topapi/report/statistics/listbytype")]
    ITask<ReportUserIdListResponse> ListReportUsersByTypeAsync([JsonContent] ListReportUsersByTypeRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取日志接收人员列表
    /// </summary>
    [HttpPost("/topapi/report/receiver/list")]
    ITask<ReportUserIdListResponse> ListReportReceiversAsync([JsonContent] ListReportReceiversRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取日志评论详情
    /// </summary>
    [HttpPost("/topapi/report/comment/list")]
    ITask<ReportCommentListResponse> ListReportCommentsAsync([JsonContent] ListReportCommentsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取用户日志未读数
    /// </summary>
    [HttpPost("/topapi/report/getunreadcount")]
    ITask<ReportUnreadCountResponse> GetReportUnreadCountAsync([JsonContent] GetReportUnreadCountRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取用户可见的日志模板
    /// </summary>
    [HttpPost("/topapi/report/template/listbyuserid")]
    ITask<ReportTemplateListResponse> ListReportTemplatesByUserIdAsync([JsonContent] ListReportTemplatesByUserIdRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
