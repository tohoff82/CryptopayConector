namespace Cryptopay.Connector.Utils;

/// <summary>
/// Available currencies
/// </summary>
public enum Assets
{
    None = 0,
    // Crypto
    BTC  = 1,
    TON  = 2,
    BNB  = 3,
    USDT = 4,
    USDC = 5,
    BUSD = 6,
    ETH  = 7, //(testnet only)

    //Fiat
    //RUB = 100,
    //USD = 101,
    //EUR = 102,
    //BYN = 103,
    //UAH = 104,
    //GBP = 105,
    //CNY = 106,
    //KZT = 107
}

/// <summary>
/// Buttons that will be shown to a user
/// </summary>
public enum PaidButtonNames
{
    viewItem    = 0,
    openChannel = 1,
    openBot     = 2,
    callback    = 3
}

/// <summary>
/// Types of invoices to be returned
/// </summary>
public enum InvoiceTypes
{
    none    = 0,
    active  = 1,
    paid    = 2,
    expired = 3
}

/// <summary>
/// Types of the transfer
/// </summary>
public enum TransferTypes
{
    none      = 0,
    completed = 1
}

/// <summary>
/// Type of incoming Updates
/// </summary>
public enum UpdateTypes
{
    none         = 0,
    invoice_paid = 1
}
