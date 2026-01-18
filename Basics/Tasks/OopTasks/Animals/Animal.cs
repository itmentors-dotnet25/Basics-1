namespace Basics.Tasks.OopTasks.Animals;

public abstract class Animal(string name)
{
    public string Name { get; set; } = name;
    public abstract string MakeSound();
}

public class Dog : Animal
{
    public string Breed { get; set ; }

    public Dog(string name, string breed = "безпородная") : base(name)
    {
        Breed = breed;
    }

    public override string MakeSound()
        { return "Гав!"; }
}

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {}

    public override string MakeSound()
    {
        return "Мяу!";
    }
}