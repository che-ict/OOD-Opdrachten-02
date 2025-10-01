using App;
using System.Linq;

namespace App.Tests;

public class GenericRepositoryTests
{
    [Test]
    public void Repository_AddAndGetAll_WorksCorrectly()
    {
        var productRepo = new Repository<Product>();
        productRepo.Add(new Product { Name = "Boek" });
        productRepo.Add(new Product { Name = "Pen" });

        var products = productRepo.GetAll().ToList();

        Assert.That(products.Count, Is.EqualTo(2));
        Assert.That(products[0].Name, Is.EqualTo("Boek"));
        Assert.That(products[1].Name, Is.EqualTo("Pen"));
    }

    [Test]
    public void Repository_IsEmptyInitially()
    {
        var productRepo = new Repository<Product>();
        Assert.That(productRepo.GetAll().Count(), Is.EqualTo(0));
    }
}
