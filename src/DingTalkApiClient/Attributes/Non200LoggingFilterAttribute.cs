using System.Net;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Attributes;

/// <summary>
/// 仅在响应状态码非 200 或请求异常时记录请求/响应日志。
/// </summary>
public sealed class Non200LoggingFilterAttribute : LoggingFilterAttribute
{
    /// <summary>
    /// 仅保留非 200 响应的默认日志输出。
    /// </summary>
    /// <param name="context">响应上下文。</param>
    /// <param name="logMessage">日志内容。</param>
    /// <returns></returns>
    protected override Task WriteLogAsync(ApiResponseContext context, LogMessage logMessage)
    {
        if (context.HttpContext.ResponseMessage?.StatusCode == HttpStatusCode.OK)
        {
            return Task.CompletedTask;
        }

        return base.WriteLogAsync(context, logMessage);
    }
}
