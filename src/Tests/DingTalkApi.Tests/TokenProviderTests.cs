using Microsoft.Extensions.DependencyInjection;
using Moq.Protected;
using Moq;
using System.Net;
using DingTalkApi.TokenProviders;
using WebApiClientCore.Extensions.OAuths.TokenProviders;

namespace DingTalkApi.Tests;

public class TokenProviderTests : TestBase
{
    [Fact]
    public async Task AccessTokenProvider_Test()
    {
        // Mock the token response
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.RequestUri!.ToString().Contains("oauth2/accessToken")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"accessToken\":\"internal_token\",\"expireIn\":7200}", System.Text.Encoding.UTF8, "application/json")
            });

        var provider = new AccessTokenProvider(Provider);
        var result = await provider.GetTokenAsync();

        Assert.NotNull(result);
        Assert.Equal("internal_token", result.Access_token);
    }

    [Fact]
    public async Task CropAccessTokenProvider_Test()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.RequestUri!.ToString().Contains("oauth2/corpAccessToken")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"accessToken\":\"crop_token\",\"expireIn\":7200}", System.Text.Encoding.UTF8, "application/json")
            });

        var provider = new CropAccessTokenProvider(Provider);
        var result = await provider.GetTokenAsync();

        Assert.NotNull(result);
        Assert.Equal("crop_token", result.Access_token);
    }

    [Fact]
    public async Task SsoAccessTokenProvider_Test()
    {
        HttpHandlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.RequestUri!.ToString().Contains("oauth2/ssoAccessToken")),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"accessToken\":\"sso_token\",\"expireIn\":7200}", System.Text.Encoding.UTF8, "application/json")
            });

        var provider = new SsoAccessTokenProvider(Provider);
        var result = await provider.GetTokenAsync();

        Assert.NotNull(result);
        Assert.Equal("sso_token", result.Access_token);
    }
}
