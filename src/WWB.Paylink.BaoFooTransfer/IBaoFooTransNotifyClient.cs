namespace WWB.Paylink.BaoFooTransfer
{
    public interface IBaoFooTransNotifyClient
    {
        Task<T> ExecuteAsync<T>(HttpRequest request, BaoFooTransOptions options) where T : BaseNotify;

        Task<T> ExecuteAsync<T>(string body, BaoFooTransOptions options) where T : BaseNotify;
    }
}