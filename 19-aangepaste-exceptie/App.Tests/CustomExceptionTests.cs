using App;

namespace App.Tests;

public class CustomExceptionTests
{
    [Test]
    public void Person_Age_ThrowsInvalidAgeException_WhenAgeIsNegative()
    {
        var person = new Person();
        Assert.Throws<InvalidAgeException>(() => person.Age = -5);
    }

    [Test]
    public void Person_Age_ThrowsInvalidAgeException_WhenAgeIsTooHigh()
    {
        var person = new Person();
        Assert.Throws<InvalidAgeException>(() => person.Age = 121);
    }

    [Test]
    public void Person_Age_SetsAgeCorrectly_WhenAgeIsValid()
    {
        var person = new Person();
        person.Age = 30;
        Assert.That(person.Age, Is.EqualTo(30));
    }
}
