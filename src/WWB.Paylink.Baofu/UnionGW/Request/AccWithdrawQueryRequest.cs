using WWB.Paylink.Baofu.UnionGW.Response;

namespace WWB.Paylink.Baofu.UnionGW.Request
{
    public class AccWithdrawQueryRequest : BaseUnionGWRRequest, IBaofuRequest<BaseUnionGWResponse<AccWithdrawQueryResponse>>
    {
        public AccWithdrawQueryRequest() : base(ServiceTpConsts.账户提现查询)
        {
        }

        public string version { get; set; } = "4.2.0";

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string transSerialNo { get; set; }

        /// <summary>
        /// 交易时间 yyyy-MM-dd
        /// </summary>
        public string tradeTime { get; set; }
    }
}