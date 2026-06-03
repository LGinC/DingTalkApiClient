using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models.Workflow;

/// <summary>
/// 创建或更新审批表单模板请求
/// </summary>
public class WorkflowCreateOrUpdateFormRequest
{
    /// <summary>
    /// 表单ProcessCode，未填写表示新建模板，填写表示更新对应审批模板。
    /// </summary>
    public string? ProcessCode { get; set; }

    /// <summary>
    /// 表单模板名称。
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 表单模板描述。
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 表单控件列表，单一表单最大组件个数不超过200。
    /// </summary>
    public required List<WorkflowFormComponent> FormComponents { get; set; }

    /// <summary>
    /// 表单全局属性配置。
    /// </summary>
    public WorkflowTemplateConfig? TemplateConfig { get; set; }
}

/// <summary>
/// 创建或更新审批表单模板响应
/// </summary>
public class WorkflowCreateOrUpdateFormResponse
{
    /// <summary>
    /// 返回的表单模板信息。
    /// </summary>
    public required string Result { get; set; }
}

/// <summary>
/// 表单组件
/// </summary>
public class WorkflowFormComponent
{
    /// <summary>
    /// 控件类型。
    /// </summary>
    public required string ComponentType { get; set; }

    /// <summary>
    /// 控件属性。
    /// </summary>
    public WorkflowFormComponentProps? Props { get; set; }

    /// <summary>
    /// 容器类控件的子控件列表。
    /// </summary>
    public List<WorkflowFormComponent> Children { get; set; } = [];
}

/// <summary>
/// 表单组件属性
/// </summary>
public class WorkflowFormComponentProps
{
    /// <summary>
    /// 控件ID，表单内唯一，与业务标识二选一。
    /// </summary>
    public string? ComponentId { get; set; }

    /// <summary>
    /// 控件标题。
    /// </summary>
    public string? Label { get; set; }

    /// <summary>
    /// 说明文字内容。
    /// </summary>
    public string? Content { get; set; }

    /// <summary>
    /// 日期或展示格式。
    /// </summary>
    public string? Format { get; set; }

    /// <summary>
    /// 金额或统计字段是否需要大写。
    /// </summary>
    public string? Upper { get; set; }

    /// <summary>
    /// 数字、日期等控件的单位。
    /// </summary>
    public string? Unit { get; set; }

    /// <summary>
    /// 输入或选择提示。
    /// </summary>
    public string? Placeholder { get; set; }

    /// <summary>
    /// 控件业务标识，表单内唯一，与控件ID二选一。
    /// </summary>
    public string? BizAlias { get; set; }

    /// <summary>
    /// 控件业务类型。
    /// </summary>
    public string? BizType { get; set; }

    /// <summary>
    /// 联系人等控件的选择方式。
    /// </summary>
    public string? Choice { get; set; }

    /// <summary>
    /// 控件是否必填。
    /// </summary>
    public bool? Required { get; set; }

    /// <summary>
    /// 控件是否不可编辑。
    /// </summary>
    public bool? Disabled { get; set; }

    /// <summary>
    /// 时间区间控件是否自动计算时长。
    /// </summary>
    public bool? Duration { get; set; }

    /// <summary>
    /// 部门等控件是否支持多选。
    /// </summary>
    public bool? Multiple { get; set; }

    /// <summary>
    /// 控件默认值。
    /// </summary>
    public string? DefaultValue { get; set; }

    /// <summary>
    /// 是否参与打印，0表示不参与打印，1表示可打印。
    /// </summary>
    public string? Print { get; set; }

    /// <summary>
    /// 文字说明控件的超链接。
    /// </summary>
    public string? Link { get; set; }

    /// <summary>
    /// 电话等控件的模式。
    /// </summary>
    public string? Mode { get; set; }

    /// <summary>
    /// 省市区控件地址模型，支持city、district、street等。
    /// </summary>
    public string? AddressModel { get; set; }

    /// <summary>
    /// 评分控件分制。
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// 明细控件填写方式，支持list或table。
    /// </summary>
    public string? TableViewMode { get; set; }

    /// <summary>
    /// 明细打印方式，true表示纵向，false表示横向。
    /// </summary>
    public bool? VerticalPrint { get; set; }

