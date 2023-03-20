using Newtonsoft.Json;
using System.Collections.Generic;

namespace WWB.Paylink.BaoFooPay.Domain.ResResult
{
    public class ComplaintQueryHistoryResponseResult
    {
        /// <summary>
        /// 分页开始位置
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 返回条数
        /// </summary>
        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }

        /// <summary>
        /// 投诉信息详情
        /// </summary>
        [JsonProperty("data")]
        public List<ComplaintQueryHistoryResponseResultData> Data { get; set; }
    }
}