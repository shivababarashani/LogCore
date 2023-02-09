using QActionLogConsumer;
using QActionLogConsumer.Contracts.Dto.Setting;
using QActionLogConsumer.LogManagement;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        IConfiguration configuration = hostContext.Configuration;
        services.Configure<AppSetting>(configuration.GetSection(nameof(AppSetting)));
        services.AddSingleton<ActionLogManagement>();
        services.AddSingleton<SendToProvider>();
        services.AddSingleton<HttpClient>();
        services.AddSingleton<ILogManager, LogManager>();

        services.AddHostedService<Worker>();
    })
    .UseWindowsService()
    .Build();

await host.RunAsync();
