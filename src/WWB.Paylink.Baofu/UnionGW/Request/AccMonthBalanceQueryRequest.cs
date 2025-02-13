using WWB.Paylink.Baofu.UnionGW.Response;

namespace WWB.Paylink.Baofu.UnionGW.Request
{
    public class AccMonthBalanceQueryRequest : BaseUnionGWRRequest, IBaofuRequest<BaseUnionGWResponse<AccMonthBalanceQueryResponse>>
    {
        public AccMonthBalanceQueryRequest() : base(ServiceTpConsts.月终余额查询)
        {
        }

        /// <summary>
        /// 版本号4.0.0
        /// </summary>
        public string version { get; set; } = "4.1.0";

        /// <summary>
        /// 客户号
        /// </summary>
        public string contractNo { get; set; }

        /// <summary>
        /// 日期格式：YYYYMM
        /// </summary>
        public string date { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        public string reqNo { get; set; }
    }
}