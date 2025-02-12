namespace WWB.Paylink.Baofu.Juhe.Notify
{
    public class JuheShareAfterPayNotify : BaseJuheNotify<JuheShareAfterPayNotifyData>
    {
    }

    public class JuheShareAfterPayNotifyData
    {
        /// <summary>
        /// 宝付交易号
        /// </summary>
        public string tradeNo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string outTradeNo { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        public string txnState { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        public string finishTime { get; set; }

        /// <summary>
        /// 成功金额
        /// </summary>
        public int succAmt { get; set; }

        /// <summary>
        /// 业务结果 SUCCESS：成功
        /// </summary>
        public string resultCode { get; set; }

        /// <summary>
        /// 清算日期
        /// </summary>
        public string clearingDate { get; set; }
    }
}