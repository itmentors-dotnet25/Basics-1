using Basics.Tasks.OopTasks.Cars;
using Xunit;

namespace Basics.Test.Tasks;

public class EngineTests
{
    [Theory]
    [InlineData(1.5, 150)]
    [InlineData(2.0, 200)]
    [InlineData(0.1, 10)]
    public void Constructor_WithValidParameters_ShouldInitialize(double volume, double horsePower)
    {
        // Act
        var engine = new Engine(volume, horsePower);

        // Assert
        Assert.Equal(volume, engine.Volume);
        Assert.Equal(horsePower, engine.HorsePower);
    }

    [Theory]
    [InlineData(-1, 100)]
    [InlineData(-0.5, 50)]
    [InlineData(0, 50)]
    public void Constructor_WithNegativeOrZeroVolume_ShouldThrow(double volume, double horsePower)
    {
        // Act & Assert
        var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Engine(volume, horsePower));
        Assert.Equal("volume", ex.ParamName);
    }

    [Theory]
    [InlineData(1, -10)]
    [InlineData(2, -0.1)]
    [InlineData(2, 0)]
    public void Constructor_WithNegativeOrZeroHorsePower_ShouldThrow(double volume, double horsePower)
    {
        // Act & Assert
        var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Engine(volume, horsePower));
        Assert.Equal("horsePower", ex.ParamName);
    }

    [Fact]
    public void Start_ShouldReturnCorrectMessage()
    {
        // Arrange
        var engine = new Engine(2.0, 150);

        // Act
        var result = engine.Start();

        // Assert
        Assert.Equal("Engine started", result);
    }
}