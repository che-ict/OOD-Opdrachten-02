using System.Collections.Generic;

namespace App;

public class QueryBuilder<T>
{
    private List<string> _conditions = new List<string>();

    public QueryBuilder<T> Where(string condition)
    {
        // TODO: Implement the Where method to add a condition and return the current instance
        throw new NotImplementedException();
    }

    public QueryBuilder<T> OrderBy(string field)
    {
        // TODO: Implement the OrderBy method to add an order by clause and return the current instance
        throw new NotImplementedException();
    }

    public int ConditionsCount => _conditions.Count;
}
