namespace Cryptopay.Connector.Utils;

public static class Constants
{
    /// <summary>
    /// Authenticate application with API token
    /// </summary>
    public const string AUTH_HEADER = "Crypto-Pay-API-Token";

    /// <summary>
    /// Values in seconds, between 1-2678400 are accepted
    /// </summary>
    public const int EXPIRES_IN_MAX_SIZE = 2678400;
}
