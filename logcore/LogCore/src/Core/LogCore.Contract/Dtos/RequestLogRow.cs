using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCore.Contract.Dtos
{
    public class RequestLogRow
    {
        public Guid UserId { get; set; }
        public int ApplicationTypeId { get; set; }
        public int ServerId { get; set; }
        public string ClientIp { get; set; }
        public string UserAgent { get; set; }
        public string TraceId { get; set; }
        public DateTime RequestDateTime { get; set; }
        public string RequestMethod { get; set; }
        public string RequestScheme { get; set; }
        public string RequestHost { get; set; }
        public string RequestPath { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Version { get; set; }
        public string RequestQuery { get; set; }
        public string RequestBody { get; set; }
        public DateTime ResponseDateTime { get; set; }
        public int ResponseTime { get; set; }
        public int ResponseStatus { get; set; }
        public string ResponseBody { get; set; }
        public string ResponseContentType { get; set; }
        public string ExceptionMessage { get; set; }
        public string ExceptionStackTrace { get; set; }
    }
}
