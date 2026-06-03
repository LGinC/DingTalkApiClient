using System.Text.Json.Serialization;

namespace DingTalkApi.Models.Yida;

/// <summary>
/// 发起宜搭审批流程请求
/// </summary>
public class YidaStartProcessInstanceRequest
{
    /// <summary>
    /// 应用编码。
    /// </summary>
    public required string AppType { get; set; }

    /// <summary>
    /// 宜搭应用密钥。
    /// </summary>
    public required string SystemToken { get; set; }

    /// <summary>
    /// 用户userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 语言。
    /// </summary>
    public required string Language { get; set; }

    /// <summary>
    /// 表单ID。
    /// </summary>
    public required string FormUuid { get; set; }

    /// <summary>
    /// 表单数据JSON字符串。
    /// </summary>
    public required string FormDataJson { get; set; }

    /// <summary>
    /// 流程编码。
    /// </summary>
    public required string ProcessCode { get; set; }

    /// <summary>
    /// 部门ID。
    /// </summary>
    public required string DepartmentId { get; set; }
}

/// <summary>
/// 发起宜搭审批流程响应
/// </summary>
public class YidaStartProcessInstanceResponse
{
    /// <summary>
    /// 流程实例ID。
    /// </summary>
    public string? Result { get; set; }
}

/// <summary>
/// 查询流程实例请求
/// </summary>
public class YidaSearchProcessInstancesRequest : YidaProcessQueryRequest
{
}

/// <summary>
/// 获取实例ID列表请求
/// </summary>
public class YidaQueryProcessInstanceIdsRequest : YidaProcessQueryRequest
{
}

/// <summary>
/// 宜搭流程查询基础请求
/// </summary>
public class YidaProcessQueryRequest
{
    /// <summary>
    /// 应用编码。
    /// </summary>
    public required string AppType { get; set; }

    /// <summary>
    /// 宜搭应用密钥。
    /// </summary>
    public required string SystemToken { get; set; }

    /// <summary>
    /// 用户userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 语言。
    /// </summary>
    public string? Language { get; set; }

    /// <summary>
    /// 表单ID。
    /// </summary>
    public required string FormUuid { get; set; }

    /// <summary>
    /// 根据表单内组件值查询的JSON字符串。
    /// </summary>
    public string? SearchFieldJson { get; set; }

    /// <summary>
    /// 发起人userId。
    /// </summary>
    public string? OriginatorId { get; set; }

    /// <summary>
    /// 创建时间查询开始日期，格式：yyyy-MM-dd。
    /// </summary>
    public string? CreateFromTimeGMT { get; set; }

    /// <summary>
    /// 创建时间查询结束日期，格式：yyyy-MM-dd。
    /// </summary>
    public string? CreateToTimeGMT { get; set; }

    /// <summary>
    /// 修改时间查询开始日期，格式：yyyy-MM-dd。
    /// </summary>
    public string? ModifiedFromTimeGMT { get; set; }

    /// <summary>
    /// 修改时间查询结束日期，格式：yyyy-MM-dd。
    /// </summary>
    public string? ModifiedToTimeGMT { get; set; }

    /// <summary>
    /// 任务ID。
    /// </summary>
    public string? TaskId { get; set; }

    /// <summary>
    /// 实例状态。
    /// </summary>
    public string? InstanceStatus { get; set; }

    /// <summary>
    /// 审批结果。
    /// </summary>
    public string? ApprovedResult { get; set; }
}

/// <summary>
/// 宜搭流程实例分页响应
/// </summary>
public class YidaProcessInstancePageResponse
{
    /// <summary>
    /// 总条数。
    /// </summary>
    public int? TotalCount { get; set; }

    /// <summary>
    /// 当前页码。
    /// </summary>
    public int? PageNumber { get; set; }

    /// <summary>
    /// 流程实例列表。
    /// </summary>
    public List<YidaProcessInstanceInfo> Data { get; set; } = [];
}

/// <summary>
/// 字符串分页响应
/// </summary>
public class YidaStringPageResponse
{
    /// <summary>
    /// 总条数。
    /// </summary>
    public int? TotalCount { get; set; }

    /// <summary>
    /// 当前页码。
    /// </summary>
    public int? PageNumber { get; set; }

    /// <summary>
    /// 字符串数据列表。
    /// </summary>
    public List<string> Data { get; set; } = [];
}

/// <summary>
/// 流程实例列表结果响应
/// </summary>
public class YidaProcessInstancesResultResponse
{
    /// <summary>
    /// 流程实例列表。
    /// </summary>
    public required List<YidaProcessInstanceInfo> Result { get; set; }
}

/// <summary>
/// 宜搭流程实例详情
/// </summary>
public class YidaProcessInstanceInfo
{
    /// <summary>
    /// 创建时间。
    /// </summary>
    public string? CreateTimeGMT { get; set; }

    /// <summary>
    /// 流程实例ID。
    /// </summary>
    public string? ProcessInstanceId { get; set; }

    /// <summary>
    /// 流程实例当前任务执行人列表。
    /// </summary>
    public List<YidaUserInfo> ActionExecutor { get; set; } = [];

    /// <summary>
    /// 审批结果。
    /// </summary>
    public string? ApprovedResult { get; set; }

