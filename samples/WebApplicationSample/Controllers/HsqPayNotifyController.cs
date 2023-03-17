using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WWB.Paylink.HsqPay;
using WWB.Paylink.HsqPay.Notify;

namespace WebApplicationSample.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HsqPayNotifyController : ControllerBase
    {
        private readonly IHsqPayNotifyClient _client;
        private readonly IOptions<HsqPayOptions> _optionsAccessor;

        public HsqPayNotifyController(IHsqPayNotifyClient client, IOptions<HsqPayOptions> optionsAccessor)
        {
            _client = client;
            _optionsAccessor = optionsAccessor;
        }

        [HttpPost]
        public async Task<IActionResult> PayNotify()
        {
            try
            {
                var notify = await _client.ExecuteAsync<HsqPayTransactionNotify>(HttpContext.Request, _optionsAccessor.Value);

                return HsqPayNotifyResult.TradeHandleSuccess;
            }
            catch (Exception ex) { }
            {
                return HsqPayNotifyResult.TradeHandleFailure;
            }
        }

        [HttpPost]
        public async Task<IActionResult> RefundNotify()
        {
            try
            {
                var notify = await _client.ExecuteAsync<HsqPayRefundNotify>(HttpContext.Request, _optionsAccessor.Value);

                return HsqPayNotifyResult.TradeHandleSuccess;
            }
            catch (Exception ex) { }
            {
                return HsqPayNotifyResult.TradeHandleFailure;
            }
        }

        [HttpPost]
        public async Task<IActionResult> ComplaintNotify()
        {
            try
            {
                var notify = await _client.ExecuteAsync<WeChatPayComplaintNotify>(HttpContext.Request, _optionsAccessor.Value);

                return HsqPayNotifyResult.TradeHandleSuccess;
            }
            catch (Exception ex) { }
            {
                return HsqPayNotifyResult.TradeHandleFailure;
            }
        }
    }
}