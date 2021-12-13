using CryptoPay.Connector.Utils;

using System;
using System.Text;

namespace CryptoPay.Connector.Extensions
{
    internal static class ValidateExt
    {
        private const ushort _maxPayloadSize = 4096;
        private const ushort _maxDescSymbols = 1024;
        private const ushort   _maxCountSize = 1000;

        public static bool IsOverSize(this string payload)
            => Encoding.Unicode.GetByteCount(payload) > _maxPayloadSize;

        public static bool IsOverSymbols(this string description)
            => description.ToCharArray().Length > _maxDescSymbols;

        public static string ToBtnName(this PaidButtonType buttonType)
            => buttonType switch
            {
                   PaidButtonType.ViewItem => "viewItem",
                PaidButtonType.OpenChannel => "openChannel",
                    PaidButtonType.OpenBot => "openBot",
                   PaidButtonType.Callback => "callback",
                                         _ => string.Empty
            };

        public static string ToStatusName(this InvoiceStatus status)
            => status switch
            {
                InvoiceStatus.Active => "active",
                  InvoiceStatus.Paid => "paid",
                                   _ => "all"
            };

        public static T ToEnum<T>(this string value)
            => (T)Enum.Parse(typeof(T), value, true);

        public static bool IsOverCount(this ushort count)
            => count > _maxCountSize;
    }
}
