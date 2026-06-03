using System.Text.Json.Serialization;
using DingTalkApiClient.Models;

namespace DingTalkApiClient.Models.IndustryOpen;

/// <summary>
/// ResidentPointsRulesGetResponsePointRuleListItem
/// </summary>
public class ResidentPointsRulesGetResponsePointRuleListItem
{
    /// <summary>
    /// 增加或减少的分数。 说明 增加为正数，减少为负数。
    /// </summary>
    [JsonPropertyName("score")]
    public long? Score { get; set; }

    /// <summary>
    /// 单日计次上限，0表示无上限。
    /// </summary>
    [JsonPropertyName("dayLimitTimes")]
    public long? DayLimitTimes { get; set; }

    /// <summary>
    /// 生效状态 ，取值： 0：不生效 1：生效
    /// </summary>
    [JsonPropertyName("status")]
    public long? Status { get; set; }

    /// <summary>
    /// 对应的行为代码。
    /// </summary>
    [JsonPropertyName("ruleCode")]
    public string? RuleCode { get; set; }

    /// <summary>
    /// 对应的行为名字。
    /// </summary>
    [JsonPropertyName("ruleName")]
    public string? RuleName { get; set; }

    /// <summary>
    /// 扩展字段。
    /// </summary>
    [JsonPropertyName("extension")]
    public string? Extension { get; set; }

    /// <summary>
    /// 分组ID。
    /// </summary>
    [JsonPropertyName("groupId")]
    public long? GroupId { get; set; }
}

/// <summary>
/// 查询组织维度配置的所有积分规则响应
/// </summary>
public class ResidentPointsRulesGetResponse
{
    /// <summary>
    /// 积分规则列表。
    /// </summary>
    [JsonPropertyName("pointRuleList")]
    public List<ResidentPointsRulesGetResponsePointRuleListItem> PointRuleList { get; set; } = [];
}

/// <summary>
/// ResidentPointsRecordsGetResponsePointRecordListItem
/// </summary>
public class ResidentPointsRecordsGetResponsePointRecordListItem
{
    /// <summary>
    /// 用户的userid。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 增加或减少的分数。 说明 增加为正数，减少为负数。
    /// </summary>
    [JsonPropertyName("score")]
    public long? Score { get; set; }

    /// <summary>
    /// 创建时间戳，单位毫秒。
    /// </summary>
    [JsonPropertyName("createAt")]
    public long? CreateAt { get; set; }

    /// <summary>
    /// 积分记录的唯一幂等标志。
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    /// <summary>
    /// 对应的行为代码，可以为空。
    /// </summary>
    [JsonPropertyName("ruleCode")]
    public string? RuleCode { get; set; }

    /// <summary>
    /// 对应的行为名字。
    /// </summary>
    [JsonPropertyName("ruleName")]
    public string? RuleName { get; set; }
}

/// <summary>
/// 分页查询居民积分流水响应
/// </summary>
public class ResidentPointsRecordsGetResponse
{
    /// <summary>
    /// 积分流水记录列表。
    /// </summary>
    [JsonPropertyName("pointRecordList")]
    public List<ResidentPointsRecordsGetResponsePointRecordListItem> PointRecordList { get; set; } = [];

    /// <summary>
    /// 是否还有更多数据。
    /// </summary>
    [JsonPropertyName("hasMore")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// 下一次请求的游标起始值。
    /// </summary>
    [JsonPropertyName("nextToken")]
    public long? NextToken { get; set; }

    /// <summary>
    /// 查询的总记录数。 说明 如果为-1则不计算总数。
    /// </summary>
    [JsonPropertyName("totalCount")]
    public long? TotalCount { get; set; }
}

/// <summary>
/// 创建项目组请求
/// </summary>
public class IndustryCampusesProjectsGroupsPostRequest
{
    /// <summary>
    /// 项目组名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 扩展信息。 说明 该参数值自定义传入，例如:{\"level\":3}。
    /// </summary>
    [JsonPropertyName("extend")]
    public string? Extend { get; set; }
}

/// <summary>
/// 创建项目组响应
/// </summary>
public class IndustryCampusesProjectsGroupsPostResponse
{
    /// <summary>
    /// 项目组ID。
    /// </summary>
    [JsonPropertyName("groupId")]
    public long? GroupId { get; set; }
}

/// <summary>
/// 删除项目组响应
/// </summary>
public class IndustryCampusesProjectsGroupsDeleteResponse
{
    /// <summary>
    /// 是否删除成功。 true：成功 false：失败
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 创建园区项目请求
/// </summary>
public class IndustryCampusesProjectsPostRequest
{
    /// <summary>
    /// 园区项目的名称。
    /// </summary>
    [JsonPropertyName("campusName")]
    public string? CampusName { get; set; }

    /// <summary>
    /// 联系电话。
    /// </summary>
    [JsonPropertyName("telephone")]
    public string? Telephone { get; set; }

    /// <summary>
    /// 园区项目的描述。
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// 园区所在国家。 说明 国家名称，例如：中国。
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>
    /// 园区所在详细地址信息。
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// 订单信息。 说明 该参数值，开发者自定义。
    /// </summary>
    [JsonPropertyName("orderInfo")]
    public string? OrderInfo { get; set; }

    /// <summary>
    /// 扩展字段。 说明 该参数值，开发者自定义。例如：{\"creator\":\"001\"}
    /// </summary>
    [JsonPropertyName("extend")]
    public string? Extend { get; set; }

    /// <summary>
    /// 创建人的unionId。 企业内部应用，调用查询用户详情接口获取unionid参数值。 第三方企业应用，调用查询用户详情接口获取unionid参数值。
    /// </summary>
    [JsonPropertyName("creatorUnionId")]
    public string? CreatorUnionId { get; set; }

    /// <summary>
    /// 经纬度，格式为：经度,维度。
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }
}

/// <summary>
/// 创建园区项目响应
/// </summary>
public class IndustryCampusesProjectsPostResponse
{
    /// <summary>
    /// 园区组织CorpId。
    /// </summary>
    [JsonPropertyName("campusCorpId")]
    public string? CampusCorpId { get; set; }

    /// <summary>
    /// 园区组织在上下游组织内的部门ID。
    /// </summary>
    [JsonPropertyName("campusDeptId")]
    public string? CampusDeptId { get; set; }
}

/// <summary>
/// 查询项目组信息响应
/// </summary>
public class IndustryCampusesProjectsGroupInfosGetResponse
{
    /// <summary>
    /// 项目组的名称。
    /// </summary>
    [JsonPropertyName("projectGroupName")]
    public string? ProjectGroupName { get; set; }

    /// <summary>
    /// 项目组的扩展信息。
    /// </summary>
    [JsonPropertyName("extend")]
    public string? Extend { get; set; }
}

/// <summary>
/// 查询园区项目信息响应
/// </summary>
public class IndustryCampusesProjectInfosGetResponse
{
    /// <summary>
    /// 园区项目的名称。
    /// </summary>
    [JsonPropertyName("campusName")]
    public string? CampusName { get; set; }

    /// <summary>
    /// 园区项目的组织corpId。
    /// </summary>
    [JsonPropertyName("campusCorpId")]
    public string? CampusCorpId { get; set; }

    /// <summary>
    /// 园区项目的部门ID。
    /// </summary>
    [JsonPropertyName("campusDeptId")]
    public long? CampusDeptId { get; set; }

    /// <summary>
    /// 所在的项目组ID。
    /// </summary>
    [JsonPropertyName("belongProjectGroupId")]
    public string? BelongProjectGroupId { get; set; }

    /// <summary>
    /// 电话。
    /// </summary>
    [JsonPropertyName("telephone")]
    public string? Telephone { get; set; }

    /// <summary>
    /// 园区项目的描述。
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// 园区项目的面积。
    /// </summary>
    [JsonPropertyName("area")]
    public long? Area { get; set; }

    /// <summary>
    /// 园区项目所在国家。
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>
    /// 园区项目所在的省行政编码。
    /// </summary>
    [JsonPropertyName("provId")]
    public long? ProvId { get; set; }

    /// <summary>
    /// 园区项目所在的市行政编码。
    /// </summary>
    [JsonPropertyName("cityId")]
    public long? CityId { get; set; }

    /// <summary>
    /// 园区项目所在的区行政编码。
    /// </summary>
    [JsonPropertyName("countyId")]
    public long? CountyId { get; set; }

    /// <summary>
    /// 园区项目的详细地址。
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// 园区项目所在的经纬度。
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// 园区项目容纳的人数。
    /// </summary>
    [JsonPropertyName("capacity")]
    public string? Capacity { get; set; }

    /// <summary>
    /// 园区项目的订购时间。
    /// </summary>
    [JsonPropertyName("orderStartTime")]
    public long? OrderStartTime { get; set; }

    /// <summary>
    /// 园区项目的过期时间。
    /// </summary>
    [JsonPropertyName("orderEndTime")]
    public long? OrderEndTime { get; set; }

    /// <summary>
    /// 园区项目的购买信息。
    /// </summary>
    [JsonPropertyName("orderInfo")]
    public string? OrderInfo { get; set; }

    /// <summary>
    /// 园区项目的扩展属性。
    /// </summary>
    [JsonPropertyName("extend")]
    public string? Extend { get; set; }
}

/// <summary>
/// 保存人员扩展属性响应
/// </summary>
public class IndustryMedicalsUsersUserIdExtendsPostResponse
{
    /// <summary>
    /// 调用是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 计件报工请求
/// </summary>
public class ManufacturingUsersUserIdJobsPostRequest
{
    /// <summary>
    /// 报废数量。
    /// </summary>
    [JsonPropertyName("scrappedQuantity")]
    public string? ScrappedQuantity { get; set; }

    /// <summary>
    /// 产品规格。
    /// </summary>
    [JsonPropertyName("productSpecification")]
    public string? ProductSpecification { get; set; }

    /// <summary>
    /// 合格数量。
    /// </summary>
    [JsonPropertyName("qualifiedQuantity")]
    public string? QualifiedQuantity { get; set; }

    /// <summary>
    /// 可重工数量。
    /// </summary>
    [JsonPropertyName("reworkableQuantity")]
    public string? ReworkableQuantity { get; set; }

    /// <summary>
    /// 员工姓名。
    /// </summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }

    /// <summary>
    /// 随机字符串，唯一标识，用于幂等及更新。
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    /// <summary>
    /// 产品名称，例如：双头螺柱001。
    /// </summary>
    [JsonPropertyName("productName")]
    public string? ProductName { get; set; }

    /// <summary>
    /// 产品英文名称。
    /// </summary>
    [JsonPropertyName("productEnName")]
    public string? ProductEnName { get; set; }

    /// <summary>
    /// 扩展字段，用于增加自定义字段。
    /// </summary>
    [JsonPropertyName("extend")]
    public string? Extend { get; set; }

    /// <summary>
    /// 产品唯一标识。
    /// </summary>
    [JsonPropertyName("productCode")]
    public string? ProductCode { get; set; }

    /// <summary>
    /// 制程名称。
    /// </summary>
    [JsonPropertyName("processName")]
    public string? ProcessName { get; set; }

    /// <summary>
    /// 制程英文名称。
    /// </summary>
    [JsonPropertyName("processEnName")]
    public string? ProcessEnName { get; set; }

    /// <summary>
    /// mes系统唯一标识。
    /// </summary>
    [JsonPropertyName("mesAppKey")]
    public string? MesAppKey { get; set; }

    /// <summary>
    /// 工单编号。
    /// </summary>
    [JsonPropertyName("instNo")]
    public string? InstNo { get; set; }

    /// <summary>
    /// 生产日期时间，格式：yyyy-MM-dd HH:mm:ss。
    /// </summary>
    [JsonPropertyName("manufactureDate")]
    public string? ManufactureDate { get; set; }

    /// <summary>
    /// 工厂所在钉钉组织的企业corpId。
    /// </summary>
    [JsonPropertyName("dingCorpId")]
    public string? DingCorpId { get; set; }

