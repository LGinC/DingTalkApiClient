# DingTalkApiClient

`DingTalkApiClient` 是一个对接钉钉 OpenAPI 的 C# 客户端库，底层基于 `WebApiClientCore` 构建，以便提供强类型和声明式的接口调用体验。当前支持 `net8.0`、`net9.0` 和 `net10.0`。

## 安装

```bash
dotnet add package DingTalkApiClient
```

## 已实现的接口能力

为了更好地组织和使用，本库按照钉钉 API 的分类进行了整理。以下是目前支持的所有接口能力列表：

- auth：[IAccessTokenApi](Apis/IAccessTokenApi.cs)、[ISsoAuthApi](Apis/Auth/ISsoAuthApi.cs)
- OA审批：[IWorkflowApi](Apis/Workflow/IWorkflowApi.cs)
- teambition项目管理：[ITeambitionProjectApi](Apis/Teambition/ITeambitionProjectApi.cs)、[ITeambitionWorkspaceTopApi](Apis/Teambition/ITeambitionWorkspaceTopApi.cs)
- 上下游和上下级：[ICooperateCorpsApi](Apis/Contacts/ICooperateCorpsApi.cs)、[IUnionCooperateApi](Apis/Contacts/IUnionCooperateApi.cs)
- 专属开放：[IExclusiveOpenApi](Apis/ExclusiveOpen/IExclusiveOpenApi.cs)、[IExclusiveOpenServiceAccountApi](Apis/ExclusiveOpen/IExclusiveOpenServiceAccountApi.cs)
- 事件订阅：[IEventSubscriptionApi](Models/EventSubscription/IEventSubscriptionApi.cs)
- 互动卡片：[ICardInstancesApi](Apis/Card/ICardInstancesApi.cs)、[IInteractiveCardApi](Apis/IM/IInteractiveCardApi.cs)
- 企业文化：[IOrgCultureApi](Apis/OrgCulture/IOrgCultureApi.cs)
- 公告：[IBlackboardApi](Apis/Blackboard/IBlackboardApi.cs)
- 即时通讯：[IChatApi](Apis/IM/IChatApi.cs)、[ICorpConversationApi](Apis/IM/ICorpConversationApi.cs)、[IRobotApi](Apis/IM/IRobotApi.cs)、[ISceneGroupApi](Apis/IM/ISceneGroupApi.cs)、[IInterconnectionsApi](Apis/IM/IInterconnectionsApi.cs)
- 宜搭应用开发：[IYidaApi](Apis/Yida/IYidaApi.cs)
- 客户管理CRM：[ICrmApi](Apis/CRM/ICrmApi.cs)
- 客服：[IInterconnectionsApi](Apis/IM/IInterconnectionsApi.cs)
- 工作台：[IWorkbenchApi](Apis/Workbench/IWorkbenchApi.cs)
- 应用管理：[IApplicationManagementApi](Apis/ApplicationManagement/IApplicationManagementApi.cs)
- 待办任务：[ITodoApi](Apis/Todo/ITodoApi.cs)
- 文档文件：[IDocumentFileApi](Apis/DocumentFile/IDocumentFileApi.cs)
- 日志：[IReportApi](Apis/Report/IReportApi.cs)
- 日程：[ICalendarApi](Apis/Calendar/ICalendarApi.cs)
- 智能人事：[IHumanResourcesApi](Apis/HRM/IHumanResourcesApi.cs)
- 智能填表：[ISmartFillApi](Apis/SmartFill/ISmartFillApi.cs)
- 智能硬件：[ISmartDeviceApi](Apis/SmartDevice/ISmartDeviceApi.cs)
- 服务窗：[IServiceWindowApi](Apis/ServiceWindow/IServiceWindowApi.cs)
- 生态开放：[IEcosystemApi](Apis/Ecosystem/IEcosystemApi.cs)、[IEcosystemTopApi](Apis/Ecosystem/IEcosystemTopApi.cs)
- 签到：[ICheckinApi](Apis/Checkin/ICheckinApi.cs)
- 考勤：[IAttendanceApprovalsApi](Apis/Attendance/IAttendanceApprovalsApi.cs)、[IAttendanceGroupsApi](Apis/Attendance/IAttendanceGroupsApi.cs)、[IAttendanceMachinesApi](Apis/Attendance/IAttendanceMachinesApi.cs)、[IAttendanceMachinesV1Api](Apis/Attendance/IAttendanceMachinesV1Api.cs)、[IAttendanceRecordsApi](Apis/Attendance/IAttendanceRecordsApi.cs)、[IAttendanceReportsApi](Apis/Attendance/IAttendanceReportsApi.cs)、[IAttendanceSchedulesApi](Apis/Attendance/IAttendanceSchedulesApi.cs)、[IAttendanceSettingsApi](Apis/Attendance/IAttendanceSettingsApi.cs)、[IAttendanceShiftsApi](Apis/Attendance/IAttendanceShiftsApi.cs)、[IAttendanceVacationsApi](Apis/Attendance/IAttendanceVacationsApi.cs)
- 行业开放：[IIndustryOpenApi](Apis/IndustryOpen/IIndustryOpenApi.cs)、[IIndustryOpenTopApi](Apis/IndustryOpen/IIndustryOpenTopApi.cs)
- 通讯录：[IAuthScopesApi](Apis/Contacts/IAuthScopesApi.cs)、[IContactSettingsApi](Apis/Contacts/IContactSettingsApi.cs)、[IContactUsersApi](Apis/Contacts/IContactUsersApi.cs)、[IDepartmentManageApi](Apis/Contacts/IDepartmentManageApi.cs)、[IEmployeeRecordsApi](Apis/Contacts/IEmployeeRecordsApi.cs)、[IExternalContactsApi](Apis/Contacts/IExternalContactsApi.cs)、[IIndustryContactsApi](Apis/Contacts/IIndustryContactsApi.cs)、[IOrgAccountsApi](Apis/Contacts/IOrgAccountsApi.cs)、[IRoleManageApi](Apis/Contacts/IRoleManageApi.cs)、[ISeniorSettingsApi](Apis/Contacts/ISeniorSettingsApi.cs)、[IStaffAttributesApi](Apis/Contacts/IStaffAttributesApi.cs)、[IUserManageApi](Apis/Contacts/IUserManageApi.cs)
- 钉工牌：[IBadgeApi](Apis/Badge/IBadgeApi.cs)
- 音视频：[ILiveApi](Apis/AudioAndVideo/ILiveApi.cs)、[IMeetingRoomsApi](Apis/AudioAndVideo/IMeetingRoomsApi.cs)、[IVideoConferencesApi](Apis/AudioAndVideo/IVideoConferencesApi.cs)

