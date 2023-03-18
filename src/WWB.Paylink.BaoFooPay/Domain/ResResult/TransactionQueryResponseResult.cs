using Newtonsoft.Json;
using WWB.Paylink.Utility.Converter;

namespace WWB.Paylink.BaoFooPay.Domain.ResResult
{
    public class TransactionQueryResponseResult
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("transNo")]
        public string TransNo { get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        [JsonProperty("tradeNo")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [JsonProperty("orderAmt")]
        public int OrderAmt { get; set; }

        /// <summary>
        /// orderStatus
        /// </summary>
        [JsonProperty("orderStatus")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        [JsonProperty("finishedDate")]
        public string FinishedDate { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("respCode")]
        public string RespCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("respMsg")]
        public string RespMsg { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("payType")]
        public string PayType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("goodsInfo")]
        public string GoodsInfo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("requestDate")]
        public string RequestDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("buyerName")]
        public string BuyerName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("channelOrderNo")]
        public string ChannelOrderNo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("payOrderNo")]
        public string PayOrderNo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("fundChannel")]
        public string FundChannel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("fundBankCode")]
        public string FundBankCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("extend")]
        public string Extend { get; set; }

        [JsonProperty("memo")]
        [JsonConverter(typeof(StringToObjectConverter))]
        public TransactionQueryResultMemo Memo { get; set; }
    }
}