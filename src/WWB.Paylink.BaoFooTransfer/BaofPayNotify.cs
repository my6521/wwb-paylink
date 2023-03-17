namespace WWB.Paylink.BaoFooTransfer;

public abstract class BaofPayNotify : BaofPayObject
{
    /// <summary>
    /// 原始内容
    /// </summary>
    [JsonIgnore]
    public string Body { get; set; }

    internal virtual void Execute(BaofPayOptions options)
    {
    }
}