using System.Collections.Generic;
using WWB.Paylink.JoinPay.Response;

namespace WWB.Paylink.JoinPay.Request
{
    /// <summary>
    /// 订单查询
    /// </summary>
    public class JoinPayQueryOrderRequest : JoinPayAbstractRequest, IJoinPayRequest<JoinPayQueryOrderResponse>
    {
        public string p1_MerchantNo { get; set; }
        public string p2_OrderNo { get; set; }

        public string GetRequestUrl(bool debug)
        {
            return "https://www.joinpay.com/trade/queryOrder.action";
        }

        public override string GetContentType()
        {
            return Paylink.Utility.HttpContentType.PostFormUrlencoded;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new Dictionary<string, string>
            {
                { "p1_MerchantNo", p1_MerchantNo },
                { "p2_OrderNo", p2_OrderNo },
            };
            return parameters;
        }


    }
}