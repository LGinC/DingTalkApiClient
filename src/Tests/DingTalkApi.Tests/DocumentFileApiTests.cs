using System.Linq.Expressions;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Moq.Protected;
using DingTalkApi.Apis.DocumentFile;
using DingTalkApi.Attributes;
using DingTalkApi.Models.DocumentFile;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApi.Tests;

public class DocumentFileApiTests : TestBase
{
    private readonly IDocumentFileApi _api;

    public DocumentFileApiTests()
    {
        _api = Provider.GetRequiredService<IDocumentFileApi>();
    }

    [Fact]
    public void DocumentFileApi_ShouldBeRegistered()
    {
        Assert.NotNull(_api);
    }

    [Fact]
    public void DocumentFileApiMethods_ShouldHaveHttpAttributeAndTokenProvider()
    {
        var methods = typeof(IDocumentFileApi).GetMethods();

        Assert.Equal(75, methods.Length);
        foreach (var method in methods)
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
    }

    [Fact]
    public void DocumentFileModels_ShouldBeRegisteredInJsonSerializerContext()
    {
        var modelTypes = typeof(PostV20WikiWorkspacesRequest).Assembly
            .GetTypes()
            .Where(type => type.Namespace == "DingTalkApi.Models.DocumentFile")
            .ToArray();

        Assert.Equal(255, modelTypes.Length);
        foreach (var modelType in modelTypes)
        {
            Assert.NotNull(DingTalkJsonSerializerContext.Default.GetTypeInfo(modelType));
        }
    }

    [Fact]
    public async Task PostV20WikiWorkspacesAsync_ShouldPostWithHeaderTokenAndBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v2.0/wiki/workspaces",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """
            {
              "workspace": {
                "workspaceId": "ws01",
                "corpId": "corp01",
                "teamId": "team01",
                "rootNodeId": "root01",
                "name": "知识库",
                "type": "TEAM",
                "description": "desc",
                "url": "https://example.test/ws01",
                "icon": { "type": "EMOJI", "value": "1f4d8" },
                "cover": "cover",
                "creatorId": "user01",
                "modifierId": "user02",
                "createTime": "2026-01-01T00:00:00Z",
                "modifiedTime": "2026-01-02T00:00:00Z",
                "permissionRole": "OWNER"
              }
            }
            """);

        var response = await _api.PostV20WikiWorkspacesAsync(
            new PostV20WikiWorkspacesRequest { Name = "知识库" },
            "union01",
            cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("ws01", response.Workspace.WorkspaceId);
        Assert.Equal("EMOJI", response.Workspace.Icon.Type);
        Assert.NotNull(capturedRequest);
        Assert.True(capturedRequest!.Headers.Contains("x-acs-dingtalk-access-token"));
        Assert.Contains("operatorId=union01", capturedRequest.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"name\":\"知识库\"", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task PostV10StorageEventsSubscribeAsync_ShouldPostScope()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/v1.0/storage/events/subscribe",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"success":true}""");

        var response = await _api.PostV10StorageEventsSubscribeAsync(
            new PostV10StorageEventsSubscribeRequest { Scope = "SPACE", ScopeId = "space01" },
            "union01",
            cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
        Assert.NotNull(capturedRequest);
        Assert.Contains("unionId=union01", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.Contains("\"scope\":\"SPACE\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"scopeId\":\"space01\"", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task GetV10StorageTasksByTaskIdAsync_ShouldReadTask()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Get && req.RequestUri!.AbsolutePath == "/v1.0/storage/tasks/task01",
            _ => { },
            """
            {
              "task": {
                "id": "task01",
                "status": "SUCCESS",
                "totalCount": 2,
                "successCount": 2,
                "failCount": 0,
                "failMessage": "",
                "beginTime": "2026-01-01T00:00Z",
                "endTime": "2026-01-01T00:01Z"
              }
            }
            """);

        var response = await _api.GetV10StorageTasksByTaskIdAsync(
            "task01",
            "union01",
            cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("task01", response.Task.Id);
        Assert.Equal("SUCCESS", response.Task.Status);
        Assert.Equal(2, response.Task.SuccessCount);
    }

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
