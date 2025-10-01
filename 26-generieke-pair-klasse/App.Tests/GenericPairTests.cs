using App;

namespace App.Tests;

public class GenericPairTests
{
    [Test]
    public void Pair_StoresAndRetrievesCorrectly()
    {
        var nameAndAge = new Pair<string, int>("Alice", 30);
        Assert.That(nameAndAge.First, Is.EqualTo("Alice"));
        Assert.That(nameAndAge.Second, Is.EqualTo(30));
    }

    [Test]
    public void Pair_WithDifferentTypes_StoresAndRetrievesCorrectly()
    {
        var productAndPrice = new Pair<string, decimal>("Laptop", 1200.50m);
        Assert.That(productAndPrice.First, Is.EqualTo("Laptop"));
        Assert.That(productAndPrice.Second, Is.EqualTo(1200.50m));
    }
}