    /// <summary>
    /// 是否是批量报工，即一次计件报工由多个工人一起分担。
    /// </summary>
    [JsonPropertyName("isBatchJob")]
    public string? IsBatchJob { get; set; }

    /// <summary>
    /// 批量报工时，多个工人的用户名列表，以英文逗号分隔。
    /// </summary>
    [JsonPropertyName("userNameList")]
    public string? UserNameList { get; set; }

    /// <summary>
    /// 批量报工时，多个工人的钉钉工号列表，以英文逗号分隔。
    /// </summary>
    [JsonPropertyName("userIdList")]
    public string? UserIdList { get; set; }

    /// <summary>
    /// 计件单价，单位：分。
    /// </summary>
    [JsonPropertyName("unitPrice")]
    public string? UnitPrice { get; set; }
}

/// <summary>
/// 计件报工响应
/// </summary>
public class ManufacturingUsersUserIdJobsPostResponse
{
    /// <summary>
    /// HTTP响应码。
    /// </summary>
    [JsonPropertyName("httpCode")]
    public string? HttpCode { get; set; }

    /// <summary>
    /// 此次上报的计件数据的唯一标识。
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    /// <summary>
    /// 返回结果。
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// 错误码描述。
    /// </summary>
    [JsonPropertyName("errorMsg")]
    public string? ErrorMsg { get; set; }

    /// <summary>
    /// 错误级别，取值：
    /// </summary>
    [JsonPropertyName("errorLevel")]
    public long? ErrorLevel { get; set; }

    /// <summary>
    /// 调用失败时返回的错误码。
    /// </summary>
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }

    /// <summary>
    /// 调用是否成功，取值:
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 查询计件报工数据请求
/// </summary>
public class ManufacturingUsersJobsQueryPostRequest
{
    /// <summary>
    /// 产品中文名称。
    /// </summary>
    [JsonPropertyName("productName")]
    public string? ProductName { get; set; }

    /// <summary>
    /// 分页参数每页显示条数。
    /// </summary>
    [JsonPropertyName("pageSize")]
    public long? PageSize { get; set; }

    /// <summary>
    /// 报工合格数量。
    /// </summary>
    [JsonPropertyName("qualifiedQuantity")]
    public string? QualifiedQuantity { get; set; }

    /// <summary>
    /// 生产日期。
    /// </summary>
    [JsonPropertyName("manufactureDay")]
    public string? ManufactureDay { get; set; }

    /// <summary>
    /// 工单编号。
    /// </summary>
    [JsonPropertyName("instNo")]
    public string? InstNo { get; set; }

    /// <summary>
    /// 员工姓名。
    /// </summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }

    /// <summary>
    /// 产品唯一标识。
    /// </summary>
    [JsonPropertyName("productCode")]
    public string? ProductCode { get; set; }

    /// <summary>
    /// 产品规格。
    /// </summary>
    [JsonPropertyName("productSpecification")]
    public string? ProductSpecification { get; set; }

    /// <summary>
    /// 计件单价，单位：分。
    /// </summary>
    [JsonPropertyName("unitPrice")]
    public string? UnitPrice { get; set; }

    /// <summary>
    /// 报工记录的唯一标识。
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    /// <summary>
    /// 分页参数，页码，从1开始。
    /// </summary>
    [JsonPropertyName("currentPage")]
    public long? CurrentPage { get; set; }

    /// <summary>
    /// 员工的userid。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// MES系统唯一标识。
    /// </summary>
    [JsonPropertyName("mesAppKey")]
    public string? MesAppKey { get; set; }
}

/// <summary>
/// 查询计件报工数据响应
/// </summary>
public class ManufacturingUsersJobsQueryPostResponse
{
    /// <summary>
    /// 返回的HTTP状态码。
    /// </summary>
    [JsonPropertyName("httpCode")]
    public string? HttpCode { get; set; }

    /// <summary>
    /// 查询的数据结果。
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }
}

/// <summary>
/// 注册设备到钉钉请求
/// </summary>
public class DeviceManagementCustomersDevicesRegisterAndActivatePostRequest
{
    /// <summary>
    /// 设备号。 说明 用户自定义参数，要求企业内每一个设备的设备码必须唯一。
    /// </summary>
    [JsonPropertyName("deviceCode")]
    public string? DeviceCode { get; set; }

    /// <summary>
    /// 设备名称。 说明 用户自定义参数。
    /// </summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>
    /// 设备的简介。
    /// </summary>
    [JsonPropertyName("introduction")]
    public string? Introduction { get; set; }

    /// <summary>
    /// 设备型号。
    /// </summary>
    [JsonPropertyName("typeUuid")]
    public string? TypeUuid { get; set; }

    /// <summary>
    /// 设备管理员的userId列表。
    /// </summary>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; } = [];

    /// <summary>
    /// 角色标识。
    /// </summary>
    [JsonPropertyName("roleUuid")]
    public string? RoleUuid { get; set; }

    /// <summary>
    /// 设备详情链接，最大长度2048字符。
    /// </summary>
    [JsonPropertyName("deviceDetailUrl")]
    public string? DeviceDetailUrl { get; set; }

    /// <summary>
    /// 设备回调链接，最大长度2048字符。
    /// </summary>
    [JsonPropertyName("deviceCallbackUrl")]
    public string? DeviceCallbackUrl { get; set; }
}

/// <summary>
/// 响应结果。
/// </summary>
public class DeviceManagementCustomersDevicesRegisterAndActivatePostResponseResult
{
    /// <summary>
    /// 设备号。
    /// </summary>
    [JsonPropertyName("deviceCode")]
    public string? DeviceCode { get; set; }

    /// <summary>
    /// 钉钉侧设备标识。
    /// </summary>
    [JsonPropertyName("deviceUuid")]
    public string? DeviceUuid { get; set; }

    /// <summary>
    /// 设备名称。
    /// </summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>
    /// 设备的简介。
    /// </summary>
    [JsonPropertyName("introduction")]
    public string? Introduction { get; set; }

    /// <summary>
    /// 设备型号。
    /// </summary>
    [JsonPropertyName("typeUuid")]
    public string? TypeUuid { get; set; }

    /// <summary>
    /// 角色标识。
    /// </summary>
    [JsonPropertyName("roleUuid")]
    public string? RoleUuid { get; set; }

    /// <summary>
    /// 设备详情链接。
    /// </summary>
    [JsonPropertyName("deviceDetailUrl")]
    public string? DeviceDetailUrl { get; set; }

    /// <summary>
    /// 设备管理员的userId列表，最大值50。
    /// </summary>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; } = [];
}

/// <summary>
/// 注册设备到钉钉响应
/// </summary>
public class DeviceManagementCustomersDevicesRegisterAndActivatePostResponse
{
    /// <summary>
    /// 接口调用是否成功。 true：成功 false：失败
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 响应结果。
    /// </summary>
    [JsonPropertyName("result")]
    public DeviceManagementCustomersDevicesRegisterAndActivatePostResponseResult? Result { get; set; }
}

/// <summary>
/// DeviceManagementCustomersDevicesRegistrationActivationsBatchPostRequestRegisterAndActivateVOSItem
/// </summary>
public class DeviceManagementCustomersDevicesRegistrationActivationsBatchPostRequestRegisterAndActivateVOSItem
{
    /// <summary>
    /// 设备号。 说明 用户自定义参数，要求企业内每一个设备的设备码必须唯一。
    /// </summary>
    [JsonPropertyName("deviceCode")]
    public string? DeviceCode { get; set; }

    /// <summary>
    /// 设备详情链接，最大长度2048字符。
    /// </summary>
    [JsonPropertyName("deviceDetailUrl")]
    public string? DeviceDetailUrl { get; set; }

    /// <summary>
    /// 设备回调链接，最大长度2048字符。
    /// </summary>
    [JsonPropertyName("deviceCallbackUrl")]
    public string? DeviceCallbackUrl { get; set; }

    /// <summary>
    /// 设备名称。 说明 用户自定义参数。
    /// </summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>
    /// 分组标识，该参数需要在群内咨询。 企业内部应用，请参考设备上钉咨询群。 第三方企业应用，请参考设备上钉咨询群。
    /// </summary>
    [JsonPropertyName("groupUuid")]
    public string? GroupUuid { get; set; }

    /// <summary>
    /// 设备的简介。
    /// </summary>
    [JsonPropertyName("introduction")]
    public string? Introduction { get; set; }

    /// <summary>
    /// 角色标识，该参数需要在群内咨询。 企业内部应用，请参考设备上钉咨询群。 第三方企业应用，请参考设备上钉咨询群。
    /// </summary>
    [JsonPropertyName("roleUuid")]
    public string? RoleUuid { get; set; }

    /// <summary>
    /// 设备型号，该参数需要在群内咨询。 企业内部应用，请参考设备上钉咨询群。 第三方企业应用，请参考设备上钉咨询群。
    /// </summary>
    [JsonPropertyName("typeUuid")]
    public string? TypeUuid { get; set; }

    /// <summary>
    /// 设备管理员的userId列表，最大值50。
    /// </summary>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; } = [];
}

/// <summary>
/// 批量注册与激活设备请求
/// </summary>
public class DeviceManagementCustomersDevicesRegistrationActivationsBatchPostRequest
{
    /// <summary>
    /// 批量注册的设备信息列表，最大值100。
    /// </summary>
    [JsonPropertyName("registerAndActivateVOS")]
    public List<DeviceManagementCustomersDevicesRegistrationActivationsBatchPostRequestRegisterAndActivateVOSItem> RegisterAndActivateVOS { get; set; } = [];
}

/// <summary>
/// 设备信息。
/// </summary>
public class DeviceManagementCustomersDevicesRegistrationActivationsBatchPostResponseSuccessItemsItemResult
{
    /// <summary>
    /// 设备回调链接。
    /// </summary>
    [JsonPropertyName("deviceCallbackUrl")]
    public string? DeviceCallbackUrl { get; set; }

    /// <summary>
    /// 设备号。
    /// </summary>
    [JsonPropertyName("deviceCode")]
    public string? DeviceCode { get; set; }

    /// <summary>
    /// 设备详情链接。
    /// </summary>
    [JsonPropertyName("deviceDetailUrl")]
    public string? DeviceDetailUrl { get; set; }

    /// <summary>
    /// 设备名称。
    /// </summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>
    /// 设备分组标识。
    /// </summary>
    [JsonPropertyName("groupUuid")]
    public string? GroupUuid { get; set; }

    /// <summary>
    /// 设备图标。
    /// </summary>
    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    /// <summary>
    /// 设备简介。
    /// </summary>
    [JsonPropertyName("introduction")]
    public string? Introduction { get; set; }

    /// <summary>
    /// 角色标识。
    /// </summary>
    [JsonPropertyName("roleUuid")]
    public string? RoleUuid { get; set; }

    /// <summary>
    /// 设备管理员的userId。
    /// </summary>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; } = [];

    /// <summary>
    /// 设备状态。 1：新建 2：激活 3：注册 说明 设备注册失败，不返回该字段。
    /// </summary>
    [JsonPropertyName("status")]
    public long? Status { get; set; }

    /// <summary>
    /// 设备型号。
    /// </summary>
    [JsonPropertyName("typeUuid")]
    public string? TypeUuid { get; set; }

    /// <summary>
    /// 钉钉侧的设备标识。
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    /// <summary>
    /// 设备分类。 0：设备 1：助手
    /// </summary>
    [JsonPropertyName("deviceCategory")]
    public long? DeviceCategory { get; set; }
}

/// <summary>
/// DeviceManagementCustomersDevicesRegistrationActivationsBatchPostResponseSuccessItemsItem
/// </summary>
public class DeviceManagementCustomersDevicesRegistrationActivationsBatchPostResponseSuccessItemsItem
{
    /// <summary>
    /// 错误码。 说明 注册成功，不返回该字段。
    /// </summary>
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }

    /// <summary>
    /// 错误信息。 说明 注册成功，不返回该字段。
    /// </summary>
    [JsonPropertyName("errorMsg")]
    public string? ErrorMsg { get; set; }

