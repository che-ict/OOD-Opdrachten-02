using System.Collections.Generic;

namespace App;

public class Cache<T>
{
    private readonly Dictionary<string, T> _cache = new Dictionary<string, T>();

    public void Add(string key, T item)
    {
        // TODO: Implement the Add method to add an item to the cache
        throw new NotImplementedException();
    }

    public T Get(string key)
    {
        // TODO: Implement the Get method to retrieve an item from the cache
        throw new NotImplementedException();
    }
}
