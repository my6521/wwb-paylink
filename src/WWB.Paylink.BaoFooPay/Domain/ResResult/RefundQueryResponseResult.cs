namespace WWB.Paylink.BaoFooPay.Domain.ResResult
{
    public class RefundQueryResponseResult
    {  /// <summary>
       /// 商户号
       /// </summary>
        public string merchantNo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string transNo { get; set; }

        /// <summary>
        /// 原商户订单号
        /// </summary>
        public string origTransNo { get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        public string tradeNo { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        public int orderAmt { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        public string orderStatus { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        public string finishedDate { get; set; }

        /// <summary>
        /// 响应码
        /// </summary>
        public string respCode { get; set; }

        /// <summary>
        /// 响应描述
        /// </summary>
        public string respMsg { get; set; }

        /// <summary>
        /// 附加字段
        /// </summary>
        public string extend { get; set; }
    }
}