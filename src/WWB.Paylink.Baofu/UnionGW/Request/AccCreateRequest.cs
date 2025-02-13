using WWB.Paylink.Baofu.UnionGW.Response;

namespace WWB.Paylink.Baofu.UnionGW.Request
{
    /// <summary>
    /// 个人/机构开户接口
    /// </summary>
    public class AccCreateRequest : BaseUnionGWRRequest, IBaofuRequest<BaseUnionGWResponse<AccCreateResponse>>
    {
        public AccCreateRequest() : base(ServiceTpConsts.宝财通开户)
        {
        }

        public string version { get; set; } = "4.1.0";

        /// <summary>
        /// 账户类型:1-个人,2-企业/个体
        /// </summary>
        public int accType { get; set; }

        /// <summary>
        /// 开户具体信息根据类型不同,信息不同,现只支持单笔开户
        /// </summary>
        public object accInfo { get; set; }

        /// <summary>
        /// 开户结果通知地址
        /// </summary>
        public string noticeUrl { get; set; }

        /// <summary>
        /// 宝财通2.0: BCT2.0
        /// </summary>
        public string businessType { get; set; } = "BCT2.0";

        public class PersonAccInfo
        {
            /// <summary>
            /// 请求流水号
            /// </summary>
            public string transSerialNo { get; set; }

            /// <summary>
            /// 登录号,商户自定义要求全局唯一，长度11位以上
            /// </summary>
            public string loginNo { get; set; }

            /// <summary>
            /// 客户名称与持卡人姓名一致
            /// </summary>
            public string customerName { get; set; }

            /// <summary>
            /// 证件类型,身份证: ID
            /// </summary>
            public string certificateType { get; set; }

            /// <summary>
            /// 身份证号码
            /// </summary>
            public string certificateNo { get; set; }

            /// <summary>
            /// 卡号
            /// </summary>
            public string cardNo { get; set; }

            /// <summary>
            /// 银行预留手机号
            /// </summary>
            public string mobileNo { get; set; }

            /// <summary>
            /// 持卡人姓名
            /// </summary>
            public string cardUserName { get; set; }

            /// <summary>
            /// 是否需要上传附件,true/false
            /// </summary>
            public bool needUploadFile { get; set; }

            /// <summary>
            /// 平台号 (代理模式下此处为业务方商户号非代理商商户号)
            /// </summary>
            public string platformNo { get; set; }

            /// <summary>
            /// 终端号(代理模式必传)
            /// </summary>
            public string platformTerminalId { get; set; }

            /// <summary>
            /// 资质文件流水,是否上传请咨询业务对接人
            /// </summary>
            public string qualificationTransSerialNo { get; set; }
        }

        public class CompanyAccInfo
        {
            /// <summary>
            /// 请求流水号
            /// </summary>
            public string transSerialNo { get; set; }

            /// <summary>
            /// 登录号,商户自定义要求全局唯一，长度11位以上
            /// </summary>
            public string loginNo { get; set; }

            /// <summary>
            /// 邮箱
            /// </summary>
            public string email { get; set; }

            /// <summary>
            /// 是否个体户  企业为false，不传默认为false
            /// </summary>
            public bool selfEmployed { get; set; }

            /// <summary>
            /// 商户名称（营业执照上的名称）
            /// </summary>
            public string customerName { get; set; }

            /// <summary>
            /// 商户名称别名
            /// </summary>
            public string aliasName { get; set; }

            /// <summary>
            /// 	证件号码
            /// </summary>
            public string certificateNo { get; set; }

            /// <summary>
            /// 证件类型 营业执照:LICENSE
            /// </summary>
            public string certificateType { get; set; }

            /// <summary>
            /// 法人姓名
            /// </summary>
            public string corporateName { get; set; }

            /// <summary>
            /// 法人证件类型：身份证-ID， 港澳通行证-HONG_KONG_AND_MACAO_PASS 台湾同胞来往内地通行证-TAIWAN_TRAVEL_PERMIT 护照-PASSPORT
            /// </summary>
            public string corporateCertType { get; set; }

            /// <summary>
            /// 法人身份证号码/港澳通行证/台湾同胞来往内地通行证
            /// </summary>
            public string corporateCertId { get; set; }

            /// <summary>
            /// 法人手机号
            /// </summary>
            public string corporateMobile { get; set; }

            /// <summary>
            /// 公司所属行业 见附录
            /// </summary>
            public string industryId { get; set; }

            /// <summary>
            /// 联系人姓名
            /// </summary>
            public string contactName { get; set; }

            /// <summary>
            /// 联系人手机号
            /// </summary>
            public string contactMobile { get; set; }

            /// <summary>
            /// 卡号
            /// </summary>
            public string cardNo { get; set; }

            /// <summary>
            /// 银行名称
            /// </summary>
            public string bankName { get; set; }

            /// <summary>
            /// 开户行省份
            /// </summary>
            public string depositBankProvince { get; set; }

            /// <summary>
            /// 开户行城市
            /// </summary>
            public string depositBankCity { get; set; }

            /// <summary>
            /// 开户支行名称
            /// </summary>
            public string depositBankName { get; set; }

            /// <summary>
            /// 注册资本
            /// </summary>
            public string registerCapital { get; set; }

            /// <summary>
            /// 持卡人姓名 当开个体户且绑定对私卡时需传此字段,否则默认绑定对公卡
            /// </summary>
            public string cardUserName { get; set; }

            /// <summary>
            /// 平台号(主商户号) (代理模式必传)
            /// </summary>
            public string platformNo { get; set; }

            /// <summary>
            /// 终端号(代理模式必传)
            /// </summary>
            public string platformTerminalId { get; set; }

            /// <summary>
            /// 资质文件流水,businessType为宝财通2.0非必填
            /// </summary>
            public string qualificationTransSerialNo { get; set; }
        }
    }
}