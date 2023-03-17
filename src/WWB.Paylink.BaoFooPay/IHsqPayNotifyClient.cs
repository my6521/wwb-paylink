namespace WWB.Paylink.BaoFooPay;

public interface IHsqPayNotifyClient
{
    Task<T> ExecuteAsync<T>(HttpRequest request, HsqPayOptions options) where T : BaseNotify;

    Task<T> ExecuteAsync<T>(string body, HsqPayOptions options) where T : BaseNotify;
}