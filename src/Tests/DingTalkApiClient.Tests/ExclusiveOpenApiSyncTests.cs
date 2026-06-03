using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Moq.Protected;
using DingTalkApiClient.Apis;
using DingTalkApiClient.Apis.ExclusiveOpen;
using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.ExclusiveOpen;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Tests;

public class ExclusiveOpenApiSyncTests : TestBase
{
    private static readonly Type[] ExclusiveOpenApiTypes =
    [
        typeof(IExclusiveOpenApi),
        typeof(IExclusiveOpenServiceAccountApi),
    ];

    [Theory]
    [MemberData(nameof(ExclusiveOpenApiTypeData))]
    public void ExclusiveOpenApis_ShouldBeRegisteredAndUseExpectedTokenTransport(Type apiType)
    {
        var api = Provider.GetService(apiType);
        Assert.NotNull(api);

        var options = Provider.GetRequiredService<IOptionsMonitor<HttpApiOptions>>().Get(apiType.FullName);
        var expectedNamingPolicy = typeof(IDingTalkQueryTokenApi).IsAssignableFrom(apiType)
            ? JsonNamingPolicy.SnakeCaseLower
            : JsonNamingPolicy.CamelCase;
        Assert.Equal(expectedNamingPolicy, options.JsonSerializeOptions.PropertyNamingPolicy);
        Assert.Equal(expectedNamingPolicy, options.JsonDeserializeOptions.PropertyNamingPolicy);
        Assert.Equal(expectedNamingPolicy, options.KeyValueSerializeOptions.PropertyNamingPolicy);
    }

    [Theory]
    [MemberData(nameof(ExclusiveOpenApiMethodData))]
    public void ExclusiveOpenApiMethods_ShouldHaveHttpAttributeAndTokenProvider(Type apiType, MethodInfo method)
    {
        Assert.Contains(method, apiType.GetMethods());
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
    [MemberData(nameof(ExclusiveOpenModelTypeData))]
    public void ExclusiveOpenModels_ShouldBeRegisteredInJsonSerializerContext(Type modelType)
    {
        Assert.NotNull(DingTalkJsonSerializerContext.Default.GetTypeInfo(modelType));
    }

    [Fact]
    public async Task TrustedDevicesBatchAddAsync_ShouldPostV1WithHeaderTokenAndCamelCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/exclusive/trustedDevices/batchAdd",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"result":true}""");

        var api = Provider.GetRequiredService<IExclusiveOpenApi>();
        var response = await api.TrustedDevicesBatchAddAsync(new TrustedDevicesBatchAddRequest
        {
            StaffId = "user01",
            Platform = "Mac",
            MacAddressList = ["00-16-3E-00-00-01"]
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Result);
        Assert.NotNull(capturedRequest);
        Assert.True(capturedRequest!.Headers.Contains("x-acs-dingtalk-access-token"));
        Assert.DoesNotContain("access_token", capturedRequest.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"staffId\":\"user01\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"macAddressList\"", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task ServiceAccountAddAsync_ShouldPostTopApiWithQueryTokenAndSnakeCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/serviceaccount/add",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"errcode":0,"errmsg":"ok","unionid":"union01","request_id":"req01"}""");

        var api = Provider.GetRequiredService<IExclusiveOpenServiceAccountApi>();
        var response = await api.ServiceAccountAddAsync(new ServiceAccountAddRequest
        {
            Name = "服务号",
            AvatarMediaId = "media01",
            Brief = "brief",
            Desc = "desc",
            PreviewMediaId = "preview01"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal(0, response.Errcode);
        Assert.Equal("union01", response.UnionId);
        Assert.NotNull(capturedRequest);
        Assert.Contains("access_token=mock_token", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"avatar_media_id\":\"media01\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"preview_media_id\"", capturedBody, StringComparison.Ordinal);
    }

    public static IEnumerable<object[]> ExclusiveOpenApiTypeData() => ExclusiveOpenApiTypes.Select(type => new object[] { type });

    public static IEnumerable<object[]> ExclusiveOpenApiMethodData() =>
        ExclusiveOpenApiTypes.SelectMany(apiType => apiType.GetMethods().Select(method => new object[] { apiType, method }));

    public static IEnumerable<object[]> ExclusiveOpenModelTypeData() =>
        typeof(TrustedDevicesBatchAddRequest).Assembly
            .GetTypes()
            .Where(type => type.IsClass && type.IsPublic && type.Namespace == "DingTalkApiClient.Models.ExclusiveOpen")
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
