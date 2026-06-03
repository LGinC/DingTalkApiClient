namespace DingTalkApiClient.Models.Contacts.UserManage;

/// <summary>
/// 查询用户详情请求
/// </summary>
/// <param name="Userid">用户id</param>
/// <param name="Language">返回值语言</param>
public class GetUserInfoRequest(string Userid, string Language = "zh_CN")
{
    /// <summary>
    /// 通讯录语言。
    /// </summary>
    public string Language { get; set; } = Language;

    /// <summary>
    /// 用户的UserId。
    /// </summary>
    public string Userid { get; set; } = Userid;
}

/// <summary>
/// 用户信息
/// </summary>
public class UserInfo
{
    /// <summary>
    /// 企业账号类型 (例如: "dingtalk")
    /// </summary>
    public string? ExclusiveAccountType { get; set; }

    /// <summary>
    /// 扩展信息，以 JSON 字符串形式存储
    /// </summary>
    public string? Extension { get; set; }

    /// <summary>
    /// 是否为老板
    /// </summary>
    public bool Boss { get; set; }

    /// <summary>
    /// 员工在当前开发者企业账号范围内的唯一标识
    /// </summary>
    public required string Unionid { get; set; }

    /// <summary>
    /// 是否为企业账号
    /// </summary>
    public bool ExclusiveAccount { get; set; }

    /// <summary>
    /// 直属上级的 UserID
    /// </summary>
    public string? ManagerUserid { get; set; }

    /// <summary>
    /// 是否为管理员
    /// </summary>
    public bool Admin { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 入职时间 (时间戳，单位：毫秒)
    /// </summary>
    public long? HiredDate { get; set; }

    /// <summary>
    /// 职位
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 扩展属性列表
    /// </summary>
    public List<ExtAttr> ExtAttrs { get; set; } = [];

    /// <summary>
    /// 员工的userId
    /// </summary>
    public required string Userid { get; set; }

    /// <summary>
    /// 禁用状态
    /// </summary>
    public bool DisableStatus { get; set; }

    /// <summary>
    /// 办公地点
    /// </summary>
    public string? WorkPlace { get; set; }

    /// <summary>
    /// 部门排序信息列表
    /// </summary>
    public List<DeptOrder> DeptOrderList { get; set; } = [];

    /// <summary>
    /// 是否完成实名认证
    /// </summary>
    public bool RealAuthed { get; set; }

    /// <summary>
    /// 昵称
    /// </summary>
    public string? Nickname { get; set; }

    /// <summary>
    /// 所属部门ID列表
    /// </summary>
    public List<long> DeptIdList { get; set; } = [];

    /// <summary>
    /// 工号
    /// </summary>
    public string? JobNumber { get; set; }

    /// <summary>
    /// 邮箱
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// 部门领导信息列表
    /// </summary>
    public List<LeaderInDept> LeaderInDept { get; set; } = [];

    /// <summary>
    /// 登录用户名
    /// </summary>
    public string? LoginId { get; set; }

    /// <summary>
    /// 企业账号所属企业名称
    /// </summary>
    public string? ExclusiveAccountCorpName { get; set; }

    /// <summary>
    /// 创建时间 (ISO 8601 格式字符串)
    /// </summary>
    public DateTimeOffset CreateTime { get; set; }

    /// <summary>
    /// 手机号码
    /// </summary>
    public string? Mobile { get; set; }

    /// <summary>
    /// 是否激活了钉钉
    /// </summary>
    public bool Active { get; set; }

    /// <summary>
    /// 座机号码
    /// </summary>
    public string? Telephone { get; set; }

    /// <summary>
    /// 头像URL
    /// </summary>
    public string? Avatar { get; set; }

    /// <summary>
    /// 是否隐藏手机号
    /// </summary>
    public bool HideMobile { get; set; }

    /// <summary>
    /// 企业账号所属企业ID
    /// </summary>
    public string? ExclusiveAccountCorpId { get; set; }

    /// <summary>
    /// 是否为企业的高管
    /// </summary>
    public bool Senior { get; set; }

    /// <summary>
    /// 姓名
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 国际电话区号
    /// </summary>
    public string? StateCode { get; set; }
}

/// <summary>
/// 扩展属性类
/// </summary>
public class ExtAttr
{
    /// <summary>
    /// 属性编码
    /// </summary>
    public required string Code { get; set; }

    /// <summary>
    /// 属性名称
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 属性值
    /// </summary>
    public ExtAttrValue? Value { get; set; }
}

/// <summary>
/// 扩展属性值类
/// </summary>
public class ExtAttrValue
{
    /// <summary>
    /// 文本类型的值
    /// </summary>
    public string? Text { get; set; }
}

/// <summary>
/// 部门排序信息类
/// </summary>
public class DeptOrder
{
    /// <summary>
    /// 部门ID
    /// </summary>
    public long DeptId { get; set; }

    /// <summary>
    /// 排序值
    /// </summary>
    public long Order { get; set; }
}

/// <summary>
/// 部门领导信息类
/// </summary>
public class LeaderInDept
{
    /// <summary>
    /// 是否为部门领导
    /// </summary>
    public bool Leader { get; set; }

    /// <summary>
    /// 部门ID
    /// </summary>
    public long DeptId { get; set; }
}
