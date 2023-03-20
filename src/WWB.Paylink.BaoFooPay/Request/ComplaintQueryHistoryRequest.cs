using Newtonsoft.Json;
using System.Collections.Generic;
using WWB.Paylink.BaoFooPay.Response;

namespace WWB.Paylink.BaoFooPay.Request
{
    public class ComplaintQueryHistoryRequest : AbstractRequest, IBaoFooPayRequest<ComplaintQueryHistoryResponse>
    {
        [JsonProperty("limit")]
        public string Limit { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("complaintId")]
        public string ComplaintId { get; set; }

        #region 方法

        protected override string GetMethod()
        {
            return "COMPLAINT_QUERY_HISTORY";
        }

        public string GetRequestUrl(bool debug)
        {
            return debug ? "https://test-api.huishouqian.com/complaint/queryHistory" : "https://api.huishouqian.com/complaint/queryHistory";
        }

        public IDictionary<string, string> PrimaryHandler(BaoFooPayOptions options)
        {
            return PrimaryHandler(this, options);
        }

        #endregion 方法
    }
}