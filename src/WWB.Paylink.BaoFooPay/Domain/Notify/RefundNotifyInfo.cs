using Newtonsoft.Json;

namespace WWB.Paylink.BaoFooPay.Domain.Notify
{
public class RefundNotifyInfo
{
    /// <summary>
    /// 商户订单号
    /// </summary>
    [JsonProperty("transNo")]
    public string TransNo { get; set; }

    /// <summary>
    /// 原商户订单号
    /// </summary>
    [JsonProperty("origTransNo")]
    public string OrigTransNo { get; set; }

    /// <summary>
    /// 交易订单号
    /// </summary>
    [JsonProperty("tradeNo")]
    public string TradeNo { get; set; }

    /// <summary>
    /// 退款金额
    /// </summary>
    [JsonProperty("orderAmt")]
    public string OrderAmt { get; set; }

    /// <summary>
    /// 退款状态
    /// </summary>
    [JsonProperty("orderStatus")]
    public string OrderStatus { get; set; }

    /// <summary>
    /// 完成时间
    /// </summary>
    [JsonProperty("finishedDate")]
    public string FinishedDate { get; set; }

    /// <summary>
    /// 响应码
    /// </summary>
    [JsonProperty("respCode")]
    public string RespCode { get; set; }

    /// <summary>
    /// 响应描述
    /// </summary>
    [JsonProperty("respMsg")]
    public string RespMsg { get; set; }

    /// <summary>
    /// 附加字段,原样返回
    /// </summary>
    [JsonProperty("extend")]
    public string Extend { get; set; }
}
}