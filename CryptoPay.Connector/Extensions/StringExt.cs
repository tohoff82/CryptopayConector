using Cryptopay.Connector.Exceptions;

namespace Cryptopay.Connector.Extensions;

/// <summary>
/// String extennsions class
/// </summary>
public static class StringExt
{
    /// <summary>
    /// Convert token to application identifier
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static long ToApplicationId(this string value)
    {
        var strId = value.Split(':').FirstOrDefault();

        if (string.IsNullOrEmpty(strId))
        {
            throw new CryptopayException("Application id is missing");
        }

        return long.TryParse(strId, out var id) ? id : throw new CryptopayException("Application id is not valid");
    }
}
