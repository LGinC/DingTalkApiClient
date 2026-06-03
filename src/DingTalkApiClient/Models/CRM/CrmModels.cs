namespace DingTalkApiClient.Models.CRM;

/// <summary>
/// CRM 动态字段数据。
/// </summary>
public class CrmDynamicData : Dictionary<string, object?>
{
}

/// <summary>
/// CRM 对象元数据。
/// </summary>
public class CrmObjectMetaResponse
{
    /// <summary>
    /// 对象名称。
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 是否自定义对象。
    /// </summary>
    public bool Customized { get; set; }

    /// <summary>
    /// 字段列表。
    /// </summary>
    public List<CrmObjectField> Fields { get; set; } = [];

    /// <summary>
    /// 表单状态，PUBLISHED 表示已发布，INVALID 表示已停用。
    /// </summary>
    public required string Status { get; set; }

    /// <summary>
    /// 表单 code。
    /// </summary>
    public required string Code { get; set; }
}

/// <summary>
/// CRM 对象字段。
/// </summary>
public class CrmObjectField
{
    /// <summary>
    /// 字段名称。
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 是否自定义字段。
    /// </summary>
    public bool Customized { get; set; }

    /// <summary>
    /// 字段展示名。
    /// </summary>
    public string? Label { get; set; }

    /// <summary>
    /// 字段类型。
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// 是否可空。
    /// </summary>
    public bool? Nillable { get; set; }

    /// <summary>
    /// 日期格式。
    /// </summary>
    public string? Format { get; set; }

    /// <summary>
    /// 日期单位或金额单位。
    /// </summary>
    public string? Unit { get; set; }

    /// <summary>
    /// 选项列表。
    /// </summary>
    public List<CrmSelectOption> SelectOptions { get; set; } = [];

    /// <summary>
    /// 是否引用关联。
    /// </summary>
    public bool? Quote { get; set; }

    /// <summary>
    /// 关联对象名称。
    /// </summary>
    public string? ReferenceTo { get; set; }

    /// <summary>
    /// 引用的关联对象字段列表。
    /// </summary>
    public List<CrmReferenceField> ReferenceFields { get; set; } = [];

    /// <summary>
    /// 对 MasterDetail 类型有效的汇总字段。
    /// </summary>
    public List<CrmRollUpSummaryField> RollUpSummaryFields { get; set; } = [];
}

/// <summary>
/// CRM 字段选项。
/// </summary>
public class CrmSelectOption
{
    /// <summary>
    /// 选项 key。
    /// </summary>
    public string? Key { get; set; }

    /// <summary>
    /// 选项值。
    /// </summary>
    public string? Value { get; set; }
}

/// <summary>
/// CRM 引用字段。
/// </summary>
public class CrmReferenceField
{
    /// <summary>
    /// 引用字段显示名。
    /// </summary>
    public string? Label { get; set; }

    /// <summary>
    /// 引用字段类型。
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// 引用字段是否可空。
    /// </summary>
    public bool? Nillable { get; set; }

    /// <summary>
    /// 引用字段单位。
    /// </summary>
    public string? Unit { get; set; }

    /// <summary>
    /// 引用字段格式。
    /// </summary>
    public string? Format { get; set; }

    /// <summary>
    /// 引用字段选项列表。
    /// </summary>
    public List<CrmSelectOption> SelectOptions { get; set; } = [];

    /// <summary>
    /// 引用字段名称。
    /// </summary>
    public string? Name { get; set; }
}

/// <summary>
/// CRM 汇总字段。
/// </summary>
public class CrmRollUpSummaryField
{
    /// <summary>
    /// 需要汇总的明细内字段名。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 汇总方法。
    /// </summary>
    public string? Aggregator { get; set; }
}

/// <summary>
/// CRM 数据权限。
/// </summary>
public class CrmPermission
{
    /// <summary>
    /// 负责人的用户 userid。
    /// </summary>
    public List<string> OwnerStaffIds { get; set; } = [];

