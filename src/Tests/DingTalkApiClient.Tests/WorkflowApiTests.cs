using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Moq.Protected;
using DingTalkApiClient.Apis.Workflow;
using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.Workflow;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Tests;

public class WorkflowApiTests : TestBase
{
    private readonly IWorkflowApi _api;

    public WorkflowApiTests()
    {
        _api = Provider.GetRequiredService<IWorkflowApi>();
    }

    [Fact]
    public void WorkflowApi_ShouldBeRegisteredAndUseCamelCaseOptions()
    {
        var api = Provider.GetService<IWorkflowApi>();
        Assert.NotNull(api);

        var options = Provider.GetRequiredService<IOptionsMonitor<HttpApiOptions>>().Get(typeof(IWorkflowApi).FullName);
        Assert.Equal(JsonNamingPolicy.CamelCase, options.JsonSerializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.CamelCase, options.JsonDeserializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.CamelCase, options.KeyValueSerializeOptions.PropertyNamingPolicy);
    }

    [Theory]
    [MemberData(nameof(WorkflowApiMethodData))]
    public void WorkflowApiMethods_ShouldHaveHttpAttributeAndTokenProvider(MethodInfo method)
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
    [MemberData(nameof(WorkflowModelTypeData))]
    public void WorkflowModels_ShouldBeRegisteredInJsonSerializerContext(Type modelType)
    {
        Assert.NotNull(DingTalkJsonSerializerContext.Default.GetTypeInfo(modelType));
    }

    [Fact]
    public async Task CreateOrUpdateFormAsync_ShouldPostV1WithHeaderTokenAndCamelCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/workflow/forms",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"result":"PROC-001"}""");

        var response = await _api.CreateOrUpdateFormAsync(new WorkflowCreateOrUpdateFormRequest
        {
            Name = "请假审批",
            Description = "OA",
            FormComponents =
            [
                new WorkflowFormComponent
                {
                    ComponentType = "TextField",
                    Props = new WorkflowFormComponentProps
                    {
                        ComponentId = "TextField_01",
                        Label = "事由",
                        Required = true
                    }
                }
            ]
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("PROC-001", response.Result);
        Assert.NotNull(capturedRequest);
        Assert.True(capturedRequest!.Headers.Contains("x-acs-dingtalk-access-token"));
        Assert.DoesNotContain("access_token", capturedRequest.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"formComponents\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"componentType\":\"TextField\"", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task GetFormSchemaAsync_ShouldSendQueryParameters()
    {
        HttpRequestMessage? capturedRequest = null;

        SetupResponse(
            req => req.Method == HttpMethod.Get && req.RequestUri!.AbsolutePath == "/v1.0/workflow/forms/schemas/processCodes",
            req => capturedRequest = req,
            """{"result":{"processCode":"PROC-001","name":"请假","formComponents":[]}}""");

        var response = await _api.GetFormSchemaAsync("PROC-001", "app-01", cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("PROC-001", response.Result.ProcessCode);
        Assert.NotNull(capturedRequest);
        Assert.Contains("processCode=PROC-001", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("appUuid=app-01", capturedRequest.RequestUri.Query, StringComparison.Ordinal);
        Assert.True(capturedRequest.Headers.Contains("x-acs-dingtalk-access-token"));
    }

    [Fact]
    public async Task CreateProcessInstanceAsync_ShouldDeserializeInstanceId()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/workflow/processInstances",
            _ => { },
            """{"instanceId":"proc-inst-01"}""");

        var response = await _api.CreateProcessInstanceAsync(new WorkflowCreateProcessInstanceRequest
        {
            OriginatorUserId = "user01",
            ProcessCode = "PROC-001",
            RequestId = "req-01",
            FormComponentValues =
            [
                new WorkflowFormComponentValue
                {
                    Name = "事由",
                    Value = "年假"
                }
            ]
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("proc-inst-01", response.InstanceId);
    }

    [Fact]
    public async Task QueryProcessCentreTodoTasksAsync_ShouldDeserializeTaskPage()
    {
        HttpRequestMessage? capturedRequest = null;

        SetupResponse(
            req => req.Method == HttpMethod.Get && req.RequestUri!.AbsolutePath == "/v1.0/workflow/processCentres/todoTasks",
            req => capturedRequest = req,
            """{"requestId":"req-01","taskPage":{"hasMore":false,"list":[{"taskId":123,"activityId":"act01","userId":"user01","status":"RUNNING","processInstanceId":"inst01"}]}}""");

        var response = await _api.QueryProcessCentreTodoTasksAsync("user01", "20", "1", "1710000000000", cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("req-01", response.RequestId);
        Assert.Single(response.TaskPage.List);
        Assert.Equal(123, response.TaskPage.List[0].TaskId);
        Assert.NotNull(capturedRequest);
        Assert.Contains("userId=user01", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("pageSize=20", capturedRequest.RequestUri.Query, StringComparison.Ordinal);
        Assert.Contains("pageNumber=1", capturedRequest.RequestUri.Query, StringComparison.Ordinal);
        Assert.Contains("createBefore=1710000000000", capturedRequest.RequestUri.Query, StringComparison.Ordinal);
    }

    public static IEnumerable<object[]> WorkflowApiMethodData() =>
        typeof(IWorkflowApi).GetMethods().Select(method => new object[] { method });

    public static IEnumerable<object[]> WorkflowModelTypeData() =>
        typeof(WorkflowCreateOrUpdateFormRequest).Assembly
            .GetTypes()
            .Where(type => type.IsClass && type.IsPublic && type.Namespace == "DingTalkApiClient.Models.Workflow")
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
