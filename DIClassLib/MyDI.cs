using Microsoft.Extensions.DependencyInjection;

namespace DIClassLib;

internal static class DependencyInjection
{
    public static ServiceProvider AddServiceLayer()
    {
        var services = new ServiceCollection();
        services.AddSingleton<SomeDep>();
        return services.BuildServiceProvider();
    }
}