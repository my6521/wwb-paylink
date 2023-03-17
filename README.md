惠收钱支付文档
===

API接口文档
---
|宝户通文档|	说明|
| ---- | ---- |
|文档地址|	https://docs.huishouqian.com/|


第一步 在appsettings.json添加宝付支付的选项
````json
"HsqPayConfig": {
    "MchId": "814000473149",                      //商户号
    "Key": "86a8eec5ae958e9948b7450439cc57e2",    //商户签名混淆密码
    "PrivateCert": "Cert\\814000473149_pri.pfx",  //商户私钥
    "PrivateCertPassword": "123456",              //商户私钥密码
    "PublicCert": "Cert\\MANDAO_814000473149_pub.cer" //惠收钱平台公钥
  },
````

第二步 引入BaoFoo到项目中
````c#

builder.Services.Configure<HsqPayOptions>(builder.Configuration.GetSection("HsqPayConfig"));
builder.Services.AddHsqPay();

````

第三步 构造函数中引入IHsqPayClient和HsqPayOptions
````c#
    private readonly IHsqPayClient _hsqPayClient;
    private readonly HsqPayOptions _hsqPayOptions;

    public HsqPayTestController(IHsqPayClient hsqPayClient, HsqPayOptions hsqPayOptions)
    {
        _hsqPayClient = hsqPayClient;
        _hsqPayOptions = hsqPayOptions;
    }


    /// <summary>
    /// 小程序支付
    /// </summary>
    /// <returns></returns>
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

    /// <summary>
    /// JSAPI支付
    /// </summary>
    /// <returns></returns>
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

    /// <summary>
    /// APP支付
    /// </summary>
    /// <returns></returns>
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

    /// <summary>
    /// 主扫支付
    /// </summary>
    /// <returns></returns>
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

    /// <summary>
    /// 被扫支付
    /// </summary>
    /// <returns></returns>
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

    /// <summary>
    /// 微信投诉查询
    /// </summary>
    /// <returns></returns>
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
````

第四步 回调构造函数引入IHsqPayNotifyClient和HsqPayOptions
````c#

  private readonly IHsqPayNotifyClient _client;
  private readonly IOptions<HsqPayOptions> _optionsAccessor;

  public HsqPayNotifyController(IHsqPayNotifyClient client, IOptions<HsqPayOptions> optionsAccessor)
  {
      _client = client;
      _optionsAccessor = optionsAccessor;
  }
  /// <summary>
  /// 支付回调
  /// </summary>
  /// <returns></returns>
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

  /// <summary>
  /// 退款回调
  /// </summary>
  /// <returns></returns>
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

  /// <summary>
  /// 微信投诉回调
  /// </summary>
  /// <returns></returns>
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
````