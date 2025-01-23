namespace WWB.Paylink.BaoFooTransfer.Response.BCT
{
    public class BCTAccWithdrawQueryResponse : BaseUnionGWResponse<BCTAccWithdrawQueryResponseBody>
    {
    }

    public class BCTAccWithdrawQueryResponseBody : BCTAccResponseBodyBase
    {
        public string memberId { get; set; }
        public string transSerialNo { get; set; }
        public int state { get; set; }
        public string orderId { get; set; }
        public string successTime { get; set; }
        public string contractNo { get; set; }
        public decimal transMoney { get; set; }
        public decimal transFee { get; set; }
        public decimal transferTotalAmount { get; set; }
        public string transRemark { get; set; }
    }
}