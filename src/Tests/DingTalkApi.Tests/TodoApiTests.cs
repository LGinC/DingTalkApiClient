using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Moq.Protected;
using DingTalkApi.Apis.Todo;
using DingTalkApi.Attributes;
using DingTalkApi.Models.Todo;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Tests;

public class TodoApiTests : TestBase
{
    private readonly ITodoApi _api;

    public TodoApiTests()
    {
        _api = Provider.GetRequiredService<ITodoApi>();
    }

    [Fact]
    public void TodoApi_ShouldBeRegisteredAndUseCamelCaseOptions()
    {
        var api = Provider.GetService<ITodoApi>();
        Assert.NotNull(api);

        var options = Provider.GetRequiredService<IOptionsMonitor<HttpApiOptions>>().Get(typeof(ITodoApi).FullName);
        Assert.Equal(JsonNamingPolicy.CamelCase, options.JsonSerializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.CamelCase, options.JsonDeserializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.CamelCase, options.KeyValueSerializeOptions.PropertyNamingPolicy);
    }

    [Theory]
    [MemberData(nameof(TodoApiMethodData))]
    public void TodoApiMethods_ShouldHaveHttpAttributeAndTokenProvider(MethodInfo method)
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
    [MemberData(nameof(TodoModelTypeData))]
    public void TodoModels_ShouldBeRegisteredInJsonSerializerContext(Type modelType)
    {
        Assert.NotNull(DingTalkJsonSerializerContext.Default.GetTypeInfo(modelType));
    }

    [Fact]
    public async Task CreatePersonalTodoTaskAsync_ShouldPostV1WithHeaderTokenAndCamelCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/todo/users/me/personalTasks",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"taskId":"task-personal-01","createdTime":1710000000000}""");

        var response = await _api.CreatePersonalTodoTaskAsync(new CreatePersonalTodoTaskRequest
        {
            Subject = "个人待办",
            DueTime = 1710003600000,
            ExecutorIds = ["union-01"],
            NotifyConfigs = new TodoNotifyConfigs { DingNotify = "1" }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("task-personal-01", response.TaskId);
        Assert.Equal(1710000000000, response.CreatedTime);
        Assert.NotNull(capturedRequest);
        Assert.True(capturedRequest!.Headers.Contains("x-acs-dingtalk-access-token"));
        Assert.DoesNotContain("access_token", capturedRequest.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"executorIds\":[\"union-01\"]", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"dingNotify\":\"1\"", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task CreateTodoTaskAsync_ShouldUsePathAndQueryParameters()
    {
        HttpRequestMessage? capturedRequest = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/todo/users/union-creator/tasks",
            req => capturedRequest = req,
            """
            {"id":"task-01","subject":"工作待办","description":"描述","startTime":1710000000000,"dueTime":1710003600000,"finishTime":0,"done":false,"executorIds":["union-01"],"participantIds":["union-02"],"detailUrl":{"pcUrl":"https://pc.example.com","appUrl":"https://app.example.com"},"source":"biz","sourceId":"source-01","createdTime":1710000000000,"modifiedTime":1710000000000,"creatorId":"union-creator","modifierId":"union-creator","bizTag":"todo","requestId":"req-01","isOnlyShowExecutor":true,"priority":20,"notifyConfigs":{"dingNotify":"1"}}
            """);

        var response = await _api.CreateTodoTaskAsync(
            "union-creator",
            new CreateTodoTaskRequest
            {
                SourceId = "source-01",
                Subject = "工作待办",
                DetailUrl = new TodoDetailUrl { AppUrl = "https://app.example.com", PcUrl = "https://pc.example.com" },
                Priority = 20
            },
            "union-operator", cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("task-01", response.Id);
        Assert.Equal("https://pc.example.com", response.DetailUrl.PcUrl);
        Assert.True(response.IsOnlyShowExecutor);
        Assert.NotNull(capturedRequest);
        Assert.Contains("operatorId=union-operator", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.True(capturedRequest.Headers.Contains("x-acs-dingtalk-access-token"));
    }

    [Fact]
    public async Task DeleteAndUpdateTodoTaskAsync_ShouldDeserializeBooleanResults()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Delete && req.RequestUri!.AbsolutePath == "/v1.0/todo/users/union-01/tasks/task-01",
            _ => { },
            """{"result":true,"requestId":"req-delete"}""");

        var deleteResponse = await _api.DeleteTodoTaskAsync("union-01", "task-01", "union-operator", cancellationToken: TestContext.Current.CancellationToken);
        Assert.True(deleteResponse.Result);
        Assert.Equal("req-delete", deleteResponse.RequestId);

        SetupResponse(
            req => req.Method == HttpMethod.Put && req.RequestUri!.AbsolutePath == "/v1.0/todo/users/union-01/tasks/task-01",
            _ => { },
            """{"result":true}""");

        var updateResponse = await _api.UpdateTodoTaskAsync(
            "union-01",
            "task-01",
            new UpdateTodoTaskRequest
            {
                Subject = "更新待办",
                Description = "更新描述",
                ExecutorIds = ["union-01"],
                ParticipantIds = ["union-02"],
                Done = true
            }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(updateResponse.Result);
    }

    [Fact]
    public async Task UpdateTodoTaskExecutorStatusAsync_ShouldPutExecutorStatus()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Put && req.RequestUri!.AbsolutePath == "/v1.0/todo/users/union-01/tasks/task-01/executorStatus",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"result":true}""");

        var response = await _api.UpdateTodoTaskExecutorStatusAsync(
            "union-01",
            "task-01",
            new UpdateTodoTaskExecutorStatusRequest
            {
                ExecutorStatusList = [new TodoExecutorStatus { Id = "union-01", IsDone = true }]
            },
            "union-operator", cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Result);
        Assert.NotNull(capturedRequest);
        Assert.Contains("operatorId=union-operator", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"isDone\":true", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task QueryOrgTodoTasksAsync_ShouldDeserializeTodoCards()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/todo/users/union-01/org/tasks/query",
            _ => { },
            """
            {"nextToken":"15","todoCards":[{"taskId":"task-01","subject":"接入钉钉待办","dueTime":1617675000000,"detailUrl":{"appUrl":"https://app.example.com","pcUrl":"https://pc.example.com"},"priority":10,"createdTime":1617675000000,"modifiedTime":1617675000000,"creatorId":"union-creator","sourceId":"source-01","bizTag":"todo","isDone":true}]}
            """);

        var response = await _api.QueryOrgTodoTasksAsync("union-01", new QueryOrgTodoTasksRequest { IsDone = true }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("15", response.NextToken);
        Assert.Single(response.TodoCards);
        Assert.Equal("task-01", response.TodoCards[0].TaskId);
        Assert.True(response.TodoCards[0].IsDone);
    }

    public static IEnumerable<object[]> TodoApiMethodData() =>
        typeof(ITodoApi).GetMethods().Select(method => new object[] { method });

    public static IEnumerable<object[]> TodoModelTypeData() =>
        typeof(CreatePersonalTodoTaskRequest).Assembly
            .GetTypes()
            .Where(type => type.IsClass && type.IsPublic && type.Namespace == "DingTalkApi.Models.Todo")
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
