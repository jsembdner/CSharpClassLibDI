using Microsoft.Extensions.DependencyInjection;
using Moq;
using DIClassLib;
using Microsoft.Extensions.Hosting;

namespace DIClassLibTests;

public class LibTests
{
    [Test]
    public void TestPropertyWithoutMock()
    {
        HostApplicationBuilder builder = Host.CreateApplicationBuilder();
        builder.Services
            .AddServiceLayer();
        using IHost host = builder.Build();
        var lib = host.Services.GetRequiredService<ILib>();

        Assert.That(lib.Hello(), Is.EqualTo("World"));
    }

    [Test]
    public void TestPropertyWithMock()
    {
        var someDepMock = new Mock<LibDep>();
        someDepMock.Setup(x => x.World).Returns("Mock");

        HostApplicationBuilder builder = Host.CreateApplicationBuilder();
        builder.Services
            .AddServiceLayer();
        builder.Services.AddSingleton(someDepMock.Object);
        using IHost host = builder.Build();
        var lib = host.Services.GetRequiredService<ILib>();

        Assert.That(lib.Hello(), Is.EqualTo("Mock"));
    }
}
