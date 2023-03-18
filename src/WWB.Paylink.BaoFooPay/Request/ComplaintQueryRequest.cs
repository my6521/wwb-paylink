using System.Collections.Generic;
using Newtonsoft.Json;
using WWB.Paylink.BaoFooPay.Response;

namespace WWB.Paylink.BaoFooPay.Request
{
    public class ComplaintQueryRequest : AbstractRequest, IBaoFooPayRequest<ComplaintQueryResponse>
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("limit")]
        public string Limit { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("agentMerchantNo")]
        public string AgentMerchantNo { get; set; }

        [JsonProperty("merchantNo")]
        public string MerchantNo { get; set; }

        [JsonProperty("complaintId")]
        public string ComplaintId { get; set; }

        [JsonProperty("merchantTradeNo")]
        public string MerchantTradeNo { get; set; }

        #region 方法

        protected override string GetMethod()
        {
            return "COMPLAINT_QUERY";
        }

        public string GetRequestUrl(bool debug)
        {
            return debug ? "https://test-api.huishouqian.com/complaint/query" : "https://api.huishouqian.com/complaint/query";
        }

        public IDictionary<string, string> PrimaryHandler(BaoFooPayOptions options)
        {
            return PrimaryHandler(this, options);
        }

        #endregion 方法
    }
}