using System.Collections.Generic;

namespace WWB.Paylink.Baofu.UnionGW.Response
{
    public class AccMonthBalanceQueryResponse
    {
        /// <summary>
        /// 客户号
        /// </summary>
        public string contractNo { get; set; }

        /// <summary>
        /// 客户姓名
        /// </summary>
        public string customerName { get; set; }

        /// <summary>
        /// 客户类型：1个体、2个人、3企业
        /// </summary>
        public string customerType { get; set; }

        /// <summary>
        /// 月初余额，单位：元
        /// </summary>
        public string beforeBalance { get; set; }

        /// <summary>
        /// 入金金额，单位：元
        /// </summary>
        public string inBalance { get; set; }

        /// <summary>
        /// 入金明细
        /// </summary>
        public List<BusinessSummaryAmount> inDetails { get; set; }

        /// <summary>
        /// 出金金额
        /// </summary>
        public string outBalance { get; set; }

        /// <summary>
        /// 出金明细
        /// </summary>
        public List<BusinessSummaryAmount> outDetails { get; set; }

        /// <summary>
        /// 期末金额
        /// </summary>
        public string afterBalance { get; set; }

        public class BusinessSummaryAmount
        {
            /// <summary>
            /// 业务类型
            /// SHARE-分账
            /// OFFSET_SHARE-差额分账
            /// REFUND-退款
            /// TRANSFER-转账
            /// WITHDRAW-提现
            /// CLEAR-资金清算
            /// OTHER-其他
            /// WITHDRAW_CANCEL-提现退回
            /// </summary>
            public string businessType { get; set; }

            /// <summary>
            /// 业务类型名称
            /// </summary>
            public string businessTypeName { get; set; }

            /// <summary>
            /// 业务汇总金额，单位：元
            /// </summary>
            public string amount { get; set; }
        }
    }
}