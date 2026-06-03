using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.ExclusiveOpen;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.ExclusiveOpen;

/// <summary>
/// 专属开放api
/// </summary>
public interface IExclusiveOpenApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 获取审计协议签署人员信息
    /// </summary>
    [HttpGet("/v1.0/exclusive/audits/users")]
    ITask<AuditUsersGetResponse> GetAuditUsersAsync(string pageNumber, string signStatus, string pageSize, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量新增可信设备
    /// </summary>
    [HttpPost("/v1.0/exclusive/trustedDevices/batchAdd")]
    ITask<TrustedDevicesBatchAddResponse> TrustedDevicesBatchAddAsync([JsonContent] TrustedDevicesBatchAddRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询公共设备
    /// </summary>
    [HttpGet("/v1.0/exclusive/trusts/publicDevices")]
    ITask<TrustsPublicDevicesGetResponse> QueryPublicDevicesAsync(string? platform, string? startTime, string? endTime, string? pageSize, string? pageNumber, string? title, string? macAddress, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 新增可信设备信息
    /// </summary>
    [HttpPost("/v1.0/exclusive/trustedDevices")]
    ITask<TrustedDevicesResponse> TrustedDevicesAsync([JsonContent] TrustedDevicesRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询可信设备详细信息
    /// </summary>
    [HttpPost("/v1.0/exclusive/trustedDevices/query")]
    ITask<TrustedDevicesQueryResponse> TrustedDevicesQueryAsync([JsonContent] TrustedDevicesQueryRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取可打标部门列表
    /// </summary>
    [HttpGet("/v1.0/exclusive/partnerDepartments")]
    ITask<PartnerDepartmentsGetResponse> GetPartnerDepartmentsAsync([DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 设置部门伙伴类型和伙伴编码
    /// </summary>
    [HttpPost("/v1.0/exclusive/partnerDepartments")]
    ITask<DingTalkResult> PartnerDepartmentsAsync([JsonContent] PartnerDepartmentsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取子标签列表
    /// </summary>
    [HttpGet("/v1.0/exclusive/partnerLabels/{parentId}")]
    ITask<PartnerLabelsParentIdGetResponse> GetPartnerLabelsAsync([PathQuery] string parentId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 修改伙伴类型可见性
    /// </summary>
    [HttpPut("/v1.0/exclusive/partnerDepartments/visibilityPartners")]
    ITask<PartnerDepartmentsVisibilityPartnersPutResponse> UpdatePartnerDepartmentVisibilityPartnersAsync([JsonContent] PartnerDepartmentsVisibilityPartnersPutRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询伙伴角色列表
    /// </summary>
    [HttpGet("/v1.0/exclusive/partnerRoles/{parentId}")]
    ITask<PartnerRolesParentIdGetResponse> GetPartnerRolesAsync([PathQuery] string parentId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 修改角色可见性
    /// </summary>
    [HttpPut("/v1.0/exclusive/partnerDepartments/visibilityRoles")]
    ITask<PartnerDepartmentsVisibilityRolesPutResponse> UpdatePartnerDepartmentVisibilityRolesAsync([JsonContent] PartnerDepartmentsVisibilityRolesPutRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 发送邀请函
    /// </summary>
    [HttpPost("/v1.0/exclusive/partnerDepartments/invitations/send")]
    ITask<DingTalkResult> PartnerDepartmentsInvitationsSendAsync([JsonContent] PartnerDepartmentsInvitationsSendRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 根据userId查询人员的标签信息
    /// </summary>
    [HttpGet("/v1.0/exclusive/partners/users/{userId}")]
    ITask<PartnersUsersUserIdGetResponse> GetPartnerUserLabelsAsync([PathQuery] string userId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// DING服务
    /// </summary>
    [HttpPost("/v1.0/exclusive/appDings/send")]
    ITask<DingTalkResult> AppDingsSendAsync([JsonContent] AppDingsSendRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 发送电话DING
    /// </summary>
    [HttpPost("/v1.0/exclusive/phoneDings/send")]
    ITask<PhoneDingsSendResponse> PhoneDingsSendAsync([JsonContent] PhoneDingsSendRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取文件操作记录
    /// </summary>
    [HttpGet("/v1.0/exclusive/fileAuditLogs")]
    ITask<FileAuditLogsGetResponse> GetFileAuditLogsAsync(string startDate, string endDate, string pageSize, string? nextGmtCreate, string? nextBizId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 发送文件更改的评论
    /// </summary>
    [HttpPost("/v1.0/exclusive/comments/send")]
    ITask<DingTalkResult> CommentsSendAsync([JsonContent] CommentsSendRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取群活跃明细列表
    /// </summary>
    [HttpGet("/v1.0/exclusive/data/activeGroups")]
    ITask<DataActiveGroupsGetResponse> GetActiveGroupDetailsAsync(string statDate, string? dingGroupId, string pageNumber, string pageSize, string? groupType, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询企业内部群信息
    /// </summary>
    [HttpGet("/v1.0/exclusive/securities/orgGroupInfos")]
    ITask<SecuritiesOrgGroupInfosGetResponse> QuerySecuritiesOrgGroupInfosAsync(string? groupMembersCountEnd, string? syncToDingpan, string? groupOwner, string? createTimeEnd, string pageSize, string? createTimeStart, string uuid, string? groupMembersCountStart, string operatorUserId, string? groupName, string pageStart, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 企业内部群禁言或解除禁言
    /// </summary>
    [HttpPut("/v1.0/exclusive/enterpriseSecurities/banOrOpenGroupWords")]
    ITask<EnterpriseSecuritiesBanOrOpenGroupWordsPutResponse> UpdateEnterpriseSecuritiesGroupWordsAsync([JsonContent] EnterpriseSecuritiesBanOrOpenGroupWordsPutRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 根据会议逻辑ID查询会议基本信息
    /// </summary>
    [HttpGet("/v1.0/exclusive/data/conferences")]
    ITask<DataConferencesGetResponse> GetConferenceInfoAsync(string logicalConferenceId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取防截屏操作记录
    /// </summary>
    [HttpPost("/v1.0/exclusive/enterpriseSecurities/userBehaviors/screenshots/query")]
    ITask<EnterpriseSecuritiesUserBehaviorsScreenshotsQueryResponse> EnterpriseSecuritiesUserBehaviorsScreenshotsQueryAsync([JsonContent] EnterpriseSecuritiesUserBehaviorsScreenshotsQueryRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询实人认证状态
    /// </summary>
    [HttpPost("/v1.0/exclusive/persons/identificationStates/query")]
    ITask<PersonsIdentificationStatesQueryResponse> PersonsIdentificationStatesQueryAsync([JsonContent] PersonsIdentificationStatesQueryRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询人脸录入状态
    /// </summary>
    [HttpPost("/v1.0/exclusive/faces/recognizeStates/query")]
    ITask<FacesRecognizeStatesQueryResponse> FacesRecognizeStatesQueryAsync([JsonContent] FacesRecognizeStatesQueryRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取实人认证接口调用记录
    /// </summary>
    [HttpPost("/v1.0/exclusive/persons/identificationRecords/query")]
    ITask<PersonsIdentificationRecordsQueryResponse> PersonsIdentificationRecordsQueryAsync([JsonContent] PersonsIdentificationRecordsQueryRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取人脸对比接口调用记录
    /// </summary>
    [HttpPost("/v1.0/exclusive/faces/recognizeRecords/query")]
    ITask<FacesRecognizeRecordsQueryResponse> FacesRecognizeRecordsQueryAsync([JsonContent] FacesRecognizeRecordsQueryRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
