namespace Basics.Tasks.OopTasks;

public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

public class Circle(double radius) : IShape
{
    public double Radius { get; set; } = radius;

    public double CalculateArea() => Math.PI * Radius * Radius;
    public double CalculatePerimeter() => 2 * Math.PI * Radius;
}

public class Rectangle(double width, double height) : IShape
{
    public double Width { get; set; } = width;
    public double Height { get; set; } = height;

    public double CalculateArea() => Width * Height;
    public double CalculatePerimeter() => 2 * (Width + Height);
}
