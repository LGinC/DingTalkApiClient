using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Moq.Protected;
using DingTalkApiClient.Apis.ApplicationManagement;
using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models;
using DingTalkApiClient.Models.ApplicationManagement;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Tests;

public class ApplicationManagementApiTests : TestBase
{
    private readonly IApplicationManagementApi _api;

    public ApplicationManagementApiTests()
    {
        _api = Provider.GetRequiredService<IApplicationManagementApi>();
    }

    [Fact]
    public void ApplicationManagementApi_ShouldBeRegisteredAndUseCamelCaseOptions()
    {
        Assert.NotNull(Provider.GetService<IApplicationManagementApi>());

        var options = Provider.GetRequiredService<IOptionsMonitor<HttpApiOptions>>().Get(typeof(IApplicationManagementApi).FullName);
        Assert.Equal(JsonNamingPolicy.CamelCase, options.JsonSerializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.CamelCase, options.JsonDeserializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.CamelCase, options.KeyValueSerializeOptions.PropertyNamingPolicy);
    }

    [Theory]
    [InlineData(nameof(IApplicationManagementApi.CreateInnerAppAsync))]
    [InlineData(nameof(IApplicationManagementApi.UpdateInnerAppAsync))]
    [InlineData(nameof(IApplicationManagementApi.DeleteInnerAppAsync))]
    [InlineData(nameof(IApplicationManagementApi.ListAllAppsAsync))]
    [InlineData(nameof(IApplicationManagementApi.PublishInnerMiniAppVersionAsync))]
    [InlineData(nameof(IApplicationManagementApi.RollbackInnerMiniAppVersionAsync))]
    [InlineData(nameof(IApplicationManagementApi.ListAllInnerAppsAsync))]
    [InlineData(nameof(IApplicationManagementApi.ListUserVisibleAppsAsync))]
    [InlineData(nameof(IApplicationManagementApi.ListInnerMiniAppVersionsAsync))]
    [InlineData(nameof(IApplicationManagementApi.ListInnerMiniAppHistoryVersionsAsync))]
    [InlineData(nameof(IApplicationManagementApi.SetInnerAppScopeAsync))]
    [InlineData(nameof(IApplicationManagementApi.GetInnerAppScopeAsync))]
    public void ApplicationManagementApiMethods_ShouldHaveHttpAttributeAndTokenProvider(string methodName)
    {
        var method = typeof(IApplicationManagementApi).GetMethod(methodName);
        Assert.NotNull(method);
        Assert.NotNull(GetHttpMethodAttribute(method!));

        var parameters = method!.GetParameters();
        var tokenParameter = parameters.SingleOrDefault(parameter =>
            parameter.GetCustomAttribute<DingTalkTokenProviderAttribute>() is not null);
        Assert.NotNull(tokenParameter);
        Assert.Equal(typeof(string), tokenParameter!.ParameterType);
        Assert.Equal(ProviderNames.Internal, tokenParameter.DefaultValue);
        Assert.Equal(typeof(CancellationToken), parameters.Last().ParameterType);
        Assert.True(method.ReturnType.IsGenericType);
        Assert.Equal(typeof(ITask<>), method.ReturnType.GetGenericTypeDefinition());
    }

    [Theory]
    [InlineData(typeof(CreateInnerAppRequest))]
    [InlineData(typeof(UpdateInnerAppRequest))]
    [InlineData(typeof(PublishInnerMiniAppVersionRequest))]
    [InlineData(typeof(RollbackInnerMiniAppVersionRequest))]
    [InlineData(typeof(SetInnerAppScopeRequest))]
    [InlineData(typeof(CreateInnerAppResponse))]
    [InlineData(typeof(ApplicationListResponse))]
    [InlineData(typeof(ApplicationInfo))]
    [InlineData(typeof(List<ApplicationInfo>))]
    [InlineData(typeof(InnerMiniAppVersionListResponse))]
    [InlineData(typeof(InnerMiniAppHistoryVersionListResponse))]
    [InlineData(typeof(InnerMiniAppVersionInfo))]
    [InlineData(typeof(List<InnerMiniAppVersionInfo>))]
    [InlineData(typeof(InnerAppScope))]
    [InlineData(typeof(DingTalkResult<InnerAppScope>))]
    [InlineData(typeof(DingTalkResult<bool>))]
    public void ApplicationManagementModels_ShouldBeRegisteredInJsonSerializerContext(Type modelType)
    {
        Assert.NotNull(DingTalkJsonSerializerContext.Default.GetTypeInfo(modelType));
    }

