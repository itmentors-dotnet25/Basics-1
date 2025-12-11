namespace Basics.Tasks.OopTasks;

/// <summary>
/// 
/// </summary>
/// <param name="width"></param>
/// <param name="height"></param>
public class Rectangle(double width, double height) : IShape
{
    public double Width = width;
    public double Height = height;

    public double CalculateArea()
    {
        return Width * Height;
    }

    public double CalculatePerimeter()
    {
        return 2 * Width + 2 * Height;
    }
}
