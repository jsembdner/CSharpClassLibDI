using Microsoft.Extensions.DependencyInjection;

ServiceCollection services = new();
services.AddSingleton<IMessageWriter, MessageWriter>();
using ServiceProvider provider = services.BuildServiceProvider();

// The code below, following the IoC pattern, is typically only aware of the IMessageWriter interface, not the implementation.
IMessageWriter messageWriter = provider.GetService<IMessageWriter>()!;
messageWriter.Write("Hello");

public interface IMessageWriter
{
    void Write(string message);
}

internal class MessageWriter : IMessageWriter
{
    public void Write(string message)
    {
        Console.WriteLine($"MessageWriter.Write(message: \"{message}\")");
    }
}

