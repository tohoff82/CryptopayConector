namespace Cryptopay.Connector.Extensions;

/// <summary>
/// Arrey extensions
/// </summary>
internal static class ArrayExt
{
    /// <summary>
    /// Transform string array to comma separated string
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static string? ToCsvString(this string[]? arr)
    {
        if (arr == default || arr.Length == 0) return default;

        return string.Join(",", arr);
    }

    /// <summary>
    /// Transform int array to comma separated string
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static string? ToCsvString(this int[]? arr)
    {
        if (arr == default || arr.Length == 0) return default;

        return string.Join(",", arr);
    }
}
