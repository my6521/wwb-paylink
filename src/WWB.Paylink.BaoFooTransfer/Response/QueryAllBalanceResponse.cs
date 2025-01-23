using Newtonsoft.Json;
using System.Collections.Generic;

namespace WWB.Paylink.BaoFooTransfer.Response
{
    public class QueryAllBalanceResponse : BaseUnionGWResponse<QueryAllBalanceResponseBody>
    {
    }

    public class QueryAllBalanceResponseBody : BaseUnionGWResponseBodyBase
    {
        /// <summary>
        /// 账户集合
        /// </summary>
        [JsonProperty("queryBalanceDetailResDtoList")]
        public List<BalanceDetail> List { get; set; }

        public class BalanceDetail
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
}