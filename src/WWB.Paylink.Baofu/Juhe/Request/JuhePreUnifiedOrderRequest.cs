using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WWB.Paylink.Baofu.Juhe.Dtos;
using WWB.Paylink.Baofu.Juhe.Response;

namespace WWB.Paylink.Baofu.Juhe.Request
{
    /// <summary>
    /// H5支付（收银台）三种支付场景，商户请求宝付统一下单交易预创建接口，交易预创建成功后，宝付返回商户系统URL链接地址，商户可使用二维码生成工具将该返回值生成二维码，用户点击链接或扫码进行后续支付操作。
    /// </summary>
    public class JuhePreUnifiedOrderRequest : BaseJuheRequest, IBaofuRequest<BaseJuheResponse<JuhePreUnifiedOrderResponse>>
    {
        public JuhePreUnifiedOrderRequest() : base("pre_unified_order")
        {
        }

        /// <summary>
        /// 交易商户订单号。商户系统内部订单号，同一个商户号下唯一
        /// </summary>
        [Required]
        public string outTradeNo { get; set; }

        /// <summary>
        /// 用户实际付款金额。交易金额，单位：分，如：1元则传入100
        /// </summary>
        public int txnAmt { get; set; }

        /// <summary>
        /// 交易时间。如20210315155012
        /// </summary>
        public string txnTime { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        public int totalAmt { get; set; }

        /// <summary>
        /// 订单支付的有效时间 单位：分钟
        /// </summary>
        public int timeExpire { get; set; }

        /// <summary>
        /// 产品类型 SHARING:分账产品,ORDINARY:普通产品
        /// </summary>
        [Required]
        public string prodType { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [Required]
        public string orderType { get; set; }

        /// <summary>
        /// 请求类型 	插件支付传入固定值：APP_PAY
        /// </summary>
        public string reqType { get; set; }

        /// <summary>
        /// 是否展示收银台 值：0
        /// </summary>
        public string cashierFlag { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        public string payCode { get; set; }

        /// <summary>
        /// 支付方式属性
        /// </summary>
        public Dictionary<string, object> payExtend { get; set; }

        /// <summary>
        /// 扣费商户号 该笔交易承担手续费的商户号，默认从交易商户号收取。
        /// </summary>
        public string feeMerId { get; set; }

        /// <summary>
        /// 聚合交易商户号。在微信/支付宝报备的二级商户号
        /// </summary>
        public string subMchId { get; set; }

        /// <summary>
        /// 服务端通知地址
        /// </summary>
        [Required]
        public string notifyUrl { get; set; }

        /// <summary>
        /// 页面端跳转地址
        /// </summary>
        public string pageUrl { get; set; }

        /// <summary>
        /// 禁止贷记卡支付 1：禁止 0：不禁止不传,默认为0
        /// </summary>
        public int forbidCredit { get; set; }

        /// <summary>
        /// 附加字段
        /// </summary>
        public string attach { get; set; }

        /// <summary>
        /// 请求方保留域
        /// </summary>
        public string reqReserved { get; set; }

        /// <summary>
        /// 营销信息
        /// </summary>
        public MktInfoEntity mktInfo { get; set; }

        /// <summary>
        /// 风控信息
        /// </summary>
        [Required]
        public RiskInfoEntity riskInfo { get; set; }
    }
}