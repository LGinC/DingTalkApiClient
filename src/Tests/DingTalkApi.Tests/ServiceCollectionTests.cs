using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using DingTalkApi.Apis;
using DingTalkApi.Apis.ApplicationManagement;
using DingTalkApi.Apis.AudioAndVideo;
using DingTalkApi.Apis.Badge;
using DingTalkApi.Apis.Blackboard;
using DingTalkApi.Apis.Calendar;
using DingTalkApi.Apis.Card;
using DingTalkApi.Apis.Checkin;
using DingTalkApi.Apis.Contacts;
using DingTalkApi.Apis.CRM;
using DingTalkApi.Apis.DocumentFile;
using DingTalkApi.Apis.Ecosystem;
using DingTalkApi.Apis.EventSubscription;
using DingTalkApi.Apis.HRM;
using DingTalkApi.Apis.IndustryOpen;
using DingTalkApi.Apis.IM;
using DingTalkApi.Apis.OrgCulture;
using DingTalkApi.Apis.Report;
using DingTalkApi.Apis.ServiceWindow;
using DingTalkApi.Apis.SmartDevice;
using DingTalkApi.Apis.SmartFill;
using DingTalkApi.Apis.Teambition;
using DingTalkApi.Apis.Todo;
using DingTalkApi.Apis.Workbench;
using DingTalkApi.Apis.Workflow;
using DingTalkApi.Apis.Yida;
using DingTalkApi.Attributes;
using DingTalkApi.Options;
using WebApiClientCore;
using System.Text.Json;
using System.Reflection;

namespace DingTalkApi.Tests;

public class ServiceCollectionTests
{
    [Fact]
    public void AddDingTalk_ShouldRegisterServices()
    {
        var services = new ServiceCollection();
        var configuration = new ConfigurationBuilder().AddInMemoryCollection(new Dictionary<string, string?>
        {
            { "DingTalk:EnableLogging", "true" },
            { "DingTalk:Internal:ClientId", "test_id" },
            { "DingTalk:Internal:ClientSecret", "test_secret" }
        }).Build();

        services.AddDingTalk(configuration);
        var sp = services.BuildServiceProvider();

        // AccessTokenOptions is verified via ProviderNames.Internal
        var options = sp.GetRequiredService<IOptionsMonitor<DingTalkAccessTokenOptions>>().Get(ProviderNames.Internal);
        Assert.Equal("test_id", options.ClientId);
        Assert.Equal("test_secret", options.ClientSecret);

        var dingTalkOptions = sp.GetRequiredService<IOptions<DingTalkOptions>>().Value;
        Assert.True(dingTalkOptions.EnableLogging);

        // Check if APIs are registered
        Assert.NotNull(sp.GetService<IBadgeApi>());
        Assert.NotNull(sp.GetService<IVideoConferencesApi>());
        Assert.NotNull(sp.GetService<ILiveApi>());
        Assert.NotNull(sp.GetService<IMeetingRoomsApi>());
        Assert.NotNull(sp.GetService<IRobotApi>());
        Assert.NotNull(sp.GetService<ICorpConversationApi>());
        Assert.NotNull(sp.GetService<IChatApi>());
        Assert.NotNull(sp.GetService<ISceneGroupApi>());
        Assert.NotNull(sp.GetService<IInteractiveCardApi>());
        Assert.NotNull(sp.GetService<IInterconnectionsApi>());
        Assert.NotNull(sp.GetService<ICalendarApi>());
        Assert.NotNull(sp.GetService<ICardInstancesApi>());
        Assert.NotNull(sp.GetService<IUserManageApi>());
        Assert.NotNull(sp.GetService<ICooperateCorpsApi>());
        Assert.NotNull(sp.GetService<IUnionCooperateApi>());
        Assert.NotNull(sp.GetService<IWorkflowApi>());
        Assert.NotNull(sp.GetService<IOrgCultureApi>());
        Assert.NotNull(sp.GetService<IOrgCultureHealthApi>());
        Assert.NotNull(sp.GetService<IBlackboardApi>());
        Assert.NotNull(sp.GetService<IBlackboardV1Api>());
        Assert.NotNull(sp.GetService<ICrmApi>());
        Assert.NotNull(sp.GetService<ICrmTopApi>());
        Assert.NotNull(sp.GetService<IApplicationManagementApi>());
        Assert.NotNull(sp.GetService<ITodoApi>());
        Assert.NotNull(sp.GetService<IWorkbenchApi>());
        Assert.NotNull(sp.GetService<IYidaApi>());
        Assert.NotNull(sp.GetService<IDocumentFileApi>());
        Assert.NotNull(sp.GetService<IReportApi>());
        Assert.NotNull(sp.GetService<IServiceWindowApi>());
        Assert.NotNull(sp.GetService<IEventSubscriptionApi>());
        Assert.NotNull(sp.GetService<ISmartDeviceApi>());
        Assert.NotNull(sp.GetService<ISmartFillApi>());
        Assert.NotNull(sp.GetService<IHumanResourcesApi>());
        Assert.NotNull(sp.GetService<IHumanResourcesTopApi>());
        Assert.NotNull(sp.GetService<IIndustryOpenApi>());
        Assert.NotNull(sp.GetService<IIndustryOpenTopApi>());
        Assert.NotNull(sp.GetService<IEcosystemApi>());
        Assert.NotNull(sp.GetService<IEcosystemTopApi>());
        Assert.NotNull(sp.GetService<ICheckinApi>());
        Assert.NotNull(sp.GetService<ITeambitionProjectApi>());
        Assert.NotNull(sp.GetService<ITeambitionWorkspaceTopApi>());
    }

