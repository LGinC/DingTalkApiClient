using System.Text.Json.Serialization;
using DingTalkApiClient.Models;

namespace DingTalkApiClient.Models.CRM;

/// <summary>
/// topapi CRM 布尔响应。
/// </summary>
public class CrmTopBooleanResponse : DingTalkResult
{
    /// <summary>
    /// 调用结果。
    /// </summary>
    public bool Result { get; set; }
}

/// <summary>
/// topapi 删除数据请求。
/// </summary>
public class CrmTopDeleteDataRequest
{
    /// <summary>
    /// 操作人的用户 userid。
    /// </summary>
    public required string OperatorUserid { get; set; }

    /// <summary>
    /// 数据 ID。
    /// </summary>
    public required string DataId { get; set; }
}

/// <summary>
/// topapi CRM 对象元数据响应。
/// </summary>
public class CrmTopObjectMetaResponse : DingTalkResult
{
    /// <summary>
    /// 对象元数据。
    /// </summary>
    public CrmObjectMetaResponse? Result { get; set; }
}

/// <summary>
/// topapi CRM 查询请求。
/// </summary>
public class CrmTopQueryRequest
{
    /// <summary>
    /// 游标。
    /// </summary>
    public string? Cursor { get; set; }

    /// <summary>
    /// 操作人的用户 userid。
    /// </summary>
    public string? CurrentOperatorUserid { get; set; }

    /// <summary>
    /// 每页数量。
    /// </summary>
    public int? PageSize { get; set; }

    /// <summary>
    /// 第三方企业应用授权企业 corpId。
    /// </summary>
    public string? ProviderCorpid { get; set; }

    /// <summary>
    /// 查询 DSL。
    /// </summary>
    public string? QueryDsl { get; set; }
}

/// <summary>
/// topapi CRM 查询响应。
/// </summary>
public class CrmTopQueryResponse : DingTalkResult
{
    /// <summary>
    /// 查询结果。
    /// </summary>
    public CrmTopQueryResult? Result { get; set; }
}

/// <summary>
/// topapi CRM 查询结果。
/// </summary>
public class CrmTopQueryResult
{
    /// <summary>
    /// 数据列表。
    /// </summary>
    public List<CrmTopDataInstance> List { get; set; } = [];

    /// <summary>
    /// 下一页游标。
    /// </summary>
    public string? NextCursor { get; set; }

    /// <summary>
    /// 是否还有更多数据。
    /// </summary>
    public bool? HasMore { get; set; }
}

/// <summary>
/// topapi CRM 数据实例。
/// </summary>
public class CrmTopDataInstance
{
    /// <summary>
    /// 数据 ID。
    /// </summary>
    public string? DataId { get; set; }

    /// <summary>
    /// 实例 ID。
    /// </summary>
    public string? InstanceId { get; set; }

    /// <summary>
    /// 数据内容。
    /// </summary>
    public CrmDynamicData Data { get; set; } = [];
}

/// <summary>
/// topapi 按 ID 列表批量获取请求。
/// </summary>
public class CrmTopListRequest
{
    /// <summary>
    /// 操作人的用户 userid。
    /// </summary>
    public string? CurrentOperatorUserid { get; set; }

    /// <summary>
    /// 数据 ID 列表。
    /// </summary>
    public List<string> DataIdList { get; set; } = [];

    /// <summary>
    /// 第三方企业应用授权企业 corpId。
    /// </summary>
    public string? ProviderCorpid { get; set; }
}

/// <summary>
/// topapi CRM 列表响应。
/// </summary>
public class CrmTopListResponse : DingTalkResult
{
    /// <summary>
    /// 结果列表。
    /// </summary>
    public List<CrmTopDataInstance> ResultList { get; set; } = [];
}

/// <summary>
/// topapi 自定义对象数据请求。
/// </summary>
public class CrmTopCustomObjectRequest
{
    /// <summary>
    /// 自定义对象实例。
    /// </summary>
    public required CrmTopCustomObjectInstance Instance { get; set; }
}

/// <summary>
/// topapi 自定义对象实例。
/// </summary>
public class CrmTopCustomObjectInstance
{
    /// <summary>
    /// 自定义对象名称。
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 数据 ID。
    /// </summary>
    public string? DataId { get; set; }

    /// <summary>
    /// 操作人的用户 userid。
    /// </summary>
    public string? CurrentOperatorUserid { get; set; }

    /// <summary>
    /// 数据字段。
    /// </summary>
    public CrmDynamicData Data { get; set; } = [];
}

/// <summary>
/// topapi 自定义对象响应。
/// </summary>
public class CrmTopCustomObjectResponse : DingTalkResult
{
    /// <summary>
    /// 自定义对象数据 ID。
    /// </summary>
    public string? Result { get; set; }

    /// <summary>
    /// 调用是否成功。
    /// </summary>
    public bool? Success { get; set; }
}

/// <summary>
/// topapi 获取自定义对象元数据请求。
/// </summary>
public class CrmTopDescribeCustomObjectMetaRequest
{
    /// <summary>
    /// 自定义对象名称。
    /// </summary>
    public required string Name { get; set; }
}

/// <summary>
/// topapi 自定义对象查询请求。
/// </summary>
public class CrmTopCustomObjectQueryRequest : CrmTopQueryRequest
{
    /// <summary>
    /// 自定义对象名称。
    /// </summary>
    public required string Name { get; set; }
}

/// <summary>
/// topapi 自定义对象按 ID 列表获取请求。
/// </summary>
public class CrmTopCustomObjectListRequest : CrmTopListRequest
{
    /// <summary>
    /// 自定义对象名称。
    /// </summary>
    public required string Name { get; set; }
}
