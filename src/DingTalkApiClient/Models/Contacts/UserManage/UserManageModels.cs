using System.Text.Json.Serialization;
namespace DingTalkApiClient.Models.Contacts.UserManage;
#pragma warning disable CS8618
/// <summary>
/// 邀请其他组织企业账号加入请求
/// </summary>
public class UserCreateRequest
{
    /// <summary>
    /// 扩展属性，可以设置多种属性，最大长度2000个字符。 说明 手机上最多只能显示10个扩展属性。 在使用该参数前，需要先在钉钉管理后台增加该属性，然后再调用接口进行赋值。详情请参见下文关于extension参数的使用。 该字段的值支持链接类型填写，同时链接支持变量通配符自动替换，目前支持通配符有：userid，corpid。例如： {"爱好":"[爱好](http://www.dingtalk.com?userid=#userid#&amp;corpid=#corpid#)"}
    /// </summary>
    [JsonPropertyName("extension")]
    public string? Extension { get; set; }

    /// <summary>
    /// 直属主管的userId。
    /// </summary>
    [JsonPropertyName("manager_userid")]
    public string? ManagerUserid { get; set; }

    /// <summary>
    /// 需要添加的企业账号所属的userId。
    /// </summary>
    [JsonPropertyName("outer_exclusive_userid")]
    public required string OuterExclusiveUserid { get; set; }

    /// <summary>
    /// 需要添加的企业账号所属的corpId。
    /// </summary>
    [JsonPropertyName("outer_exclusive_corpid")]
    public required string OuterExclusiveCorpid { get; set; }

    /// <summary>
    /// 备注，长度最大2000个字符。
    /// </summary>
    [JsonPropertyName("remark")]
    public string? Remark { get; set; }

    /// <summary>
    /// 职位，长度最大为200个字符。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 入职时间，Unix时间戳，单位毫秒。
    /// </summary>
    [JsonPropertyName("hired_date")]
    public string? HiredDate { get; set; }

    /// <summary>
    /// 员工唯一标识ID（不可修改），长度为1~64个字符。 说明 企业内必须唯一。 如果不传，将自动生成一个userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 员工的企业邮箱类型： profession: 标准版。 base：基础版。
    /// </summary>
    [JsonPropertyName("org_email_type")]
    public string? OrgEmailType { get; set; }

    /// <summary>
    /// 办公地点，长度最大100个字符。
    /// </summary>
    [JsonPropertyName("work_place")]
    public string? WorkPlace { get; set; }

    /// <summary>
    /// 员工在对应的部门中的排序。
    /// </summary>
    [JsonPropertyName("dept_order_list")]
    public UserCreateRequestDeptOrderList DeptOrderList { get; set; }

    /// <summary>
    /// 是否开启高管模式，默认值false。 true：开启。 说明 开启后，手机号码对所有员工隐藏。 普通员工无法对其发DING、发起钉钉商务电话。 高管之间可以发DING、发起钉钉商务电话。 false：不开启。
    /// </summary>
    [JsonPropertyName("senior_mode")]
    public string? SeniorMode { get; set; }

    /// <summary>
    /// 所属部门ID列表，多个部门ID使用英文,隔开，每次调用最多传100个部门ID。
    /// </summary>
    [JsonPropertyName("dept_id_list")]
    public string? DeptIdList { get; set; }

    /// <summary>
    /// 员工工号，长度最大为50个字符。
    /// </summary>
    [JsonPropertyName("job_number")]
    public string? JobNumber { get; set; }

    /// <summary>
    /// 员工个人邮箱，长度最大50个字符。 说明 员工邮箱是唯一的，企业内不能重复。
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// 分机号，长度最大50个字符。 说明 分机号是唯一的，企业内不能重复。
    /// </summary>
    [JsonPropertyName("telephone")]
    public string? Telephone { get; set; }

    /// <summary>
    /// 员工在对应的部门中的职位。
    /// </summary>
    [JsonPropertyName("dept_title_list")]
    public UserCreateRequestDeptTitleList DeptTitleList { get; set; }

    /// <summary>
    /// 员工的企业邮箱，长度最大100个字符。 说明 需满足以下条件，此字段才生效：员工已开通企业邮箱。
    /// </summary>
    [JsonPropertyName("org_email")]
    public string? OrgEmail { get; set; }

    /// <summary>
    /// 员工名称，长度最大80个字符。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// 员工在对应的部门中的排序。
/// </summary>
public class UserCreateRequestDeptOrderList
{
    /// <summary>
    /// DeptId
    /// </summary>
    [JsonPropertyName("dept_id")]
    public required string DeptId { get; set; }

