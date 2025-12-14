using Basics.Tasks.OopTasks.Figures;
using Xunit;

namespace Basics.Test.Tasks;

public class CircleTests
{
    [Fact]
    public void Implement_IShape()
    {
        var circle = new Circle(3);

        Assert.IsAssignableFrom<IShape>(circle);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, Math.PI)]
    [InlineData(2, 4 * Math.PI)]
    [InlineData(3, 9 * Math.PI)]
    [InlineData(4.5, 20.25 * Math.PI)]
    public void CalculateArea_ShouldReturnCorrectArea(double radius, double expectedArea)
    {
        Circle circle = new Circle(radius);

        var result = circle.CalculateArea();

        Assert.Equal(expectedArea, result);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 2 * Math.PI)]
    [InlineData(2, 4 * Math.PI)]
    [InlineData(3.3, 6.6 * Math.PI)]
    public void CalculatePerimeter_ShouldReturnCorrectPerimeter(double radius, double expectedPerimeter)
    {
        Circle circle = new Circle(radius);

        var result = circle.CalculatePerimeter();

        Assert.Equal(expectedPerimeter, result);
    }
}