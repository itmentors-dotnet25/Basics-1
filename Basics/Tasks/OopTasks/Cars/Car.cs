namespace Basics.Tasks.OopTasks.Cars;

public class Car
{
    public string Model {get; init;}
    public Engine Engine {get; init;}

    public Car(string model, double volume, double horsePower)
    {
        ArgumentNullException.ThrowIfNull(model);
        
        Model = model;
        Engine = new Engine(volume, horsePower);
    }
    
    public string StartCar() => $"{Model} started: {Engine.Start()}";
}