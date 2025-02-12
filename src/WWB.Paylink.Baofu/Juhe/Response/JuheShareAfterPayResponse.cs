namespace WWB.Paylink.Baofu.Juhe.Response
{
    public class JuheShareAfterPayResponse
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
        /// 业务结果
        /// </summary>
        public string resultCode { get; set; }

        /// <summary>
        /// 错误代码
        /// </summary>
        public string errCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        public string errMsg { get; set; }

        /// <summary>
        /// 宝付订单号
        /// </summary>
        public string tradeNo { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        public string txnState { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        public string finishTime { get; set; }

        /// <summary>
        /// 分账成功金额 单位分
        /// </summary>
        public int succAmt { get; set; }

        /// <summary>
        /// 清算日期
        /// </summary>
        public string clearingDate { get; set; }
    }
}