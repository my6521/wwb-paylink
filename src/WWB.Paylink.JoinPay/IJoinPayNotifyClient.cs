using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WWB.Paylink.JoinPay
{
    public interface IJoinPayNotifyClient
    {
        Task<T> ExecuteAsync<T>(HttpRequest request, JoinPayOptions options) where T : JoinPayNotify;
        Task<T> ExecuteAsync<T>(string body, JoinPayOptions options) where T : JoinPayNotify;
    }
}