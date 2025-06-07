using Microsoft.Extensions.DependencyInjection;

namespace DIClassLib;

public interface IMyLib
{
    public string Hello();
}

internal class MyLib(SomeDep dep) : IMyLib
{
    private readonly SomeDep dep = dep;

    public string Hello()
    {
        return dep.World;
    }
}
