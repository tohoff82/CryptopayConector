namespace CryptoPay.Connector.Extensions
{
    internal static class ArrayExt
    {
        public static string ToCsString(this string[] arr)
        {
            if (arr == null || arr.Length == 0) return string.Empty;

            return string.Join(",", arr);
        }

        public static string ToCsString(this int[] arr)
        {
            if (arr == null || arr.Length == 0) return string.Empty;

            return string.Join(",", arr);
        }
    }
}
