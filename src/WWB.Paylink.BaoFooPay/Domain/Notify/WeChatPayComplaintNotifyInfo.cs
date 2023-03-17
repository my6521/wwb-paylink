namespace WWB.Paylink.BaoFooPay.Domain.Notify
{
    public class WeChatPayComplaintNotifyInfo
    {
        /// <summary>
        /// 动作类型
        /// </summary>
        [JsonProperty("actionType")]
        public string actionType { get; set; }

        /// <summary>
        /// 投诉单号
        /// </summary>
        [JsonProperty("complaintId")]
        public string complaintId { get; set; }

        /// <summary>
        /// 获取动作类型描述
        /// </summary>
        /// <returns></returns>
        public string GetActionDes()
        {
            return actionType switch
            {
                "CREATE_COMPLAINT" => "用户提交投诉",
                "CONTINUE_COMPLAINT" => "用户继续投诉",
                "USER_RESPONSE" => "用户新留言",
                "RESPONSE_BY_PLATFORM" => "平台新留言",
                "SELLER_REFUND" => "收款方全额退款",
                "MERCHANT_RESPONSE" => "商户新回复",
                "MERCHANT_CONFIRM_COMPLETE" => "商户反馈处理完成",
                _ => ""
            };
        }
    }
}