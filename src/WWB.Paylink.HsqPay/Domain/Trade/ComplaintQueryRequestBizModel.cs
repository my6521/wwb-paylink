namespace WWB.Paylink.HsqPay.Domain.Trade;

public class ComplaintQueryRequestBizModel : HsqPayObject
{
    public string beginDate { get; set; }
    public string endDate { get; set; }
    public string limit { get; set; }
    public string offset { get; set; }
    public string agentMerchantNo { get; set; }
    public string merchantNo { get; set; }
    public string complaintId { get; set; }
    public string merchantTradeNo { get; set; }
}