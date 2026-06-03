using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models.Report;

/// <summary>
/// 创建日志请求。
/// </summary>
public class CreateReportRequest
{
    /// <summary>
    /// 创建日志的参数对象。
    /// </summary>
    public required CreateReportParam CreateReportParam { get; set; }
}

/// <summary>
/// 创建日志的参数对象。
/// </summary>
public class CreateReportParam
{
    /// <summary>
    /// 日志内容数组。
    /// </summary>
    public required List<ReportContent> Contents { get; set; }

    /// <summary>
    /// 模板ID。调用获取模板详情接口获取。
    /// </summary>
    public required string TemplateId { get; set; }

    /// <summary>
    /// 日志发送到的员工userid。
    /// </summary>
    public List<string>? ToUserids { get; set; }

    /// <summary>
    /// 发送日志到员工时是否发送单聊消息。true：发送日志消息给指定用户；false：不单独发送消息。
    /// </summary>
    public bool ToChat { get; set; }

    /// <summary>
    /// 日志要发送到的群ID。群需要在日志模板中预先配置。
    /// </summary>
    public List<string>? ToCids { get; set; }

    /// <summary>
    /// 日志来源，每个组织可以自己起一个唯一的来源标识。
    /// </summary>
    public required string DdFrom { get; set; }

    /// <summary>
    /// 创建日志的员工userid。
    /// </summary>
    public required string Userid { get; set; }
}

/// <summary>
/// 保存日志内容请求。
/// </summary>
public class SaveReportContentRequest
{
    /// <summary>
    /// 保存日志的参数对象。
    /// </summary>
    public required SaveReportContentParam CreateReportParam { get; set; }
}

/// <summary>
/// 保存日志的参数对象。
/// </summary>
public class SaveReportContentParam
{
    /// <summary>
    /// 日志内容数组。
    /// </summary>
    public required List<ReportContent> Contents { get; set; }

    /// <summary>
    /// 模板ID。调用获取模板详情接口获取。
    /// </summary>
    public required string TemplateId { get; set; }

    /// <summary>
    /// 日志来源，每个组织可以自己起一个唯一的来源标识。
    /// </summary>
    public required string DdFrom { get; set; }

    /// <summary>
    /// 创建日志的员工的userid。
    /// </summary>
    public required string Userid { get; set; }
}

/// <summary>
/// 日志内容。
/// </summary>
public class ReportContent
{
    /// <summary>
    /// 模板字段的唯一序列ID。调用获取模板详情接口获取。
    /// </summary>
    public long Sort { get; set; }

    /// <summary>
    /// 模板字段的类型。创建日志时只支持文本类型日志组件，即type固定值为1。
    /// </summary>
    public long Type { get; set; }

    /// <summary>
    /// 日志内容的类型。目前只支持markdown类型。
    /// </summary>
    public required string ContentType { get; set; }

    /// <summary>
    /// 日志内容。只支持Markdown语法。
    /// </summary>
    public required string Content { get; set; }

    /// <summary>
    /// 日志对应的模板某个字段的标题。调用获取模板详情接口获取。
    /// </summary>
    public required string Key { get; set; }
}

/// <summary>
/// 获取模板详情请求。
/// </summary>
public class GetReportTemplateByNameRequest
{
    /// <summary>
    /// 操作该接口的员工userid。
    /// </summary>
    public required string Userid { get; set; }

    /// <summary>
    /// 模板名称。
    /// </summary>
    public required string TemplateName { get; set; }
}

/// <summary>
/// 日志模板详情。
/// </summary>
public class ReportTemplateDetail
{
    /// <summary>
    /// 模板默认接收人。
    /// </summary>
    public List<ReportTemplateReceiver> DefaultReceivers { get; set; } = [];

    /// <summary>
    /// 模板名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 模板ID。
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// 模板字段。
    /// </summary>
    public List<ReportTemplateField> Fields { get; set; } = [];

    /// <summary>
    /// 操作该接口的员工姓名。
    /// </summary>
    public string? UserName { get; set; }