    [Fact]
    public void AddDingTalk_ShouldRejectNullArguments()
    {
        var services = new ServiceCollection();
        var configuration = new ConfigurationBuilder().Build();

        Assert.Throws<ArgumentNullException>(() => DingTalkServiceCollectionExtension.AddDingTalk(null!, configuration));
        Assert.Throws<ArgumentNullException>(() => services.AddDingTalk(null!));
    }

    [Fact]
    public void AddDingTalk_ShouldAllowMissingInternalConfiguration()
    {
        var services = new ServiceCollection();
        var configuration = new ConfigurationBuilder().Build();

        services.AddDingTalk(configuration);
        var sp = services.BuildServiceProvider();

        var options = sp.GetRequiredService<IOptionsMonitor<DingTalkAccessTokenOptions>>().Get(ProviderNames.Internal);
        Assert.Null(options.ClientId);
        Assert.Null(options.ClientSecret);
    }

    [Fact]
    public void AddDingTalk_ShouldConfigureSelectedProviderNames()
    {
        var services = new ServiceCollection();
        var configuration = new ConfigurationBuilder().AddInMemoryCollection(new Dictionary<string, string?>
        {
            { "DingTalk:Corp:SuiteKey", "suite_key" },
            { "DingTalk:Corp:SuiteSecret", "suite_secret" },
            { "DingTalk:Corp:AuthCorpId", "auth_corp_id" },
            { "DingTalk:Corp:SuiteTicket", "suite_ticket" },
            { "DingTalk:MicroApp:CropId", "corp_id" },
            { "DingTalk:MicroApp:SsoSecret", "sso_secret" }
        }).Build();

        services.AddDingTalk(configuration, ProviderNames.Corp, ProviderNames.MicroApp);
        var sp = services.BuildServiceProvider();

        var monitor = sp.GetRequiredService<IOptionsMonitor<DingTalkAccessTokenOptions>>();
        var corp = monitor.Get(ProviderNames.Corp);
        var microApp = monitor.Get(ProviderNames.MicroApp);

        Assert.Equal("suite_key", corp.SuiteKey);
        Assert.Equal("suite_secret", corp.SuiteSecret);
        Assert.Equal("auth_corp_id", corp.AuthCorpId);
        Assert.Equal("suite_ticket", corp.SuiteTicket);
        Assert.Equal("corp_id", microApp.CropId);
        Assert.Equal("sso_secret", microApp.SsoSecret);
    }

