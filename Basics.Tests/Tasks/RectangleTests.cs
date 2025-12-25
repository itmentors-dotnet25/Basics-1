using Basics.Tasks.OopTasks.Figures;
using Xunit;

namespace Basics.Test.Tasks;

public class RectangleTests
{
    [Theory]
    [InlineData(2, 3)]
    [InlineData(0, 5)]
    [InlineData(4.5, 1.2)]
    public void Constructor_WithValidDimensions_ShouldInitialize(double height, double width)
    {
        // Act
        var rect = new Rectangle(height, width);

        // Assert
        Assert.Equal(height, rect.Height);
        Assert.Equal(width, rect.Width);
    }

    [Theory]
    [InlineData(-1, 2)]
    [InlineData(-0.5, 10)]
    public void Constructor_WithNegativeHeight_ShouldThrowArgumentOutOfRangeException(double height, double width)
    {
        // Act & Assert
        var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Rectangle(height, width));
        Assert.Equal("height", ex.ParamName);
        Assert.Contains("отрицательной", ex.Message);
    }

    [Theory]
    [InlineData(3, -2)]
    [InlineData(1, -0.1)]
    public void Constructor_WithNegativeWidth_ShouldThrowArgumentOutOfRangeException(double height, double width)
    {
        // Act & Assert
        var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Rectangle(height, width));
        Assert.Equal("width", ex.ParamName);
        Assert.Contains("отрицательной", ex.Message);
    }

    [Theory]
    [InlineData(double.NaN, 5)]
    [InlineData(double.PositiveInfinity, 2)]
    public void Constructor_WithInvalidHeight_ShouldThrowArgumentException(double height, double width)
    {
        // Act & Assert
        var ex = Assert.Throws<ArgumentException>(() => new Rectangle(height, width));
        Assert.Equal("height", ex.ParamName);
        Assert.Contains("NaN или бесконечностью", ex.Message);
    }

    [Theory]
    [InlineData(5, double.NaN)]
    [InlineData(2, double.NegativeInfinity)]
    public void Constructor_WithInvalidWidth_ShouldThrowArgumentException(double height, double width)
    {
        // Act & Assert
        var ex = Assert.Throws<ArgumentException>(() => new Rectangle(height, width));
        Assert.Equal("width", ex.ParamName);
        Assert.Contains("NaN или бесконечностью", ex.Message);
    }
    
    [Fact]
    public void Constructor_WithMaxValue_ShouldThrow()
    {
        var ex = Assert.Throws<ArgumentOutOfRangeException>(() => 
            new Rectangle(Math.Sqrt(double.MaxValue) * 1.1, 1.0));
    }

    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(0, 5, 0)]
    [InlineData(1.5, 4, 6)]
    public void CalculateArea_ShouldReturnCorrectValue(double height, double width, double expected)
    {
        // Arrange
        var rect = new Rectangle(height, width);

        // Act
        var area = rect.CalculateArea();

        // Assert
        Assert.Equal(expected, area, precision: 10);
    }

    [Theory]
    [InlineData(2, 3, 10)]
    [InlineData(0, 5, 10)]
    [InlineData(1.5, 4, 11)]
    public void CalculatePerimeter_ShouldReturnCorrectValue(double height, double width, double expected)
    {
        // Arrange
        var rect = new Rectangle(height, width);

        // Act
        var perimeter = rect.CalculatePerimeter();

        // Assert
        Assert.Equal(expected, perimeter, precision: 10);
    }
}