    /// <summary>
    /// Order
    /// </summary>
    [JsonPropertyName("order")]
    public required string Order { get; set; }
}

/// <summary>
/// 员工在对应的部门中的职位。
/// </summary>
public class UserCreateRequestDeptTitleList
{
    /// <summary>
    /// DeptId
    /// </summary>
    [JsonPropertyName("dept_id")]
    public required string DeptId { get; set; }

    /// <summary>
    /// Title
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }
}

/// <summary>
/// 邀请其他组织企业账号加入结果
/// </summary>
public class UserCreateResult
{
    /// <summary>
    /// 员工unionId。
    /// </summary>
    [JsonPropertyName("unionId")]
    public required string UnionId { get; set; }

    /// <summary>
    /// 员工userId。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }
}

/// <summary>
/// 更新企业账号用户信息请求
/// </summary>
public class UserUpdateRequest
{
    /// <summary>
    /// 扩展属性，长度最大2000个字符。 说明 手机上最多只能显示10个扩展属性。 在使用该参数前，需要先在钉钉管理后台 &gt; 设置 &gt; 通讯录信息增加该属性。 该字段的值支持链接类型填写，同时链接支持变量通配符自动替换，目前支持通配符有：userid和corpid。示例： [工位地址](http://www.dingtalk.com?userid=#userid#&amp;corpid=#corpid#)。
    /// </summary>
    [JsonPropertyName("extension")]
    public string? Extension { get; set; }

    /// <summary>
    /// 钉钉企业账号的登录名。 说明 仅支持钉钉企业账号更新该字段，SSO企业账号暂不支持。
    /// </summary>
    [JsonPropertyName("loginId")]
    public string? LoginId { get; set; }

    /// <summary>
    /// 直属主管的userId。
    /// </summary>
    [JsonPropertyName("manager_userid")]
    public string? ManagerUserid { get; set; }

    /// <summary>
    /// 通讯录语言，取值。 zh_CN：中文（默认值）。 en_US：英文。
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>
    /// 分机号，长度最大50个字符。 说明 分机号是唯一的，企业内不能重复。
    /// </summary>
    [JsonPropertyName("telephone")]
    public string? Telephone { get; set; }

    /// <summary>
    /// 是否号码隐藏： true：隐藏 隐藏手机号后，手机号在个人资料页隐藏，但仍可对其发DING、发起钉钉商务电话。 false：不隐藏
    /// </summary>
    [JsonPropertyName("hide_mobile")]
    public string? HideMobile { get; set; }

    /// <summary>
    /// 入职时间，UNIX时间戳，单位毫秒。
    /// </summary>
    [JsonPropertyName("hired_date")]
    public string? HiredDate { get; set; }

    /// <summary>
    /// 职位，长度最大200个字符。
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 企业账号员工的企业邮箱类型。 profession: 标准版 base: 基础版
    /// </summary>
    [JsonPropertyName("org_email_type")]
    public string? OrgEmailType { get; set; }

    /// <summary>
    /// 员工的userId。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }

    /// <summary>
    /// 更新本组织企业账号时可指定头像MediaId，只支持jpg/png格式，可调用上传媒体文件接口获取。 说明 仅企业本组织创建的自建企业账号返回该字段。
    /// </summary>
    [JsonPropertyName("avatarMediaId")]
    public string? AvatarMediaId { get; set; }

    /// <summary>
    /// 员工在对应的部门中的职位。
    /// </summary>
    [JsonPropertyName("dept_title_list")]
    public string? DeptTitleList { get; set; }

    /// <summary>
    /// 办公地点，长度最大100个字符。
    /// </summary>
    [JsonPropertyName("work_place")]
    public string? WorkPlace { get; set; }

    /// <summary>
    /// 员工在对应的部门中的排序。
    /// </summary>
    [JsonPropertyName("dept_order_list")]
    public string? DeptOrderList { get; set; }

    /// <summary>
    /// 是否开启高管模式，默认值false。 true：开启。 说明 开启后，手机号码对所有员工隐藏。 普通员工无法对其发DING、发起钉钉商务电话。 高管之间可以发DING、发起钉钉商务电话。 false：不开启。
    /// </summary>
    [JsonPropertyName("senior_mode")]
    public string? SeniorMode { get; set; }

    /// <summary>
    /// 备注，长度最大2000个字符。
    /// </summary>
    [JsonPropertyName("remark")]
    public string? Remark { get; set; }

    /// <summary>
    /// 员工的企业邮箱。 说明 需满足以下条件，此字段才生效：员工的企业邮箱已开通。
    /// </summary>
    [JsonPropertyName("org_email")]
    public string? OrgEmail { get; set; }

