namespace WWB.Paylink.HsqPay.Domain.Trade;

public class DynamicScanPayRequestMemo
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
}