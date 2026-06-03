using System.Text.Json.Serialization;
namespace DingTalkApiClient.Models.Contacts.IndustryContacts;
#pragma warning disable CS8618
/// <summary>
/// 获取部门列表请求
/// </summary>
public class IndustryDepartmentListRequest
{
    /// <summary>
    /// 父部门ID，行业根部门传1。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public decimal DeptId { get; set; }

    /// <summary>
    /// 分页查询的游标。
    /// </summary>
    [JsonPropertyName("cursor")]
    public decimal? Cursor { get; set; }

    /// <summary>
    /// 分页查询的大小，最大值1000。
    /// </summary>
    [JsonPropertyName("size")]
    public decimal Size { get; set; }
}

/// <summary>
/// 获取部门列表结果
/// </summary>
public class IndustryDepartmentListResult
{
    /// <summary>
    /// 部门详情列表。
    /// </summary>
    [JsonPropertyName("details")]
    public List<IndustryDepartmentListResultDetailsItem> Details { get; set; } = [];

    /// <summary>
    /// 分页查询的游标。
    /// </summary>
    [JsonPropertyName("next_cursor")]
    public decimal? NextCursor { get; set; }

    /// <summary>
    /// 是否还有更多数据。
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}

/// <summary>
/// IndustryDepartmentListResultDetailsItem
/// </summary>
public class IndustryDepartmentListResultDetailsItem
{
    /// <summary>
    /// 部门的其他业务属性。可JSON反序列化。例如：针对家校period_type：学段类型（幼儿园，小学等）name_mode：学段对应的名称类型（一年级，一年级1班等）grade_level：年纪级数（一年级值为1）start_year：入学年份class_level：年级下班级级数针对农村manager_user_id：组长userIDhome_tel：家庭电话destitute：是否贫困户
    /// </summary>
    [JsonPropertyName("feature")]
    public string? Feature { get; set; }

    /// <summary>
    /// 通讯录类型 行业相关。例如：针对学校classic：传统经典校区、学段、年级、班级4层结构。custom：自定义结构针对农村Origin：传统农村类型Community：社区类型custom：自定义结构
    /// </summary>
    [JsonPropertyName("contact_type")]
    public string? ContactType { get; set; }

    /// <summary>
    /// 部门类型。行业相关。例如：针对学校campus：校区period：学段grade：年级class：班级针对农村VillageGroup：组Residence：户LeaseholderDept：租客SecretaryDept：村委
    /// </summary>
    [JsonPropertyName("dept_type")]
    public string? DeptType { get; set; }

    /// <summary>
    /// 部门名称
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 部门ID
    /// </summary>
    [JsonPropertyName("dept_id")]
    public decimal? DeptId { get; set; }
}

/// <summary>
/// 获取部门详情请求
/// </summary>
public class IndustryDepartmentGetRequest
{
    /// <summary>
    /// 部门ID。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public decimal DeptId { get; set; }
}

/// <summary>
/// 获取部门详情结果
/// </summary>
public class IndustryDepartmentGetResult
{
    /// <summary>
    /// 部门的其他业务属性。可JSON反序列化。例如：针对家校period_type：学段类型（幼儿园，小学等）name_mode：学段对应的名称类型（一年级，一年级1班等）grade_level：年纪级数（一年级值为1）start_year：入学年份class_level：年级下班级级数针对农村manager_user_id：组长userIDhome_tel：家庭电话destitute：是否贫困户
    /// </summary>
    [JsonPropertyName("feature")]
    public string? Feature { get; set; }

    /// <summary>
    /// 通讯录类型 行业相关。例如：针对学校classic：传统经典校区、学段、年级、班级4层结构。custom：自定义结构针对农村Origin：传统农村类型Community：社区类型custom：自定义结构
    /// </summary>
    [JsonPropertyName("contact_type")]
    public string? ContactType { get; set; }

    /// <summary>
    /// 部门类型。行业相关。例如：针对学校campus：校区period：学段grade：年级class：班级针对农村VillageGroup：组Residence：户LeaseholderDept：租客SecretaryDept：村委
    /// </summary>
    [JsonPropertyName("dept_type")]
    public string? DeptType { get; set; }

    /// <summary>
    /// 父部门ID。
    /// </summary>
    [JsonPropertyName("super_id")]
    public decimal? SuperId { get; set; }

    /// <summary>
    /// 部门名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// 获取部门下人员列表请求
/// </summary>
public class IndustryUserListRequest
{
    /// <summary>
    /// 部门id。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public decimal DeptId { get; set; }

