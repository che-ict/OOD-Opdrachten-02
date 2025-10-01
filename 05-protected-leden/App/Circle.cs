namespace App;

public class Circle : Shape
{
    public Circle(string color)
    {
        _color = color; // Heeft toegang tot protected lid
    }
}
