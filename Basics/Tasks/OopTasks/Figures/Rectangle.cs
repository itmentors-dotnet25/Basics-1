namespace Basics.Tasks.OopTasks.Figures;

public class Rectangle(double width, double height) : IShape
{
    private double Width { get; } = width;
    private double Height { get; } = height;

    public double CalculateArea()
    {
        return Width * Height;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}