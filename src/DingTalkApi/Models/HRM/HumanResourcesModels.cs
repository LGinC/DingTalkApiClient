using System.Text.Json.Serialization;
using DingTalkApi.Models;

namespace DingTalkApi.Models.HRM;

/// <summary>
/// 获取企业职位列表请求。
/// </summary>
public class HrmPositionQueryRequest
{
    /// <summary>
    /// 职位名称。
    /// </summary>
    public string? PositionName { get; set; }

    /// <summary>
    /// 职位类别ID列表。
    /// </summary>
    public List<string> InCategoryIds { get; set; } = [];

    /// <summary>
    /// 职位ID列表。
    /// </summary>
    public List<string> InPositionIds { get; set; } = [];

    /// <summary>
    /// 部门ID。
    /// </summary>
    public long? DeptId { get; set; }
}

/// <summary>
/// 企业职位列表响应。
/// </summary>
public class HrmPositionListResponse
{
    /// <summary>
    /// 分页游标。如果未返回，表示数据已经读取完毕。
    /// </summary>
    public long? NextToken { get; set; }

    /// <summary>
    /// 是否有更多数据。
    /// </summary>
    public bool HasMore { get; set; }

    /// <summary>
    /// 职位列表。
    /// </summary>
    public List<HrmPositionInfo> List { get; set; } = [];
}

/// <summary>
/// 企业职位信息。
/// </summary>
public class HrmPositionInfo
{
    /// <summary>
    /// 职位ID。
    /// </summary>
    public string? PositionId { get; set; }

    /// <summary>
    /// 职位名称。
    /// </summary>
    public string? PositionName { get; set; }

    /// <summary>
    /// 职位类别ID。
    /// </summary>
    public string? PositionCategoryId { get; set; }

    /// <summary>
    /// 所属职务ID。
    /// </summary>
    public string? JobId { get; set; }

    /// <summary>
    /// 职位描述。
    /// </summary>
    public string? PositionDes { get; set; }

    /// <summary>
    /// 职级ID。
    /// </summary>
    public List<string> RankIdList { get; set; } = [];

    /// <summary>
    /// 职位状态，0为启用，1为停用。
    /// </summary>
    public int? Status { get; set; }
}

/// <summary>
/// 企业职级列表响应。
/// </summary>
public class HrmJobRankListResponse
{
    /// <summary>
    /// 分页游标。如果未返回，表示数据已经读取完毕。
    /// </summary>
    public long? NextToken { get; set; }

    /// <summary>
    /// 是否有更多数据。
    /// </summary>
    public bool HasMore { get; set; }

    /// <summary>
    /// 职级信息列表。
    /// </summary>
    public List<HrmJobRankInfo> List { get; set; } = [];
}

/// <summary>
/// 企业职级信息。
/// </summary>
public class HrmJobRankInfo
{
    /// <summary>
    /// 职级ID。
    /// </summary>
    public string? RankId { get; set; }

    /// <summary>
    /// 职级序列ID。
    /// </summary>
    public string? RankCategoryId { get; set; }

    /// <summary>
    /// 职级编码。
    /// </summary>
    public string? RankCode { get; set; }

    /// <summary>
    /// 职级名称。
    /// </summary>
    public string? RankName { get; set; }

    /// <summary>
    /// 最小等级。
    /// </summary>
    public int? MinJobGrade { get; set; }

    /// <summary>
    /// 最大等级。
    /// </summary>
    public int? MaxJobGrade { get; set; }

    /// <summary>
    /// 职级描述。
    /// </summary>
    public string? RankDescription { get; set; }
}

/// <summary>
/// 企业职务列表响应。
/// </summary>
public class HrmJobListResponse
{
    /// <summary>
    /// 分页游标。如果未返回，表示数据已经读取完毕。
    /// </summary>
    public long? NextToken { get; set; }

    /// <summary>
    /// 是否有更多数据。
    /// </summary>
    public bool HasMore { get; set; }

    /// <summary>
    /// 职务信息列表。
    /// </summary>
    public List<HrmJobInfo> List { get; set; } = [];
}

/// <summary>
/// 企业职务信息。
/// </summary>
public class HrmJobInfo
{
    /// <summary>
    /// 职务ID。
    /// </summary>
    public string? JobId { get; set; }

    /// <summary>
    /// 职务名称。
    /// </summary>
    public string? JobName { get; set; }

    /// <summary>
    /// 职务描述。
    /// </summary>
    public string? JobDescription { get; set; }
}