    /// <summary>
    /// 员工名称，长度最大80个字符。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 企业账号的昵称。 说明 仅企业本组织创建的自建企业账号返回该字段。
    /// </summary>
    [JsonPropertyName("nickname")]
    public string? Nickname { get; set; }

    /// <summary>
    /// 企业账号手机号。
    /// </summary>
    [JsonPropertyName("exclusive_mobile")]
    public string? ExclusiveMobile { get; set; }

    /// <summary>
    /// 强制更新的字段，支持清空指定的字段，多个字段之间使用逗号分隔。目前支持字段: manager_userid。
    /// </summary>
    [JsonPropertyName("force_update_fields")]
    public string? ForceUpdateFields { get; set; }

    /// <summary>
    /// 所属部门ID列表。
    /// </summary>
    [JsonPropertyName("dept_id_list")]
    public required string DeptIdList { get; set; }

    /// <summary>
    /// 员工工号，长度最大50个字符。
    /// </summary>
    [JsonPropertyName("job_number")]
    public string? JobNumber { get; set; }

    /// <summary>
    /// 员工邮箱，长度最大50个字符。 说明 员工邮箱是唯一的，企业内不能重复。
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

/// <summary>
/// 删除用户请求
/// </summary>
public class UserDeleteRequest
{
    /// <summary>
    /// 员工的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }
}

/// <summary>
/// 查询企业账号用户详情请求
/// </summary>
public class UserGetRequest
{
    /// <summary>
    /// 通讯录语言。 zh_CN：中文（默认值） en_US：英文
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>
    /// 用户的UserId。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }
}

/// <summary>
/// 查询企业账号用户详情结果
/// </summary>
public class UserGetResult
{
    /// <summary>
    /// 企业账号类型： sso：企业自建企业账号 dingtalk：钉钉自建企业账号 说明 仅企业账号返回该字段。
    /// </summary>
    [JsonPropertyName("exclusive_account_type")]
    public required string ExclusiveAccountType { get; set; }

    /// <summary>
    /// 扩展属性，最大长度2000个字符。 说明 企业内部应用如果没有返回该字段，需要检查当前应用通讯录权限中邮箱等个人信息权限是否开启。 员工信息面板中添加的拓展字段内有值才返回。 第三方企业应用不返回该字段。
    /// </summary>
    [JsonPropertyName("extension")]
    public required string Extension { get; set; }

    /// <summary>
    /// 员工在当前开发者企业账号范围内的唯一标识。
    /// </summary>
    [JsonPropertyName("unionid")]
    public required string Unionid { get; set; }

    /// <summary>
    /// 是否为企业的老板： true：是 false：不是
    /// </summary>
    [JsonPropertyName("boss")]
    public required string Boss { get; set; }

    /// <summary>
    /// 角色列表。
    /// </summary>
    [JsonPropertyName("role_list")]
    public UserGetResultRoleList RoleList { get; set; }

    /// <summary>
    /// 是否为企业账号： true：是 false：不是
    /// </summary>
    [JsonPropertyName("exclusive_account")]
    public required string ExclusiveAccount { get; set; }

    /// <summary>
    /// 员工的直属主管。 说明 员工在企业管理后台个人信息面板中，直属主管内有值，才会返回该字段。
    /// </summary>
    [JsonPropertyName("manager_userid")]
    public required string ManagerUserid { get; set; }

    /// <summary>
    /// 是否为企业的管理员： true：是 false：不是
    /// </summary>
    [JsonPropertyName("admin")]
    public required string Admin { get; set; }

    /// <summary>
    /// 备注。 说明 企业内部应用如果没有返回该字段，需要检查当前应用通讯录权限中邮箱等个人信息权限是否开启。 员工信息面板中该字段内有值才返回。 第三方企业应用不返回该字段。
    /// </summary>
    [JsonPropertyName("remark")]
    public required string Remark { get; set; }

    /// <summary>
    /// 职位。
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    /// <summary>
    /// 入职时间，Unix时间戳，单位毫秒。 说明 第三方企业应用不返回该字段。 信息面板中入职时间字段内有值才返回该字段。
    /// </summary>
    [JsonPropertyName("hired_date")]
    public required string HiredDate { get; set; }

    /// <summary>
    /// 员工的UserId。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }

    /// <summary>
    /// 员工的企业邮箱类型： profession：标准版 base：基础版
    /// </summary>
    [JsonPropertyName("org_email_type")]
    public required string OrgEmailType { get; set; }

    /// <summary>
    /// 办公地点。 说明 企业内部应用如果没有返回该字段，需要检查当前应用通讯录权限中邮箱等个人信息权限是否开启。 员工信息面板中该字段内有值才返回å。 第三方企业应用不返回该字段。
    /// </summary>
    [JsonPropertyName("work_place")]
    public required string WorkPlace { get; set; }

