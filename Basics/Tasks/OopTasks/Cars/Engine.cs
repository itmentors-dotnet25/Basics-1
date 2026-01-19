namespace Basics.Tasks.OopTasks.Cars;

public class Engine
{
    public double Volume { get; }
    public int HorsePower { get; }

    public Engine(double volume, int horsePower)
    {
        Volume = volume;
        HorsePower = horsePower;
    }

    public string Start()
    {
        return "Engine started";
    }
}