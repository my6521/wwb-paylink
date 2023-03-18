using System.Collections.Generic;
using Newtonsoft.Json;
using WWB.Paylink.BaoFooPay.Domain.ReqMemo;
using WWB.Paylink.BaoFooPay.Response;
using WWB.Paylink.Utility.Converter;

namespace WWB.Paylink.BaoFooPay.Request
{
    public class DynamicScanPayRequest : AbstractRequest, IBaoFooPayRequest<DynamicScanPayResponse>
    {
        #region 属性

        /// <summary>
        /// 门店编号
        /// </summary>
        /// <remarks>
        /// 商户在支付平台创建生成的门店编号
        /// </remarks>
        [JsonProperty("subMerchantNo")]
        public string SubMerchantNo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        /// <remarks>
        /// 商户系统内部订单号，唯一不重复
        /// </remarks>
        [JsonProperty("transNo")]
        public string TransNo { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [JsonProperty("payType")]
        public string PayType { get; set; }

        /// <summary>
        /// 后端通知地
        /// </summary>
        [JsonProperty("returnUrl")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// 前台通知地址
        /// </summary>
        [JsonProperty("pageUrl")]
        public string PageUrl { get; set; }

        /// <summary>
        /// 交易金额.单位为：分
        /// </summary>
        [JsonProperty("orderAmt")]
        public int OrderAmt { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [JsonProperty("goodsInfo")]
        public string GoodsInfo { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        /// <remarks>
        /// 请求时间，与当前系统时间相差小于10分钟，格式[yyyyMMddHHmmss]
        /// </remarks>
        [JsonProperty("requestDate")]
        public string RequestDate { get; set; }

        /// <summary>
        /// 附加字段
        /// </summary>
        /// <remarks>
        /// 附加数据，在查询API和支付通知中原样返回，可作为自定义参数使用
        /// </remarks>
        [JsonProperty("extend")]
        public string Extend { get; set; }

        /// <summary>
        /// 是否支持重复扫码
        /// </summary>
        /// <remarks>
        /// TRUE 是 FALSE否 默认是
        /// </remarks>
        [JsonProperty("reusePay")]
        public string ReusePay { get; set; }

        /// <summary>
        /// 附加数据
        /// </summary>
        [JsonConverter(typeof(ObjectToStringConverter))]
        [JsonProperty("memo")]
        public DynamicScanPayRequestMemo Memo { get; set; }

        #endregion 属性

        #region 方法

        protected override string GetMethod()
        {
            return "POLYMERIZE_MAIN_SWEPTN";
        }

        public string GetRequestUrl(bool debug)
        {
            return debug ? "https://test-api.huishouqian.com/api/acquiring" : "https://api.huishouqian.com/api/acquiring";
        }

        public IDictionary<string, string> PrimaryHandler(BaoFooPayOptions options)
        {
            return PrimaryHandler(this, options);
        }

        #endregion 方法
    }
}