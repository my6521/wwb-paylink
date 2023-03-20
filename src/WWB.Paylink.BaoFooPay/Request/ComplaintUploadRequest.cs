using System.Collections.Generic;
using WWB.Paylink.BaoFooPay.Response;

namespace WWB.Paylink.BaoFooPay.Request
{
    public class ComplaintUploadRequest : AbstractRequest, IBaoFooPayRequest<ComplaintUploadResponse>
    {
        public string img { get; set; }

        #region 方法

        protected override string GetMethod()
        {
            return "COMPLAINT_FILE_UPLOAD";
        }

        public string GetRequestUrl(bool debug)
        {
            return debug ? "https://test-api.huishouqian.com/complaint/upload" : "https://api.huishouqian.com/complaint/upload";
        }

        public IDictionary<string, string> PrimaryHandler(BaoFooPayOptions options)
        {
            return PrimaryHandler(this, options);
        }

        #endregion 方法
    }
}