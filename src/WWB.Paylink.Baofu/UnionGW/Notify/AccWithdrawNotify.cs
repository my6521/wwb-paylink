namespace WWB.Paylink.Baofu.UnionGW.Notify
{
    public class AccWithdrawNotify : BaseUnionGWNotify<AccWithdrawNotifyData>
    { }

    /// <summary>
    /// 提现结果通知
    /// </summary>
    public class AccWithdrawNotifyData
    {
        /// <summary>
        /// 提现子商户号
        /// </summary>
        public string contractNo { get; set; }

        /// <summary>
        /// 提现订单号
        /// </summary>
        public string orderId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string transSerialNo { get; set; }

        /// <summary>
        /// 转账金额,单位：元
        /// </summary>
        public decimal transMoney { get; set; }

        /// <summary>
        /// 费用,单位：元
        /// </summary>
        public decimal transFee { get; set; }

        /// <summary>
        /// 转账交易时金额,单位：元
        /// </summary>
        public decimal transferTotalAmount { get; set; }

        /// <summary>
        /// 状态枚举
        /// 0:失败
        /// 1:成功
        /// 2:处理中
        /// 3:提现退回 注：此状态只在提现时上送版本号4.2.0返回
        /// </summary>
        public string state { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        public string transRemark { get; set; }

        /// <summary>
        /// 保留域
        /// </summary>
        public string reqReserved { get; set; }
    }
}