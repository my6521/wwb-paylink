﻿using Newtonsoft.Json;
using WWB.Paylink.BaoFooTransfer.Constants;
using WWB.Paylink.BaoFooTransfer.Response;

namespace WWB.Paylink.BaoFooTransfer.Request
{
    public class QueryAllBalanceRequest : BaseUnionGWRRequest, IBaoFooTransRequest<QueryAllBalanceResponse>
    {
        private const string serviceTp = "T-1001-006-03";

        public QueryAllBalanceRequest() : base(serviceTp)
        {
        }

        /// <summary>
        /// 版本号4.0.0
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; } = "4.0.0";

        /// <summary>
        /// 账户类型
        /// ALL:所有账户
        /// </summary>
        [JsonProperty("accountType")]
        public string AccountType { get; } = AccountTypeConst.ALL;
    }
}