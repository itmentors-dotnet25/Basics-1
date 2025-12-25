namespace Basics.Tasks.OopTasks.Animals;

public class Dog(string name) : Animal(name)
{
    public string Breed { get; set; }
    public override string MakeSound() => "Гав!";
}