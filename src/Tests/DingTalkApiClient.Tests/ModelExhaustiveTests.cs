using System;
using System.Collections.Generic;
using DingTalkApiClient.Models;
using DingTalkApiClient.Models.ApplicationManagement;
using DingTalkApiClient.Models.IM.Robot;
using DingTalkApiClient.Models.IM.CorpConversation;
using DingTalkApiClient.Models.IM.Chat;
using DingTalkApiClient.Models.IM.Interconnections;
using DingTalkApiClient.Models.IM.InteractiveCards;
using DingTalkApiClient.Models.Card.CardInstances;
using DingTalkApiClient.Models.Contacts.UserManage;
using DingTalkApiClient.Models.AudioAndVideo.Live;
using DingTalkApiClient.Models.AudioAndVideo.MeetingRooms;
using DingTalkApiClient.Models.AudioAndVideo.VideoConferences;
using DingTalkApiClient.Models.Badge;
using DingTalkApiClient.Models.Blackboard;
using DingTalkApiClient.Models.Calendar;
using DingTalkApiClient.Models.Checkin;
using DingTalkApiClient.Models.CRM;
using DingTalkApiClient.Models.EventSubscription;
using DingTalkApiClient.Models.HRM;
using DingTalkApiClient.Models.OrgCulture;
using DingTalkApiClient.Models.Report;
using DingTalkApiClient.Models.ServiceWindow;
using DingTalkApiClient.Models.SmartDevice;
using DingTalkApiClient.Models.SmartFill;
using DingTalkApiClient.Models.Todo;
using DingTalkApiClient.Models.Workbench;
using DingTalkApiClient.Models.Workflow;
using DingTalkApiClient.Models.Yida;
using DingTalkApiClient.Enums;
using Xunit;

namespace DingTalkApiClient.Tests;

