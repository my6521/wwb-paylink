using System.Collections.Generic;
using WWB.Paylink.JoinPay.Response;

namespace WWB.Paylink.JoinPay.Request
{
    /// <summary>
    /// 单笔代付查询
    /// </summary>
    public class JoinPaySinglePayQueryRequest : JoinPayAbstractRequest, IJoinPayRequest<JoinPaySinglePayQueryResponse>
    {
        public string userNo { get; set; }
        public string merchantOrderNo { get; set; }

        public string GetRequestUrl(bool debug)
        {
            return "https://www.joinpay.com/payment/pay/singlePayQuery";
        }

        public override string GetContentType()
        {
            return Paylink.Utility.HttpContentType.PostJson;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new Dictionary<string, string>
            {
                { "userNo", userNo },
                { "merchantOrderNo", merchantOrderNo },
            };

            return parameters;
        }

    }
}