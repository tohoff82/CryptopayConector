namespace Cryptopay.Connector.Models.Rest.Requests;

/// <summary>
/// GetMeRequest class
/// </summary>
internal class GetMeRequest : ApiRequest
{
    /// <summary>
    /// Initializes GetMeRequest instance
    /// </summary>
    /// <returns></returns>
    public GetMeRequest() : base()
            => Path.Append("/getMe");
}
