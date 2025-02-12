namespace WWB.Paylink.Baofu.Juhe.Response
{
    public class JuheRefundQueryResponse
    {
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
        public string refundState { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        public string finishTime { get; set; }

        /// <summary>
        /// 成功金额
        /// </summary>
        public int succAmt { get; set; }

        /// <summary>
        /// 业务结果 SUCCESS：成功 FAIL：失败
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
    }
}