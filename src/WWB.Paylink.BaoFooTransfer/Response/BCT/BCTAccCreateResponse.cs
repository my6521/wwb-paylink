using System.Collections.Generic;

namespace WWB.Paylink.BaoFooTransfer.Response.BCT
{
    public class BCTAccCreateResponse : BaseUnionGWResponse<BCTAccCreateResponseBody>
    {
    }

    public class BCTAccCreateResponseBody : BaseUnionGWResponseBodyBase
    {
        public List<BCTAccCreateResult> result { get; set; }

        public class BCTAccCreateResult
        {
            public string state { get; set; }
            public string errorCode { get; set; }
            public string errorMsg { get; set; }
            public string transSerialNo { get; set; }
            public string loginNo { get; set; }
            public string customerName { get; set; }
            public string contractNo { get; set; }
        }
    }
}