    /// <summary>
    /// 表单ID。
    /// </summary>
    public string? FormUuid { get; set; }

    /// <summary>
    /// 表单或流程数据。
    /// </summary>
    public Dictionary<string, object?> Data { get; set; } = [];

    /// <summary>
    /// 修改时间。
    /// </summary>
    public string? ModifiedTimeGMT { get; set; }

    /// <summary>
    /// 流程编码。
    /// </summary>
    public string? ProcessCode { get; set; }

    /// <summary>
    /// 发起人。
    /// </summary>
    public YidaUserInfo? Originator { get; set; }

    /// <summary>
    /// 流程标题。
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 实例状态。
    /// </summary>
    public string? InstanceStatus { get; set; }

    /// <summary>
    /// 数据版本。
    /// </summary>
    public int? Version { get; set; }
}

/// <summary>
/// 宜搭用户信息
/// </summary>
public class YidaUserInfo
{
    /// <summary>
    /// 名称。
    /// </summary>
    public YidaUserName? Name { get; set; }

    /// <summary>
    /// 用户名。
    /// </summary>
    public YidaUserName? UserName { get; set; }

    /// <summary>
    /// 部门名称。
    /// </summary>
    public string? DeptName { get; set; }

    /// <summary>
    /// 部门名称。
    /// </summary>
    public string? DepartmentName { get; set; }

    /// <summary>
    /// 用户userId。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// 邮箱。
    /// </summary>
    public string? Email { get; set; }
}

/// <summary>
/// 宜搭用户名称
/// </summary>
public class YidaUserName
{
    /// <summary>
    /// 英文名称。
    /// </summary>
    public string? NameInEnglish { get; set; }

    /// <summary>
    /// 中文名称。
    /// </summary>
    public string? NameInChinese { get; set; }

    /// <summary>
    /// 国际化类型。
    /// </summary>
    public string? Type { get; set; }
}

/// <summary>
/// 获取指定应用下的表单列表响应
/// </summary>
public class YidaFormsResponse
{
    /// <summary>
    /// 是否调用成功。
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 表单分页结果。
    /// </summary>
    public required YidaFormsResult Result { get; set; }
}

/// <summary>
/// 宜搭表单分页结果
/// </summary>
public class YidaFormsResult
{
    /// <summary>
    /// 返回的表单列表。
    /// </summary>
    public List<YidaFormInfo> Data { get; set; } = [];

    /// <summary>
    /// 总条数。
    /// </summary>
    public int TotalCount { get; set; }

    /// <summary>
    /// 当前页码。
    /// </summary>
    public int CurrentPage { get; set; }
}

/// <summary>
/// 宜搭表单信息
/// </summary>
public class YidaFormInfo
{
    /// <summary>
    /// 表单类型，receipt表示普通单据表单，process表示流程表单。
    /// </summary>
    public string? FormType { get; set; }

    /// <summary>
    /// 创建者userId。
    /// </summary>
    public string? Creator { get; set; }

    /// <summary>
    /// 表单ID。
    /// </summary>
    public string? FormUuid { get; set; }

    /// <summary>
    /// 表单创建时间，ISO8601格式。
    /// </summary>
    public string? GmtCreate { get; set; }

    /// <summary>
    /// 表单名称信息。
    /// </summary>
    public YidaI18nTitle? Title { get; set; }
}

/// <summary>
/// 宜搭国际化标题
/// </summary>
public class YidaI18nTitle
{
    /// <summary>
    /// 表单英文名称。
    /// </summary>
    public string? EnUS { get; set; }

    /// <summary>
    /// 表单中文名称。
    /// </summary>
    public string? ZhCN { get; set; }
}

/// <summary>
/// 获取表单内的组件信息响应
/// </summary>
public class YidaFormFieldsResponse
{
    /// <summary>
    /// 接口调用是否成功。
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 表单组件列表。
    /// </summary>
    public List<YidaFormField> Result { get; set; } = [];
}

/// <summary>
/// 宜搭表单组件信息
/// </summary>
public class YidaFormField
{
    /// <summary>
    /// 组件类型。
    /// </summary>
    public string? ComponentName { get; set; }

    /// <summary>
    /// 组件唯一标识。
    /// </summary>
    public string? FieldId { get; set; }

    /// <summary>
    /// 组件展示状态。
    /// </summary>
    public string? Behavior { get; set; }

    /// <summary>
    /// 组件名称。
    /// </summary>
    public string? Label { get; set; }

    /// <summary>
    /// 组件属性。
    /// </summary>
    public string? Props { get; set; }

    /// <summary>
    /// 子组件信息。
    /// </summary>
    public string? Children { get; set; }
}

/// <summary>
/// 查询表单实例数据请求
/// </summary>
public class YidaSearchFormInstancesRequest : YidaFormInstanceQueryRequest
{
    /// <summary>
    /// 语言。
    /// </summary>
    public required string Language { get; set; }

    /// <summary>
    /// 根据表单内组件值查询的JSON字符串。
    /// </summary>
    public required string SearchFieldJson { get; set; }

    /// <summary>
    /// 指定排序字段。
    /// </summary>
    public required string DynamicOrder { get; set; }

