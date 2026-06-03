using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.IndustryOpen;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.IndustryOpen;

/// <summary>
/// 行业开放api
/// </summary>
public interface IIndustryOpenApi : IDingTalkHeaderTokenApi
{
    /// <summary>
    /// 增加或减少居民积分
    /// </summary>
    [HttpPost("/v1.0/resident/points")]
    Task AddResidentPointsAsync(bool isCircle, string uuid, string userId, string ruleCode, string ruleName, string actionTime, string score, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询组织维度配置的所有积分规则
    /// </summary>
    [HttpGet("/v1.0/resident/points/rules")]
    ITask<ResidentPointsRulesGetResponse> ListResidentPointRulesAsync(string isCircle, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 分页查询居民积分流水
    /// </summary>
    [HttpGet("/v1.0/resident/points/records")]
    ITask<ResidentPointsRecordsGetResponse> PageResidentPointRecordsAsync(bool isCircle, string userId, string nextToken, string maxResults, string startTime, string endTime, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建项目组
    /// </summary>
    [HttpPost("/v1.0/industry/campuses/projects/groups")]
    ITask<IndustryCampusesProjectsGroupsPostResponse> CreateCampusProjectGroupAsync([JsonContent] IndustryCampusesProjectsGroupsPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除项目组
    /// </summary>
    [HttpDelete("/v1.0/industry/campuses/projects/groups")]
    ITask<IndustryCampusesProjectsGroupsDeleteResponse> DeleteCampusProjectGroupAsync(string campusProjectGroupId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建园区项目
    /// </summary>
    [HttpPost("/v1.0/industry/campuses/projects")]
    ITask<IndustryCampusesProjectsPostResponse> CreateCampusProjectAsync([JsonContent] IndustryCampusesProjectsPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询项目组信息
    /// </summary>
    [HttpGet("/v1.0/industry/campuses/projects/groupInfos")]
    ITask<IndustryCampusesProjectsGroupInfosGetResponse> GetCampusProjectGroupInfoAsync(string groupId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询园区项目信息
    /// </summary>
    [HttpGet("/v1.0/industry/campuses/projectInfos")]
    ITask<IndustryCampusesProjectInfosGetResponse> GetCampusProjectInfoAsync(string campusDeptId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 保存人员扩展属性
    /// </summary>
    [HttpPost("/v1.0/industry/medicals/users/{userId}/extends")]
    ITask<IndustryMedicalsUsersUserIdExtendsPostResponse> SaveMedicalUserExtendAsync([PathQuery] string userId, string userExtendKey, string userExtendValue, string userDisplayName, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 计件报工
    /// </summary>
    [HttpPost("/v1.0/manufacturing/users/{userId}/jobs")]
    ITask<ManufacturingUsersUserIdJobsPostResponse> ReportManufacturingJobAsync([PathQuery] string userId, [JsonContent] ManufacturingUsersUserIdJobsPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询计件报工数据
    /// </summary>
    [HttpPost("/v1.0/manufacturing/users/jobs/query")]
    ITask<ManufacturingUsersJobsQueryPostResponse> QueryManufacturingJobsAsync([JsonContent] ManufacturingUsersJobsQueryPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 注册设备到钉钉
    /// </summary>
    [HttpPost("/v1.0/devicemng/customers/devices/registerAndActivate")]
    ITask<DeviceManagementCustomersDevicesRegisterAndActivatePostResponse> RegisterAndActivateDeviceAsync([JsonContent] DeviceManagementCustomersDevicesRegisterAndActivatePostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量注册与激活设备
    /// </summary>
    [HttpPost("/v1.0/devicemng/customers/devices/registrationActivations/batch")]
    ITask<DeviceManagementCustomersDevicesRegistrationActivationsBatchPostResponse> BatchRegisterAndActivateDevicesAsync([JsonContent] DeviceManagementCustomersDevicesRegistrationActivationsBatchPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询已经注册的设备信息
    /// </summary>
    [HttpGet("/v1.0/devicemng/customers/devices/activations/infos")]
    ITask<DeviceManagementCustomersDevicesActivationsInfosGetResponse> GetDeviceActivationInfosAsync(string deviceTypeId, long pageNumber, string groupId, long pageSize, string deviceCode, long deviceCategory, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取报修记录
    /// </summary>
    [HttpPost("/v1.0/devicemng/customers/devices/maintainInfos/query")]
    ITask<DeviceManagementCustomersDevicesMaintainInfosQueryPostResponse> QueryDeviceMaintainInfosAsync([JsonContent] DeviceManagementCustomersDevicesMaintainInfosQueryPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取巡检或保养记录
    /// </summary>
    [HttpPost("/v1.0/devicemng/customers/devices/inspectInfos/query")]
    ITask<DeviceManagementCustomersDevicesInspectInfosQueryPostResponse> QueryDeviceInspectInfosAsync([JsonContent] DeviceManagementCustomersDevicesInspectInfosQueryPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 群发任务
    /// </summary>
    [HttpPost("/v1.0/serviceGroup/messages/tasks/send")]
    ITask<ServiceGroupMessagesTasksSendPostResponse> SendServiceGroupMessageTaskAsync([JsonContent] ServiceGroupMessagesTasksSendPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 发送服务群消息
    /// </summary>
    [HttpPost("/v1.0/serviceGroup/messages/send")]
    ITask<ServiceGroupMessagesSendPostResponse> SendServiceGroupMessageAsync([JsonContent] ServiceGroupMessagesSendPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建场景服务群
    /// </summary>
    [HttpPost("/v1.0/serviceGroup/groups")]
    ITask<ServiceGroupGroupsPostResponse> CreateServiceGroupAsync([JsonContent] ServiceGroupGroupsPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 添加服务群成员
    /// </summary>
    [HttpPost("/v1.0/serviceGroup/groups/members")]
    ITask<ServiceGroupGroupsMembersPostResponse> AddServiceGroupMembersAsync([JsonContent] ServiceGroupGroupsMembersPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询服务群活跃用户
    /// </summary>
    [HttpGet("/v1.0/serviceGroup/groups/queryActiveUsers")]
    ITask<ServiceGroupGroupsQueryActiveUsersGetResponse> QueryServiceGroupActiveUsersAsync(string openTeamId, string openConversationId, [JsonContent] ServiceGroupGroupsQueryActiveUsersGetRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更换服务群所在的群分组
    /// </summary>
    [HttpPut("/v1.0/serviceGroup/groups/configurations")]
    ITask<ServiceGroupGroupsConfigurationsPutResponse> UpdateServiceGroupConfigurationAsync([JsonContent] ServiceGroupGroupsConfigurationsPutRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 升级普通群为服务群
    /// </summary>
    [HttpPost("/v1.0/serviceGroup/normalGroups/upgrade")]
    Task UpgradeNormalGroupAsync([JsonContent] ServiceGroupNormalGroupsUpgradePostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 升级云客服服务群为钉钉智能服务群
    /// </summary>
    [HttpPost("/v1.0/serviceGroup/cloudGroups/upgrade")]
    Task UpgradeCloudGroupAsync([JsonContent] ServiceGroupCloudGroupsUpgradePostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建自定义校区或部门
    /// </summary>
    [HttpPost("/v1.0/edu/customDepts")]
    ITask<EduCustomDeptsPostResponse> CreateEduCustomDeptAsync([JsonContent] EduCustomDeptsPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除家校部门
    /// </summary>
    [HttpDelete("/v1.0/edu/depts/{deptId}")]
    ITask<EduDeptsDeptIdDeleteResponse> DeleteEduDeptAsync([PathQuery] string deptId, string @operator, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建自定义部门下的班级
    /// </summary>
    [HttpPost("/v1.0/edu/customClasses")]
    ITask<EduCustomClassesPostResponse> CreateEduCustomClassAsync([JsonContent] EduCustomClassesPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除学生
    /// </summary>
    [HttpDelete("/v1.0/edu/classes/{classId}/students/{userId}")]
    ITask<EduClassesClassIdStudentsUserIdDeleteResponse> DeleteEduStudentAsync([PathQuery] string classId, [PathQuery] string userId, string @operator, [JsonContent] EduClassesClassIdStudentsUserIdDeleteRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除家长关系
    /// </summary>
    [HttpDelete("/v1.0/edu/classes/{classId}/guardians/{userId}")]
    ITask<EduClassesClassIdGuardiansUserIdDeleteResponse> DeleteEduGuardianRelationAsync([PathQuery] string classId, [PathQuery] string userId, string stuId, string @operator, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除老师
    /// </summary>
    [HttpDelete("/v1.0/edu/classes/{classId}/teachers/{userId}")]
    ITask<EduClassesClassIdTeachersUserIdDeleteResponse> DeleteEduTeacherAsync([PathQuery] string classId, [PathQuery] string userId, string adviser, string @operator, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 学生调班
    /// </summary>
    [HttpPost("/v1.0/edu/students/move")]
    ITask<EduStudentsMovePostResponse> MoveEduStudentAsync([JsonContent] EduStudentsMovePostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取用户所在的行业角色信息
    /// </summary>
    [HttpGet("/v1.0/resident/users/industryRoles")]
    ITask<ResidentUsersIndustryRolesGetResponse> ListResidentUserIndustryRolesAsync(string userId, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取行业角色下的用户列表
    /// </summary>
    [HttpGet("/v1.0/resident/industryRoles/users")]
    ITask<ResidentIndustryRolesUsersGetResponse> ListResidentIndustryRoleUsersAsync(string tagCode, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
