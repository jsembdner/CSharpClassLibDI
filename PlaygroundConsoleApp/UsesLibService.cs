
using DIClassLib;
using Microsoft.Extensions.Hosting;

internal class UsesLibService(ILib lib) : BackgroundService
{
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        Console.WriteLine($"Hello {lib.Hello()}");
        return Task.CompletedTask;
    }
}