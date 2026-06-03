using System.Text.Json.Serialization;

namespace DingTalkApi.Models.ExclusiveOpen;

#pragma warning disable CS8618

/// <summary>
/// 获取审计协议签署人员信息响应
/// </summary>
public class AuditUsersGetResponse
{
    /// <summary>
    /// 员工信息
    /// </summary>
    [JsonPropertyName("auditSignedDetailDTOList")]
    public List<AuditUsersGetResponseAuditSignedDetailDtoListItem> AuditSignedDetailDtoList { get; set; } = [];

    /// <summary>
    /// 当前页码。
    /// </summary>
    [JsonPropertyName("currentPage")]
    public long CurrentPage { get; set; }

    /// <summary>
    /// 当前页数据量。
    /// </summary>
    [JsonPropertyName("pageSize")]
    public long PageSize { get; set; }

    /// <summary>
    /// 总数据量。
    /// </summary>
    [JsonPropertyName("total")]
    public long Total { get; set; }
}

/// <summary>
/// AuditSignedDetailDtoList项
/// </summary>
public class AuditUsersGetResponseAuditSignedDetailDtoListItem
{
    /// <summary>
    /// 员工名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 员工userId。
    /// </summary>
    [JsonPropertyName("staffId")]
    public string? StaffId { get; set; }

    /// <summary>
    /// 职位。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 员工手机号。
    /// </summary>
    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    /// <summary>
    /// 邮件。
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// 部门名称。
    /// </summary>
    [JsonPropertyName("deptName")]
    public string? DeptName { get; set; }

    /// <summary>
    /// 角色名称。
    /// </summary>
    [JsonPropertyName("roles")]
    public string? Roles { get; set; }
}

/// <summary>
/// 批量新增可信设备请求
/// </summary>
public class TrustedDevicesBatchAddRequest
{
    /// <summary>
    /// StaffId
    /// </summary>
    [JsonPropertyName("staffId")]
    public required string StaffId { get; set; }

    /// <summary>
    /// 操作端。 Mac端 Win端
    /// </summary>
    [JsonPropertyName("platform")]
    public required string Platform { get; set; }

    /// <summary>
    /// 设备的Mac地址。
    /// </summary>
    [JsonPropertyName("macAddressList")]
    public List<string> MacAddressList { get; set; } = [];
}

/// <summary>
/// 批量新增可信设备响应
/// </summary>
public class TrustedDevicesBatchAddResponse
{
    /// <summary>
    /// Result
    /// </summary>
    [JsonPropertyName("result")]
    public bool Result { get; set; }
}

/// <summary>
/// 查询公共设备响应
/// </summary>
public class TrustsPublicDevicesGetResponse
{
    /// <summary>
    /// 数据总数。
    /// </summary>
    [JsonPropertyName("totalCnt")]
    public long TotalCount { get; set; }

    /// <summary>
    /// 当前页数据量。
    /// </summary>
    [JsonPropertyName("dataCnt")]
    public long DataCount { get; set; }

    /// <summary>
    /// 设备列表。
    /// </summary>
    [JsonPropertyName("data")]
    public List<TrustsPublicDevicesGetResponseDataItem> Data { get; set; } = [];
}

/// <summary>
/// Data项
/// </summary>
public class TrustsPublicDevicesGetResponseDataItem
{
    /// <summary>
    /// 创建时间。
    /// </summary>
    [JsonPropertyName("gmtCreate")]
    public long? GmtCreate { get; set; }

    /// <summary>
    /// 修改时间。
    /// </summary>
    [JsonPropertyName("gmtModified")]
    public long? GmtModified { get; set; }

    /// <summary>
    /// 设备标题。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// Mac地址。
    /// </summary>
    [JsonPropertyName("macAddress")]
    public string? MacAddress { get; set; }

    /// <summary>
    /// 系统： Mac：Mac端 Win：Windows端 iOS：iOS端 Android：Android端
    /// </summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>
    /// 生效范围： 1: 全员生效 2: 部分生效
    /// </summary>
    [JsonPropertyName("deviceScopeType")]
    public long? DeviceScopeType { get; set; }

    /// <summary>
    /// 员工列表。 说明 仅生效范围是部分生效时有效。
    /// </summary>
    [JsonPropertyName("deviceStaffs")]
    public List<TrustsPublicDevicesGetResponseDataItemDeviceStaffsItem> DeviceStaffs { get; set; } = [];

    /// <summary>
    /// 部门列表。 说明 仅生效范围是部分生效时有效。
    /// </summary>
    [JsonPropertyName("deviceDepts")]
    public List<TrustsPublicDevicesGetResponseDataItemDeviceDeptsItem> DeviceDepts { get; set; } = [];

    /// <summary>
    /// 角色列表。 说明 仅生效范围是部分生效时有效。
    /// </summary>
    [JsonPropertyName("deviceRoles")]
    public List<TrustsPublicDevicesGetResponseDataItemDeviceRolesItem> DeviceRoles { get; set; } = [];
}

/// <summary>
/// DeviceStaffs项
/// </summary>
public class TrustsPublicDevicesGetResponseDataItemDeviceStaffsItem
{
    /// <summary>
    /// 员工id。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 员工姓名。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// DeviceDepts项
/// </summary>
public class TrustsPublicDevicesGetResponseDataItemDeviceDeptsItem
{
    /// <summary>
    /// 部门id。
    /// </summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>
    /// 部门名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// DeviceRoles项
/// </summary>
public class TrustsPublicDevicesGetResponseDataItemDeviceRolesItem
{
    /// <summary>
    /// 角色code。
    /// </summary>
    [JsonPropertyName("tagCode")]
    public string? TagCode { get; set; }

    /// <summary>
    /// 角色名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// 新增可信设备信息请求
/// </summary>
public class TrustedDevicesRequest
{
    /// <summary>
    /// 员工userid。
    /// </summary>
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }

    /// <summary>
    /// 平台类型，目前仅支持Mac和Win两种类型。
    /// </summary>
    [JsonPropertyName("platform")]
    public required string Platform { get; set; }

    /// <summary>
    /// 可信设备mac地址。
    /// </summary>
    [JsonPropertyName("macAddress")]
    public string? MacAddress { get; set; }

    /// <summary>
    /// 设备状态，取值：
    /// </summary>
    [JsonPropertyName("status")]
    public long? Status { get; set; }

    /// <summary>
    /// 设备唯一标识。
    /// </summary>
    [JsonPropertyName("did")]
    public string? Did { get; set; }
}

/// <summary>
/// 新增可信设备信息响应
/// </summary>
public class TrustedDevicesResponse
{
    /// <summary>
    /// 查询结果。 添加是否成功由http状态码表示，状态码200表示添加成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 查询可信设备详细信息请求
/// </summary>
public class TrustedDevicesQueryRequest
{
    /// <summary>
    /// 用户userid列表。
    /// </summary>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; } = [];
}

/// <summary>
/// 查询可信设备详细信息响应
/// </summary>
public class TrustedDevicesQueryResponse
{
    /// <summary>
    /// 查询结果。
    /// </summary>
    [JsonPropertyName("data")]
    public List<TrustedDevicesQueryResponseDataItem> Data { get; set; } = [];
}

/// <summary>
/// Data项
/// </summary>
public class TrustedDevicesQueryResponseDataItem
{
    /// <summary>
    /// 员工userid。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 平台类型，目前仅支持Mac和Win两种类型。
    /// </summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>
    /// 可信设备mac地址。
    /// </summary>
    [JsonPropertyName("macAddress")]
    public string? MacAddress { get; set; }

    /// <summary>
    /// 设备状态，取值：
    /// </summary>
    [JsonPropertyName("status")]
    public long? Status { get; set; }

    /// <summary>
    /// 创建时间，时间戳。
    /// </summary>
    [JsonPropertyName("createTime")]
    public long? CreateTime { get; set; }

    /// <summary>
    /// 设备名称。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 版本信息： Android端：示例值，Android,10。 IOS端：示例值，iOS,12.0.1。
    /// </summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }
}

/// <summary>
/// 获取可打标部门列表响应
/// </summary>
public class PartnerDepartmentsGetResponse
{
    /// <summary>
    /// 伙伴钉可打标部门列表。
    /// </summary>
    [JsonPropertyName("data")]
    public List<PartnerDepartmentsGetResponseDataItem> Data { get; set; } = [];
}

/// <summary>
/// Data项
/// </summary>
public class PartnerDepartmentsGetResponseDataItem
{
    /// <summary>
    /// 部门ID。
    /// </summary>
    [JsonPropertyName("deptId")]
    public string? DeptId { get; set; }

    /// <summary>
    /// 父部门ID。
    /// </summary>
    [JsonPropertyName("superDeptId")]
    public string? SuperDeptId { get; set; }

    /// <summary>
    /// 部门名称。
    /// </summary>
    [JsonPropertyName("deptName")]
    public string? DeptName { get; set; }

    /// <summary>
    /// 部门人数。
    /// </summary>
    [JsonPropertyName("memberCount")]
    public long? MemberCount { get; set; }

    /// <summary>
    /// 部门伙伴编码。
    /// </summary>
    [JsonPropertyName("partnerNum")]
    public string? PartnerNum { get; set; }

    /// <summary>
    /// 部门一级伙伴类型。
    /// </summary>
    [JsonPropertyName("partnerLabelVOLevel1")]
    public PartnerDepartmentsGetResponseDataItemPartnerLabelVOLevel1 PartnerLabelVOLevel1 { get; set; }

    /// <summary>
    /// 部门二级伙伴类型。
    /// </summary>
    [JsonPropertyName("partnerLabelVOLevel2")]
    public PartnerDepartmentsGetResponseDataItemPartnerLabelVOLevel2 PartnerLabelVOLevel2 { get; set; }

    /// <summary>
    /// 部门三级伙伴类型。
    /// </summary>
    [JsonPropertyName("partnerLabelVOLevel3")]
    public PartnerDepartmentsGetResponseDataItemPartnerLabelVOLevel3 PartnerLabelVOLevel3 { get; set; }

    /// <summary>
    /// 部门四级伙伴类型。
    /// </summary>
    [JsonPropertyName("partnerLabelVOLevel4")]
    public PartnerDepartmentsGetResponseDataItemPartnerLabelVOLevel4 PartnerLabelVOLevel4 { get; set; }

    /// <summary>
    /// 部门五级伙伴类型。
    /// </summary>
    [JsonPropertyName("partnerLabelVOLevel5")]
    public PartnerDepartmentsGetResponseDataItemPartnerLabelVOLevel5 PartnerLabelVOLevel5 { get; set; }
}

/// <summary>
/// 部门一级伙伴类型。
/// </summary>
public class PartnerDepartmentsGetResponseDataItemPartnerLabelVOLevel1
{
    /// <summary>
    /// 伙伴类型ID。
    /// </summary>
    [JsonPropertyName("labelId")]
    public long? LabelId { get; set; }

    /// <summary>
    /// 伙伴类型。
    /// </summary>
    [JsonPropertyName("labelName")]
    public string? LabelName { get; set; }

