using Basics.Tasks.OopTasks;
using Basics.Tasks.OopTasks.Animals;
using Basics.Tasks.OopTasks.Cars;
using Xunit;

namespace Basics.Test.Tasks;

public class OopTasksTests
{

    [Theory]
    [InlineData(4.00, 50.27)]
    [InlineData(-7.00, 0.00)]
    [InlineData(0.00, 0.00)]
    public void CalculateAreaCircle_ShouldReturnCorrectAverage(double input, double? expected)
    {
        Circle _oopTasks = new(input);
        var result = _oopTasks.CalculateArea();

        Assert.Equal($"{expected:F2}", $"{result:F2}");
    }

    [Theory]
    [InlineData(4, 25.13)]
    [InlineData(-7.00, 0.00)]
    [InlineData(0.00, 0.00)]
    public void CalculatePerimeterCircle_ShouldReturnCorrectAverage(double input, double? expected)
    {
        Circle _oopTasks = new(input);
        var result = _oopTasks.CalculatePerimeter();

        Assert.Equal($"{expected:F2}", $"{result:F2}");
    }

    [Theory]
    [InlineData(8, 7, 56.00)]
    [InlineData(-7, 5, -35.00)]
    [InlineData(7, 0, 0.00)]
    [InlineData(0, 6, 0.00)]
    public void CalculateAreaRectangle_ShouldReturnCorrectAverage(double width, double height, double? expected)
    {
        Rectangle _oopTasks = new(width, height);
        var result = _oopTasks.CalculateArea();

        Assert.Equal($"{expected:F2}", $"{result:F2}");
    }

    [Theory]
    [InlineData(4, 15, 38.00)]
    [InlineData(-7, 6, -2.00)]
    [InlineData(15, -8, 14.00)]
    public void CalculatePerimeterRectangle_ShouldReturnCorrectAverage(double width, double height, double? expected)
    {
        Rectangle _oopTasks = new(width, height);
        var result = _oopTasks.CalculatePerimeter();

        Assert.Equal($"{expected:F2}", $"{result:F2}");
    }

    [Theory]
    [InlineData("Шарик", "Питбуль", "Гав!")]
    public void DogMakeSound_ShouldReturnCorrectAverage(string name, string breed, string expected)
    {
        Dog _oopTasks = new(name, breed);
        var result = _oopTasks.MakeSound();

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Мурка", "Мяу!")]
    public void CatMakeSound_ShouldReturnCorrectAverage(string name, string expected)
    {
        Cat _oopTasks = new(name);
        var result = _oopTasks.MakeSound();

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Audo", 1.6, 300, "Audo started: результат Engine started")]
    public void StartCarEngine_ShouldReturnCorrectAverage(string model, double volume, int horsePower, string expected)
    {
        Car _oopTasks = new(model, volume, horsePower);
        var result = _oopTasks.StartCar();

        Assert.Equal(expected, result);
    }
}
