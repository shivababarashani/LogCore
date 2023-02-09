using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCore.Domain.Entities
{
    public class LogType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<StateLog> StateLogs { get; set; }

    }
}
