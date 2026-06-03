using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Moq.Protected;
using DingTalkApiClient.Apis.Calendar;
using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.Calendar;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Tests;

public class CalendarApiTests : TestBase
{
    private readonly ICalendarApi _api;

    public CalendarApiTests()
    {
        _api = Provider.GetRequiredService<ICalendarApi>();
    }

    [Fact]
    public void CalendarApi_ShouldBeRegisteredAndUseCamelCaseOptions()
    {
        Assert.NotNull(Provider.GetService<ICalendarApi>());

        var options = Provider.GetRequiredService<IOptionsMonitor<HttpApiOptions>>().Get(typeof(ICalendarApi).FullName);
        Assert.Equal(JsonNamingPolicy.CamelCase, options.JsonSerializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.CamelCase, options.JsonDeserializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.CamelCase, options.KeyValueSerializeOptions.PropertyNamingPolicy);
    }

    [Theory]
    [MemberData(nameof(CalendarApiMethodData))]
    public void CalendarApiMethods_ShouldHaveHttpAttributeAndTokenProvider(MethodInfo method)
    {
        Assert.NotNull(GetHttpMethodAttribute(method));

        var parameters = method.GetParameters();
        var tokenParameter = parameters.SingleOrDefault(parameter =>
            parameter.GetCustomAttribute<DingTalkTokenProviderAttribute>() is not null);
        Assert.NotNull(tokenParameter);
        Assert.Equal(typeof(string), tokenParameter!.ParameterType);
        Assert.Equal(ProviderNames.Internal, tokenParameter.DefaultValue);
        Assert.Equal(typeof(CancellationToken), parameters.Last().ParameterType);
        if (method.ReturnType == typeof(Task))
        {
            return;
        }

        Assert.True(method.ReturnType.IsGenericType);
        Assert.Equal(typeof(ITask<>), method.ReturnType.GetGenericTypeDefinition());
    }

    [Theory]
    [MemberData(nameof(CalendarModelTypeData))]
    public void CalendarModels_ShouldBeRegisteredInJsonSerializerContext(Type modelType)
    {
        Assert.NotNull(DingTalkJsonSerializerContext.Default.GetTypeInfo(modelType));
    }

