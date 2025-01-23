using WWB.Paylink.BaoFooTransfer.Response.BCT;

namespace WWB.Paylink.BaoFooTransfer.Request.BCT
{
    public class BCTAccBalanceQueryRequest : BaseUnionGWRRequest, IBaoFooTransRequest<BCTAccBalanceQueryResponse>
    {
        private const string serviceTp = "T-1001-013-06";

        public BCTAccBalanceQueryRequest() : base(serviceTp)
        {
        }

        public string version { get; set; } = "4.1.0";
        public string contractNo { get; set; }
        public int accType { get; set; }
    }
}