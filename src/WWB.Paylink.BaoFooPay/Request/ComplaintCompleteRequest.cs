using System.Collections.Generic;
using WWB.Paylink.BaoFooPay.Response;

namespace WWB.Paylink.BaoFooPay.Request
{
    public class ComplaintCompleteRequest : AbstractRequest, IBaoFooPayRequest<ComplaintCompleteResponse>
    {
        public string complaintId { get; set; }
        public string responseContent { get; set; }
        public List<string> responseImages { get; set; }

        #region 方法

        protected override string GetMethod()
        {
            return "COMPLAINT_COMMIT_COMPLETE";
        }

        public string GetRequestUrl(bool debug)
        {
            return debug ? "https://test-api.huishouqian.com/complaint/commitComplete" : "https://api.huishouqian.com/complaint/commitComplete";
        }

        public IDictionary<string, string> PrimaryHandler(BaoFooPayOptions options)
        {
            return PrimaryHandler(this, options);
        }

        #endregion 方法
    }
}