    /// <summary>
    /// 行业相关，不同行业角色不一样。例如：针对家校teacher: 老师guardian: 监护人student: 学生针对农村GroupManager: 组长HeadOfHouseHold: 户主HouseAdmin: 家庭管理员Villager：村民Leaseholder：租客
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>
    /// 分页查询的游标。
    /// </summary>
    [JsonPropertyName("cursor")]
    public decimal? Cursor { get; set; }

    /// <summary>
    /// 分页查询的大小，最大值1000。
    /// </summary>
    [JsonPropertyName("size")]
    public decimal Size { get; set; }
}

/// <summary>
/// 获取部门下人员列表结果
/// </summary>
public class IndustryUserListResult
{
    /// <summary>
    /// 是否还有更多数据。
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// 分页查询的游标。
    /// </summary>
    [JsonPropertyName("next_cursor")]
    public decimal? NextCursor { get; set; }

    /// <summary>
    /// 员工列表。
    /// </summary>
    [JsonPropertyName("details")]
    public List<IndustryUserListResultDetailsItem> Details { get; set; } = [];
}

/// <summary>
/// IndustryUserListResultDetailsItem
/// </summary>
public class IndustryUserListResultDetailsItem
{
    /// <summary>
    /// 不同角色的其他业务属性。可JSON反序列化。
    /// </summary>
    [JsonPropertyName("feature")]
    public string? Feature { get; set; }

    /// <summary>
    /// 人员角色列表。
    /// </summary>
    [JsonPropertyName("roles")]
    public List<IndustryUserListResultDetailsItemRolesItem> Roles { get; set; } = [];

    /// <summary>
    /// 员工姓名。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 员工的userId。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 用户在当前钉钉开放平台账号范围内的唯一标识。
    /// </summary>
    [JsonPropertyName("unionid")]
    public string? Unionid { get; set; }
}

/// <summary>
/// IndustryUserListResultDetailsItemRolesItem
/// </summary>
public class IndustryUserListResultDetailsItemRolesItem
{
    /// <summary>
    /// 角色名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 角色ID。
    /// </summary>
    [JsonPropertyName("id")]
    public decimal? Id { get; set; }
}

/// <summary>
/// 获取部门用户详情请求
/// </summary>
public class IndustryUserGetRequest
{
    /// <summary>
    /// 部门ID。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public decimal DeptId { get; set; }

    /// <summary>
    /// 员工userId。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }
}

/// <summary>
/// 获取部门用户详情结果
/// </summary>
public class IndustryUserGetResult
{
    /// <summary>
    /// 人员角色列表。
    /// </summary>
    [JsonPropertyName("roles")]
    public List<IndustryUserGetResultRolesItem> Roles { get; set; } = [];

    /// <summary>
    /// 员工姓名。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 不同角色的其他业务属性。可JSON反序列化。
    /// </summary>
    [JsonPropertyName("feature")]
    public string? Feature { get; set; }

    /// <summary>
    /// 用户在当前钉钉开放平台账号范围内的唯一标识。
    /// </summary>
    [JsonPropertyName("unionid")]
    public string? Unionid { get; set; }
}

/// <summary>
/// IndustryUserGetResultRolesItem
/// </summary>
public class IndustryUserGetResultRolesItem
{
    /// <summary>
    /// 角色名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 角色ID。
    /// </summary>
    [JsonPropertyName("id")]
    public decimal? Id { get; set; }
}

/// <summary>
/// 获取企业信息请求
/// </summary>
public class IndustryOrganizationGetRequest
{
}

/// <summary>
/// 获取企业信息结果
/// </summary>
public class IndustryOrganizationGetResult
{
    /// <summary>
    /// 具体的企业区域位置信息，下划线划分省市区。例如：中国_浙江省_杭州市_余杭区
    /// </summary>
    [JsonPropertyName("region_location")]
    public string? RegionLocation { get; set; }

    /// <summary>
    /// 企业所在区域id。110101 针对行政区，国家统一标准，可以自行处理。例如11开头北京市，0101东城区类似。
    /// </summary>
    [JsonPropertyName("region_id")]
    public string? RegionId { get; set; }

    /// <summary>
    /// 企业所在区域类型，目前有以下五种：PROVINCE：省份CITY：城市COUNTRY：县区TOWN：乡镇VILLAGE：村
    /// </summary>
    [JsonPropertyName("region_type")]
    public string? RegionType { get; set; }
}
