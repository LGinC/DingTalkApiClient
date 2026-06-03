using System.Text.Json.Serialization;

namespace DingTalkApiClient.Models.Blackboard;

/// <summary>
/// 创建公告请求。
/// </summary>
public class CreateBlackboardRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    public required CreateBlackboardRequestBody CreateRequest { get; set; }
}

/// <summary>
/// 创建公告请求对象。
/// </summary>
public class CreateBlackboardRequestBody
{
    /// <summary>
    /// 操作人的userid，必须是公告管理员。
    /// </summary>
    public required string OperationUserid { get; set; }

    /// <summary>
    /// 公告作者。
    /// </summary>
    public required string Author { get; set; }

    /// <summary>
    /// 保密等级：0为普通公告，20为保密公告。
    /// </summary>
    public int PrivateLevel { get; set; }

    /// <summary>
    /// 是否发送应用内钉提醒：false不发送，true发送。
    /// </summary>
    public bool Ding { get; set; }

    /// <summary>
    /// 公告接收人。
    /// </summary>
    public required BlackboardReceiver BlackboardReceiver { get; set; }

    /// <summary>
    /// 公告标题。
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// 公告是否置顶。
    /// </summary>
    public bool PushTop { get; set; }

    /// <summary>
    /// 公告内容。
    /// </summary>
    public required string Content { get; set; }

    /// <summary>
    /// 公告分类ID。
    /// </summary>
    public required string CategoryId { get; set; }

    /// <summary>
    /// 封面图，格式为@mediaId。可以通过上传媒体文件接口上传图片获取mediaId。
    /// </summary>
    public required string CoverpicMediaid { get; set; }
}

/// <summary>
/// 公告接收人。
/// </summary>
public class BlackboardReceiver
{
    /// <summary>
    /// 接收部门ID列表，最大的列表长度为20。
    /// </summary>
    public required List<long> DeptidList { get; set; }

    /// <summary>
    /// 接收人userid列表，最大的列表长度为1000。
    /// </summary>
    public required List<string> UseridList { get; set; }
}

/// <summary>
/// 删除公告请求。
/// </summary>
public class DeleteBlackboardRequest
{
    /// <summary>
    /// 公告ID，可以通过获取公告ID列表接口获取。
    /// </summary>
    public required string BlackboardId { get; set; }

    /// <summary>
    /// 操作人userid，必须是公告管理员。
    /// </summary>
    public required string OperationUserid { get; set; }
}

/// <summary>
/// 更新公告请求。
/// </summary>
public class UpdateBlackboardRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    public required UpdateBlackboardRequestBody UpdateRequest { get; set; }
}

/// <summary>
/// 更新公告请求对象。
/// </summary>
public class UpdateBlackboardRequestBody
{
    /// <summary>
    /// 公告作者。
    /// </summary>
    public string? Author { get; set; }

    /// <summary>
    /// 是否发送应用内钉提醒。
    /// </summary>
    public bool? Ding { get; set; }

    /// <summary>
    /// 公告ID。
    /// </summary>
    public required string BlackboardId { get; set; }

    /// <summary>
    /// 公告标题。
    /// </summary>
    public required string Title { get; set; }

    /// <summary>
    /// 公告内容。
    /// </summary>
    public required string Content { get; set; }

    /// <summary>
    /// 公告分类ID，可以通过获取公告分类列表接口获取有效值。
    /// </summary>
    public string? CategoryId { get; set; }

    /// <summary>
    /// 修改后是否再次通知接收人。
    /// </summary>
    public bool? Notify { get; set; }

    /// <summary>
    /// 操作人userid，必须是公告管理员。
    /// </summary>
    public required string OperationUserid { get; set; }

    /// <summary>
    /// 封面图，格式为@mediaId。可以通过上传媒体文件接口上传图片获取mediaId。
    /// </summary>
    public string? CoverpicMediaid { get; set; }
}

/// <summary>
/// 获取公告详情请求。
/// </summary>
public class GetBlackboardRequest
{
    /// <summary>
    /// 公告id，可以通过获取公告ID列表接口获取。
    /// </summary>
    public required string BlackboardId { get; set; }

    /// <summary>
    /// 操作人userid。
    /// </summary>
    public required string OperationUserid { get; set; }
}

/// <summary>
/// 获取公告ID列表请求。
/// </summary>
public class ListBlackboardIdsRequest
{
    /// <summary>
    /// 请求对象。
    /// </summary>
    public required ListBlackboardIdsRequestBody QueryRequest { get; set; }
}

/// <summary>
/// 获取公告ID列表请求对象。
/// </summary>
public class ListBlackboardIdsRequestBody
{
    /// <summary>
    /// 操作人userid，必须是公告管理员。
    /// </summary>
    public required string OperationUserid { get; set; }

    /// <summary>
    /// 每页记录数。
    /// </summary>
    public int PageSize { get; set; }

