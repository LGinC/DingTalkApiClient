using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Moq.Protected;
using DingTalkApiClient.Apis.Report;
using DingTalkApiClient.Attributes;
using DingTalkApiClient.Models.Report;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace DingTalkApiClient.Tests;

public class ReportApiTests : TestBase
{
    private readonly IReportApi _api;

    public ReportApiTests()
    {
        _api = Provider.GetRequiredService<IReportApi>();
    }

    [Fact]
    public void ReportApi_ShouldBeRegisteredAndUseSnakeCase()
    {
        Assert.NotNull(Provider.GetService<IReportApi>());

        var options = Provider.GetRequiredService<IOptionsMonitor<HttpApiOptions>>().Get(typeof(IReportApi).FullName);
        Assert.Equal(JsonNamingPolicy.SnakeCaseLower, options.JsonSerializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.SnakeCaseLower, options.JsonDeserializeOptions.PropertyNamingPolicy);
        Assert.Equal(JsonNamingPolicy.SnakeCaseLower, options.KeyValueSerializeOptions.PropertyNamingPolicy);
    }

    [Theory]
    [MemberData(nameof(ReportApiMethodData))]
    public void ReportApiMethods_ShouldHaveHttpAttributeAndTokenProvider(MethodInfo method)
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
    [MemberData(nameof(ReportModelTypeData))]
    public void ReportModels_ShouldBeRegisteredInJsonSerializerContext(Type modelType)
    {
        Assert.NotNull(DingTalkJsonSerializerContext.Default.GetTypeInfo(modelType));
    }

    [Fact]
    public async Task CreateReportAsync_ShouldPostTopApiWithQueryTokenAndSnakeCaseBody()
    {
        HttpRequestMessage? capturedRequest = null;
        string? capturedBody = null;

        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/report/create",
            req =>
            {
                capturedRequest = req;
                capturedBody = req.Content?.ReadAsStringAsync().GetAwaiter().GetResult();
            },
            """{"errcode":0,"errmsg":"ok","result":"report01"}""");

        var response = await _api.CreateReportAsync(new CreateReportRequest
        {
            CreateReportParam = new CreateReportParam
            {
                Contents = [new ReportContent { Sort = 0, Type = 1, ContentType = "markdown", Content = "今日完成工作", Key = "今日完成工作" }],
                TemplateId = "tpl01",
                ToUserids = ["u2"],
                ToChat = true,
                ToCids = ["cid01"],
                DdFrom = "report",
                Userid = "u1"
            }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal(0, response.ErrCode);
        Assert.Equal("report01", response.Result);
        Assert.NotNull(capturedRequest);
        Assert.Contains("access_token=mock_token", capturedRequest!.RequestUri!.Query, StringComparison.Ordinal);
        Assert.DoesNotContain("x-acs-dingtalk-access-token", string.Join(",", capturedRequest.Headers.Select(header => header.Key)), StringComparison.Ordinal);
        Assert.Contains("\"create_report_param\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"template_id\":\"tpl01\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"content_type\":\"markdown\"", capturedBody, StringComparison.Ordinal);
        Assert.Contains("\"to_userids\":[\"u2\"]", capturedBody, StringComparison.Ordinal);
    }

    [Fact]
    public async Task SaveReportContentAsync_ShouldDeserializeResult()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/report/savecontent",
            _ => { },
            """{"errcode":0,"errmsg":"ok","result":"content01"}""");

        var response = await _api.SaveReportContentAsync(new SaveReportContentRequest
        {
            CreateReportParam = new SaveReportContentParam
            {
                Contents = [new ReportContent { Sort = 1, Type = 1, ContentType = "markdown", Content = "待处理任务", Key = "未完成工作" }],
                TemplateId = "tpl01",
                DdFrom = "report",
                Userid = "u1"
            }
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("content01", response.Result);
    }

    [Fact]
    public async Task GetReportTemplateByNameAsync_ShouldDeserializeTemplateDetail()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/report/template/getbyname",
            _ => { },
            """{"errcode":0,"errmsg":"ok","result":{"default_receivers":[{"user_name":"张三","userid":"u2"}],"name":"日报","id":"tpl01","fields":[{"field_name":"今日完成工作","type":1,"sort":0}],"user_name":"李四","userid":"u1","default_received_convs":[{"conversation_id":"cid01","title":"日报群"}]}}""");

        var response = await _api.GetReportTemplateByNameAsync(new GetReportTemplateByNameRequest
        {
            Userid = "u1",
            TemplateName = "日报"
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("日报", response.Result!.Name);
        Assert.Equal("张三", Assert.Single(response.Result.DefaultReceivers).UserName);
        Assert.Equal("今日完成工作", Assert.Single(response.Result.Fields).FieldName);
        Assert.Equal("cid01", Assert.Single(response.Result.DefaultReceivedConvs).ConversationId);
    }

    [Fact]
    public async Task ListReportsAsync_ShouldDeserializePagedReports()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/report/list",
            _ => { },
            """{"errcode":0,"errmsg":"ok","result":{"data_list":[{"contents":"内容","remark":"备注","template_name":"日报","dept_name":"研发","creator_name":"张三","creator_id":"u1","create_time":1710000000000,"report_id":"report01","modified_time":1710000001000}],"size":20,"next_cursor":20,"has_more":true}}""");

