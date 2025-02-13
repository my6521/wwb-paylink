using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WWB.Paylink.Baofu;

namespace WebApplicationSample.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UnionGWNotifyController : ControllerBase
    {
        private readonly IOptions<BaofuOptions> _optionsAccessor;
        private readonly IBaofuNotifyClient _client;

        public UnionGWNotifyController(IOptions<BaofuOptions> optionsAccessor, IBaofuNotifyClient client)
        {
            _optionsAccessor = optionsAccessor;
            _client = client;
        }
    }
}