using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models.Teambition;

/// <summary>
/// Teambition 通用响应。
/// </summary>
/// <typeparam name="T">结果类型。</typeparam>
public class TeambitionResult<T>
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    public T? Result { get; set; }
}

/// <summary>
/// Teambition 分页响应。
/// </summary>
/// <typeparam name="T">结果类型。</typeparam>
public class TeambitionPagedResult<T> : TeambitionResult<T>
{
    /// <summary>
    /// 下一页游标。
    /// </summary>
    public string? NextToken { get; set; }

    /// <summary>
    /// 总数量。
    /// </summary>
    public int? TotalCount { get; set; }
}

/// <summary>
/// Teambition topapi 通用响应。
/// </summary>
/// <typeparam name="T">结果类型。</typeparam>
public class TeambitionTopResult<T>
{
    /// <summary>
    /// 错误码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public int? ErrCode { get; set; }

    /// <summary>
    /// 错误信息。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? ErrMsg { get; set; }

    /// <summary>
    /// 返回结果。
    /// </summary>
    public T? Result { get; set; }
}

/// <summary>
/// 创建项目请求。
/// </summary>
/// <param name="Name">项目名称。</param>
public record TeambitionCreateProjectRequest(string Name);

/// <summary>
/// 删除项目成员请求。
/// </summary>
/// <param name="UserIds">待删除成员 userId 列表。</param>
public record TeambitionRemoveProjectMembersRequest(List<string> UserIds);

/// <summary>
/// 根据项目模板创建项目请求。
/// </summary>
/// <param name="Name">项目名称。</param>
/// <param name="TemplateId">项目模板 ID。</param>
public record TeambitionCreateProjectFromTemplateRequest(string Name, string TemplateId);

/// <summary>
/// 更新项目所在分组请求。
/// </summary>
public class TeambitionUpdateProjectGroupsRequest
{
    /// <summary>
    /// 需要加入的项目分组 ID 列表。
    /// </summary>
    public List<string> AddProjectGroupIds { get; set; } = [];

    /// <summary>
    /// 需要移除的项目分组 ID 列表。
    /// </summary>
    public List<string> DelProjectGroupIds { get; set; } = [];
}

/// <summary>
/// 创建或更新项目概览自定义字段请求。
/// </summary>
public class TeambitionUpsertProjectCustomFieldRequest
{
    /// <summary>
    /// 自定义字段 ID。
    /// </summary>
    public string? CustomFieldId { get; set; }

    /// <summary>
    /// 自定义字段名称。
    /// </summary>
    public string? CustomFieldName { get; set; }

    /// <summary>
    /// 自定义字段实例 ID。
    /// </summary>
    public string? CustomFieldInstanceId { get; set; }

    /// <summary>
    /// 自定义字段值。
    /// </summary>
    public List<TeambitionCustomFieldValue> Value { get; set; } = [];
}

/// <summary>
/// 创建项目任务请求。
/// </summary>
public class TeambitionCreateTaskRequest
{
    /// <summary>
    /// 项目 ID。
    /// </summary>
    public string? ProjectId { get; set; }

    /// <summary>
    /// 任务标题。
    /// </summary>
    public string? Content { get; set; }

    /// <summary>
    /// 执行者 ID。
    /// </summary>
    public string? ExecutorId { get; set; }

    /// <summary>
    /// 截止时间，ISO 8601 格式。
    /// </summary>
    public string? DueDate { get; set; }

    /// <summary>
    /// 备注。
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// 自定义字段值。
    /// </summary>
    public List<TeambitionTaskCustomFieldRequest> Customfields { get; set; } = [];

    /// <summary>
    /// 任务阶段 ID。
    /// </summary>
    public string? StageId { get; set; }

    /// <summary>
    /// 父任务 ID。
    /// </summary>
    public string? ParentTaskId { get; set; }

    /// <summary>
    /// 场景字段配置 ID。
    /// </summary>
    public string? ScenariofieldconfigId { get; set; }

    /// <summary>
    /// 开始时间，ISO 8601 格式。
    /// </summary>
    public string? StartDate { get; set; }

    /// <summary>
    /// 可见范围。
    /// </summary>
    public string? Visible { get; set; }
}

/// <summary>
/// 添加任务关联内容请求。
/// </summary>
public class TeambitionAddTaskObjectLinkRequest
{
    /// <summary>
    /// 关联内容。
    /// </summary>
    public required TeambitionLinkedData LinkedData { get; set; }
}

/// <summary>
/// 更新任务工作流状态请求。
/// </summary>
/// <param name="TaskflowStatusId">任务工作流状态 ID。</param>
/// <param name="TfsUpdateNote">更新备注。</param>
public record TeambitionUpdateTaskflowStatusRequest(string TaskflowStatusId, string? TfsUpdateNote = null);

/// <summary>
/// 更新任务备注请求。
/// </summary>
/// <param name="Note">任务备注。</param>
public record TeambitionUpdateNoteRequest(string Note);

/// <summary>
/// 更新任务标题请求。
/// </summary>
/// <param name="Content">任务标题。</param>
public record TeambitionUpdateContentRequest(string Content);

/// <summary>
/// 更新任务执行者请求。
/// </summary>
/// <param name="ExecutorId">执行者 ID。</param>
public record TeambitionUpdateExecutorRequest(string ExecutorId);

