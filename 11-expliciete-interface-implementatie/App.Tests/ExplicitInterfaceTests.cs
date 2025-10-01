using App;

namespace App.Tests;

public class ExplicitInterfaceTests
{
    [Test]
    public void BilingualPerson_EnglishGreet_ReturnsHello()
    {
        var person = new BilingualPerson();
        IEnglishSpeaker englishSpeaker = person;
        Assert.That(englishSpeaker.Greet(), Is.EqualTo("Hello!"));
    }

    [Test]
    public void BilingualPerson_FrenchGreet_ReturnsBonjour()
    {
        var person = new BilingualPerson();
        IFrenchSpeaker frenchSpeaker = person;
        Assert.That(frenchSpeaker.Greet(), Is.EqualTo("Bonjour!"));
    }
}
