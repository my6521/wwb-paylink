using System.Collections.Generic;

namespace WWB.Paylink.Baofu.UnionGW.Response
{
    public class AccQueryResponse : BaseUnionGWResponseBody
    {
        public List<AccQueryResult> result { get; set; }

        public class AccQueryResult
        {
            /// <summary>
            /// 客户账户号
            /// </summary>
            public string contractNo { get; set; }

            /// <summary>
            /// 客户账户名
            /// </summary>
            public string contractName { get; set; }

            /// <summary>
            /// 客户名
            /// </summary>
            public string customerName { get; set; }

            /// <summary>
            /// 此字段暂用不到
            /// </summary>
            public string customerNo { get; set; }

            /// <summary>
            /// 	客户类型
            /// </summary>
            public string customerType { get; set; }

            /// <summary>
            /// 	证件类型 只能取”ID”或”LICENSE”
            /// </summary>
            public string certificateType { get; set; }

            /// <summary>
            /// 	证件号码（社会信用代码）
            /// </summary>
            public string certificateNo { get; set; }

            /// <summary>
            /// 平台号
            /// </summary>
            public string platformNo { get; set; }

            /// <summary>
            /// 	绑定手机号
            /// </summary>
            public string bindMobile { get; set; }

            /// <summary>
            /// 邮箱
            /// </summary>
            public string email { get; set; }
        }
    }
}