using LogCore.Contract.Interfaces.Repositories;
using LogCore.Domain.Entities;
using LogCore.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCore.Persistence.Implementations.Repositories
{
    public class ActionLogRepository : IActionLogRepository
    {
        private readonly LogDbContext _logDbContext;

        public ActionLogRepository(LogDbContext logDbContext)
        {
            _logDbContext = logDbContext;
        }

        public async Task InsertAsync(ActionLog actionLog)
        {
            await _logDbContext.ActionLogs.AddAsync(actionLog);
            await _logDbContext.SaveChangesAsync();
        }
    }
}
