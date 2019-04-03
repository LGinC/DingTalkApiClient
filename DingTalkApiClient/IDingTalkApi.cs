using DingTalkApiClient.Dto;
using WebApiClient;
using WebApiClient.Attributes;

namespace DingTalkApiClient
{
    /// <summary>
    /// 钉钉企业内部应用开发API
    /// </summary>
    [HttpHost("https://oapi.dingtalk.com")]
    public interface IDingTalkApi : IHttpApi
    {
        /// <summary>
        /// 获取访问令牌
        /// </summary>
        /// <param name="corpid">企业Id</param>
        /// <param name="corpsecret">企业密钥</param>
        /// <returns></returns>
        [HttpGet("/gettoken")]
        ITask<AccessToken> GetAccessToken(string corpid, string corpsecret);
        /// <summary>
        /// 发送图文到钉钉
        /// </summary>
        /// <param name="access_token">访问令牌</param>
        /// <param name="input">图文信息</param>
        /// <returns></returns>
        [HttpPost("/message/send")]
        ITask<string> SendMessage(string access_token, [JsonContent] DingTalkSenderInfo input);
        /// <summary>
        /// 获取部门详情
        /// </summary>
        /// <param name="access_token">访问令牌</param>
        /// <param name="id">部门Id</param>
        /// <returns></returns>
        [HttpGet("/department/get")]
        ITask<DingTalkDepartmentDetail> GetDepartmentDetails(string access_token, string id);
        /// <summary>
        /// 获取部门列表
        /// </summary>
        /// <param name="access_token">访问令牌</param>
        /// <param name="id">上级部门Id  为空则全部</param>
        /// <returns></returns>
        [HttpGet("/department/list")]
        ITask<OrgListDtoInDD> GetDepartments(string access_token, string id);
        ///// <summary>
        ///// 获取部门成员
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="department_id">部门Id</param>
        ///// <returns></returns>
        //[HttpGet("https://oapi.dingtalk.com/user/simplelist")]
        //ITask<DingTalkUserList> GetUserSimpleList(string access_token, string department_id);
        ///// <summary>
        ///// 获取用户详情
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="userid">用户id</param>
        ///// <returns></returns>
        //[HttpGet("https://oapi.dingtalk.com/user/get")]
        //ITask<DingTalkUserDetail> GetUserDetail(string access_token, string userid);

        ///// <summary>
        ///// 获取企业角色信息
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="input">其他参数</param>
        ///// <returns></returns>
        //[HttpPost("https://oapi.dingtalk.com/topapi/role/list")]
        //ITask<DingTalkRoleResult> GetRoles(string access_token, [JsonContent]GetRolesInput input);

        ///// <summary>
        ///// 获取角色详情
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="roleId">角色Id</param>
        ///// <returns></returns>
        //[HttpPost("https://oapi.dingtalk.com/topapi/role/getrole")]
        //ITask<DingTalkRoleDetailResult> GetRoleById(string access_token, [FormContent]long roleId);

        ///// <summary>
        ///// 创建部门
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="input">部门信息</param>
        ///// <returns></returns>
        //[HttpPost("https://oapi.dingtalk.com/department/create")]
        //ITask<DingTalkCreateResult> CreateDepartment(string access_token, [JsonContent]CreateDepartmentInput input);
        ///// <summary>
        ///// 更新部门
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="input">部门信息</param>
        ///// <returns></returns>
        //[HttpPost("https://oapi.dingtalk.com/department/update")]
        //ITask<DingTalkCreateResult> UpdateDepartment(string access_token, [JsonContent]UpdateDepartmentInput input);
        ///// <summary>
        ///// 删除部门  (注：不能删除根部门；不能删除含有子部门、成员的部门)
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="id">部门id</param>
        ///// <returns></returns>
        //[HttpGet("https://oapi.dingtalk.com/department/delete")]
        //ITask<BaseResponse> DeleteDepartment(string access_token, long id);
        ///// <summary>
        ///// 获取钉钉上某个企业/组织内的人数
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="onlyActive">0：包含未激活钉钉的人员数量 
        ///// <para>1：不包含未激活钉钉的人员数量</para></param>
        ///// <returns></returns>
        //[HttpGet("https://oapi.dingtalk.com/user/get_org_user_count")]
        //ITask<OrgUserCount> GetOrgUserCount(string access_token, int onlyActive = 0);
        ///// <summary>
        ///// 创建用户
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="input">用户信息</param>
        ///// <returns></returns>
        //[HttpPost("https://oapi.dingtalk.com/user/create")]
        //ITask<CreateUserResult> CreateUser(string access_token, [JsonContent]DingTalkCreateUserInput input);
        ///// <summary>
        ///// 更新用户信息
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="input">用户信息</param>
        ///// <returns></returns>
        //[HttpPost("https://oapi.dingtalk.com/user/update")]
        //ITask<BaseResponse> UpdateUser(string access_token, [JsonContent]DingTalkUpdateUserInput input);
        ///// <summary>
        ///// 批量删除用户
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="userids">员工唯一标识ID列表</param>
        ///// <returns></returns>
        //[HttpPost("https://oapi.dingtalk.com/user/batchdelete")]
        //ITask<BaseResponse> BatchDeleteUser(string access_token, [JsonContent]UserIdList userids);