    /// <summary>
    /// 操作该接口的员工userid。
    /// </summary>
    public string? Userid { get; set; }

    /// <summary>
    /// 默认接收群。
    /// </summary>
    public List<ReportTemplateConversation> DefaultReceivedConvs { get; set; } = [];
}

/// <summary>
/// 日志模板默认接收人。
/// </summary>
public class ReportTemplateReceiver
{
    /// <summary>
    /// 默认接收人名称。
    /// </summary>
    public string? UserName { get; set; }

    /// <summary>
    /// 默认接收人员工的userid。
    /// </summary>
    public string? Userid { get; set; }
}

/// <summary>
/// 日志模板字段。
/// </summary>
public class ReportTemplateField
{
    /// <summary>
    /// 模板字段名称。
    /// </summary>
    public string? FieldName { get; set; }

    /// <summary>
    /// 字段类型。
    /// </summary>
    public long Type { get; set; }

    /// <summary>
    /// 模板字段唯一标识。
    /// </summary>
    public long Sort { get; set; }
}

/// <summary>
/// 日志模板默认接收群。
/// </summary>
public class ReportTemplateConversation
{
    /// <summary>
    /// 该日志模板的默认接收群ID。
    /// </summary>
    public string? ConversationId { get; set; }

    /// <summary>
    /// 群名称。
    /// </summary>
    public string? Title { get; set; }
}

/// <summary>
/// 获取用户发出的日志列表请求。
/// </summary>
public class ListReportsRequest
{
    /// <summary>
    /// 查询的日志创建的开始时间，Unix时间戳，单位毫秒。
    /// </summary>
    public long StartTime { get; set; }

    /// <summary>
    /// 查询的日志创建的结束时间，Unix时间戳，单位毫秒。
    /// </summary>
    public long EndTime { get; set; }

    /// <summary>
    /// 要查询的模板名称。
    /// </summary>
    public string? TemplateName { get; set; }

    /// <summary>
    /// 员工的userid。
    /// </summary>
    public string? Userid { get; set; }

    /// <summary>
    /// 查询游标，初始传入0，后续从上一次的返回值中获取。
    /// </summary>
    public long Cursor { get; set; }

    /// <summary>
    /// 每页数据量，最大值为20。
    /// </summary>
    public long Size { get; set; }

    /// <summary>
    /// 查询的日志修改的开始时间，Unix时间戳，单位毫秒。
    /// </summary>
    public long? ModifiedStartTime { get; set; }

    /// <summary>
    /// 查询的日志修改的结束时间，Unix时间戳，单位毫秒。
    /// </summary>
    public long? ModifiedEndTime { get; set; }
}

/// <summary>
/// 获取用户发出的日志列表结果。
/// </summary>
public class ReportListResult
{
    /// <summary>
    /// 日志列表。
    /// </summary>
    public List<ReportDetail> DataList { get; set; } = [];

    /// <summary>
    /// 分页大小。
    /// </summary>
    public long Size { get; set; }

    /// <summary>
    /// 下一游标。
    /// </summary>
    public long? NextCursor { get; set; }

    /// <summary>
    /// 是否还有下一页数据。
    /// </summary>
    public bool HasMore { get; set; }
}

/// <summary>
/// 日志详情。
/// </summary>
public class ReportDetail
{
    /// <summary>
    /// 日志内容。
    /// </summary>
    public string? Contents { get; set; }

    /// <summary>
    /// 备注。
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 日志模板名。
    /// </summary>
    public string? TemplateName { get; set; }

    /// <summary>
    /// 部门。
    /// </summary>
    public string? DeptName { get; set; }

    /// <summary>
    /// 日志创建人。
    /// </summary>
    public string? CreatorName { get; set; }

    /// <summary>
    /// 日志创建人的userid。
    /// </summary>
    public string? CreatorId { get; set; }

    /// <summary>
    /// 日志创建时间。
    /// </summary>
    public long CreateTime { get; set; }

    /// <summary>
    /// 日志ID。
    /// </summary>
    public string? ReportId { get; set; }

