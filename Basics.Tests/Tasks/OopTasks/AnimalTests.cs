using Basics.Tasks.OopTasks.Animals;
using Xunit;

namespace Basics.Tests.Tasks.OopTasks;

public class AnimalTests
{
    [Fact]
    public void Dogs_MakeSound_ReturnsBark()
    {
        var dog1 = new Dog("Барсик");
        Assert.Equal("Гав!", dog1.MakeSound());
    }

    [Fact]
    public void Dog_Name_IsSetCorrectly()
    {
        var dog = new Dog("Лайка");
        Assert.Equal("Лайка", dog.Name);
    }

    [Fact]
    public void Cat_MakeSound_ReturnsMeow()
    {
        var cat = new Cat("Черныш");
        string sound = cat.MakeSound();
        Assert.Equal("Мяу!", sound);
    }

    [Fact]
    public void Cat_Name_IsSetCorrectly()
    {
        var cat = new Cat("Рыжик");
        Assert.Equal("Рыжик", cat.Name);
    }

    [Fact]
    public void DogsAndCatSoundTest_ReturnBarkAndMeow()
    {
        var dog1 = new Dog("Барсик");
        var dog2 = new Dog("Рекс");
        var dog3 = new Dog("И Жулька");
        
        var cat1 = new Cat("Матильда");
        Assert.Equal("Мяу!", cat1.MakeSound());
        
        Assert.Equal("Гав!", dog1.MakeSound());
        Assert.Equal("Гав!", dog2.MakeSound());
        Assert.Equal("Гав!", dog1.MakeSound());
        Assert.Equal("Гав!", dog2.MakeSound());
        Assert.Equal("Гав!", dog3.MakeSound());
    }
}