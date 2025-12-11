namespace Basics.Tasks.OopTasks.Animals;

/// <summary>
///
/// </summary>
/// <param name="name"></param>
public abstract class Animal(string name)
{
    public string Name { get; set; } = name;
    public abstract string MakeSound();
}