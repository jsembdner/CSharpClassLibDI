using Microsoft.Extensions.DependencyInjection;
using Moq;
using DIClassLib;

namespace DIClassLibTests;

public class LibTests
{
    private IServiceCollection services;

    [SetUp]
    public void SetUp()
    {
        services = new ServiceCollection();
        services.AddLib();
    }

    [Test]
    public void TestPropertyWithoutMock()
    {
        var provider = services.BuildServiceProvider();
        var lib = provider.GetRequiredService<ILib>();

        Assert.That(lib.Hello(), Is.EqualTo("World"));
    }

    [Test]
    public void TestPropertyWithMock()
    {
        var someDepMock = new Mock<LibDep>();
        someDepMock.Setup(x => x.World).Returns("Mock");

        services.AddSingleton(someDepMock.Object);
        var provider = services.BuildServiceProvider();

        var lib = provider.GetRequiredService<ILib>();

        Assert.That(lib.Hello(), Is.EqualTo("Mock"));
    }
}
