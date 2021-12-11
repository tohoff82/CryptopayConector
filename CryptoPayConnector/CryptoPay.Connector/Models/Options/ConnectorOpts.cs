namespace CryptoPay.Connector.Models.Options
{
    public class ConnectorOpts
    {
        /// <summary>
        /// Http connection handler lifetime in minutes
        /// </summary>
        public int Lifetime { get; set; }

        /// <summary>
        /// Testnet or Mainnet flag
        /// </summary>
        public bool   IsTestnet { get; set; }

        /// <summary>
        /// You App Token from Cryptobot
        /// </summary>
        public string  ApiToken { get; set; }
    }
}
