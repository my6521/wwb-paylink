namespace WWB.Paylink.HsqPay.Domain.Notify;

public class RefundNotifyInfo
{
    public string transNo { get; set; }
    public string origTransNo { get; set; }
    public string tradeNo { get; set; }
    public string orderAmt { get; set; }
    public string orderStatus { get; set; }
    public string finishedDate { get; set; }
    public string respCode { get; set; }
    public string respMsg { get; set; }
    public string extend { get; set; }
}