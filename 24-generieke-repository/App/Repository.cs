using System.Collections.Generic;

namespace App;

public class Repository<T> where T : class
{
    private readonly List<T> _items = new List<T>();

    public void Add(T item)
    {
        // TODO: Implement the Add method to add an item to the repository
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll()
    {
        // TODO: Implement the GetAll method to return all items in the repository
        throw new NotImplementedException();
    }
    // Voeg GetById, Delete etc. toe voor compleetheid
}