    /// <summary>
    /// 日志修改时间。
    /// </summary>
    public long? ModifiedTime { get; set; }
}

/// <summary>
/// 获取用户发送日志的概要信息请求。
/// </summary>
public class ListSimpleReportsRequest
{
    /// <summary>
    /// 查询起始时间，Unix时间戳，单位：毫秒。
    /// </summary>
    public long StartTime { get; set; }

    /// <summary>
    /// 查询截止时间，Unix时间戳，单位：毫秒。
    /// </summary>
    public long EndTime { get; set; }

    /// <summary>
    /// 要查询的模板名称。
    /// </summary>
    public string? TemplateName { get; set; }

    /// <summary>
    /// 员工的userid。
    /// </summary>
    public string? Userid { get; set; }

    /// <summary>
    /// 查询游标，初始传入0，后续从上一次的返回值中获取。
    /// </summary>
    public long Cursor { get; set; }

    /// <summary>
    /// 每页数据量，最大为20。
    /// </summary>
    public long Size { get; set; }
}

/// <summary>
/// 获取用户发送日志的概要信息响应。
/// </summary>
public class ReportSimpleListResponse : ReportCommonResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    public ReportSimpleListResult? Result { get; set; }
}

/// <summary>
/// 获取用户发送日志的概要信息结果。
/// </summary>
public class ReportSimpleListResult
{
    /// <summary>
    /// 日志列表。
    /// </summary>
    public List<ReportSimpleDetail> DataList { get; set; } = [];

    /// <summary>
    /// 分页大小。
    /// </summary>
    public long Size { get; set; }

    /// <summary>
    /// 下一页的游标，当返回结果里没有next_cursor时，表示分页结束。
    /// </summary>
    public long? NextCursor { get; set; }

    /// <summary>
    /// 是否还有下一页数据。
    /// </summary>
    public bool HasMore { get; set; }
}

/// <summary>
/// 日志概要信息。
/// </summary>
public class ReportSimpleDetail
{
    /// <summary>
    /// 备注。
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 日志模板名。
    /// </summary>
    public string? TemplateName { get; set; }

    /// <summary>
    /// 部门。
    /// </summary>
    public string? DeptName { get; set; }

    /// <summary>
    /// 日志创建人。
    /// </summary>
    public string? CreatorName { get; set; }

    /// <summary>
    /// 日志创建人userid。
    /// </summary>
    public string? CreatorId { get; set; }

    /// <summary>
    /// 日志创建时间。
    /// </summary>
    public long CreateTime { get; set; }

    /// <summary>
    /// 日志ID。
    /// </summary>
    public string? ReportId { get; set; }
}

/// <summary>
/// 获取日志相关人员列表请求。
/// </summary>
public class ListReportUsersByTypeRequest : ReportPageRequest
{
    /// <summary>
    /// 查询类型：0：已读人员列表；1：评论人员列表；2：点赞人员列表。
    /// </summary>
    public long Type { get; set; }
}

/// <summary>
/// 获取日志接收人员列表请求。
/// </summary>
public class ListReportReceiversRequest : ReportPageRequest;

/// <summary>
/// 获取日志评论详情请求。
/// </summary>
public class ListReportCommentsRequest : ReportPageRequest;

/// <summary>
/// 日志分页请求。
/// </summary>
public class ReportPageRequest
{
    /// <summary>
    /// 日志ID。
    /// </summary>
    public required string ReportId { get; set; }

    /// <summary>
    /// 分页查询的游标，最开始传0，后续传返回参数中的next_cursor值，默认值为0。
    /// </summary>
    public long? Offset { get; set; }

    /// <summary>
    /// 分页参数，每页大小。
    /// </summary>
    public long? Size { get; set; }
}

/// <summary>
/// 日志人员列表响应。
/// </summary>
public class ReportUserIdListResponse : ReportCommonResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    public ReportUserIdListResult? Result { get; set; }
}

