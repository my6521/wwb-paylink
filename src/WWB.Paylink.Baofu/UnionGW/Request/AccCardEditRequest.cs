using WWB.Paylink.Baofu.UnionGW.Response;

namespace WWB.Paylink.Baofu.UnionGW.Request
{
    public class AccCardEditRequest : BaseUnionGWRRequest, IBaofuRequest<BaseUnionGWResponse<AccCardEditResponse>>
    {
        public AccCardEditRequest() : base(ServiceTpConsts.修改绑定卡信息)
        {
        }

        /// <summary>
        /// 版本号4.0.0
        /// </summary>
        public string version { get; set; } = "4.0.0";

        /// <summary>
        /// 账户类型:1个人,2商户
        /// </summary>
        public int accType { get; set; }

        /// <summary>
        /// 开户具体信息根据类型不同,信息不同,现只支持单笔修改
        /// </summary>
        public object accInfo { get; set; }

        public class PersonCardInfo
        {
            /// <summary>
            /// 客户账户号
            /// </summary>
            public string contractNo { get; set; }

            /// <summary>
            /// 	请求流水号
            /// </summary>
            public string transSerialNo { get; set; }

            /// <summary>
            /// 卡号
            /// </summary>
            public string cardNo { get; set; }

            /// <summary>
            /// 银行预留手机号
            /// </summary>
            public string mobileNo { get; set; }
        }

        public class CompanyCardInfo
        {
            /// <summary>
            /// 客户账户号
            /// </summary>
            public string contractNo { get; set; }

            /// <summary>
            /// 请求流水号
            /// </summary>
            public string transSerialNo { get; set; }

            /// <summary>
            /// 卡号 (修改卡号时必传)
            /// </summary>
            public string cardNo { get; set; }

            /// <summary>
            /// 银行名称 (修改卡号时必传
            /// </summary>
            public string bankName { get; set; }

            /// <summary>
            /// 开户行省份 (修改卡号时必传)
            /// </summary>
            public string depositBankProvince { get; set; }

            /// <summary>
            /// 开户行城市 (修改卡号时必传)
            /// </summary>
            public string depositBankCity { get; set; }

            /// <summary>
            /// 开户支行 (修改卡号时必传)
            /// </summary>
            public string depositBankName { get; set; }

            /// <summary>
            /// 联系人姓名
            /// </summary>
            public string contactName { get; set; }

            /// <summary>
            /// 联系人手机号
            /// </summary>
            public string contactMobile { get; set; }

            /// <summary>
            /// 法人手机号,当开个体户且绑定对私卡时必传
            /// </summary>
            public string corporateMobile { get; set; }
        }
    }
}