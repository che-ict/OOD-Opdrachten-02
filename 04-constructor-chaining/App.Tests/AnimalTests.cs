using App;

namespace App.Tests;

public class AnimalTests
{
    [Test]
    public void Dog_ConstructorChaining_Test()
    {
        var dog = new Dog("Buddy");
        Assert.That(dog.Name, Is.EqualTo("Buddy"));
    }

    [Test]
    public void Cat_ConstructorChaining_Test()
    {
        var cat = new Cat("Whiskers");
        Assert.That(cat.Name, Is.EqualTo("Whiskers"));
    }
}
