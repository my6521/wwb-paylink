namespace WWB.Paylink.HsqPay;

public abstract class HsqPayResponse : HsqPayObject
{
    [JsonProperty("success")]
    public string Success { get; set; }

    [JsonProperty("errorCode")]
    public string ErrorCode { get; set; }

    [JsonProperty("errorMsg")]
    public string ErrorMsg { get; set; }

    [JsonProperty("result")]
    public string Result { get; set; }

    [JsonProperty("sign")]
    public string Sign { get; set; }

    [JsonIgnore] public bool IsError => !Success.ToLower().Equals("true");

    /// <summary>
    /// 原始内容
    /// </summary>
    [JsonIgnore]
    public string Body { get; set; }

    internal virtual IDictionary<string, string> GetParameters()
    {
        var parameters = new Dictionary<string, string>()
        {
            {HsqPayConsts.SIGN, Sign}
        };
        if (!IsError)
        {
            parameters.Add("result", Result);
            parameters.Add("success", Success);
        }
        else
        {
            parameters.Add("errorCode", ErrorCode);
            parameters.Add("errorMsg", ErrorMsg);
            parameters.Add("success", Success);
        }

        return parameters;
    }

    internal virtual void Execute()
    {
    }
}