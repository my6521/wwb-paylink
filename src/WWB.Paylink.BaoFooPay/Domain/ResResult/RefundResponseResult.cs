namespace WWB.Paylink.BaoFooPay.Domain.ResResult
{
    public class RefundResponseResult
    {
        public string merchantNo { get; set; }
        public string transNo { get; set; }
        public string tradeNo { get; set; }
        public int orderAmt { get; set; }
        public int orderStatus { get; set; }
        public string finishedDate { get; set; }
        public string respCode { get; set; }
        public string respMsg { get; set; }
    }
}