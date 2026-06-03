using WebApiClientCore;
using WebApiClientCore.Attributes;
using WebApiClientCore.Extensions.OAuths;
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
namespace DingTalkApi.Attributes
{
    /// <summary>
    /// 钉钉服务端api 设置accessToken请求头
    /// </summary>
    public class DingTalkHeaderTokenAttribute : OAuthTokenAttribute
    {
        public DingTalkHeaderTokenAttribute() : base(DingTalkTokenProviderAttribute.ParameterName)
        {
            TokenProviderSearchMode = TypeMatchMode.TypeOrBaseTypes;
        }

        protected override void UseTokenResult(ApiRequestContext context, TokenResult tokenResult)
        {
            context.HttpContext.RequestMessage.Headers.TryAddWithoutValidation("x-acs-dingtalk-access-token", tokenResult.Access_token);
        }
    }

    public class DingTalkQueryTokenAttribute : OAuthTokenAttribute
    {
        public DingTalkQueryTokenAttribute() : base(DingTalkTokenProviderAttribute.ParameterName)
        {
            TokenProviderSearchMode = TypeMatchMode.TypeOrBaseTypes;
        }

        protected override void UseTokenResult(ApiRequestContext context, TokenResult tokenResult)
        {
            context.HttpContext.RequestMessage.AddUrlQuery("access_token", tokenResult.Access_token);
        }
    }

    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class DingTalkTokenProviderAttribute : ApiParameterAttribute
    {
        public const string ParameterName = "tokenProviderName";

        public override Task OnRequestAsync(ApiParameterContext context)
        {
            return Task.CompletedTask;
        }
    }
}
