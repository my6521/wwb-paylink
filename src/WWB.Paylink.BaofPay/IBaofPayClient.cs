namespace WWB.Paylink.BaofPay;

public interface IBaofPayClient
{
    Task<T> ExecuteAsync<T>(IBaofPayRequest<T> request, BaofPayOptions options) where T : BaofPayResponse;
}