/// <summary>
/// 更新任务优先级请求。
/// </summary>
/// <param name="Priority">优先级，数值越大优先级越高。</param>
public record TeambitionUpdatePriorityRequest(int Priority);

/// <summary>
/// 更新任务参与者请求。
/// </summary>
public class TeambitionUpdateInvolveMembersRequest
{
    /// <summary>
    /// 参与者 userId 列表。
    /// </summary>
    public List<string> InvolveMembers { get; set; } = [];

    /// <summary>
    /// 需要增加的参与者 userId 列表。
    /// </summary>
    public List<string> AddInvolvers { get; set; } = [];

    /// <summary>
    /// 需要删除的参与者 userId 列表。
    /// </summary>
    public List<string> DelInvolvers { get; set; } = [];
}

/// <summary>
/// 更新任务截止时间请求。
/// </summary>
/// <param name="DueDate">截止时间，ISO 8601 格式。</param>
public record TeambitionUpdateDueDateRequest(string DueDate);

/// <summary>
/// 更新任务开始时间请求。
/// </summary>
/// <param name="StartDate">开始时间，ISO 8601 格式。</param>
public record TeambitionUpdateStartDateRequest(string StartDate);

/// <summary>
/// 更新项目任务自定义字段请求。
/// </summary>
public class TeambitionUpdateTaskCustomFieldRequest
{
    /// <summary>
    /// 自定义字段名称。
    /// </summary>
    public string? CustomfieldName { get; set; }

    /// <summary>
    /// 自定义字段值。
    /// </summary>
    public List<TeambitionTaskCustomFieldValue> Value { get; set; } = [];

    /// <summary>
    /// 自定义字段 ID。
    /// </summary>
    public string? CustomfieldId { get; set; }
}

/// <summary>
/// 创建自由任务请求。
/// </summary>
public class TeambitionCreateOrganizationTaskRequest
{
    /// <summary>
    /// 任务标题。
    /// </summary>
    public string? Content { get; set; }

    /// <summary>
    /// 备注。
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// 优先级。
    /// </summary>
    public int? Priority { get; set; }

    /// <summary>
    /// 参与者 userId 列表。
    /// </summary>
    public List<string> InvolveMembers { get; set; } = [];

    /// <summary>
    /// 执行者 ID。
    /// </summary>
    public string? ExecutorId { get; set; }

    /// <summary>
    /// 截止时间，ISO 8601 格式。
    /// </summary>
    public string? DueDate { get; set; }

    /// <summary>
    /// 创建时间，ISO 8601 格式。
    /// </summary>
    public string? CreateTime { get; set; }

    /// <summary>
    /// 可见范围。
    /// </summary>
    public string? Visible { get; set; }
}

/// <summary>
/// 更新自由任务状态请求。
/// </summary>
public class TeambitionUpdateOrganizationTaskStateRequest
{
    /// <summary>
    /// 是否完成。
    /// </summary>
    public bool IsDone { get; set; }

    /// <summary>
    /// 是否禁用动态。
    /// </summary>
    public bool? DisableActivity { get; set; }

    /// <summary>
    /// 是否禁用通知。
    /// </summary>
    public bool? DisableNotification { get; set; }
}

/// <summary>
/// 更新自由任务优先级请求。
/// </summary>
public class TeambitionUpdateOrganizationTaskPriorityRequest
{
    /// <summary>
    /// 优先级，数值越大优先级越高。
    /// </summary>
    public int Priority { get; set; }

    /// <summary>
    /// 是否禁用动态。
    /// </summary>
    public bool? DisableActivity { get; set; }

    /// <summary>
    /// 是否禁用通知。
    /// </summary>
    public bool? DisableNotification { get; set; }
}

/// <summary>
/// 创建计划工时请求。
/// </summary>
public class TeambitionCreatePlanTimeRequest
{
    /// <summary>
    /// 执行者 ID。
    /// </summary>
    public string? ExecutorId { get; set; }

    /// <summary>
    /// 对象 ID。
    /// </summary>
    public string? ObjectId { get; set; }

    /// <summary>
    /// 对象类型。
    /// </summary>
    public string? ObjectType { get; set; }

    /// <summary>
    /// 是否按时间段提交。
    /// </summary>
    public bool? IsDuration { get; set; }

    /// <summary>
    /// 是否包含节假日。
    /// </summary>
    public bool? IncludesHolidays { get; set; }

    /// <summary>
    /// 提交者 ID。
    /// </summary>
    public string? SubmitterId { get; set; }

    /// <summary>
    /// 开始时间。
    /// </summary>
    public string? StartDate { get; set; }

    /// <summary>
    /// 结束时间。
    /// </summary>
    public string? EndDate { get; set; }

    /// <summary>
    /// 计划工时。
    /// </summary>
    public string? PlanTime { get; set; }
}

/// <summary>
/// 创建实际工时请求。
/// </summary>
public class TeambitionCreateWorkTimeRequest : TeambitionCreatePlanTimeRequest
{
    /// <summary>
    /// 实际工时。
    /// </summary>
    public string? WorkTime { get; set; }

    /// <summary>
    /// 工时描述。
    /// </summary>
    public string? Description { get; set; }
}

/// <summary>
/// 查询项目中文件操作日志请求。
/// </summary>
public class TeambitionWorkspaceAuditLogListRequest
{
    /// <summary>
    /// 开始时间，毫秒时间戳。
    /// </summary>
    public long? StartDate { get; set; }