    /// <summary>
    /// 员工在对应的部门中的排序。
    /// </summary>
    [JsonPropertyName("dept_order_list")]
    public UserGetResultDeptOrderList DeptOrderList { get; set; }

    /// <summary>
    /// 是否已完成实名认证： true：已认证 false：未认证
    /// </summary>
    [JsonPropertyName("real_authed")]
    public required string RealAuthed { get; set; }

    /// <summary>
    /// 员工昵称。 说明 仅归属于本企业的钉钉企业账号返回该字段。
    /// </summary>
    [JsonPropertyName("nickname")]
    public required string Nickname { get; set; }

    /// <summary>
    /// 所属部门id列表。
    /// </summary>
    [JsonPropertyName("dept_id_list")]
    public required string DeptIdList { get; set; }

    /// <summary>
    /// 员工工号。
    /// </summary>
    [JsonPropertyName("job_number")]
    public required string JobNumber { get; set; }

    /// <summary>
    /// 员工邮箱。 说明 企业内部应用如果没有返回该字段，需要检查当前应用通讯录权限中邮箱等个人信息权限是否开启。 第三方企业应用不返回该字段；如需获取email，可以使用钉钉统一授权套件方式获取。
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    /// <summary>
    /// 员工所在部门信息及是否是领导： 员工所在部门的部门ID。 员工在对应的部门中是否是领导： true：是 false：不是
    /// </summary>
    [JsonPropertyName("leader_in_dept")]
    public UserGetResultLeaderInDept LeaderInDept { get; set; }

    /// <summary>
    /// 钉钉自建企业账号的登录名。 说明 仅归属于本企业的钉钉企业账号号返回该字段。
    /// </summary>
    [JsonPropertyName("login_id")]
    public required string LoginId { get; set; }

    /// <summary>
    /// 企业账号归属组织的组织名称。 说明 仅适用于企业账号，返回创建该企业账号的组织。
    /// </summary>
    [JsonPropertyName("exclusive_account_corp_name")]
    public required string ExclusiveAccountCorpName { get; set; }

    /// <summary>
    /// 手机号码。 说明 企业内部应用如果没有返回该字段，需要检查当前应用通讯录权限中企业员工手机号信息权限是否开启。 第三方企业应用不返回该字段；如需获取mobile，可以使用钉钉统一授权套件方式获取。
    /// </summary>
    [JsonPropertyName("mobile")]
    public required string Mobile { get; set; }

    /// <summary>
    /// 是否已激活钉钉： true：已激活 false：未激活
    /// </summary>
    [JsonPropertyName("active")]
    public required string Active { get; set; }

    /// <summary>
    /// 分机号。 说明 第三方企业应用不返回该字段。
    /// </summary>
    [JsonPropertyName("telephone")]
    public required string Telephone { get; set; }

    /// <summary>
    /// 头像。 说明 员工使用默认头像，不返回该字段。 员工手动设置头像会返回该字段。
    /// </summary>
    [JsonPropertyName("avatar")]
    public required string Avatar { get; set; }

    /// <summary>
    /// 是否号码隐藏： true：隐藏 false：不隐藏 说明 隐藏手机号后，手机号在个人资料页隐藏，但仍可对其发DING、发起钉钉商务电话。
    /// </summary>
    [JsonPropertyName("hide_mobile")]
    public required string HideMobile { get; set; }

    /// <summary>
    /// 企业账号归属组织的组织CorpId。 说明 仅适用于企业账号，返回创建该企业账号的组织。
    /// </summary>
    [JsonPropertyName("exclusive_account_corp_id")]
    public required string ExclusiveAccountCorpId { get; set; }

    /// <summary>
    /// 是否为企业的高管： true：是 false：不是
    /// </summary>
    [JsonPropertyName("senior")]
    public required string Senior { get; set; }

    /// <summary>
    /// 员工的企业邮箱。 如果员工的企业邮箱没有开通，返回信息中不包含该数据。 说明 第三方企业应用不返回该字段。
    /// </summary>
    [JsonPropertyName("org_email")]
    public required string OrgEmail { get; set; }

    /// <summary>
    /// 员工姓名。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 当用户来自于关联组织时的关联信息。 说明 用户所在企业存在关联关系的企业，返回该字段。
    /// </summary>
    [JsonPropertyName("union_emp_ext")]
    public UserGetResultUnionEmpExt UnionEmpExt { get; set; }

