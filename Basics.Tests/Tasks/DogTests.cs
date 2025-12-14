using Basics.Tasks.OopTasks.Animals;
using Xunit;

namespace Basics.Test.Tasks;

public class DogTests
{
    private readonly Dog _dog = new("Мухтар");

    [Fact]
    public void Extend_Animal()
    {
        // Assert
        Assert.IsAssignableFrom<Animal>(_dog);
    }

    [Fact]
    private void MakeSound_CatMakeCorrectSound()
    {
        // Assert
        Assert.Equal("Гав!", _dog.MakeSound());
    }
}