    /// <summary>
    /// 结束时间，毫秒时间戳。
    /// </summary>
    public long? EndDate { get; set; }

    /// <summary>
    /// 每页数量。
    /// </summary>
    public int? PageSize { get; set; }

    /// <summary>
    /// 加载更多使用的创建时间。
    /// </summary>
    public long? LoadMoreGmtCreate { get; set; }

    /// <summary>
    /// 加载更多使用的业务 ID。
    /// </summary>
    public long? LoadMoreBizId { get; set; }
}

/// <summary>
/// Teambition 项目信息。
/// </summary>
public class TeambitionProject
{
    /// <summary>
    /// 项目 ID。
    /// </summary>
    public string? ProjectId { get; set; }

    /// <summary>
    /// 项目名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 创建者 ID。
    /// </summary>
    public string? CreatorId { get; set; }

    /// <summary>
    /// 项目图标。
    /// </summary>
    public string? Logo { get; set; }

    /// <summary>
    /// 可见范围。
    /// </summary>
    public string? Visibility { get; set; }

    /// <summary>
    /// 项目唯一编号前缀。
    /// </summary>
    public string? UniqueIdPrefix { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    public string? Created { get; set; }

    /// <summary>
    /// 更新时间。
    /// </summary>
    public string? Updated { get; set; }

    /// <summary>
    /// 是否已放入回收站。
    /// </summary>
    public bool? IsArchived { get; set; }

    /// <summary>
    /// 是否已归档。
    /// </summary>
    public bool? IsSuspended { get; set; }

    /// <summary>
    /// 项目类型。
    /// </summary>
    public string? NormalType { get; set; }

    /// <summary>
    /// 根集合 ID。
    /// </summary>
    public string? RootCollectionId { get; set; }

    /// <summary>
    /// 来源 ID。
    /// </summary>
    public string? SourceId { get; set; }

    /// <summary>
    /// 默认集合 ID。
    /// </summary>
    public string? DefaultCollectionId { get; set; }

    /// <summary>
    /// 是否为模板。
    /// </summary>
    public bool? IsTemplate { get; set; }

    /// <summary>
    /// 自定义字段列表。
    /// </summary>
    public List<TeambitionCustomField> CustomFields { get; set; } = [];
}

/// <summary>
/// Teambition 自定义字段。
/// </summary>
public class TeambitionCustomField
{
    /// <summary>
    /// 自定义字段 ID。
    /// </summary>
    public string? CustomFieldId { get; set; }

    /// <summary>
    /// 字段类型。
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// 自定义字段值。
    /// </summary>
    public List<TeambitionCustomFieldValue> Value { get; set; } = [];
}

/// <summary>
/// Teambition 自定义字段值。
/// </summary>
public class TeambitionCustomFieldValue
{
    /// <summary>
    /// 自定义字段值 ID。
    /// </summary>
    public string? CustomFieldValueId { get; set; }

    /// <summary>
    /// 标题。
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 扩展元数据。
    /// </summary>
    public string? MetaString { get; set; }
}

/// <summary>
/// Teambition 任务自定义字段请求项。
/// </summary>
public class TeambitionTaskCustomFieldRequest
{
    /// <summary>
    /// 自定义字段名称。
    /// </summary>
    public string? CustomfieldName { get; set; }

    /// <summary>
    /// 自定义字段 ID。
    /// </summary>
    public string? CustomfieldId { get; set; }

    /// <summary>
    /// 自定义字段值。
    /// </summary>
    public List<TeambitionTaskCustomFieldValue> Value { get; set; } = [];
}

/// <summary>
/// Teambition 任务自定义字段值。
/// </summary>
public class TeambitionTaskCustomFieldValue
{
    /// <summary>
    /// 标题。
    /// </summary>
    public string? Title { get; set; }
}

/// <summary>
/// 更新时间返回结果。
/// </summary>
public class TeambitionUpdatedResult
{
    /// <summary>
    /// 更新时间。
    /// </summary>
    public string? Updated { get; set; }
}

/// <summary>
/// 归档返回结果。
/// </summary>
public class TeambitionArchiveResult : TeambitionUpdatedResult
{
    /// <summary>
    /// 是否已放入回收站。
    /// </summary>
    public bool IsArchived { get; set; }
}

/// <summary>
/// 通用成功返回结果。
/// </summary>
public class TeambitionOkResult
{
    /// <summary>
    /// 是否成功。
    /// </summary>
    public bool Ok { get; set; }
}

/// <summary>
/// 删除任务返回结果。
/// </summary>
public class TeambitionDeleteResult
{
    /// <summary>
    /// 删除结果。
    /// </summary>
    public string? Result { get; set; }
}

/// <summary>
/// 项目成员。
/// </summary>
public class TeambitionProjectMember
{
    /// <summary>
    /// 项目成员 ID。
    /// </summary>
    public string? MemberId { get; set; }

    /// <summary>
    /// 用户 userId。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// 成员角色。
    /// </summary>
    public int? Role { get; set; }

    /// <summary>
    /// 角色 ID 列表。
    /// </summary>
    public List<string> RoleIds { get; set; } = [];
}

/// <summary>
/// 添加项目成员结果。
/// </summary>
public class TeambitionAddedProjectMember
{
    /// <summary>
    /// 项目成员昵称。
    /// </summary>
    public string? Nickname { get; set; }

