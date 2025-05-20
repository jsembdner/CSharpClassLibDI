using Microsoft.Extensions.DependencyInjection;
using Moq;
using DIClassLib;

namespace DIClassLibTests;

public class MyLibTests
{
    [Test]
    public void TestPropertyWithoutMock()
    {
        var myLib = new MyLib();

        Assert.That(myLib.Hello(), Is.EqualTo("World"));
    }

    [Test]
    public void TestPropertyWithMock()
    {
        var someDepMock = new Mock<SomeDep>();
        someDepMock.Setup(x => x.World).Returns("Mock");

        var services = new ServiceCollection();
        services.AddSingleton(someDepMock.Object);

        var myLib = new MyLib(services.BuildServiceProvider());

        Assert.That(myLib.Hello(), Is.EqualTo("Mock"));
    }
}
