using Newtonsoft.Json;

namespace WWB.Paylink.BaoFooTransfer.Domain.Request
{
    public class TransReqData
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("trans_no")] public string TransNo { get; set; }

        /// <summary>
        /// 转账金额
        /// </summary>
        [JsonProperty("trans_money")] public decimal TransMoney { get; set; }

        /// <summary>
        /// 收款人姓名
        /// </summary>
        [JsonProperty("to_acc_name")] public string ToAccName { get; set; }

        /// <summary>
        /// 收款人银行帐号
        /// </summary>
        [JsonProperty("to_acc_no")] public string ToAccNo { get; set; }

        /// <summary>
        /// 收款人银行名称
        /// </summary>
        [JsonProperty("to_bank_name")] public string ToBankName { get; set; }

        /// <summary>
        /// 收款人开户行省名
        /// </summary>
        [JsonProperty("to_pro_name")] public string ToProName { get; set; }

        /// <summary>
        /// 联行号
        /// </summary>
        [JsonProperty("trans_cnap")] public string TransCnap { get; set; }

        /// <summary>
        /// 收款人开户行市名
        /// </summary>
        [JsonProperty("to_city_name")] public string ToCityName { get; set; }

        /// <summary>
        /// 收款人开户行机构名
        /// </summary>
        [JsonProperty("to_acc_dept")] public string ToAccDept { get; set; }

        /// <summary>
        /// 银行卡身份证件号码
        /// </summary>
        [JsonProperty("trans_card_id")] public string TransCardId { get; set; }

        /// <summary>
        /// 银行卡预留手机号
        /// </summary>
        [JsonProperty("trans_mobile")] public string TransMobile { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        [JsonProperty("trans_summary")] public string TransSummary { get; set; }

        /// <summary>
        /// 用途
        /// </summary>
        [JsonProperty("trans_reserved")] public string TransReserved { get; set; }
    }
}