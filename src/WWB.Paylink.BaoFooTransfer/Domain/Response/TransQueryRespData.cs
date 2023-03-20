namespace WWB.Paylink.BaoFooTransfer.Domain.Response
{
    public class TransQueryRespData
    {
        public string trans_orderid { get; set; }
        public string trans_batchid { get; set; }
        public string trans_no { get; set; }
        public decimal trans_money { get; set; }
        public string to_acc_name { get; set; }
        public string to_acc_no { get; set; }
        public string to_acc_dept { get; set; }
        public string trans_fee { get; set; }
        public string state { get; set; }
        public string trans_summary { get; set; }
        public string trans_remark { get; set; }
        public string trans_starttime { get; set; }
        public string trans_endtime { get; set; }

        public string to_member_id { get; set; }
        public string trans_reserved { get; set; }
    }
}