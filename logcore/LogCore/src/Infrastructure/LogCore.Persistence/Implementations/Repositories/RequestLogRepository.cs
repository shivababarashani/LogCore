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
    public class RequestLogRepository : IRequestLogRepository
    {
        private readonly LogDbContext _logDbContext;

        public RequestLogRepository(LogDbContext logDbContext)
        {
            _logDbContext = logDbContext;
        }

        public async Task InsertAsync(RequestLog reqLog)
        {
            await _logDbContext.RequestLogs.AddAsync(reqLog);
            await _logDbContext.SaveChangesAsync();
        }
    }
}
