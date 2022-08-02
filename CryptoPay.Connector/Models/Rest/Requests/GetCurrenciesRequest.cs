namespace Cryptopay.Connector.Models.Rest.Requests;

/// <summary>
/// GetCurrenciesRequest class
/// </summary>
internal class GetCurrenciesRequest : ApiRequest
{
    /// <summary>
    /// Initializes GetCurrenciesRequest instance
    /// </summary>
    /// <returns></returns>
    public GetCurrenciesRequest() : base()
            => Path.Append("/getCurrencies");
}
