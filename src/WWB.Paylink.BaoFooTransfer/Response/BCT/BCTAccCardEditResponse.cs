﻿namespace WWB.Paylink.BaoFooTransfer.Response.BCT
{
    public class BCTAccCardEditResponse : BaseUnionGWResponse<BCTAccCardEditResponseBody>
    {
    }

    public class BCTAccCardEditResponseBody : BaseUnionGWResponseBodyBase
    {
        public string contractNo { get; set; }
    }
}