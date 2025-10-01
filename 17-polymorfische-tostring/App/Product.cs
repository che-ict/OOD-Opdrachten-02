namespace App;

public class Product : IComparable<Product>
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public int CompareTo(Product other)
    {
        if (other == null) return 1;
        return this.Price.CompareTo(other.Price);
    }

    public override string ToString()
    {
        // TODO: Override the ToString method to return a formatted string of the product's Name and Price
        throw new NotImplementedException();
    }
}
