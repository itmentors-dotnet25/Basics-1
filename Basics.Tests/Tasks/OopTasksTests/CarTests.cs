using Basics.Tasks.OopTasks.Cars;
using Xunit;

namespace Basics.Test;

public class CarTests

{
    [Fact]
    public void StartCar_ShouldReturn_CorrectMessage()
    {
        // Arrange
        var car = new Car("BMW", 3.0, 300);

        // Act
        string result = car.StartCar();

        // Assert
        Assert.Equal("BMW started: Engine started", result);
    }

    [Fact]
    public void Car_Properties_ShouldBeSetCorrectly()
    {
        // Arrange
        string model = "Audi";
        double volume = 2.0;
        int horsePower = 190;

        // Act
        var car = new Car(model, volume, horsePower);

        // Assert
        Assert.Equal(model, car.Model);
        Assert.NotNull(car.Engine);
        Assert.Equal(volume, car.Engine.Volume);
        Assert.Equal(horsePower, car.Engine.HorsePower);
    }

    [Fact]
    public void Car_Engine_ShouldBeCreatedDuringConstruction()
    {
        // Arrange & Act
        var car = new Car("Tesla", 0, 0); 

        // Assert
        Assert.NotNull(car.Engine);
    }
}