/// <summary>
/// 日志人员列表结果。
/// </summary>
public class ReportUserIdListResult
{
    /// <summary>
    /// 下一次分页调用的offset值，当返回结果里没有next_cursor时，表示分页结束。
    /// </summary>
    public long? NextCursor { get; set; }

    /// <summary>
    /// 是否还有下一页数据。
    /// </summary>
    public bool HasMore { get; set; }

    /// <summary>
    /// userid列表。
    /// </summary>
    public List<string> UseridList { get; set; } = [];
}

/// <summary>
/// 获取日志评论详情响应。
/// </summary>
public class ReportCommentListResponse : ReportCommonResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    public ReportCommentListResult? Result { get; set; }
}

/// <summary>
/// 获取日志评论详情结果。
/// </summary>
public class ReportCommentListResult
{
    /// <summary>
    /// 日志评论详情。
    /// </summary>
    public List<ReportComment> Comments { get; set; } = [];

    /// <summary>
    /// 是否还有下一页。
    /// </summary>
    public bool HasMore { get; set; }

    /// <summary>
    /// 下一次分页调用的offset值，当返回结果里没有next_cursor时，表示分页结束。
    /// </summary>
    public long? NextCursor { get; set; }
}

/// <summary>
/// 日志评论详情。
/// </summary>
public class ReportComment
{
    /// <summary>
    /// 评论时间。
    /// </summary>
    public string? CreateTime { get; set; }

    /// <summary>
    /// 评论内容。
    /// </summary>
    public string? Content { get; set; }

    /// <summary>
    /// 评论人ID。
    /// </summary>
    public string? Userid { get; set; }
}

/// <summary>
/// 获取用户日志未读数请求。
/// </summary>
public class GetReportUnreadCountRequest
{
    /// <summary>
    /// 要获取的员工userid。
    /// </summary>
    public required string Userid { get; set; }
}

/// <summary>
/// 获取用户日志未读数响应。
/// </summary>
public class ReportUnreadCountResponse
{
    /// <summary>
    /// 员工日志未读数。
    /// </summary>
    public long Count { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public int? ErrCode { get; set; }

    /// <summary>
    /// 返回的错误信息。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? ErrMsg { get; set; }
}

/// <summary>
/// 获取用户可见的日志模板请求。
/// </summary>
public class ListReportTemplatesByUserIdRequest
{
    /// <summary>
    /// 员工的userid。不传递表示获取所有日志模板。
    /// </summary>
    public string? Userid { get; set; }

    /// <summary>
    /// 分页游标，从0开始。再次调用时offset设置成next_cursor的值。
    /// </summary>
    public long? Offset { get; set; }

    /// <summary>
    /// 分页大小，最大可设置成100。
    /// </summary>
    public long? Size { get; set; }
}

/// <summary>
/// 获取用户可见的日志模板响应。
/// </summary>
public class ReportTemplateListResponse : ReportCommonResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    public ReportTemplateListResult? Result { get; set; }
}

/// <summary>
/// 获取用户可见的日志模板结果。
/// </summary>
public class ReportTemplateListResult
{
    /// <summary>
    /// 模板列表。
    /// </summary>
    public List<ReportTemplateSummary> TemplateList { get; set; } = [];

    /// <summary>
    /// 下一次分页调用的offset值，当返回结果里没有nextCursor时，表示分页结束。
    /// </summary>
    public long? NextCursor { get; set; }
}

/// <summary>
/// 日志模板概要。
/// </summary>
public class ReportTemplateSummary
{
    /// <summary>
    /// 日志模板名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 模板图标URL。
    /// </summary>
    public string? IconUrl { get; set; }

    /// <summary>
    /// 模板Code。
    /// </summary>
    public string? ReportCode { get; set; }

    /// <summary>
    /// 模板URL。
    /// </summary>
    public string? Url { get; set; }
}

/// <summary>
/// 日志通用响应。
/// </summary>
public class ReportCommonResponse
{
    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public int? ErrCode { get; set; }

    /// <summary>
    /// 错误信息或返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? ErrMsg { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }

    /// <summary>
    /// 是否成功。
    /// </summary>
    public bool Success { get; set; }
}
