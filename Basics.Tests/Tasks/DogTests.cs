using Basics.Tasks.OopTasks.Animals;
using Xunit;

namespace Basics.Test.Tasks;

public class DogTests
{
    private readonly Dog _dog = new("Граф");
    
    [Fact]
    public void Dog_ShouldInheritFromAnimal()
    {
        // Assert
        Assert.IsType<Animal>(_dog, exactMatch: false);
    }
    
    [Fact]
    public void MakeSound_ShouldReturnCorrectSound()
    {
        // Act
        var sound = _dog.MakeSound();

        // Assert
        Assert.Equal("Гав!", sound);
    }
    
    [Fact]
    public void Breed_ShouldBeInitiallyNull()
    {
        // Act
        var dog = new Dog("Граф");

        // Assert
        Assert.Null(dog.Breed);
    }

    [Fact]
    public void Breed_ShouldBeSettable()
    {
        // Act
        _dog.Breed = "Овчарка";

        // Assert
        Assert.Equal("Овчарка", _dog.Breed);
    }

    [Fact]
    public void Breed_ShouldAllowEmptyString()
    {
        // Act
        _dog.Breed = "";

        // Assert
        Assert.Equal("", _dog.Breed);
    }

    [Fact]
    public void Breed_ShouldAllowNull()
    {
        // Arrange
        _dog.Breed = "Овчарка";

        // Act
        _dog.Breed = null;

        // Assert
        Assert.Null(_dog.Breed);
    }
}