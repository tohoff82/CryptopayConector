using CryptoPay.Connector.Models.Options;

using Microsoft.Extensions.DependencyInjection;

using System;

namespace CryptoPay.Connector.Extensions
{
    public static class ServiceExt
    {
        private const string _authHeader = "Crypto-Pay-API-Token";

        public static void AddCryptopay(this IServiceCollection services, ConnectorOpts options)
        {
            services.AddHttpClient<ApiContext>(httpClient =>
            {
                httpClient.BaseAddress = new Uri(options.ApiUrl);
                httpClient.DefaultRequestHeaders.Add(_authHeader, options.ApiToken);
            }).SetHandlerLifetime(TimeSpan.FromMinutes(options.Lifetime));

            services.AddTransient<IPayConector>(x => new PayConector(x.GetService<ApiContext>()));
        }
    }
}
