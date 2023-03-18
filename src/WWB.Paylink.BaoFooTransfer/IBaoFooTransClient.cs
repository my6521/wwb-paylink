using System.Threading.Tasks;

namespace WWB.Paylink.BaoFooTransfer
{
    public interface IBaoFooTransClient
    {
        Task<T> ExecuteAsync<T>(IBaoFooTransRequest<T> request, BaoFooTransOptions options) where T : BaseResponse;
    }
}