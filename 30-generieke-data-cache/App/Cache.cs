using System.Collections.Generic;

namespace App;

public class Cache<T>
{
    private readonly Dictionary<string, T> _cache = new Dictionary<string, T>();
    public void Add(string key, T item) => _cache[key] = item;
    public T Get(string key) => _cache.TryGetValue(key, out T value) ? value : default(T);
}
