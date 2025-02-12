using Newtonsoft.Json;
using System.Collections.Generic;
using WWB.Paylink.Utility;
using WWB.Paylink.Utility.Security;

namespace WWB.Paylink.Baofu.Transfer.Dtos
{
    public abstract class BaseTransRequest
    {
        public virtual string GetContentType()
        {
            return HttpContentType.PostFormUrlencoded;
        }

        public IDictionary<string, string> PrimaryHandler(BaofuOptions options)
        {
            var parameters = new Dictionary<string, string>
            {
                {"member_id", options.MerchantNo},
                {"terminal_id", options.TerminalId},
                {"data_type", "json"},
                {"version", "4.0.0"}
            };
            var encryptStr = JsonConvert.SerializeObject(GetData());

            parameters.Add("data_content", RSAUtil.EncryptByPfx(encryptStr, options.PfxCertificate, options.Password));

            return parameters;
        }

        protected abstract object GetData();
    }
}