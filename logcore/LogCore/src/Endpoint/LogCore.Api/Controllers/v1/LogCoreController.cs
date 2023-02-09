using LogCore.Contract.Dtos;
using LogCore.Contract.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LogCore.Api.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]

    public class LogCoreController : ControllerBase
    {
        private readonly IRequestLogService _requestLogService;
        private readonly IActionLogService _actionLogService;
        private readonly IStateLogService _stateLogService;
        private readonly ILogger<LogCoreController> _logger;

        public LogCoreController(IRequestLogService requestLogService, IActionLogService actionLogService, IStateLogService stateLogService, ILogger<LogCoreController> logger)
        {
            _requestLogService = requestLogService;
            _actionLogService = actionLogService;
            _stateLogService = stateLogService;
            _logger = logger;
        }

        [HttpPost]
        [MapToApiVersion("1")]
        public async Task<bool> AddRequestLog([FromBody] RequestLogRow requestLogRow)
        {
            bool isSuccess = await _requestLogService.AddRequestLog(requestLogRow);
            return isSuccess;
        }

        [HttpPost]
        [MapToApiVersion("1")]
        public async Task<bool> AddActionLog([FromBody] ActionLogRow actionLogRow)
        {
            bool isSuccess = await _actionLogService.AddActionLog(actionLogRow);
            return isSuccess;
        }

        [HttpPost]
        [MapToApiVersion("1")]
        public async Task<bool> AddStateLog([FromBody] StateLogRow stateLogRow)
        {
            bool isSuccess = await _stateLogService.AddStateLog(stateLogRow);
            return isSuccess;
        }
    }
}
