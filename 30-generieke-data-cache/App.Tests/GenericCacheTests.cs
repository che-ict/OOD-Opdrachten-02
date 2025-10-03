using App;

namespace App.Tests;

private class Song {
    public string Artist{get;set;}
    public string Title{get;set;}
}

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

    [Test]
    public void Cache_GetSongList(){
        var albumCache = new Cache<List<Song>>();
        var songs = new List<Song>(){
            new Song{Artist:"Blur", Title:"Song 1"},
            new Song{Artist:"Blur", Title:"Song 2"}
        };
        albumCache.Add("blur-album", songs);
        var retrievedAlbums = albumCache.Get("blur-album");
        Assert.That(retrievedAlbums, Is.EqualTo(songs));
    }
}
