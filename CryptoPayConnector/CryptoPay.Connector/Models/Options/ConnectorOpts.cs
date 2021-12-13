namespace CryptoPay.Connector.Models.Options
{
    public class ConnectorOpts
    {
        /// <summary>
        /// Http connection handler lifetime in minutes, default 3 min
        /// </summary>
        public int Lifetime { get; set; } = 3;

        /// <summary>
        /// Testnet or Mainnet API url
        /// </summary>
        public string ApiUrl { get; set; }

        /// <summary>
        /// You App Token from Cryptobot
        /// </summary>
        public string ApiToken { get; set; }
    }
}