    /// <summary>
    /// 分页参数，当前页。
    /// </summary>
    public int? CurrentPage { get; set; }

    /// <summary>
    /// 分页参数，每页显示条数。
    /// </summary>
    public int? PageSize { get; set; }
}

/// <summary>
/// 表单实例查询基础请求
/// </summary>
public class YidaFormInstanceQueryRequest
{
    /// <summary>
    /// 应用编码。
    /// </summary>
    public required string AppType { get; set; }

    /// <summary>
    /// 宜搭应用密钥。
    /// </summary>
    public required string SystemToken { get; set; }

    /// <summary>
    /// 用户userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 表单ID。
    /// </summary>
    public required string FormUuid { get; set; }

    /// <summary>
    /// 根据数据提交人工号查询。
    /// </summary>
    public string? OriginatorId { get; set; }

    /// <summary>
    /// 创建时间查询开始日期，格式：yyyy-MM-dd。
    /// </summary>
    public string? CreateFromTimeGMT { get; set; }

    /// <summary>
    /// 创建时间查询结束日期，格式：yyyy-MM-dd。
    /// </summary>
    public string? CreateToTimeGMT { get; set; }

    /// <summary>
    /// 修改时间查询开始日期，格式：yyyy-MM-dd。
    /// </summary>
    public string? ModifiedFromTimeGMT { get; set; }

    /// <summary>
    /// 修改时间查询结束日期，格式：yyyy-MM-dd。
    /// </summary>
    public string? ModifiedToTimeGMT { get; set; }
}

/// <summary>
/// 宜搭表单实例分页响应
/// </summary>
public class YidaFormInstancePageResponse
{
    /// <summary>
    /// 当前页码。
    /// </summary>
    public int? CurrentPage { get; set; }

    /// <summary>
    /// 当前页码。
    /// </summary>
    public int? PageNumber { get; set; }

    /// <summary>
    /// 符合条件的实例总数。
    /// </summary>
    public int? TotalCount { get; set; }

    /// <summary>
    /// 表单实例详情列表。
    /// </summary>
    public List<YidaFormInstanceDetail> Data { get; set; } = [];
}

/// <summary>
/// 宜搭表单实例详情
/// </summary>
public class YidaFormInstanceDetail
{
    /// <summary>
    /// 实体主键ID。
    /// </summary>
    public long? DataId { get; set; }

    /// <summary>
    /// 表单实例ID。
    /// </summary>
    public string? FormInstanceId { get; set; }

    /// <summary>
    /// 表单实例ID。
    /// </summary>
    public string? FormInstId { get; set; }

    /// <summary>
    /// 数据创建时间。
    /// </summary>
    public string? CreatedTimeGMT { get; set; }

    /// <summary>
    /// 最近修改时间。
    /// </summary>
    public string? ModifiedTimeGMT { get; set; }

    /// <summary>
    /// 表单ID。
    /// </summary>
    public string? FormUuid { get; set; }

    /// <summary>
    /// 模型ID。
    /// </summary>
    public string? ModelUuid { get; set; }

    /// <summary>
    /// 发起人信息。
    /// </summary>
    public YidaUserInfo? Originator { get; set; }

    /// <summary>
    /// 修改者信息。
    /// </summary>
    public YidaUserInfo? ModifyUser { get; set; }

    /// <summary>
    /// 表单数据。
    /// </summary>
    public Dictionary<string, object?> FormData { get; set; } = [];

    /// <summary>
    /// 标题。
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 流水号。
    /// </summary>
    public string? SerialNo { get; set; }

    /// <summary>
    /// 表单实例原始格式值。
    /// </summary>
    public string? InstanceValue { get; set; }

    /// <summary>
    /// 数据版本。
    /// </summary>
    public int? Version { get; set; }

    /// <summary>
    /// 创建人的userId。
    /// </summary>
    public string? CreatorUserId { get; set; }

    /// <summary>
    /// 修改人的userId。
    /// </summary>
    public string? ModifierUserId { get; set; }

    /// <summary>
    /// 批次号。
    /// </summary>
    public string? Sequence { get; set; }
}

/// <summary>
/// 保存表单数据请求
/// </summary>
public class YidaSaveFormInstanceRequest
{
    /// <summary>
    /// 应用编码。
    /// </summary>
    public required string AppType { get; set; }

    /// <summary>
    /// 宜搭应用密钥。
    /// </summary>
    public required string SystemToken { get; set; }

    /// <summary>
    /// 用户userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 语言。
    /// </summary>
    public required string Language { get; set; }

    /// <summary>
    /// 表单ID。
    /// </summary>
    public required string FormUuid { get; set; }

    /// <summary>
    /// 表单数据JSON字符串。
    /// </summary>
    public required string FormDataJson { get; set; }
}

/// <summary>
/// 保存表单数据响应
/// </summary>
public class YidaSaveFormInstanceResponse
{
    /// <summary>
    /// 表单实例ID。
    /// </summary>
    public string? Result { get; set; }
}

/// <summary>
/// 更新表单数据请求
/// </summary>
public class YidaUpdateFormInstanceRequest
{
    /// <summary>
    /// 应用编码。
    /// </summary>
    public required string AppType { get; set; }

