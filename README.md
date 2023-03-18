宝付收款文档
===

API接口文档
---
|宝付收款文档|	说明|
| ---- | ---- |
|文档地址|	https://docs.huishouqian.com/|


第一步 在appsettings.json添加宝付支付的选项
````json
 "BaofooPayConfig": {
    "MerchantNo": "814000473149",
    "Key": "86a8eec5ae958e9948b7450439cc57e2",
    "PfxCertificate": "Cert\\814000473149_pri.pfx",
    "Password": "123456",
    "CerCertificate": "Cert\\MANDAO_814000473149_pub.cer",
    "Debug": true
  }
````

第二步 引入BaoFoo到项目中
````c#

 builder.Services.Configure<BaoFooPayOptions>(builder.Configuration.GetSection("BaofooPayConfig"));
 builder.Services.AddHsqPay();

````

第三步 支付API构造函数中引入IBaoFooPayClient和BaoFooPayOptions
````c#
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
````

第四步 回调API构造函数中引入IBaoFooPayNotifyClient和BaoFooPayOptions

````c#

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

            return Ok("Success");
        }
        catch (Exception ex) { }
        {
            return NoContent();
        }
    }

````