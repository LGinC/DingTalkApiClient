using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Moq.Protected;
using DingTalkApiClient.Apis;
using DingTalkApiClient.Apis.OrgCulture;
using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.OrgCulture;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Tests;

public class OrgCultureApiTests : TestBase
{
    private static readonly Type[] OrgCultureApiTypes =
    [
        typeof(IOrgCultureApi),
        typeof(IOrgCultureHealthApi),
    ];

    private readonly IOrgCultureApi _api;
    private readonly IOrgCultureHealthApi _healthApi;

    public OrgCultureApiTests()
    {
        _api = Provider.GetRequiredService<IOrgCultureApi>();
        _healthApi = Provider.GetRequiredService<IOrgCultureHealthApi>();
    }

    [Theory]
    [MemberData(nameof(OrgCultureApiTypeData))]
    public void OrgCultureApis_ShouldBeRegisteredAndUseExpectedOptions(Type apiType)
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
    [MemberData(nameof(OrgCultureApiMethodData))]
    public void OrgCultureApiMethods_ShouldHaveHttpAttributeAndTokenProvider(Type apiType, MethodInfo method)
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
    [MemberData(nameof(OrgCultureModelTypeData))]
    public void OrgCultureModels_ShouldBeRegisteredInJsonSerializerContext(Type modelType)
    {
        Assert.NotNull(DingTalkJsonSerializerContext.Default.GetTypeInfo(modelType));
    }

