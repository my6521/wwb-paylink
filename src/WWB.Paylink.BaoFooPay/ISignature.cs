using System.Collections.Generic;

namespace WWB.Paylink.BaoFooPay
{
    public interface ISignature
    {
        IDictionary<string, string> GetSignatureParameters(BaoFooPayOptions options);
    }
}