    /// <summary>
    /// 宜搭应用密钥。
    /// </summary>
    public required string SystemToken { get; set; }

    /// <summary>
    /// 用户userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 语言。
    /// </summary>
    public required string Language { get; set; }

    /// <summary>
    /// 表单实例ID。
    /// </summary>
    public required string FormInstanceId { get; set; }

    /// <summary>
    /// 是否使用最新版本。
    /// </summary>
    public string? UseLatestVersion { get; set; }

    /// <summary>
    /// 更新表单数据JSON字符串。
    /// </summary>
    public required string UpdateFormDataJson { get; set; }
}

/// <summary>
/// 获取员工组件的值请求
/// </summary>
public class YidaEmployeeFieldsRequest : YidaFormInstanceQueryRequest
{
    /// <summary>
    /// 目标员工组件字段JSON字符串。
    /// </summary>
    public string? TargetFieldJson { get; set; }

    /// <summary>
    /// 语言。
    /// </summary>
    public string? Language { get; set; }

    /// <summary>
    /// 根据表单内组件值查询的JSON字符串。
    /// </summary>
    public string? SearchFieldJson { get; set; }
}

/// <summary>
/// 获取员工组件的值响应
/// </summary>
public class YidaEmployeeFieldsResponse
{
    /// <summary>
    /// 员工组件值结果。
    /// </summary>
    public List<Dictionary<string, object?>> Result { get; set; } = [];
}

/// <summary>
/// 获取表单组件定义列表响应
/// </summary>
public class YidaFormDefinitionsResponse
{
    /// <summary>
    /// 表单组件定义列表。
    /// </summary>
    public List<Dictionary<string, object?>> Result { get; set; } = [];
}

/// <summary>
/// 获取多个表单实例ID请求
/// </summary>
public class YidaQueryFormInstanceIdsRequest : YidaFormInstanceQueryRequest
{
    /// <summary>
    /// 语言。
    /// </summary>
    public string? Language { get; set; }

    /// <summary>
    /// 根据表单内组件值查询的JSON字符串。
    /// </summary>
    public string? SearchFieldJson { get; set; }
}

/// <summary>
/// 批量表单实例请求
/// </summary>
public class YidaBatchFormInstanceRequest
{
    /// <summary>
    /// 表单ID。
    /// </summary>
    public required string FormUuid { get; set; }

    /// <summary>
    /// 应用编码。
    /// </summary>
    public required string AppType { get; set; }

    /// <summary>
    /// 宜搭应用密钥。
    /// </summary>
    public required string SystemToken { get; set; }

    /// <summary>
    /// 表单实例ID列表。
    /// </summary>
    public required List<string> FormInstanceIdList { get; set; }

    /// <summary>
    /// 用户userId。
    /// </summary>
    public required string UserId { get; set; }
}

/// <summary>
/// 表单实例列表结果响应
/// </summary>
public class YidaFormInstancesResultResponse
{
    /// <summary>
    /// 表单实例列表。
    /// </summary>
    public required List<YidaFormInstanceDetail> Result { get; set; }
}

/// <summary>
/// 批量创建表单实例请求
/// </summary>
public class YidaBatchSaveFormInstancesRequest
{
    /// <summary>
    /// 表单ID。
    /// </summary>
    public required string FormUuid { get; set; }

    /// <summary>
    /// 应用编码。
    /// </summary>
    public required string AppType { get; set; }

    /// <summary>
    /// 宜搭应用密钥。
    /// </summary>
    public required string SystemToken { get; set; }

    /// <summary>
    /// 用户userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 表单数据JSON字符串列表。
    /// </summary>
    public required List<string> FormDataJsonList { get; set; }
}

/// <summary>
/// 批量创建表单实例响应
/// </summary>
public class YidaBatchSaveFormInstancesResponse
{
    /// <summary>
    /// 创建的表单实例ID列表。
    /// </summary>
    public required List<string> Result { get; set; }
}

/// <summary>
/// 批量更新表单实例内的组件值请求
/// </summary>
public class YidaBatchUpdateComponentsRequest
{
    /// <summary>
    /// 表单ID。
    /// </summary>
    public required string FormUuid { get; set; }

    /// <summary>
    /// 更新表单数据JSON字符串。
    /// </summary>
    public required string UpdateFormDataJson { get; set; }

    /// <summary>
    /// 应用编码。
    /// </summary>
    public required string AppType { get; set; }

    /// <summary>
    /// 宜搭应用密钥。
    /// </summary>
    public required string SystemToken { get; set; }

    /// <summary>
    /// 表单实例ID列表。
    /// </summary>
    public required List<string> FormInstanceIdList { get; set; }

    /// <summary>
    /// 用户userId。
    /// </summary>
    public required string UserId { get; set; }
}

/// <summary>
/// 批量更新表单实例内的组件值响应
/// </summary>
public class YidaBatchUpdateComponentsResponse
{
    /// <summary>
    /// 批量更新结果。
    /// </summary>
    public required Dictionary<string, object?> Result { get; set; }
}

/// <summary>
/// 新增或更新表单实例请求
/// </summary>
public class YidaInsertOrUpdateFormInstanceRequest
{
    /// <summary>
    /// 表单ID。
    /// </summary>
    public required string FormUuid { get; set; }

