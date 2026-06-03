using System.Text.Json;

using System.Text.Json.Serialization;



namespace DingTalkApi.Models.DocumentFile;



/// <summary>
/// 知识库图标。
/// </summary>
public class PostV20WikiWorkspacesResponseWorkspaceIcon
{
    /// <summary>
    /// 图标类型，枚举值: URL：链接 EMOJI：emoji图标
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 图标值： 当 type 为 URL 时，返回图标链接。 当 type 为 EMOJI 时，返回 emoji 图标的 unicode 值。
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// 知识库。
/// </summary>
public class PostV20WikiWorkspacesResponseWorkspace
{
    /// <summary>
    /// 知识库id(spaceUuid)。
    /// </summary>
    [JsonPropertyName("workspaceId")]
    public required string WorkspaceId { get; set; }
    /// <summary>
    /// 知识库归属企业的corpId。
    /// </summary>
    [JsonPropertyName("corpId")]
    public required string CorpId { get; set; }
    /// <summary>
    /// 知识库归属知识小组的id。 说明 不归属任何知识小组的时候, 返回空
    /// </summary>
    [JsonPropertyName("teamId")]
    public required string TeamId { get; set; }
    /// <summary>
    /// 根节点id(根节点dentryUuid)。
    /// </summary>
    [JsonPropertyName("rootNodeId")]
    public required string RootNodeId { get; set; }
    /// <summary>
    /// 知识库名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 知识库类型，枚举值: TEAM：知识库 PERSONAL：我的文档
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 知识库简介。
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }
    /// <summary>
    /// 知识库访问url。
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
    /// <summary>
    /// 知识库图标。
    /// </summary>
    [JsonPropertyName("icon")]
    public required PostV20WikiWorkspacesResponseWorkspaceIcon Icon { get; set; }
    /// <summary>
    /// 知识库封面url。
    /// </summary>
    [JsonPropertyName("cover")]
    public required string Cover { get; set; }
    /// <summary>
    /// 知识库创建者userId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// 知识库修改者userId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 知识库创建时间。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 知识库修改时间。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
    /// <summary>
    /// 查询人对知识库的权限角色，枚举值: OWNER：拥有者 MANAGER：管理者 EDITOR：编辑者 DOWNLOADER：可查看下载者 READER：仅可查看者 NONE：无权限者
    /// </summary>
    [JsonPropertyName("permissionRole")]
    public required string PermissionRole { get; set; }
}

/// <summary>
/// 新建知识库响应
/// </summary>
public class PostV20WikiWorkspacesResponse
{
    /// <summary>
    /// 知识库。
    /// </summary>
    [JsonPropertyName("workspace")]
    public required PostV20WikiWorkspacesResponseWorkspace Workspace { get; set; }
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV20WikiWorkspacesRequestOption
{
    /// <summary>
    /// 知识库描述。
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    /// <summary>
    /// 知识小组id： 企业内部应用，可通过获取知识小组列表接口，获取返回参数teamId字段。 第三方企业应用，可通过获取知识小组列表接口，获取返回参数teamId字段。
    /// </summary>
    [JsonPropertyName("teamId")]
    public string? TeamId { get; set; }
}

/// <summary>
/// 新建知识库请求
/// </summary>
public class PostV20WikiWorkspacesRequest
{
    /// <summary>
    /// 知识库名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public PostV20WikiWorkspacesRequestOption? Option { get; set; }
}

/// <summary>
/// 知识库图标。
/// </summary>
public class GetV20WikiWorkspacesResponseWorkspaceIcon
{
    /// <summary>
    /// 图标类型，枚举值: URL：链接 EMOJI：emoji图标
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 图标值： 当 type 为 URL 时，返回图标链接。 当 type 为 EMOJI 时，返回 emoji 图标的 unicode 值。
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// 知识库。
/// </summary>
public class GetV20WikiWorkspacesResponseWorkspace
{
    /// <summary>
    /// 知识库id(spaceUuid)。
    /// </summary>
    [JsonPropertyName("workspaceId")]
    public required string WorkspaceId { get; set; }
    /// <summary>
    /// 知识库归属企业的corpId。
    /// </summary>
    [JsonPropertyName("corpId")]
    public required string CorpId { get; set; }
    /// <summary>
    /// 知识库归属知识小组的id。 说明 不归属任何知识小组的时候, 返回空
    /// </summary>
    [JsonPropertyName("teamId")]
    public required string TeamId { get; set; }
    /// <summary>
    /// 根节点id(根节点dentryUuid)。
    /// </summary>
    [JsonPropertyName("rootNodeId")]
    public required string RootNodeId { get; set; }
    /// <summary>
    /// 知识库名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 知识库类型，枚举值: TEAM：知识库 PERSONAL：我的文档
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 知识库简介。
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }
    /// <summary>
    /// 知识库访问url。
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
    /// <summary>
    /// 知识库图标。
    /// </summary>
    [JsonPropertyName("icon")]
    public required GetV20WikiWorkspacesResponseWorkspaceIcon Icon { get; set; }
    /// <summary>
    /// 知识库封面url。
    /// </summary>
    [JsonPropertyName("cover")]
    public required string Cover { get; set; }
    /// <summary>
    /// 知识库创建者userId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// 知识库修改者userId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 知识库创建时间。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 知识库修改时间。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
    /// <summary>
    /// 查询人对知识库的权限角色，枚举值: OWNER：拥有者 MANAGER：管理者 EDITOR：编辑者 DOWNLOADER：可查看下载者 READER：仅可查看者 NONE：无权限者
    /// </summary>
    [JsonPropertyName("permissionRole")]
    public required string PermissionRole { get; set; }
}

/// <summary>
/// 获取知识库列表响应
/// </summary>
public class GetV20WikiWorkspacesResponse
{
    /// <summary>
    /// 知识库。
    /// </summary>
    [JsonPropertyName("workspace")]
    public required GetV20WikiWorkspacesResponseWorkspace Workspace { get; set; }
    /// <summary>
    /// 分页游标。 说明 不为空表示有更多数据。
    /// </summary>
    [JsonPropertyName("nextToken")]
    public required string NextToken { get; set; }
}

/// <summary>
/// 知识库图标。
/// </summary>
public class GetV20WikiWorkspacesByWorkspaceIdResponseWorkspaceIcon
{
    /// <summary>
    /// 图标类型，枚举值: URL：链接 EMOJI：emoji图标
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 图标值： 当 type 为 URL 时，返回图标链接。 当 type 为 EMOJI 时，返回 emoji 图标的 unicode 值。
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// 知识库。
/// </summary>
public class GetV20WikiWorkspacesByWorkspaceIdResponseWorkspace
{
    /// <summary>
    /// 知识库id(spaceUuid)。
    /// </summary>
    [JsonPropertyName("workspaceId")]
    public required string WorkspaceId { get; set; }
    /// <summary>
    /// 知识库归属企业的corpId。
    /// </summary>
    [JsonPropertyName("corpId")]
    public required string CorpId { get; set; }
    /// <summary>
    /// 知识库归属知识小组的id。 说明 不归属任何知识小组的时候, 返回空
    /// </summary>
    [JsonPropertyName("teamId")]
    public required string TeamId { get; set; }
    /// <summary>
    /// 根节点id(根节点dentryUuid)。
    /// </summary>
    [JsonPropertyName("rootNodeId")]
    public required string RootNodeId { get; set; }
    /// <summary>
    /// 知识库名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 知识库类型，枚举值: TEAM：知识库 PERSONAL：我的文档
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 知识库简介。
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }
    /// <summary>
    /// 知识库访问url。
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
    /// <summary>
    /// 知识库图标。
    /// </summary>
    [JsonPropertyName("icon")]
    public required GetV20WikiWorkspacesByWorkspaceIdResponseWorkspaceIcon Icon { get; set; }
    /// <summary>
    /// 知识库封面url。
    /// </summary>
    [JsonPropertyName("cover")]
    public required string Cover { get; set; }
    /// <summary>
    /// 知识库创建者userId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// 知识库修改者userId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 知识库创建时间。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 知识库修改时间。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
    /// <summary>
    /// 查询人对知识库的权限角色，枚举值: OWNER：拥有者 MANAGER：管理者 EDITOR：编辑者 DOWNLOADER：可查看下载者 READER：仅可查看者 NONE：无权限者
    /// </summary>
    [JsonPropertyName("permissionRole")]
    public required string PermissionRole { get; set; }
}

/// <summary>
/// 获取知识库响应
/// </summary>
public class GetV20WikiWorkspacesByWorkspaceIdResponse
{
    /// <summary>
    /// 知识库。
    /// </summary>
    [JsonPropertyName("workspace")]
    public required GetV20WikiWorkspacesByWorkspaceIdResponseWorkspace Workspace { get; set; }
}

/// <summary>
/// 知识库图标。
/// </summary>
public class PostV20WikiWorkspacesBatchQueryResponseWorkspaceIcon
{
    /// <summary>
    /// 图标类型，枚举值: URL：链接 EMOJI：emoji图标
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 图标值： 当 type 为 URL 时，返回图标链接。 当 type 为 EMOJI 时，返回 emoji 图标的 unicode 值。
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// 知识库。
/// </summary>
public class PostV20WikiWorkspacesBatchQueryResponseWorkspace
{
    /// <summary>
    /// 知识库id(spaceUuid)。
    /// </summary>
    [JsonPropertyName("workspaceId")]
    public required string WorkspaceId { get; set; }
    /// <summary>
    /// 知识库归属企业的corpId。
    /// </summary>
    [JsonPropertyName("corpId")]
    public required string CorpId { get; set; }
    /// <summary>
    /// 知识库归属知识小组的id。 说明 不归属任何知识小组的时候, 返回空
    /// </summary>
    [JsonPropertyName("teamId")]
    public required string TeamId { get; set; }
    /// <summary>
    /// 根节点id(根节点dentryUuid)。
    /// </summary>
    [JsonPropertyName("rootNodeId")]
    public required string RootNodeId { get; set; }
    /// <summary>
    /// 知识库名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 知识库类型，枚举值: TEAM：知识库 PERSONAL：我的文档
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 知识库简介。
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }
    /// <summary>
    /// 知识库访问url。
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
    /// <summary>
    /// 知识库图标。
    /// </summary>
    [JsonPropertyName("icon")]
    public required PostV20WikiWorkspacesBatchQueryResponseWorkspaceIcon Icon { get; set; }
    /// <summary>
    /// 知识库封面url。
    /// </summary>
    [JsonPropertyName("cover")]
    public required string Cover { get; set; }
    /// <summary>
    /// 知识库创建者userId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// 知识库修改者userId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 知识库创建时间。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 知识库修改时间。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
    /// <summary>
    /// 查询人对知识库的权限角色，枚举值: OWNER：拥有者 MANAGER：管理者 EDITOR：编辑者 DOWNLOADER：可查看下载者 READER：仅可查看者 NONE：无权限者
    /// </summary>
    [JsonPropertyName("permissionRole")]
    public required string PermissionRole { get; set; }
}

/// <summary>
/// 批量获取知识库响应
/// </summary>
public class PostV20WikiWorkspacesBatchQueryResponse
{
    /// <summary>
    /// 知识库。
    /// </summary>
    [JsonPropertyName("workspace")]
    public required PostV20WikiWorkspacesBatchQueryResponseWorkspace Workspace { get; set; }
}

/// <summary>
/// 可选参数
/// </summary>
public class PostV20WikiWorkspacesBatchQueryRequestOption
{
    /// <summary>
    /// 扩展数据。
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object?> ExtensionData { get; set; } = [];
}

/// <summary>
/// 批量获取知识库请求
/// </summary>
public class PostV20WikiWorkspacesBatchQueryRequest
{
    /// <summary>
    /// 知识库id： 企业内部应用，可通过调用获取知识库列表接口，获取返回参数workspaceId字段。 第三方企业应用，可通过调用获取知识库列表接口，获取返回参数workspaceId字段。 说明 最大size20。
    /// </summary>
    [JsonPropertyName("workspaceIds")]
    public List<string> WorkspaceIds { get; set; } = [];
    /// <summary>
    /// 可选参数
    /// </summary>
    [JsonPropertyName("option")]
    public required PostV20WikiWorkspacesBatchQueryRequestOption Option { get; set; }
}

/// <summary>
/// 知识库图标。
/// </summary>
public class GetV20WikiMineWorkspacesResponseWorkspaceIcon
{
    /// <summary>
    /// 图标类型，枚举值: URL：链接 EMOJI：emoji图标
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 图标值： 当 type 为 URL 时，返回图标链接。 当 type 为 EMOJI 时，返回 emoji 图标的 unicode 值。
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// 知识库。
/// </summary>
public class GetV20WikiMineWorkspacesResponseWorkspace
{
    /// <summary>
    /// 知识库id(spaceUuid)。
    /// </summary>
    [JsonPropertyName("workspaceId")]
    public required string WorkspaceId { get; set; }
    /// <summary>
    /// 知识库归属企业的corpId。
    /// </summary>
    [JsonPropertyName("corpId")]
    public required string CorpId { get; set; }
    /// <summary>
    /// 知识库归属知识小组的id。 说明 不归属任何知识小组的时候, 返回空
    /// </summary>
    [JsonPropertyName("teamId")]
    public required string TeamId { get; set; }
    /// <summary>
    /// 根节点id(根节点dentryUuid)。
    /// </summary>
    [JsonPropertyName("rootNodeId")]
    public required string RootNodeId { get; set; }
    /// <summary>
    /// 知识库名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 知识库类型，枚举值: TEAM：知识库 PERSONAL：我的文档
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 知识库简介。
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }
    /// <summary>
    /// 知识库访问url。
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
    /// <summary>
    /// 知识库图标。
    /// </summary>
    [JsonPropertyName("icon")]
    public required GetV20WikiMineWorkspacesResponseWorkspaceIcon Icon { get; set; }
    /// <summary>
    /// 知识库封面url。
    /// </summary>
    [JsonPropertyName("cover")]
    public required string Cover { get; set; }
    /// <summary>
    /// 知识库创建者userId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// 知识库修改者userId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 知识库创建时间。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 知识库修改时间。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
    /// <summary>
    /// 查询人对知识库的权限角色，枚举值: OWNER：拥有者 MANAGER：管理者 EDITOR：编辑者 DOWNLOADER：可查看下载者 READER：仅可查看者 NONE：无权限者
    /// </summary>
    [JsonPropertyName("permissionRole")]
    public required string PermissionRole { get; set; }
}

/// <summary>
/// 获取我的文档知识库信息响应
/// </summary>
public class GetV20WikiMineWorkspacesResponse
{
    /// <summary>
    /// 知识库。
    /// </summary>
    [JsonPropertyName("workspace")]
    public required GetV20WikiMineWorkspacesResponseWorkspace Workspace { get; set; }
}

/// <summary>
/// 创建知识库文档响应
/// </summary>
public class PostV10DocWorkspacesByWorkspaceIdDocsResponse
{
    /// <summary>
    /// 知识库ID。
    /// </summary>
    [JsonPropertyName("workspaceId")]
    public required string WorkspaceId { get; set; }
    /// <summary>
    /// 知识库文档ID。
    /// </summary>
    [JsonPropertyName("nodeId")]
    public required string NodeId { get; set; }
    /// <summary>
    /// 文档docKey。
    /// </summary>
    [JsonPropertyName("docKey")]
    public required string DocKey { get; set; }
    /// <summary>
    /// 文档URL。
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>
/// 创建知识库文档请求
/// </summary>
public class PostV10DocWorkspacesByWorkspaceIdDocsRequest
{
    /// <summary>
    /// 文档名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 文档类型，取值： DOC：文字 WORKBOOK：表格 MIND：脑图 FOLDER：文件夹
    /// </summary>
    [JsonPropertyName("docType")]
    public required string DocType { get; set; }
    /// <summary>
    /// 用户的unionId。 企业内部应用，调用查询用户详情接口获取unionid参数值。 第三方企业应用，调用查询用户详情接口获取unionid参数值。
    /// </summary>
    [JsonPropertyName("operatorId")]
    public required string OperatorId { get; set; }
    /// <summary>
    /// 父节点Id，如果不传，默认在根目录创建。 说明 父节点可以是文件夹，也可以是普通的文档。 企业内部应用，调用查询知识库下的目录结构接口获取DentryModel参数值。 第三方企业应用，调用查询知识库下的目录结构接口获取DentryModel参数值。
    /// </summary>
    [JsonPropertyName("parentNodeId")]
    public string? ParentNodeId { get; set; }
    /// <summary>
    /// 文档模板id。 企业内部应用，调用查询文档模板接口获取id参数值。 第三方企业应用，调用查询文档模板接口获取id参数值。
    /// </summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }
    /// <summary>
    /// 文档模版类型，支持以下值： public_template：推荐模版 team_template：团队模版 user_template：个人模版
    /// </summary>
    [JsonPropertyName("templateType")]
    public string? TemplateType { get; set; }
}

/// <summary>
/// 统计信息。
/// </summary>
public class GetV20WikiNodesByNodeIdResponseNodeStatisticalInfo
{
    /// <summary>
    /// 字数。
    /// </summary>
    [JsonPropertyName("wordCount")]
    public long WordCount { get; set; }
}

/// <summary>
/// 节点。
/// </summary>
public class GetV20WikiNodesByNodeIdResponseNode
{
    /// <summary>
    /// 节点id(dentryUuid)。
    /// </summary>
    [JsonPropertyName("nodeId")]
    public required string NodeId { get; set; }
    /// <summary>
    /// 知识库id(spaceUuid)。
    /// </summary>
    [JsonPropertyName("workspaceId")]
    public required string WorkspaceId { get; set; }
    /// <summary>
    /// 名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 大小。
    /// </summary>
    [JsonPropertyName("size")]
    public long Size { get; set; }
    /// <summary>
    /// 类型，枚举值： FILE：文件 FOLDER：文件夹
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 类别，枚举值: ALIDOC：钉钉文档 DOCUMENT：本地文档 IMAGE：图片 VIDEO：视频 AUDIO：音频 ARCHIVE：归档文件 OTHER：其他类型
    /// </summary>
    [JsonPropertyName("category")]
    public required string Category { get; set; }
    /// <summary>
    /// 后缀。
    /// </summary>
    [JsonPropertyName("extension")]
    public required string Extension { get; set; }
    /// <summary>
    /// 访问url。
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
    /// <summary>
    /// 创建者userId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// 修改者userId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 创建时间。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 修改时间。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
    /// <summary>
    /// 是否有子节点。
    /// </summary>
    [JsonPropertyName("hasChildren")]
    public bool HasChildren { get; set; }
    /// <summary>
    /// 统计信息。
    /// </summary>
    [JsonPropertyName("statisticalInfo")]
    public required GetV20WikiNodesByNodeIdResponseNodeStatisticalInfo StatisticalInfo { get; set; }
    /// <summary>
    /// 当前用户对知识库节点的权限角色，枚举值: OWNER：拥有者 MANAGER：管理者 EDITOR：编辑者 DOWNLOADER：可查看下载者 READER：仅可查看者 NONE：无权限者
    /// </summary>
    [JsonPropertyName("permissionRole")]
    public required string PermissionRole { get; set; }
}

/// <summary>
/// 获取节点响应
/// </summary>
public class GetV20WikiNodesByNodeIdResponse
{
    /// <summary>
    /// 节点。
    /// </summary>
    [JsonPropertyName("node")]
    public required GetV20WikiNodesByNodeIdResponseNode Node { get; set; }
}

/// <summary>
/// 统计信息。
/// </summary>
public class GetV20WikiNodesResponseNodeStatisticalInfo
{
    /// <summary>
    /// 字数。
    /// </summary>
    [JsonPropertyName("wordCount")]
    public long WordCount { get; set; }
}

/// <summary>
/// 节点。
/// </summary>
public class GetV20WikiNodesResponseNode
{
    /// <summary>
    /// 节点id(dentryUuid)。
    /// </summary>
    [JsonPropertyName("nodeId")]
    public required string NodeId { get; set; }
    /// <summary>
    /// 知识库id(spaceUuid)。
    /// </summary>
    [JsonPropertyName("workspaceId")]
    public required string WorkspaceId { get; set; }
    /// <summary>
    /// 名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 大小。
    /// </summary>
    [JsonPropertyName("size")]
    public long Size { get; set; }
    /// <summary>
    /// 类型，枚举值： FILE：文件 FOLDER：文件夹
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 类别，枚举值: ALIDOC：钉钉文档 DOCUMENT：本地文档 IMAGE：图片 VIDEO：视频 AUDIO：音频 ARCHIVE：归档文件 OTHER：其他类型
    /// </summary>
    [JsonPropertyName("category")]
    public required string Category { get; set; }
    /// <summary>
    /// 后缀。
    /// </summary>
    [JsonPropertyName("extension")]
    public required string Extension { get; set; }
    /// <summary>
    /// 访问url。
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
    /// <summary>
    /// 创建者userId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// 修改者userId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 创建时间。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 修改时间。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
    /// <summary>
    /// 是否有子节点。
    /// </summary>
    [JsonPropertyName("hasChildren")]
    public bool HasChildren { get; set; }
    /// <summary>
    /// 统计信息。
    /// </summary>
    [JsonPropertyName("statisticalInfo")]
    public required GetV20WikiNodesResponseNodeStatisticalInfo StatisticalInfo { get; set; }
    /// <summary>
    /// 当前用户对知识库节点的权限角色，枚举值: OWNER：拥有者 MANAGER：管理者 EDITOR：编辑者 DOWNLOADER：可查看下载者 READER：仅可查看者 NONE：无权限者
    /// </summary>
    [JsonPropertyName("permissionRole")]
    public required string PermissionRole { get; set; }
}

/// <summary>
/// 获取节点列表响应
/// </summary>
public class GetV20WikiNodesResponse
{
    /// <summary>
    /// 节点。
    /// </summary>
    [JsonPropertyName("node")]
    public required GetV20WikiNodesResponseNode Node { get; set; }
    /// <summary>
    /// 分页游标。 说明 不为空表示有更多数据。
    /// </summary>
    [JsonPropertyName("nextToken")]
    public required string NextToken { get; set; }
}

/// <summary>
/// 统计信息。
/// </summary>
public class PostV20WikiNodesQueryByUrlResponseNodeStatisticalInfo
{
    /// <summary>
    /// 字数。
    /// </summary>
    [JsonPropertyName("wordCount")]
    public long WordCount { get; set; }
}

/// <summary>
/// 节点。
/// </summary>
public class PostV20WikiNodesQueryByUrlResponseNode
{
    /// <summary>
    /// 节点id(dentryUuid)。
    /// </summary>
    [JsonPropertyName("nodeId")]
    public required string NodeId { get; set; }
    /// <summary>
    /// 知识库id(spaceUuid)。
    /// </summary>
    [JsonPropertyName("workspaceId")]
    public required string WorkspaceId { get; set; }
    /// <summary>
    /// 名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 大小。
    /// </summary>
    [JsonPropertyName("size")]
    public long Size { get; set; }
    /// <summary>
    /// 类型，枚举值： FILE：文件 FOLDER：文件夹
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 类别，枚举值: ALIDOC：钉钉文档 DOCUMENT：本地文档 IMAGE：图片 VIDEO：视频 AUDIO：音频 ARCHIVE：归档文件 OTHER：其他类型
    /// </summary>
    [JsonPropertyName("category")]
    public required string Category { get; set; }
    /// <summary>
    /// 后缀。
    /// </summary>
    [JsonPropertyName("extension")]
    public required string Extension { get; set; }
    /// <summary>
    /// 访问url。
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
    /// <summary>
    /// 创建者userId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// 修改者userId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 创建时间。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 修改时间。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
    /// <summary>
    /// 是否有子节点。
    /// </summary>
    [JsonPropertyName("hasChildren")]
    public bool HasChildren { get; set; }
    /// <summary>
    /// 统计信息。
    /// </summary>
    [JsonPropertyName("statisticalInfo")]
    public required PostV20WikiNodesQueryByUrlResponseNodeStatisticalInfo StatisticalInfo { get; set; }
    /// <summary>
    /// 当前用户对知识库节点的权限角色，枚举值: OWNER：拥有者 MANAGER：管理者 EDITOR：编辑者 DOWNLOADER：可查看下载者 READER：仅可查看者 NONE：无权限者
    /// </summary>
    [JsonPropertyName("permissionRole")]
    public required string PermissionRole { get; set; }
}

/// <summary>
/// 通过链接获取节点响应
/// </summary>
public class PostV20WikiNodesQueryByUrlResponse
{
    /// <summary>
    /// 节点。
    /// </summary>
    [JsonPropertyName("node")]
    public required PostV20WikiNodesQueryByUrlResponseNode Node { get; set; }
}

/// <summary>
/// 可选参数
/// </summary>
public class PostV20WikiNodesQueryByUrlRequestOption
{
    /// <summary>
    /// 扩展数据。
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object?> ExtensionData { get; set; } = [];
}

/// <summary>
/// 通过链接获取节点请求
/// </summary>
public class PostV20WikiNodesQueryByUrlRequest
{
    /// <summary>
    /// 文档链接
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
    /// <summary>
    /// 可选参数
    /// </summary>
    [JsonPropertyName("option")]
    public PostV20WikiNodesQueryByUrlRequestOption? Option { get; set; }
}

/// <summary>
/// 统计信息。
/// </summary>
public class PostV20WikiNodesBatchQueryResponseNodeStatisticalInfo
{
    /// <summary>
    /// 字数。
    /// </summary>
    [JsonPropertyName("wordCount")]
    public long WordCount { get; set; }
}

/// <summary>
/// 节点。
/// </summary>
public class PostV20WikiNodesBatchQueryResponseNode
{
    /// <summary>
    /// 节点id(dentryUuid)。
    /// </summary>
    [JsonPropertyName("nodeId")]
    public required string NodeId { get; set; }
    /// <summary>
    /// 知识库id(spaceUuid)。
    /// </summary>
    [JsonPropertyName("workspaceId")]
    public required string WorkspaceId { get; set; }
    /// <summary>
    /// 名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 大小。
    /// </summary>
    [JsonPropertyName("size")]
    public long Size { get; set; }
    /// <summary>
    /// 类型，枚举值： FILE：文件 FOLDER：文件夹
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 类别，枚举值: ALIDOC：钉钉文档 DOCUMENT：本地文档 IMAGE：图片 VIDEO：视频 AUDIO：音频 ARCHIVE：归档文件 OTHER：其他类型
    /// </summary>
    [JsonPropertyName("category")]
    public required string Category { get; set; }
    /// <summary>
    /// 后缀。
    /// </summary>
    [JsonPropertyName("extension")]
    public required string Extension { get; set; }
    /// <summary>
    /// 访问url。
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
    /// <summary>
    /// 创建者userId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// 修改者userId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 创建时间。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 修改时间。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
    /// <summary>
    /// 是否有子节点。
    /// </summary>
    [JsonPropertyName("hasChildren")]
    public bool HasChildren { get; set; }
    /// <summary>
    /// 统计信息。
    /// </summary>
    [JsonPropertyName("statisticalInfo")]
    public required PostV20WikiNodesBatchQueryResponseNodeStatisticalInfo StatisticalInfo { get; set; }
    /// <summary>
    /// 当前用户对知识库节点的权限角色，枚举值: OWNER：拥有者 MANAGER：管理者 EDITOR：编辑者 DOWNLOADER：可查看下载者 READER：仅可查看者 NONE：无权限者
    /// </summary>
    [JsonPropertyName("permissionRole")]
    public required string PermissionRole { get; set; }
}

/// <summary>
/// 批量获取节点响应
/// </summary>
public class PostV20WikiNodesBatchQueryResponse
{
    /// <summary>
    /// 节点。
    /// </summary>
    [JsonPropertyName("node")]
    public required PostV20WikiNodesBatchQueryResponseNode Node { get; set; }
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV20WikiNodesBatchQueryRequestOption
{
    /// <summary>
    /// 扩展数据。
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object?> ExtensionData { get; set; } = [];
}

/// <summary>
/// 批量获取节点请求
/// </summary>
public class PostV20WikiNodesBatchQueryRequest
{
    /// <summary>
    /// 节点id。 说明 最大size20。
    /// </summary>
    [JsonPropertyName("nodeIds")]
    public List<string> NodeIds { get; set; } = [];
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public PostV20WikiNodesBatchQueryRequestOption? Option { get; set; }
}

/// <summary>
/// 新建空间响应
/// </summary>
public class PostV10DriveSpacesResponse
{
    /// <summary>
    /// 空间ID。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public string? SpaceId { get; set; }
    /// <summary>
    /// 空间名称。
    /// </summary>
    [JsonPropertyName("spaceName")]
    public string? SpaceName { get; set; }
    /// <summary>
    /// 空间类型。
    /// </summary>
    [JsonPropertyName("spaceType")]
    public string? SpaceType { get; set; }
    /// <summary>
    /// 空间总额度。
    /// </summary>
    [JsonPropertyName("quota")]
    public long? Quota { get; set; }
    /// <summary>
    /// 空间已使用额度。
    /// </summary>
    [JsonPropertyName("usedQuota")]
    public long? UsedQuota { get; set; }
    /// <summary>
    /// 授权模式，取值：
    /// </summary>
    [JsonPropertyName("permissionMode")]
    public string? PermissionMode { get; set; }
    /// <summary>
    /// 创建时间。
    /// </summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }
    /// <summary>
    /// 修改时间。
    /// </summary>
    [JsonPropertyName("modifyTime")]
    public string? ModifyTime { get; set; }
}

/// <summary>
/// 新建空间请求
/// </summary>
public class PostV10DriveSpacesRequest
{
    /// <summary>
    /// 空间名称（不能为空）。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 用户unionId，可以调用通过免登码获取用户信息(v2)接口获取。
    /// </summary>
    [JsonPropertyName("unionId")]
    public required string UnionId { get; set; }
}

/// <summary>
/// GetV10DriveSpacesResponseSpacesItem
/// </summary>
public class GetV10DriveSpacesResponseSpacesItem
{
    /// <summary>
    /// 空间ID。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public string? SpaceId { get; set; }
    /// <summary>
    /// 空间名称。
    /// </summary>
    [JsonPropertyName("spaceName")]
    public string? SpaceName { get; set; }
    /// <summary>
    /// 空间类型。
    /// </summary>
    [JsonPropertyName("spaceType")]
    public string? SpaceType { get; set; }
    /// <summary>
    /// 空间总额度。 -1表示该空间额度无限制，如果有企业属性, 不能超过企业空间额度。
    /// </summary>
    [JsonPropertyName("quota")]
    public long? Quota { get; set; }
    /// <summary>
    /// 空间已使用额度。
    /// </summary>
    [JsonPropertyName("usedQuota")]
    public long? UsedQuota { get; set; }
    /// <summary>
    /// 授权模式，取值：
    /// </summary>
    [JsonPropertyName("permissionMode")]
    public string? PermissionMode { get; set; }
    /// <summary>
    /// 创建时间。
    /// </summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }
    /// <summary>
    /// 修改时间。
    /// </summary>
    [JsonPropertyName("modifyTime")]
    public string? ModifyTime { get; set; }
}

/// <summary>
/// 获取空间列表响应
/// </summary>
public class GetV10DriveSpacesResponse
{
    /// <summary>
    /// 空间列表。
    /// </summary>
    [JsonPropertyName("spaces")]
    public List<GetV10DriveSpacesResponseSpacesItem> Spaces { get; set; } = [];
    /// <summary>
    /// 下一页的游标，为空字符串则表示分页结束。
    /// </summary>
    [JsonPropertyName("nextToken")]
    public string? NextToken { get; set; }
}

/// <summary>
/// 获取空间列表请求
/// </summary>
public class GetV10DriveSpacesRequest
{
    /// <summary>
    /// 扩展数据。
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object?> ExtensionData { get; set; } = [];
}

/// <summary>
/// 删除空间响应
/// </summary>
public class DeleteV10DriveSpacesBySpaceIdResponse
{
    /// <summary>
    /// 扩展数据。
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object?> ExtensionData { get; set; } = [];
}

/// <summary>
/// 会话存储空间信息。
/// </summary>
public class PostV10ConvFileConversationsSpacesQueryResponseSpace
{
    /// <summary>
    /// 会话存储空间ID。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public required string SpaceId { get; set; }
    /// <summary>
    /// 空间归属企业的corpId。
    /// </summary>
    [JsonPropertyName("corpId")]
    public required string CorpId { get; set; }
    /// <summary>
    /// 群存储空间的创建时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 群存储空间的修改时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
}

/// <summary>
/// 获取群存储空间信息响应
/// </summary>
public class PostV10ConvFileConversationsSpacesQueryResponse
{
    /// <summary>
    /// 会话存储空间信息。
    /// </summary>
    [JsonPropertyName("space")]
    public required PostV10ConvFileConversationsSpacesQueryResponseSpace Space { get; set; }
}

/// <summary>
/// 获取群存储空间信息请求
/// </summary>
public class PostV10ConvFileConversationsSpacesQueryRequest
{
    /// <summary>
    /// 会话openConversationId。 企业内部应用，调用创建群会话接口获取openConversationId参数值。
    /// </summary>
    [JsonPropertyName("openConversationId")]
    public required string OpenConversationId { get; set; }
}

/// <summary>
/// 发送到目标会话的文件信息。
/// </summary>
public class PostV10ConvFileAppsConversationsFilesSendResponseFile
{
    /// <summary>
    /// 文件ID。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 文件所在会话ID。
    /// </summary>
    [JsonPropertyName("conversationId")]
    public required string ConversationId { get; set; }
    /// <summary>
    /// 文件所在空间ID。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public required string SpaceId { get; set; }
    /// <summary>
    /// 文件所在的父目录ID。根目录时，该参数是0。
    /// </summary>
    [JsonPropertyName("parentId")]
    public required string ParentId { get; set; }
    /// <summary>
    /// 文件类型。 FILE：文件 FOLDER：文件夹 说明 本接口只能发送文件。
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 文件名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 文件大小，单位Byte。
    /// </summary>
    [JsonPropertyName("size")]
    public long Size { get; set; }
    /// <summary>
    /// 文件路径。
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }
    /// <summary>
    /// 文件版本。
    /// </summary>
    [JsonPropertyName("version")]
    public long Version { get; set; }
    /// <summary>
    /// 文件状态。 NORMAL：正常 DELETED：已删除 EXPIRED：已过期
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }
    /// <summary>
    /// 文件后缀。
    /// </summary>
    [JsonPropertyName("extension")]
    public required string Extension { get; set; }
    /// <summary>
    /// 创建者unionId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// 修改者unionId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 创建时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 修改时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
}

/// <summary>
/// 以应用身份发送文件给指定用户响应
/// </summary>
public class PostV10ConvFileAppsConversationsFilesSendResponse
{
    /// <summary>
    /// 发送到目标会话的文件信息。
    /// </summary>
    [JsonPropertyName("file")]
    public required PostV10ConvFileAppsConversationsFilesSendResponseFile File { get; set; }
}

/// <summary>
/// 以应用身份发送文件给指定用户请求
/// </summary>
public class PostV10ConvFileAppsConversationsFilesSendRequest
{
    /// <summary>
    /// 文件所在空间ID。 企业内部应用，调用添加空间接口获取id参数值。 第三方企业应用，调用添加空间接口获取id参数值。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public required string SpaceId { get; set; }
    /// <summary>
    /// 文件ID。 企业内部应用，调用获取文件或文件夹列表接口获取id参数值。 第三方企业应用，调用获取文件或文件夹列表接口获取id参数值。
    /// </summary>
    [JsonPropertyName("dentryId")]
    public required string DentryId { get; set; }
}

/// <summary>
/// 发送到目标会话的文件信息。
/// </summary>
public class PostV10ConvFileConversationsFilesSendResponseFile
{
    /// <summary>
    /// 文件ID。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 文件所在会话ID。
    /// </summary>
    [JsonPropertyName("conversationId")]
    public required string ConversationId { get; set; }
    /// <summary>
    /// 文件所在空间ID。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public required string SpaceId { get; set; }
    /// <summary>
    /// 文件所在的父目录ID。根目录时，该参数是0。
    /// </summary>
    [JsonPropertyName("parentId")]
    public required string ParentId { get; set; }
    /// <summary>
    /// 文件类型。 FILE：文件 FOLDER：文件夹 说明 本接口只能发送文件。
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 文件名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 文件大小，单位Byte。
    /// </summary>
    [JsonPropertyName("size")]
    public long Size { get; set; }
    /// <summary>
    /// 文件路径。
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }
    /// <summary>
    /// 文件版本。
    /// </summary>
    [JsonPropertyName("version")]
    public long Version { get; set; }
    /// <summary>
    /// 文件状态。 NORMAL：正常 DELETED：已删除 EXPIRED：已过期
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }
    /// <summary>
    /// 文件后缀。
    /// </summary>
    [JsonPropertyName("extension")]
    public required string Extension { get; set; }
    /// <summary>
    /// 创建者unionId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// 修改者unionId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 创建时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 修改时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
}

