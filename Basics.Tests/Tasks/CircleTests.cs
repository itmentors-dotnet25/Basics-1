using Basics.Tasks.OopTasks.Figures;
using Xunit;

namespace Basics.Test.Tasks;

public class CircleTests
{
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(5.5)]
    public void Constructor_WithValidRadius_ShouldInitialize(double radius)
    {
        // Act
        var circle = new Circle(radius);

        // Assert
        Assert.Equal(radius, circle.Radius);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-0.1)]
    public void Constructor_WithNegativeRadius_ShouldThrowArgumentOutOfRangeException(double radius)
    {
        // Act & Assert
        var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        Assert.Equal("radius", ex.ParamName);
        Assert.Contains("отрицательным", ex.Message);
    }

    [Theory]
    [InlineData(double.NaN)]
    [InlineData(double.PositiveInfinity)]
    [InlineData(double.NegativeInfinity)]
    public void Constructor_WithInvalidRadius_ShouldThrowArgumentException(double radius)
    {
        // Act & Assert
        var ex = Assert.Throws<ArgumentException>(() => new Circle(radius));
        Assert.Equal("radius", ex.ParamName);
        Assert.Contains("NaN или бесконечностью", ex.Message);
    }
    
    [Fact]
    public void Constructor_WithRadiusNearMax_ShouldThrow()
    {
        var maxSafe = Math.Sqrt(double.MaxValue / Math.PI);
        var ex = Assert.Throws<ArgumentOutOfRangeException>(() => 
            new Circle(maxSafe * 1.0001));
    }

    [Theory]
    [InlineData(1, Math.PI)]
    [InlineData(2, 4 * Math.PI)]
    [InlineData(0, 0)]
    public void CalculateArea_ShouldReturnCorrectValue(double radius, double expected)
    {
        // Arrange
        var circle = new Circle(radius);

        // Act
        var area = circle.CalculateArea();

        // Assert
        Assert.Equal(expected, area, precision: 10);
    }

    [Theory]
    [InlineData(1, 2 * Math.PI)]
    [InlineData(3, 6 * Math.PI)]
    [InlineData(0, 0)]
    public void CalculatePerimeter_ShouldReturnCorrectValue(double radius, double expected)
    {
        // Arrange
        var circle = new Circle(radius);

        // Act
        var perimeter = circle.CalculatePerimeter();

        // Assert
        Assert.Equal(expected, perimeter, precision: 10);
    }
}