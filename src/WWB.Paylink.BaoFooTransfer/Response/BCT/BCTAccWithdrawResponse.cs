namespace WWB.Paylink.BaoFooTransfer.Response.BCT
{
    public class BCTAccWithdrawResponse : BaseUnionGWResponse<BCTAccWithdrawResponseBody>
    {
    }

    public class BCTAccWithdrawResponseBody : BCTAccResponseBodyBase
    {
        public string transSerialNo { get; set; }
        public string contractNo { get; set; }
        public int state { get; set; }
        public string transRemark { get; set; }
    }
}