/// <summary>
/// 花名册选项类型字段选项更新请求。
/// </summary>
public class HrmRosterMetaFieldOptionsUpdateRequest
{
    /// <summary>
    /// 花名册分组ID。
    /// </summary>
    public required string GroupId { get; set; }

    /// <summary>
    /// 花名册字段标识。
    /// </summary>
    public required string FieldCode { get; set; }

    /// <summary>
    /// 需要修改的选项值列表，最大值20。
    /// </summary>
    public List<string> Labels { get; set; } = [];

    /// <summary>
    /// 修改类型，OPTIONS_ADD为添加选项，OPTIONS_DELETE为删除选项。
    /// </summary>
    public required string ModifyType { get; set; }
}

/// <summary>
/// 智能人事布尔结果响应。
/// </summary>
public class HrmBooleanResultResponse
{
    /// <summary>
    /// 操作是否成功。
    /// </summary>
    public bool Result { get; set; }
}

/// <summary>
/// 添加待入职员工请求。
/// </summary>
public class HrmPreentryCreateRequest
{
    /// <summary>
    /// 待入职员工的姓名。
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 待入职员工的手机号。
    /// </summary>
    public required string Mobile { get; set; }

    /// <summary>
    /// 待入职员工花名册分组列表，建议不超过5个。
    /// </summary>
    public List<HrmPreentryGroup> Groups { get; set; } = [];
}

/// <summary>
/// 待入职员工花名册分组。
/// </summary>
public class HrmPreentryGroup
{
    /// <summary>
    /// 分组ID。
    /// </summary>
    public string? GroupId { get; set; }

    /// <summary>
    /// 分组下明细。
    /// </summary>
    public List<HrmPreentrySection> Sections { get; set; } = [];
}

/// <summary>
/// 待入职员工花名册分组明细。
/// </summary>
public class HrmPreentrySection
{
    /// <summary>
    /// 员工字段列表。
    /// </summary>
    public List<HrmPreentryField> EmpFieldVOList { get; set; } = [];
}

/// <summary>
/// 待入职员工花名册字段。
/// </summary>
public class HrmPreentryField
{
    /// <summary>
    /// 字段值。
    /// </summary>
    public string? Value { get; set; }

    /// <summary>
    /// 字段标识。
    /// </summary>
    public string? FieldCode { get; set; }
}

/// <summary>
/// 添加待入职员工响应。
/// </summary>
public class HrmPreentryCreateResponse
{
    /// <summary>
    /// 待入职员工的临时userId，正式入职后会发生变化。
    /// </summary>
    public required string TmpUserId { get; set; }
}

/// <summary>
/// 离职员工列表响应。
/// </summary>
public class HrmDismissionEmployeeListResponse
{
    /// <summary>
    /// 分页游标。
    /// </summary>
    public long? NextToken { get; set; }

    /// <summary>
    /// 是否还有更多数据。
    /// </summary>
    public bool HasMore { get; set; }

    /// <summary>
    /// 返回的离职人员userId列表。
    /// </summary>
    public List<string> UserIdList { get; set; } = [];
}

/// <summary>
/// 修改已离职员工信息请求。
/// </summary>
public class HrmTerminatedEmployeeUpdateRequest
{
    /// <summary>
    /// 已离职员工的userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 离职备注信息。
    /// </summary>
    public required string DismissionMemo { get; set; }

    /// <summary>
    /// 最后工作日，即离职日期，格式为毫秒值时间戳。
    /// </summary>
    public required string LastWorkDate { get; set; }
}

/// <summary>
/// 批量获取员工离职信息响应。
/// </summary>
public class HrmDimissionInfoListResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    public List<HrmDimissionInfo> Result { get; set; } = [];
}

/// <summary>
/// 员工离职信息。
/// </summary>
public class HrmDimissionInfo
{
    /// <summary>
    /// 员工userId。
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// 最后工作日。
    /// </summary>
    public long? LastWorkDay { get; set; }

    /// <summary>
    /// 离职前部门列表。
    /// </summary>
    public List<HrmDimissionDepartment> DeptList { get; set; } = [];

    /// <summary>
    /// 离职原因备注。
    /// </summary>
    public string? ReasonMemo { get; set; }

    /// <summary>
    /// 离职前工作状态，1为待入职，2为试用期，3为正式。
    /// </summary>
    public int? PreStatus { get; set; }

    /// <summary>
    /// 离职交接人的userId。
    /// </summary>
    public string? HandoverUserId { get; set; }

