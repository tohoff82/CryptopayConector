namespace Cryptopay.Connector.Models.Rest.Requests;

/// <summary>
/// GetExchangeRatesRequest class
/// </summary>
internal class GetExchangeRatesRequest : ApiRequest
{
    /// <summary>
    /// Initializes GetExchangeRatesRequest instance
    /// </summary>
    public GetExchangeRatesRequest(): base()
        => Path.Append("/getExchangeRates");
}