    /// <summary>
    /// 可选选项列表。
    /// </summary>
    public List<WorkflowFormComponentOption> Options { get; set; } = [];

    /// <summary>
    /// 数字、金额类控件统计字段配置。
    /// </summary>
    public List<WorkflowFormComponentStatField> StatField { get; set; } = [];

    /// <summary>
    /// 关联审批单控件可关联的审批模板列表。
    /// </summary>
    public List<WorkflowAvailableTemplate> AvailableTemplates { get; set; } = [];

    /// <summary>
    /// YAML中未显式建模的组件扩展属性。
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object?>? ExtensionData { get; set; }
}

/// <summary>
/// 表单组件选项
/// </summary>
public class WorkflowFormComponentOption
{
    /// <summary>
    /// 控件内唯一选项Key，未传时系统默认生成。
    /// </summary>
    public string? Key { get; set; }

    /// <summary>
    /// 选项显示名称。
    /// </summary>
    public string? Value { get; set; }
}

/// <summary>
/// 表单组件统计字段
/// </summary>
public class WorkflowFormComponentStatField
{
    /// <summary>
    /// 统计结果是否需要大写。
    /// </summary>
    public string? Upper { get; set; }

    /// <summary>
    /// 被统计控件ID。
    /// </summary>
    public string? ComponentId { get; set; }

    /// <summary>
    /// 被统计控件标题。
    /// </summary>
    public string? Label { get; set; }
}

/// <summary>
/// 可关联审批模板
/// </summary>
public class WorkflowAvailableTemplate
{
    /// <summary>
    /// 可关联的审批表单名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 可关联的审批表单ProcessCode。
    /// </summary>
    public string? ProcessCode { get; set; }
}

/// <summary>
/// 审批模板配置
/// </summary>
public class WorkflowTemplateConfig
{
    /// <summary>
    /// 是否禁用表单编辑。
    /// </summary>
    public bool? DisableFormEdit { get; set; }

    /// <summary>
    /// 模板是否隐藏。
    /// </summary>
    public bool? Hidden { get; set; }

    /// <summary>
    /// YAML中未显式建模的模板配置扩展属性。
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object?>? ExtensionData { get; set; }
}

/// <summary>
/// 获取表单schema响应
/// </summary>
public class WorkflowFormSchemaResponse
{
    /// <summary>
    /// 返回结果详情。
    /// </summary>
    public required WorkflowFormSchema Result { get; set; }
}

/// <summary>
/// 表单schema
/// </summary>
public class WorkflowFormSchema
{
    /// <summary>
    /// 表单的唯一码。
    /// </summary>
    public string? ProcessCode { get; set; }

    /// <summary>
    /// 表单名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 说明文案。
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 表单schema中的控件列表。
    /// </summary>
    public List<WorkflowFormComponent> FormComponents { get; set; } = [];

    /// <summary>
    /// 表单全局属性配置。
    /// </summary>
    public WorkflowTemplateConfig? TemplateConfig { get; set; }
}

/// <summary>
/// 获取审批单流程中的节点信息请求
/// </summary>
public class WorkflowProcessForecastRequest
{
    /// <summary>
    /// 请求ID。
    /// </summary>
    public required string RequestId { get; set; }

    /// <summary>
    /// 审批流的唯一码。
    /// </summary>
    public required string ProcessCode { get; set; }

    /// <summary>
    /// 即将发起审批单的员工所在部门ID。
    /// </summary>
    public required long DeptId { get; set; }

    /// <summary>
    /// 即将发起审批单的员工userId值。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 表单数据内容，控件列表，最大列表长度150。
    /// </summary>
    public required List<WorkflowFormComponentValue> FormComponentValues { get; set; }
}

/// <summary>
/// 获取审批单流程中的节点信息响应
/// </summary>
public class WorkflowProcessForecastResponse
{
    /// <summary>
    /// 返回结果详情。
    /// </summary>
    public required WorkflowProcessForecastResult Result { get; set; }
}

/// <summary>
/// 审批流程预测结果
/// </summary>
public class WorkflowProcessForecastResult
{
    /// <summary>
    /// 工作流节点规则。
    /// </summary>
    public List<WorkflowProcessForecastActivity> Activities { get; set; } = [];
}

