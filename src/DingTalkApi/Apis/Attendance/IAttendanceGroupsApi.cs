using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.Attendance;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.Attendance;

/// <summary>
/// 考勤组api
/// </summary>
public interface IAttendanceGroupsApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 创建考勤组
    /// </summary>
    [HttpPost("/topapi/attendance/group/add")]
    ITask<DingTalkResult<AttendanceGroupAddResult>> AttendanceGroupAddAsync([JsonContent] AttendanceGroupAddRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新考勤组
    /// </summary>
    [HttpPost("/topapi/attendance/group/modify")]
    ITask<DingTalkResult<AttendanceGroupModifyResult>> AttendanceGroupModifyAsync([JsonContent] AttendanceGroupModifyRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除考勤组
    /// </summary>
    [HttpPost("/topapi/attendance/group/delete")]
    ITask<AttendanceGroupDeleteResponse> AttendanceGroupDeleteAsync([JsonContent] AttendanceGroupDeleteRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 搜索考勤组摘要
    /// </summary>
    [HttpPost("/topapi/attendance/group/search")]
    ITask<DingTalkResult<AttendanceGroupSearchResult>> AttendanceGroupSearchAsync([JsonContent] AttendanceGroupSearchRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取考勤组详情
    /// </summary>
    [HttpPost("/topapi/attendance/group/query")]
    ITask<DingTalkResult<AttendanceGroupQueryResult>> AttendanceGroupQueryAsync([JsonContent] AttendanceGroupQueryRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 根据groupkey查询考勤组信息
    /// </summary>
    [HttpPost("/topapi/attendance/group/get")]
    ITask<DingTalkResult<AttendanceGroupGetResult>> AttendanceGroupGetAsync([JsonContent] AttendanceGroupGetRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// groupKey转换为groupId
    /// </summary>
    [HttpPost("/topapi/attendance/groups/keytoid")]
    ITask<AttendanceGroupsKeyToIdResponse> AttendanceGroupsKeyToIdAsync([JsonContent] AttendanceGroupsKeyToIdRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// groupId转换为groupKey
    /// </summary>
    [HttpPost("/topapi/attendance/groups/idtokey")]
    ITask<AttendanceGroupsIdToKeyResponse> AttendanceGroupsIdToKeyAsync([JsonContent] AttendanceGroupsIdToKeyRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量获取考勤组摘要
    /// </summary>
    [HttpPost("/topapi/attendance/group/minimalism/list")]
    ITask<DingTalkResult<AttendanceGroupMinimalismListResult>> AttendanceGroupMinimalismListAsync([JsonContent] AttendanceGroupMinimalismListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量获取考勤组详情
    /// </summary>
    [HttpPost("/topapi/attendance/getsimplegroups")]
    ITask<DingTalkResult<AttendanceGetSimpleGroupsResult>> AttendanceGetSimpleGroupsAsync([JsonContent] AttendanceGetSimpleGroupsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取用户考勤组
    /// </summary>
    [HttpPost("/topapi/attendance/getusergroup")]
    ITask<DingTalkResult<AttendanceGetUserGroupResult>> AttendanceGetUserGroupAsync([JsonContent] AttendanceGetUserGroupRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量新增参与考勤人员
    /// </summary>
    [HttpPost("/topapi/attendance/group/users/add")]
    ITask<DingTalkResult<AttendanceGroupUsersAddResult>> AttendanceGroupUsersAddAsync([JsonContent] AttendanceGroupUsersAddRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新参与考勤人员
    /// </summary>
    [HttpPost("/topapi/attendance/group/member/update")]
    ITask<DingTalkResult> AttendanceGroupMemberUpdateAsync([JsonContent] AttendanceGroupMemberUpdateRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取参与考勤人员
    /// </summary>
    [HttpPost("/topapi/attendance/group/member/list")]
    ITask<DingTalkResult<AttendanceGroupMemberListResult>> AttendanceGroupMemberListAsync([JsonContent] AttendanceGroupMemberListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取考勤组员工的userid
    /// </summary>
    [HttpPost("/topapi/attendance/group/memberusers/list")]
    ITask<DingTalkResult<AttendanceGroupMemberusersListResult>> AttendanceGroupMemberusersListAsync([JsonContent] AttendanceGroupMemberusersListRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量删除考勤组成员
    /// </summary>
    [HttpPost("/topapi/attendance/group/users/remove")]
    ITask<DingTalkResult<AttendanceGroupUsersRemoveResult>> AttendanceGroupUsersRemoveAsync([JsonContent] AttendanceGroupUsersRemoveRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 查询考勤组员工
    /// </summary>
    [HttpPost("/topapi/attendance/group/users/query")]
    ITask<AttendanceGroupUsersQueryResponse> AttendanceGroupUsersQueryAsync([JsonContent] AttendanceGroupUsersQueryRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 考勤组成员校验
    /// </summary>
    [HttpPost("/topapi/attendance/group/member/listbyids")]
    ITask<DingTalkResult<AttendanceGroupMemberListByIdsResult>> AttendanceGroupMemberListByIdsAsync([JsonContent] AttendanceGroupMemberListByIdsRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量新增wifi信息
    /// </summary>
    [HttpPost("/topapi/attendance/group/wifis/add")]
    ITask<DingTalkResult<AttendanceGroupWifisAddResult>> AttendanceGroupWifisAddAsync([JsonContent] AttendanceGroupWifisAddRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量移除wifi
    /// </summary>
    [HttpPost("/topapi/attendance/group/wifis/remove")]
    ITask<DingTalkResult<AttendanceGroupWifisRemoveResult>> AttendanceGroupWifisRemoveAsync([JsonContent] AttendanceGroupWifisRemoveRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量查询wifi
    /// </summary>
    [HttpPost("/topapi/attendance/group/wifis/query")]
    ITask<DingTalkResult<AttendanceGroupWifisQueryResult>> AttendanceGroupWifisQueryAsync([JsonContent] AttendanceGroupWifisQueryRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量新增地点
    /// </summary>
    [HttpPost("/topapi/attendance/group/positions/add")]
    ITask<DingTalkResult<AttendanceGroupPositionsAddResult>> AttendanceGroupPositionsAddAsync([JsonContent] AttendanceGroupPositionsAddRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量删除地点
    /// </summary>
    [HttpPost("/topapi/attendance/group/positions/remove")]
    ITask<DingTalkResult<AttendanceGroupPositionsRemoveResult>> AttendanceGroupPositionsRemoveAsync([JsonContent] AttendanceGroupPositionsRemoveRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量查询地点
    /// </summary>
    [HttpPost("/topapi/attendance/group/positions/query")]
    ITask<DingTalkResult<AttendanceGroupPositionsQueryResult>> AttendanceGroupPositionsQueryAsync([JsonContent] AttendanceGroupPositionsQueryRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 排班制考勤组排班
    /// </summary>
    [HttpPost("/topapi/attendance/group/schedule/async")]
    ITask<DingTalkResult> AttendanceGroupScheduleAsyncAsync([JsonContent] AttendanceGroupScheduleAsyncRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
