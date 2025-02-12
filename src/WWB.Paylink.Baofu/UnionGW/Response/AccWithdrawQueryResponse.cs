namespace WWB.Paylink.Baofu.UnionGW.Response
{
    public class AccWithdrawQueryResponse : BaseUnionGWResponseBody
    {
        /// <summary>
        /// 商户号
        /// </summary>
        public string memberId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string transSerialNo { get; set; }

        /// <summary>
        /// 订单状态 1成功 0失败 2处理中 3提现退回
        /// </summary>
        public int state { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string orderId { get; set; }

        /// <summary>
        /// 成功时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string successTime { get; set; }

        /// <summary>
        /// 商户客户号
        /// </summary>
        public string contractNo { get; set; }

        /// <summary>
        /// 转账金额,单位：元
        /// </summary>
        public decimal transMoney { get; set; }

        /// <summary>
        /// 转账手续费,单位：元
        /// </summary>
        public decimal transFee { get; set; }

        /// <summary>
        /// 转账交易时金额,单位：元
        /// </summary>
        public decimal transferTotalAmount { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        public string transRemark { get; set; }
    }
}