/// <summary>
/// 审批流程预测节点
/// </summary>
public class WorkflowProcessForecastActivity
{
    /// <summary>
    /// 节点ID。
    /// </summary>
    public string? ActivityId { get; set; }

    /// <summary>
    /// 节点名称。
    /// </summary>
    public string? ActivityName { get; set; }

    /// <summary>
    /// 规则类型。
    /// </summary>
    public string? ActivityType { get; set; }

    /// <summary>
    /// 节点操作人userId列表。
    /// </summary>
    public List<string> UserIds { get; set; } = [];

    /// <summary>
    /// 节点操作人信息。
    /// </summary>
    public List<WorkflowProcessForecastUser> Users { get; set; } = [];
}

/// <summary>
/// 审批流程预测用户
/// </summary>
public class WorkflowProcessForecastUser
{
    /// <summary>
    /// 员工userId。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// 员工姓名。
    /// </summary>
    public string? Name { get; set; }
}

/// <summary>
/// 获取指定用户可见的审批表单列表响应
/// </summary>
public class WorkflowVisibleTemplatesResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    public required WorkflowVisibleTemplatesResult Result { get; set; }
}

/// <summary>
/// 用户可见审批表单分页结果
/// </summary>
public class WorkflowVisibleTemplatesResult
{
    /// <summary>
    /// 是否还有更多数据。
    /// </summary>
    public bool HasMore { get; set; }

    /// <summary>
    /// 分页游标，不为空表示有更多数据。
    /// </summary>
    public string? NextToken { get; set; }

    /// <summary>
    /// 可见表单列表。
    /// </summary>
    public List<WorkflowTemplateInfo> List { get; set; } = [];
}

/// <summary>
/// 获取当前企业所有可管理的表单响应
/// </summary>
public class WorkflowManageableTemplatesResponse
{
    /// <summary>
    /// 模板列表。
    /// </summary>
    public List<WorkflowTemplateInfo> Result { get; set; } = [];

    /// <summary>
    /// 接口调用是否成功。
    /// </summary>
    public bool Success { get; set; }
}

/// <summary>
/// 审批模板信息
/// </summary>
public class WorkflowTemplateInfo
{
    /// <summary>
    /// 表单或模板名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 表单唯一标识或模板code。
    /// </summary>
    public string? ProcessCode { get; set; }

    /// <summary>
    /// 图标URL。
    /// </summary>
    public string? IconUrl { get; set; }

    /// <summary>
    /// 表单URL。
    /// </summary>
    public string? Url { get; set; }
}

/// <summary>
/// 发起审批实例请求
/// </summary>
public class WorkflowCreateProcessInstanceRequest
{
    /// <summary>
    /// 审批发起人的userId。
    /// </summary>
    public required string OriginatorUserId { get; set; }

    /// <summary>
    /// 审批流的唯一码。
    /// </summary>
    public required string ProcessCode { get; set; }

    /// <summary>
    /// 不使用审批流模板时直接指定的审批人列表，最大列表长度20。
    /// </summary>
    public List<WorkflowApprover> Approvers { get; set; } = [];

    /// <summary>
    /// 抄送人userId列表，最大列表长度50。
    /// </summary>
    public List<string> CcList { get; set; } = [];

    /// <summary>
    /// 抄送时间点，支持START、FINISH、START_FINISH。
    /// </summary>
    public string? CcPosition { get; set; }

    /// <summary>
    /// 使用审批流模板时自选操作人列表，最大列表长度20。
    /// </summary>
    public List<WorkflowTargetSelectActioner> TargetSelectActioners { get; set; } = [];

    /// <summary>
    /// 表单数据内容，控件列表，最大列表长度150。
    /// </summary>
    public required List<WorkflowFormComponentValue> FormComponentValues { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    public required string RequestId { get; set; }
}

/// <summary>
/// 发起审批实例响应
/// </summary>
public class WorkflowCreateProcessInstanceResponse
{
    /// <summary>
    /// 审批实例ID。
    /// </summary>
    public required string InstanceId { get; set; }
}

/// <summary>
/// 审批人
/// </summary>
public class WorkflowApprover
{
    /// <summary>
    /// 审批动作类型。
    /// </summary>
    public string? ActionType { get; set; }

