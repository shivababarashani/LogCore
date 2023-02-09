using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCore.Domain.Entities
{
    public class StateLog
    {
        public Guid Id { get; set; }
        public string Body { get; set; }
        public string ActionName { get; set; }
        public string? Exception { get; set; }
        public string TraceId { get; set; }
        public int LogTypeId { get; set; }
        public LogType LogType { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
