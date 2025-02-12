using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WWB.Paylink.Baofu;
using WWB.Paylink.Baofu.UnionGW;
using WWB.Paylink.Baofu.UnionGW.Request;
using static WWB.Paylink.Baofu.UnionGW.Request.AccCreateRequest;

namespace WebApplicationSample.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UnionGWController : ControllerBase
    {
        private readonly IOptions<BaofuOptions> _optionsAccessor;
        private readonly IBaofuClient _client;

        public UnionGWController(IOptions<BaofuOptions> optionsAccessor, IBaofuClient client)
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
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> QueryAll()
        {
            var request = new QueryAllBalanceRequest();
            var result = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> AccCreate()
        {
            var request = new AccCreateRequest
            {
                accType = 1,
                accInfo = new PersonAccInfo
                {
                    transSerialNo = "C" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                    loginNo = "270046192476",
                    customerName = "双彦飞",
                    certificateType = "ID",
                    certificateNo = "340102200001010458",
                    cardNo = "6228480402564890016",
                    mobileNo = "13567796514",
                    cardUserName = "双彦飞",
                },
                noticeUrl = "http://"
            };
            var result = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> AccQuery()
        {
            var request = new AccQueryRequest
            {
                certificateNo = "340102200001010458",
                certificateType = "ID",
                platformNo = _optionsAccessor.Value.MerchantNo,
                loginNo = "270046192476",
                accType = 1,
            };
            var result = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            return Ok(result);
        }
    }
}