using QActionLogConsumer.Contracts.Dto.Enums;
using QActionLogConsumer.LogManagement;

namespace QActionLogConsumer
{
    public class Worker : BackgroundService
    {
        private readonly ActionLogManagement _actionLogManagement;
        private readonly ILogManager _logger;
        public Worker(ActionLogManagement actionLogManagement,
                      ILogManager logger)
        {
            _actionLogManagement = actionLogManagement;
            _logger = logger;
        }
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.Log(LoggType.Information, $"QActionLogService is start at {DateTime.Now}");
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.Log(LoggType.Information, $"QActionLogService is stop at {DateTime.Now}");
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
                await _actionLogManagement.AddLog();
            }
        }
    }
}