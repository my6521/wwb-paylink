namespace WWB.Paylink.BaoFooTransfer.Domain
{
    public class TransHead
    {
        public string return_code { get; set; }
        public string return_msg { get; set; }
        public int? trans_count { get; set; }
        public decimal? trans_totalMoney { get; set; }
    }
}