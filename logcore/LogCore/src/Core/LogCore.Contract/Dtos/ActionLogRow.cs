using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCore.Contract.Dtos
{
    public class ActionLogRow
    {
        public string TraceId { get; set; }
        public int ResponseTime { get; set; }
        public string RequestBody { get; set; } 
        public string ResponseBody { get; set; }
        public string ActionName { get; set; }
        public int ResponseStatus { get; set; }
        public int TransactionTypeId { get; set; }
    }
}
