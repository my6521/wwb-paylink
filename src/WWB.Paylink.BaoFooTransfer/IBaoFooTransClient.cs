namespace WWB.Paylink.BaoFooTransfer
{
    public interface IBaoFooTransClient
    {
        Task<T> ExecuteAsync<T>(IRequest<T> request, BaoFooTransOptions options) where T : BaseResponse;
    }
}