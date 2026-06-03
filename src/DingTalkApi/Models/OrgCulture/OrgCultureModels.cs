using System.Text.Json.Serialization;

namespace DingTalkApi.Models.OrgCulture;

/// <summary>
/// 给员工颁发荣誉请求。
/// </summary>
public class GrantHonorRequest
{
    /// <summary>
    /// 发送人userId。同一个发送人给多个员工颁发荣誉时请按顺序执行。
    /// </summary>
    public required string SenderUserId { get; set; }

    /// <summary>
    /// 颁奖词，最多50个字符。
    /// </summary>
    public required string GrantReason { get; set; }

    /// <summary>
    /// 颁奖人名字，最多15个字符。
    /// </summary>
    public required string GranterName { get; set; }

    /// <summary>
    /// 接受人userId列表，最大值10。
    /// </summary>
    public required List<string> ReceiverUserIds { get; set; }

    /// <summary>
    /// 接收荣誉消息的群openConversationId列表，最大值5。
    /// </summary>
    public List<string>? OpenConversationIds { get; set; }
}

/// <summary>
/// 查询员工已获得的组织荣誉响应。
/// </summary>
public class QueryUserHonorsResponse
{
    /// <summary>
    /// 是否调用成功。
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 返回结果。
    /// </summary>
    public required UserHonorsPage Result { get; set; }
}

/// <summary>
/// 员工荣誉分页结果。
/// </summary>
public class UserHonorsPage
{
    /// <summary>
    /// 下次查询数据的游标；未返回表示没有更多数据。
    /// </summary>
    public required string NextToken { get; set; }

    /// <summary>
    /// 荣誉信息列表。
    /// </summary>
    public List<UserHonorInfo> Honors { get; set; } = [];
}

/// <summary>
/// 员工获得的荣誉信息。
/// </summary>
public class UserHonorInfo
{
    /// <summary>
    /// 授予历史记录列表。
    /// </summary>
    public List<HonorGrantHistory> GrantHistory { get; set; } = [];

    /// <summary>
    /// 荣誉Id。
    /// </summary>
    public string? HonorId { get; set; }

    /// <summary>
    /// 荣誉名称。
    /// </summary>
    public string? HonorName { get; set; }

    /// <summary>
    /// 荣誉含义。
    /// </summary>
    public string? HonorDesc { get; set; }

    /// <summary>
    /// 荣誉有效期截止时间戳，单位毫秒；未返回代表永久有效。
    /// </summary>
    public long? ExpirationTime { get; set; }
}

/// <summary>
/// 荣誉授予历史记录。
/// </summary>
public class HonorGrantHistory
{
    /// <summary>
    /// 发送人userId。
    /// </summary>
    public string? SenderUserid { get; set; }

    /// <summary>
    /// 授予时间戳，单位毫秒。
    /// </summary>
    public long GrantTime { get; set; }
}

/// <summary>
/// 查询当前企业下可颁发的荣誉列表响应。
/// </summary>
public class QueryOrgHonorsResponse
{
    /// <summary>
    /// 调用是否成功。
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 返回结果。
    /// </summary>
    public required OrgHonorsPage Result { get; set; }
}

/// <summary>
/// 企业荣誉分页结果。
/// </summary>
public class OrgHonorsPage
{
    /// <summary>
    /// 下次查询数据的游标；未返回表示没有更多数据。
    /// </summary>
    public required string NextToken { get; set; }

    /// <summary>
    /// 荣誉信息列表。
    /// </summary>
    public List<OrgHonorInfo> OpenHonors { get; set; } = [];
}

/// <summary>
/// 企业可颁发的荣誉信息。
/// </summary>
public class OrgHonorInfo
{
    /// <summary>
    /// 荣誉Id。
    /// </summary>
    public long HonorId { get; set; }

    /// <summary>
    /// 荣誉图标URL。
    /// </summary>
    public string? HonorImgUrl { get; set; }

    /// <summary>
    /// 荣誉附赠的挂件图URL。
    /// </summary>
    public string? HonorPendantImgUrl { get; set; }

    /// <summary>
    /// 荣誉名字。
    /// </summary>
    public string? HonorName { get; set; }

    /// <summary>
    /// 荣誉含义。
    /// </summary>
    public string? HonorDesc { get; set; }
}

