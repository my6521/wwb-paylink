using Newtonsoft.Json;
using System.Linq;

namespace WWB.Paylink.BaoFooTransfer.Domain
{
    public class TransHead
    {
        /// <summary>
        /// 交易处理状态码
        /// </summary>
        [JsonProperty("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// 交易处理状态中文信息
        /// </summary>
        [JsonProperty("return_msg")]
        public string ReturnMsg { get; set; }

        /// <summary>
        /// 转账总笔数
        /// </summary>
        [JsonProperty("trans_count")]
        public int? TransCount { get; set; }

        /// <summary>
        /// 转账总金额
        /// </summary>
        [JsonProperty("trans_totalMoney")]
        public decimal? TransTotalMoney { get; set; }

        /// <summary>
        /// 是否提交成功
        /// </summary>
        public bool IsSuccess
        {
            get
            {
                string[] _successCodes = new string[] { "0000", "200", "0300", "0401", "0999" };

                return _successCodes.Contains(ReturnCode);
            }
        }
    }
}