    /// <summary>
    /// 伙伴类型层级。
    /// </summary>
    [JsonPropertyName("levelNum")]
    public long? LevelNum { get; set; }
}

/// <summary>
/// 部门二级伙伴类型。
/// </summary>
public class PartnerDepartmentsGetResponseDataItemPartnerLabelVOLevel2
{
    /// <summary>
    /// 伙伴类型ID。
    /// </summary>
    [JsonPropertyName("labelId")]
    public long? LabelId { get; set; }

    /// <summary>
    /// 伙伴类型。
    /// </summary>
    [JsonPropertyName("labelName")]
    public string? LabelName { get; set; }

    /// <summary>
    /// 伙伴类型层级。
    /// </summary>
    [JsonPropertyName("levelNum")]
    public long? LevelNum { get; set; }
}

/// <summary>
/// 部门三级伙伴类型。
/// </summary>
public class PartnerDepartmentsGetResponseDataItemPartnerLabelVOLevel3
{
    /// <summary>
    /// 伙伴类型ID。
    /// </summary>
    [JsonPropertyName("labelId")]
    public long? LabelId { get; set; }

    /// <summary>
    /// 伙伴类型。
    /// </summary>
    [JsonPropertyName("labelName")]
    public string? LabelName { get; set; }

    /// <summary>
    /// 伙伴类型层级。
    /// </summary>
    [JsonPropertyName("levelNum")]
    public long? LevelNum { get; set; }
}

/// <summary>
/// 部门四级伙伴类型。
/// </summary>
public class PartnerDepartmentsGetResponseDataItemPartnerLabelVOLevel4
{
    /// <summary>
    /// 伙伴类型ID。
    /// </summary>
    [JsonPropertyName("labelId")]
    public long? LabelId { get; set; }

    /// <summary>
    /// 伙伴类型。
    /// </summary>
    [JsonPropertyName("labelName")]
    public string? LabelName { get; set; }

    /// <summary>
    /// 伙伴类型层级。
    /// </summary>
    [JsonPropertyName("levelNum")]
    public long? LevelNum { get; set; }
}

/// <summary>
/// 部门五级伙伴类型。
/// </summary>
public class PartnerDepartmentsGetResponseDataItemPartnerLabelVOLevel5
{
    /// <summary>
    /// 伙伴类型ID。
    /// </summary>
    [JsonPropertyName("labelId")]
    public long? LabelId { get; set; }

    /// <summary>
    /// 伙伴类型。
    /// </summary>
    [JsonPropertyName("labelName")]
    public string? LabelName { get; set; }

    /// <summary>
    /// 伙伴类型层级。
    /// </summary>
    [JsonPropertyName("levelNum")]
    public long? LevelNum { get; set; }
}

/// <summary>
/// 设置部门伙伴类型和伙伴编码请求
/// </summary>
public class PartnerDepartmentsRequest
{
    /// <summary>
    /// 部门ID。
    /// </summary>
    [JsonPropertyName("deptId")]
    public required string DeptId { get; set; }

    /// <summary>
    /// 伙伴编码。
    /// </summary>
    [JsonPropertyName("partnerNum")]
    public string? PartnerNum { get; set; }

    /// <summary>
    /// 伙伴类型ID。
    /// </summary>
    [JsonPropertyName("labelIds")]
    public List<string> LabelIds { get; set; } = [];
}

/// <summary>
/// 获取子标签列表响应
/// </summary>
public class PartnerLabelsParentIdGetResponse
{
    /// <summary>
    /// 子标签列表。
    /// </summary>
    [JsonPropertyName("data")]
    public List<PartnerLabelsParentIdGetResponseDataItem> Data { get; set; } = [];
}

/// <summary>
/// Data项
/// </summary>
public class PartnerLabelsParentIdGetResponseDataItem
{
    /// <summary>
    /// 子标签ID。
    /// </summary>
    [JsonPropertyName("typeId")]
    public Dictionary<string, object?> TypeId { get; set; } = [];

    /// <summary>
    /// 子标签名称。
    /// </summary>
    [JsonPropertyName("typeName")]
    public string? TypeName { get; set; }
}

/// <summary>
/// 修改伙伴类型可见性请求
/// </summary>
public class PartnerDepartmentsVisibilityPartnersPutRequest
{
    /// <summary>
    /// 可见的部门ID列表。
    /// </summary>
    [JsonPropertyName("deptIds")]
    public List<string> DeptIds { get; set; } = [];

    /// <summary>
    /// 可见的员工userid列表。
    /// </summary>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; } = [];

    /// <summary>
    /// 标签ID。
    /// </summary>
    [JsonPropertyName("labelId")]
    public required string LabelId { get; set; }
}

/// <summary>
/// 修改伙伴类型可见性响应
/// </summary>
public class PartnerDepartmentsVisibilityPartnersPutResponse
{
    /// <summary>
    /// 调用是否成功。
    /// </summary>
    [JsonPropertyName("result")]
    public bool Result { get; set; }
}

/// <summary>
/// 查询伙伴角色列表响应
/// </summary>
public class PartnerRolesParentIdGetResponse
{
    /// <summary>
    /// 角色列表。
    /// </summary>
    [JsonPropertyName("list")]
    public List<PartnerRolesParentIdGetResponseListItem> List { get; set; } = [];
}

/// <summary>
/// List项
/// </summary>
public class PartnerRolesParentIdGetResponseListItem
{
    /// <summary>
    /// 角色ID。
    /// </summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>
    /// 角色名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 是否必邀角色。 0: 否 1: 是
    /// </summary>
    [JsonPropertyName("isNecessary")]
    public long? IsNecessary { get; set; }

    /// <summary>
    /// 可见员工列表。
    /// </summary>
    [JsonPropertyName("visibleUsers")]
    public List<PartnerRolesParentIdGetResponseListItemVisibleUsersItem> VisibleUsers { get; set; } = [];

    /// <summary>
    /// 可见部门列表。
    /// </summary>
    [JsonPropertyName("visibleDepts")]
    public List<PartnerRolesParentIdGetResponseListItemVisibleDeptsItem> VisibleDepts { get; set; } = [];

    /// <summary>
    /// 预警成员列表。
    /// </summary>
    [JsonPropertyName("warningUsers")]
    public List<PartnerRolesParentIdGetResponseListItemWarningUsersItem> WarningUsers { get; set; } = [];

    /// <summary>
    /// 预警部门列表。
    /// </summary>
    [JsonPropertyName("warningDepts")]
    public List<PartnerRolesParentIdGetResponseListItemWarningDeptsItem> WarningDepts { get; set; } = [];
}

/// <summary>
/// VisibleUsers项
/// </summary>
public class PartnerRolesParentIdGetResponseListItemVisibleUsersItem
{
    /// <summary>
    /// 可见员工userId。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 可见员工姓名。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// VisibleDepts项
/// </summary>
public class PartnerRolesParentIdGetResponseListItemVisibleDeptsItem
{
    /// <summary>
    /// 可见部门ID。
    /// </summary>
    [JsonPropertyName("deptId")]
    public long? DeptId { get; set; }

    /// <summary>
    /// 可见部门名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// WarningUsers项
/// </summary>
public class PartnerRolesParentIdGetResponseListItemWarningUsersItem
{
    /// <summary>
    /// 预警成员userId。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 预警成员姓名。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// WarningDepts项
/// </summary>
public class PartnerRolesParentIdGetResponseListItemWarningDeptsItem
{
    /// <summary>
    /// 预警部门ID。
    /// </summary>
    [JsonPropertyName("deptId")]
    public long? DeptId { get; set; }

    /// <summary>
    /// 预警部门名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// 修改角色可见性请求
/// </summary>
public class PartnerDepartmentsVisibilityRolesPutRequest
{
    /// <summary>
    /// 可见的部门ID列表。
    /// </summary>
    [JsonPropertyName("deptIds")]
    public List<string> DeptIds { get; set; } = [];

    /// <summary>
    /// 可见的员工userid列表。
    /// </summary>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; } = [];

    /// <summary>
    /// 标签iID。
    /// </summary>
    [JsonPropertyName("labelId")]
    public required string LabelId { get; set; }
}

/// <summary>
/// 修改角色可见性响应
/// </summary>
public class PartnerDepartmentsVisibilityRolesPutResponse
{
    /// <summary>
    /// 调用是否成功。
    /// </summary>
    [JsonPropertyName("result")]
    public bool Result { get; set; }
}

/// <summary>
/// 发送邀请函请求
/// </summary>
public class PartnerDepartmentsInvitationsSendRequest
{
    /// <summary>
    /// 部门ID。
    /// </summary>
    [JsonPropertyName("deptId")]
    public required string DeptId { get; set; }

    /// <summary>
    /// 伙伴编码。
    /// </summary>
    [JsonPropertyName("partnerNum")]
    public required string PartnerNum { get; set; }

    /// <summary>
    /// 手机号。
    /// </summary>
    [JsonPropertyName("phone")]
    public required string Phone { get; set; }

    /// <summary>
    /// 组织别名。
    /// </summary>
    [JsonPropertyName("orgAlias")]
    public required string OrgAlias { get; set; }

    /// <summary>
    /// 伙伴标签ID。
    /// </summary>
    [JsonPropertyName("partnerLabelId")]
    public required string PartnerLabelId { get; set; }
}

/// <summary>
/// 根据userId查询人员的标签信息响应
/// </summary>
public class PartnersUsersUserIdGetResponse
{
    /// <summary>
    /// 员工所在的部门列表。
    /// </summary>
    [JsonPropertyName("partnerDeptList")]
    public List<PartnersUsersUserIdGetResponsePartnerDeptListItem> PartnerDeptList { get; set; } = [];

    /// <summary>
    /// 伙伴类型下的角色列表。
    /// </summary>
    [JsonPropertyName("partnerLabelList")]
    public List<PartnersUsersUserIdGetResponsePartnerLabelListItem> PartnerLabelList { get; set; } = [];

    /// <summary>
    /// 员工userId。 说明 如果partnerLabelList为空，该字段返回为空。
    /// </summary>
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }
}

/// <summary>
/// PartnerDeptList项
/// </summary>
public class PartnersUsersUserIdGetResponsePartnerDeptListItem
{
    /// <summary>
    /// 部门名称。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 部门ID。
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    /// 成员数。
    /// </summary>
    [JsonPropertyName("memberCount")]
    public long? MemberCount { get; set; }

    /// <summary>
    /// 伙伴编码。
    /// </summary>
    [JsonPropertyName("partnerNum")]
    public string? PartnerNum { get; set; }

    /// <summary>
    /// 一级伙伴信息。
    /// </summary>
    [JsonPropertyName("partnerLabelModelLevel1")]
    public PartnersUsersUserIdGetResponsePartnerDeptListItemPartnerLabelModelLevel1 PartnerLabelModelLevel1 { get; set; }
}

/// <summary>
/// PartnerLabelList项
/// </summary>
public class PartnersUsersUserIdGetResponsePartnerLabelListItem
{
    /// <summary>
    /// 伙伴标签下的角色ID。
    /// </summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>
    /// 伙伴标签下的角色名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// 一级伙伴信息。
/// </summary>
public class PartnersUsersUserIdGetResponsePartnerDeptListItemPartnerLabelModelLevel1
{
    /// <summary>
    /// 一级伙伴标签ID。
    /// </summary>
    [JsonPropertyName("labelId")]
    public long LabelId { get; set; }

