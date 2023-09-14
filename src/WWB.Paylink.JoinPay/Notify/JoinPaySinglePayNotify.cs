using System.Collections.Generic;

namespace WWB.Paylink.JoinPay.Notify
{
    /// <summary>
    /// 单笔代付通知
    /// </summary>
    public class JoinPaySinglePayNotify : JoinPayNotify
    {
        public string status { get; set; }
        public string errorCode { get; set; }
        public string errorCodeDesc { get; set; }
        public string userNo { get; set; }
        public string tradeMerchantNo { get; set; }
        public string merchantOrderNo { get; set; }
        public string platformSerialNo { get; set; }
        public string receiverAccountNoEnc { get; set; }
        public string receiverNameEnc { get; set; }
        public decimal paidAmount { get; set; }
        public decimal fee { get; set; }
        public string hmac { get; set; }

        public override IDictionary<string, string> GetParameters()
        {
            var parameters = new Dictionary<string, string> {
                { "status", $"{status}" },
                { "errorCode", errorCode },
                { "errorCodeDesc", errorCodeDesc },
                { "userNo", userNo },
                { "tradeMerchantNo", tradeMerchantNo },
                { "merchantOrderNo", merchantOrderNo },
                { "platformSerialNo", platformSerialNo },
                { "receiverAccountNoEnc", receiverAccountNoEnc },
                { "receiverNameEnc", receiverNameEnc },
                { "paidAmount", $"{paidAmount}" },
                { "fee", $"{fee}" },
                { "hmac", hmac },
            };

            return parameters;
        }
    }
}