using Newtonsoft.Json;
using System.Collections.Generic;

namespace WWB.Paylink.BaoFooTransfer.Domain.Response
{
    public class QueryAllBalanceRespData
    {
        /// <summary>
        /// 返回码 1成功 2处理中 0失败
        /// </summary>
        [JsonProperty("retCode")]
        public int RetCode { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误原因
        /// </summary>
        [JsonProperty("errorMsg")]
        public string ErrorMsg { get; set; }

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