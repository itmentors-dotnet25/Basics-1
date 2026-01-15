namespace Basics.Tasks.OopTasks.Animals;

public class Dog : Animal
{
    public string Breed { get; }

    public Dog(string name, string breed = "") : base(name)
    {
        Breed = breed;
    }

    public override string MakeSound()
    {
        return "Гав!";
    }
}