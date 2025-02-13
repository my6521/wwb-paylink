using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WWB.Paylink.Baofu;
using WWB.Paylink.Baofu.Juhe.Notify;

namespace WebApplicationSample.Controllers
{
    /// <summary>
    /// 聚合支付回调
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class JuheNotifyController : ControllerBase
    {
        private readonly IOptions<BaofuOptions> _optionsAccessor;
        private readonly IBaofuNotifyClient _client;

        public JuheNotifyController(IOptions<BaofuOptions> optionsAccessor, IBaofuNotifyClient client)
        {
            _optionsAccessor = optionsAccessor;
            _client = client;
        }

        [HttpPost]
        public async Task<IActionResult> PayNotify()
        {
            try
            {
                var notify = await _client.ExecuteAsync<JuheUnifiedOrderNotify>(HttpContext.Request, _optionsAccessor.Value);
                if (notify.Data.resultCode == "SUCCESS")
                {
                }
                else if (notify.Data.resultCode == "FAIL")
                {
                }

                return Ok(BaofuNotifyResult.Ok);
            }
            catch (Exception ex) { }
            {
                return NoContent();
            }
        }

        [HttpPost]
        public async Task<IActionResult> RefundNotify()
        {
            try
            {
                var notify = await _client.ExecuteAsync<JuheRefundNotify>(HttpContext.Request, _optionsAccessor.Value);
                if (notify.Data.resultCode == "SUCCESS")
                {
                }
                else if (notify.Data.resultCode == "FAIL")
                {
                }

                return Ok(BaofuNotifyResult.Ok);
            }
            catch (Exception ex) { }
            {
                return NoContent();
            }
        }

        [HttpPost]
        public async Task<IActionResult> ShareNotify()
        {
            try
            {
                var notify = await _client.ExecuteAsync<JuheShareAfterPayNotify>(HttpContext.Request, _optionsAccessor.Value);
                if (notify.Data.resultCode == "SUCCESS")
                {
                }
                else if (notify.Data.resultCode == "FAIL")
                {
                }

                return Ok(BaofuNotifyResult.Ok);
            }
            catch (Exception ex) { }
            {
                return NoContent();
            }
        }
    }
}