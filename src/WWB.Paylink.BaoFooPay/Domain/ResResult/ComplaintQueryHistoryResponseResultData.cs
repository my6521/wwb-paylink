using Newtonsoft.Json;
using System.Collections.Generic;

namespace WWB.Paylink.BaoFooPay.Domain.ResResult
{
    public class ComplaintQueryHistoryResponseResultData
    {
        public string logId { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        public string operateTime { get; set; }
        public string operateType { get; set; }
        public string operateDetails { get; set; }

        public List<string> imageList { get; set; }
    }
}