    /// <summary>
    /// 加入项目时间。
    /// </summary>
    public string? Joined { get; set; }
}

/// <summary>
/// 项目状态。
/// </summary>
public class TeambitionProjectStatus
{
    /// <summary>
    /// 项目 ID。
    /// </summary>
    public string? ProjectId { get; set; }

    /// <summary>
    /// 状态名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 状态内容。
    /// </summary>
    public string? Content { get; set; }

    /// <summary>
    /// 状态程度。
    /// </summary>
    public string? Degree { get; set; }

    /// <summary>
    /// 创建者 ID。
    /// </summary>
    public string? CreatorId { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    public string? Created { get; set; }
}

/// <summary>
/// 项目模板。
/// </summary>
public class TeambitionProjectTemplate
{
    /// <summary>
    /// 模板 ID。
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// 模板描述。
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 可见范围。
    /// </summary>
    public string? Visible { get; set; }

    /// <summary>
    /// 是否为演示模板。
    /// </summary>
    public bool? IsDemo { get; set; }

    /// <summary>
    /// 是否已删除。
    /// </summary>
    public bool? IsDeleted { get; set; }

    /// <summary>
    /// 模板名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 模板图标。
    /// </summary>
    public string? Logo { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    public string? Created { get; set; }

    /// <summary>
    /// 更新时间。
    /// </summary>
    public string? Updated { get; set; }
}

/// <summary>
/// 根据模板创建的项目。
/// </summary>
public class TeambitionTemplateProject
{
    /// <summary>
    /// 项目 ID。
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// 项目名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    public string? Created { get; set; }

    /// <summary>
    /// 项目图标。
    /// </summary>
    public string? Logo { get; set; }
}

/// <summary>
/// 项目分组。
/// </summary>
public class TeambitionProjectGroup
{
    /// <summary>
    /// 分组 ID。
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// 可见范围。
    /// </summary>
    public string? Visible { get; set; }

    /// <summary>
    /// 分组名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    public string? Created { get; set; }

    /// <summary>
    /// 更新时间。
    /// </summary>
    public string? Updated { get; set; }
}

/// <summary>
/// 项目自定义字段更新结果。
/// </summary>
public class TeambitionProjectCustomFieldResult
{
    /// <summary>
    /// 自定义字段 ID。
    /// </summary>
    public string? CustomfieldId { get; set; }

    /// <summary>
    /// 原始 ID。
    /// </summary>
    public string? OriginalId { get; set; }

    /// <summary>
    /// 字段名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 字段类型。
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// 高级自定义字段对象类型。
    /// </summary>
    public string? AdvCfObjectType { get; set; }

    /// <summary>
    /// 字段值。
    /// </summary>
    public List<TeambitionProjectCustomFieldValueResult> Value { get; set; } = [];
}

/// <summary>
/// 项目自定义字段值更新结果。
/// </summary>
public class TeambitionProjectCustomFieldValueResult
{
    /// <summary>
    /// 字段值 ID。
    /// </summary>
    public string? FieldvalueId { get; set; }

    /// <summary>
    /// 标题。
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 扩展元数据。
    /// </summary>
    public string? MetaString { get; set; }
}

/// <summary>
/// Teambition 项目任务。
/// </summary>
public class TeambitionTask
{
    /// <summary>
    /// 任务 ID。
    /// </summary>
    public string? TaskId { get; set; }

    /// <summary>
    /// 任务标题。
    /// </summary>
    public string? Content { get; set; }

    /// <summary>
    /// 参与者 userId 列表。
    /// </summary>
    public List<string> InvolveMembers { get; set; } = [];

    /// <summary>
    /// 项目 ID。
    /// </summary>
    public string? ProjectId { get; set; }

    /// <summary>
    /// 执行者 ID。
    /// </summary>
    public string? ExecutorId { get; set; }

    /// <summary>
    /// 创建者 ID。
    /// </summary>
    public string? CreatorId { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    public string? Created { get; set; }

    /// <summary>
    /// 更新时间。
    /// </summary>
    public string? Updated { get; set; }

    /// <summary>
    /// 备注。
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// 截止时间。
    /// </summary>
    public string? DueDate { get; set; }

    /// <summary>
    /// 优先级。
    /// </summary>
    public int? Priority { get; set; }

    /// <summary>
    /// 自定义字段。
    /// </summary>
    public List<TeambitionTaskCustomField> Customfields { get; set; } = [];
}

/// <summary>
/// Teambition 任务详情。
/// </summary>
public class TeambitionTaskDetail
{
    /// <summary>
    /// 任务 ID。
    /// </summary>
    public string? TaskId { get; set; }

    /// <summary>
    /// 任务标题。
    /// </summary>
    public string? Content { get; set; }

    /// <summary>
    /// 备注。
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// 项目 ID。
    /// </summary>
    public string? ProjectId { get; set; }

    /// <summary>
    /// 祖先任务 ID 列表。
    /// </summary>
    public List<string> AncestorIds { get; set; } = [];

    /// <summary>
    /// 父任务 ID。
    /// </summary>
    public string? ParentTaskId { get; set; }

    /// <summary>
    /// 工作流状态 ID。
    /// </summary>
    public string? TaskflowStatusId { get; set; }

    /// <summary>
    /// 任务分组 ID。
    /// </summary>
    public string? TaskListId { get; set; }

    /// <summary>
    /// 任务阶段 ID。
    /// </summary>
    public string? TaskStageId { get; set; }