    [Fact]
    public async Task CreateInnerAppAsync_ShouldPostV1WithHeaderTokenAndCamelCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/microApp/apps",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"agentId":111,"appKey":"dingkey","appSecret":"secret"}""");

        var response = await _api.CreateInnerAppAsync(
            new CreateInnerAppRequest
            {
                OpUnionId = "union01",
                Name = "测试应用",
                Desc = "应用描述",
                IpWhiteList = ["127.0.0.1"],
                ScopeType = "BASE",
                DevelopType = 0
            },
            cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal(111, response.AgentId);
        Assert.Equal("dingkey", response.AppKey);
        Assert.NotNull(capturedRequest);
        Assert.True(capturedRequest!.Headers.Contains("x-acs-dingtalk-access-token"));
        Assert.DoesNotContain("access_token", capturedRequest.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"opUnionId\":\"union01\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"ipWhiteList\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"developType\":0", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task DeleteInnerAppAsync_ShouldSendQueryParameters()
    {
        HttpRequestMessage? capturedRequest = null;

        SetupResponse(
            req => req.Method == HttpMethod.Delete && req.RequestUri!.AbsolutePath == "/v1.0/microApp/apps/111",
            req => capturedRequest = req,
            """{"errcode":0,"errmsg":"ok","result":true}""");

        var response = await _api.DeleteInnerAppAsync("111", "union01", "corp01", cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Result);
        Assert.NotNull(capturedRequest);
        Assert.Contains("opUnionId=union01", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("ecologicalCorpId=corp01", capturedRequest.RequestUri.Query, StringComparison.Ordinal);
    }

    [Fact]
    public async Task ListAllAppsAsync_ShouldDeserializeAppList()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Get && req.RequestUri!.AbsolutePath == "/v1.0/microApp/allApps",
            _ => { },
            """{"appList":[{"agentId":111,"name":"应用","desc":"描述","icon":"icon","homepageLink":"https://m","pcHomepageLink":"https://pc","ompLink":"https://admin","appId":0,"appStatus":1,"developType":0}]}""");

        var response = await _api.ListAllAppsAsync(cancellationToken: TestContext.Current.CancellationToken);

        var app = Assert.Single(response.AppList);
        Assert.Equal(111, app.AgentId);
        Assert.Equal("应用", app.Name);
        Assert.Equal("https://pc", app.PcHomepageLink);
        Assert.Equal(1, app.AppStatus);
    }

    [Fact]
    public async Task ListInnerMiniAppHistoryVersionsAsync_ShouldSendPagingQueryAndDeserializeVersions()
    {
        HttpRequestMessage? capturedRequest = null;

        SetupResponse(
            req => req.Method == HttpMethod.Get && req.RequestUri!.AbsolutePath == "/v1.0/microApp/innerMiniApps/111/historyVersions",
            req => capturedRequest = req,
            """{"totalCount":1,"miniAppVersionList":[{"appVersionId":1001,"miniAppId":"mini01","appVersion":"1.0.0","appVersionType":2,"miniAppOnPc":true,"createTime":"2026-01-01 10:00:00","modifyTime":"2026-01-02 10:00:00"}]}""");

        var response = await _api.ListInnerMiniAppHistoryVersionsAsync("111", "1", "20", cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal(1, response.TotalCount);
        Assert.Equal("1.0.0", Assert.Single(response.MiniAppVersionList).AppVersion);
        Assert.NotNull(capturedRequest);
        Assert.Contains("pageNumber=1", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("pageSize=20", capturedRequest.RequestUri.Query, StringComparison.Ordinal);
    }

    [Fact]
    public async Task GetInnerAppScopeAsync_ShouldDeserializeScopeResult()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Get && req.RequestUri!.AbsolutePath == "/v1.0/microApp/apps/111/scopes",
            _ => { },
            """{"errcode":0,"errmsg":"ok","result":{"userIds":["u1"],"deptIds":[1],"roleIds":[2],"onlyAdminVisible":false}}""");

        var response = await _api.GetInnerAppScopeAsync("111", cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal(0, response.ErrCode);
        Assert.Equal("u1", Assert.Single(response.Result!.UserIds));
        Assert.Equal(1, Assert.Single(response.Result.DeptIds));
        Assert.False(response.Result.OnlyAdminVisible);
    }

    private void SetupResponse(Expression<Func<HttpRequestMessage, bool>> requestMatcher, Action<HttpRequestMessage> capture, string json)
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is(requestMatcher),
                ItExpr.IsAny<CancellationToken>())
            .Callback((HttpRequestMessage req, CancellationToken _) => capture(req))
            .Returns(() => Task.FromResult(new HttpResponseMessage
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json")
            }));
    }

    private static Attribute? GetHttpMethodAttribute(MethodInfo method) =>
        method.GetCustomAttributes()
            .FirstOrDefault(attribute => attribute.GetType().Namespace == typeof(HttpGetAttribute).Namespace &&
                                         attribute.GetType().Name.StartsWith("Http", StringComparison.Ordinal));
}
