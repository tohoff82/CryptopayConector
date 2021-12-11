namespace CryptoPay.Connector.Models.Rest
{
    public class GetMeRequest : ApiRequest
    {
        public GetMeRequest() : base()
            => Path.Append("/getMe");
    }
}
