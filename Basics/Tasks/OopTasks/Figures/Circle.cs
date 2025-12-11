namespace Basics.Tasks.OopTasks;

/// <summary>
/// 
/// </summary>
/// <param name="radius"></param>
public class Circle(double radius) : IShape
{
    public double Radius = radius;

    public double CalculateArea()
    {
        if (Radius <= 0) return 0.00;
        return Math.PI * Math.Pow(Radius, 2);
    }

    public double CalculatePerimeter()
    {
        if (Radius <= 0) return 0.00;
        return 2 * Math.PI * Radius;
    }
}