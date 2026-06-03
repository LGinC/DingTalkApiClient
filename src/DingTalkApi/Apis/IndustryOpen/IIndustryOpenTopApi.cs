using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.IndustryOpen;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Apis.IndustryOpen;

/// <summary>
/// 行业开放 topapi
/// </summary>
public interface IIndustryOpenTopApi : IDingTalkQueryTokenApi
{
    /// <summary>
    /// 初始化家校架构
    /// </summary>
    [HttpPost("/topapi/edu/school/init")]
    ITask<EduSchoolInitPostResponse> InitEduSchoolAsync([JsonContent] EduSchoolInitPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建学段
    /// </summary>
    [HttpPost("/topapi/edu/period/create")]
    ITask<EduPeriodCreatePostResponse> CreateEduPeriodAsync([JsonContent] EduPeriodCreatePostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建年级
    /// </summary>
    [HttpPost("/topapi/edu/grade/create")]
    ITask<EduGradeCreatePostResponse> CreateEduGradeAsync([JsonContent] EduGradeCreatePostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 创建班级
    /// </summary>
    [HttpPost("/topapi/edu/class/create")]
    ITask<EduClassCreatePostResponse> CreateEduClassAsync([JsonContent] EduClassCreatePostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 添加学生
    /// </summary>
    [HttpPost("/topapi/edu/student/create")]
    ITask<EduStudentCreatePostResponse> CreateEduStudentAsync([JsonContent] EduStudentCreatePostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 添加家长
    /// </summary>
    [HttpPost("/topapi/edu/guardian/create")]
    ITask<EduGuardianCreatePostResponse> CreateEduGuardianAsync([JsonContent] EduGuardianCreatePostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 添加老师
    /// </summary>
    [HttpPost("/topapi/edu/teacher/create")]
    ITask<EduTeacherCreatePostResponse> CreateEduTeacherAsync([JsonContent] EduTeacherCreatePostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取部门详情
    /// </summary>
    [HttpPost("/topapi/edu/dept/get")]
    ITask<EduDeptGetPostResponse> GetEduDeptAsync([JsonContent] EduDeptGetPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取部门列表
    /// </summary>
    [HttpPost("/topapi/edu/dept/list")]
    ITask<EduDeptListPostResponse> ListEduDeptsAsync([JsonContent] EduDeptListPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取人员列表
    /// </summary>
    [HttpPost("/topapi/edu/user/list")]
    ITask<EduUserListPostResponse> ListEduUsersAsync([JsonContent] EduUserListPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取人员详情
    /// </summary>
    [HttpPost("/topapi/edu/user/get")]
    ITask<EduUserGetPostResponse> GetEduUserAsync([JsonContent] EduUserGetPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取班级内学生的关系列表
    /// </summary>
    [HttpPost("/topapi/edu/user/relation/list")]
    ITask<EduUserRelationListPostResponse> ListEduUserRelationsAsync([JsonContent] EduUserRelationListPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取学生监护人详情
    /// </summary>
    [HttpPost("/topapi/edu/user/relation/get")]
    ITask<EduUserRelationGetPostResponse> GetEduUserRelationAsync([JsonContent] EduUserRelationGetPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取班级圈话题列表
    /// </summary>
    [HttpPost("/topapi/edu/circle/topiclist")]
    ITask<EduCircleTopiclistPostResponse> ListEduCircleTopicsAsync([JsonContent] EduCircleTopiclistPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取班级圈动态列表
    /// </summary>
    [HttpPost("/topapi/edu/circle/post/list")]
    ITask<EduCirclePostListPostResponse> ListEduCirclePostsAsync([JsonContent] EduCirclePostListPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取数字化证书
    /// </summary>
    [HttpPost("/topapi/edu/cert/get")]
    ITask<EduCertGetPostResponse> GetEduCertAsync([JsonContent] EduCertGetPostRequest request, [DingTalkTokenProvider] string tokenProviderName = ProviderNames.Internal, CancellationToken cancellationToken = default);
}
