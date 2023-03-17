namespace WWB.Paylink.HsqPay;

public interface IHsqPayNotifyClient
{
    Task<T> ExecuteAsync<T>(HttpRequest request, HsqPayOptions options) where T : HsqPayNotify;

    Task<T> ExecuteAsync<T>(string body, HsqPayOptions options) where T : HsqPayNotify;
}