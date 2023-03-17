namespace WWB.Paylink.HsqPay.Domain.Trade;

public class TransactionQueryResponseResult : RequireMemoObject<TransactionQueryResultMemo>
{
    public string transNo { get; set; }
    public string tradeNo { get; set; }
    public int orderAmt { get; set; }
    public string orderStatus { get; set; }
    public string finishedDate { get; set; }
    public string respCode { get; set; }
    public string respMsg { get; set; }
    public string payType { get; set; }
    public string goodsInfo { get; set; }
    public string requestDate { get; set; }
    public string buyerName { get; set; }
    public string channelOrderNo { get; set; }
    public string payOrderNo { get; set; }
    public string fundChannel { get; set; }
    public string fundBankCode { get; set; }
    public string extend { get; set; }
}