        ///// <summary>
        ///// 删除用户
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="userid">员工唯一标识ID（不可修改）</param>
        ///// <returns></returns>
        //[HttpGet("https://oapi.dingtalk.com/user/delete")]
        //ITask<BaseResponse> DeleteUser(string access_token, string userid);
        /////// <summary>
        /////// 根据code获取用户ID
        /////// </summary>
        /////// <param name="code">code</param>
        /////// <param name="access_token">访问令牌</param>
        /////// <returns>用户Id</returns>
        ////[HttpGet("https://oapi.dingtalk.com/user/getuserinfo")]
        ////ITask<DingTalkUserId> GetUserIdByCode(string code, string access_token);
        /////// <summary>
        /////// 根据用户ID获取用户详细信息
        /////// </summary>
        /////// <param name="AccessToken">访问令牌</param>
        /////// <param name="UserId">用户Id</param>
        /////// <returns></returns>
        ////[HttpGet("https://oapi.dingtalk.com/user/get")]
        ////ITask<DingTalkUserInfo> GetUserMsgByUserId(string access_token, string userid);


        //#region 考勤
        ///// <summary>
        ///// 获取打卡详情
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="input">其他参数</param>
        ///// <returns></returns>
        //[HttpPost("https://oapi.dingtalk.com/attendance/listRecord")]
        //ITask<DingTalkPunchRecordResult> GetPunchRecords(string access_token, [JsonContent] GetPunchRecordsInput input);

        ///// <summary>
        ///// 获取打卡结果
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="input">获取请求</param>
        ///// <returns></returns>
        //[HttpPost("https://oapi.dingtalk.com/attendance/list")]
        //ITask<GetDingTalkAttendanceResult> GetAttendanceResult(string access_token, [JsonContent]GetAttendanceInput input);

        ///// <summary>
        ///// 获取请假时长 
        ///// <para>可以自动根据排班规则统计出每个员工的请假时长，进而与企业自有的请假／财务系统对接，进行工资统计，如果您的企业使用了钉钉考勤并希望依赖考勤系统自动计算员工请假时长</para>
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="input"></param>
        ///// <returns></returns>
        //[HttpPost("https://oapi.dingtalk.com/topapi/attendance/getleaveapproveduration")]
        //ITask<GetLeaveApproveDurationResult> GetLeaveApproveDurationResult(string access_token, [JsonContent]GetLeaveApproveDurationInput input);

        ///// <summary>
        ///// 查询指定企业下的指定用户在指定时间段内的请假状态
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="input"></param>
        ///// <returns></returns>
        //ITask<DingTalkLeaveStatusResult> GetLeaveStatus(string access_token, [JsonContent]GetLeaveStatusInput input);

        ///// <summary>
        ///// 企业考勤排班详情 查询某天的考勤排班全量信息
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="input">指定日期</param>
        ///// <returns></returns>
        //[HttpPost("https://oapi.dingtalk.com/topapi/attendance/getleaveapproveduration")]
        //ITask<GetDingTalkScheduleResult> GetScheduleByDate(string access_token, [JsonContent]GetDingTalkScheduleInput input);

