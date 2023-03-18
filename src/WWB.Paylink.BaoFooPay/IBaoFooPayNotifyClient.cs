using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WWB.Paylink.BaoFooPay
{
    public interface IBaoFooPayNotifyClient
    {
        Task<TResponse> ExecuteAsync<TResponse>(HttpRequest request, BaoFooPayOptions options) where TResponse : BaseNotify;

        Task<TResponse> ExecuteAsync<TResponse>(string body, BaoFooPayOptions options) where TResponse : BaseNotify;
    }
}