    /// <summary>
    /// 开始时间。如2019-10-07 10:10:10，结果返回包含该时间点的公告。
    /// </summary>
    public required string StartTime { get; set; }

    /// <summary>
    /// 结束时间。如2019-11-07 10:10:10，结果不返回2019-11-07 10:10:10时间点的公告。
    /// </summary>
    public required string EndTime { get; set; }

    /// <summary>
    /// 页码。
    /// </summary>
    public int Page { get; set; }

    /// <summary>
    /// 分类ID，可以通过获取公告分类列表接口获取。
    /// </summary>
    public required string CategoryId { get; set; }
}

/// <summary>
/// 获取公告分类列表请求。
/// </summary>
public class ListBlackboardCategoriesRequest
{
    /// <summary>
    /// 操作人userid，必须是公告管理员。
    /// </summary>
    public required string OperationUserid { get; set; }
}

/// <summary>
/// 获取用户可查看的公告请求。
/// </summary>
public class ListTopTenBlackboardsRequest
{
    /// <summary>
    /// 员工的userid。
    /// </summary>
    public required string Userid { get; set; }
}

/// <summary>
/// 获取公告钉盘空间信息请求。
/// </summary>
public class BlackboardSpaceRequest
{
    /// <summary>
    /// 当前组织的公告对应的钉盘空间id。
    /// </summary>
    public required string SpaceId { get; set; }
}

/// <summary>
/// 公告布尔结果响应。
/// </summary>
public class BlackboardBooleanResponse
{
    /// <summary>
    /// 是否操作成功。
    /// </summary>
    public bool Result { get; set; }

    /// <summary>
    /// 本次调用是否成功。
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public int Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 获取公告详情响应。
/// </summary>
public class GetBlackboardResponse
{
    /// <summary>
    /// 公告详情。
    /// </summary>
    public BlackboardDetail? Result { get; set; }

    /// <summary>
    /// 本次调用是否成功。
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public int Errcode { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 公告详情。
/// </summary>
public class BlackboardDetail
{
    /// <summary>
    /// 公告ID。
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// 公告作者。
    /// </summary>
    public string? Author { get; set; }

    /// <summary>
    /// 公告标题。
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 公告内容。
    /// </summary>
    public string? Content { get; set; }

    /// <summary>
    /// 公告分类ID。
    /// </summary>
    [JsonPropertyName("categoryId")]
    public string? CategoryId { get; set; }

    /// <summary>
    /// 保密等级：0为普通公告，20为保密公告。
    /// </summary>
    public int PrivateLevel { get; set; }

    /// <summary>
    /// 接收部门列表。
    /// </summary>
    public List<string> DepnameList { get; set; } = [];

    /// <summary>
    /// 接收人列表。
    /// </summary>
    public List<string> UsernameList { get; set; } = [];

    /// <summary>
    /// 公告创建时间。
    /// </summary>
    public string? GmtCreate { get; set; }

    /// <summary>
    /// 公告最后修改时间。
    /// </summary>
    public string? GmtModified { get; set; }

    /// <summary>
    /// 已读人数。
    /// </summary>
    public int ReadCount { get; set; }

    /// <summary>
    /// 未读人数。
    /// </summary>
    public int UnreadCount { get; set; }

    /// <summary>
    /// 封面图的url链接。
    /// </summary>
    public string? CoverpicUrl { get; set; }
}

/// <summary>
/// 获取公告ID列表响应。
/// </summary>
public class BlackboardIdListResponse
{
    /// <summary>
    /// 公告ID列表。
    /// </summary>
    public List<string> Result { get; set; } = [];

    /// <summary>
    /// 本次调用是否成功。
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public int Errcode { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 获取公告分类列表响应。
/// </summary>
public class BlackboardCategoryListResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    public List<BlackboardCategory> Result { get; set; } = [];

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public int Errcode { get; set; }

    /// <summary>
    /// 本次调用是否成功。
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 公告分类。
/// </summary>
public class BlackboardCategory
{
    /// <summary>
    /// 分类名。
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 分类ID。
    /// </summary>
    public required string Id { get; set; }
}

/// <summary>
/// 获取用户可查看的公告响应。
/// </summary>
public class ListTopTenBlackboardsResponse
{
    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public int Errcode { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }

    /// <summary>
    /// 返回结果。
    /// </summary>
    public List<TopTenBlackboard> BlackboardList { get; set; } = [];
}

/// <summary>
/// 用户可查看的公告。
/// </summary>
public class TopTenBlackboard
{
    /// <summary>
    /// 创建时间。
    /// </summary>
    public string? GmtCreate { get; set; }

    /// <summary>
    /// 公告标题。
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 跳转URL。
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// 公告分类ID。
    /// </summary>
    [JsonPropertyName("categoryId")]
    public string? CategoryId { get; set; }

    /// <summary>
    /// 公告ID。
    /// </summary>
    public string? Id { get; set; }
}

/// <summary>
/// 获取公告钉盘空间信息响应。
/// </summary>
public class BlackboardSpaceResponse
{
}
