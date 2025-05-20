using Microsoft.Extensions.DependencyInjection;

namespace DIClassLib;

public class MyLib
{
    private readonly SomeDep dep;

    public MyLib() : this(DependencyInjection.AddServiceLayer())
    {

    }

    internal MyLib(ServiceProvider provider)
    {
        this.dep = provider.GetRequiredService<SomeDep>();
    }

    public string Hello()
    {
        return this.dep.World;
    }
}
