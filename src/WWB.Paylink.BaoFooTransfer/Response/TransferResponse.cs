﻿namespace WWB.Paylink.BaoFooTransfer.Response
{
    public class TransferResponse : BaseResponse
    {
        public TransContent<TransRespData> trans_content { get; set; }
    }
}