    /// <summary>
    /// 审批人userId列表。
    /// </summary>
    public List<string> UserIds { get; set; } = [];
}

/// <summary>
/// 自选操作人
/// </summary>
public class WorkflowTargetSelectActioner
{
    /// <summary>
    /// 自选节点的规则Key。
    /// </summary>
    public string? ActionerKey { get; set; }

    /// <summary>
    /// 操作人userId列表。
    /// </summary>
    public List<string> ActionerUserIds { get; set; } = [];
}

/// <summary>
/// 表单控件值
/// </summary>
public class WorkflowFormComponentValue
{
    /// <summary>
    /// 控件名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 控件值。
    /// </summary>
    public string? Value { get; set; }

    /// <summary>
    /// 控件类型。
    /// </summary>
    public string? ComponentType { get; set; }

    /// <summary>
    /// 控件业务标识。
    /// </summary>
    public string? BizAlias { get; set; }

    /// <summary>
    /// 控件扩展值。
    /// </summary>
    public string? ExtValue { get; set; }

    /// <summary>
    /// 控件ID。
    /// </summary>
    public string? Id { get; set; }
}

/// <summary>
/// 获取单个审批实例详情响应
/// </summary>
public class WorkflowProcessInstanceResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    public required WorkflowProcessInstance Result { get; set; }

    /// <summary>
    /// 接口调用是否成功。
    /// </summary>
    public bool Success { get; set; }
}

/// <summary>
/// 审批实例详情
/// </summary>
public class WorkflowProcessInstance
{
    /// <summary>
    /// 审批实例ID。
    /// </summary>
    public string? ProcessInstanceId { get; set; }

    /// <summary>
    /// 审批实例标题。
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 审批流的唯一码。
    /// </summary>
    public string? ProcessCode { get; set; }

    /// <summary>
    /// 发起人的userId。
    /// </summary>
    public string? OriginatorUserId { get; set; }

    /// <summary>
    /// 审批状态。
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// 审批结果，agree表示同意，refuse表示拒绝。
    /// </summary>
    public string? Result { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    public long? CreateTime { get; set; }

    /// <summary>
    /// 结束时间。
    /// </summary>
    public long? FinishTime { get; set; }

    /// <summary>
    /// 表单数据内容。
    /// </summary>
    public List<WorkflowFormComponentValue> FormComponentValues { get; set; } = [];

    /// <summary>
    /// 任务列表。
    /// </summary>
    public List<WorkflowTaskInfo> Tasks { get; set; } = [];

    /// <summary>
    /// 操作记录列表。
    /// </summary>
    public List<WorkflowOperationRecord> OperationRecords { get; set; } = [];
}

/// <summary>
/// 审批任务信息
/// </summary>
public class WorkflowTaskInfo
{
    /// <summary>
    /// 任务ID。
    /// </summary>
    public long? TaskId { get; set; }

    /// <summary>
    /// 任务处理人userId。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// 任务状态。
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// 任务处理结果。
    /// </summary>
    public string? Result { get; set; }

    /// <summary>
    /// 任务开始时间。
    /// </summary>
    public long? CreateTime { get; set; }

    /// <summary>
    /// 任务完成时间。
    /// </summary>
    public long? FinishTime { get; set; }

    /// <summary>
    /// 待办组ID或节点ID。
    /// </summary>
    public string? ActivityId { get; set; }
}

/// <summary>
/// 审批操作记录
/// </summary>
public class WorkflowOperationRecord
{
    /// <summary>
    /// 操作人userId。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// 操作类型。
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// 操作结果。
    /// </summary>
    public string? Result { get; set; }

    /// <summary>
    /// 操作时间。
    /// </summary>
    public long? Date { get; set; }

    /// <summary>
    /// 评论内容。
    /// </summary>
    public string? Remark { get; set; }
}

/// <summary>
/// 撤销审批实例请求
/// </summary>
public class WorkflowTerminateProcessInstanceRequest
{
    /// <summary>
    /// 审批实例ID。
    /// </summary>
    public required string ProcessInstanceId { get; set; }

    /// <summary>
    /// 撤销备注。
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 操作人userId。
    /// </summary>
    public string? OperatingUserId { get; set; }
}

/// <summary>
/// 添加审批评论请求
/// </summary>
public class WorkflowAddProcessInstanceCommentRequest
{
    /// <summary>
    /// 审批实例ID。
    /// </summary>
    public required string ProcessInstanceId { get; set; }

