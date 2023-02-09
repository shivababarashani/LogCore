using Serilog;

namespace QRequestLogConsumer.Contracts.Dto.Setting
{
    public class LogFileConfig
    {
        public string RootFolder { get; set; }=String.Empty;
        public string LogFileName { get; set; } = String.Empty;
        public string LogFolderFormat { get; set; } = String.Empty;
        public RollingInterval RollingType { get; set; }
        public long FileSizeLimitBytes { get; set; }
        public bool RollOnFileSizeLimit { get; set; }
        public string RetainedFileCountLimit { get; set; } = String.Empty;
    }
}
