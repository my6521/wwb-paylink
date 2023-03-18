using Newtonsoft.Json;

namespace WWB.Paylink.BaoFooPay.Domain.ReqMemo
{
    public class JsapiPayRequestMemo
    {
        /// <summary>
        /// 交易结束时间
        /// </summary>
        /// <remarks>
        /// 订单失效时间，格式[yyyyMMddHHmmss]，
        /// 建议：最短失效时间间隔大于1分钟
        /// </remarks>
       
        [JsonProperty("timeExpire")]
        public string TimeExpire { get; set; }

        /// <summary>
        /// 限制卡类型
        /// </summary>
        [JsonProperty("paylimit")]
        public string PayLimit { get; set; }

        /// <summary>
        /// 	终端用户IP
        /// </summary>
        [JsonProperty("spbillCreateIp")]
        public string SpbillCreateIp { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 微信公众号APPID
        /// </summary>
        [JsonProperty("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        /// <remarks>
        /// 用户在商户appid下的唯一标识。下单前需获取到用户的Openid，获取详见微信,支付宝
        /// </remarks>
        [JsonProperty("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 区域信息
        /// </summary>
        [JsonProperty("areaInfo")]
        public string AreaInfo { get; set; }

        /// <summary>
        /// 应用程序版本
        /// </summary>
        /// <remarks>
        /// 银联选填 固定8位，长度不足右补空格
        /// </remarks>
        [JsonProperty("appVersion")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        /// <remarks>
        /// 银联选填 终端设备类型，取值如下:
        /// 01：自动柜员机（含 ATM 和 CDM）和多媒体自助终端
        /// 02：传统 POS
        /// 03：mPOS
        /// 04：智能 POS
        /// 05：II型固定电话
        /// </remarks>
        [JsonProperty("deviceType")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 终端设备号
        /// </summary>
        /// <remarks>
        /// 银联选填 最多50位，终端设备的硬件序列号
        /// </remarks>
        [JsonProperty("deviceNo")]
        public string DeviceNo { get; set; }
    }
}