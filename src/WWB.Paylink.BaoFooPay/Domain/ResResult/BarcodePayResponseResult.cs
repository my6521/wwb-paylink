using Newtonsoft.Json;

namespace WWB.Paylink.BaoFooPay.Domain.ResResult
{
    public class BarcodePayResponseResult
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
        /// 第三方支付流水号
        /// </summary>
        /// <remarks>
        /// 支付宝 微信 银联等第三方支付返回的流水号
        /// </remarks>
        [JsonProperty("payOrderNo")]
        public string PayOrderNo { get; set; }

        /// <summary>
        /// 第三方支付支付方式
        /// </summary>
        /// <remarks>
        /// 支付宝 微信 银联等第三方支付返回的支付方式如 余额 花呗 银行卡信用卡等 取值详见支付宝微信文档
        /// </remarks>
        [JsonProperty("fundChannel")]
        public string RundChannel { get; set; }

        /// <summary>
        /// 第三方支付银行编码/借贷标识
        /// </summary>
        /// <remarks>
        /// 支付宝 微信 银联等第三方支付返回的银行编码/借贷标识取值详见支付宝微信文档
        /// </remarks>
        [JsonProperty("fundBankCode")]
        public string FundBankCode { get; set; }
    }
}