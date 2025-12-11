namespace Basics.Tasks.OopTasks.Cars;

/// <summary>
/// 
/// </summary>
/// <param name="volume"></param>
/// <param name="horsePower"></param>
public class Engine(double volume, int horsePower)
{
    public double Volume { get; } = volume;
    public double HorsePower { get; } = horsePower;

    public string Start()
    {
        return "Engine started"; 
    }
}