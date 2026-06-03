using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Moq.Protected;
using DingTalkApiClient.Apis.CRM;
using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.CRM;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Tests;

public class CrmApiTests : TestBase
{
    private static readonly Type[] CrmApiTypes =
    [
        typeof(ICrmApi),
        typeof(ICrmTopApi),
    ];

    private readonly ICrmApi _api;
    private readonly ICrmTopApi _topApi;

    public CrmApiTests()
    {
        _api = Provider.GetRequiredService<ICrmApi>();
        _topApi = Provider.GetRequiredService<ICrmTopApi>();
    }

    [Theory]
    [MemberData(nameof(CrmApiTypeData))]
    public void CrmApis_ShouldBeRegisteredAndUseExpectedOptions(Type apiType)
    {
        Assert.NotNull(Provider.GetService(apiType));

        var options = Provider.GetRequiredService<IOptionsMonitor<HttpApiOptions>>().Get(apiType.FullName);
        var expectedPolicy = apiType == typeof(ICrmTopApi) ? JsonNamingPolicy.SnakeCaseLower : JsonNamingPolicy.CamelCase;
        Assert.Equal(expectedPolicy, options.JsonSerializeOptions.PropertyNamingPolicy);
        Assert.Equal(expectedPolicy, options.JsonDeserializeOptions.PropertyNamingPolicy);
        Assert.Equal(expectedPolicy, options.KeyValueSerializeOptions.PropertyNamingPolicy);
    }

    [Theory]
    [MemberData(nameof(CrmApiMethodData))]
    public void CrmApiMethods_ShouldHaveHttpAttributeAndTokenProvider(Type apiType, MethodInfo method)
    {
        Assert.Contains(method, apiType.GetMethods());
        Assert.NotNull(GetHttpMethodAttribute(method));

        var parameters = method.GetParameters();
        var tokenParameter = parameters.SingleOrDefault(parameter =>
            parameter.GetCustomAttribute<DingTalkTokenProviderAttribute>() is not null);
        Assert.NotNull(tokenParameter);
        Assert.Equal(ProviderNames.Internal, tokenParameter!.DefaultValue);
        Assert.Equal(typeof(CancellationToken), parameters.Last().ParameterType);
        Assert.True(method.ReturnType.IsGenericType);
        Assert.Equal(typeof(ITask<>), method.ReturnType.GetGenericTypeDefinition());
    }

    [Theory]
    [MemberData(nameof(CrmModelTypeData))]
    public void CrmModels_ShouldBeRegisteredInJsonSerializerContext(Type modelType)
    {
        Assert.NotNull(DingTalkJsonSerializerContext.Default.GetTypeInfo(modelType));
    }