    /// <summary>
    /// 国际电话区号。 说明 第三方企业应用不返回该字段；如需获取state_code，可以使用钉钉统一授权套件方式获取。
    /// </summary>
    [JsonPropertyName("state_code")]
    public required string StateCode { get; set; }
}

/// <summary>
/// 角色列表。
/// </summary>
public class UserGetResultRoleList
{
    /// <summary>
    /// GroupName
    /// </summary>
    [JsonPropertyName("group_name")]
    public required string GroupName { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Id
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
}

/// <summary>
/// 员工在对应的部门中的排序。
/// </summary>
public class UserGetResultDeptOrderList
{
    /// <summary>
    /// DeptId
    /// </summary>
    [JsonPropertyName("dept_id")]
    public required string DeptId { get; set; }

    /// <summary>
    /// Order
    /// </summary>
    [JsonPropertyName("order")]
    public required string Order { get; set; }
}

/// <summary>
/// 员工所在部门信息及是否是领导： 员工所在部门的部门ID。 员工在对应的部门中是否是领导： true：是 false：不是
/// </summary>
public class UserGetResultLeaderInDept
{
    /// <summary>
    /// Leader
    /// </summary>
    [JsonPropertyName("leader")]
    public required string Leader { get; set; }

    /// <summary>
    /// DeptId
    /// </summary>
    [JsonPropertyName("dept_id")]
    public required string DeptId { get; set; }
}

/// <summary>
/// 当用户来自于关联组织时的关联信息。 说明 用户所在企业存在关联关系的企业，返回该字段。
/// </summary>
public class UserGetResultUnionEmpExt
{
    /// <summary>
    /// UnionEmpMapList
    /// </summary>
    [JsonPropertyName("union_emp_map_list")]
    public UserGetResultUnionEmpExtUnionEmpMapList UnionEmpMapList { get; set; }

    /// <summary>
    /// Userid
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }

    /// <summary>
    /// CorpId
    /// </summary>
    [JsonPropertyName("corp_id")]
    public required string CorpId { get; set; }
}

/// <summary>
/// UserGetResultUnionEmpExtUnionEmpMapList
/// </summary>
public class UserGetResultUnionEmpExtUnionEmpMapList
{
    /// <summary>
    /// Userid
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }

    /// <summary>
    /// CorpId
    /// </summary>
    [JsonPropertyName("corp_id")]
    public required string CorpId { get; set; }
}

/// <summary>
/// 获取部门用户基础信息请求
/// </summary>
public class UserListSimpleRequest
{
    /// <summary>
    /// 部门ID，如果是根部门，该参数传1。 企业内部应用，可调用获取部门列表获取dept_id参数值。 第三方企业应用，可调用获取部门列表获取dept_id参数值。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public required string DeptId { get; set; }

    /// <summary>
    /// 分页查询的游标，最开始传0，后续传返回参数中的next_cursor值。
    /// </summary>
    [JsonPropertyName("cursor")]
    public long Cursor { get; set; }

    /// <summary>
    /// 分页长度，最大值100。
    /// </summary>
    [JsonPropertyName("size")]
    public long Size { get; set; }

    /// <summary>
    /// 部门成员的排序规则：entry_asc：代表按照进入部门的时间升序。entry_desc：代表按照进入部门的时间降序。modify_asc：代表按照部门信息修改时间升序。modify_desc：代表按照部门信息修改时间降序。custom：代表用户定义(未定义时按照拼音)排序。默认值：custom。
    /// </summary>
    [JsonPropertyName("order_field")]
    public string? OrderField { get; set; }

    /// <summary>
    /// 是否返回访问受限的员工。
    /// </summary>
    [JsonPropertyName("contain_access_limit")]
    public bool? ContainAccessLimit { get; set; }

    /// <summary>
    /// 通讯录语言，取值。zh_CN：中文（默认值）。en_US：英文。
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }
}

/// <summary>
/// 获取部门用户基础信息结果
/// </summary>
public class UserListSimpleResult
{
    /// <summary>
    /// 是否还有更多的数据。
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// 下一次分页的游标，如果has_more为false，表示没有更多的分页数据。
    /// </summary>
    [JsonPropertyName("next_cursor")]
    public decimal? NextCursor { get; set; }

    /// <summary>
    /// 用户信息列表。
    /// </summary>
    [JsonPropertyName("list")]
    public List<UserListSimpleResultListItem> List { get; set; } = [];
}

/// <summary>
/// UserListSimpleResultListItem
/// </summary>
public class UserListSimpleResultListItem
{
    /// <summary>
    /// 用户的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }

