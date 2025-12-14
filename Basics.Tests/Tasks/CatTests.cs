using Basics.Tasks.OopTasks.Animals;
using Xunit;

namespace Basics.Test.Tasks;

public class CatTests
{
    private readonly Cat _cat = new("Гаф");

    [Fact]
    public void Extend_Animal()
    {
        // Assert
        Assert.IsAssignableFrom<Animal>(_cat);
    }

    [Fact]
    public void MakeSound_CatMakeCorrectSound()
    {
        // Assert
        Assert.Equal("Мяу!", _cat.MakeSound());
    }
}