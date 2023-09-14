using System.Threading.Tasks;

namespace WWB.Paylink.JoinPay
{
    public interface IJoinPayClient
    {
        Task<T> ExecuteAsync<T>(IJoinPayRequest<T> request, JoinPayOptions options) where T : JoinPayResponse;
    }
}