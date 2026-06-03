
using Microsoft.Extensions.DependencyInjection;
using DingTalkApi.TokenProviders;
using DingTalkApi.Apis;

namespace DingTalkApi.Tests;

public class AccessTokenTests : TestBase
{
    [Fact]
    public async Task GetAccessTokenAsyncTest()
    {
        var provider = Provider.GetRequiredService<AccessTokenProvider>();
        Assert.NotNull(provider);
        var token = await provider.GetTokenAsync();
        Assert.NotNull(token);
        Assert.NotNull(token.Access_token);
        Assert.True(token.Expires_in > 0);
    }

    [Fact]
    public async Task DirectApiTest()
    {
        var api = Provider.GetRequiredService<IAccessTokenApi>();
        var result = await api.GetAccessTokenAsync(new("id", "secret"), cancellationToken: TestContext.Current.CancellationToken);
        Assert.NotNull(result);
        Assert.NotNull(result.AccessToken);
    }
}
