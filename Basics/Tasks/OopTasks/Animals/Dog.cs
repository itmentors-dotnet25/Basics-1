namespace Basics.Tasks.OopTasks.Animals;

public class Dog(string name) : Animal(name)
{
    public override string MakeSound()
    {
        return "Гав!";
    }
}