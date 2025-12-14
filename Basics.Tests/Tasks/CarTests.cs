using Basics.Tasks.OopTasks.Cars;
using Xunit;

namespace Basics.Test.Tasks;

public class CarTests
{
    [Fact]
    public void StartCar_ShouldReturnCorrectMessage()
    {
        // Arrange
        var engine = new Engine();
        var car = new Car("Lada Granta", engine);

        // Act
        string result = car.StartCar();

        // Assert
        Assert.Equal("Lada Granta started: Engine started", result);
    }
}