/// <summary>
/// 穷举测试所有 Model 的属性，以提高覆盖率并验证 AOT 兼容性
/// </summary>
public class ModelExhaustiveTests
{
    [Fact]
    public void ExhaustiveModelPropertyAssignmentTest()
    {
        var result = new DingTalkResult { ErrCode = 0, Code = "Success" };
        Assert.True(result.IsSuccess);
        result.ErrCode = 1;
        result.Code = "Failure";
        Assert.False(result.IsSuccess);
        result.RequestId = "req01";
        result.ErrMsg = "err";
        
        // Robot Models
        var robotText = new CustomRobotMessageRequest.TextObj { Content = "test" };
        Assert.Equal("test", robotText.Content);

        var robotAt = new CustomRobotMessageRequest.AtObj
        {
            AtUserIds = ["u1"],
            AtMobiles = ["138"],
            IsAtAll = true
        };
        Assert.True(robotAt.IsAtAll);

        var robotActionCard = new CustomRobotMessageRequest.ActionCardObj
        {
            Title = "t",
            Text = "text",
            BtnOrientation = "1",
            SingleTitle = "st",
            SingleUrl = "su",
            Btns = [new() { Title = "b", ActionUrl = "u" }]
        };

        var robotFeedCard = new CustomRobotMessageRequest.FeedCardObj
        {
            Links = [new() { Title = "t", MessageUrl = "m", PicUrl = "p" }]
        };

        var customRobotReq = CustomRobotMessageRequest.Create(RobotMsgType.Text, robotText);
        customRobotReq.At = robotAt;

        // Calendar Models
        var calendarAcl = new CalendarAcl
        {
            AclId = "acl-01",
            Privilege = "reader",
            Scope = new CalendarAclScope { ScopeType = "user", UserId = "union-01" }
        };
        Assert.Equal("union-01", calendarAcl.Scope.UserId);

        var calendarEvent = new CalendarEvent
        {
            Id = "event-01",
            Summary = "项目评审",
            Description = "评审会议",
            Start = new CalendarEventTime { DateTime = "2026-06-03T09:00:00+08:00", TimeZone = "Asia/Shanghai" },
            End = new CalendarEventTime { DateTime = "2026-06-03T10:00:00+08:00", TimeZone = "Asia/Shanghai" },
            IsAllDay = false,
            Recurrence = new CalendarRecurrence
            {
                Pattern = new CalendarRecurrencePattern { Type = "daily", Interval = 1 },
                Range = new CalendarRecurrenceRange { Type = "numbered", NumberOfOccurrences = 2 }
            },
            Attendees = [new CalendarAttendee { Id = "union-02", DisplayName = "李四", ResponseStatus = "accepted" }],
            Organizer = new CalendarAttendee { Id = "union-01", Self = true },
            Location = new CalendarLocation { DisplayName = "会议室A" },
            Reminders = [new CalendarReminder { Method = "popup", Minutes = 15 }],
            MeetingRooms = [new CalendarMeetingRoom { RoomId = "room-01", RoomName = "会议室A" }],
            Extra = new CalendarExtra { Name = "source", Value = "crm" },
            ETag = "etag-01"
        };
        Assert.Equal("event-01", calendarEvent.Id);

        var calendarRequest = new CalendarEventRequest
        {
            Summary = "项目评审",
            Start = calendarEvent.Start,
            End = calendarEvent.End,
            Attendees = [new CalendarAttendee { Id = "union-02" }]
        };
        Assert.Equal("项目评审", calendarRequest.Summary);

        var subscribedCalendar = new SubscribedCalendar
        {
            CalendarId = "sub-01",
            Name = "公开课",
            Author = "union-01",
            Managers = ["union-03"],
            SubscribeScope = new CalendarSubscribeScope { UnionIds = ["union-02"], OpenConversationIds = [], CorpIds = [] }
        };
        Assert.Equal("sub-01", subscribedCalendar.CalendarId);

        var roomSchedule = new QueryMeetingRoomScheduleResponse
        {
            ScheduleInformation =
            [
                new()
                {
                    RoomId = "room-01",
                    ScheduleItems = [new MeetingRoomScheduleItem { EventId = "event-01", Status = "BUSY" }]
                }
            ]
        };
        Assert.Equal("BUSY", roomSchedule.ScheduleInformation[0].ScheduleItems[0].Status);

        // CorpConversation Models
        var corpText = new CorpConversationMsgRequest.TextObj { Content = "test" };
        var corpImage = new CorpConversationMsgRequest.ImageObj { MediaId = "m" };
        var corpVoice = new CorpConversationMsgRequest.VoiceObj { MediaId = "v", Duration = "10" };
        var corpFile = new CorpConversationMsgRequest.FileObj { MediaId = "f" };
        var corpLink = new CorpConversationMsgRequest.LinkObj { Title = "t", Text = "txt", MessageUrl = "m", PicUrl = "p" };
        var corpMarkdown = new CorpConversationMsgRequest.CorpConversationMarkdownObj { Title = "t", Text = "m" };
        
        var oaHead = new CorpConversationMsgRequest.OAHead { BgColor = "c", Text = "t" };
        var oaBody = new CorpConversationMsgRequest.OABody
        {
            Title = "t",
            Content = "c",
            Image = "i",
            FileCount = "1",
            Author = "a"
        };
        oaBody.Form = [new() { Key = "k", Value = "v" }];
        oaBody.Rich = new CorpConversationMsgRequest.OARich { Num = "1", Unit = "u" };
        
        var corpOA = new CorpConversationMsgRequest.OAObj
        {
            MessageUrl = "m",
            PcMessageUrl = "pm",
            Head = oaHead,
            Body = oaBody
        };

        var corpActionCard = new CorpConversationMsgRequest.ActionCardObj
        {
            Title = "t",
            Markdown = "m",
            SingleTitle = "st",
            SingleUrl = "su",
            BtnOrientation = "1",
            BtnJsonList = [new() { Title = "b", ActionUrl = "u" }]
        };

        // UserManage Models
        var mobileReq = new MobileRequest("138");
        Assert.Equal("138", mobileReq.Mobile);

        // Checkin Models
        var checkinRequest = new GetUserCheckinRecordsRequest
        {
            UseridList = "manager4220",
            StartTime = 1605437194000,
            EndTime = 1605786394000,
            Cursor = 0,
            Size = 100
        };
        var userCheckinResponse = new GetUserCheckinRecordsResponse
        {
            ErrCode = 0,
            RequestId = "req01",
            Result = new CheckinRecordsResult
            {
                NextCursor = 20,
                PageList =
                [
                    new UserCheckinRecord
                    {
                        CheckinTime = 1599544940000,
                        DetailPlace = "浙江省杭州市余杭区五常街道",
                        ImageList = ["https://static.dingtalk.com/media/xxxx"],
                        Place = "绿城未来park",
                        Remark = "客户拜访",
                        Userid = "manager4220",
                        Longitude = "120.017394",
                        Latitude = "30.286053",
                        VisitUser = "客户A"
                    }
                ]
            }
        };
        var departmentCheckinResponse = new GetDepartmentCheckinRecordsResponse
        {
            ErrCode = 0,
            ErrMsg = "ok",
            Data =
            [
                new DepartmentCheckinRecord
                {
                    Name = "杨xx",
                    UserId = "manager4220",
                    Avatar = "https://example.com/avatar.png",
                    Timestamp = 1599544940000,
                    Place = "绿城未来park",
                    DetailPlace = "浙江省杭州市余杭区五常街道",
                    Remark = "客户拜访",
                    ImageList = ["https://static.dingtalk.com/media/xxxx"],
                    Latitude = "30.286053",
                    Longitude = "120.017394"
                }
            ]
        };
        Assert.Equal("manager4220", checkinRequest.UseridList);
        Assert.Equal("客户A", userCheckinResponse.Result.PageList[0].VisitUser);
        Assert.Equal("manager4220", departmentCheckinResponse.Data[0].UserId);

        // Badge Models
        var badgeTime = new BadgeAvailableTime { GmtStart = "2026-06-03 09:00:00", GmtEnd = "2026-06-03 18:00:00" };
        var createBadge = new CreateBadgeCodeUserInstanceRequest
        {
            RequestId = "request01",
            CodeIdentity = "DT_VISITOR",
            CodeValue = "value01",
            Status = "OPEN",
            CorpId = "dingcorp",
            UserCorpRelationType = "INTERNAL_STAFF",
            UserIdentity = "user01",
            GmtExpired = "2026-06-10 18:00:00",
            AvailableTimes = [badgeTime],
            ExtInfo = new Dictionary<string, object?> { ["scene"] = "visitor" },
            CodeValueType = "DING_STATIC"
        };
        var updateBadge = new UpdateBadgeCodeUserInstanceRequest
        {
            CodeId = "code01",
            CodeIdentity = "DT_VISITOR",
            CodeValue = "value02",
            Status = "OPEN",
            CorpId = "dingcorp",
            UserCorpRelationType = "INTERNAL_STAFF",
            UserIdentity = "user01",
            GmtExpired = "2026-06-10 18:00:00",
            AvailableTimes = [badgeTime],
            ExtInfo = []
        };
        var badgeFund = new BadgeFundToolDetail { FundToolName = "余额", Amount = "9.00", GmtCreate = "2026-06-03 09:00:00", GmtFinish = "2026-06-03 09:01:00", PromotionFundTool = false, ExtInfo = "{}" };
        var badgePayChannel = new BadgePayChannelDetail
        {
            PayChannelName = "支付宝",
            GmtCreate = "2026-06-03 09:00:00",
            GmtFinish = "2026-06-03 09:01:00",
            PayChannelType = "ALIPAY",
            Amount = "10.00",
            PayChannelOrderNo = "channel01",
            PayChannelRefundOrderNo = "refund-channel01",
            PromotionAmount = "1.00",
            FundToolDetailList = [badgeFund]
        };
        var badgePay = new NotifyBadgeCodePayResultRequest
        {
            PayCode = "pay01",
            CorpId = "dingcorp",
            UserId = "user01",
            GmtTradeCreate = "2026-06-03 09:00:00",
            GmtTradeFinish = "2026-06-03 09:01:00",
            TradeNo = "trade01",
            TradeStatus = "SUCCESS",
            Title = "午餐",
            Remark = "食堂消费",
            Amount = "10.00",
            PromotionAmount = "1.00",
            ChargeAmount = "9.00",
            PayChannelDetailList = [badgePayChannel],
            TradeErrorCode = "",
            TradeErrorMsg = "",
            ExtInfo = "{}",
            MerchantName = "食堂"
        };
        var badgeRefund = new NotifyBadgeCodeRefundResultRequest
        {
            CorpId = "dingcorp",
            UserId = "user01",
            TradeNo = "trade01",
            RefundOrderNo = "refund01",
            Remark = "退款",
            RefundAmount = "5.00",
            RefundPromotionAmount = "0.50",
            GmtRefund = "2026-06-03 10:00:00",
            PayChannelDetailList = [badgePayChannel],
            PayCode = "pay01"
        };
        Assert.Equal("request01", createBadge.RequestId);
        Assert.Equal("code01", updateBadge.CodeId);
        Assert.Equal("https://example.com/code01", new CreateBadgeCodeUserInstanceResponse { CodeId = "code01", CodeDetailUrl = "https://example.com/code01" }.CodeDetailUrl);
        Assert.Equal("code01", new UpdateBadgeCodeUserInstanceResponse { CodeId = "code01" }.CodeId);
        Assert.Equal("OPEN", new SaveBadgeCodeCorpInstanceRequest { CodeIdentity = "DT_IDENTITY", CorpId = "dingcorp", Status = "OPEN" }.Status);
        Assert.Equal("dingcorp", new SaveBadgeCodeCorpInstanceResponse { CodeIdentity = "DT_IDENTITY", CorpId = "dingcorp", Status = "OPEN", ExtInfo = new Dictionary<string, object?> { ["key"] = "value" } }.CorpId);
        Assert.Equal("pay01", new DecodeBadgeCodeRequest { PayCode = "pay01", RequestId = "request01" }.PayCode);
        Assert.Equal("code01", new DecodeBadgeCodeResponse { CorpId = "dingcorp", UserId = "user01", CodeType = "PURE_IDENTIFY_CODE", AlipayCode = "2512345678", UserCorpRelationType = "INTERNAL_STAFF", CodeIdentity = "DT_VISITOR", CodeId = "code01", OutBizId = "request01", ExtInfo = "{}" }.CodeId);
        Assert.Equal("余额", badgePay.PayChannelDetailList[0].FundToolDetailList[0].FundToolName);
        Assert.Equal("refund01", badgeRefund.RefundOrderNo);
        Assert.True(new BadgeBooleanResultResponse { Result = true }.Result);
        Assert.Equal("SUCCESS", new BadgeStringResultResponse { Result = "SUCCESS" }.Result);
        Assert.Equal("msg01", new CreateBadgeNotifyRequest { UserId = "user01", MsgId = "msg01", MsgType = "DING_BADGE_NOTIFY", Content = "{}" }.MsgId);
        Assert.True(new NotifyBadgeCodeVerifyResultRequest { PayCode = "pay01", CorpId = "dingcorp", UserCorpRelationType = "INTERNAL_STAFF", UserIdentity = "user01", VerifyTime = "2026-06-03 09:00:00", VerifyResult = true, VerifyLocation = "门禁A" }.VerifyResult);

        // CRM Models
        var crmMeta = new CrmObjectMetaResponse
        {
            Name = "crm_customer",
            Customized = false,
            Status = "PUBLISHED",
            Code = "PROC-1",
            Fields =
            [
                new()
                {
                    Name = "customer_name",
                    Customized = false,
                    Label = "客户名称",
                    Type = "Text",
                    Nillable = false,
                    SelectOptions = [new() { Key = "a", Value = "A" }],
                    ReferenceFields = [new() { Name = "crm_contact", Label = "联系人", Type = "Text" }],
                    RollUpSummaryFields = [new() { Name = "Money", Aggregator = "SUM" }]
                }
            ]
        };
        Assert.Equal("customer_name", crmMeta.Fields[0].Name);

        var crmCreate = new CrmPersonalCustomerCreateRequest
        {
            CreatorUserId = "u1",
            CreatorNick = "张三",
            RelationType = "crm_customer",
            Permission = new CrmPermission { OwnerStaffIds = ["u1"], ParticipantStaffIds = ["u2"] },
            Data = { ["customer_name"] = "抱壹" }
        };
        Assert.Equal("抱壹", crmCreate.Data["customer_name"]);

        var crmUpdate = new CrmPersonalCustomerUpdateRequest
        {
            InstanceId = "inst01",
            ModifierUserId = "u2",
            ModifierNick = "李四"
        };
        Assert.Equal("inst01", crmUpdate.InstanceId);

        var crmBatch = new CrmBatchCreateRelationDatasRequest
        {
            RelationType = "crm_customer",
            OperatorUserId = "u1",
            RelationList =
            [
                new()
                {
                    BizDataList = [new() { Key = "customer_name", Value = "抱壹", ExtendValue = "ext" }],
                    BizExtMap = { ["key"] = "value" },
                    RelationPermissionDTO = new CrmRelationPermission { PrincipalUserIds = ["u1"], ParticipantUserIds = ["u2"] }
                }
            ]
        };
        Assert.Single(crmBatch.RelationList[0].BizDataList);

        var crmGroupSet = new CrmGroupSetDetail
        {
            Name = "重点客户",
            OpenGroupSetId = "set01",
            ManagerUserIds = ["u2"],
            Owner = new CrmGroupSetUser { UserId = "u1", UserName = "张三" },
            Manager = [new() { UserId = "u2", UserName = "李四" }]
        };
        Assert.Equal("张三", crmGroupSet.Owner.UserName);

        var crmTop = new CrmTopCustomObjectRequest
        {
            Instance = new CrmTopCustomObjectInstance
            {
                Name = "custom_object",
                DataId = "data01",
                CurrentOperatorUserid = "u1",
                Data = { ["field"] = "value" }
            }
        };
        Assert.Equal("custom_object", crmTop.Instance.Name);

        // HRM Models
        var hrmPositionQuery = new HrmPositionQueryRequest
        {
            PositionName = "工程师",
            InCategoryIds = ["cat01"],
            InPositionIds = ["pos01"],
            DeptId = 1
        };
        Assert.Equal("工程师", hrmPositionQuery.PositionName);

        var hrmPositionList = new HrmPositionListResponse
        {
            NextToken = 1,
            HasMore = true,
            List = [new HrmPositionInfo { PositionId = "pos01", PositionName = "工程师", RankIdList = ["rank01"], Status = 0 }]
        };
        Assert.Equal("pos01", hrmPositionList.List[0].PositionId);

        var hrmRankList = new HrmJobRankListResponse
        {
            HasMore = false,
            List = [new HrmJobRankInfo { RankId = "rank01", RankName = "P6", MinJobGrade = 1, MaxJobGrade = 2 }]
        };
        Assert.Equal("P6", hrmRankList.List[0].RankName);

        var hrmJobList = new HrmJobListResponse
        {
            HasMore = false,
            List = [new HrmJobInfo { JobId = "job01", JobName = "研发", JobDescription = "开发岗位" }]
        };
        Assert.Equal("研发", hrmJobList.List[0].JobName);

        var hrmOptionUpdate = new HrmRosterMetaFieldOptionsUpdateRequest
        {
            GroupId = "sys05",
            FieldCode = "sys05-contractType",
            Labels = ["固定期限劳动合同"],
            ModifyType = "OPTIONS_ADD"
        };
        Assert.Single(hrmOptionUpdate.Labels);

        var hrmPreentry = new HrmPreentryCreateRequest
        {
            Name = "张三",
            Mobile = "13800138000",
            Groups =
            [
                new HrmPreentryGroup
                {
                    GroupId = "sys00",
                    Sections =
                    [
                        new HrmPreentrySection
                        {
                            EmpFieldVOList = [new HrmPreentryField { FieldCode = "sys00-name", Value = "张三" }]
                        }
                    ]
                }
            ]
        };
        Assert.Equal("sys00-name", hrmPreentry.Groups[0].Sections[0].EmpFieldVOList[0].FieldCode);

        var hrmCreateResponse = new HrmPreentryCreateResponse { TmpUserId = "tmp01" };
        Assert.Equal("tmp01", hrmCreateResponse.TmpUserId);

        var hrmDismissionList = new HrmDismissionEmployeeListResponse
        {
            NextToken = 2,
            HasMore = false,
            UserIdList = ["u1"]
        };
        Assert.Equal("u1", hrmDismissionList.UserIdList[0]);

        var hrmTermination = new HrmTerminatedEmployeeUpdateRequest
        {
            UserId = "u1",
            DismissionMemo = "备注",
            LastWorkDate = "1700000000000"
        };
        Assert.Equal("备注", hrmTermination.DismissionMemo);

        var hrmDimissionInfos = new HrmDimissionInfoListResponse
        {
            Result =
            [
                new HrmDimissionInfo
                {
                    UserId = "u1",
                    LastWorkDay = 1700000000000,
                    DeptList = [new HrmDimissionDepartment { DeptId = 1, DeptPath = "总部/研发" }],
                    ReasonMemo = "个人原因",
                    PreStatus = 3,
                    HandoverUserId = "u2",
                    Status = 2,
                    MainDeptName = "研发",
                    MainDeptId = 1,
                    VoluntaryReason = ["个人原因"],
                    PassiveReason = []
                }
            ]
        };
        Assert.Equal("总部/研发", hrmDimissionInfos.Result[0].DeptList[0].DeptPath);

        var hrmTransfer = new HrmEmployeeTransferRequest
        {
            UserId = "u1",
            DeptIdsAfterTransfer = ["1"],
            PositionNameAfterTransfer = "工程师",
            PositionLevelAfterTransfer = "pos01",
            JobIdAfterTransfer = "job01",
            PositionIdAfterTransfer = "rankName",
            RankIdAfterTransfer = "rank01",
            OperateUserId = "op1"
        };
        Assert.Equal("op1", hrmTransfer.OperateUserId);

        var hrmRegular = new HrmBecomeRegularRequest
        {
            UserId = "u1",
            RegularDate = "1700000000000",
            Remark = "转正",
            OperationId = "op1"
        };
        Assert.Equal("转正", hrmRegular.Remark);

        var hrmRosterMeta = new HrmRosterMetaResponse
        {
            ErrCode = 0,
            Success = true,
            Result =
            [
                new HrmRosterMetaGroup
                {
                    GroupName = "个人信息",
                    GroupId = "sys00",
                    Detail = false,
                    FieldMetaInfoList = [new HrmRosterMetaField { FieldName = "姓名", FieldCode = "sys00-name", Derived = false }]
                }
            ]
        };
        Assert.Equal("个人信息", hrmRosterMeta.Result[0].GroupName);

        var hrmRosterGroups = new HrmRosterFieldGroupResponse
        {
            Success = true,
            Result =
            [
                new HrmRosterFieldGroup
                {
                    GroupId = "sys00",
                    HasDetail = false,
                    FieldList = [new HrmRosterField { FieldType = "DDTextField", FieldName = "姓名", FieldCode = "sys00-name" }]
                }
            ]
        };
        Assert.Equal("DDTextField", hrmRosterGroups.Result[0].FieldList[0].FieldType);

        var hrmRosterFieldRequest = new HrmEmployeeRosterFieldListRequest
        {
            UseridList = "u1",
            FieldFilterList = "sys00-name",
            Agentid = 1
        };
        Assert.Equal("u1", hrmRosterFieldRequest.UseridList);

        var hrmRosterFieldResponse = new HrmEmployeeRosterFieldListResponse
        {
            ErrCode = 0,
            Success = true,
            Result =
            [
                new HrmEmployeeRosterFieldInfo
                {
                    CorpId = "corp01",
                    Userid = "u1",
                    FieldDataList =
                    [
                        new HrmEmployeeRosterFieldData
                        {
                            FieldName = "姓名",
                            FieldCode = "sys00-name",
                            GroupId = "sys00",
                            FieldValueList = [new HrmEmployeeRosterFieldValue { ItemIndex = 0, Label = "张三", Value = "张三" }]
                        }
                    ]
                }
            ]
        };
        Assert.Equal("张三", hrmRosterFieldResponse.Result[0].FieldDataList[0].FieldValueList[0].Value);

        var hrmRosterUpdate = new HrmEmployeeRosterUpdateRequest
        {
            Agentid = 1,
            Param = new HrmEmployeeRosterUpdateParam
            {
                Userid = "u1",
                Groups =
                [
                    new HrmEmployeeRosterUpdateGroup
                    {
                        GroupId = "sys03",
                        Sections =
                        [
                            new HrmEmployeeRosterUpdateSection
                            {
                                OldIndex = 0,
                                Section = [new HrmEmployeeRosterUpdateField { FieldCode = "sys03-school", Value = "测试大学" }]
                            }
                        ]
                    }
                ]
            }
        };
        Assert.Equal("sys03-school", hrmRosterUpdate.Param.Groups[0].Sections[0].Section[0].FieldCode);

        var hrmBool = new HrmBooleanResultResponse { Result = true };
        var hrmTopBool = new HrmTopBooleanResponse { ErrCode = 0, Result = true, Success = true };
        Assert.True(hrmBool.Result);
        Assert.True(hrmTopBool.Result);

        var hrmAgent = new HrmAgentRequest { Agentid = 1 };
        Assert.Equal(1, hrmAgent.Agentid);

        var hrmPreentryPage = new HrmPreentryListResponse
        {
            ErrCode = 0,
            Success = true,
            Result = new HrmUserIdPage { NextCursor = 1, DataList = ["u1"] }
        };
        Assert.Equal("u1", hrmPreentryPage.Result.DataList[0]);

        var hrmOnJobRequest = new HrmOnJobEmployeeListRequest { StatusList = "2,3", Offset = 0, Size = 20 };
        var hrmOnJobResponse = new HrmOnJobEmployeeListResponse
        {
            Success = true,
            Result = new HrmOnJobEmployeePage { DataList = "u1,u2", NextCursor = 20 }
        };
        Assert.Equal("2,3", hrmOnJobRequest.StatusList);
        Assert.Equal("u1,u2", hrmOnJobResponse.Result.DataList);

        var hrmTopPreentry = new HrmTopPreentryCreateRequest
        {
            Param = new HrmTopPreentryCreateParam
            {
                PreEntryTime = "2026-06-03",
                Name = "李四",
                Mobile = "13900139000",
                ExtendInfo = "{}",
                OpUserid = "op1"
            }
        };
        var hrmTopPreentryResponse = new HrmTopPreentryCreateResponse { ErrCode = 0, Success = true, Userid = "u3" };
        Assert.Equal("李四", hrmTopPreentry.Param.Name);
        Assert.Equal("u3", hrmTopPreentryResponse.Userid);

        // Yida Models
        var yidaStart = new YidaStartProcessInstanceRequest
        {
            AppType = "APP-001",
            SystemToken = "sys-token",
            UserId = "user01",
            Language = "zh_CN",
            FormUuid = "FORM-001",
            FormDataJson = "{}",
            ProcessCode = "PROC-001",
            DepartmentId = "1"
        };
        Assert.Equal("APP-001", yidaStart.AppType);

        var yidaPage = new YidaFormInstancePageResponse
        {
            CurrentPage = 1,
            TotalCount = 1,
            Data =
            [
                new()
                {
                    FormInstanceId = "FINST-001",
                    Title = "表单标题",
                    Originator = new YidaUserInfo
                    {
                        UserId = "user01",
                        UserName = new YidaUserName { NameInChinese = "张三" }
                    },
                    FormData = { ["TextField"] = "hello" }
                }
            ]
        };
        Assert.Equal("hello", yidaPage.Data[0].FormData["TextField"]);

        var yidaTask = new YidaTaskInfo
        {
            ProcessInstanceId = "PROCINST-001",
            ActionerName = ["张三"],
            Actioner = [new() { UserId = "user01", Name = "张三", IsSystemAdmin = false }],
            DataMap = { ["amount"] = 100 },
            CurrentActivityInstances = [new() { ActivityName = "审批" }]
        };
        Assert.Equal("PROCINST-001", yidaTask.ProcessInstanceId);

        var yidaAppResponse = new YidaApplicationsResponse
        {
            PageNumber = 1,
            TotalCount = 1,
            Data = [new() { AppType = "APP-001", Name = "宜搭应用", ApplicationStatus = "ONLINE" }]
        };
        Assert.Equal("宜搭应用", yidaAppResponse.Data[0].Name);

        var yidaLogs = new YidaOperationLogsResponse
        {
            OperationLogMap = new()
            {
                ["FINST-001"] =
                [
                    new()
                    {
                        ComponentName = "文本",
                        OperationType = "UPDATE",
                        Operator = new YidaOperationLogOperator { DisplayName = "张三" }
                    }
                ]
            }
        };
        Assert.Equal("张三", yidaLogs.OperationLogMap["FINST-001"][0].Operator!.DisplayName);
        
        var userInfoReq = new GetUserInfoRequest("u1");
        Assert.Equal("u1", userInfoReq.Userid);

        var userInfo = new UserInfo
        {
            Userid = "u1", Name = "n1", Avatar = "a1", Mobile = "m1",
            Active = true, Admin = true, Boss = true, DeptIdList = [1],
            DeptOrderList = [new() { DeptId = 1, Order = 1 }],
            LeaderInDept = [new() { DeptId = 1, Leader = true }],
            Unionid = "un1", ExclusiveAccount = true
        };
        userInfo.ExtAttrs = [new() { Name = "n", Code = "v", Value = new() { Text = "t" } }];

        // Test Record Types generated methods (to improve coverage of generated code)
        var atToken = new UserAccessTokenResult("token", "refresh", 100, "crop1");
        var atToken2 = new UserAccessTokenResult("token", "refresh", 100, "crop1");
        Assert.Equal(atToken, atToken2);
        Assert.Equal(atToken.GetHashCode(), atToken2.GetHashCode());

        var jsApi = new JsApiTicketResult("tk", 100);
        var jsApi2 = new JsApiTicketResult("tk", 100);
        Assert.Equal(jsApi, jsApi2);

        var unionReq = new UnionIdRequest("phone");
        var unionReq2 = new UnionIdRequest("phone");
        Assert.Equal(unionReq, unionReq2);

        var asyncRes = new AsyncSendCorpConversationV2Response { TaskId = 123 };
        var progRes = new GetSendProgressCorpConversationResponse { Progress = new GetSendProgressCorpConversationResponse.ProgressObj { ProgressInPercent = 100 } };
        var sendRes = new GetSendResultCorpConversationResponse { SendResult = new GetSendResultCorpConversationResponse.SendResultObj { InvalidUserIdList = ["a"] } };
        var templateRes = new SendByTemplateCorpConversationResponse { TaskId = 123 };
        var mobileRes = new MobileResponse(["1"], "u1");
        
        Assert.NotNull(asyncRes);
        Assert.NotNull(progRes.Progress);
        Assert.NotEmpty(sendRes.SendResult.InvalidUserIdList);
        Assert.Equal(123, templateRes.TaskId);
        Assert.Equal("u1", mobileRes.Userid);
        
        // CustomRobotMessageRequest factory branch coverage (use already-declared objects)
        var robotTextReq = CustomRobotMessageRequest.Create(RobotMsgType.Text, robotText);
        var robotLinkReq = CustomRobotMessageRequest.Create(RobotMsgType.Link, new CustomRobotMessageRequest.LinkObj { Title = "t", Text = "x", MessageUrl = "http://a.com", PicUrl = "http://p.com" });
        var robotMdReq   = CustomRobotMessageRequest.Create(RobotMsgType.Markdown, new CustomRobotMessageRequest.CustomRobotMarkdownObj { Title = "t", Text = "x" });
        var robotAcReq   = CustomRobotMessageRequest.Create(RobotMsgType.ActionCard, robotActionCard);
        var robotFcReq   = CustomRobotMessageRequest.Create(RobotMsgType.FeedCard, robotFeedCard);
        Assert.NotNull(robotTextReq);
        Assert.NotNull(robotLinkReq);
        Assert.NotNull(robotMdReq);
        Assert.NotNull(robotAcReq);
        Assert.NotNull(robotFcReq);

        // CorpConversationMsgRequest factory branch coverage (use already-declared objects)
        var corpTextReq  = CorpConversationMsgRequest.Create(CorpConversationMsgType.Text,       corpText);
        var corpImageReq = CorpConversationMsgRequest.Create(CorpConversationMsgType.Image,      corpImage);
        var corpVoiceReq = CorpConversationMsgRequest.Create(CorpConversationMsgType.Voice,      corpVoice);
        var corpFileReq  = CorpConversationMsgRequest.Create(CorpConversationMsgType.File,       corpFile);
        var corpLinkReq  = CorpConversationMsgRequest.Create(CorpConversationMsgType.Link,       corpLink);
        var corpOaReq    = CorpConversationMsgRequest.Create(CorpConversationMsgType.OA,         corpOA);
        var corpMdReq    = CorpConversationMsgRequest.Create(CorpConversationMsgType.Markdown,   corpMarkdown);
        var corpAcReq    = CorpConversationMsgRequest.Create(CorpConversationMsgType.ActionCard, corpActionCard);
        Assert.NotNull(corpTextReq);
        Assert.NotNull(corpImageReq);
        Assert.NotNull(corpVoiceReq);
        Assert.NotNull(corpFileReq);
        Assert.NotNull(corpLinkReq);
        Assert.NotNull(corpOaReq);
        Assert.NotNull(corpMdReq);
        Assert.NotNull(corpAcReq);

        // VideoConferences Models
        var createMeeting = new CreateVideoConferencesRequest(
            UserId: "u1",
            ConfTitle: "t",
            InviteUserIds: ["u1"]
        );
        
        var cloudRecord = new CloudRecordRequest(UnionId: "u1", Mode: "m");

        var videoConf = new ConferenceInfo
        {
            ConferenceId = "c1", Title = "t", Status = ConferenceStatus.Started, MediaStatus = MediaStatus.Normal
        };

        var videoInfo = new VideoInfo
        {
            RecordId = "r1", UnionId = "u1", StartTime = 1, EndTime = 2,
            Duration = 1, FileSize = 1, MediaId = "m1", RegionId = "reg1",
            RecordType = RecordType.Normal
        };

        var getTextRes = new GetTextResult { HasMore = true };
        getTextRes.ParagraphList.Add(new Paragraph
        {
             NickName = "n", UnionId = "u", StartTime = 1, EndTime = 2,
             ParagraphText = "p", NextTtoken = 1, Status = 1, RecordId = 1
        });
        getTextRes.ParagraphList[0].SentenceList.Add(new Sentence
        {
             UnionId = "u", SentenceText = "s", StartTime = 1, EndTime = 2
        });
        getTextRes.ParagraphList[0].SentenceList[0].WordList.Add(new Word
        {
             WordId = "w", WordText = "w", StartTime = 1, EndTime = 2
        });
        // UserInfo all properties coverage
        var userInfo2 = new UserInfo
        {
            Unionid = "uu1", Userid = "u2", Name = "Test",
            ExclusiveAccountType = "dingtalk", Extension = "{}",
            Boss = true, ExclusiveAccount = false, ManagerUserid = "m1",
            Admin = true, Remark = "r", HiredDate = 1000L, Title = "Eng",
            DisableStatus = false, WorkPlace = "BJ",
            RealAuthed = true, Nickname = "Nick", JobNumber = "001",
            Email = "a@b.com", LoginId = "lid", ExclusiveAccountCorpName = "cn",
            CreateTime = DateTimeOffset.Now, Mobile = "13800138000",
            Active = true, Telephone = "010-1234", Avatar = "http://av.com",
            HideMobile = false, ExclusiveAccountCorpId = "cid", Senior = false,
            StateCode = "+86"
        };
        userInfo2.ExtAttrs.Add(new ExtAttr { Name = "n", Code = "c", Value = new ExtAttrValue { Text = "t" } });
        userInfo2.DeptOrderList.Add(new DeptOrder { DeptId = 1, Order = 1 });
        userInfo2.LeaderInDept.Add(new LeaderInDept { DeptId = 1, Leader = true });
        userInfo2.DeptIdList.Add(1L);
        Assert.Equal("Test", userInfo2.Name);

        // VideoPlayResult coverage
        var playResult = new VideoPlayResult { Mp4FileUrl = "http://v.com/1.mp4", PlayUrl = "http://v.com", Duration = 100, Size = 200, Status = 1 };
        Assert.Equal("http://v.com/1.mp4", playResult.Mp4FileUrl);

        // CreateVideoConferencesResult coverage (includes all required fields)
        var createResult = new CreateVideoConferencesResult { ConferenceId = "c1", RoomCode = "rc1", ConferencePassword = "pwd", HostPassword = "hp" };
        Assert.Equal("c1", createResult.ConferenceId);

        var conferenceMember = new ConferenceMember { UnionId = "u1", ConferenceId = "c1", UserNick = "n1", DeviceType = "Win" };
        var membersResult = new ConferenceMembersResult { TotalCount = 1, MemberModels = [conferenceMember] };
        var streamRequest = new StartConferenceStreamOutRequest
        {
            UnionId = "u1",
            StreamUrlList = ["rtmp://demo"],
            StreamName = "stream",
            Mode = "grid",
            SmallWindowPosition = "float_right",
            NeedHostJoin = true
        };
        var streamResult = new StartConferenceStreamOutResult { SuccessStreamMap = new Dictionary<string, string> { ["rtmp://demo"] = "live01" } };
        var scheduleResult = new ScheduleConferenceHistoryResult
        {
            ConferenceList = [new ScheduleConferenceHistory { ConferenceId = "c1", Title = "t", RoomCode = "1001" }]
        };
        Assert.Equal("u1", membersResult.MemberModels[0].UnionId);
        Assert.Equal("live01", streamResult.SuccessStreamMap["rtmp://demo"]);
        Assert.Equal("c1", scheduleResult.ConferenceList[0].ConferenceId);

        var liveCreate = new LiveCreateRequest { UnionId = "u1", Title = "live" };
        var liveInfo = new LiveInfoResponse { Result = new LiveInfo { LiveId = "live01", Title = "live" } };
        var liveWatchUsers = new LiveWatchUsersResponse
        {
            Result = new LiveWatchUsersResult { TotalCount = 1, List = [new LiveWatchUser { UnionId = "u1", Nick = "n1", WatchTime = 60 }] }
        };
        Assert.Equal("live", liveCreate.Title);
        Assert.Equal("live01", liveInfo.Result.LiveId);
        Assert.Single(liveWatchUsers.Result.List);

        var meetingRoomRequest = new MeetingRoomRequest
        {
            UnionId = "u1",
            RoomName = "room",
            RoomLocation = new MeetingRoomLocation { Title = "杭州", Desc = "西溪" }
        };
        var meetingRoomInfo = new MeetingRoomInfo
        {
            RoomId = "room01",
            RoomName = "room",
            RoomLabels = [new MeetingRoomLabel { LabelId = 1, LabelName = "大" }],
            RoomGroup = new MeetingRoomGroupInfo { GroupId = 1, GroupName = "默认", ParentId = 0 }
        };
        var device = new MeetingRoomDevice { DeviceId = "dev01", Controllers = [new MeetingRoomDevice { DeviceId = "ctrl01" }] };
        var screenTemplate = new ScreenTemplateInfo
        {
            DeviceCustomTemplate = new DeviceCustomTemplate { TemplateId = 1001, TemplateName = "tpl" },
            DeviceUnionIds = ["du01"],
            GroupIds = [1],
            RoomIds = ["room01"]
        };
        Assert.Equal("杭州", meetingRoomRequest.RoomLocation.Title);
        Assert.Equal("默认", meetingRoomInfo.RoomGroup.GroupName);
        Assert.Equal("ctrl01", device.Controllers[0].DeviceId);
        Assert.Equal(1001, screenTemplate.DeviceCustomTemplate.TemplateId);

        // SendOToMessageBatchResponse coverage
        var batchResp = new SendOToMessageBatchResponse { ProcessQueryKey = "pqk", InvalidStaffIdList = ["s1"] };
        Assert.Equal("pqk", batchResp.ProcessQueryKey);

        // GetUserAccessTokenRequest coverage
        var userTokenReq = new GetUserAccessTokenRequest
        {
            ClientId = "id", ClientSecret = "sec",
            Code = "c", RefreshToken = "rt", GrantType = "authorization_code"
        };
        Assert.Equal("id", userTokenReq.ClientId);

        var chatCreateReq = new CreateChatRequest { Name = "群", Owner = "u1", Useridlist = ["u1"] };
        var chatCreateRes = new CreateChatResponse { ChatId = "chat01", OpenConversationId = "cid01", ConversationTag = 2 };
        var chatInfo = new ChatInfo { ChatId = "chat01", OpenConversationId = "cid01", Name = "群", Owner = "u1", UserIdList = ["u1"] };
        var groupNickReq = new UpdateGroupNickRequest { ChatId = "chat01", UserId = "u1", GroupNick = "nick" };
        var sceneCreateReq = new CreateSceneGroupRequest { Title = "群", TemplateId = "tpl", OwnerUserId = "u1", UserIds = ["u1"] };
        var sceneInfo = new SceneGroupInfo { OpenConversationId = "cid01", Title = "群", TemplateId = "tpl", OwnerUserId = "u1", UserIds = ["u1"] };
        var memberReq = new SceneGroupMemberRequest { OpenConversationId = "cid01", UserIds = ["u1"] };
        var sceneMessageReq = new SendSceneGroupMessageRequest
        {
            RobotCode = "robot",
            TargetOpenConversationId = "cid01",
            MessageTemplateId = "tpl",
            MessageParamMap = new Dictionary<string, string> { ["k"] = "v" }
        };
        var querySceneRes = new QuerySceneGroupResponse { Success = true, OpenConversationId = "cid01", Title = "群" };
        var muteRes = new GetMuteSettingsResponse { GroupMuteMode = 1, UserMuteResult = [new() { UserId = "u1", MuteStatus = 1 }] };
        Assert.Equal("群", chatCreateReq.Name);
        Assert.Equal("chat01", chatCreateRes.ChatId);
        Assert.Equal("u1", Assert.Single(chatInfo.UserIdList));
        Assert.Equal("nick", groupNickReq.GroupNick);
        Assert.Equal("tpl", sceneCreateReq.TemplateId);
        Assert.Equal("cid01", sceneInfo.OpenConversationId);
        Assert.Equal("u1", Assert.Single(memberReq.UserIds));
        Assert.Equal("v", sceneMessageReq.MessageParamMap["k"]);
        Assert.True(querySceneRes.Success);
        Assert.Equal("u1", Assert.Single(muteRes.UserMuteResult).UserId);

        var interconnectionGroup = new CreateInterconnectionGroupRequest
        {
            GroupName = "客户群",
            GroupAvatar = "https://example.com/a.png",
            GroupTemplateId = "tpl",
            Users = [new() { AppUserId = "app01" }],
            OperatorId = "user01"
        };
        var interconnectionCoupleGroup = new CreateInterconnectionCoupleGroupRequest
        {
            GroupTemplateId = "tpl",
            Users = [new() { AppUserId = "app01" }, new() { UserId = "user01" }],
            OperatorId = "user01"
        };
        var createInterconnections = new CreateInterconnectionsRequest
        {
            Interconnections =
            [
                new()
                {
                    AppUserId = "app01",
                    AppUserName = "客户",
                    AppUserAvatar = "https://example.com/avatar.png",
                    AppUserDynamics = "{}",
                    AppUserMobile = "13800138000",
                    UserId = "user01",
                    ChannelCode = "channel"
                }
            ]
        };
        var groupResponse = new CreateInterconnectionGroupResponse { OpenConversationId = "cid01", ConversationId = "dingcid01", AppUserIds = ["app01"], UserIds = ["user01"] };
        var interconnectionCreateResponse = new CreateInterconnectionsResponse { Results = [new() { AppUserId = "app01", UserId = "user01", Message = "ok" }] };
        var doubleGroups = new QueryDoubleGroupsRequest { GroupTemplateId = "tpl", GroupMembers = [new() { AppUserId = "app01", UserId = "user01" }] };
        var doubleGroupsResponse = new QueryDoubleGroupsResponse { OpenConversations = [new() { OpenConversationId = "cid01", AppUserId = "app01", UserId = "user01" }] };
        var conversationUrl = new GetConversationUrlRequest { AppUserId = "app01", UserId = "user01", OpenConversationId = "cid01", ChannelCode = "channel" };
        var unread = new QueryUnreadMessagesResponse { UnReadCount = 1, UnReadItems = [new() { OpenConversationId = "cid01", UnReadCount = 1 }] };
        var updateMembers = new UpdateGroupMembersRequest { OpenConversationId = "cid01", AppUserIds = ["app01"], UserIds = ["user01"], OperatorId = "user01" };
        var groupMembers = new QueryGroupMembersResponse
        {
            OpenConversationId = "cid01",
            GroupMembers = [new() { GroupMemberId = "app01", GroupMemberName = "客户", GroupMemberType = 2, GroupMemberAvatar = "https://example.com/a.png", GroupMemberDynamics = "{}" }]
        };
        var robotGroupMessage = new SendRobotGroupMessageRequest { OpenConversationIds = ["cid01"], RobotCode = "robot", MsgType = "text", MsgContent = "{}", AtDingUserId = "user01", AtAppUserId = "app01", AtAll = true };
        Assert.Equal("客户群", interconnectionGroup.GroupName);
        Assert.Equal("user01", interconnectionCoupleGroup.Users[1].UserId);
        Assert.Equal("13800138000", createInterconnections.Interconnections[0].AppUserMobile);
        Assert.Equal("dingcid01", groupResponse.ConversationId);
        Assert.Equal("ok", interconnectionCreateResponse.Results[0].Message);
        Assert.Equal("tpl", doubleGroups.GroupTemplateId);
        Assert.Equal("cid01", doubleGroupsResponse.OpenConversations[0].OpenConversationId);
        Assert.Equal("channel", conversationUrl.ChannelCode);
        Assert.Equal("cid01", new QueryUnreadMessagesRequest { AppUserId = "app01", OpenConversationIds = ["cid01"] }.OpenConversationIds![0]);
        Assert.Equal(1, unread.UnReadItems[0].UnReadCount);
        Assert.Equal("user01", updateMembers.OperatorId);
        Assert.Equal("ok", new RemoveGroupMembersResponse { Message = "ok" }.Message);
        Assert.Equal("https://example.com/a.png", new UpdateGroupAvatarResponse { NewGroupAvatar = "https://example.com/a.png" }.NewGroupAvatar);
        Assert.Equal("新群名", new UpdateGroupNameResponse { NewGroupName = "新群名" }.NewGroupName);
        Assert.Equal(2, new UpdateGroupOwnerResponse { NewGroupOwnerId = "app01", NewGroupOwnerType = 2 }.NewGroupOwnerType);
        Assert.Equal("cid01", new QueryGroupMembersRequest("cid01").OpenConversationId);
        Assert.Equal("客户", groupMembers.GroupMembers[0].GroupMemberName);
        Assert.Equal("cid01", new DismissGroupResponse { OpenConversationId = "cid01" }.OpenConversationId);
        Assert.True(robotGroupMessage.AtAll);
        Assert.True(new SendRobotGroupMessageResponse { Success = true }.Success);
        Assert.Equal("req01", new SendInterconnectionMessageResponse { RequestId = "req01" }.RequestId);
        Assert.Equal("code01", new SendDingMessageRequest { SenderId = "user01", ReceiverId = "app01", MessageType = "text", Message = "{}", Code = "code01" }.Code);

        var downloadReq = new DownloadRobotMessageFileRequest("code", "robot");
        var recallRes = new BatchRecallRobotMessagesResponse
        {
            SuccessResult = ["pqk01"],
            FailedResult = [new() { ProcessQueryKey = "pqk02", ErrorCode = "400", ErrorMessage = "bad" }]
        };
        var plugin = new RobotPluginInfo { PluginId = "p1", Name = "入口", PcUrl = "https://pc" };
        var pluginRes = new QueryRobotPluginsResponse { PluginInfoList = [plugin] };
        Assert.Equal("code", downloadReq.DownloadCode);
        Assert.Equal("pqk01", Assert.Single(recallRes.SuccessResult));
        Assert.Equal("p1", Assert.Single(pluginRes.PluginInfoList).PluginId);

        var cardReq = new SendInteractiveCardRequest
        {
            CardTemplateId = "tpl",
            OutTrackId = "track",
            ConversationType = 1,
            CardData = new Dictionary<string, object?> { ["title"] = "hello" }
        };
        var cardRes = new InteractiveCardSendResponse
        {
            Success = true,
            Result = new InteractiveCardSendResult { ProcessQueryKey = "pqk", OpenDynamicCardInstanceId = "card" }
        };
        Assert.Equal("tpl", cardReq.CardTemplateId);
        Assert.Equal("pqk", cardRes.Result.ProcessQueryKey);

        var cardInstanceData = new CardData { CardParamMap = new Dictionary<string, string> { ["title"] = "hello" } };
        var cardInstanceReq = new CreateCardInstanceRequest
        {
            UserId = "u1",
            CardTemplateId = "tpl",
            OutTrackId = "track",
            CallbackRouteKey = "route",
            CardData = cardInstanceData,
            PrivateData = new Dictionary<string, CardData> { ["u1"] = cardInstanceData },
            OpenDynamicDataConfig = new OpenDynamicDataConfig
            {
                DynamicDataSourceConfigs =
                [
                    new DynamicDataSourceConfig
                    {
                        DynamicDataSourceId = "source01",
                        ConstParams = new Dictionary<string, string> { ["creatorId"] = "u1" },
                        PullConfig = new DynamicDataPullConfig { PullStrategy = "INTERVAL", TimeUnit = "SECOND", Interval = 3 }
                    }
                ]
            },
            ImGroupOpenSpaceModel = new ImOpenSpaceModel
            {
                SupportForward = true,
                LastMessageI18n = new Dictionary<string, string> { ["ZH_CN"] = "卡片" },
                SearchSupport = new SearchSupport { SearchIcon = "icon", SearchTypeName = "card", SearchDesc = "desc" },
                Notification = new Notification { AlertContent = "alert", NotificationOff = false }
            },
            ImRobotOpenSpaceModel = new ImOpenSpaceModel(),
            CoFeedOpenSpaceModel = new CoFeedOpenSpaceModel { Title = "title", CoolAppCode = "cool" },
            TopOpenSpaceModel = new TopOpenSpaceModel { SpaceType = "ONE_BOX" },
            UserIdType = 1
        };
        var updateCardInstanceReq = new UpdateCardInstanceRequest
        {
            OutTrackId = "track",
            CardData = cardInstanceData,
            PrivateData = new Dictionary<string, CardData> { ["u1"] = cardInstanceData },
            CardUpdateOptions = new CardUpdateOptions { UpdateCardDataByKey = true, UpdatePrivateDataByKey = true },
            UserIdType = 1
        };
        var deliverReq = new DeliverCardRequest
        {
            OutTrackId = "track",
            OpenSpaceId = "dtv1.card//IM_GROUP.space01",
            ImRobotOpenDeliverModel = new ImRobotOpenDeliverModel { SpaceType = "IM_ROBOT" },
            ImGroupOpenDeliverModel = new ImGroupOpenDeliverModel
            {
                RobotCode = "robot",
                AtUserIds = new Dictionary<string, string> { ["u1"] = "User One" },
                Recipients = ["u1"]
            },
            TopOpenDeliverModel = new TopOpenDeliverModel { ExpiredTimeMillis = 1, UserIds = ["u1"], Platforms = ["ios"] },
            CoFeedOpenDeliverModel = new CoFeedOpenDeliverModel { BizTag = "biz", GmtTimeLine = 1 },
            DocOpenDeliverModel = new DocOpenDeliverModel { UserId = "u1" },
            UserIdType = 1
        };
        var createAndDeliverReq = new CreateAndDeliverCardRequest
        {
            CardTemplateId = "tpl",
            OutTrackId = "track",
            CardData = cardInstanceData,
            OpenSpaceId = "dtv1.card//IM_GROUP.space01",
            ImGroupOpenDeliverModel = deliverReq.ImGroupOpenDeliverModel
        };
        var registerCardCallbackReq = new RegisterCardCallbackRequest { CallbackRouteKey = "route", CallbackUrl = "https://example.com", ApiSecret = "secret", ForceUpdate = true };
        var upsertCardSpaceReq = new UpsertCardSpaceRequest
        {
            OutTrackId = "track",
            ImGroupOpenSpaceModel = cardInstanceReq.ImGroupOpenSpaceModel,
            ImRobotOpenSpaceModel = cardInstanceReq.ImRobotOpenSpaceModel,
            TopOpenSpaceModel = cardInstanceReq.TopOpenSpaceModel,
            CoFeedOpenSpaceModel = cardInstanceReq.CoFeedOpenSpaceModel
        };
        var createCardRes = new CreateCardInstanceResponse { Success = true, Result = "track" };
        var cardBoolRes = new CardBooleanResponse { Success = true, Result = true };
        var deliverRes = new DeliverCardResponse { Success = true, Result = [new CardDeliverResult { SpaceType = "IM_GROUP", SpaceId = "space01", Success = true, CarrierId = "pqk", ErrorMsg = null }] };
        var createAndDeliverRes = new CreateAndDeliverCardResponse { Success = true, Result = new CreateAndDeliverCardResult { OutTrackId = "track", DeliverResults = deliverRes.Result } };
        var registerCardCallbackRes = new RegisterCardCallbackResponse { Success = true, Result = new RegisterCardCallbackResult { CallbackUrl = "https://example.com", ApiSecret = "secret" } };
        Assert.Equal("tpl", cardInstanceReq.CardTemplateId);
        Assert.True(updateCardInstanceReq.CardUpdateOptions.UpdateCardDataByKey);
        Assert.Equal("robot", deliverReq.ImGroupOpenDeliverModel.RobotCode);
        Assert.Equal("dtv1.card//IM_GROUP.space01", createAndDeliverReq.OpenSpaceId);
        Assert.True(registerCardCallbackReq.ForceUpdate);
        Assert.Equal("ONE_BOX", upsertCardSpaceReq.TopOpenSpaceModel.SpaceType);
        Assert.Equal("track", createCardRes.Result);
        Assert.True(cardBoolRes.Result);
        Assert.Equal("pqk", deliverRes.Result[0].CarrierId);
        Assert.Equal("track", createAndDeliverRes.Result.OutTrackId);
        Assert.Equal("secret", registerCardCallbackRes.Result.ApiSecret);

        var workflowForm = new WorkflowCreateOrUpdateFormRequest
        {
            Name = "请假审批",
            FormComponents =
            [
                new WorkflowFormComponent
                {
                    ComponentType = "TextField",
                    Props = new WorkflowFormComponentProps
                    {
                        ComponentId = "TextField_01",
                        Label = "事由",
                        Required = true,
                        Options = [new WorkflowFormComponentOption { Key = "option_0", Value = "年假" }],
                        StatField = [new WorkflowFormComponentStatField { ComponentId = "Number_01", Label = "天数" }],
                        AvailableTemplates = [new WorkflowAvailableTemplate { Name = "关联审批", ProcessCode = "PROC-REL" }]
                    }
                }
            ],
            TemplateConfig = new WorkflowTemplateConfig { Hidden = false }
        };
        var workflowInstanceReq = new WorkflowCreateProcessInstanceRequest
        {
            OriginatorUserId = "u1",
            ProcessCode = "PROC-001",
            RequestId = "req01",
            FormComponentValues = [new WorkflowFormComponentValue { Name = "事由", Value = "年假" }]
        };
        var workflowTaskPage = new WorkflowProcessCentreTodoTasksResponse
        {
            RequestId = "req01",
            TaskPage = new WorkflowProcessCentreTaskPage
            {
                HasMore = false,
                List = [new WorkflowProcessCentreTodoTask { TaskId = 1, UserId = "u1", ProcessInstanceId = "inst01" }]
            }
        };
        var workflowUpdate = new WorkflowBatchUpdateProcessCentreInstancesRequest
        {
            UpdateProcessInstanceRequests =
            [
                new WorkflowUpdateProcessCentreInstanceRequest
                {
                    ProcessInstanceId = "inst01",
                    Status = "COMPLETED",
                    Result = "AGREE",
                    Notifiers = [new WorkflowProcessCentreNotifier { UserId = "u2", Type = "CC" }]
                }
            ]
        };
        Assert.Equal("请假审批", workflowForm.Name);
        Assert.Equal("PROC-001", workflowInstanceReq.ProcessCode);
        Assert.Equal(1, workflowTaskPage.TaskPage.List[0].TaskId);
        Assert.Equal("u2", workflowUpdate.UpdateProcessInstanceRequests[0].Notifiers[0].UserId);

        var personalTodo = new CreatePersonalTodoTaskRequest
        {
            Subject = "个人待办",
            ExecutorIds = ["union-01"],
            NotifyConfigs = new TodoNotifyConfigs { DingNotify = "1" }
        };
        var todoCreate = new CreateTodoTaskRequest
        {
            Subject = "工作待办",
            SourceId = "source-01",
            DetailUrl = new TodoDetailUrl { AppUrl = "https://app.example.com", PcUrl = "https://pc.example.com" },
            Priority = 20
        };
        var todoTask = new TodoTaskResponse
        {
            Id = "task-01",
            Subject = "工作待办",
            Description = "描述",
            StartTime = 1710000000000,
            DueTime = 1710003600000,
            FinishTime = 0,
            Done = false,
            ExecutorIds = ["union-01"],
            ParticipantIds = ["union-02"],
            DetailUrl = new TodoDetailUrl { AppUrl = "https://app.example.com", PcUrl = "https://pc.example.com" },
            Source = "biz",
            SourceId = "source-01",
            CreatedTime = 1710000000000,
            ModifiedTime = 1710000000000,
            CreatorId = "union-creator",
            ModifierId = "union-creator",
            BizTag = "todo",
            RequestId = "req-01",
            IsOnlyShowExecutor = true,
            Priority = 20,
            NotifyConfigs = new TodoNotifyConfigs { DingNotify = "1" }
        };
        var todoQuery = new QueryOrgTodoTasksResponse
        {
            NextToken = "15",
            TodoCards = [new TodoCard { TaskId = "task-01", Subject = "接入钉钉待办", IsDone = true }]
        };
        var executorStatus = new UpdateTodoTaskExecutorStatusRequest
        {
            ExecutorStatusList = [new TodoExecutorStatus { Id = "union-01", IsDone = true }]
        };
        Assert.Equal("个人待办", personalTodo.Subject);
        Assert.Equal("source-01", todoCreate.SourceId);
        Assert.Equal("https://pc.example.com", todoTask.DetailUrl.PcUrl);
        Assert.True(todoQuery.TodoCards[0].IsDone);
        Assert.True(executorStatus.ExecutorStatusList[0].IsDone);

        var grantHonor = new GrantHonorRequest
        {
            SenderUserId = "u1",
            GrantReason = "表现优秀",
            GranterName = "主管",
            ReceiverUserIds = ["u2"],
            OpenConversationIds = ["cid01"]
        };
        var orgHonors = new QueryOrgHonorsResponse
        {
            Success = true,
            Result = new OrgHonorsPage
            {
                NextToken = "next",
                OpenHonors =
                [
                    new OrgHonorInfo
                    {
                        HonorId = 1,
                        HonorName = "创造之星",
                        HonorDesc = "创新",
                        HonorImgUrl = "https://img",
                        HonorPendantImgUrl = "https://pendant"
                    }
                ]
            }
        };
        var userHonors = new QueryUserHonorsResponse
        {
            Success = true,
            Result = new UserHonorsPage
            {
                NextToken = "next",
                Honors =
                [
                    new UserHonorInfo
                    {
                        HonorId = "honor01",
                        HonorName = "创造之星",
                        HonorDesc = "创新",
                        ExpirationTime = 1710000000000,
                        GrantHistory = [new HonorGrantHistory { SenderUserid = "u1", GrantTime = 1700000000000 }]
                    }
                ]
            }
        };
        var honorTemplate = new CreateHonorTemplateRequest
        {
            UserId = "u1",
            MedalName = "创造之星",
            MedalDesc = "创新贡献",
            MedalMediaId = "media01",
            AvatarFrameMediaId = "media02",
            DefaultBgColor = "#FFFBB4"
        };
        var honorTemplateResponse = new CreateHonorTemplateResponse { Success = true, Result = new HonorIdResult { HonorId = "honor01" } };
        var recallHonor = new RecallHonorRequest { UserId = "u2" };
        var recallHonorResponse = new RecallHonorResponse { Success = true, Result = honorTemplateResponse.Result };
        var stepRequest = new GetUserStepStatusRequest { Userid = "u1" };
        var stepResponse = new GetUserStepStatusResponse { Errcode = 0, Status = true, RequestId = "req01" };
        var addPediaWord = new AddPediaWordRequest
        {
            WordName = "测试词条",
            WordAlias = ["测试"],
            HighLightWordAlias = ["测试"],
            RelatedDoc = [new PediaRelatedDoc { Name = "文档", Type = "adoc", Link = "https://doc" }],
            RelatedLink = [new PediaRelatedLink { Name = "链接", Type = "url", Link = "https://link" }],
            WordParaphrase = "释义",
            PicList = [new PediaPicture { MediaIdUrl = "https://pic" }],
            UserId = "u1",
            ContactList = [new PediaContact { UserId = "u2", NickName = "同事", AvatarMediaId = "avatar" }]
        };
        var updatePediaWord = new UpdatePediaWordRequest
        {
            WordName = "测试词条",
            WordParaphrase = "释义",
            UserId = "u1",
            Uuid = "1001",
            AppLink = [new PediaAppLink { AppName = "应用", AppId = 1, PcLink = "https://pc", PhoneLink = "https://phone", IconLink = "https://icon" }]
        };
        var approvePediaWord = new ApprovePediaWordRequest { UserId = "u1", Uuid = "1001", ApproveStatus = "1", ApproveReason = "ok", ImHighLight = true, SimHighLight = false };
        var pediaDetail = new PediaWordDetail
        {
            WordName = "测试词条",
            Uuid = 1001,
            GmtCreate = 1700000000000,
            GmtModify = 1700000001000,
            OrgName = "组织",
            WordAlias = ["测试"],
            HighLightWordAlias = ["测试"],
            WordFullName = "测试词条",
            RelatedDoc = addPediaWord.RelatedDoc,
            RelatedLink = addPediaWord.RelatedLink,
            CreatorName = "创建者",
            UpdaterName = "更新人",
            ApproveName = "审核人",
            WordParaphrase = "释义",
            SimpleWordParaphrase = "释义",
            Contacts = ["同事"],
            TagsList = ["分类"],
            AppLink = updatePediaWord.AppLink,
            ImHighLight = true,
            SimHighLight = false,
            PicList = addPediaWord.PicList,
            ContactList = addPediaWord.ContactList,
            UserId = "u1",
            ParentUuid = 0
        };
        var searchPediaWords = new SearchPediaWordsRequest { WordName = "测试", UserId = "u1", Status = "0", PageSize = 20, PageNumber = 1 };
        var parseWikiWords = new ParseWikiWordsRequest { Content = "这是一条测试信息" };
        var parseResponse = new ParseWikiWordsResponse { Success = true, Data = [new ParsedWikiWord { StartIndex = 4, EndIndex = 6, WordName = "测试" }] };
        Assert.Equal("u1", grantHonor.SenderUserId);
        Assert.Equal(1, orgHonors.Result.OpenHonors[0].HonorId);
        Assert.Equal("u1", userHonors.Result.Honors[0].GrantHistory[0].SenderUserid);
        Assert.Equal("#FFFBB4", honorTemplate.DefaultBgColor);
        Assert.Equal("honor01", recallHonorResponse.Result.HonorId);
        Assert.Equal("u2", recallHonor.UserId);
        Assert.True(stepResponse.Status);
        Assert.Equal("u1", stepRequest.Userid);
        Assert.Equal("测试词条", addPediaWord.WordName);
        Assert.Equal("1001", updatePediaWord.Uuid);
        Assert.True(approvePediaWord.ImHighLight);
        Assert.Equal(1001, pediaDetail.Uuid);
        Assert.Equal(20, searchPediaWords.PageSize);
        Assert.Equal("这是一条测试信息", parseWikiWords.Content);
        Assert.Equal(4, parseResponse.Data[0].StartIndex);
        Assert.True(new PediaWordMutationResponse { Uuid = 1001, Success = true }.Success);
        Assert.True(new PediaWordApproveResponse { Success = true }.Success);
        Assert.True(new WikiWordDetailsResponse { Success = true, ErrMsg = "ok", Data = [pediaDetail] }.Success);
        Assert.True(new PediaWordDetailResponse { Success = true, Data = pediaDetail }.Success);

        var createBlackboard = new CreateBlackboardRequest
        {
            CreateRequest = new CreateBlackboardRequestBody
            {
                OperationUserid = "manager01",
                Author = "作者",
                PrivateLevel = 0,
                Ding = false,
                BlackboardReceiver = new BlackboardReceiver { DeptidList = [1], UseridList = ["u1"] },
                Title = "入职须知",
                PushTop = true,
                Content = "欢迎加入",
                CategoryId = "cat01",
                CoverpicMediaid = "@media"
            }
        };
        var updateBlackboard = new UpdateBlackboardRequest
        {
            UpdateRequest = new UpdateBlackboardRequestBody
            {
                BlackboardId = "bb01",
                Title = "标题",
                Content = "内容",
                OperationUserid = "manager01",
                Author = "作者",
                Ding = true,
                CategoryId = "cat01",
                Notify = true,
                CoverpicMediaid = "@media"
            }
        };
        var blackboardDetail = new BlackboardDetail
        {
            Id = "bb01",
            Author = "作者",
            Title = "标题",
            Content = "内容",
            CategoryId = "cat01",
            PrivateLevel = 0,
            DepnameList = ["人事部"],
            UsernameList = ["张三"],
            GmtCreate = "2019-10-22 14:43:07",
            GmtModified = "2019-11-22 10:43:07",
            ReadCount = 10,
            UnreadCount = 1,
            CoverpicUrl = "https://example.com/pic.png"
        };
        var blackboardCategory = new BlackboardCategory { Name = "正式公告", Id = "cat01" };
        var topTenBlackboard = new TopTenBlackboard
        {
            GmtCreate = "2020-09-08 14:42:12",
            Title = "国庆节值班表",
            Url = "https://example.com",
            CategoryId = "cat01",
            Id = "bb01"
        };
        Assert.Equal("入职须知", createBlackboard.CreateRequest.Title);
        Assert.Equal("bb01", updateBlackboard.UpdateRequest.BlackboardId);
        Assert.Equal("bb01", new DeleteBlackboardRequest { BlackboardId = "bb01", OperationUserid = "manager01" }.BlackboardId);
        Assert.Equal("bb01", new GetBlackboardRequest { BlackboardId = "bb01", OperationUserid = "manager01" }.BlackboardId);
        Assert.Equal("cat01", new ListBlackboardIdsRequest { QueryRequest = new ListBlackboardIdsRequestBody { OperationUserid = "manager01", Page = 1, PageSize = 10, StartTime = "2019-10-07 10:10:10", EndTime = "2019-11-07 10:10:10", CategoryId = "cat01" } }.QueryRequest.CategoryId);
        Assert.Equal("manager01", new ListBlackboardCategoriesRequest { OperationUserid = "manager01" }.OperationUserid);
        Assert.Equal("u1", new ListTopTenBlackboardsRequest { Userid = "u1" }.Userid);
        Assert.Equal("100", new BlackboardSpaceRequest { SpaceId = "100" }.SpaceId);
        Assert.Equal("标题", blackboardDetail.Title);
        Assert.True(new BlackboardBooleanResponse { Errcode = 0, Success = true, Result = true, RequestId = "req01" }.Result);
        Assert.Equal("bb01", new GetBlackboardResponse { Errcode = 0, Success = true, RequestId = "req01", Result = blackboardDetail }.Result.Id);
        Assert.Equal("bb01", new BlackboardIdListResponse { Errcode = 0, Success = true, RequestId = "req01", Result = ["bb01"] }.Result[0]);
        Assert.Equal("正式公告", new BlackboardCategoryListResponse { Errcode = 0, Success = true, RequestId = "req01", Result = [blackboardCategory] }.Result[0].Name);
        Assert.Equal("国庆节值班表", new ListTopTenBlackboardsResponse { Errcode = 0, RequestId = "req01", BlackboardList = [topTenBlackboard] }.BlackboardList[0].Title);
        Assert.NotNull(new BlackboardSpaceResponse());

        var reportContent = new ReportContent { Sort = 0, Type = 1, ContentType = "markdown", Content = "今日完成", Key = "今日完成工作" };
        var createReport = new CreateReportRequest
        {
            CreateReportParam = new CreateReportParam
            {
                Contents = [reportContent],
                TemplateId = "tpl01",
                ToUserids = ["u2"],
                ToChat = true,
                ToCids = ["cid01"],
                DdFrom = "report",
                Userid = "u1"
            }
        };
        var saveReport = new SaveReportContentRequest
        {
            CreateReportParam = new SaveReportContentParam
            {
                Contents = [reportContent],
                TemplateId = "tpl01",
                DdFrom = "report",
                Userid = "u1"
            }
        };
        var reportTemplate = new ReportTemplateDetail
        {
            Name = "日报",
            Id = "tpl01",
            UserName = "张三",
            Userid = "u1",
            DefaultReceivers = [new ReportTemplateReceiver { UserName = "李四", Userid = "u2" }],
            Fields = [new ReportTemplateField { FieldName = "今日完成工作", Type = 1, Sort = 0 }],
            DefaultReceivedConvs = [new ReportTemplateConversation { ConversationId = "cid01", Title = "日报群" }]
        };
        var reportList = new ReportListResult
        {
            DataList = [new ReportDetail { Contents = "内容", Remark = "备注", TemplateName = "日报", DeptName = "研发", CreatorName = "张三", CreatorId = "u1", CreateTime = 1710000000000, ReportId = "report01", ModifiedTime = 1710000001000 }],
            Size = 20,
            NextCursor = 20,
            HasMore = true
        };
        var simpleReports = new ReportSimpleListResponse
        {
            ErrCode = 0,
            RequestId = "req01",
            Result = new ReportSimpleListResult
            {
                DataList = [new ReportSimpleDetail { Remark = "备注", TemplateName = "日报", DeptName = "研发", CreatorName = "张三", CreatorId = "u1", CreateTime = 1710000000000, ReportId = "report01" }],
                Size = 20,
                HasMore = false
            }
        };
        var reportUsers = new ReportUserIdListResponse { Success = true, Result = new ReportUserIdListResult { NextCursor = 100, HasMore = true, UseridList = ["u1"] } };
        var reportComments = new ReportCommentListResponse { Success = true, Result = new ReportCommentListResult { Comments = [new ReportComment { CreateTime = "2020-09-08 00:26:37", Content = "不错", Userid = "u2" }] } };
        var reportTemplates = new ReportTemplateListResponse { ErrMsg = "ok", Result = new ReportTemplateListResult { TemplateList = [new ReportTemplateSummary { Name = "日报", IconUrl = "https://example.com/icon.png", ReportCode = "tpl01", Url = "https://example.com/report" }], NextCursor = 100 } };
        Assert.Equal("tpl01", createReport.CreateReportParam.TemplateId);
        Assert.Equal("u1", saveReport.CreateReportParam.Userid);
        Assert.Equal("日报", new GetReportTemplateByNameRequest { Userid = "u1", TemplateName = "日报" }.TemplateName);
        Assert.Equal("日报", reportTemplate.Name);
        Assert.Equal("report01", reportList.DataList[0].ReportId);
        Assert.Equal("日报", simpleReports.Result.DataList[0].TemplateName);
        Assert.Equal("u1", new ListReportsRequest { StartTime = 1, EndTime = 2, Cursor = 0, Size = 20, Userid = "u1", TemplateName = "日报", ModifiedStartTime = 1, ModifiedEndTime = 2 }.Userid);
        Assert.Equal(20, new ListSimpleReportsRequest { StartTime = 1, EndTime = 2, Cursor = 0, Size = 20 }.Size);
        Assert.Equal(0, new ListReportUsersByTypeRequest { ReportId = "report01", Type = 0, Offset = 0, Size = 100 }.Type);
        Assert.Equal("report01", new ListReportReceiversRequest { ReportId = "report01" }.ReportId);
        Assert.Equal("report01", new ListReportCommentsRequest { ReportId = "report01" }.ReportId);
        Assert.Equal("u1", reportUsers.Result.UseridList[0]);
        Assert.Equal("不错", reportComments.Result.Comments[0].Content);
        Assert.Equal(2, new ReportUnreadCountResponse { Count = 2, ErrCode = 0, ErrMsg = "ok", RequestId = "req01" }.Count);
        Assert.Equal("u1", new GetReportUnreadCountRequest { Userid = "u1" }.Userid);
        Assert.Equal("tpl01", reportTemplates.Result.TemplateList[0].ReportCode);
        Assert.Equal(100, new ListReportTemplatesByUserIdRequest { Userid = "u1", Offset = 0, Size = 100 }.Size);

        var serviceWindowBatch = new ServiceWindowBatchSendMessageRequest
        {
            BizId = "biz01",
            AccountId = "account01",
            Detail = new ServiceWindowBatchMessageDetail
            {
                MsgType = "text",
                Uuid = "uuid01",
                BizRequestId = "biz-request-01",
                UserIdList = ["user01"],
                SendToAll = false,
                MessageBody = new ServiceWindowMessageBody
                {
                    Text = new ServiceWindowTextMessage { Content = "hello" },
                    Markdown = new ServiceWindowMarkdownMessage { Title = "标题", Text = "### 内容" },
                    Link = new ServiceWindowLinkMessage { PicUrl = "https://example.com/p.png", MessageUrl = "https://example.com", Title = "链接", Text = "描述" },
                    ActionCard = new ServiceWindowActionCardMessage
                    {
                        Title = "卡片",
                        ButtonOrientation = "0",
                        SingleTitle = "查看",
                        SingleUrl = "https://example.com",
                        Markdown = "### 卡片",
                        ButtonList = [new ServiceWindowActionCardButton { Title = "按钮", ActionUrl = "https://example.com/action" }]
                    }
                }
            }
        };
        var serviceWindowSend = new ServiceWindowSendMessageRequest
        {
            AccountId = "account01",
            Detail = new ServiceWindowMessageDetail
            {
                MsgType = "text",
                Uuid = "uuid02",
                UserId = "user01",
                MessageBody = new ServiceWindowMessageBody { Text = new ServiceWindowTextMessage { Content = "hello" } }
            }
        };
        var serviceWindowAccounts = new ServiceWindowAccountListResponse { Result = [new ServiceWindowAccount { AccountId = "account01", AccountName = "服务窗" }] };
        var serviceWindowFollowers = new ServiceWindowFollowerListResponse
        {
            RequestId = "req01",
            Result = new ServiceWindowFollowerListResult
            {
                NextToken = "next01",
                UserList = [new ServiceWindowFollower { UserId = "user01", Name = "张三", Timestamp = 1710000000000 }]
            }
        };
        var serviceWindowFollowerInfo = new ServiceWindowFollowerInfoResponse
        {
            RequestId = "req02",
            Result = new ServiceWindowFollowerInfoResult
            {
                User = new ServiceWindowFollower { UserId = "user01", Name = "张三", Timestamp = 1710000000000 }
            }
        };
        Assert.Equal("biz-request-01", serviceWindowBatch.Detail.BizRequestId);
        Assert.Equal("按钮", serviceWindowBatch.Detail.MessageBody.ActionCard!.ButtonList[0].Title);
        Assert.Equal("user01", serviceWindowSend.Detail.UserId);
        Assert.Equal("push01", new ServiceWindowMessageSendResponse { RequestId = "req01", Result = new ServiceWindowMessageSendResult { OpenPushId = "push01" } }.Result.OpenPushId);
        Assert.Equal("服务窗", serviceWindowAccounts.Result[0].AccountName);
        Assert.Equal("next01", serviceWindowFollowers.Result.NextToken);
        Assert.Equal("张三", serviceWindowFollowerInfo.Result.User.Name);

        var smartDeviceBind = new SmartDeviceBindRequest
        {
            DeviceBindReqVo = new SmartDeviceBindInfo
            {
                Nick = "ding",
                Sn = "sdx123d123asdf",
                Mac = "11:11:11:11:11",
                Outid = "123456",
                Ext = "智能产品",
                Dn = "产品智能",
                Pk = "pk_01"
            }
        };
        var smartDevicePage = new SmartDeviceQueryListResponse
        {
            Success = true,
            Result = new SmartDeviceQueryListResult
            {
                NextCursor = 20,
                HasMore = true,
                List =
                [
                    new SmartDeviceInfo
                    {
                        CorpId = "ding9f5xxxx",
                        DeviceMac = "11:11:11:11:11",
                        Nick = "ding",
                        DeviceId = "QWR45GT",
                        DeviceName = "产品智能",
                        Pk = "pk_01",
                        Userid = "user01",
                        Ext = "智能产品",
                        Sn = "sdx123d123asdf"
                    }
                ]
            }
        };
        var smartDeviceQuery = new SmartDeviceQueryRequest { DeviceQueryVo = new SmartDeviceQueryInfo { Pk = "pk_01", DeviceName = "产品智能", DeviceId = "QWR45GT" } };
        var smartDeviceById = new SmartDeviceQueryByIdRequest { DeviceQueryVo = new SmartDeviceQueryByIdInfo { DeviceId = "QWR45GT" } };
        Assert.Equal("sdx123d123asdf", smartDeviceBind.DeviceBindReqVo.Sn);
        Assert.Equal("QWR45GT", new SmartDeviceBindResponse { Success = true, Result = new SmartDeviceBindResult { DeviceId = "QWR45GT" } }.Result.DeviceId);
        Assert.Equal("user01", smartDevicePage.Result.List[0].Userid);
        Assert.Equal("QWR45GT", smartDeviceQuery.DeviceQueryVo.DeviceId);
        Assert.Equal("QWR45GT", smartDeviceById.DeviceQueryVo.DeviceId);
        Assert.Equal("user01", new SmartDeviceUnbindRequest { DeviceUnbindVo = new SmartDeviceUnbindInfo { Pk = "pk_01", DeviceName = "产品智能", DeviceId = "QWR45GT", Userid = "user01" } }.DeviceUnbindVo.Userid);
        Assert.Equal("newding", new SmartDeviceUpdateNickRequest { DeviceNickModifyVo = new SmartDeviceUpdateNickInfo { Pk = "pk_01", DeviceName = "产品智能", DeviceId = "QWR45GT", Nick = "newding" } }.DeviceNickModifyVo.Nick);
        Assert.Equal(20, new SmartDeviceQueryListRequest { PageQueryVo = new SmartDevicePageQuery { Pk = "pk_01", Cursor = 0, Size = 20 } }.PageQueryVo.Size);

        var callbackFailed = new GetCallbackFailedResultResponse
        {
            ErrCode = 0,
            ErrMsg = "ok",
            HasMore = true,
            FailedList =
            [
                new CallbackFailedEvent
                {
                    CallBackTag = "user_add_org",
                    EventTime = 1710000000000,
                    UserAddOrg = new CallbackUserAddOrgEvent
                    {
                        Corpid = "ding9f5xxxx",
                        Userid = ["user01"]
                    }
                }
            ]
        };
        Assert.True(callbackFailed.HasMore);
        Assert.Equal("user01", callbackFailed.FailedList[0].UserAddOrg!.Userid[0]);
        Assert.Equal("ding9f5xxxx", new CallbackBpmsInstanceChangeEvent { Corpid = "ding9f5xxxx" }.Corpid);
        Assert.Equal("ding9f5xxxx", new CallbackLabelConfAddEvent { Corpid = "ding9f5xxxx" }.Corpid);

        var smartFillSetting = new SmartFillFormSetting
        {
            BizType = 0,
            CreateTime = "2022-07-29T14:55Z",
            FormType = 1,
            Stop = false,
            LoopTime = "09:00",
            LoopDays = [1, 2],
            EndTime = "2022-08-01T14:55Z"
        };
        var smartFillSchemas = new SmartFillFormSchemasResponse
        {
            Success = true,
            Result = new SmartFillFormSchemasResult
            {
                HasMore = false,
                NextToken = 0,
                List = [new SmartFillFormSchema { Creator = "u1", FormCode = "form01", Name = "测试填表", Memo = "提示", Setting = smartFillSetting }]
            }
        };
        var smartFillInstances = new SmartFillFormInstancesResponse
        {
            Success = true,
            Result = new SmartFillFormInstancesResult
            {
                HasMore = true,
                NextToken = 100,
                List =
                [
                    new SmartFillFormInstanceSummary
                    {
                        CreateTime = "2022-07-29T15:06Z",
                        ModifyTime = "2022-07-29T15:07Z",
                        FormCode = "form01",
                        Title = "测试填表",
                        SubmitterUserId = "u2",
                        SubmitterUserName = "李四",
                        Forms = [new SmartFillFormValue { Label = "姓名", Key = "TextField_1", Value = "李四" }],
                        FormInstanceId = "inst01",
                        StudentClassName = "一班",
                        StudentClassId = "class01",
                        StudentUserId = "stu01",
                        StudentName = "学生"
                    }
                ]
            }
        };
        var smartFillInstance = new SmartFillFormInstanceResponse
        {
            Success = true,
            Result = new SmartFillFormInstanceDetail
            {
                CreateTime = "2022-07-29T15:07Z",
                ModifyTime = "2022-07-29T15:08Z",
                FormCode = "form01",
                Title = "测试填表",
                Creator = "u2",
                Forms = [new SmartFillFormValue { Label = "城市", Key = "TextField_2", Value = "上海" }]
            }
        };
        Assert.Equal("form01", smartFillSchemas.Result.List[0].FormCode);
        Assert.Equal(2, smartFillSchemas.Result.List[0].Setting!.LoopDays[1]);
        Assert.Equal("inst01", smartFillInstances.Result.List[0].FormInstanceId);
        Assert.Equal("上海", smartFillInstance.Result.Forms[0].Value);

        var workbenchRequest = new BatchAddRecentUsedAppsRequest
        {
            CorpId = "dingcorp",
            UserId = "user01",
            UsedAppDetailList = [new RecentUsedAppDetail { AgentId = "agent01" }]
        };
        Assert.Equal("agent01", workbenchRequest.UsedAppDetailList[0].AgentId);

        var createInnerApp = new CreateInnerAppRequest
        {
            OpUnionId = "union01",
            Name = "应用",
            Desc = "描述",
            Icon = "media01",
            HomepageLink = "https://m",
            PcHomepageLink = "https://pc",
            OmpLink = "https://admin",
            IpWhiteList = ["127.0.0.1"],
            ScopeType = "BASE",
            DevelopType = 0
        };
        var updateInnerApp = new UpdateInnerAppRequest
        {
            OpUnionId = "union01",
            Name = "新应用",
            Desc = "新描述",
            Icon = "media02",
            HomepageLink = "https://m2",
            PcHomepageLink = "https://pc2",
            OmpLink = "https://admin2",
            IpWhiteList = ["192.168.*.*"]
        };
        var createInnerAppResponse = new CreateInnerAppResponse { AgentId = 111, AppKey = "dingkey", AppSecret = "secret" };
        var applicationList = new ApplicationListResponse
        {
            AppList =
            [
                new ApplicationInfo
                {
                    AgentId = 111,
                    Name = "应用",
                    Desc = "描述",
                    Icon = "icon",
                    HomepageLink = "https://m",
                    PcHomepageLink = "https://pc",
                    OmpLink = "https://admin",
                    AppId = 0,
                    AppStatus = 1,
                    DevelopType = 0
                }
            ]
        };
        var publishVersion = new PublishInnerMiniAppVersionRequest { OpUnionId = "union01", PublishType = "online", AppVersionId = "1001", MiniAppOnPc = true };
        var rollbackVersion = new RollbackInnerMiniAppVersionRequest { OpUnionId = "union01", VersionId = "1000" };
        var versionInfo = new InnerMiniAppVersionInfo
        {
            AppVersionId = 1001,
            MiniAppId = "mini01",
            AppVersion = "1.0.0",
            AppVersionType = 2,
            MiniAppOnPc = true,
            CreateTime = "2026-01-01 10:00:00",
            ModifyTime = "2026-01-02 10:00:00",
            EntranceLink = "https://entrance"
        };
        var versionList = new InnerMiniAppVersionListResponse { AppVersionList = [versionInfo] };
        var historyVersionList = new InnerMiniAppHistoryVersionListResponse { TotalCount = 1, MiniAppVersionList = [versionInfo] };
        var setScope = new SetInnerAppScopeRequest
        {
            AddUserIds = ["u1"],
            DelUserIds = ["u2"],
            AddDeptIds = ["1"],
            DelDeptIds = ["2"],
            AddRoleIds = ["3"],
            DelRoleIds = ["4"],
            OnlyAdminVisible = false
        };
        var scope = new InnerAppScope { UserIds = ["u1"], DeptIds = [1], RoleIds = [2], OnlyAdminVisible = false };
        Assert.Equal("应用", createInnerApp.Name);
        Assert.Equal("新应用", updateInnerApp.Name);
        Assert.Equal("dingkey", createInnerAppResponse.AppKey);
        Assert.Equal(111, applicationList.AppList[0].AgentId);
        Assert.Equal("online", publishVersion.PublishType);
        Assert.Equal("1000", rollbackVersion.VersionId);
        Assert.Equal("1.0.0", versionList.AppVersionList[0].AppVersion);
        Assert.Equal(1, historyVersionList.TotalCount);
        Assert.Equal("u1", setScope.AddUserIds[0]);
        Assert.Equal(2, scope.RoleIds[0]);
    }
}
