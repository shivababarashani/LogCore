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
    public class RequestLogService : IRequestLogService
    {
        private readonly IRequestLogRepository _requestLogRepository;
        private readonly ILogManager _logManager;

        public RequestLogService(IRequestLogRepository requestLogRepository, ILogManager logManager)
        {
            _requestLogRepository = requestLogRepository;
            _logManager = logManager;
        }

        public async Task<bool> AddRequestLog(RequestLogRow logRow)
        {
            RequestLog requestLog = new RequestLog();
            try
            {
                requestLog.UserId = logRow.UserId;
                requestLog.ApplicationTypeId = logRow.ApplicationTypeId;
                requestLog.ServerId = logRow.ServerId;
                requestLog.ClientIp = logRow.ClientIp;
                requestLog.UserAgent = logRow.UserAgent;
                requestLog.TraceId = logRow.TraceId;
                requestLog.RequestDateTime = logRow.RequestDateTime;
                requestLog.RequestMethod = logRow.RequestMethod;
                requestLog.RequestScheme = logRow.RequestScheme;
                requestLog.RequestHost = logRow.RequestHost;
                requestLog.RequestPath = logRow.RequestPath;
                requestLog.Controller = logRow.Controller;
                requestLog.Action = logRow.Action;
                requestLog.Version = logRow.Version;
                requestLog.RequestQuery = logRow.RequestQuery;
                requestLog.RequestBody = logRow.RequestBody;
                requestLog.ResponseDateTime = logRow.ResponseDateTime;
                requestLog.ResponseTime = logRow.ResponseTime;
                requestLog.ResponseStatus = logRow.ResponseStatus;
                requestLog.ResponseBody = logRow.ResponseBody;
                requestLog.ResponseContentType = logRow.ResponseContentType;
                requestLog.ExceptionMessage = logRow.ExceptionMessage;
                requestLog.ExceptionStackTrace = logRow.ExceptionStackTrace;
                requestLog.CreatedDate = DateTime.Now;
                await _requestLogRepository.InsertAsync(requestLog);
                return true;
                
            }
            catch (Exception ex)
            {
               var fileLoggerMessage = JsonConvert.SerializeObject(requestLog);
                _logManager.Log($"Request: {fileLoggerMessage} | ExceptionError:{ex}", LogEventLevel.Error);
                return false;
            }
        }
    }
}
