using DingTalkApiClient.Attributes;
using WebApiClientCore.Attributes;
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
namespace DingTalkApiClient.Apis
{
    [HttpHost("https://api.dingtalk.com")]
    [Non200LoggingFilter(LogRequest = true, LogResponse = true)]
    public interface IDingTalkApiClient
    {

    }

    [DingTalkHeaderToken]
    public interface IDingTalkHeaderTokenApi : IDingTalkApiClient;

    [DingTalkQueryToken]
    [HttpHost("https://oapi.dingtalk.com")]
    public interface IDingTalkQueryTokenApi : IDingTalkApiClient;
}
