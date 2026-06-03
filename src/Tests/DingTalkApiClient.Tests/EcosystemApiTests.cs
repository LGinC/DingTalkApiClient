using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Moq.Protected;
using DingTalkApiClient.Apis;
using DingTalkApiClient.Apis.Ecosystem;
using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.Ecosystem;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Tests;

public class EcosystemApiTests : TestBase
{
    private static readonly Type[] EcosystemApiTypes =
    [
        typeof(IEcosystemApi),
        typeof(IEcosystemTopApi),
    ];

    [Theory]
    [MemberData(nameof(EcosystemApiTypeData))]
    public void EcosystemApis_ShouldBeRegisteredAndUseExpectedTokenTransport(Type apiType)
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
    [MemberData(nameof(EcosystemApiMethodData))]
    public void EcosystemApiMethods_ShouldHaveHttpAttributeAndTokenProvider(Type apiType, MethodInfo method)
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
    [MemberData(nameof(EcosystemModelTypeData))]
    public void EcosystemModels_ShouldBeRegisteredInJsonSerializerContext(Type modelType)
    {
        Assert.NotNull(DingTalkJsonSerializerContext.Default.GetTypeInfo(modelType));
    }

    [Fact]
    public async Task PostV1CustomerServiceTicketsAsync_ShouldPostWithHeaderTokenAndCamelCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/customerService/tickets",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"ticketId":"ticket01"}""");

        var api = Provider.GetRequiredService<IEcosystemApi>();
        var response = await api.PostV1CustomerServiceTicketsAsync(
            new PostV1CustomerServiceTicketsRequest
            {
                SourceId = "source01",
                ForeignId = "foreign01",
                ForeignName = "客户",
                TemplateId = "template01",
                Title = "工单标题",
                Properties =
                [
                    new PostV1CustomerServiceTicketsRequestPropertiesItem
                    {
                        Name = "field01",
                        Value = "value01",
                    }
                ],
            },
            cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("ticket01", response.TicketId);
        Assert.NotNull(capturedRequest);
        Assert.True(capturedRequest!.Headers.Contains("x-acs-dingtalk-access-token"));
        Assert.DoesNotContain("access_token", capturedRequest.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"sourceId\":\"source01\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"foreignId\":\"foreign01\"", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task PostTopapiAiMtTranslateAsync_ShouldPostWithQueryTokenAndSnakeCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/ai/mt/translate",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"errcode":0,"result":"hello","request_id":"req01"}""");

        var api = Provider.GetRequiredService<IEcosystemTopApi>();
        var response = await api.PostTopapiAiMtTranslateAsync(
            new PostTopapiAiMtTranslateRequest
            {
                Query = "你好",
                SourceLanguage = "zh",
                TargetLanguage = "en",
            },
            "api_access_token",
            cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("hello", response.Result);
        Assert.NotNull(capturedRequest);
        Assert.Contains("access_token=mock_token", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"source_language\":\"zh\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"target_language\":\"en\"", capturedBody, StringComparison.Ordinal);
    }

    public static IEnumerable<object[]> EcosystemApiTypeData() => EcosystemApiTypes.Select(type => new object[] { type });

    public static IEnumerable<object[]> EcosystemApiMethodData() =>
        EcosystemApiTypes.SelectMany(apiType => apiType.GetMethods().Select(method => new object[] { apiType, method }));

    public static IEnumerable<object[]> EcosystemModelTypeData() =>
        typeof(PostV1CustomerServiceTicketsRequest).Assembly
            .GetTypes()
            .Where(type => type.IsClass && type.IsPublic && type.Namespace == "DingTalkApiClient.Models.Ecosystem")
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
