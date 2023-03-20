using System.Collections.Generic;
using WWB.Paylink.BaoFooPay.Response;

namespace WWB.Paylink.BaoFooPay.Request
{
    public class ComplaintReplyRequest : AbstractRequest, IBaoFooPayRequest<ComplaintReplyResponse>
    {
        public string complaintId { get; set; }
        public string responseContent { get; set; }
        public List<string> responseImages { get; set; }
        public int actType { get; set; }

        #region 方法

        protected override string GetMethod()
        {
            return "COMPLAINT_COMMIT_RESPONSE";
        }

        public string GetRequestUrl(bool debug)
        {
            return debug ? "https://test-api.huishouqian.com/complaint/commitResponse" : "https://api.huishouqian.com/complaint/commitResponse";
        }

        public IDictionary<string, string> PrimaryHandler(BaoFooPayOptions options)
        {
            return PrimaryHandler(this, options);
        }

        #endregion 方法
    }
}