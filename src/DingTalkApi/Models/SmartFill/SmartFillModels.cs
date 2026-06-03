namespace DingTalkApi.Models.SmartFill;

/// <summary>
/// 智能填表响应。
/// </summary>
/// <typeparam name="T">返回结果类型。</typeparam>
public class SmartFillResponse<T>
{
    /// <summary>
    /// 接口调用是否成功。true：成功；false：失败。
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 返回结果。
    /// </summary>
    public required T Result { get; set; }
}

/// <summary>
/// 获取用户创建的填表模板列表响应。
/// </summary>
public class SmartFillFormSchemasResponse : SmartFillResponse<SmartFillFormSchemasResult>
{
}

/// <summary>
/// 获取填表实例列表响应。
/// </summary>
public class SmartFillFormInstancesResponse : SmartFillResponse<SmartFillFormInstancesResult>
{
}

/// <summary>
/// 获取单条填表实例详情响应。
/// </summary>
public class SmartFillFormInstanceResponse : SmartFillResponse<SmartFillFormInstanceDetail>
{
}

/// <summary>
/// 用户创建的填表模板分页结果。
/// </summary>
public class SmartFillFormSchemasResult
{
    /// <summary>
    /// 是否有下一页数据。true：是；false：否。
    /// </summary>
    public bool HasMore { get; set; }

    /// <summary>
    /// 分页游标。
    /// </summary>
    public long NextToken { get; set; }

    /// <summary>
    /// 创建的表单模版列表。
    /// </summary>
    public List<SmartFillFormSchema> List { get; set; } = [];
}

/// <summary>
/// 智能填表模板信息。
/// </summary>
public class SmartFillFormSchema
{
    /// <summary>
    /// 创建人userId。
    /// </summary>
    public string? Creator { get; set; }

    /// <summary>
    /// 填表code。
    /// </summary>
    public string? FormCode { get; set; }

    /// <summary>
    /// 填表名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 填表提示。
    /// </summary>
    public string? Memo { get; set; }

    /// <summary>
    /// 表单设置信息。
    /// </summary>
    public SmartFillFormSetting? Setting { get; set; }
}

/// <summary>
/// 智能填表模板设置信息。
/// </summary>
public class SmartFillFormSetting
{
    /// <summary>
    /// 填表类型。0：通用填表；1：教育版填表。
    /// </summary>
    public int BizType { get; set; }

    /// <summary>
    /// 创建时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    public required string CreateTime { get; set; }

    /// <summary>
    /// 表单类型。0：一次性填表；1：周期性填表。
    /// </summary>
    public int FormType { get; set; }

    /// <summary>
    /// 填表是否已终止。true：已经终止；false：未终止。
    /// </summary>
    public bool Stop { get; set; }

    /// <summary>
    /// 周期性填表的提醒时间点。一次性填表类型不返回该字段。
    /// </summary>
    public string? LoopTime { get; set; }

    /// <summary>
    /// 填表周期，周一到周日分别用1-7表示。
    /// </summary>
    public List<int> LoopDays { get; set; } = [];

    /// <summary>
    /// 填表截止时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    public required string EndTime { get; set; }
}

/// <summary>
/// 填表实例分页结果。
/// </summary>
public class SmartFillFormInstancesResult
{
    /// <summary>
    /// 是否还有下一页数据。true：是；false：否。
    /// </summary>
    public bool HasMore { get; set; }

    /// <summary>
    /// 分页游标。
    /// </summary>
    public long NextToken { get; set; }

    /// <summary>
    /// 填表实例列表。
    /// </summary>
    public List<SmartFillFormInstanceSummary> List { get; set; } = [];
}

/// <summary>
/// 智能填表实例摘要。
/// </summary>
public class SmartFillFormInstanceSummary
{
    /// <summary>
    /// 填表提交时间，iso8601格式，例如2022-07-29T15:06Z。
    /// </summary>
    public string? CreateTime { get; set; }

    /// <summary>
    /// 填表更新时间，iso8601格式，例如2022-07-29T15:06Z。
    /// </summary>
    public string? ModifyTime { get; set; }

    /// <summary>
    /// 表单模版code。
    /// </summary>
    public string? FormCode { get; set; }

    /// <summary>
    /// 表单名称。
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 提交人的userId。
    /// </summary>
    public string? SubmitterUserId { get; set; }

    /// <summary>
    /// 提交人姓名。
    /// </summary>
    public string? SubmitterUserName { get; set; }

    /// <summary>
    /// 表单内容列表。
    /// </summary>
    public List<SmartFillFormValue> Forms { get; set; } = [];

    /// <summary>
    /// 表单实例ID。
    /// </summary>
    public string? FormInstanceId { get; set; }

    /// <summary>
    /// 学生班级名称。教育版填表返回该字段。
    /// </summary>
    public string? StudentClassName { get; set; }

    /// <summary>
    /// 学生班级ID。教育版填表返回该字段。
    /// </summary>
    public string? StudentClassId { get; set; }

    /// <summary>
    /// 学生ID。教育版填表返回该字段。
    /// </summary>
    public string? StudentUserId { get; set; }

    /// <summary>
    /// 学生名称。教育版填表返回该字段。
    /// </summary>
    public string? StudentName { get; set; }
}

/// <summary>
/// 智能填表实例详情。
/// </summary>
public class SmartFillFormInstanceDetail
{
    /// <summary>
    /// 填表实例提交时间，iso8601格式，例如2022-07-29T15:07Z。
    /// </summary>
    public required string CreateTime { get; set; }

    /// <summary>
    /// 填表更新时间，iso8601格式，例如2022-07-29T15:07Z。
    /// </summary>
    public required string ModifyTime { get; set; }

    /// <summary>
    /// 表单模版code。
    /// </summary>
    public required string FormCode { get; set; }

    /// <summary>
    /// 表单名称。
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// 表单实例提交者userId。
    /// </summary>
    public required string Creator { get; set; }

    /// <summary>
    /// 表单内容列表。
    /// </summary>
    public List<SmartFillFormValue> Forms { get; set; } = [];
}

/// <summary>
/// 智能填表表单控件值。
/// </summary>
public class SmartFillFormValue
{
    /// <summary>
    /// 表单控件名称。
    /// </summary>
    public string? Label { get; set; }

    /// <summary>
    /// 表单控件key。
    /// </summary>
    public string? Key { get; set; }

    /// <summary>
    /// 表单控件的值。
    /// </summary>
    public string? Value { get; set; }
}
