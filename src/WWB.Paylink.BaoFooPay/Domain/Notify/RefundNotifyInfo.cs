namespace WWB.Paylink.BaoFooPay.Domain.Notify;

public class RefundNotifyInfo
{
    [JsonProperty("transNo")]
    public string transNo { get; set; }

    [JsonProperty("origTransNo")]
    public string origTransNo { get; set; }

    [JsonProperty("tradeNo")]
    public string tradeNo { get; set; }

    [JsonProperty("orderAmt")]
    public string orderAmt { get; set; }

    [JsonProperty("orderStatus")]
    public string orderStatus { get; set; }

    [JsonProperty("finishedDate")]
    public string finishedDate { get; set; }

    [JsonProperty("respCode")]
    public string respCode { get; set; }

    [JsonProperty("respMsg")]
    public string respMsg { get; set; }

    [JsonProperty("extend")]
    public string extend { get; set; }
}