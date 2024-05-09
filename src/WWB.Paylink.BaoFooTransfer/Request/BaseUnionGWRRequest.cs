using Newtonsoft.Json;
using System.Collections.Generic;
using WWB.Paylink.Utility;
using WWB.Paylink.Utility.Security;

namespace WWB.Paylink.BaoFooTransfer.Request
{
  public abstract class BaseUnionGWRRequest
  {
    private readonly string _serviceTp;

    public BaseUnionGWRRequest(string serviceTp)
    {
      _serviceTp = serviceTp;
    }

    public virtual string GetContentType()
    {
      return HttpContentType.PostFormUrlencoded;
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
                {"memberId", options.MerchantNo},
                {"terminalId", options.TerminalId},
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