using QStateLogConsumer.Contracts.Dto.Enums;

namespace QStateLogConsumer.LogManagement
{
    public interface ILogManager
    {
        void Log(LoggType loggType, string message);
        void AddDay();
    }
}
