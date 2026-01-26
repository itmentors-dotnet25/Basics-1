namespace Basics.Tasks.OopTasks.Cars;

public class Car
{
    public string Model { get; set; }
    public Engine Engine { get; private set; }

    public Car(string model, double engineVolume, int horsePower)
    {
        Model = model;
        Engine = new Engine(engineVolume, horsePower);
    }

    public string StartCar()
    {
        return $"{Model} started: {Engine.Start()}";
    }
}
