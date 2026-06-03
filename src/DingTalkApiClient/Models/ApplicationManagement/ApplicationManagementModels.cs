namespace DingTalkApiClient.Models.ApplicationManagement;

/// <summary>
/// 创建企业内部应用请求。
/// </summary>
public class CreateInnerAppRequest
{
    /// <summary>
    /// 操作人的unionId，该用户必须是拥有应用管理权限的管理员。
    /// </summary>
    public required string OpUnionId { get; set; }

    /// <summary>
    /// 应用名称。
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// 应用描述。
    /// </summary>
    public required string Desc { get; set; }

    /// <summary>
    /// 应用图标media，可调用上传媒体文件接口获取media_id参数值。
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// 应用首页地址；创建企业内部H5微应用时必传。
    /// </summary>
    public string? HomepageLink { get; set; }

    /// <summary>
    /// 应用PC端地址。
    /// </summary>
    public string? PcHomepageLink { get; set; }

    /// <summary>
    /// 应用管理后台地址。
    /// </summary>
    public string? OmpLink { get; set; }

    /// <summary>
    /// 服务器出口IP白名单列表，最大值50。
    /// </summary>
    public List<string>? IpWhiteList { get; set; }

    /// <summary>
    /// 权限类型，目前只支持BASE。
    /// </summary>
    public string? ScopeType { get; set; }

    /// <summary>
    /// 应用开发类型，0表示H5微应用，1表示小程序。
    /// </summary>
    public int? DevelopType { get; set; }
}

/// <summary>
/// 创建企业内部应用响应。
/// </summary>
public class CreateInnerAppResponse
{
    /// <summary>
    /// 应用的AgentId。
    /// </summary>
    public required long AgentId { get; set; }

    /// <summary>
    /// 应用的AppKey。
    /// </summary>
    public required string AppKey { get; set; }

    /// <summary>
    /// 应用的AppSecret。
    /// </summary>
    public required string AppSecret { get; set; }
}

/// <summary>
/// 更新企业内部应用请求。
/// </summary>
public class UpdateInnerAppRequest
{
    /// <summary>
    /// 操作更新的员工unionId，该员工必须有该应用的管理权限。
    /// </summary>
    public required string OpUnionId { get; set; }

    /// <summary>
    /// 应用名称，长度范围要求2-20个字符。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 应用描述，最大长度200个字符。
    /// </summary>
    public string? Desc { get; set; }

    /// <summary>
    /// 应用图标，可调用上传媒体文件接口获取media_id参数值。
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// 应用首页地址，请输入http或https开头的网址链接。
    /// </summary>
    public string? HomepageLink { get; set; }

    /// <summary>
    /// 应用PC端地址，请输入http或https开头的链接。
    /// </summary>
    public string? PcHomepageLink { get; set; }

    /// <summary>
    /// 应用管理后台地址，输入http或https开头的链接。
    /// </summary>
    public string? OmpLink { get; set; }

    /// <summary>
    /// 服务器出口ip白名单，支持带一个*号通配符的IP格式。
    /// </summary>
    public List<string>? IpWhiteList { get; set; }
}

/// <summary>
/// 企业应用列表响应。
/// </summary>
public class ApplicationListResponse
{
    /// <summary>
    /// 应用列表。
    /// </summary>
    public required List<ApplicationInfo> AppList { get; set; }
}

/// <summary>
/// 企业应用信息。
/// </summary>
public class ApplicationInfo
{
    /// <summary>
    /// 应用AgentId。
    /// </summary>
    public long AgentId { get; set; }

    /// <summary>
    /// 应用名称。
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 应用描述。
    /// </summary>
    public string? Desc { get; set; }

    /// <summary>
    /// 应用图标。
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// 应用移动端首页地址。
    /// </summary>
    public string? HomepageLink { get; set; }

    /// <summary>
    /// 应用PC端首页地址。
    /// </summary>
    public string? PcHomepageLink { get; set; }

    /// <summary>
    /// 应用管理后台地址。
    /// </summary>
    public string? OmpLink { get; set; }

    /// <summary>
    /// 应用ID；企业自建应用的AppId值是0。
    /// </summary>
    public long? AppId { get; set; }

    /// <summary>
    /// 应用状态，0表示停用，1表示启用，3表示过期。
    /// </summary>
    public int? AppStatus { get; set; }

    /// <summary>
    /// 应用类型，0表示H5微应用，1表示小程序。
    /// </summary>
    public int? DevelopType { get; set; }
}

/// <summary>
/// 发布企业内部小程序版本请求。
/// </summary>
public class PublishInnerMiniAppVersionRequest
{
    /// <summary>
    /// 操作人的unionId，该用户必须是拥有应用管理权限的管理员。
    /// </summary>
    public required string OpUnionId { get; set; }

