using Basics.Tasks.OopTasks.Cars;
using Xunit;

namespace Basics.Test.Tasks;

public class EngineTests
{
    private readonly Engine _engine = new();

    [Fact]
    public void Start_ShouldReturnFixedMessage()
    {
        // Assert
        Assert.Equal("Engine started", _engine.Start());
    }
}