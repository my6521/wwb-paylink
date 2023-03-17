using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WWB.Paylink.HsqPay;
using WWB.Paylink.HsqPay.Domain.Trade;
using WWB.Paylink.HsqPay.Request;

namespace WebApplicationSample.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HsqPayController : ControllerBase
    {
        private readonly IHsqPayClient _client;
        private readonly IOptions<HsqPayOptions> _optionsAccessor;

        public HsqPayController(IHsqPayClient client, IOptions<HsqPayOptions> optionsAccessor)
        {
            _client = client;
            _optionsAccessor = optionsAccessor;
        }

        [HttpGet]
        public async Task<IActionResult> AppletPay()
        {
            var body = new AppletPayRequestBizModel
            {
                transNo = "DD" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                payType = HsqPayTradeType.WECHAT_APPLET,
                orderAmt = 1,
                goodsInfo = "测试",
                requestDate = DateTime.Now.ToString("yyyyMMddHHmmss"),
                returnUrl = "",
                pageUrl = "",
                extend = "自定义字段",
            };

            body.SetMemo(new AppletPayRequestMemo()
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
            });

            var request = new AppletPayRequest();

            request.SetBizModel(body);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            if (!response.IsError && response.Data.orderStatus == HsqPayOrderStatus.SUCCESS)
            {
                //成功
            }

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> JsapiPay()
        {
            var body = new JsapiPayRequestBizModel
            {
                transNo = "DD" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                payType = HsqPayTradeType.WECHAT_APPLET,
                orderAmt = 1,
                goodsInfo = "测试",
                requestDate = DateTime.Now.ToString("yyyyMMddHHmmss"),
                returnUrl = "",
                pageUrl = "",
                extend = "自定义字段",
            };

            body.SetMemo(new JsapiPayRequestMemo()
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
            });

            var request = new AppletPayRequest();

            request.SetBizModel(body);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            if (!response.IsError && response.Data.orderStatus == HsqPayOrderStatus.SUCCESS)
            {
                //成功
            }

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> AppPay()
        {
            var body = new AppPayRequestBizModel
            {
                transNo = "DD" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                payType = HsqPayTradeType.WECHAT_APPLET,
                orderAmt = 1,
                goodsInfo = "测试",
                requestDate = DateTime.Now.ToString("yyyyMMddHHmmss"),
                returnUrl = "",
                pageUrl = "http://www.baidu.com",
                extend = "自定义字段",
            };

            body.SetMemo(new AppPayRequestMemo()
            {
                paylimit = "balance",
                timeExpire = "",
                spbillCreateIp = "172.22.11.2",
                latitude = "",
                longitude = "116.397128",
            });

            var request = new AppletPayRequest();

            request.SetBizModel(body);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            if (!response.IsError && response.Data.orderStatus == HsqPayOrderStatus.SUCCESS)
            {
                //成功
            }

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> DynamicScanPay()
        {
            var body = new DynamicScanPayRequestBizModel
            {
                transNo = "DD" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                payType = HsqPayTradeType.WECHAT_APPLET,
                orderAmt = 1,
                goodsInfo = "测试",
                requestDate = DateTime.Now.ToString("yyyyMMddHHmmss"),
                returnUrl = "",
                pageUrl = "http://www.baidu.com",
                extend = "自定义字段",
            };

            body.SetMemo(new DynamicScanPayRequestMemo()
            {
                paylimit = "balance",
                timeExpire = "",
                spbillCreateIp = "172.22.11.2",
                latitude = "",
                longitude = "116.397128",
            });

            var request = new AppletPayRequest();

            request.SetBizModel(body);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            if (!response.IsError && response.Data.orderStatus == HsqPayOrderStatus.SUCCESS)
            {
                //成功
            }

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> BarcodePay()
        {
            var body = new BarcodePayRequestBizModel
            {
                transNo = "DD" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                payType = HsqPayTradeType.WECHAT_APPLET,
                orderAmt = 1,
                goodsInfo = "测试",
                requestDate = DateTime.Now.ToString("yyyyMMddHHmmss"),
                returnUrl = "",
                pageUrl = "http://www.baidu.com",
                extend = "自定义字段",
            };

            body.SetMemo(new BarcodePayRequestMemo()
            {
                paylimit = "balance",
                timeExpire = "",
                spbillCreateIp = "172.22.11.2",
                latitude = "",
                longitude = "116.397128",
            });

            var request = new AppletPayRequest();

            request.SetBizModel(body);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            if (!response.IsError && response.Data.orderStatus == HsqPayOrderStatus.SUCCESS)
            {
                //成功
            }

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> ComplaintQuery()
        {
            var body = new ComplaintQueryRequestBizModel
            {
            };

            var request = new WeChatPayComplaintQueryRequest();

            request.SetBizModel(body);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            if (!response.IsError)
            {
                //成功
            }

            return Ok(response);
        }
    }
}