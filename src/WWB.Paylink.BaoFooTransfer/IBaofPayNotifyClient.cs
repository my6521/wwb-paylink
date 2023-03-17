namespace WWB.Paylink.BaoFooTransfer;

public interface IBaofPayNotifyClient
{
    Task<T> ExecuteAsync<T>(HttpRequest request, BaofPayOptions options) where T : BaofPayNotify;

    Task<T> ExecuteAsync<T>(string body, BaofPayOptions options) where T : BaofPayNotify;
}