    /// <summary>
    /// 离职状态，1为待离职，2为已离职，3为非待离职或非已离职，4为已提交离职审批单且暂未通过。
    /// </summary>
    public int? Status { get; set; }

    /// <summary>
    /// 离职前主部门名称。
    /// </summary>
    public string? MainDeptName { get; set; }

    /// <summary>
    /// 离职前主部门ID。
    /// </summary>
    public long? MainDeptId { get; set; }

    /// <summary>
    /// 主动原因。
    /// </summary>
    public List<string> VoluntaryReason { get; set; } = [];

    /// <summary>
    /// 被动原因。
    /// </summary>
    public List<string> PassiveReason { get; set; } = [];
}

/// <summary>
/// 离职前部门信息。
/// </summary>
public class HrmDimissionDepartment
{
    /// <summary>
    /// 部门路径。
    /// </summary>
    [JsonPropertyName("dept_path")]
    public string? DeptPath { get; set; }

    /// <summary>
    /// 部门ID。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public long? DeptId { get; set; }
}

/// <summary>
/// 智能人事员工调岗请求。
/// </summary>
public class HrmEmployeeTransferRequest
{
    /// <summary>
    /// 被调岗员工userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 调岗后的部门ID列表。
    /// </summary>
    public List<string> DeptIdsAfterTransfer { get; set; } = [];

    /// <summary>
    /// 员工调岗后的职位名称。
    /// </summary>
    public string? PositionNameAfterTransfer { get; set; }

    /// <summary>
    /// 员工调岗后的职位ID。
    /// </summary>
    public string? PositionLevelAfterTransfer { get; set; }

    /// <summary>
    /// 员工调岗后的职务ID。
    /// </summary>
    public string? JobIdAfterTransfer { get; set; }

    /// <summary>
    /// 员工调岗后的职级名称或职位ID。
    /// </summary>
    public string? PositionIdAfterTransfer { get; set; }

    /// <summary>
    /// 员工调岗后的职级ID。
    /// </summary>
    public string? RankIdAfterTransfer { get; set; }

    /// <summary>
    /// 操作人userId。
    /// </summary>
    public string? OperateUserId { get; set; }
}

/// <summary>
/// 智能人事员工转正请求。
/// </summary>
public class HrmBecomeRegularRequest
{
    /// <summary>
    /// 待转正用户userId。
    /// </summary>
    public required string UserId { get; set; }

    /// <summary>
    /// 转正时间，Unix毫秒时间戳。
    /// </summary>
    public required string RegularDate { get; set; }

    /// <summary>
    /// 备注信息。
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 操作用户userId。
    /// </summary>
    public required string OperationId { get; set; }
}

/// <summary>
/// 带应用AgentID的topapi请求。
/// </summary>
public class HrmAgentRequest
{
    /// <summary>
    /// 应用的AgentID。
    /// </summary>
    public required long Agentid { get; set; }
}

/// <summary>
/// 花名册元数据响应。
/// </summary>
public class HrmRosterMetaResponse : DingTalkResult
{
    /// <summary>
    /// 服务调用是否成功。
    /// </summary>
    public bool? Success { get; set; }

    /// <summary>
    /// 返回结果，花名册分组定义。
    /// </summary>
    public List<HrmRosterMetaGroup> Result { get; set; } = [];
}

/// <summary>
/// 花名册分组定义。
/// </summary>
public class HrmRosterMetaGroup
{
    /// <summary>
    /// 分组名称。
    /// </summary>
    public string? GroupName { get; set; }

    /// <summary>
    /// 分组标识。
    /// </summary>
    public string? GroupId { get; set; }

    /// <summary>
    /// 花名册分组内字段定义。
    /// </summary>
    public List<HrmRosterMetaField> FieldMetaInfoList { get; set; } = [];

    /// <summary>
    /// 分组是否支持明细。
    /// </summary>
    public bool? Detail { get; set; }
}

/// <summary>
/// 花名册字段定义。
/// </summary>
public class HrmRosterMetaField
{
    /// <summary>
    /// 字段名称。
    /// </summary>
    public string? FieldName { get; set; }

    /// <summary>
    /// 字段标识。
    /// </summary>
    public string? FieldCode { get; set; }

    /// <summary>
    /// 是否衍生字段，例如司龄、年龄等系统计算的字段。
    /// </summary>
    public bool? Derived { get; set; }
}

/// <summary>
/// 花名册字段组详情响应。
/// </summary>
public class HrmRosterFieldGroupResponse : DingTalkResult
{
    /// <summary>
    /// 成功标记。
    /// </summary>
    public bool? Success { get; set; }

