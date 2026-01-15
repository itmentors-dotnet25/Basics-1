using Basics.Tasks.OopTasks;
using Xunit;

namespace Basics.Tests.Tasks.OopTasks;

public class ShapeTests
{
    [Fact]
    public void CircleCalculateArea_ReturnsCorrectValue()
    {
        var circle = new Circle(3);
        double area = circle.CalculateArea();
        Assert.Equal(Math.PI * 9, area, precision: 10);
    }

    [Fact]
    public void CircleCalculatePerimeter_ReturnsCorrectValue()
    {
        var circle = new Circle(2);
        double perimeter = circle.CalculatePerimeter();
        Assert.Equal(4 * Math.PI, perimeter, precision: 10);
    }

    [Fact]
    public void RectangleCalculateArea_ReturnsCorrectValue()
    {
        var rectangle = new Rectangle(4, 5);
        double area = rectangle.CalculateArea();
        Assert.Equal(20, area);
    }

    [Fact]
    public void RectangleCalculatePerimeter_ReturnsCorrectValue()
    {
        var rectangle = new Rectangle(3, 7);
        double perimeter = rectangle.CalculatePerimeter();
        Assert.Equal(20, perimeter);
    }
}