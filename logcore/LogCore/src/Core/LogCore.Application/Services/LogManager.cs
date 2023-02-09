using LogCore.Contract.Dtos;
using LogCore.Contract.Interfaces.Services;
using Microsoft.Extensions.Options;
using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCore.Application.Services
{
    public class LogManager : ILogManager
    {
        private readonly FileLoggerSetting fileLoggerSetting;
        private Serilog.ILogger fileLogger { get; set; }
        private DateTime loggerDateTime;
        public LogManager(IOptions<FileLoggerSetting> options)
        {
            fileLoggerSetting = options.Value;
            loggerDateTime = DateTime.Now;
            fileLogger = new LoggerConfiguration()

                .WriteTo.Map(le => loggerDateTime.ToString(fileLoggerSetting.LogFileConfig.LogFolderFormat
                ), (folderName, wt) => wt.File(AppDomain.CurrentDomain.BaseDirectory + fileLoggerSetting.LogFileConfig.RootFolder + $"{folderName}" + fileLoggerSetting.LogFileConfig.LogFileName, rollingInterval: fileLoggerSetting.LogFileConfig.RollingType, fileSizeLimitBytes: fileLoggerSetting.LogFileConfig.FileSizeLimitBytes, rollOnFileSizeLimit: fileLoggerSetting.LogFileConfig.RollOnFileSizeLimit, retainedFileCountLimit: null))
                .CreateLogger();
        }
        public void Log(string message, LogEventLevel level)
        {
            switch (level)
            {
                case LogEventLevel.Debug:
                    fileLogger.Debug(message);
                    break;
                case LogEventLevel.Error:
                    fileLogger.Error(message);
                    break;
                case LogEventLevel.Fatal:
                    fileLogger.Fatal(message);
                    break;
                case LogEventLevel.Information:
                    fileLogger.Information(message);
                    break;
                case LogEventLevel.Verbose:
                    fileLogger.Verbose(message);
                    break;
                case LogEventLevel.Warning:
                    fileLogger.Warning(message);
                    break;
            }

        }
    }
}
