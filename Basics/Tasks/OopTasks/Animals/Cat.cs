namespace Basics.Tasks.OopTasks.Animals;

/// <summary>
/// 
/// </summary>
/// <param name="name"></param>
public class Cat(string name) : Animal(name)
{
    public override string MakeSound()
    {
        return "Мяу!";
    }
}