    /// <summary>
    /// 设备信息。
    /// </summary>
    [JsonPropertyName("result")]
    public DeviceManagementCustomersDevicesRegistrationActivationsBatchPostResponseSuccessItemsItemResult? Result { get; set; }

    /// <summary>
    /// 设备注册是否成功。 true：成功 false：失败
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 设备信息。
/// </summary>
public class DeviceManagementCustomersDevicesRegistrationActivationsBatchPostResponseFailItemsItemResult
{
    /// <summary>
    /// 设备回调地址。
    /// </summary>
    [JsonPropertyName("deviceCallbackUrl")]
    public string? DeviceCallbackUrl { get; set; }

    /// <summary>
    /// 设备号。
    /// </summary>
    [JsonPropertyName("deviceCode")]
    public string? DeviceCode { get; set; }

    /// <summary>
    /// 设备详情链接。
    /// </summary>
    [JsonPropertyName("deviceDetailUrl")]
    public string? DeviceDetailUrl { get; set; }

    /// <summary>
    /// 设备名称。
    /// </summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>
    /// 设备分组标识。
    /// </summary>
    [JsonPropertyName("groupUuid")]
    public string? GroupUuid { get; set; }

    /// <summary>
    /// 设备图标。
    /// </summary>
    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    /// <summary>
    /// 设备的简介。
    /// </summary>
    [JsonPropertyName("introduction")]
    public string? Introduction { get; set; }

    /// <summary>
    /// 角色标识。
    /// </summary>
    [JsonPropertyName("roleUuid")]
    public string? RoleUuid { get; set; }

    /// <summary>
    /// 设备管理员的userId。
    /// </summary>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; } = [];

    /// <summary>
    /// 状态标识。 1：新建 2：激活 3：注册 说明 设备注册失败，不返回该字段。
    /// </summary>
    [JsonPropertyName("status")]
    public long? Status { get; set; }

    /// <summary>
    /// 设备型号。
    /// </summary>
    [JsonPropertyName("typeUuid")]
    public string? TypeUuid { get; set; }

    /// <summary>
    /// 钉钉侧设备标识。
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    /// <summary>
    /// 设备分类。 0：设备 1：助手
    /// </summary>
    [JsonPropertyName("deviceCategory")]
    public long? DeviceCategory { get; set; }
}

/// <summary>
/// DeviceManagementCustomersDevicesRegistrationActivationsBatchPostResponseFailItemsItem
/// </summary>
public class DeviceManagementCustomersDevicesRegistrationActivationsBatchPostResponseFailItemsItem
{
    /// <summary>
    /// 错误码。
    /// </summary>
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }

    /// <summary>
    /// 错误信息。
    /// </summary>
    [JsonPropertyName("errorMsg")]
    public string? ErrorMsg { get; set; }

    /// <summary>
    /// 设备信息。
    /// </summary>
    [JsonPropertyName("result")]
    public DeviceManagementCustomersDevicesRegistrationActivationsBatchPostResponseFailItemsItemResult? Result { get; set; }

    /// <summary>
    /// 设备注册是否成功。 true：成功 false：失败
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 批量注册与激活设备响应
/// </summary>
public class DeviceManagementCustomersDevicesRegistrationActivationsBatchPostResponse
{
    /// <summary>
    /// 注册成功的设备列表。
    /// </summary>
    [JsonPropertyName("successItems")]
    public List<DeviceManagementCustomersDevicesRegistrationActivationsBatchPostResponseSuccessItemsItem> SuccessItems { get; set; } = [];

    /// <summary>
    /// 接口调用是否成功。 true：成功 false：失败
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 注册失败的设备列表。
    /// </summary>
    [JsonPropertyName("failItems")]
    public List<DeviceManagementCustomersDevicesRegistrationActivationsBatchPostResponseFailItemsItem> FailItems { get; set; } = [];
}

/// <summary>
/// DeviceManagementCustomersDevicesActivationsInfosGetResponseResultItem
/// </summary>
public class DeviceManagementCustomersDevicesActivationsInfosGetResponseResultItem
{
    /// <summary>
    /// 拓展信息。 说明 该字段暂时返回为空。
    /// </summary>
    [JsonPropertyName("bizExt")]
    public string? BizExt { get; set; }

    /// <summary>
    /// 设备回调链接。
    /// </summary>
    [JsonPropertyName("deviceCallbackUrl")]
    public string? DeviceCallbackUrl { get; set; }

    /// <summary>
    /// 设备编号。
    /// </summary>
    [JsonPropertyName("deviceCode")]
    public string? DeviceCode { get; set; }

    /// <summary>
    /// 设备详情链接。
    /// </summary>
    [JsonPropertyName("deviceDetailUrl")]
    public string? DeviceDetailUrl { get; set; }

    /// <summary>
    /// 设备名称。
    /// </summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>
    /// 设备分组标识。
    /// </summary>
    [JsonPropertyName("groupUuid")]
    public string? GroupUuid { get; set; }

    /// <summary>
    /// 设备标题。 说明 该字段暂无使用场景。
    /// </summary>
    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    /// <summary>
    /// 设备的简介。
    /// </summary>
    [JsonPropertyName("introduction")]
    public string? Introduction { get; set; }

    /// <summary>
    /// 设备型号。
    /// </summary>
    [JsonPropertyName("typeUuid")]
    public string? TypeUuid { get; set; }

    /// <summary>
    /// 钉钉侧设备标识。
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    /// <summary>
    /// 设备分类。 0：设备 1：助手
    /// </summary>
    [JsonPropertyName("deviceCategory")]
    public long? DeviceCategory { get; set; }
}

/// <summary>
/// 查询已经注册的设备信息响应
/// </summary>
public class DeviceManagementCustomersDevicesActivationsInfosGetResponse
{
    /// <summary>
    /// 返回总数。
    /// </summary>
    [JsonPropertyName("totalCount")]
    public long? TotalCount { get; set; }

    /// <summary>
    /// 接口调用是否成功。 true：成功 false：失败
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 返回的设备列表。
    /// </summary>
    [JsonPropertyName("result")]
    public List<DeviceManagementCustomersDevicesActivationsInfosGetResponseResultItem> Result { get; set; } = [];
}

/// <summary>
/// 获取报修记录请求
/// </summary>
public class DeviceManagementCustomersDevicesMaintainInfosQueryPostRequest
{
    /// <summary>
    /// 设备uuIi列表，最大值10。 企业内部应用，调用查询已经注册的设备信息接口获取的uuid。 第三方企业应用，调用查询已经注册的设备信息接口获取的uuid。
    /// </summary>
    [JsonPropertyName("deviceUuid")]
    public List<string> DeviceUuid { get; set; } = [];
}

/// <summary>
/// DeviceManagementCustomersDevicesMaintainInfosQueryPostResponseResultItem
/// </summary>
public class DeviceManagementCustomersDevicesMaintainInfosQueryPostResponseResultItem
{
    /// <summary>
    /// 报修时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("gmtCreate")]
    public string? GmtCreate { get; set; }

    /// <summary>
    /// 报修设备码。
    /// </summary>
    [JsonPropertyName("deviceCode")]
    public string? DeviceCode { get; set; }

    /// <summary>
    /// 设备名称。
    /// </summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>
    /// 报修单内填写的异常描述。
    /// </summary>
    [JsonPropertyName("remark")]
    public string? Remark { get; set; }

    /// <summary>
    /// 报修人姓名列表。
    /// </summary>
    [JsonPropertyName("maintenanceStaff")]
    public List<string> MaintenanceStaff { get; set; } = [];

    /// <summary>
    /// 处理结果。 0：同意 1：拒绝 2：终止 3：删除 4：进行中
    /// </summary>
    [JsonPropertyName("processState")]
    public long? ProcessState { get; set; }

    /// <summary>
    /// 处理时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("handleTime")]
    public string? HandleTime { get; set; }
}

/// <summary>
/// 获取报修记录响应
/// </summary>
public class DeviceManagementCustomersDevicesMaintainInfosQueryPostResponse
{
    /// <summary>
    /// 总共的数量。
    /// </summary>
    [JsonPropertyName("totalCount")]
    public long? TotalCount { get; set; }

    /// <summary>
    /// 是否成功，true表示成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 返回的结果列表。
    /// </summary>
    [JsonPropertyName("result")]
    public List<DeviceManagementCustomersDevicesMaintainInfosQueryPostResponseResultItem> Result { get; set; } = [];
}

/// <summary>
/// 获取巡检或保养记录请求
/// </summary>
public class DeviceManagementCustomersDevicesInspectInfosQueryPostRequest
{
    /// <summary>
    /// 设备uuIi列表，最大值10。 企业内部应用，调用查询已经注册的设备信息接口获取的uuid。 第三方企业应用，调用查询已经注册的设备信息接口获取的uuid。
    /// </summary>
    [JsonPropertyName("deviceUuid")]
    public List<string> DeviceUuid { get; set; } = [];

    /// <summary>
    /// 类型。 inspect：巡检 protect：保养
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// DeviceManagementCustomersDevicesInspectInfosQueryPostResponseResultItem
/// </summary>
public class DeviceManagementCustomersDevicesInspectInfosQueryPostResponseResultItem
{
    /// <summary>
    /// 设备名称。
    /// </summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>
    /// 设备码。
    /// </summary>
    [JsonPropertyName("deviceCode")]
    public string? DeviceCode { get; set; }

    /// <summary>
    /// 类型。 inspect：巡检 protect：保养
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// 巡检或者保养结果。 0：正常 1：异常
    /// </summary>
    [JsonPropertyName("status")]
    public long? Status { get; set; }

    /// <summary>
    /// 处理结果。 1：未修复 2：已修复
    /// </summary>
    [JsonPropertyName("repairStatus")]
    public long? RepairStatus { get; set; }

    /// <summary>
    /// 维修人员姓名列表。
    /// </summary>
    [JsonPropertyName("maintenanceStaff")]
    public List<string> MaintenanceStaff { get; set; } = [];

    /// <summary>
    /// 处理时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("handleTime")]
    public string? HandleTime { get; set; }

    /// <summary>
    /// 巡检或保养表填写的内容。
    /// </summary>
    [JsonPropertyName("remark")]
    public string? Remark { get; set; }

    /// <summary>
    /// 巡检表或者保养表的名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 创建时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("gmtCreate")]
    public string? GmtCreate { get; set; }
}

/// <summary>
/// 获取巡检或保养记录响应
/// </summary>
public class DeviceManagementCustomersDevicesInspectInfosQueryPostResponse
{
    /// <summary>
    /// 总共数量。
    /// </summary>
    [JsonPropertyName("totalCount")]
    public long? TotalCount { get; set; }

    /// <summary>
    /// 是否成功，true表示成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 返回的结果列表。
    /// </summary>
    [JsonPropertyName("result")]
    public List<DeviceManagementCustomersDevicesInspectInfosQueryPostResponseResultItem> Result { get; set; } = [];
}

/// <summary>
/// ServiceGroupMessagesTasksSendPostRequestMessageContentBtnsItem
/// </summary>
public class ServiceGroupMessagesTasksSendPostRequestMessageContentBtnsItem
{
    /// <summary>
    /// 按钮链接。
    /// </summary>
    [JsonPropertyName("actionURL")]
    public string? ActionURL { get; set; }

    /// <summary>
    /// 按钮标题。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// 群发内容。
/// </summary>
public class ServiceGroupMessagesTasksSendPostRequestMessageContent
{
    /// <summary>
    /// 消息类型，取值： MARKDOWN：markdowm消息 ACTIONCARD：卡片消息 NOTICE：群公告
    /// </summary>
    [JsonPropertyName("messageType")]
    public string? MessageType { get; set; }

    /// <summary>
    /// 标题。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 消息内容。
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// 图片。
    /// </summary>
    [JsonPropertyName("images")]
    public List<string> Images { get; set; } = [];

