namespace WWB.Paylink.BaoFooPay
{
    public interface IBaoFooPayNotifyClient
    {
        Task<T> ExecuteAsync<T>(HttpRequest request, BaoFooPayOptions options) where T : BaseNotify;

        Task<T> ExecuteAsync<T>(string body, BaoFooPayOptions options) where T : BaseNotify;
    }
}