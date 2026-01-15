using Basics.Tasks.OopTasks.Cars;
using Xunit;

namespace Basics.Tests.Tasks.OopTasks;

public class CarTests
{
    [Fact]
    public void EngineStart_ReturnsCorrectMessage()
    {
        var engine = new Engine(2.0, 150);
        string result = engine.Start();
        Assert.Equal("Engine started", result);
    }

    [Fact]
    public void CarStartCar_ReturnsCorrectMessage()
    {
        var car = new Car("Волга", 2.0, 150);
        string result = car.StartCar();
        Assert.Equal("Волга started: Engine started", result);
    }

    [Fact]
    public void CarEngine_IsCreatedWithCorrectParameters()
    {
        var car = new Car("Москвич", 1.2, 65);
        Assert.Equal(1.2, car.Engine.Volume);
        Assert.Equal(65, car.Engine.HorsePower);
    }

    [Fact]
    public void CarModel_IsSetCorrectly()
    {
        var car = new Car("Чайка", 2.5, 150);
        Assert.Equal("Чайка", car.Model);
    }
}