using App;
using System.Linq;

namespace App.Tests;

public class PolymorphismTests
{
    [Test]
    public void AnimalHierarchy_MakeSound_PolymorphismTest()
    {
        var animals = new List<Animal>
        {
            new Dog("Buddy"),
            new Cat("Whiskers")
        };

        var sounds = new List<string>();
        foreach (var animal in animals)
        {
            sounds.Add(animal.MakeSound());
        }

        Assert.That(sounds, Contains.Item("Woef!"));
        Assert.That(sounds, Contains.Item("Miauw!"));
        Assert.That(sounds.Count, Is.EqualTo(2));
    }
}
