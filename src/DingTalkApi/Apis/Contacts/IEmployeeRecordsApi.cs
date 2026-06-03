using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.Contacts.EmployeeRecords;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.Contacts;

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
