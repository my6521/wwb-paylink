using System.Xml.Serialization;

namespace WWB.Paylink.BaoFooTransfer.Domain
{
    public class TransNotifyData
    {
        /// <summary>
        /// 宝付订单号
        /// </summary>
        [XmlElement("trans_orderid")] public string TransOrderId { get; set; }

        /// <summary>
        /// 宝付批次号
        /// </summary>
        [XmlElement("trans_batchid")] public string TransBatchId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("trans_no")] public string TransNo { get; set; }

        /// <summary>
        /// 转账金额
        /// </summary>
        [XmlElement("trans_money")] public string TransMoney { get; set; }

        /// <summary>
        /// 收款人姓名
        /// </summary>
        [XmlElement("to_acc_name")] public string ToAccName { get; set; }

        /// <summary>
        /// 收款人银行帐号
        /// </summary>
        [XmlElement("to_acc_no")] public string ToAccNo { get; set; }

        /// <summary>
        /// 交易手续费
        /// </summary>
        [XmlElement("trans_fee")] public string TransFee { get; set; }

        /// <summary>
        /// 订单交易处理状态
        /// 0：转账中；
        /// 1：转账成功；
        /// -1：转账失败；
        /// 2：转账退款；
        [XmlElement("state")] public int State { get; set; }

        /// <summary>
        /// 备注（错误信息）
        /// </summary>
        [XmlElement("trans_remark")] public string TransRemark { get; set; }

        /// <summary>
        /// 交易申请时间
        /// </summary>
        [XmlElement("trans_starttime")] public string TransStartTime { get; set; }

        /// <summary>
        /// 交易完成时间
        /// </summary>
        [XmlElement("trans_endtime")] public string TransEndTime { get; set; }

        /// <summary>
        /// 用途
        /// </summary>
        [XmlElement("trans_reserved")] public string TransReserved { get; set; }
    }
}