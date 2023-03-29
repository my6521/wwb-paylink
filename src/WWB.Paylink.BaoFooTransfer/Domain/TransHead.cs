using Newtonsoft.Json;
using System.Linq;

namespace WWB.Paylink.BaoFooTransfer.Domain
{
    public class TransHead
    {
        [JsonProperty("return_code")]
        public string ReturnCode { get; set; }

        [JsonProperty("return_msg")]
        public string ReturnMsg { get; set; }

        [JsonProperty("trans_count")]
        public int? TransCount { get; set; }

        [JsonProperty("trans_totalMoney")]
        public decimal? TransTotalMoney { get; set; }

        public bool IsSuccess
        {
            get
            {
                string[] _successCodes = new string[] { "0000", "200", "0300", "0401", "0999" };

                return _successCodes.Contains(ReturnCode);
            }
        }
    }
}