    /// <summary>
    /// 评论文本。
    /// </summary>
    public required string Text { get; set; }

    /// <summary>
    /// 评论人userId。
    /// </summary>
    public required string CommentUserId { get; set; }

    /// <summary>
    /// 评论附件。
    /// </summary>
    public WorkflowFileInfo? File { get; set; }
}

/// <summary>
/// 布尔结果响应
/// </summary>
public class WorkflowBooleanResultResponse
{
    /// <summary>
    /// 操作结果。
    /// </summary>
    public bool Result { get; set; }

    /// <summary>
    /// 接口调用是否成功。
    /// </summary>
    public bool Success { get; set; }
}

/// <summary>
/// 获取审批实例ID列表请求
/// </summary>
public class WorkflowProcessInstanceIdsQueryRequest
{
    /// <summary>
    /// 审批模板唯一标识。
    /// </summary>
    public required string ProcessCode { get; set; }

    /// <summary>
    /// 查询开始时间。
    /// </summary>
    public required long StartTime { get; set; }

    /// <summary>
    /// 查询结束时间。
    /// </summary>
    public required long EndTime { get; set; }

    /// <summary>
    /// 分页游标。
    /// </summary>
    public required string NextToken { get; set; }

    /// <summary>
    /// 分页大小，最大值10。
    /// </summary>
    public required long MaxResults { get; set; }

    /// <summary>
    /// 发起人userId列表，最大长度10。
    /// </summary>
    public List<string> UserIds { get; set; } = [];

    /// <summary>
    /// 流程实例状态列表，未传表示查询所有状态。
    /// </summary>
    public List<string> Statuses { get; set; } = [];
}

/// <summary>
/// 获取审批实例ID列表响应
/// </summary>
public class WorkflowProcessInstanceIdsResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    public required WorkflowProcessInstanceIdsResult Result { get; set; }

    /// <summary>
    /// 接口请求是否成功。
    /// </summary>
    public bool Success { get; set; }
}

/// <summary>
/// 审批实例ID分页结果
/// </summary>
public class WorkflowProcessInstanceIdsResult
{
    /// <summary>
    /// 是否还有更多数据。
    /// </summary>
    public bool HasMore { get; set; }

    /// <summary>
    /// 分页游标，不为空表示有更多数据。
    /// </summary>
    public string? NextToken { get; set; }

    /// <summary>
    /// 审批实例ID列表。
    /// </summary>
    public List<string> List { get; set; } = [];
}

/// <summary>
/// 获取审批钉盘空间信息请求
/// </summary>
public class WorkflowSpaceInfoRequest
{
    /// <summary>
    /// 用户的userId。
    /// </summary>
    public required string UserId { get; set; }
}

/// <summary>
/// 获取审批钉盘空间信息响应
/// </summary>
public class WorkflowSpaceInfoResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    public required WorkflowSpaceInfo Result { get; set; }

    /// <summary>
    /// 接口调用是否成功。
    /// </summary>
    public bool Success { get; set; }
}

/// <summary>
/// 审批钉盘空间信息
/// </summary>
public class WorkflowSpaceInfo
{
    /// <summary>
    /// 钉盘空间ID。
    /// </summary>
    public string? SpaceId { get; set; }

    /// <summary>
    /// 企业ID。
    /// </summary>
    public string? CorpId { get; set; }
}

/// <summary>
/// 授权预览审批附件请求
/// </summary>
public class WorkflowAuthorizeFilePreviewRequest
{
    /// <summary>
    /// 授权允许预览附件的用户userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 审批实例ID。
    /// </summary>
    public required string ProcessInstanceId { get; set; }

    /// <summary>
    /// 审批附件ID。
    /// </summary>
    public required string FileId { get; set; }

    /// <summary>
    /// 附件ID列表，支持批量授权，最大列表长度20。
    /// </summary>
    public List<string> FileIdList { get; set; } = [];
}

