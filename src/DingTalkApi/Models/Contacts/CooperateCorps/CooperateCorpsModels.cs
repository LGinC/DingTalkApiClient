using System.Text.Json.Serialization;

namespace DingTalkApi.Models.Contacts.CooperateCorps;

#pragma warning disable CS1591

/// <summary>
/// 创建上下游组织请求
/// </summary>
public class CooperateCorpCreateRequest
{
    /// <summary>
    /// 上下游组织名称。
    /// </summary>
    public required string OrgName { get; set; }

    /// <summary>
    /// 上下游组织的logo。企业内部应用，调用上传媒体文件接口获取图片的media_id参数值。第三方企业应用，调用上传媒体文件接口获取图片的media_id参数值。
    /// </summary>
    public string? LogoMediaId { get; set; }

    /// <summary>
    /// 行业code。
    /// </summary>
    public int? IndustryCode { get; set; }
}

/// <summary>
/// 创建上下游组织响应
/// </summary>
public class CooperateCorpCreateResponse
{
    /// <summary>
    /// 上下游组织的CorpId。
    /// </summary>
    public required string CooperateCorpId { get; set; }
}

/// <summary>
/// 解除关联组织请求
/// </summary>
public class CooperateCorpSeparateRequest
{
    /// <summary>
    /// 分支组织在主干组织内的部门ID。企业内部应用，主干组织通过获取部门列表接口获取。第三方企业应用，主干通过获取部门列表接口获取。
    /// </summary>
    public long AttachDeptId { get; set; }
}

/// <summary>
/// 解除关联组织响应
/// </summary>
public class CooperateCorpSeparateResponse
{
    /// <summary>
    /// 处理结果。如果解除成功，该值为true。如果解除失败，不返回result，接口会响应对应报错信息。
    /// </summary>
    public bool Result { get; set; }
}

/// <summary>
/// 获取上下游组织邀请信息响应
/// </summary>
public class CooperateCorpInviteInfoResponse
{
    /// <summary>
    /// 邀请伙伴组织加入上下游组织的链接。
    /// </summary>
    public required string InviteUrl { get; set; }
}

/// <summary>
/// 批量通过伙伴组织的加入申请请求项
/// </summary>
public class UnionApplicationApproveRequestItem
{
    /// <summary>
    /// 分支组织corpId。
    /// </summary>
    public string? BranchCorpId { get; set; }

    /// <summary>
    /// 上下游组织名称。
    /// </summary>
    public string? UnionRootName { get; set; }
}

/// <summary>
/// 批量通过伙伴组织的加入申请响应
/// </summary>
public class UnionApplicationApproveResponse
{
    /// <summary>
    /// 是否处理成功。true：成功 false：失败。
    /// </summary>
    public bool Result { get; set; }
}

/// <summary>
/// 更新分支组织属性请求项
/// </summary>
public class BranchAttributeUpdateRequestItem
{
    /// <summary>
    /// 分支组织corpId。
    /// </summary>
    public string? BranchCorpId { get; set; }

    /// <summary>
    /// 分支组织别名。
    /// </summary>
    public string? UnionRootName { get; set; }

    /// <summary>
    /// 挂载部门ID。
    /// </summary>
    public long? LinkDeptId { get; set; }
}

/// <summary>
/// 设置分支组织可见范围请求项
/// </summary>
public class BranchVisibleSettingUpdateRequestItem
{
    /// <summary>
    /// 分支组织corpId。
    /// </summary>
    public string? BranchCorpId { get; set; }

    /// <summary>
    /// 可见范围类型。
    /// </summary>
    public int? Type { get; set; }

    /// <summary>
    /// 是否开启。
    /// </summary>
    public bool? Open { get; set; }

    /// <summary>
    /// 可见分支组织corpId列表。
    /// </summary>
    public List<string> VisibleBranchCorpIds { get; set; } = [];

    /// <summary>
    /// 可见部门ID列表。
    /// </summary>
    public List<long> VisibleDeptIds { get; set; } = [];
}

/// <summary>
/// 获取上下级组织分支授权数据请求
/// </summary>
public class BranchAuthDataSearchRequest
{
    /// <summary>
    /// 数据查询条件，可参考授权数据编码及入参条件概览。
    /// </summary>
    public string? Key { get; set; }
}

/// <summary>
/// 获取上下级组织分支授权数据响应
/// </summary>
public class BranchAuthDataSearchResponse
{
    /// <summary>
    /// 查询结果集。
    /// </summary>
    public List<BranchAuthDataSearchResponseItem> Result { get; set; } = [];
}

/// <summary>
/// 获取上下级组织分支授权数据响应项
/// </summary>
public class BranchAuthDataSearchResponseItem
{
    /// <summary>
    /// 指标编码。
    /// </summary>
    public string? FieldCode { get; set; }

    /// <summary>
    /// 指标名称。
    /// </summary>
    public string? FieldName { get; set; }

    /// <summary>
    /// 指标值。
    /// </summary>
    public string? FieldValue { get; set; }
}

/// <summary>
/// 获取企业已经加入的或申请加入中的上下游组织的信息请求
/// </summary>
public class UnionCooperateJoinedListRequest
{
    /// <summary>
    /// 要查询的空间状态：0：申请中 1：已成功加入。
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }
}

