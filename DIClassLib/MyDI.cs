using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace DIClassLib;

public static class DependencyInjection
{
    public static IServiceCollection AddServiceLayer(this IServiceCollection services)
    {
        services.TryAddTransient<SomeDep>();
        services.TryAddTransient<IMyLib, MyLib>();
        return services;
    }
}