using System.Net;
using System.Runtime.CompilerServices;
using Cryptopay.Connector.Models.Value;

namespace Cryptopay.Connector.Exceptions;

/// <summary>
/// Exception included Error
/// </summary>
public class CryptopayException : Exception
{
    /// <summary>
    /// Initializes a new instance
    /// </summary>
    /// <param name="message">The message that describes the error</param>
    public CryptopayException(string message)
        : base(message) {}

    /// <summary>
    /// Initializes a new instance
    /// </summary>
    /// <param name="message">
    /// The error message that explains the reason for the exception
    /// </param>
    /// <param name="error"></param>
    /// <param name="httpStatusCode">
    /// HttpStatusCode of the received response.
    /// </param>
    public CryptopayException(string message, Error error, HttpStatusCode httpStatusCode)
        : base(PrepareErrorMessage(message, error))
    {
                 Error = error;
        HttpStatusCode = httpStatusCode;
    }

    /// <summary>
    /// HttpStatusCodeof the received response
    /// </summary>
    public HttpStatusCode? HttpStatusCode { get; }

    /// <summary>
    /// Error from response
    /// </summary>
    public Error? Error { get; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string PrepareErrorMessage(string message, Error error)
    {
        if (error is null) return message;
        
        var errorMessage = $"Code: {error.Code} Name: {error.Name}";

        return message is null
            ? errorMessage
            : $"{message}{Environment.NewLine}{errorMessage}";
    }
}
