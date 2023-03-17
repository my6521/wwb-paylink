namespace WWB.Paylink.HsqPay.Domain.Trade;

public class AppPayResponseResult
{
    /// <summary>
    /// 商户订单号
    /// </summary>
    public string transNo { get; set; }

    /// <summary>
    /// 交易订单号
    /// </summary>
    public string tradeNo { get; set; }

    /// <summary>
    /// 交易金额
    /// </summary>
    public int orderAmt { get; set; }

    /// <summary>
    /// orderStatus
    /// </summary>
    public string orderStatus { get; set; }

    /// <summary>
    /// 完成时间
    /// </summary>
    public string finishedDate { get; set; }

    /// <summary>
    /// 错误码
    /// </summary>
    public string respCode { get; set; }

    /// <summary>
    /// 错误信息
    /// </summary>
    public string respMsg { get; set; }

    /// <summary>
    /// 预支付交易会话标识
    /// </summary>
    public string qrCode { get; set; }
}