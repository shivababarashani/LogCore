using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCore.Domain.Entities
{
    public class ApplicationType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<RequestLog> RequestLogs { get; set; }

    }
}
