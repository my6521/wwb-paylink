namespace WWB.Paylink.BaofPay;

public abstract class BaofPayResponse : BaofPayObject
{
    /// <summary>
    /// 原始内容
    /// </summary>
    [JsonIgnore]
    internal string Body { get; set; }

    internal virtual void Execute()
    {
    }
}