    /// <summary>
    /// 按钮列表。
    /// </summary>
    [JsonPropertyName("btns")]
    public List<ServiceGroupMessagesTasksSendPostRequestMessageContentBtnsItem> Btns { get; set; } = [];
}

/// <summary>
/// 查询条件。
/// </summary>
public class ServiceGroupMessagesTasksSendPostRequestQueryGroup
{
    /// <summary>
    /// 群发圈选类型，取值： AIMED：精准圈选 MULTI_CONDITIONS：多条件圈选
    /// </summary>
    [JsonPropertyName("queryType")]
    public string? QueryType { get; set; }

    /// <summary>
    /// 单个会话ID。
    /// </summary>
    [JsonPropertyName("openConversationIds")]
    public List<string> OpenConversationIds { get; set; } = [];

    /// <summary>
    /// 最近活跃时间的开始时间。
    /// </summary>
    [JsonPropertyName("lastActiveTimeStart")]
    public string? LastActiveTimeStart { get; set; }

    /// <summary>
    /// 最近活跃时间的结束时间。
    /// </summary>
    [JsonPropertyName("lastActiveTimeEnd")]
    public string? LastActiveTimeEnd { get; set; }

    /// <summary>
    /// 活跃日期筛选类型，取值： ACTIVE：活跃 NOTACTIVE：不活跃
    /// </summary>
    [JsonPropertyName("lastActiveDateFilterType")]
    public string? LastActiveDateFilterType { get; set; }

    /// <summary>
    /// 群标签。
    /// </summary>
    [JsonPropertyName("groupTagNames")]
    public List<string> GroupTagNames { get; set; } = [];

    /// <summary>
    /// 群分组ID。
    /// </summary>
    [JsonPropertyName("openGroupSetId")]
    public string? OpenGroupSetId { get; set; }
}

/// <summary>
/// ServiceGroupMessagesTasksSendPostRequestSendConfigUrlTrackConfigItem
/// </summary>
public class ServiceGroupMessagesTasksSendPostRequestSendConfigUrlTrackConfigItem
{
    /// <summary>
    /// 跟踪链接URL。
    /// </summary>
    [JsonPropertyName("trackUrl")]
    public string? TrackUrl { get; set; }

    /// <summary>
    /// 跟踪链接的标题。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 跟踪链接的唯一标识，sg开头。
    /// </summary>
    [JsonPropertyName("trackId")]
    public string? TrackId { get; set; }
}

/// <summary>
/// 发送配置。
/// </summary>
public class ServiceGroupMessagesTasksSendPostRequestSendConfig
{
    /// <summary>
    /// 发送类型，取值： TIMING：定时执行 INSTANT：立即执行
    /// </summary>
    [JsonPropertyName("sendType")]
    public string? SendType { get; set; }

    /// <summary>
    /// 执行时间。 **说明** 当**sendType**的值为**TIMING**时传入
    /// </summary>
    [JsonPropertyName("sendTime")]
    public string? SendTime { get; set; }

    /// <summary>
    /// 只有needUrlTrack取值true时，才需要进行链接跟踪配置。
    /// </summary>
    [JsonPropertyName("urlTrackConfig")]
    public List<ServiceGroupMessagesTasksSendPostRequestSendConfigUrlTrackConfigItem> UrlTrackConfig { get; set; } = [];
}

/// <summary>
/// 群发任务请求
/// </summary>
public class ServiceGroupMessagesTasksSendPostRequest
{
    /// <summary>
    /// 团队ID。
    /// </summary>
    [JsonPropertyName("openTeamId")]
    public string? OpenTeamId { get; set; }

    /// <summary>
    /// 群发任务名称。
    /// </summary>
    [JsonPropertyName("taskName")]
    public string? TaskName { get; set; }

    /// <summary>
    /// 群发内容。
    /// </summary>
    [JsonPropertyName("messageContent")]
    public ServiceGroupMessagesTasksSendPostRequestMessageContent? MessageContent { get; set; }

    /// <summary>
    /// 查询条件。
    /// </summary>
    [JsonPropertyName("queryGroup")]
    public ServiceGroupMessagesTasksSendPostRequestQueryGroup? QueryGroup { get; set; }

    /// <summary>
    /// 发送配置。
    /// </summary>
    [JsonPropertyName("sendConfig")]
    public ServiceGroupMessagesTasksSendPostRequestSendConfig? SendConfig { get; set; }
}

/// <summary>
/// 群发任务响应
/// </summary>
public class ServiceGroupMessagesTasksSendPostResponse
{
    /// <summary>
    /// 开放群发任务ID。
    /// </summary>
    [JsonPropertyName("openBatchTaskId")]
    public string? OpenBatchTaskId { get; set; }
}

/// <summary>
/// ServiceGroupMessagesSendPostRequestBtnsItem
/// </summary>
public class ServiceGroupMessagesSendPostRequestBtnsItem
{
    /// <summary>
    /// 按钮跳转地址。
    /// </summary>
    [JsonPropertyName("actionURL")]
    public string? ActionURL { get; set; }

    /// <summary>
    /// 按钮名称。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// 发送服务群消息请求
/// </summary>
public class ServiceGroupMessagesSendPostRequest
{
    /// <summary>
    /// 开放群ID。 调用创建服务群接口获取。
    /// </summary>
    [JsonPropertyName("targetOpenConversationId")]
    public string? TargetOpenConversationId { get; set; }

    /// <summary>
    /// 标题。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 消息内容。
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// 被@人的手机号列表。
    /// </summary>
    [JsonPropertyName("atMobiles")]
    public List<string> AtMobiles { get; set; } = [];

    /// <summary>
    /// 被@人的dingtalkId列表。
    /// </summary>
    [JsonPropertyName("atDingtalkIds")]
    public List<string> AtDingtalkIds { get; set; } = [];

    /// <summary>
    /// 被@人的unionId列表。
    /// </summary>
    [JsonPropertyName("atUnionIds")]
    public List<string> AtUnionIds { get; set; } = [];

    /// <summary>
    /// 手机号接收者列表。
    /// </summary>
    [JsonPropertyName("receiverMobiles")]
    public List<string> ReceiverMobiles { get; set; } = [];

    /// <summary>
    /// dingtalkId接收者列表。
    /// </summary>
    [JsonPropertyName("receiverDingtalkIds")]
    public List<string> ReceiverDingtalkIds { get; set; } = [];

    /// <summary>
    /// unionId接收者列表。
    /// </summary>
    [JsonPropertyName("receiverUnionIds")]
    public List<string> ReceiverUnionIds { get; set; } = [];

    /// <summary>
    /// 消息类型，取值。
    /// </summary>
    [JsonPropertyName("messageType")]
    public string? MessageType { get; set; }

    /// <summary>
    /// 排列方式，取值。
    /// </summary>
    [JsonPropertyName("btnOrientation")]
    public string? BtnOrientation { get; set; }

    /// <summary>
    /// actionCard按钮。
    /// </summary>
    [JsonPropertyName("btns")]
    public List<ServiceGroupMessagesSendPostRequestBtnsItem> Btns { get; set; } = [];
}

/// <summary>
/// 发送服务群消息响应
/// </summary>
public class ServiceGroupMessagesSendPostResponse
{
    /// <summary>
    /// 开放消息任务ID。
    /// </summary>
    [JsonPropertyName("openMsgTaskId")]
    public string? OpenMsgTaskId { get; set; }
}

/// <summary>
/// 创建场景服务群请求
/// </summary>
public class ServiceGroupGroupsPostRequest
{
    /// <summary>
    /// 业务关联ID。
    /// </summary>
    [JsonPropertyName("groupBizId")]
    public string? GroupBizId { get; set; }

    /// <summary>
    /// 开放团队ID。
    /// </summary>
    [JsonPropertyName("openTeamId")]
    public string? OpenTeamId { get; set; }

    /// <summary>
    /// 开放群组ID。
    /// </summary>
    [JsonPropertyName("openGroupSetId")]
    public string? OpenGroupSetId { get; set; }

    /// <summary>
    /// 群名称。
    /// </summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    /// <summary>
    /// 群主员工userid。
    /// </summary>
    [JsonPropertyName("ownerStaffId")]
    public string? OwnerStaffId { get; set; }

    /// <summary>
    /// 群成员员工ID列表。
    /// </summary>
    [JsonPropertyName("memberStaffIds")]
    public List<string> MemberStaffIds { get; set; } = [];

    /// <summary>
    /// 群标签。
    /// </summary>
    [JsonPropertyName("groupTagNames")]
    public List<string> GroupTagNames { get; set; } = [];
}

/// <summary>
/// 创建场景服务群响应
/// </summary>
public class ServiceGroupGroupsPostResponse
{
    /// <summary>
    /// 开放群ID。
    /// </summary>
    [JsonPropertyName("openConversationId")]
    public string? OpenConversationId { get; set; }

    /// <summary>
    /// 加群的url。
    /// </summary>
    [JsonPropertyName("groupUrl")]
    public string? GroupUrl { get; set; }
}

/// <summary>
/// 添加服务群成员请求
/// </summary>
public class ServiceGroupGroupsMembersPostRequest
{
    /// <summary>
    /// 开放团队ID。如下图所示，查看**ID信息**内的**团队ID**值。 
    /// </summary>
    [JsonPropertyName("openTeamId")]
    public string? OpenTeamId { get; set; }

    /// <summary>
    /// 服务群openConversionId，调用创建场景服务群接口获取openConversationId参数值。
    /// </summary>
    [JsonPropertyName("openConversationId")]
    public string? OpenConversationId { get; set; }

    /// <summary>
    /// 待添加员工在钉钉组织内的的userId列表，最大值100。 说明 请确保userId值的正确性，如果userId值不正确，该接口不会报错，添加时会自动忽略该成员。
    /// </summary>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; } = [];
}

/// <summary>
/// 添加服务群成员响应
/// </summary>
public class ServiceGroupGroupsMembersPostResponse
{
    /// <summary>
    /// 添加是否成功，true表示成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 查询服务群活跃用户请求
/// </summary>
public class ServiceGroupGroupsQueryActiveUsersGetRequest
{
}

/// <summary>
/// ServiceGroupGroupsQueryActiveUsersGetResponseActiveUserInfosItem
/// </summary>
public class ServiceGroupGroupsQueryActiveUsersGetResponseActiveUserInfosItem
{
    /// <summary>
    /// 用户unionId。
    /// </summary>
    [JsonPropertyName("unionId")]
    public string? UnionId { get; set; }

    /// <summary>
    /// 昵称。
    /// </summary>
    [JsonPropertyName("nickName")]
    public string? NickName { get; set; }

    /// <summary>
    /// 最近一周的行为指数。
    /// </summary>
    [JsonPropertyName("actionIndexL7d")]
    public Dictionary<string, object?>? ActionIndexL7d { get; set; } = [];

    /// <summary>
    /// 最近二周的行为指数。
    /// </summary>
    [JsonPropertyName("actionIndexL14d")]
    public Dictionary<string, object?>? ActionIndexL14d { get; set; } = [];

    /// <summary>
    /// 最近一个月的行为指数。
    /// </summary>
    [JsonPropertyName("actionIndexL30d")]
    public Dictionary<string, object?>? ActionIndexL30d { get; set; } = [];

    /// <summary>
    /// 活跃度。
    /// </summary>
    [JsonPropertyName("activeScore")]
    public Dictionary<string, object?>? ActiveScore { get; set; } = [];

    /// <summary>
    /// 排名。
    /// </summary>
    [JsonPropertyName("ranking")]
    public long? Ranking { get; set; }
}

/// <summary>
/// 查询服务群活跃用户响应
/// </summary>
public class ServiceGroupGroupsQueryActiveUsersGetResponse
{
    /// <summary>
    /// 活跃用户列表。
    /// </summary>
    [JsonPropertyName("activeUserInfos")]
    public List<ServiceGroupGroupsQueryActiveUsersGetResponseActiveUserInfosItem> ActiveUserInfos { get; set; } = [];
}

/// <summary>
/// 更换服务群所在的群分组请求
/// </summary>
public class ServiceGroupGroupsConfigurationsPutRequest
{
    /// <summary>
    /// 开放团队ID。
    /// </summary>
    [JsonPropertyName("openTeamId")]
    public string? OpenTeamId { get; set; }

