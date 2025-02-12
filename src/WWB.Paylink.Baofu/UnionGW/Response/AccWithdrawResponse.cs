namespace WWB.Paylink.Baofu.UnionGW.Response
{
    public class AccWithdrawResponse : BaseUnionGWResponseBody
    {
        /// <summary>
        /// 请求流水号
        /// </summary>
        public string transSerialNo { get; set; }

        /// <summary>
        /// 客户账户号
        /// </summary>
        public string contractNo { get; set; }

        /// <summary>
        /// 订单状态 1受理成功 2受理失败
        /// </summary>
        public int state { get; set; }

        /// <summary>
        /// 单备注（受理失败的具体原因）
        /// </summary>
        public string transRemark { get; set; }
    }
}