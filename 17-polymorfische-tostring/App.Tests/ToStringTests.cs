using App;

namespace App.Tests;

public class ToStringTests
{
    [Test]
    public void Product_ToString_ReturnsFormattedString()
    {
        var product = new Product { Name = "Toetsenbord", Price = 75 };
        Assert.That(product.ToString(), Is.EqualTo("Toetsenbord - €75,00"));
    }

    [Test]
    public void Product_ToString_WithDifferentPrice_ReturnsFormattedString()
    {
        var product = new Product { Name = "Muis", Price = 25.50m };
        Assert.That(product.ToString(), Is.EqualTo("Muis - €25,50"));
    }
}
