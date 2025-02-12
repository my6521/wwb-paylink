using System.Text.Json.Serialization;

namespace WWB.Paylink.Baofu
{
    public class BaseNotify
    {
        /// <summary>
        /// 原始内容
        /// </summary>
        [JsonIgnore]
        public string Raw { get; set; }

        internal virtual void PrimaryHandler(BaofuOptions options)
        {
        }
    }
}