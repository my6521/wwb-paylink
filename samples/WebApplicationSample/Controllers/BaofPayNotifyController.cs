using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WWB.Paylink.BaofPay;
using WWB.Paylink.BaofPay.Notify;

namespace WebApplicationSample.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BaofPayNotifyController : ControllerBase
    {
        private readonly IOptions<BaofPayOptions> _optionsAccessor;
        private readonly IBaofPayNotifyClient _client;
        private readonly ILogger<BaofPayNotifyController> _logger;

        public BaofPayNotifyController(IOptions<BaofPayOptions> optionsAccessor, IBaofPayNotifyClient client, ILogger<BaofPayNotifyController> logger)
        {
            _optionsAccessor = optionsAccessor;
            _client = client;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Notify()
        {
            try
            {
                var notify = await _client.ExecuteAsync<TransferNotify>(HttpContext.Request, _optionsAccessor.Value);
                notify.ResultData.trans_reqDatas.ForEach(data =>
                {
                    data.trans_reqData.ForEach(reqData =>
                    {
                        _logger.LogInformation(reqData.trans_no);
                    });
                });

                return BaofPayNotifyResult.TradeHandleSuccess;
            }
            catch (Exception ex) { }
            {
                return BaofPayNotifyResult.TradeHandleFailure;
            }
        }
    }
}