    [Fact]
    public async Task GetPersonalCustomerObjectMetaAsync_ShouldGetV1WithHeaderToken()
    {
        HttpRequestMessage? capturedRequest = null;

        SetupResponse(
            req => req.Method == HttpMethod.Get && req.RequestUri!.AbsolutePath == "/v1.0/crm/personalCustomers/objectMeta",
            req => capturedRequest = req,
            """{"name":"crm_customer","customized":false,"status":"PUBLISHED","code":"PROC-1","fields":[{"name":"customer_name","customized":false,"label":"客户名称","type":"Text","nillable":false,"selectOptions":[{"key":"a","value":"A"}]}]}""");

        var response = await _api.GetPersonalCustomerObjectMetaAsync("crm_customer", cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("crm_customer", response.Name);
        Assert.Equal("customer_name", Assert.Single(response.Fields).Name);
        Assert.Equal("A", Assert.Single(response.Fields[0].SelectOptions).Value);
        Assert.NotNull(capturedRequest);
        Assert.True(capturedRequest!.Headers.Contains("x-acs-dingtalk-access-token"));
        Assert.Contains("relationType=crm_customer", capturedRequest.RequestUri!.Query, StringComparison.Ordinal);
        Assert.DoesNotContain("access_token", capturedRequest.RequestUri.Query, StringComparison.Ordinal);
    }

    [Fact]
    public async Task CreatePersonalCustomerAsync_ShouldPostCamelCaseBody()
    {
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/crm/personalCustomers",
            req => capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult(),
            """{"instanceId":"inst01"}""");

        var response = await _api.CreatePersonalCustomerAsync(new CrmPersonalCustomerCreateRequest
        {
            CreatorUserId = "u1",
            RelationType = "crm_customer",
            Permission = new CrmPermission { OwnerStaffIds = ["u1"], ParticipantStaffIds = ["u2"] },
            Data = { ["customer_name"] = "抱壹" }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("inst01", response.InstanceId);
        Assert.Contains("\"creatorUserId\":\"u1\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"ownerStaffIds\":[\"u1\"]", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"customer_name\":\"抱壹\"", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task BatchCreateRelationDatasAsync_ShouldDeserializeResults()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/crm/relationDatas/batch",
            _ => { },
            """{"results":[{"success":true,"relationId":"rel01","duplicatedRelationIds":[]}]}""");

        var response = await _api.BatchCreateRelationDatasAsync(new CrmBatchCreateRelationDatasRequest
        {
            RelationType = "crm_customer",
            OperatorUserId = "u1",
            RelationList =
            [
                new()
                {
                    BizDataList = [new() { Key = "customer_name", Value = "抱壹" }],
                    RelationPermissionDTO = new CrmRelationPermission { PrincipalUserIds = ["u1"] }
                }
            ]
        }, cancellationToken: TestContext.Current.CancellationToken);

        var result = Assert.Single(response.Results);
        Assert.True(result.Success);
        Assert.Equal("rel01", result.RelationId);
    }

    [Fact]
    public async Task QueryGroupSetsAsync_ShouldDeserializeGroupSetList()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Get && req.RequestUri!.AbsolutePath == "/v1.0/crm/groupSets/lists",
            _ => { },
            """{"hasMore":false,"nextToken":"next","totalCount":1,"resultList":[{"name":"重点客户","openGroupSetId":"set01","ownerUserId":"u1","managerUserIds":["u2"],"owner":{"userId":"u1","userName":"张三"}}]}""");

        var response = await _api.QueryGroupSetsAsync(relationType: "crm_customer", cancellationToken: TestContext.Current.CancellationToken);

        Assert.False(response.HasMore);
        Assert.Equal("重点客户", Assert.Single(response.ResultList).Name);
        Assert.Equal("张三", response.ResultList[0].Owner!.UserName);
    }

    [Fact]
    public async Task DeleteContactAsync_ShouldPostTopApiWithQueryTokenAndSnakeCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/crm/objectdata/contact/delete",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"errcode":0,"errmsg":"ok","result":true}""");

        var response = await _topApi.DeleteContactAsync(new CrmTopDeleteDataRequest
        {
            OperatorUserid = "u1",
            DataId = "data01"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Result);
        Assert.Equal(0, response.ErrCode);
        Assert.NotNull(capturedRequest);
        Assert.Contains("access_token=mock_token", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"operator_userid\":\"u1\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"data_id\":\"data01\"", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task QueryContactsAsync_ShouldDeserializeTopApiResult()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/crm/objectdata/contact/query",
            _ => { },
            """{"errcode":0,"errmsg":"ok","result":{"has_more":false,"next_cursor":"2","list":[{"data_id":"data01","data":{"contact_name":"李四"}}]}}""");

        var response = await _topApi.QueryContactsAsync(new CrmTopQueryRequest
        {
            CurrentOperatorUserid = "u1",
            PageSize = 10,
            QueryDsl = "{}"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("2", response.Result!.NextCursor);
        var item = Assert.Single(response.Result.List);
        Assert.Equal("data01", item.DataId);
        Assert.Equal("李四", item.Data["contact_name"]?.ToString());
    }

    public static IEnumerable<object[]> CrmApiTypeData() => CrmApiTypes.Select(type => new object[] { type });

    public static IEnumerable<object[]> CrmApiMethodData() =>
        CrmApiTypes.SelectMany(apiType => apiType.GetMethods().Select(method => new object[] { apiType, method }));

    public static IEnumerable<object[]> CrmModelTypeData() =>
        typeof(CrmPersonalCustomerCreateRequest).Assembly
            .GetTypes()
            .Where(type => type.IsPublic && type.Namespace == "DingTalkApiClient.Models.CRM" && !type.IsGenericType)
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
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json")
            }));
    }

    private static Attribute? GetHttpMethodAttribute(MethodInfo method) =>
        method.GetCustomAttributes()
            .FirstOrDefault(attribute => attribute.GetType().Namespace == typeof(HttpGetAttribute).Namespace &&
                                         attribute.GetType().Name.StartsWith("Http", StringComparison.Ordinal));
}
