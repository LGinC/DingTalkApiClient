using DingTalkApi.Attributes;
using DingTalkApi.Models.Teambition;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.Teambition;

/// <summary>
/// Teambition 项目管理 v1.0 api
/// </summary>
public interface ITeambitionProjectApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 创建项目
    /// </summary>
    [HttpPost("/v1.0/project/users/{userId}/projects")]
    ITask<TeambitionResult<TeambitionProject>> CreateProjectAsync([PathQuery] string userId, [JsonContent] TeambitionCreateProjectRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询项目
    /// </summary>
    [HttpPost("/v1.0/project/users/{userId}/projects/query")]
    ITask<TeambitionResult<TeambitionProject>> QueryProjectAsync([PathQuery] string userId, string? projectIds = null, string? name = null, string? maxResults = null, string? nextToken = null, string? sourceId = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 归档项目
    /// </summary>
    [HttpPost("/v1.0/project/users/{userId}/projects/{projectId}/suspend")]
    ITask<TeambitionResult<TeambitionUpdatedResult>> SuspendProjectAsync([PathQuery] string userId, [PathQuery] string projectId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 恢复项目归档
    /// </summary>
    [HttpPost("/v1.0/project/users/{userId}/projects/{projectId}/unsuspend")]
    ITask<TeambitionResult<TeambitionUpdatedResult>> UnsuspendProjectAsync([PathQuery] string userId, [PathQuery] string projectId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取项目成员
    /// </summary>
    [HttpGet("/v1.0/project/users/{userId}/projects/{projectId}/members")]
    ITask<TeambitionResult<List<TeambitionProjectMember>>> GetProjectMembersAsync([PathQuery] string userId, [PathQuery] string projectId, string? userIds = null, string? projectRoleId = null, string? maxResults = null, string? skip = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 添加项目成员
    /// </summary>
    [HttpPost("/v1.0/project/users/{userId}/projects/{projectId}/members")]
    ITask<TeambitionResult<List<TeambitionAddedProjectMember>>> AddProjectMembersAsync([PathQuery] string userId, [PathQuery] string projectId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询项目状态
    /// </summary>
    [HttpGet("/v1.0/project/users/{userId}/projects/{projectId}/statuses")]
    ITask<TeambitionResult<List<TeambitionProjectStatus>>> GetProjectStatusesAsync([PathQuery] string userId, [PathQuery] string projectId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除项目成员
    /// </summary>
    [HttpPost("/v1.0/project/users/{userId}/projects/{projectId}/members/remove")]
    ITask<TeambitionResult<List<string>>> RemoveProjectMembersAsync([PathQuery] string userId, [PathQuery] string projectId, [JsonContent] TeambitionRemoveProjectMembersRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 项目放入回收站
    /// </summary>
    [HttpPost("/v1.0/project/users/{userId}/projects/{projectId}/archive")]
    ITask<TeambitionResult<TeambitionArchiveResult>> ArchiveProjectAsync([PathQuery] string userId, [PathQuery] string projectId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取用户加入的项目
    /// </summary>
    [HttpGet("/v1.0/project/users/{userId}/joinProjects")]
    ITask<TeambitionPagedResult<List<string>>> GetJoinedProjectsAsync([PathQuery] string userId, string? maxResults = null, string? nextToken = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 搜索企业项目模板
    /// </summary>
    [HttpGet("/v1.0/project/organizations/users/{userId}/templates")]
    ITask<TeambitionResult<List<TeambitionProjectTemplate>>> SearchProjectTemplatesAsync([PathQuery] string userId, string? keyword = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 根据项目模板创建项目
    /// </summary>
    [HttpPost("/v1.0/project/users/{userId}/templates/projects")]
    ITask<TeambitionResult<TeambitionTemplateProject>> CreateProjectFromTemplateAsync([PathQuery] string userId, [JsonContent] TeambitionCreateProjectFromTemplateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询员工可见的项目分组
    /// </summary>
    [HttpGet("/v1.0/project/organizations/users/{userId}/groups")]
    ITask<TeambitionResult<List<TeambitionProjectGroup>>> GetVisibleProjectGroupsAsync([PathQuery] string userId, string? viewerId = null, string? pageSize = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新项目所在的分组
    /// </summary>
    [HttpGet("/v1.0/project/users/{userId}/projects/{projectId}/groups")]
    ITask<TeambitionResult<TeambitionOkResult>> UpdateProjectGroupsAsync([PathQuery] string userId, [PathQuery] string projectId, [JsonContent] TeambitionUpdateProjectGroupsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建或更新项目概览中自定义字段值
    /// </summary>
    [HttpPut("/v1.0/project/users/{userId}/projects/{projectId}/customfields")]
    ITask<TeambitionResult<TeambitionProjectCustomFieldResult>> UpsertProjectCustomFieldAsync([PathQuery] string userId, [PathQuery] string projectId, [JsonContent] TeambitionUpsertProjectCustomFieldRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建项目任务
    /// </summary>
    [HttpPost("/v1.0/project/users/{userId}/tasks")]
    ITask<TeambitionResult<TeambitionTask>> CreateTaskAsync([PathQuery] string userId, [JsonContent] TeambitionCreateTaskRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取任务详情
    /// </summary>
    [HttpGet("/v1.0/project/users/{userId}/tasks")]
    ITask<TeambitionResult<List<TeambitionTaskDetail>>> GetTasksAsync([PathQuery] string userId, string? taskId = null, string? parentTaskId = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除任务
    /// </summary>
    [HttpDelete("/v1.0/project/users/{userId}/tasks/{taskId}")]
    ITask<TeambitionResult<TeambitionDeleteResult>> DeleteTaskAsync([PathQuery] string userId, [PathQuery] string taskId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询任务分组
    /// </summary>
    [HttpGet("/v1.0/project/users/{userId}/projects/{projectId}/taskLists/search")]
    ITask<TeambitionPagedResult<List<TeambitionTaskList>>> SearchTaskListsAsync([PathQuery] string userId, [PathQuery] string projectId, string? query = null, string? maxResults = null, string? nextToken = null, string? taskListIds = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取任务列表
    /// </summary>
    [HttpPost("/v1.0/project/users/{userId}/projects/{projectId}/taskStages/search")]
    ITask<TeambitionPagedResult<List<TeambitionTaskStage>>> SearchTaskStagesAsync([PathQuery] string userId, [PathQuery] string projectId, string? taskListId = null, string? query = null, string? maxResults = null, string? nextToken = null, string? taskStageIds = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询任务工作流
    /// </summary>
    [HttpPost("/v1.0/project/users/{userId}/projects/{projectId}/taskflows/search")]
    ITask<TeambitionResult<List<TeambitionTaskflow>>> SearchTaskflowsAsync([PathQuery] string userId, [PathQuery] string projectId, string? query = null, string? maxResults = null, string? nextToken = null, string? taskflowIds = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询用户任务信息列表
    /// </summary>
    [HttpPost("/v1.0/project/users/{userId}/tasks/search")]
    ITask<TeambitionTaskSearchResult> SearchUserTasksAsync([PathQuery] string userId, string? roleTypes = null, string? tql = null, string? nextToken = null, string? maxResults = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询项目中的任务
    /// </summary>
    [HttpGet("/v1.0/project/users/{userId}/projectIds/{projectId}/tasks")]
    ITask<TeambitionPagedResult<List<TeambitionProjectTask>>> GetProjectTasksAsync([PathQuery] string userId, [PathQuery] string projectId, string? nextToken = null, string? maxResults = null, string? query = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 添加任务的关联内容
    /// </summary>
    [HttpPost("/v1.0/project/users/{userId}/tasks/{taskId}/objectLinks")]
    ITask<TeambitionResult<TeambitionObjectLinkResult>> AddTaskObjectLinkAsync([PathQuery] string userId, [PathQuery] string taskId, [JsonContent] TeambitionAddTaskObjectLinkRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 任务迁移至回收站
    /// </summary>
    [HttpPost("/v1.0/project/users/{userId}/tasks/{taskId}/archive")]
    ITask<TeambitionResult<TeambitionUpdatedResult>> ArchiveTaskAsync([PathQuery] string userId, [PathQuery] string taskId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 搜索任务工作流状态
    /// </summary>
    [HttpGet("/v1.0/project/users/{userId}/projects/{projectId}/taskflowStatuses/search")]
    ITask<TeambitionResult<List<TeambitionTaskflowStatus>>> SearchTaskflowStatusesAsync([PathQuery] string userId, [PathQuery] string projectId, string? query = null, string? maxResults = null, string? nextToken = null, string? tfIds = null, string? tfsIds = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新任务工作流状态
    /// </summary>
    [HttpPut("/v1.0/project/users/{userId}/tasks/{taskId}/taskflowStatuses")]
    ITask<TeambitionResult<TeambitionUpdatedResult>> UpdateTaskflowStatusAsync([PathQuery] string userId, [PathQuery] string taskId, [JsonContent] TeambitionUpdateTaskflowStatusRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新任务备注
    /// </summary>
    [HttpPut("/v1.0/project/users/{userId}/tasks/{taskId}/notes")]
    ITask<TeambitionResult<TeambitionNoteUpdateResult>> UpdateTaskNoteAsync([PathQuery] string userId, [PathQuery] string taskId, [JsonContent] TeambitionUpdateNoteRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新任务标题
    /// </summary>
    [HttpPut("/v1.0/project/users/{userId}/tasks/{taskId}/contents")]
    ITask<TeambitionResult<TeambitionContentUpdateResult>> UpdateTaskContentAsync([PathQuery] string userId, [PathQuery] string taskId, [JsonContent] TeambitionUpdateContentRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新任务执行者
    /// </summary>
    [HttpPut("/v1.0/project/users/{userId}/tasks/{taskId}/executors")]
    ITask<TeambitionResult<TeambitionExecutorUpdateResult>> UpdateTaskExecutorAsync([PathQuery] string userId, [PathQuery] string taskId, [JsonContent] TeambitionUpdateExecutorRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新任务优先级
    /// </summary>
    [HttpPut("/v1.0/project/users/{userId}/tasks/{taskId}/priorities")]
    ITask<TeambitionResult<TeambitionPriorityUpdateResult>> UpdateTaskPriorityAsync([PathQuery] string userId, [PathQuery] string taskId, [JsonContent] TeambitionUpdatePriorityRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新任务参与者
    /// </summary>
    [HttpPut("/v1.0/project/users/{userId}/tasks/{taskId}/involveMembers")]
    ITask<TeambitionResult<TeambitionInvolveMembersUpdateResult>> UpdateTaskInvolveMembersAsync([PathQuery] string userId, [PathQuery] string taskId, [JsonContent] TeambitionUpdateInvolveMembersRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新任务截止时间
    /// </summary>
    [HttpPut("/v1.0/project/users/{userId}/tasks/{taskId}/dueDates")]
    ITask<TeambitionResult<TeambitionDueDateUpdateResult>> UpdateTaskDueDateAsync([PathQuery] string userId, [PathQuery] string taskId, [JsonContent] TeambitionUpdateDueDateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新任务开始时间
    /// </summary>
    [HttpPut("/v1.0/project/users/{userId}/tasks/{taskId}/startDates")]
    ITask<TeambitionResult<TeambitionStartDateUpdateResult>> UpdateTaskStartDateAsync([PathQuery] string userId, [PathQuery] string taskId, [JsonContent] TeambitionUpdateStartDateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新项目任务的自定义字段值
    /// </summary>
    [HttpPut("/v1.0/project/users/{userId}/tasks/{taskId}/customFields")]
    ITask<TeambitionResult<TeambitionTaskCustomFieldsResult>> UpdateTaskCustomFieldsAsync([PathQuery] string userId, [PathQuery] string taskId, [JsonContent] TeambitionUpdateTaskCustomFieldRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建自由任务
    /// </summary>
    [HttpPost("/v1.0/project/organizations/users/{userId}/tasks")]
    ITask<TeambitionResult<TeambitionOrganizationTask>> CreateOrganizationTaskAsync([PathQuery] string userId, [JsonContent] TeambitionCreateOrganizationTaskRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量获取自由任务详情
    /// </summary>
    [HttpGet("/v1.0/project/organizations/users/{userId}/tasks")]
    ITask<TeambitionResult<List<TeambitionOrganizationTaskDetail>>> GetOrganizationTasksAsync([PathQuery] string userId, string? taskIds = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取自由任务详情
    /// </summary>
    [HttpGet("/v1.0/project/organizations/users/{userId}/tasks/{taskId}")]
    ITask<TeambitionResult<TeambitionOrganizationTaskDetail>> GetOrganizationTaskAsync([PathQuery] string userId, [PathQuery] string taskId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询优先级列表
    /// </summary>
    [HttpGet("/v1.0/project/organizations/users/{userId}/priorities")]
    ITask<TeambitionResult<List<TeambitionPriority>>> GetPrioritiesAsync([PathQuery] string userId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新自由任务标题
    /// </summary>
    [HttpPut("/v1.0/project/organizations/users/{userId}/tasks/{taskId}/contents")]
    ITask<TeambitionResult<TeambitionContentUpdateResult>> UpdateOrganizationTaskContentAsync([PathQuery] string userId, [PathQuery] string taskId, [JsonContent] TeambitionUpdateContentRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新自由任务状态
    /// </summary>
    [HttpPut("/v1.0/project/organizations/users/{userId}/tasks/{taskId}/states")]
    ITask<TeambitionResult<TeambitionOrganizationTaskStateUpdateResult>> UpdateOrganizationTaskStateAsync([PathQuery] string userId, [PathQuery] string taskId, [JsonContent] TeambitionUpdateOrganizationTaskStateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新自由任务备注
    /// </summary>
    [HttpPut("/v1.0/project/organizations/users/{userId}/tasks/{taskId}/notes")]
    ITask<TeambitionResult<TeambitionNoteUpdateResult>> UpdateOrganizationTaskNoteAsync([PathQuery] string userId, [PathQuery] string taskId, [JsonContent] TeambitionUpdateNoteRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新自由任务执行者
    /// </summary>
    [HttpPut("/v1.0/project/organizations/users/{userId}/tasks/{taskId}/executors")]
    ITask<TeambitionResult<TeambitionOrganizationExecutorUpdateResult>> UpdateOrganizationTaskExecutorAsync([PathQuery] string userId, [PathQuery] string taskId, [JsonContent] TeambitionUpdateExecutorRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新自由任务的优先级
    /// </summary>
    [HttpPut("/v1.0/project/organizations/users/{userId}/tasks/{taskId}/priorities")]
    ITask<TeambitionResult<TeambitionPriorityUpdateResult>> UpdateOrganizationTaskPriorityAsync([PathQuery] string userId, [PathQuery] string taskId, [JsonContent] TeambitionUpdateOrganizationTaskPriorityRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新自由任务截止时间
    /// </summary>
    [HttpPut("/v1.0/project/organizations/users/{userId}/tasks/{taskId}/dueDates")]
    ITask<TeambitionResult<TeambitionDueDateUpdateResult>> UpdateOrganizationTaskDueDateAsync([PathQuery] string userId, [PathQuery] string taskId, [JsonContent] TeambitionUpdateDueDateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 增加或删除自由任务的参与者
    /// </summary>
    [HttpPut("/v1.0/project/organizations/users/{userId}/tasks/{taskId}/involveMembers")]
    ITask<TeambitionResult<TeambitionOrganizationInvolversUpdateResult>> UpdateOrganizationTaskInvolveMembersAsync([PathQuery] string userId, [PathQuery] string taskId, [JsonContent] TeambitionUpdateInvolveMembersRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建计划工时
    /// </summary>
    [HttpPost("/v1.0/project/users/{userId}/planTimes")]
    ITask<TeambitionResult<TeambitionPlanTimeResult>> CreatePlanTimeAsync([PathQuery] string userId, string? tenantType, [JsonContent] TeambitionCreatePlanTimeRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建实际工时
    /// </summary>
    [HttpPost("/v1.0/project/users/{userId}/workTimes")]
    ITask<TeambitionResult<TeambitionWorkTimeResult>> CreateWorkTimeAsync([PathQuery] string userId, string? tenantType, [JsonContent] TeambitionCreateWorkTimeRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取 Teambition 项目企业 ID
    /// </summary>
    [HttpGet("/v1.0/project/teambition/organizations")]
    ITask<TeambitionResult<TeambitionOrganizationIdResult>> GetTeambitionOrganizationIdAsync(string? optUserId = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 根据 userId 获取 Teambition 项目用户 ID
    /// </summary>
    [HttpGet("/v1.0/project/teambition/users")]
    ITask<TeambitionResult<TeambitionUserIdResult>> GetTeambitionUserIdAsync(string? optUserId = null, string? userId = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
