using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.Yida;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.Yida;

/// <summary>
/// 宜搭应用开发api
/// </summary>
public interface IYidaApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 发起宜搭审批流程
    /// </summary>
    [HttpPost("/v1.0/yida/processes/instances/start")]
    ITask<YidaStartProcessInstanceResponse> StartProcessInstanceAsync([JsonContent] YidaStartProcessInstanceRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除流程实例
    /// </summary>
    [HttpDelete("/v1.0/yida/processes/instances")]
    ITask<DingTalkResult> DeleteProcessInstanceAsync(string appType, string systemToken, string userId, string processInstanceId, string? language = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取流程实例
    /// </summary>
    [HttpPost("/v1.0/yida/processes/instances")]
    ITask<YidaProcessInstancePageResponse> SearchProcessInstancesAsync([JsonContent] YidaSearchProcessInstancesRequest request, string? pageNumber = null, string? pageSize = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 终止流程实例
    /// </summary>
    [HttpPut("/v1.0/yida/processes/instances/terminate")]
    ITask<DingTalkResult> TerminateProcessInstanceAsync(string appType, string systemToken, string userId, string processInstanceId, string? language = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取实例ID列表
    /// </summary>
    [HttpPost("/v1.0/yida/processes/instanceIds")]
    ITask<YidaStringPageResponse> QueryProcessInstanceIdsAsync([JsonContent] YidaQueryProcessInstanceIdsRequest request, string? pageSize = null, string? pageNumber = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量获取流程实例列表
    /// </summary>
    [HttpGet("/v1.0/yida/processes/instances/searchWithIds")]
    ITask<YidaProcessInstancesResultResponse> GetProcessInstancesByIdsAsync(string appType, string systemToken, string userId, string processInstanceIds, string? language = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 根据流程实例ID获取流程实例
    /// </summary>
    [HttpGet("/v1.0/yida/processes/instancesInfos/{id}")]
    ITask<YidaProcessInstanceInfo> GetProcessInstanceInfoAsync([PathQuery] string id, string appType, string systemToken, string userId, string? language = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取指定应用下的表单列表
    /// </summary>
    [HttpGet("/v1.0/yida/forms")]
    ITask<YidaFormsResponse> GetFormsAsync(string appType, string systemToken, string userId, string? formTypes = null, string? pageSize = null, string? pageNumber = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取表单内的组件信息
    /// </summary>
    [HttpGet("/v1.0/yida/forms/formFields")]
    ITask<YidaFormFieldsResponse> GetFormFieldsAsync(string appType, string systemToken, string userId, string? formUuid = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询表单实例数据
    /// </summary>
    [HttpPost("/v1.0/yida/forms/instances/search")]
    ITask<YidaFormInstancePageResponse> SearchFormInstancesAsync([JsonContent] YidaSearchFormInstancesRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 保存表单数据
    /// </summary>
    [HttpPost("/v1.0/yida/forms/instances")]
    ITask<YidaSaveFormInstanceResponse> SaveFormInstanceAsync([JsonContent] YidaSaveFormInstanceRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新表单数据
    /// </summary>
    [HttpPut("/v1.0/yida/forms/instances")]
    ITask<DingTalkResult> UpdateFormInstanceAsync([JsonContent] YidaUpdateFormInstanceRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除表单数据
    /// </summary>
    [HttpDelete("/v1.0/yida/forms/instances")]
    ITask<DingTalkResult> DeleteFormInstanceAsync(string appType, string systemToken, string userId, string formInstanceId, string? language = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询表单数据
    /// </summary>
    [HttpGet("/v1.0/yida/forms/instances/{id}")]
    ITask<YidaFormInstanceDetail> GetFormInstanceAsync([PathQuery] string id, string? appType = null, string? systemToken = null, string? userId = null, string? language = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取员工组件的值
    /// </summary>
    [HttpPost("/v1.0/yida/forms/employeeFields")]
    ITask<YidaEmployeeFieldsResponse> GetEmployeeFieldsAsync([JsonContent] YidaEmployeeFieldsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取表单组件定义列表
    /// </summary>
    [HttpGet("/v1.0/yida/forms/definitions/{appType}/{formUuid}")]
    ITask<YidaFormDefinitionsResponse> GetFormDefinitionsAsync([PathQuery] string appType, [PathQuery] string formUuid, string systemToken, string userId, string? language = null, string? version = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取子表组件数据
    /// </summary>
    [HttpGet("/v1.0/yida/forms/innerTables/{formInstanceId}")]
    ITask<YidaFormInstancePageResponse> GetInnerTableDataAsync([PathQuery] string formInstanceId, string formUuid, string tableFieldId, string systemToken, string userId, string appType, string? pageNumber = null, string? pageSize = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取多个表单实例ID
    /// </summary>
    [HttpPost("/v1.0/yida/forms/instances/ids/{appType}/{formUuid}")]
    ITask<YidaStringPageResponse> QueryFormInstanceIdsAsync([PathQuery] string appType, [PathQuery] string formUuid, [JsonContent] YidaQueryFormInstanceIdsRequest request, string? pageNumber = null, string? pageSize = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量获取表单实例数据
    /// </summary>
    [HttpPost("/v1.0/yida/forms/instances/ids/query")]
    ITask<YidaFormInstancesResultResponse> BatchGetFormInstancesAsync([JsonContent] YidaBatchFormInstanceRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量删除表单实例
    /// </summary>
    [HttpPost("/v1.0/yida/forms/instances/batchRemove")]
    ITask<DingTalkResult> BatchRemoveFormInstancesAsync([JsonContent] YidaBatchFormInstanceRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量创建表单实例
    /// </summary>
    [HttpPost("/v1.0/yida/forms/instances/batchSave")]
    ITask<YidaBatchSaveFormInstancesResponse> BatchSaveFormInstancesAsync([JsonContent] YidaBatchSaveFormInstancesRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量更新表单实例内的组件值
    /// </summary>
    [HttpPut("/v1.0/yida/forms/instances/components")]
    ITask<YidaBatchUpdateComponentsResponse> BatchUpdateFormInstanceComponentsAsync([JsonContent] YidaBatchUpdateComponentsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 新增或更新表单实例
    /// </summary>
    [HttpPost("/v1.0/yida/forms/instances/insertOrUpdate")]
    ITask<YidaSaveFormInstanceResponse> InsertOrUpdateFormInstanceAsync([JsonContent] YidaInsertOrUpdateFormInstanceRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 通过高级查询条件获取表单实例数据（包括子表单组件数据）新版SDK
    /// </summary>
    [HttpPost("/v1.0/yida/forms/instances/advances/queryAll")]
    ITask<YidaFormInstancePageResponse> QueryAllAdvancedFormInstancesAsync([JsonContent] YidaAdvancedQueryFormInstancesRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 通过高级查询条件获取表单实例数据（不包括子表单组件数据）
    /// </summary>
    [HttpPost("/v1.0/yida/forms/instances/advances/query")]
    ITask<YidaFormInstancePageResponse> QueryAdvancedFormInstancesAsync([JsonContent] YidaAdvancedQueryFormInstancesRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 通过表单实例数据批量更新表单实例
    /// </summary>
    [HttpPut("/v1.0/yida/forms/instances/datas")]
    ITask<YidaBatchUpdateFormDataResponse> BatchUpdateFormInstanceDataAsync([JsonContent] YidaBatchUpdateFormDataRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询表单的变更记录
    /// </summary>
    [HttpPost("/v1.0/yida/forms/operationsLogs/query")]
    ITask<YidaOperationLogsResponse> QueryOperationLogsAsync([JsonContent] YidaOperationLogsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取审批记录
    /// </summary>
    [HttpGet("/v1.0/yida/processes/operationRecords")]
    ITask<YidaProcessOperationRecordsResponse> GetProcessOperationRecordsAsync(string appType, string systemToken, string userId, string processInstanceId, string? language = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 同意或拒绝宜搭审批任务
    /// </summary>
    [HttpPost("/v1.0/yida/tasks/execute")]
    ITask<DingTalkResult> ExecuteTaskAsync([JsonContent] YidaExecuteTaskRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取组织内某人提交的任务
    /// </summary>
    [HttpGet("/v1.0/yida/tasks/myCorpSubmission/{userId}")]
    ITask<YidaTaskPageResponse> GetMyCorpSubmissionsAsync([PathQuery] string userId, string corpId, string token, string? pageSize = null, string? language = null, string? pageNumber = null, string? keyword = null, string? appTypes = null, string? processCodes = null, string? createFromTimeGMT = null, string? createToTimeGMT = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取组织内已完成的审批任务
    /// </summary>
    [HttpGet("/v1.0/yida/tasks/completedTasks/{corpId}/{userId}")]
    ITask<YidaTaskPageResponse> GetCompletedTasksAsync([PathQuery] string corpId, [PathQuery] string userId, string token, string? pageSize = null, string? language = null, string? pageNumber = null, string? keyword = null, string? appTypes = null, string? processCodes = null, string? createFromTimeGMT = null, string? createToTimeGMT = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 转交任务
    /// </summary>
    [HttpPost("/v1.0/yida/tasks/redirect")]
    ITask<DingTalkResult> RedirectTaskAsync([JsonContent] YidaRedirectTaskRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询流程运行任务（VPC）
    /// </summary>
    [HttpGet("/v1.0/yida/processes/tasks/getRunningTasks")]
    ITask<YidaRunningTasksResponse> GetRunningTasksAsync(string? processInstanceId = null, string? appType = null, string? systemToken = null, string? language = null, string? userId = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取任务列表（组织维度）
    /// </summary>
    [HttpGet("/v1.0/yida/corpTasks")]
    ITask<YidaTaskPageResponse> GetCorpTasksAsync(string corpId, string userId, string token, string? pageSize = null, string? language = null, string? pageNumber = null, string? keyword = null, string? appTypes = null, string? processCodes = null, string? createFromTimeGMT = null, string? createToTimeGMT = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取发送给用户的通知
    /// </summary>
    [HttpGet("/v1.0/yida/corpNotifications/{userId}")]
    ITask<YidaTaskPageResponse> GetCorpNotificationsAsync([PathQuery] string userId, string corpId, string token, string? pageNumber = null, string? pageSize = null, string? language = null, string? keyword = null, string? appTypes = null, string? processCodes = null, string? instanceCreateFromTimeGMT = null, string? instanceCreateToTimeGMT = null, string? createFromTimeGMT = null, string? createToTimeGMT = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询抄送我的任务列表（应用维度）
    /// </summary>
    [HttpGet("/v1.0/yida/tasks/taskCopies")]
    ITask<YidaTaskPageResponse> GetTaskCopiesAsync(string appType, string systemToken, string userId, string? pageSize = null, string? language = null, string? pageNumber = null, string? keyword = null, string? processCodes = null, string? createFromTimeGMT = null, string? createToTimeGMT = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量执行宜搭审批任务
    /// </summary>
    [HttpPost("/v1.0/yida/tasks/batches/execute")]
    ITask<YidaBatchExecuteTasksResponse> BatchExecuteTasksAsync([JsonContent] YidaBatchExecuteTasksRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 提交评论
    /// </summary>
    [HttpPost("/v1.0/yida/forms/remarks")]
    ITask<YidaSubmitRemarkResponse> SubmitRemarkAsync([JsonContent] YidaSubmitRemarkRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量查询宜搭表单实例的评论
    /// </summary>
    [HttpPost("/v1.0/yida/forms/remarks/query")]
    ITask<YidaRemarksResponse> QueryRemarksAsync([JsonContent] YidaRemarksRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取宜搭附件临时免登地址
    /// </summary>
    [HttpGet("/v1.0/yida/apps/temporaryUrls/{appType}")]
    ITask<YidaTemporaryUrlResponse> GetTemporaryUrlAsync([PathQuery] string appType, string systemToken, string userId, string fileUrl, string? language = null, string? timeout = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询宜搭应用列表
    /// </summary>
    [HttpGet("/v1.0/yida/organizations/applications")]
    ITask<YidaApplicationsResponse> GetApplicationsAsync(string corpId, string userId, string token, string? appFilter = null, string? pageNumber = null, string? pageSize = null, string? appNameSearchKeyword = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询宜搭表单服务调用执行记录
    /// </summary>
    [HttpGet("/v1.0/yida/services/invocationRecords")]
    ITask<YidaServiceInvocationRecordsResponse> GetServiceInvocationRecordsAsync(string userId, string instanceId, string appType, string? hookType = null, string? systemToken = null, string? hookUuid = null, string? sourceUuid = null, string? requestUrl = null, bool? success = null, string? pageNumber = null, string? invokeAfterDateGMT = null, int? pageSize = null, string? invokeStatus = null, string? invokeBeforeDateGMT = null, string? formUuid = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