    /// <summary>
    /// 开放群ID，可调用创建服务群接口获取openConversationId参数值。
    /// </summary>
    [JsonPropertyName("openConversationId")]
    public string? OpenConversationId { get; set; }

    /// <summary>
    /// 开放群组ID。
    /// </summary>
    [JsonPropertyName("openGroupSetId")]
    public string? OpenGroupSetId { get; set; }
}

/// <summary>
/// 更换服务群所在的群分组响应
/// </summary>
public class ServiceGroupGroupsConfigurationsPutResponse
{
    /// <summary>
    /// 更新是否成功，true表示更新成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 升级普通群为服务群请求
/// </summary>
public class ServiceGroupNormalGroupsUpgradePostRequest
{
    /// <summary>
    /// 升级的目标群组ID。
    /// </summary>
    [JsonPropertyName("openGroupSetId")]
    public string? OpenGroupSetId { get; set; }

    /// <summary>
    /// 升级的目标群模板ID。
    /// </summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }

    /// <summary>
    /// 群ID。
    /// </summary>
    [JsonPropertyName("openConversationId")]
    public string? OpenConversationId { get; set; }

    /// <summary>
    /// 升级的目标团队ID。
    /// </summary>
    [JsonPropertyName("openTeamId")]
    public string? OpenTeamId { get; set; }
}

/// <summary>
/// 升级云客服服务群为钉钉智能服务群请求
/// </summary>
public class ServiceGroupCloudGroupsUpgradePostRequest
{
    /// <summary>
    /// 群ID。
    /// </summary>
    [JsonPropertyName("openConversationId")]
    public string? OpenConversationId { get; set; }

    /// <summary>
    /// 升级的目标群模板ID。
    /// </summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }

    /// <summary>
    /// 升级的目标群组ID。
    /// </summary>
    [JsonPropertyName("openGroupSetId")]
    public string? OpenGroupSetId { get; set; }

    /// <summary>
    /// 智能云客服租户ID。
    /// </summary>
    [JsonPropertyName("ccsInstanceId")]
    public string? CcsInstanceId { get; set; }

    /// <summary>
    /// 升级的目标团队ID。
    /// </summary>
    [JsonPropertyName("openTeamId")]
    public string? OpenTeamId { get; set; }
}

/// <summary>
/// 自定义校区或部门信息。
/// </summary>
public class EduCustomDeptsPostRequestCustomDept
{
    /// <summary>
    /// 部门类型，取值：
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// 自定义校区或部门名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// 创建自定义校区或部门请求
/// </summary>
public class EduCustomDeptsPostRequest
{
    /// <summary>
    /// 自定义校区或部门信息。
    /// </summary>
    [JsonPropertyName("customDept")]
    public EduCustomDeptsPostRequestCustomDept? CustomDept { get; set; }

    /// <summary>
    /// 上级部门ID。 如果type取值为custom_campus时，必须为-7。
    /// </summary>
    [JsonPropertyName("superId")]
    public long? SuperId { get; set; }

    /// <summary>
    /// 操作人userid。
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary>
/// 返回结果。
/// </summary>
public class EduCustomDeptsPostResponseResult
{
    /// <summary>
    /// 校区或部门ID。
    /// </summary>
    [JsonPropertyName("deptId")]
    public long? DeptId { get; set; }
}

/// <summary>
/// 创建自定义校区或部门响应
/// </summary>
public class EduCustomDeptsPostResponse
{
    /// <summary>
    /// 调用结果。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 返回结果。
    /// </summary>
    [JsonPropertyName("result")]
    public EduCustomDeptsPostResponseResult? Result { get; set; }
}

/// <summary>
/// 删除家校部门响应
/// </summary>
public class EduDeptsDeptIdDeleteResponse
{
    /// <summary>
    /// 调用结果。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 班级信息。
/// </summary>
public class EduCustomClassesPostRequestCustomClass
{
    /// <summary>
    /// 班级名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// 创建自定义部门下的班级请求
/// </summary>
public class EduCustomClassesPostRequest
{
    /// <summary>
    /// 班级信息。
    /// </summary>
    [JsonPropertyName("customClass")]
    public EduCustomClassesPostRequestCustomClass? CustomClass { get; set; }

    /// <summary>
    /// 上级部门ID。
    /// </summary>
    [JsonPropertyName("superId")]
    public long? SuperId { get; set; }

    /// <summary>
    /// 操作人userid。
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary>
/// 返回结果。
/// </summary>
public class EduCustomClassesPostResponseResult
{
    /// <summary>
    /// 班级ID。
    /// </summary>
    [JsonPropertyName("deptId")]
    public long? DeptId { get; set; }
}

/// <summary>
/// 创建自定义部门下的班级响应
/// </summary>
public class EduCustomClassesPostResponse
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    [JsonPropertyName("result")]
    public EduCustomClassesPostResponseResult? Result { get; set; }

    /// <summary>
    /// 调用结果。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 删除学生请求
/// </summary>
public class EduClassesClassIdStudentsUserIdDeleteRequest
{
}

/// <summary>
/// 删除学生响应
/// </summary>
public class EduClassesClassIdStudentsUserIdDeleteResponse
{
    /// <summary>
    /// 调用结果。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 删除家长关系响应
/// </summary>
public class EduClassesClassIdGuardiansUserIdDeleteResponse
{
    /// <summary>
    /// 调用结果。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 删除老师响应
/// </summary>
public class EduClassesClassIdTeachersUserIdDeleteResponse
{
    /// <summary>
    /// 调用结果。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 学生调班请求
/// </summary>
public class EduStudentsMovePostRequest
{
    /// <summary>
    /// 操作者的userid，可调用通过免登码获取用户信息接口获取。
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// 学生的userid，可调用获取人员列表接口获取。
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    /// <summary>
    /// 原班级ID，可调用获取部门列表接口获取。
    /// </summary>
    [JsonPropertyName("originClassId")]
    public long? OriginClassId { get; set; }

    /// <summary>
    /// 目标班级ID，可调用获取部门列表接口获取。
    /// </summary>
    [JsonPropertyName("targetClassId")]
    public long? TargetClassId { get; set; }
}

/// <summary>
/// 学生调班响应
/// </summary>
public class EduStudentsMovePostResponse
{
    /// <summary>
    /// 调班是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// ResidentUsersIndustryRolesGetResponseRoleListItem
/// </summary>
public class ResidentUsersIndustryRolesGetResponseRoleListItem
{
    /// <summary>
    /// 角色ID。 说明 以下管理角色没有角色ID，即该参数为空。 super-admin：创建者 main-admin：主管理员 sub-admin：子管理员
    /// </summary>
    [JsonPropertyName("roleId")]
    public long? RoleId { get; set; }

    /// <summary>
    /// 角色名称。
    /// </summary>
    [JsonPropertyName("roleName")]
    public string? RoleName { get; set; }

    /// <summary>
    /// 角色编码。 说明 如果是自定义角色，该参数值为空。
    /// </summary>
    [JsonPropertyName("tagCode")]
    public string? TagCode { get; set; }
}

/// <summary>
/// 获取用户所在的行业角色信息响应
/// </summary>
public class ResidentUsersIndustryRolesGetResponse
{
    /// <summary>
    /// 角色列表。
    /// </summary>
    [JsonPropertyName("roleList")]
    public List<ResidentUsersIndustryRolesGetResponseRoleListItem> RoleList { get; set; } = [];
}

/// <summary>
/// 获取行业角色下的用户列表响应
/// </summary>
public class ResidentIndustryRolesUsersGetResponse
{
    /// <summary>
    /// 用户userId列表。
    /// </summary>
    [JsonPropertyName("userIdList")]
    public List<string> UserIdList { get; set; } = [];
}

/// <summary>
/// EduSchoolInitPostRequestCampusPeriodsItemGradesItem
/// </summary>
public class EduSchoolInitPostRequestCampusPeriodsItemGradesItem
{
    /// <summary>
    /// 年级级数，一年级为1，二年级为2。
    /// </summary>
    [JsonPropertyName("grade")]
    public string? Grade { get; set; }

    /// <summary>
    /// 年级名称，需要与grade和start_year对应。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 入学年份。请注意start_year、name、grade三者之间的关联关系。
    /// </summary>
    [JsonPropertyName("start_year")]
    public string? StartYear { get; set; }

    /// <summary>
    /// 每个年级下班级级数，1班为1，2班为2。0表示无限。尽量不要超过100个，否则页面性能有问题。
    /// </summary>
    [JsonPropertyName("classes")]
    public decimal? Classes { get; set; }
}

/// <summary>
/// EduSchoolInitPostRequestCampusPeriodsItem
/// </summary>
public class EduSchoolInitPostRequestCampusPeriodsItem
{
    /// <summary>
    /// 学段名称：幼儿园小学初中高中
    /// </summary>
    [JsonPropertyName("step")]
    public string? Step { get; set; }

    /// <summary>
    /// 年级列表，最大列表长度为999。
    /// </summary>
    [JsonPropertyName("grades")]
    public List<EduSchoolInitPostRequestCampusPeriodsItemGradesItem> Grades { get; set; } = [];

    /// <summary>
    /// 学段编码：kindergarten ：幼儿园primary_school：小学middle_school： 初中high_school： 高中
    /// </summary>
    [JsonPropertyName("period_code")]
    public string? PeriodCode { get; set; }

    /// <summary>
    /// 学段名称类型：text：文本型，如初中为七年级，八年级，九年级。number：数字型，如初中一年级1班，二年级1班等。
    /// </summary>
    [JsonPropertyName("name_mode")]
    public string? NameMode { get; set; }
}

/// <summary>
/// 校区信息。
/// </summary>
public class EduSchoolInitPostRequestCampus
{
    /// <summary>
    /// 校区名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 学段列表。
    /// </summary>
    [JsonPropertyName("periods")]
    public List<EduSchoolInitPostRequestCampusPeriodsItem> Periods { get; set; } = [];
}

/// <summary>
/// 初始化家校架构请求
/// </summary>
public class EduSchoolInitPostRequest
{
    /// <summary>
    /// 校区信息。
    /// </summary>
    [JsonPropertyName("campus")]
    public EduSchoolInitPostRequestCampus? Campus { get; set; }

    /// <summary>
    /// 钉钉企业通讯录管理员。
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary>
/// 初始化结果。
/// </summary>
public class EduSchoolInitPostResponseResult
{
    /// <summary>
    /// 校区列表。
    /// </summary>
    [JsonPropertyName("campus_list")]
    public List<decimal> CampusList { get; set; } = [];

    /// <summary>
    /// 0：已经有校区，不会进行初始化校区。1：执行了初始化校区。
    /// </summary>
    [JsonPropertyName("effected")]
    public string? Effected { get; set; }
}

/// <summary>
/// 初始化家校架构响应
/// </summary>
public class EduSchoolInitPostResponse : DingTalkResult
{
    /// <summary>
    /// 初始化结果。
    /// </summary>
    [JsonPropertyName("result")]
    public EduSchoolInitPostResponseResult? Result { get; set; }

    /// <summary>
    /// 请求是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// EduPeriodCreatePostRequestOpenPeriodGradesItem
/// </summary>
public class EduPeriodCreatePostRequestOpenPeriodGradesItem
{
    /// <summary>
    /// 年级级数，一年级为1，二年级为2。
    /// </summary>
    [JsonPropertyName("grade")]
    public string? Grade { get; set; }

    /// <summary>
    /// 每个年级下班级级数，1班为1，2班为2。0表示无限。尽量不要超过100个，否则页面性能有问题。
    /// </summary>
    [JsonPropertyName("classes")]
    public decimal? Classes { get; set; }

