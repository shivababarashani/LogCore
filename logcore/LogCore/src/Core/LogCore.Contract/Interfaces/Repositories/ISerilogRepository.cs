using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCore.Contract.Interfaces.Repositories
{
    public interface ISerilogRepository
    {
        Task InsertAsync(string message);
    }
}
