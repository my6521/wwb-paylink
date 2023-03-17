namespace WWB.Paylink.HsqPay.Domain.Trade;

public class AppletPayRequestBizModel : RequireMemoObject<AppletPayRequestMemo>
{
    /// <summary>
    /// 门店编号
    /// </summary>
    /// <remarks>
    /// 商户在支付平台创建生成的门店编号
    /// </remarks>
    public string subMerchantNo { get; set; }

    /// <summary>
    /// 商户订单号
    /// </summary>
    /// <remarks>
    /// 商户系统内部订单号，唯一不重复
    /// </remarks>
    [Required]
    public string transNo { get; set; }

    /// <summary>
    /// 交易类型
    /// </summary>
    [Required]
    public string payType { get; set; }

    /// <summary>
    /// 后端通知地
    /// </summary>
    public string returnUrl { get; set; }

    /// <summary>
    /// 前台通知地址
    /// </summary>
    public string pageUrl { get; set; }

    /// <summary>
    /// 交易金额.单位为：分
    /// </summary>
    [Range(1, int.MaxValue)]
    public int orderAmt { get; set; }

    /// <summary>
    /// 商品信息
    /// </summary>
    [Required]
    public string goodsInfo { get; set; }

    /// <summary>
    /// 交易时间
    /// </summary>
    /// <remarks>
    /// 请求时间，与当前系统时间相差小于10分钟，格式[yyyyMMddHHmmss]
    /// </remarks>
    [Required]
    public string requestDate { get; set; }

    /// <summary>
    /// 附加字段
    /// </summary>
    /// <remarks>
    /// 附加数据，在查询API和支付通知中原样返回，可作为自定义参数使用
    /// </remarks>
    public string extend { get; set; }
}