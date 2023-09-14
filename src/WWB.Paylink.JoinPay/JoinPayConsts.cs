namespace WWB.Paylink.JoinPay
{
    public class JoinPayConsts
    {
        public const string sign = "hmac";

        public const string return_code = "ra_Code";

        public const string MD5 = "MD5";
    }

    /// <summary>
    /// 代付币种类型
    /// </summary>
    public class JoinPayPayCurrency
    {
        /// <summary>
        /// 人民币
        /// </summary>
        public const string RMB = "201";

        /// <summary>
        /// 美元
        /// </summary>
        public const string USD = "202";
    }

    /// <summary>
    /// 代付产品类型
    /// </summary>
    public class JoinPayPayProductCode
    {
        /// <summary>
        /// 普通代付
        /// </summary>
        public const string BANK_PAY_ORDINARY_ORDER = "BANK_PAY_ORDINARY_ORDER";

        /// <summary>
        /// 朝夕付
        /// </summary>
        public const string BANK_PAY_DAILY_ORDER = "BANK_PAY_DAILY_ORDER";

        /// <summary>
        /// 任意付
        /// </summary>
        public const string BANK_PAY_MAT_ENDOWMENT_ORDER = "BANK_PAY_MAT_ENDOWMENT_ORDER";

        /// <summary>
        /// 组合付
        /// </summary>
        public const string BANK_PAY_COMPOSE_ORDER = "BANK_PAY_COMPOSE_ORDER";
    }

    /// <summary>
    /// 代付账户类型 
    /// </summary>
    public class JoinPayPayReceiverAccountType
    {
        /// <summary>
        /// 对私
        /// </summary>
        public const string DUI_SI = "201";

        /// <summary>
        /// 对公
        /// </summary>
        public const string DUI_GONG = "204";
    }

    /// <summary>
    /// 代付用途类型  
    /// </summary>
    public class JonPayPayPaidUse
    {
        public const string 工资资金 = "201";
        public const string 活动经费 = "202";
        public const string 养老金 = "203";
        public const string 货款 = "204";
        public const string 劳务费 = "205";
        public const string 保险理财 = "206";
        public const string 资金下发 = "207";
        public const string 营业退款 = "208";
        public const string 其他 = "209";
        public const string 退回款项 = "210";
        public const string 消费款项 = "211";
    }

    /// <summary>
    /// 代付应答码
    /// </summary>
    public class JoinPayPayResponseStatusCode
    {
        public const string 受理成功 = "2001";
        public const string 受理失败 = "2002";
        public const string 未知 = "2003";
    }

    /// <summary>
    /// 代付明细状态码
    /// </summary>
    public class JoinPayPayStatusCode
    {
        public const string 订单已创建 = "201";
        public const string 待商户审核 = "202";
        public const string 交易处理中 = "203";
        public const string 交易失败 = "204";
        public const string 交易成功 = "205";
        public const string 订单已取消 = "208";
        public const string 账务冻结中 = "210";
        public const string 账务解冻中 = "211";
        public const string 订单取消中 = "212";
        public const string 账务扣款中 = "213";
        public const string 订单不存在 = "214";
    }
}