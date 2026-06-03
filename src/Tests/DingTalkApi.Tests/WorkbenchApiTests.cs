using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Moq.Protected;
using DingTalkApi.Apis.Workbench;
using DingTalkApi.Attributes;
using DingTalkApi.Models;
using DingTalkApi.Models.Workbench;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Tests;

public class WorkbenchApiTests : TestBase
{
    private readonly IWorkbenchApi _api;

    public WorkbenchApiTests()
    {
        _api = Provider.GetRequiredService<IWorkbenchApi>();
    }

    [Fact]
    public void WorkbenchApi_ShouldBeRegisteredAndUseCamelCaseOptions()
    {
        Assert.NotNull(Provider.GetService<IWorkbenchApi>());

        var options = Provider.GetRequiredService<IOptionsMonitor<HttpApiOptions>>().Get(typeof(IWorkbenchApi).FullName);
        Assert.Equal(JsonNamingPolicy.CamelCase, options.JsonSerializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.CamelCase, options.JsonDeserializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.CamelCase, options.KeyValueSerializeOptions.PropertyNamingPolicy);
    }

    [Fact]
    public void WorkbenchApiMethods_ShouldHaveHttpAttributeAndTokenProvider()
    {
        var method = typeof(IWorkbenchApi).GetMethod(nameof(IWorkbenchApi.BatchAddRecentUsedAppsAsync));
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
    [InlineData(typeof(BatchAddRecentUsedAppsRequest))]
    [InlineData(typeof(RecentUsedAppDetail))]
    [InlineData(typeof(DingTalkResult<bool>))]
    public void WorkbenchModels_ShouldBeRegisteredInJsonSerializerContext(Type modelType)
    {
        Assert.NotNull(DingTalkJsonSerializerContext.Default.GetTypeInfo(modelType));
    }

    [Fact]
    public async Task BatchAddRecentUsedAppsAsync_ShouldPostV1WithHeaderTokenAndCamelCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/workbench/components/recentUsed/batch",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"errcode":0,"errmsg":"ok","result":true,"request_id":"req01"}""");

        var response = await _api.BatchAddRecentUsedAppsAsync(
            new BatchAddRecentUsedAppsRequest
            {
                CorpId = "dingcorp",
                UserId = "user01",
                UsedAppDetailList = [new RecentUsedAppDetail { AgentId = "agent01" }]
            },
            cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(response);
        Assert.Equal(0, response.ErrCode);
        Assert.Equal("ok", response.ErrMsg);
        Assert.True(response.Result);
        Assert.Equal("req01", response.RequestId);
        Assert.NotNull(capturedRequest);
        Assert.True(capturedRequest!.Headers.Contains("x-acs-dingtalk-access-token"));
        Assert.DoesNotContain("access_token", capturedRequest.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"corpId\":\"dingcorp\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"usedAppDetailList\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"agentId\":\"agent01\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"userId\":\"user01\"", capturedBody, StringComparison.Ordinal);
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
