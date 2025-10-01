using App;
using System.Linq;

namespace App.Tests;

public class ShapeDrawingTests
{
    [Test]
    public void Shapes_Draw_ReturnsCorrectStrings()
    {
        var shapes = new List<Shape> { new Circle(), new Square() };
        var drawings = shapes.Select(s => s.Draw()).ToList();

        Assert.That(drawings, Contains.Item("Tekent een cirkel"));
        Assert.That(drawings, Contains.Item("Tekent een vierkant"));
        Assert.That(drawings.Count, Is.EqualTo(2));
    }
}
