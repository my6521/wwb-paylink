using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WWB.Paylink.Baofu.Juhe.Response;

namespace WWB.Paylink.Baofu.Juhe.Request
{
    public class JuheOrderRefundRequest : BaseJuheRequest, IBaofuRequest<BaseJuheResponse<JuheOrderRefundResponse>>
    {
        public JuheOrderRefundRequest() : base("order_refund")
        {
        }

        /// <summary>
        /// 代理商商户号
        /// </summary>
        public string agentMerId { get; set; }

        /// <summary>
        /// 代理商终端号
        /// </summary>
        public string agentTerId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [Required]
        public string merId { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        [Required]
        public string terId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        public string merchantName { get; set; }

        /// <summary>
        /// 原支付订单宝付交易号
        /// </summary>
        public string originTradeNo { get; set; }

        /// <summary>
        /// 原支付订单商户订单号
        /// </summary>
        public string originOutTradeNo { get; set; }

        /// <summary>
        /// 退款订单号
        /// </summary>
        [Required]
        public string outTradeNo { get; set; }

        /// <summary>
        /// 服务端通知地址
        /// </summary>
        [Required]
        public string notifyUrl { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        public int refundAmt { get; set; }

        /// <summary>
        /// 退款总金额
        /// </summary>
        public int totalAmt { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        public string txnTime { get; set; }

        /// <summary>
        /// 附加字段
        /// </summary>
        public string attach { get; set; }

        /// <summary>
        /// 请求方保留域
        /// </summary>
        public string reqReserved { get; set; }

        /// <summary>
        /// 分账退款信息 JSON数组 [{“sharingAmt”:100,”sharingMerId”:”100000”},{“sharingAmt”:200,”sharingMerId”:”100001”}]
        /// </summary>
        public List<SharingRefundInfo> sharingRefundInfo { get; set; }

        /// <summary>
        /// 营销退款信息 {“mktAmt”:100,”mktMerId”:”100000”}
        /// </summary>
        public MktRefundInfo mktRefundInfo { get; set; }

        /// <summary>
        /// 垫资金额
        /// </summary>
        public int advanceAmt { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [Required]
        public string refundReason { get; set; }

        /// <summary>
        /// 分账退款信息
        /// </summary>
        public class SharingRefundInfo
        {
            /// <summary>
            /// 商户号
            /// </summary>
            public string sharingMerId { get; set; }

            /// <summary>
            /// 分账金额
            /// </summary>
            public int sharingAmt { get; set; }
        }

        /// <summary>
        /// 营销退款信息
        /// </summary>
        public class MktRefundInfo
        {
            /// <summary>
            /// 商户号
            /// </summary>
            public string mktMerId { get; set; }

            /// <summary>
            /// 营销金额
            /// </summary>
            public int mktAmt { get; set; }
        }
    }
}