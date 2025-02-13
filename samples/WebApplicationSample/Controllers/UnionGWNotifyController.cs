using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WWB.Paylink.Baofu;
using WWB.Paylink.Baofu.UnionGW.Notify;

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

        [HttpPost]
        public async Task<IActionResult> AccCreateNotify()
        {
            try
            {
                var notify = await _client.ExecuteAsync<AccCreateNotify>(HttpContext.Request, _optionsAccessor.Value);

                return Ok("OK");
            }
            catch (Exception ex) { }
            {
                return NoContent();
            }
        }

        [HttpPost]
        public async Task<IActionResult> AccWithdrawNotify()
        {
            try
            {
                var notify = await _client.ExecuteAsync<AccWithdrawNotify>(HttpContext.Request, _optionsAccessor.Value);

                return Ok("OK");
            }
            catch (Exception ex) { }
            {
                return NoContent();
            }
        }
    }
}