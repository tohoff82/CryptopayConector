namespace CryptoPay.Connector.Models.Options
{
    public class ConnectorOpts
    {
        /// <summary>
        /// Http connection handler lifetime in minutes, default 3 min
        /// </summary>
        public int Lifetime { get; set; } = 3;

        /// <summary>
        /// Testnet or Mainnet flag
        /// </summary>
        public bool IsTestnet { get; set; } = true;

        /// <summary>
        /// You App Token from Cryptobot
        /// </summary>
        public string ApiToken { get; set; }
    }
}
