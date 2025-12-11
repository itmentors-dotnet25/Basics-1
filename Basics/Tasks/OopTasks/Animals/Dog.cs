namespace Basics.Tasks.OopTasks.Animals;

/// <summary>
/// 
/// </summary>
/// <param name="name"></param>
/// <param name="breed"></param>
public class Dog(string name, string breed) : Animal(name)
{
    public string Breed { get; } = breed;
    public override string MakeSound()
    {
        return "Гав!";
    }
}
