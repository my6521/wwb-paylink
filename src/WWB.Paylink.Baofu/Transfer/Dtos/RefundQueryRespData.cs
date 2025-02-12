using Newtonsoft.Json;

namespace WWB.Paylink.Baofu.Transfer.Dtos
{
    public class RefundQueryRespData
    {
        /// <summary>
        /// 宝付订单号
        /// </summary>
        [JsonProperty("trans_orderid")]
        public string TransOrderId { get; set; }

        /// <summary>
        /// 宝付批次号
        /// </summary>
        [JsonProperty("trans_batchid")]
        public string TransBatchId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("trans_no")]
        public string TransNo { get; set; }

        /// <summary>
        /// 转账金额
        /// </summary>
        [JsonProperty("trans_money")]
        public decimal TransMoney { get; set; }

        /// <summary>
        /// 收款人姓名
        /// </summary>
        [JsonProperty("to_acc_name")]
        public string ToAccName { get; set; }

        /// <summary>
        /// 收款人银行帐号
        /// </summary>
        [JsonProperty("to_acc_no")]
        public string ToAccNo { get; set; }

        /// <summary>
        /// 收款人开户行机构名
        /// </summary>
        [JsonProperty("to_acc_dept")]
        public string ToAccDept { get; set; }

        /// <summary>
        /// 交易手续费
        /// </summary>
        [JsonProperty("trans_fee")]
        public string TransFee { get; set; }

        /// <summary>
        /// 订单交易处理状态
        /// 0：转账中；
        /// 1：转账成功；
        /// -1：转账失败；
        /// 2：转账退款；

        [JsonProperty("state")]
        public int State { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        [JsonProperty("trans_summary")]
        public string TransSummary { get; set; }

        /// <summary>
        /// 备注（错误信息）
        /// </summary>
        [JsonProperty("trans_remark")]
        public string TransRemark { get; set; }

        /// <summary>
        /// 交易申请时间
        /// </summary>
        [JsonProperty("trans_starttime")]
        public string TransStartTime { get; set; }

        /// <summary>
        /// 交易完成时间
        /// </summary>
        [JsonProperty("trans_endtime")]
        public string TransEndTime { get; set; }

        /// <summary>
        /// 收款方宝付会员
        /// </summary>
        [JsonProperty("to_member_id")]
        public string ToMemberId { get; set; }

        /// <summary>
        /// 用途
        /// </summary>
        [JsonProperty("trans_reserved")]
        public string TransReserved { get; set; }
    }
}