using LogCore.Application.Services;
using LogCore.Contract.Interfaces.Repositories;
using LogCore.Contract.Interfaces.Services;
using LogCore.Persistence.Implementations.Repositories;

namespace LogCore.Api.Helper
{
    public static class IocRegisterExtension
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped <IRequestLogRepository, RequestLogRepository>();
            services.AddScoped<IActionLogRepository, ActionLogRepository>();
            services.AddScoped<IStateLogRepository, StateLogRepository>();
        }

        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IRequestLogService, RequestLogService>();
            services.AddScoped<IActionLogService, ActionLogService  >();
            services.AddScoped<IStateLogService, StateLogService>();
            services.AddSingleton<ILogManager, LogManager>();
        }
    }
}
