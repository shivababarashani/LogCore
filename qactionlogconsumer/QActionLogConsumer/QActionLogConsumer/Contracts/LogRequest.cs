namespace QActionLogConsumer.Contracts.Dto
{
    public class LogRequest
    {
        public string TraceId { get; set; }
        public int TransactionTypeId { get; set; }
        public string ActionName { get; set; }
        public int ResponseStatus { get; set; }
        public int ResponseTime { get; set; }
        public string RequestBody { get; set; }
        public string ResponseBody { get; set; }
    }
}