    [Fact]
    public async Task GrantHonorAsync_ShouldPostV1WithHeaderTokenAndCamelCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/orgCulture/honors/honor01/grant",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"errcode":0,"errmsg":"ok"}""");

        var response = await _api.GrantHonorAsync("honor01", new GrantHonorRequest
        {
            SenderUserId = "u1",
            GrantReason = "表现优秀",
            GranterName = "主管",
            ReceiverUserIds = ["u2"],
            OpenConversationIds = ["cid01"]
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.IsSuccess);
        Assert.NotNull(capturedRequest);
        Assert.True(capturedRequest!.Headers.Contains("x-acs-dingtalk-access-token"));
        Assert.DoesNotContain("access_token", capturedRequest.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"senderUserId\":\"u1\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"receiverUserIds\"", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task QueryUserHonorsAsync_ShouldSendPathAndQueryParameters()
    {
        HttpRequestMessage? capturedRequest = null;

        SetupResponse(
            req => req.Method == HttpMethod.Get && req.RequestUri!.AbsolutePath == "/v1.0/orgCulture/honors/users/user01",
            req => capturedRequest = req,
            """{"success":true,"result":{"nextToken":"next","honors":[{"honorId":"honor01","honorName":"创造之星","honorDesc":"创新","expirationTime":1710000000000,"grantHistory":[{"senderUserid":"u1","grantTime":1700000000000}]}]}}""");

        var response = await _api.QueryUserHonorsAsync("user01", "0", "20", cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
        Assert.Equal("next", response.Result.NextToken);
        Assert.Equal("创造之星", Assert.Single(response.Result.Honors).HonorName);
        Assert.Equal("u1", Assert.Single(response.Result.Honors[0].GrantHistory).SenderUserid);
        Assert.NotNull(capturedRequest);
        Assert.Contains("nextToken=0", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("maxResults=20", capturedRequest.RequestUri.Query, StringComparison.Ordinal);
        Assert.True(capturedRequest.Headers.Contains("x-acs-dingtalk-access-token"));
    }

    [Fact]
    public async Task CreateHonorTemplateAsync_ShouldDeserializeHonorId()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/orgCulture/honors/templates",
            _ => { },
            """{"success":true,"result":{"honorId":"honor-template-01"}}""");

        var response = await _api.CreateHonorTemplateAsync(new CreateHonorTemplateRequest
        {
            UserId = "u1",
            MedalName = "创造之星",
            MedalDesc = "创新贡献",
            MedalMediaId = "media01",
            AvatarFrameMediaId = "media02",
            DefaultBgColor = "#FFFBB4"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
        Assert.Equal("honor-template-01", response.Result.HonorId);
    }

    [Fact]
    public async Task AddPediaWordAsync_ShouldSerializeNestedWordObjects()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/pedia/words",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"uuid":1001,"success":true}""");

        var response = await _api.AddPediaWordAsync(new AddPediaWordRequest
        {
            WordName = "测试词条",
            WordAlias = ["测试"],
            RelatedDoc = [new PediaRelatedDoc { Name = "文档", Type = "adoc", Link = "https://example.com/doc" }],
            RelatedLink = [new PediaRelatedLink { Name = "链接", Link = "https://example.com" }],
            WordParaphrase = "释义",
            PicList = [new PediaPicture { MediaIdUrl = "https://example.com/pic.png" }],
            UserId = "u1",
            ContactList = [new PediaContact { UserId = "u2", NickName = "同事" }]
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
        Assert.Equal(1001, response.Uuid);
        Assert.NotNull(capturedRequest);
        Assert.True(capturedRequest!.Headers.Contains("x-acs-dingtalk-access-token"));
        Assert.Contains("\"wordName\":\"测试词条\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"relatedDoc\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"mediaIdUrl\"", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task SearchPediaWordsAsync_ShouldDeserializeWordDetail()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/pedia/words/search",
            _ => { },
            """{"success":true,"data":{"wordName":"测试词条","uuid":1001,"gmtCreate":1700000000000,"gmtModify":1700000001000,"wordAlias":["测试"],"highLightWordAlias":["测试"],"relatedDoc":[{"name":"文档","type":"adoc","link":"https://example.com/doc"}],"relatedLink":[{"name":"链接","link":"https://example.com"}],"creatorName":"创建者","updaterName":"更新人","approveName":"审核人","wordParaphrase":"<p>释义</p>","simpleWordParaphrase":"释义","contacts":["同事"],"tagsList":["分类"],"appLink":[{"appName":"应用","pcLink":"https://pc","phoneLink":"https://phone","iconLink":"https://icon"}],"imHighLight":true,"simHighLight":false,"picList":[{"mediaIdUrl":"https://pic"}],"contactList":[{"userId":"u2","nickName":"同事","avatarMediaId":"avatar"}],"userId":"u1","parentUuid":0}}""");

        var response = await _api.SearchPediaWordsAsync(new SearchPediaWordsRequest
        {
            WordName = "测试",
            UserId = "u1",
            Status = "0",
            PageNumber = 1,
            PageSize = 20
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
        Assert.Equal("测试词条", response.Data.WordName);
        Assert.Equal("adoc", Assert.Single(response.Data.RelatedDoc).Type);
        Assert.Equal("应用", Assert.Single(response.Data.AppLink).AppName);
        Assert.Equal("u2", Assert.Single(response.Data.ContactList).UserId);
    }

    [Fact]
    public async Task GetUserStepStatusAsync_ShouldPostTopApiWithQueryTokenAndSnakeCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/health/stepinfo/getuserstatus",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"errcode":0,"status":true,"request_id":"req01"}""");

        var response = await _healthApi.GetUserStepStatusAsync(new GetUserStepStatusRequest { Userid = "user01" }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal(0, response.Errcode);
        Assert.True(response.Status);
        Assert.Equal("req01", response.RequestId);
        Assert.NotNull(capturedRequest);
        Assert.Contains("access_token=mock_token", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.DoesNotContain("x-acs-dingtalk-access-token", string.Join(",", capturedRequest.Headers.Select(header => header.Key)), StringComparison.Ordinal);
        Assert.Contains("\"userid\":\"user01\"", capturedBody, StringComparison.Ordinal);
    }

    public static IEnumerable<object[]> OrgCultureApiTypeData() => OrgCultureApiTypes.Select(type => new object[] { type });

    public static IEnumerable<object[]> OrgCultureApiMethodData() =>
        OrgCultureApiTypes.SelectMany(apiType => apiType.GetMethods().Select(method => new object[] { apiType, method }));

    public static IEnumerable<object[]> OrgCultureModelTypeData() =>
        typeof(GrantHonorRequest).Assembly
            .GetTypes()
            .Where(type => type.IsClass && type.IsPublic && type.Namespace == "DingTalkApiClient.Models.OrgCulture")
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
