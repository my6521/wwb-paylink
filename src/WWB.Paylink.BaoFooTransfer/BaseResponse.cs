using Newtonsoft.Json;
using WWB.Paylink.BaoFooTransfer.Domain;

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

    public abstract class BaseUnionGWResponse<T> : BaseResponse
    {
        /// <summary>
        ///
        /// </summary>
        [JsonIgnore]
        public T ResultData { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonIgnore]
        public UnionGWResultHeader Header { get; set; }

        /// <summary>
        /// 处理器
        /// </summary>
        internal override void Execute()
        {
            var result = JsonConvert.DeserializeObject<UnionGWResultWraper<T>>(Raw);
            ResultData = result.Body;
            Header = result.Header;
        }
    }
}