namespace DIClassLib;

public interface ILib
{
    public string Hello();
}

internal class Lib(LibDep dep) : ILib
{
    private readonly LibDep dep = dep;

    public string Hello()
    {
        return dep.World;
    }
}
