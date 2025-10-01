using App;

namespace App.Tests;

public class GenericSwapTests
{
    [Test]
    public void Swap_Integers_WorksCorrectly()
    {
        int x = 5, y = 10;
        Utility.Swap(ref x, ref y);
        Assert.That(x, Is.EqualTo(10));
        Assert.That(y, Is.EqualTo(5));
    }

    [Test]
    public void Swap_Strings_WorksCorrectly()
    {
        string s1 = "Hello", s2 = "World";
        Utility.Swap(ref s1, ref s2);
        Assert.That(s1, Is.EqualTo("World"));
        Assert.That(s2, Is.EqualTo("Hello"));
    }

    [Test]
    public void Swap_CustomObjects_WorksCorrectly()
    {
        var p1 = new Product { Name = "Product A" };
        var p2 = new Product { Name = "Product B" };

        Utility.Swap(ref p1, ref p2);

        Assert.That(p1.Name, Is.EqualTo("Product B"));
        Assert.That(p2.Name, Is.EqualTo("Product A"));
    }
}

// Define a simple Product class for testing custom objects
namespace App
{
    public class Product
    {
        public string Name { get; set; }
    }
}
