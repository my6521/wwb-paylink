namespace WWB.Paylink.HsqPay.Domain.Trade;

public class RefundQueryRequestBizModel : HsqPayObject
{
    /// <summary>
    /// 商户订单号
    /// </summary>
    /// <remarks>
    /// 原退款交易对应的商户订单号
    /// </remarks>
    public string transNo { get; set; }
}