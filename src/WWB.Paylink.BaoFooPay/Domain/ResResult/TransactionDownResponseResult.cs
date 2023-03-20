namespace WWB.Paylink.BaoFooPay.Domain.ResResult
{
    public class TransactionDownResponseResult
    {
        public string batchDate { get; set; }
        public string downloadUrl { get; set; }
        public string infoNo { get; set; }
        public string orderStatus { get; set; }
        public string respCode { get; set; }
        public string respMsg { get; set; }
    }
}