using DingTalkApi.Attributes;
using WebApiClientCore.Attributes;
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
namespace DingTalkApi.Apis
{
    [HttpHost("https://api.dingtalk.com")]
    [Non200LoggingFilter(LogRequest = true, LogResponse = true)]
    public interface IDingTalkApi
    {

    }

    [DingTalkHeaderToken]
    public interface IDingTalkHeaderTokenApi : IDingTalkApi;

    [DingTalkQueryToken]
    [HttpHost("https://oapi.dingtalk.com")]
    public interface IDingTalkQueryTokenApi : IDingTalkApi;
}
