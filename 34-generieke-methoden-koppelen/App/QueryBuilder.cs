using System.Collections.Generic;

namespace App;

public class QueryBuilder<T>
{
    private List<string> _conditions = new List<string>();
    public QueryBuilder<T> Where(string condition) { _conditions.Add(condition); return this; }
    public QueryBuilder<T> OrderBy(string field) { return this; }
    public int ConditionsCount => _conditions.Count;
}
