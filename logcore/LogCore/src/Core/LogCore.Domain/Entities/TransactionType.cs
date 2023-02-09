using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCore.Domain.Entities
{
    public class TransactionType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ProxyCompanyId { get; set; }
        public ProxyCompany ProxyCompany { get; set; }
        public IEnumerable<ActionLog> ActionLogs { get; set; }
    }
}
