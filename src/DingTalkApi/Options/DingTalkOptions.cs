namespace DingTalkApi.Options;

/// <summary>
/// 钉钉客户端公共配置
/// </summary>
public sealed class DingTalkOptions
{
    /// <summary>
    /// 是否启用 WebApiClientCore 非 200 响应请求日志
    /// </summary>
    public bool EnableLogging { get; set; }
}
