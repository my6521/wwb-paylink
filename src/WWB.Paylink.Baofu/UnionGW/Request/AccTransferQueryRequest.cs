using WWB.Paylink.Baofu.UnionGW.Response;

namespace WWB.Paylink.Baofu.UnionGW.Request
{
    /// <summary>
    /// 账户间转账查询
    /// </summary>
    public class AccTransferQueryRequest : BaseUnionGWRRequest, IBaofuRequest<BaseUnionGWResponse<AccTransferQueryResponse>>
    {
        public AccTransferQueryRequest() : base(ServiceTpConsts.账户间转账查询)
        {
        }

        /// <summary>
        /// 版本号4.0.0
        /// </summary>
        public string version { get; set; } = "4.0.0";

        /// <summary>
        /// 请求流水号
        /// </summary>
        public string transSerialNo { get; set; }

        /// <summary>
        /// 原交易时间 yyyy-MM-dd
        /// </summary>
        public string tradeTime { get; set; }
    }
}