namespace WWB.Paylink.BaoFooPay.Domain.Notify
{
public class TransactionNotifyMemo
{
    [JsonProperty("paylimit")]
    public string paylimit { get; set; }

    [JsonProperty("timeExpire")]
    public string timeExpire { get; set; }

    [JsonProperty("openid")]
    public string openid { get; set; }

    [JsonProperty("appid")]
    public string appid { get; set; }

    [JsonProperty("spbillCreateIp")]
    public string spbillCreateIp { get; set; }

    [JsonProperty("longitude")]
    public string longitude { get; set; }

    [JsonProperty("latitude")]
    public string latitude { get; set; }

    [JsonProperty("areaInfo")]
    public string areaInfo { get; set; }

    [JsonProperty("appVersion")]
    public string appVersion { get; set; }

    [JsonProperty("deviceType")]
    public string deviceType { get; set; }

    [JsonProperty("deviceNo")]
    public string deviceNo { get; set; }
}
}