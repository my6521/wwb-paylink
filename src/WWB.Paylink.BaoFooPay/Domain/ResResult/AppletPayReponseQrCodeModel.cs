namespace WWB.Paylink.BaoFooPay.Domain.ResResult
{
    public class AppletPayReponseQrCodeModel
    {
        public string AppId { get; set; }
        public string TimeStamp { get; set; }
        public string NonceStr { get; set; }
        public string Package { get; set; }
        public string SignType { get; set; }
        public string PaySign { get; set; }
    }
}