namespace Cryptopay.Connector.Models;

/// <summary>
/// Cryptopay credentials for API access
/// </summary>
public class CryptopayCredentials
{
    /// <summary>
    /// Testnet or Mainnet API url
    /// </summary>
    public string ApiUrl { get; init; }

    /// <summary>
    /// You App Token from Cryptobot
    /// </summary>
    public string ApiToken { get; init; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="apiUrl">Mainnet or Testnet url</param>
    /// <param name="apiToken">You API token from Cryptobot</param>
    public CryptopayCredentials(string apiUrl, string apiToken)
    {
          ApiUrl = apiUrl;
        ApiToken = apiToken;
    }
}
