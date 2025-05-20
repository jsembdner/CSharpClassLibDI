using DIClassLib;
using Microsoft.Extensions.DependencyInjection;

internal static class DependencyInjection
{
    public static ServiceProvider AddServiceLayer()
    {
        var services = new ServiceCollection();
        services.AddSingleton<SomeDep>();
        return services.BuildServiceProvider();
    }
}