using System.Collections.Generic;

namespace WWB.Paylink.JoinPay
{
    public interface IJoinPayRequest<T> where T : JoinPayResponse
    {
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        string GetContentType();

        /// <summary>
        /// 获取请求接口地址
        /// </summary>
        /// <returns>接口地址</returns>
        string GetRequestUrl(bool debug);

        /// <summary>
        /// 获取文本参数字典
        /// </summary>
        /// <returns>文本参数字典</returns>
        IDictionary<string, string> GetParameters();

        /// <summary>
        /// 获取签名类型
        /// </summary>
        /// <returns>签名类型</returns>
        JoinPaySignType GetSignType();

        /// <summary>
        /// 参数处理器
        /// </summary>
        /// <param name="sortedTxtParams">排序文本参数</param>
        /// <param name="options">配置选项</param>
        void PrimaryHandler(IDictionary<string, string> sortedTxtParams, JoinPayOptions options);

        /// <summary>
        /// 获取是否需要验签
        /// </summary>
        /// <returns>是否需要验签</returns>
        bool GetNeedCheckSign()
        {
            return true;
        }
    }
}