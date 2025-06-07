using DIClassLib;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services
    .AddServiceLayer()
    .AddHostedService<UsesLib>();

using IHost host = builder.Build();

await host.RunAsync();