using Newtonsoft.Json;

namespace WWB.Paylink.BaoFooTransfer.Domain.Response
{
    public class TransRespData
    {
        [JsonProperty("trans_orderid")] public string TransOrderId { get; set; }
        [JsonProperty("trans_batchid")] public string TransBatchId { get; set; }
        [JsonProperty("trans_no")] public string TransNo { get; set; }
        [JsonProperty("trans_money")] public decimal TransMoney { get; set; }
        [JsonProperty("to_acc_name")] public string ToAccName { get; set; }
        [JsonProperty("to_acc_no")] public string ToAccNo { get; }
        [JsonProperty("to_acc_dept")] public string ToAccDept { get; }
        [JsonProperty("trans_summary")] public string TransSummary { get; set; }
        [JsonProperty("trans_reserved")] public string TransReserved { get; set; }
    }
}