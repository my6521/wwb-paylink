using Newtonsoft.Json;

namespace WWB.Paylink.BaoFooPay.Domain.ResResult
{
    public class ComplaintQueryResponseResult
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
        public int otalSize { get; set; }

        /// <summary>
        /// 投诉信息详情
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// 投诉订单号
        /// </summary>
        [JsonProperty("complaintId")]
        public string ComplaintId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("merchantTradeNo")]
        public string MerchantTradeNo { get; set; }

        /// <summary>
        /// 投诉金额
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 投诉单状态
        /// </summary>
        [JsonProperty("complaintState")]
        public string ComplaintState { get; set; }

        /// <summary>
        /// 投诉时间
        /// </summary>
        [JsonProperty("complaintTime")]
        public string complaintTime { get; set; }

        /// <summary>
        /// 问题描述
        /// </summary>
        [JsonProperty("problemDescription")]
        public string ProblemDescription { get; set; }

        /// <summary>
        /// 投诉内容描述
        /// </summary>
        [JsonProperty("complaintDetail")]
        public string ComplaintDetail { get; set; }

        /// <summary>
        /// 用户投诉次数
        /// </summary>
        [JsonProperty("userComplaintTimes")]
        public string UserComplaintTimes { get; set; }

        /// <summary>
        /// 是否有待回复的用户留言
        /// </summary>
        [JsonProperty("incomingUserResponse")]
        public string IncomingUserResponse { get; set; }

        /// <summary>
        /// 投诉人openId
        /// </summary>
        [JsonProperty("payerOpenid")]
        public string PayerOpenId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty("merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 代理商户号
        /// </summary>
        [JsonProperty("agentNo")]
        public string AgentNo { get; set; }

        /// <summary>
        /// 	投诉人联系方式
        /// </summary>
        [JsonProperty("payerPhone")]
        public string PayerPhone { get; set; }

        /// <summary>
        /// 是否全额退款
        /// </summary>
        [JsonProperty("complaintFullRefunded")]
        public string ComplaintFullRefunded { get; set; }
    }
}