using WWB.Paylink.BaoFooTransfer.Constants;
using WWB.Paylink.Utility.Security;

namespace WWB.Paylink.BaoFooTransfer.Request
{
    public abstract class AbstractRequest
    {
        public virtual string GetContentType()
        {
            return HttpContentType.PostFormUrlencoded;
        }

        public IDictionary<string, string> PrimaryHandler<T>(T data, BaoFooTransOptions options)
        {
            var parameters = new Dictionary<string, string>
            {
                {"member_id", options.MerchantNo},
                {"terminal_id", options.TerminalId},
                {"data_type", "json"},
                {"version", "4.0.0"}
            };
            var encryptStr = JsonConvert.SerializeObject(data);

            parameters.Add(Consts.SIGN_CONTENT, RSAHelper.EncryptByPfx(encryptStr, options.PfxCertificate, options.Password));

            return parameters;
        }
    }
}