using System.Collections.Generic;
using WWB.Paylink.JoinPay.Response;

namespace WWB.Paylink.JoinPay.Request
{
    /// <summary>
    /// 单笔代付
    /// </summary>
    public class JoinPaySinglePayRequest : JoinPayAbstractRequest, IJoinPayRequest<JoinPaySinglePayResponse>
    {
        public string userNo { get; set; }
        public string tradeMerchantNo { get; set; }
        public string productCode { get; set; }
        public string requestTime { get; set; }
        public string merchantOrderNo { get; set; }
        public string receiverAccountNoEnc { get; set; }
        public string receiverNameEnc { get; set; }
        public string receiverAccountType { get; set; }
        public string receiverBankChannelNo { get; set; }
        public decimal paidAmount { get; set; }
        public string currency { get; set; }
        public string isChecked { get; set; }
        public string paidDesc { get; set; }
        public string paidUse { get; set; }
        public string callbackUrl { get; set; }
        public string firstProductCode { get; set; }

        public string GetRequestUrl(bool debug)
        {
            return "https://www.joinpay.com/payment/pay/singlePay";
        }

        public override string GetContentType()
        {
            return Paylink.Utility.HttpContentType.PostJson;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new Dictionary<string, string>
            {
                {"userNo", userNo},
                {"tradeMerchantNo", tradeMerchantNo},
                {"productCode", productCode},
                {"requestTime", requestTime},
                {"merchantOrderNo", merchantOrderNo},
                {"receiverAccountNoEnc", receiverAccountNoEnc},
                {"receiverNameEnc", receiverNameEnc},
                {"receiverAccountType", receiverAccountType},
                {"receiverBankChannelNo", receiverBankChannelNo},
                {"paidAmount", $"{paidAmount}"},
                {"currency", currency},
                {"isChecked", isChecked},
                {"paidDesc", paidDesc},
                {"paidUse", paidUse},
                {"callbackUrl", callbackUrl},
                {"firstProductCode", firstProductCode}
            };
            return parameters;
        }

    }
}