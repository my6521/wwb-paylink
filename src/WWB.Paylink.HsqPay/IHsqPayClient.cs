namespace WWB.Paylink.HsqPay;

public interface IHsqPayClient
{
    Task<T> ExecuteAsync<T>(IHsqPayRequest<T> request, HsqPayOptions options) where T : HsqPayResponse;
}