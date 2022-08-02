using System.Security.Cryptography;
using System.Text;
using Cryptopay.Connector.Models.Value;

namespace Cryptopay.Connector.Utils;

/// <summary>
/// Helper for check update signature
/// </summary>
public static class Helper
{
    /// <summary>
    /// This method verify the integrity of the received data
    /// </summary>
    /// <param name="signature">Sting from header parameter <c>crypto-pay-api-signature</c></param>
    /// <param name="token">Your application token from CryptoPay</param>
    /// <param name="body">Response Update body</param>
    /// <returns><c>true</c> if the header parameter <c>crypto-pay-api-signature</c> equals hash of request body</returns>
    public static bool CheckSignature(string signature, string token, Update body)
    {
        using var sha256Hash = SHA256.Create();
        var secret = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(token));

        using var hmac  = new HMACSHA256(secret);
        var checkedStr  = Encoding.UTF8.GetBytes(body.ToString());
        var checkedHash = hmac.ComputeHash(checkedStr);
        var checkedHex  = Convert.ToHexString(checkedHash).ToLower();

        return checkedHex == signature;
    }
}
