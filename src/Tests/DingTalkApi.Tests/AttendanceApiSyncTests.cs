using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Moq.Protected;
using DingTalkApi.Apis.Attendance;
using DingTalkApi.Attributes;
using DingTalkApi.Models.Attendance;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Tests;

public class AttendanceApiSyncTests : TestBase
{
    private static readonly Type[] AttendanceApiTypes =
    [
        typeof(IAttendanceApprovalsApi),
        typeof(IAttendanceGroupsApi),
        typeof(IAttendanceMachinesApi),
        typeof(IAttendanceMachinesV1Api),
        typeof(IAttendanceRecordsApi),
        typeof(IAttendanceReportsApi),
        typeof(IAttendanceSchedulesApi),
        typeof(IAttendanceSettingsApi),
        typeof(IAttendanceShiftsApi),
        typeof(IAttendanceVacationsApi),
    ];

    [Theory]
    [MemberData(nameof(AttendanceApiTypeData))]
    public void AttendanceApis_ShouldBeRegisteredAndUseExpectedTokenTransport(Type apiType)
    {
        var api = Provider.GetService(apiType);
        Assert.NotNull(api);

        var options = Provider.GetRequiredService<IOptionsMonitor<HttpApiOptions>>().Get(apiType.FullName);
        var expectedNamingPolicy = typeof(DingTalkApi.Apis.IDingTalkQueryTokenApi).IsAssignableFrom(apiType)
            ? JsonNamingPolicy.SnakeCaseLower
            : JsonNamingPolicy.CamelCase;
        Assert.Equal(expectedNamingPolicy, options.JsonSerializeOptions.PropertyNamingPolicy);
        Assert.Equal(expectedNamingPolicy, options.JsonDeserializeOptions.PropertyNamingPolicy);
        Assert.Equal(expectedNamingPolicy, options.KeyValueSerializeOptions.PropertyNamingPolicy);
    }

    [Theory]
    [MemberData(nameof(AttendanceApiMethodData))]
    public void AttendanceApiMethods_ShouldHaveHttpAttributeAndTokenProvider(Type apiType, MethodInfo method)
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
    [MemberData(nameof(AttendanceModelTypeData))]
    public void AttendanceModels_ShouldBeRegisteredInJsonSerializerContext(Type modelType)
    {
        Assert.NotNull(DingTalkJsonSerializerContext.Default.GetTypeInfo(modelType));
    }

    [Fact]
    public async Task AttendanceGroupAddAsync_ShouldPostTopApiWithQueryTokenAndSnakeCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/attendance/group/add",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"errcode":0,"errmsg":"ok","result":{"name":"白班考勤","id":712070073}}""");

        var api = Provider.GetRequiredService<IAttendanceGroupsApi>();
        var response = await api.AttendanceGroupAddAsync(new AttendanceGroupAddRequest
        {
            OpUserId = "manager01",
            TopGroup = new AttendanceGroupAddRequestTopGroup
            {
                Type = "FIXED",
                Name = "白班考勤",
                Members =
                [
                    new AttendanceGroupAddRequestTopGroupMembersItem
                    {
                        Role = "Attendance",
                        Type = "StaffMember",
                        UserId = "user01"
                    }
                ]
            }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal(0, response.ErrCode);
        Assert.Equal("白班考勤", response.Result!.Name);
        Assert.NotNull(capturedRequest);
        Assert.Contains("access_token=mock_token", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"op_user_id\":\"manager01\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"top_group\"", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task AttendanceWritePermissionsQueryAsync_ShouldPostV1WithHeaderToken()
    {
        HttpRequestMessage? capturedRequest = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/attendance/writePermissions/query",
            req => capturedRequest = req,
            """{"entityPermissionMap":{"key":true}}""");

        var api = Provider.GetRequiredService<IAttendanceSettingsApi>();
        var response = await api.AttendanceWritePermissionsQueryAsync(new AttendanceWritePermissionsQueryRequest
        {
            OpUserId = "manager01",
            Category = "GROUP",
            ResourceKey = "GROUP_MEMBER",
            EntityIds = [123]
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.EntityPermissionMap.Key);
        Assert.NotNull(capturedRequest);
        Assert.True(capturedRequest!.Headers.Contains("x-acs-dingtalk-access-token"));
        Assert.DoesNotContain("access_token", capturedRequest.RequestUri!.Query, StringComparison.Ordinal);
    }

    public static IEnumerable<object[]> AttendanceApiTypeData() => AttendanceApiTypes.Select(type => new object[] { type });

    public static IEnumerable<object[]> AttendanceApiMethodData() =>
        AttendanceApiTypes.SelectMany(apiType => apiType.GetMethods().Select(method => new object[] { apiType, method }));

    public static IEnumerable<object[]> AttendanceModelTypeData() =>
        typeof(AttendanceGroupAddRequest).Assembly
            .GetTypes()
            .Where(type => type.IsClass && type.IsPublic && type.Namespace == "DingTalkApi.Models.Attendance")
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
