using Basics.Tasks.OopTasks.Animals;
using Xunit;

namespace Basics.Test.Tasks;

public class CatTests
{
    private readonly Cat _cat = new("Барон");
    
    [Fact]
    public void Dog_ShouldInheritFromAnimal()
    {
        // Assert
        Assert.IsType<Animal>(_cat, exactMatch: false);
    }
    
    [Fact]
    public void MakeSound_ShouldReturnCorrectSound()
    {
        // Act
        var sound = _cat.MakeSound();

        // Assert
        Assert.Equal("Мяу!", sound);
    }
}