    /// <summary>
    /// 查询条件。
    /// </summary>
    public required string SearchCondition { get; set; }

    /// <summary>
    /// 应用编码。
    /// </summary>
    public required string AppType { get; set; }

    /// <summary>
    /// 表单数据JSON字符串。
    /// </summary>
    public required string FormDataJson { get; set; }

    /// <summary>
    /// 宜搭应用密钥。
    /// </summary>
    public required string SystemToken { get; set; }

    /// <summary>
    /// 用户userId。
    /// </summary>
    public required string UserId { get; set; }
}

/// <summary>
/// 高级查询表单实例请求
/// </summary>
public class YidaAdvancedQueryFormInstancesRequest : YidaFormInstanceQueryRequest
{
    /// <summary>
    /// 高级查询条件。
    /// </summary>
    public string? SearchCondition { get; set; }

    /// <summary>
    /// 排序配置JSON字符串。
    /// </summary>
    public string? OrderConfigJson { get; set; }
}

/// <summary>
/// 通过表单实例数据批量更新表单实例请求
/// </summary>
public class YidaBatchUpdateFormDataRequest
{
    /// <summary>
    /// 表单ID。
    /// </summary>
    public required string FormUuid { get; set; }

    /// <summary>
    /// 应用编码。
    /// </summary>
    public required string AppType { get; set; }

    /// <summary>
    /// 宜搭应用密钥。
    /// </summary>
    public required string SystemToken { get; set; }

    /// <summary>
    /// 用户userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 表单实例数据批量更新映射JSON字符串。
    /// </summary>
    public required string UpdateFormDataJsonMap { get; set; }
}

/// <summary>
/// 通过表单实例数据批量更新表单实例响应
/// </summary>
public class YidaBatchUpdateFormDataResponse
{
    /// <summary>
    /// 批量更新结果。
    /// </summary>
    public required Dictionary<string, object?> Result { get; set; }
}

/// <summary>
/// 查询表单变更记录请求
/// </summary>
public class YidaOperationLogsRequest
{
    /// <summary>
    /// 表单编码。
    /// </summary>
    public required string FormUuid { get; set; }

    /// <summary>
    /// 宜搭应用编码。
    /// </summary>
    public required string AppType { get; set; }

    /// <summary>
    /// 宜搭应用密钥。
    /// </summary>
    public required string SystemToken { get; set; }

    /// <summary>
    /// 宜搭表单实例ID列表。
    /// </summary>
    public List<string> FormInstanceIdList { get; set; } = [];

    /// <summary>
    /// 用户userId。
    /// </summary>
    public required string UserId { get; set; }
}

/// <summary>
/// 查询表单变更记录响应
/// </summary>
public class YidaOperationLogsResponse
{
    /// <summary>
    /// 按表单实例ID分组的操作记录信息。
    /// </summary>
    public required Dictionary<string, List<YidaOperationLog>> OperationLogMap { get; set; }
}

/// <summary>
/// 宜搭表单变更记录
/// </summary>
public class YidaOperationLog
{
    /// <summary>
    /// 当前文本。
    /// </summary>
    public string? CurrentText { get; set; }

    /// <summary>
    /// 修改时间。
    /// </summary>
    public string? GmtModified { get; set; }

    /// <summary>
    /// 操作类型。
    /// </summary>
    public string? OperationType { get; set; }

    /// <summary>
    /// 组件名称。
    /// </summary>
    public string? ComponentName { get; set; }

    /// <summary>
    /// 操作人。
    /// </summary>
    public YidaOperationLogOperator? Operator { get; set; }
}

/// <summary>
/// 宜搭表单变更记录操作人
/// </summary>
public class YidaOperationLogOperator
{
    /// <summary>
    /// 展示名称。
    /// </summary>
    public string? DisplayName { get; set; }
}

/// <summary>
/// 获取审批记录响应
/// </summary>
public class YidaProcessOperationRecordsResponse
{
    /// <summary>
    /// 审批记录列表。
    /// </summary>
    public List<YidaProcessOperationRecord> Result { get; set; } = [];
}

/// <summary>
/// 宜搭审批记录
/// </summary>
public class YidaProcessOperationRecord
{
    /// <summary>
    /// 操作人userId。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// 操作类型。
    /// </summary>
    public string? OperationType { get; set; }

    /// <summary>
    /// 操作结果。
    /// </summary>
    public string? OperationResult { get; set; }

    /// <summary>
    /// 操作时间。
    /// </summary>
    public string? OperationTimeGMT { get; set; }

    /// <summary>
    /// 备注。
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// YAML中未显式建模的审批记录扩展字段。
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object?>? ExtensionData { get; set; }
}

/// <summary>
/// 同意或拒绝宜搭审批任务请求
/// </summary>
public class YidaExecuteTaskRequest
{
    /// <summary>
    /// 审批动作，agree表示同意，disagree表示拒绝。
    /// </summary>
    public required string OutResult { get; set; }

    /// <summary>
    /// 不执行表达式。
    /// </summary>
    public string? NoExecuteExpressions { get; set; }

    /// <summary>
    /// 宜搭应用编码。
    /// </summary>
    public required string AppType { get; set; }

