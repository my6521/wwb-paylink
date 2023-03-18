using Newtonsoft.Json;

namespace WWB.Paylink.BaoFooPay.Domain.ResResult
{
    public class JsapiPayResponseResult
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("transNo")]
        public string TransNo { get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        [JsonProperty("tradeNo")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [JsonProperty("orderAmt")]
        public int OrderAmt { get; set; }

        /// <summary>
        /// orderStatus
        /// </summary>
        [JsonProperty("orderStatus")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        [JsonProperty("finishedDate")]
        public string FinishedDate { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("respCode")]
        public string RespCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("respMsg")]
        public string RespMsg { get; set; }

        /// <summary>
        /// 预支付交易会话标识
        /// </summary>
        [JsonProperty("qrCode")]
        public string QrCode { get; set; }

        /// <summary>
        /// 慧收钱上送三方支付的交易订单号
        /// </summary>
        [JsonProperty("channelOrderNo")]
        public string ChannelOrderNo { get; set; }
    }
}