    /// <summary>
    /// 用户姓名。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// 获取部门用户userid列表请求
/// </summary>
public class UserListIdRequest
{
    /// <summary>
    /// 部门ID，根部门ID为1。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public decimal DeptId { get; set; }
}

/// <summary>
/// 获取部门用户userid列表结果
/// </summary>
public class UserListIdResult
{
    /// <summary>
    /// 指定部门的userid列表。
    /// </summary>
    [JsonPropertyName("userid_list")]
    public List<string> UseridList { get; set; } = [];
}

/// <summary>
/// 获取部门企业账号用户详情请求
/// </summary>
public class UserListRequest
{
    /// <summary>
    /// 分页查询的游标，最开始传0，后续传返回参数中的next_cursor值。
    /// </summary>
    [JsonPropertyName("cursor")]
    public decimal Cursor { get; set; }

    /// <summary>
    /// 是否返回访问受限的员工： true：返回 false：不返回
    /// </summary>
    [JsonPropertyName("contain_access_limit")]
    public bool? ContainAccessLimit { get; set; }

    /// <summary>
    /// 分页大小。
    /// </summary>
    [JsonPropertyName("size")]
    public decimal Size { get; set; }

    /// <summary>
    /// 部门成员的排序规则，默认不传是按自定义排序（custom）： entry_asc：代表按照进入部门的时间升序 entry_desc：代表按照进入部门的时间降序 modify_asc：代表按照部门信息修改时间升序 modify_desc：代表按照部门信息修改时间降序 custom：代表用户定义(未定义时按照拼音)排序
    /// </summary>
    [JsonPropertyName("order_field")]
    public string? OrderField { get; set; }

    /// <summary>
    /// 通讯录语言，取值。 zh_CN：中文（默认值）。 en_US：英文。
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>
    /// 部门ID。 企业内部应用，可调用获取部门列表接口获取dept_id参数值。 第三方企业应用，可调用获取部门列表接口获取dept_id参数值。 说明 只获取当前部门下的员工信息，不包含子部门内的员工。 如果是根部门，该参数传1。
    /// </summary>
    [JsonPropertyName("dept_id")]
    public decimal DeptId { get; set; }
}

/// <summary>
/// 获取部门企业账号用户详情结果
/// </summary>
public class UserListResult
{
    /// <summary>
    /// 下一次分页的游标。 说明 如果has_more为false，表示没有更多的分页数据。
    /// </summary>
    [JsonPropertyName("next_cursor")]
    public required string NextCursor { get; set; }

    /// <summary>
    /// 是否还有更多的数据： true：有 false：没有
    /// </summary>
    [JsonPropertyName("has_more")]
    public required string HasMore { get; set; }

    /// <summary>
    /// 用户信息列表。
    /// </summary>
    [JsonPropertyName("list")]
    public UserListResultList List { get; set; }
}

/// <summary>
/// 用户信息列表。
/// </summary>
public class UserListResultList
{
    /// <summary>
    /// 是否是部门的主管： true：是 false：不是
    /// </summary>
    [JsonPropertyName("leader")]
    public required string Leader { get; set; }

    /// <summary>
    /// 企业账号类型。 sso：企业自建企业账号 dingtalk：钉钉自建企业账号 说明 仅企业账号返回该字段。
    /// </summary>
    [JsonPropertyName("exclusive_account_type")]
    public required string ExclusiveAccountType { get; set; }

    /// <summary>
    /// 扩展属性。 说明 企业内部应用如果没有返回该字段，需要检查当前应用通讯录权限中邮箱等个人信息权限是否开启。 员工信息面板中该字段内有值才返回。 第三方企业应用不返回该参数。
    /// </summary>
    [JsonPropertyName("extension")]
    public required string Extension { get; set; }

    /// <summary>
    /// 用户在当前开发者企业账号范围内的唯一标识。
    /// </summary>
    [JsonPropertyName("unionid")]
    public required string Unionid { get; set; }

    /// <summary>
    /// 是否为企业的老板： true：是 false：不是
    /// </summary>
    [JsonPropertyName("boss")]
    public required string Boss { get; set; }

    /// <summary>
    /// 是否企业账号： true：是 false：不是 说明 第三方企业应用不返回该参数。
    /// </summary>
    [JsonPropertyName("exclusive_account")]
    public required string ExclusiveAccount { get; set; }

    /// <summary>
    /// 是否为企业的管理员： true：是 false：不是
    /// </summary>
    [JsonPropertyName("admin")]
    public required string Admin { get; set; }

    /// <summary>
    /// 备注。 说明 企业内部应用如果没有返回该字段，需要检查当前应用通讯录权限中邮箱等个人信息权限是否开启。 员工信息面板中该字段内有值才返回。 第三方企业应用不返回该参数。
    /// </summary>
    [JsonPropertyName("remark")]
    public required string Remark { get; set; }

    /// <summary>
    /// 职位。
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    /// <summary>
    /// 入职时间，Unix时间戳，单位毫秒。 说明 第三方企业应用不返回该参数。
    /// </summary>
    [JsonPropertyName("hired_date")]
    public required string HiredDate { get; set; }

