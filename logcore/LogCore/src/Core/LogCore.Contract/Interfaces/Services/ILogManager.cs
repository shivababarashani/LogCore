using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog.Events;

namespace LogCore.Contract.Interfaces.Services
{
    public interface ILogManager
    {
        void Log(string message, LogEventLevel level);
    }
}
