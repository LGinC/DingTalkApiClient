using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.DocumentFile;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.DocumentFile;

/// <summary>
/// 文档文件api
/// </summary>
public interface IDocumentFileApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 新建知识库
    /// </summary>
    [HttpPost("/v2.0/wiki/workspaces")]
    ITask<PostV20WikiWorkspacesResponse> PostV20WikiWorkspacesAsync(
        [JsonContent] PostV20WikiWorkspacesRequest request,
        string operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取知识库列表
    /// </summary>
    [HttpGet("/v2.0/wiki/workspaces")]
    ITask<GetV20WikiWorkspacesResponse> GetV20WikiWorkspacesAsync(
        string? nextToken,
        string? maxResults,
        string? orderBy,
        string? teamId,
        string? withPermissionRole,
        string operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取知识库
    /// </summary>
    [HttpGet("/v2.0/wiki/workspaces/{workspaceId}")]
    ITask<GetV20WikiWorkspacesByWorkspaceIdResponse> GetV20WikiWorkspacesByWorkspaceIdAsync(
        [PathQuery] string workspaceId,
        string? withPermissionRole,
        string operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量获取知识库
    /// </summary>
    [HttpPost("/v2.0/wiki/workspaces/batchQuery")]
    ITask<PostV20WikiWorkspacesBatchQueryResponse> PostV20WikiWorkspacesBatchQueryAsync(
        [JsonContent] PostV20WikiWorkspacesBatchQueryRequest request,
        string operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取我的文档知识库信息
    /// </summary>
    [HttpGet("/v2.0/wiki/mineWorkspaces")]
    ITask<GetV20WikiMineWorkspacesResponse> GetV20WikiMineWorkspacesAsync(string operatorId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建知识库文档
    /// </summary>
    [HttpPost("/v1.0/doc/workspaces/{workspaceId}/docs")]
    ITask<PostV10DocWorkspacesByWorkspaceIdDocsResponse> PostV10DocWorkspacesByWorkspaceIdDocsAsync(
        [JsonContent] PostV10DocWorkspacesByWorkspaceIdDocsRequest request,
        [PathQuery] string workspaceId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取节点
    /// </summary>
    [HttpGet("/v2.0/wiki/nodes/{nodeId}")]
    ITask<GetV20WikiNodesByNodeIdResponse> GetV20WikiNodesByNodeIdAsync(
        [PathQuery] string nodeId,
        string? withStatisticalInfo,
        string? withPermissionRole,
        string operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取节点列表
    /// </summary>
    [HttpGet("/v2.0/wiki/nodes")]
    ITask<GetV20WikiNodesResponse> GetV20WikiNodesAsync(
        string parentNodeId,
        string? nextToken,
        string? maxResults,
        string? withPermissionRole,
        string operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 通过链接获取节点
    /// </summary>
    [HttpPost("/v2.0/wiki/nodes/queryByUrl")]
    ITask<PostV20WikiNodesQueryByUrlResponse> PostV20WikiNodesQueryByUrlAsync(
        [JsonContent] PostV20WikiNodesQueryByUrlRequest request,
        string operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量获取节点
    /// </summary>
    [HttpPost("/v2.0/wiki/nodes/batchQuery")]
    ITask<PostV20WikiNodesBatchQueryResponse> PostV20WikiNodesBatchQueryAsync(
        [JsonContent] PostV20WikiNodesBatchQueryRequest request,
        string operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 新建空间
    /// </summary>
    [HttpPost("/v1.0/drive/spaces")]
    ITask<PostV10DriveSpacesResponse> PostV10DriveSpacesAsync(
        [JsonContent] PostV10DriveSpacesRequest request,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取空间列表
    /// </summary>
    [HttpGet("/v1.0/drive/spaces")]
    ITask<GetV10DriveSpacesResponse> GetV10DriveSpacesAsync(
        [JsonContent] GetV10DriveSpacesRequest request,
        string unionId,
        string spaceType,
        string? nextToken,
        string maxResults,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除空间
    /// </summary>
    [HttpDelete("/v1.0/drive/spaces/{spaceId}")]
    ITask<DeleteV10DriveSpacesBySpaceIdResponse> DeleteV10DriveSpacesBySpaceIdAsync(
        [PathQuery] string spaceId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取群存储空间信息
    /// </summary>
    [HttpPost("/v1.0/convFile/conversations/spaces/query")]
    ITask<PostV10ConvFileConversationsSpacesQueryResponse> PostV10ConvFileConversationsSpacesQueryAsync(
        [JsonContent] PostV10ConvFileConversationsSpacesQueryRequest request,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 以应用身份发送文件给指定用户
    /// </summary>
    [HttpPost("/v1.0/convFile/apps/conversations/files/send")]
    ITask<PostV10ConvFileAppsConversationsFilesSendResponse> PostV10ConvFileAppsConversationsFilesSendAsync(
        [JsonContent] PostV10ConvFileAppsConversationsFilesSendRequest request,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 发送文件到指定会话
    /// </summary>
    [HttpPost("/v1.0/convFile/conversations/files/send")]
    ITask<PostV10ConvFileConversationsFilesSendResponse> PostV10ConvFileConversationsFilesSendAsync(
        [JsonContent] PostV10ConvFileConversationsFilesSendRequest request,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 发送文件链接到指定会话
    /// </summary>
    [HttpPost("/v1.0/convFile/conversations/files/links/send")]
    ITask<PostV10ConvFileConversationsFilesLinksSendResponse> PostV10ConvFileConversationsFilesLinksSendAsync(
        [JsonContent] PostV10ConvFileConversationsFilesLinksSendRequest request,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 上传媒体文件
    /// </summary>
    [HttpPost("/media/upload")]
    ITask<PostMediaUploadResponse> PostMediaUploadAsync(
        [JsonContent] PostMediaUploadRequest request,
        string accessToken,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取所有工作表
    /// </summary>
    [HttpGet("/v1.0/doc/workbooks/{workbookId}/sheets")]
    ITask<GetV10DocWorkbooksByWorkbookIdSheetsResponse> GetV10DocWorkbooksByWorkbookIdSheetsAsync(
        [PathQuery] string workbookId,
        string? operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建工作表
    /// </summary>
    [HttpPost("/v1.0/doc/workbooks/{workbookId}/sheets")]
    ITask<PostV10DocWorkbooksByWorkbookIdSheetsResponse> PostV10DocWorkbooksByWorkbookIdSheetsAsync(
        [PathQuery] string workbookId,
        string operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取工作表
    /// </summary>
    [HttpGet("/v1.0/doc/workbooks/{workbookId}/sheets/{sheetId}")]
    ITask<GetV10DocWorkbooksByWorkbookIdSheetsBySheetIdResponse> GetV10DocWorkbooksByWorkbookIdSheetsBySheetIdAsync(
        [PathQuery] string workbookId,
        [PathQuery] string sheetId,
        string? operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除工作表
    /// </summary>
    [HttpDelete("/v1.0/doc/workbooks/{workbookId}/sheets/{sheetId}")]
    ITask<DeleteV10DocWorkbooksByWorkbookIdSheetsBySheetIdResponse> DeleteV10DocWorkbooksByWorkbookIdSheetsBySheetIdAsync(
        [PathQuery] string workbookId,
        [PathQuery] string sheetId,
        string? operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 指定行上方插入若干行
    /// </summary>
    [HttpPost("/v1.0/doc/workbooks/{workbookId}/sheets/{sheetId}/insertRowsBefore")]
    ITask<PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdInsertRowsBeforeResponse> PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdInsertRowsBeforeAsync(
        [JsonContent] PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdInsertRowsBeforeRequest request,
        [PathQuery] string workbookId,
        [PathQuery] string sheetId,
        string operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 指定列左侧插入若干列
    /// </summary>
    [HttpPost("/v1.0/doc/workbooks/{workbookId}/sheets/{sheetId}/insertColumnsBefore")]
    ITask<PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdInsertColumnsBeforeResponse> PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdInsertColumnsBeforeAsync(
        [JsonContent] PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdInsertColumnsBeforeRequest request,
        [PathQuery] string workbookId,
        [PathQuery] string sheetId,
        string operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除列
    /// </summary>
    [HttpPost("/v1.0/doc/workbooks/{workbookId}/sheets/{sheetId}/deleteColumns")]
    ITask<PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdDeleteColumnsResponse> PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdDeleteColumnsAsync(
        [JsonContent] PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdDeleteColumnsRequest request,
        [PathQuery] string workbookId,
        [PathQuery] string sheetId,
        string operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 设置行隐藏或显示
    /// </summary>
    [HttpPost("/v1.0/doc/workbooks/{workbookId}/sheets/{sheetId}/setRowsVisibility")]
    ITask<PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdSetRowsVisibilityResponse> PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdSetRowsVisibilityAsync(
        [JsonContent] PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdSetRowsVisibilityRequest request,
        [PathQuery] string workbookId,
        [PathQuery] string sheetId,
        string operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 设置列隐藏或显示
    /// </summary>
    [HttpPost("/v1.0/doc/workbooks/{workbookId}/sheets/{sheetId}/setColumnsVisibility")]
    ITask<PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdSetColumnsVisibilityResponse> PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdSetColumnsVisibilityAsync(
        [JsonContent] PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdSetColumnsVisibilityRequest request,
        [PathQuery] string workbookId,
        [PathQuery] string sheetId,
        string? operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取单元格区域
    /// </summary>
    [HttpGet("/v1.0/doc/workbooks/{workbookId}/sheets/{sheetId}/ranges/{rangeAddress}")]
    ITask<GetV10DocWorkbooksByWorkbookIdSheetsBySheetIdRangesByRangeAddressResponse> GetV10DocWorkbooksByWorkbookIdSheetsBySheetIdRangesByRangeAddressAsync(
        [PathQuery] string workbookId,
        [PathQuery] string sheetId,
        [PathQuery] string rangeAddress,
        string? select,
        string? operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新单元格区域
    /// </summary>
    [HttpPut("/v1.0/doc/workbooks/{workbookId}/sheets/{sheetId}/ranges/{rangeAddress}")]
    ITask<UpdateV10DocWorkbooksByWorkbookIdSheetsBySheetIdRangesByRangeAddressResponse> UpdateV10DocWorkbooksByWorkbookIdSheetsBySheetIdRangesByRangeAddressAsync(
        [JsonContent] UpdateV10DocWorkbooksByWorkbookIdSheetsBySheetIdRangesByRangeAddressRequest request,
        [PathQuery] string workbookId,
        [PathQuery] string sheetId,
        [PathQuery] string rangeAddress,
        string operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 清除单元格区域内数据
    /// </summary>
    [HttpPost("/v1.0/doc/workbooks/{workbookId}/sheets/{sheetId}/ranges/{rangeAddress}/clearData")]
    ITask<PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdRangesByRangeAddressClearDataResponse> PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdRangesByRangeAddressClearDataAsync(
        [PathQuery] string workbookId,
        [PathQuery] string sheetId,
        [PathQuery] string rangeAddress,
        string operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 清除单元格区域内所有内容
    /// </summary>
    [HttpPost("/v1.0/doc/workbooks/{workbookId}/sheets/{sheetId}/ranges/{rangeAddress}/clear")]
    ITask<PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdRangesByRangeAddressClearResponse> PostV10DocWorkbooksByWorkbookIdSheetsBySheetIdRangesByRangeAddressClearAsync(
        [PathQuery] string workbookId,
        [PathQuery] string sheetId,
        [PathQuery] string rangeAddress,
        string operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 搜索文件
    /// </summary>
    [HttpPost("/v2.0/storage/dentries/search")]
    ITask<PostV20StorageDentriesSearchResponse> PostV20StorageDentriesSearchAsync(
        [JsonContent] PostV20StorageDentriesSearchRequest request,
        string operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 搜索知识库
    /// </summary>
    [HttpPost("/v2.0/storage/workspaces/search")]
    ITask<PostV20StorageWorkspacesSearchResponse> PostV20StorageWorkspacesSearchAsync(
        [JsonContent] PostV20StorageWorkspacesSearchRequest request,
        string operatorId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取企业信息
    /// </summary>
    [HttpGet("/v1.0/storage/orgs/{corpId}")]
    ITask<GetV10StorageOrgsByCorpIdResponse> GetV10StorageOrgsByCorpIdAsync(
        [PathQuery] string corpId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取应用信息
    /// </summary>
    [HttpPost("/v1.0/storage/currentApps/query")]
    ITask<PostV10StorageCurrentAppsQueryResponse> PostV10StorageCurrentAppsQueryAsync(
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 添加空间
    /// </summary>
    [HttpPost("/v1.0/storage/spaces")]
    ITask<PostV10StorageSpacesResponse> PostV10StorageSpacesAsync(
        [JsonContent] PostV10StorageSpacesRequest request,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取空间信息
    /// </summary>
    [HttpGet("/v1.0/storage/spaces/{spaceId}")]
    ITask<GetV10StorageSpacesBySpaceIdResponse> GetV10StorageSpacesBySpaceIdAsync(
        [PathQuery] string spaceId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 添加文件夹
    /// </summary>
    [HttpPost("/v1.0/storage/spaces/{spaceId}/dentries/{parentId}/folders")]
    ITask<PostV10StorageSpacesBySpaceIdDentriesByParentIdFoldersResponse> PostV10StorageSpacesBySpaceIdDentriesByParentIdFoldersAsync(
        [JsonContent] PostV10StorageSpacesBySpaceIdDentriesByParentIdFoldersRequest request,
        [PathQuery] string spaceId,
        [PathQuery] string parentId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 复制文件或文件夹
    /// </summary>
    [HttpPost("/v1.0/storage/spaces/{spaceId}/dentries/{dentryId}/copy")]
    ITask<PostV10StorageSpacesBySpaceIdDentriesByDentryIdCopyResponse> PostV10StorageSpacesBySpaceIdDentriesByDentryIdCopyAsync(
        [JsonContent] PostV10StorageSpacesBySpaceIdDentriesByDentryIdCopyRequest request,
        [PathQuery] string spaceId,
        [PathQuery] string dentryId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量复制文件或文件夹
    /// </summary>
    [HttpPost("/v1.0/storage/spaces/{spaceId}/dentries/batchCopy")]
    ITask<PostV10StorageSpacesBySpaceIdDentriesBatchCopyResponse> PostV10StorageSpacesBySpaceIdDentriesBatchCopyAsync(
        [JsonContent] PostV10StorageSpacesBySpaceIdDentriesBatchCopyRequest request,
        [PathQuery] string spaceId,
        string? unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 移动文件或文件夹
    /// </summary>
    [HttpPost("/v1.0/storage/spaces/{spaceId}/dentries/{dentryId}/move")]
    ITask<PostV10StorageSpacesBySpaceIdDentriesByDentryIdMoveResponse> PostV10StorageSpacesBySpaceIdDentriesByDentryIdMoveAsync(
        [JsonContent] PostV10StorageSpacesBySpaceIdDentriesByDentryIdMoveRequest request,
        [PathQuery] string spaceId,
        [PathQuery] string dentryId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量移动文件或文件夹
    /// </summary>
    [HttpPost("/v1.0/storage/spaces/{spaceId}/dentries/batchMove")]
    ITask<PostV10StorageSpacesBySpaceIdDentriesBatchMoveResponse> PostV10StorageSpacesBySpaceIdDentriesBatchMoveAsync(
        [JsonContent] PostV10StorageSpacesBySpaceIdDentriesBatchMoveRequest request,
        [PathQuery] string spaceId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 重命名文件或文件夹
    /// </summary>
    [HttpPost("/v1.0/storage/spaces/{spaceId}/dentries/{dentryId}/rename")]
    ITask<PostV10StorageSpacesBySpaceIdDentriesByDentryIdRenameResponse> PostV10StorageSpacesBySpaceIdDentriesByDentryIdRenameAsync(
        [JsonContent] PostV10StorageSpacesBySpaceIdDentriesByDentryIdRenameRequest request,
        [PathQuery] string spaceId,
        [PathQuery] string dentryId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除文件或文件夹
    /// </summary>
    [HttpDelete("/v1.0/storage/spaces/{spaceId}/dentries/{dentryId}")]
    ITask<DeleteV10StorageSpacesBySpaceIdDentriesByDentryIdResponse> DeleteV10StorageSpacesBySpaceIdDentriesByDentryIdAsync(
        [PathQuery] string spaceId,
        [PathQuery] string dentryId,
        string? toRecycleBin,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量删除文件或文件夹
    /// </summary>
    [HttpPost("/v1.0/storage/spaces/{spaceId}/dentries/batchRemove")]
    ITask<PostV10StorageSpacesBySpaceIdDentriesBatchRemoveResponse> PostV10StorageSpacesBySpaceIdDentriesBatchRemoveAsync(
        [JsonContent] PostV10StorageSpacesBySpaceIdDentriesBatchRemoveRequest request,
        [PathQuery] string spaceId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 恢复文件历史版本
    /// </summary>
    [HttpPost("/v1.0/storage/spaces/{spaceId}/dentries/{dentryId}/versions/{version}/revert")]
    ITask<PostV10StorageSpacesBySpaceIdDentriesByDentryIdVersionsByVersionRevertResponse> PostV10StorageSpacesBySpaceIdDentriesByDentryIdVersionsByVersionRevertAsync(
        [PathQuery] string spaceId,
        [PathQuery] string dentryId,
        [PathQuery] string version,
        string? unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取文件版本列表
    /// </summary>
    [HttpGet("/v1.0/storage/spaces/{spaceId}/dentries/{dentryId}/versions")]
    ITask<GetV10StorageSpacesBySpaceIdDentriesByDentryIdVersionsResponse> GetV10StorageSpacesBySpaceIdDentriesByDentryIdVersionsAsync(
        [PathQuery] string spaceId,
        [PathQuery] string dentryId,
        string? nextToken,
        string? maxResults,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取文件或文件夹信息
    /// </summary>
    [HttpPost("/v1.0/storage/spaces/{spaceId}/dentries/{dentryId}/query")]
    ITask<PostV10StorageSpacesBySpaceIdDentriesByDentryIdQueryResponse> PostV10StorageSpacesBySpaceIdDentriesByDentryIdQueryAsync(
        [JsonContent] PostV10StorageSpacesBySpaceIdDentriesByDentryIdQueryRequest request,
        [PathQuery] string spaceId,
        [PathQuery] string dentryId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量获取文件或文件夹信息
    /// </summary>
    [HttpPost("/v1.0/storage/spaces/{spaceId}/dentries/query")]
    ITask<PostV10StorageSpacesBySpaceIdDentriesQueryResponse> PostV10StorageSpacesBySpaceIdDentriesQueryAsync(
        [JsonContent] PostV10StorageSpacesBySpaceIdDentriesQueryRequest request,
        [PathQuery] string spaceId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取文件或文件夹列表
    /// </summary>
    [HttpGet("/v1.0/storage/spaces/{spaceId}/dentries")]
    ITask<GetV10StorageSpacesBySpaceIdDentriesResponse> GetV10StorageSpacesBySpaceIdDentriesAsync(
        [PathQuery] string spaceId,
        string parentId,
        string? nextToken,
        string? maxResults,
        string? orderBy,
        string? order,
        string? withThumbnail,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取空间下所有文件或文件夹列表
    /// </summary>
    [HttpPost("/v1.0/storage/spaces/{spaceId}/dentries/listAll")]
    ITask<PostV10StorageSpacesBySpaceIdDentriesListAllResponse> PostV10StorageSpacesBySpaceIdDentriesListAllAsync(
        [JsonContent] PostV10StorageSpacesBySpaceIdDentriesListAllRequest request,
        [PathQuery] string spaceId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除文件或文件夹的应用属性
    /// </summary>
    [HttpPost("/v1.0/storage/spaces/{spaceId}/dentries/{dentryId}/appProperties/remove")]
    ITask<PostV10StorageSpacesBySpaceIdDentriesByDentryIdAppPropertiesRemoveResponse> PostV10StorageSpacesBySpaceIdDentriesByDentryIdAppPropertiesRemoveAsync(
        [JsonContent] PostV10StorageSpacesBySpaceIdDentriesByDentryIdAppPropertiesRemoveRequest request,
        [PathQuery] string spaceId,
        [PathQuery] string dentryId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取文件预览或编辑信息
    /// </summary>
    [HttpPost("/v1.0/storage/spaces/{spaceId}/dentries/{dentryId}/openInfos/query")]
    ITask<PostV10StorageSpacesBySpaceIdDentriesByDentryIdOpenInfosQueryResponse> PostV10StorageSpacesBySpaceIdDentriesByDentryIdOpenInfosQueryAsync(
        [JsonContent] PostV10StorageSpacesBySpaceIdDentriesByDentryIdOpenInfosQueryRequest request,
        [PathQuery] string spaceId,
        [PathQuery] string dentryId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量获取文件缩略图
    /// </summary>
    [HttpPost("/v1.0/storage/spaces/{spaceId}/thumbnails/query")]
    ITask<PostV10StorageSpacesBySpaceIdThumbnailsQueryResponse> PostV10StorageSpacesBySpaceIdThumbnailsQueryAsync(
        [JsonContent] PostV10StorageSpacesBySpaceIdThumbnailsQueryRequest request,
        [PathQuery] string spaceId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 初始化文件分片上传
    /// </summary>
    [HttpPost("/v1.0/storage/spaces/{spaceId}/files/multiPartUploadInfos/init")]
    ITask<PostV10StorageSpacesBySpaceIdFilesMultiPartUploadInfosInitResponse> PostV10StorageSpacesBySpaceIdFilesMultiPartUploadInfosInitAsync(
        [JsonContent] PostV10StorageSpacesBySpaceIdFilesMultiPartUploadInfosInitRequest request,
        [PathQuery] string spaceId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取文件分片上传信息
    /// </summary>
    [HttpPost("/v1.0/storage/spaces/files/multiPartUploadInfos/query")]
    ITask<PostV10StorageSpacesFilesMultiPartUploadInfosQueryResponse> PostV10StorageSpacesFilesMultiPartUploadInfosQueryAsync(
        [JsonContent] PostV10StorageSpacesFilesMultiPartUploadInfosQueryRequest request,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取文件上传信息
    /// </summary>
    [HttpPost("/v2.0/storage/spaces/files/{parentDentryUuid}/uploadInfos/query")]
    ITask<PostV20StorageSpacesFilesByParentDentryUuidUploadInfosQueryResponse> PostV20StorageSpacesFilesByParentDentryUuidUploadInfosQueryAsync(
        [JsonContent] PostV20StorageSpacesFilesByParentDentryUuidUploadInfosQueryRequest request,
        [PathQuery] string parentDentryUuid,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 提交文件
    /// </summary>
    [HttpPost("/v2.0/storage/spaces/files/{parentDentryUuid}/commit")]
    ITask<PostV20StorageSpacesFilesByParentDentryUuidCommitResponse> PostV20StorageSpacesFilesByParentDentryUuidCommitAsync(
        [JsonContent] PostV20StorageSpacesFilesByParentDentryUuidCommitRequest request,
        [PathQuery] string parentDentryUuid,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取文件下载信息
    /// </summary>
    [HttpPost("/v1.0/storage/spaces/{spaceId}/dentries/{dentryId}/downloadInfos/query")]
    ITask<PostV10StorageSpacesBySpaceIdDentriesByDentryIdDownloadInfosQueryResponse> PostV10StorageSpacesBySpaceIdDentriesByDentryIdDownloadInfosQueryAsync(
        [JsonContent] PostV10StorageSpacesBySpaceIdDentriesByDentryIdDownloadInfosQueryRequest request,
        [PathQuery] string spaceId,
        [PathQuery] string dentryId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 修改权限
    /// </summary>
    [HttpPost("/v2.0/storage/spaces/dentries/{dentryUuid}/permissions")]
    ITask<PostV20StorageSpacesDentriesByDentryUuidPermissionsResponse> PostV20StorageSpacesDentriesByDentryUuidPermissionsAsync(
        [JsonContent] PostV20StorageSpacesDentriesByDentryUuidPermissionsRequest request,
        [PathQuery] string dentryUuid,
        string? unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除权限
    /// </summary>
    [HttpPost("/v2.0/storage/spaces/dentries/{dentryUuid}/permissions/remove")]
    ITask<PostV20StorageSpacesDentriesByDentryUuidPermissionsRemoveResponse> PostV20StorageSpacesDentriesByDentryUuidPermissionsRemoveAsync(
        [JsonContent] PostV20StorageSpacesDentriesByDentryUuidPermissionsRemoveRequest request,
        [PathQuery] string dentryUuid,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取权限列表
    /// </summary>
    [HttpPost("/v2.0/storage/spaces/dentries/{dentryUuid}/permissions/query")]
    ITask<PostV20StorageSpacesDentriesByDentryUuidPermissionsQueryResponse> PostV20StorageSpacesDentriesByDentryUuidPermissionsQueryAsync(
        [JsonContent] PostV20StorageSpacesDentriesByDentryUuidPermissionsQueryRequest request,
        [PathQuery] string dentryUuid,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 设置权限继承模式
    /// </summary>
    [HttpPut("/v2.0/storage/spaces/dentries/{dentryUuid}/permissions/inheritances")]
    ITask<UpdateV20StorageSpacesDentriesByDentryUuidPermissionsInheritancesResponse> UpdateV20StorageSpacesDentriesByDentryUuidPermissionsInheritancesAsync(
        [JsonContent] UpdateV20StorageSpacesDentriesByDentryUuidPermissionsInheritancesRequest request,
        [PathQuery] string dentryUuid,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取权限继承模式
    /// </summary>
    [HttpGet("/v2.0/storage/spaces/dentries/{dentryUuid}/permissions/inheritances")]
    ITask<GetV20StorageSpacesDentriesByDentryUuidPermissionsInheritancesResponse> GetV20StorageSpacesDentriesByDentryUuidPermissionsInheritancesAsync(
        [PathQuery] string dentryUuid,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取回收站信息
    /// </summary>
    [HttpGet("/v1.0/storage/recycleBins")]
    ITask<GetV10StorageRecycleBinsResponse> GetV10StorageRecycleBinsAsync(
        string recycleBinScope,
        string scopeId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取回收项列表
    /// </summary>
    [HttpGet("/v1.0/storage/recycleBins/{recycleBinId}/recycleItems")]
    ITask<GetV10StorageRecycleBinsByRecycleBinIdRecycleItemsResponse> GetV10StorageRecycleBinsByRecycleBinIdRecycleItemsAsync(
        [PathQuery] string recycleBinId,
        string? nextToken,
        string? maxResults,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取回收项信息
    /// </summary>
    [HttpGet("/v1.0/storage/recycleBins/{recycleBinId}/recycleItems/{recycleItemId}")]
    ITask<GetV10StorageRecycleBinsByRecycleBinIdRecycleItemsByRecycleItemIdResponse> GetV10StorageRecycleBinsByRecycleBinIdRecycleItemsByRecycleItemIdAsync(
        [PathQuery] string recycleBinId,
        [PathQuery] string recycleItemId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除回收项
    /// </summary>
    [HttpDelete("/v1.0/storage/recycleBins/{recycleBinId}/recycleItems/{recycleItemId}")]
    ITask<DeleteV10StorageRecycleBinsByRecycleBinIdRecycleItemsByRecycleItemIdResponse> DeleteV10StorageRecycleBinsByRecycleBinIdRecycleItemsByRecycleItemIdAsync(
        [PathQuery] string recycleBinId,
        [PathQuery] string recycleItemId,
        string? unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 还原回收项
    /// </summary>
    [HttpPost("/v1.0/storage/recycleBins/{recycleBinId}/recycleItems/{recycleItemId}/restore")]
    ITask<PostV10StorageRecycleBinsByRecycleBinIdRecycleItemsByRecycleItemIdRestoreResponse> PostV10StorageRecycleBinsByRecycleBinIdRecycleItemsByRecycleItemIdRestoreAsync(
        [JsonContent] PostV10StorageRecycleBinsByRecycleBinIdRecycleItemsByRecycleItemIdRestoreRequest request,
        [PathQuery] string recycleBinId,
        [PathQuery] string recycleItemId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量还原回收项
    /// </summary>
    [HttpPost("/v1.0/storage/recycleBins/{recycleBinId}/recycleItems/batchRestore")]
    ITask<PostV10StorageRecycleBinsByRecycleBinIdRecycleItemsBatchRestoreResponse> PostV10StorageRecycleBinsByRecycleBinIdRecycleItemsBatchRestoreAsync(
        [JsonContent] PostV10StorageRecycleBinsByRecycleBinIdRecycleItemsBatchRestoreRequest request,
        [PathQuery] string recycleBinId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量删除回收项
    /// </summary>
    [HttpPost("/v1.0/storage/recycleBins/{recycleBinId}/recycleItems/batchRemove")]
    ITask<PostV10StorageRecycleBinsByRecycleBinIdRecycleItemsBatchRemoveResponse> PostV10StorageRecycleBinsByRecycleBinIdRecycleItemsBatchRemoveAsync(
        [JsonContent] PostV10StorageRecycleBinsByRecycleBinIdRecycleItemsBatchRemoveRequest request,
        [PathQuery] string recycleBinId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 清空回收站
    /// </summary>
    [HttpPost("/v1.0/storage/recycleBins/{recycleBinId}/clear")]
    ITask<PostV10StorageRecycleBinsByRecycleBinIdClearResponse> PostV10StorageRecycleBinsByRecycleBinIdClearAsync(
        [PathQuery] string recycleBinId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取存储中异步任务信息
    /// </summary>
    [HttpGet("/v1.0/storage/tasks/{taskId}")]
    ITask<GetV10StorageTasksByTaskIdResponse> GetV10StorageTasksByTaskIdAsync(
        [PathQuery] string taskId,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 订阅文件变更事件
    /// </summary>
    [HttpPost("/v1.0/storage/events/subscribe")]
    ITask<PostV10StorageEventsSubscribeResponse> PostV10StorageEventsSubscribeAsync(
        [JsonContent] PostV10StorageEventsSubscribeRequest request,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// 取消订阅文件变更事件
    /// </summary>
    [HttpPost("/v1.0/storage/events/unsubscribe")]
    ITask<PostV10StorageEventsUnsubscribeResponse> PostV10StorageEventsUnsubscribeAsync(
        [JsonContent] PostV10StorageEventsUnsubscribeRequest request,
        string unionId,
        [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal,
        CancellationToken cancellationToken = default);

}
