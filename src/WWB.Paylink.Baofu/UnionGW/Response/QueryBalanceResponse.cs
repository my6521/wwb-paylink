using Newtonsoft.Json;

namespace WWB.Paylink.Baofu.UnionGW.Response
{
    public class QueryBalanceResponse : BaseUnionGWResponseBody
    {
        /// <summary>
        /// 账户类型
        /// </summary>
        [JsonProperty("accountType")]
        public string AccountType { get; set; }

        /// <summary>
        /// 余额 单位元，最多2位小数
        /// </summary>
        [JsonProperty("balance")]
        public decimal Balance { get; set; }
    }
}