using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.Workflow;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.Workflow;

/// <summary>
/// OA审批api
/// </summary>
public interface IWorkflowApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 创建或更新审批表单模板
    /// </summary>
    [HttpPost("/v1.0/workflow/forms")]
    ITask<WorkflowCreateOrUpdateFormResponse> CreateOrUpdateFormAsync([JsonContent] WorkflowCreateOrUpdateFormRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取表单 schema
    /// </summary>
    [HttpGet("/v1.0/workflow/forms/schemas/processCodes")]
    ITask<WorkflowFormSchemaResponse> GetFormSchemaAsync(string processCode, string? appUuid = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取审批单流程中的节点信息
    /// </summary>
    [HttpPost("/v1.0/workflow/processes/forecast")]
    ITask<WorkflowProcessForecastResponse> ForecastProcessAsync([JsonContent] WorkflowProcessForecastRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取指定用户可见的审批表单列表
    /// </summary>
    [HttpPost("/v1.0/workflow/processes/userVisibilities/templates")]
    ITask<WorkflowVisibleTemplatesResponse> GetUserVisibleTemplatesAsync(string maxResults, string nextToken, string? userId = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取当前企业所有可管理的表单
    /// </summary>
    [HttpGet("/v1.0/workflow/processes/managements/templates")]
    ITask<WorkflowManageableTemplatesResponse> GetManageableTemplatesAsync(string userId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 发起审批实例
    /// </summary>
    [HttpPost("/v1.0/workflow/processInstances")]
    ITask<WorkflowCreateProcessInstanceResponse> CreateProcessInstanceAsync([JsonContent] WorkflowCreateProcessInstanceRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取单个审批实例详情
    /// </summary>
    [HttpGet("/v1.0/workflow/processInstances")]
    ITask<WorkflowProcessInstanceResponse> GetProcessInstanceAsync(string? processInstanceId = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 撤销审批实例
    /// </summary>
    [HttpPost("/v1.0/workflow/processInstances/terminate")]
    ITask<WorkflowBooleanResultResponse> TerminateProcessInstanceAsync([JsonContent] WorkflowTerminateProcessInstanceRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 添加审批评论
    /// </summary>
    [HttpPost("/v1.0/workflow/processInstances/comments")]
    ITask<WorkflowBooleanResultResponse> AddProcessInstanceCommentAsync([JsonContent] WorkflowAddProcessInstanceCommentRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取审批实例ID列表
    /// </summary>
    [HttpPost("/v1.0/workflow/processes/instanceIds/query")]
    ITask<WorkflowProcessInstanceIdsResponse> QueryProcessInstanceIdsAsync([JsonContent] WorkflowProcessInstanceIdsQueryRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取审批钉盘空间信息
    /// </summary>
    [HttpPost("/v1.0/workflow/processInstances/spaces/infos/query")]
    ITask<WorkflowSpaceInfoResponse> QueryProcessInstanceSpaceInfoAsync([JsonContent] WorkflowSpaceInfoRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 授权预览审批附件
    /// </summary>
    [HttpPost("/v1.0/workflow/processInstances/spaces/authPreview")]
    ITask<WorkflowBooleanResultResponse> AuthorizeProcessInstanceFilePreviewAsync([JsonContent] WorkflowAuthorizeFilePreviewRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 授权下载审批钉盘文件
    /// </summary>
    [HttpPost("/v1.0/workflow/processInstances/spaces/files/authDownload")]
    ITask<WorkflowBooleanResultResponse> AuthorizeProcessInstanceFileDownloadAsync([JsonContent] WorkflowAuthorizeFileDownloadRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 下载审批附件
    /// </summary>
    [HttpPost("/v1.0/workflow/processInstances/spaces/files/urls/download")]
    ITask<WorkflowDownloadFileUrlResponse> DownloadProcessInstanceFileUrlAsync([JsonContent] WorkflowDownloadFileUrlRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 同意或拒绝审批任务
    /// </summary>
    [HttpPost("/v1.0/workflow/processInstances/execute")]
    ITask<WorkflowBooleanResultResponse> ExecuteProcessInstanceTaskAsync([JsonContent] WorkflowExecuteProcessInstanceTaskRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 转交OA审批任务
    /// </summary>
    [HttpPost("/v1.0/workflow/tasks/redirect")]
    ITask<WorkflowBooleanResultResponse> RedirectTaskAsync([JsonContent] WorkflowRedirectTaskRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取用户待审批数量
    /// </summary>
    [HttpGet("/v1.0/workflow/processes/todoTasks/numbers")]
    ITask<WorkflowTodoTaskNumberResponse> GetTodoTaskNumberAsync(string userId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建或更新审批模板
    /// </summary>
    [HttpPost("/v1.0/workflow/processCentres/schemas")]
    ITask<WorkflowCreateOrUpdateProcessCentreSchemaResponse> CreateOrUpdateProcessCentreSchemaAsync([JsonContent] WorkflowCreateOrUpdateProcessCentreSchemaRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除模板
    /// </summary>
    [HttpDelete("/v1.0/workflow/processCentres/schemas")]
    ITask<WorkflowBooleanResultResponse> DeleteProcessCentreSchemaAsync(string processCode, string? cleanRunningTask = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取模板code
    /// </summary>
    [HttpGet("/v1.0/workflow/processCentres/schemaNames/processCodes")]
    ITask<WorkflowProcessCentreSchemaCodeResponse> GetProcessCentreSchemaCodeAsync(string name, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建实例
    /// </summary>
    [HttpPost("/v1.0/workflow/processCentres/instances")]
    ITask<WorkflowCreateProcessCentreInstanceResponse> CreateProcessCentreInstanceAsync([JsonContent] WorkflowCreateProcessCentreInstanceRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新实例状态
    /// </summary>
    [HttpPut("/v1.0/workflow/processCentres/instances")]
    ITask<WorkflowSuccessResponse> UpdateProcessCentreInstanceAsync([JsonContent] WorkflowUpdateProcessCentreInstanceRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量更新实例状态
    /// </summary>
    [HttpPut("/v1.0/workflow/processCentres/instances/batch")]
    ITask<WorkflowSuccessResponse> BatchUpdateProcessCentreInstancesAsync([JsonContent] WorkflowBatchUpdateProcessCentreInstancesRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建流程中心待处理任务
    /// </summary>
    [HttpPost("/v1.0/workflow/processCentres/tasks")]
    ITask<WorkflowCreateProcessCentreTaskResponse> CreateProcessCentreTasksAsync([JsonContent] WorkflowCreateProcessCentreTaskRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新流程中心任务状态
    /// </summary>
    [HttpPut("/v1.0/workflow/processCentres/tasks")]
    ITask<WorkflowSuccessResponse> UpdateProcessCentreTasksAsync([JsonContent] WorkflowUpdateProcessCentreTaskRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询通过流程中心集成的OA审批任务
    /// </summary>
    [HttpGet("/v1.0/workflow/processCentres/todoTasks")]
    ITask<WorkflowProcessCentreTodoTasksResponse> QueryProcessCentreTodoTasksAsync(string userId, string pageSize, string pageNumber, string? createBefore = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量取消流程中心待处理任务
    /// </summary>
    [HttpPost("/v1.0/workflow/processCentres/tasks/cancel")]
    ITask<WorkflowSuccessResponse> CancelProcessCentreTasksAsync([JsonContent] WorkflowCancelProcessCentreTaskRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
