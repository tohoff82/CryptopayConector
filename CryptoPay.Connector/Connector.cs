using Cryptopay.Connector.Exceptions;
using Cryptopay.Connector.Models;
using Microsoft.Extensions.DependencyInjection;

using static Cryptopay.Connector.Utils.Constants;

namespace Cryptopay.Connector;

/// <summary>
/// Implement DI for Cryptopay.Connector
/// </summary>
public static class Connector
{
    /// <summary>
    /// Inject Cryptopay to you application using DI
    /// </summary>
    /// <param name="services">You app services container</param>
    /// <param name="credentials">Cryptopay API credentials</param>
    /// <param name="httpLifetime">Http message handler life time (default 3 min.)</param>
    public static void AddCryptopay(this IServiceCollection services, CryptopayCredentials credentials, double httpLifetime = 3)
    {
        services.AddHttpClient<ApiContext>(httpClient =>
        {
            httpClient.BaseAddress = new Uri(credentials.ApiUrl);
            httpClient.DefaultRequestHeaders.Add(AUTH_HEADER, credentials.ApiToken);
        }).SetHandlerLifetime(TimeSpan.FromMinutes(httpLifetime));

        services.AddScoped<ICryptopay>(x => new Cryptopay(x.GetService<ApiContext>()
            ?? throw new CryptopayException("Cryptopay ApiContext must be not null")));
    }

    /// <summary>
    /// Create new Cryptopay API instance
    /// </summary>
    /// <param name="credentials">Cryptopay credentials</param>
    /// <returns></returns>
    public static ICryptopay GetIstance(HttpClient httpClient, CryptopayCredentials credentials)
    {
        httpClient.BaseAddress = new Uri(credentials.ApiUrl);
        httpClient.DefaultRequestHeaders.Add(AUTH_HEADER, credentials.ApiToken);

        return new Cryptopay(new ApiContext(httpClient));
    }
}
