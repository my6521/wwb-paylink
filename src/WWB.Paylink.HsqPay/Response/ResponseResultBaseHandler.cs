namespace WWB.Paylink.HsqPay.Response;

public abstract class ResponseResultBaseHandler<TResult> : HsqPayResponse
{
    /// <summary>
    /// 返回数据对象
    /// </summary>
    [JsonIgnore]
    public TResult Data { get; private set; }

    internal override void Execute()
    {
        if (string.IsNullOrWhiteSpace(Result)) throw new ArgumentNullException(nameof(Result));

        Data = JsonConvert.DeserializeObject<TResult>(Result);
    }
}