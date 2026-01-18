using Basics.Tasks.OopTasks.Animals;
using Xunit;

namespace Basics.Test.Tasks.OopTasksTests;

public class AnimalTests
{
    [Fact]
    public void Dog_Constructor_SetNameAndBreed()
    {
        // Arrange & Act
        var dog = new Dog("Рекс", "Овчарка");

        // Assert
        Assert.Equal("Рекс", dog.Name);
        Assert.Equal("Овчарка", dog.Breed);
    }

    [Fact]
    public void Dog_Constructor_DefaultBreed()
    {
        // Arrange
        var dog = new Dog("Шарик");
        // Assert
        Assert.Equal("безпородная", dog.Breed);
    }

    [Fact]
    public void Dog_MakeSound_ReturnsCorrectSound()
    {
        // Arrange
        var dog = new Dog("Бобик");

        //Act
        var sound = dog.MakeSound();

        // Assert
        Assert.Equal("Гав!", sound);
    }

    [Fact]
    public void Cat_Constructor_SetsName()
    {
        // Arrange
        var cat = new Cat("Мурзик");

        // Assert
        Assert.Equal("Мурзик", cat.Name);
    }

    [Fact]
    public void Cat_MakeSound_ReturnsCorrectSound()
    {
        // Arrange
        var cat = new Cat("Пушок");

        // Assert
        Assert.Equal("Мяу!", cat.MakeSound());
    }
}