/// <summary>
/// 创建荣誉勋章模板请求。
/// </summary>
public class CreateHonorTemplateRequest
{
    /// <summary>
    /// 创建荣誉勋章模板的管理员userId，需要主管理员或子管理员角色。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 荣誉勋章名称，最大长度10字符。
    /// </summary>
    public required string MedalName { get; set; }

    /// <summary>
    /// 荣誉勋章描述，最大长度30字符。
    /// </summary>
    public required string MedalDesc { get; set; }

    /// <summary>
    /// 荣誉勋章图片媒体资源标识符media_id。
    /// </summary>
    public required string MedalMediaId { get; set; }

    /// <summary>
    /// 头像挂件媒体资源标识符media_id。
    /// </summary>
    public required string AvatarFrameMediaId { get; set; }

    /// <summary>
    /// 背景颜色。
    /// </summary>
    public required string DefaultBgColor { get; set; }
}

/// <summary>
/// 创建荣誉勋章模板响应。
/// </summary>
public class CreateHonorTemplateResponse
{
    /// <summary>
    /// 接口调用是否成功。
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 荣誉勋章创建结果。
    /// </summary>
    public required HonorIdResult Result { get; set; }
}

/// <summary>
/// 撤销员工获得的荣誉勋章请求。
/// </summary>
public class RecallHonorRequest
{
    /// <summary>
    /// 撤销荣誉勋章的员工userId。
    /// </summary>
    public required string UserId { get; set; }
}

/// <summary>
/// 撤销员工获得的荣誉勋章响应。
/// </summary>
public class RecallHonorResponse
{
    /// <summary>
    /// 接口调用是否成功。
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 撤销荣誉勋章结果。
    /// </summary>
    public required HonorIdResult Result { get; set; }
}

/// <summary>
/// 荣誉Id结果。
/// </summary>
public class HonorIdResult
{
    /// <summary>
    /// 荣誉勋章模板Id或被撤销荣誉勋章id。
    /// </summary>
    public required string HonorId { get; set; }
}

/// <summary>
/// 查询用户是否参与企业步数排行榜请求。
/// </summary>
public class GetUserStepStatusRequest
{
    /// <summary>
    /// 要查询的用户userId。
    /// </summary>
    public required string Userid { get; set; }
}

/// <summary>
/// 查询用户是否参与企业步数排行榜响应。
/// </summary>
public class GetUserStepStatusResponse
{
    /// <summary>
    /// 返回码。
    /// </summary>
    public int Errcode { get; set; }