    [Fact]
    public async Task CreateAclAsync_ShouldPostAclAndDeserializeResponse()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/calendar/users/union-01/calendars/primary/acls",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """
            {"privilege":"reader","aclId":"acl-01","scope":{"scopeType":"user","userId":"union-02"}}
            """);

        var response = await _api.CreateAclAsync(
            "union-01",
            "primary",
            new CreateCalendarAclRequest
            {
                Privilege = "reader",
                SendMsg = true,
                Scope = new CalendarAclScope { ScopeType = "user", UserId = "union-02" }
            }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("acl-01", response.AclId);
        Assert.Equal("union-02", response.Scope.UserId);
        Assert.NotNull(capturedRequest);
        Assert.True(capturedRequest!.Headers.Contains("x-acs-dingtalk-access-token"));
        Assert.Contains("\"sendMsg\":true", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task CreateAndListEventsAsync_ShouldHandleHeadersQueriesAndNestedModels()
    {
        HttpRequestMessage? capturedCreateRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/calendar/users/union-01/calendars/primary/events",
            req =>
            {
                capturedCreateRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            EventJson("event-01"));

        var createResponse = await _api.CreateEventAsync(
            "union-01",
            "primary",
            CreateEventRequest(),
            "client-token-01", cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("event-01", createResponse.Id);
        Assert.Equal("Asia/Shanghai", createResponse.Start.TimeZone);
        Assert.Equal("union-02", createResponse.Attendees[0].Id);
        Assert.NotNull(capturedCreateRequest);
        Assert.Equal("client-token-01", capturedCreateRequest!.Headers.GetValues("x-client-token").Single());
        Assert.Contains("\"isAllDay\":false", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"dateTime\":\"2026-06-03T09:00:00", capturedBody, StringComparison.Ordinal);

        HttpRequestMessage? capturedListRequest = null;
        SetupResponse(
            req => req.Method == HttpMethod.Get && req.RequestUri!.AbsolutePath == "/v1.0/calendar/users/union-01/calendars/primary/events",
            req => capturedListRequest = req,
            $$"""{"nextToken":"next-01","syncToken":"sync-01","events":[{{EventJson("event-02")}}]}""");

        var listResponse = await _api.ListEventsAsync(
            "union-01",
            "primary",
            timeMin: "2026-06-03T00:00:00+08:00",
            maxResults: "50",
            nextToken: "next-00", cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("next-01", listResponse.NextToken);
        Assert.Equal("event-02", listResponse.Events[0].Id);
        Assert.NotNull(capturedListRequest);
        Assert.Contains("timeMin=2026", capturedListRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("maxResults=50", capturedListRequest.RequestUri.Query, StringComparison.Ordinal);
    }

    [Fact]
    public async Task AttendeesAndRespondAsync_ShouldUseEventSubPaths()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/calendar/users/union-01/calendars/primary/events/event-01/attendees",
            _ => { },
            "{}");

        await _api.AddEventAttendeesAsync(
            "union-01",
            "primary",
            "event-01",
            new CalendarAttendeesRequest { AttendeesToAdd = [new CalendarAttendee { Id = "union-02" }] }, cancellationToken: TestContext.Current.CancellationToken);

        SetupResponse(
            req => req.Method == HttpMethod.Get && req.RequestUri!.AbsolutePath == "/v1.0/calendar/users/union-01/calendars/primary/events/event-01/attendees",
            _ => { },
            """{"nextToken":"next-01","attendees":[{"id":"union-02","displayName":"李四","responseStatus":"accepted"}]}""");

        var listResponse = await _api.ListEventAttendeesAsync("union-01", "primary", "event-01", "100", cancellationToken: TestContext.Current.CancellationToken);
        Assert.Equal("union-02", listResponse.Attendees[0].Id);

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/calendar/users/union-02/calendars/primary/events/event-01/respond",
            _ => { },
            "{}");

        await _api.RespondEventAsync("union-02", "primary", "event-01", new RespondCalendarEventRequest { ResponseStatus = "accepted" }, cancellationToken: TestContext.Current.CancellationToken);
    }

    [Fact]
    public async Task QueryScheduleAndCalendarsAsync_ShouldDeserializeWrappers()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/calendar/users/union-01/querySchedule",
            _ => { },
            """
            {"scheduleInformation":[{"userId":"union-02","scheduleItems":[{"status":"busy","start":{"dateTime":"2026-06-03T09:00:00+08:00","timeZone":"Asia/Shanghai"},"end":{"dateTime":"2026-06-03T10:00:00+08:00","timeZone":"Asia/Shanghai"}}]}]}
            """);

        var schedule = await _api.QueryUserScheduleAsync(
            "union-01",
            new QueryUserScheduleRequest
            {
                UserIds = ["union-02"],
                StartTime = "2026-06-03T00:00:00+08:00",
                EndTime = "2026-06-04T00:00:00+08:00"
            }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("busy", schedule.ScheduleInformation[0].ScheduleItems[0].Status);

        SetupResponse(
            req => req.Method == HttpMethod.Get && req.RequestUri!.AbsolutePath == "/v1.0/calendar/users/union-01/calendars",
            _ => { },
            """{"response":{"calendars":[{"id":"primary","summary":"主日历","timeZone":"Asia/Shanghai","type":"primary","privilege":"writer"}]}}""");

        var calendars = await _api.ListCalendarsAsync("union-01", cancellationToken: TestContext.Current.CancellationToken);
        Assert.Equal("primary", calendars.Response!.Calendars[0].Id);
    }

    [Fact]
    public async Task SubscribedCalendarAndSignAsync_ShouldDeserializeResults()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/calendar/users/union-01/subscribedCalendars",
            _ => { },
            """{"calendarId":"sub-01"}""");

        var create = await _api.CreateSubscribedCalendarAsync(
            "union-01",
            new SubscribedCalendarRequest
            {
                Name = "公开课",
                SubscribeScope = new CalendarSubscribeScope { UnionIds = ["union-02"] }
            }, cancellationToken: TestContext.Current.CancellationToken);
        Assert.Equal("sub-01", create.CalendarId);

        SetupResponse(
            req => req.Method == HttpMethod.Get && req.RequestUri!.AbsolutePath == "/v1.0/calendar/users/union-01/subscribedCalendars/sub-01",
            _ => { },
            """{"calendarId":"sub-01","name":"公开课","description":"描述","author":"union-01","managers":["union-03"],"subscribeScope":{"unionIds":["union-02"],"openConversationIds":[],"corpIds":[]}}""");

        var detail = await _api.GetSubscribedCalendarAsync("union-01", "sub-01", cancellationToken: TestContext.Current.CancellationToken);
        Assert.Equal("union-03", detail.Managers[0]);

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/calendar/users/union-01/calendars/primary/unsubscribe",
            _ => { },
            """{"result":true}""");

        var unsubscribe = await _api.UnsubscribeCalendarAsync("union-01", "primary", cancellationToken: TestContext.Current.CancellationToken);
        Assert.True(unsubscribe.Result);

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/calendar/users/union-01/calendars/primary/events/event-01/signin",
            _ => { },
            """{"checkInTime":1780477200000}""");

        var signIn = await _api.SignInEventAsync("union-01", "primary", "event-01", cancellationToken: TestContext.Current.CancellationToken);
        Assert.Equal(1780477200000, signIn.CheckInTime);

        SetupResponse(
            req => req.Method == HttpMethod.Get && req.RequestUri!.AbsolutePath == "/v1.0/calendar/users/union-01/calendars/primary/events/event-01/signOut",
            _ => { },
            """{"nextToken":"next-01","users":[{"userId":"union-01","displayName":"张三","checkOutTime":1780480800000}]}""");

        var signOuts = await _api.ListEventSignOutsAsync("union-01", "primary", "event-01", "100", "all", cancellationToken: TestContext.Current.CancellationToken);
        Assert.Equal(1780480800000, signOuts.Users[0].CheckOutTime);
    }

    [Fact]
    public async Task MeetingRoomsAsync_ShouldDeserializeScheduleAndBooleanResult()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/calendar/users/union-01/meetingRooms/schedules/query",
            _ => { },
            """
            {"scheduleInformation":[{"roomId":"room-01","scheduleItems":[{"status":"BUSY","eventId":"event-01","organizer":{"id":"union-01"},"start":{"dateTime":"2026-06-03T09:00:00+08:00","timeZone":"Asia/Shanghai"},"end":{"dateTime":"2026-06-03T10:00:00+08:00","timeZone":"Asia/Shanghai"}}]}]}
            """);

        var schedule = await _api.QueryMeetingRoomScheduleAsync(
            "union-01",
            new QueryMeetingRoomScheduleRequest
            {
                RoomIds = ["room-01"],
                StartTime = "2026-06-03T09:00:00+08:00",
                EndTime = "2026-06-03T10:00:00+08:00"
            }, cancellationToken: TestContext.Current.CancellationToken);
        Assert.Equal("event-01", schedule.ScheduleInformation[0].ScheduleItems[0].EventId);

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/calendar/users/union-01/calendars/primary/events/event-01/meetingRooms",
            _ => { },
            """{"result":true}""");

        var add = await _api.AddEventMeetingRoomsAsync(
            "union-01",
            "primary",
            "event-01",
            new CalendarMeetingRoomsRequest { MeetingRoomsToAdd = [new CalendarMeetingRoom { RoomId = "room-01" }] }, cancellationToken: TestContext.Current.CancellationToken);
        Assert.True(add.Result);
    }

    public static IEnumerable<object[]> CalendarApiMethodData() =>
        typeof(ICalendarApi).GetMethods().Select(method => new object[] { method });

    public static IEnumerable<object[]> CalendarModelTypeData() =>
        typeof(CreateCalendarAclRequest).Assembly
            .GetTypes()
            .Where(type => type.IsClass && type.IsPublic && type.Namespace == "DingTalkApiClient.Models.Calendar")
            .Select(type => new object[] { type });

    private static CalendarEventRequest CreateEventRequest() => new()
    {
        Summary = "项目评审",
        Description = "评审会议",
        Start = new CalendarEventTime { DateTime = "2026-06-03T09:00:00+08:00", TimeZone = "Asia/Shanghai" },
        End = new CalendarEventTime { DateTime = "2026-06-03T10:00:00+08:00", TimeZone = "Asia/Shanghai" },
        IsAllDay = false,
        Attendees = [new CalendarAttendee { Id = "union-02" }],
        Location = new CalendarLocation { DisplayName = "会议室A" },
        Reminders = [new CalendarReminder { Method = "popup", Minutes = 15 }]
    };

    private static string EventJson(string id) =>
        $$"""
        {"id":"{{id}}","summary":"项目评审","description":"评审会议","start":{"dateTime":"2026-06-03T09:00:00+08:00","timeZone":"Asia/Shanghai"},"end":{"dateTime":"2026-06-03T10:00:00+08:00","timeZone":"Asia/Shanghai"},"isAllDay":false,"attendees":[{"id":"union-02","displayName":"李四","responseStatus":"needsAction","self":false,"isOptional":false}],"organizer":{"id":"union-01","displayName":"张三","responseStatus":"accepted","self":true},"location":{"displayName":"会议室A"},"reminders":[{"method":"popup","minutes":15}],"meetingRooms":[{"roomId":"room-01","roomName":"会议室A"}],"eTag":"etag-01"}
        """;

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
