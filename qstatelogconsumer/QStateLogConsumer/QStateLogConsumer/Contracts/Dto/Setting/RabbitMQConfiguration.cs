namespace QStateLogConsumer.Contracts.Dto.Setting
{
    public class RabbitMQConfiguration
    {
        public string RabbitMQUrl { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string VirtualHost { get; set; }
    }
}