/// <summary>
/// 发送文件到指定会话响应
/// </summary>
public class PostV10ConvFileConversationsFilesSendResponse
{
    /// <summary>
    /// 发送到目标会话的文件信息。
    /// </summary>
    [JsonPropertyName("file")]
    public required PostV10ConvFileConversationsFilesSendResponseFile File { get; set; }
}

/// <summary>
/// 发送文件到指定会话请求
/// </summary>
public class PostV10ConvFileConversationsFilesSendRequest
{
    /// <summary>
    /// 空间ID，调用添加空间接口获取id参数值。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public required string SpaceId { get; set; }
    /// <summary>
    /// 文件ID，调用获取文件或文件夹列表接口获取id参数值。
    /// </summary>
    [JsonPropertyName("dentryId")]
    public required string DentryId { get; set; }
    /// <summary>
    /// 目标会话的openConversationId，调用创建群会话接口获取openConversationId参数值。
    /// </summary>
    [JsonPropertyName("openConversationId")]
    public required string OpenConversationId { get; set; }
}

/// <summary>
/// 发送到目标会话的文件信息。
/// </summary>
public class PostV10ConvFileConversationsFilesLinksSendResponseFile
{
    /// <summary>
    /// 文件ID。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 文件所在会话ID。
    /// </summary>
    [JsonPropertyName("conversationId")]
    public required string ConversationId { get; set; }
    /// <summary>
    /// 文件所在空间ID。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public required string SpaceId { get; set; }
    /// <summary>
    /// 文件所在的父目录ID。根目录时，该参数是0。
    /// </summary>
    [JsonPropertyName("parentId")]
    public required string ParentId { get; set; }
    /// <summary>
    /// 文件类型。 FILE：文件 FOLDER：文件夹 说明 本接口只能发送文件。
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 文件名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 文件大小，单位Byte。
    /// </summary>
    [JsonPropertyName("size")]
    public long Size { get; set; }
    /// <summary>
    /// 文件路径。
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }
    /// <summary>
    /// 文件版本。
    /// </summary>
    [JsonPropertyName("version")]
    public long Version { get; set; }
    /// <summary>
    /// 文件状态。 NORMAL：正常 DELETED：已删除 EXPIRED：已过期
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }
    /// <summary>
    /// 文件后缀。
    /// </summary>
    [JsonPropertyName("extension")]
    public required string Extension { get; set; }
    /// <summary>
    /// 创建者unionId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// 修改者unionId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 创建时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 修改时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
}

/// <summary>
/// 发送文件链接到指定会话响应
/// </summary>
public class PostV10ConvFileConversationsFilesLinksSendResponse
{
    /// <summary>
    /// 发送到目标会话的文件信息。
    /// </summary>
    [JsonPropertyName("file")]
    public required PostV10ConvFileConversationsFilesLinksSendResponseFile File { get; set; }
}

/// <summary>
/// 发送文件链接到指定会话请求
/// </summary>
public class PostV10ConvFileConversationsFilesLinksSendRequest
{
    /// <summary>
    /// 文件所在空间ID，调用添加空间接口获取id参数值。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public required string SpaceId { get; set; }
    /// <summary>
    /// 文件ID，调用获取文件或文件夹列表接口获取id参数值。
    /// </summary>
    [JsonPropertyName("dentryId")]
    public required string DentryId { get; set; }
    /// <summary>
    /// 目标会话的openConversationId，调用创建群会话接口获取openConversationId参数值。
    /// </summary>
    [JsonPropertyName("openConversationId")]
    public required string OpenConversationId { get; set; }
}

/// <summary>
/// 上传媒体文件响应
/// </summary>
public class PostMediaUploadResponse
{
    /// <summary>
    /// 返回码。
    /// </summary>
    [JsonPropertyName("errcode")]
    public double? Errcode { get; set; }
    /// <summary>
    /// 返回码描述。
    /// </summary>
    [JsonPropertyName("errmsg")]
    public string? Errmsg { get; set; }
    /// <summary>
    /// 媒体文件类型：image：图片voice：语音file：普通文件video：视频
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    /// <summary>
    /// 媒体文件上传后获取的唯一标识。
    /// </summary>
    [JsonPropertyName("media_id")]
    public string? MediaId { get; set; }
    /// <summary>
    /// 媒体文件上传时间戳。
    /// </summary>
    [JsonPropertyName("created_at")]
    public double? CreatedAt { get; set; }
}

/// <summary>
/// 要上传的媒体文件。form-data中媒体文件标识，有filename、filelength、content-type等信息。
/// </summary>
public class PostMediaUploadRequestMedia
{
    /// <summary>
    /// 扩展数据。
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object?> ExtensionData { get; set; } = [];
}

/// <summary>
/// 上传媒体文件请求
/// </summary>
public class PostMediaUploadRequest
{
    /// <summary>
    /// 媒体文件类型：image：图片，图片最大1MB。支持上传jpg、gif、png、bmp格式。voice：语音，语音文件最大2MB。支持上传amr、mp3、wav格式。video：视频，视频最大10MB。支持上传mp4格式。file：普通文件，最大10MB。支持上传doc、docx、xls、xlsx、ppt、pptx、zip、pdf、rar格式。如果使用...
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 要上传的媒体文件。form-data中媒体文件标识，有filename、filelength、content-type等信息。
    /// </summary>
    [JsonPropertyName("media")]
    public required PostMediaUploadRequestMedia Media { get; set; }
}

