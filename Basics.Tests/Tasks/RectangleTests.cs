using Basics.Tasks.OopTasks.Figures;
using Xunit;

namespace Basics.Test.Tasks;

public class RectangleTests
{
    [Fact]
    public void Rectangle_Implement_IShape()
    {
        // Arrange
        var rectangle = new Rectangle(3, 3);

        // Assert
        Assert.IsAssignableFrom<IShape>(rectangle);
    }

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(0, 1, 0)]
    [InlineData(1, 1, 1)]
    [InlineData(1, 2, 2)]
    [InlineData(2, 2, 4)]
    [InlineData(3.5, 3.5, 12.25)]
    public void CalculateArea_ShouldReturnCorrectArea(double width, double height, double expectedArea)
    {
        // Arrange
        var rectangle = new Rectangle(width, height);

        // Assert
        Assert.Equal(expectedArea, rectangle.CalculateArea());
    }

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(0, 1, 2)]
    [InlineData(1, 1, 4)]
    [InlineData(2, 2, 8)]
    [InlineData(3.4, 3.4, 13.6)]
    public void CalculatePerimeter_ShouldReturnCorrectPerimeter(double width, double height, double expectedPerimeter)
    {
        // Arrange
        var rectangle = new Rectangle(width, height);

        // Assert
        Assert.Equal(expectedPerimeter, rectangle.CalculatePerimeter());
    }
}