/// <summary>
/// 授权下载审批钉盘文件请求
/// </summary>
public class WorkflowAuthorizeFileDownloadRequest
{
    /// <summary>
    /// 授权的用户userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 授权的钉盘文件信息列表，支持批量授权，最大列表长度10。
    /// </summary>
    public required List<WorkflowFileInfo> FileInfos { get; set; }
}

/// <summary>
/// 下载审批附件请求
/// </summary>
public class WorkflowDownloadFileUrlRequest
{
    /// <summary>
    /// 审批实例ID。
    /// </summary>
    public required string ProcessInstanceId { get; set; }

    /// <summary>
    /// 文件fileId。
    /// </summary>
    public required string FileId { get; set; }
}

/// <summary>
/// 下载审批附件响应
/// </summary>
public class WorkflowDownloadFileUrlResponse
{
    /// <summary>
    /// 文件下载地址。
    /// </summary>
    public required string Result { get; set; }

    /// <summary>
    /// 接口调用是否成功。
    /// </summary>
    public bool Success { get; set; }
}

/// <summary>
/// 同意或拒绝审批任务请求
/// </summary>
public class WorkflowExecuteProcessInstanceTaskRequest
{
    /// <summary>
    /// 审批实例ID。
    /// </summary>
    public required string ProcessInstanceId { get; set; }

    /// <summary>
    /// 审批意见，可为空。
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 审批操作，agree表示同意，refuse表示拒绝。
    /// </summary>
    public required string Result { get; set; }

    /// <summary>
    /// 操作人userId。
    /// </summary>
    public required string ActionerUserId { get; set; }

    /// <summary>
    /// 任务ID。
    /// </summary>
    public required string TaskId { get; set; }

    /// <summary>
    /// 审批操作附件。
    /// </summary>
    public WorkflowFileInfo? File { get; set; }
}

/// <summary>
/// 转交OA审批任务请求
/// </summary>
public class WorkflowRedirectTaskRequest
{
    /// <summary>
    /// OA审批任务被转交对象的用户userId。
    /// </summary>
    public required string ToUserId { get; set; }

    /// <summary>
    /// OA审批任务ID。
    /// </summary>
    public required string TaskId { get; set; }

    /// <summary>
    /// 转交备注信息。
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 操作人userId，需要跟任务的当前执行人保持一致。
    /// </summary>
    public required string OperateUserId { get; set; }

    /// <summary>
    /// 操作节点名。
    /// </summary>
    public string? ActionName { get; set; }

    /// <summary>
    /// 转交附件。
    /// </summary>
    public WorkflowFileInfo? File { get; set; }
}

/// <summary>
/// 审批附件或钉盘文件信息
/// </summary>
public class WorkflowFileInfo
{
    /// <summary>
    /// 文件fileId。
    /// </summary>
    public string? FileId { get; set; }

    /// <summary>
    /// 文件名。
    /// </summary>
    public string? FileName { get; set; }

    /// <summary>
    /// 审批钉盘空间spaceId。
    /// </summary>
    public string? SpaceId { get; set; }

    /// <summary>
    /// 文件大小。
    /// </summary>
    public string? FileSize { get; set; }

    /// <summary>
    /// 文件类型。
    /// </summary>
    public string? FileType { get; set; }
}

/// <summary>
/// 获取用户待审批数量响应
/// </summary>
public class WorkflowTodoTaskNumberResponse
{
    /// <summary>
    /// 待处理的审批数量。
    /// </summary>
    public long Result { get; set; }
}

/// <summary>
/// 创建或更新流程中心审批模板请求
/// </summary>
public class WorkflowCreateOrUpdateProcessCentreSchemaRequest : WorkflowCreateOrUpdateFormRequest
{
    /// <summary>
    /// 流程中心集成配置。
    /// </summary>
    public WorkflowProcessFeatureConfig? ProcessFeatureConfig { get; set; }
}

/// <summary>
/// 创建或更新流程中心审批模板响应
/// </summary>
public class WorkflowCreateOrUpdateProcessCentreSchemaResponse
{
    /// <summary>
    /// 表单模板信息。
    /// </summary>
    public required WorkflowProcessCentreSchemaResult Result { get; set; }
}

/// <summary>
/// 流程中心模板信息
/// </summary>
public class WorkflowProcessCentreSchemaResult
{
    /// <summary>
    /// 保存或更新的表单code。
    /// </summary>
    public string? ProcessCode { get; set; }
}