    /// <summary>
    /// 用户的userId。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }

    /// <summary>
    /// 办公地点。 说明 企业内部应用如果没有返回该字段，需要检查当前应用通讯录权限中邮箱等个人信息权限是否开启。 员工信息面板中该字段内有值才返回。 第三方企业应用不返回该参数。
    /// </summary>
    [JsonPropertyName("work_place")]
    public required string WorkPlace { get; set; }

    /// <summary>
    /// 企业账号昵称。 说明 仅企业本组织创建的自建企业账号返回该字段。
    /// </summary>
    [JsonPropertyName("nickname")]
    public required string Nickname { get; set; }

    /// <summary>
    /// 所属部门id列表。
    /// </summary>
    [JsonPropertyName("dept_id_list")]
    public required string DeptIdList { get; set; }

    /// <summary>
    /// 员工工号。
    /// </summary>
    [JsonPropertyName("job_number")]
    public required string JobNumber { get; set; }

    /// <summary>
    /// 员工邮箱。 说明 企业内部应用如果没有返回该字段，需要检查当前应用通讯录权限中邮箱等个人信息权限是否开启。 员工信息面板中有邮箱字段值才返回该字段。 第三方企业应用不返回该参数。
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    /// <summary>
    /// 员工在部门中的排序。
    /// </summary>
    [JsonPropertyName("dept_order")]
    public required string DeptOrder { get; set; }

    /// <summary>
    /// 本组织企业账号登录名。 说明 仅归属于本企业的钉钉企业账号返回该字段。
    /// </summary>
    [JsonPropertyName("login_id")]
    public required string LoginId { get; set; }

    /// <summary>
    /// 企业账号归属组织的组织名称。 说明 仅适用于企业账号，返回创建该企业账号的组织名称。
    /// </summary>
    [JsonPropertyName("exclusive_account_corp_name")]
    public required string ExclusiveAccountCorpName { get; set; }

    /// <summary>
    /// 手机号码。 说明 企业内部应用如果没有返回该字段，需要检查当前应用通讯录权限中企业员工手机号信息权限是否开启。 第三方企业应用不返回该参数；如需获取mobile，可以使用钉钉统一授权套件方式获取。
    /// </summary>
    [JsonPropertyName("mobile")]
    public required string Mobile { get; set; }

    /// <summary>
    /// 是否激活了钉钉： true：已激活 false：未激活
    /// </summary>
    [JsonPropertyName("active")]
    public required string Active { get; set; }

    /// <summary>
    /// 分机号。 说明 第三方企业应用不返回该参数。
    /// </summary>
    [JsonPropertyName("telephone")]
    public required string Telephone { get; set; }

    /// <summary>
    /// 头像地址。
    /// </summary>
    [JsonPropertyName("avatar")]
    public required string Avatar { get; set; }

    /// <summary>
    /// 是否号码隐藏： true：隐藏 隐藏手机号后，手机号在个人资料页隐藏，但仍可对其发DING、发起钉钉商务电话。 false：不隐藏
    /// </summary>
    [JsonPropertyName("hide_mobile")]
    public required string HideMobile { get; set; }

    /// <summary>
    /// 企业账号归属组织的组织corpId。 说明 仅适用于企业账号，返回创建该企业账号的组织corpId。
    /// </summary>
    [JsonPropertyName("exclusive_account_corp_id")]
    public required string ExclusiveAccountCorpId { get; set; }

    /// <summary>
    /// 员工的企业邮箱。 说明 企业内部应用如果没有返回该字段，需要检查当前应用通讯录权限中邮箱等个人信息权限是否开启。 员工信息面板中该字段内有值才返回。 第三方企业应用不返回该参数。
    /// </summary>
    [JsonPropertyName("org_email")]
    public required string OrgEmail { get; set; }

    /// <summary>
    /// 用户姓名。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 国际电话区号。 说明 企业内部应用如果没有返回该字段，需要检查当前应用通讯录权限中企业员工手机号信息权限是否开启。 第三方企业应用不返回该参数；如需获取state_code，可以使用钉钉统一授权套件方式获取。
    /// </summary>
    [JsonPropertyName("state_code")]
    public required string StateCode { get; set; }
}

/// <summary>
/// 获取员工人数请求
/// </summary>
public class UserCountRequest
{
    /// <summary>
    /// 是否包含未激活钉钉人数：false：包含未激活钉钉的人员数量。true：只包含激活钉钉的人员数量。
    /// </summary>
    [JsonPropertyName("only_active")]
    public bool OnlyActive { get; set; }
}

/// <summary>
/// 获取员工人数结果
/// </summary>
public class UserCountResult
{
    /// <summary>
    /// 员工数量。
    /// </summary>
    [JsonPropertyName("count")]
    public decimal? Count { get; set; }
}

/// <summary>
/// 获取未登录钉钉的员工列表请求
/// </summary>
public class InactiveUserGetRequest
{
    /// <summary>
    /// 是否活跃：false：未登录true：登录
    /// </summary>
    [JsonPropertyName("is_active")]
    public bool IsActive { get; set; }