    /// <summary>
    /// 一级伙伴类型。
    /// </summary>
    [JsonPropertyName("labelname")]
    public required string Labelname { get; set; }
}

/// <summary>
/// DING服务请求
/// </summary>
public class AppDingsSendRequest
{
    /// <summary>
    /// 接收DING消息的用户userid列表。
    /// </summary>
    [JsonPropertyName("userids")]
    public List<string> Userids { get; set; } = [];

    /// <summary>
    /// 消息内容。
    /// </summary>
    [JsonPropertyName("content")]
    public required string Content { get; set; }
}

/// <summary>
/// 发送电话DING请求
/// </summary>
public class PhoneDingsSendRequest
{
    /// <summary>
    /// 接收DING消息的用户userId列表，最大值20。
    /// </summary>
    [JsonPropertyName("userids")]
    public List<string> Userids { get; set; } = [];

    /// <summary>
    /// 消息内容。
    /// </summary>
    [JsonPropertyName("content")]
    public required string Content { get; set; }
}

/// <summary>
/// 发送电话DING响应
/// </summary>
public class PhoneDingsSendResponse
{
    /// <summary>
    /// 发送Ding消息是否成功。 true：成功 false：失败
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }
}

/// <summary>
/// 获取文件操作记录响应
/// </summary>
public class FileAuditLogsGetResponse
{
    /// <summary>
    /// 获取的文件操作记录列表。
    /// </summary>
    [JsonPropertyName("list")]
    public List<FileAuditLogsGetResponseListItem> List { get; set; } = [];
}

/// <summary>
/// List项
/// </summary>
public class FileAuditLogsGetResponseListItem
{
    /// <summary>
    /// 操作用户的昵称。
    /// </summary>
    [JsonPropertyName("operatorName")]
    public string? OperatorName { get; set; }

    /// <summary>
    /// 操作端。 0：IOS端 1：ANDROID端 2：WEB端，即网页版钉钉 11：WIN端 12：MAC端
    /// </summary>
    [JsonPropertyName("platform")]
    public long? Platform { get; set; }

    /// <summary>
    /// 操作端含义值。 0：IOS端 1：ANDROID端 2：WEB端，即网页版钉钉 11：WIN端 12：MAC端
    /// </summary>
    [JsonPropertyName("platformView")]
    public string? PlatformView { get; set; }

    /// <summary>
    /// 记录状态。 0：正常 1：删除
    /// </summary>
    [JsonPropertyName("status")]
    public long? Status { get; set; }

    /// <summary>
    /// 操作类型。 0：上传文件 1：删除文件 2：下载文件 3：预览文件 4：覆盖文件 5：创建外链分享 6：重命名文件 7：移动文件 8：复制或转发文件 9：离职转交 10：创建文档 11：删除文档 12：导出文档 13：预览文档 14：回滚文档 15：应用内分享文档 16：文档移动 17：创建副本 18：文档评论 19：文档导入 20：更改协作者 21：...
    /// </summary>
    [JsonPropertyName("action")]
    public long? Action { get; set; }

    /// <summary>
    /// 操作类型含义值。 0：上传文件 1：删除文件 2：下载文件 3：预览文件 4：覆盖文件 5：创建外链分享 6：重命名文件 7：移动文件 8：复制或转发文件 9：离职转交 10：创建文档 11：删除文档 12：导出文档 13：预览文档 14：回滚文档 15：应用内分享文档 16：文档移动 17：创建副本 18：文档评论 19：文档导入 20：更改协作者...
    /// </summary>
    [JsonPropertyName("actionView")]
    public string? ActionView { get; set; }

    /// <summary>
    /// 文件名。
    /// </summary>
    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <summary>
    /// 记录生成时间，UNIX时间戳，单位毫秒。
    /// </summary>
    [JsonPropertyName("gmtCreate")]
    public long? GmtCreate { get; set; }

    /// <summary>
    /// 操作员工的userId。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 本次操作所在的机器IP。
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>
    /// 文件所属组织名称。
    /// </summary>
    [JsonPropertyName("orgName")]
    public string? OrgName { get; set; }

    /// <summary>
    /// 文件接收方名称。
    /// </summary>
    [JsonPropertyName("receiverName")]
    public string? ReceiverName { get; set; }

    /// <summary>
    /// 文件接收方类型含义值。 0：单聊 1：群聊 2：钉盘 3：文档
    /// </summary>
    [JsonPropertyName("receiverTypeView")]
    public string? ReceiverTypeView { get; set; }

    /// <summary>
    /// 文件接收方类型。 0：单聊 1：群聊 2：钉盘 3：文档
    /// </summary>
    [JsonPropertyName("receiverType")]
    public long? ReceiverType { get; set; }

    /// <summary>
    /// 文件类型。
    /// </summary>
    [JsonPropertyName("resourceExtension")]
    public string? ResourceExtension { get; set; }

    /// <summary>
    /// 文件大小。
    /// </summary>
    [JsonPropertyName("resourceSize")]
    public long? ResourceSize { get; set; }

    /// <summary>
    /// 文件所属的空间ID。
    /// </summary>
    [JsonPropertyName("targetSpaceId")]
    public long? TargetSpaceId { get; set; }

    /// <summary>
    /// 操作人的姓名。
    /// </summary>
    [JsonPropertyName("realName")]
    public string? RealName { get; set; }

    /// <summary>
    /// 文件ID。
    /// </summary>
    [JsonPropertyName("bizId")]
    public string? BizId { get; set; }

    /// <summary>
    /// 操作来源含义值。 0：我的文件 1：单聊或者普通群 2：企业群 3：公共区 4：微应用钉盘存储空间 5：共享文件夹 6：单聊 7：普通群 8：员工个人工作文件夹 9：临时空间 10：隐藏会话 11：会话 12：收集文件 13：自定义个人空间 14：自定义业务空间 15：内部自定义企业空间 16：项目钉盘 17：群任务 18：收藏空间 19：行业运营 2...
    /// </summary>
    [JsonPropertyName("operateModuleView")]
    public string? OperateModuleView { get; set; }

    /// <summary>
    /// 操作来源。 0：我的文件 1：单聊或者普通群 2：企业群 3：公共区 4：微应用钉盘存储空间 5：共享文件夹 6：单聊 7：普通群 8：员工个人工作文件夹 9：临时空间 10：隐藏会话 11：会话 12：收集文件 13：自定义个人空间 14：自定义业务空间 15：内部自定义企业空间 16：项目钉盘 17：群任务 18：收藏空间 19：行业运营 20：d...
    /// </summary>
    [JsonPropertyName("operateModule")]
    public long? OperateModule { get; set; }

    /// <summary>
    /// 记录修改时间，UNIX时间戳，单位毫秒。
    /// </summary>
    [JsonPropertyName("gmtModified")]
    public long? GmtModified { get; set; }

    /// <summary>
    /// 成员授权列表。 说明 需满足以下条件，此字段才生效：文档或知识库已进行授权操作。
    /// </summary>
    [JsonPropertyName("docMemberList")]
    public List<FileAuditLogsGetResponseListItemDocMemberListItem> DocMemberList { get; set; } = [];

    /// <summary>
    /// 文件接收人列表。 说明 只有进行了文档分享操作时，返回该字段。
    /// </summary>
    [JsonPropertyName("docReceiverList")]
    public List<FileAuditLogsGetResponseListItemDocReceiverListItem> DocReceiverList { get; set; } = [];

    /// <summary>
    /// 知识库名称。
    /// </summary>
    [JsonPropertyName("workSpaceName")]
    public string? WorkSpaceName { get; set; }

    /// <summary>
    /// 知识库PC端地址。
    /// </summary>
    [JsonPropertyName("workSpacePcUrl")]
    public string? WorkSpacePcUrl { get; set; }

    /// <summary>
    /// 知识库移动端地址。
    /// </summary>
    [JsonPropertyName("workSpaceMobileUrl")]
    public string? WorkSpaceMobileUrl { get; set; }

    /// <summary>
    /// 文档PC端地址。
    /// </summary>
    [JsonPropertyName("docPcUrl")]
    public string? DocPcUrl { get; set; }

    /// <summary>
    /// 文档移动端地址。
    /// </summary>
    [JsonPropertyName("docMobileUrl")]
    public string? DocMobileUrl { get; set; }

    /// <summary>
    /// 知识库id。
    /// </summary>
    [JsonPropertyName("workSpaceId")]
    public long? WorkSpaceId { get; set; }
}

/// <summary>
/// DocMemberList项
/// </summary>
public class FileAuditLogsGetResponseListItemDocMemberListItem
{
    /// <summary>
    /// 接收人名称。
    /// </summary>
    [JsonPropertyName("memberName")]
    public string? MemberName { get; set; }

    /// <summary>
    /// 接收人类型。 0：部门 1：群 2：用户 3：组织
    /// </summary>
    [JsonPropertyName("memberType")]
    public long? MemberType { get; set; }

    /// <summary>
    /// 成员类型含义值。 0：部门 1：群 2：用户 3：组织
    /// </summary>
    [JsonPropertyName("memberTypeView")]
    public string? MemberTypeView { get; set; }

    /// <summary>
    /// 权限类型。 0：无权限 1：可查看和下载 2：可编辑 3：管理者 4：仅可查看，不能下载
    /// </summary>
    [JsonPropertyName("permissionRole")]
    public long? PermissionRole { get; set; }

    /// <summary>
    /// 权限类型含义值。 0：无权限 1：可查看和下载 2：可编辑 3：管理者 4：仅可查看，不能下载
    /// </summary>
    [JsonPropertyName("permissionRoleView")]
    public string? PermissionRoleView { get; set; }
}

/// <summary>
/// DocReceiverList项
/// </summary>
public class FileAuditLogsGetResponseListItemDocReceiverListItem
{
    /// <summary>
    /// 授权成员名称。
    /// </summary>
    [JsonPropertyName("receiverName")]
    public string? ReceiverName { get; set; }

    /// <summary>
    /// 授权成员类型。 0：单聊 1：群聊 2：钉盘 3：文档
    /// </summary>
    [JsonPropertyName("receiverType")]
    public long? ReceiverType { get; set; }

    /// <summary>
    /// 授权成员类型含义值。 0：单聊 1：群聊 2：钉盘 3：文档
    /// </summary>
    [JsonPropertyName("receiverTypeView")]
    public string? ReceiverTypeView { get; set; }
}

/// <summary>
/// 发送文件更改的评论请求
/// </summary>
public class CommentsSendRequest
{
    /// <summary>
    /// 钉盘文件ID。可以调用JSAPI获取： 企业内部应用： 小程序：选取钉盘目录。 微应用：选取钉盘目录。 第三方企业应用： 小程序：选取钉盘目录。 微应用：选取钉盘目录。
    /// </summary>
    [JsonPropertyName("fileId")]
    public required string FileId { get; set; }

