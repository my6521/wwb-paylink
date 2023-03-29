using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WWB.Paylink.BaoFooPay;
using WWB.Paylink.BaoFooPay.Notify;

namespace WebApplicationSample.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PaymentNotifyController : ControllerBase
    {
        private readonly IBaoFooPayNotifyClient _client;
        private readonly IOptions<BaoFooPayOptions> _optionsAccessor;

        public PaymentNotifyController(IBaoFooPayNotifyClient client, IOptions<BaoFooPayOptions> optionsAccessor)
        {
            _client = client;
            _optionsAccessor = optionsAccessor;
        }

        [HttpPost]
        public async Task<IActionResult> PayNotify()
        {
            try
            {
                var notify = await _client.ExecuteAsync<PaymentNotify>(HttpContext.Request, _optionsAccessor.Value);

                return Ok(BaoFooPayNotifyResult.Success);
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
                var notify = await _client.ExecuteAsync<RefundNotify>(HttpContext.Request, _optionsAccessor.Value);

                return Ok(BaoFooPayNotifyResult.Success);
            }
            catch (Exception ex) { }
            {
                return NoContent();
            }
        }

        [HttpPost]
        public async Task<IActionResult> ComplaintNotify()
        {
            try
            {
                var notify = await _client.ExecuteAsync<WeChatPayComplaintNotify>(HttpContext.Request, _optionsAccessor.Value);

                return Ok(BaoFooPayNotifyResult.Success);
            }
            catch (Exception ex) { }
            {
                return NoContent();
            }
        }
    }
}