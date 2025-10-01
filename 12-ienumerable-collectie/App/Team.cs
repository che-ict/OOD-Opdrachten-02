using System.Collections;

namespace App;

public class Team : IEnumerable<Player>
{
    private readonly List<Player> _players = new List<Player>();
    public void AddPlayer(Player player) => _players.Add(player);

    public IEnumerator<Player> GetEnumerator() => _players.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
