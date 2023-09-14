using System.Collections.Generic;
using WWB.Paylink.JoinPay.Response;

namespace WWB.Paylink.JoinPay.Request
{
    /// <summary>
    /// 退款查询
    /// </summary>
    public class JoinPayRefundQueryRequest : JoinPayAbstractRequest, IJoinPayRequest<JoinPayRefundQueryResponse>
    {
        public string p1_MerchantNo { get; set; }
        public string p2_RefundOrderNo { get; set; }

        public string p3_Version { get; set; } = "2.1";

        public string GetRequestUrl(bool debug)
        {
            return "https://www.joinpay.com/trade/queryRefund.action";
        }

        public override string GetContentType()
        {
            return Paylink.Utility.HttpContentType.PostFormUrlencoded;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new Dictionary<string, string>
            {
                {"p1_MerchantNo", p1_MerchantNo},
                {"p2_RefundOrderNo", p2_RefundOrderNo},
                {"p3_Version", p3_Version},
            };
            return parameters;
        }


    }
}