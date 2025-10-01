using System.Collections;

namespace App;

public class Team : IEnumerable<Player>
{
    private readonly List<Player> _players = new List<Player>();
    public void AddPlayer(Player player) => _players.Add(player);

    public IEnumerator<Player> GetEnumerator()
    {
        // TODO: Implement the generic GetEnumerator method
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        // TODO: Implement the non-generic GetEnumerator method
        throw new NotImplementedException();
    }
}
