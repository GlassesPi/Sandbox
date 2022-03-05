using Core.Services;
using Worker.Services;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Sandbox.Worker.Worker>();
        services.AddSingleton<IFieldNameProvider, FieldNameProvider>();
    })
    .Build();

await host.RunAsync();
