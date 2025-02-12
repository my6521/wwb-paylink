using System.Threading.Tasks;

namespace WWB.Paylink.Baofu
{
    public interface IBaofuClient
    {
        Task<T> ExecuteAsync<T>(IBaofuRequest<T> request, BaofuOptions options) where T : BaseResponse;
    }
}