    /// <summary>
    /// 协同人的用户 userid。
    /// </summary>
    public List<string> ParticipantStaffIds { get; set; } = [];
}

/// <summary>
/// 创建个人或企业客户数据请求。
/// </summary>
public class CrmPersonalCustomerCreateRequest
{
    /// <summary>
    /// 记录创建人的用户 userid。
    /// </summary>
    public string? CreatorUserId { get; set; }

    /// <summary>
    /// 记录创建人的昵称。
    /// </summary>
    public string? CreatorNick { get; set; }

    /// <summary>
    /// 数据内容。
    /// </summary>
    public CrmDynamicData Data { get; set; } = [];

    /// <summary>
    /// 扩展数据内容。
    /// </summary>
    public CrmDynamicData ExtendData { get; set; } = [];

    /// <summary>
    /// 权限。
    /// </summary>
    public CrmPermission? Permission { get; set; }

    /// <summary>
    /// 是否跳过重复校验。
    /// </summary>
    public bool? SkipDuplicateCheck { get; set; }

    /// <summary>
    /// 对公海客户的领取或分配动作。
    /// </summary>
    public string? Action { get; set; }

    /// <summary>
    /// 关系类型，crm_customer 表示企业客户，crm_customer_personal 表示个人客户。
    /// </summary>
    public string? RelationType { get; set; }
}

/// <summary>
/// 更新个人或企业客户数据请求。
/// </summary>
public class CrmPersonalCustomerUpdateRequest : CrmPersonalCustomerCreateRequest
{
    /// <summary>
    /// 客户数据 ID。
    /// </summary>
    public required string InstanceId { get; set; }

    /// <summary>
    /// 记录修改人的用户 userid。
    /// </summary>
    public string? ModifierUserId { get; set; }

    /// <summary>
    /// 记录修改人的昵称。
    /// </summary>
    public string? ModifierNick { get; set; }
}

/// <summary>
/// CRM 实例 ID 响应。
/// </summary>
public class CrmInstanceIdResponse
{
    /// <summary>
    /// 数据 ID。
    /// </summary>
    public string? InstanceId { get; set; }
}

/// <summary>
/// CRM 客户查询响应。
/// </summary>
public class CrmCustomerQueryResponse
{
    /// <summary>
    /// 数据列表。
    /// </summary>
    public List<CrmCustomerInstance> Values { get; set; } = [];

    /// <summary>
    /// 是否还有更多数据。
    /// </summary>
    public bool HasMore { get; set; }

    /// <summary>
    /// 下一页游标。
    /// </summary>
    public string? NextToken { get; set; }

    /// <summary>
    /// 每页最大结果数。
    /// </summary>
    public int? MaxResults { get; set; }

    /// <summary>
    /// 总数量。
    /// </summary>
    public long? TotalCount { get; set; }
}

/// <summary>
/// CRM 客户实例。
/// </summary>
public class CrmCustomerInstance
{
    /// <summary>
    /// 数据 ID。
    /// </summary>
    public string? InstanceId { get; set; }

    /// <summary>
    /// 数据内容。
    /// </summary>
    public CrmDynamicData Data { get; set; } = [];

    /// <summary>
    /// 扩展数据内容。
    /// </summary>
    public CrmDynamicData ExtendData { get; set; } = [];
}

/// <summary>
/// CRM 模型字段值。
/// </summary>
public class CrmBizData
{
    /// <summary>
    /// 模型字段 key，取自对象元数据中的字段 name。
    /// </summary>
    public required string Key { get; set; }

    /// <summary>
    /// 模型字段 value。
    /// </summary>
    public required string Value { get; set; }

    /// <summary>
    /// 模型字段 extendValue。
    /// </summary>
    public string? ExtendValue { get; set; }
}

/// <summary>
/// CRM 负责人和协同人信息。
/// </summary>
public class CrmRelationPermission
{
    /// <summary>
    /// 负责人 userId 列表。
    /// </summary>
    public List<string> PrincipalUserIds { get; set; } = [];