    /// <summary>
    /// 标签 ID 列表。
    /// </summary>
    public List<string> TagIds { get; set; } = [];

    /// <summary>
    /// 故事点。
    /// </summary>
    public string? StoryPoint { get; set; }

    /// <summary>
    /// 重复规则。
    /// </summary>
    public List<string> Recurrence { get; set; } = [];

    /// <summary>
    /// 是否完成。
    /// </summary>
    public bool? IsDone { get; set; }

    /// <summary>
    /// 是否已归档。
    /// </summary>
    public bool? IsArchived { get; set; }

    /// <summary>
    /// 可见范围。
    /// </summary>
    public string? Visible { get; set; }

    /// <summary>
    /// 任务唯一编号。
    /// </summary>
    public string? UniqueId { get; set; }

    /// <summary>
    /// 开始时间。
    /// </summary>
    public string? StartDate { get; set; }

    /// <summary>
    /// 完成时间。
    /// </summary>
    public string? AccomplishTime { get; set; }

    /// <summary>
    /// 场景字段配置 ID。
    /// </summary>
    public string? ScenarioFieldConfigId { get; set; }

    /// <summary>
    /// 迭代 ID。
    /// </summary>
    public string? SprintId { get; set; }

    /// <summary>
    /// 执行者 ID。
    /// </summary>
    public string? ExecutorId { get; set; }

    /// <summary>
    /// 创建者 ID。
    /// </summary>
    public string? CreatorId { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    public string? Created { get; set; }

    /// <summary>
    /// 更新时间。
    /// </summary>
    public string? Updated { get; set; }

    /// <summary>
    /// 截止时间。
    /// </summary>
    public string? DueDate { get; set; }

    /// <summary>
    /// 优先级。
    /// </summary>
    public int? Priority { get; set; }

    /// <summary>
    /// 参与者 userId 列表。
    /// </summary>
    public List<string> InvolveMembers { get; set; } = [];

    /// <summary>
    /// 自定义字段列表。
    /// </summary>
    public List<TeambitionCustomField> CustomFields { get; set; } = [];
}

/// <summary>
/// 项目任务列表项。
/// </summary>
public class TeambitionProjectTask
{
    /// <summary>
    /// 任务 ID。
    /// </summary>
    public string? TaskId { get; set; }

    /// <summary>
    /// 任务标题。
    /// </summary>
    public string? Content { get; set; }

    /// <summary>
    /// 参与者 userId 列表。
    /// </summary>
    public List<string> InvolveMembers { get; set; } = [];

    /// <summary>
    /// 项目 ID。
    /// </summary>
    public string? ProjectId { get; set; }

    /// <summary>
    /// 执行者 ID。
    /// </summary>
    public string? ExecutorId { get; set; }

    /// <summary>
    /// 创建者 ID。
    /// </summary>
    public string? CreatorId { get; set; }

    /// <summary>
    /// 是否已删除。
    /// </summary>
    public bool? IsDeleted { get; set; }

    /// <summary>
    /// 标签。
    /// </summary>
    public string? Labels { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    public string? Created { get; set; }

    /// <summary>
    /// 更新时间。
    /// </summary>
    public string? Updated { get; set; }

    /// <summary>
    /// 场景字段配置 ID。
    /// </summary>
    public string? ScenariofieldconfigId { get; set; }

    /// <summary>
    /// 自定义字段摘要。
    /// </summary>
    public List<string> Customfields { get; set; } = [];

    /// <summary>
    /// 备注。
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// 开始时间。
    /// </summary>
    public string? StartDate { get; set; }

    /// <summary>
    /// 截止时间。
    /// </summary>
    public string? DueDate { get; set; }

    /// <summary>
    /// 优先级。
    /// </summary>
    public int? Priority { get; set; }

    /// <summary>
    /// 工作流状态 ID。
    /// </summary>
    public string? TaskflowstatusId { get; set; }

    /// <summary>
    /// 是否完成。
    /// </summary>
    public bool? IsDone { get; set; }

    /// <summary>
    /// 是否已归档。
    /// </summary>
    public bool? IsArchived { get; set; }

    /// <summary>
    /// 可见范围。
    /// </summary>
    public string? Visible { get; set; }

    /// <summary>
    /// 标签 ID。
    /// </summary>
    public string? TagIds { get; set; }

    /// <summary>
    /// 阶段 ID。
    /// </summary>
    public string? StageId { get; set; }

    /// <summary>
    /// 迭代 ID。
    /// </summary>
    public string? SprintId { get; set; }

    /// <summary>
    /// 完成时间。
    /// </summary>
    public string? Accomplished { get; set; }

    /// <summary>
    /// 故事点。
    /// </summary>
    public int? StoryPoint { get; set; }

    /// <summary>
    /// 进度。
    /// </summary>
    public int? Progress { get; set; }

    /// <summary>
    /// 祖先任务 ID 列表。
    /// </summary>
    public List<string> AncestorIds { get; set; } = [];
}

/// <summary>
/// Teambition 任务自定义字段。
/// </summary>
public class TeambitionTaskCustomField
{
    /// <summary>
    /// 自定义字段 ID。
    /// </summary>
    public string? CustomfieldId { get; set; }

