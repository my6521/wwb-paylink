using WWB.Paylink.BaoFooPay.Response;

namespace WWB.Paylink.BaoFooPay.Request
{
    public class RefundQueryRequest : AbstractRequest, IRequest<RefundQueryResponse>
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        /// <remarks>
        /// 原退款交易对应的商户订单号
        /// </remarks>
        [JsonProperty("transNo")]
        public string TransNo { get; set; }

        #region 方法

        protected override string GetMethod()
        {
            return "POLYMERIZE_REFUND_QUERY";
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