    /// <summary>
    /// 钉盘空间ID，可以调用JSAPI获取： 企业内部应用： 小程序：选取钉盘目录。 微应用：选取钉盘目录。 第三方企业应用： 小程序：选取钉盘目录。 微应用：选取钉盘目录。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public required string SpaceId { get; set; }

    /// <summary>
    /// 操作人的unionId，可通过以下两种方式获取： 企业内部应用： 可以调用通过免登码获取用户信息(v2)接口获取。 可以调用查询用户详情接口获取。 第三方企业应用： 可以调用通过免登码获取用户信息(v2)接口获取。 可以调用查询用户详情接口获取。
    /// </summary>
    [JsonPropertyName("operatorUnionId")]
    public required string OperatorUnionId { get; set; }

    /// <summary>
    /// 操作类型，取值： 1：添加 2：修改
    /// </summary>
    [JsonPropertyName("operateType")]
    public string? OperateType { get; set; }
}

/// <summary>
/// 获取群活跃明细列表响应
/// </summary>
public class DataActiveGroupsGetResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    [JsonPropertyName("data")]
    public List<DataActiveGroupsGetResponseDataItem> Data { get; set; } = [];

    /// <summary>
    /// 总共数据条数。
    /// </summary>
    [JsonPropertyName("totalCount")]
    public long TotalCount { get; set; }
}

/// <summary>
/// Data项
/// </summary>
public class DataActiveGroupsGetResponseDataItem
{
    /// <summary>
    /// 统计时间。
    /// </summary>
    [JsonPropertyName("statDate")]
    public string? StatDate { get; set; }

    /// <summary>
    /// 群组ID。
    /// </summary>
    [JsonPropertyName("dingGroupId")]
    public string? DingGroupId { get; set; }

    /// <summary>
    /// 群组创建时间。
    /// </summary>
    [JsonPropertyName("groupCreateTime")]
    public string? GroupCreateTime { get; set; }

    /// <summary>
    /// 群组创建者的unionId。
    /// </summary>
    [JsonPropertyName("groupCreateUserId")]
    public string? GroupCreateUserId { get; set; }

    /// <summary>
    /// 群组创建用户姓名。
    /// </summary>
    [JsonPropertyName("groupCreateUserName")]
    public string? GroupCreateUserName { get; set; }

    /// <summary>
    /// 群名称。
    /// </summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    /// <summary>
    /// 群类型，取值。 1：全员群 2：部门群 3：内部群（其他） 4：场景群
    /// </summary>
    [JsonPropertyName("groupType")]
    public long? GroupType { get; set; }

    /// <summary>
    /// 最近1天群人数。
    /// </summary>
    [JsonPropertyName("groupUserCnt1d")]
    public long? GroupUserCnt1d { get; set; }

    /// <summary>
    /// 最近1天发消息人数。
    /// </summary>
    [JsonPropertyName("sendMessageUserCnt1d")]
    public long? SendMessageUserCnt1d { get; set; }

    /// <summary>
    /// 最近1天发消息次数。
    /// </summary>
    [JsonPropertyName("sendMessageCnt1d")]
    public long? SendMessageCnt1d { get; set; }

    /// <summary>
    /// 最近1天打开群人数。
    /// </summary>
    [JsonPropertyName("openConvUv1d")]
    public long? OpenConvUv1d { get; set; }
}

/// <summary>
/// 查询企业内部群信息响应
/// </summary>
public class SecuritiesOrgGroupInfosGetResponse
{
    /// <summary>
    /// 查询总数。
    /// </summary>
    [JsonPropertyName("totalCount")]
    public long? TotalCount { get; set; }

    /// <summary>
    /// 当前查询结果数。
    /// </summary>
    [JsonPropertyName("itemCount")]
    public long? ItemCount { get; set; }

    /// <summary>
    /// 当前结果集。
    /// </summary>
    [JsonPropertyName("items")]
    public List<SecuritiesOrgGroupInfosGetResponseItemsItem> Items { get; set; } = [];
}

/// <summary>
/// Items项
/// </summary>
public class SecuritiesOrgGroupInfosGetResponseItemsItem
{
    /// <summary>
    /// 群会话开放id。
    /// </summary>
    [JsonPropertyName("openConversationId")]
    public string? OpenConversationId { get; set; }

    /// <summary>
    /// 群主。
    /// </summary>
    [JsonPropertyName("groupOwner")]
    public string? GroupOwner { get; set; }

    /// <summary>
    /// 群名。
    /// </summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    /// <summary>
    /// 群管理员个数。
    /// </summary>
    [JsonPropertyName("groupAdminsCount")]
    public long? GroupAdminsCount { get; set; }

    /// <summary>
    /// 群人数。
    /// </summary>
    [JsonPropertyName("groupMembersCount")]
    public long? GroupMembersCount { get; set; }

    /// <summary>
    /// 群创建时间。
    /// </summary>
    [JsonPropertyName("groupCreateTime")]
    public long? GroupCreateTime { get; set; }

    /// <summary>
    /// 群最后一次活跃时间。
    /// </summary>
    [JsonPropertyName("groupLastActiveTime")]
    public long? GroupLastActiveTime { get; set; }

    /// <summary>
    /// 群最后一次活跃时间文字描述。
    /// </summary>
    [JsonPropertyName("groupLastActiveTimeShow")]
    public string? GroupLastActiveTimeShow { get; set; }

    /// <summary>
    /// 是否同步到钉盘。
    /// </summary>
    [JsonPropertyName("syncToDingpan")]
    public long? SyncToDingpan { get; set; }

    /// <summary>
    /// 当前使用容量。
    /// </summary>
    [JsonPropertyName("usedQuota")]
    public long? UsedQuota { get; set; }

    /// <summary>
    /// 群主的userid。
    /// </summary>
    [JsonPropertyName("groupOwnerUserId")]
    public string? GroupOwnerUserId { get; set; }

    /// <summary>
    /// 群状态：
    /// </summary>
    [JsonPropertyName("status")]
    public long? Status { get; set; }

    /// <summary>
    /// 群模板ID。
    /// </summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }

    /// <summary>
    /// 群模板名称。
    /// </summary>
    [JsonPropertyName("templateName")]
    public string? TemplateName { get; set; }
}

/// <summary>
/// 企业内部群禁言或解除禁言请求
/// </summary>
public class EnterpriseSecuritiesBanOrOpenGroupWordsPutRequest
{
    /// <summary>
    /// 群ID，获取方式如下 1. 拥有专属安全-群管理权限的管理员登录 &gt; 专属钉钉 &gt; 专属安全 &gt; 群管理中读取，如图。 2. 通过接口获取。 - 企业内部应用，调用接口获取。 - 第三方企业应用，调用接口获取。
    /// </summary>
    [JsonPropertyName("openConverationId")]
    public required string OpenConverationId { get; set; }

    /// <summary>
    /// 操作类型。 0：解除禁言 1：开启禁言
    /// </summary>
    [JsonPropertyName("banWordsType")]
    public long BanWordsType { get; set; }
}

/// <summary>
/// 企业内部群禁言或解除禁言响应
/// </summary>
public class EnterpriseSecuritiesBanOrOpenGroupWordsPutResponse
{
    /// <summary>
    /// 返回码
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// 结果。
    /// </summary>
    [JsonPropertyName("cause")]
    public required string Cause { get; set; }
}

/// <summary>
/// 根据会议逻辑ID查询会议基本信息响应
/// </summary>
public class DataConferencesGetResponse
{
    /// <summary>
    /// 会议实体ID。 说明 会议正式开始后才会返回该字段。
    /// </summary>
    [JsonPropertyName("conferenceId")]
    public required string ConferenceId { get; set; }

    /// <summary>
    /// 会议标题。
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    /// <summary>
    /// 开始时间戳，单位毫秒。
    /// </summary>
    [JsonPropertyName("startTime")]
    public long StartTime { get; set; }

    /// <summary>
    /// 会议逻辑ID。
    /// </summary>
    [JsonPropertyName("logicalConferenceId")]
    public required string LogicalConferenceId { get; set; }

    /// <summary>
    /// 会议创建者的unionId。
    /// </summary>
    [JsonPropertyName("unionId")]
    public required string UnionId { get; set; }

    /// <summary>
    /// 会议创建者的昵称。
    /// </summary>
    [JsonPropertyName("nickname")]
    public required string Nickname { get; set; }
}

/// <summary>
/// 获取防截屏操作记录请求
/// </summary>
public class EnterpriseSecuritiesUserBehaviorsScreenshotsQueryRequest
{
    /// <summary>
    /// 用户userId信息，可调用获取部门用户userId列表接口获取userId。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 用户行为： 0：全部 1：截屏 2：录屏
    /// </summary>
    [JsonPropertyName("type")]
    public long Type { get; set; }

    /// <summary>
    /// 端类型： 0：全部 1：iOS 2：Android 3：Mac 4：Windows
    /// </summary>
    [JsonPropertyName("platform")]
    public long Platform { get; set; }

    /// <summary>
    /// 开始时间，时间戳，单位毫秒。 说明 默认当前时间前7天。
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>
    /// 结束时间，时间戳，单位毫秒。 说明 默认当前时间。
    /// </summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>
    /// 分页大小。 说明 最大值100。
    /// </summary>
    [JsonPropertyName("pageSize")]
    public required string PageSize { get; set; }

    /// <summary>
    /// 起始页。 说明 默认从1开始。
    /// </summary>
    [JsonPropertyName("pageNumber")]
    public required string PageNumber { get; set; }
}

/// <summary>
/// 获取防截屏操作记录响应
/// </summary>
public class EnterpriseSecuritiesUserBehaviorsScreenshotsQueryResponse
{
    /// <summary>
    /// 数据列表。
    /// </summary>
    [JsonPropertyName("data")]
    public List<EnterpriseSecuritiesUserBehaviorsScreenshotsQueryResponseDataItem> Data { get; set; } = [];

    /// <summary>
    /// 数据总量。
    /// </summary>
    [JsonPropertyName("totalCnt")]
    public long TotalCount { get; set; }

    /// <summary>
    /// 当前页数据量。
    /// </summary>
    [JsonPropertyName("dataCnt")]
    public long DataCount { get; set; }
}

/// <summary>
/// Data项
/// </summary>
public class EnterpriseSecuritiesUserBehaviorsScreenshotsQueryResponseDataItem
{
    /// <summary>
    /// 用户昵称。
    /// </summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }

    /// <summary>
    /// 用户操作时间，时间戳，单位毫秒。
    /// </summary>
    [JsonPropertyName("time")]
    public long? Time { get; set; }

    /// <summary>
    /// 用户操作类型： 1：截屏 2：录屏
    /// </summary>
    [JsonPropertyName("type")]
    public long? Type { get; set; }

    /// <summary>
    /// 用户截屏图片url。 说明 当用户签署响应条款后，才能获取到图片URL。
    /// </summary>
    [JsonPropertyName("pictureUrl")]
    public string? PictureUrl { get; set; }

