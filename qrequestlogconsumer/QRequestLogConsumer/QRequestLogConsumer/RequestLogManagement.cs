using System.Text;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using QRequestLogConsumer.Contracts.Dto;
using QRequestLogConsumer.Contracts.Dto.Enums;
using QRequestLogConsumer.Contracts.Dto.Setting;
using QRequestLogConsumer.LogManagement;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace QRequestLogConsumer
{
    public class RequestLogManagement
    {
        private readonly AppSetting _siteSetting;
        private readonly SendToProvider _sendToProvider;
        private readonly ILogManager _logger;
        public RequestLogManagement(IOptions<AppSetting> options,
                                 SendToProvider sendToProvider,
                                 ILogManager logger)
        {
            _siteSetting = options.Value;
            _sendToProvider = sendToProvider;
            _logger = logger;
        }
        public async Task AddLog()
        {
            var factory = new ConnectionFactory()
            {
                HostName = _siteSetting.RabbitMQConfiguration.RabbitMQUrl,
                Port = _siteSetting.RabbitMQConfiguration.Port,
                UserName = _siteSetting.RabbitMQConfiguration.Username,
                Password = _siteSetting.RabbitMQConfiguration.Password,
                VirtualHost= _siteSetting.RabbitMQConfiguration.VirtualHost
            };
            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();
            var message = "";

            var consumer = new EventingBasicConsumer(channel);
            var isSuccess = false;

            consumer.Received += async (model, ea) =>
            {
                var body = ea.Body.ToArray();
                message = Encoding.UTF8.GetString(body);
                var logRequest = new LogRequest();
                try
                {
                    logRequest = JsonConvert.DeserializeObject<LogRequest>(message);
                    isSuccess = await _sendToProvider.Add(logRequest.LogModel);
                }
                catch (Exception ex)
                {
                    _logger.Log(LoggType.Error, ex.Message);
                    isSuccess = false;
                }

                if (isSuccess == true)
                {
                    channel.BasicAck(ea.DeliveryTag, true);
                    ea.Redelivered = false;
                }
                else
                {
                    channel.BasicReject(ea.DeliveryTag, true);
                    ea.DeliveryTag = 1;
                }
            };
            channel.BasicConsume("account-RequestLog", false, "", consumer);
            Console.ReadLine();
        }
    }
}
