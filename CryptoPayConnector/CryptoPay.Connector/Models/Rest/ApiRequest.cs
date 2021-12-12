using Newtonsoft.Json;

using System;
using System.Text;

namespace CryptoPay.Connector.Models.Rest
{
    internal class ApiRequest
    {
        private readonly string _api = "/api";

        protected StringBuilder Path { get; set; }
        protected object RequestBody { get; set; }

        public ApiRequest()
            => Path = new StringBuilder(_api);

        public Uri Uri
            => new Uri($"{Path}", UriKind.Relative);

        public string JsonBody
            => JsonConvert.SerializeObject(RequestBody);
    }
}
