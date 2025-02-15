﻿using Newtonsoft.Json;
using WWB.Paylink.Baofu.UnionGW.Response;

namespace WWB.Paylink.Baofu.UnionGW.Request
{
    public class QueryBalanceRequest : BaseUnionGWRRequest, IBaofuRequest<BaseUnionGWResponse<QueryBalanceResponse>>
    {
        private const string serviceTp = "T-1001-006-03";

        public QueryBalanceRequest() : base(serviceTp)
        {
        }

        /// <summary>
        /// 版本号4.0.0
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; } = "4.0.0";

        /// <summary>
        /// 账户类型
        /// BASE_ACCOUNT:基本户
        /// FREEZE_ACCOUNT:冻结户
        /// UNSETTLE_ACCOUNT:未结算户
        /// MARGIN_ACCOUNT:保证金账户
        /// FEE_ACCOUNT:手续费账户
        /// MARKETING_ACCOUNT:营销户
        /// SPECIAL_CAPITAL_ACCOUNT:资金专户;
        /// </summary>
        [JsonProperty("accountType")]
        public string AccountType { get; set; }
    }
}