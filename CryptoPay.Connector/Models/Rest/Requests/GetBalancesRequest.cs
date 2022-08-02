namespace Cryptopay.Connector.Models.Rest.Requests;

/// <summary>
/// GetBalancesRequest class
/// </summary>
internal class GetBalancesRequest : ApiRequest
{
    /// <summary>
    /// Initializes GetBalancesRequest instance
    /// </summary>
    /// <returns></returns>
    public GetBalancesRequest() : base()
            => Path.Append("/getBalance");
}
