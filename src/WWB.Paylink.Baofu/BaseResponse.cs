using System.Text.Json.Serialization;

namespace WWB.Paylink.Baofu
{
    public class BaseResponse
    {
        /// <summary>
        /// 原始内容
        /// </summary>
        [JsonIgnore]
        internal string Raw { get; set; }

        /// <summary>
        /// 数据处理
        /// </summary>
        /// <param name="options"></param>
        internal virtual void PrimaryHandler(BaofuOptions options)
        {
        }
    }
}