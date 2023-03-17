namespace WWB.Paylink.HsqPay.Domain.Trade;

public class TransactionQueryRequestBizModel : HsqPayObject
{
    /// <summary>
    /// 商户订单号
    /// </summary>
    public string transNo { get; set; }

    /// <summary>
    /// 查询类型
    /// </summary>
    public int queryType { get; set; }
}