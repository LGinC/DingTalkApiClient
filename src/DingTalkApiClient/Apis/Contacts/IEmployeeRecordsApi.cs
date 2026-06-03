using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models;
using DingTalkApiClient.Models.Contacts.EmployeeRecords;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Apis.Contacts;

/// <summary>
/// 员工记录api
/// </summary>
public interface IEmployeeRecordsApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 查询离职记录列表
    /// </summary>
    [HttpGet("/v1.0/contact/empLeaveRecords")]
    ITask<ContactEmpLeaveRecordsGetResponse> GetContactEmpLeaveRecordsAsync(string startTime, string? endTime, string? nextToken, string maxResults, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