    /// <summary>
    /// 小程序发布类型，online表示发布线上版本，experience表示发布体验版本。
    /// </summary>
    public string? PublishType { get; set; }

    /// <summary>
    /// 小程序版本id，用于唯一标识小程序版本信息。
    /// </summary>
    public required string AppVersionId { get; set; }

    /// <summary>
    /// 是否支持PC端打开小程序。
    /// </summary>
    public bool? MiniAppOnPc { get; set; }
}

/// <summary>
/// 回滚企业内部小程序版本请求。
/// </summary>
public class RollbackInnerMiniAppVersionRequest
{
    /// <summary>
    /// 操作人的unionId，该用户必须是拥有应用管理权限的管理员。
    /// </summary>
    public required string OpUnionId { get; set; }

    /// <summary>
    /// 小程序版本id。
    /// </summary>
    public required string VersionId { get; set; }
}

/// <summary>
/// 企业内部小程序版本列表响应。
/// </summary>
public class InnerMiniAppVersionListResponse
{
    /// <summary>
    /// 企业内部小程序版本号列表。
    /// </summary>
    public required List<InnerMiniAppVersionInfo> AppVersionList { get; set; }
}

/// <summary>
/// 企业内部小程序历史版本列表响应。
/// </summary>
public class InnerMiniAppHistoryVersionListResponse
{
    /// <summary>
    /// 当前小程序历史版本的总数量。
    /// </summary>
    public long TotalCount { get; set; }

    /// <summary>
    /// 企业内部小程序版本号列表。
    /// </summary>
    public required List<InnerMiniAppVersionInfo> MiniAppVersionList { get; set; }
}

/// <summary>
/// 企业内部小程序版本信息。
/// </summary>
public class InnerMiniAppVersionInfo
{
    /// <summary>
    /// 小程序版本id，用于发布和回滚小程序版本唯一标识。
    /// </summary>
    public long AppVersionId { get; set; }

    /// <summary>
    /// 小程序id。
    /// </summary>
    public string? MiniAppId { get; set; }

    /// <summary>
    /// 小程序版本号。
    /// </summary>
    public string? AppVersion { get; set; }

    /// <summary>
    /// 小程序版本类型，0表示开发版本，2表示正式版本，3表示体验版本。
    /// </summary>
    public int? AppVersionType { get; set; }

    /// <summary>
    /// 是否支持PC端打开小程序。
    /// </summary>
    public bool? MiniAppOnPc { get; set; }

    /// <summary>
    /// 小程序版本创建时间，格式yyyy-MM-dd HH:mm:ss。
    /// </summary>
    public string? CreateTime { get; set; }

    /// <summary>
    /// 小程序版本号更新时间，格式yyyy-MM-dd HH:mm:ss。
    /// </summary>
    public string? ModifyTime { get; set; }

    /// <summary>
    /// 企业内部小程序版本的跳转链接，目前只会返回体验版小程序的跳转链接。
    /// </summary>
    public string? EntranceLink { get; set; }
}

/// <summary>
/// 更新企业内部应用微应用的可使用范围请求。
/// </summary>
public class SetInnerAppScopeRequest
{
    /// <summary>
    /// 增加的可使用用户userId列表，最大长度100。
    /// </summary>
    public List<string>? AddUserIds { get; set; }

    /// <summary>
    /// 删除的可使用用户userId列表，最大长度100。
    /// </summary>
    public List<string>? DelUserIds { get; set; }

    /// <summary>
    /// 增加的可使用部门ID列表，最大长度100。
    /// </summary>
    public List<string>? AddDeptIds { get; set; }

    /// <summary>
    /// 删除的可使用部门ID列表，最大长度100。
    /// </summary>
    public List<string>? DelDeptIds { get; set; }

    /// <summary>
    /// 增加的可使用角色列表，最大长度100。
    /// </summary>
    public List<string>? AddRoleIds { get; set; }

    /// <summary>
    /// 删除的可使用角色列表，最大长度100。
    /// </summary>
    public List<string>? DelRoleIds { get; set; }

    /// <summary>
    /// 是否仅管理员可使用。
    /// </summary>
    public bool? OnlyAdminVisible { get; set; }
}

/// <summary>
/// 企业内部应用微应用的可使用范围。
/// </summary>
public class InnerAppScope
{
    /// <summary>
    /// 用户userId。
    /// </summary>
    public required List<string> UserIds { get; set; }

    /// <summary>
    /// 部门ID。
    /// </summary>
    public required List<long> DeptIds { get; set; }

    /// <summary>
    /// 角色ID。
    /// </summary>
    public required List<long> RoleIds { get; set; }

    /// <summary>
    /// 是否仅管理员可使用。
    /// </summary>
    public bool OnlyAdminVisible { get; set; }
}
