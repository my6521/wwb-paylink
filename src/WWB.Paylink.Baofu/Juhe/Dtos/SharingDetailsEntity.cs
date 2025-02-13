using System.ComponentModel.DataAnnotations;

namespace WWB.Paylink.Baofu.Juhe.Dtos
{
    public class SharingDetailsEntity
    {
        /// <summary>
        /// 宝付支付分配的商户号
        /// </summary>
        [Required]
        public string sharingMerId { get; set; }

        /// <summary>
        /// 分账金额，单位：分，如：1元则传入100
        /// </summary>
        public int sharingAmt { get; set; }
    }
}