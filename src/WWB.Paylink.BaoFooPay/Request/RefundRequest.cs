using WWB.Paylink.BaoFooPay.Response;

namespace WWB.Paylink.BaoFooPay.Request
{
    public class RefundRequest : AbstractRequest, IRequest<JsapiPayResponse>
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("transNo")]
        public string TransNo { get; set; }

        /// <summary>
        /// 退款类型
        /// </summary>
        [JsonProperty("refundType")]
        public int RefundType { get; set; }

        /// <summary>
        /// 原商户订单号
        /// </summary>
        [JsonProperty("origTransNo")]
        public string OrigTransNo { get; set; }

        /// <summary>
        /// 原订单金额
        /// </summary>
        [JsonProperty("origOrderAmt")]
        public int OrigOrderAmt { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [JsonProperty("orderAmt")]
        public int OrderAmt { get; set; }

        /// <summary>
        /// 请求时间
        /// </summary>
        [JsonProperty("requestDate")]
        public string RequestDate { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [JsonProperty("refundReason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 后端通知地址
        /// </summary>
        [JsonProperty("returnUrl")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// 附加字段
        /// </summary>
        [JsonProperty("extend")]
        public string Extend { get; set; }

        #region 方法

        protected override string GetMethod()
        {
            return "POLYMERIZE_REFUND";
        }

        public string GetRequestUrl(bool debug)
        {
            return debug ? "https://test-api.huishouqian.com/api/acquiring" : "https://api.huishouqian.com/api/acquiring";
        }

        public IDictionary<string, string> PrimaryHandler(HsqPayOptions options)
        {
            return PrimaryHandler(this, options);
        }

        #endregion 方法
    }
}