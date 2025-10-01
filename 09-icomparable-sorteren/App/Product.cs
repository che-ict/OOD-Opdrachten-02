namespace App;

public class Product : IComparable<Product>
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public int CompareTo(Product other)
    {
        // TODO: Implement the CompareTo method to compare products by price
        throw new NotImplementedException();
    }
}
