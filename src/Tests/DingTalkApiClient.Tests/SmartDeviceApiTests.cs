using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Moq.Protected;
using DingTalkApiClient.Apis.SmartDevice;
using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.SmartDevice;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Tests;

public class SmartDeviceApiTests : TestBase
{
    private readonly ISmartDeviceApi _api;

    public SmartDeviceApiTests()
    {
        _api = Provider.GetRequiredService<ISmartDeviceApi>();
    }

    [Fact]
    public void SmartDeviceApi_ShouldBeRegisteredAndUseSnakeCase()
    {
        Assert.NotNull(Provider.GetService<ISmartDeviceApi>());

        var options = Provider.GetRequiredService<IOptionsMonitor<HttpApiOptions>>().Get(typeof(ISmartDeviceApi).FullName);
        Assert.Equal(JsonNamingPolicy.SnakeCaseLower, options.JsonSerializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.SnakeCaseLower, options.JsonDeserializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.SnakeCaseLower, options.KeyValueSerializeOptions.PropertyNamingPolicy);
    }

    [Theory]
    [MemberData(nameof(SmartDeviceApiMethodData))]
    public void SmartDeviceApiMethods_ShouldHaveHttpAttributeAndTokenProvider(MethodInfo method)
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
    [MemberData(nameof(SmartDeviceModelTypeData))]
    public void SmartDeviceModels_ShouldBeRegisteredInJsonSerializerContext(Type modelType)
    {
        Assert.NotNull(DingTalkJsonSerializerContext.Default.GetTypeInfo(modelType));
    }

    [Fact]
    public async Task BindAsync_ShouldPostTopApiWithQueryTokenAndSnakeCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/smartdevice/external/bind",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"errcode":0,"errmsg":"ok","success":true,"request_id":"req01","result":{"device_id":"QWR45GT"}}""");

        var response = await _api.BindAsync(new SmartDeviceBindRequest
        {
            DeviceBindReqVo = new SmartDeviceBindInfo
            {
                Nick = "ding",
                Sn = "sdx123d123asdf",
                Mac = "11:11:11:11:11",
                Outid = "123456",
                Ext = "智能产品",
                Dn = "产品智能",
                Pk = "pk_01"
            }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
        Assert.Equal(0, response.ErrCode);
        Assert.Equal("req01", response.RequestId);
        Assert.Equal("QWR45GT", response.Result!.DeviceId);
        Assert.NotNull(capturedRequest);
        Assert.Contains("access_token=mock_token", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"device_bind_req_vo\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"sn\":\"sdx123d123asdf\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"outid\":\"123456\"", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task UnbindAsync_ShouldDeserializeTopApiStatus()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/smartdevice/device/unbind",
            _ => { },
            """{"errcode":0,"errmsg":"ok","success":true,"request_id":"req02"}""");

        var response = await _api.UnbindAsync(new SmartDeviceUnbindRequest
        {
            DeviceUnbindVo = new SmartDeviceUnbindInfo
            {
                Pk = "pk_01",
                DeviceName = "产品智能",
                DeviceId = "QWR45GT",
                Userid = "user01"
            }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
        Assert.Equal("req02", response.RequestId);
    }

    [Fact]
    public async Task UpdateNickAsync_ShouldPostSnakeCaseBody()
    {
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/smartdevice/device/updatenick",
            req => capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult(),
            """{"errcode":0,"errmsg":"ok","success":true}""");

        var response = await _api.UpdateNickAsync(new SmartDeviceUpdateNickRequest
        {
            DeviceNickModifyVo = new SmartDeviceUpdateNickInfo
            {
                Pk = "pk_01",
                DeviceName = "产品智能",
                DeviceId = "QWR45GT",
                Nick = "newding"
            }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
        Assert.Contains("\"device_nick_modify_vo\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"device_name\":\"产品智能\"", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task QueryListAsync_ShouldDeserializeDevicePage()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/smartdevice/device/querylist",
            _ => { },
            """{"errcode":0,"errmsg":"ok","success":true,"result":{"next_cursor":20,"has_more":true,"list":[{"nick":"ding","ext":"智能产品","device_mac":"11:11:11:11:11","device_name":"产品智能","device_id":"QWR45GT","pk":"pk_01","sn":"sdx123d123asdf","corp_id":"ding9f5xxxx","userid":"user01"}]}}""");

        var response = await _api.QueryListAsync(new SmartDeviceQueryListRequest
        {
            PageQueryVo = new SmartDevicePageQuery
            {
                Cursor = 0,
                Size = 20,
                Pk = "pk_01"
            }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Result!.HasMore);
        Assert.Equal(20, response.Result.NextCursor);
        var device = Assert.Single(response.Result.List);
        Assert.Equal("ding9f5xxxx", device.CorpId);
        Assert.Equal("QWR45GT", device.DeviceId);
    }

    [Fact]
    public async Task QueryAsync_ShouldDeserializeDeviceDetail()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/smartdevice/device/query",
            _ => { },
            """{"errcode":0,"errmsg":"ok","success":true,"result":{"nick":"ding","device_mac":"11:11:11:11:11","device_name":"产品智能","device_id":"QWR45GT","pk":"pk_01","sn":"sdx123d123asdf","corp_id":"ding9f5xxxx","userid":"user01","ext":"智能产品"}}""");

        var response = await _api.QueryAsync(new SmartDeviceQueryRequest
        {
            DeviceQueryVo = new SmartDeviceQueryInfo
            {
                Pk = "pk_01",
                DeviceName = "产品智能",
                DeviceId = "QWR45GT"
            }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("产品智能", response.Result!.DeviceName);
        Assert.Equal("user01", response.Result.Userid);
    }

    [Fact]
    public async Task QueryByIdAsync_ShouldDeserializeDeviceDetail()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/smartdevice/device/querybyid",
            _ => { },
            """{"errcode":0,"errmsg":"ok","success":true,"result":{"nick":"ding","device_id":"QWR45GT","device_name":"产品智能","pk":"pk_01"}}""");

        var response = await _api.QueryByIdAsync(new SmartDeviceQueryByIdRequest
        {
            DeviceQueryVo = new SmartDeviceQueryByIdInfo { DeviceId = "QWR45GT" }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("QWR45GT", response.Result!.DeviceId);
        Assert.Equal("pk_01", response.Result.Pk);
    }

    public static IEnumerable<object[]> SmartDeviceApiMethodData() =>
        typeof(ISmartDeviceApi).GetMethods().Select(method => new object[] { method });

    public static IEnumerable<object[]> SmartDeviceModelTypeData() =>
        typeof(SmartDeviceBindRequest).Assembly
            .GetTypes()
            .Where(type => type.IsPublic && type.Namespace == "DingTalkApiClient.Models.SmartDevice" && !type.IsGenericType)
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