    [Fact]
    public void AddDingTalk_ShouldRejectUnsupportedProviderName()
    {
        var services = new ServiceCollection();
        var configuration = new ConfigurationBuilder().Build();

        Assert.Throws<ArgumentException>(() => services.AddDingTalk(configuration, "Unknown"));
    }

    [Fact]
    public void AddDingTalk_UserManageApi_ShouldHaveSnakeCase()
    {
        var services = new ServiceCollection();
        var configuration = new ConfigurationBuilder().Build();
        services.AddDingTalk(configuration);
        
        var sp = services.BuildServiceProvider();
        // HttpApiOptions is configured using the full name of the interface as the name of the option
        var apiOptions = sp.GetRequiredService<IOptionsMonitor<HttpApiOptions>>().Get(typeof(IUserManageApi).FullName);

        Assert.Equal(JsonNamingPolicy.SnakeCaseLower, apiOptions.JsonSerializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.SnakeCaseLower, apiOptions.JsonDeserializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.SnakeCaseLower, apiOptions.KeyValueSerializeOptions.PropertyNamingPolicy);
    }

    [Theory]
    [InlineData(null, false)]
    [InlineData("false", false)]
    [InlineData("true", true)]
    public void AddDingTalk_ShouldApplyEnableLoggingFromConfiguration(string? enableLoggingValue, bool expected)
    {
        var services = new ServiceCollection();
        var settings = new Dictionary<string, string?>();
        if (enableLoggingValue is not null)
        {
            settings["DingTalk:EnableLogging"] = enableLoggingValue;
        }

        var configuration = new ConfigurationBuilder().AddInMemoryCollection(settings).Build();
        services.AddDingTalk(configuration);

        var sp = services.BuildServiceProvider();
        var optionsMonitor = sp.GetRequiredService<IOptionsMonitor<HttpApiOptions>>();

        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IAccessTokenApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IBadgeApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IVideoConferencesApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(ILiveApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IMeetingRoomsApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IRobotApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(ICorpConversationApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IChatApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(ISceneGroupApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IInteractiveCardApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IInterconnectionsApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(ICalendarApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(ICardInstancesApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IUserManageApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(ICooperateCorpsApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IUnionCooperateApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IWorkflowApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IOrgCultureApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IOrgCultureHealthApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IBlackboardApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IBlackboardV1Api).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(ICrmApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(ICrmTopApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IApplicationManagementApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(ITodoApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IWorkbenchApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IYidaApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IDocumentFileApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IReportApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IServiceWindowApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IEventSubscriptionApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(ISmartDeviceApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(ISmartFillApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IHumanResourcesApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IHumanResourcesTopApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IIndustryOpenApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IIndustryOpenTopApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IEcosystemApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(IEcosystemTopApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(ICheckinApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(ITeambitionProjectApi).FullName), expected);
        AssertUseLoggingConfiguration(optionsMonitor.Get(typeof(ITeambitionWorkspaceTopApi).FullName), expected);

        var dingTalkOptions = sp.GetRequiredService<IOptions<DingTalkOptions>>().Value;
        Assert.Equal(expected, dingTalkOptions.EnableLogging);
    }

    [Fact]
    public void IDingTalkApi_ShouldDefineNon200LoggingFilter()
    {
        var filter = typeof(IDingTalkApi).GetCustomAttribute<Non200LoggingFilterAttribute>();
        Assert.NotNull(filter);
        Assert.True(filter!.LogRequest);
        Assert.True(filter.LogResponse);
    }

    [Fact]
    public void IAccessTokenApi_ShouldDefineNon200LoggingFilter()
    {
        var filter = typeof(IAccessTokenApi).GetCustomAttribute<Non200LoggingFilterAttribute>();
        Assert.NotNull(filter);
        Assert.True(filter!.LogRequest);
        Assert.True(filter.LogResponse);
    }

    private static void AssertUseLoggingConfiguration(HttpApiOptions options, bool expected)
    {
        Assert.Equal(expected, options.UseLogging);
    }
}
