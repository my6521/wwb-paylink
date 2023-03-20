using System.Collections.Generic;
using WWB.Paylink.BaoFooPay.Response;

namespace WWB.Paylink.BaoFooPay.Request
{
    public class TransactionDownRequest : AbstractRequest, IBaoFooPayRequest<TransactionDownResponse>
    {
        public string batchDate { get; set; }
        public string billType { get; set; }

        #region 方法

        protected override string GetMethod()
        {
            return "QUERY_TRADE_FILE";
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