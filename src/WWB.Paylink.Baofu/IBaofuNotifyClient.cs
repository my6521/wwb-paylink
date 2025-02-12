using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WWB.Paylink.Baofu
{
    public interface IBaofuNotifyClient
    {
        Task<T> ExecuteAsync<T>(HttpRequest request, BaofuOptions options) where T : BaseNotify;

        Task<T> ExecuteAsync<T>(string body, BaofuOptions options) where T : BaseNotify;
    }
}