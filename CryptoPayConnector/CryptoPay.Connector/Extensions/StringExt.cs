using CryptoPay.Connector.Utils;

using System;
using System.Text;

namespace CryptoPay.Connector.Extensions
{
    internal static class StringExt
    {
        private const ushort _maxPayloadSize = 4096;

        public static bool IsOverSize(this string payload)
        {
            int size = Encoding.Unicode.GetByteCount(payload);

            return size > _maxPayloadSize;
        }

        public static string ToBtnName(this PaidButtonType buttonType)
            => buttonType switch
            {
                   PaidButtonType.ViewItem => "viewItem",
                PaidButtonType.OpenChannel => "openChannel",
                    PaidButtonType.OpenBot => "openBot",
                   PaidButtonType.Callback => "callback",
                                         _ => throw new ArgumentException("Unknown PaidButton type")
            };

        public static T ToEnum<T>(this string value)
            => (T)Enum.Parse(typeof(T), value, true);
    }
}
