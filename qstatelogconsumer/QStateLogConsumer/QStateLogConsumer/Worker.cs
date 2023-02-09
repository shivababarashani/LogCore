using QStateLogConsumer.Contracts.Dto.Enums;
using QStateLogConsumer.LogManagement;

namespace QStateLogConsumer
{
    public class Worker : BackgroundService
    {
        private readonly StateLogManagement _stateLogManagement;
        private readonly ILogManager _logger;
        public Worker(StateLogManagement stateLogManagement,
                      ILogManager logger)
        {
            _stateLogManagement = stateLogManagement;
            _logger = logger;
        }
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.Log(LoggType.Information, $"QStateLogService is start at {DateTime.Now}");
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.Log(LoggType.Information, $"QStateLogService is stop at {DateTime.Now}");
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
                await _stateLogManagement.AddLog();
            }
        }
    }
}