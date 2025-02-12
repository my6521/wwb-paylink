using System.Collections.Generic;

namespace WWB.Paylink.Baofu.UnionGW.Response
{
    public class AccAccountRecordQueryResponse : BaseUnionGWResponseBody
    {
        public int pageNum { get; set; }
        public int pageSize { get; set; }
        public int pageCount { get; set; }

        public List<AccAccountRecord> list { get; set; }

        public class AccAccountRecord
        {
            /// <summary>
            /// 交易类型 :RECHARGE 入金,TRANSFER 划拨 ,WITHDRAW 出金
            /// </summary>
            public string transType { get; set; }

            /// <summary>
            /// 余额方向：CR-贷款（收入）/ DR-借款（支出）
            /// </summary>
            public string drCrFlag { get; set; }

            /// <summary>
            /// 币种 CNY人民币
            /// </summary>
            public string ccy { get; set; }

            /// <summary>
            /// 交易金额,单位：元
            /// </summary>
            public decimal amount { get; set; }

            /// <summary>
            /// 交易后余额,单位：元
            /// </summary>
            public decimal afterBal { get; set; }

            /// <summary>
            /// 创建时间yyyy-MM-dd HH:mm:ss
            /// </summary>
            public string creatTime { get; set; }

            /// <summary>
            /// 宝付订单号
            /// </summary>
            public string orderId { get; set; }

            /// <summary>
            /// 商户订单号
            /// </summary>
            public string transSerialNo { get; set; }

            /// <summary>
            /// SHARE-分账
            /// OFFSET_SHARE-差额分账
            /// REFUND-退款
            /// TRANSFER-转账
            /// WITHDRAW-提现
            /// CLEAR-资金清算
            /// OTHER-其他
            /// WITHDRAW_CANCEL-提现退回
            /// </summary>
            public string businessTadeType { get; set; }
        }
    }
}