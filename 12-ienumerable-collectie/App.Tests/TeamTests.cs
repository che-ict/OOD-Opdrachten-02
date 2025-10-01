using App;
using System.Linq;

namespace App.Tests;

public class TeamTests
{
    [Test]
    public void Team_CanAddPlayersAndIterate()
    {
        var team = new Team();
        team.AddPlayer(new Player { Name = "Alice" });
        team.AddPlayer(new Player { Name = "Bob" });

        Assert.That(team.Count(), Is.EqualTo(2));
        Assert.That(team.First().Name, Is.EqualTo("Alice"));
        Assert.That(team.Last().Name, Is.EqualTo("Bob"));
    }

    [Test]
    public void Team_IsEmptyInitially()
    {
        var team = new Team();
        Assert.That(team.Count(), Is.EqualTo(0));
    }
}
