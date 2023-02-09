using LogCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCore.Contract.Interfaces.Repositories
{
    public interface IStateLogRepository
    {
        Task InsertAsync(StateLog reqLog);
    }
}