        ///// <summary>
        ///// 企业考勤组详情 查询所有的考勤组详情信息
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="input">分页信息</param>
        ///// <returns></returns>
        //[HttpPost("https://oapi.dingtalk.com/topapi/attendance/getsimplegroups")]
        //ITask<GetDingTalkScheduleGroupResult> GetScheduleGroup(string access_token, [JsonContent]GetDingTalkScheduleGroupInput input);

        ///// <summary>
        ///// 获取用户考勤组  考勤组是一类具有相同的班次、考勤位置等考勤规则的人或部门的组合，一个企业中的一个人只能属于一个考勤组
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="userid">用户Id</param>
        ///// <returns></returns>
        //[HttpPost("https://oapi.dingtalk.com/topapi/attendance/getsimplegroups")]
        //ITask<DingTalkUserScheduleGroup> GetUserScheduleGroup(string access_token, [JsonContent]string userid);
        ///// <summary>
        ///// 获取用户签到记录
        ///// </summary>
        ///// <param name="input">请求细节</param>
        ///// <returns></returns>
        //[HttpGet("https://oapi.dingtalk.com/topapi/checkin/record/get")]
        //ITask<GetDingTalkUserCheckInResult> GetUserCheckin(GetDingTalkUserCheckInInput input);

        ///// <summary>
        ///// 获取部门用户签到记录 
        ///// </summary>
        ///// <param name="input">请求细节</param>
        ///// <returns></returns>
        //[HttpGet("https://oapi.dingtalk.com/checkin/record")]
        //ITask<GetDingTalkCheckInResult> GetCheckIn(GetDingTalkCheckIn input);
        //#endregion
        //#region 回调注册
        ///// <summary>
        ///// 注册业务事件回调接口
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="input">参数列表</param>
        ///// <returns></returns>
        //[HttpPost("https://oapi.dingtalk.com/call_back/register_call_back")]
        //ITask<BaseResponse> RegisterCallbback(string access_token, [JsonContent]RegisterDingTalkCallBackInput input);
        ///// <summary>
        ///// 查询已注册事件回调接口
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <returns></returns>
        //[HttpGet("https://oapi.dingtalk.com/call_back/get_call_back")]
        //ITask<DingTalkRegisteredCallBack> GetCallbback(string access_token);

        ///// <summary>
        ///// 更新已注册业务事件回调接口
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="input">参数列表</param>
        ///// <returns></returns>
        //[HttpPost("https://oapi.dingtalk.com/call_back/update_call_back")]
        //ITask<BaseResponse> UpdateRegisteredCallback(string access_token, [JsonContent]RegisterDingTalkCallBackInput input);

        ///// <summary>
        ///// 删除所有已注册事件回调接口
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <returns></returns>
        //[HttpGet("https://oapi.dingtalk.com/call_back/delete_call_back")]
        //ITask<BaseResponse> DeleteRegisteredCallback(string access_token);

        ///// <summary>
        ///// 获取回调失败的结果
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <returns></returns>
        //[HttpGet("https://oapi.dingtalk.com/call_back/get_call_back_failed_result")]
        //ITask<DingTalkCallbackFailedResult> GetCallbackFailed(string access_token);
        //#endregion

        //#region 审批流程
        ///// <summary>
        ///// 获取单个审批实例 详情包括审批表单信息、操作记录列表、操作人、抄送人、审批任务列表
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="process_instance_id">实例Id</param>
        ///// <returns></returns>
        //[HttpPost("https://oapi.dingtalk.com/topapi/processinstance/get")]
        //ITask<DingTalkProcessInstanceMsg> GetProcessInstance(string access_token, [FormContent]string process_instance_id);

        ///// <summary>
        ///// 批量获取审批实例id 
        ///// </summary>
        ///// <param name="access_token">访问令牌</param>
        ///// <param name="input">参数</param>
        ///// <returns></returns>
        //[HttpPost("https://oapi.dingtalk.com/topapi/processinstance/listids")]
        //ITask<DingTalkProcessInstanceList> GetProcessInstanceList(string access_token, [JsonContent]GetProcessInstanceListInput input);
        //#endregion
    }
}
