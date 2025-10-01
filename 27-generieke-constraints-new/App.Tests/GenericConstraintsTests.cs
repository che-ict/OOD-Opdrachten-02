using App;

namespace App.Tests;

public class GenericConstraintsTests
{
    [Test]
    public void CreateInstance_ReturnsNonNullObject()
    {
        var product = Factory.CreateInstance<Product>();
        Assert.That(product, Is.Not.Null);
        Assert.That(product, Is.InstanceOf<Product>());
    }

    [Test]
    public void CreateInstance_CanCreateDifferentTypes()
    {
        var myClass = Factory.CreateInstance<MyClass>();
        Assert.That(myClass, Is.Not.Null);
        Assert.That(myClass, Is.InstanceOf<MyClass>());
    }
}

// Define a simple class with a parameterless constructor for testing
namespace App
{
    public class MyClass
    {
        public string Message { get; set; } = "Default Message";
    }
}
