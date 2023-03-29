using Newtonsoft.Json;

namespace WWB.Paylink.BaoFooTransfer.Domain.Response
{
    public class TransRespData
    {
        /// <summary>
        /// 宝付订单号
        /// </summary>
        [JsonProperty("trans_orderid")] public string TransOrderId { get; set; }

        /// <summary>
        /// 宝付批次号
        /// </summary>
        [JsonProperty("trans_batchid")] public string TransBatchId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("trans_no")] public string TransNo { get; set; }

        /// <summary>
        /// 转账金额
        /// </summary>
        [JsonProperty("trans_money")] public decimal TransMoney { get; set; }

        /// <summary>
        /// 收款人姓名
        /// </summary>
        [JsonProperty("to_acc_name")] public string ToAccName { get; set; }

        /// <summary>
        /// 收款人银行帐号
        /// </summary>
        [JsonProperty("to_acc_no")] public string ToAccNo { get; }

        /// <summary>
        /// 收款人开户行机构名
        /// </summary>
        [JsonProperty("to_acc_dept")] public string ToAccDept { get; }

        /// <summary>
        /// 摘要
        /// </summary>
        [JsonProperty("trans_summary")] public string TransSummary { get; set; }

        /// <summary>
        /// 用途
        /// </summary>
        [JsonProperty("trans_reserved")] public string TransReserved { get; set; }
    }
}