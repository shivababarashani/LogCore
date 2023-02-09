using LogCore.Contract.Dtos;
using LogCore.Contract.Interfaces.Repositories;
using LogCore.Contract.Interfaces.Services;
using LogCore.Domain.Entities;
using LogCore.Utility;
using Newtonsoft.Json;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCore.Application.Services
{
    public class StateLogService : IStateLogService
    {
        private readonly IStateLogRepository _stateLogRepository;
        private readonly ILogManager _logManager;

        public StateLogService(IStateLogRepository stateLogRepository, ILogManager logManager)
        {
            _stateLogRepository = stateLogRepository;
            _logManager = logManager;
        }

        public async Task<bool> AddStateLog(StateLogRow logRow)
        {
            StateLog stateLog = new StateLog();
            try
            {
                stateLog.ActionName = logRow.ActionName;
                stateLog.Body = logRow.Body;
                stateLog.TraceId = logRow.TraceId;
                stateLog.LogTypeId = (int)logRow.LogType;
                stateLog.Exception = logRow.Exception;
                stateLog.CreatedDate = DateTime.Now;
                await _stateLogRepository.InsertAsync(stateLog);
                return true;
            }
            catch (Exception ex)
            {
                var fileLoggerMessage = JsonConvert.SerializeObject(stateLog);
                _logManager.Log($"Request: {fileLoggerMessage} | ExceptionError:{ex}", LogEventLevel.Error);
                return false;
            }
        }
    }
}
