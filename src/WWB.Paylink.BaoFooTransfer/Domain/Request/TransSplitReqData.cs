namespace WWB.Paylink.BaoFooTransfer.Domain.Request
{
    public class TransSplitReqData
    {
        public string trans_no { get; set; }
        public decimal trans_money { get; set; }
        public string to_acc_name { get; set; }
        public string to_acc_no { get; set; }
        public string to_bank_name { get; set; }
        public string to_pro_name { get; set; }
        public string to_city_name { get; set; }
        public string to_acc_dept { get; set; }
        public string trans_card_id { get; set; }
        public string trans_mobile { get; set; }
        public string trans_summary { get; set; }
        public string trans_reserved { get; set; }
    }
}