using Newtonsoft.Json;
using System.Collections.Generic;
using WWB.Paylink.BaoFooPay.Constants;

namespace WWB.Paylink.BaoFooPay
{
    public abstract class BaseResponse : ISignature
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
        public string Success { get; set; }

        /// <summary>
        /// 结果域
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }

        /// <summary>
        /// 结果域
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 判断是否成功
        /// </summary>
        [JsonIgnore]
        public bool IsSuccess => !string.IsNullOrWhiteSpace(Success) && Success.ToLower().Equals("true");

        #region 方法

        /// <summary>
        /// 获取签名验证参数
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public IDictionary<string, string> GetSignatureParameters(BaoFooPayOptions options)
        {
            var parameters = new Dictionary<string, string>();
            if (IsSuccess)
            {
                parameters.Add("result", Result);
                parameters.Add("success", Success);
            }
            else
            {
                parameters.Add("errorCode", ErrorCode);
                parameters.Add("errorMsg", ErrorMsg);
                parameters.Add("success", Success);
            }
            parameters.Add(Consts.SIGN, Sign);
            return parameters;
        }

        /// <summary>
        /// 处理器
        /// </summary>
        public virtual void PrimaryHandler()
        {
        }

        #endregion 方法
    }

    public abstract class BaseResponse<TResult> : BaseResponse
    {
        /// <summary>
        /// 结果域
        /// </summary>
        [JsonIgnore]
        public TResult ResultData { get; set; }

        /// <summary>
        /// 处理器
        /// </summary>
        public override void PrimaryHandler()
        {
            base.PrimaryHandler();
            ResultData = JsonConvert.DeserializeObject<TResult>(Result);
        }
    }
}