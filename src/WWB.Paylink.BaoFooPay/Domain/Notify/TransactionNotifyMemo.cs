using Newtonsoft.Json;

namespace WWB.Paylink.BaoFooPay.Domain.Notify
{
public class TransactionNotifyMemo
{
    /// <summary>
    /// 限制卡类型
    /// </summary>
    [JsonProperty("paylimit")]
    public string Paylimit { get; set; }

    /// <summary>
    /// 交易结束时间
    /// </summary>
    [JsonProperty("timeExpire")]
    public string TimeExpire { get; set; }

    /// <summary>
    /// 用户标识
    /// </summary>
    [JsonProperty("openid")]
    public string OpenId { get; set; }

    /// <summary>
    /// 应用ID
    /// </summary>
    [JsonProperty("appid")]
    public string AppId { get; set; }

    /// <summary>
    /// 终端用户IP
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
    /// 区域信息.银联选填，区域信息，长度固定7
    /// </summary>
    [JsonProperty("areaInfo")]
    public string AreaInfo { get; set; }

    /// <summary>
    /// 用程序版本.银联选填，固定8位，长度不足右补空格
    /// </summary>
    [JsonProperty("appVersion")]
    public string AppVersion { get; set; }

    /// <summary>
    /// 设备类型.银联选填 
    /// </summary>
    [JsonProperty("deviceType")]
    public string DeviceType { get; set; }

    /// <summary>
    /// 终端设备号.银联选填 
    /// </summary>
    [JsonProperty("deviceNo")]
    public string DeviceNo { get; set; }
}
}