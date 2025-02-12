namespace WWB.Paylink.Baofu.Juhe.Response
{
    public class JuheOrderBalanceQueryResponse
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
        /// 原支付订单宝付订单号
        /// </summary>
        public string originTradeNo { get; set; }

        /// <summary>
        /// 原支付订单商户订单号
        /// </summary>
        public string originOutTradeNo { get; set; }

        /// <summary>
        /// 原支付单总金额
        /// </summary>
        public int orderTotalAmt { get; set; }

        /// <summary>
        /// 剩余分账金额
        /// </summary>
        public int shareBalanceAmt { get; set; }

        /// <summary>
        /// 退款成功金额
        /// </summary>
        public int refundSuccessAmt { get; set; }

        /// <summary>
        /// 退款处理中的金额
        /// </summary>
        public int refundProcessingAmt { get; set; }

        /// <summary>
        /// 请求方保留域
        /// </summary>
        public string reqReserved { get; set; }

        /// <summary>
        /// 业务结果
        /// </summary>
        public string resultCode { get; set; }

        /// <summary>
        /// 错误代码 当业务结果FAIL时，返回错误代码
        /// </summary>
        public string errCode { get; set; }

        /// <summary>
        /// 错误描述 当业务结果为FAIL时，返回错误描述
        /// </summary>
        public string errMsg { get; set; }
    }
}