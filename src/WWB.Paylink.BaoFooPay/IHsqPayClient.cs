namespace WWB.Paylink.BaoFooPay;

public interface IHsqPayClient
{
    Task<T> ExecuteAsync<T>(IRequest<T> request, HsqPayOptions options) where T : BaseResponse;
}