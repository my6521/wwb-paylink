using WWB.Paylink.BaoFooTransfer.Response.BCT;

namespace WWB.Paylink.BaoFooTransfer.Request.BCT
{
    public class BCTAccWithdrawQueryRequest : BaseUnionGWRRequest, IBaoFooTransRequest<BCTAccWithdrawQueryResponse>
    {
        private const string serviceTp = "T-1001-013-15";

        public BCTAccWithdrawQueryRequest() : base(serviceTp)
        {
        }

        public string version { get; set; } = "4.1.0";
        public string transSerialNo { get; set; }
        public string tradeTime { get; set; }
    }
}