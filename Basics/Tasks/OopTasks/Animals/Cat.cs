namespace Basics.Tasks.OopTasks.Animals;

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public override string MakeSound()
    {
        return "Мяу!";
    }
}