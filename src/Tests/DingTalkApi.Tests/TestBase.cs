using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Moq.Protected;
using System.Net;

namespace DingTalkApi.Tests;

public class TestBase
{
    protected readonly IServiceProvider Provider;
    protected readonly Mock<HttpMessageHandler> HttpHandlerMock;

    public TestBase()
    {
        HttpHandlerMock = new Mock<HttpMessageHandler>();

        // 默认返回成功响应，使用工厂函数确保每次请求获得独立的 HttpResponseMessage，避免流关闭错误
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>())
            .Returns(() => Task.FromResult(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"access_token\":\"mock_token\",\"accessToken\":\"mock_token\",\"expires_in\":7200,\"expireIn\":7200,\"errcode\":0,\"errmsg\":\"ok\"}", System.Text.Encoding.UTF8, "application/json")
            }));

        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true)
            .AddInMemoryCollection(new Dictionary<string, string?>
            {
                { "DingTalk:Internal:ClientId", "test_client" },
                { "DingTalk:Internal:ClientSecret", "test_secret" },
                { "DingTalk:Internal:SuiteKey", "test_suite_key" },
                { "DingTalk:Internal:SuiteSecret", "test_suite_secret" },
                { "DingTalk:Internal:AuthCorpId", "test_auth_corp_id" },
                { "DingTalk:Internal:SuiteTicket", "test_suite_ticket" },
                { "DingTalk:Internal:CropId", "test_crop_id" },
                { "DingTalk:Internal:SsoSecret", "test_sso_secret" }
            })
            .Build();

        var services = new ServiceCollection();
        services.AddDingTalk(configuration);

        // 核心修复：WebApiClientCore 可能不完全走标准 AddHttpClient 流程，
        // 我们通过自定义 IHttpClientFactory 来强制返回 Mock 处理器。
        var httpClient = new HttpClient(HttpHandlerMock.Object) { BaseAddress = new Uri("https://oapi.dingtalk.com") };
        var mockFactory = new Mock<IHttpClientFactory>();
        mockFactory.Setup(x => x.CreateClient(It.IsAny<string>())).Returns(httpClient);

        services.AddSingleton(mockFactory.Object);

        Provider = services.BuildServiceProvider();
    }
}
