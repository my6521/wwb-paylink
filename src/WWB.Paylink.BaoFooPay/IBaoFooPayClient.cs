namespace WWB.Paylink.BaoFooPay
{
    public interface IBaoFooPayClient
    {
        Task<T> ExecuteAsync<T>(IRequest<T> request, BaoFooPayOptions options) where T : BaseResponse;
    }
}