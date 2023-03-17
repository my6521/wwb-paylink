namespace WWB.Paylink.BaoFooTransfer;

public interface IBaofPayClient
{
    Task<T> ExecuteAsync<T>(IBaofPayRequest<T> request, BaofPayOptions options) where T : BaofPayResponse;
}