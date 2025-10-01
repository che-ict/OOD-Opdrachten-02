using App;

namespace App.Tests;

public class FluentApiTests
{
    [Test]
    public void QueryBuilder_WhereMethod_AddsConditionsAndReturnsSelf()
    {
        var query = new QueryBuilder<Product>();
        query.Where("Price > 100").Where("Stock > 0");

        Assert.That(query.ConditionsCount, Is.EqualTo(2));
    }

    [Test]
    public void QueryBuilder_OrderByMethod_ReturnsSelf()
    {
        var query = new QueryBuilder<Product>();
        var result = query.OrderBy("Name");

        Assert.That(result, Is.SameAs(query));
    }
}
