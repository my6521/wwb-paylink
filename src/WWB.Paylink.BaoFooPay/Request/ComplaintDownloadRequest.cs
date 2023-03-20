using System.Collections.Generic;
using WWB.Paylink.BaoFooPay.Response;

namespace WWB.Paylink.BaoFooPay.Request
{
    public class ComplaintDownloadRequest : AbstractRequest, IBaoFooPayRequest<ComplaintDownloadResponse>
    {
        public string complaintId { get; set; }
        public string mediaUrl { get; set; }
        public string mediaType { get; set; }

        #region 方法

        protected override string GetMethod()
        {
            return "COMPLAINT_FILE_DOWNLOAD";
        }

        public string GetRequestUrl(bool debug)
        {
            return debug ? "https://test-api.huishouqian.com/complaint/download" : "https://api.huishouqian.com/complaint/download";
        }

        public IDictionary<string, string> PrimaryHandler(BaoFooPayOptions options)
        {
            return PrimaryHandler(this, options);
        }

        #endregion 方法
    }
}