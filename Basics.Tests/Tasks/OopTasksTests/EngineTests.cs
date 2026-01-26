namespace Basics.Test;

using Basics.Tasks.OopTasks.Cars;
using Xunit;


public class EngineTests

{
    [Fact]
    public void Start_ShouldReturn_EngineStarted()
    {
        // Arrange
        var engine = new Engine(2.0, 150);

        // Act
        string result = engine.Start();

        // Assert
        Assert.Equal("Engine started", result);
    }

    [Fact]
    public void Engine_Properties_ShouldBeSetCorrectly()
    {
        // Arrange
        double volume = 3.5;
        int horsePower = 280;

        // Act
        var engine = new Engine(volume, horsePower);

        // Assert
        Assert.Equal(volume, engine.Volume);
        Assert.Equal(horsePower, engine.HorsePower);
    }
}
