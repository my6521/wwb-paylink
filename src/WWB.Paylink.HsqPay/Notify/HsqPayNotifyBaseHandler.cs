namespace WWB.Paylink.HsqPay.Notify;

public abstract class HsqPayNotifyBaseHandler<T> : HsqPayNotify
{
    /// <summary>
    /// 返回数据对象
    /// </summary>
    [JsonIgnore]
    public T ResultData { get; set; }

    internal override void Execute()
    {
        if (string.IsNullOrWhiteSpace(SignContent)) throw new ArgumentNullException(nameof(SignContent));

        ResultData = JsonConvert.DeserializeObject<T>(SignContent);
    }
}