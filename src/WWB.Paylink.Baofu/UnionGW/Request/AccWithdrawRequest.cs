using WWB.Paylink.Baofu.UnionGW.Response;

namespace WWB.Paylink.Baofu.UnionGW.Request
{
    /// <summary>
    /// 账户提现
    /// </summary>
    public class AccWithdrawRequest : BaseUnionGWRRequest, IBaofuRequest<BaseUnionGWResponse<AccWithdrawResponse>>
    {
        public AccWithdrawRequest() : base(ServiceTpConsts.账户提现)
        {
        }

        public string version { get; set; } = "4.2.0";

        /// <summary>
        /// 客户账户号
        /// </summary>
        public string contractNo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string transSerialNo { get; set; }

        /// <summary>
        /// 提现金额,单位：元
        /// </summary>
        public decimal dealAmount { get; set; }

        /// <summary>
        /// 提现结果异步通知地址，通知参数详见提现结果通知
        /// </summary>
        public string returnUrl { get; set; }

        /// <summary>
        /// 用户自己承担手续费必传，与客户号contractNo一致需用户承担手续费时要提前和商务申请配置
        /// </summary>
        public string feeMemberId { get; set; }

        /// <summary>
        /// 原样返回保留字段
        /// </summary>
        public string reqReserved { get; set; }
    }
}