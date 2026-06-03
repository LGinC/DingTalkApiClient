using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Moq.Protected;
using DingTalkApi.Apis.EventSubscription;
using DingTalkApi.Attributes;
using DingTalkApi.Models.EventSubscription;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Tests;

public class EventSubscriptionApiTests : TestBase
{
    private readonly IEventSubscriptionApi _api;

    public EventSubscriptionApiTests()
    {
        _api = Provider.GetRequiredService<IEventSubscriptionApi>();
    }

    [Fact]
    public void EventSubscriptionApi_ShouldBeRegisteredAndUseSnakeCase()
    {
        Assert.NotNull(Provider.GetService<IEventSubscriptionApi>());

        var options = Provider.GetRequiredService<IOptionsMonitor<HttpApiOptions>>().Get(typeof(IEventSubscriptionApi).FullName);
        Assert.Equal(JsonNamingPolicy.SnakeCaseLower, options.JsonSerializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.SnakeCaseLower, options.JsonDeserializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.SnakeCaseLower, options.KeyValueSerializeOptions.PropertyNamingPolicy);
    }

    [Theory]
    [MemberData(nameof(EventSubscriptionApiMethodData))]
    public void EventSubscriptionApiMethods_ShouldHaveHttpAttributeAndTokenProvider(MethodInfo method)
    {
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
    [MemberData(nameof(EventSubscriptionModelTypeData))]
    public void EventSubscriptionModels_ShouldBeRegisteredInJsonSerializerContext(Type modelType)
    {
        Assert.NotNull(DingTalkJsonSerializerContext.Default.GetTypeInfo(modelType));
    }

    [Fact]
    public async Task GetCallbackFailedResultAsync_ShouldGetTopApiWithQueryTokenAndDeserializeEvents()
    {
        HttpRequestMessage? capturedRequest = null;

        SetupResponse(
            req => req.Method == HttpMethod.Get && req.RequestUri!.AbsolutePath == "/call_back/get_call_back_failed_result",
            req => capturedRequest = req,
            """
            {"errcode":0,"errmsg":"ok","failed_list":[{"call_back_tag":"user_add_org","event_time":1710000000000,"user_add_org":{"userid":["user01"],"corpid":"ding9f5xxxx"}},{"call_back_tag":"bpms_instance_change","event_time":1710000001000,"bpms_instance_change":{"bpmsCallBackData":{"processInstanceId":"proc01"},"corpid":"ding9f5xxxx"}},{"call_back_tag":"label_conf_add","event_time":1710000002000,"label_conf_add":{"roleLabelChange":{"labelId":"label01"},"corpid":"ding9f5xxxx"}}],"has_more":true}
            """);

        var response = await _api.GetCallbackFailedResultAsync(cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal(0, response.ErrCode);
        Assert.True(response.HasMore);
        Assert.NotNull(capturedRequest);
        Assert.Contains("access_token=mock_token", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);

        Assert.Equal(3, response.FailedList.Count);
        Assert.Equal("user01", response.FailedList[0].UserAddOrg!.Userid[0]);
        Assert.Equal("proc01", response.FailedList[1].BpmsInstanceChange!.BpmsCallBackData.GetProperty("processInstanceId").GetString());
        Assert.Equal("label01", response.FailedList[2].LabelConfAdd!.RoleLabelChange.GetProperty("labelId").GetString());
    }

    public static IEnumerable<object[]> EventSubscriptionApiMethodData() =>
        typeof(IEventSubscriptionApi).GetMethods().Select(method => new object[] { method });

    public static IEnumerable<object[]> EventSubscriptionModelTypeData() =>
        typeof(GetCallbackFailedResultResponse).Assembly
            .GetTypes()
            .Where(type => type.IsPublic && type.Namespace == "DingTalkApi.Models.EventSubscription" && !type.IsGenericType)
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
