using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WWB.Paylink.BaoFooTransfer.Parser;
using WWB.Paylink.Utility;
using WWB.Paylink.Utility.Security;

namespace WWB.Paylink.BaoFooTransfer
{
  public class BaoFooTransClient : IBaoFooTransClient
  {
    public const string Name = "WWB.Paylink.BaoFooTransfer.Client";

    private readonly IHttpClientFactory _httpClientFactory;
    private readonly ILogger<BaoFooTransClient> _logger;

    public BaoFooTransClient(IHttpClientFactory httpClientFactory, ILogger<BaoFooTransClient> logger)
    {
      _httpClientFactory = httpClientFactory;
      _logger = logger;
    }

    public async Task<T> ExecuteAsync<T>(IBaoFooTransRequest<T> request, BaoFooTransOptions options) where T : BaseResponse
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

          //解密
          var realContent = RSAUtil.DecryptByCer(body, options.CerCertificate);

          _logger.LogDebug($"消息解密：{realContent}");

          //反序列化
          var parser = new ResponseJsonParser<T>();
          var response = parser.Parse(realContent);
          return response;
        }
        else
        {
          throw new BaoFooTransException($"请求错误 {body}");
        }
      }
    }
  }
}