/// <summary>
/// 获取已加入或正在申请加入上下游组织的组织和个人信息请求
/// </summary>
public class UnionCooperateInfoListRequest
{
    /// <summary>
    /// 加入空间的状态：0：申请中的 1：已成功加入。
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }
}

/// <summary>
/// 获取企业已经加入的或申请加入中的上下游组织的信息响应
/// </summary>
public class UnionCooperateJoinedListResponse
{
    /// <summary>
    /// 空间信息。
    /// </summary>
    [JsonPropertyName("result")]
    public UnionCooperateJoinedListResult? Result { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public int? ErrCode { get; set; }

    /// <summary>
    /// 是否调用成功。
    /// </summary>
    [JsonPropertyName("success")]
    public string? Success { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? ErrMsg { get; set; }
}

/// <summary>
/// 企业加入的上下游组织信息
/// </summary>
public class UnionCooperateJoinedListResult
{
    /// <summary>
    /// 空间归属企业corpId。
    /// </summary>
    [JsonPropertyName("belong_corp_id")]
    public required string BelongCorpId { get; set; }

    /// <summary>
    /// 空间归属企业名称。
    /// </summary>
    [JsonPropertyName("belong_org_name")]
    public required string BelongOrgName { get; set; }

    /// <summary>
    /// 空间名称。
    /// </summary>
    [JsonPropertyName("org_name")]
    public required string OrgName { get; set; }

    /// <summary>
    /// 查询空间的corpId。
    /// </summary>
    [JsonPropertyName("corp_id")]
    public required string CorpId { get; set; }
}

/// <summary>
/// 获取已加入或正在申请加入上下游组织的组织和个人信息响应
/// </summary>
public class UnionCooperateInfoListResponse
{
    /// <summary>
    /// 加入或申请加入的空间信息。
    /// </summary>
    [JsonPropertyName("result")]
    public UnionCooperateInfoListResult? Result { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public int? ErrCode { get; set; }

    /// <summary>
    /// 调用是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public string? Success { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? ErrMsg { get; set; }
}

/// <summary>
/// 已加入或正在申请加入上下游组织的组织和个人信息
/// </summary>
public class UnionCooperateInfoListResult
{
    /// <summary>
    /// 加入企业的企业corpId。
    /// </summary>
    [JsonPropertyName("union_corp_id")]
    public required string UnionCorpId { get; set; }

    /// <summary>
    /// 加入企业认证等级：0：未认证 1：高级认证 2：中级认证 3：初级认证。
    /// </summary>
    [JsonPropertyName("auth_level")]
    public required string AuthLevel { get; set; }

    /// <summary>
    /// 单独加入的员工。所在部门不需要加入的情况，直接选择的几个员工。
    /// </summary>
    [JsonPropertyName("userids")]
    public required string UserIds { get; set; }

    /// <summary>
    /// 加入的部门列表。部门下的员工会全部加入。
    /// </summary>
    [JsonPropertyName("dept_ids")]
    public required string DeptIds { get; set; }

    /// <summary>
    /// 加入的方式：1：全部加入(不需要选择部门和员工) 2：部分加入。
    /// </summary>
    [JsonPropertyName("union_type")]
    public required string UnionType { get; set; }

    /// <summary>
    /// 加入企业的企业名称。
    /// </summary>
    [JsonPropertyName("union_org_name")]
    public required string UnionOrgName { get; set; }

    /// <summary>
    /// 挂载部门名称(在上下游组织中的架构属性)，不设置默认是加入企业的名称。
    /// </summary>
    [JsonPropertyName("dept_name")]
    public required string DeptName { get; set; }

    /// <summary>
    /// 挂载部门ID(在上下游组织中的架构属性)。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public required string DeptId { get; set; }
}

/// <summary>
/// 获取主干组织列表响应
/// </summary>
public class UnionTrunkGetResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    [JsonPropertyName("result")]
    public UnionTrunkGetResult? Result { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public int? ErrCode { get; set; }

    /// <summary>
    /// 调用是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 主干组织信息
/// </summary>
public class UnionTrunkGetResult
{
    /// <summary>
    /// 主干组织corpId。
    /// </summary>
    [JsonPropertyName("corpid")]
    public required string CorpId { get; set; }

    /// <summary>
    /// 主干组织名称。
    /// </summary>
    [JsonPropertyName("org_name")]
    public required string OrgName { get; set; }
}

/// <summary>
/// 获取分支组织列表请求
/// </summary>
public class UnionBranchGetRequest
{
}

/// <summary>
/// 获取分支组织列表响应
/// </summary>
public class UnionBranchGetResponse
{
    /// <summary>
    /// 返回接口。
    /// </summary>
    [JsonPropertyName("result")]
    public List<UnionBranchGetResultItem> Result { get; set; } = [];

    /// <summary>
    /// 是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? ErrCode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? ErrMsg { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 分支组织信息
/// </summary>
public class UnionBranchGetResultItem
{
    /// <summary>
    /// 分支组织名称。
    /// </summary>
    [JsonPropertyName("union_org_name")]
    public string? UnionOrgName { get; set; }

    /// <summary>
    /// 分支组织的corpid。
    /// </summary>
    [JsonPropertyName("union_corpid")]
    public string? UnionCorpId { get; set; }
}
