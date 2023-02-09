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
    public class StateLogRepository : IStateLogRepository
    {
        private readonly LogDbContext _logDbContext;

        public StateLogRepository(LogDbContext logDbContext)
        {
            _logDbContext = logDbContext;
        }

        public async Task InsertAsync(StateLog stateLog)
        {
            await _logDbContext.StateLogs.AddAsync(stateLog);
            await _logDbContext.SaveChangesAsync();
        }
    }
}
