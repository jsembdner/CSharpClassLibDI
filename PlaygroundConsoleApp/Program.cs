using DIClassLib;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

HostApplicationBuilder builder = Host.CreateApplicationBuilder();
builder.Services
    .AddLib()
    .AddHostedService<UsesLibService>();

using IHost host = builder.Build();

await host.RunAsync();