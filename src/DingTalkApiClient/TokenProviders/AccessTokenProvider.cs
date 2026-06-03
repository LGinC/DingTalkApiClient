using Microsoft.Extensions.DependencyInjection;
using DingTalkApiClient.Apis;
using DingTalkApiClient.Options;
using WebApiClientCore.Extensions.OAuths;
using WebApiClientCore.Extensions.OAuths.TokenProviders;
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释

namespace DingTalkApiClient.TokenProviders;

public class AccessTokenProvider : TokenProvider
{
    public AccessTokenProvider(IServiceProvider services) : base(services)
    {
        Name = ProviderNames.Internal;
        base.Name = ProviderNames.Internal;
    }
    protected override async Task<TokenResult?> RefreshTokenAsync(IServiceProvider serviceProvider, string refreshToken)
    {
        Name = ProviderNames.Internal;
        var options = GetOptionsValue<DingTalkAccessTokenOptions>();
        ArgumentNullException.ThrowIfNull(options.ClientId);
        ArgumentNullException.ThrowIfNull(options.ClientSecret);
        var result = await serviceProvider.GetRequiredService<IAccessTokenApi>().GetAccessTokenAsync(new(options.ClientId, options.ClientSecret));
        return new TokenResult
        {
            Access_token = result.AccessToken,
            Expires_in = result.ExpireIn
        };
    }

    protected override Task<TokenResult?> RequestTokenAsync(IServiceProvider serviceProvider) => RefreshTokenAsync(serviceProvider, string.Empty);
}

public class CropAccessTokenProvider : TokenProvider
{
    public CropAccessTokenProvider(IServiceProvider services) : base(services)
    {
        Name = ProviderNames.Corp;
        base.Name = ProviderNames.Corp;
    }

    protected override async Task<TokenResult?> RefreshTokenAsync(IServiceProvider serviceProvider, string refresh_token)
    {

        var options = GetOptionsValue<DingTalkAccessTokenOptions>();
        var result = await serviceProvider.GetRequiredService<IAccessTokenApi>().GetCropAccessTokenAsync(new(options.SuiteKey!, options.SuiteSecret!, options.AuthCorpId!, options.SuiteTicket!));
        return new TokenResult
        {
            Access_token = result.AccessToken,
            Expires_in = result.ExpireIn
        };
    }

    protected override Task<TokenResult?> RequestTokenAsync(IServiceProvider serviceProvider) => RefreshTokenAsync(serviceProvider, string.Empty);
}

public class SsoAccessTokenProvider : TokenProvider
{
    public SsoAccessTokenProvider(IServiceProvider services) : base(services)
    {
        Name = ProviderNames.MicroApp;
        base.Name = ProviderNames.MicroApp;
    }

    protected override async Task<TokenResult?> RefreshTokenAsync(IServiceProvider serviceProvider, string refresh_token)
    {
        var options = GetOptionsValue<DingTalkAccessTokenOptions>();
        var result = await serviceProvider.GetRequiredService<IAccessTokenApi>().GetSsoAccessTokenAsync(new(options.CropId!, options.SsoSecret!));
        return new TokenResult
        {
            Access_token = result.AccessToken,
            Expires_in = result.ExpireIn
        };
    }

    protected override Task<TokenResult?> RequestTokenAsync(IServiceProvider serviceProvider) => RefreshTokenAsync(serviceProvider, string.Empty);
}