    /// <summary>
    /// 年级名称，需要与grade和start_year对应。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 入学年份。请注意start_year、name、grade三者之间的关联关系。
    /// </summary>
    [JsonPropertyName("start_year")]
    public string? StartYear { get; set; }
}

/// <summary>
/// 学段信息。
/// </summary>
public class EduPeriodCreatePostRequestOpenPeriod
{
    /// <summary>
    /// 学段名称：幼儿园小学初中高中
    /// </summary>
    [JsonPropertyName("step")]
    public string? Step { get; set; }

    /// <summary>
    /// 年级列表，最大列表长度为999。
    /// </summary>
    [JsonPropertyName("grades")]
    public List<EduPeriodCreatePostRequestOpenPeriodGradesItem> Grades { get; set; } = [];

    /// <summary>
    /// 学段编码：kindergarten ：幼儿园primary_school：小学middle_school： 初中high_school： 高中
    /// </summary>
    [JsonPropertyName("period_code")]
    public string? PeriodCode { get; set; }

    /// <summary>
    /// 学段名称类型：text：文本型，如初中为七年级，八年级，九年级。number：数字型，如初中一年级1班，二年级1班等。
    /// </summary>
    [JsonPropertyName("name_mode")]
    public string? NameMode { get; set; }
}

/// <summary>
/// 创建学段请求
/// </summary>
public class EduPeriodCreatePostRequest
{
    /// <summary>
    /// 校区ID。
    /// </summary>
    [JsonPropertyName("super_id")]
    public decimal? SuperId { get; set; }

    /// <summary>
    /// 钉钉管理员。
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// 学段信息。
    /// </summary>
    [JsonPropertyName("open_period")]
    public EduPeriodCreatePostRequestOpenPeriod? OpenPeriod { get; set; }
}

/// <summary>
/// EduPeriodCreatePostResponseResultGradesItem
/// </summary>
public class EduPeriodCreatePostResponseResultGradesItem
{
    /// <summary>
    /// 校区ID。
    /// </summary>
    [JsonPropertyName("campus_id")]
    public decimal? CampusId { get; set; }

    /// <summary>
    /// 年级ID。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public decimal? DeptId { get; set; }

    /// <summary>
    /// 年级级数，一年级为1，二年级为2。
    /// </summary>
    [JsonPropertyName("grade")]
    public decimal? Grade { get; set; }

    /// <summary>
    /// 年级名。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 学段ID。
    /// </summary>
    [JsonPropertyName("super_id")]
    public decimal? SuperId { get; set; }
}

/// <summary>
/// 调用结果。
/// </summary>
public class EduPeriodCreatePostResponseResult
{
    /// <summary>
    /// 学段ID。
    /// </summary>
    [JsonPropertyName("deptId")]
    public decimal? DeptId { get; set; }

    /// <summary>
    /// 年级列表。
    /// </summary>
    [JsonPropertyName("grades")]
    public List<EduPeriodCreatePostResponseResultGradesItem> Grades { get; set; } = [];
}

/// <summary>
/// 创建学段响应
/// </summary>
public class EduPeriodCreatePostResponse : DingTalkResult
{
    /// <summary>
    /// 调用结果。
    /// </summary>
    [JsonPropertyName("result")]
    public EduPeriodCreatePostResponseResult? Result { get; set; }

    /// <summary>
    /// 请求是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 年级信息。
/// </summary>
public class EduGradeCreatePostRequestOpenGrade
{
    /// <summary>
    /// 年级级数，一年级为1，二年级为2。
    /// </summary>
    [JsonPropertyName("grade")]
    public string? Grade { get; set; }

    /// <summary>
    /// 每个年级下班级级数，1班为1，2班为2。0表示无限。尽量不要超过100个，否则页面性能有问题。
    /// </summary>
    [JsonPropertyName("classes")]
    public decimal? Classes { get; set; }

    /// <summary>
    /// 年级名称，需要与grade和start_year对应。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 入学年份。请注意start_year、name、grade三者之间的关联关系。
    /// </summary>
    [JsonPropertyName("start_year")]
    public string? StartYear { get; set; }
}

/// <summary>
/// 创建年级请求
/// </summary>
public class EduGradeCreatePostRequest
{
    /// <summary>
    /// 年级信息。
    /// </summary>
    [JsonPropertyName("open_grade")]
    public EduGradeCreatePostRequestOpenGrade? OpenGrade { get; set; }

    /// <summary>
    /// 学段ID。
    /// </summary>
    [JsonPropertyName("super_id")]
    public decimal? SuperId { get; set; }

    /// <summary>
    /// 钉钉企业管理员。
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary>
/// 调用结果。
/// </summary>
public class EduGradeCreatePostResponseResult
{
    /// <summary>
    /// 年级ID。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public decimal? DeptId { get; set; }
}

/// <summary>
/// 创建年级响应
/// </summary>
public class EduGradeCreatePostResponse : DingTalkResult
{
    /// <summary>
    /// 调用结果。
    /// </summary>
    [JsonPropertyName("result")]
    public EduGradeCreatePostResponseResult? Result { get; set; }

    /// <summary>
    /// 请求是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 班级信息。
/// </summary>
public class EduClassCreatePostRequestOpenClass
{
    /// <summary>
    /// 班级nick。
    /// </summary>
    [JsonPropertyName("nick")]
    public string? Nick { get; set; }

    /// <summary>
    /// 是否只展现nick。
    /// </summary>
    [JsonPropertyName("only_use_nick")]
    public string? OnlyUseNick { get; set; }

    /// <summary>
    /// 班级名。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 每个年级下班级级数，1班为1，2班为2。
    /// </summary>
    [JsonPropertyName("class_level")]
    public decimal? ClassLevel { get; set; }
}

/// <summary>
/// 创建班级请求
/// </summary>
public class EduClassCreatePostRequest
{
    /// <summary>
    /// 班级信息。
    /// </summary>
    [JsonPropertyName("open_class")]
    public EduClassCreatePostRequestOpenClass? OpenClass { get; set; }

    /// <summary>
    /// 年级ID。
    /// </summary>
    [JsonPropertyName("super_id")]
    public decimal? SuperId { get; set; }

    /// <summary>
    /// 钉钉企业管理员。
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary>
/// 调用结果。
/// </summary>
public class EduClassCreatePostResponseResult
{
    /// <summary>
    /// 班级ID。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public decimal? DeptId { get; set; }
}

/// <summary>
/// 创建班级响应
/// </summary>
public class EduClassCreatePostResponse : DingTalkResult
{
    /// <summary>
    /// 调用结果。
    /// </summary>
    [JsonPropertyName("result")]
    public EduClassCreatePostResponseResult? Result { get; set; }

    /// <summary>
    /// 请求是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 添加学生请求
/// </summary>
public class EduStudentCreatePostRequest
{
    /// <summary>
    /// 班级ID。
    /// </summary>
    [JsonPropertyName("class_id")]
    public decimal? ClassId { get; set; }

    /// <summary>
    /// 学生姓名。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 业务的唯一ID。
    /// </summary>
    [JsonPropertyName("biz_id")]
    public string? BizId { get; set; }

    /// <summary>
    /// 学生学号。
    /// </summary>
    [JsonPropertyName("student_no")]
    public string? StudentNo { get; set; }

    /// <summary>
    /// 钉钉企业管理员。
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary>
/// 调用结果。
/// </summary>
public class EduStudentCreatePostResponseResult
{
    /// <summary>
    /// 业务的唯一ID。
    /// </summary>
    [JsonPropertyName("biz_id")]
    public string? BizId { get; set; }

    /// <summary>
    /// 学生的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }
}

/// <summary>
/// 添加学生响应
/// </summary>
public class EduStudentCreatePostResponse : DingTalkResult
{
    /// <summary>
    /// 调用结果。
    /// </summary>
    [JsonPropertyName("result")]
    public EduStudentCreatePostResponseResult? Result { get; set; }

    /// <summary>
    /// 请求是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 添加家长请求
/// </summary>
public class EduGuardianCreatePostRequest
{
    /// <summary>
    /// 班级ID。
    /// </summary>
    [JsonPropertyName("class_id")]
    public decimal? ClassId { get; set; }

    /// <summary>
    /// 学生ID。
    /// </summary>
    [JsonPropertyName("stu_id")]
    public string? StuId { get; set; }

    /// <summary>
    /// 手机号码。
    /// </summary>
    [JsonPropertyName("mobile")]
    public string? Mobile { get; set; }

    /// <summary>
    /// 业务ID。
    /// </summary>
    [JsonPropertyName("biz_id")]
    public string? BizId { get; set; }

    /// <summary>
    /// 钉钉企业管理员。
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// 家长与学生的关系：F：爸爸M：妈妈GF：爷爷GM：奶奶GFA：外公GMA：外婆U：叔叔A：阿姨B：哥哥S：姐姐O：其他
    /// </summary>
    [JsonPropertyName("relation")]
    public string? Relation { get; set; }
}

/// <summary>
/// 调用结果。
/// </summary>
public class EduGuardianCreatePostResponseResult
{
    /// <summary>
    /// 业务ID。
    /// </summary>
    [JsonPropertyName("biz_id")]
    public string? BizId { get; set; }

    /// <summary>
    /// 家长的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }
}

/// <summary>
/// 添加家长响应
/// </summary>
public class EduGuardianCreatePostResponse : DingTalkResult
{
    /// <summary>
    /// 调用结果。
    /// </summary>
    [JsonPropertyName("result")]
    public EduGuardianCreatePostResponseResult? Result { get; set; }

    /// <summary>
    /// 请求是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 添加老师请求
/// </summary>
public class EduTeacherCreatePostRequest
{
    /// <summary>
    /// 班级ID。
    /// </summary>
    [JsonPropertyName("class_id")]
    public decimal? ClassId { get; set; }

    /// <summary>
    /// 业务ID。
    /// </summary>
    [JsonPropertyName("biz_id")]
    public string? BizId { get; set; }

    /// <summary>
    /// 是否班主任：1：班主任0：非班主任
    /// </summary>
    [JsonPropertyName("adviser")]
    public decimal? Adviser { get; set; }

    /// <summary>
    /// 老师的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 钉钉企业管理员。
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }
}

/// <summary>
/// 调用结果。
/// </summary>
public class EduTeacherCreatePostResponseResult
{
    /// <summary>
    /// 业务ID。
    /// </summary>
    [JsonPropertyName("biz_id")]
    public string? BizId { get; set; }

    /// <summary>
    /// 老师的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }
}

/// <summary>
/// 添加老师响应
/// </summary>
public class EduTeacherCreatePostResponse : DingTalkResult
{
    /// <summary>
    /// 调用结果。
    /// </summary>
    [JsonPropertyName("result")]
    public EduTeacherCreatePostResponseResult? Result { get; set; }

    /// <summary>
    /// 请求是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 获取部门详情请求
/// </summary>
public class EduDeptGetPostRequest
{
    /// <summary>
    /// 家校部门ID，通过获取部门列表接口获取。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public decimal? DeptId { get; set; }
}

/// <summary>
/// 部门详情。
/// </summary>
public class EduDeptGetPostResponseResultDetail
{
    /// <summary>
    /// 部门别名。
    /// </summary>
    [JsonPropertyName("nick")]
    public string? Nick { get; set; }

    /// <summary>
    /// 节点链。从顶层节点到当前节点的中间节点，其内容不包含当前节点。
    /// </summary>
    [JsonPropertyName("chain")]
    public string? Chain { get; set; }

    /// <summary>
    /// 部门节点特有属性。
    /// </summary>
    [JsonPropertyName("feature")]
    public string? Feature { get; set; }

    /// <summary>
    /// 部门名。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 通讯录类型：classic：传统经典4层结构。校区/学段/年级/班级custom：自定义结构
    /// </summary>
    [JsonPropertyName("contact_type")]
    public string? ContactType { get; set; }

    /// <summary>
    /// 节点类型：campus：校区period：学段grade：年级class：班级dept：普通节点，没有业务含义，主用存在于自定义通讯录中
    /// </summary>
    [JsonPropertyName("dept_type")]
    public string? DeptType { get; set; }

