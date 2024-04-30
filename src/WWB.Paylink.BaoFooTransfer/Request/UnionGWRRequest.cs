using Newtonsoft.Json;
using System.Collections.Generic;
using WWB.Paylink.Utility.Security;

namespace WWB.Paylink.BaoFooTransfer.Request
{
    public class UnionGWRRequest : AbstractRequest
    {
        private readonly string _serviceTp;

        public UnionGWRRequest(string serviceTp)
        {
            _serviceTp = serviceTp;
        }

        public string GetRequestUrl(bool debug)
        {
            return debug ? $"https://vgw.baofoo.com/union-gw/api/{_serviceTp}/transReq.do"
                : $"https://public.baofu.com/union-gw/api/{_serviceTp}/transReq.do";
        }

        public IDictionary<string, string> PrimaryHandler(BaoFooTransOptions options)
        {
            var header = new Dictionary<string, string>
            {
                {"member_id", options.MerchantNo},
                {"terminal_id", options.TerminalId},
                {"serviceTp", _serviceTp},
                {"verifyType", "1"}
            };

            var contentData = new
            {
                header = header,
                body = this,
            };

            var jsonStr = JsonConvert.SerializeObject(contentData);
            var encryptStr = RSAUtil.EncryptByPfx(jsonStr, options.PfxCertificate, options.Password);
            header.Add("content", encryptStr);

            return header;
        }
    }
}