    /// <summary>
    /// 协同人 userId 列表。
    /// </summary>
    public List<string> ParticipantUserIds { get; set; } = [];
}

/// <summary>
/// 批量新增客户关系项。
/// </summary>
public class CrmCreateRelationData
{
    /// <summary>
    /// 模型数据列表，最大值 256。
    /// </summary>
    public List<CrmBizData> BizDataList { get; set; } = [];

    /// <summary>
    /// 扩展业务字段，暂不支持使用。
    /// </summary>
    public CrmDynamicData BizExtMap { get; set; } = [];

    /// <summary>
    /// 负责人和协同人信息。
    /// </summary>
    public CrmRelationPermission? RelationPermissionDTO { get; set; }
}

/// <summary>
/// 批量更新客户关系项。
/// </summary>
public class CrmUpdateRelationData
{
    /// <summary>
    /// 客户数据 ID。
    /// </summary>
    public required string RelationId { get; set; }

    /// <summary>
    /// 模型数据列表，最大值 256。
    /// </summary>
    public List<CrmBizData> BizDataList { get; set; } = [];

    /// <summary>
    /// 扩展业务字段，暂不支持使用。
    /// </summary>
    public CrmDynamicData BizExtMap { get; set; } = [];
}

/// <summary>
/// 批量新增个人或企业客户数据请求。
/// </summary>
public class CrmBatchCreateRelationDatasRequest
{
    /// <summary>
    /// 客户类型。
    /// </summary>
    public required string RelationType { get; set; }

    /// <summary>
    /// 操作人 userId。
    /// </summary>
    public required string OperatorUserId { get; set; }

    /// <summary>
    /// 是否跳过重复校验。
    /// </summary>
    public bool? SkipDuplicateCheck { get; set; }

    /// <summary>
    /// 新增客户关系列表，最大值 10。
    /// </summary>
    public List<CrmCreateRelationData> RelationList { get; set; } = [];
}

/// <summary>
/// 批量更新个人或企业客户数据请求。
/// </summary>
public class CrmBatchUpdateRelationDatasRequest
{
    /// <summary>
    /// 客户类型。
    /// </summary>
    public required string RelationType { get; set; }

    /// <summary>
    /// 操作人 userId。
    /// </summary>
    public required string OperatorUserId { get; set; }

    /// <summary>
    /// 更新的客户数据列表，最大值 10。
    /// </summary>
    public List<CrmUpdateRelationData> RelationList { get; set; } = [];
}

/// <summary>
/// CRM 批量保存响应。
/// </summary>
public class CrmBatchRelationResponse
{
    /// <summary>
    /// 批量保存结果列表，返回顺序与请求数据一致。
    /// </summary>
    public List<CrmBatchRelationResult> Results { get; set; } = [];
}

/// <summary>
/// CRM 批量保存结果。
/// </summary>
public class CrmBatchRelationResult
{
    /// <summary>
    /// 数据是否保存成功。
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 错误码。
    /// </summary>
    public string? ErrorCode { get; set; }

    /// <summary>
    /// 错误信息。
    /// </summary>
    public string? ErrorMsg { get; set; }

    /// <summary>
    /// 保存成功的客户 ID。
    /// </summary>
    public string? RelationId { get; set; }

    /// <summary>
    /// 因查重失败时返回的重复客户 ID 列表。
    /// </summary>
    public List<string> DuplicatedRelationIds { get; set; } = [];
}

/// <summary>
/// 批量获取个人或企业客户响应。
/// </summary>
public class CrmBatchGetPersonalCustomersResponse
{
    /// <summary>
    /// 批量客户数据。
    /// </summary>
    public List<CrmCustomerInstance> Result { get; set; } = [];
}

/// <summary>
/// 获取全量个人或企业客户数据请求。
/// </summary>
public class CrmCustomerInstancesRequest
{
    /// <summary>
    /// 操作人 userId。
    /// </summary>
    public required string OperatorUserId { get; set; }

