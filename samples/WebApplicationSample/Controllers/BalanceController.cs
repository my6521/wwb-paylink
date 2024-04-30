using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WWB.Paylink.BaoFooTransfer;
using WWB.Paylink.BaoFooTransfer.Constants;
using WWB.Paylink.BaoFooTransfer.Request;

namespace WebApplicationSample.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BalanceController : ControllerBase
    {
        private readonly IOptions<BaoFooTransOptions> _optionsAccessor;
        private readonly IBaoFooTransClient _client;

        public BalanceController(IOptions<BaoFooTransOptions> optionsAccessor, IBaoFooTransClient client)
        {
            _optionsAccessor = optionsAccessor;
            _client = client;
        }

        [HttpGet]
        public async Task<IActionResult> Query()
        {
            var request = new QueryBalanceRequest
            {
                AccountType = AccountTypeConst.BASE_ACCOUNT,
            };

            var result = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> QueryAll()
        {
            var request = new QueryAllBalanceRequest();
            var result = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            return Ok();
        }
    }
}