using WWB.Paylink.BaoFooTransfer.Response.BCT;

namespace WWB.Paylink.BaoFooTransfer.Request.BCT
{
    public class BCTAccWithdrawRequest : BaseUnionGWRRequest, IBaoFooTransRequest<BCTAccWithdrawResponse>
    {
        private const string serviceTp = "T-1001-013-14";

        public BCTAccWithdrawRequest() : base(serviceTp)
        {
        }

        public string version { get; set; } = "4.1.0";
        public string contractNo { get; set; }
        public string transSerialNo { get; set; }
        public decimal dealAmount { get; set; }
        public string returnUrl { get; set; }
        public string feeMemberId { get; set; }
        public string reqReserved { get; set; }
    }
}