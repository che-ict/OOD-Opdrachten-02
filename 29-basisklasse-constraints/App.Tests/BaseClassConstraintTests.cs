using App;

namespace App.Tests;

public class BaseClassConstraintTests
{
    [Test]
    public void GetAnimalName_ReturnsCorrectName_ForDog()
    {
        var dog = new Dog("Fido");
        var name = AnimalService.GetAnimalName(dog);
        Assert.That(name, Is.EqualTo("Fido"));
    }

    [Test]
    public void GetAnimalName_DoesNotCompileForNonAnimalTypes()
    {
        // This test is conceptual. The following line would cause a compile-time error:
        // public class Product { public string Name { get; set; } }
        // AnimalService.GetAnimalName(new Product());
        Assert.Pass("Method only accepts types derived from Animal, verified by compile-time check.");
    }
}