    /// <summary>
    /// 返回结果。
    /// </summary>
    public List<HrmRosterFieldGroup> Result { get; set; } = [];
}

/// <summary>
/// 花名册字段组。
/// </summary>
public class HrmRosterFieldGroup
{
    /// <summary>
    /// 字段组ID。
    /// </summary>
    public string? GroupId { get; set; }

    /// <summary>
    /// 是否支持明细。
    /// </summary>
    public bool? HasDetail { get; set; }

    /// <summary>
    /// 组里面的字段集合。
    /// </summary>
    public List<HrmRosterField> FieldList { get; set; } = [];
}

/// <summary>
/// 花名册字段。
/// </summary>
public class HrmRosterField
{
    /// <summary>
    /// 字段类型。
    /// </summary>
    public string? FieldType { get; set; }

    /// <summary>
    /// 字段描述。
    /// </summary>
    public string? FieldName { get; set; }

    /// <summary>
    /// 字段code。
    /// </summary>
    public string? FieldCode { get; set; }
}

/// <summary>
/// 获取员工花名册字段信息请求。
/// </summary>
public class HrmEmployeeRosterFieldListRequest
{
    /// <summary>
    /// 员工的userid列表，多个userid之间使用逗号分隔，一次最多支持传100个值。
    /// </summary>
    public required string UseridList { get; set; }

    /// <summary>
    /// 需要获取的花名册字段信息，多个字段之间使用逗号分隔。
    /// </summary>
    public string? FieldFilterList { get; set; }

    /// <summary>
    /// 应用的AgentID。
    /// </summary>
    public required long Agentid { get; set; }
}

/// <summary>
/// 员工花名册字段信息响应。
/// </summary>
public class HrmEmployeeRosterFieldListResponse : DingTalkResult
{
    /// <summary>
    /// 调用是否成功。
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 返回结果。
    /// </summary>
    public List<HrmEmployeeRosterFieldInfo> Result { get; set; } = [];
}

/// <summary>
/// 员工花名册字段信息。
/// </summary>
public class HrmEmployeeRosterFieldInfo
{
    /// <summary>
    /// 企业的corpid。
    /// </summary>
    public required string CorpId { get; set; }

    /// <summary>
    /// 返回的字段信息列表。
    /// </summary>
    public List<HrmEmployeeRosterFieldData> FieldDataList { get; set; } = [];

    /// <summary>
    /// 员工的userid。
    /// </summary>
    public required string Userid { get; set; }
}

/// <summary>
/// 员工花名册字段数据。
/// </summary>
public class HrmEmployeeRosterFieldData
{
    /// <summary>
    /// 字段名称。
    /// </summary>
    public required string FieldName { get; set; }

    /// <summary>
    /// 字段标识。
    /// </summary>
    public required string FieldCode { get; set; }

    /// <summary>
    /// 分组标识。
    /// </summary>
    public required string GroupId { get; set; }

    /// <summary>
    /// 字段值列表。明细分组字段包含多条，非明细分组仅一条记录。
    /// </summary>
    public List<HrmEmployeeRosterFieldValue> FieldValueList { get; set; } = [];
}

/// <summary>
/// 员工花名册字段值。
/// </summary>
public class HrmEmployeeRosterFieldValue
{
    /// <summary>
    /// 明细下标。
    /// </summary>
    public int ItemIndex { get; set; }

    /// <summary>
    /// 字段展示值，选项类型字段对应选项的value。
    /// </summary>
    public required string Label { get; set; }

    /// <summary>
    /// 字段取值，选项类型字段对应选项的key。
    /// </summary>
    public required string Value { get; set; }
}

/// <summary>
/// 更新员工花名册信息请求。
/// </summary>
public class HrmEmployeeRosterUpdateRequest
{
    /// <summary>
    /// 应用的AgentID。
    /// </summary>
    public required long Agentid { get; set; }

    /// <summary>
    /// 员工信息。
    /// </summary>
    public required HrmEmployeeRosterUpdateParam Param { get; set; }
}

/// <summary>
/// 员工花名册更新信息。
/// </summary>
public class HrmEmployeeRosterUpdateParam
{
    /// <summary>
    /// 花名册分组。
    /// </summary>
    public List<HrmEmployeeRosterUpdateGroup> Groups { get; set; } = [];

    /// <summary>
    /// 员工的userid。
    /// </summary>
    public string? Userid { get; set; }
}

