using Newtonsoft.Json;

namespace WWB.Paylink.BaoFooTransfer.Domain.Response
{
    public class RefundQueryRespData
    {
        [JsonProperty("trans_orderid")] public string TransOrderId { get; set; }

        [JsonProperty("trans_batchid")] public string TransBatchId { get; set; }

        [JsonProperty("trans_no")] public string TransNo { get; set; }
        [JsonProperty("trans_money")] public decimal TransMoney { get; set; }
        [JsonProperty("to_acc_name")] public string ToAccName { get; set; }
        [JsonProperty("to_acc_no")] public string ToAccNo { get; set; }
        [JsonProperty("to_acc_dept")] public string ToAccDept { get; set; }
        [JsonProperty("trans_fee")] public string TransFee { get; set; }
        [JsonProperty("state")] public int State { get; set; }
        [JsonProperty("trans_summary")] public string TransSummary { get; set; }
        [JsonProperty("trans_remark")] public string TransRemark { get; set; }
        [JsonProperty("trans_starttime")] public string TransStartTime { get; set; }
        [JsonProperty("trans_endtime")] public string TransEndTime { get; set; }
        [JsonProperty("to_member_id")] public string ToMemberId { get; set; }
        [JsonProperty("trans_reserved")] public string TransReserved { get; set; }
    }
}