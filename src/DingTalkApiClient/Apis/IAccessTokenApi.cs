using DingTalkApiClient.Models;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis
{
    /// <summary>
    /// 访问令牌api
    /// </summary>
    [HttpHost("https://api.dingtalk.com")]
    [Attributes.Non200LoggingFilter(LogRequest = true, LogResponse = true)]
    public interface IAccessTokenApi : IHttpApi
    {
        /// <summary>
        /// 获取企业内部应用的accessToken
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("/v1.0/oauth2/accessToken")]
        public ITask<AccessTokenResult> GetAccessTokenAsync([JsonContent] GetAccessTokenRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// 获取用户token
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("/v1.0/oauth2/userAccessToken")]
        public ITask<UserAccessTokenResult> GetUserAccessTokenAsync([JsonContent] GetUserAccessTokenRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// 获取定制应用的accessToken
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellation"></param>
        /// <returns></returns>
        [HttpPost("/v1.0/oauth2/corpAccessToken")]
        public ITask<AccessTokenResult> GetCropAccessTokenAsync([JsonContent] GetCorpAccessTokenRequest request, CancellationToken cancellation = default);

        /// <summary>
        /// 获取jsapiTicket
        /// <para>当开发H5微应用时，需要先通过本接口获取jsapi_ticket，然后再生成鉴权签名，最后调用dd.config完成鉴权</para>
        /// </summary>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        [HttpPost("/v1.0/oauth2/jsapiTickets")]
        public ITask<JsApiTicketResult> GetJsApiTicketAsync([Header("x-acs-dingtalk-access-token")] string accessToken);

        /// <summary>
        /// 获取微应用后台免登的accessToken
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("/v1.0/oauth2/ssoAccessToken")]
        public ITask<AccessTokenResult> GetSsoAccessTokenAsync([JsonContent] GetSsoAccessTokenRequest request, CancellationToken cancellationToken = default);
    }
}
