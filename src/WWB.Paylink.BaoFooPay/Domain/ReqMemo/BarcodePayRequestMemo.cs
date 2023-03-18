using Newtonsoft.Json;

namespace WWB.Paylink.BaoFooPay.Domain.ReqMemo
{
    public class BarcodePayRequestMemo
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
    }
}