using App;

namespace App.Tests;

public class ProductTests
{
    [Test]
    public void Products_SortByPrice_Correctly()
    {
        var products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 1200 },
            new Product { Name = "Muis", Price = 25 },
            new Product { Name = "Toetsenbord", Price = 75 }
        };
        products.Sort();
        Assert.That(products[0].Name, Is.EqualTo("Muis"));
        Assert.That(products[1].Name, Is.EqualTo("Toetsenbord"));
        Assert.That(products[2].Name, Is.EqualTo("Laptop"));
    }

    [Test]
    public void CompareTo_ReturnsCorrectValue()
    {
        var product1 = new Product { Name = "A", Price = 100 };
        var product2 = new Product { Name = "B", Price = 50 };
        var product3 = new Product { Name = "C", Price = 100 };

        Assert.That(product1.CompareTo(product2), Is.GreaterThan(0));
        Assert.That(product2.CompareTo(product1), Is.LessThan(0));
        Assert.That(product1.CompareTo(product3), Is.EqualTo(0));
        Assert.That(product1.CompareTo(null), Is.GreaterThan(0));
    }
}
