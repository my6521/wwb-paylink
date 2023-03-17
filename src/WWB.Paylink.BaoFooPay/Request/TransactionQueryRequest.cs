namespace WWB.Paylink.BaoFooPay.Request
{
    public class TransactionQueryRequest : AbstractRequest, IRequest<TransactionQueryResponse>
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("transNo")]
        public string TransNo { get; set; }

        /// <summary>
        /// 查询类型
        /// </summary>
        [JsonProperty("queryType")]
        public int QueryType { get; set; }

        #region 方法

        protected override string GetMethod()
        {
            return "POLYMERIZE_QUERY";
        }

        public string GetRequestUrl(bool debug)
        {
            return debug ? "https://test-api.huishouqian.com/api/acquiring" : "https://api.huishouqian.com/api/acquiring";
        }

        public IDictionary<string, string> PrimaryHandler(BaoFooPayOptions options)
        {
            return PrimaryHandler(this, options);
        }

        #endregion 方法
    }
}