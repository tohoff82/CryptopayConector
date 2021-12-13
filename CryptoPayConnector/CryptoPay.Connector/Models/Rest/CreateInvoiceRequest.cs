using CryptoPay.Connector.Extensions;
using CryptoPay.Connector.Models.Rest.RequestBodies;
using CryptoPay.Connector.Utils;

using System;

namespace CryptoPay.Connector.Models.Rest
{
    internal class CreateInvoiceRequest : ApiRequest
    {
        public CreateInvoiceRequest(string asset, double amount, bool allowComments, bool allowAnanymous)
        {
            if (string.IsNullOrEmpty(asset)) throw new ArgumentNullException(
                nameof(asset), $"{nameof(asset)}, must not be null or empty");

            if (amount == 0) throw new ArgumentNullException(
                nameof(amount), $"{nameof(amount)}, must not be over 0");

            Path.Append("/createInvoice");

            RequestBody = new CreateInvoiceBodyBase
            {
                         Asset = asset,
                        Amount = amount,
                 AllowComments = allowComments,
                AllowAnonymous = allowAnanymous,
            };
        }

        public CreateInvoiceRequest(string asset, double amount, PaidButtonType btnType, string btnUrl,  bool allowComments, bool allowAnanymous)
        {
            if (string.IsNullOrEmpty(asset)) throw new ArgumentNullException(
                nameof(asset), $"{nameof(asset)}, must not be null or empty");

            if (amount == 0) throw new ArgumentNullException(
                nameof(amount), $"{nameof(amount)}, must not be over 0");

            if (string.IsNullOrEmpty(btnUrl)) throw new ArgumentNullException(
                nameof(btnUrl), $"{nameof(btnUrl)}, must not be null or empty");

            if (btnType == PaidButtonType.None) throw new ArgumentException(
                nameof(btnType), $"{nameof(btnType)}, must not be None");

            Path.Append("/createInvoice");

            RequestBody = new CreateInvoiceBodyWithButton
            {
                         Asset = asset,
                        Amount = amount,
                 AllowComments = allowComments,
                AllowAnonymous = allowAnanymous,
                PaidButtonName = btnType.ToBtnName(),
                 PaidButtonUrl = btnUrl
            };
        }

        public CreateInvoiceRequest(string asset, double amount, string payload, bool allowComments, bool allowAnanymous)
        {
            if (string.IsNullOrEmpty(asset)) throw new ArgumentNullException(
                nameof(asset), $"{nameof(asset)}, must not be null or empty");

            if (amount == 0) throw new ArgumentNullException(
                nameof(amount), $"{nameof(amount)}, must not be over 0");

            if (payload.IsOverSize()) throw new ArgumentOutOfRangeException(
                 nameof(payload), $"{nameof(payload)}, must not be over 4 kb");

            Path.Append("/createInvoice");

            RequestBody = new CreateInvoiceBodyWithPayload
            {
                         Asset = asset,
                        Amount = amount,
                 AllowComments = allowComments,
                AllowAnonymous = allowAnanymous,
                       Payload = payload
            };
        }

        public CreateInvoiceRequest(string asset, double amount, string payload, string description, bool allowComments, bool allowAnanymous)
        {
            if (string.IsNullOrEmpty(asset)) throw new ArgumentNullException(
                nameof(asset), $"{nameof(asset)}, must not be null or empty");

            if (amount == 0) throw new ArgumentNullException(
                nameof(amount), $"{nameof(amount)}, must not be over 0");

            if (payload.IsOverSize()) throw new ArgumentOutOfRangeException(
                 nameof(payload), $"{nameof(payload)}, must not be over 4 kb");

            if (description.IsOverSymbols()) throw new ArgumentOutOfRangeException(
                 nameof(description), $"{nameof(description)}, must not be over 1024 symbols");

            Path.Append("/createInvoice");

            RequestBody = new CreateInvoiceBodyWithDescription
            {
                         Asset = asset,
                        Amount = amount,
                 AllowComments = allowComments,
                AllowAnonymous = allowAnanymous,
                   Description = description,
                       Payload = payload
            };
        }

        public CreateInvoiceRequest(string asset, double amount, PaidButtonType btnType, string btnUrl, string payload, bool allowComments, bool allowAnanymous)
        {
            if (string.IsNullOrEmpty(asset)) throw new ArgumentNullException(
                nameof(asset), $"{nameof(asset)}, must not be null or empty");

            if (amount == 0) throw new ArgumentNullException(
                nameof(amount), $"{nameof(amount)}, must not be over 0");

            if (string.IsNullOrEmpty(btnUrl)) throw new ArgumentNullException(
                nameof(btnUrl), $"{nameof(btnUrl)}, must not be null or empty");

            if (payload.IsOverSize()) throw new ArgumentOutOfRangeException(
                 nameof(payload), $"{nameof(payload)}, must not be over 4 kb");

            if (btnType == PaidButtonType.None) throw new ArgumentException(
                nameof(btnType), $"{nameof(btnType)}, must not be None");

            Path.Append("/createInvoice");

            RequestBody = new CreateInvoiceBodyWithButtonAndPayload
            {
                         Asset = asset,
                        Amount = amount,
                 AllowComments = allowComments,
                AllowAnonymous = allowAnanymous,
                PaidButtonName = btnType.ToBtnName(),
                 PaidButtonUrl = btnUrl,
                       Payload = payload
            };
        }

        public CreateInvoiceRequest(string asset, double amount, PaidButtonType btnType, string btnUrl, string payload, string description, bool allowComments, bool allowAnanymous)
        {
            if (string.IsNullOrEmpty(asset)) throw new ArgumentNullException(
                nameof(asset), $"{nameof(asset)}, must not be null or empty");

            if (amount == 0) throw new ArgumentNullException(
                nameof(amount), $"{nameof(amount)}, must not be over 0");

            if (string.IsNullOrEmpty(btnUrl)) throw new ArgumentNullException(
                nameof(btnUrl), $"{nameof(btnUrl)}, must not be null or empty");

            if (payload.IsOverSize()) throw new ArgumentOutOfRangeException(
                 nameof(payload), $"{nameof(payload)}, must not be over 4 kb");

            if (description.IsOverSymbols()) throw new ArgumentOutOfRangeException(
                 nameof(description), $"{nameof(description)}, must not be over 1024 symbols");

            if (btnType == PaidButtonType.None) throw new ArgumentException(
                nameof(btnType), $"{nameof(btnType)}, must not be None");

            Path.Append("/createInvoice");

            RequestBody = new CreateInvoiceBodyWithButtonAndDescription
            {
                         Asset = asset,
                        Amount = amount,
                 AllowComments = allowComments,
                AllowAnonymous = allowAnanymous,
                PaidButtonName = btnType.ToBtnName(),
                 PaidButtonUrl = btnUrl,
                   Description = description,
                       Payload = payload
            };
        }
    }
}
