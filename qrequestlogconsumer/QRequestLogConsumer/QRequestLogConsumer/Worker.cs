using QRequestLogConsumer.Contracts.Dto.Enums;
using QRequestLogConsumer.LogManagement;

namespace QRequestLogConsumer
{
    public class Worker : BackgroundService
    {
        private readonly RequestLogManagement _requestLogManagement;
        private readonly ILogManager _logger;
        public Worker(RequestLogManagement requestLogManagement,
                      ILogManager logger)
        {
            _requestLogManagement = requestLogManagement;
            _logger = logger;
        }
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.Log(LoggType.Information, $"QRequestLogService is start at {DateTime.Now}");
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.Log(LoggType.Information, $"QRequestLogService is stop at {DateTime.Now}");
            return base.StopAsync(cancellationToken);
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await _requestLogManagement.AddLog();
            }
        }
    }
}