using CryptoPay.Connector.Extensions;
using CryptoPay.Connector.Models.Rest.RequestBodies;
using CryptoPay.Connector.Utils;

using System;

namespace CryptoPay.Connector.Models.Rest
{
    internal class GetInvoicesRequest : ApiRequest
    {
        public GetInvoicesRequest(string[] assets, int[] ids, InvoiceStatus status, ushort offset, ushort count)
        {
            if (count.IsOverCount()) throw new ArgumentOutOfRangeException(
                nameof(count), $"{nameof(count)},  must not be over 1000");

            Path.Append("/getInvoices");

            RequestBody = new GetInvoicesBody
            {
                InvoiceId = ids.ToCsString(),
                   Status = status.ToStatusName(),
                    Asset = assets.ToCsString(),
                   Offset = offset,
                    Count = count
            };
        }
    }
}
