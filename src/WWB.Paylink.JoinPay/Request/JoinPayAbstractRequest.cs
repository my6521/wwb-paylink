using System.Collections.Generic;

namespace WWB.Paylink.JoinPay.Request
{
    public abstract class JoinPayAbstractRequest
    {
        public virtual string GetContentType()
        {
            return Paylink.Utility.HttpContentType.PostFormUrlencoded;
        }

        public virtual JoinPaySignType GetSignType()
        {
            return JoinPaySignType.MD5;
        }

        public virtual void PrimaryHandler(IDictionary<string, string> sortedTxtParams, JoinPayOptions options)
        {
            sortedTxtParams.Add(JoinPayConsts.sign, JoinPaySignature.SignWithKey(sortedTxtParams, options.APIKey, GetSignType()));
        }
    }
}