    /// <summary>
    /// 端类型： 1：iOS 2：Android 3：Mac 4：Windows
    /// </summary>
    [JsonPropertyName("platform")]
    public long? Platform { get; set; }

    /// <summary>
    /// 场景。
    /// </summary>
    [JsonPropertyName("scene")]
    public string? Scene { get; set; }

    /// <summary>
    /// 用户userId。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }
}

/// <summary>
/// 查询实人认证状态请求
/// </summary>
public class PersonsIdentificationStatesQueryRequest
{
    /// <summary>
    /// 员工userId列表。
    /// </summary>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; } = [];
}

/// <summary>
/// 查询实人认证状态响应
/// </summary>
public class PersonsIdentificationStatesQueryResponse
{
    /// <summary>
    /// 返回的信息列表。
    /// </summary>
    [JsonPropertyName("data")]
    public List<PersonsIdentificationStatesQueryResponseDataItem> Data { get; set; } = [];
}

/// <summary>
/// Data项
/// </summary>
public class PersonsIdentificationStatesQueryResponseDataItem
{
    /// <summary>
    /// 认证状态： 1：未认证 2：已认证
    /// </summary>
    [JsonPropertyName("state")]
    public long? State { get; set; }

    /// <summary>
    /// 用户userId。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }
}

/// <summary>
/// 查询人脸录入状态请求
/// </summary>
public class FacesRecognizeStatesQueryRequest
{
    /// <summary>
    /// userIduserId列表。
    /// </summary>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; } = [];
}

/// <summary>
/// 查询人脸录入状态响应
/// </summary>
public class FacesRecognizeStatesQueryResponse
{
    /// <summary>
    /// 查询的信息列表。
    /// </summary>
    [JsonPropertyName("data")]
    public List<FacesRecognizeStatesQueryResponseDataItem> Data { get; set; } = [];
}

/// <summary>
/// Data项
/// </summary>
public class FacesRecognizeStatesQueryResponseDataItem
{
    /// <summary>
    /// 人脸录入状态。 1：无人脸 2：有人脸
    /// </summary>
    [JsonPropertyName("state")]
    public long? State { get; set; }

    /// <summary>
    /// 用户userId。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }
}

/// <summary>
/// 获取实人认证接口调用记录请求
/// </summary>
public class PersonsIdentificationRecordsQueryRequest
{
    /// <summary>
    /// 记录开始时间戳，单位毫秒。
    /// </summary>
    [JsonPropertyName("fromTime")]
    public string? FromTime { get; set; }

    /// <summary>
    /// 记录结束时间戳，单位毫秒。
    /// </summary>
    [JsonPropertyName("toTime")]
    public string? ToTime { get; set; }

    /// <summary>
    /// 应用唯一标识。
    /// </summary>
    [JsonPropertyName("agentId")]
    public string? AgentId { get; set; }

    /// <summary>
    /// 员工userId列表。
    /// </summary>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; } = [];

    /// <summary>
    /// 分页游标，从0开始。
    /// </summary>
    [JsonPropertyName("nextToken")]
    public required string NextToken { get; set; }

    /// <summary>
    /// 每页最大条目数，最大值50。
    /// </summary>
    [JsonPropertyName("maxResults")]
    public long MaxResults { get; set; }

    /// <summary>
    /// 实人认证结果。 1：成功 2：失败
    /// </summary>
    [JsonPropertyName("personIdentification")]
    public long? PersonIdentification { get; set; }

    /// <summary>
    /// 场景。 1：姓名匹配阶段失败 2：认证阶段失败 3：实人流程阶段失败 4：协议签署阶段失败 5：人脸录入阶段失败 6：人脸录入阶段用户主动取消 7：人脸录入阶段成功 8：人脸识别阶段失败 9：人脸识别阶段主动取消 10：人脸识别阶段成功 11：去实人场景
    /// </summary>
    [JsonPropertyName("scene")]
    public long? Scene { get; set; }
}

/// <summary>
/// 获取实人认证接口调用记录响应
/// </summary>
public class PersonsIdentificationRecordsQueryResponse
{
    /// <summary>
    /// 分页游标。
    /// </summary>
    [JsonPropertyName("nextToken")]
    public long NextToken { get; set; }

    /// <summary>
    /// 总数据数。
    /// </summary>
    [JsonPropertyName("total")]
    public long Total { get; set; }

    /// <summary>
    /// 数据列表。
    /// </summary>
    [JsonPropertyName("data")]
    public List<PersonsIdentificationRecordsQueryResponseDataItem> Data { get; set; } = [];
}

/// <summary>
/// Data项
/// </summary>
public class PersonsIdentificationRecordsQueryResponseDataItem
{
    /// <summary>
    /// 用户userId。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 接口调用时间戳，单位毫秒。
    /// </summary>
    [JsonPropertyName("invokeTime")]
    public long? InvokeTime { get; set; }

    /// <summary>
    /// 实人认证结果。 1：成功 2：失败
    /// </summary>
    [JsonPropertyName("personIdentification")]
    public long? PersonIdentification { get; set; }

    /// <summary>
    /// 平台。 0：Android 1：iOS
    /// </summary>
    [JsonPropertyName("platform")]
    public long? Platform { get; set; }

    /// <summary>
    /// 场景。 1：姓名匹配阶段失败 2：认证阶段失败 3：实人流程阶段失败 4：协议签署阶段失败 5：人脸录入阶段失败 6：人脸录入阶段用户主动取消 7：人脸录入阶段成功 8：人脸识别阶段失败 9：人脸识别阶段主动取消 10：人脸识别阶段成功 11：去实人场景
    /// </summary>
    [JsonPropertyName("scene")]
    public long? Scene { get; set; }
}

/// <summary>
/// 获取人脸对比接口调用记录请求
/// </summary>
public class FacesRecognizeRecordsQueryRequest
{
    /// <summary>
    /// 记录开始时间戳，单位毫秒。
    /// </summary>
    [JsonPropertyName("fromTime")]
    public string? FromTime { get; set; }

    /// <summary>
    /// 记录结束时间戳，单位毫秒。
    /// </summary>
    [JsonPropertyName("toTime")]
    public string? ToTime { get; set; }

    /// <summary>
    /// 应用唯一标识。
    /// </summary>
    [JsonPropertyName("agentId")]
    public string? AgentId { get; set; }

    /// <summary>
    /// 员工userId列表。
    /// </summary>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; } = [];

    /// <summary>
    /// 分页游标，从0开始。
    /// </summary>
    [JsonPropertyName("nextToken")]
    public required string NextToken { get; set; }

    /// <summary>
    /// 每页最大条目数，最大50。
    /// </summary>
    [JsonPropertyName("maxResults")]
    public long MaxResults { get; set; }

    /// <summary>
    /// 人脸对比结果。 1：成功 2：失败
    /// </summary>
    [JsonPropertyName("faceCompareResult")]
    public string? FaceCompareResult { get; set; }
}

/// <summary>
/// 获取人脸对比接口调用记录响应
/// </summary>
public class FacesRecognizeRecordsQueryResponse
{
    /// <summary>
    /// 分页游标。
    /// </summary>
    [JsonPropertyName("nextToken")]
    public long NextToken { get; set; }

    /// <summary>
    /// 总数据数。
    /// </summary>
    [JsonPropertyName("total")]
    public long Total { get; set; }

    /// <summary>
    /// 数据信息列表。
    /// </summary>
    [JsonPropertyName("data")]
    public List<FacesRecognizeRecordsQueryResponseDataItem> Data { get; set; } = [];
}

/// <summary>
/// Data项
/// </summary>
public class FacesRecognizeRecordsQueryResponseDataItem
{
    /// <summary>
    /// 用户userId。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 接口调用时间戳，单位毫秒。
    /// </summary>
    [JsonPropertyName("invokeTime")]
    public long? InvokeTime { get; set; }

    /// <summary>
    /// 人脸对比结果。 1：成功 2：失败
    /// </summary>
    [JsonPropertyName("faceCompareResult")]
    public long? FaceCompareResult { get; set; }

    /// <summary>
    /// 平台。 0：Android 1：iOS
    /// </summary>
    [JsonPropertyName("platform")]
    public long? Platform { get; set; }
}

/// <summary>
/// 新增服务号请求
/// </summary>
public class ServiceAccountAddRequest
{
    /// <summary>
    /// 服务号名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 头像图片mediaId，可以通过上传媒体文件接口上传图片获取mediaId。
    /// </summary>
    [JsonPropertyName("avatar_media_id")]
    public required string AvatarMediaId { get; set; }

    /// <summary>
    /// 机器人管理列表中的简介。
    /// </summary>
    [JsonPropertyName("brief")]
    public string? Brief { get; set; }

    /// <summary>
    /// 机器人主页中的服务号功能简介，最多200个字符。
    /// </summary>
    [JsonPropertyName("desc")]
    public required string Desc { get; set; }

    /// <summary>
    /// 机器人主页中，消息预览图片的mediaId，可以通过上传媒体文件接口上传图片获取mediaId。
    /// </summary>
    [JsonPropertyName("preview_media_id")]
    public required string PreviewMediaId { get; set; }
}

/// <summary>
/// 新增服务号响应
/// </summary>
public class ServiceAccountAddResponse
{
    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public long Errcode { get; set; }

    /// <summary>
    /// 服务号的unionid。
    /// </summary>
    [JsonPropertyName("unionid")]
    public required string UnionId { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; set; }
}

/// <summary>
/// 更新服务号请求
/// </summary>
public class ServiceAccountUpdateRequest
{
    /// <summary>
    /// 服务号的unionid，可通过查询服务号列表接口获取。
    /// </summary>
    [JsonPropertyName("unionid")]
    public required string UnionId { get; set; }

    /// <summary>
    /// 服务号名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 头像图片mediaId，可以通过上传媒体文件接口上传图片获取mediaId。
    /// </summary>
    [JsonPropertyName("avatar_media_id")]
    public string? AvatarMediaId { get; set; }

    /// <summary>
    /// 机器人管理列表中的简介，最多60个字符。
    /// </summary>
    [JsonPropertyName("brief")]
    public string? Brief { get; set; }

    /// <summary>
    /// 机器人主页中的服务号功能简介，最多200个字符。
    /// </summary>
    [JsonPropertyName("desc")]
    public string? Desc { get; set; }

    /// <summary>
    /// 机器人主页中，消息预览图片的mediaId，可以通过上传媒体文件接口上传图片获取mediaId。
    /// </summary>
    [JsonPropertyName("preview_media_id")]
    public string? PreviewMediaId { get; set; }

    /// <summary>
    /// 状态：normal：正常disabled：删除当status设置为disabled时，就代表永久的删除当前服务号。
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// 更新服务号响应
/// </summary>
public class ServiceAccountUpdateResponse
{
    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 查询服务号列表请求
/// </summary>
public class ServiceAccountListRequest
{
    /// <summary>
    /// 页码，从1开始。
    /// </summary>
    [JsonPropertyName("pageStart")]
    public decimal? PageStart { get; set; }

