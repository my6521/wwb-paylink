using System.ComponentModel.DataAnnotations;

namespace WWB.Paylink.Baofu.UnionGW.Notify
{
    public class AccCreateNotify : BaseUnionGWNotify<AccCreateNotifyData>
    {
    }

    /// <summary>
    /// 开户结果通知
    /// </summary>
    public class AccCreateNotifyData
    {
        /// <summary>
        /// 商户号
        /// </summary>
        [Required]
        public string member_id { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        [Required]
        public string terminal_id { get; set; }

        /// <summary>
        /// 类型:类型:1-个人,2-企业,3-个体工商户
        /// </summary>
        [Required]
        public string memberType { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [Required]
        public string openSerialNo { get; set; }

        /// <summary>
        /// 状态 1 成功 0 失败 -1 异常 2开户处理中
        /// </summary>
        [Required]
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
        [Required]
        public string transSerialNo { get; set; }

        /// <summary>
        /// 登录号
        /// </summary>
        [Required]
        public string loginNo { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [Required]
        public string customerName { get; set; }

        /// <summary>
        /// 商户客户号
        /// </summary>
        [Required]
        public string contractNo { get; set; }

        public string noticeType { get; set; }
    }
}