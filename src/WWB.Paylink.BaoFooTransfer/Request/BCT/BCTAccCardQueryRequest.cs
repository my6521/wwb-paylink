using WWB.Paylink.BaoFooTransfer.Response.BCT;

namespace WWB.Paylink.BaoFooTransfer.Request.BCT
{
    public class BCTAccCardQueryRequest : BaseUnionGWRRequest, IBaoFooTransRequest<BCTAccCardQueryResponse>
    {
        private const string serviceTp = "T-1001-013-08";

        public BCTAccCardQueryRequest() : base(serviceTp)
        {
        }

        public string version { get; set; } = "4.1.0";
        public string loginNo { get; set; }
        public string contractNo { get; set; }
        public int accType { get; set; }
        public string platformNo { get; set; }
    }
}