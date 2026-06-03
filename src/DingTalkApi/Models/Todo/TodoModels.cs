namespace DingTalkApi.Models.Todo;

/// <summary>
/// 创建钉钉个人待办任务请求。
/// </summary>
public class CreatePersonalTodoTaskRequest
{
    /// <summary>
    /// 待办标题，最大长度1024字节。
    /// </summary>
    public required string Subject { get; set; }

    /// <summary>
    /// 待办备注，最大长度4096字节。
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 截止时间，Unix时间戳，单位毫秒。
    /// </summary>
    public long? DueTime { get; set; }

    /// <summary>
    /// 执行者列表，需传用户的unionId，最大数量100。
    /// </summary>
    public required List<string> ExecutorIds { get; set; }

    /// <summary>
    /// 参与者列表，需传用户的unionId，最大长度100。
    /// </summary>
    public List<string>? ParticipantIds { get; set; }

    /// <summary>
    /// 通知提醒设置。
    /// </summary>
    public TodoNotifyConfigs? NotifyConfigs { get; set; }
}

/// <summary>
/// 创建钉钉个人待办任务响应。
/// </summary>
public class CreatePersonalTodoTaskResponse
{
    /// <summary>
    /// 待办ID。
    /// </summary>
    public required string TaskId { get; set; }

    /// <summary>
    /// 创建时间，Unix时间戳，单位毫秒。
    /// </summary>
    public long CreatedTime { get; set; }
}

/// <summary>
/// 创建钉钉待办任务请求。
/// </summary>
public class CreateTodoTaskRequest
{
    /// <summary>
    /// 业务系统侧的唯一标识ID，即业务ID。
    /// </summary>
    public string? SourceId { get; set; }

    /// <summary>
    /// 待办标题，最大长度1024。
    /// </summary>
    public required string Subject { get; set; }

    /// <summary>
    /// 创建者的unionId。
    /// </summary>
    public string? CreatorId { get; set; }

    /// <summary>
    /// 待办备注描述，最大长度4096。
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 截止时间，Unix时间戳，单位毫秒。
    /// </summary>
    public long? DueTime { get; set; }

    /// <summary>
    /// 执行者的unionId，最大数量1000。
    /// </summary>
    public List<string>? ExecutorIds { get; set; }

    /// <summary>
    /// 参与者的unionId，最大数量1000。
    /// </summary>
    public List<string>? ParticipantIds { get; set; }

    /// <summary>
    /// 详情页url跳转地址。创建第三方待办时需传入自身应用详情页链接，禁止使用 encode 编码后的 url。
    /// </summary>
    public TodoDetailUrl? DetailUrl { get; set; }

    /// <summary>
    /// 生成的待办是否仅展示在执行者的待办列表中。
    /// </summary>
    public bool? IsOnlyShowExecutor { get; set; }

    /// <summary>
    /// 优先级，取值：10较低，20普通，30紧急，40非常紧急。
    /// </summary>
    public int? Priority { get; set; }

    /// <summary>
    /// 待办通知配置。
    /// </summary>
    public TodoNotifyConfigs? NotifyConfigs { get; set; }
}

/// <summary>
/// 更新钉钉待办任务请求。
/// </summary>
public class UpdateTodoTaskRequest
{
    /// <summary>
    /// 待办标题。
    /// </summary>
    public required string Subject { get; set; }

    /// <summary>
    /// 待办描述。
    /// </summary>
    public required string Description { get; set; }

    /// <summary>
    /// 截止时间，Unix时间戳，单位毫秒。
    /// </summary>
    public long? DueTime { get; set; }

    /// <summary>
    /// 完成状态。
    /// </summary>
    public bool? Done { get; set; }

    /// <summary>
    /// 执行者的unionId列表，可通过根据userid获取用户详情接口获取。
    /// </summary>
    public required List<string> ExecutorIds { get; set; }

    /// <summary>
    /// 参与者的unionId列表，可通过根据userid获取用户详情接口获取。
    /// </summary>
    public required List<string> ParticipantIds { get; set; }
}

/// <summary>
/// 更新钉钉待办执行者状态请求。
/// </summary>
public class UpdateTodoTaskExecutorStatusRequest
{
    /// <summary>
    /// 执行者状态列表，id需传用户的unionId。
    /// </summary>
    public List<TodoExecutorStatus> ExecutorStatusList { get; set; } = [];
}

/// <summary>
/// 查询企业下用户待办列表请求。
/// </summary>
public class QueryOrgTodoTasksRequest
{
    /// <summary>
    /// 分页游标。分页token为null表示数据已经全部查询完毕。
    /// </summary>
    public string? NextToken { get; set; }

    /// <summary>
    /// 待办完成状态。
    /// </summary>
    public bool? IsDone { get; set; }
}

/// <summary>
/// 钉钉待办任务响应。
/// </summary>
public class TodoTaskResponse
{
    /// <summary>
    /// 待办ID。
    /// </summary>
    public required string Id { get; set; }

    /// <summary>
    /// 待办的标题。
    /// </summary>
    public required string Subject { get; set; }

