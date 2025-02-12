using WWB.Paylink.Baofu.UnionGW.Response;

namespace WWB.Paylink.Baofu.UnionGW.Request
{
    public class AccAccountRecordQueryRequest : BaseUnionGWRRequest, IBaofuRequest<BaseUnionGWResponse<AccAccountRecordQueryResponse>>
    {
        private const string serviceTp = "T-1001-013-11";

        public AccAccountRecordQueryRequest() : base(serviceTp)
        {
        }

        /// <summary>
        ///
        /// </summary>
        public string version { get; set; } = "4.0.0";

        /// <summary>
        /// 商户客户号
        /// </summary>
        public string contractNo { get; set; }

        /// <summary>
        /// BALANCE-余额户,TRANSIT-在途户,不传默认余额户
        /// </summary>
        public string accountType { get; set; }

        /// <summary>
        /// 明细开始时间 yyyy-MM-dd HH：mm：ss
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        /// 明细结束时间 yyyy-MM-dd HH：mm：ss查询间隔最大支持一个月
        /// </summary>
        public string endTime { get; set; }

        /// <summary>
        /// 开始页
        /// </summary>
        public int pageNum { get; set; }

        /// <summary>
        /// 每页显示记录数,最大100
        /// </summary>
        public int pageSize { get; set; }
    }
}