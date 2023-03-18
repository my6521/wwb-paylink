using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WWB.Paylink.BaoFooPay;
using WWB.Paylink.BaoFooPay.Constants;
using WWB.Paylink.BaoFooPay.Domain.ReqMemo;
using WWB.Paylink.BaoFooPay.Request;

namespace WebApplicationSample.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PaymentController : ControllerBase
    {
        private readonly IBaoFooPayClient _client;
        private readonly IOptions<BaoFooPayOptions> _optionsAccessor;

        public PaymentController(IBaoFooPayClient client, IOptions<BaoFooPayOptions> optionsAccessor)
        {
            _client = client;
            _optionsAccessor = optionsAccessor;
        }

        /// <summary>
        /// 小程序支付
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AppletPay()
        {
            var request = new AppletPayRequest()
            {
                TransNo = "DD" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                PayType = TradeType.WECHAT_APPLET,
                OrderAmt = 1,
                GoodsInfo = "测试",
                RequestDate = DateTime.Now.ToString("yyyyMMddHHmmss"),
                ReturnUrl = "",
                PageUrl = "",
                Extend = "自定义字段",
                Memo = new AppletPayRequestMemo()
                {
                    PayLimit = "balance",
                    TimeExpire = "",
                    AppId = "wxb63c89abb9243ad0",
                    OpenId = "oUpF8uMuAJO_M2pxb1Q9zNjWeS6o",
                    SpbillCreateIp = "172.22.11.2",
                    Latitude = "",
                    Longitude = "116.397128",
                    AppVersion = "39.916527",
                    AreaInfo = "",
                    DeviceNo = "",
                    DeviceType = ""
                }
            };

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> AppPay()
        {
            var request = new AppPayRequest()
            {
                TransNo = "DD" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                PayType = TradeType.WECHAT_APPLET,
                OrderAmt = 1,
                GoodsInfo = "测试",
                RequestDate = DateTime.Now.ToString("yyyyMMddHHmmss"),
                ReturnUrl = "",
                PageUrl = "",
                Extend = "自定义字段",
                Memo = new AppPayRequestMemo()
                {
                    PayLimit = "balance",
                    TimeExpire = "",
                    SpbillCreateIp = "172.22.11.2",
                    Latitude = "",
                    Longitude = "116.397128",
                }
            };

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> JsapiPay()
        {
            var request = new JsapiPayRequest()
            {
                TransNo = "DD" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                PayType = TradeType.WECHAT_APPLET,
                OrderAmt = 1,
                GoodsInfo = "测试",
                RequestDate = DateTime.Now.ToString("yyyyMMddHHmmss"),
                ReturnUrl = "",
                PageUrl = "",
                Extend = "自定义字段",
                Memo = new JsapiPayRequestMemo()
                {
                    PayLimit = "balance",
                    TimeExpire = "",
                    AppId = "wxb63c89abb9243ad0",
                    OpenId = "oUpF8uMuAJO_M2pxb1Q9zNjWeS6o",
                    SpbillCreateIp = "172.22.11.2",
                    Latitude = "",
                    Longitude = "116.397128",
                    AppVersion = "39.916527",
                    AreaInfo = "",
                    DeviceNo = "",
                    DeviceType = ""
                }
            };

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> BarcodePay()
        {
            var request = new BarcodePayRequest()
            {
                TransNo = "DD" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                PayType = TradeType.WECHAT_APPLET,
                OrderAmt = 1,
                GoodsInfo = "测试",
                RequestDate = DateTime.Now.ToString("yyyyMMddHHmmss"),
                ReturnUrl = "",
                PageUrl = "",
                Extend = "自定义字段",
                Memo = new BarcodePayRequestMemo()
                {
                    PayLimit = "balance",
                    TimeExpire = "",
                    SpbillCreateIp = "172.22.11.2",
                    Latitude = "",
                    Longitude = "116.397128",
                }
            };

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> DynamicScanPay()
        {
            var request = new DynamicScanPayRequest()
            {
                TransNo = "DD" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                PayType = TradeType.WECHAT_APPLET,
                OrderAmt = 1,
                GoodsInfo = "测试",
                RequestDate = DateTime.Now.ToString("yyyyMMddHHmmss"),
                ReturnUrl = "",
                PageUrl = "",
                Extend = "自定义字段",
                Memo = new DynamicScanPayRequestMemo()
                {
                    PayLimit = "balance",
                    TimeExpire = "",
                    SpbillCreateIp = "172.22.11.2",
                    Latitude = "",
                    Longitude = "116.397128",
                }
            };

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            return Ok(response);
        }
    }
}