using App;

namespace App.Tests;

public class CatchBlockTests
{
    [Test]
    public void ParseNumber_ReturnsSucces_ForValidNumber()
    {
        Assert.That(Parser.ParseNumber("123"), Is.EqualTo("Succes"));
    }

    [Test]
    public void ParseNumber_ReturnsOngeldigFormaat_ForInvalidFormat()
    {
        Assert.That(Parser.ParseNumber("abc"), Is.EqualTo("Ongeldig formaat"));
    }

    [Test]
    public void ParseNumber_ReturnsGetalTeGroot_ForOverflow()
    {
        Assert.That(Parser.ParseNumber("10000000000"), Is.EqualTo("Getal te groot"));
    }
}