    /// <summary>
    /// 每页条数。
    /// </summary>
    [JsonPropertyName("pageSize")]
    public decimal? PageSize { get; set; }
}

/// <summary>
/// 查询服务号列表响应
/// </summary>
public class ServiceAccountListResponse
{
    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 总记录数。
    /// </summary>
    [JsonPropertyName("total_count")]
    public decimal? TotalCount { get; set; }

    /// <summary>
    /// 当前记录数。
    /// </summary>
    [JsonPropertyName("item_count")]
    public decimal? ItemCount { get; set; }

    /// <summary>
    /// 服务号列表。
    /// </summary>
    [JsonPropertyName("items")]
    public List<ServiceAccountListResponseItemsItem> Items { get; set; } = [];
}

/// <summary>
/// Items项
/// </summary>
public class ServiceAccountListResponseItemsItem
{
    /// <summary>
    /// 机器人主页中的服务号功能简介。
    /// </summary>
    [JsonPropertyName("desc")]
    public string? Desc { get; set; }

    /// <summary>
    /// 机器人主页中，消息预览图片的mediaId。
    /// </summary>
    [JsonPropertyName("preview_media_id")]
    public string? PreviewMediaId { get; set; }

    /// <summary>
    /// 机器人管理列表中的简介。
    /// </summary>
    [JsonPropertyName("brief")]
    public string? Brief { get; set; }

    /// <summary>
    /// 头像图片mediaId。
    /// </summary>
    [JsonPropertyName("avatar_media_id")]
    public string? AvatarMediaId { get; set; }

    /// <summary>
    /// 服务号名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 状态：normal：正常disabled：停用
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// 服务号的unionid。
    /// </summary>
    [JsonPropertyName("unionid")]
    public string? UnionId { get; set; }
}

/// <summary>
/// 查询服务号详情请求
/// </summary>
public class ServiceAccountGetRequest
{
    /// <summary>
    /// 服务号的unionid，可通过查询服务号列表接口获取。
    /// </summary>
    [JsonPropertyName("unionid")]
    public required string UnionId { get; set; }
}

/// <summary>
/// 查询服务号详情响应
/// </summary>
public class ServiceAccountGetResponse
{
    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 服务号详情。
    /// </summary>
    [JsonPropertyName("service_account")]
    public ServiceAccountGetResponseServiceAccount ServiceAccount { get; set; }
}

/// <summary>
/// 服务号详情。
/// </summary>
public class ServiceAccountGetResponseServiceAccount
{
    /// <summary>
    /// 状态：normal：正常disabled：删除
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// 服务号的unionid。
    /// </summary>
    [JsonPropertyName("unionid")]
    public string? UnionId { get; set; }

    /// <summary>
    /// 服务号名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 机器人管理列表中的简介，最多60个字符。
    /// </summary>
    [JsonPropertyName("brief")]
    public string? Brief { get; set; }

    /// <summary>
    /// 机器人主页中的服务号功能简介，最多200个字符。
    /// </summary>
    [JsonPropertyName("desc")]
    public string? Desc { get; set; }

    /// <summary>
    /// 头像图片mediaId。
    /// </summary>
    [JsonPropertyName("avatar_media_id")]
    public string? AvatarMediaId { get; set; }

    /// <summary>
    /// 机器人主页中，消息预览图片的mediaId。
    /// </summary>
    [JsonPropertyName("preview_media_id")]
    public string? PreviewMediaId { get; set; }
}

/// <summary>
/// 新增文章请求
/// </summary>
public class MaterialArticleAddRequest
{
    /// <summary>
    /// 服务号的unionid，可以通过查询服务号列表接口获取。
    /// </summary>
    [JsonPropertyName("unionid")]
    public required string UnionId { get; set; }

    /// <summary>
    /// 文章参数对象。
    /// </summary>
    [JsonPropertyName("article")]
    public Dictionary<string, object?> Article { get; set; } = [];
}

/// <summary>
/// 新增文章响应
/// </summary>
public class MaterialArticleAddResponse
{
    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public long Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    /// <summary>
    /// 文章id。
    /// </summary>
    [JsonPropertyName("article_id")]
    public long ArticleId { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; set; }
}

/// <summary>
/// 删除文章请求
/// </summary>
public class MaterialArticleDeleteRequest
{
    /// <summary>
    /// 服务号的unionid，可以通过查询服务号列表接口获取。
    /// </summary>
    [JsonPropertyName("unionid")]
    public required string UnionId { get; set; }

    /// <summary>
    /// 文章id，可以通过查询文章列表接口获取。
    /// </summary>
    [JsonPropertyName("article_id")]
    public decimal ArticleId { get; set; }
}

/// <summary>
/// 删除文章响应
/// </summary>
public class MaterialArticleDeleteResponse
{
    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

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
/// 更新文章请求
/// </summary>
public class MaterialArticleUpdateRequest
{
    /// <summary>
    /// 服务号的unionid，可以通过查询服务号列表接口获取。
    /// </summary>
    [JsonPropertyName("unionid")]
    public required string UnionId { get; set; }

    /// <summary>
    /// 文章参数对象。
    /// </summary>
    [JsonPropertyName("article")]
    public Dictionary<string, object?> Article { get; set; } = [];
}

/// <summary>
/// 更新文章响应
/// </summary>
public class MaterialArticleUpdateResponse
{
    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

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
/// 查询文章列表请求
/// </summary>
public class MaterialArticleListRequest
{
    /// <summary>
    /// 服务号的unionid，可以通过查询服务号列表接口获取。
    /// </summary>
    [JsonPropertyName("unionid")]
    public required string UnionId { get; set; }

    /// <summary>
    /// 每页条数。
    /// </summary>
    [JsonPropertyName("page_size")]
    public decimal PageSize { get; set; }

    /// <summary>
    /// 页码。
    /// </summary>
    [JsonPropertyName("page_start")]
    public decimal PageStart { get; set; }
}

/// <summary>
/// 查询文章列表响应
/// </summary>
public class MaterialArticleListResponse
{
    /// <summary>
    /// 文章列表。
    /// </summary>
    [JsonPropertyName("items")]
    public List<MaterialArticleListResponseItemsItem> Items { get; set; } = [];

    /// <summary>
    /// 文章总数。
    /// </summary>
    [JsonPropertyName("total_count")]
    public decimal? TotalCount { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 本页条数。
    /// </summary>
    [JsonPropertyName("item_count")]
    public decimal? ItemCount { get; set; }
}

/// <summary>
/// Items项
/// </summary>
public class MaterialArticleListResponseItemsItem
{
    /// <summary>
    /// 文章id。
    /// </summary>
    [JsonPropertyName("article_id")]
    public decimal? ArticleId { get; set; }

    /// <summary>
    /// 标题。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 封面图。
    /// </summary>
    [JsonPropertyName("thumb_media_id")]
    public string? ThumbMediaId { get; set; }

    /// <summary>
    /// 发布状态：0：未发布1：已发布文章第一次发布后，状态置为1，已发布文章支持修改，修改后此状态保持为1，每次修改文章后需要再次发布内容才会生效。
    /// </summary>
    [JsonPropertyName("publish_status")]
    public decimal? PublishStatus { get; set; }

    /// <summary>
    /// 发布时间。文章成功发布之后才有返回值。
    /// </summary>
    [JsonPropertyName("publish_time")]
    public decimal? PublishTime { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    [JsonPropertyName("create_time")]
    public decimal? CreateTime { get; set; }

    /// <summary>
    /// 更新时间。
    /// </summary>
    [JsonPropertyName("update_time")]
    public decimal? UpdateTime { get; set; }

    /// <summary>
    /// 文章内容。
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// 文章跳转链接。文章成功发布之后才有返回值。
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// 文章摘要。
    /// </summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }
}

/// <summary>
/// 获取文章详情请求
/// </summary>
public class MaterialArticleGetRequest
{
    /// <summary>
    /// 调用服务端接口的授权凭证。企业内部应用可通过调用access_token接口获得。
    /// </summary>
    [JsonPropertyName("unionid")]
    public required string UnionId { get; set; }

    /// <summary>
    /// 文章id，可以通过查询文章列表接口获取。
    /// </summary>
    [JsonPropertyName("article_id")]
    public decimal ArticleId { get; set; }
}

/// <summary>
/// 获取文章详情响应
/// </summary>
public class MaterialArticleGetResponse
{
    /// <summary>
    /// 文章id。
    /// </summary>
    [JsonPropertyName("article_id")]
    public decimal? ArticleId { get; set; }

    /// <summary>
    /// 文章标题。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 封面图。
    /// </summary>
    [JsonPropertyName("thumb_media_id")]
    public string? ThumbMediaId { get; set; }

    /// <summary>
    /// 发布状态：0：未发布1：已发布文章第一次发布后，状态置为1，已发布文章支持修改，修改后此状态保持为1，每次修改文章后需要再次发布内容才会生效。
    /// </summary>
    [JsonPropertyName("publish_status")]
    public decimal? PublishStatus { get; set; }

    /// <summary>
    /// 发布时间。文章成功发布之后才有返回值。
    /// </summary>
    [JsonPropertyName("publish_time")]
    public decimal? PublishTime { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    [JsonPropertyName("create_time")]
    public decimal? CreateTime { get; set; }

    /// <summary>
    /// 更新时间。
    /// </summary>
    [JsonPropertyName("update_time")]
    public decimal? UpdateTime { get; set; }

    /// <summary>
    /// 文章内容（html格式）。
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 文章跳转链接。文章成功发布之后才有返回值。
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// 文章摘要。
    /// </summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }
}

/// <summary>
/// 发布文章请求
/// </summary>
public class MaterialArticlePublishRequest
{
    /// <summary>
    /// 服务号的unionid，可以通过查询服务号列表接口获取。
    /// </summary>
    [JsonPropertyName("unionid")]
    public required string UnionId { get; set; }

    /// <summary>
    /// 文章id，可以通过查询文章列表接口获取。
    /// </summary>
    [JsonPropertyName("article_id")]
    public decimal ArticleId { get; set; }
}

/// <summary>
/// 发布文章响应
/// </summary>
public class MaterialArticlePublishResponse
{
    /// <summary>
    /// 生成文章url链接。
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }
}

/// <summary>
/// 新增图文卡片请求
/// </summary>
public class MaterialNewsAddRequest
{
    /// <summary>
    /// 服务号的unionid，可以通过查询服务号列表接口获取。
    /// </summary>
    [JsonPropertyName("unionid")]
    public required string UnionId { get; set; }

    /// <summary>
    /// 文章列表。
    /// </summary>
    [JsonPropertyName("articles")]
    public List<Dictionary<string, object?>> Articles { get; set; } = [];
}

/// <summary>
/// 新增图文卡片响应
/// </summary>
public class MaterialNewsAddResponse
{
    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 卡片素材id。
    /// </summary>
    [JsonPropertyName("media_id")]
    public string? MediaId { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }
}

/// <summary>
/// 删除图文卡片请求
/// </summary>
public class MaterialNewsDeleteRequest
{
    /// <summary>
    /// 服务号的unionid，可以通过查询服务号列表接口获取。
    /// </summary>
    [JsonPropertyName("unionid")]
    public required string UnionId { get; set; }

