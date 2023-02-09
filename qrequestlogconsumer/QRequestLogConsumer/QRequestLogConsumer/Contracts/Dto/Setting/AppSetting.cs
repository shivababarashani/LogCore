namespace QRequestLogConsumer.Contracts.Dto.Setting
{
    public class AppSetting
    {
        public List<ProviderConfig> ProviderConfig { get; set; }
        public RabbitMQConfiguration RabbitMQConfiguration { get; set; }
        public LogFileConfig LogFileConfig { get; set; }

    }
}
