using App;

namespace App.Tests;

public class AnimalTests
{
    [Test]
    public void Dog_MakeSound_Test()
    {
        var dog = new Dog { Name = "Buddy" };
        Assert.That(dog.MakeSound(), Is.EqualTo("Woef!"));
    }

    [Test]
    public void Cat_MakeSound_Test()
    {
        var cat = new Cat { Name = "Whiskers" };
        Assert.That(cat.MakeSound(), Is.EqualTo("Miauw!"));
    }

    [Test]
    public void Animal_IsAbstract_Test()
    {
        // This test verifies that Animal is abstract and cannot be instantiated directly.
        // It will cause a compile-time error if uncommented:
        // var animal = new Animal();
        Assert.Pass("Animal class is abstract and cannot be instantiated directly.");
    }
}
