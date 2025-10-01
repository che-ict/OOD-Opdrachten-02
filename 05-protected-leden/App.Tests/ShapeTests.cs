using App;

namespace App.Tests;

public class ShapeTests
{
    [Test]
    public void Circle_GetColor_Test()
    {
        var circle = new Circle("Blauw");
        Assert.That(circle.GetColor(), Is.EqualTo("Blauw"));
    }
}
