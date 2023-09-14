using System.Collections.Generic;

namespace WWB.Paylink.JoinPay.Notify
{
    /// <summary>
    /// 批量代付通知
    /// </summary>
    public class JoinPayBatchPayNotify : JoinPayNotify
    {
        public int status { get; set; }
        public string userNo { get; set; }
        public string merchantBatchNo { get; set; }
        public string platformBatchNo { get; set; }
        public int successCount { get; set; }
        public decimal successAmount { get; set; }
        public int failCount { get; set; }
        public decimal failAmount { get; set; }
        public int processCount { get; set; }
        public decimal processAmount { get; set; }
        public int requestCount { get; set; }
        public decimal requestAmount { get; set; }
        public int acceptCount { get; set; }
        public decimal acceptAmount { get; set; }
        public decimal feeSum { get; set; }
        public string singleNotifyList { get; set; }
        public string hmac { get; set; }

        public override IDictionary<string, string> GetParameters()
        {
            var parameters = new Dictionary<string, string>
            {
                {"status", $"{status}"},
                {"userNo", userNo},
                {"merchantBatchNo", merchantBatchNo},
                {"platformBatchNo", platformBatchNo},
                {"successCount", $"{successCount}"},
                {"successAmount", $"{successAmount}"},
                {"failCount", $"{failCount}"},
                {"failAmount", $"{failAmount}"},
                {"processCount", $"{processCount}"},
                {"processAmount", $"{processAmount}"},
                {"requestCount", $"{requestCount}"},
                {"requestAmount", $"{requestAmount}"},
                {"acceptCount", $"{acceptCount}"},
                {"acceptAmount", $"{acceptAmount}"},
                {"feeSum", $"{feeSum}"},
                {"singleNotifyList", singleNotifyList},
                {"hmac", hmac},
            };

            return parameters;
        }
    }
}