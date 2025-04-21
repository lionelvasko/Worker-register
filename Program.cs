using Dolgozó_nyilvántartó.Infrastructure;
using Dolgozó_nyilvántartó.UserInterface;
using Microsoft.Extensions.DependencyInjection;
using MyIHost = Dolgozó_nyilvántartó.Infrastructure.IHost;
using MyHost = Dolgozó_nyilvántartó.UserInterface.Host;
using Dolgozó_nyilvántartó.Database.Controllers;

var host = Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        // DI
        services.AddSingleton<CommandProvider>();
        services.AddSingleton<MyIHost, MyHost>();
        services.AddSingleton<IController, WorkerController>();
        services.AddSingleton<ICLI, UI>();
        services.AddScoped<IFileManager, TxtFileManager>();
        services.AddSingleton<UI>();

    })
    .Build();

var app = host.Services.GetRequiredService<UI>();
app.Run();