    /// <summary>
    /// 自定义字段值。
    /// </summary>
    public List<TeambitionTaskCustomFieldValue> Value { get; set; } = [];
}

/// <summary>
/// 任务搜索响应。
/// </summary>
public class TeambitionTaskSearchResult : TeambitionPagedResult<List<TeambitionTaskDetail>>
{
    /// <summary>
    /// 请求 ID。
    /// </summary>
    public string? RequestId { get; set; }
}

/// <summary>
/// 任务分组。
/// </summary>
public class TeambitionTaskList
{
    /// <summary>
    /// 任务分组 ID。
    /// </summary>
    public string? TaskListId { get; set; }

    /// <summary>
    /// 标题。
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 描述。
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 项目 ID。
    /// </summary>
    public string? ProjectId { get; set; }

    /// <summary>
    /// 创建者 ID。
    /// </summary>
    public string? CreatorId { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    public string? Created { get; set; }

    /// <summary>
    /// 更新时间。
    /// </summary>
    public string? Updated { get; set; }
}

/// <summary>
/// 任务阶段。
/// </summary>
public class TeambitionTaskStage
{
    /// <summary>
    /// 任务阶段 ID。
    /// </summary>
    public string? TaskStageId { get; set; }

    /// <summary>
    /// 阶段名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 阶段描述。
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 项目 ID。
    /// </summary>
    public string? ProjectId { get; set; }

    /// <summary>
    /// 任务分组 ID。
    /// </summary>
    public string? TaskListId { get; set; }

    /// <summary>
    /// 创建者 ID。
    /// </summary>
    public string? CreatorId { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    public string? Created { get; set; }

    /// <summary>
    /// 更新时间。
    /// </summary>
    public string? Updated { get; set; }
}

/// <summary>
/// 任务工作流。
/// </summary>
public class TeambitionTaskflow
{
    /// <summary>
    /// 工作流 ID。
    /// </summary>
    public string? TaskflowId { get; set; }

    /// <summary>
    /// 工作流名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 绑定对象 ID。
    /// </summary>
    public string? BoundToObjectId { get; set; }

    /// <summary>
    /// 绑定对象类型。
    /// </summary>
    public string? BoundToObjectType { get; set; }

    /// <summary>
    /// 创建者 ID。
    /// </summary>
    public string? CreatorId { get; set; }

    /// <summary>
    /// 是否已删除。
    /// </summary>
    public bool? IsDeleted { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    public string? Created { get; set; }

    /// <summary>
    /// 更新时间。
    /// </summary>
    public string? Updated { get; set; }
}

/// <summary>
/// 任务工作流状态。
/// </summary>
public class TeambitionTaskflowStatus
{
    /// <summary>
    /// 状态 ID。
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// 状态名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 排序位置。
    /// </summary>
    public int? Pos { get; set; }

    /// <summary>
    /// 工作流 ID。
    /// </summary>
    public string? TaskflowId { get; set; }

    /// <summary>
    /// 驳回状态 ID 列表。
    /// </summary>
    public List<string> RejectStatusIds { get; set; } = [];

    /// <summary>
    /// 状态类型。
    /// </summary>
    public string? Kind { get; set; }

    /// <summary>
    /// 创建者 ID。
    /// </summary>
    public string? CreatorId { get; set; }

    /// <summary>
    /// 是否已删除。
    /// </summary>
    public bool? IsDeleted { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    public string? Created { get; set; }

    /// <summary>
    /// 更新时间。
    /// </summary>
    public string? Updated { get; set; }

    /// <summary>
    /// 是否为规则执行状态。
    /// </summary>
    public bool? IsTaskflowstatusruleexector { get; set; }
}

/// <summary>
/// 关联内容。
/// </summary>
public class TeambitionLinkedData
{
    /// <summary>
    /// 标题。
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 内容。
    /// </summary>
    public string? Content { get; set; }

    /// <summary>
    /// 链接地址。
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// 缩略图地址。
    /// </summary>
    public string? ThumbnailUrl { get; set; }
}

/// <summary>
/// 任务关联内容创建结果。
/// </summary>
public class TeambitionObjectLinkResult
{
    /// <summary>
    /// 创建时间。
    /// </summary>
    public string? Created { get; set; }

    /// <summary>
    /// 关联内容 ID。
    /// </summary>
    public string? ObjectLinkId { get; set; }
}

/// <summary>
/// 更新备注结果。
/// </summary>
public class TeambitionNoteUpdateResult : TeambitionUpdatedResult
{
    /// <summary>
    /// 备注。
    /// </summary>
    public string? Note { get; set; }
}

/// <summary>
/// 更新标题结果。
/// </summary>
public class TeambitionContentUpdateResult : TeambitionUpdatedResult
{
    /// <summary>
    /// 标题。
    /// </summary>
    public string? Content { get; set; }
}

/// <summary>
/// 更新执行者结果。
/// </summary>
public class TeambitionExecutorUpdateResult : TeambitionUpdatedResult
{
    /// <summary>
    /// 执行者 ID。
    /// </summary>
    public string? ExecutorId { get; set; }
}

/// <summary>
/// 更新优先级结果。
/// </summary>
public class TeambitionPriorityUpdateResult : TeambitionUpdatedResult
{
    /// <summary>
    /// 优先级。
    /// </summary>
    public int? Priority { get; set; }
}

/// <summary>
/// 更新参与者结果。
/// </summary>
public class TeambitionInvolveMembersUpdateResult : TeambitionUpdatedResult
{
    /// <summary>
    /// 参与者 userId 列表。
    /// </summary>
    public List<string> InvolveMembers { get; set; } = [];
}

/// <summary>
/// 更新截止时间结果。
/// </summary>
public class TeambitionDueDateUpdateResult : TeambitionUpdatedResult
{
    /// <summary>
    /// 截止时间。
    /// </summary>
    public string? DueDate { get; set; }