    /// <summary>
    /// 过滤部门ID列表，不传表示查询整个企业。
    /// </summary>
    [JsonPropertyName("dept_ids")]
    public List<decimal> DeptIds { get; set; } = [];

    /// <summary>
    /// 支持分页查询，与size参数同时设置时才生效，此参数代表偏移量，偏移量从0开始。
    /// </summary>
    [JsonPropertyName("offset")]
    public decimal Offset { get; set; }

    /// <summary>
    /// 支持分页查询，与offset参数同时设置时才生效，此参数代表分页大小，最大100。
    /// </summary>
    [JsonPropertyName("size")]
    public decimal Size { get; set; }

    /// <summary>
    /// 查询日期，日期格式为：yyyyMMdd。
    /// </summary>
    [JsonPropertyName("query_date")]
    public required string QueryDate { get; set; }
}

/// <summary>
/// 获取未登录钉钉的员工列表结果
/// </summary>
public class InactiveUserGetResult
{
    /// <summary>
    /// 下一页的偏移量。
    /// </summary>
    [JsonPropertyName("next_cursor")]
    public decimal? NextCursor { get; set; }

    /// <summary>
    /// 未登录用户列表。
    /// </summary>
    [JsonPropertyName("list")]
    public List<string> List { get; set; } = [];

    /// <summary>
    /// 是否有更多数据。
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}

/// <summary>
/// 根据手机号查询企业账号用户请求
/// </summary>
public class UserGetByMobileRequest
{
    /// <summary>
    /// 用户的手机号。
    /// </summary>
    [JsonPropertyName("mobile")]
    public required string Mobile { get; set; }

    /// <summary>
    /// 是否支持通过手机号搜索企业账号。 true：支持。 fasle：不支持。 说明 仅适用于企业账号。 仅支持搜索当前企业创建的企业账号。
    /// </summary>
    [JsonPropertyName("support_exclusive_account_search")]
    public bool SupportExclusiveAccountSearch { get; set; }
}

/// <summary>
/// 根据手机号查询企业账号用户结果
/// </summary>
public class UserGetByMobileResult
{
    /// <summary>
    /// 企业账号员工的userId列表。 说明 只返回由当前组织创建的企业账号。
    /// </summary>
    [JsonPropertyName("exclusive_account_userid_list")]
    public List<string> ExclusiveAccountUseridList { get; set; } = [];

    /// <summary>
    /// 员工的userId。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }
}

/// <summary>
/// 根据unionid获取用户userid请求
/// </summary>
public class UserGetByUnionIdRequest
{
    /// <summary>
    /// 员工在当前开发者企业账号范围内的唯一标识，系统生成，不会改变。可以通过调用根据userid获取用户详情接口或通过免登码获取用户信息(v2)获取unionid。
    /// </summary>
    [JsonPropertyName("unionid")]
    public required string Unionid { get; set; }
}

/// <summary>
/// 根据unionid获取用户userid结果
/// </summary>
public class UserGetByUnionIdResult
{
    /// <summary>
    /// 联系类型：0：企业内部员工 1：企业外部联系人
    /// </summary>
    [JsonPropertyName("contact_type")]
    public decimal? ContactType { get; set; }

    /// <summary>
    /// 用户的userid。
    /// </summary>
    [JsonPropertyName("userid")]
    public string? Userid { get; set; }
}

/// <summary>
/// 获取管理员列表请求
/// </summary>
public class UserListAdminRequest
{
}

/// <summary>
/// 获取管理员列表结果
/// </summary>
public class UserListAdminResult
{
}

/// <summary>
/// 获取管理员通讯录权限范围请求
/// </summary>
public class UserGetAdminScopeRequest
{
    /// <summary>
    /// 管理员的userid。可调用获取管理员列表调接口获取当前企业下的管理员ID。
    /// </summary>
    [JsonPropertyName("userid")]
    public required string Userid { get; set; }
}

/// <summary>
/// 获取管理员通讯录权限范围响应
/// </summary>
public class UserGetAdminScopeResponse
{
    /// <summary>
    /// 请求ID。
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }

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
    /// 可管理的部门ID列表。
    /// </summary>
    [JsonPropertyName("dept_ids")]
    public List<decimal> DeptIds { get; set; } = [];
}
