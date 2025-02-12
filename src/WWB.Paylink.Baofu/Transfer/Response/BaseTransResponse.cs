using Newtonsoft.Json;
using WWB.Paylink.Utility.Security;

namespace WWB.Paylink.Baofu.Transfer.Response
{
    public abstract class BaseTransResponse<T> : BaseResponse
    {
        public T Data { get; set; }

        internal override void PrimaryHandler(BaofuOptions options)
        {
            var realContent = RSAUtil.DecryptByCer(base.Raw, options.CerCertificate);

            Data = JsonConvert.DeserializeObject<T>(realContent);
        }
    }
}