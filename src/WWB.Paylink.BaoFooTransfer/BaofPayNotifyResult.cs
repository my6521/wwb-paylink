namespace WWB.Paylink.BaoFooTransfer;

public abstract class BaofPayNotifyResult
{
    /// <summary>
    /// 交易通知处理成功
    /// </summary>
    public static IActionResult TradeHandleSuccess => new ContentResult() { Content = "ok" };

    /// <summary>
    /// 交易通知处理失败
    /// </summary>
    public static IActionResult TradeHandleFailure => new ContentResult() { Content = "failure" };
}