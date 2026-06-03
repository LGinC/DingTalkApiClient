using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Moq.Protected;
using DingTalkApiClient.Apis.Yida;
using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.Yida;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Tests;

public class YidaApiTests : TestBase
{
    private readonly IYidaApi _api;

    public YidaApiTests()
    {
        _api = Provider.GetRequiredService<IYidaApi>();
    }

    [Fact]
    public void YidaApi_ShouldBeRegisteredAndUseCamelCaseOptions()
    {
        var api = Provider.GetService<IYidaApi>();
        Assert.NotNull(api);

        var options = Provider.GetRequiredService<IOptionsMonitor<HttpApiOptions>>().Get(typeof(IYidaApi).FullName);
        Assert.Equal(JsonNamingPolicy.CamelCase, options.JsonSerializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.CamelCase, options.JsonDeserializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.CamelCase, options.KeyValueSerializeOptions.PropertyNamingPolicy);
    }

    [Theory]
    [MemberData(nameof(YidaApiMethodData))]
    public void YidaApiMethods_ShouldHaveHttpAttributeAndTokenProvider(MethodInfo method)
    {
        Assert.NotNull(GetHttpMethodAttribute(method));

        var parameters = method.GetParameters();
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
    [MemberData(nameof(YidaModelTypeData))]
    public void YidaModels_ShouldBeRegisteredInJsonSerializerContext(Type modelType)
    {
        Assert.NotNull(DingTalkJsonSerializerContext.Default.GetTypeInfo(modelType));
    }

    [Fact]
    public async Task StartProcessInstanceAsync_ShouldPostV1WithHeaderTokenAndCamelCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/yida/processes/instances/start",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"result":"proc-inst-01"}""");

        var response = await _api.StartProcessInstanceAsync(new YidaStartProcessInstanceRequest
        {
            AppType = "APP-001",
            SystemToken = "sys-token",
            UserId = "user01",
            Language = "zh_CN",
            FormUuid = "FORM-001",
            FormDataJson = """{"TextField":"hello"}""",
            ProcessCode = "PROC-001",
            DepartmentId = "1"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("proc-inst-01", response.Result);
        Assert.NotNull(capturedRequest);
        Assert.True(capturedRequest!.Headers.Contains("x-acs-dingtalk-access-token"));
        Assert.DoesNotContain("access_token", capturedRequest.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"appType\":\"APP-001\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"formDataJson\"", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task SearchFormInstancesAsync_ShouldDeserializeDynamicFormData()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/yida/forms/instances/search",
            _ => { },
            """{"currentPage":1,"totalCount":1,"data":[{"formInstanceId":"FINST-01","formUuid":"FORM-001","originator":{"userId":"user01","userName":{"nameInChinese":"张三"}},"formData":{"TextField":"hello"},"title":"标题"}]}""");

        var response = await _api.SearchFormInstancesAsync(new YidaSearchFormInstancesRequest
        {
            AppType = "APP-001",
            SystemToken = "sys-token",
            UserId = "user01",
            Language = "zh_CN",
            FormUuid = "FORM-001",
            SearchFieldJson = "{}",
            OriginatorId = "user01",
            CreateFromTimeGMT = "2026-01-01",
            CreateToTimeGMT = "2026-01-31",
            ModifiedFromTimeGMT = "2026-01-01",
            ModifiedToTimeGMT = "2026-01-31",
            DynamicOrder = "{}"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal(1, response.TotalCount);
        Assert.Single(response.Data);
        Assert.Equal("FINST-01", response.Data[0].FormInstanceId);
        Assert.Equal("张三", response.Data[0].Originator!.UserName!.NameInChinese);
        Assert.True(response.Data[0].FormData.ContainsKey("TextField"));
    }

    [Fact]
    public async Task GetApplicationsAsync_ShouldSendQueryParametersAndDeserializeList()
    {
        HttpRequestMessage? capturedRequest = null;

        SetupResponse(
            req => req.Method == HttpMethod.Get && req.RequestUri!.AbsolutePath == "/v1.0/yida/organizations/applications",
            req => capturedRequest = req,
            """{"pageNumber":1,"totalCount":1,"data":[{"appType":"APP-001","name":"宜搭应用","applicationStatus":"ONLINE"}]}""");

        var response = await _api.GetApplicationsAsync("corp01", "user01", "third-token", pageNumber: "1", pageSize: "20", cancellationToken: TestContext.Current.CancellationToken);

        Assert.Single(response.Data);
        Assert.Equal("APP-001", response.Data[0].AppType);
        Assert.NotNull(capturedRequest);
        Assert.Contains("corpId=corp01", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("userId=user01", capturedRequest.RequestUri.Query, StringComparison.Ordinal);
        Assert.Contains("token=third-token", capturedRequest.RequestUri.Query, StringComparison.Ordinal);
        Assert.True(capturedRequest.Headers.Contains("x-acs-dingtalk-access-token"));
    }

    public static IEnumerable<object[]> YidaApiMethodData() =>
        typeof(IYidaApi).GetMethods().Select(method => new object[] { method });

    public static IEnumerable<object[]> YidaModelTypeData() =>
        typeof(YidaStartProcessInstanceRequest).Assembly
            .GetTypes()
            .Where(type => type.IsClass && type.IsPublic && type.Namespace == "DingTalkApiClient.Models.Yida")
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
                StatusCode = System.Net.HttpStatusCode.OK,
                Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json")
            }));
    }

    private static Attribute? GetHttpMethodAttribute(MethodInfo method) =>
        method.GetCustomAttributes()
            .FirstOrDefault(attribute => attribute.GetType().Namespace == typeof(HttpGetAttribute).Namespace &&
                                         attribute.GetType().Name.StartsWith("Http", StringComparison.Ordinal));
}
