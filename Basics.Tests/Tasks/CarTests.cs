using Basics.Tasks.OopTasks.Cars;
using Xunit;

namespace Basics.Test.Tasks;

public class CarTests
{
    [Theory]
    [InlineData("Tesla", 2.0, 300)]
    [InlineData("Lada", 1.6, 90)]
    public void Constructor_WithValidParameters_ShouldInitialize(string model, double volume, double horsePower)
    {
        // Act
        var car = new Car(model, volume, horsePower);

        // Assert
        Assert.Equal(model, car.Model);
        Assert.NotNull(car.Engine);
        Assert.Equal(volume, car.Engine.Volume);
        Assert.Equal(horsePower, car.Engine.HorsePower);
    }

    [Theory]
    [InlineData("Tesla", -1, 100)]
    [InlineData("Tesla", 1, -50)]
    [InlineData("Tesla", 0, 100)]
    [InlineData("Tesla", 1, 0)]
    public void Constructor_WithInvalidEngineParameters_ShouldThrow(string model, double volume, double horsePower)
    {
        // Act & Assert
        var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Car(model, volume, horsePower));
        
        // исключение пришло из Engine?
        Assert.True(
            ex.ParamName == "volume" || ex.ParamName == "horsePower",
            $"Unexpected ParamName: {ex.ParamName}"
        );
    }

    [Fact]
    public void Constructor_WithNullModel_ShouldThrowArgumentNullException()
    {
        // Act & Assert
        var ex = Assert.Throws<ArgumentNullException>(() => new Car(null!, 2.0, 150));
        Assert.Equal("model", ex.ParamName);
    }

    [Fact]
    public void StartCar_ShouldReturnCorrectMessage()
    {
        // Arrange
        var car = new Car("BMW", 3.0, 350);

        // Act
        var result = car.StartCar();

        // Assert
        Assert.Equal("BMW started: Engine started", result);
    }

    [Fact]
    public void Engine_ShouldBeInitialized()
    {
        // Arrange
        var car = new Car("Toyota", 2.0, 150);

        // Act & Assert
        Assert.NotNull(car.Engine);
        Assert.Equal(2.0, car.Engine.Volume);
        Assert.Equal(150, car.Engine.HorsePower);
    }
}