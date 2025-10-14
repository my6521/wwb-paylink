using System.Collections.Generic;

namespace WWB.Paylink.Baofu.UnionGW.Response
{
    public class AccCreateResponse : BaseUnionGWResponseBody
    {
        public List<AccCreateResult> result { get; set; }

        public class AccCreateResult
        {
            /// <summary>
            /// 状态 1 成功 0 失败 -1 异常 2开户处理中
            /// </summary>
            public string state { get; set; }

            /// <summary>
            /// 错误码
            /// </summary>
            public string? errorCode { get; set; }

            /// <summary>
            /// 错误原因
            /// </summary>
            public string? errorMsg { get; set; }

            /// <summary>
            /// 请求流水号
            /// </summary>
            public string transSerialNo { get; set; }

            /// <summary>
            /// 登录号
            /// </summary>
            public string loginNo { get; set; }

            /// <summary>
            /// 商户名称
            /// </summary>
            public string customerName { get; set; }

            /// <summary>
            /// 商户客户号
            /// </summary>
            public string? contractNo { get; set; }
        }
    }
}