    /// <summary>
    /// 每页最大结果数。
    /// </summary>
    public int? MaxResults { get; set; }

    /// <summary>
    /// 下一页游标。
    /// </summary>
    public string? NextToken { get; set; }

    /// <summary>
    /// 对象类型。
    /// </summary>
    public string? ObjectType { get; set; }
}

/// <summary>
/// 获取全量个人或企业客户数据响应。
/// </summary>
public class CrmCustomerInstancesResponse
{
    /// <summary>
    /// 分页客户数据。
    /// </summary>
    public CrmCustomerQueryResponse? Result { get; set; }
}

/// <summary>
/// CRM 查重字段响应。
/// </summary>
public class CrmRelationUkSettingsResponse
{
    /// <summary>
    /// 查重字段列表。
    /// </summary>
    public List<CrmRelationUkSetting> Result { get; set; } = [];
}

/// <summary>
/// CRM 查重字段。
/// </summary>
public class CrmRelationUkSetting
{
    /// <summary>
    /// 字段名称。
    /// </summary>
    public string? FieldName { get; set; }

    /// <summary>
    /// 字段展示名。
    /// </summary>
    public string? FieldLabel { get; set; }
}

/// <summary>
/// 客户管理全局信息响应。
/// </summary>
public class CrmGlobalInfosResponse
{
    /// <summary>
    /// 全局信息。
    /// </summary>
    public CrmGlobalInfo? Result { get; set; }
}

/// <summary>
/// 客户管理全局信息。
/// </summary>
public class CrmGlobalInfo
{
    /// <summary>
    /// 是否开通 CRM。
    /// </summary>
    public bool? Opened { get; set; }

    /// <summary>
    /// 默认客户类型。
    /// </summary>
    public string? DefaultRelationType { get; set; }
}

/// <summary>
/// 根据目标查询客户关系响应。
/// </summary>
public class CrmRelationsByTargetResponse
{
    /// <summary>
    /// 客户关系列表。
    /// </summary>
    public List<CrmRelationTarget> Relations { get; set; } = [];
}

/// <summary>
/// 客户关系目标数据。
/// </summary>
public class CrmRelationTarget
{
    /// <summary>
    /// 客户关系 ID。
    /// </summary>
    public string? RelationId { get; set; }

    /// <summary>
    /// 目标 ID。
    /// </summary>
    public string? TargetId { get; set; }

    /// <summary>
    /// 关系类型。
    /// </summary>
    public string? RelationType { get; set; }
}

/// <summary>
/// 批量联系人请求。
/// </summary>
public class CrmBatchContactRequest
{
    /// <summary>
    /// 操作人 userId。
    /// </summary>
    public required string OperatorUserId { get; set; }

    /// <summary>
    /// 联系人列表。
    /// </summary>
    public List<CrmCreateRelationData> RelationList { get; set; } = [];
}

/// <summary>
/// 批量跟进记录请求。
/// </summary>
public class CrmBatchFollowRecordRequest
{
    /// <summary>
    /// 操作人 userId。
    /// </summary>
    public required string OperatorUserId { get; set; }

    /// <summary>
    /// 跟进记录列表。
    /// </summary>
    public List<CrmCustomerInstance> InstanceList { get; set; } = [];
}

/// <summary>
/// 批量删除跟进记录请求。
/// </summary>
public class CrmBatchRemoveFollowRecordsRequest
{
    /// <summary>
    /// 操作人 userId。
    /// </summary>
    public required string OperatorUserId { get; set; }

    /// <summary>
    /// 跟进记录 ID 列表。
    /// </summary>
    public List<string> InstanceIds { get; set; } = [];
}

/// <summary>
/// 批量删除响应。
/// </summary>
public class CrmBatchRemoveResponse
{
    /// <summary>
    /// 删除结果列表。
    /// </summary>
    public List<CrmBatchRemoveResult> Results { get; set; } = [];
}

