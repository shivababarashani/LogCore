using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCore.Domain.Entities
{
    public class ActionLog
    {
        public Guid Id { get; set; }
        public string TraceId { get; set; }
        public int ResponseTime { get; set; }
        public string RequestBody { get; set; } 
        public string ResponseBody { get; set; }
        public string ActionName { get; set; }
        public int ResponseStatus { get; set; }
        public int TransactionTypeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public TransactionType TransactionType { get; set; }

    }
}
