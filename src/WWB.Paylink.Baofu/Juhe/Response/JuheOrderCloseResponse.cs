namespace WWB.Paylink.Baofu.Juhe.Response
{
    public class JuheOrderCloseResponse
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
        /// 业务结果 SUCCESS：成功，FAIL：失败
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