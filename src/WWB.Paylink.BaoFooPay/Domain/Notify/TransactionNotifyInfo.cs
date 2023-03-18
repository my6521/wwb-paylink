using Newtonsoft.Json;
using WWB.Paylink.Utility.Converter;

namespace WWB.Paylink.BaoFooPay.Domain.Notify
{
public class TransactionNotifyInfo
{
    /// <summary>
    /// 商户订单号
    /// </summary>
    [JsonProperty("transNo")]
    public string TransNo { get; set; }

    /// <summary>
    /// 交易订单号
    /// </summary>
    [JsonProperty("tradeNo")]
    public string TradeNo { get; set; }

    /// <summary>
    /// 交易金额
    /// </summary>
    [JsonProperty("orderAmt")]
    public int OrderAmt { get; set; }

    /// <summary>
    /// 交易状态
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
    /// 支付类型
    /// </summary>
    [JsonProperty("payType")]
    public string PayType { get; set; }

    /// <summary>
    /// 商品信息
    /// </summary>
    [JsonProperty("goodsInfo")]
    public string GoodsInfo { get; set; }

    /// <summary>
    /// 交易时间
    /// </summary>
    [JsonProperty("requestDate")]
    public string RequestDate { get; set; }

    /// <summary>
    /// 用户账号
    /// </summary>
    [JsonProperty("buyerName")]
    public string BuyerName { get; set; }

    /// <summary>
    /// 渠道商户订单号
    /// </summary>
    [JsonProperty("channelOrderNo")]
    public string ChannelOrderNo { get; set; }

    /// <summary>
    /// 渠道交易单号
    /// </summary>
    [JsonProperty("payOrderNo")]
    public string PayOrderNo { get; set; }

    /// <summary>
    /// 渠道支付方式
    /// </summary>
    [JsonProperty("fundChannel")]
    public string RundChannel { get; set; }

    /// <summary>
    /// 渠道支付编码
    /// </summary>
    [JsonProperty("fundBankCode")]
    public string FundBankCode { get; set; }

    /// <summary>
    /// 附加字段
    /// </summary>
    [JsonProperty("extend")]
    public string Extend { get; set; }

    /// <summary>
    /// 扩展信息域
    /// </summary>
    [JsonProperty("memo")]
    [JsonConverter(typeof(StringToObjectConverter))]
    public TransactionNotifyMemo Memo { get; set; }
}
}