    /// <summary>
    /// 部门ID。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public decimal? DeptId { get; set; }
}

/// <summary>
/// 返回结果。
/// </summary>
public class EduDeptGetPostResponseResult
{
    /// <summary>
    /// 部门详情。
    /// </summary>
    [JsonPropertyName("detail")]
    public EduDeptGetPostResponseResultDetail? Detail { get; set; }
}

/// <summary>
/// 获取部门详情响应
/// </summary>
public class EduDeptGetPostResponse : DingTalkResult
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    [JsonPropertyName("result")]
    public EduDeptGetPostResponseResult? Result { get; set; }

    /// <summary>
    /// 是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 获取部门列表请求
/// </summary>
public class EduDeptListPostRequest
{
    /// <summary>
    /// 每页大小，最大30。
    /// </summary>
    [JsonPropertyName("page_size")]
    public decimal? PageSize { get; set; }

    /// <summary>
    /// 页码，从1开始。
    /// </summary>
    [JsonPropertyName("page_no")]
    public decimal? PageNo { get; set; }

    /// <summary>
    /// 父部门节点ID，如果不填，则默认获取第一层级的部门节点。
    /// </summary>
    [JsonPropertyName("super_id")]
    public decimal? SuperId { get; set; }
}

/// <summary>
/// EduDeptListPostResponseResultDetailsItem
/// </summary>
public class EduDeptListPostResponseResultDetailsItem
{
    /// <summary>
    /// 节点别名。
    /// </summary>
    [JsonPropertyName("nick")]
    public string? Nick { get; set; }

    /// <summary>
    /// 节点链。从顶层节点到当前节点的中间节点，其内容不包含当前节点。
    /// </summary>
    [JsonPropertyName("chain")]
    public string? Chain { get; set; }

    /// <summary>
    /// 节点的其他业务属性。可JSON反序列化。
    /// </summary>
    [JsonPropertyName("feature")]
    public string? Feature { get; set; }

    /// <summary>
    /// 节点名。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 通讯录类型：classic：传统经典4层结构。校区/学段/年级/班级custom：自定义结构
    /// </summary>
    [JsonPropertyName("contact_type")]
    public string? ContactType { get; set; }

    /// <summary>
    /// 节点类型：campus：校区period：学段grade：年级class：班级dept：普通节点，没有业务含义，主用存在于自定义通讯录中
    /// </summary>
    [JsonPropertyName("dept_type")]
    public string? DeptType { get; set; }

    /// <summary>
    /// 节点ID。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public decimal? DeptId { get; set; }
}

/// <summary>
/// 返回结果。
/// </summary>
public class EduDeptListPostResponseResult
{
    /// <summary>
    /// 部门节点列表。
    /// </summary>
    [JsonPropertyName("details")]
    public List<EduDeptListPostResponseResultDetailsItem> Details { get; set; } = [];

    /// <summary>
    /// 是否有更多数据。
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// 父部门ID。
    /// </summary>
    [JsonPropertyName("super_id")]
    public decimal? SuperId { get; set; }
}

/// <summary>
/// 获取部门列表响应
/// </summary>
public class EduDeptListPostResponse : DingTalkResult
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    [JsonPropertyName("result")]
    public EduDeptListPostResponseResult? Result { get; set; }

    /// <summary>
    /// 是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 获取人员列表请求
/// </summary>
public class EduUserListPostRequest
{
    /// <summary>
    /// 最大30条，最小1条。
    /// </summary>
    [JsonPropertyName("page_size")]
    public decimal? PageSize { get; set; }

    /// <summary>
    /// 页码，从1开始。
    /// </summary>
    [JsonPropertyName("page_no")]
    public decimal? PageNo { get; set; }

    /// <summary>
    /// 家校人员角色：teacher：老师guardian：监护人student：学生
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>
    /// 班级ID。
    /// </summary>
    [JsonPropertyName("class_id")]
    public decimal? ClassId { get; set; }
}

/// <summary>
/// EduUserListPostResponseResultDetailsItem
/// </summary>
public class EduUserListPostResponseResultDetailsItem
{
    /// <summary>
    /// 班级ID。
    /// </summary>
    [JsonPropertyName("class_id")]
    public decimal? ClassId { get; set; }

    /// <summary>
    /// 家校人员角色：teacher：老师guardian：监护人student：学生
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>
    /// 不同角色的其他业务属性，可JSON反序列化。
    /// </summary>
    [JsonPropertyName("feature")]
    public string? Feature { get; set; }

    /// <summary>
    /// 只在老师角色下意义。1：班主任0：非班主任
    /// </summary>
    [JsonPropertyName("is_adviser")]
    public string? IsAdviser { get; set; }

    /// <summary>
    /// 学号，只有在学生角色下才有意义，并且需确认各个班级的设置，如果没有设置，则不会返回此字段。
    /// </summary>
    [JsonPropertyName("student_no")]
    public string? StudentNo { get; set; }

    /// <summary>
    /// 人员姓名。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 人员的unionid，无手机号的学生为""。
    /// </summary>
    [JsonPropertyName("unionid")]
    public string? Unionid { get; set; }

    /// <summary>
    /// 人员的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }
}

/// <summary>
/// 返回结果。
/// </summary>
public class EduUserListPostResponseResult
{
    /// <summary>
    /// 是否还有数据。
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// 人员身份列表。
    /// </summary>
    [JsonPropertyName("details")]
    public List<EduUserListPostResponseResultDetailsItem> Details { get; set; } = [];
}

/// <summary>
/// 获取人员列表响应
/// </summary>
public class EduUserListPostResponse : DingTalkResult
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    [JsonPropertyName("result")]
    public EduUserListPostResponseResult? Result { get; set; }

    /// <summary>
    /// 是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("")]
    public string? Value { get; set; }
}

/// <summary>
/// 获取人员详情请求
/// </summary>
public class EduUserGetPostRequest
{
    /// <summary>
    /// 班级ID。
    /// </summary>
    [JsonPropertyName("class_id")]
    public decimal? ClassId { get; set; }

    /// <summary>
    /// 家校人员角色：teacher：老师guardian：监护人student：学生
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>
    /// 人员userid。企业内部应用可通过根据手机号获取userid接口获取。第三方企业应用可通过获取部门用户接口获取。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }
}

/// <summary>
/// EduUserGetPostResponseResultDetailsItem
/// </summary>
public class EduUserGetPostResponseResultDetailsItem
{
    /// <summary>
    /// 班级ID。
    /// </summary>
    [JsonPropertyName("class_id")]
    public decimal? ClassId { get; set; }

    /// <summary>
    /// 家校人员角色：teacher: 老师guardian: 监护人student: 学生
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>
    /// 不同角色的其他业务属性，可JSON反序列化。
    /// </summary>
    [JsonPropertyName("feature")]
    public string? Feature { get; set; }

    /// <summary>
    /// 只在老师角色下意义。1：班主任0：表示非班主任
    /// </summary>
    [JsonPropertyName("is_adviser")]
    public string? IsAdviser { get; set; }

    /// <summary>
    /// 学号，只有在学生角色下才有意义。
    /// </summary>
    [JsonPropertyName("student_no")]
    public string? StudentNo { get; set; }

    /// <summary>
    /// 人员名。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 人员的unionid，无手机号的学生为""。
    /// </summary>
    [JsonPropertyName("unionid")]
    public string? Unionid { get; set; }

    /// <summary>
    /// 人员userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }
}

/// <summary>
/// 返回结果。
/// </summary>
public class EduUserGetPostResponseResult
{
    /// <summary>
    /// 人员身份详情。
    /// </summary>
    [JsonPropertyName("details")]
    public List<EduUserGetPostResponseResultDetailsItem> Details { get; set; } = [];
}

/// <summary>
/// 获取人员详情响应
/// </summary>
public class EduUserGetPostResponse : DingTalkResult
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    [JsonPropertyName("result")]
    public EduUserGetPostResponseResult? Result { get; set; }

    /// <summary>
    /// 是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("")]
    public Dictionary<string, object?>? Value { get; set; } = [];
}

/// <summary>
/// 获取班级内学生的关系列表请求
/// </summary>
public class EduUserRelationListPostRequest
{
    /// <summary>
    /// 从1开始。
    /// </summary>
    [JsonPropertyName("page_no")]
    public decimal? PageNo { get; set; }

    /// <summary>
    /// 最大值30，最小值1。
    /// </summary>
    [JsonPropertyName("page_size")]
    public decimal? PageSize { get; set; }

    /// <summary>
    /// 班级ID。
    /// </summary>
    [JsonPropertyName("class_id")]
    public decimal? ClassId { get; set; }
}

/// <summary>
/// EduUserRelationListPostResponseResultRelationsItem
/// </summary>
public class EduUserRelationListPostResponseResultRelationsItem
{
    /// <summary>
    /// 班级ID。
    /// </summary>
    [JsonPropertyName("class_id")]
    public decimal? ClassId { get; set; }

    /// <summary>
    /// 关系名。
    /// </summary>
    [JsonPropertyName("relation_name")]
    public string? RelationName { get; set; }

    /// <summary>
    /// 关系code：F：爸爸M：妈妈GF：爷爷GM：奶奶GFA：外公GMA：外婆U：叔叔A：阿姨B：哥哥S：姐姐O：家长
    /// </summary>
    [JsonPropertyName("relation_code")]
    public string? RelationCode { get; set; }

    /// <summary>
    /// 监护人userid。
    /// </summary>
    [JsonPropertyName("from_userid")]
    public string? FromUserid { get; set; }

    /// <summary>
    /// 学生userid。
    /// </summary>
    [JsonPropertyName("to_userid")]
    public string? ToUserid { get; set; }
}

/// <summary>
/// 返回结果。
/// </summary>
public class EduUserRelationListPostResponseResult
{
    /// <summary>
    /// 是否还存在数据。
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// 关系列表。
    /// </summary>
    [JsonPropertyName("relations")]
    public List<EduUserRelationListPostResponseResultRelationsItem> Relations { get; set; } = [];
}

/// <summary>
/// 获取班级内学生的关系列表响应
/// </summary>
public class EduUserRelationListPostResponse : DingTalkResult
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    [JsonPropertyName("result")]
    public EduUserRelationListPostResponseResult? Result { get; set; }

    /// <summary>
    /// 是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 获取学生监护人详情请求
/// </summary>
public class EduUserRelationGetPostRequest
{
    /// <summary>
    /// 监护人userid。
    /// </summary>
    [JsonPropertyName("from_userid")]
    public string? FromUserid { get; set; }

    /// <summary>
    /// 班级ID。
    /// </summary>
    [JsonPropertyName("class_id")]
    public decimal? ClassId { get; set; }
}

/// <summary>
/// EduUserRelationGetPostResponseResultRelationsItem
/// </summary>
public class EduUserRelationGetPostResponseResultRelationsItem
{
    /// <summary>
    /// 班级ID。
    /// </summary>
    [JsonPropertyName("class_id")]
    public decimal? ClassId { get; set; }

    /// <summary>
    /// 关系名。
    /// </summary>
    [JsonPropertyName("relation_name")]
    public string? RelationName { get; set; }

    /// <summary>
    /// 关系code：F：爸爸M：妈妈GF：爷爷GM：奶奶GFA：外公GMA：外婆U：叔叔A：阿姨B：哥哥S：姐姐O：家长
    /// </summary>
    [JsonPropertyName("relation_code")]
    public string? RelationCode { get; set; }

    /// <summary>
    /// 监护人userid。
    /// </summary>
    [JsonPropertyName("from_userid")]
    public string? FromUserid { get; set; }

    /// <summary>
    /// 学生userid。
    /// </summary>
    [JsonPropertyName("to_userid")]
    public string? ToUserid { get; set; }
}

/// <summary>
/// 返回结果。
/// </summary>
public class EduUserRelationGetPostResponseResult
{
    /// <summary>
    /// 关系详情列表
    /// </summary>
    [JsonPropertyName("relations")]
    public List<EduUserRelationGetPostResponseResultRelationsItem> Relations { get; set; } = [];
}

/// <summary>
/// 获取学生监护人详情响应
/// </summary>
public class EduUserRelationGetPostResponse : DingTalkResult
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    [JsonPropertyName("result")]
    public EduUserRelationGetPostResponseResult? Result { get; set; }

