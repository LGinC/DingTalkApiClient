using System.Text.Json.Serialization;
namespace DingTalkApi.Models.Contacts.EmployeeRecords;
#pragma warning disable CS8618
/// <summary>
/// 查询离职记录列表响应
/// </summary>
public class ContactEmpLeaveRecordsGetResponse
{
    /// <summary>
    /// 下一次请求的分页token。
    /// </summary>
    [JsonPropertyName("nextToken")]
    public required string NextToken { get; set; }

    /// <summary>
    /// 离职记录列表。
    /// </summary>
    [JsonPropertyName("records")]
    public List<ContactEmpLeaveRecordsGetResponseRecordsItem> Records { get; set; } = [];
}

/// <summary>
/// ContactEmpLeaveRecordsGetResponseRecordsItem
/// </summary>
public class ContactEmpLeaveRecordsGetResponseRecordsItem
{
    /// <summary>
    /// 员工的userId。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 员工名字。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 国际电话区号。
    /// </summary>
    [JsonPropertyName("stateCode")]
    public string? StateCode { get; set; }

    /// <summary>
    /// 手机号码。
    /// </summary>
    [JsonPropertyName("mobile")]
    public string? Mobile { get; set; }

    /// <summary>
    /// 离职时间。 格式：YYYY-MM-DDTHH:mm:ssZ（ISO 8601/RFC 3339）。
    /// </summary>
    [JsonPropertyName("leaveTime")]
    public string? LeaveTime { get; set; }

    /// <summary>
    /// 退出企业方式，取值： oapi：调用接口删除 cancel：注销 leave：主动离职 unknown：未知原因 delete：管理员删除
    /// </summary>
    [JsonPropertyName("leaveReason")]
    public string? LeaveReason { get; set; }
}