    /// <summary>
    /// 待办描述。
    /// </summary>
    public required string Description { get; set; }

    /// <summary>
    /// 开始时间，Unix时间戳，单位毫秒。
    /// </summary>
    public long StartTime { get; set; }

    /// <summary>
    /// 截止时间，Unix时间戳，单位毫秒。
    /// </summary>
    public long DueTime { get; set; }

    /// <summary>
    /// 完成时间，Unix时间戳，单位毫秒。
    /// </summary>
    public long FinishTime { get; set; }

    /// <summary>
    /// 完成状态。
    /// </summary>
    public bool Done { get; set; }

    /// <summary>
    /// 执行者的unionId。
    /// </summary>
    public required List<string> ExecutorIds { get; set; }

    /// <summary>
    /// 参与者的unionId。
    /// </summary>
    public required List<string> ParticipantIds { get; set; }

    /// <summary>
    /// 详情页url跳转地址。
    /// </summary>
    public required TodoDetailUrl DetailUrl { get; set; }

    /// <summary>
    /// 业务来源。
    /// </summary>
    public required string Source { get; set; }

    /// <summary>
    /// 业务系统侧的唯一标识ID，即业务ID。
    /// </summary>
    public required string SourceId { get; set; }

    /// <summary>
    /// 创建时间，Unix时间戳，单位毫秒。
    /// </summary>
    public long CreatedTime { get; set; }

    /// <summary>
    /// 更新时间，Unix时间戳，单位毫秒。
    /// </summary>
    public long ModifiedTime { get; set; }

    /// <summary>
    /// 创建者的unionId。
    /// </summary>
    public required string CreatorId { get; set; }

    /// <summary>
    /// 更新者的unionId。
    /// </summary>
    public required string ModifierId { get; set; }

    /// <summary>
    /// 接入应用标识。
    /// </summary>
    public required string BizTag { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    public required string RequestId { get; set; }

    /// <summary>
    /// 生成的待办是否仅展示在执行者的待办列表中。
    /// </summary>
    public bool IsOnlyShowExecutor { get; set; }

    /// <summary>
    /// 优先级，取值：10较低，20普通，30紧急，40非常紧急。
    /// </summary>
    public int Priority { get; set; }

    /// <summary>
    /// 待办通知配置。
    /// </summary>
    public required TodoNotifyConfigs NotifyConfigs { get; set; }
}

/// <summary>
/// 待办布尔操作响应。
/// </summary>
public class TodoBooleanResponse
{
    /// <summary>
    /// 操作结果。
    /// </summary>
    public bool Result { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    public string? RequestId { get; set; }
}

/// <summary>
/// 查询企业下用户待办列表响应。
/// </summary>
public class QueryOrgTodoTasksResponse
{
    /// <summary>
    /// 下一次请求的token。
    /// </summary>
    public string? NextToken { get; set; }

    /// <summary>
    /// 待办卡片列表。
    /// </summary>
    public List<TodoCard> TodoCards { get; set; } = [];
}

/// <summary>
/// 待办卡片。
/// </summary>
public class TodoCard
{
    /// <summary>
    /// 待办ID。
    /// </summary>
    public string? TaskId { get; set; }

    /// <summary>
    /// 待办标题。
    /// </summary>
    public string? Subject { get; set; }

    /// <summary>
    /// 待办截止时间。
    /// </summary>
    public long? DueTime { get; set; }

    /// <summary>
    /// 详情页链接。
    /// </summary>
    public TodoDetailUrl? DetailUrl { get; set; }

    /// <summary>
    /// 优先级。
    /// </summary>
    public int? Priority { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    public long? CreatedTime { get; set; }

    /// <summary>
    /// 更新时间。
    /// </summary>
    public long? ModifiedTime { get; set; }

    /// <summary>
    /// 创建者ID。
    /// </summary>
    public string? CreatorId { get; set; }

    /// <summary>
    /// 来源ID。
    /// </summary>
    public string? SourceId { get; set; }

    /// <summary>
    /// 所属应用。
    /// </summary>
    public string? BizTag { get; set; }

    /// <summary>
    /// 待办完成状态。
    /// </summary>
    public bool? IsDone { get; set; }
}

/// <summary>
/// 详情页url跳转地址。
/// </summary>
public class TodoDetailUrl
{
    /// <summary>
    /// APP端详情页url跳转地址。
    /// </summary>
    public string? AppUrl { get; set; }

    /// <summary>
    /// PC端详情页url跳转地址。
    /// </summary>
    public string? PcUrl { get; set; }
}

/// <summary>
/// 待办通知配置。
/// </summary>
public class TodoNotifyConfigs
{
    /// <summary>
    /// DING通知配置，目前仅支持取值为1，表示应用内DING。
    /// </summary>
    public string? DingNotify { get; set; }
}

/// <summary>
/// 待办执行者状态。
/// </summary>
public class TodoExecutorStatus
{
    /// <summary>
    /// 执行者的unionId。
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// 执行者完成状态。
    /// </summary>
    public bool? IsDone { get; set; }
}
