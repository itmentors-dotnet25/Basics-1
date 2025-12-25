namespace Basics.Tasks.OopTasks.Cars;

public class Engine
{
    public double Volume { get; init; }
    public double HorsePower { get; init; }

    public Engine(double volume, double horsePower)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(volume, nameof(volume));
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(horsePower, nameof(horsePower));
        
        Volume = volume;
        HorsePower = horsePower;
    }

    public string Start() => "Engine started";
}