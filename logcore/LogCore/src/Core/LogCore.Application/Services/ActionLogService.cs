using LogCore.Contract.Dtos;
using LogCore.Contract.Interfaces.Repositories;
using LogCore.Contract.Interfaces.Services;
using LogCore.Domain.Entities;
using LogCore.Utility;
using Newtonsoft.Json;
using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogCore.Application.Services
{
    public class ActionLogService : IActionLogService
    {
        private readonly IActionLogRepository _actionLogRepository;
        private readonly ILogManager _logManager;

        public ActionLogService(IActionLogRepository actionLogRepository, ILogManager logManager)
        {
            _actionLogRepository = actionLogRepository;
            _logManager = logManager;
        }

        public async Task<bool> AddActionLog(ActionLogRow logRow)
        {
            ActionLog actionLog = new ActionLog();
            try
            {
                actionLog.ActionName = logRow.ActionName;
                actionLog.TransactionTypeId = logRow.TransactionTypeId;
                actionLog.RequestBody = logRow.RequestBody;
                actionLog.ResponseBody = logRow.ResponseBody;
                actionLog.ResponseStatus = logRow.ResponseStatus;
                actionLog.ResponseTime = logRow.ResponseTime;
                actionLog.TraceId = logRow.TraceId;
                actionLog.CreatedDate = DateTime.Now;
                await _actionLogRepository.InsertAsync(actionLog);
                return true;
            }
            catch (Exception ex)
            {
                var fileLoggerMessage = JsonConvert.SerializeObject(actionLog);
                _logManager.Log($"Request: {fileLoggerMessage} | ExceptionError:{ex}", LogEventLevel.Error);
                return false;
            }
        }
    }
}
