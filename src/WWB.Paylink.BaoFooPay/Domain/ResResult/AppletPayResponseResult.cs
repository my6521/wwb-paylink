namespace WWB.Paylink.BaoFooPay.Domain.ResResult
{
    public class AppletPayResponseResult
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("transNo")]
        public string transNo { get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        [JsonProperty("tradeNo")]
        public string tradeNo { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [JsonProperty("orderAmt")]
        public int orderAmt { get; set; }

        /// <summary>
        /// orderStatus
        /// </summary>
        [JsonProperty("orderStatus")]
        public string orderStatus { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        [JsonProperty("finishedDate")]
        public string finishedDate { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("respCode")]
        public string respCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("respMsg")]
        public string respMsg { get; set; }

        /// <summary>
        /// 预支付交易会话标识
        /// </summary>
        [JsonProperty("qrCode")]
        public string qrCode { get; set; }

        /// <summary>
        /// 慧收钱上送三方支付的交易订单号
        /// </summary>
        [JsonProperty("channelOrderNo")]
        public string channelOrderNo { get; set; }
    }
}