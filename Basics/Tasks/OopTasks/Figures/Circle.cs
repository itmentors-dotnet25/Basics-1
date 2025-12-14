namespace Basics.Tasks.OopTasks.Figures;

public class Circle(double radius) : IShape
{
    private double Radius { get; } = radius;

    public double CalculateArea()
    {
        return Radius * Radius * Math.PI;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}