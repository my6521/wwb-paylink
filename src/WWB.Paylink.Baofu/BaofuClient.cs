using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WWB.Paylink.Baofu.Parser;
using WWB.Paylink.Utility;

namespace WWB.Paylink.Baofu
{
    public class BaofuClient : IBaofuClient
    {
        public const string Name = "WWB.Paylink.Baofu.Client";

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<BaofuClient> _logger;

        public BaofuClient(IHttpClientFactory httpClientFactory, ILogger<BaofuClient> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        public async Task<T> ExecuteAsync<T>(IBaofuRequest<T> request, BaofuOptions options) where T : BaseResponse
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            //获取参数
            var txtParams = request.PrimaryHandler(options);
            //获取请求url
            var url = request.GetRequestUrl(options.Debug);
            //获取提交类型0
            var contentType = request.GetContentType();
            //提交
            using (var client = _httpClientFactory.CreateClient(Name))
            {
                _logger.LogDebug($"请求参数：{JsonConvert.SerializeObject(txtParams)}");

                var (body, isSuccessStatusCode) = await client.PostAsync(url, contentType, txtParams);
                if (isSuccessStatusCode)
                {
                    _logger.LogDebug($"反馈消息：{body}");
                    //反序列化
                    var parser = new ResponseJsonParser<T>();
                    var response = parser.Parse(body, options);
                    return response;
                }
                else
                {
                    throw new BaofuException($"请求错误 {body}");
                }
            }
        }
    }
}