    /// <summary>
    /// 表单数据JSON字符串。
    /// </summary>
    public string? FormDataJson { get; set; }

    /// <summary>
    /// 宜搭应用密钥。
    /// </summary>
    public required string SystemToken { get; set; }

    /// <summary>
    /// 语言。
    /// </summary>
    public string? Language { get; set; }

    /// <summary>
    /// 审批意见。
    /// </summary>
    public required string Remark { get; set; }

    /// <summary>
    /// 流程实例ID。
    /// </summary>
    public required string ProcessInstanceId { get; set; }

    /// <summary>
    /// 操作人userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 任务ID。
    /// </summary>
    public required string TaskId { get; set; }
}

/// <summary>
/// 宜搭任务分页响应
/// </summary>
public class YidaTaskPageResponse
{
    /// <summary>
    /// 总数量。
    /// </summary>
    public int? TotalCount { get; set; }

    /// <summary>
    /// 当前页码。
    /// </summary>
    public int? PageNumber { get; set; }

    /// <summary>
    /// 任务列表。
    /// </summary>
    public List<YidaTaskInfo> Data { get; set; } = [];
}

/// <summary>
/// 宜搭任务信息
/// </summary>
public class YidaTaskInfo
{
    /// <summary>
    /// 执行人姓名。
    /// </summary>
    public List<string> ActionerName { get; set; } = [];

    /// <summary>
    /// 流程实例ID。
    /// </summary>
    public string? ProcessInstanceId { get; set; }

    /// <summary>
    /// 修改时间。
    /// </summary>
    public string? ModifiedTimeGMT { get; set; }

    /// <summary>
    /// 结束时间。
    /// </summary>
    public string? FinishTimeGMT { get; set; }

    /// <summary>
    /// 表单ID。
    /// </summary>
    public string? FormUuid { get; set; }

    /// <summary>
    /// 流程实例状态。
    /// </summary>
    public string? ProcessInstanceStatus { get; set; }

    /// <summary>
    /// 发起人展示名称。
    /// </summary>
    public string? OriginatorDisplayName { get; set; }

    /// <summary>
    /// 数据类型。
    /// </summary>
    public string? DataType { get; set; }

    /// <summary>
    /// 发起人头像。
    /// </summary>
    public string? OriginatorAvatar { get; set; }

    /// <summary>
    /// 流程状态展示文案。
    /// </summary>
    public string? ProcessInstanceStatusText { get; set; }

    /// <summary>
    /// 任务执行者信息。
    /// </summary>
    public List<YidaTaskActioner> Actioner { get; set; } = [];

    /// <summary>
    /// 流程审批结果文字表示。
    /// </summary>
    public string? ProcessApprovedResultText { get; set; }

    /// <summary>
    /// 表单实例ID。
    /// </summary>
    public string? FormInstanceId { get; set; }

    /// <summary>
    /// 标题。
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 版本。
    /// </summary>
    public int? Version { get; set; }

    /// <summary>
    /// 实例数据。
    /// </summary>
    public string? InstanceValue { get; set; }

    /// <summary>
    /// 流程审批结果。
    /// </summary>
    public string? ProcessApprovedResult { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    public string? CreateTimeGMT { get; set; }

    /// <summary>
    /// 流程ID。
    /// </summary>
    public long? ProcessId { get; set; }

    /// <summary>
    /// 流程名称。
    /// </summary>
    public string? ProcessName { get; set; }

    /// <summary>
    /// 流程编码。
    /// </summary>
    public string? ProcessCode { get; set; }

    /// <summary>
    /// 应用ID。
    /// </summary>
    public string? AppType { get; set; }

    /// <summary>
    /// 操作者userId列表。
    /// </summary>
    public List<string> ActionerId { get; set; } = [];

    /// <summary>
    /// 任务数据。
    /// </summary>
    public Dictionary<string, object?> DataMap { get; set; } = [];

    /// <summary>
    /// 当前流程节点实例。
    /// </summary>
    public List<YidaActivityInstance> CurrentActivityInstances { get; set; } = [];
}

/// <summary>
/// 宜搭任务执行者信息
/// </summary>
public class YidaTaskActioner
{
    /// <summary>
    /// 员工类型信息。
    /// </summary>
    public string? EmployeeTypeInformation { get; set; }

    /// <summary>
    /// 员工类型。
    /// </summary>
    public string? EmployeeType { get; set; }

    /// <summary>
    /// 层级。
    /// </summary>
    public string? Level { get; set; }

    /// <summary>
    /// 花名。
    /// </summary>
    public string? NickName { get; set; }

    /// <summary>
    /// 订单号。
    /// </summary>
    public string? OrderNumber { get; set; }

    /// <summary>
    /// 花名拼音。
    /// </summary>
    public string? PinyinNickName { get; set; }

    /// <summary>
    /// 超管userId。
    /// </summary>
    public string? SuperUserId { get; set; }

    /// <summary>
    /// 用户userId。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// BU名称。
    /// </summary>
    public string? BuName { get; set; }

    /// <summary>
    /// 淘宝旺。
    /// </summary>
    public string? TbWang { get; set; }