/// <summary>
/// 流程中心集成配置
/// </summary>
public class WorkflowProcessFeatureConfig
{
    /// <summary>
    /// 是否启用流程中心集成。
    /// </summary>
    public bool? IsIntegration { get; set; }

    /// <summary>
    /// YAML中未显式建模的流程中心集成配置扩展属性。
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object?>? ExtensionData { get; set; }
}

/// <summary>
/// 获取模板code响应
/// </summary>
public class WorkflowProcessCentreSchemaCodeResponse
{
    /// <summary>
    /// 表单模板的code。
    /// </summary>
    public required string Result { get; set; }
}

/// <summary>
/// 创建流程中心实例请求
/// </summary>
public class WorkflowCreateProcessCentreInstanceRequest
{
    /// <summary>
    /// 审批模板code。
    /// </summary>
    public required string ProcessCode { get; set; }

    /// <summary>
    /// 审批实例发起人的userId。
    /// </summary>
    public required string OriginatorUserId { get; set; }

    /// <summary>
    /// 表单控件值列表。
    /// </summary>
    public required List<WorkflowFormComponentValue> FormComponentValueList { get; set; }

    /// <summary>
    /// 实例标题。
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 第三方审批系统中审批单详情页地址。
    /// </summary>
    public required string Url { get; set; }

    /// <summary>
    /// 抄送信息列表。
    /// </summary>
    public List<WorkflowProcessCentreNotifier> Notifiers { get; set; } = [];

    /// <summary>
    /// 用户自定义业务参数，JSON字符串格式。
    /// </summary>
    public string? BizData { get; set; }
}

/// <summary>
/// 创建流程中心实例响应
/// </summary>
public class WorkflowCreateProcessCentreInstanceResponse
{
    /// <summary>
    /// 实例ID。
    /// </summary>
    public required string Result { get; set; }
}

/// <summary>
/// 流程中心抄送信息
/// </summary>
public class WorkflowProcessCentreNotifier
{
    /// <summary>
    /// 抄送人userId。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// 抄送类型或位置。
    /// </summary>
    public string? Type { get; set; }
}

/// <summary>
/// 更新流程中心实例状态请求
/// </summary>
public class WorkflowUpdateProcessCentreInstanceRequest
{
    /// <summary>
    /// 审批实例ID。
    /// </summary>
    public required string ProcessInstanceId { get; set; }

    /// <summary>
    /// 实例状态，COMPLETED表示结束审批流，TERMINATED表示终止审批流。
    /// </summary>
    public required string Status { get; set; }

    /// <summary>
    /// 实例结果，agree表示同意，refuse表示拒绝。
    /// </summary>
    public required string Result { get; set; }

    /// <summary>
    /// 抄送人列表，最大值30。
    /// </summary>
    public List<WorkflowProcessCentreNotifier> Notifiers { get; set; } = [];
}

/// <summary>
/// 批量更新流程中心实例状态请求
/// </summary>
public class WorkflowBatchUpdateProcessCentreInstancesRequest
{
    /// <summary>
    /// 实例列表，最大值50。
    /// </summary>
    public List<WorkflowUpdateProcessCentreInstanceRequest> UpdateProcessInstanceRequests { get; set; } = [];
}

/// <summary>
/// 成功状态响应
/// </summary>
public class WorkflowSuccessResponse
{
    /// <summary>
    /// 操作是否成功。
    /// </summary>
    public bool Success { get; set; }
}

/// <summary>
/// 创建流程中心待处理任务请求
/// </summary>
public class WorkflowCreateProcessCentreTaskRequest
{
    /// <summary>
    /// OA审批流程实例ID。
    /// </summary>
    public required string ProcessInstanceId { get; set; }

    /// <summary>
    /// 自定义审批节点ID。
    /// </summary>
    public string? ActivityId { get; set; }

    /// <summary>
    /// 任务列表。
    /// </summary>
    public required List<WorkflowProcessCentreTaskRequestItem> Tasks { get; set; }
}

/// <summary>
/// 流程中心待处理任务请求项
/// </summary>
public class WorkflowProcessCentreTaskRequestItem
{
    /// <summary>
    /// 钉钉用户userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 待办组ID或自定义审批节点ID。
    /// </summary>
    public string? ActivityId { get; set; }

