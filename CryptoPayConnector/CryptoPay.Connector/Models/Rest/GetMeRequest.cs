namespace CryptoPay.Connector.Models.Rest
{
    internal class GetMeRequest : ApiRequest
    {
        public GetMeRequest() : base()
            => Path.Append("/getMe");
    }
}
