using WWB.Paylink.BaoFooPay.Converter;

namespace WWB.Paylink.BaoFooPay.Domain.Notify;

public class TransactionNotifyInfo
{
    [JsonProperty("transNo")]
    public string transNo { get; set; }

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

    [JsonProperty("payType")]
    public string payType { get; set; }

    [JsonProperty("goodsInfo")]
    public string goodsInfo { get; set; }

    [JsonProperty("requestDate")]
    public string requestDate { get; set; }

    [JsonProperty("buyerName")]
    public string buyerName { get; set; }

    [JsonProperty("channelOrderNo")]
    public string channelOrderNo { get; set; }

    [JsonProperty("payOrderNo")]
    public string payOrderNo { get; set; }

    [JsonProperty("fundChannel")]
    public string fundChannel { get; set; }

    [JsonProperty("fundBankCode")]
    public string fundBankCode { get; set; }

    [JsonProperty("extend")]
    public string extend { get; set; }

    [JsonProperty("memo")]
    [JsonConverter(typeof(StringToObjectConverter))]
    public TransactionNotifyMemo Memo { get; set; }
}