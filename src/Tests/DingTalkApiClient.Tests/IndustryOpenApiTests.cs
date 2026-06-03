using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Moq.Protected;
using DingTalkApiClient.Apis.IndustryOpen;
using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.IndustryOpen;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Tests;

public class IndustryOpenApiTests : TestBase
{
    private readonly IIndustryOpenApi _api;
    private readonly IIndustryOpenTopApi _topApi;

    public IndustryOpenApiTests()
    {
        _api = Provider.GetRequiredService<IIndustryOpenApi>();
        _topApi = Provider.GetRequiredService<IIndustryOpenTopApi>();
    }

    [Fact]
    public void IndustryOpenApis_ShouldBeRegisteredAndUseExpectedOptions()
    {
        Assert.NotNull(Provider.GetService<IIndustryOpenApi>());
        Assert.NotNull(Provider.GetService<IIndustryOpenTopApi>());

        var options = Provider.GetRequiredService<IOptionsMonitor<HttpApiOptions>>();
        var apiOptions = options.Get(typeof(IIndustryOpenApi).FullName);
        var topApiOptions = options.Get(typeof(IIndustryOpenTopApi).FullName);

        Assert.Equal(JsonNamingPolicy.CamelCase, apiOptions.JsonSerializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.CamelCase, apiOptions.JsonDeserializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.CamelCase, apiOptions.KeyValueSerializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.SnakeCaseLower, topApiOptions.JsonSerializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.SnakeCaseLower, topApiOptions.JsonDeserializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.SnakeCaseLower, topApiOptions.KeyValueSerializeOptions.PropertyNamingPolicy);
    }

    [Theory]
    [MemberData(nameof(IndustryOpenApiMethodData))]
    public void IndustryOpenApiMethods_ShouldHaveHttpAttributeAndTokenProvider(MethodInfo method)
    {
        Assert.NotNull(GetHttpMethodAttribute(method));

        var parameters = method.GetParameters();
        var tokenParameter = parameters.SingleOrDefault(parameter =>
            parameter.GetCustomAttribute<DingTalkTokenProviderAttribute>() is not null);
        Assert.NotNull(tokenParameter);
        Assert.Equal(ProviderNames.Internal, tokenParameter!.DefaultValue);
        Assert.Equal(typeof(CancellationToken), parameters.Last().ParameterType);
        Assert.True(method.ReturnType == typeof(Task) ||
                    method.ReturnType.IsGenericType &&
                    method.ReturnType.GetGenericTypeDefinition() == typeof(ITask<>));
    }

    [Theory]
    [MemberData(nameof(IndustryOpenModelTypeData))]
    public void IndustryOpenModels_ShouldBeRegisteredInJsonSerializerContext(Type modelType)
    {
        Assert.NotNull(DingTalkJsonSerializerContext.Default.GetTypeInfo(modelType));
    }

    [Fact]
    public async Task ResidentPointsRulesAsync_ShouldGetWithHeaderToken()
    {
        HttpRequestMessage? capturedRequest = null;

        SetupResponse(
            req => req.Method == HttpMethod.Get && req.RequestUri!.AbsolutePath == "/v1.0/resident/points/rules",
            req => capturedRequest = req,
            """{"pointRuleList":[{"score":10,"dayLimitTimes":3,"status":1,"ruleCode":"rule01","ruleName":"签到","extension":"{}","groupId":5}]}""");

        var response = await _api.ListResidentPointRulesAsync("false", cancellationToken: TestContext.Current.CancellationToken);

        var rule = Assert.Single(response.PointRuleList);
        Assert.Equal("rule01", rule.RuleCode);
        Assert.Equal(10, rule.Score);
        Assert.NotNull(capturedRequest);
        Assert.True(capturedRequest!.Headers.Contains("x-acs-dingtalk-access-token"));
        Assert.DoesNotContain("access_token", capturedRequest.RequestUri!.Query, StringComparison.Ordinal);
    }

    [Fact]
    public async Task EduCertGetAsync_ShouldPostTopApiWithQueryTokenAndSnakeCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/edu/cert/get",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"errcode":0,"errmsg":"ok","success":true,"result":{"current_cert_level":2,"cert_datas":[{"cert_status":3,"can_cert":true,"cert_level":2}],"practical_task_data":[{"finish":true,"task_code":"sendImMsg"}]}}""");

        var response = await _topApi.GetEduCertAsync(new EduCertGetPostRequest
        {
            Userid = "user01"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal(0, response.ErrCode);
        Assert.True(response.Success);
        Assert.Equal(2, response.Result!.CurrentCertLevel);
        Assert.True(Assert.Single(response.Result.CertDatas).CanCert);
        Assert.NotNull(capturedRequest);
        Assert.Contains("access_token=mock_token", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"userid\":\"user01\"", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task ServiceGroupNormalGroupsUpgradeAsync_ShouldHandleEmptyResponse()
    {
        HttpRequestMessage? capturedRequest = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/serviceGroup/normalGroups/upgrade",
            req => capturedRequest = req,
            "");

        await _api.UpgradeNormalGroupAsync(new ServiceGroupNormalGroupsUpgradePostRequest
        {
            OpenConversationId = "cid01"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.NotNull(capturedRequest);
        Assert.True(capturedRequest!.Headers.Contains("x-acs-dingtalk-access-token"));
    }

    public static IEnumerable<object[]> IndustryOpenApiMethodData() =>
        typeof(IIndustryOpenApi).GetMethods()
            .Concat(typeof(IIndustryOpenTopApi).GetMethods())
            .Select(method => new object[] { method });

    public static IEnumerable<object[]> IndustryOpenModelTypeData() =>
        typeof(EduCertGetPostRequest).Assembly
            .GetTypes()
            .Where(type => type.IsPublic && type.Namespace == "DingTalkApiClient.Models.IndustryOpen" && !type.IsGenericType)
            .Select(type => new object[] { type });

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
                StatusCode = string.IsNullOrEmpty(json) ? HttpStatusCode.NoContent : HttpStatusCode.OK,
                Content = string.IsNullOrEmpty(json) ? null : new StringContent(json, System.Text.Encoding.UTF8, "application/json")
            }));
    }

    private static Attribute? GetHttpMethodAttribute(MethodInfo method) =>
        method.GetCustomAttributes()
            .FirstOrDefault(attribute => attribute.GetType().Namespace == typeof(HttpGetAttribute).Namespace &&
                                         attribute.GetType().Name.StartsWith("Http", StringComparison.Ordinal));
}
