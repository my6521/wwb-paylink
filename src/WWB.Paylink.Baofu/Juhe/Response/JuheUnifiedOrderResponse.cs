using System.Collections.Generic;

namespace WWB.Paylink.Baofu.Juhe.Response
{
    public class JuheUnifiedOrderResponse
    {
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
        public string merId { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        public string terId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string outTradeNo { get; set; }

        /// <summary>
        /// 订单状态 订单状态，详见附录
        /// </summary>
        public string txnState { get; set; }

        /// <summary>
        /// 宝付交易号
        /// </summary>
        public string tradeNo { get; set; }

        /// <summary>
        /// 请求渠道订单号
        /// </summary>
        public string reqChlNo { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        public string payCode { get; set; }

        /// <summary>
        /// 渠道返回参数 根据不同的支付方式返回相应的业务参数，作为商户侧唤起支付，详见附录：【统一下单渠道返回参数】
        /// </summary>
        public Dictionary<string, string> chlRetParam { get; set; }

        /// <summary>
        /// 业务结果
        /// </summary>
        public string resultCode { get; set; }

        /// <summary>
        /// 错误代码 当业务结果FAIL时，返回错误代码
        /// </summary>
        public string errCode { get; set; }

        /// <summary>
        /// 错误描述 当业务结果为FAIL时，返回错误描述
        /// </summary>
        public string errMsg { get; set; }
    }
}