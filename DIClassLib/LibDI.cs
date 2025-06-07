using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace DIClassLib;

public static class LibDI
{
    public static IServiceCollection AddLib(this IServiceCollection services)
    {
        services.TryAddTransient<LibDep>();
        services.TryAddTransient<ILib, Lib>();
        return services;
    }
}