/// <summary>
/// 批量删除结果。
/// </summary>
public class CrmBatchRemoveResult
{
    /// <summary>
    /// 调用是否成功。
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 删除的数据 ID。
    /// </summary>
    public string? InstanceId { get; set; }

    /// <summary>
    /// 错误码。
    /// </summary>
    public string? ErrorCode { get; set; }

    /// <summary>
    /// 错误信息。
    /// </summary>
    public string? ErrorMsg { get; set; }
}

/// <summary>
/// 创建客户群请求。
/// </summary>
public class CrmCreateGroupRequest
{
    /// <summary>
    /// 客户群名称。
    /// </summary>
    public required string GroupName { get; set; }

    /// <summary>
    /// 群主 userId。
    /// </summary>
    public required string OwnerUserId { get; set; }

    /// <summary>
    /// 群成员 userId 列表。
    /// </summary>
    public List<string> MemberUserIds { get; set; } = [];

    /// <summary>
    /// 关系类型。
    /// </summary>
    public string? RelationType { get; set; }
}

/// <summary>
/// 创建客户群响应。
/// </summary>
public class CrmCreateGroupResponse
{
    /// <summary>
    /// 开放会话 ID。
    /// </summary>
    public string? OpenConversationId { get; set; }
}

/// <summary>
/// 客户群列表响应。
/// </summary>
public class CrmGroupChatListResponse
{
    /// <summary>
    /// 客户群列表。
    /// </summary>
    public List<CrmGroupChatDetail> ResultList { get; set; } = [];

    /// <summary>
    /// 是否还有更多数据。
    /// </summary>
    public bool HasMore { get; set; }

    /// <summary>
    /// 下一页游标。
    /// </summary>
    public string? NextToken { get; set; }

    /// <summary>
    /// 总数量。
    /// </summary>
    public long? TotalCount { get; set; }
}

/// <summary>
/// 客户群详情。
/// </summary>
public class CrmGroupChatDetail
{
    /// <summary>
    /// 开放会话 ID。
    /// </summary>
    public string? OpenConversationId { get; set; }

    /// <summary>
    /// 开放群组 ID。
    /// </summary>
    public string? OpenGroupSetId { get; set; }

    /// <summary>
    /// 群主 userId。
    /// </summary>
    public string? OwnerUserId { get; set; }

    /// <summary>
    /// 群主名称。
    /// </summary>
    public string? OwnerUserName { get; set; }

    /// <summary>
    /// 群名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 成员数量。
    /// </summary>
    public int? MemberCount { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    public long? GmtCreate { get; set; }

    /// <summary>
    /// 群头像地址。
    /// </summary>
    public string? IconUrl { get; set; }
}

/// <summary>
/// 批量查询客户群请求。
/// </summary>
public class CrmBatchGroupChatRequest
{
    /// <summary>
    /// 开放会话 ID 列表。
    /// </summary>
    public List<string> OpenConversationIds { get; set; } = [];
}

/// <summary>
/// 批量查询客户群响应。
/// </summary>
public class CrmBatchGroupChatResponse
{
    /// <summary>
    /// 客户群详情列表。
    /// </summary>
    public List<CrmGroupChatDetail> Result { get; set; } = [];
}

/// <summary>
/// 创建客户群组请求。
/// </summary>
public class CrmCreateGroupSetRequest
{
    /// <summary>
    /// 群组名称。
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 群主 userId。
    /// </summary>
    public required string OwnerUserId { get; set; }

    /// <summary>
    /// 创建人 userId。
    /// </summary>
    public string? CreatorUserId { get; set; }

    /// <summary>
    /// 模板 ID。
    /// </summary>
    public string? TemplateId { get; set; }

    /// <summary>
    /// 管理员 userId 列表。
    /// </summary>
    public List<string> ManagerUserIds { get; set; } = [];

