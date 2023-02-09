using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using QRequestLogConsumer.Contracts.Dto.Enums;
using QRequestLogConsumer.Contracts.Dto.Setting;
using QRequestLogConsumer.LogManagement;
using System.Text;


namespace QRequestLogConsumer
{
    public class SendToProvider
    {
        private readonly HttpClient _httpClient;
        private readonly AppSetting _siteSetting;
        private readonly ILogManager _logger;
        public SendToProvider(HttpClient httpClient,
                              IOptions<AppSetting> options,
                              ILogManager logger)
        {
            _httpClient = httpClient;
            _siteSetting = options.Value;
            _logger = logger;
        }
        public async Task<bool> Add(object request)
        {
            string url = _siteSetting.ProviderConfig.FirstOrDefault(p => p.Name == "AddRequestLog").Url;
            try
            {
                var responseMessage = CallApi(request, url);
                var resultResponse = await responseMessage.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<bool>(resultResponse);
                return result;
            }

            catch (Exception ex)
            {
                _logger.Log(LoggType.Error, ex.Message);
                return false;
            }
            
            
        }


        private HttpResponseMessage CallApi(object content, string url)
        {
            var requestJson = JsonConvert.SerializeObject(content);
            var queryString = new StringContent(requestJson, Encoding.UTF8, "application/json");
            return _httpClient.PostAsync(url, queryString).Result;
        }
    }

}