    /// <summary>
    /// 待办事项跳转URL。
    /// </summary>
    public string? Url { get; set; }
}

/// <summary>
/// 创建流程中心待处理任务响应
/// </summary>
public class WorkflowCreateProcessCentreTaskResponse
{
    /// <summary>
    /// 返回结果列表。
    /// </summary>
    public List<WorkflowCreateProcessCentreTaskResultItem> Result { get; set; } = [];

    /// <summary>
    /// 是否创建成功。
    /// </summary>
    public bool Success { get; set; }
}

/// <summary>
/// 创建流程中心待处理任务结果项
/// </summary>
public class WorkflowCreateProcessCentreTaskResultItem
{
    /// <summary>
    /// OA审批任务ID。
    /// </summary>
    public long TaskId { get; set; }

    /// <summary>
    /// OA审批任务执行人用户userId。
    /// </summary>
    public string? UserId { get; set; }
}

/// <summary>
/// 更新流程中心任务状态请求
/// </summary>
public class WorkflowUpdateProcessCentreTaskRequest
{
    /// <summary>
    /// OA审批流程实例ID。
    /// </summary>
    public required string ProcessInstanceId { get; set; }

    /// <summary>
    /// OA审批任务列表。
    /// </summary>
    public required List<WorkflowUpdateProcessCentreTaskItem> Tasks { get; set; }
}

/// <summary>
/// 更新流程中心任务状态项
/// </summary>
public class WorkflowUpdateProcessCentreTaskItem
{
    /// <summary>
    /// 更新为目标任务状态，CANCELED表示撤销，COMPLETED表示完成。
    /// </summary>
    public required string Status { get; set; }

    /// <summary>
    /// OA审批任务ID。
    /// </summary>
    public required string TaskId { get; set; }

    /// <summary>
    /// 任务结果，AGREE表示同意，REFUSE表示拒绝。
    /// </summary>
    public string? Result { get; set; }
}

/// <summary>
/// 查询通过流程中心集成的OA审批任务响应
/// </summary>
public class WorkflowProcessCentreTodoTasksResponse
{
    /// <summary>
    /// 请求ID。
    /// </summary>
    public required string RequestId { get; set; }

    /// <summary>
    /// 分页结果封装。
    /// </summary>
    public required WorkflowProcessCentreTaskPage TaskPage { get; set; }
}

/// <summary>
/// 流程中心任务分页结果
/// </summary>
public class WorkflowProcessCentreTaskPage
{
    /// <summary>
    /// 是否还有下一页。
    /// </summary>
    public bool HasMore { get; set; }

    /// <summary>
    /// 任务列表。
    /// </summary>
    public List<WorkflowProcessCentreTodoTask> List { get; set; } = [];
}

/// <summary>
/// 流程中心待办任务
/// </summary>
public class WorkflowProcessCentreTodoTask
{
    /// <summary>
    /// OA审批任务ID。
    /// </summary>
    public long TaskId { get; set; }

    /// <summary>
    /// 待办组ID。
    /// </summary>
    public string? ActivityId { get; set; }

    /// <summary>
    /// OA审批任务发起人的用户userId。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// 任务状态。
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// 任务处理结果，agree表示同意，refuse表示拒绝。
    /// </summary>
    public string? Result { get; set; }

    /// <summary>
    /// OA审批任务创建时间。
    /// </summary>
    public long? CreateTime { get; set; }

    /// <summary>
    /// OA审批任务完成时间。
    /// </summary>
    public string? FinishTime { get; set; }

    /// <summary>
    /// OA审批流程实例ID。
    /// </summary>
    public string? ProcessInstanceId { get; set; }
}

/// <summary>
/// 批量取消流程中心待处理任务请求
/// </summary>
public class WorkflowCancelProcessCentreTaskRequest
{
    /// <summary>
    /// OA审批流程实例ID。
    /// </summary>
    public required string ProcessInstanceId { get; set; }

    /// <summary>
    /// 待办组ID。
    /// </summary>
    public required string ActivityId { get; set; }

    /// <summary>
    /// 待办组ID列表。
    /// </summary>
    public List<string> ActivityIds { get; set; } = [];
}
