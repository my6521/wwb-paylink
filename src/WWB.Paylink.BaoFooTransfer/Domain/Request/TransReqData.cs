using Newtonsoft.Json;

namespace WWB.Paylink.BaoFooTransfer.Domain.Request
{
    public class TransReqData
    {
        [JsonProperty("trans_no")] public string TransNo { get; set; }
        [JsonProperty("trans_money")] public decimal TransMoney { get; set; }
        [JsonProperty("to_acc_name")] public string ToAccName { get; set; }
        [JsonProperty("to_acc_no")] public string ToAccNo { get; set; }
        [JsonProperty("to_bank_name")] public string ToBankName { get; set; }
        [JsonProperty("to_pro_name")] public string ToProName { get; set; }
        [JsonProperty("trans_cnap")] public string TransCnap { get; set; }
        [JsonProperty("to_city_name")] public string ToCityName { get; set; }
        [JsonProperty("to_acc_dept")] public string ToAccDept { get; set; }
        [JsonProperty("trans_card_id")] public string TransCardId { get; set; }
        [JsonProperty("trans_mobile")] public string TransMobile { get; set; }
        [JsonProperty("trans_summary")] public string TransSummary { get; set; }
        [JsonProperty("trans_reserved")] public string TransReserved { get; set; }
    }
}