    /// <summary>
    /// 消息卡片素材id，可以通过查询消息卡片列表接口获取。
    /// </summary>
    [JsonPropertyName("media_id")]
    public required string MediaId { get; set; }
}

/// <summary>
/// 删除图文卡片响应
/// </summary>
public class MaterialNewsDeleteResponse
{
    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 获取图文卡片详情请求
/// </summary>
public class MaterialNewsGetRequest
{
    /// <summary>
    /// 服务号的unionid，可以通过查询服务号列表接口获取。
    /// </summary>
    [JsonPropertyName("unionid")]
    public required string UnionId { get; set; }

    /// <summary>
    /// 消息卡片素材id，可以通过查询消息卡片列表接口获取。
    /// </summary>
    [JsonPropertyName("media_id")]
    public required string MediaId { get; set; }
}

/// <summary>
/// 获取图文卡片详情响应
/// </summary>
public class MaterialNewsGetResponse
{
    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 卡片素材id。
    /// </summary>
    [JsonPropertyName("media_id")]
    public string? MediaId { get; set; }

    /// <summary>
    /// 消息卡片更新时间。
    /// </summary>
    [JsonPropertyName("update_time")]
    public decimal? UpdateTime { get; set; }

    /// <summary>
    /// 文章列表。
    /// </summary>
    [JsonPropertyName("articles")]
    public List<MaterialNewsGetResponseArticlesItem> Articles { get; set; } = [];
}

/// <summary>
/// Articles项
/// </summary>
public class MaterialNewsGetResponseArticlesItem
{
    /// <summary>
    /// 文章id。
    /// </summary>
    [JsonPropertyName("article_id")]
    public decimal? ArticleId { get; set; }

    /// <summary>
    /// 文章标题。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 文章内容。
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// 封面图片的素材id。
    /// </summary>
    [JsonPropertyName("thumb_media_id")]
    public string? ThumbMediaId { get; set; }

    /// <summary>
    /// 发布状态：0：未发布1：已发布文章第一次发布后，状态为1，已发布文章支持修改，修改后此状态保持为1，每次修改文章后需要再次发布内容才会生效。
    /// </summary>
    [JsonPropertyName("publish_status")]
    public decimal? PublishStatus { get; set; }

    /// <summary>
    /// 发布时间。文章成功发布之后才有返回值。
    /// </summary>
    [JsonPropertyName("publish_time")]
    public decimal? PublishTime { get; set; }

    /// <summary>
    /// 已读用户数。
    /// </summary>
    [JsonPropertyName("user_view_count")]
    public decimal? UserViewCount { get; set; }

    /// <summary>
    /// 阅读次数。
    /// </summary>
    [JsonPropertyName("total_view_count")]
    public decimal? TotalViewCount { get; set; }

    /// <summary>
    /// 文章创建时间。
    /// </summary>
    [JsonPropertyName("create_time")]
    public decimal? CreateTime { get; set; }

    /// <summary>
    /// 文章更新时间。
    /// </summary>
    [JsonPropertyName("update_time")]
    public decimal? UpdateTime { get; set; }

    /// <summary>
    /// 文章链接。文章成功发布之后才有返回值。
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// 文章摘要。
    /// </summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }
}

/// <summary>
/// 更新图文卡片请求
/// </summary>
public class MaterialNewsUpdateRequest
{
    /// <summary>
    /// 服务号的unionid，可以通过查询服务号列表接口获取。
    /// </summary>
    [JsonPropertyName("unionid")]
    public required string UnionId { get; set; }

    /// <summary>
    /// 消息卡片素材id，可以通过查询消息卡片列表接口获取。
    /// </summary>
    [JsonPropertyName("media_id")]
    public required string MediaId { get; set; }

    /// <summary>
    /// 文章列表。
    /// </summary>
    [JsonPropertyName("articles")]
    public List<MaterialNewsUpdateRequestArticlesItem> Articles { get; set; } = [];
}

/// <summary>
/// Articles项
/// </summary>
public class MaterialNewsUpdateRequestArticlesItem
{
    /// <summary>
    /// 文章id，可以通过查询文章列表接口获取。
    /// </summary>
    [JsonPropertyName("article_id")]
    public decimal? ArticleId { get; set; }
}

/// <summary>
/// 更新图文卡片响应
/// </summary>
public class MaterialNewsUpdateResponse
{
    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 查询图文卡片列表请求
/// </summary>
public class MaterialNewsListRequest
{
    /// <summary>
    /// 服务号的unionid，可以通过查询服务号详情接口获取。
    /// </summary>
    [JsonPropertyName("unionid")]
    public required string UnionId { get; set; }

    /// <summary>
    /// 页码，从1开始。
    /// </summary>
    [JsonPropertyName("page_start")]
    public long? PageStart { get; set; }

    /// <summary>
    /// 每页条数。
    /// </summary>
    [JsonPropertyName("page_size")]
    public long? PageSize { get; set; }
}

/// <summary>
/// 查询图文卡片列表响应
/// </summary>
public class MaterialNewsListResponse
{
    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }

    /// <summary>
    /// 总记录数。
    /// </summary>
    [JsonPropertyName("total_count")]
    public decimal? TotalCount { get; set; }

    /// <summary>
    /// 当前返回记录数。
    /// </summary>
    [JsonPropertyName("item_count")]
    public decimal? ItemCount { get; set; }

    /// <summary>
    /// 卡片列表。
    /// </summary>
    [JsonPropertyName("items")]
    public List<MaterialNewsListResponseItemsItem> Items { get; set; } = [];
}

/// <summary>
/// Items项
/// </summary>
public class MaterialNewsListResponseItemsItem
{
    /// <summary>
    /// 文章列表。
    /// </summary>
    [JsonPropertyName("articles")]
    public List<MaterialNewsListResponseItemsItemArticlesItem> Articles { get; set; } = [];

    /// <summary>
    /// 消息卡片更新时间。
    /// </summary>
    [JsonPropertyName("update_time")]
    public decimal? UpdateTime { get; set; }

    /// <summary>
    /// 消息卡片的素材id。
    /// </summary>
    [JsonPropertyName("media_id")]
    public string? MediaId { get; set; }
}

/// <summary>
/// Articles项
/// </summary>
public class MaterialNewsListResponseItemsItemArticlesItem
{
    /// <summary>
    /// 文章id。
    /// </summary>
    [JsonPropertyName("article_id")]
    public decimal? ArticleId { get; set; }

    /// <summary>
    /// 文章标题。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 封面图片的素材id。
    /// </summary>
    [JsonPropertyName("thumb_media_id")]
    public string? ThumbMediaId { get; set; }

    /// <summary>
    /// 发布状态：0：未发布1：已发布文章第一次发布后，状态置为1，已发布文章支持修改，修改后此状态保持为1，每次修改文章后需要再次发布内容才会生效。
    /// </summary>
    [JsonPropertyName("publish_status")]
    public decimal? PublishStatus { get; set; }

    /// <summary>
    /// 发布时间。文章成功发布之后才有返回值。
    /// </summary>
    [JsonPropertyName("publish_time")]
    public decimal? PublishTime { get; set; }

    /// <summary>
    /// 已读用户数。
    /// </summary>
    [JsonPropertyName("user_view_count")]
    public decimal? UserViewCount { get; set; }

    /// <summary>
    /// 阅读次数。
    /// </summary>
    [JsonPropertyName("total_view_count")]
    public decimal? TotalViewCount { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    [JsonPropertyName("create_time")]
    public decimal? CreateTime { get; set; }

    /// <summary>
    /// 修改时间。
    /// </summary>
    [JsonPropertyName("update_time")]
    public decimal? UpdateTime { get; set; }

    /// <summary>
    /// 文章链接。文章成功发布之后才有返回值。
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// 文章内容。
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// 文章摘要。
    /// </summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }
}

/// <summary>
/// 消息撤回请求
/// </summary>
public class MessageMassRecallRequest
{
    /// <summary>
    /// 服务号的unionid，可以通过查询服务号详情接口获取。
    /// </summary>
    [JsonPropertyName("unionid")]
    public required string UnionId { get; set; }

    /// <summary>
    /// 消息发送任务id，可以通过消息群发接口获取。
    /// </summary>
    [JsonPropertyName("task_id")]
    public required string TaskId { get; set; }
}

/// <summary>
/// 消息撤回响应
/// </summary>
public class MessageMassRecallResponse
{
    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 消息群发请求
/// </summary>
public class MessageMassSendRequest
{
    /// <summary>
    /// 服务号的unionid，可以通过查询服务号列表接口获取。
    /// </summary>
    [JsonPropertyName("unionid")]
    public required string UnionId { get; set; }

    /// <summary>
    /// 消息卡片素材id。当参数msg_type为news_card、image类型时，该参数为必填项。
    /// </summary>
    [JsonPropertyName("media_id")]
    public string? MediaId { get; set; }

    /// <summary>
    /// 是否群发给所有订阅者：true：是false：否
    /// </summary>
    [JsonPropertyName("is_to_all")]
    public bool IsToAll { get; set; }

    /// <summary>
    /// 消息类型：text：文本类型，文本内容填在text_content字段中news_card：消息卡片，可以通过查询消息卡片列表接口获取media_idimage：图片类型，可以通过上传媒体文件接口获取media_idmarkdown：markdown消息，需要设置msg_body中markdown对象的相关参数action_card：action_ca...
    /// </summary>
    [JsonPropertyName("msg_type")]
    public required string MsgType { get; set; }

    /// <summary>
    /// 文本内容，当msg_type为text时有效。
    /// </summary>
    [JsonPropertyName("text_content")]
    public string? TextContent { get; set; }

    /// <summary>
    /// 调用时填写随机生成的UUID，防止消息重复发送。
    /// </summary>
    [JsonPropertyName("uuid")]
    public required string Uuid { get; set; }

    /// <summary>
    /// 接收者的用户userid列表，列表最大长度1000。
    /// </summary>
    [JsonPropertyName("userid_list")]
    public string? UserIdList { get; set; }

    /// <summary>
    /// 接收者的部门id列表，接收者是部门id下(包括子部门下)的所有用户，列表最大长度1000。
    /// </summary>
    [JsonPropertyName("dep_id_list")]
    public List<decimal> DepIdList { get; set; } = [];

    /// <summary>
    /// 是否预览推送，预览推送只会发给单个用户，并且内容链接24小时后可能会失效。
    /// </summary>
    [JsonPropertyName("is_preview")]
    public bool? IsPreview { get; set; }

    /// <summary>
    /// 消息体。当msg_type设置为markdown时，必须传入markdown对象的相关参数；当msg_type设置为action_card时，必须传入action_card对象的相关参数。
    /// </summary>
    [JsonPropertyName("msg_body")]
    public MessageMassSendRequestMsgBody MsgBody { get; set; }
}

/// <summary>
/// 消息体。当msg_type设置为markdown时，必须传入markdown对象的相关参数；当msg_type设置为action_card时，必须传入action_card对象的相关参数。
/// </summary>
public class MessageMassSendRequestMsgBody
{
    /// <summary>
    /// 语音消息。
    /// </summary>
    [JsonPropertyName("voice")]
    public MessageMassSendRequestMsgBodyVoice Voice { get; set; }

