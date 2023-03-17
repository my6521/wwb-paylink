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
                    paylimit = "balance",
                    timeExpire = "",
                    appid = "wxb63c89abb9243ad0",
                    openid = "oUpF8uMuAJO_M2pxb1Q9zNjWeS6o",
                    spbillCreateIp = "172.22.11.2",
                    latitude = "",
                    longitude = "116.397128",
                    appVersion = "39.916527",
                    areaInfo = "",
                    deviceNo = "",
                    deviceType = ""
                }
            };

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            if (response.Success)
            {
                //成功
            }

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
                    paylimit = "balance",
                    timeExpire = "",
                    spbillCreateIp = "172.22.11.2",
                    latitude = "",
                    longitude = "116.397128",
                }
            };

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            if (response.Success)
            {
                //成功
            }

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
                    paylimit = "balance",
                    timeExpire = "",
                    appid = "wxb63c89abb9243ad0",
                    openid = "oUpF8uMuAJO_M2pxb1Q9zNjWeS6o",
                    spbillCreateIp = "172.22.11.2",
                    latitude = "",
                    longitude = "116.397128",
                    appVersion = "39.916527",
                    areaInfo = "",
                    deviceNo = "",
                    deviceType = ""
                }
            };

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            if (response.Success)
            {
                //成功
            }

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
                    paylimit = "balance",
                    timeExpire = "",
                    spbillCreateIp = "172.22.11.2",
                    latitude = "",
                    longitude = "116.397128",
                }
            };

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            if (response.Success)
            {
                //成功
            }

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
                    paylimit = "balance",
                    timeExpire = "",
                    spbillCreateIp = "172.22.11.2",
                    latitude = "",
                    longitude = "116.397128",
                }
            };

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            if (response.Success)
            {
                //成功
            }

            return Ok(response);
        }
    }
}