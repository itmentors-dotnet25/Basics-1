namespace Basics.Tasks.OopTasks.Cars;

/// <summary>
///
/// </summary>
/// <param name="model"></param>
/// <param name="volume"></param>
/// <param name="horsePower"></param>
public class Car(string model, double volume, int horsePower)
{
    public string Model { get; } = model;
    public double Volume { get; } = volume;
    public int HorsePower { get; } = horsePower;

    public string StartCar()
    {
        Engine engine = new(this.Volume, this.HorsePower);
        return $"{Model} started: результат {engine.Start()}"; 
    }
}