    /// <summary>
    /// 群公告。
    /// </summary>
    public string? Notice { get; set; }

    /// <summary>
    /// 关系类型。
    /// </summary>
    public string? RelationType { get; set; }
}

/// <summary>
/// 更新客户群组请求。
/// </summary>
public class CrmUpdateGroupSetRequest
{
    /// <summary>
    /// 开放群组 ID。
    /// </summary>
    public required string OpenGroupSetId { get; set; }

    /// <summary>
    /// 群组名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 群主 userId。
    /// </summary>
    public string? OwnerUserId { get; set; }

    /// <summary>
    /// 管理员 userId 列表。
    /// </summary>
    public List<string> ManagerUserIds { get; set; } = [];

    /// <summary>
    /// 群公告。
    /// </summary>
    public string? Notice { get; set; }

    /// <summary>
    /// 模板 ID。
    /// </summary>
    public string? TemplateId { get; set; }

    /// <summary>
    /// 欢迎语。
    /// </summary>
    public string? Welcome { get; set; }
}

/// <summary>
/// 客户群组详情。
/// </summary>
public class CrmGroupSetDetail
{
    /// <summary>
    /// 群组名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 开放群组 ID。
    /// </summary>
    public string? OpenGroupSetId { get; set; }

    /// <summary>
    /// 关系类型。
    /// </summary>
    public string? RelationType { get; set; }

    /// <summary>
    /// 成员配额。
    /// </summary>
    public int? MemberQuota { get; set; }

    /// <summary>
    /// 成员数量。
    /// </summary>
    public int? MemberCount { get; set; }

    /// <summary>
    /// 模板 ID。
    /// </summary>
    public string? TemplateId { get; set; }

    /// <summary>
    /// 群主 userId。
    /// </summary>
    public string? OwnerUserId { get; set; }

    /// <summary>
    /// 管理员 userId 列表。
    /// </summary>
    public List<string> ManagerUserIds { get; set; } = [];

    /// <summary>
    /// 群公告。
    /// </summary>
    public string? Notice { get; set; }

    /// <summary>
    /// 公告是否置顶。
    /// </summary>
    public bool? NoticeToped { get; set; }

    /// <summary>
    /// 群主信息。
    /// </summary>
    public CrmGroupSetUser? Owner { get; set; }

    /// <summary>
    /// 管理员信息列表。
    /// </summary>
    public List<CrmGroupSetUser> Manager { get; set; } = [];

    /// <summary>
    /// 最后一个开放会话 ID。
    /// </summary>
    public string? LastOpenConversationId { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    public long? GmtCreate { get; set; }

    /// <summary>
    /// 修改时间。
    /// </summary>
    public long? GmtModified { get; set; }

    /// <summary>
    /// 客户群数量。
    /// </summary>
    public int? GroupChatCount { get; set; }

    /// <summary>
    /// 邀请链接。
    /// </summary>
    public string? InviteLink { get; set; }
}

/// <summary>
/// 客户群组用户信息。
/// </summary>
public class CrmGroupSetUser
{
    /// <summary>
    /// 用户 ID。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// 用户名称。
    /// </summary>
    public string? UserName { get; set; }
}

/// <summary>
/// CRM 布尔结果响应。
/// </summary>
public class CrmBooleanResultResponse
{
    /// <summary>
    /// 调用结果。
    /// </summary>
    public bool Result { get; set; }
}

/// <summary>
/// 客户群组列表响应。
/// </summary>
public class CrmGroupSetListResponse
{
    /// <summary>
    /// 是否还有更多数据。
    /// </summary>
    public bool HasMore { get; set; }

    /// <summary>
    /// 下一页游标。
    /// </summary>
    public string? NextToken { get; set; }

    /// <summary>
    /// 客户群组列表。
    /// </summary>
    public List<CrmGroupSetDetail> ResultList { get; set; } = [];

    /// <summary>
    /// 总数量。
    /// </summary>
    public long? TotalCount { get; set; }
}
