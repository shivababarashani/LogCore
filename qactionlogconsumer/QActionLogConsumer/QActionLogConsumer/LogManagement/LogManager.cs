using Microsoft.Extensions.Options;
using QActionLogConsumer.Contracts.Dto.Enums;
using QActionLogConsumer.Contracts.Dto.Setting;
using Serilog;

namespace QActionLogConsumer.LogManagement
{
    public class LogManager : ILogManager
    {
        private readonly AppSetting _appSetting;
        private Serilog.ILogger fileLogger { get; set; }
        private DateTime loggerDateTime;
        public LogManager(IOptions<AppSetting> options)
        {
            _appSetting = options.Value;
            loggerDateTime = DateTime.Now;
            fileLogger = new LoggerConfiguration()

                .WriteTo.Map(le => loggerDateTime.ToString(_appSetting.LogFileConfig.LogFolderFormat
                ), (folderName, wt) => wt.File(AppDomain.CurrentDomain.BaseDirectory+ _appSetting.LogFileConfig.RootFolder + $"{folderName}" + _appSetting.LogFileConfig.LogFileName, rollingInterval: _appSetting.LogFileConfig.RollingType, fileSizeLimitBytes: _appSetting.LogFileConfig.FileSizeLimitBytes, rollOnFileSizeLimit: _appSetting.LogFileConfig.RollOnFileSizeLimit, retainedFileCountLimit: null))
                .CreateLogger();
        }
        public void Log(LoggType loggType,string message)
        {
            switch (loggType)
            {
                case LoggType.Error:
                    fileLogger.Error(message);
                    break;
                case LoggType.Information:
                    fileLogger.Information(message);
                    break;
                default:
                    fileLogger.Error(message);
                    break;
            }
            
        }
        public void AddDay()
        {
            loggerDateTime = loggerDateTime.AddDays(1);
        }
    }
}
