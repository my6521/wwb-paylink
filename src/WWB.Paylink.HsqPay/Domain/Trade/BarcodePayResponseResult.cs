namespace WWB.Paylink.HsqPay.Domain.Trade;

public class BarcodePayResponseResult
{
    /// <summary>
    /// 商户订单号
    /// </summary>
    public string transNo { get; set; }

    /// <summary>
    /// 交易订单号
    /// </summary>
    public string tradeNo { get; set; }

    /// <summary>
    /// 交易金额
    /// </summary>
    public int orderAmt { get; set; }

    /// <summary>
    /// orderStatus
    /// </summary>
    public string orderStatus { get; set; }

    /// <summary>
    /// 完成时间
    /// </summary>
    public string finishedDate { get; set; }

    /// <summary>
    /// 错误码
    /// </summary>
    public string respCode { get; set; }

    /// <summary>
    /// 错误信息
    /// </summary>
    public string respMsg { get; set; }

    /// <summary>
    /// 预支付交易会话标识
    /// </summary>
    public string qrCode { get; set; }

    /// <summary>
    /// 第三方支付流水号
    /// </summary>
    /// <remarks>
    /// 支付宝 微信 银联等第三方支付返回的流水号
    /// </remarks>
    public string payOrderNo { get; set; }

    /// <summary>
    /// 第三方支付支付方式
    /// </summary>
    /// <remarks>
    /// 支付宝 微信 银联等第三方支付返回的支付方式如 余额 花呗 银行卡信用卡等 取值详见支付宝微信文档
    /// </remarks>
    public string fundChannel { get; set; }

    /// <summary>
    /// 第三方支付银行编码/借贷标识
    /// </summary>
    /// <remarks>
    /// 支付宝 微信 银联等第三方支付返回的银行编码/借贷标识取值详见支付宝微信文档
    /// </remarks>
    public string fundBankCode { get; set; }
}