        var response = await _api.ListReportsAsync(new ListReportsRequest
        {
            StartTime = 1710000000000,
            EndTime = 1710086400000,
            TemplateName = "日报",
            Userid = "u1",
            Cursor = 0,
            Size = 20
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Result!.HasMore);
        Assert.Equal("report01", Assert.Single(response.Result.DataList).ReportId);
        Assert.Equal(1710000001000, response.Result.DataList[0].ModifiedTime);
    }

    [Fact]
    public async Task ListSimpleReportsAsync_ShouldDeserializePagedSummaries()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/report/simplelist",
            _ => { },
            """{"errcode":0,"request_id":"req01","result":{"data_list":[{"remark":"备注","template_name":"日报","dept_name":"研发","creator_name":"张三","creator_id":"u1","create_time":1710000000000,"report_id":"report01"}],"size":20,"next_cursor":20,"has_more":false}}""");

        var response = await _api.ListSimpleReportsAsync(new ListSimpleReportsRequest
        {
            StartTime = 1710000000000,
            EndTime = 1710086400000,
            Cursor = 0,
            Size = 20
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("req01", response.RequestId);
        Assert.False(response.Result!.HasMore);
        Assert.Equal("日报", Assert.Single(response.Result.DataList).TemplateName);
    }

    [Fact]
    public async Task ListReportUsersByTypeAsync_ShouldDeserializeUserIds()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/report/statistics/listbytype",
            _ => { },
            """{"errcode":0,"success":true,"request_id":"req01","result":{"next_cursor":100,"has_more":true,"userid_list":["u1","u2"]}}""");

        var response = await _api.ListReportUsersByTypeAsync(new ListReportUsersByTypeRequest
        {
            ReportId = "report01",
            Type = 0,
            Offset = 0,
            Size = 100
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
        Assert.Equal(["u1", "u2"], response.Result!.UseridList);
    }

    [Fact]
    public async Task ListReportReceiversAsync_ShouldDeserializeUserIds()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/report/receiver/list",
            _ => { },
            """{"errcode":0,"errmsg":"ok","success":true,"result":{"has_more":false,"userid_list":["u3"]}}""");

        var response = await _api.ListReportReceiversAsync(new ListReportReceiversRequest
        {
            ReportId = "report01",
            Offset = 0,
            Size = 100
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("u3", Assert.Single(response.Result!.UseridList));
    }

    [Fact]
    public async Task ListReportCommentsAsync_ShouldDeserializeComments()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/report/comment/list",
            _ => { },
            """{"errcode":0,"request_id":"req01","success":true,"result":{"comments":[{"create_time":"2020-09-08 00:26:37","content":"不错","userid":"u2"}],"has_more":false}}""");

        var response = await _api.ListReportCommentsAsync(new ListReportCommentsRequest
        {
            ReportId = "report01",
            Offset = 0,
            Size = 20
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.True(response.Success);
        Assert.Equal("不错", Assert.Single(response.Result!.Comments).Content);
    }

    [Fact]
    public async Task GetReportUnreadCountAsync_ShouldDeserializeCount()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/report/getunreadcount",
            _ => { },
            """{"count":2,"errcode":0,"errmsg":"ok","request_id":"req01"}""");

        var response = await _api.GetReportUnreadCountAsync(new GetReportUnreadCountRequest { Userid = "u1" }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal(2, response.Count);
        Assert.Equal("req01", response.RequestId);
    }

    [Fact]
    public async Task ListReportTemplatesByUserIdAsync_ShouldDeserializeTemplates()
    {
        SetupResponse(
            req => req.Method == HttpMethod.Post && req.RequestUri!.AbsolutePath == "/topapi/report/template/listbyuserid",
            _ => { },
            """{"errcode":0,"errmsg":"ok","request_id":"req01","result":{"template_list":[{"name":"日报","icon_url":"https://example.com/icon.png","report_code":"tpl01","url":"https://example.com/report"}],"next_cursor":100}}""");

        var response = await _api.ListReportTemplatesByUserIdAsync(new ListReportTemplatesByUserIdRequest
        {
            Userid = "u1",
            Offset = 0,
            Size = 100
        }, cancellationToken: TestContext.Current.CancellationToken);

        Assert.Equal("req01", response.RequestId);
        Assert.Equal("tpl01", Assert.Single(response.Result!.TemplateList).ReportCode);
        Assert.Equal(100, response.Result.NextCursor);
    }

    public static IEnumerable<object[]> ReportApiMethodData() =>
        typeof(IReportApi).GetMethods().Select(method => new object[] { method });

    public static IEnumerable<object[]> ReportModelTypeData() =>
        typeof(CreateReportRequest).Assembly
            .GetTypes()
            .Where(type => type.IsClass && type.IsPublic && type.Namespace == "DingTalkApiClient.Models.Report")
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