    /// <summary>
    /// 是否开启钉钉运动。
    /// </summary>
    public bool Status { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 新增词条请求。
/// </summary>
public class AddPediaWordRequest
{
    /// <summary>
    /// 新增词条的名称。
    /// </summary>
    public required string WordName { get; set; }

    /// <summary>
    /// 词条的别名列表，每次调用最多传10个。
    /// </summary>
    public List<string>? WordAlias { get; set; }

    /// <summary>
    /// 词条高亮别名列表，每次调用最多传10个。
    /// </summary>
    public List<string>? HighLightWordAlias { get; set; }

    /// <summary>
    /// 词条相关的文档列表，每次调用最多传10个。
    /// </summary>
    public List<PediaRelatedDoc>? RelatedDoc { get; set; }

    /// <summary>
    /// 词条相关的链接列表，每次调用最多传10个。
    /// </summary>
    public List<PediaRelatedLink>? RelatedLink { get; set; }

    /// <summary>
    /// 词条释义，针对词条的描述内容。
    /// </summary>
    public required string WordParaphrase { get; set; }

    /// <summary>
    /// 词条相关的图片列表，每次调用最多传10个。
    /// </summary>
    public List<PediaPicture>? PicList { get; set; }

    /// <summary>
    /// 组织对应的员工userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 词条相关的联系人列表，每次调用最多传10个。
    /// </summary>
    public List<PediaContact>? ContactList { get; set; }
}

/// <summary>
/// 更新词条请求。
/// </summary>
public class UpdatePediaWordRequest : AddPediaWordRequest
{
    /// <summary>
    /// 需要更新的词条编号。
    /// </summary>
    public required string Uuid { get; set; }

    /// <summary>
    /// 词条相关应用，最大值10。
    /// </summary>
    public List<PediaAppLink>? AppLink { get; set; }
}

/// <summary>
/// 词条新增、更新或删除响应。
/// </summary>
public class PediaWordMutationResponse
{
    /// <summary>
    /// 操作成功后的词条编号。
    /// </summary>
    public long Uuid { get; set; }

    /// <summary>
    /// 请求是否成功。
    /// </summary>
    public bool Success { get; set; }
}

/// <summary>
/// 审核词条请求。
/// </summary>
public class ApprovePediaWordRequest
{
    /// <summary>
    /// 操作人的组织员工userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 当前审核的词条主键编号。
    /// </summary>
    public required string Uuid { get; set; }

    /// <summary>
    /// 审核的结果：1表示通过，0表示拒绝。
    /// </summary>
    public required string ApproveStatus { get; set; }

    /// <summary>
    /// 拒绝的原因。
    /// </summary>
    public string? ApproveReason { get; set; }

    /// <summary>
    /// 当前内部群是否高亮。
    /// </summary>
    public bool ImHighLight { get; set; }

    /// <summary>
    /// 服务群是否高亮。
    /// </summary>
    public bool SimHighLight { get; set; }
}

/// <summary>
/// 审核词条响应。
/// </summary>
public class PediaWordApproveResponse
{
    /// <summary>
    /// 请求是否成功。
    /// </summary>
    public bool Success { get; set; }
}

/// <summary>
/// 查询词条详情响应。
/// </summary>
public class WikiWordDetailsResponse
{
    /// <summary>
    /// 返回的词条信息列表。
    /// </summary>
    public List<PediaWordDetail> Data { get; set; } = [];

    /// <summary>
    /// 返回的错误信息。
    /// </summary>
    public string? ErrMsg { get; set; }

    /// <summary>
    /// 请求是否成功。
    /// </summary>
    public bool Success { get; set; }
}

/// <summary>
/// 根据词条ID查询详情或分页获取企业词条信息响应。
/// </summary>
public class PediaWordDetailResponse
{
    /// <summary>
    /// 返回词条具体对象。
    /// </summary>
    public required PediaWordDetail Data { get; set; }

    /// <summary>
    /// 请求是否成功。
    /// </summary>
    public bool Success { get; set; }
}

/// <summary>
/// 分页获取企业词条信息请求。
/// </summary>
public class SearchPediaWordsRequest
{
    /// <summary>
    /// 搜索关键词；为空时分页获取所有词条。
    /// </summary>
    public string? WordName { get; set; }

    /// <summary>
    /// 操作人的userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 当前搜索列表的状态：0审核通过，1创建待审核，2更新待审核。
    /// </summary>
    public required string Status { get; set; }

    /// <summary>
    /// 当前每页需要展示的数量，最大20。
    /// </summary>
    public int PageSize { get; set; }

    /// <summary>
    /// 当前查询的页数，从1开始。
    /// </summary>
    public int PageNumber { get; set; }
}

/// <summary>
/// 匹配文本中的词条请求。
/// </summary>
public class ParseWikiWordsRequest
{
    /// <summary>
    /// 待匹配词条的文本，最大长度4096个字符。
    /// </summary>
    public required string Content { get; set; }
}

/// <summary>
/// 匹配文本中的词条响应。
/// </summary>
public class ParseWikiWordsResponse
{
    /// <summary>
    /// 请求是否成功。
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 请求返回的数据对象。
    /// </summary>
    public List<ParsedWikiWord> Data { get; set; } = [];
}

/// <summary>
/// 匹配到的词条文本。
/// </summary>
public class ParsedWikiWord
{
    /// <summary>
    /// 匹配到的字符串在文本内的起始索引，索引从0开始。
    /// </summary>
    public int StartIndex { get; set; }

    /// <summary>
    /// 匹配到的字符串在文本内的结束索引，不包括。
    /// </summary>
    public int EndIndex { get; set; }

    /// <summary>
    /// 匹配到的词条全名或别名。
    /// </summary>
    public string? WordName { get; set; }
}

/// <summary>
/// 词条具体对象。
/// </summary>
public class PediaWordDetail
{
    /// <summary>
    /// 词条名称。
    /// </summary>
    public required string WordName { get; set; }

    /// <summary>
    /// 词条主键ID。
    /// </summary>
    public long Uuid { get; set; }

    /// <summary>
    /// 创建时间戳，单位毫秒。
    /// </summary>
    public long GmtCreate { get; set; }

    /// <summary>
    /// 修改时间戳，单位毫秒。
    /// </summary>
    public long GmtModify { get; set; }

    /// <summary>
    /// 词条所属的组织名称。
    /// </summary>
    public string? OrgName { get; set; }

    /// <summary>
    /// 词条别名列表。
    /// </summary>
    public List<string> WordAlias { get; set; } = [];

    /// <summary>
    /// 高亮的别名列表。
    /// </summary>
    public List<string> HighLightWordAlias { get; set; } = [];

    /// <summary>
    /// 词条全名。
    /// </summary>
    public string? WordFullName { get; set; }

    /// <summary>
    /// 相关文档列表。
    /// </summary>
    public List<PediaRelatedDoc> RelatedDoc { get; set; } = [];

    /// <summary>
    /// 相关链接列表。
    /// </summary>
    public List<PediaRelatedLink> RelatedLink { get; set; } = [];

    /// <summary>
    /// 创建者。
    /// </summary>
    public string? CreatorName { get; set; }

    /// <summary>
    /// 更新人。
    /// </summary>
    public string? UpdaterName { get; set; }

    /// <summary>
    /// 审核人。
    /// </summary>
    public string? ApproveName { get; set; }

    /// <summary>
    /// 词条释义，富文本。
    /// </summary>
    public string? WordParaphrase { get; set; }

    /// <summary>
    /// 词条释义，非富文本。
    /// </summary>
    public string? SimpleWordParaphrase { get; set; }

    /// <summary>
    /// 相关联系人列表。
    /// </summary>
    public List<string> Contacts { get; set; } = [];

    /// <summary>
    /// 分类列表。
    /// </summary>
    public List<string> TagsList { get; set; } = [];

    /// <summary>
    /// 相关应用列表。
    /// </summary>
    public List<PediaAppLink> AppLink { get; set; } = [];

    /// <summary>
    /// 内部群是否高亮。
    /// </summary>
    public bool ImHighLight { get; set; }

    /// <summary>
    /// 服务群是否高亮。
    /// </summary>
    public bool SimHighLight { get; set; }

    /// <summary>
    /// 相关图片列表。
    /// </summary>
    public List<PediaPicture> PicList { get; set; } = [];

    /// <summary>
    /// 联系人列表。
    /// </summary>
    public List<PediaContact> ContactList { get; set; } = [];

    /// <summary>
    /// 操作员工userId。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// 当为待审核词条时的父编号。
    /// </summary>
    public long? ParentUuid { get; set; }
}

/// <summary>
/// 词条相关文档。
/// </summary>
public class PediaRelatedDoc
{
    /// <summary>
    /// 文档名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 文档类型。
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// 文档链接。
    /// </summary>
    public string? Link { get; set; }
}

/// <summary>
/// 词条相关链接。
/// </summary>
public class PediaRelatedLink
{
    /// <summary>
    /// 链接名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 链接类型，部分接口暂不返回。
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// 链接地址。
    /// </summary>
    public string? Link { get; set; }
}

/// <summary>
/// 词条相关应用。
/// </summary>
public class PediaAppLink
{
    /// <summary>
    /// 应用名称。
    /// </summary>
    public string? AppName { get; set; }

    /// <summary>
    /// 应用编号。
    /// </summary>
    public long? AppId { get; set; }

    /// <summary>
    /// 电脑端地址。
    /// </summary>
    public string? PcLink { get; set; }

    /// <summary>
    /// 手机端地址。
    /// </summary>
    public string? PhoneLink { get; set; }

    /// <summary>
    /// icon地址。
    /// </summary>
    public string? IconLink { get; set; }
}

/// <summary>
/// 词条相关图片。
/// </summary>
public class PediaPicture
{
    /// <summary>
    /// 图片地址。
    /// </summary>
    public string? MediaIdUrl { get; set; }
}

/// <summary>
/// 词条相关联系人。
/// </summary>
public class PediaContact
{
    /// <summary>
    /// 联系人的userId。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// 联系人的昵称。
    /// </summary>
    public string? NickName { get; set; }

    /// <summary>
    /// 联系人的头像地址。
    /// </summary>
    public string? AvatarMediaId { get; set; }
}
