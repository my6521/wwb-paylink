namespace WWB.Paylink.Baofu.UnionGW.Response
{
    public class AccTransferResponse : BaseUnionGWResponseBody
    {
        /// <summary>
        /// 请求流水号
        /// </summary>
        public string transSerialNo { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        public string businessNo { get; set; }

        /// <summary>
        /// 付款方(二级子商户号)
        /// </summary>
        public string payerNo { get; set; }

        /// <summary>
        /// 收款方(二级子商户号)
        /// </summary>
        public string payeeNo { get; set; }

        /// <summary>
        /// 转账金额,单位：元
        /// </summary>
        public decimal dealAmount { get; set; }

        /// <summary>
        /// 手续费金额,单位：元
        /// </summary>
        public decimal feeAmount { get; set; }

        /// <summary>
        /// 订单状态 1成功 2失败
        /// </summary>
        public int state { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        public string transRemark { get; set; }
    }
}