    /// <summary>
    /// HRG的userId。
    /// </summary>
    public string? HumanResourceGroupWorkNumber { get; set; }

    /// <summary>
    /// 全名拼音。
    /// </summary>
    public string? PinyinNameAll { get; set; }

    /// <summary>
    /// 名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 状态。
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// 个人照片URL。
    /// </summary>
    public string? PersonalPhotoUrl { get; set; }

    /// <summary>
    /// 是否系统管理员。
    /// </summary>
    public bool? IsSystemAdmin { get; set; }

    /// <summary>
    /// 邮箱。
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// 个人照片。
    /// </summary>
    public string? PersonalPhoto { get; set; }
}

/// <summary>
/// 宜搭流程节点实例
/// </summary>
public class YidaActivityInstance
{
    /// <summary>
    /// 节点名称。
    /// </summary>
    public string? ActivityName { get; set; }

    /// <summary>
    /// 节点英文名称。
    /// </summary>
    public string? ActivityNameEn { get; set; }

    /// <summary>
    /// YAML中未显式建模的节点扩展字段。
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object?>? ExtensionData { get; set; }
}

/// <summary>
/// 转交任务请求
/// </summary>
public class YidaRedirectTaskRequest
{
    /// <summary>
    /// 流程实例ID。
    /// </summary>
    public required string ProcessInstanceId { get; set; }

    /// <summary>
    /// 是否通过管理员转交。
    /// </summary>
    public string? ByManager { get; set; }

    /// <summary>
    /// 宜搭应用编码。
    /// </summary>
    public required string AppType { get; set; }

    /// <summary>
    /// 宜搭应用密钥。
    /// </summary>
    public required string SystemToken { get; set; }

    /// <summary>
    /// 语言。
    /// </summary>
    public string? Language { get; set; }

    /// <summary>
    /// 转交备注。
    /// </summary>
    public required string Remark { get; set; }

    /// <summary>
    /// 当前任务执行人userId。
    /// </summary>
    public required string NowActionExecutorId { get; set; }

    /// <summary>
    /// 操作人userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 任务ID。
    /// </summary>
    public required string TaskId { get; set; }
}

/// <summary>
/// 查询流程运行任务响应
/// </summary>
public class YidaRunningTasksResponse
{
    /// <summary>
    /// 正在运行的任务列表。
    /// </summary>
    public List<YidaRunningTask> Result { get; set; } = [];
}

/// <summary>
/// 宜搭运行中任务
/// </summary>
public class YidaRunningTask
{
    /// <summary>
    /// 任务ID。
    /// </summary>
    public string? TaskId { get; set; }

    /// <summary>
    /// 表单实例ID。
    /// </summary>
    public string? FormInstId { get; set; }

    /// <summary>
    /// 执行人userId。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// YAML中未显式建模的运行任务扩展字段。
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object?>? ExtensionData { get; set; }
}

/// <summary>
/// 批量执行宜搭审批任务请求
/// </summary>
public class YidaBatchExecuteTasksRequest
{
    /// <summary>
    /// 审批动作，agree表示同意，disagree表示拒绝。
    /// </summary>
    public required string OutResult { get; set; }

    /// <summary>
    /// 宜搭应用编码。
    /// </summary>
    public required string AppType { get; set; }

    /// <summary>
    /// 宜搭应用密钥。
    /// </summary>
    public required string SystemToken { get; set; }

    /// <summary>
    /// 审批意见。
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 操作人userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 批量执行的审批任务列表JSON字符串。
    /// </summary>
    public required string TaskInformationList { get; set; }
}

/// <summary>
/// 批量执行宜搭审批任务响应
/// </summary>
public class YidaBatchExecuteTasksResponse
{
    /// <summary>
    /// 审批失败的任务数量。
    /// </summary>
    public int FailNumber { get; set; }

    /// <summary>
    /// 审批成功的任务数量。
    /// </summary>
    public int SuccessNumber { get; set; }

    /// <summary>
    /// 总任务数。
    /// </summary>
    public int Total { get; set; }
}

/// <summary>
/// 提交评论请求
/// </summary>
public class YidaSubmitRemarkRequest
{
    /// <summary>
    /// 宜搭应用编码。
    /// </summary>
    public required string AppType { get; set; }

    /// <summary>
    /// 宜搭应用密钥。
    /// </summary>
    public required string SystemToken { get; set; }

    /// <summary>
    /// 回复的评论ID。
    /// </summary>
    public string? ReplyId { get; set; }

    /// <summary>
    /// 语言。
    /// </summary>
    public string? Language { get; set; }

    /// <summary>
    /// 表单实例ID。
    /// </summary>
    public required string FormInstanceId { get; set; }

    /// <summary>
    /// 用户userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 被@用户userId。
    /// </summary>
    public string? AtUserId { get; set; }

    /// <summary>
    /// 评论内容。
    /// </summary>
    public required string Content { get; set; }
}

/// <summary>
/// 提交评论响应
/// </summary>
public class YidaSubmitRemarkResponse
{
    /// <summary>
    /// 评论ID。
    /// </summary>
    public string? Result { get; set; }
}

/// <summary>
/// 批量查询宜搭表单实例评论请求
/// </summary>
public class YidaRemarksRequest
{
    /// <summary>
    /// 表单ID。
    /// </summary>
    public required string FormUuid { get; set; }