/// <summary>
/// GetV10DocWorkbooksByWorkbookIdSheetsResponseValueItem
/// </summary>
public class GetV10DocWorkbooksByWorkbookIdSheetsResponseValueItem
{
    /// <summary>
    /// 工作表ID。
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    /// <summary>
    /// 工作表名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// 获取所有工作表响应
/// </summary>
public class GetV10DocWorkbooksByWorkbookIdSheetsResponse
{
    /// <summary>
    /// 工作表信息列表。
    /// </summary>
    [JsonPropertyName("value")]
    public List<GetV10DocWorkbooksByWorkbookIdSheetsResponseValueItem> Value { get; set; } = [];
}

/// <summary>
/// 创建工作表响应
/// </summary>
public class PostV10DocWorkbooksByWorkbookIdSheetsResponse
{
    /// <summary>
    /// 工作表可见性，固定值为visible。
    /// </summary>
    [JsonPropertyName("visibility")]
    public required string Visibility { get; set; }
    /// <summary>
    /// 工作表的名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 工作表的ID。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
}

/// <summary>
/// 获取工作表响应
/// </summary>
public class GetV10DocWorkbooksByWorkbookIdSheetsBySheetIdResponse
{
    /// <summary>
    /// 工作表ID。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 工作表名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 工作表可见性。
    /// </summary>
    [JsonPropertyName("visibility")]
    public required string Visibility { get; set; }
    /// <summary>
    /// 最后一行非空行的位置，从0开始，表为空时返回-1。
    /// </summary>
    [JsonPropertyName("lastNonEmptyRow")]
    public long LastNonEmptyRow { get; set; }
    /// <summary>
    /// 最后一列非空列的位置，从0开始，表为空时返回-1。
    /// </summary>
    [JsonPropertyName("lastNonEmptyColumn")]
    public long LastNonEmptyColumn { get; set; }
    /// <summary>
    /// 工作表行数。
    /// </summary>
    [JsonPropertyName("rowCount")]
    public long RowCount { get; set; }
    /// <summary>
    /// 工作表列数。
    /// </summary>
    [JsonPropertyName("columnCount")]
    public long ColumnCount { get; set; }
}

/// <summary>
/// 删除工作表响应
/// </summary>
public class DeleteV10DocWorkbooksByWorkbookIdSheetsBySheetIdResponse
{
    /// <summary>
    /// 删除是否成功，true代表成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }
}

/// <summary>
/// 指定行上方插入若干行响应
/// </summary>
public class PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdInsertRowsBeforeResponse
{
    /// <summary>
    /// 扩展数据。
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object?> ExtensionData { get; set; } = [];
}

/// <summary>
/// 指定行上方插入若干行请求
/// </summary>
public class PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdInsertRowsBeforeRequest
{
    /// <summary>
    /// 指定行的游标，从0开始。
    /// </summary>
    [JsonPropertyName("row")]
    public required string Row { get; set; }
    /// <summary>
    /// 插入行的数量。
    /// </summary>
    [JsonPropertyName("rowCount")]
    public required string RowCount { get; set; }
}

/// <summary>
/// 指定列左侧插入若干列响应
/// </summary>
public class PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdInsertColumnsBeforeResponse
{
    /// <summary>
    /// 工作表ID。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
}

/// <summary>
/// 指定列左侧插入若干列请求
/// </summary>
public class PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdInsertColumnsBeforeRequest
{
    /// <summary>
    /// 指定列的游标，从0开始。
    /// </summary>
    [JsonPropertyName("column")]
    public required string Column { get; set; }
    /// <summary>
    /// 插入列的数量。
    /// </summary>
    [JsonPropertyName("columnCount")]
    public required string ColumnCount { get; set; }
}

/// <summary>
/// 删除列响应
/// </summary>
public class PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdDeleteColumnsResponse
{
    /// <summary>
    /// 工作表ID。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
}

/// <summary>
/// 删除列请求
/// </summary>
public class PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdDeleteColumnsRequest
{
    /// <summary>
    /// 要删除的第一列的游标，从0开始。
    /// </summary>
    [JsonPropertyName("column")]
    public required string Column { get; set; }
    /// <summary>
    /// 要删除的列的数量。
    /// </summary>
    [JsonPropertyName("columnCount")]
    public required string ColumnCount { get; set; }
}

/// <summary>
/// 设置行隐藏或显示响应
/// </summary>
public class PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdSetRowsVisibilityResponse
{
    /// <summary>
    /// 工作表ID。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
}

/// <summary>
/// 设置行隐藏或显示请求
/// </summary>
public class PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdSetRowsVisibilityRequest
{
    /// <summary>
    /// 可见性。 visible：可见 hidden：隐藏
    /// </summary>
    [JsonPropertyName("visibility")]
    public required string Visibility { get; set; }
    /// <summary>
    /// 要显示或者隐藏的第一行的游标，从0开始。
    /// </summary>
    [JsonPropertyName("row")]
    public required string Row { get; set; }
    /// <summary>
    /// 要显示或隐藏的行的数量。
    /// </summary>
    [JsonPropertyName("rowCount")]
    public required string RowCount { get; set; }
}

/// <summary>
/// 设置列隐藏或显示响应
/// </summary>
public class PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdSetColumnsVisibilityResponse
{
    /// <summary>
    /// 工作表ID。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
}

/// <summary>
/// 设置列隐藏或显示请求
/// </summary>
public class PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdSetColumnsVisibilityRequest
{
    /// <summary>
    /// 可见性。 visible：可见 hidden：隐藏
    /// </summary>
    [JsonPropertyName("visibility")]
    public required string Visibility { get; set; }
    /// <summary>
    /// 要显示或隐藏的第一列的游标，从0开始。
    /// </summary>
    [JsonPropertyName("column")]
    public required string Column { get; set; }
    /// <summary>
    /// 要显示或隐藏的列的数量。
    /// </summary>
    [JsonPropertyName("columnCount")]
    public required string ColumnCount { get; set; }
}

/// <summary>
/// GetV10DocWorkbooksByWorkbookIdSheetsBySheetIdRangesByRangeAddressResponseBackgroundColorsItemItem
/// </summary>
public class GetV10DocWorkbooksByWorkbookIdSheetsBySheetIdRangesByRangeAddressResponseBackgroundColorsItemItem
{
    /// <summary>
    /// RGB值中的红色值。
    /// </summary>
    [JsonPropertyName("red")]
    public long? Red { get; set; }
    /// <summary>
    /// RGB值中的绿色值。
    /// </summary>
    [JsonPropertyName("green")]
    public long? Green { get; set; }
    /// <summary>
    /// RGB值中的蓝色值。
    /// </summary>
    [JsonPropertyName("blue")]
    public long? Blue { get; set; }
    /// <summary>
    /// 16进制表示的颜色。
    /// </summary>
    [JsonPropertyName("hexString")]
    public string? HexString { get; set; }
}

/// <summary>
/// 获取单元格区域响应
/// </summary>
public class GetV10DocWorkbooksByWorkbookIdSheetsBySheetIdRangesByRangeAddressResponse
{
    /// <summary>
    /// 单元格的值。 说明 如果单元格是公式，则返回公式计算后的结果。形式为二维数组，第一维为Range范围内的所有行，第二维为Range范围内每一行的单元格的值。
    /// </summary>
    [JsonPropertyName("values")]
    public List<List<string>> Values { get; set; } = [];
    /// <summary>
    /// 单元格的公式。 说明 形式为二维数组，第一维为Range范围内的所有行，第二维为Range范围内每一行的所有单元格的公式。
    /// </summary>
    [JsonPropertyName("formulas")]
    public List<List<string>> Formulas { get; set; } = [];
    /// <summary>
    /// 单元格的显示值。 说明 显示值为在表格界面上所看到的结果。和values相比，其会受到数字格式（如小数位数、百分比、日期格式等）等因素影响。形式为二维数组，第一维为Range范围内的所有行，第二维为Range范围内每一行的所有单元格的显示值。
    /// </summary>
    [JsonPropertyName("displayValues")]
    public List<List<string>> DisplayValues { get; set; } = [];
    /// <summary>
    /// 单元格的背景色。 说明 形式为二维数组，第一维为Range范围内的所有行，第二维为Range范围内每一行的所有单元格的背景色。
    /// </summary>
    [JsonPropertyName("backgroundColors")]
    public List<List<GetV10DocWorkbooksByWorkbookIdSheetsBySheetIdRangesByRangeAddressResponseBackgroundColorsItemItem>> BackgroundColors { get; set; } = [];
}

/// <summary>
/// 更新单元格区域响应
/// </summary>
public class UpdateV10DocWorkbooksByWorkbookIdSheetsBySheetIdRangesByRangeAddressResponse
{
    /// <summary>
    /// 被更新的range地址。
    /// </summary>
    [JsonPropertyName("a1Notation")]
    public required string A1Notation { get; set; }
}

/// <summary>
/// UpdateV10DocWorkbooksByWorkbookIdSheetsBySheetIdRangesByRangeAddressRequestHyperlinksItemItem
/// </summary>
public class UpdateV10DocWorkbooksByWorkbookIdSheetsBySheetIdRangesByRangeAddressRequestHyperlinksItemItem
{
    /// <summary>
    /// Type
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    /// <summary>
    /// Link
    /// </summary>
    [JsonPropertyName("link")]
    public string? Link { get; set; }
    /// <summary>
    /// Text
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>
/// 更新单元格区域请求
/// </summary>
public class UpdateV10DocWorkbooksByWorkbookIdSheetsBySheetIdRangesByRangeAddressRequest
{
    /// <summary>
    /// 单元格的值，根据Range地址范围传参，格式为二维数组。详情请参考如下示例：**说明**Range地址范围有几行，该参数二维数组内就有几个元素；Range地址范围内有几列，该参数二维数组每个元素内就有几个值。**示例1**：Range地址为A1:B3，范围内是一个三行两列的表格，该参数值格式如下：12345678{ "values": [ ["1", ...
    /// </summary>
    [JsonPropertyName("values")]
    public List<List<string>> Values { get; set; } = [];
    /// <summary>
    /// 背景色，颜色的16进制值，根据Range地址范围传参，格式为二维数组。详情请参考如下示例： **说明** Range地址范围有几行，该参数二维数组内就有几个元素；Range地址范围内有几列，该参数二维数组每个元素内就有几个值。 **示例1**：Range地址为A1:B3，范围内是一个三行两列的表格，该参数值格式如下： { "backgroundColo...
    /// </summary>
    [JsonPropertyName("backgroundColors")]
    public List<List<string>> BackgroundColors { get; set; } = [];
    /// <summary>
    /// 超链接，根据Range地址范围传参，格式为二维数组。详情请参考如下示例： **说明** Range地址范围有几行，该参数二维数组内就有几个元素；Range地址范围内有几列，该参数二维数组每个元素内就有几个值。 **示例1**：Range地址为A1:B3，范围内是一个三行两列的表格，该参数值格式如下： { "hyperlinks": [ [ { "typ...
    /// </summary>
    [JsonPropertyName("hyperlinks")]
    public List<List<UpdateV10DocWorkbooksByWorkbookIdSheetsBySheetIdRangesByRangeAddressRequestHyperlinksItemItem>> Hyperlinks { get; set; } = [];
    /// <summary>
    /// 数字格式。 | 名称 | 数字格式 | 示例 | | ---------------- | ------------------- | ----------------- | | 常规 | "General" | | | 文本 | "@" | | | 数字 | "#,##0" | 1,234 | | 数字（小数点） | "#,##0.00" | 1,2...
    /// </summary>
    [JsonPropertyName("numberFormat")]
    public string? NumberFormat { get; set; }
}

/// <summary>
/// 清除单元格区域内数据响应
/// </summary>
public class PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdRangesByRangeAddressClearDataResponse
{
    /// <summary>
    /// 单元格地址。
    /// </summary>
    [JsonPropertyName("a1Notation")]
    public required string A1Notation { get; set; }
}

/// <summary>
/// 清除单元格区域内所有内容响应
/// </summary>
public class PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdRangesByRangeAddressClearResponse
{
    /// <summary>
    /// 单元格地址。
    /// </summary>
    [JsonPropertyName("a1Notation")]
    public required string A1Notation { get; set; }
}

/// <summary>
/// 创建者。
/// </summary>
public class PostV20StorageDentriesSearchResponseItemsItemCreator
{
    /// <summary>
    /// 用户id。
    /// </summary>
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }
    /// <summary>
    /// 名称
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// 修改者
/// </summary>
public class PostV20StorageDentriesSearchResponseItemsItemModifier
{
    /// <summary>
    /// 用户id
    /// </summary>
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }
    /// <summary>
    /// 名称
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// PostV20StorageDentriesSearchResponseItemsItem
/// </summary>
public class PostV20StorageDentriesSearchResponseItemsItem
{
    /// <summary>
    /// 文件uuid。
    /// </summary>
    [JsonPropertyName("dentryUuid")]
    public string? DentryUuid { get; set; }
    /// <summary>
    /// 文件名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// 创建者。
    /// </summary>
    [JsonPropertyName("creator")]
    public PostV20StorageDentriesSearchResponseItemsItemCreator? Creator { get; set; }
    /// <summary>
    /// 修改者
    /// </summary>
    [JsonPropertyName("modifier")]
    public PostV20StorageDentriesSearchResponseItemsItemModifier? Modifier { get; set; }
}

/// <summary>
/// 搜索文件响应
/// </summary>
public class PostV20StorageDentriesSearchResponse
{
    /// <summary>
    /// 搜索结果列表，最大size50。
    /// </summary>
    [JsonPropertyName("items")]
    public List<PostV20StorageDentriesSearchResponseItemsItem> Items { get; set; } = [];
    /// <summary>
    /// 分页游标 不为空表示有更多数据
    /// </summary>
    [JsonPropertyName("nextToken")]
    public required string NextToken { get; set; }
}

/// <summary>
/// 限定创建时间范围。 说明 不指定时, 默认所有创建时间。
/// </summary>
public class PostV20StorageDentriesSearchRequestOptionCreateTimeRange
{
    /// <summary>
    /// 扩展数据。
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object?> ExtensionData { get; set; } = [];
}

/// <summary>
/// 限定访问时间范围。 说明 不指定时, 默认所有访问时间。
/// </summary>
public class PostV20StorageDentriesSearchRequestOptionVisitTimeRange
{
    /// <summary>
    /// 扩展数据。
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object?> ExtensionData { get; set; } = [];
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV20StorageDentriesSearchRequestOption
{
    /// <summary>
    /// 分页游标。 说明 首次拉取不用传。
    /// </summary>
    [JsonPropertyName("nextToken")]
    public string? NextToken { get; set; }
    /// <summary>
    /// 限定文件类别。
    /// </summary>
    [JsonPropertyName("dentryCategories")]
    public List<string> DentryCategories { get; set; } = [];
    /// <summary>
    /// 限定创建者。
    /// </summary>
    [JsonPropertyName("creatorIds")]
    public List<string> CreatorIds { get; set; } = [];
    /// <summary>
    /// 限定修改者。
    /// </summary>
    [JsonPropertyName("modifierIds")]
    public List<string> ModifierIds { get; set; } = [];
    /// <summary>
    /// 限定创建时间范围。 说明 不指定时, 默认所有创建时间。
    /// </summary>
    [JsonPropertyName("createTimeRange")]
    public PostV20StorageDentriesSearchRequestOptionCreateTimeRange? CreateTimeRange { get; set; }
    /// <summary>
    /// 限定访问时间范围。 说明 不指定时, 默认所有访问时间。
    /// </summary>
    [JsonPropertyName("visitTimeRange")]
    public PostV20StorageDentriesSearchRequestOptionVisitTimeRange? VisitTimeRange { get; set; }
}

/// <summary>
/// 搜索文件请求
/// </summary>
public class PostV20StorageDentriesSearchRequest
{
    /// <summary>
    /// 搜索关键词。
    /// </summary>
    [JsonPropertyName("keyword")]
    public required string Keyword { get; set; }
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public PostV20StorageDentriesSearchRequestOption? Option { get; set; }
}

/// <summary>
/// PostV20StorageWorkspacesSearchResponseItemsItem
/// </summary>
public class PostV20StorageWorkspacesSearchResponseItemsItem
{
    /// <summary>
    /// 知识库id(spaceUuid)。
    /// </summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
    /// <summary>
    /// 知识库名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// 知识库访问url。
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// 搜索知识库响应
/// </summary>
public class PostV20StorageWorkspacesSearchResponse
{
    /// <summary>
    /// 搜索结果列表，最大size20。
    /// </summary>
    [JsonPropertyName("items")]
    public List<PostV20StorageWorkspacesSearchResponseItemsItem> Items { get; set; } = [];
    /// <summary>
    /// 分页游标。 说明 不为空表示有更多数据。
    /// </summary>
    [JsonPropertyName("nextToken")]
    public required string NextToken { get; set; }
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV20StorageWorkspacesSearchRequestOption
{
    /// <summary>
    /// 分页游标。 说明 首次拉取不用传。
    /// </summary>
    [JsonPropertyName("nextToken")]
    public string? NextToken { get; set; }
}

/// <summary>
/// 搜索知识库请求
/// </summary>
public class PostV20StorageWorkspacesSearchRequest
{
    /// <summary>
    /// 搜索关键词。
    /// </summary>
    [JsonPropertyName("keyword")]
    public required string Keyword { get; set; }
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public PostV20StorageWorkspacesSearchRequestOption? Option { get; set; }
}

/// <summary>
/// 容量信息。
/// </summary>
public class GetV10StorageOrgsByCorpIdResponseOrgPartitionsItemQuota
{
    /// <summary>
    /// 已使用容量，单位: Byte。
    /// </summary>
    [JsonPropertyName("used")]
    public long Used { get; set; }
    /// <summary>
    /// 最大容量，单位: Byte。
    /// </summary>
    [JsonPropertyName("max")]
    public long Max { get; set; }
    /// <summary>
    /// 预分配剩余容量，单位Byte。 说明 管理后台可以给应用或空间预分配容量，此字段表示预分配剩余容量，即预分配容量中未使用部分。如果没有设置预分配容，此字段为空。
    /// </summary>
    [JsonPropertyName("reserved")]
    public long Reserved { get; set; }
    /// <summary>
    /// 容量类型。 SHARE：共享企业容量 PRIVATE：专享容量
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// GetV10StorageOrgsByCorpIdResponseOrgPartitionsItem
/// </summary>
public class GetV10StorageOrgsByCorpIdResponseOrgPartitionsItem
{
    /// <summary>
    /// 分区类型。 PUBLIC_OSS_PARTITION：公有云OSS存储分区 MINI_OSS_PARTITION：专属MiniOSS存储分区
    /// </summary>
    [JsonPropertyName("partitionType")]
    public string? PartitionType { get; set; }
    /// <summary>
    /// 容量信息。
    /// </summary>
    [JsonPropertyName("quota")]
    public GetV10StorageOrgsByCorpIdResponseOrgPartitionsItemQuota? Quota { get; set; }
}

/// <summary>
/// 企业信息。
/// </summary>
public class GetV10StorageOrgsByCorpIdResponseOrg
{
    /// <summary>
    /// 企业corpId。
    /// </summary>
    [JsonPropertyName("corpId")]
    public required string CorpId { get; set; }
    /// <summary>
    /// 分区容量信息列表。
    /// </summary>
    [JsonPropertyName("partitions")]
    public List<GetV10StorageOrgsByCorpIdResponseOrgPartitionsItem> Partitions { get; set; } = [];
}

/// <summary>
/// 获取企业信息响应
/// </summary>
public class GetV10StorageOrgsByCorpIdResponse
{
    /// <summary>
    /// 企业信息。
    /// </summary>
    [JsonPropertyName("org")]
    public required GetV10StorageOrgsByCorpIdResponseOrg Org { get; set; }
}

/// <summary>
/// 容量信息。
/// </summary>
public class PostV10StorageCurrentAppsQueryResponseAppPartitionsItemQuota
{
    /// <summary>
    /// 已使用容量, 单位Byte。
    /// </summary>
    [JsonPropertyName("used")]
    public long Used { get; set; }
    /// <summary>
    /// 最大容量，单位Byte。 说明 如果当前应用容量没有设置quota容量，不返回该字段。
    /// </summary>
    [JsonPropertyName("max")]
    public long Max { get; set; }
    /// <summary>
    /// 预分配剩余容量，单位Byte。 说明 管理后台可以给应用或空间预分配容量，此字段表示预分剩余容量，即预分配容量中未使用部分。如果没有设置预分配容量，此字段是空。
    /// </summary>
    [JsonPropertyName("reserved")]
    public long Reserved { get; set; }
    /// <summary>
    /// 容量类型。 SHARE：共享企业容量 PRIVATE：专享容量
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// PostV10StorageCurrentAppsQueryResponseAppPartitionsItem
/// </summary>
public class PostV10StorageCurrentAppsQueryResponseAppPartitionsItem
{
    /// <summary>
    /// 分区类型。 PUBLIC_OSS_PARTITION：公有云OSS存储分区 MINI_OSS_PARTITION：专属MiniOSS存储分区
    /// </summary>
    [JsonPropertyName("partitionType")]
    public string? PartitionType { get; set; }
    /// <summary>
    /// 容量信息。
    /// </summary>
    [JsonPropertyName("quota")]
    public PostV10StorageCurrentAppsQueryResponseAppPartitionsItemQuota? Quota { get; set; }
}

/// <summary>
/// 企业存储应用信息。
/// </summary>
public class PostV10StorageCurrentAppsQueryResponseApp
{
    /// <summary>
    /// 应用归属企业的corpId。
    /// </summary>
    [JsonPropertyName("corpId")]
    public required string CorpId { get; set; }
    /// <summary>
    /// 应用标识。
    /// </summary>
    [JsonPropertyName("appId")]
    public required string AppId { get; set; }
    /// <summary>
    /// 应用名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 应用空间创建时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 应用空间修改时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
    /// <summary>
    /// 分区信息列表。
    /// </summary>
    [JsonPropertyName("partitions")]
    public List<PostV10StorageCurrentAppsQueryResponseAppPartitionsItem> Partitions { get; set; } = [];
}

/// <summary>
/// 获取应用信息响应
/// </summary>
public class PostV10StorageCurrentAppsQueryResponse
{
    /// <summary>
    /// 企业存储应用信息。
    /// </summary>
    [JsonPropertyName("app")]
    public required PostV10StorageCurrentAppsQueryResponseApp App { get; set; }
}

/// <summary>
/// 空间能力项。
/// </summary>
public class PostV10StorageSpacesResponseSpaceCapabilities
{
    /// <summary>
    /// 是否支持搜索。 true：支持 false：不支持，默认值。
    /// </summary>
    [JsonPropertyName("canSearch")]
    public bool CanSearch { get; set; }
    /// <summary>
    /// 是否支持重命名空间名称。 true：支持 false：不支持，默认值。
    /// </summary>
    [JsonPropertyName("canRename")]
    public bool CanRename { get; set; }
    /// <summary>
    /// 是否支持被列入最近使用列表。 true：支持 false：不支持，默认值。
    /// </summary>
    [JsonPropertyName("canRecordRecentFile")]
    public bool CanRecordRecentFile { get; set; }
}

/// <summary>
/// 空间信息。
/// </summary>
public class PostV10StorageSpacesResponseSpace
{
    /// <summary>
    /// 空间id。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 空间所在企业corpId。
    /// </summary>
    [JsonPropertyName("corpId")]
    public required string CorpId { get; set; }
    /// <summary>
    /// 创建者unionId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// owner类型。 USER：用户类型，默认值 APP：App类型
    /// </summary>
    [JsonPropertyName("ownerType")]
    public required string OwnerType { get; set; }
    /// <summary>
    /// 所有者标识。
    /// </summary>
    [JsonPropertyName("ownerId")]
    public required string OwnerId { get; set; }
    /// <summary>
    /// 修改者unionId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 已使用容量，单位Byte。
    /// </summary>
    [JsonPropertyName("usedQuota")]
    public long UsedQuota { get; set; }
    /// <summary>
    /// 总容量，单位Byte。
    /// </summary>
    [JsonPropertyName("quota")]
    public long Quota { get; set; }
    /// <summary>
    /// 空间状态。 NORMAL：正常 DELETE：已删除
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }
    /// <summary>
    /// 创建时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 修改时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
    /// <summary>
    /// 业务场景。
    /// </summary>
    [JsonPropertyName("scene")]
    public required string Scene { get; set; }
    /// <summary>
    /// 空间场景Id。
    /// </summary>
    [JsonPropertyName("sceneId")]
    public required string SceneId { get; set; }
    /// <summary>
    /// 空间能力项。
    /// </summary>
    [JsonPropertyName("capabilities")]
    public required PostV10StorageSpacesResponseSpaceCapabilities Capabilities { get; set; }
    /// <summary>
    /// 空间名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// 添加空间响应
/// </summary>
public class PostV10StorageSpacesResponse
{
    /// <summary>
    /// 空间信息。
    /// </summary>
    [JsonPropertyName("space")]
    public required PostV10StorageSpacesResponseSpace Space { get; set; }
}

/// <summary>
/// 空间能力项，默认表示不设置拓展能力项。
/// </summary>
public class PostV10StorageSpacesRequestOptionCapabilities
{
    /// <summary>
    /// 扩展数据。
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object?> ExtensionData { get; set; } = [];
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV10StorageSpacesRequestOption
{
    /// <summary>
    /// 空间名称，默认无空间名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// 空间能力项，默认表示不设置拓展能力项。
    /// </summary>
    [JsonPropertyName("capabilities")]
    public PostV10StorageSpacesRequestOptionCapabilities? Capabilities { get; set; }
    /// <summary>
    /// 空间场景，该参数由开发者自定义传入。 说明 如果该参数不传，默认值是default。 如果该参数值+sceneId已存在，本接口返回已创建的空间，不会创建新空间。
    /// </summary>
    [JsonPropertyName("scene")]
    public string? Scene { get; set; }
    /// <summary>
    /// 空间场景Id，该参数值由开发者自定义传入。 说明 如果该参数不传，默认值是0。 如果参数sceneId+该参数值已存在，本接口返回已创建的空间，不会创建新空间。
    /// </summary>
    [JsonPropertyName("sceneId")]
    public string? SceneId { get; set; }
    /// <summary>
    /// owner类型。 USER：用户类型，默认值 APP：App类型
    /// </summary>
    [JsonPropertyName("ownerType")]
    public string? OwnerType { get; set; }
}

/// <summary>
/// 添加空间请求
/// </summary>
public class PostV10StorageSpacesRequest
{
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public PostV10StorageSpacesRequestOption? Option { get; set; }
}

/// <summary>
/// 空间能力项。
/// </summary>
public class GetV10StorageSpacesBySpaceIdResponseSpaceCapabilities
{
    /// <summary>
    /// 是否支持搜索。 true：支持 false：不支持
    /// </summary>
    [JsonPropertyName("canSearch")]
    public bool CanSearch { get; set; }
    /// <summary>
    /// 是否支持重命名空间名称。 true：支持 false：不支持
    /// </summary>
    [JsonPropertyName("canRename")]
    public bool CanRename { get; set; }
    /// <summary>
    /// 是否支持列入最近使用列表。 true：支持 false：不支持
    /// </summary>
    [JsonPropertyName("canRecordRecentFile")]
    public bool CanRecordRecentFile { get; set; }
}

/// <summary>
/// 容量信息。
/// </summary>
public class GetV10StorageSpacesBySpaceIdResponseSpacePartitionsItemQuota
{
    /// <summary>
    /// 实际已使用容量，单位Byte，最小值0。 说明 表示该应用下所用文件占用容量的总和，文件的上传、复制、删除相关操作会对used的值做相应变更。
    /// </summary>
    [JsonPropertyName("used")]
    public long Used { get; set; }
    /// <summary>
    /// 最大容量，单位Byte。 说明 当前应用容量被设置为max时，代表当前应用容量设置了上限，used参数值不能大于max参数值。 当前应用容量未设置为max时，返回空，此时应用共享该企业剩余可用容量。
    /// </summary>
    [JsonPropertyName("max")]
    public long Max { get; set; }
    /// <summary>
    /// 预分配剩余容量，单位Byte。 说明 管理后台可以给应用或空间预分配容量，此字段表示预分配剩余容量，即预分配容量中未使用部分。如果没有设置预分配容，此字段是空。
    /// </summary>
    [JsonPropertyName("reserved")]
    public long Reserved { get; set; }
    /// <summary>
    /// 容量类型。 SHARE: 共享容量。此模式下，Quota.max为空，表示共享企业容量。 PRIVATE: 预分配容量（专享容量）。此模式下，Quota.max设置值后，表示容量独占。 说明 需要保证单个应用的可用容量不受其他应用影响时，可使用预分配容量（专享容量）。
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// GetV10StorageSpacesBySpaceIdResponseSpacePartitionsItem
/// </summary>
public class GetV10StorageSpacesBySpaceIdResponseSpacePartitionsItem
{
    /// <summary>
    /// 分区类型。 PUBLIC_OSS_PARTITION：公有云OSS存储分区 MINI_OSS_PARTITION：专属Mini OSS存储分区
    /// </summary>
    [JsonPropertyName("partitionType")]
    public string? PartitionType { get; set; }
    /// <summary>
    /// 容量信息。
    /// </summary>
    [JsonPropertyName("quota")]
    public GetV10StorageSpacesBySpaceIdResponseSpacePartitionsItemQuota? Quota { get; set; }
}

/// <summary>
/// 空间详情。
/// </summary>
public class GetV10StorageSpacesBySpaceIdResponseSpace
{
    /// <summary>
    /// 空间id。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 空间归属企业的corpId。
    /// </summary>
    [JsonPropertyName("corpId")]
    public required string CorpId { get; set; }
    /// <summary>
    /// 创建者unionId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// owner类型。 USER：用户类型 APP：App类型
    /// </summary>
    [JsonPropertyName("ownerType")]
    public required string OwnerType { get; set; }
    /// <summary>
    /// 所有者标识。
    /// </summary>
    [JsonPropertyName("ownerId")]
    public required string OwnerId { get; set; }
    /// <summary>
    /// 修改者unionId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 已使用容量，单位Byte。
    /// </summary>
    [JsonPropertyName("usedQuota")]
    public long UsedQuota { get; set; }
    /// <summary>
    /// 总容量，单位Byte。
    /// </summary>
    [JsonPropertyName("quota")]
    public long Quota { get; set; }
    /// <summary>
    /// 空间状态。 NORMAL：正常 DELETE：已删除
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }
    /// <summary>
    /// 创建时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 修改时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
    /// <summary>
    /// 开放平台应用appId
    /// </summary>
    [JsonPropertyName("appId")]
    public required string AppId { get; set; }
    /// <summary>
    /// 业务场景。
    /// </summary>
    [JsonPropertyName("scene")]
    public required string Scene { get; set; }
    /// <summary>
    /// 场景Id。
    /// </summary>
    [JsonPropertyName("sceneId")]
    public required string SceneId { get; set; }
    /// <summary>
    /// 空间能力项。
    /// </summary>
    [JsonPropertyName("capabilities")]
    public required GetV10StorageSpacesBySpaceIdResponseSpaceCapabilities Capabilities { get; set; }
    /// <summary>
    /// 空间名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 分区容量信息，最大值2。
    /// </summary>
    [JsonPropertyName("partitions")]
    public List<GetV10StorageSpacesBySpaceIdResponseSpacePartitionsItem> Partitions { get; set; } = [];
}

/// <summary>
/// 获取空间信息响应
/// </summary>
public class GetV10StorageSpacesBySpaceIdResponse
{
    /// <summary>
    /// 空间详情。
    /// </summary>
    [JsonPropertyName("space")]
    public required GetV10StorageSpacesBySpaceIdResponseSpace Space { get; set; }
}

/// <summary>
/// 文件夹属性。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByParentIdFoldersResponseDentryProperties
{
    /// <summary>
    /// 是否只读。 true：是 false：否
    /// </summary>
    [JsonPropertyName("readOnly")]
    public bool ReadOnly { get; set; }
}

/// <summary>
/// PostV10StorageSpacesBySpaceIdDentriesByParentIdFoldersResponseDentryAppPropertiesItem
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByParentIdFoldersResponseDentryAppPropertiesItem
{
    /// <summary>
    /// 属性名。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// 属性值。
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
    /// <summary>
    /// 属性可见性。 PUBLIC：所有应用都可见 PRIVATE：仅限当前应用可见
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>
/// 文件夹信息。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByParentIdFoldersResponseDentry
{
    /// <summary>
    /// 文件夹id。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 所在空间Id。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public required string SpaceId { get; set; }
    /// <summary>
    /// 父目录Id。 说明 该字段为0，表示根目录。
    /// </summary>
    [JsonPropertyName("parentId")]
    public required string ParentId { get; set; }
    /// <summary>
    /// 类型，本接口返回类型是固定值。 FOLDER：文件夹
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 文件夹的名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 大小, 单位Byte。 说明 本接口添加文件夹，不返回该字段。
    /// </summary>
    [JsonPropertyName("size")]
    public long Size { get; set; }
    /// <summary>
    /// 文件夹在空间内的路径。
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }
    /// <summary>
    /// 版本。 说明 本接口添加文件夹，不返回该字段。
    /// </summary>
    [JsonPropertyName("version")]
    public long Version { get; set; }
    /// <summary>
    /// 状态。 NORMAL：正常 DELETED：已删除
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }
    /// <summary>
    /// 后缀。 说明 本接口添加文件夹，不返回该字段。
    /// </summary>
    [JsonPropertyName("extension")]
    public required string Extension { get; set; }
    /// <summary>
    /// 创建者unionId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// 修改者unionId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 创建时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 修改时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
    /// <summary>
    /// 文件夹属性。
    /// </summary>
    [JsonPropertyName("properties")]
    public required PostV10StorageSpacesBySpaceIdDentriesByParentIdFoldersResponseDentryProperties Properties { get; set; }
    /// <summary>
    /// 在特定应用上的属性。key是空间的ownerId，value是属性列表。
    /// </summary>
    [JsonPropertyName("appProperties")]
    public List<PostV10StorageSpacesBySpaceIdDentriesByParentIdFoldersResponseDentryAppPropertiesItem> AppProperties { get; set; } = [];
    /// <summary>
    /// 标识字段。
    /// </summary>
    [JsonPropertyName("uuid")]
    public required string Uuid { get; set; }
    /// <summary>
    /// 存储分区。 PUBLIC_OSS_PARTITION：公有云OSS存储分区 MINI_OSS_PARTITION：专属MiniOSS存储分区
    /// </summary>
    [JsonPropertyName("partitionType")]
    public required string PartitionType { get; set; }
    /// <summary>
    /// 驱动类型。 DINGTALK：钉钉统一存储驱动 ALIDOC：钉钉文档存储驱动 UNKNOWN：未知驱动
    /// </summary>
    [JsonPropertyName("storageDriver")]
    public required string StorageDriver { get; set; }
}

/// <summary>
/// 添加文件夹响应
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByParentIdFoldersResponse
{
    /// <summary>
    /// 文件夹信息。
    /// </summary>
    [JsonPropertyName("dentry")]
    public required PostV10StorageSpacesBySpaceIdDentriesByParentIdFoldersResponseDentry Dentry { get; set; }
}

/// <summary>
/// PostV10StorageSpacesBySpaceIdDentriesByParentIdFoldersRequestOptionAppPropertiesItem
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByParentIdFoldersRequestOptionAppPropertiesItem
{
    /// <summary>
    /// 属性名称。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// 属性值。
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
    /// <summary>
    /// 属性可见性。 PUBLIC：所有应用都可见 PRIVATE：仅限当前应用可见
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByParentIdFoldersRequestOption
{
    /// <summary>
    /// 文件夹名称冲突策略。 AUTO_RENAME：自动重命名，默认值 OVERWRITE：覆盖 RETURN_DENTRY_IF_EXISTS：返回已存在文件夹 RETURN_ERROR_IF_EXISTS：文件夹已存在时报错
    /// </summary>
    [JsonPropertyName("conflictStrategy")]
    public required string ConflictStrategy { get; set; }
    /// <summary>
    /// 当前文件夹的应用属性列表，最大值3。
    /// </summary>
    [JsonPropertyName("appProperties")]
    public List<PostV10StorageSpacesBySpaceIdDentriesByParentIdFoldersRequestOptionAppPropertiesItem> AppProperties { get; set; } = [];
}

/// <summary>
/// 添加文件夹请求
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByParentIdFoldersRequest
{
    /// <summary>
    /// 文件夹的名称，命名有以下要求： 头尾不能包含空格，否则会自动去除 不能包含特殊字符，包括：制表符、*、"、&lt;、&gt;、| 不能以"."结尾
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public PostV10StorageSpacesBySpaceIdDentriesByParentIdFoldersRequestOption? Option { get; set; }
}

/// <summary>
/// 属性。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdCopyResponseDentryProperties
{
    /// <summary>
    /// ReadOnly
    /// </summary>
    [JsonPropertyName("readOnly")]
    public bool ReadOnly { get; set; }
}

/// <summary>
/// PostV10StorageSpacesBySpaceIdDentriesByDentryIdCopyResponseDentryAppPropertiesItem
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdCopyResponseDentryAppPropertiesItem
{
    /// <summary>
    /// Name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// Value
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
    /// <summary>
    /// Visibility
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>
/// 文件或文件夹信息列表。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdCopyResponseDentry
{
    /// <summary>
    /// 文件或文件夹id。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 所在空间Id。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public required string SpaceId { get; set; }
    /// <summary>
    /// 父目录Id。
    /// </summary>
    [JsonPropertyName("parentId")]
    public required string ParentId { get; set; }
    /// <summary>
    /// 类型。 FILE：文件 FOLDER：文件夹
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 文件或文件夹名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 文件大小，单位Byte。 说明 文件夹不返回该字段。
    /// </summary>
    [JsonPropertyName("size")]
    public long Size { get; set; }
    /// <summary>
    /// 路径。
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }
    /// <summary>
    /// 版本。
    /// </summary>
    [JsonPropertyName("version")]
    public long Version { get; set; }
    /// <summary>
    /// 状态。 NORMAL：正常 DELETED：已删除 EXPIRED：已过期
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }
    /// <summary>
    /// 文件后缀。 说明 文件夹不返回该字段。
    /// </summary>
    [JsonPropertyName("extension")]
    public required string Extension { get; set; }
    /// <summary>
    /// 创建者unionId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// 修改者unionId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 创建时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 修改时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
    /// <summary>
    /// 属性。
    /// </summary>
    [JsonPropertyName("properties")]
    public required PostV10StorageSpacesBySpaceIdDentriesByDentryIdCopyResponseDentryProperties Properties { get; set; }
    /// <summary>
    /// 在特定应用上的属性。
    /// </summary>
    [JsonPropertyName("appProperties")]
    public List<PostV10StorageSpacesBySpaceIdDentriesByDentryIdCopyResponseDentryAppPropertiesItem> AppProperties { get; set; } = [];
    /// <summary>
    /// 标识字段。
    /// </summary>
    [JsonPropertyName("uuid")]
    public required string Uuid { get; set; }
    /// <summary>
    /// 存储分区。 PUBLIC_OSS_PARTITION：公有云OSS存储分区 MINI_OSS_PARTITION：专属MiniOSS存储分区
    /// </summary>
    [JsonPropertyName("partitionType")]
    public required string PartitionType { get; set; }
    /// <summary>
    /// 驱动类型。 DINGTALK：钉钉统一存储驱动 ALIDOC：钉钉文档存储驱动 UNKNOWN：未知驱动
    /// </summary>
    [JsonPropertyName("storageDriver")]
    public required string StorageDriver { get; set; }
}

/// <summary>
/// 复制文件或文件夹响应
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdCopyResponse
{
    /// <summary>
    /// 文件或文件夹信息列表。
    /// </summary>
    [JsonPropertyName("dentry")]
    public required PostV10StorageSpacesBySpaceIdDentriesByDentryIdCopyResponseDentry Dentry { get; set; }
    /// <summary>
    /// 是否是异步任务。 true：是 false：否
    /// </summary>
    [JsonPropertyName("async")]
    public bool Async { get; set; }
    /// <summary>
    /// 任务Id，用于查询任务执行状态。
    /// </summary>
    [JsonPropertyName("taskId")]
    public required string TaskId { get; set; }
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdCopyRequestOption
{
    /// <summary>
    /// 文件和文件夹的名称冲突策略。 AUTO_RENAME：自动重命名，默认值 OVERWRITE：覆盖 RETURN_DENTRY_IF_EXISTS：返回已存在文件 RETURN_ERROR_IF_EXISTS：文件已存在时报错
    /// </summary>
    [JsonPropertyName("conflictStrategy")]
    public string? ConflictStrategy { get; set; }
}

/// <summary>
/// 复制文件或文件夹请求
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdCopyRequest
{
    /// <summary>
    /// 需要存放的目标空间Id。 企业内部应用，调用添加空间接口获取id参数值。 第三方企业应用，调用添加空间接口获取id参数值。
    /// </summary>
    [JsonPropertyName("targetSpaceId")]
    public required string TargetSpaceId { get; set; }
    /// <summary>
    /// 需要存放的位置父目录Id。 企业内部应用，调用获取文件或文件夹列表接口获取parentId参数值。 第三方企业应用，调用获取文件或文件夹列表接口获取parentId参数值。
    /// </summary>
    [JsonPropertyName("targetFolderId")]
    public required string TargetFolderId { get; set; }
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public PostV10StorageSpacesBySpaceIdDentriesByDentryIdCopyRequestOption? Option { get; set; }
}

/// <summary>
/// PostV10StorageSpacesBySpaceIdDentriesBatchCopyResponseResultItemsItem
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesBatchCopyResponseResultItemsItem
{
    /// <summary>
    /// 源文件或文件夹所在的空间ID。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public string? SpaceId { get; set; }
    /// <summary>
    /// 源文件或文件夹的ID。
    /// </summary>
    [JsonPropertyName("dentryId")]
    public string? DentryId { get; set; }
    /// <summary>
    /// 是否是异步任务。 true：是 false：不是 说明 如果操作的文件夹有子节点，则会异步处理。
    /// </summary>
    [JsonPropertyName("async")]
    public bool? Async { get; set; }
    /// <summary>
    /// 是否成功。 true：成功 false：失败 说明 如果是异步任务，该字段不返回。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
    /// <summary>
    /// 错误原因。 说明 如果是异步任务，该字段不返回。
    /// </summary>
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }
    /// <summary>
    /// 异步任务ID，可用于查询任务执行状态。 企业内部应用，可调用获取存储中异步任务信息接口查询任务执行状态。 第三方企业应用，可调用获取存储中异步任务信息接口查询任务执行状态。
    /// </summary>
    [JsonPropertyName("taskId")]
    public string? TaskId { get; set; }
    /// <summary>
    /// 目标空间ID。 说明 非失败情况下，同步或异步都会返回。
    /// </summary>
    [JsonPropertyName("targetSpaceId")]
    public string? TargetSpaceId { get; set; }
    /// <summary>
    /// 复制之后的文件或文件夹ID。 说明 非失败情况下，同步或异步都会返回。
    /// </summary>
    [JsonPropertyName("targetDentryId")]
    public string? TargetDentryId { get; set; }
}

/// <summary>
/// 批量复制文件或文件夹响应
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesBatchCopyResponse
{
    /// <summary>
    /// 批量复制文件或文件夹的结果列表。
    /// </summary>
    [JsonPropertyName("resultItems")]
    public List<PostV10StorageSpacesBySpaceIdDentriesBatchCopyResponseResultItemsItem> ResultItems { get; set; } = [];
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesBatchCopyRequestOption
{
    /// <summary>
    /// 文件或者文件夹的名称冲突策略。 AUTO_RENAME：自动重命名，默认值 OVERWRITE：覆盖 RETURN_DENTRY_IF_EXISTS：返回已存在文件 RETURN_ERROR_IF_EXISTS：文件已存在时报错
    /// </summary>
    [JsonPropertyName("conflictStrategy")]
    public string? ConflictStrategy { get; set; }
}

/// <summary>
/// 批量复制文件或文件夹请求
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesBatchCopyRequest
{
    /// <summary>
    /// 目标文件或文件夹所在的空间ID。 企业内部应用，调用添加空间接口获取id参数值。 第三方企业应用，调用添加空间接口获取id参数值。
    /// </summary>
    [JsonPropertyName("targetSpaceId")]
    public required string TargetSpaceId { get; set; }
    /// <summary>
    /// 目标文件夹ID， 根目录ID值为0。 企业内部应用，调用获取文件或文件夹列表接口获取id参数值。 第三方企业应用，调用获取文件或文件夹列表接口获取id参数值。
    /// </summary>
    [JsonPropertyName("targetFolderId")]
    public required string TargetFolderId { get; set; }
    /// <summary>
    /// 源文件或文件夹的ID列表，最大值30。 企业内部应用，调用获取文件或文件夹列表接口获取id参数值。 第三方企业应用，调用获取文件或文件夹列表接口获取id参数值。
    /// </summary>
    [JsonPropertyName("dentryIds")]
    public List<string> DentryIds { get; set; } = [];
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public PostV10StorageSpacesBySpaceIdDentriesBatchCopyRequestOption? Option { get; set; }
}

/// <summary>
/// 属性。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdMoveResponseDentryProperties
{
    /// <summary>
    /// ReadOnly
    /// </summary>
    [JsonPropertyName("readOnly")]
    public bool ReadOnly { get; set; }
}

/// <summary>
/// PostV10StorageSpacesBySpaceIdDentriesByDentryIdMoveResponseDentryAppPropertiesItem
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdMoveResponseDentryAppPropertiesItem
{
    /// <summary>
    /// Name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// Value
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
    /// <summary>
    /// Visibility
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>
/// 文件或文件夹信息列表。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdMoveResponseDentry
{
    /// <summary>
    /// 文件或文件夹id。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 所在空间Id。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public required string SpaceId { get; set; }
    /// <summary>
    /// 父目录Id。根目录时，该参数是0。
    /// </summary>
    [JsonPropertyName("parentId")]
    public required string ParentId { get; set; }
    /// <summary>
    /// 类型。 FILE：文件 FOLDER：文件夹
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 文件或文件夹的名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 文件大小，单位Byte。 说明 文件夹不返回该字段。
    /// </summary>
    [JsonPropertyName("size")]
    public long Size { get; set; }
    /// <summary>
    /// 路径。
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }
    /// <summary>
    /// 版本。
    /// </summary>
    [JsonPropertyName("version")]
    public long Version { get; set; }
    /// <summary>
    /// 状态。 NORMAL：正常 DELETED：已删除 EXPIRED：已过期
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }
    /// <summary>
    /// 文件后缀。 说明 文件夹不返回该字段。
    /// </summary>
    [JsonPropertyName("extension")]
    public required string Extension { get; set; }
    /// <summary>
    /// 创建者unionId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// 修改者unionId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 创建时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 修改时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
    /// <summary>
    /// 属性。
    /// </summary>
    [JsonPropertyName("properties")]
    public required PostV10StorageSpacesBySpaceIdDentriesByDentryIdMoveResponseDentryProperties Properties { get; set; }
    /// <summary>
    /// 在特定应用上的属性。
    /// </summary>
    [JsonPropertyName("appProperties")]
    public List<PostV10StorageSpacesBySpaceIdDentriesByDentryIdMoveResponseDentryAppPropertiesItem> AppProperties { get; set; } = [];
    /// <summary>
    /// 标识字段。
    /// </summary>
    [JsonPropertyName("uuid")]
    public required string Uuid { get; set; }
    /// <summary>
    /// 存储分区。 PUBLIC_OSS_PARTITION：公有云OSS存储分区 MINI_OSS_PARTITION：专属MiniOSS存储分区
    /// </summary>
    [JsonPropertyName("partitionType")]
    public required string PartitionType { get; set; }
    /// <summary>
    /// 驱动类型。 DINGTALK：钉钉统一存储驱动 ALIDOC：钉钉文档存储驱动 UNKNOWN：未知驱动
    /// </summary>
    [JsonPropertyName("storageDriver")]
    public required string StorageDriver { get; set; }
}

/// <summary>
/// 移动文件或文件夹响应
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdMoveResponse
{
    /// <summary>
    /// 文件或文件夹信息列表。
    /// </summary>
    [JsonPropertyName("dentry")]
    public required PostV10StorageSpacesBySpaceIdDentriesByDentryIdMoveResponseDentry Dentry { get; set; }
    /// <summary>
    /// 是否是异步任务。 true：是 false：否
    /// </summary>
    [JsonPropertyName("async")]
    public bool Async { get; set; }
    /// <summary>
    /// 任务Id，用于查询任务执行状态。
    /// </summary>
    [JsonPropertyName("taskId")]
    public required string TaskId { get; set; }
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdMoveRequestOption
{
    /// <summary>
    /// 文件和文件夹的名称冲突策略。 AUTO_RENAME：自动重命名，默认值 OVERWRITE：覆盖 RETURN_DENTRY_IF_EXISTS：返回已存在文件 RETURN_ERROR_IF_EXISTS：文件已存在时报错
    /// </summary>
    [JsonPropertyName("conflictStrategy")]
    public string? ConflictStrategy { get; set; }
}

/// <summary>
/// 移动文件或文件夹请求
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdMoveRequest
{
    /// <summary>
    /// 需要存放的目标空间Id。 企业内部应用，调用添加空间接口获取id参数值。 第三方企业应用，调用添加空间接口获取id参数值。
    /// </summary>
    [JsonPropertyName("targetSpaceId")]
    public required string TargetSpaceId { get; set; }
    /// <summary>
    /// 需要存放的位置父目录Id。根目录时，该参数是0。 企业内部应用，调用获取文件或文件夹列表接口获取parentId参数值。 第三方企业应用，调用获取文件或文件夹列表接口获取parentId参数值。
    /// </summary>
    [JsonPropertyName("targetFolderId")]
    public required string TargetFolderId { get; set; }
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public PostV10StorageSpacesBySpaceIdDentriesByDentryIdMoveRequestOption? Option { get; set; }
}

/// <summary>
/// PostV10StorageSpacesBySpaceIdDentriesBatchMoveResponseResultItemsItem
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesBatchMoveResponseResultItemsItem
{
    /// <summary>
    /// 源文件或文件夹所在的空间ID。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public string? SpaceId { get; set; }
    /// <summary>
    /// 源文件或文件夹的ID。
    /// </summary>
    [JsonPropertyName("dentryId")]
    public string? DentryId { get; set; }
    /// <summary>
    /// 是否是异步任务。 true：是 false：否 说明 如果操作对象有子节点，则会异步处理。
    /// </summary>
    [JsonPropertyName("async")]
    public bool? Async { get; set; }
    /// <summary>
    /// 是否成功。 true：成功 false：失败 说明 异步任务该字段不返回。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
    /// <summary>
    /// 错误原因。 说明 异步任务该字段不返回。
    /// </summary>
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }
    /// <summary>
    /// 异步任务ID，可用于查询任务执行状态。 企业内部应用，可调用获取存储中异步任务信息接口查询任务执行状态。 第三方企业应用，可调用获取存储中异步任务信息接口查询任务执行状态。
    /// </summary>
    [JsonPropertyName("taskId")]
    public string? TaskId { get; set; }
    /// <summary>
    /// 移动之后所属的空间ID。 说明 非失败情况下，同步或异步都会返回。
    /// </summary>
    [JsonPropertyName("targetSpaceId")]
    public string? TargetSpaceId { get; set; }
    /// <summary>
    /// 移动之后文件或文件夹的ID。 说明 非失败情况下，同步或异步都会返回。
    /// </summary>
    [JsonPropertyName("targetDentryId")]
    public string? TargetDentryId { get; set; }
}

/// <summary>
/// 批量移动文件或文件夹响应
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesBatchMoveResponse
{
    /// <summary>
    /// 批量移动文件或文件夹的结果列表。
    /// </summary>
    [JsonPropertyName("resultItems")]
    public List<PostV10StorageSpacesBySpaceIdDentriesBatchMoveResponseResultItemsItem> ResultItems { get; set; } = [];
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesBatchMoveRequestOption
{
    /// <summary>
    /// 文件或文件夹的名称冲突策略。 AUTO_RENAME：自动重命名，默认值 OVERWRITE：覆盖 RETURN_DENTRY_IF_EXISTS：返回已存在文件 RETURN_ERROR_IF_EXISTS：文件已存在时报错
    /// </summary>
    [JsonPropertyName("conflictStrategy")]
    public string? ConflictStrategy { get; set; }
}

/// <summary>
/// 批量移动文件或文件夹请求
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesBatchMoveRequest
{
    /// <summary>
    /// 目标空间ID。 企业内部应用，调用添加空间接口获取id参数值。 第三方企业应用，调用添加空间接口获取id参数值。
    /// </summary>
    [JsonPropertyName("targetSpaceId")]
    public required string TargetSpaceId { get; set; }
    /// <summary>
    /// 目标文件夹id, 根目录id值为0。 企业内部应用，调用获取文件或文件夹列表接口获取id参数值。 第三方企业应用，调用获取文件或文件夹列表接口获取id参数值。
    /// </summary>
    [JsonPropertyName("targetFolderId")]
    public required string TargetFolderId { get; set; }
    /// <summary>
    /// 源文件或文件夹的ID列表，最大值30。 企业内部应用，调用获取文件或文件夹列表接口获取id参数值。 第三方企业应用，调用获取文件或文件夹列表接口获取id参数值。
    /// </summary>
    [JsonPropertyName("dentryIds")]
    public List<string> DentryIds { get; set; } = [];
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public PostV10StorageSpacesBySpaceIdDentriesBatchMoveRequestOption? Option { get; set; }
}

/// <summary>
/// 属性。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdRenameResponseDentryProperties
{
    /// <summary>
    /// ReadOnly
    /// </summary>
    [JsonPropertyName("readOnly")]
    public bool ReadOnly { get; set; }
}

/// <summary>
/// PostV10StorageSpacesBySpaceIdDentriesByDentryIdRenameResponseDentryAppPropertiesItem
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdRenameResponseDentryAppPropertiesItem
{
    /// <summary>
    /// Name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// Value
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
    /// <summary>
    /// Visibility
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>
/// 文件或文件夹信息列表。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdRenameResponseDentry
{
    /// <summary>
    /// 文件或文件夹id。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 所在空间Id。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public required string SpaceId { get; set; }
    /// <summary>
    /// 父目录Id。
    /// </summary>
    [JsonPropertyName("parentId")]
    public required string ParentId { get; set; }
    /// <summary>
    /// 类型。 FILE：文件 FOLDER：文件夹
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 文件或文件夹名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 文件大小，单位Byte。 说明 文件夹不返回该字段。
    /// </summary>
    [JsonPropertyName("size")]
    public long Size { get; set; }
    /// <summary>
    /// 路径。
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }
    /// <summary>
    /// 版本。
    /// </summary>
    [JsonPropertyName("version")]
    public long Version { get; set; }
    /// <summary>
    /// 状态。 NORMAL：正常 DELETED：已删除 EXPIRED：已过期
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }
    /// <summary>
    /// 文件后缀。 说明 文件夹不返回该字段。
    /// </summary>
    [JsonPropertyName("extension")]
    public required string Extension { get; set; }
    /// <summary>
    /// 创建者unionId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// 修改者unionId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 创建时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 修改时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
    /// <summary>
    /// 属性。
    /// </summary>
    [JsonPropertyName("properties")]
    public required PostV10StorageSpacesBySpaceIdDentriesByDentryIdRenameResponseDentryProperties Properties { get; set; }
    /// <summary>
    /// 在特定应用上的属性。
    /// </summary>
    [JsonPropertyName("appProperties")]
    public List<PostV10StorageSpacesBySpaceIdDentriesByDentryIdRenameResponseDentryAppPropertiesItem> AppProperties { get; set; } = [];
    /// <summary>
    /// 标识字段。
    /// </summary>
    [JsonPropertyName("uuid")]
    public required string Uuid { get; set; }
    /// <summary>
    /// 存储分区。 PUBLIC_OSS_PARTITION：公有云OSS存储分区 MINI_OSS_PARTITION：专属MiniOSS存储分区
    /// </summary>
    [JsonPropertyName("partitionType")]
    public required string PartitionType { get; set; }
    /// <summary>
    /// 驱动类型。 DINGTALK：钉钉统一存储驱动 ALIDOC：钉钉文档存储驱动 UNKNOWN：未知驱动
    /// </summary>
    [JsonPropertyName("storageDriver")]
    public required string StorageDriver { get; set; }
}

/// <summary>
/// 重命名文件或文件夹响应
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdRenameResponse
{
    /// <summary>
    /// 文件或文件夹信息列表。
    /// </summary>
    [JsonPropertyName("dentry")]
    public required PostV10StorageSpacesBySpaceIdDentriesByDentryIdRenameResponseDentry Dentry { get; set; }
}

/// <summary>
/// 重命名文件或文件夹请求
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdRenameRequest
{
    /// <summary>
    /// 文件或文件夹的新名称，命名规则如下： 头尾不能包含空格，否则会自动去除 不能包含特殊字符，包括：制表符、*、"、&lt;、&gt;、| 不能以"."结尾
    /// </summary>
    [JsonPropertyName("newName")]
    public required string NewName { get; set; }
}

/// <summary>
/// 删除文件或文件夹响应
/// </summary>
public class DeleteV10StorageSpacesBySpaceIdDentriesByDentryIdResponse
{
    /// <summary>
    /// 是否是异步任务。 true：是 false：否
    /// </summary>
    [JsonPropertyName("async")]
    public bool Async { get; set; }
    /// <summary>
    /// 任务Id，用于查询任务执行状态。
    /// </summary>
    [JsonPropertyName("taskId")]
    public required string TaskId { get; set; }
}

/// <summary>
/// PostV10StorageSpacesBySpaceIdDentriesBatchRemoveResponseResultItemsItem
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesBatchRemoveResponseResultItemsItem
{
    /// <summary>
    /// 源文件或文件夹的空间ID。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public string? SpaceId { get; set; }
    /// <summary>
    /// 源文件或文件夹的ID。
    /// </summary>
    [JsonPropertyName("dentryId")]
    public string? DentryId { get; set; }
    /// <summary>
    /// 是否是异步任务。 true：是 false：否 说明 如果操作对象有子节点，则会异步处理。
    /// </summary>
    [JsonPropertyName("async")]
    public bool? Async { get; set; }
    /// <summary>
    /// 是否成功。 true：成功 false：失败 说明 如果为异步任务，该字段为空。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
    /// <summary>
    /// 错误原因。 说明 如果为异步任务，该字段为空。
    /// </summary>
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }
    /// <summary>
    /// 异步任务ID，可用于查询任务执行状态。 企业内部应用，可调用获取存储中异步任务信息接口查询任务执行状态。 第三方企业应用，可调用获取存储中异步任务信息接口查询任务执行状态。
    /// </summary>
    [JsonPropertyName("taskId")]
    public string? TaskId { get; set; }
}

/// <summary>
/// 批量删除文件或文件夹响应
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesBatchRemoveResponse
{
    /// <summary>
    /// 批量删除文件结果列表。
    /// </summary>
    [JsonPropertyName("resultItems")]
    public List<PostV10StorageSpacesBySpaceIdDentriesBatchRemoveResponseResultItemsItem> ResultItems { get; set; } = [];
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesBatchRemoveRequestOption
{
    /// <summary>
    /// 扩展数据。
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object?> ExtensionData { get; set; } = [];
}

/// <summary>
/// 批量删除文件或文件夹请求
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesBatchRemoveRequest
{
    /// <summary>
    /// 文件或文件夹ID列表，最大值50。 企业内部应用，调用获取文件或文件夹列表接口获取id参数值。 第三方企业应用，调用获取文件或文件夹列表接口获取id参数值。
    /// </summary>
    [JsonPropertyName("dentryIds")]
    public List<string> DentryIds { get; set; } = [];
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public PostV10StorageSpacesBySpaceIdDentriesBatchRemoveRequestOption? Option { get; set; }
}

/// <summary>
/// 恢复文件历史版本响应
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdVersionsByVersionRevertResponse
{
    /// <summary>
    /// 本次操作是否成功。 true：成功 false：失败
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }
}

/// <summary>
/// 属性。
/// </summary>
public class GetV10StorageSpacesBySpaceIdDentriesByDentryIdVersionsResponseDentriesProperties
{
    /// <summary>
    /// ReadOnly
    /// </summary>
    [JsonPropertyName("readOnly")]
    public bool ReadOnly { get; set; }
}

/// <summary>
/// GetV10StorageSpacesBySpaceIdDentriesByDentryIdVersionsResponseDentriesAppPropertiesItem
/// </summary>
public class GetV10StorageSpacesBySpaceIdDentriesByDentryIdVersionsResponseDentriesAppPropertiesItem
{
    /// <summary>
    /// Name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// Value
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
    /// <summary>
    /// Visibility
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>
/// 文件或文件夹信息列表。
/// </summary>
public class GetV10StorageSpacesBySpaceIdDentriesByDentryIdVersionsResponseDentries
{
    /// <summary>
    /// 文件或文件夹id。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 所在空间Id。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public required string SpaceId { get; set; }
    /// <summary>
    /// 父目录Id。
    /// </summary>
    [JsonPropertyName("parentId")]
    public required string ParentId { get; set; }
    /// <summary>
    /// 类型。 FILE：文件 FOLDER：文件夹
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 文件或文件夹名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 文件大小，单位Byte。 说明 文件夹不返回该字段。
    /// </summary>
    [JsonPropertyName("size")]
    public long Size { get; set; }
    /// <summary>
    /// 路径。
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }
    /// <summary>
    /// 版本。
    /// </summary>
    [JsonPropertyName("version")]
    public long Version { get; set; }
    /// <summary>
    /// 状态。 NORMAL：正常 DELETED：已删除 EXPIRED：已过期
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }
    /// <summary>
    /// 文件后缀。 说明 文件夹不返回该字段。
    /// </summary>
    [JsonPropertyName("extension")]
    public required string Extension { get; set; }
    /// <summary>
    /// 创建者unionId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// 修改者unionId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 创建时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 修改时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
    /// <summary>
    /// 属性。
    /// </summary>
    [JsonPropertyName("properties")]
    public required GetV10StorageSpacesBySpaceIdDentriesByDentryIdVersionsResponseDentriesProperties Properties { get; set; }
    /// <summary>
    /// 在特定应用上的属性。
    /// </summary>
    [JsonPropertyName("appProperties")]
    public List<GetV10StorageSpacesBySpaceIdDentriesByDentryIdVersionsResponseDentriesAppPropertiesItem> AppProperties { get; set; } = [];
    /// <summary>
    /// 标识字段。
    /// </summary>
    [JsonPropertyName("uuid")]
    public required string Uuid { get; set; }
    /// <summary>
    /// 存储分区。 PUBLIC_OSS_PARTITION：公有云OSS存储分区 MINI_OSS_PARTITION：专属MiniOSS存储分区
    /// </summary>
    [JsonPropertyName("partitionType")]
    public required string PartitionType { get; set; }
    /// <summary>
    /// 驱动类型。 DINGTALK：钉钉统一存储驱动 ALIDOC：钉钉文档存储驱动 UNKNOWN：未知驱动
    /// </summary>
    [JsonPropertyName("storageDriver")]
    public required string StorageDriver { get; set; }
}

/// <summary>
/// 获取文件版本列表响应
/// </summary>
public class GetV10StorageSpacesBySpaceIdDentriesByDentryIdVersionsResponse
{
    /// <summary>
    /// 文件或文件夹信息列表。
    /// </summary>
    [JsonPropertyName("dentries")]
    public required GetV10StorageSpacesBySpaceIdDentriesByDentryIdVersionsResponseDentries Dentries { get; set; }
    /// <summary>
    /// 分页游标。 说明 该字段不为空，表示有更多数据。
    /// </summary>
    [JsonPropertyName("nextToken")]
    public required string NextToken { get; set; }
}

/// <summary>
/// 属性。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdQueryResponseDentryProperties
{
    /// <summary>
    /// ReadOnly
    /// </summary>
    [JsonPropertyName("readOnly")]
    public bool ReadOnly { get; set; }
}

/// <summary>
/// PostV10StorageSpacesBySpaceIdDentriesByDentryIdQueryResponseDentryAppPropertiesItem
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdQueryResponseDentryAppPropertiesItem
{
    /// <summary>
    /// Name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// Value
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
    /// <summary>
    /// Visibility
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>
/// 文件或文件夹信息列表。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdQueryResponseDentry
{
    /// <summary>
    /// 文件或文件夹id。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 所在空间Id。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public required string SpaceId { get; set; }
    /// <summary>
    /// 父目录Id。
    /// </summary>
    [JsonPropertyName("parentId")]
    public required string ParentId { get; set; }
    /// <summary>
    /// 类型。 FILE：文件 FOLDER：文件夹
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 文件或文件夹名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 文件大小，单位Byte。 说明 文件夹不返回该字段。
    /// </summary>
    [JsonPropertyName("size")]
    public long Size { get; set; }
    /// <summary>
    /// 路径。
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }
    /// <summary>
    /// 版本。
    /// </summary>
    [JsonPropertyName("version")]
    public long Version { get; set; }
    /// <summary>
    /// 状态。 NORMAL：正常 DELETED：已删除 EXPIRED：已过期
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }
    /// <summary>
    /// 文件后缀。 说明 文件夹不返回该字段。
    /// </summary>
    [JsonPropertyName("extension")]
    public required string Extension { get; set; }
    /// <summary>
    /// 创建者unionId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// 修改者unionId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 创建时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 修改时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
    /// <summary>
    /// 属性。
    /// </summary>
    [JsonPropertyName("properties")]
    public required PostV10StorageSpacesBySpaceIdDentriesByDentryIdQueryResponseDentryProperties Properties { get; set; }
    /// <summary>
    /// 在特定应用上的属性。
    /// </summary>
    [JsonPropertyName("appProperties")]
    public List<PostV10StorageSpacesBySpaceIdDentriesByDentryIdQueryResponseDentryAppPropertiesItem> AppProperties { get; set; } = [];
    /// <summary>
    /// 标识字段。
    /// </summary>
    [JsonPropertyName("uuid")]
    public required string Uuid { get; set; }
    /// <summary>
    /// 存储分区。 PUBLIC_OSS_PARTITION：公有云OSS存储分区 MINI_OSS_PARTITION：专属MiniOSS存储分区
    /// </summary>
    [JsonPropertyName("partitionType")]
    public required string PartitionType { get; set; }
    /// <summary>
    /// 驱动类型。 DINGTALK：钉钉统一存储驱动 ALIDOC：钉钉文档存储驱动 UNKNOWN：未知驱动
    /// </summary>
    [JsonPropertyName("storageDriver")]
    public required string StorageDriver { get; set; }
}

/// <summary>
/// 获取文件或文件夹信息响应
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdQueryResponse
{
    /// <summary>
    /// 文件或文件夹信息列表。
    /// </summary>
    [JsonPropertyName("dentry")]
    public required PostV10StorageSpacesBySpaceIdDentriesByDentryIdQueryResponseDentry Dentry { get; set; }
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdQueryRequestOption
{
    /// <summary>
    /// 通过指定空间ownerId列表，返回对应的可见属性。最大值20。 ownerType是APP时，ownerId是应用标识。 ownerType是USER时，ownerId是创建者unionId。
    /// </summary>
    [JsonPropertyName("appIdsForAppProperties")]
    public List<string> AppIdsForAppProperties { get; set; } = [];
}

/// <summary>
/// 获取文件或文件夹信息请求
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdQueryRequest
{
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public PostV10StorageSpacesBySpaceIdDentriesByDentryIdQueryRequestOption? Option { get; set; }
}

/// <summary>
/// 属性。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesQueryResponseResultItemsItemDentryDentryProperties
{
    /// <summary>
    /// ReadOnly
    /// </summary>
    [JsonPropertyName("readOnly")]
    public bool ReadOnly { get; set; }
}

/// <summary>
/// PostV10StorageSpacesBySpaceIdDentriesQueryResponseResultItemsItemDentryDentryAppPropertiesItem
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesQueryResponseResultItemsItemDentryDentryAppPropertiesItem
{
    /// <summary>
    /// Name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// Value
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
    /// <summary>
    /// Visibility
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>
/// 缩略图信息。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesQueryResponseResultItemsItemDentryDentryThumbnail
{
    /// <summary>
    /// 缩略图宽度，单位px。
    /// </summary>
    [JsonPropertyName("width")]
    public long Width { get; set; }
    /// <summary>
    /// 缩略图高度，单位px。
    /// </summary>
    [JsonPropertyName("height")]
    public long Height { get; set; }
    /// <summary>
    /// 缩略图url。
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>
/// 文件或文件夹信息列表。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesQueryResponseResultItemsItemDentryDentry
{
    /// <summary>
    /// 文件或文件夹id。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 所在空间Id。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public required string SpaceId { get; set; }
    /// <summary>
    /// 父目录Id。
    /// </summary>
    [JsonPropertyName("parentId")]
    public required string ParentId { get; set; }
    /// <summary>
    /// 类型。 FILE：文件 FOLDER：文件夹
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 文件或文件夹名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 文件大小，单位Byte。 说明 文件夹不返回该字段。
    /// </summary>
    [JsonPropertyName("size")]
    public long Size { get; set; }
    /// <summary>
    /// 路径。
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }
    /// <summary>
    /// 版本。
    /// </summary>
    [JsonPropertyName("version")]
    public long Version { get; set; }
    /// <summary>
    /// 状态。 NORMAL：正常 DELETED：已删除 EXPIRED：已过期
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }
    /// <summary>
    /// 文件后缀。 说明 文件夹不返回该字段。
    /// </summary>
    [JsonPropertyName("extension")]
    public required string Extension { get; set; }
    /// <summary>
    /// 创建者unionId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// 修改者unionId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 创建时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 修改时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
    /// <summary>
    /// 属性。
    /// </summary>
    [JsonPropertyName("properties")]
    public required PostV10StorageSpacesBySpaceIdDentriesQueryResponseResultItemsItemDentryDentryProperties Properties { get; set; }
    /// <summary>
    /// 在特定应用上的属性。
    /// </summary>
    [JsonPropertyName("appProperties")]
    public List<PostV10StorageSpacesBySpaceIdDentriesQueryResponseResultItemsItemDentryDentryAppPropertiesItem> AppProperties { get; set; } = [];
    /// <summary>
    /// 标识字段。
    /// </summary>
    [JsonPropertyName("uuid")]
    public required string Uuid { get; set; }
    /// <summary>
    /// 存储分区。 PUBLIC_OSS_PARTITION：公有云OSS存储分区 MINI_OSS_PARTITION：专属MiniOSS存储分区
    /// </summary>
    [JsonPropertyName("partitionType")]
    public required string PartitionType { get; set; }
    /// <summary>
    /// 驱动类型。 DINGTALK：钉钉统一存储驱动 ALIDOC：钉钉文档存储驱动 UNKNOWN：未知驱动
    /// </summary>
    [JsonPropertyName("storageDriver")]
    public required string StorageDriver { get; set; }
    /// <summary>
    /// 缩略图信息。
    /// </summary>
    [JsonPropertyName("thumbnail")]
    public required PostV10StorageSpacesBySpaceIdDentriesQueryResponseResultItemsItemDentryDentryThumbnail Thumbnail { get; set; }
}

/// <summary>
/// 文件或文件夹的信息。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesQueryResponseResultItemsItemDentry
{
    /// <summary>
    /// 文件或文件夹信息列表。
    /// </summary>
    [JsonPropertyName("dentry")]
    public required PostV10StorageSpacesBySpaceIdDentriesQueryResponseResultItemsItemDentryDentry Dentry { get; set; }
}

/// <summary>
/// PostV10StorageSpacesBySpaceIdDentriesQueryResponseResultItemsItem
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesQueryResponseResultItemsItem
{
    /// <summary>
    /// 文件或文件夹所在空间ID。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public string? SpaceId { get; set; }
    /// <summary>
    /// 文件或文件夹的ID。
    /// </summary>
    [JsonPropertyName("dentryId")]
    public string? DentryId { get; set; }
    /// <summary>
    /// 文件或文件夹获取是否成功，true表示成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
    /// <summary>
    /// 错误原因。
    /// </summary>
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }
    /// <summary>
    /// 文件或文件夹的信息。
    /// </summary>
    [JsonPropertyName("dentry")]
    public PostV10StorageSpacesBySpaceIdDentriesQueryResponseResultItemsItemDentry? Dentry { get; set; }
}

/// <summary>
/// 批量获取文件或文件夹信息响应
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesQueryResponse
{
    /// <summary>
    /// 批量获取的文件或文件夹信息列表。
    /// </summary>
    [JsonPropertyName("resultItems")]
    public List<PostV10StorageSpacesBySpaceIdDentriesQueryResponseResultItemsItem> ResultItems { get; set; } = [];
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesQueryRequestOption
{
    /// <summary>
    /// 指定应用ID列表，最大值20。 企业内部应用，调用获取空间信息接口获取ownerId参数值。 第三方企业应用，调用获取空间信息接口获取ownerId参数值。 说明 如果传该参数，会返回该文件或文件夹对应应用的属性。 如果不传该参数，会返回该文件或文件夹的所有应用的属性。
    /// </summary>
    [JsonPropertyName("appIdsForAppProperties")]
    public List<string> AppIdsForAppProperties { get; set; } = [];
}

/// <summary>
/// 批量获取文件或文件夹信息请求
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesQueryRequest
{
    /// <summary>
    /// 文件或文件夹的ID列表，最大值30。
    /// </summary>
    [JsonPropertyName("dentryIds")]
    public List<string> DentryIds { get; set; } = [];
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public PostV10StorageSpacesBySpaceIdDentriesQueryRequestOption? Option { get; set; }
}

/// <summary>
/// 属性。
/// </summary>
public class GetV10StorageSpacesBySpaceIdDentriesResponseDentriesProperties
{
    /// <summary>
    /// ReadOnly
    /// </summary>
    [JsonPropertyName("readOnly")]
    public bool ReadOnly { get; set; }
}

/// <summary>
/// GetV10StorageSpacesBySpaceIdDentriesResponseDentriesAppPropertiesItem
/// </summary>
public class GetV10StorageSpacesBySpaceIdDentriesResponseDentriesAppPropertiesItem
{
    /// <summary>
    /// Name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// Value
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
    /// <summary>
    /// Visibility
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>
/// 文件或文件夹信息列表。
/// </summary>
public class GetV10StorageSpacesBySpaceIdDentriesResponseDentries
{
    /// <summary>
    /// 文件或文件夹id。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 所在空间Id。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public required string SpaceId { get; set; }
    /// <summary>
    /// 父目录Id。
    /// </summary>
    [JsonPropertyName("parentId")]
    public required string ParentId { get; set; }
    /// <summary>
    /// 类型。 FILE：文件 FOLDER：文件夹
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 文件或文件夹名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 文件大小，单位Byte。 说明 文件夹不返回该字段。
    /// </summary>
    [JsonPropertyName("size")]
    public long Size { get; set; }
    /// <summary>
    /// 路径。
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }
    /// <summary>
    /// 版本。
    /// </summary>
    [JsonPropertyName("version")]
    public long Version { get; set; }
    /// <summary>
    /// 状态。 NORMAL：正常 DELETED：已删除 EXPIRED：已过期
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }
    /// <summary>
    /// 文件后缀。 说明 文件夹不返回该字段。
    /// </summary>
    [JsonPropertyName("extension")]
    public required string Extension { get; set; }
    /// <summary>
    /// 创建者unionId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// 修改者unionId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 创建时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 修改时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
    /// <summary>
    /// 属性。
    /// </summary>
    [JsonPropertyName("properties")]
    public required GetV10StorageSpacesBySpaceIdDentriesResponseDentriesProperties Properties { get; set; }
    /// <summary>
    /// 在特定应用上的属性。
    /// </summary>
    [JsonPropertyName("appProperties")]
    public List<GetV10StorageSpacesBySpaceIdDentriesResponseDentriesAppPropertiesItem> AppProperties { get; set; } = [];
    /// <summary>
    /// 标识字段。
    /// </summary>
    [JsonPropertyName("uuid")]
    public required string Uuid { get; set; }
    /// <summary>
    /// 存储分区。 PUBLIC_OSS_PARTITION：公有云OSS存储分区 MINI_OSS_PARTITION：专属MiniOSS存储分区
    /// </summary>
    [JsonPropertyName("partitionType")]
    public required string PartitionType { get; set; }
    /// <summary>
    /// 驱动类型。 DINGTALK：钉钉统一存储驱动 ALIDOC：钉钉文档存储驱动 UNKNOWN：未知驱动
    /// </summary>
    [JsonPropertyName("storageDriver")]
    public required string StorageDriver { get; set; }
}

/// <summary>
/// 获取文件或文件夹列表响应
/// </summary>
public class GetV10StorageSpacesBySpaceIdDentriesResponse
{
    /// <summary>
    /// 文件或文件夹信息列表。
    /// </summary>
    [JsonPropertyName("dentries")]
    public required GetV10StorageSpacesBySpaceIdDentriesResponseDentries Dentries { get; set; }
    /// <summary>
    /// 分页游标。 说明 该字段不为空，表示有更多数据。
    /// </summary>
    [JsonPropertyName("nextToken")]
    public required string NextToken { get; set; }
}

/// <summary>
/// 属性。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesListAllResponseDentriesProperties
{
    /// <summary>
    /// ReadOnly
    /// </summary>
    [JsonPropertyName("readOnly")]
    public bool ReadOnly { get; set; }
}

/// <summary>
/// PostV10StorageSpacesBySpaceIdDentriesListAllResponseDentriesAppPropertiesItem
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesListAllResponseDentriesAppPropertiesItem
{
    /// <summary>
    /// Name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// Value
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
    /// <summary>
    /// Visibility
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>
/// 文件或文件夹信息列表。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesListAllResponseDentries
{
    /// <summary>
    /// 文件或文件夹id。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 所在空间Id。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public required string SpaceId { get; set; }
    /// <summary>
    /// 父目录Id。
    /// </summary>
    [JsonPropertyName("parentId")]
    public required string ParentId { get; set; }
    /// <summary>
    /// 类型。 FILE：文件 FOLDER：文件夹
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 文件或文件夹名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 文件大小，单位Byte。 说明 文件夹不返回该字段。
    /// </summary>
    [JsonPropertyName("size")]
    public long Size { get; set; }
    /// <summary>
    /// 路径。
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }
    /// <summary>
    /// 版本。
    /// </summary>
    [JsonPropertyName("version")]
    public long Version { get; set; }
    /// <summary>
    /// 状态。 NORMAL：正常 DELETED：已删除 EXPIRED：已过期
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }
    /// <summary>
    /// 文件后缀。 说明 文件夹不返回该字段。
    /// </summary>
    [JsonPropertyName("extension")]
    public required string Extension { get; set; }
    /// <summary>
    /// 创建者unionId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// 修改者unionId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 创建时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 修改时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
    /// <summary>
    /// 属性。
    /// </summary>
    [JsonPropertyName("properties")]
    public required PostV10StorageSpacesBySpaceIdDentriesListAllResponseDentriesProperties Properties { get; set; }
    /// <summary>
    /// 在特定应用上的属性。
    /// </summary>
    [JsonPropertyName("appProperties")]
    public List<PostV10StorageSpacesBySpaceIdDentriesListAllResponseDentriesAppPropertiesItem> AppProperties { get; set; } = [];
    /// <summary>
    /// 标识字段。
    /// </summary>
    [JsonPropertyName("uuid")]
    public required string Uuid { get; set; }
    /// <summary>
    /// 存储分区。 PUBLIC_OSS_PARTITION：公有云OSS存储分区 MINI_OSS_PARTITION：专属MiniOSS存储分区
    /// </summary>
    [JsonPropertyName("partitionType")]
    public required string PartitionType { get; set; }
    /// <summary>
    /// 驱动类型。 DINGTALK：钉钉统一存储驱动 ALIDOC：钉钉文档存储驱动 UNKNOWN：未知驱动
    /// </summary>
    [JsonPropertyName("storageDriver")]
    public required string StorageDriver { get; set; }
}

/// <summary>
/// 获取空间下所有文件或文件夹列表响应
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesListAllResponse
{
    /// <summary>
    /// 文件或文件夹信息列表。
    /// </summary>
    [JsonPropertyName("dentries")]
    public required PostV10StorageSpacesBySpaceIdDentriesListAllResponseDentries Dentries { get; set; }
    /// <summary>
    /// 分页游标。 说明 该字段不为空，表示有更多数据。
    /// </summary>
    [JsonPropertyName("nextToken")]
    public required string NextToken { get; set; }
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesListAllRequestOption
{
    /// <summary>
    /// 分页游标。 如果是首次调用，该参数不传。 如果是非首次调用，该参数传上次调用时返回的nextToken。
    /// </summary>
    [JsonPropertyName("nextToken")]
    public string? NextToken { get; set; }
    /// <summary>
    /// 排序规则，目前仅支持按修改时间排序。 ASC（默认）：升序 DESC：降序 说明 如果是升序排序，分页拉取过程中，如果文件发生变化，可能拉取到重复数据。 如果是降序排序，分页拉取过程中，如果文件发生变化， 可能会丢失数据。
    /// </summary>
    [JsonPropertyName("order")]
    public string? Order { get; set; }
}

/// <summary>
/// 获取空间下所有文件或文件夹列表请求
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesListAllRequest
{
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public PostV10StorageSpacesBySpaceIdDentriesListAllRequestOption? Option { get; set; }
}

/// <summary>
/// 删除文件或文件夹的应用属性响应
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdAppPropertiesRemoveResponse
{
    /// <summary>
    /// 本次删除是否成功。 true：成功 false：失败
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }
}

/// <summary>
/// 删除文件或文件夹的应用属性请求
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdAppPropertiesRemoveRequest
{
    /// <summary>
    /// 文件或文件夹的应用属性名称列表，最大值3。
    /// </summary>
    [JsonPropertyName("propertyNames")]
    public List<string> PropertyNames { get; set; } = [];
}

/// <summary>
/// 获取文件预览或编辑信息响应
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdOpenInfosQueryResponse
{
    /// <summary>
    /// 文件链接。
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
    /// <summary>
    /// 是否支持水印。 true：支持 false：不支持
    /// </summary>
    [JsonPropertyName("hasWaterMark")]
    public bool HasWaterMark { get; set; }
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdOpenInfosQueryRequestOption
{
    /// <summary>
    /// 文件的打开方式。 PREVIEW：预览，默认值 EDIT：编辑
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// 获取文件预览或编辑信息请求
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdOpenInfosQueryRequest
{
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public PostV10StorageSpacesBySpaceIdDentriesByDentryIdOpenInfosQueryRequestOption? Option { get; set; }
}

/// <summary>
/// 缩略图信息。
/// </summary>
public class PostV10StorageSpacesBySpaceIdThumbnailsQueryResponseResultItemsItemThumbnail
{
    /// <summary>
    /// 缩略图宽度，单位px。
    /// </summary>
    [JsonPropertyName("width")]
    public long Width { get; set; }
    /// <summary>
    /// 缩略图高度，单位px。
    /// </summary>
    [JsonPropertyName("height")]
    public long Height { get; set; }
    /// <summary>
    /// 缩略图url。
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>
/// PostV10StorageSpacesBySpaceIdThumbnailsQueryResponseResultItemsItem
/// </summary>
public class PostV10StorageSpacesBySpaceIdThumbnailsQueryResponseResultItemsItem
{
    /// <summary>
    /// 文件所在空间ID。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public string? SpaceId { get; set; }
    /// <summary>
    /// 文件ID。
    /// </summary>
    [JsonPropertyName("dentryId")]
    public string? DentryId { get; set; }
    /// <summary>
    /// 是否成功获取到缩略图信息，true表示成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
    /// <summary>
    /// 错误原因。
    /// </summary>
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }
    /// <summary>
    /// 缩略图信息。
    /// </summary>
    [JsonPropertyName("thumbnail")]
    public PostV10StorageSpacesBySpaceIdThumbnailsQueryResponseResultItemsItemThumbnail? Thumbnail { get; set; }
}

/// <summary>
/// 批量获取文件缩略图响应
/// </summary>
public class PostV10StorageSpacesBySpaceIdThumbnailsQueryResponse
{
    /// <summary>
    /// 缩略图获取结果列表。
    /// </summary>
    [JsonPropertyName("resultItems")]
    public List<PostV10StorageSpacesBySpaceIdThumbnailsQueryResponseResultItemsItem> ResultItems { get; set; } = [];
}

/// <summary>
/// 批量获取文件缩略图请求
/// </summary>
public class PostV10StorageSpacesBySpaceIdThumbnailsQueryRequest
{
    /// <summary>
    /// 文件ID，最大值30。 企业内部应用，调用获取文件或文件夹列表接口获取id参数值。 第三方企业应用，调用获取文件或文件夹列表接口获取id参数值。
    /// </summary>
    [JsonPropertyName("dentryIds")]
    public List<string> DentryIds { get; set; } = [];
}

/// <summary>
/// 初始化文件分片上传响应
/// </summary>
public class PostV10StorageSpacesBySpaceIdFilesMultiPartUploadInfosInitResponse
{
    /// <summary>
    /// 上传唯一标识。
    /// </summary>
    [JsonPropertyName("uploadKey")]
    public required string UploadKey { get; set; }
    /// <summary>
    /// 文件存储类型。 DINGTALK：钉钉统一存储驱动 ALIDOC：钉钉文档存储驱动 SHANJI：闪记存储驱动 UNKNOWN：未知驱动
    /// </summary>
    [JsonPropertyName("storageDriver")]
    public required string StorageDriver { get; set; }
}

/// <summary>
/// 预检查的字段。 说明 可实现对文件名称、文件完整性、容量的校验。
/// </summary>
public class PostV10StorageSpacesBySpaceIdFilesMultiPartUploadInfosInitRequestOptionPreCheckParam
{
    /// <summary>
    /// 文件md5值，DigestUtils.md5Hex()。 说明 文件完整性校验，不传则不做校验。
    /// </summary>
    [JsonPropertyName("md5")]
    public string? Md5 { get; set; }
    /// <summary>
    /// 父目录Id。根目录时，该参数是0。 企业内部应用，调用获取文件或文件夹列表接口获取parentId参数值。 第三方企业应用，调用获取文件或文件夹列表接口获取parentId参数值。 说明 用于同目录文件名冲突校验。
    /// </summary>
    [JsonPropertyName("parentId")]
    public string? ParentId { get; set; }
    /// <summary>
    /// 文件名称，命名有以下要求： 头尾不能包含空格，否则会自动去除 不能包含特殊字符，包括：制表符、*、"、&lt;、&gt;、| 不能以"."结尾 说明 文件名称合法性和文件名称冲突校验。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV10StorageSpacesBySpaceIdFilesMultiPartUploadInfosInitRequestOption
{
    /// <summary>
    /// 文件存储驱动类型，目前只支持DINGTALK。
    /// </summary>
    [JsonPropertyName("storageDriver")]
    public string? StorageDriver { get; set; }
    /// <summary>
    /// 预检查的字段。 说明 可实现对文件名称、文件完整性、容量的校验。
    /// </summary>
    [JsonPropertyName("preCheckParam")]
    public PostV10StorageSpacesBySpaceIdFilesMultiPartUploadInfosInitRequestOptionPreCheckParam? PreCheckParam { get; set; }
    /// <summary>
    /// 优先地域。 ZHANGJIAKOU：张家口 SHENZHEN：深圳 SHANGHAI：上海 SINGAPORE：新加坡 UNKNOWN：未知 说明 倾向于将资源存到哪个地域，可实现就近上传等功能。
    /// </summary>
    [JsonPropertyName("preferRegion")]
    public string? PreferRegion { get; set; }
}

/// <summary>
/// 初始化文件分片上传请求
/// </summary>
public class PostV10StorageSpacesBySpaceIdFilesMultiPartUploadInfosInitRequest
{
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public PostV10StorageSpacesBySpaceIdFilesMultiPartUploadInfosInitRequestOption? Option { get; set; }
}

/// <summary>
/// 请求头。
/// </summary>
public class PostV10StorageSpacesFilesMultiPartUploadInfosQueryResponseMultipartHeaderSignatureInfosItemHeaderSignatureInfoHeaders
{
    /// <summary>
    /// Key
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }
}

/// <summary>
/// header信息。
/// </summary>
public class PostV10StorageSpacesFilesMultiPartUploadInfosQueryResponseMultipartHeaderSignatureInfosItemHeaderSignatureInfo
{
    /// <summary>
    /// 多个上传URL，最大值10，前面的url优先。
    /// </summary>
    [JsonPropertyName("resourceUrls")]
    public List<string> ResourceUrls { get; set; } = [];
    /// <summary>
    /// 请求头。
    /// </summary>
    [JsonPropertyName("headers")]
    public required PostV10StorageSpacesFilesMultiPartUploadInfosQueryResponseMultipartHeaderSignatureInfosItemHeaderSignatureInfoHeaders Headers { get; set; }
    /// <summary>
    /// 过期时间，单位秒。
    /// </summary>
    [JsonPropertyName("expirationSeconds")]
    public long ExpirationSeconds { get; set; }
    /// <summary>
    /// 地域。 ZHANGJIAKOU：张家口 SHENZHEN：深圳 SHANGHAI：上海 SINGAPORE：新加坡 UNKNOWN：未知
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
    /// <summary>
    /// 内网URL列表。 说明 该字段目前无使用场景，请忽略。
    /// </summary>
    [JsonPropertyName("internalResourceUrls")]
    public List<string> InternalResourceUrls { get; set; } = [];
}

/// <summary>
/// PostV10StorageSpacesFilesMultiPartUploadInfosQueryResponseMultipartHeaderSignatureInfosItem
/// </summary>
public class PostV10StorageSpacesFilesMultiPartUploadInfosQueryResponseMultipartHeaderSignatureInfosItem
{
    /// <summary>
    /// 分片Id。
    /// </summary>
    [JsonPropertyName("partNumber")]
    public long? PartNumber { get; set; }
    /// <summary>
    /// header信息。
    /// </summary>
    [JsonPropertyName("headerSignatureInfo")]
    public PostV10StorageSpacesFilesMultiPartUploadInfosQueryResponseMultipartHeaderSignatureInfosItemHeaderSignatureInfo? HeaderSignatureInfo { get; set; }
}

/// <summary>
/// 获取文件分片上传信息响应
/// </summary>
public class PostV10StorageSpacesFilesMultiPartUploadInfosQueryResponse
{
    /// <summary>
    /// 分片Header加签上传信息列表。
    /// </summary>
    [JsonPropertyName("multipartHeaderSignatureInfos")]
    public List<PostV10StorageSpacesFilesMultiPartUploadInfosQueryResponseMultipartHeaderSignatureInfosItem> MultipartHeaderSignatureInfos { get; set; } = [];
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV10StorageSpacesFilesMultiPartUploadInfosQueryRequestOption
{
    /// <summary>
    /// 扩展数据。
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object?> ExtensionData { get; set; } = [];
}

/// <summary>
/// 获取文件分片上传信息请求
/// </summary>
public class PostV10StorageSpacesFilesMultiPartUploadInfosQueryRequest
{
    /// <summary>
    /// 上传唯一标识。 企业内部应用，调用初始化文件分片上传接口，获取上传标识uploadKey。 第三方企业应用，调用初始化文件分片上传接口，获取上传标识uploadKey。
    /// </summary>
    [JsonPropertyName("uploadKey")]
    public required string UploadKey { get; set; }
    /// <summary>
    /// 每片文件的Id，文件的分片数量最大值10000，每片文件大小限制范围是100KB~5GB，最多传30。 说明 每片文件的Id，由开发者指定，本接口会返回每片文件的上传地址和headers等信息。示例：[1,2,3,4,5]
    /// </summary>
    [JsonPropertyName("partNumbers")]
    public List<string> PartNumbers { get; set; } = [];
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public PostV10StorageSpacesFilesMultiPartUploadInfosQueryRequestOption? Option { get; set; }
}

/// <summary>
/// 请求头，最大size：20。
/// </summary>
public class PostV20StorageSpacesFilesByParentDentryUuidUploadInfosQueryResponseHeaderSignatureInfoHeaders
{
    /// <summary>
    /// Key
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }
}

/// <summary>
/// Header加签上传信息。 说明 当protocol参数传HEADER_SIGNATURE时，返回该字段。
/// </summary>
public class PostV20StorageSpacesFilesByParentDentryUuidUploadInfosQueryResponseHeaderSignatureInfo
{
    /// <summary>
    /// 传输地址。
    /// </summary>
    [JsonPropertyName("resourceUrls")]
    public List<string> ResourceUrls { get; set; } = [];
    /// <summary>
    /// 请求头，最大size：20。
    /// </summary>
    [JsonPropertyName("headers")]
    public required PostV20StorageSpacesFilesByParentDentryUuidUploadInfosQueryResponseHeaderSignatureInfoHeaders Headers { get; set; }
    /// <summary>
    /// 过期时间，单位秒
    /// </summary>
    [JsonPropertyName("expirationSeconds")]
    public long ExpirationSeconds { get; set; }
    /// <summary>
    /// 地域，枚举值： ZHANGJIAKOU：张家口 SHENZHEN：深圳 SHANGHAI：上海 SINGAPORE：新加坡 UNKNOWN：未知
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
    /// <summary>
    /// 内网地址。 说明 该字段目前无使用场景，请忽略。
    /// </summary>
    [JsonPropertyName("internalResourceUrls")]
    public List<string> InternalResourceUrls { get; set; } = [];
}

/// <summary>
/// 获取文件上传信息响应
/// </summary>
public class PostV20StorageSpacesFilesByParentDentryUuidUploadInfosQueryResponse
{
    /// <summary>
    /// 上传唯一标识
    /// </summary>
    [JsonPropertyName("uploadKey")]
    public required string UploadKey { get; set; }
    /// <summary>
    /// 文件存储类型。
    /// </summary>
    [JsonPropertyName("storageDriver")]
    public required string StorageDriver { get; set; }
    /// <summary>
    /// 上传协议： HEADER_SIGNATURE：Header加签
    /// </summary>
    [JsonPropertyName("protocol")]
    public required string Protocol { get; set; }
    /// <summary>
    /// Header加签上传信息。 说明 当protocol参数传HEADER_SIGNATURE时，返回该字段。
    /// </summary>
    [JsonPropertyName("headerSignatureInfo")]
    public required PostV20StorageSpacesFilesByParentDentryUuidUploadInfosQueryResponseHeaderSignatureInfo HeaderSignatureInfo { get; set; }
}

/// <summary>
/// 预检查的字段。可实现对文件名称，文件完整性，容量的校验
/// </summary>
public class PostV20StorageSpacesFilesByParentDentryUuidUploadInfosQueryRequestOptionPreCheckParam
{
    /// <summary>
    /// Name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// 可选参数
/// </summary>
public class PostV20StorageSpacesFilesByParentDentryUuidUploadInfosQueryRequestOption
{
    /// <summary>
    /// 文件存储驱动类型。 说明 当前只支持DINGTALK。
    /// </summary>
    [JsonPropertyName("storageDriver")]
    public string? StorageDriver { get; set; }
    /// <summary>
    /// 预检查的字段。可实现对文件名称，文件完整性，容量的校验
    /// </summary>
    [JsonPropertyName("preCheckParam")]
    public PostV20StorageSpacesFilesByParentDentryUuidUploadInfosQueryRequestOptionPreCheckParam? PreCheckParam { get; set; }
    /// <summary>
    /// 优先地域： ZHANGJIAKOU：张家口 SHENZHEN：深圳 SHANGHAI：上海 SINGAPORE：新加坡 UNKNOWN：未知 说明 倾向于将资源存到哪个地域，可实现就近上传等功能。
    /// </summary>
    [JsonPropertyName("preferRegion")]
    public string? PreferRegion { get; set; }
}

/// <summary>
/// 获取文件上传信息请求
/// </summary>
public class PostV20StorageSpacesFilesByParentDentryUuidUploadInfosQueryRequest
{
    /// <summary>
    /// 通过指定上传协议返回不同协议上传所需要的信息。 HEADER_SIGNATURE：Header加签
    /// </summary>
    [JsonPropertyName("protocol")]
    public required string Protocol { get; set; }
    /// <summary>
    /// 可选参数
    /// </summary>
    [JsonPropertyName("option")]
    public PostV20StorageSpacesFilesByParentDentryUuidUploadInfosQueryRequestOption? Option { get; set; }
}

/// <summary>
/// 属性。
/// </summary>
public class PostV20StorageSpacesFilesByParentDentryUuidCommitResponseDentryProperties
{
    /// <summary>
    /// ReadOnly
    /// </summary>
    [JsonPropertyName("readOnly")]
    public bool ReadOnly { get; set; }
}

/// <summary>
/// PostV20StorageSpacesFilesByParentDentryUuidCommitResponseDentryAppPropertiesItem
/// </summary>
public class PostV20StorageSpacesFilesByParentDentryUuidCommitResponseDentryAppPropertiesItem
{
    /// <summary>
    /// Name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// Value
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
    /// <summary>
    /// Visibility
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>
/// 缩略图信息。
/// </summary>
public class PostV20StorageSpacesFilesByParentDentryUuidCommitResponseDentryThumbnail
{
    /// <summary>
    /// 缩略图宽度。
    /// </summary>
    [JsonPropertyName("width")]
    public long Width { get; set; }
    /// <summary>
    /// 缩略图高度。
    /// </summary>
    [JsonPropertyName("height")]
    public long Height { get; set; }
    /// <summary>
    /// 缩略图url。
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>
/// 文件或文件夹信息列表。
/// </summary>
public class PostV20StorageSpacesFilesByParentDentryUuidCommitResponseDentry
{
    /// <summary>
    /// 文件或文件夹id。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 所在空间Id。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public required string SpaceId { get; set; }
    /// <summary>
    /// 父目录Id。
    /// </summary>
    [JsonPropertyName("parentId")]
    public required string ParentId { get; set; }
    /// <summary>
    /// 类型。 FILE：文件 FOLDER：文件夹
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 文件或文件夹名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 文件大小，单位Byte。 说明 文件夹不返回该字段。
    /// </summary>
    [JsonPropertyName("size")]
    public long Size { get; set; }
    /// <summary>
    /// 路径。
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }
    /// <summary>
    /// 版本。
    /// </summary>
    [JsonPropertyName("version")]
    public long Version { get; set; }
    /// <summary>
    /// 状态。 NORMAL：正常 DELETED：已删除 EXPIRED：已过期
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }
    /// <summary>
    /// 文件后缀。 说明 文件夹不返回该字段。
    /// </summary>
    [JsonPropertyName("extension")]
    public required string Extension { get; set; }
    /// <summary>
    /// 创建者unionId。
    /// </summary>
    [JsonPropertyName("creatorId")]
    public required string CreatorId { get; set; }
    /// <summary>
    /// 修改者unionId。
    /// </summary>
    [JsonPropertyName("modifierId")]
    public required string ModifierId { get; set; }
    /// <summary>
    /// 创建时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("createTime")]
    public required string CreateTime { get; set; }
    /// <summary>
    /// 修改时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("modifiedTime")]
    public required string ModifiedTime { get; set; }
    /// <summary>
    /// 属性。
    /// </summary>
    [JsonPropertyName("properties")]
    public required PostV20StorageSpacesFilesByParentDentryUuidCommitResponseDentryProperties Properties { get; set; }
    /// <summary>
    /// 在特定应用上的属性。
    /// </summary>
    [JsonPropertyName("appProperties")]
    public List<PostV20StorageSpacesFilesByParentDentryUuidCommitResponseDentryAppPropertiesItem> AppProperties { get; set; } = [];
    /// <summary>
    /// 标识字段。
    /// </summary>
    [JsonPropertyName("uuid")]
    public required string Uuid { get; set; }
    /// <summary>
    /// 存储分区。 PUBLIC_OSS_PARTITION：公有云OSS存储分区 MINI_OSS_PARTITION：专属MiniOSS存储分区
    /// </summary>
    [JsonPropertyName("partitionType")]
    public required string PartitionType { get; set; }
    /// <summary>
    /// 驱动类型。 DINGTALK：钉钉统一存储驱动 ALIDOC：钉钉文档存储驱动 UNKNOWN：未知驱动
    /// </summary>
    [JsonPropertyName("storageDriver")]
    public required string StorageDriver { get; set; }
    /// <summary>
    /// 缩略图信息。
    /// </summary>
    [JsonPropertyName("thumbnail")]
    public required PostV20StorageSpacesFilesByParentDentryUuidCommitResponseDentryThumbnail Thumbnail { get; set; }
    /// <summary>
    /// 类别，枚举值: IMAGE：图片 VIDEO：视频 AUDIO：音频 ARCHIVE：压缩包 SHORTCUT：快捷方式 DOCUMENT：文档 ALI_DOC：钉钉文档 OTHER：其它
    /// </summary>
    [JsonPropertyName("category")]
    public required string Category { get; set; }
}

/// <summary>
/// 提交文件响应
/// </summary>
public class PostV20StorageSpacesFilesByParentDentryUuidCommitResponse
{
    /// <summary>
    /// 文件或文件夹信息列表。
    /// </summary>
    [JsonPropertyName("dentry")]
    public required PostV20StorageSpacesFilesByParentDentryUuidCommitResponseDentry Dentry { get; set; }
}

/// <summary>
/// PostV20StorageSpacesFilesByParentDentryUuidCommitRequestOptionAppPropertiesItem
/// </summary>
public class PostV20StorageSpacesFilesByParentDentryUuidCommitRequestOptionAppPropertiesItem
{
    /// <summary>
    /// 属性名称。 说明 该属性名称在当前app下需要保证唯一，不同app间同名属性互不影响。
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// 属性值。
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
    /// <summary>
    /// 属性可见性。 PUBLIC：所有应用都可见 PRIVATE：仅限当前应用可见
    /// </summary>
    [JsonPropertyName("visibility")]
    public string? Visibility { get; set; }
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV20StorageSpacesFilesByParentDentryUuidCommitRequestOption
{
    /// <summary>
    /// 文件名称冲突策略。 AUTO_RENAME：自动重命名，默认值 OVERWRITE：覆盖 RETURN_DENTRY_IF_EXISTS：返回已存在文件 RETURN_ERROR_IF_EXISTS：文件已存在时报错
    /// </summary>
    [JsonPropertyName("conflictStrategy")]
    public string? ConflictStrategy { get; set; }
    /// <summary>
    /// 当前文件的应用属性列表，最大值3。
    /// </summary>
    [JsonPropertyName("appProperties")]
    public List<PostV20StorageSpacesFilesByParentDentryUuidCommitRequestOptionAppPropertiesItem> AppProperties { get; set; } = [];
}

/// <summary>
/// 提交文件请求
/// </summary>
public class PostV20StorageSpacesFilesByParentDentryUuidCommitRequest
{
    /// <summary>
    /// 添加文件唯一标识。 企业内部应用，调用获取文件上传信息接口获取uploadKey参数值。
    /// </summary>
    [JsonPropertyName("uploadKey")]
    public required string UploadKey { get; set; }
    /// <summary>
    /// 文件的名称，带后缀。命名有以下要求： 头尾不能包含空格，否则会自动去除 不能包含特殊字符，包括：制表符、*、"、&lt;、&gt;、| 不能以"."结尾
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public PostV20StorageSpacesFilesByParentDentryUuidCommitRequestOption? Option { get; set; }
}

/// <summary>
/// 请求头信息。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdDownloadInfosQueryResponseHeaderSignatureInfoHeaders
{
    /// <summary>
    /// Key
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }
}

/// <summary>
/// Header加签信息。 说明 当protocol字段值为HEADER_SIGNATURE时，此字段生效。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdDownloadInfosQueryResponseHeaderSignatureInfo
{
    /// <summary>
    /// 多个下载URL，越靠前的URL越优先。
    /// </summary>
    [JsonPropertyName("resourceUrls")]
    public List<string> ResourceUrls { get; set; } = [];
    /// <summary>
    /// 请求头信息。
    /// </summary>
    [JsonPropertyName("headers")]
    public required PostV10StorageSpacesBySpaceIdDentriesByDentryIdDownloadInfosQueryResponseHeaderSignatureInfoHeaders Headers { get; set; }
    /// <summary>
    /// 过期时间，单位秒。
    /// </summary>
    [JsonPropertyName("expirationSeconds")]
    public long ExpirationSeconds { get; set; }
    /// <summary>
    /// 地域。 ZHANGJIAKOU：张家口 SHENZHEN：深圳 SHANGHAI：上海 SINGAPORE：新加坡 UNKNOWN：未知
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
    /// <summary>
    /// 内网URL。 说明 该字段目前无使用场景，请忽略。
    /// </summary>
    [JsonPropertyName("internalResourceUrls")]
    public List<string> InternalResourceUrls { get; set; } = [];
}

/// <summary>
/// 获取文件下载信息响应
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdDownloadInfosQueryResponse
{
    /// <summary>
    /// 文件下载协议。 HEADER_SIGNATURE：Header加签
    /// </summary>
    [JsonPropertyName("protocol")]
    public required string Protocol { get; set; }
    /// <summary>
    /// Header加签信息。 说明 当protocol字段值为HEADER_SIGNATURE时，此字段生效。
    /// </summary>
    [JsonPropertyName("headerSignatureInfo")]
    public required PostV10StorageSpacesBySpaceIdDentriesByDentryIdDownloadInfosQueryResponseHeaderSignatureInfo HeaderSignatureInfo { get; set; }
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdDownloadInfosQueryRequestOption
{
    /// <summary>
    /// 扩展数据。
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object?> ExtensionData { get; set; } = [];
}

/// <summary>
/// 获取文件下载信息请求
/// </summary>
public class PostV10StorageSpacesBySpaceIdDentriesByDentryIdDownloadInfosQueryRequest
{
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public PostV10StorageSpacesBySpaceIdDentriesByDentryIdDownloadInfosQueryRequestOption? Option { get; set; }
}

/// <summary>
/// 修改权限响应
/// </summary>
public class PostV20StorageSpacesDentriesByDentryUuidPermissionsResponse
{
    /// <summary>
    /// 本次操作是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }
}

/// <summary>
/// PostV20StorageSpacesDentriesByDentryUuidPermissionsRequestMembersItem
/// </summary>
public class PostV20StorageSpacesDentriesByDentryUuidPermissionsRequestMembersItem
{
    /// <summary>
    /// 权限成员类型，枚举值: ORG：企业 DEPT：部门 TAG：自定义tag CONVERSATION：会话 USER：用户
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 权限成员id： type=ORG时, id为企业id type=DEPT时, id为部门id type=TAG时, id为标签id type=CONVERSATION时, id为会话id type=USER时, id为员工id
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 权限归属的企业： 说明 如果存在企业id, 对应member离职的时候会自动清理权限。 如果memberType是dept类型，必须要有企业id。
    /// </summary>
    [JsonPropertyName("corpId")]
    public string? CorpId { get; set; }
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV20StorageSpacesDentriesByDentryUuidPermissionsRequestOption
{
    /// <summary>
    /// 扩展数据。
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object?> ExtensionData { get; set; } = [];
}

/// <summary>
/// 修改权限请求
/// </summary>
public class PostV20StorageSpacesDentriesByDentryUuidPermissionsRequest
{
    /// <summary>
    /// 角色id，枚举值: OWNER: 拥有者, 具有以下权限点: PermissionPrivilegeEnum.INFO PermissionPrivilegeEnum.LIST PermissionPrivilegeEnum.PREVIEW PermissionPrivilegeEnum.READ PermissionPrivilegeEnum.WRI...
    /// </summary>
    [JsonPropertyName("roleId")]
    public required string RoleId { get; set; }
    /// <summary>
    /// 权限成员列表，最大size30。
    /// </summary>
    [JsonPropertyName("members")]
    public List<PostV20StorageSpacesDentriesByDentryUuidPermissionsRequestMembersItem> Members { get; set; } = [];
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public required PostV20StorageSpacesDentriesByDentryUuidPermissionsRequestOption Option { get; set; }
}

/// <summary>
/// 删除权限响应
/// </summary>
public class PostV20StorageSpacesDentriesByDentryUuidPermissionsRemoveResponse
{
    /// <summary>
    /// 本次操作是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }
}

/// <summary>
/// PostV20StorageSpacesDentriesByDentryUuidPermissionsRemoveRequestMembersItem
/// </summary>
public class PostV20StorageSpacesDentriesByDentryUuidPermissionsRemoveRequestMembersItem
{
    /// <summary>
    /// 权限成员类型，枚举值: ORG：企业 DEPT：部门 TAG：自定义tag CONVERSATION：会话 USER：用户
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 权限成员id： type=ORG时, id为企业id type=DEPT时, id为部门id type=TAG时, id为标签id type=CONVERSATION时, id为会话id type=USER时, id为员工userId
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 权限归属的企业： 说明 如果存在企业id, 对应member离职的时候会自动清理权限。 如果memberType是dept类型，必须要有企业id。
    /// </summary>
    [JsonPropertyName("corpId")]
    public string? CorpId { get; set; }
}

/// <summary>
/// 删除权限请求
/// </summary>
public class PostV20StorageSpacesDentriesByDentryUuidPermissionsRemoveRequest
{
    /// <summary>
    /// 角色id，枚举值: OWNER: 拥有者, 具有以下权限点: PermissionPrivilegeEnum.INFO PermissionPrivilegeEnum.LIST PermissionPrivilegeEnum.PREVIEW PermissionPrivilegeEnum.READ PermissionPrivilegeEnum.WRI...
    /// </summary>
    [JsonPropertyName("roleId")]
    public required string RoleId { get; set; }
    /// <summary>
    /// 权限成员列表，最大size30。
    /// </summary>
    [JsonPropertyName("members")]
    public List<PostV20StorageSpacesDentriesByDentryUuidPermissionsRemoveRequestMembersItem> Members { get; set; } = [];
}

/// <summary>
/// 权限成员。
/// </summary>
public class PostV20StorageSpacesDentriesByDentryUuidPermissionsQueryResponsePermissionsItemMember
{
    /// <summary>
    /// 权限成员类型，枚举值: ORG：企业 DEPT：部门 TAG：自定义tag CONVERSATION：会话 USER：用户
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 权限成员id： type=ORG时, id为企业id type=DEPT时, id为部门id type=TAG时, id为标签id type=CONVERSATION时, id为会话id type=USER时, id为员工userId
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 权限归属的企业。 说明 如果存在企业id, 对应member离职的时候会自动清理权限。 如果memberType是dept类型，必须要有企业id。
    /// </summary>
    [JsonPropertyName("corpId")]
    public required string CorpId { get; set; }
}

/// <summary>
/// 权限角色。
/// </summary>
public class PostV20StorageSpacesDentriesByDentryUuidPermissionsQueryResponsePermissionsItemRole
{
    /// <summary>
    /// 角色id，枚举值: OWNER: 拥有者, 具有以下权限点: PermissionPrivilegeEnum.INFO PermissionPrivilegeEnum.LIST PermissionPrivilegeEnum.PREVIEW PermissionPrivilegeEnum.READ PermissionPrivilegeEnum.WRI...
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 角色名称。
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// PostV20StorageSpacesDentriesByDentryUuidPermissionsQueryResponsePermissionsItem
/// </summary>
public class PostV20StorageSpacesDentriesByDentryUuidPermissionsQueryResponsePermissionsItem
{
    /// <summary>
    /// 文件uuid。
    /// </summary>
    [JsonPropertyName("dentryUuid")]
    public string? DentryUuid { get; set; }
    /// <summary>
    /// 权限成员。
    /// </summary>
    [JsonPropertyName("member")]
    public PostV20StorageSpacesDentriesByDentryUuidPermissionsQueryResponsePermissionsItemMember? Member { get; set; }
    /// <summary>
    /// 权限角色。
    /// </summary>
    [JsonPropertyName("role")]
    public PostV20StorageSpacesDentriesByDentryUuidPermissionsQueryResponsePermissionsItemRole? Role { get; set; }
    /// <summary>
    /// 有效时间。 说明 duration为空表示授权没有时效限制。
    /// </summary>
    [JsonPropertyName("duration")]
    public long? Duration { get; set; }
}

/// <summary>
/// 获取权限列表响应
/// </summary>
public class PostV20StorageSpacesDentriesByDentryUuidPermissionsQueryResponse
{
    /// <summary>
    /// 权限列表分页数据，最大size30。
    /// </summary>
    [JsonPropertyName("permissions")]
    public List<PostV20StorageSpacesDentriesByDentryUuidPermissionsQueryResponsePermissionsItem> Permissions { get; set; } = [];
    /// <summary>
    /// 分页游标。 说明 nextToken不为空表示有更多数据。
    /// </summary>
    [JsonPropertyName("nextToken")]
    public required string NextToken { get; set; }
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV20StorageSpacesDentriesByDentryUuidPermissionsQueryRequestOption
{
    /// <summary>
    /// 分页游标。
    /// </summary>
    [JsonPropertyName("nextToken")]
    public string? NextToken { get; set; }
    /// <summary>
    /// 过滤角色。
    /// </summary>
    [JsonPropertyName("filterRoleIds")]
    public List<string> FilterRoleIds { get; set; } = [];
}

/// <summary>
/// 获取权限列表请求
/// </summary>
public class PostV20StorageSpacesDentriesByDentryUuidPermissionsQueryRequest
{
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public PostV20StorageSpacesDentriesByDentryUuidPermissionsQueryRequestOption? Option { get; set; }
}

/// <summary>
/// 设置权限继承模式响应
/// </summary>
public class UpdateV20StorageSpacesDentriesByDentryUuidPermissionsInheritancesResponse
{
    /// <summary>
    /// 本次操作是否成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }
}

/// <summary>
/// 设置权限继承模式请求
/// </summary>
public class UpdateV20StorageSpacesDentriesByDentryUuidPermissionsInheritancesRequest
{
    /// <summary>
    /// 权限继承模式，枚举值: PASS_ON: 传递 当前文件(夹)会继承所有父节点的权限, 然后结合当前文件(夹)上的权限, 相同成员权限取最大。 BREAK: 打断 权限的传递在当前节点做一个打断。 说明 不支持OWNER和MANAGER的打断 默认权限继承模式
    /// </summary>
    [JsonPropertyName("inheritance")]
    public required string Inheritance { get; set; }
}

/// <summary>
/// 获取权限继承模式响应
/// </summary>
public class GetV20StorageSpacesDentriesByDentryUuidPermissionsInheritancesResponse
{
    /// <summary>
    /// 权限继承模式，枚举值: PASS_ON: 传递 当前文件(夹)会继承所有父节点的权限, 然后结合当前文件(夹)上的权限, 相同成员权限取最大。 BREAK: 打断 权限的传递在当前节点做一个打断。 说明 不支持OWNER和MANAGER的打断 默认权限继承模式
    /// </summary>
    [JsonPropertyName("inheritance")]
    public required string Inheritance { get; set; }
}

/// <summary>
/// 回收站信息。
/// </summary>
public class GetV10StorageRecycleBinsResponseRecycleBin
{
    /// <summary>
    /// 回收站id。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 回收站范围类型。 ORG：企业
    /// </summary>
    [JsonPropertyName("scope")]
    public required string Scope { get; set; }
    /// <summary>
    /// 回收站范围Id。
    /// </summary>
    [JsonPropertyName("scopeId")]
    public required string ScopeId { get; set; }
}

/// <summary>
/// 获取回收站信息响应
/// </summary>
public class GetV10StorageRecycleBinsResponse
{
    /// <summary>
    /// 回收站信息。
    /// </summary>
    [JsonPropertyName("recycleBin")]
    public required GetV10StorageRecycleBinsResponseRecycleBin RecycleBin { get; set; }
}

/// <summary>
/// GetV10StorageRecycleBinsByRecycleBinIdRecycleItemsResponseRecycleItemsItem
/// </summary>
public class GetV10StorageRecycleBinsByRecycleBinIdRecycleItemsResponseRecycleItemsItem
{
    /// <summary>
    /// 回收项id。
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    /// <summary>
    /// 原文件或文件夹所在的空间Id。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public string? SpaceId { get; set; }
    /// <summary>
    /// 原文件或文件夹Id。
    /// </summary>
    [JsonPropertyName("dentryId")]
    public string? DentryId { get; set; }
    /// <summary>
    /// 原文件或文件夹大小，单位Byte。
    /// </summary>
    [JsonPropertyName("size")]
    public long? Size { get; set; }
    /// <summary>
    /// 类型。 FILE：文件 FOLDER：文件夹
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    /// <summary>
    /// 原文件或文件夹名称。
    /// </summary>
    [JsonPropertyName("originalName")]
    public string? OriginalName { get; set; }
    /// <summary>
    /// 原文件或文件夹路径。
    /// </summary>
    [JsonPropertyName("originalPath")]
    public string? OriginalPath { get; set; }
    /// <summary>
    /// 删除操作人unionId。
    /// </summary>
    [JsonPropertyName("operatorId")]
    public string? OperatorId { get; set; }
    /// <summary>
    /// 删除时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("operatorTime")]
    public string? OperatorTime { get; set; }
}

/// <summary>
/// 获取回收项列表响应
/// </summary>
public class GetV10StorageRecycleBinsByRecycleBinIdRecycleItemsResponse
{
    /// <summary>
    /// 回收项列表。
    /// </summary>
    [JsonPropertyName("recycleItems")]
    public List<GetV10StorageRecycleBinsByRecycleBinIdRecycleItemsResponseRecycleItemsItem> RecycleItems { get; set; } = [];
    /// <summary>
    /// 分页游标。 说明 不为空表示有更多数据。
    /// </summary>
    [JsonPropertyName("nextToken")]
    public required string NextToken { get; set; }
}

/// <summary>
/// 回收项信息。
/// </summary>
public class GetV10StorageRecycleBinsByRecycleBinIdRecycleItemsByRecycleItemIdResponseItem
{
    /// <summary>
    /// 回收项id。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 原文件或文件夹所在空间Id。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public required string SpaceId { get; set; }
    /// <summary>
    /// 原文件或文件夹Id。
    /// </summary>
    [JsonPropertyName("dentryId")]
    public required string DentryId { get; set; }
    /// <summary>
    /// 原文件或文件夹大小，单位Byte。
    /// </summary>
    [JsonPropertyName("size")]
    public long Size { get; set; }
    /// <summary>
    /// 类型。 FILE：文件 FOLDER：文件夹
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
    /// <summary>
    /// 原文件或文件夹名称。
    /// </summary>
    [JsonPropertyName("originalName")]
    public required string OriginalName { get; set; }
    /// <summary>
    /// 原文件或文件夹路径。
    /// </summary>
    [JsonPropertyName("originalPath")]
    public required string OriginalPath { get; set; }
    /// <summary>
    /// 删除操作人unionId。
    /// </summary>
    [JsonPropertyName("operatorId")]
    public required string OperatorId { get; set; }
    /// <summary>
    /// 删除时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("operatorTime")]
    public required string OperatorTime { get; set; }
}

/// <summary>
/// 获取回收项信息响应
/// </summary>
public class GetV10StorageRecycleBinsByRecycleBinIdRecycleItemsByRecycleItemIdResponse
{
    /// <summary>
    /// 回收项信息。
    /// </summary>
    [JsonPropertyName("item")]
    public required GetV10StorageRecycleBinsByRecycleBinIdRecycleItemsByRecycleItemIdResponseItem Item { get; set; }
}

/// <summary>
/// 删除回收项响应
/// </summary>
public class DeleteV10StorageRecycleBinsByRecycleBinIdRecycleItemsByRecycleItemIdResponse
{
    /// <summary>
    /// 本次操作是否成功。 true：成功 false：失败
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }
}

/// <summary>
/// 还原回收项响应
/// </summary>
public class PostV10StorageRecycleBinsByRecycleBinIdRecycleItemsByRecycleItemIdRestoreResponse
{
    /// <summary>
    /// 是否是异步任务。 说明 如果操作对象有子节点，则会异步处理。 true：是 false：不是
    /// </summary>
    [JsonPropertyName("async")]
    public bool Async { get; set; }
    /// <summary>
    /// 异步任务ID，用于查询任务执行状态。
    /// </summary>
    [JsonPropertyName("taskId")]
    public required string TaskId { get; set; }
    /// <summary>
    /// 操作对应根节点还原之后的空间ID。 说明 非失败的情况下，同步或者异步都会返回该参数。
    /// </summary>
    [JsonPropertyName("spaceId")]
    public required string SpaceId { get; set; }
    /// <summary>
    /// 操作对应根节点还原之后的文件ID。 说明 非失败的情况下，同步或者异步都会返回该参数。
    /// </summary>
    [JsonPropertyName("dentryId")]
    public required string DentryId { get; set; }
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV10StorageRecycleBinsByRecycleBinIdRecycleItemsByRecycleItemIdRestoreRequestOption
{
    /// <summary>
    /// 文件名称冲突策略，还原时原路径可能已经存在同名的文件。 AUTO_RENAME：自动重命名，默认值 OVERWRITE：覆盖 RETURN_DENTRY_IF_EXISTS：返回已存在文件 RETURN_ERROR_IF_EXISTS：文件已存在时报错
    /// </summary>
    [JsonPropertyName("conflictStrategy")]
    public string? ConflictStrategy { get; set; }
}

/// <summary>
/// 还原回收项请求
/// </summary>
public class PostV10StorageRecycleBinsByRecycleBinIdRecycleItemsByRecycleItemIdRestoreRequest
{
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public PostV10StorageRecycleBinsByRecycleBinIdRecycleItemsByRecycleItemIdRestoreRequestOption? Option { get; set; }
}

/// <summary>
/// PostV10StorageRecycleBinsByRecycleBinIdRecycleItemsBatchRestoreResponseResultItemsItem
/// </summary>
public class PostV10StorageRecycleBinsByRecycleBinIdRecycleItemsBatchRestoreResponseResultItemsItem
{
    /// <summary>
    /// RecycleBinId
    /// </summary>
    [JsonPropertyName("recycleBinId")]
    public string? RecycleBinId { get; set; }
    /// <summary>
    /// RecycleItemId
    /// </summary>
    [JsonPropertyName("recycleItemId")]
    public string? RecycleItemId { get; set; }
    /// <summary>
    /// Async
    /// </summary>
    [JsonPropertyName("async")]
    public bool? Async { get; set; }
    /// <summary>
    /// Success
    /// </summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
    /// <summary>
    /// ErrorCode
    /// </summary>
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }
    /// <summary>
    /// TaskId
    /// </summary>
    [JsonPropertyName("taskId")]
    public string? TaskId { get; set; }
    /// <summary>
    /// SpaceId
    /// </summary>
    [JsonPropertyName("spaceId")]
    public string? SpaceId { get; set; }
    /// <summary>
    /// DentryId
    /// </summary>
    [JsonPropertyName("dentryId")]
    public string? DentryId { get; set; }
}

/// <summary>
/// 批量还原回收项响应
/// </summary>
public class PostV10StorageRecycleBinsByRecycleBinIdRecycleItemsBatchRestoreResponse
{
    /// <summary>
    /// ResultItems
    /// </summary>
    [JsonPropertyName("resultItems")]
    public List<PostV10StorageRecycleBinsByRecycleBinIdRecycleItemsBatchRestoreResponseResultItemsItem> ResultItems { get; set; } = [];
}

/// <summary>
/// 可选参数。
/// </summary>
public class PostV10StorageRecycleBinsByRecycleBinIdRecycleItemsBatchRestoreRequestOption
{
    /// <summary>
    /// 文件名称冲突策略，还原时原路径可能已经存在同名的文件。 AUTO_RENAME：自动重命名，默认值 OVERWRITE：覆盖 RETURN_DENTRY_IF_EXISTS：返回已存在文件 RETURN_ERROR_IF_EXISTS：文件已存在时报错
    /// </summary>
    [JsonPropertyName("conflictStrategy")]
    public string? ConflictStrategy { get; set; }
}

/// <summary>
/// 批量还原回收项请求
/// </summary>
public class PostV10StorageRecycleBinsByRecycleBinIdRecycleItemsBatchRestoreRequest
{
    /// <summary>
    /// 回收项ID列表，最大值30。 企业内部应用，调用获取回收项列表接口获取id参数值。 第三方企业应用，调用获取回收项列表接口获取id参数值。
    /// </summary>
    [JsonPropertyName("recycleItemIds")]
    public List<string> RecycleItemIds { get; set; } = [];
    /// <summary>
    /// 可选参数。
    /// </summary>
    [JsonPropertyName("option")]
    public PostV10StorageRecycleBinsByRecycleBinIdRecycleItemsBatchRestoreRequestOption? Option { get; set; }
}

/// <summary>
/// 批量删除回收项响应
/// </summary>
public class PostV10StorageRecycleBinsByRecycleBinIdRecycleItemsBatchRemoveResponse
{
    /// <summary>
    /// 本次操作是否成功。 true：成功 false：失败
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }
}

/// <summary>
/// 批量删除回收项请求
/// </summary>
public class PostV10StorageRecycleBinsByRecycleBinIdRecycleItemsBatchRemoveRequest
{
    /// <summary>
    /// 回收项Id列表，最大值50。 企业内部应用，调用获取回收项列表接口获取id参数值。 第三方企业应用，调用获取回收项列表接口获取id参数值。
    /// </summary>
    [JsonPropertyName("recycleItemIds")]
    public List<string> RecycleItemIds { get; set; } = [];
}

/// <summary>
/// 清空回收站响应
/// </summary>
public class PostV10StorageRecycleBinsByRecycleBinIdClearResponse
{
    /// <summary>
    /// 本次操作是否成功。 true：成功 false：失败
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }
}

/// <summary>
/// 任务信息。
/// </summary>
public class GetV10StorageTasksByTaskIdResponseTask
{
    /// <summary>
    /// 任务ID。
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    /// <summary>
    /// 任务状态。 INIT：初始化 IN_PROGRESS：进行中 SUCCESS：成功 FAIL：失败
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }
    /// <summary>
    /// 子任务总数。
    /// </summary>
    [JsonPropertyName("totalCount")]
    public long TotalCount { get; set; }
    /// <summary>
    /// 子任务成功总数。
    /// </summary>
    [JsonPropertyName("successCount")]
    public long SuccessCount { get; set; }
    /// <summary>
    /// 子任务失败总数。
    /// </summary>
    [JsonPropertyName("failCount")]
    public long FailCount { get; set; }
    /// <summary>
    /// 任务失败原因。
    /// </summary>
    [JsonPropertyName("failMessage")]
    public required string FailMessage { get; set; }
    /// <summary>
    /// 任务开始时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("beginTime")]
    public required string BeginTime { get; set; }
    /// <summary>
    /// 任务结束时间，iso8601格式，例如：2022-07-29T14:55Z。
    /// </summary>
    [JsonPropertyName("endTime")]
    public required string EndTime { get; set; }
}

/// <summary>
/// 获取存储中异步任务信息响应
/// </summary>
public class GetV10StorageTasksByTaskIdResponse
{
    /// <summary>
    /// 任务信息。
    /// </summary>
    [JsonPropertyName("task")]
    public required GetV10StorageTasksByTaskIdResponseTask Task { get; set; }
}

/// <summary>
/// 订阅文件变更事件响应
/// </summary>
public class PostV10StorageEventsSubscribeResponse
{
    /// <summary>
    /// 本次操作是否成功，true表示成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }
}

/// <summary>
/// 订阅文件变更事件请求
/// </summary>
public class PostV10StorageEventsSubscribeRequest
{
    /// <summary>
    /// 订阅范围对应的ID。 当scope参数值为ORG时，scopeId对应的是企业corpId。 企业内部应用，请参考基础概念-CorpId。 第三方企业应用，请参考基础概念-CorpId。 当scope为SPACE时，scopeId对应的是存储空间ID。 企业内部应用，可调用添加空间接口获取id。 第三方企业应用，可调用添加空间接口获取id。
    /// </summary>
    [JsonPropertyName("scopeId")]
    public required string ScopeId { get; set; }
    /// <summary>
    /// 订阅范围。 ORG：企业 SPACE：空间
    /// </summary>
    [JsonPropertyName("scope")]
    public required string Scope { get; set; }
}

/// <summary>
/// 取消订阅文件变更事件响应
/// </summary>
public class PostV10StorageEventsUnsubscribeResponse
{
    /// <summary>
    /// 本次操作是否成功，true表示成功。
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; set; }
}

/// <summary>
/// 取消订阅文件变更事件请求
/// </summary>
public class PostV10StorageEventsUnsubscribeRequest
{
    /// <summary>
    /// 订阅范围对应的ID。 当scope参数值为ORG时，scopeId对应的是企业corpId。 企业内部应用，请参考基础概念-CorpId。 第三方企业应用，请参考基础概念-CorpId。 当scope为SPACE时，scopeId对应的是存储空间ID。 企业内部应用，可调用添加空间接口获取id。 第三方企业应用，可调用添加空间接口获取id。
    /// </summary>
    [JsonPropertyName("scopeId")]
    public required string ScopeId { get; set; }
    /// <summary>
    /// 订阅范围。 ORG：企业 SPACE：空间
    /// </summary>
    [JsonPropertyName("scope")]
    public required string Scope { get; set; }
}