## 配置说明与 WebApiClientCore

由于本库依赖于 [WebApiClientCore](https://github.com/dotnetcore/WebApiClient)，你可以利用 `WebApiClientCore.Extensions.OAuths` 或本库提供的扩展，在 ASP.NET Core 服务中轻松挂载并管理 Http 客户端。

### 1. `appsettings.json` 配置示例

本库会根据调用 `AddDingTalk` 时传入的 `ProviderName`，从 `DingTalk:{ProviderName}` 节点读取对应的密钥配置。未传入 `ProviderName` 时，默认注册 `Internal`，即读取 `DingTalk:Internal`。

```json
{
  "DingTalk": {
    "EnableLogging": false,
    "Internal": {
      "ClientId": "your_client_id",
      "ClientSecret": "your_client_secret",
      "CropId": "your_crop_id"
    },
    "Corp": {
      "ClientId": "your_corp_client_id",
      "ClientSecret": "your_corp_client_secret",
      "SuiteKey": "your_suite_key",
      "SuiteSecret": "your_suite_secret",
      "AuthCorpId": "",
      "SuiteTicket": ""
    },
    "MicroApp": {
      "ClientId": "your_micro_app_client_id",
      "CropId": "your_crop_id",
      "SsoSecret": "your_sso_secret"
    }
  }
}
```

内置的 `ProviderName` 包括 `Internal`（内部应用）、`Corp`（定制应用）和 `MicroApp`（微应用）。例如：

```csharp
builder.Services.AddDingTalk(builder.Configuration, ProviderNames.Internal, ProviderNames.Corp);
```

上面的代码会读取 `DingTalk:Internal` 和 `DingTalk:Corp` 两组配置，并注册对应的 AccessToken Provider。

`EnableLogging` 用于控制 `WebApiClientCore` 的异常日志是否启用。开启后，仅当响应状态码不是 `200`，或请求在发出/反序列化阶段发生异常时，才会记录请求头、请求体、响应头和响应体；默认建议在生产环境保持 `false`，排查联调问题时再打开。

### 机器人消息发送示例

```csharp
// 发送自定义机器人文本消息 (使用工厂方法)
var robotMsg = CustomRobotMessageRequest.Create(
    RobotMsgType.Text,
    new CustomRobotMessageRequest.TextObj { Content = "您有一条新的告警消息" }
);

var response = await robotApi.SendCustomRobotMessageAsync("your_access_token", robotMsg);

// 发送群聊 Markdown 消息
var request = new SendGroupMessageRequest(
    robotCode: "your_robot_code",
    openConversationId: "cidXXXXXX",
    msgKey: "sampleMarkdown",
    msgParam: "{\"title\":\"Hello\",\"text\":\"World\"}"
);

var response = await robotApi.SendGroupMessageAsync(request);
```

### Source Generation 与序列化说明

项目支持并使用 `System.Text.Json` Source Generation。所有已实现接口涉及的请求、响应模型会注册到 `DingTalkJsonSerializerContext`，以减少运行时反射依赖，并更好地支持 AOT、裁剪和高性能序列化场景。

针对机器人消息和工作通知，项目通过工厂模式保证了类型安全与序列化的一致性。
1. 继承自 `DingTalkResult` 以统一处理错误。
2. 属性使用 `PascalCase` 命名，并通过 `[JsonPropertyName]` 映射。
3. 通过 `Create<TBody>` 静态方法构建消息，强制校验消息体类型。

### 2. 依赖注入 (DI) 调用示例

在 `Startup.cs` 或者 `Program.cs` (.NET 6+) 中调用扩展方法进行依赖注入：

```csharp
using DingTalkApiClient;

var builder = WebApplication.CreateBuilder(args);

// 未传入 ProviderName 时默认读取 DingTalk:Internal，并注册所有已支持的钉钉 HttpApi
builder.Services.AddDingTalk(builder.Configuration);
```

完成注入后，即可在任意的控制器、服务或者使用依赖注入的类中获取接口（如 `ICorpConversationApi`）：

```csharp
using DingTalkApiClient.Apis.IM;
using DingTalkApiClient.Models.IM.CorpConversation;

public class NotificationService
{
    private readonly ICorpConversationApi _corpConversationApi;

    public NotificationService(ICorpConversationApi corpConversationApi)
    {
        _corpConversationApi = corpConversationApi;
    }

    public async Task NotifyUserAsync()
    {
        // 构建工作通知请求：使用静态泛型工厂方法 Create 确保消息类型的类型安全
        var request = new AsyncSendCorpConversationV2Request(
            AgentId: 10001,
            UserIdList: "user1,user2",
            DeptIdList: "",
            ToAllUser: false,
            Msg: CorpConversationMsgRequest.Create(
                CorpConversationMsgType.Text, 
                new CorpConversationMsgRequest.TextObj { Content = "您有一条新的提醒待查看！" }
            )
        );

        // 即可直接调用钉钉接口进行工作通知，无须手动处理 AccessToken 的获取与拼接
        var result = await _corpConversationApi.AsyncSendCorpConversationV2Async(request);
        
        if (result.IsSuccess)
        {
            Console.WriteLine($"任务创建成功！任务ID: {result.TaskId}");
        }
    }
}
```

如果需要使用非默认的 AccessToken Provider，可以在调用接口时指定 `tokenProviderName`：

```csharp
var result = await _corpConversationApi.AsyncSendCorpConversationV2Async(
    request,
    tokenProviderName: ProviderNames.Corp
);
```
