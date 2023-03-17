namespace WWB.Paylink.BaoFooPay
{
    public abstract class BaseResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonProperty("errorMsg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 接口调用成功
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public abstract class BaseResponse<TResult> : BaseResponse
    {
        /// <summary>
        /// 结果域
        /// </summary>
        [JsonProperty("result")]
        [JsonConverter(typeof(StringToObjectConverter))]
        public TResult ResultData { get; set; }
    }
}