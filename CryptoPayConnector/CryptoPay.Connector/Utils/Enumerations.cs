namespace CryptoPay.Connector.Utils
{
    public enum PaidButtonType
    {
        ViewItem    = 1,
        OpenChannel = 2,
        OpenBot     = 3,
        Callback    = 4
    }

    public enum InvoiceStatus
    {
        Active = 1,
        Paid   = 2
    }
}
