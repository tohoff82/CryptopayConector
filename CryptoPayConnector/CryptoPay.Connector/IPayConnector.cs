using CryptoPay.Connector.Models.Rest;

using System.Threading.Tasks;

namespace CryptoPay.Connector
{
    public interface IPayConnector
    {
        Task<GetMeResponse> GetMeAsync();
    }
}
