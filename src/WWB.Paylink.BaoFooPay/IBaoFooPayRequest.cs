﻿using System.Collections.Generic;

namespace WWB.Paylink.BaoFooPay
{
    public interface IBaoFooPayRequest<TResponse> where TResponse : BaseResponse
    {
        /// <summary>
        /// 获取请求地址
        /// </summary>
        /// <param name="debug"></param>
        /// <returns></returns>
        string GetRequestUrl(bool debug);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        string GetContentType();

        /// <summary>
        /// 处理
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        IDictionary<string, string> PrimaryHandler(BaoFooPayOptions options);
    }
}