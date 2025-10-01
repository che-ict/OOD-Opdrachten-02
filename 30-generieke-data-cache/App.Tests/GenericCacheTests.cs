using App;

namespace App.Tests;

public class GenericCacheTests
{
    [Test]
    public void Cache_AddAndGet_WorksCorrectly()
    {
        var userCache = new Cache<Person>();
        userCache.Add("user1", new Person { Age = 25 });

        var retrievedPerson = userCache.Get("user1");
        Assert.That(retrievedPerson, Is.Not.Null);
        Assert.That(retrievedPerson.Age, Is.EqualTo(25));
    }

    [Test]
    public void Cache_Get_ReturnsDefault_ForNonExistentKey()
    {
        var userCache = new Cache<Person>();
        var retrievedPerson = userCache.Get("user2");
        Assert.That(retrievedPerson, Is.Null);
    }

    [Test]
    public void Cache_Get_ReturnsDefaultValueType_ForNonExistentKey()
    {
        var intCache = new Cache<int>();
        var retrievedInt = intCache.Get("number1");
        Assert.That(retrievedInt, Is.EqualTo(0)); // default for int is 0
    }
}
