using DingTalkApi.Attributes;
using DingTalkApi.Models.Todo;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.Todo;

/// <summary>
/// 待办任务api
/// </summary>
public interface ITodoApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 创建钉钉个人待办任务
    /// </summary>
    [HttpPost("/v1.0/todo/users/me/personalTasks")]
    ITask<CreatePersonalTodoTaskResponse> CreatePersonalTodoTaskAsync([JsonContent] CreatePersonalTodoTaskRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建钉钉待办任务
    /// </summary>
    [HttpPost("/v1.0/todo/users/{unionId}/tasks")]
    ITask<TodoTaskResponse> CreateTodoTaskAsync([PathQuery] string unionId, [JsonContent] CreateTodoTaskRequest request, string? operatorId = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除钉钉待办任务
    /// </summary>
    [HttpDelete("/v1.0/todo/users/{unionId}/tasks/{taskId}")]
    ITask<TodoBooleanResponse> DeleteTodoTaskAsync([PathQuery] string unionId, [PathQuery] string taskId, string? operatorId = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新钉钉待办任务
    /// </summary>
    [HttpPut("/v1.0/todo/users/{unionId}/tasks/{taskId}")]
    ITask<TodoBooleanResponse> UpdateTodoTaskAsync([PathQuery] string unionId, [PathQuery] string taskId, [JsonContent] UpdateTodoTaskRequest request, string? operatorId = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新钉钉待办执行者状态
    /// </summary>
    [HttpPut("/v1.0/todo/users/{unionId}/tasks/{taskId}/executorStatus")]
    ITask<TodoBooleanResponse> UpdateTodoTaskExecutorStatusAsync([PathQuery] string unionId, [PathQuery] string taskId, [JsonContent] UpdateTodoTaskExecutorStatusRequest request, string? operatorId = null, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询企业下用户待办列表
    /// </summary>
    [HttpPost("/v1.0/todo/users/{unionId}/org/tasks/query")]
    ITask<QueryOrgTodoTasksResponse> QueryOrgTodoTasksAsync([PathQuery] string unionId, [JsonContent] QueryOrgTodoTasksRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
