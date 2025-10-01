using System.Collections.Generic;

namespace App;

public class Repository<T> where T : class
{
    private readonly List<T> _items = new List<T>();
    public void Add(T item) => _items.Add(item);
    public IEnumerable<T> GetAll() => _items;
    // Voeg GetById, Delete etc. toe voor compleetheid
}
