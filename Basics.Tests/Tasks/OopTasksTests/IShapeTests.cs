using Basics.Tasks;
using Basics.Tasks.OopTasks;
using Xunit;

namespace Basics.Test.Tasks.OopTasksTests;

public class IShapeTests
{
    [Fact]
    public void Circle_CalculateArea_ReurnsCorrectValue()
    {
        // Arrange
        var circle = new Circle(5);

        // Act
        var area = circle.CalculateArea();

        // Assert
        Assert.Equal(Math.PI * 5 * 5, area);
    }

    [Fact]
    public void CalculatePerimeter_ReurnsCorrectValue()
    {
        // Arrange
        var circle = new Circle(10);

        // Act
        var perimeter = circle.CalculatePerimeter();

        // Assert
        Assert.Equal(Math.PI * 2 * 10, perimeter);
    }

    [Fact]
    public void Rectangle_CalculateArea_ReturnsCorrectValue()
    {
        // Arrange
        var rect = new Rectangle(4, 5);

        // Act
        var area = rect.CalculateArea();

        // Assert
        Assert.Equal(20, area);
    }

    [Fact]
    public void Rectangle_CalculatePerimeter_ReurnsCorrectValue()
    {
        // Arrange
        var rect = new Rectangle(3, 6);

        // Act
        var perimeter = rect.CalculatePerimeter();

        // Assert
        Assert.Equal(18, perimeter);
    }

}