namespace WWB.Paylink.HsqPay.Domain.Trade;

public class JsapiPayRequestMemo
{
    /// <summary>
    /// 交易结束时间
    /// </summary>
    /// <remarks>
    /// 订单失效时间，格式[yyyyMMddHHmmss]，
    /// 建议：最短失效时间间隔大于1分钟
    /// </remarks>
    public string timeExpire { get; set; }

    /// <summary>
    /// 限制卡类型
    /// </summary>
    public string paylimit { get; set; }

    /// <summary>
    /// 	终端用户IP
    /// </summary>
    public string spbillCreateIp { get; set; }

    /// <summary>
    /// 经度
    /// </summary>
    public string longitude { get; set; }

    /// <summary>
    /// 纬度
    /// </summary>
    public string latitude { get; set; }

    /// <summary>
    /// 微信公众号APPID
    /// </summary>
    public string appid { get; set; }

    /// <summary>
    /// 用户标识
    /// </summary>
    /// <remarks>
    /// 用户在商户appid下的唯一标识。下单前需获取到用户的Openid，获取详见微信,支付宝
    /// </remarks>
    public string openid { get; set; }

    /// <summary>
    /// 区域信息
    /// </summary>
    public string areaInfo { get; set; }

    /// <summary>
    /// 应用程序版本
    /// </summary>
    /// <remarks>
    /// 银联选填 固定8位，长度不足右补空格
    /// </remarks>
    public string appVersion { get; set; }

    /// <summary>
    /// 设备类型
    /// </summary>
    /// <remarks>
    /// 银联选填 终端设备类型，取值如下:
    /// 01：自动柜员机（含 ATM 和 CDM）和多媒体自助终端
    /// 02：传统 POS
    /// 03：mPOS
    /// 04：智能 POS
    /// 05：II型固定电话
    /// </remarks>
    public string deviceType { get; set; }

    /// <summary>
    /// 终端设备号
    /// </summary>
    /// <remarks>
    /// 银联选填 最多50位，终端设备的硬件序列号
    /// </remarks>
    public string deviceNo { get; set; }
}