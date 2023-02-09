namespace QStateLogConsumer.Contracts.Dto
{
    public class LogRequest
    {
        public string Body { get; set; }
        public string ActionName { get; set; }
        public string TraceId { get; set; }
        public string? Exception { get; set; }
        public int LogType { get; set; }
    }
}