/// <summary>
/// 员工花名册更新分组。
/// </summary>
public class HrmEmployeeRosterUpdateGroup
{
    /// <summary>
    /// 分组标识。
    /// </summary>
    public string? GroupId { get; set; }

    /// <summary>
    /// 分组下明细，非明细分组仅一条明细。
    /// </summary>
    public List<HrmEmployeeRosterUpdateSection> Sections { get; set; } = [];
}

/// <summary>
/// 员工花名册更新明细。
/// </summary>
public class HrmEmployeeRosterUpdateSection
{
    /// <summary>
    /// 分组下字段列表。
    /// </summary>
    public List<HrmEmployeeRosterUpdateField> Section { get; set; } = [];

    /// <summary>
    /// 明细下标。
    /// </summary>
    public double? OldIndex { get; set; }
}

/// <summary>
/// 员工花名册更新字段。
/// </summary>
public class HrmEmployeeRosterUpdateField
{
    /// <summary>
    /// 更新的字段code。
    /// </summary>
    public string? FieldCode { get; set; }

    /// <summary>
    /// 更新的字段值。
    /// </summary>
    public string? Value { get; set; }
}

/// <summary>
/// topapi智能人事布尔响应。
/// </summary>
public class HrmTopBooleanResponse : DingTalkResult
{
    /// <summary>
    /// 调用结果。
    /// </summary>
    public bool Result { get; set; }

    /// <summary>
    /// 调用是否成功。
    /// </summary>
    public bool? Success { get; set; }
}

/// <summary>
/// topapi游标分页请求。
/// </summary>
public class HrmCursorPageRequest
{
    /// <summary>
    /// 分页游标，从0开始。
    /// </summary>
    public required double Offset { get; set; }

    /// <summary>
    /// 分页大小，最大50。
    /// </summary>
    public required double Size { get; set; }
}

/// <summary>
/// 待入职员工列表响应。
/// </summary>
public class HrmPreentryListResponse : DingTalkResult
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    public required HrmUserIdPage Result { get; set; }

    /// <summary>
    /// 调用结果。
    /// </summary>
    public bool Success { get; set; }
}

/// <summary>
/// userId分页结果。
/// </summary>
public class HrmUserIdPage
{
    /// <summary>
    /// 下一次分页调用的offset值。
    /// </summary>
    public long NextCursor { get; set; }

    /// <summary>
    /// 查询到的员工userid。
    /// </summary>
    public List<string> DataList { get; set; } = [];
}

/// <summary>
/// 获取在职员工列表请求。
/// </summary>
public class HrmOnJobEmployeeListRequest : HrmCursorPageRequest
{
    /// <summary>
    /// 在职员工子状态筛选，多个状态之间使用英文逗号分隔。
    /// </summary>
    public required string StatusList { get; set; }
}

/// <summary>
/// 在职员工列表响应。
/// </summary>
public class HrmOnJobEmployeeListResponse : DingTalkResult
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    public HrmOnJobEmployeePage? Result { get; set; }

    /// <summary>
    /// 调用结果。
    /// </summary>
    public bool? Success { get; set; }
}

/// <summary>
/// 在职员工分页结果。
/// </summary>
public class HrmOnJobEmployeePage
{
    /// <summary>
    /// 查询到的员工userid。
    /// </summary>
    public string? DataList { get; set; }

    /// <summary>
    /// 下一次分页调用的offset值。
    /// </summary>
    public double? NextCursor { get; set; }
}

/// <summary>
/// 添加企业待入职员工请求。
/// </summary>
public class HrmTopPreentryCreateRequest
{
    /// <summary>
    /// 添加待入职人员。
    /// </summary>
    public required HrmTopPreentryCreateParam Param { get; set; }
}

/// <summary>
/// 添加企业待入职员工参数。
/// </summary>
public class HrmTopPreentryCreateParam
{
    /// <summary>
    /// 预期入职时间。
    /// </summary>
    public string? PreEntryTime { get; set; }

    /// <summary>
    /// 待入职员工姓名。
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 待入职员工手机号。
    /// </summary>
    public required string Mobile { get; set; }

    /// <summary>
    /// 扩展信息，json串格式。
    /// </summary>
    public string? ExtendInfo { get; set; }

    /// <summary>
    /// 操作人userid。
    /// </summary>
    public string? OpUserid { get; set; }
}

/// <summary>
/// 添加企业待入职员工响应。
/// </summary>
public class HrmTopPreentryCreateResponse : DingTalkResult
{
    /// <summary>
    /// 是否调用成功。
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 员工ID。
    /// </summary>
    public required string Userid { get; set; }
}
