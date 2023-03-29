using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WWB.Paylink.BaoFooTransfer;
using WWB.Paylink.BaoFooTransfer.Notify;

namespace WebApplicationSample.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TransferNotifyController : ControllerBase
    {
        private readonly IOptions<BaoFooTransOptions> _optionsAccessor;
        private readonly IBaoFooTransNotifyClient _client;
        private readonly ILogger<TransferNotifyController> _logger;

        public TransferNotifyController(IOptions<BaoFooTransOptions> optionsAccessor, IBaoFooTransNotifyClient client, ILogger<TransferNotifyController> logger)
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
                notify.ResultData.TransReqDatas.ForEach(data =>
                {
                    data.TransReqData.ForEach(reqData =>
                    {
                        _logger.LogInformation(reqData.TransNo);
                    });
                });

                return Ok(BaoFooTransNotifyResult.Success);
            }
            catch (Exception ex) { }
            {
                return NoContent();
            }
        }
    }
}