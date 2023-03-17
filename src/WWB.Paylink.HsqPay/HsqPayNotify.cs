namespace WWB.Paylink.HsqPay;

public abstract class HsqPayNotify : HsqPayObject
{
    [JsonProperty("method")]
    public string Method { get; set; }

    [JsonProperty("version")]
    public string Version { get; set; }

    [JsonProperty("format")]
    public string Format { get; set; }

    [JsonProperty("merchantNo")]
    public string MerchantNo { get; set; }

    [JsonProperty("signType")]
    public string SignType { get; set; }

    [JsonProperty("signContent")]
    public string SignContent { get; set; }

    [JsonProperty("sign")]
    public string Sign { get; set; }

    [JsonIgnore] public string Body { get; set; }

    internal virtual IDictionary<string, string> GetParameters()
    {
        var parameters = new Dictionary<string, string>
        {
            {"method", Method},
            {"version", Version},
            {"format", Format},
            {"merchantNo", MerchantNo},
            {"signType", SignType},
            {"signContent", SignContent},
            {HsqPayConsts.SIGN, Sign}
        };

        return parameters;
    }

    internal virtual void Execute()
    {
    }
}