    /// <summary>
    /// 宜搭应用编码。
    /// </summary>
    public required string AppType { get; set; }

    /// <summary>
    /// 宜搭应用密钥。
    /// </summary>
    public required string SystemToken { get; set; }

    /// <summary>
    /// 表单实例ID列表。
    /// </summary>
    public List<string> FormInstanceIdList { get; set; } = [];

    /// <summary>
    /// 用户userId。
    /// </summary>
    public required string UserId { get; set; }
}

/// <summary>
/// 批量查询宜搭表单实例评论响应
/// </summary>
public class YidaRemarksResponse : Dictionary<string, List<YidaRemark>>
{
}

/// <summary>
/// 宜搭评论
/// </summary>
public class YidaRemark
{
    /// <summary>
    /// 评论ID。
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// 评论内容。
    /// </summary>
    public string? Content { get; set; }

    /// <summary>
    /// 评论人userId。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// 评论创建时间。
    /// </summary>
    public string? CreateTimeGMT { get; set; }

    /// <summary>
    /// YAML中未显式建模的评论扩展字段。
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object?>? ExtensionData { get; set; }
}

/// <summary>
/// 获取宜搭附件临时免登地址响应
/// </summary>
public class YidaTemporaryUrlResponse
{
    /// <summary>
    /// 临时免登地址。
    /// </summary>
    public string? Result { get; set; }
}

/// <summary>
/// 查询宜搭应用列表响应
/// </summary>
public class YidaApplicationsResponse
{
    /// <summary>
    /// 当前页码。
    /// </summary>
    public int PageNumber { get; set; }

    /// <summary>
    /// 总数量。
    /// </summary>
    public int TotalCount { get; set; }

    /// <summary>
    /// 宜搭应用列表。
    /// </summary>
    public List<YidaApplicationInfo> Data { get; set; } = [];
}

/// <summary>
/// 宜搭应用信息
/// </summary>
public class YidaApplicationInfo
{
    /// <summary>
    /// 创建者userId。
    /// </summary>
    public string? CreatorUserId { get; set; }

    /// <summary>
    /// 钉钉组织corpId。
    /// </summary>
    public string? CorpId { get; set; }

    /// <summary>
    /// 宜搭图标地址。
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// 描述信息。
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 应用状态，ONLINE表示上线，OFFLINE表示下线。
    /// </summary>
    public string? ApplicationStatus { get; set; }

    /// <summary>
    /// 宜搭应用配置。
    /// </summary>
    public string? AppConfig { get; set; }

    /// <summary>
    /// 是否被删除，y表示删除，n表示未删除。
    /// </summary>
    public string? Inexistence { get; set; }

    /// <summary>
    /// 子组织corpId。
    /// </summary>
    public string? SubCorpId { get; set; }

    /// <summary>
    /// 宜搭应用编码。
    /// </summary>
    public string? AppType { get; set; }

    /// <summary>
    /// 宜搭应用名称。
    /// </summary>
    public string? Name { get; set; }
}

/// <summary>
/// 查询宜搭表单服务调用执行记录响应
/// </summary>
public class YidaServiceInvocationRecordsResponse
{
    /// <summary>
    /// 总数量。
    /// </summary>
    public int TotalCount { get; set; }

    /// <summary>
    /// 服务调用记录列表。
    /// </summary>
    public List<YidaServiceInvocationRecord> Values { get; set; } = [];
}

/// <summary>
/// 宜搭表单服务调用执行记录
/// </summary>
public class YidaServiceInvocationRecord
{
    /// <summary>
    /// 宜搭调用目标服务时传的实际参数。
    /// </summary>
    public string? ServiceContent { get; set; }

    /// <summary>
    /// 表单编码。
    /// </summary>
    public string? FormUuid { get; set; }

    /// <summary>
    /// 重试的服务调用唯一ID。
    /// </summary>
    public string? SourceUuid { get; set; }

    /// <summary>
    /// 服务调用状态。
    /// </summary>
    public string? InvokeStatus { get; set; }

    /// <summary>
    /// 服务调用地址。
    /// </summary>
    public string? InvokeUrl { get; set; }

    /// <summary>
    /// 服务调用返回结果值。
    /// </summary>
    public string? InvokeResult { get; set; }

    /// <summary>
    /// 服务调用实际入参。
    /// </summary>
    public string? InvokeParameter { get; set; }

    /// <summary>
    /// 本次服务调用唯一ID。
    /// </summary>
    public string? HookUuid { get; set; }

    /// <summary>
    /// 表单实例ID。
    /// </summary>
    public string? FormInstanceId { get; set; }

    /// <summary>
    /// 服务调用实际入参。
    /// </summary>
    public string? ServiceParameter { get; set; }

    /// <summary>
    /// 服务名称。
    /// </summary>
    public string? ServiceName { get; set; }

    /// <summary>
    /// 服务类型。
    /// </summary>
    public string? HookType { get; set; }

    /// <summary>
    /// 服务调用是否成功，y表示成功，n表示失败。
    /// </summary>
    public string? InvokeSuccess { get; set; }
}
