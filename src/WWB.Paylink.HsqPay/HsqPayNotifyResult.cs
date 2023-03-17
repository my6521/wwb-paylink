using Microsoft.AspNetCore.Mvc;

namespace WWB.Paylink.HsqPay;

public abstract class HsqPayNotifyResult
{
    /// <summary>
    /// 交易通知处理成功
    /// </summary>
    public static IActionResult TradeHandleSuccess => new ContentResult() { Content = "SUCCESS" };

    /// <summary>
    /// 交易通知处理失败
    /// </summary>
    public static IActionResult TradeHandleFailure => new ContentResult() { Content = "failure" };

    /// <summary>
    /// 代付通知处理成功
    /// </summary>
    public static IActionResult PayHandleSuccess => new JsonResult(new { statusCode = 2001, message = "成功" });

    /// <summary>
    /// 代付通知处理失败
    /// </summary>
    public static IActionResult PayHandleFailure => new JsonResult(new { statusCode = 2002, message = "失败" });
}