    /// <summary>
    /// 更新时间。
    /// </summary>
    public string? UpdateTime { get; set; }
}

/// <summary>
/// 更新开始时间结果。
/// </summary>
public class TeambitionStartDateUpdateResult : TeambitionUpdatedResult
{
    /// <summary>
    /// 开始时间。
    /// </summary>
    public string? StartDate { get; set; }
}

/// <summary>
/// 任务自定义字段更新结果。
/// </summary>
public class TeambitionTaskCustomFieldsResult
{
    /// <summary>
    /// 自定义字段列表。
    /// </summary>
    public List<TeambitionTaskCustomField> CustomFields { get; set; } = [];
}

/// <summary>
/// Teambition 用户。
/// </summary>
public class TeambitionUser
{
    /// <summary>
    /// 头像地址。
    /// </summary>
    public string? AvatarUrl { get; set; }

    /// <summary>
    /// 用户名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 用户 ID。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// ID。
    /// </summary>
    public string? Id { get; set; }
}

/// <summary>
/// 自由任务创建结果。
/// </summary>
public class TeambitionOrganizationTask
{
    /// <summary>
    /// 截止时间。
    /// </summary>
    public string? DueDate { get; set; }

    /// <summary>
    /// 执行者。
    /// </summary>
    public TeambitionUser? Executor { get; set; }

    /// <summary>
    /// 任务 ID。
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// 可见范围。
    /// </summary>
    public string? Visible { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    public string? Created { get; set; }

    /// <summary>
    /// 优先级。
    /// </summary>
    public int? Priority { get; set; }

    /// <summary>
    /// 参与者信息。
    /// </summary>
    public List<TeambitionUser> Involvers { get; set; } = [];

    /// <summary>
    /// 更新时间。
    /// </summary>
    public string? Updated { get; set; }

    /// <summary>
    /// 备注。
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// 是否有提醒。
    /// </summary>
    public bool? HasReminder { get; set; }

    /// <summary>
    /// 创建者 ID。
    /// </summary>
    public string? CreatorId { get; set; }

    /// <summary>
    /// 任务标题。
    /// </summary>
    public string? Content { get; set; }

    /// <summary>
    /// 附件数量。
    /// </summary>
    public int? AttachmentsCount { get; set; }

    /// <summary>
    /// 是否已删除。
    /// </summary>
    public bool? IsDeleted { get; set; }

    /// <summary>
    /// 祖先任务 ID 列表。
    /// </summary>
    public List<string> AncestorIds { get; set; } = [];

    /// <summary>
    /// 创建者。
    /// </summary>
    public TeambitionUser? Creator { get; set; }

    /// <summary>
    /// 执行者 ID。
    /// </summary>
    public string? ExecutorId { get; set; }

    /// <summary>
    /// 参与者 userId 列表。
    /// </summary>
    public List<string> InvolveMembers { get; set; } = [];

    /// <summary>
    /// 是否完成。
    /// </summary>
    public string? IsDone { get; set; }
}

/// <summary>
/// 自由任务详情。
/// </summary>
public class TeambitionOrganizationTaskDetail
{
    /// <summary>
    /// 备注。
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// 可见范围。
    /// </summary>
    public string? Visible { get; set; }

    /// <summary>
    /// 执行者 ID。
    /// </summary>
    public string? ExecutorId { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    public string? Created { get; set; }

    /// <summary>
    /// 截止时间。
    /// </summary>
    public string? DueDate { get; set; }

    /// <summary>
    /// 创建者 ID。
    /// </summary>
    public string? CreatorId { get; set; }

    /// <summary>
    /// 参与者 userId 列表。
    /// </summary>
    public List<string> InvolveMembers { get; set; } = [];

    /// <summary>
    /// 优先级。
    /// </summary>
    public int? Priority { get; set; }

    /// <summary>
    /// 是否完成。
    /// </summary>
    public bool? IsDone { get; set; }

    /// <summary>
    /// 标题。
    /// </summary>
    public string? Content { get; set; }

    /// <summary>
    /// 标签列表。
    /// </summary>
    public List<string> Labels { get; set; } = [];

    /// <summary>
    /// 是否已删除。
    /// </summary>
    public bool? IsDeleted { get; set; }

    /// <summary>
    /// 祖先任务 ID 列表。
    /// </summary>
    public List<string> AncestorIds { get; set; } = [];

    /// <summary>
    /// 任务 ID。
    /// </summary>
    public string? TaskId { get; set; }

    /// <summary>
    /// 更新时间。
    /// </summary>
    public string? Updated { get; set; }

    /// <summary>
    /// 开始时间。
    /// </summary>
    public string? StartDate { get; set; }
}

/// <summary>
/// 任务优先级。
/// </summary>
public class TeambitionPriority
{
    /// <summary>
    /// 颜色。
    /// </summary>
    public string? Color { get; set; }

    /// <summary>
    /// 名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 优先级 ID。
    /// </summary>
    public string? PriorityId { get; set; }

    /// <summary>
    /// 优先级值。
    /// </summary>
    public string? Priority { get; set; }
}

/// <summary>
/// 更新自由任务状态结果。
/// </summary>
public class TeambitionOrganizationTaskStateUpdateResult
{
    /// <summary>
    /// 是否完成。
    /// </summary>
    public bool IsDone { get; set; }

