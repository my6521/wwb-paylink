using Newtonsoft.Json;

namespace WWB.Paylink.BaoFooTransfer
{
    public abstract class BaseResponse
    {
        /// <summary>
        /// 原始内容
        /// </summary>
        [JsonIgnore]
        internal string Raw { get; set; }

        internal virtual void Execute()
        {
        }
    }
}