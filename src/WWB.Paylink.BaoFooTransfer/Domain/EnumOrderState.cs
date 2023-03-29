using System.ComponentModel;

namespace WWB.Paylink.BaoFooTransfer.Domain
{
    public enum EnumOrderState
    {
        [Description("转账失败")]
        Fail = -1,

        [Description("转账中")]
        Processing = 0,

        [Description("成功")]
        Success = 1,

        [Description("退款")]
        Refund = 2,
    }
}