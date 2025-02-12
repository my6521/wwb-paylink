namespace WWB.Paylink.Baofu.Juhe.Notify
{
    public class JuheUnifiedOrderNotify : BaseJuheNotify<JuheUnifiedOrderNotifyData>
    {
    }

    public class JuheUnifiedOrderNotifyData
    {
        /// <summary>
        /// 代理商商户号
        /// </summary>
        public string agentMerId { get; set; }

        /// <summary>
        /// 代理商终端号
        /// </summary>
        public string agentTerId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        public string merId { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        public string terId { get; set; }

        /// <summary>
        /// 宝付订单号
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
        /// 支付手续费
        /// </summary>
        public int feeAmt { get; set; }

        /// <summary>
        /// 分期手续费
        /// </summary>
        public int instFeeAmt { get; set; }

        /// <summary>
        /// 业务结果 SUCCESS：成功 FAIL：失败 ，注：关单场景不返回
        /// </summary>
        public string resultCode { get; set; }

        /// <summary>
        /// 错误代码 当业务结果FAIL时，返回错误代码
        /// </summary>
        public string errCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        public string errMsg { get; set; }

        /// <summary>
        /// 请求渠道订单号 支付成功时返回
        /// </summary>
        public string reqChlNo { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        public string payCode { get; set; }

        /// <summary>
        /// 渠道返回参数
        /// </summary>
        public string chlRetParam { get; set; }

        /// <summary>
        /// 清算日期
        /// </summary>
        public string clearingDate { get; set; }
    }
}