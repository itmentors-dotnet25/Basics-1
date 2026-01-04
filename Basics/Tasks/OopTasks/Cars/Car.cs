namespace Basics.Tasks.OopTasks.Cars;

public class Car(string model, Engine engine)
{
    private string Model { get; } = model;
    private Engine Engine { get; } = engine;

    public string StartCar()
    {
        return $"{Model} started: {Engine.Start()}";
    }
}