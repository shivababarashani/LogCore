using LogCore.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCore.Contract.Dtos
{
    public class StateLogRow
    {
        public string Body { get; set; }
        public string ActionName { get; set; }
        public string? Exception { get; set; }
        public string TraceId { get; set; }
        public LogTypeEnum LogType { get; set; }
    }
}