    /// <summary>
    /// oa消息。
    /// </summary>
    [JsonPropertyName("oa")]
    public MessageMassSendRequestMsgBodyOa Oa { get; set; }

    /// <summary>
    /// 文件消息。
    /// </summary>
    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary>
    /// 链接消息。
    /// </summary>
    [JsonPropertyName("link")]
    public MessageMassSendRequestMsgBodyLink Link { get; set; }

    /// <summary>
    /// markdown消息。
    /// </summary>
    [JsonPropertyName("markdown")]
    public MessageMassSendRequestMsgBodyMarkdown Markdown { get; set; }

    /// <summary>
    /// action_card卡片消息。
    /// </summary>
    [JsonPropertyName("action_card")]
    public MessageMassSendRequestMsgBodyActionCard ActionCard { get; set; }
}

/// <summary>
/// 语音消息。
/// </summary>
public class MessageMassSendRequestMsgBodyVoice
{
    /// <summary>
    /// 正整数，小于60，表示音频时长。
    /// </summary>
    [JsonPropertyName("duration")]
    public decimal? Duration { get; set; }

    /// <summary>
    /// 媒体文件id，播放时长小于60s，文件不大于2MB，并且文件为AMR格式。
    /// </summary>
    [JsonPropertyName("media_id")]
    public string? MediaId { get; set; }
}

/// <summary>
/// oa消息。
/// </summary>
public class MessageMassSendRequestMsgBodyOa
{
    /// <summary>
    /// 消息头部内容。
    /// </summary>
    [JsonPropertyName("head")]
    public MessageMassSendRequestMsgBodyOaHead Head { get; set; }

    /// <summary>
    /// 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接。
    /// </summary>
    [JsonPropertyName("message_url")]
    public string? MessageUrl { get; set; }

    /// <summary>
    /// 消息体。
    /// </summary>
    [JsonPropertyName("body")]
    public MessageMassSendRequestMsgBodyOaBody Body { get; set; }

    /// <summary>
    /// PC端点击消息时跳转到的地址。
    /// </summary>
    [JsonPropertyName("pc_message_url")]
    public string? PcMessageUrl { get; set; }
}

/// <summary>
/// 链接消息。
/// </summary>
public class MessageMassSendRequestMsgBodyLink
{
    /// <summary>
    /// 图片地址。
    /// </summary>
    [JsonPropertyName("pic_url")]
    public string? PicUrl { get; set; }

    /// <summary>
    /// 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接。
    /// </summary>
    [JsonPropertyName("message_url")]
    public string? MessageUrl { get; set; }

    /// <summary>
    /// 消息描述，建议500字符以内。
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>
    /// 消息标题，建议100字符以内。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// markdown消息。
/// </summary>
public class MessageMassSendRequestMsgBodyMarkdown
{
    /// <summary>
    /// markdown格式的消息，建议5000字符以内。当msg_type设置为markdown时，该字段为必填项。
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>
    /// 首屏会话透出的展示内容。当msg_type设置为markdown时，该字段为必填项。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// action_card卡片消息。
/// </summary>
public class MessageMassSendRequestMsgBodyActionCard
{
    /// <summary>
    /// 使用独立跳转ActionCard样式时的按钮排列方式：0：竖直排列1：横向排列必须与button_list同时设置。
    /// </summary>
    [JsonPropertyName("btn_orientation")]
    public string? BtnOrientation { get; set; }

    /// <summary>
    /// 使用整体跳转ActionCard样式时的标题，最长20个字符。必须与single_url同时设置。
    /// </summary>
    [JsonPropertyName("single_title")]
    public string? SingleTitle { get; set; }

    /// <summary>
    /// 消息内容，支持markdown，语法请参考markdown消息。建议1000个字符以内。
    /// </summary>
    [JsonPropertyName("markdown")]
    public string? Markdown { get; set; }

    /// <summary>
    /// 使用独立跳转ActionCard样式时的按钮列表。必须与btn_orientation同时设置。
    /// </summary>
    [JsonPropertyName("button_list")]
    public List<MessageMassSendRequestMsgBodyActionCardButtonListItem> ButtonList { get; set; } = [];

    /// <summary>
    /// 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接，最长500个字符。
    /// </summary>
    [JsonPropertyName("single_url")]
    public string? SingleUrl { get; set; }

    /// <summary>
    /// 透出到会话列表和通知的文案，最长64个字符。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// 消息头部内容。
/// </summary>
public class MessageMassSendRequestMsgBodyOaHead
{
    /// <summary>
    /// 消息头部的背景颜色，长度限制为8个英文字符，其中前2位表示透明度，后6位表示颜色值，不能添加0x。
    /// </summary>
    [JsonPropertyName("bgcolor")]
    public string? Bgcolor { get; set; }

    /// <summary>
    /// 消息的头部标题，长度限制为最多10个字符。向普通会话发送时有效，向企业会话发送时会被替换为微应用的名字。
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>
/// 消息体。
/// </summary>
public class MessageMassSendRequestMsgBodyOaBody
{
    /// <summary>
    /// 消息体中的图片，支持图片资源@mediaId，可以通过上传媒体文件接口获取。
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>
    /// 消息体的表单，最多显示6个，超过会被隐藏。
    /// </summary>
    [JsonPropertyName("form")]
    public List<MessageMassSendRequestMsgBodyOaBodyFormItem> Form { get; set; } = [];

    /// <summary>
    /// 自定义的作者名字。
    /// </summary>
    [JsonPropertyName("author")]
    public string? Author { get; set; }

    /// <summary>
    /// 单行富文本信息。
    /// </summary>
    [JsonPropertyName("rich")]
    public MessageMassSendRequestMsgBodyOaBodyRich Rich { get; set; }

    /// <summary>
    /// 消息体的标题，建议50个字符以内。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 自定义的附件数目，此数字仅供显示，钉钉不作验证。
    /// </summary>
    [JsonPropertyName("file_count")]
    public decimal? FileCount { get; set; }

    /// <summary>
    /// 消息体的内容，最多显示3行。
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }
}

/// <summary>
/// ButtonList项
/// </summary>
public class MessageMassSendRequestMsgBodyActionCardButtonListItem
{
    /// <summary>
    /// 使用独立跳转ActionCard样式时的按钮的标题，最长20个字符。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接，最长500个字符。
    /// </summary>
    [JsonPropertyName("action_url")]
    public string? ActionUrl { get; set; }
}

/// <summary>
/// Form项
/// </summary>
public class MessageMassSendRequestMsgBodyOaBodyFormItem
{
    /// <summary>
    /// 消息体的关键字。
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// 消息体的关键字对应的值。
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// 单行富文本信息。
/// </summary>
public class MessageMassSendRequestMsgBodyOaBodyRich
{
    /// <summary>
    /// 单行富文本信息的单位。
    /// </summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>
    /// 单行富文本信息的数目。
    /// </summary>
    [JsonPropertyName("num")]
    public string? Num { get; set; }
}

/// <summary>
/// 消息群发响应
/// </summary>
public class MessageMassSendResponse
{
    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 推送任务id。
    /// </summary>
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// 服务号菜单更新请求
/// </summary>
public class ServiceAccountMenuUpdateRequest
{
    /// <summary>
    /// 服务号的unionid，可以通过查询服务号列表接口获取。
    /// </summary>
    [JsonPropertyName("unionid")]
    public required string UnionId { get; set; }

    /// <summary>
    /// 菜单。
    /// </summary>
    [JsonPropertyName("menu")]
    public ServiceAccountMenuUpdateRequestMenu Menu { get; set; }
}

/// <summary>
/// 菜单。
/// </summary>
public class ServiceAccountMenuUpdateRequestMenu
{
    /// <summary>
    /// 菜单按钮列表。
    /// </summary>
    [JsonPropertyName("button")]
    public List<ServiceAccountMenuUpdateRequestMenuButtonItem> Button { get; set; } = [];

    /// <summary>
    /// 是否允许用户输入：true：允许false：不允许
    /// </summary>
    [JsonPropertyName("enable_input")]
    public bool EnableInput { get; set; }

    /// <summary>
    /// 状态：0：正常1：停用
    /// </summary>
    [JsonPropertyName("status")]
    public decimal Status { get; set; }
}

/// <summary>
/// Button项
/// </summary>
public class ServiceAccountMenuUpdateRequestMenuButtonItem
{
    /// <summary>
    /// 菜单名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 菜单类型，如果是 一级菜单则不填，代表这是一个父菜单：click：拉取自定义消息view：跳转链接media_id：拉取站内消息，包括消息卡片和图片配合media_id字段使用，填写卡片id或图片id。view_article：跳转站内文章配合media_id字段使用，填写为相应的文章id。
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// 菜单绑定的key值，用于点击菜单拉取自定义消息的场景。
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// 菜单绑定的URL，用于链接跳转。
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// 素材id，用于拉取站内消息的场景。如果菜单类型为media_id或view_article类型，则该字符为必填项。
    /// </summary>
    [JsonPropertyName("media_id")]
    public string? MediaId { get; set; }

    /// <summary>
    /// 子菜单按钮列表。
    /// </summary>
    [JsonPropertyName("sub_button")]
    public List<ServiceAccountMenuUpdateRequestMenuButtonItemSubButtonItem> SubButton { get; set; } = [];
}

/// <summary>
/// SubButton项
/// </summary>
public class ServiceAccountMenuUpdateRequestMenuButtonItemSubButtonItem
{
    /// <summary>
    /// 按钮名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 按钮类型：click：拉取自定义消息view：跳转链接media_id：拉取站内消息，包括消息卡片和图片配合media_id字段使用，填写卡片id或图片id。view_article：跳转站内文章配合media_id字段使用，填写为相应的文章id。其中media_id类型会在内部转化为click类型，view_article类型会在内部转化为view类型。
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// 子菜单绑定的key值。
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// 子菜单绑定的URL。
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// 子菜单素材id。如果子菜单类型为media_id或view_article类型，则该参数为必填项。
    /// </summary>
    [JsonPropertyName("media_id")]
    public string? MediaId { get; set; }
}

/// <summary>
/// 服务号菜单更新响应
/// </summary>
public class ServiceAccountMenuUpdateResponse
{
    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }
}

/// <summary>
/// 查询服务号菜单请求
/// </summary>
public class ServiceAccountMenuGetRequest
{
    /// <summary>
    /// 服务号的unionid，可以通过查询服务号列表接口获取。
    /// </summary>
    [JsonPropertyName("unionid")]
    public required string UnionId { get; set; }
}

/// <summary>
/// 查询服务号菜单响应
/// </summary>
public class ServiceAccountMenuGetResponse
{
    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }

    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public decimal? Errcode { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }

    /// <summary>
    /// 菜单。
    /// </summary>
    [JsonPropertyName("menu")]
    public Dictionary<string, object?> Menu { get; set; } = [];
}
