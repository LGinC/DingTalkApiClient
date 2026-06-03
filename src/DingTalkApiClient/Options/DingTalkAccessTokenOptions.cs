namespace DingTalkApiClient.Options
{
    /// <summary>
    /// 钉钉访问令牌选项
    /// </summary>
    public class DingTalkAccessTokenOptions
    {
        /// <summary>
        /// 应用Id 用于获取内部应用accessToken
        /// </summary>
        public string? ClientId { get; set; }

        /// <summary>
        /// 应用Secret 用于获取内部应用accessToken
        /// </summary>
        public string? ClientSecret { get; set; }

        /// <summary>
        /// 定制应用的CustomKey 用于获取定制应用accessToken
        /// </summary>
        public string? SuiteKey { get; set; }

        /// <summary>
        /// 定制应用的CustomSecret 用于获取定制应用accessToken
        /// </summary>
        public string? SuiteSecret { get; set; }

        /// <summary>
        /// 授权企业的CropId 用于获取定制应用accessToken
        /// </summary>
        public string? AuthCorpId { get; set; }

        /// <summary>
        /// 钉钉推送的suiteTicket 用于获取定制应用accessToken
        /// </summary>
        public string? SuiteTicket { get; set; }

        /// <summary>
        /// 企业的corpId 用于微应用的accessToken
        /// </summary>
        public string? CropId { get; set; }

        /// <summary>
        /// sso密钥，可以在开发者后台基本信息—开发信息（旧版）页面查看 用于微应用的accessToken
        /// </summary>
        public string? SsoSecret { get; set; }
    }
}
