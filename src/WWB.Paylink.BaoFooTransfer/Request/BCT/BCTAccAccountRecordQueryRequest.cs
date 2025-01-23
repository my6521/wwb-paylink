using WWB.Paylink.BaoFooTransfer.Response.BCT;

namespace WWB.Paylink.BaoFooTransfer.Request.BCT
{
    public class BCTAccAccountRecordQueryRequest : BaseUnionGWRRequest, IBaoFooTransRequest<BCTAccAccountRecordQueryResponse>
    {
        private const string serviceTp = "T-1001-013-11";

        public BCTAccAccountRecordQueryRequest() : base(serviceTp)
        {
        }

        public string version { get; set; } = "4.1.0";
        public string contractNo { get; set; }
        public string accountType { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public int pageNum { get; set; }
        public int pageSize { get; set; }
    }
}