using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WWB.Paylink.Baofu;
using WWB.Paylink.Baofu.Juhe;
using WWB.Paylink.Baofu.Juhe.Dtos;
using WWB.Paylink.Baofu.Juhe.Request;

namespace WebApplicationSample.Controllers
{
    /// <summary>
    /// 聚合支付
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class JuheController : ControllerBase
    {
        private readonly IOptions<BaofuOptions> _optionsAccessor;
        private readonly IBaofuClient _client;

        public JuheController(IOptions<BaofuOptions> optionsAccessor, IBaofuClient client)
        {
            _optionsAccessor = optionsAccessor;
            _client = client;
        }

        [HttpPost]
        public async Task<IActionResult> UnifiedOrder()
        {
            var payExtend = new Dictionary<String, Object>();
            payExtend.Add("sub_appid", "");
            payExtend.Add("sub_openid", "");
            payExtend.Add("body", "测试商品");
            //payExtend.Add("area_info", "");

            var request = new JuheUnifiedOrderRequest
            {
                agentMerId = "",
                agentTerId = "",
                merId = _optionsAccessor.Value.PayMerId,
                terId = _optionsAccessor.Value.PayTerId,
                outTradeNo = "DD" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                txnAmt = 1000,
                txnTime = DateTime.Now.ToString("yyyyMMddHHmmss"),
                totalAmt = 1000,
                timeExpire = 10,
                prodType = "SHARING",
                orderType = "7",
                payCode = JuhePayCodes.WECHAT_JSAPI,
                payExtend = payExtend,
                subMchId = "",
                notifyUrl = "http://125.71.135.181:7658/api/JuheNotify/PayNotify",
                pageUrl = "",
                forbidCredit = 0,
                attach = "",
                reqReserved = "",
                riskInfo = new RiskInfoEntity
                {
                    locationPoint = "",
                    clientIp = "181.219.133.152"
                }
            };

            var result = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> ShareAfterPay(string outTradeNo)
        {
            var request = new JuheShareAfterPayRequest
            {
                agentMerId = "",
                agentTerId = "",
                merId = _optionsAccessor.Value.PayMerId,
                terId = _optionsAccessor.Value.PayTerId,
                originOutTradeNo = outTradeNo,
                txnTime = DateTime.Now.ToString("yyyyMMddHHmmss"),
                outTradeNo = "S" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                sharingDetails = new List<SharingDetailsEntity>
                {
                    new SharingDetailsEntity{ sharingMerId ="111",sharingAmt =100}
                }
            };

            var result = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> ShareQuery(string outTradeNo)
        {
            var request = new JuheShareQueryRequest
            {
                agentMerId = "",
                agentTerId = "",
                merId = _optionsAccessor.Value.PayMerId,
                terId = _optionsAccessor.Value.PayTerId,
                outTradeNo = outTradeNo
            };

            var result = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> OrderRefund(string outTradeNo)
        {
            var request = new JuheOrderRefundRequest
            {
                agentMerId = "",
                agentTerId = "",
                merId = _optionsAccessor.Value.PayMerId,
                terId = _optionsAccessor.Value.PayTerId,
                originOutTradeNo = outTradeNo,
                outTradeNo = "R" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                txnTime = DateTime.Now.ToString("yyyyMMddHHmmss"),
                refundAmt = 100,
                totalAmt = 100,
                refundReason = "测试退款"
            };

            var result = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> OrderQuery(string outTradeNo)
        {
            var request = new JuheOrderQueryRequest
            {
                agentMerId = "",
                agentTerId = "",
                merId = _optionsAccessor.Value.PayMerId,
                terId = _optionsAccessor.Value.PayTerId,
                outTradeNo = outTradeNo
            };

            var result = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> OrderClose(string outTradeNo)
        {
            var request = new JuheOrderCloseRequest
            {
                agentMerId = "",
                agentTerId = "",
                merId = _optionsAccessor.Value.PayMerId,
                terId = _optionsAccessor.Value.PayTerId,
                outTradeNo = outTradeNo
            };

            var result = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> RefundQuery(string outTradeNo)
        {
            var request = new JuheRefundQueryRequest
            {
                agentMerId = "",
                agentTerId = "",
                merId = _optionsAccessor.Value.PayMerId,
                terId = _optionsAccessor.Value.PayTerId,
                outTradeNo = outTradeNo
            };

            var result = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> OrderBalanceQuery(string outTradeNo)
        {
            var request = new JuheOrderBalanceQueryRequest
            {
                agentMerId = "",
                agentTerId = "",
                merId = _optionsAccessor.Value.PayMerId,
                terId = _optionsAccessor.Value.PayTerId,
                originOutTradeNo = outTradeNo
            };

            var result = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            return Ok(result);
        }
    }
}