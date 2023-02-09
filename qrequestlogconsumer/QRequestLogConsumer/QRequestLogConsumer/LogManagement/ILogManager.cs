using QRequestLogConsumer.Contracts.Dto.Enums;

namespace QRequestLogConsumer.LogManagement
{
    public interface ILogManager
    {
        void Log(LoggType loggType, string message);
        void AddDay();
    }
}
