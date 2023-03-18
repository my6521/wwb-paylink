using System.Threading.Tasks;

namespace WWB.Paylink.BaoFooPay
{
    public interface IBaoFooPayClient
    {
        Task<TResponse> ExecuteAsync<TResponse>(IBaoFooPayRequest<TResponse> request, BaoFooPayOptions options) where TResponse : BaseResponse;
    }
}