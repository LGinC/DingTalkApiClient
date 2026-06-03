using System.Linq.Expressions;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Moq.Protected;
using DingTalkApi.Apis.SmartFill;
using DingTalkApi.Attributes;
using DingTalkApi.Models.SmartFill;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Tests;

public class SmartFillApiTests : TestBase
{
    private readonly ISmartFillApi _api;

    public SmartFillApiTests()
    {
        _api = Provider.GetRequiredService<ISmartFillApi>();
    }

    [Theory]
    [MemberData(nameof(SmartFillApiMethodData))]
    public void SmartFillApiMethods_ShouldHaveHttpAttributeAndTokenProvider(MethodInfo method)
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
    [MemberData(nameof(SmartFillModelTypeData))]
    public void SmartFillModels_ShouldBeRegisteredInJsonSerializerContext(Type modelType)
    {
        Assert.NotNull(DingTalkJsonSerializerContext.Default.GetTypeInfo(modelType));
    }

    [Fact]
    public async Task ListFormSchemasByCreatorAsync_ShouldDeserializeTemplatesAndSendHeaderToken()
    {
        HttpRequestMessage? capturedRequest = null;

        SetupResponse(
            req => req.Method == HttpMethod.Get &&
                   req.RequestUri!.AbsolutePath == "/v1.0/swform/users/forms" &&
                   req.RequestUri.Query.Contains("maxResults=20", StringComparison.Ordinal) &&
                   req.RequestUri.Query.Contains("nextToken=0", StringComparison.Ordinal),
            req => capturedRequest = req,
            """{"success":true,"result":{"hasMore":false,"nextToken":0,"list":[{"creator":"u1","formCode":"form01","name":"测试填表","memo":"提示","setting":{"bizType":0,"createTime":"2022-07-29T14:55Z","formType":1,"stop":false,"loopTime":"09:00","loopDays":[1,2],"endTime":"2022-08-01T14:55Z"}}]}}""");

        var response = await _api.ListFormSchemasByCreatorAsync("20", "0", "0", "u1", cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
        Assert.Equal("form01", response.Result.List[0].FormCode);
        Assert.Equal(1, response.Result.List[0].Setting!.FormType);
        Assert.Equal([1, 2], response.Result.List[0].Setting!.LoopDays);
        Assert.NotNull(capturedRequest);
        Assert.Equal("mock_token", capturedRequest!.Headers.GetValues("x-acs-dingtalk-access-token").Single());
    }

    [Fact]
    public async Task ListFormInstancesAsync_ShouldDeserializeInstances()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Get &&
                   req.RequestUri!.AbsolutePath == "/v1.0/swform/forms/form01/instances" &&
                   req.RequestUri.Query.Contains("actionDate=2026-06-03", StringComparison.Ordinal),
            _ => { },
            """{"success":true,"result":{"hasMore":true,"nextToken":100,"list":[{"createTime":"2022-07-29T15:06Z","modifyTime":"2022-07-29T15:07Z","formCode":"form01","title":"测试填表","submitterUserId":"u2","submitterUserName":"李四","forms":[{"label":"姓名","key":"TextField_1","value":"李四"}],"formInstanceId":"inst01","studentClassName":"一班","studentClassId":"class01","studentUserId":"stu01","studentName":"学生"}]}}""");

        var response = await _api.ListFormInstancesAsync("form01", "0", "20", "1", "2026-06-03", cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Result.HasMore);
        var instance = Assert.Single(response.Result.List);
        Assert.Equal("inst01", instance.FormInstanceId);
        Assert.Equal("姓名", Assert.Single(instance.Forms).Label);
        Assert.Equal("一班", instance.StudentClassName);
    }

    [Fact]
    public async Task GetFormInstanceAsync_ShouldDeserializeDetail()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Get &&
                   req.RequestUri!.AbsolutePath == "/v1.0/swform/instances/inst01" &&
                   req.RequestUri.Query.Contains("bizType=0", StringComparison.Ordinal),
            _ => { },
            """{"success":true,"result":{"createTime":"2022-07-29T15:07Z","modifyTime":"2022-07-29T15:08Z","formCode":"form01","title":"测试填表","creator":"u2","forms":[{"label":"城市","key":"TextField_2","value":"上海"}]}}""");

        var response = await _api.GetFormInstanceAsync("inst01", "0", cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
        Assert.Equal("u2", response.Result.Creator);
        Assert.Equal("上海", Assert.Single(response.Result.Forms).Value);
    }

    public static IEnumerable<object[]> SmartFillApiMethodData() =>
        typeof(ISmartFillApi).GetMethods().Select(method => new object[] { method });

    public static IEnumerable<object[]> SmartFillModelTypeData() =>
        typeof(SmartFillFormSchemasResponse).Assembly
            .GetTypes()
            .Where(type => type.IsClass && type.IsPublic && !type.ContainsGenericParameters && type.Namespace == "DingTalkApi.Models.SmartFill")
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
