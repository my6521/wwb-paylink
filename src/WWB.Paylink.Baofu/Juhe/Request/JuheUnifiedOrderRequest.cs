using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WWB.Paylink.Baofu.Juhe.Dtos;
using WWB.Paylink.Baofu.Juhe.Response;

namespace WWB.Paylink.Baofu.Juhe.Request
{
    public class JuheUnifiedOrderRequest : BaseJuheRequest, IBaofuRequest<BaseJuheResponse<JuheUnifiedOrderResponse>>
    {
        public JuheUnifiedOrderRequest() : base("unified_order")
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
        /// 支付方式
        /// WECHAT_JSAPI	微信JSAPI
        /// ALIPAY_NATIVE 支付宝扫码支付（主扫）
        /// ALIPAY_JSAPI 支付宝生活号支付
        /// QUICK_PASS_NATIVE 云闪付主扫
        /// QUICK_PASS_NATIVE_JS 云闪付主扫JS
        /// </summary>
        [Required]
        public string payCode { get; set; }

        /// <summary>
        /// 支付方式属性。微信公众号为例：{“sub_openid”:”1231231231”,”sub_appid”:”1231231123”,”body”:”特价手机”}
        /// </summary>
        [Required]
        public Dictionary<string, object> payExtend { get; set; }

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