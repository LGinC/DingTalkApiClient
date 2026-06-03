using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models;

/// <summary>
/// 钉钉通用响应
/// </summary>
public class DingTalkResult
{
    /// <summary>
    /// 响应代码（供v2 API使用）
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// 错误代码
    /// </summary>
    [JsonPropertyName("errcode")]
    public int? ErrCode { get; set; }

    /// <summary>
    /// 错误信息
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? ErrMsg { get; set; }

    /// <summary>
    /// 信息
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// 请求id
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }

    /// <summary>
    /// 是否请求成功
    /// </summary>
    [JsonIgnore]
    public bool IsSuccess => (ErrCode is null && Code is null) || ErrCode == 0 || Code == "Success";
}

/// <summary>
/// 带错误原因的通用响应
/// </summary>
/// <param name="Code">返回码 200是正常</param>
/// <param name="Cause">原因，若为200则返回success，否则返回失败原因</param>
public record DingTalkCauseResult(long Code, string Cause);

/// <summary>
/// 钉钉通用响应
/// </summary>
/// <typeparam name="T"></typeparam>
public class DingTalkResult<T> : DingTalkResult
{
    /// <summary>
    /// 数据
    /// </summary>
    public T? Result { get; set; }
}
