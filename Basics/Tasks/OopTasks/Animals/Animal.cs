namespace Basics.Tasks.OopTasks.Animals;

public abstract class Animal(string name)
{
    public string Name { get; set; } = name;
    public abstract string MakeSound();
}