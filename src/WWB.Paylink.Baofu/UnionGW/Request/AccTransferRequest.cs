using WWB.Paylink.Baofu.UnionGW.Response;

namespace WWB.Paylink.Baofu.UnionGW.Request
{
    public class AccTransferRequest : BaseUnionGWRRequest, IBaofuRequest<BaseUnionGWResponse<AccTransferResponse>>
    {
        public AccTransferRequest() : base(ServiceTpConsts.账户间转账)
        {
        }

        /// <summary>
        /// 版本号4.0.0
        /// </summary>
        public string version { get; set; } = "4.0.0";

        /// <summary>
        /// 付款方(二级子商户号)
        /// </summary>
        public string payerNo { get; set; }

        /// <summary>
        /// 收款方(二级子商户号)
        /// </summary>
        public string payeeNo { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        public string transSerialNo { get; set; }

        /// <summary>
        /// 转账金额,单位：元
        /// </summary>
        public decimal dealAmount { get; set; }
    }
}