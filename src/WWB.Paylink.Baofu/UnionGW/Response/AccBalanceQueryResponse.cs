namespace WWB.Paylink.Baofu.UnionGW.Response
{
    public class AccBalanceQueryResponse : BaseUnionGWResponseBody
    {
        /// <summary>
        /// 账簿可用余额,单位：元;可用于提现
        /// </summary>
        public decimal availableBal { get; set; }

        /// <summary>
        /// 在途资金余额,单位：元
        /// </summary>
        public decimal pendingBal { get; set; }

        /// <summary>
        /// 账簿余额,单位：元; 账簿余额=可用余额(availableBal)+在途余额(pendingBal)+冻结金额
        /// </summary>
        public decimal currBal { get; set; }
    }
}