using QActionLogConsumer.Contracts.Dto.Enums;

namespace QActionLogConsumer.LogManagement
{
    public interface ILogManager
    {
        void Log(LoggType loggType, string message);
        void AddDay();
    }
}