    /// <summary>
    /// 是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 获取班级圈话题列表请求
/// </summary>
public class EduCircleTopiclistPostRequest
{
    /// <summary>
    /// 班级ID。
    /// </summary>
    [JsonPropertyName("class_id")]
    public decimal? ClassId { get; set; }

    /// <summary>
    /// 业务类型，固定值为4，表示班级圈。
    /// </summary>
    [JsonPropertyName("biz_type")]
    public decimal? BizType { get; set; }

    /// <summary>
    /// 用户userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }
}

/// <summary>
/// EduCircleTopiclistPostResponseResultItem
/// </summary>
public class EduCircleTopiclistPostResponseResultItem
{
    /// <summary>
    /// 话题ID。
    /// </summary>
    [JsonPropertyName("topic_id")]
    public decimal? TopicId { get; set; }

    /// <summary>
    /// 是否是初始化话题。
    /// </summary>
    [JsonPropertyName("init_topic")]
    public bool? InitTopic { get; set; }

    /// <summary>
    /// 话题名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 动态数量。
    /// </summary>
    [JsonPropertyName("post_count")]
    public decimal? PostCount { get; set; }

    /// <summary>
    /// 话题背景图片。
    /// </summary>
    [JsonPropertyName("album_media_id")]
    public string? AlbumMediaId { get; set; }

    /// <summary>
    /// 话题描述。
    /// </summary>
    [JsonPropertyName("desc")]
    public string? Desc { get; set; }
}

/// <summary>
/// 获取班级圈话题列表响应
/// </summary>
public class EduCircleTopiclistPostResponse : DingTalkResult
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    [JsonPropertyName("result")]
    public List<EduCircleTopiclistPostResponseResultItem> Result { get; set; } = [];

    /// <summary>
    /// 是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 请求结构
/// </summary>
public class EduCirclePostListPostRequestOpenFeedQueryParam
{
    /// <summary>
    /// 分页游标，第一页传入系统时间，毫秒。返回的数据的时间戳不超过该数值
    /// </summary>
    [JsonPropertyName("cursor")]
    public decimal? Cursor { get; set; }

    /// <summary>
    /// 学生的userid。
    /// </summary>
    [JsonPropertyName("student_id")]
    public string? StudentId { get; set; }

    /// <summary>
    /// 班级ID。
    /// </summary>
    [JsonPropertyName("class_id")]
    public decimal? ClassId { get; set; }

    /// <summary>
    /// 话题ID。
    /// </summary>
    [JsonPropertyName("topic_id")]
    public decimal? TopicId { get; set; }

    /// <summary>
    /// 业务类型，固定值为4，表示班级圈。
    /// </summary>
    [JsonPropertyName("biz_type")]
    public decimal? BizType { get; set; }

    /// <summary>
    /// 动态类型，固定值0。
    /// </summary>
    [JsonPropertyName("feed_type")]
    public decimal? FeedType { get; set; }

    /// <summary>
    /// 分页大小，最大值20。
    /// </summary>
    [JsonPropertyName("count")]
    public decimal? Count { get; set; }

    /// <summary>
    /// 角色，可不传。
    /// </summary>
    [JsonPropertyName("user_role")]
    public string? UserRole { get; set; }

    /// <summary>
    /// 当前人登录人userId，如果没有人登录。可以传入班级的老师userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }
}

/// <summary>
/// 获取班级圈动态列表请求
/// </summary>
public class EduCirclePostListPostRequest
{
    /// <summary>
    /// 请求结构
    /// </summary>
    [JsonPropertyName("open_feed_query_param")]
    public EduCirclePostListPostRequestOpenFeedQueryParam? OpenFeedQueryParam { get; set; }
}

/// <summary>
/// 评论发送者。
/// </summary>
public class EduCirclePostListPostResponseResultPostsItemCommentsItemOriginUser
{
    /// <summary>
    /// 评论人名称。
    /// </summary>
    [JsonPropertyName("show_name")]
    public string? ShowName { get; set; }

    /// <summary>
    /// 员工userid。
    /// </summary>
    [JsonPropertyName("staff_id")]
    public string? StaffId { get; set; }
}

/// <summary>
/// EduCirclePostListPostResponseResultPostsItemCommentsItem
/// </summary>
public class EduCirclePostListPostResponseResultPostsItemCommentsItem
{
    /// <summary>
    /// 评论ID。
    /// </summary>
    [JsonPropertyName("comment_id")]
    public decimal? CommentId { get; set; }

    /// <summary>
    /// 评论内容。
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// 评论发送者。
    /// </summary>
    [JsonPropertyName("origin_user")]
    public EduCirclePostListPostResponseResultPostsItemCommentsItemOriginUser? OriginUser { get; set; }
}

/// <summary>
/// 动态作者。
/// </summary>
public class EduCirclePostListPostResponseResultPostsItemAuthor
{
    /// <summary>
    /// 是否是当前人。
    /// </summary>
    [JsonPropertyName("owner")]
    public bool? Owner { get; set; }

    /// <summary>
    /// 页面展示的作者昵称。
    /// </summary>
    [JsonPropertyName("show_name")]
    public string? ShowName { get; set; }

    /// <summary>
    /// 作者头像。
    /// </summary>
    [JsonPropertyName("icon_media_id")]
    public string? IconMediaId { get; set; }

    /// <summary>
    /// 员工在公司的职位信息。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 用户类型。
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// 作者头像.
    /// </summary>
    [JsonPropertyName("avatar_media_id")]
    public string? AvatarMediaId { get; set; }

    /// <summary>
    /// 作者昵称。
    /// </summary>
    [JsonPropertyName("nick")]
    public string? Nick { get; set; }

    /// <summary>
    /// 是否是当前人。
    /// </summary>
    [JsonPropertyName("is_owner")]
    public bool? IsOwner { get; set; }

    /// <summary>
    /// 员工标签。
    /// </summary>
    [JsonPropertyName("tag")]
    public decimal? Tag { get; set; }

    /// <summary>
    /// 用户角色。
    /// </summary>
    [JsonPropertyName("user_role")]
    public string? UserRole { get; set; }

    /// <summary>
    /// 作者userid。
    /// </summary>
    [JsonPropertyName("staff_id")]
    public string? StaffId { get; set; }
}

/// <summary>
/// 动态内容。需要自行解析里面的内容。
/// </summary>
public class EduCirclePostListPostResponseResultPostsItemContent
{
    /// <summary>
    /// 地址位置信息。
    /// </summary>
    [JsonPropertyName("geo_content")]
    public string? GeoContent { get; set; }

    /// <summary>
    /// 动态文字内容。
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>
    /// 内容类型。取值：1：文本2：图片3：视频4：链接5：地理位置6：附件7：转发8：富文本9：钉盘文件
    /// </summary>
    [JsonPropertyName("content_type")]
    public decimal? ContentType { get; set; }
}

/// <summary>
/// EduCirclePostListPostResponseResultPostsItem
/// </summary>
public class EduCirclePostListPostResponseResultPostsItem
{
    /// <summary>
    /// 动态对应的评论。
    /// </summary>
    [JsonPropertyName("comments")]
    public List<EduCirclePostListPostResponseResultPostsItemCommentsItem> Comments { get; set; } = [];

    /// <summary>
    /// 动态作者。
    /// </summary>
    [JsonPropertyName("author")]
    public EduCirclePostListPostResponseResultPostsItemAuthor? Author { get; set; }

    /// <summary>
    /// 动态类型，0表示动态。
    /// </summary>
    [JsonPropertyName("feed_type")]
    public decimal? FeedType { get; set; }

    /// <summary>
    /// 业务ID。
    /// </summary>
    [JsonPropertyName("biz_id")]
    public string? BizId { get; set; }

    /// <summary>
    /// 动态ID。
    /// </summary>
    [JsonPropertyName("post_id")]
    public decimal? PostId { get; set; }

    /// <summary>
    /// 创建时间。
    /// </summary>
    [JsonPropertyName("create_at")]
    public decimal? CreateAt { get; set; }

    /// <summary>
    /// 动态内容。需要自行解析里面的内容。
    /// </summary>
    [JsonPropertyName("content")]
    public EduCirclePostListPostResponseResultPostsItemContent? Content { get; set; }

    /// <summary>
    /// 动态标签。
    /// </summary>
    [JsonPropertyName("tags")]
    public string? Tags { get; set; }

    /// <summary>
    /// 状态，0表示正常。
    /// </summary>
    [JsonPropertyName("status")]
    public decimal? Status { get; set; }
}

/// <summary>
/// 返回结果。
/// </summary>
public class EduCirclePostListPostResponseResult
{
    /// <summary>
    /// 是否还有更多数据。
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// 动态列表。
    /// </summary>
    [JsonPropertyName("posts")]
    public List<EduCirclePostListPostResponseResultPostsItem> Posts { get; set; } = [];
}

/// <summary>
/// 获取班级圈动态列表响应
/// </summary>
public class EduCirclePostListPostResponse : DingTalkResult
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    [JsonPropertyName("result")]
    public EduCirclePostListPostResponseResult? Result { get; set; }

    /// <summary>
    /// 是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}

/// <summary>
/// 获取数字化证书请求
/// </summary>
public class EduCertGetPostRequest
{
    /// <summary>
    /// 学校人员userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }
}

/// <summary>
/// EduCertGetPostResponseResultCertDatasItem
/// </summary>
public class EduCertGetPostResponseResultCertDatasItem
{
    /// <summary>
    /// 当前等级认证状态：0：未获取1：认证中2：证书制作中3：已获取
    /// </summary>
    [JsonPropertyName("cert_status")]
    public decimal? CertStatus { get; set; }

    /// <summary>
    /// 是否可以参加当前认证考试：true：可以false：敬请期待
    /// </summary>
    [JsonPropertyName("can_cert")]
    public bool? CanCert { get; set; }

    /// <summary>
    /// 认证等级：0：没有认证1：初级2：中级3：高级
    /// </summary>
    [JsonPropertyName("cert_level")]
    public decimal? CertLevel { get; set; }
}

/// <summary>
/// EduCertGetPostResponseResultPracticalTaskDataItem
/// </summary>
public class EduCertGetPostResponseResultPracticalTaskDataItem
{
    /// <summary>
    /// 是否完成实操任务：true：完成false：未完成
    /// </summary>
    [JsonPropertyName("finish")]
    public bool? Finish { get; set; }

    /// <summary>
    /// 实操任务code：sendCard：发布打卡sendImMsg：发布消息
    /// </summary>
    [JsonPropertyName("task_code")]
    public string? TaskCode { get; set; }
}

/// <summary>
/// 返回结果。
/// </summary>
public class EduCertGetPostResponseResult
{
    /// <summary>
    /// 当前用户最高认证等级：0：没有认证1：初级2：中级3：高级
    /// </summary>
    [JsonPropertyName("current_cert_level")]
    public decimal? CurrentCertLevel { get; set; }

    /// <summary>
    /// 认证明细。
    /// </summary>
    [JsonPropertyName("cert_datas")]
    public List<EduCertGetPostResponseResultCertDatasItem> CertDatas { get; set; } = [];

    /// <summary>
    /// 实操任务完成信息。
    /// </summary>
    [JsonPropertyName("practical_task_data")]
    public List<EduCertGetPostResponseResultPracticalTaskDataItem> PracticalTaskData { get; set; } = [];
}

/// <summary>
/// 获取数字化证书响应
/// </summary>
public class EduCertGetPostResponse : DingTalkResult
{
    /// <summary>
    /// 返回结果。
    /// </summary>
    [JsonPropertyName("result")]
    public EduCertGetPostResponseResult? Result { get; set; }

    /// <summary>
    /// 请求是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}
