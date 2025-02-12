using WWB.Paylink.Baofu.UnionGW.Response;

namespace WWB.Paylink.Baofu.UnionGW.Request
{
    public class AccWithdrawQueryRequest : BaseUnionGWRRequest, IBaofuRequest<BaseUnionGWResponse<AccWithdrawQueryResponse>>
    {
        private const string serviceTp = "T-1001-013-15";

        public AccWithdrawQueryRequest() : base(serviceTp)
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