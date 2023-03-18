using WorkerService;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>()
        .AddSingleton<IFileData ,FileData>();
    })
    .Build();

await host.RunAsync();
