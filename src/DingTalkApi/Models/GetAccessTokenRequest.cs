namespace DingTalkApi.Models
{
    /// <summary>
    /// 获取企业内部应用访问令牌请求
    /// </summary>
    /// <param name="AppKey">内部应用的 Cilent ID</param>
    /// <param name="AppSecret">内部应用的 Cilent Secre</param>
    public record GetAccessTokenRequest(string AppKey, string AppSecret);

    /// <summary>
    /// 访问令牌信息
    /// </summary>
    /// <param name="AccessToken">访问令牌</param>
    /// <param name="ExpireIn">过期时间戳， 单位 秒</param>
    public record AccessTokenResult(string AccessToken, long ExpireIn);

    /// <summary>
    /// 用户访问令牌
    /// </summary>
    /// <param name="AccessToken">访问令牌</param>
    /// <param name="RefreshToken">刷新令牌</param>
    /// <param name="ExpireIn">过期时间 单位 秒</param>
    /// <param name="CropId">所选企业corpId</param>
    public record UserAccessTokenResult(string AccessToken, string RefreshToken, long ExpireIn, string CropId);

    /// <summary>
    /// 获取用户token
    /// </summary>
    public class GetUserAccessTokenRequest
    {
        /// <summary>
        /// 应用id
        /// </summary>
        public required string ClientId { get; set; }

        /// <summary>
        /// 应用密钥
        /// </summary>
        public required string ClientSecret { get; set; }

        /// <summary>
        /// OAuth 2.0 临时授权码
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// OAuth2.0刷新令牌，从返回结果里面获取。
        /// </summary>
        public string? RefreshToken { get; set; }

        /// <summary>
        /// 授权类型（如果使用授权码换token，传authorization_code   如果使用刷新token换用户token，传refresh_token）
        /// </summary>
        public string? GrantType { get; set; }
    }

    /// <summary>
    /// 获取定制应用的accessToken请求
    /// </summary>
    /// <param name="SuiteKey">定制应用的CustomKey</param>
    /// <param name="SuiteSecret">定制应用的CustomSecret</param>
    /// <param name="AuthCorpId">授权企业的CorpId</param>
    /// <param name="SuiteTicket">钉钉推送的suiteTicket，定制应用该参数自定义，比如Test</param>
    public record GetCorpAccessTokenRequest(string SuiteKey, string SuiteSecret, string AuthCorpId, string SuiteTicket);

    /// <summary>
    /// jsapi_ticket响应
    /// </summary>
    /// <param name="JsapiTicket"></param>
    /// <param name="ExpireIn"></param>
    public record JsApiTicketResult(string JsapiTicket, long ExpireIn);

    /// <summary>
    /// 获取微应用访问令牌请求
    /// </summary>
    /// <param name="Corpid">企业的corpId</param>
    /// <param name="SsoSecret">sso密钥，可以在开发者后台基本信息—开发信息（旧版）页面查看</param>
    public record GetSsoAccessTokenRequest(string Corpid, string SsoSecret);
}
