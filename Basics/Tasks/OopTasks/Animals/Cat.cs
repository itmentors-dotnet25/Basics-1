namespace Basics.Tasks.OopTasks.Animals;

public class Cat(string name) : Animal(name)
{
    public override string MakeSound()
    {
        return "Мяу!";
    }
}