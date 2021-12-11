using CryptoPay.Connector.Models.Options;

using Microsoft.Extensions.DependencyInjection;

using System;

namespace CryptoPay.Connector.Extensions
{
    public static class Injector
    {
        private const string _baseUrlProd = "https://pay.crypt.bot";
        private const string _baseUrlTest = "https://testnet-pay.crypt.bot";

        public static void AddCryptopay(this IServiceCollection services, ConnectorOpts options)
        {
            services.AddHttpClient<ApiContext>(opt =>
            {
                if (options.IsTestnet)
                     opt.BaseAddress = new Uri(_baseUrlTest);
                else opt.BaseAddress = new Uri(_baseUrlProd);
            }).SetHandlerLifetime(TimeSpan.FromMinutes(options.Lifetime));

            services.AddTransient<IPayConnector>(x => new PayConnector(x.GetService<ApiContext>(), options.ApiToken));
        }
    }
}
