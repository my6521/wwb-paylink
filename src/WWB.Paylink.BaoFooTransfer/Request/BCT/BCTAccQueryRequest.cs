using WWB.Paylink.BaoFooTransfer.Response.BCT;

namespace WWB.Paylink.BaoFooTransfer.Request.BCT
{
    public class BCTAccQueryRequest : BaseUnionGWRRequest, IBaoFooTransRequest<BCTAccQueryResponse>
    {
        private const string serviceTp = "T-1001-013-03";

        public BCTAccQueryRequest() : base(serviceTp)
        {
        }

        public string version { get; set; } = "4.1.0";
        public string certificateNo { get; set; }
        public string certificateType { get; set; }
        public string platformNo { get; set; }
        public string loginNo { get; set; }
        public string contractNo { get; set; }
        public int accType { get; set; }
    }
}