    /// <summary>
    /// 更新时间。
    /// </summary>
    public string? UpdateTime { get; set; }
}

/// <summary>
/// 更新自由任务执行者结果。
/// </summary>
public class TeambitionOrganizationExecutorUpdateResult : TeambitionExecutorUpdateResult
{
    /// <summary>
    /// 执行者。
    /// </summary>
    public TeambitionUser? Executor { get; set; }

    /// <summary>
    /// 参与者信息。
    /// </summary>
    public List<TeambitionUser> Involvers { get; set; } = [];
}

/// <summary>
/// 更新自由任务参与者结果。
/// </summary>
public class TeambitionOrganizationInvolversUpdateResult : TeambitionUpdatedResult
{
    /// <summary>
    /// 参与者信息。
    /// </summary>
    public List<TeambitionUser> Involvers { get; set; } = [];
}

/// <summary>
/// 计划工时返回结果。
/// </summary>
public class TeambitionPlanTimeResult
{
    /// <summary>
    /// 是否成功。
    /// </summary>
    public bool Ok { get; set; }

    /// <summary>
    /// 消息。
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// 工时明细。
    /// </summary>
    public List<TeambitionPlanTimeItem> Body { get; set; } = [];
}

/// <summary>
/// 计划工时明细。
/// </summary>
public class TeambitionPlanTimeItem
{
    /// <summary>
    /// 对象 ID。
    /// </summary>
    public string? ObjectId { get; set; }

    /// <summary>
    /// 日期。
    /// </summary>
    public string? Date { get; set; }

    /// <summary>
    /// 计划工时。
    /// </summary>
    public int? PlanTime { get; set; }
}

/// <summary>
/// 实际工时返回结果。
/// </summary>
public class TeambitionWorkTimeResult
{
    /// <summary>
    /// 是否成功。
    /// </summary>
    public bool Ok { get; set; }

    /// <summary>
    /// 消息。
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// 工时明细。
    /// </summary>
    public List<TeambitionWorkTimeItem> Body { get; set; } = [];
}

/// <summary>
/// 实际工时明细。
/// </summary>
public class TeambitionWorkTimeItem
{
    /// <summary>
    /// 任务 ID。
    /// </summary>
    public string? TaskId { get; set; }

    /// <summary>
    /// 日期。
    /// </summary>
    public string? Date { get; set; }

    /// <summary>
    /// 实际工时。
    /// </summary>
    public int? WorkTime { get; set; }
}

/// <summary>
/// Teambition 项目企业 ID。
/// </summary>
public class TeambitionOrganizationIdResult
{
    /// <summary>
    /// Teambition 项目企业 ID。
    /// </summary>
    public string? TbOrganizationId { get; set; }
}

/// <summary>
/// Teambition 项目用户 ID。
/// </summary>
public class TeambitionUserIdResult
{
    /// <summary>
    /// Teambition 项目用户 ID。
    /// </summary>
    public string? TbUserId { get; set; }
}

/// <summary>
/// 文件操作日志列表结果。
/// </summary>
public class TeambitionWorkspaceAuditLogListResult
{
    /// <summary>
    /// 文件操作日志列表。
    /// </summary>
    public List<TeambitionWorkspaceAuditLog> LogList { get; set; } = [];
}

/// <summary>
/// 文件操作日志。
/// </summary>
public class TeambitionWorkspaceAuditLog
{
    /// <summary>
    /// 操作类型。
    /// </summary>
    public string? Action { get; set; }

    /// <summary>
    /// 业务 ID。
    /// </summary>
    [JsonPropertyName("bizId")]
    public long? BizId { get; set; }

    /// <summary>
    /// 钉钉 ID。
    /// </summary>
    [JsonPropertyName("dingTalkId")]
    public long? DingTalkId { get; set; }

    /// <summary>
    /// 员工 ID。
    /// </summary>
    public string? EmpId { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    [JsonPropertyName("gmtCreate")]
    public long? GmtCreate { get; set; }

    /// <summary>
    /// 操作人名称。
    /// </summary>
    [JsonPropertyName("operatorName")]
    public string? OperatorName { get; set; }

    /// <summary>
    /// 企业名称。
    /// </summary>
    [JsonPropertyName("orgName")]
    public string? OrgName { get; set; }

    /// <summary>
    /// 操作平台。
    /// </summary>
    public string? Platform { get; set; }

    /// <summary>
    /// 项目名称。
    /// </summary>
    [JsonPropertyName("projectName")]
    public string? ProjectName { get; set; }

    /// <summary>
    /// 资源名称。
    /// </summary>
    public string? Resource { get; set; }

    /// <summary>
    /// 资源扩展名。
    /// </summary>
    [JsonPropertyName("resourceExtension")]
    public string? ResourceExtension { get; set; }

    /// <summary>
    /// 资源大小。
    /// </summary>
    [JsonPropertyName("resourceSize")]
    public long? ResourceSize { get; set; }

    /// <summary>
    /// 任务名称。
    /// </summary>
    [JsonPropertyName("taskName")]
    public string? TaskName { get; set; }

    /// <summary>
    /// IP 地址。
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>
    /// 接收人名称。
    /// </summary>
    [JsonPropertyName("receiverName")]
    public string? ReceiverName { get; set; }
}
