namespace CryptoPay.Connector.Utils
{
    public enum PaidButtonType
    {
        ViewItem    = 1,
        OpenChannel = 2,
        OpenBot     = 3,
        Callback    = 4,
        None        = 5
    }

    public enum InvoiceStatus
    {
        All    = 1,
        Active = 2,
        Paid   = 3
    }
}
