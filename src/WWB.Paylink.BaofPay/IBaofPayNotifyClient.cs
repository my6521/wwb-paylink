namespace WWB.Paylink.BaofPay;

public interface IBaofPayNotifyClient
{
    Task<T> ExecuteAsync<T>(HttpRequest request, BaofPayOptions options) where T : BaofPayNotify;

    Task<T> ExecuteAsync<T>(string body, BaofPayOptions options) where T : BaofPayNotify;
}