﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WWB.Paylink.Baofu.Juhe.Dtos;
using WWB.Paylink.Baofu.Juhe.Response;

namespace WWB.Paylink.Baofu.Juhe.Request
{
    public class JuheShareAfterPayRequest : BaseJuheRequest, IBaofuRequest<BaseJuheResponse<JuheShareAfterPayResponse>>
    {
        public JuheShareAfterPayRequest() : base("share_after_pay")
        {
        }

        /// <summary>
        /// 与商户订单号对应的宝付侧唯一订单号，推荐传入此值。originTradeNo和originOutTradeNo必须二选一上送
        /// </summary>
        public string originTradeNo { get; set; }

        /// <summary>
        /// 商户系统内部订单号，同一个商户号下唯一。originTradeNo和originOutTradeNo必须二选一上送
        /// </summary>
        public string originOutTradeNo { get; set; }

        /// <summary>
        /// 发起分账交易时间 	20210315155012
        /// </summary>
        [Required]
        public string txnTime { get; set; }

        /// <summary>
        /// 商户分账订单号，查询分账订单
        /// </summary>
        [Required]
        public string outTradeNo { get; set; }

        /// <summary>
        /// 宝付分账完成通知商户侧接收地址，不传入此值则不通知
        /// </summary>
        public string notifyUrl { get; set; }

        /// <summary>
        /// JSON数组 “sharingDetails”:[{“sharingAmt”:100,”sharingMerId”:”100000”},{“sharingAmt”:200,”sharingMerId”:”100001”}]
        /// </summary>
        [Required]
        public List<SharingDetailsEntity> sharingDetails { get; set; }
    }
}