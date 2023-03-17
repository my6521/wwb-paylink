namespace WWB.Paylink.HsqPay.Domain.Trade;

public class RefundRequestBizModel : HsqPayObject
{
    /// <summary>
    /// 商户订单号
    /// </summary>
    public string transNo { get; set; }

    /// <summary>
    /// 退款类型
    /// </summary>
    public int refundType { get; set; }

    /// <summary>
    /// 原商户订单号
    /// </summary>
    public string origTransNo { get; set; }

    /// <summary>
    /// 原订单金额
    /// </summary>
    public int origOrderAmt { get; set; }

    /// <summary>
    /// 退款金额
    /// </summary>
    public int orderAmt { get; set; }

    /// <summary>
    /// 请求时间
    /// </summary>
    public string requestDate { get; set; }

    /// <summary>
    /// 退款原因
    /// </summary>
    public string refundReason { get; set; }

    /// <summary>
    /// 后端通知地址
    /// </summary>
    public string returnUrl { get; set; }

    /// <summary>
    /// 附加字段
    /// </summary>
    public string extend { get; set; }
}